using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001296 RID: 4758
	public static class ESurvivorsRougeConditionStepExtensions
	{
		// Token: 0x06006B4A RID: 27466 RVA: 0x00101A18 File Offset: 0x000FFC18
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

		// Token: 0x06006B4B RID: 27467 RVA: 0x00101A90 File Offset: 0x000FFC90
		public static ESurvivorsRougeConditionStep FromString(string name)
		{
			ESurvivorsRougeConditionStep result;
			if (!ESurvivorsRougeConditionStepExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESurvivorsRougeConditionStep 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006B4C RID: 27468 RVA: 0x00101ABC File Offset: 0x000FFCBC
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

		// Token: 0x06006B4D RID: 27469 RVA: 0x00101BA8 File Offset: 0x000FFDA8
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

		// Token: 0x06006B4E RID: 27470 RVA: 0x00101BE8 File Offset: 0x000FFDE8
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

		// Token: 0x06006B4F RID: 27471 RVA: 0x00101BFB File Offset: 0x000FFDFB
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
