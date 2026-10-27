using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200247B RID: 9339
	public static class ETraceSplineOptionTypeExtensions
	{
		// Token: 0x0600CAA8 RID: 51880 RVA: 0x001DD498 File Offset: 0x001DB698
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

		// Token: 0x0600CAA9 RID: 51881 RVA: 0x001DD4D0 File Offset: 0x001DB6D0
		public static ETraceSplineOptionType FromString(string name)
		{
			ETraceSplineOptionType result;
			if (!ETraceSplineOptionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETraceSplineOptionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CAAA RID: 51882 RVA: 0x001DD4F9 File Offset: 0x001DB6F9
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

		// Token: 0x0600CAAB RID: 51883 RVA: 0x001DD532 File Offset: 0x001DB732
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Open",
				"Close"
			};
		}

		// Token: 0x0600CAAC RID: 51884 RVA: 0x001DD54A File Offset: 0x001DB74A
		public static ETraceSplineOptionType[] GetValues()
		{
			return new ETraceSplineOptionType[]
			{
				ETraceSplineOptionType.Open,
				ETraceSplineOptionType.Close
			};
		}

		// Token: 0x0600CAAD RID: 51885 RVA: 0x001DD556 File Offset: 0x001DB756
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
