using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000938 RID: 2360
	public static class EEntityGroupFailureConditionExtensions
	{
		// Token: 0x0600352D RID: 13613 RVA: 0x0008AD0C File Offset: 0x00088F0C
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

		// Token: 0x0600352E RID: 13614 RVA: 0x0008AD44 File Offset: 0x00088F44
		public static EEntityGroupFailureCondition FromString(string name)
		{
			EEntityGroupFailureCondition result;
			if (!EEntityGroupFailureConditionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEntityGroupFailureCondition 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600352F RID: 13615 RVA: 0x0008AD6D File Offset: 0x00088F6D
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

		// Token: 0x06003530 RID: 13616 RVA: 0x0008ADA6 File Offset: 0x00088FA6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SequentialState",
				"ArbitraryState"
			};
		}

		// Token: 0x06003531 RID: 13617 RVA: 0x0008ADBE File Offset: 0x00088FBE
		public static EEntityGroupFailureCondition[] GetValues()
		{
			return new EEntityGroupFailureCondition[]
			{
				EEntityGroupFailureCondition.SequentialState,
				EEntityGroupFailureCondition.ArbitraryState
			};
		}

		// Token: 0x06003532 RID: 13618 RVA: 0x0008ADCA File Offset: 0x00088FCA
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
