using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200241B RID: 9243
	public static class ESkillBtnEffectTypeExtensions
	{
		// Token: 0x0600C8F8 RID: 51448 RVA: 0x001D6F18 File Offset: 0x001D5118
		public static string ToEnumString(this ESkillBtnEffectType value)
		{
			string result;
			if (value == ESkillBtnEffectType.MusicBattleBtnEffect)
			{
				result = "MusicBattleBtnEffect";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C8F9 RID: 51449 RVA: 0x001D6F40 File Offset: 0x001D5140
		public static ESkillBtnEffectType FromString(string name)
		{
			ESkillBtnEffectType result;
			if (!ESkillBtnEffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESkillBtnEffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C8FA RID: 51450 RVA: 0x001D6F69 File Offset: 0x001D5169
		public static bool TryFromString(string name, out ESkillBtnEffectType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESkillBtnEffectType.MusicBattleBtnEffect;
				return false;
			}
			if (name == "MusicBattleBtnEffect")
			{
				value = ESkillBtnEffectType.MusicBattleBtnEffect;
				return true;
			}
			value = ESkillBtnEffectType.MusicBattleBtnEffect;
			return false;
		}

		// Token: 0x0600C8FB RID: 51451 RVA: 0x001D6F8E File Offset: 0x001D518E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"MusicBattleBtnEffect"
			};
		}

		// Token: 0x0600C8FC RID: 51452 RVA: 0x001D6F9E File Offset: 0x001D519E
		public static ESkillBtnEffectType[] GetValues()
		{
			return new ESkillBtnEffectType[1];
		}

		// Token: 0x0600C8FD RID: 51453 RVA: 0x001D6FA6 File Offset: 0x001D51A6
		public static string[] GetNames()
		{
			return new string[]
			{
				"MusicBattleBtnEffect"
			};
		}
	}
}
