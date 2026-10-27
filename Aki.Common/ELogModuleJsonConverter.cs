using System;
using System.Text.Json;
using System.Text.Json.Serialization;

// Token: 0x02000011 RID: 17
public class ELogModuleJsonConverter : JsonConverter<ELogModule>
{
	// Token: 0x060000A3 RID: 163 RVA: 0x0000A9A8 File Offset: 0x00008BA8
	public override ELogModule Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string @string = reader.GetString();
		if (string.IsNullOrEmpty(@string))
		{
			return ELogModule.Engine;
		}
		return ELogModuleExtensions.FromString(@string);
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x0000A9CC File Offset: 0x00008BCC
	public override void Write(Utf8JsonWriter writer, ELogModule value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToEnumString());
	}
}
