using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026BA RID: 9914
	public static class ESkillBtnEffectTypeExtensions
	{
		// Token: 0x0600D59F RID: 54687 RVA: 0x001F0BEC File Offset: 0x001EEDEC
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

		// Token: 0x0600D5A0 RID: 54688 RVA: 0x001F0C14 File Offset: 0x001EEE14
		public static ESkillBtnEffectType FromString(string name)
		{
			ESkillBtnEffectType result;
			if (!ESkillBtnEffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESkillBtnEffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D5A1 RID: 54689 RVA: 0x001F0C3D File Offset: 0x001EEE3D
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

		// Token: 0x0600D5A2 RID: 54690 RVA: 0x001F0C62 File Offset: 0x001EEE62
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"MusicBattleBtnEffect"
			};
		}

		// Token: 0x0600D5A3 RID: 54691 RVA: 0x001F0C72 File Offset: 0x001EEE72
		public static ESkillBtnEffectType[] GetValues()
		{
			return new ESkillBtnEffectType[1];
		}

		// Token: 0x0600D5A4 RID: 54692 RVA: 0x001F0C7A File Offset: 0x001EEE7A
		public static string[] GetNames()
		{
			return new string[]
			{
				"MusicBattleBtnEffect"
			};
		}
	}
}
