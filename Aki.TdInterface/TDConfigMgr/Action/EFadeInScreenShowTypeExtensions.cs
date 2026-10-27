using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002339 RID: 9017
	public static class EFadeInScreenShowTypeExtensions
	{
		// Token: 0x0600C4FF RID: 50431 RVA: 0x001CC1F4 File Offset: 0x001CA3F4
		public static string ToEnumString(this EFadeInScreenShowType value)
		{
			string result;
			if (value != EFadeInScreenShowType.White)
			{
				if (value != EFadeInScreenShowType.Black)
				{
					result = value.ToString();
				}
				else
				{
					result = "Black";
				}
			}
			else
			{
				result = "White";
			}
			return result;
		}

		// Token: 0x0600C500 RID: 50432 RVA: 0x001CC22C File Offset: 0x001CA42C
		public static EFadeInScreenShowType FromString(string name)
		{
			EFadeInScreenShowType result;
			if (!EFadeInScreenShowTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFadeInScreenShowType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C501 RID: 50433 RVA: 0x001CC255 File Offset: 0x001CA455
		public static bool TryFromString(string name, out EFadeInScreenShowType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EFadeInScreenShowType.White;
				return false;
			}
			if (name == "White")
			{
				value = EFadeInScreenShowType.White;
				return true;
			}
			if (!(name == "Black"))
			{
				value = EFadeInScreenShowType.White;
				return false;
			}
			value = EFadeInScreenShowType.Black;
			return true;
		}

		// Token: 0x0600C502 RID: 50434 RVA: 0x001CC28E File Offset: 0x001CA48E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"White",
				"Black"
			};
		}

		// Token: 0x0600C503 RID: 50435 RVA: 0x001CC2A6 File Offset: 0x001CA4A6
		public static EFadeInScreenShowType[] GetValues()
		{
			return new EFadeInScreenShowType[]
			{
				EFadeInScreenShowType.White,
				EFadeInScreenShowType.Black
			};
		}

		// Token: 0x0600C504 RID: 50436 RVA: 0x001CC2B2 File Offset: 0x001CA4B2
		public static string[] GetNames()
		{
			return new string[]
			{
				"White",
				"Black"
			};
		}
	}
}
