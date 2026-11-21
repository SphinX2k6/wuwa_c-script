using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AF1 RID: 2801
	public static class ETargetGearGroupSuccessConditionExtensions
	{
		// Token: 0x06003D4F RID: 15695 RVA: 0x0009CF74 File Offset: 0x0009B174
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

		// Token: 0x06003D50 RID: 15696 RVA: 0x0009CFC8 File Offset: 0x0009B1C8
		public static ETargetGearGroupSuccessCondition FromString(string name)
		{
			ETargetGearGroupSuccessCondition result;
			if (!ETargetGearGroupSuccessConditionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETargetGearGroupSuccessCondition 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003D51 RID: 15697 RVA: 0x0009CFF4 File Offset: 0x0009B1F4
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

		// Token: 0x06003D52 RID: 15698 RVA: 0x0009D05C File Offset: 0x0009B25C
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

		// Token: 0x06003D53 RID: 15699 RVA: 0x0009D084 File Offset: 0x0009B284
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

		// Token: 0x06003D54 RID: 15700 RVA: 0x0009D097 File Offset: 0x0009B297
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
