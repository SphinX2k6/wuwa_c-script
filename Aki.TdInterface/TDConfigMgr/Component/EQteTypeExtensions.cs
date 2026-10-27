using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009E6 RID: 2534
	public static class EQteTypeExtensions
	{
		// Token: 0x0600383C RID: 14396 RVA: 0x00091C68 File Offset: 0x0008FE68
		public static string ToEnumString(this EQteType value)
		{
			string result;
			if (value == EQteType.SingleBtn)
			{
				result = "SingleBtn";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x00091C90 File Offset: 0x0008FE90
		public static EQteType FromString(string name)
		{
			EQteType result;
			if (!EQteTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EQteType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x00091CB9 File Offset: 0x0008FEB9
		public static bool TryFromString(string name, out EQteType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EQteType.SingleBtn;
				return false;
			}
			if (name == "SingleBtn")
			{
				value = EQteType.SingleBtn;
				return true;
			}
			value = EQteType.SingleBtn;
			return false;
		}

		// Token: 0x0600383F RID: 14399 RVA: 0x00091CDE File Offset: 0x0008FEDE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SingleBtn"
			};
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x00091CEE File Offset: 0x0008FEEE
		public static EQteType[] GetValues()
		{
			return new EQteType[1];
		}

		// Token: 0x06003841 RID: 14401 RVA: 0x00091CF6 File Offset: 0x0008FEF6
		public static string[] GetNames()
		{
			return new string[]
			{
				"SingleBtn"
			};
		}
	}
}
