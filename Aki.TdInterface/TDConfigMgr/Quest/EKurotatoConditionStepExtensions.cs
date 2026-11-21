using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200138E RID: 5006
	public static class EKurotatoConditionStepExtensions
	{
		// Token: 0x06007059 RID: 28761 RVA: 0x0010BB00 File Offset: 0x00109D00
		public static string ToEnumString(this EKurotatoConditionStep value)
		{
			string result;
			switch (value)
			{
			case EKurotatoConditionStep.Prepare:
				result = "Prepare";
				break;
			case EKurotatoConditionStep.Battle:
				result = "Battle";
				break;
			case EKurotatoConditionStep.End:
				result = "End";
				break;
			case EKurotatoConditionStep.SaveRole:
				result = "SaveRole";
				break;
			case EKurotatoConditionStep.ChestReward:
				result = "ChestReward";
				break;
			case EKurotatoConditionStep.UpgradeReward:
				result = "UpgradeReward";
				break;
			case EKurotatoConditionStep.Shopping:
				result = "Shopping";
				break;
			case EKurotatoConditionStep.UpdateBatch:
				result = "UpdateBatch";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600705A RID: 28762 RVA: 0x0010BB84 File Offset: 0x00109D84
		public static EKurotatoConditionStep FromString(string name)
		{
			EKurotatoConditionStep result;
			if (!EKurotatoConditionStepExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EKurotatoConditionStep 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600705B RID: 28763 RVA: 0x0010BBB0 File Offset: 0x00109DB0
		public static bool TryFromString(string name, out EKurotatoConditionStep value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EKurotatoConditionStep.Prepare;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 3:
					if (name == "End")
					{
						value = EKurotatoConditionStep.End;
						return true;
					}
					break;
				case 6:
					if (name == "Battle")
					{
						value = EKurotatoConditionStep.Battle;
						return true;
					}
					break;
				case 7:
					if (name == "Prepare")
					{
						value = EKurotatoConditionStep.Prepare;
						return true;
					}
					break;
				case 8:
				{
					char c = name[1];
					if (c != 'a')
					{
						if (c == 'h')
						{
							if (name == "Shopping")
							{
								value = EKurotatoConditionStep.Shopping;
								return true;
							}
						}
					}
					else if (name == "SaveRole")
					{
						value = EKurotatoConditionStep.SaveRole;
						return true;
					}
					break;
				}
				case 11:
				{
					char c = name[0];
					if (c != 'C')
					{
						if (c == 'U')
						{
							if (name == "UpdateBatch")
							{
								value = EKurotatoConditionStep.UpdateBatch;
								return true;
							}
						}
					}
					else if (name == "ChestReward")
					{
						value = EKurotatoConditionStep.ChestReward;
						return true;
					}
					break;
				}
				case 13:
					if (name == "UpgradeReward")
					{
						value = EKurotatoConditionStep.UpgradeReward;
						return true;
					}
					break;
				}
			}
			value = EKurotatoConditionStep.Prepare;
			return false;
		}

		// Token: 0x0600705C RID: 28764 RVA: 0x0010BCE8 File Offset: 0x00109EE8
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Prepare",
				"Battle",
				"End",
				"SaveRole",
				"ChestReward",
				"UpgradeReward",
				"Shopping",
				"UpdateBatch"
			};
		}

		// Token: 0x0600705D RID: 28765 RVA: 0x0010BD3B File Offset: 0x00109F3B
		public static EKurotatoConditionStep[] GetValues()
		{
			return new EKurotatoConditionStep[]
			{
				EKurotatoConditionStep.Prepare,
				EKurotatoConditionStep.Battle,
				EKurotatoConditionStep.End,
				EKurotatoConditionStep.SaveRole,
				EKurotatoConditionStep.ChestReward,
				EKurotatoConditionStep.UpgradeReward,
				EKurotatoConditionStep.Shopping,
				EKurotatoConditionStep.UpdateBatch
			};
		}

		// Token: 0x0600705E RID: 28766 RVA: 0x0010BD50 File Offset: 0x00109F50
		public static string[] GetNames()
		{
			return new string[]
			{
				"Prepare",
				"Battle",
				"End",
				"SaveRole",
				"ChestReward",
				"UpgradeReward",
				"Shopping",
				"UpdateBatch"
			};
		}
	}
}
