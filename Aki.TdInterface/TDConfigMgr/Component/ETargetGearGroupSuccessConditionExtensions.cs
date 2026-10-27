using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A2C RID: 2604
	public static class ETargetGearGroupSuccessConditionExtensions
	{
		// Token: 0x06003977 RID: 14711 RVA: 0x00094640 File Offset: 0x00092840
		public static string ToEnumString(this ETargetGearGroupSuccessCondition value)
		{
			string result;
			switch (value)
			{
			case ETargetGearGroupSuccessCondition.SameSpecificState:
				result = "SameSpecificState";
				break;
			case ETargetGearGroupSuccessCondition.SameArbitraryState:
				result = "SameArbitraryState";
				break;
			case ETargetGearGroupSuccessCondition.CountDownState:
				result = "CountDownState";
				break;
			case ETargetGearGroupSuccessCondition.SpecificTargetState:
				result = "SpecificTargetState";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003978 RID: 14712 RVA: 0x00094694 File Offset: 0x00092894
		public static ETargetGearGroupSuccessCondition FromString(string name)
		{
			ETargetGearGroupSuccessCondition result;
			if (!ETargetGearGroupSuccessConditionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETargetGearGroupSuccessCondition 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003979 RID: 14713 RVA: 0x000946C0 File Offset: 0x000928C0
		public static bool TryFromString(string name, out ETargetGearGroupSuccessCondition value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETargetGearGroupSuccessCondition.SameSpecificState;
				return false;
			}
			if (name == "SameSpecificState")
			{
				value = ETargetGearGroupSuccessCondition.SameSpecificState;
				return true;
			}
			if (name == "SameArbitraryState")
			{
				value = ETargetGearGroupSuccessCondition.SameArbitraryState;
				return true;
			}
			if (name == "CountDownState")
			{
				value = ETargetGearGroupSuccessCondition.CountDownState;
				return true;
			}
			if (!(name == "SpecificTargetState"))
			{
				value = ETargetGearGroupSuccessCondition.SameSpecificState;
				return false;
			}
			value = ETargetGearGroupSuccessCondition.SpecificTargetState;
			return true;
		}

		// Token: 0x0600397A RID: 14714 RVA: 0x00094728 File Offset: 0x00092928
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SameSpecificState",
				"SameArbitraryState",
				"CountDownState",
				"SpecificTargetState"
			};
		}

		// Token: 0x0600397B RID: 14715 RVA: 0x00094750 File Offset: 0x00092950
		public static ETargetGearGroupSuccessCondition[] GetValues()
		{
			return new ETargetGearGroupSuccessCondition[]
			{
				ETargetGearGroupSuccessCondition.SameSpecificState,
				ETargetGearGroupSuccessCondition.SameArbitraryState,
				ETargetGearGroupSuccessCondition.CountDownState,
				ETargetGearGroupSuccessCondition.SpecificTargetState
			};
		}

		// Token: 0x0600397C RID: 14716 RVA: 0x00094763 File Offset: 0x00092963
		public static string[] GetNames()
		{
			return new string[]
			{
				"SameSpecificState",
				"SameArbitraryState",
				"CountDownState",
				"SpecificTargetState"
			};
		}
	}
}
