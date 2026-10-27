using System;
using System.Text.Json;
using System.Text.Json.Serialization;

// Token: 0x02003550 RID: 13648
public class EMapExploreToolUseTipIdJsonConverter : JsonConverter<EMapExploreToolUseTipId>
{
	// Token: 0x0601DF90 RID: 122768 RVA: 0x008665A0 File Offset: 0x008647A0
	public override EMapExploreToolUseTipId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string @string = reader.GetString();
		if (string.IsNullOrEmpty(@string))
		{
			return EMapExploreToolUseTipId.MapExploreToolDeploySuccess;
		}
		return EMapExploreToolUseTipIdExtensions.FromString(@string);
	}

	// Token: 0x0601DF91 RID: 122769 RVA: 0x008665C4 File Offset: 0x008647C4
	public override void Write(Utf8JsonWriter writer, EMapExploreToolUseTipId value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToEnumString());
	}
}
