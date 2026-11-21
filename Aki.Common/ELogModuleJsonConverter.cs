using System;
using System.Text.Json;
using System.Text.Json.Serialization;

// Token: 0x02000012 RID: 18
public class ELogModuleJsonConverter : JsonConverter<ELogModule>
{
	// Token: 0x06000110 RID: 272 RVA: 0x0000E150 File Offset: 0x0000C350
	public override ELogModule Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string @string = reader.GetString();
		if (string.IsNullOrEmpty(@string))
		{
			return ELogModule.Engine;
		}
		return ELogModuleExtensions.FromString(@string);
	}

	// Token: 0x06000111 RID: 273 RVA: 0x0000E174 File Offset: 0x0000C374
	public override void Write(Utf8JsonWriter writer, ELogModule value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToEnumString());
	}
}
