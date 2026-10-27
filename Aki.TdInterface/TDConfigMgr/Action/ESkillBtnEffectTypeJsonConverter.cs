using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200241C RID: 9244
	public class ESkillBtnEffectTypeJsonConverter : JsonConverter<ESkillBtnEffectType>
	{
		// Token: 0x0600C8FE RID: 51454 RVA: 0x001D6FB8 File Offset: 0x001D51B8
		public override ESkillBtnEffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESkillBtnEffectType.MusicBattleBtnEffect;
			}
			return ESkillBtnEffectTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C8FF RID: 51455 RVA: 0x001D6FDC File Offset: 0x001D51DC
		public override void Write(Utf8JsonWriter writer, ESkillBtnEffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
