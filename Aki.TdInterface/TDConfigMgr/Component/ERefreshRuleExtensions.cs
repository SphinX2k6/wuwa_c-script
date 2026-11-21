using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AB5 RID: 2741
	public static class ERefreshRuleExtensions
	{
		// Token: 0x06003C41 RID: 15425 RVA: 0x0009A9E4 File Offset: 0x00098BE4
		public static string ToEnumString(this ERefreshRule value)
		{
			string result;
			switch (value)
			{
			case ERefreshRule.CD:
				result = "CD";
				break;
			case ERefreshRule.FixedDateTime:
				result = "FixedDateTime";
				break;
			case ERefreshRule.ProbabilityByTime:
				result = "ProbabilityByTime";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003C42 RID: 15426 RVA: 0x0009AA2C File Offset: 0x00098C2C
		public static ERefreshRule FromString(string name)
		{
			ERefreshRule result;
			if (!ERefreshRuleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERefreshRule 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003C43 RID: 15427 RVA: 0x0009AA58 File Offset: 0x00098C58
		public static bool TryFromString(string name, out ERefreshRule value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERefreshRule.CD;
				return false;
			}
			if (name == "CD")
			{
				value = ERefreshRule.CD;
				return true;
			}
			if (name == "FixedDateTime")
			{
				value = ERefreshRule.FixedDateTime;
				return true;
			}
			if (!(name == "ProbabilityByTime"))
			{
				value = ERefreshRule.CD;
				return false;
			}
			value = ERefreshRule.ProbabilityByTime;
			return true;
		}

		// Token: 0x06003C44 RID: 15428 RVA: 0x0009AAAE File Offset: 0x00098CAE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CD",
				"FixedDateTime",
				"ProbabilityByTime"
			};
		}

		// Token: 0x06003C45 RID: 15429 RVA: 0x0009AACE File Offset: 0x00098CCE
		public static ERefreshRule[] GetValues()
		{
			return new ERefreshRule[]
			{
				ERefreshRule.CD,
				ERefreshRule.FixedDateTime,
				ERefreshRule.ProbabilityByTime
			};
		}

		// Token: 0x06003C46 RID: 15430 RVA: 0x0009AADE File Offset: 0x00098CDE
		public static string[] GetNames()
		{
			return new string[]
			{
				"CD",
				"FixedDateTime",
				"ProbabilityByTime"
			};
		}
	}
}
