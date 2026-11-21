using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013CE RID: 5070
	public static class ESkillTypeExtensions
	{
		// Token: 0x06007179 RID: 29049 RVA: 0x0010F014 File Offset: 0x0010D214
		public static string ToEnumString(this ESkillType value)
		{
			string result;
			switch (value)
			{
			case ESkillType.NormalSkill:
				result = "NormalSkill";
				break;
			case ESkillType.VisionSkill:
				result = "VisionSkill";
				break;
			case ESkillType.CharacterFightSkill:
				result = "CharacterFightSkill";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600717A RID: 29050 RVA: 0x0010F05C File Offset: 0x0010D25C
		public static ESkillType FromString(string name)
		{
			ESkillType result;
			if (!ESkillTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESkillType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600717B RID: 29051 RVA: 0x0010F088 File Offset: 0x0010D288
		public static bool TryFromString(string name, out ESkillType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESkillType.NormalSkill;
				return false;
			}
			if (name == "NormalSkill")
			{
				value = ESkillType.NormalSkill;
				return true;
			}
			if (name == "VisionSkill")
			{
				value = ESkillType.VisionSkill;
				return true;
			}
			if (!(name == "CharacterFightSkill"))
			{
				value = ESkillType.NormalSkill;
				return false;
			}
			value = ESkillType.CharacterFightSkill;
			return true;
		}

		// Token: 0x0600717C RID: 29052 RVA: 0x0010F0DE File Offset: 0x0010D2DE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"NormalSkill",
				"VisionSkill",
				"CharacterFightSkill"
			};
		}

		// Token: 0x0600717D RID: 29053 RVA: 0x0010F0FE File Offset: 0x0010D2FE
		public static ESkillType[] GetValues()
		{
			return new ESkillType[]
			{
				ESkillType.NormalSkill,
				ESkillType.VisionSkill,
				ESkillType.CharacterFightSkill
			};
		}

		// Token: 0x0600717E RID: 29054 RVA: 0x0010F10E File Offset: 0x0010D30E
		public static string[] GetNames()
		{
			return new string[]
			{
				"NormalSkill",
				"VisionSkill",
				"CharacterFightSkill"
			};
		}
	}
}
