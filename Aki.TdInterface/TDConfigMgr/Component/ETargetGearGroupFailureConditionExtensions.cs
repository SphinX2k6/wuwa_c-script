using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A2A RID: 2602
	public static class ETargetGearGroupFailureConditionExtensions
	{
		// Token: 0x0600396E RID: 14702 RVA: 0x000944E8 File Offset: 0x000926E8
		public static string ToEnumString(this ETargetGearGroupFailureCondition value)
		{
			string result;
			switch (value)
			{
			case ETargetGearGroupFailureCondition.ArbitraryState:
				result = "ArbitraryState";
				break;
			case ETargetGearGroupFailureCondition.SequentialState:
				result = "SequentialState";
				break;
			case ETargetGearGroupFailureCondition.HitTargetEntity:
				result = "HitTargetEntity";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600396F RID: 14703 RVA: 0x00094530 File Offset: 0x00092730
		public static ETargetGearGroupFailureCondition FromString(string name)
		{
			ETargetGearGroupFailureCondition result;
			if (!ETargetGearGroupFailureConditionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETargetGearGroupFailureCondition 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003970 RID: 14704 RVA: 0x0009455C File Offset: 0x0009275C
		public static bool TryFromString(string name, out ETargetGearGroupFailureCondition value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETargetGearGroupFailureCondition.ArbitraryState;
				return false;
			}
			if (name == "ArbitraryState")
			{
				value = ETargetGearGroupFailureCondition.ArbitraryState;
				return true;
			}
			if (name == "SequentialState")
			{
				value = ETargetGearGroupFailureCondition.SequentialState;
				return true;
			}
			if (!(name == "HitTargetEntity"))
			{
				value = ETargetGearGroupFailureCondition.ArbitraryState;
				return false;
			}
			value = ETargetGearGroupFailureCondition.HitTargetEntity;
			return true;
		}

		// Token: 0x06003971 RID: 14705 RVA: 0x000945B2 File Offset: 0x000927B2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ArbitraryState",
				"SequentialState",
				"HitTargetEntity"
			};
		}

		// Token: 0x06003972 RID: 14706 RVA: 0x000945D2 File Offset: 0x000927D2
		public static ETargetGearGroupFailureCondition[] GetValues()
		{
			return new ETargetGearGroupFailureCondition[]
			{
				ETargetGearGroupFailureCondition.ArbitraryState,
				ETargetGearGroupFailureCondition.SequentialState,
				ETargetGearGroupFailureCondition.HitTargetEntity
			};
		}

		// Token: 0x06003973 RID: 14707 RVA: 0x000945E2 File Offset: 0x000927E2
		public static string[] GetNames()
		{
			return new string[]
			{
				"ArbitraryState",
				"SequentialState",
				"HitTargetEntity"
			};
		}
	}
}
