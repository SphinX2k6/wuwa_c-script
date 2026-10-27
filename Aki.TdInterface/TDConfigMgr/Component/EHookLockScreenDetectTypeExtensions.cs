using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000968 RID: 2408
	public static class EHookLockScreenDetectTypeExtensions
	{
		// Token: 0x06003605 RID: 13829 RVA: 0x0008D108 File Offset: 0x0008B308
		public static string ToEnumString(this EHookLockScreenDetectType value)
		{
			string result;
			if (value != EHookLockScreenDetectType.CentralEllipse)
			{
				if (value != EHookLockScreenDetectType.FullScreen)
				{
					result = value.ToString();
				}
				else
				{
					result = "FullScreen";
				}
			}
			else
			{
				result = "CentralEllipse";
			}
			return result;
		}

		// Token: 0x06003606 RID: 13830 RVA: 0x0008D140 File Offset: 0x0008B340
		public static EHookLockScreenDetectType FromString(string name)
		{
			EHookLockScreenDetectType result;
			if (!EHookLockScreenDetectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EHookLockScreenDetectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003607 RID: 13831 RVA: 0x0008D169 File Offset: 0x0008B369
		public static bool TryFromString(string name, out EHookLockScreenDetectType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EHookLockScreenDetectType.CentralEllipse;
				return false;
			}
			if (name == "CentralEllipse")
			{
				value = EHookLockScreenDetectType.CentralEllipse;
				return true;
			}
			if (!(name == "FullScreen"))
			{
				value = EHookLockScreenDetectType.CentralEllipse;
				return false;
			}
			value = EHookLockScreenDetectType.FullScreen;
			return true;
		}

		// Token: 0x06003608 RID: 13832 RVA: 0x0008D1A2 File Offset: 0x0008B3A2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CentralEllipse",
				"FullScreen"
			};
		}

		// Token: 0x06003609 RID: 13833 RVA: 0x0008D1BA File Offset: 0x0008B3BA
		public static EHookLockScreenDetectType[] GetValues()
		{
			return new EHookLockScreenDetectType[]
			{
				EHookLockScreenDetectType.CentralEllipse,
				EHookLockScreenDetectType.FullScreen
			};
		}

		// Token: 0x0600360A RID: 13834 RVA: 0x0008D1C6 File Offset: 0x0008B3C6
		public static string[] GetNames()
		{
			return new string[]
			{
				"CentralEllipse",
				"FullScreen"
			};
		}
	}
}
