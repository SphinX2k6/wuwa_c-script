using System;
using System.Text.Json;
using System.Text.Json.Serialization;

// Token: 0x0200354E RID: 13646
public class EMapExploreToolCheckTipIdJsonConverter : JsonConverter<EMapExploreToolCheckTipId>
{
	// Token: 0x0601DF87 RID: 122759 RVA: 0x0086648C File Offset: 0x0086468C
	public override EMapExploreToolCheckTipId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string @string = reader.GetString();
		if (string.IsNullOrEmpty(@string))
		{
			return EMapExploreToolCheckTipId.NotHost;
		}
		return EMapExploreToolCheckTipIdExtensions.FromString(@string);
	}

	// Token: 0x0601DF88 RID: 122760 RVA: 0x008664B0 File Offset: 0x008646B0
	public override void Write(Utf8JsonWriter writer, EMapExploreToolCheckTipId value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToEnumString());
	}
}
