using System;
using System.Text.Json;
using System.Text.Json.Serialization;

// Token: 0x02002AC5 RID: 10949
public class EMapExploreToolUseTipIdJsonConverter : JsonConverter<EMapExploreToolUseTipId>
{
	// Token: 0x0601BCB8 RID: 113848 RVA: 0x0088E108 File Offset: 0x0088C308
	public override EMapExploreToolUseTipId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		string @string = reader.GetString();
		if (string.IsNullOrEmpty(@string))
		{
			return EMapExploreToolUseTipId.MapExploreToolDeploySuccess;
		}
		return EMapExploreToolUseTipIdExtensions.FromString(@string);
	}

	// Token: 0x0601BCB9 RID: 113849 RVA: 0x0088E12C File Offset: 0x0088C32C
	public override void Write(Utf8JsonWriter writer, EMapExploreToolUseTipId value, JsonSerializerOptions options)
	{
		writer.WriteStringValue(value.ToEnumString());
	}
}
