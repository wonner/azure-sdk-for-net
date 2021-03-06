// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class PrivateDnsZoneConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (PrivateDnsZoneId != null)
            {
                writer.WritePropertyName("privateDnsZoneId");
                writer.WriteStringValue(PrivateDnsZoneId);
            }
            if (RecordSets != null)
            {
                writer.WritePropertyName("recordSets");
                writer.WriteStartArray();
                foreach (var item in RecordSets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PrivateDnsZoneConfig DeserializePrivateDnsZoneConfig(JsonElement element)
        {
            string name = default;
            string privateDnsZoneId = default;
            IList<RecordSet> recordSets = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("privateDnsZoneId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateDnsZoneId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("recordSets"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RecordSet> array = new List<RecordSet>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(RecordSet.DeserializeRecordSet(item));
                                }
                            }
                            recordSets = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PrivateDnsZoneConfig(name, privateDnsZoneId, recordSets);
        }
    }
}
