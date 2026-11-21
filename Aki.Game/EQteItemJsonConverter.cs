using System;
using System.Text.Json;
using System.Text.Json.Serialization;

// Token: 0x02002AC7 RID: 10951
public class EQteItemJsonConverter : JsonConverter<EQteItem>
{
	// Token: 0x0601BCC1 RID: 113857 RVA: 0x0088E768 File Offset: 0x0088C968
	public override EQteItem Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string @string = reader.GetString();
		if (string.IsNullOrEmpty(@string))
		{
			return EQteItem.SingleClickItem;
		}
		return EQteItemExtensions.FromString(@string);
	}

	// Token: 0x0601BCC2 RID: 113858 RVA: 0x0088E78C File Offset: 0x0088C98C
	public override void Write(Utf8JsonWriter writer, EQteItem value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToEnumString());
	}
}
