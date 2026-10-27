using System;
using System.Text.Json;
using System.Text.Json.Serialization;

// Token: 0x02003558 RID: 13656
public class ERichTextTypeJsonConverter : JsonConverter<ERichTextType>
{
	// Token: 0x0601DFB4 RID: 122804 RVA: 0x0086CE2C File Offset: 0x0086B02C
	public override ERichTextType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string @string = reader.GetString();
		if (string.IsNullOrEmpty(@string))
		{
			return ERichTextType.PlayerName;
		}
		return ERichTextTypeExtensions.FromString(@string);
	}

	// Token: 0x0601DFB5 RID: 122805 RVA: 0x0086CE50 File Offset: 0x0086B050
	public override void Write(Utf8JsonWriter writer, ERichTextType value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToEnumString());
	}
}
