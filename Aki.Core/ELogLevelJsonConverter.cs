using System;
using System.Text.Json;
using System.Text.Json.Serialization;

// Token: 0x0200010F RID: 271
public class ELogLevelJsonConverter : JsonConverter<ELogLevel>
{
	// Token: 0x06000A04 RID: 2564 RVA: 0x00032D74 File Offset: 0x00030F74
	public override ELogLevel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string @string = reader.GetString();
		if (string.IsNullOrEmpty(@string))
		{
			return ELogLevel.Error;
		}
		return ELogLevelExtensions.FromString(@string);
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x00032D98 File Offset: 0x00030F98
	public override void Write(Utf8JsonWriter writer, ELogLevel value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToEnumString());
	}
}
