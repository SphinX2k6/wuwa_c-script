using System;
using System.Text.Json;
using System.Text.Json.Serialization;

// Token: 0x02000111 RID: 273
public class EBpTypeNameJsonConverter : JsonConverter<EBpTypeName>
{
	// Token: 0x06000A0D RID: 2573 RVA: 0x00033714 File Offset: 0x00031914
	public override EBpTypeName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string @string = reader.GetString();
		if (string.IsNullOrEmpty(@string))
		{
			return EBpTypeName.DataTableUtil_C;
		}
		return EBpTypeNameExtensions.FromString(@string);
	}

	// Token: 0x06000A0E RID: 2574 RVA: 0x00033738 File Offset: 0x00031938
	public override void Write(Utf8JsonWriter writer, EBpTypeName value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToEnumString());
	}
}
