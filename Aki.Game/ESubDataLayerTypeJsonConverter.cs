using System;
using System.Text.Json;
using System.Text.Json.Serialization;

// Token: 0x0200355C RID: 13660
public class ESubDataLayerTypeJsonConverter : JsonConverter<ESubDataLayerType>
{
	// Token: 0x0601DFC6 RID: 122822 RVA: 0x0086D0D4 File Offset: 0x0086B2D4
	public override ESubDataLayerType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string @string = reader.GetString();
		if (string.IsNullOrEmpty(@string))
		{
			return ESubDataLayerType.Default;
		}
		return ESubDataLayerTypeExtensions.FromString(@string);
	}

	// Token: 0x0601DFC7 RID: 122823 RVA: 0x0086D0F8 File Offset: 0x0086B2F8
	public override void Write(Utf8JsonWriter writer, ESubDataLayerType value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToEnumString());
	}
}
