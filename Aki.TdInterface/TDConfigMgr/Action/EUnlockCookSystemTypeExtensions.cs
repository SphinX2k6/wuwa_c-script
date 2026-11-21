using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002738 RID: 10040
	public static class EUnlockCookSystemTypeExtensions
	{
		// Token: 0x0600D7D6 RID: 55254 RVA: 0x001F88E4 File Offset: 0x001F6AE4
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

		// Token: 0x0600D7D7 RID: 55255 RVA: 0x001F890C File Offset: 0x001F6B0C
		public static EUnlockCookSystemType FromString(string name)
		{
			EUnlockCookSystemType result;
			if (!EUnlockCookSystemTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EUnlockCookSystemType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D7D8 RID: 55256 RVA: 0x001F8935 File Offset: 0x001F6B35
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

		// Token: 0x0600D7D9 RID: 55257 RVA: 0x001F895A File Offset: 0x001F6B5A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"UnlockCookBook"
			};
		}

		// Token: 0x0600D7DA RID: 55258 RVA: 0x001F896A File Offset: 0x001F6B6A
		public static EUnlockCookSystemType[] GetValues()
		{
			return new EUnlockCookSystemType[1];
		}

		// Token: 0x0600D7DB RID: 55259 RVA: 0x001F8972 File Offset: 0x001F6B72
		public static string[] GetNames()
		{
			return new string[]
			{
				"UnlockCookBook"
			};
		}
	}
}
