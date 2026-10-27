using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000930 RID: 2352
	public static class EElementalWellEntryTypeExtensions
	{
		// Token: 0x06003509 RID: 13577 RVA: 0x0008A83C File Offset: 0x00088A3C
		public static string ToEnumString(this EElementalWellEntryType value)
		{
			string result;
			if (value != EElementalWellEntryType.Entry)
			{
				if (value != EElementalWellEntryType.Exit)
				{
					result = value.ToString();
				}
				else
				{
					result = "Exit";
				}
			}
			else
			{
				result = "Entry";
			}
			return result;
		}

		// Token: 0x0600350A RID: 13578 RVA: 0x0008A874 File Offset: 0x00088A74
		public static EElementalWellEntryType FromString(string name)
		{
			EElementalWellEntryType result;
			if (!EElementalWellEntryTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EElementalWellEntryType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600350B RID: 13579 RVA: 0x0008A89D File Offset: 0x00088A9D
		public static bool TryFromString(string name, out EElementalWellEntryType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EElementalWellEntryType.Entry;
				return false;
			}
			if (name == "Entry")
			{
				value = EElementalWellEntryType.Entry;
				return true;
			}
			if (!(name == "Exit"))
			{
				value = EElementalWellEntryType.Entry;
				return false;
			}
			value = EElementalWellEntryType.Exit;
			return true;
		}

		// Token: 0x0600350C RID: 13580 RVA: 0x0008A8D6 File Offset: 0x00088AD6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Entry",
				"Exit"
			};
		}

		// Token: 0x0600350D RID: 13581 RVA: 0x0008A8EE File Offset: 0x00088AEE
		public static EElementalWellEntryType[] GetValues()
		{
			return new EElementalWellEntryType[]
			{
				EElementalWellEntryType.Entry,
				EElementalWellEntryType.Exit
			};
		}

		// Token: 0x0600350E RID: 13582 RVA: 0x0008A8FA File Offset: 0x00088AFA
		public static string[] GetNames()
		{
			return new string[]
			{
				"Entry",
				"Exit"
			};
		}
	}
}
