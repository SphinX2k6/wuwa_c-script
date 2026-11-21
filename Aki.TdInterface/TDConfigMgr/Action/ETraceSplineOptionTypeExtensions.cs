using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200271E RID: 10014
	public static class ETraceSplineOptionTypeExtensions
	{
		// Token: 0x0600D761 RID: 55137 RVA: 0x001F7660 File Offset: 0x001F5860
		public static string ToEnumString(this ETraceSplineOptionType value)
		{
			string result;
			if (value != ETraceSplineOptionType.Open)
			{
				if (value != ETraceSplineOptionType.Close)
				{
					result = value.ToString();
				}
				else
				{
					result = "Close";
				}
			}
			else
			{
				result = "Open";
			}
			return result;
		}

		// Token: 0x0600D762 RID: 55138 RVA: 0x001F7698 File Offset: 0x001F5898
		public static ETraceSplineOptionType FromString(string name)
		{
			ETraceSplineOptionType result;
			if (!ETraceSplineOptionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETraceSplineOptionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D763 RID: 55139 RVA: 0x001F76C1 File Offset: 0x001F58C1
		public static bool TryFromString(string name, out ETraceSplineOptionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETraceSplineOptionType.Open;
				return false;
			}
			if (name == "Open")
			{
				value = ETraceSplineOptionType.Open;
				return true;
			}
			if (!(name == "Close"))
			{
				value = ETraceSplineOptionType.Open;
				return false;
			}
			value = ETraceSplineOptionType.Close;
			return true;
		}

		// Token: 0x0600D764 RID: 55140 RVA: 0x001F76FA File Offset: 0x001F58FA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Open",
				"Close"
			};
		}

		// Token: 0x0600D765 RID: 55141 RVA: 0x001F7712 File Offset: 0x001F5912
		public static ETraceSplineOptionType[] GetValues()
		{
			return new ETraceSplineOptionType[]
			{
				ETraceSplineOptionType.Open,
				ETraceSplineOptionType.Close
			};
		}

		// Token: 0x0600D766 RID: 55142 RVA: 0x001F771E File Offset: 0x001F591E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Open",
				"Close"
			};
		}
	}
}
