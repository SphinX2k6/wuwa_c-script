using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AEF RID: 2799
	public static class ETargetGearGroupFailureConditionExtensions
	{
		// Token: 0x06003D46 RID: 15686 RVA: 0x0009CE1C File Offset: 0x0009B01C
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

		// Token: 0x06003D47 RID: 15687 RVA: 0x0009CE64 File Offset: 0x0009B064
		public static ETargetGearGroupFailureCondition FromString(string name)
		{
			ETargetGearGroupFailureCondition result;
			if (!ETargetGearGroupFailureConditionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETargetGearGroupFailureCondition 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003D48 RID: 15688 RVA: 0x0009CE90 File Offset: 0x0009B090
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

		// Token: 0x06003D49 RID: 15689 RVA: 0x0009CEE6 File Offset: 0x0009B0E6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ArbitraryState",
				"SequentialState",
				"HitTargetEntity"
			};
		}

		// Token: 0x06003D4A RID: 15690 RVA: 0x0009CF06 File Offset: 0x0009B106
		public static ETargetGearGroupFailureCondition[] GetValues()
		{
			return new ETargetGearGroupFailureCondition[]
			{
				ETargetGearGroupFailureCondition.ArbitraryState,
				ETargetGearGroupFailureCondition.SequentialState,
				ETargetGearGroupFailureCondition.HitTargetEntity
			};
		}

		// Token: 0x06003D4B RID: 15691 RVA: 0x0009CF16 File Offset: 0x0009B116
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
