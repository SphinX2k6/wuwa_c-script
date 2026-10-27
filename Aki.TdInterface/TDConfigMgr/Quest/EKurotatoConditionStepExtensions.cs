using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200124E RID: 4686
	public static class EKurotatoConditionStepExtensions
	{
		// Token: 0x06006A06 RID: 27142 RVA: 0x000FDED4 File Offset: 0x000FC0D4
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

		// Token: 0x06006A07 RID: 27143 RVA: 0x000FDF58 File Offset: 0x000FC158
		public static EKurotatoConditionStep FromString(string name)
		{
			EKurotatoConditionStep result;
			if (!EKurotatoConditionStepExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EKurotatoConditionStep 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006A08 RID: 27144 RVA: 0x000FDF84 File Offset: 0x000FC184
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

		// Token: 0x06006A09 RID: 27145 RVA: 0x000FE0BC File Offset: 0x000FC2BC
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

		// Token: 0x06006A0A RID: 27146 RVA: 0x000FE10F File Offset: 0x000FC30F
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

		// Token: 0x06006A0B RID: 27147 RVA: 0x000FE124 File Offset: 0x000FC324
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
