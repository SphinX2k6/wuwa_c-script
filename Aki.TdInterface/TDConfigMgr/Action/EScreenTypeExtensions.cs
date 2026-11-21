using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200269E RID: 9886
	public static class EScreenTypeExtensions
	{
		// Token: 0x0600D521 RID: 54561 RVA: 0x001EF304 File Offset: 0x001ED504
		public static string ToEnumString(this EScreenType value)
		{
			string result;
			if (value != EScreenType.Main)
			{
				if (value != EScreenType.Sub)
				{
					result = value.ToString();
				}
				else
				{
					result = "Sub";
				}
			}
			else
			{
				result = "Main";
			}
			return result;
		}

		// Token: 0x0600D522 RID: 54562 RVA: 0x001EF33C File Offset: 0x001ED53C
		public static EScreenType FromString(string name)
		{
			EScreenType result;
			if (!EScreenTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EScreenType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D523 RID: 54563 RVA: 0x001EF365 File Offset: 0x001ED565
		public static bool TryFromString(string name, out EScreenType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EScreenType.Main;
				return false;
			}
			if (name == "Main")
			{
				value = EScreenType.Main;
				return true;
			}
			if (!(name == "Sub"))
			{
				value = EScreenType.Main;
				return false;
			}
			value = EScreenType.Sub;
			return true;
		}

		// Token: 0x0600D524 RID: 54564 RVA: 0x001EF39E File Offset: 0x001ED59E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Main",
				"Sub"
			};
		}

		// Token: 0x0600D525 RID: 54565 RVA: 0x001EF3B6 File Offset: 0x001ED5B6
		public static EScreenType[] GetValues()
		{
			return new EScreenType[]
			{
				EScreenType.Main,
				EScreenType.Sub
			};
		}

		// Token: 0x0600D526 RID: 54566 RVA: 0x001EF3C2 File Offset: 0x001ED5C2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Main",
				"Sub"
			};
		}
	}
}
