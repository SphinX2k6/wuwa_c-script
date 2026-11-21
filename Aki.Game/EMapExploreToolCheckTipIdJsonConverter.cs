using System;
using System.Text.Json;
using System.Text.Json.Serialization;

// Token: 0x02002AC3 RID: 10947
public class EMapExploreToolCheckTipIdJsonConverter : JsonConverter<EMapExploreToolCheckTipId>
{
	// Token: 0x0601BCAF RID: 113839 RVA: 0x0088DFF4 File Offset: 0x0088C1F4
	public override EMapExploreToolCheckTipId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string @string = reader.GetString();
		if (string.IsNullOrEmpty(@string))
		{
			return EMapExploreToolCheckTipId.NotHost;
		}
		return EMapExploreToolCheckTipIdExtensions.FromString(@string);
	}

	// Token: 0x0601BCB0 RID: 113840 RVA: 0x0088E018 File Offset: 0x0088C218
	public override void Write(Utf8JsonWriter writer, EMapExploreToolCheckTipId value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToEnumString());
	}
}
