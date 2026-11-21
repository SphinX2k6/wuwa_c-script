using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009EE RID: 2542
	public class EExploreSkillSearchTargetCfgJsonConverter : JsonConverter<EExploreSkillSearchTargetCfg>
	{
		// Token: 0x060038C3 RID: 14531 RVA: 0x000931F8 File Offset: 0x000913F8
		public override EExploreSkillSearchTargetCfg Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EExploreSkillSearchTargetCfg.AngleWeight;
			}
			return EExploreSkillSearchTargetCfgExtensions.FromString(@string);
		}

		// Token: 0x060038C4 RID: 14532 RVA: 0x0009321C File Offset: 0x0009141C
		public override void Write(Utf8JsonWriter writer, EExploreSkillSearchTargetCfg value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
