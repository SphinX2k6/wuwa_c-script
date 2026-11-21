using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025AA RID: 9642
	public static class EFadeInScreenShowTypeExtensions
	{
		// Token: 0x0600D0D7 RID: 53463 RVA: 0x001E42AC File Offset: 0x001E24AC
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

		// Token: 0x0600D0D8 RID: 53464 RVA: 0x001E42E4 File Offset: 0x001E24E4
		public static EFadeInScreenShowType FromString(string name)
		{
			EFadeInScreenShowType result;
			if (!EFadeInScreenShowTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFadeInScreenShowType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D0D9 RID: 53465 RVA: 0x001E430D File Offset: 0x001E250D
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

		// Token: 0x0600D0DA RID: 53466 RVA: 0x001E4346 File Offset: 0x001E2546
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"White",
				"Black"
			};
		}

		// Token: 0x0600D0DB RID: 53467 RVA: 0x001E435E File Offset: 0x001E255E
		public static EFadeInScreenShowType[] GetValues()
		{
			return new EFadeInScreenShowType[]
			{
				EFadeInScreenShowType.White,
				EFadeInScreenShowType.Black
			};
		}

		// Token: 0x0600D0DC RID: 53468 RVA: 0x001E436A File Offset: 0x001E256A
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
