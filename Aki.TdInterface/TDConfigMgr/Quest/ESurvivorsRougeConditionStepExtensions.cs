using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013D8 RID: 5080
	public static class ESurvivorsRougeConditionStepExtensions
	{
		// Token: 0x060071A6 RID: 29094 RVA: 0x0010F7F0 File Offset: 0x0010D9F0
		public static string ToEnumString(this ESurvivorsRougeConditionStep value)
		{
			string result;
			switch (value)
			{
			case ESurvivorsRougeConditionStep.Prepare:
				result = "Prepare";
				break;
			case ESurvivorsRougeConditionStep.Battle:
				result = "Battle";
				break;
			case ESurvivorsRougeConditionStep.End:
				result = "End";
				break;
			case ESurvivorsRougeConditionStep.ChestReward:
				result = "ChestReward";
				break;
			case ESurvivorsRougeConditionStep.ChooseWeapon:
				result = "ChooseWeapon";
				break;
			case ESurvivorsRougeConditionStep.ChooseItem:
				result = "ChooseItem";
				break;
			case ESurvivorsRougeConditionStep.Shopping:
				result = "Shopping";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060071A7 RID: 29095 RVA: 0x0010F868 File Offset: 0x0010DA68
		public static ESurvivorsRougeConditionStep FromString(string name)
		{
			ESurvivorsRougeConditionStep result;
			if (!ESurvivorsRougeConditionStepExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESurvivorsRougeConditionStep 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060071A8 RID: 29096 RVA: 0x0010F894 File Offset: 0x0010DA94
		public static bool TryFromString(string name, out ESurvivorsRougeConditionStep value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESurvivorsRougeConditionStep.Prepare;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 3:
					if (name == "End")
					{
						value = ESurvivorsRougeConditionStep.End;
						return true;
					}
					break;
				case 6:
					if (name == "Battle")
					{
						value = ESurvivorsRougeConditionStep.Battle;
						return true;
					}
					break;
				case 7:
					if (name == "Prepare")
					{
						value = ESurvivorsRougeConditionStep.Prepare;
						return true;
					}
					break;
				case 8:
					if (name == "Shopping")
					{
						value = ESurvivorsRougeConditionStep.Shopping;
						return true;
					}
					break;
				case 10:
					if (name == "ChooseItem")
					{
						value = ESurvivorsRougeConditionStep.ChooseItem;
						return true;
					}
					break;
				case 11:
					if (name == "ChestReward")
					{
						value = ESurvivorsRougeConditionStep.ChestReward;
						return true;
					}
					break;
				case 12:
					if (name == "ChooseWeapon")
					{
						value = ESurvivorsRougeConditionStep.ChooseWeapon;
						return true;
					}
					break;
				}
			}
			value = ESurvivorsRougeConditionStep.Prepare;
			return false;
		}

		// Token: 0x060071A9 RID: 29097 RVA: 0x0010F980 File Offset: 0x0010DB80
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Prepare",
				"Battle",
				"End",
				"ChestReward",
				"ChooseWeapon",
				"ChooseItem",
				"Shopping"
			};
		}

		// Token: 0x060071AA RID: 29098 RVA: 0x0010F9C0 File Offset: 0x0010DBC0
		public static ESurvivorsRougeConditionStep[] GetValues()
		{
			return new ESurvivorsRougeConditionStep[]
			{
				ESurvivorsRougeConditionStep.Prepare,
				ESurvivorsRougeConditionStep.Battle,
				ESurvivorsRougeConditionStep.End,
				ESurvivorsRougeConditionStep.ChestReward,
				ESurvivorsRougeConditionStep.ChooseWeapon,
				ESurvivorsRougeConditionStep.ChooseItem,
				ESurvivorsRougeConditionStep.Shopping
			};
		}

		// Token: 0x060071AB RID: 29099 RVA: 0x0010F9D3 File Offset: 0x0010DBD3
		public static string[] GetNames()
		{
			return new string[]
			{
				"Prepare",
				"Battle",
				"End",
				"ChestReward",
				"ChooseWeapon",
				"ChooseItem",
				"Shopping"
			};
		}
	}
}
