using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000941 RID: 2369
	public class EExploreSkillSearchTargetCfgJsonConverter : JsonConverter<EExploreSkillSearchTargetCfg>
	{
		// Token: 0x06003557 RID: 13655 RVA: 0x0008B61C File Offset: 0x0008981C
		public override EExploreSkillSearchTargetCfg Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EExploreSkillSearchTargetCfg.AngleWeight;
			}
			return EExploreSkillSearchTargetCfgExtensions.FromString(@string);
		}

		// Token: 0x06003558 RID: 13656 RVA: 0x0008B640 File Offset: 0x00089840
		public override void Write(Utf8JsonWriter writer, EExploreSkillSearchTargetCfg value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
