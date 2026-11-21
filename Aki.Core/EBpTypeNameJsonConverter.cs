using System;
using System.Text.Json;
using System.Text.Json.Serialization;

// Token: 0x02000111 RID: 273
public class EBpTypeNameJsonConverter : JsonConverter<EBpTypeName>
{
	// Token: 0x06000A5E RID: 2654 RVA: 0x000340F0 File Offset: 0x000322F0
	public override EBpTypeName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string @string = reader.GetString();
		if (string.IsNullOrEmpty(@string))
		{
			return EBpTypeName.DataTableUtil_C;
		}
		return EBpTypeNameExtensions.FromString(@string);
	}

	// Token: 0x06000A5F RID: 2655 RVA: 0x00034114 File Offset: 0x00032314
	public override void Write(Utf8JsonWriter writer, EBpTypeName value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToEnumString());
	}
}
