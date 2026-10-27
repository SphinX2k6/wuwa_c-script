using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000924 RID: 2340
	public static class EDollGrabShowcaseBelongTypeExtensions
	{
		// Token: 0x060034D3 RID: 13523 RVA: 0x0008A228 File Offset: 0x00088428
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

		// Token: 0x060034D4 RID: 13524 RVA: 0x0008A250 File Offset: 0x00088450
		public static EDollGrabShowcaseBelongType FromString(string name)
		{
			EDollGrabShowcaseBelongType result;
			if (!EDollGrabShowcaseBelongTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDollGrabShowcaseBelongType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060034D5 RID: 13525 RVA: 0x0008A279 File Offset: 0x00088479
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

		// Token: 0x060034D6 RID: 13526 RVA: 0x0008A29E File Offset: 0x0008849E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LandOfXuanfang"
			};
		}

		// Token: 0x060034D7 RID: 13527 RVA: 0x0008A2AE File Offset: 0x000884AE
		public static EDollGrabShowcaseBelongType[] GetValues()
		{
			return new EDollGrabShowcaseBelongType[1];
		}

		// Token: 0x060034D8 RID: 13528 RVA: 0x0008A2B6 File Offset: 0x000884B6
		public static string[] GetNames()
		{
			return new string[]
			{
				"LandOfXuanfang"
			};
		}
	}
}
