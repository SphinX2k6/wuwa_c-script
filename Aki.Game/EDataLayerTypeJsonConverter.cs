using System;
using System.Text.Json;
using System.Text.Json.Serialization;

// Token: 0x02002ACF RID: 10959
public class EDataLayerTypeJsonConverter : JsonConverter<EDataLayerType>
{
	// Token: 0x0601BCE5 RID: 113893 RVA: 0x00894BE0 File Offset: 0x00892DE0
	public override EDataLayerType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string @string = reader.GetString();
		if (string.IsNullOrEmpty(@string))
		{
			return EDataLayerType.Default;
		}
		return EDataLayerTypeExtensions.FromString(@string);
	}

	// Token: 0x0601BCE6 RID: 113894 RVA: 0x00894C04 File Offset: 0x00892E04
	public override void Write(Utf8JsonWriter writer, EDataLayerType value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToEnumString());
	}
}
