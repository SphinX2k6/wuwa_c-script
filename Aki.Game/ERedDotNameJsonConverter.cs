using System;
using System.Text.Json;
using System.Text.Json.Serialization;

// Token: 0x02003556 RID: 13654
public class ERedDotNameJsonConverter : JsonConverter<ERedDotName>
{
	// Token: 0x0601DFAB RID: 122795 RVA: 0x0086CC48 File Offset: 0x0086AE48
	public override ERedDotName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string @string = reader.GetString();
		if (string.IsNullOrEmpty(@string))
		{
			return ERedDotName.Test;
		}
		return ERedDotNameExtensions.FromString(@string);
	}

	// Token: 0x0601DFAC RID: 122796 RVA: 0x0086CC6C File Offset: 0x0086AE6C
	public override void Write(Utf8JsonWriter writer, ERedDotName value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToEnumString());
	}
}
