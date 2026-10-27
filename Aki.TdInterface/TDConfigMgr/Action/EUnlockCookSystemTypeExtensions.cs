using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002495 RID: 9365
	public static class EUnlockCookSystemTypeExtensions
	{
		// Token: 0x0600CB1D RID: 51997 RVA: 0x001DE71C File Offset: 0x001DC91C
		public static string ToEnumString(this EUnlockCookSystemType value)
		{
			string result;
			if (value == EUnlockCookSystemType.UnlockCookBook)
			{
				result = "UnlockCookBook";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600CB1E RID: 51998 RVA: 0x001DE744 File Offset: 0x001DC944
		public static EUnlockCookSystemType FromString(string name)
		{
			EUnlockCookSystemType result;
			if (!EUnlockCookSystemTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EUnlockCookSystemType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CB1F RID: 51999 RVA: 0x001DE76D File Offset: 0x001DC96D
		public static bool TryFromString(string name, out EUnlockCookSystemType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EUnlockCookSystemType.UnlockCookBook;
				return false;
			}
			if (name == "UnlockCookBook")
			{
				value = EUnlockCookSystemType.UnlockCookBook;
				return true;
			}
			value = EUnlockCookSystemType.UnlockCookBook;
			return false;
		}

		// Token: 0x0600CB20 RID: 52000 RVA: 0x001DE792 File Offset: 0x001DC992
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"UnlockCookBook"
			};
		}

		// Token: 0x0600CB21 RID: 52001 RVA: 0x001DE7A2 File Offset: 0x001DC9A2
		public static EUnlockCookSystemType[] GetValues()
		{
			return new EUnlockCookSystemType[1];
		}

		// Token: 0x0600CB22 RID: 52002 RVA: 0x001DE7AA File Offset: 0x001DC9AA
		public static string[] GetNames()
		{
			return new string[]
			{
				"UnlockCookBook"
			};
		}
	}
}
