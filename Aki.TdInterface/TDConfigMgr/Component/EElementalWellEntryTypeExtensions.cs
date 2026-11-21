using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009DD RID: 2525
	public static class EElementalWellEntryTypeExtensions
	{
		// Token: 0x06003875 RID: 14453 RVA: 0x000923BC File Offset: 0x000905BC
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

		// Token: 0x06003876 RID: 14454 RVA: 0x000923F4 File Offset: 0x000905F4
		public static EElementalWellEntryType FromString(string name)
		{
			EElementalWellEntryType result;
			if (!EElementalWellEntryTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EElementalWellEntryType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003877 RID: 14455 RVA: 0x0009241D File Offset: 0x0009061D
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

		// Token: 0x06003878 RID: 14456 RVA: 0x00092456 File Offset: 0x00090656
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Entry",
				"Exit"
			};
		}

		// Token: 0x06003879 RID: 14457 RVA: 0x0009246E File Offset: 0x0009066E
		public static EElementalWellEntryType[] GetValues()
		{
			return new EElementalWellEntryType[]
			{
				EElementalWellEntryType.Entry,
				EElementalWellEntryType.Exit
			};
		}

		// Token: 0x0600387A RID: 14458 RVA: 0x0009247A File Offset: 0x0009067A
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
