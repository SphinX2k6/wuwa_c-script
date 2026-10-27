using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200096A RID: 2410
	public static class EIndependentSystemRewardTypeExtensions
	{
		// Token: 0x0600360E RID: 13838 RVA: 0x0008D21C File Offset: 0x0008B41C
		public static string ToEnumString(this EIndependentSystemRewardType value)
		{
			string result;
			if (value == EIndependentSystemRewardType.DarkTide)
			{
				result = "DarkTide";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600360F RID: 13839 RVA: 0x0008D244 File Offset: 0x0008B444
		public static EIndependentSystemRewardType FromString(string name)
		{
			EIndependentSystemRewardType result;
			if (!EIndependentSystemRewardTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EIndependentSystemRewardType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003610 RID: 13840 RVA: 0x0008D26D File Offset: 0x0008B46D
		public static bool TryFromString(string name, out EIndependentSystemRewardType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EIndependentSystemRewardType.DarkTide;
				return false;
			}
			if (name == "DarkTide")
			{
				value = EIndependentSystemRewardType.DarkTide;
				return true;
			}
			value = EIndependentSystemRewardType.DarkTide;
			return false;
		}

		// Token: 0x06003611 RID: 13841 RVA: 0x0008D292 File Offset: 0x0008B492
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DarkTide"
			};
		}

		// Token: 0x06003612 RID: 13842 RVA: 0x0008D2A2 File Offset: 0x0008B4A2
		public static EIndependentSystemRewardType[] GetValues()
		{
			return new EIndependentSystemRewardType[1];
		}

		// Token: 0x06003613 RID: 13843 RVA: 0x0008D2AA File Offset: 0x0008B4AA
		public static string[] GetNames()
		{
			return new string[]
			{
				"DarkTide"
			};
		}
	}
}
