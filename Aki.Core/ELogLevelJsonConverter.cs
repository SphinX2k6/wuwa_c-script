using System;
using System.Text.Json;
using System.Text.Json.Serialization;

// Token: 0x0200010F RID: 271
public class ELogLevelJsonConverter : JsonConverter<ELogLevel>
{
	// Token: 0x06000A55 RID: 2645 RVA: 0x000336D0 File Offset: 0x000318D0
	public override ELogLevel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string @string = reader.GetString();
		if (string.IsNullOrEmpty(@string))
		{
			return ELogLevel.Error;
		}
		return ELogLevelExtensions.FromString(@string);
	}

	// Token: 0x06000A56 RID: 2646 RVA: 0x000336F4 File Offset: 0x000318F4
	public override void Write(Utf8JsonWriter writer, ELogLevel value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToEnumString());
	}
}
