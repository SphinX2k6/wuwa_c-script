using System;
using System.Text.Json;
using System.Text.Json.Serialization;

// Token: 0x0200355A RID: 13658
public class EDataLayerTypeJsonConverter : JsonConverter<EDataLayerType>
{
	// Token: 0x0601DFBD RID: 122813 RVA: 0x0086CF80 File Offset: 0x0086B180
	public override EDataLayerType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string @string = reader.GetString();
		if (string.IsNullOrEmpty(@string))
		{
			return EDataLayerType.Default;
		}
		return EDataLayerTypeExtensions.FromString(@string);
	}

	// Token: 0x0601DFBE RID: 122814 RVA: 0x0086CFA4 File Offset: 0x0086B1A4
	public override void Write(Utf8JsonWriter writer, EDataLayerType value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToEnumString());
	}
}
