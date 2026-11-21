using System;
using System.Text.Json;
using System.Text.Json.Serialization;

// Token: 0x02002AD1 RID: 10961
public class ESubDataLayerTypeJsonConverter : JsonConverter<ESubDataLayerType>
{
	// Token: 0x0601BCEE RID: 113902 RVA: 0x00894D34 File Offset: 0x00892F34
	public override ESubDataLayerType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string @string = reader.GetString();
		if (string.IsNullOrEmpty(@string))
		{
			return ESubDataLayerType.Default;
		}
		return ESubDataLayerTypeExtensions.FromString(@string);
	}

	// Token: 0x0601BCEF RID: 113903 RVA: 0x00894D58 File Offset: 0x00892F58
	public override void Write(Utf8JsonWriter writer, ESubDataLayerType value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToEnumString());
	}
}
