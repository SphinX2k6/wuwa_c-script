using System;
using System.Text.Json;
using System.Text.Json.Serialization;

// Token: 0x02002ACB RID: 10955
public class ERedDotNameJsonConverter : JsonConverter<ERedDotName>
{
	// Token: 0x0601BCD3 RID: 113875 RVA: 0x008948A8 File Offset: 0x00892AA8
	public override ERedDotName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string @string = reader.GetString();
		if (string.IsNullOrEmpty(@string))
		{
			return ERedDotName.Test;
		}
		return ERedDotNameExtensions.FromString(@string);
	}

	// Token: 0x0601BCD4 RID: 113876 RVA: 0x008948CC File Offset: 0x00892ACC
	public override void Write(Utf8JsonWriter writer, ERedDotName value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToEnumString());
	}
}
