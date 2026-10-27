using System;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F8C RID: 20364
	public static class EQuickHackSkillConditionExtensions
	{
		// Token: 0x0603425E RID: 213598 RVA: 0x00C3D1EC File Offset: 0x00C3B3EC
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

		// Token: 0x0603425F RID: 213599 RVA: 0x00C3D258 File Offset: 0x00C3B458
		public static EQuickHackSkillCondition FromString(string name)
		{
			EQuickHackSkillCondition result;
			if (!EQuickHackSkillConditionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EQuickHackSkillCondition 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06034260 RID: 213600 RVA: 0x00C3D284 File Offset: 0x00C3B484
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

		// Token: 0x06034261 RID: 213601 RVA: 0x00C3D310 File Offset: 0x00C3B510
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

		// Token: 0x06034262 RID: 213602 RVA: 0x00C3D348 File Offset: 0x00C3B548
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

		// Token: 0x06034263 RID: 213603 RVA: 0x00C3D35B File Offset: 0x00C3B55B
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
