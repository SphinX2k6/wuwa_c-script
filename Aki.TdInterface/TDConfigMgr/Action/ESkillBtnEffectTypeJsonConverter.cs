using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026BB RID: 9915
	public class ESkillBtnEffectTypeJsonConverter : JsonConverter<ESkillBtnEffectType>
	{
		// Token: 0x0600D5A5 RID: 54693 RVA: 0x001F0C8C File Offset: 0x001EEE8C
		public override ESkillBtnEffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESkillBtnEffectType.MusicBattleBtnEffect;
			}
			return ESkillBtnEffectTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D5A6 RID: 54694 RVA: 0x001F0CB0 File Offset: 0x001EEEB0
		public override void Write(Utf8JsonWriter writer, ESkillBtnEffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
