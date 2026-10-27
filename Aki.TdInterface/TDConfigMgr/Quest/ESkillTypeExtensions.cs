using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200128E RID: 4750
	public static class ESkillTypeExtensions
	{
		// Token: 0x06006B26 RID: 27430 RVA: 0x00101318 File Offset: 0x000FF518
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

		// Token: 0x06006B27 RID: 27431 RVA: 0x00101360 File Offset: 0x000FF560
		public static ESkillType FromString(string name)
		{
			ESkillType result;
			if (!ESkillTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESkillType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006B28 RID: 27432 RVA: 0x0010138C File Offset: 0x000FF58C
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

		// Token: 0x06006B29 RID: 27433 RVA: 0x001013E2 File Offset: 0x000FF5E2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"NormalSkill",
				"VisionSkill",
				"CharacterFightSkill"
			};
		}

		// Token: 0x06006B2A RID: 27434 RVA: 0x00101402 File Offset: 0x000FF602
		public static ESkillType[] GetValues()
		{
			return new ESkillType[]
			{
				ESkillType.NormalSkill,
				ESkillType.VisionSkill,
				ESkillType.CharacterFightSkill
			};
		}

		// Token: 0x06006B2B RID: 27435 RVA: 0x00101412 File Offset: 0x000FF612
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
