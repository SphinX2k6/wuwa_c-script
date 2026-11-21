using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013C2 RID: 5058
	public static class ERoleTowerConditionStepExtensions
	{
		// Token: 0x06007143 RID: 28995 RVA: 0x0010E4DC File Offset: 0x0010C6DC
		public static string ToEnumString(this ERoleTowerConditionStep value)
		{
			string result;
			switch (value)
			{
			case ERoleTowerConditionStep.Prepare:
				result = "Prepare";
				break;
			case ERoleTowerConditionStep.Battle:
				result = "Battle";
				break;
			case ERoleTowerConditionStep.Settle:
				result = "Settle";
				break;
			case ERoleTowerConditionStep.TeamUpgrade:
				result = "TeamUpgrade";
				break;
			case ERoleTowerConditionStep.LoadSubLevel:
				result = "LoadSubLevel";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06007144 RID: 28996 RVA: 0x0010E53C File Offset: 0x0010C73C
		public static ERoleTowerConditionStep FromString(string name)
		{
			ERoleTowerConditionStep result;
			if (!ERoleTowerConditionStepExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERoleTowerConditionStep 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007145 RID: 28997 RVA: 0x0010E568 File Offset: 0x0010C768
		public static bool TryFromString(string name, out ERoleTowerConditionStep value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERoleTowerConditionStep.Prepare;
				return false;
			}
			if (name == "Prepare")
			{
				value = ERoleTowerConditionStep.Prepare;
				return true;
			}
			if (name == "Battle")
			{
				value = ERoleTowerConditionStep.Battle;
				return true;
			}
			if (name == "Settle")
			{
				value = ERoleTowerConditionStep.Settle;
				return true;
			}
			if (name == "TeamUpgrade")
			{
				value = ERoleTowerConditionStep.TeamUpgrade;
				return true;
			}
			if (!(name == "LoadSubLevel"))
			{
				value = ERoleTowerConditionStep.Prepare;
				return false;
			}
			value = ERoleTowerConditionStep.LoadSubLevel;
			return true;
		}

		// Token: 0x06007146 RID: 28998 RVA: 0x0010E5E2 File Offset: 0x0010C7E2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Prepare",
				"Battle",
				"Settle",
				"TeamUpgrade",
				"LoadSubLevel"
			};
		}

		// Token: 0x06007147 RID: 28999 RVA: 0x0010E612 File Offset: 0x0010C812
		public static ERoleTowerConditionStep[] GetValues()
		{
			return new ERoleTowerConditionStep[]
			{
				ERoleTowerConditionStep.Prepare,
				ERoleTowerConditionStep.Battle,
				ERoleTowerConditionStep.Settle,
				ERoleTowerConditionStep.TeamUpgrade,
				ERoleTowerConditionStep.LoadSubLevel
			};
		}

		// Token: 0x06007148 RID: 29000 RVA: 0x0010E625 File Offset: 0x0010C825
		public static string[] GetNames()
		{
			return new string[]
			{
				"Prepare",
				"Battle",
				"Settle",
				"TeamUpgrade",
				"LoadSubLevel"
			};
		}
	}
}
