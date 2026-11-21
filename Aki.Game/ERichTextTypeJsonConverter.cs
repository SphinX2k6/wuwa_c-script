using System;
using System.Text.Json;
using System.Text.Json.Serialization;

// Token: 0x02002ACD RID: 10957
public class ERichTextTypeJsonConverter : JsonConverter<ERichTextType>
{
	// Token: 0x0601BCDC RID: 113884 RVA: 0x00894A8C File Offset: 0x00892C8C
	public override ERichTextType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string @string = reader.GetString();
		if (string.IsNullOrEmpty(@string))
		{
			return ERichTextType.PlayerName;
		}
		return ERichTextTypeExtensions.FromString(@string);
	}

	// Token: 0x0601BCDD RID: 113885 RVA: 0x00894AB0 File Offset: 0x00892CB0
	public override void Write(Utf8JsonWriter writer, ERichTextType value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToEnumString());
	}
}
