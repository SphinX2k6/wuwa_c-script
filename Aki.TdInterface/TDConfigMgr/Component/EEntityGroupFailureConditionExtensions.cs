using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009E5 RID: 2533
	public static class EEntityGroupFailureConditionExtensions
	{
		// Token: 0x06003899 RID: 14489 RVA: 0x0009288C File Offset: 0x00090A8C
		public static string ToEnumString(this EEntityGroupFailureCondition value)
		{
			string result;
			if (value != EEntityGroupFailureCondition.SequentialState)
			{
				if (value != EEntityGroupFailureCondition.ArbitraryState)
				{
					result = value.ToString();
				}
				else
				{
					result = "ArbitraryState";
				}
			}
			else
			{
				result = "SequentialState";
			}
			return result;
		}

		// Token: 0x0600389A RID: 14490 RVA: 0x000928C4 File Offset: 0x00090AC4
		public static EEntityGroupFailureCondition FromString(string name)
		{
			EEntityGroupFailureCondition result;
			if (!EEntityGroupFailureConditionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEntityGroupFailureCondition 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600389B RID: 14491 RVA: 0x000928ED File Offset: 0x00090AED
		public static bool TryFromString(string name, out EEntityGroupFailureCondition value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EEntityGroupFailureCondition.SequentialState;
				return false;
			}
			if (name == "SequentialState")
			{
				value = EEntityGroupFailureCondition.SequentialState;
				return true;
			}
			if (!(name == "ArbitraryState"))
			{
				value = EEntityGroupFailureCondition.SequentialState;
				return false;
			}
			value = EEntityGroupFailureCondition.ArbitraryState;
			return true;
		}

		// Token: 0x0600389C RID: 14492 RVA: 0x00092926 File Offset: 0x00090B26
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SequentialState",
				"ArbitraryState"
			};
		}

		// Token: 0x0600389D RID: 14493 RVA: 0x0009293E File Offset: 0x00090B3E
		public static EEntityGroupFailureCondition[] GetValues()
		{
			return new EEntityGroupFailureCondition[]
			{
				EEntityGroupFailureCondition.SequentialState,
				EEntityGroupFailureCondition.ArbitraryState
			};
		}

		// Token: 0x0600389E RID: 14494 RVA: 0x0009294A File Offset: 0x00090B4A
		public static string[] GetNames()
		{
			return new string[]
			{
				"SequentialState",
				"ArbitraryState"
			};
		}
	}
}
