using System;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F55 RID: 16213
	public static class EQuickHackSkillConditionExtensions
	{
		// Token: 0x060290CC RID: 168140 RVA: 0x00B86998 File Offset: 0x00B84B98
		public static string ToEnumString(this EQuickHackSkillCondition value)
		{
			string result;
			switch (value)
			{
			case EQuickHackSkillCondition.CheckTargetTypeMatch:
				result = "CheckTargetTypeMatch";
				break;
			case EQuickHackSkillCondition.CheckRamEnough:
				result = "CheckRamEnough";
				break;
			case EQuickHackSkillCondition.CheckUsageCountEnough:
				result = "CheckUsageCountEnough";
				break;
			case EQuickHackSkillCondition.CheckAnyMonsterTypeMatch:
				result = "CheckAnyMonsterTypeMatch";
				break;
			case EQuickHackSkillCondition.CheckAnySceneItemCanHack:
				result = "CheckAnySceneItemCanHack";
				break;
			case EQuickHackSkillCondition.CheckAnyTargetNotBeenUsedSkill:
				result = "CheckAnyTargetNotBeenUsedSkill";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060290CD RID: 168141 RVA: 0x00B86A04 File Offset: 0x00B84C04
		public static EQuickHackSkillCondition FromString(string name)
		{
			EQuickHackSkillCondition result;
			if (!EQuickHackSkillConditionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EQuickHackSkillCondition 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060290CE RID: 168142 RVA: 0x00B86A30 File Offset: 0x00B84C30
		public static bool TryFromString(string name, out EQuickHackSkillCondition value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EQuickHackSkillCondition.CheckTargetTypeMatch;
				return false;
			}
			if (name == "CheckTargetTypeMatch")
			{
				value = EQuickHackSkillCondition.CheckTargetTypeMatch;
				return true;
			}
			if (name == "CheckRamEnough")
			{
				value = EQuickHackSkillCondition.CheckRamEnough;
				return true;
			}
			if (name == "CheckUsageCountEnough")
			{
				value = EQuickHackSkillCondition.CheckUsageCountEnough;
				return true;
			}
			if (name == "CheckAnyMonsterTypeMatch")
			{
				value = EQuickHackSkillCondition.CheckAnyMonsterTypeMatch;
				return true;
			}
			if (name == "CheckAnySceneItemCanHack")
			{
				value = EQuickHackSkillCondition.CheckAnySceneItemCanHack;
				return true;
			}
			if (!(name == "CheckAnyTargetNotBeenUsedSkill"))
			{
				value = EQuickHackSkillCondition.CheckTargetTypeMatch;
				return false;
			}
			value = EQuickHackSkillCondition.CheckAnyTargetNotBeenUsedSkill;
			return true;
		}

		// Token: 0x060290CF RID: 168143 RVA: 0x00B86ABC File Offset: 0x00B84CBC
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CheckTargetTypeMatch",
				"CheckRamEnough",
				"CheckUsageCountEnough",
				"CheckAnyMonsterTypeMatch",
				"CheckAnySceneItemCanHack",
				"CheckAnyTargetNotBeenUsedSkill"
			};
		}

		// Token: 0x060290D0 RID: 168144 RVA: 0x00B86AF4 File Offset: 0x00B84CF4
		public static EQuickHackSkillCondition[] GetValues()
		{
			return new EQuickHackSkillCondition[]
			{
				EQuickHackSkillCondition.CheckTargetTypeMatch,
				EQuickHackSkillCondition.CheckRamEnough,
				EQuickHackSkillCondition.CheckUsageCountEnough,
				EQuickHackSkillCondition.CheckAnyMonsterTypeMatch,
				EQuickHackSkillCondition.CheckAnySceneItemCanHack,
				EQuickHackSkillCondition.CheckAnyTargetNotBeenUsedSkill
			};
		}

		// Token: 0x060290D1 RID: 168145 RVA: 0x00B86B07 File Offset: 0x00B84D07
		public static string[] GetNames()
		{
			return new string[]
			{
				"CheckTargetTypeMatch",
				"CheckRamEnough",
				"CheckUsageCountEnough",
				"CheckAnyMonsterTypeMatch",
				"CheckAnySceneItemCanHack",
				"CheckAnyTargetNotBeenUsedSkill"
			};
		}
	}
}
