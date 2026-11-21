using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009D1 RID: 2513
	public static class EDollGrabShowcaseBelongTypeExtensions
	{
		// Token: 0x0600383F RID: 14399 RVA: 0x00091DA8 File Offset: 0x0008FFA8
		public static string ToEnumString(this EDollGrabShowcaseBelongType value)
		{
			string result;
			if (value == EDollGrabShowcaseBelongType.LandOfXuanfang)
			{
				result = "LandOfXuanfang";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x00091DD0 File Offset: 0x0008FFD0
		public static EDollGrabShowcaseBelongType FromString(string name)
		{
			EDollGrabShowcaseBelongType result;
			if (!EDollGrabShowcaseBelongTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDollGrabShowcaseBelongType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003841 RID: 14401 RVA: 0x00091DF9 File Offset: 0x0008FFF9
		public static bool TryFromString(string name, out EDollGrabShowcaseBelongType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDollGrabShowcaseBelongType.LandOfXuanfang;
				return false;
			}
			if (name == "LandOfXuanfang")
			{
				value = EDollGrabShowcaseBelongType.LandOfXuanfang;
				return true;
			}
			value = EDollGrabShowcaseBelongType.LandOfXuanfang;
			return false;
		}

		// Token: 0x06003842 RID: 14402 RVA: 0x00091E1E File Offset: 0x0009001E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LandOfXuanfang"
			};
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x00091E2E File Offset: 0x0009002E
		public static EDollGrabShowcaseBelongType[] GetValues()
		{
			return new EDollGrabShowcaseBelongType[1];
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x00091E36 File Offset: 0x00090036
		public static string[] GetNames()
		{
			return new string[]
			{
				"LandOfXuanfang"
			};
		}
	}
}
