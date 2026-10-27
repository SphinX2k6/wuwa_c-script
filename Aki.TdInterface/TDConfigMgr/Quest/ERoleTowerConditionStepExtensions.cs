using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001282 RID: 4738
	public static class ERoleTowerConditionStepExtensions
	{
		// Token: 0x06006AF0 RID: 27376 RVA: 0x001008B0 File Offset: 0x000FEAB0
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

		// Token: 0x06006AF1 RID: 27377 RVA: 0x00100910 File Offset: 0x000FEB10
		public static ERoleTowerConditionStep FromString(string name)
		{
			ERoleTowerConditionStep result;
			if (!ERoleTowerConditionStepExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERoleTowerConditionStep 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006AF2 RID: 27378 RVA: 0x0010093C File Offset: 0x000FEB3C
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

		// Token: 0x06006AF3 RID: 27379 RVA: 0x001009B6 File Offset: 0x000FEBB6
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

		// Token: 0x06006AF4 RID: 27380 RVA: 0x001009E6 File Offset: 0x000FEBE6
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

		// Token: 0x06006AF5 RID: 27381 RVA: 0x001009F9 File Offset: 0x000FEBF9
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
