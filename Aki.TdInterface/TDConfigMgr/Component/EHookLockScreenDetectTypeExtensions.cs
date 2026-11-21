using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A1B RID: 2587
	public static class EHookLockScreenDetectTypeExtensions
	{
		// Token: 0x0600398C RID: 14732 RVA: 0x00095074 File Offset: 0x00093274
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

		// Token: 0x0600398D RID: 14733 RVA: 0x000950AC File Offset: 0x000932AC
		public static EHookLockScreenDetectType FromString(string name)
		{
			EHookLockScreenDetectType result;
			if (!EHookLockScreenDetectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EHookLockScreenDetectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600398E RID: 14734 RVA: 0x000950D5 File Offset: 0x000932D5
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

		// Token: 0x0600398F RID: 14735 RVA: 0x0009510E File Offset: 0x0009330E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CentralEllipse",
				"FullScreen"
			};
		}

		// Token: 0x06003990 RID: 14736 RVA: 0x00095126 File Offset: 0x00093326
		public static EHookLockScreenDetectType[] GetValues()
		{
			return new EHookLockScreenDetectType[]
			{
				EHookLockScreenDetectType.CentralEllipse,
				EHookLockScreenDetectType.FullScreen
			};
		}

		// Token: 0x06003991 RID: 14737 RVA: 0x00095132 File Offset: 0x00093332
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
