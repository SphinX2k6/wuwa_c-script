using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A1D RID: 2589
	public static class EIndependentSystemRewardTypeExtensions
	{
		// Token: 0x06003995 RID: 14741 RVA: 0x00095188 File Offset: 0x00093388
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

		// Token: 0x06003996 RID: 14742 RVA: 0x000951B0 File Offset: 0x000933B0
		public static EIndependentSystemRewardType FromString(string name)
		{
			EIndependentSystemRewardType result;
			if (!EIndependentSystemRewardTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EIndependentSystemRewardType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003997 RID: 14743 RVA: 0x000951D9 File Offset: 0x000933D9
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

		// Token: 0x06003998 RID: 14744 RVA: 0x000951FE File Offset: 0x000933FE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DarkTide"
			};
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x0009520E File Offset: 0x0009340E
		public static EIndependentSystemRewardType[] GetValues()
		{
			return new EIndependentSystemRewardType[1];
		}

		// Token: 0x0600399A RID: 14746 RVA: 0x00095216 File Offset: 0x00093416
		public static string[] GetNames()
		{
			return new string[]
			{
				"DarkTide"
			};
		}
	}
}
