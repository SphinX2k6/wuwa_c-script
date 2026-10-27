using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009F0 RID: 2544
	public static class ERefreshRuleExtensions
	{
		// Token: 0x06003869 RID: 14441 RVA: 0x00092124 File Offset: 0x00090324
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

		// Token: 0x0600386A RID: 14442 RVA: 0x0009216C File Offset: 0x0009036C
		public static ERefreshRule FromString(string name)
		{
			ERefreshRule result;
			if (!ERefreshRuleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERefreshRule 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600386B RID: 14443 RVA: 0x00092198 File Offset: 0x00090398
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

		// Token: 0x0600386C RID: 14444 RVA: 0x000921EE File Offset: 0x000903EE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CD",
				"FixedDateTime",
				"ProbabilityByTime"
			};
		}

		// Token: 0x0600386D RID: 14445 RVA: 0x0009220E File Offset: 0x0009040E
		public static ERefreshRule[] GetValues()
		{
			return new ERefreshRule[]
			{
				ERefreshRule.CD,
				ERefreshRule.FixedDateTime,
				ERefreshRule.ProbabilityByTime
			};
		}

		// Token: 0x0600386E RID: 14446 RVA: 0x0009221E File Offset: 0x0009041E
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
