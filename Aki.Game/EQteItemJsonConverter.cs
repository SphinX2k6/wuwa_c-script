using System;
using System.Text.Json;
using System.Text.Json.Serialization;

// Token: 0x02003552 RID: 13650
public class EQteItemJsonConverter : JsonConverter<EQteItem>
{
	// Token: 0x0601DF99 RID: 122777 RVA: 0x00866BA4 File Offset: 0x00864DA4
	public override EQteItem Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string @string = reader.GetString();
		if (string.IsNullOrEmpty(@string))
		{
			return EQteItem.SingleClickItem;
		}
		return EQteItemExtensions.FromString(@string);
	}

	// Token: 0x0601DF9A RID: 122778 RVA: 0x00866BC8 File Offset: 0x00864DC8
	public override void Write(Utf8JsonWriter writer, EQteItem value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToEnumString());
	}
}
