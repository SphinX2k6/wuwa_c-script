using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024A5 RID: 9381
	public static class EVisualNovelBlackScreenTypeExtensions
	{
		// Token: 0x0600CB65 RID: 52069 RVA: 0x001DF0B0 File Offset: 0x001DD2B0
		public static string ToEnumString(this EVisualNovelBlackScreenType value)
		{
			string result;
			if (value != EVisualNovelBlackScreenType.Black)
			{
				if (value != EVisualNovelBlackScreenType.White)
				{
					result = value.ToString();
				}
				else
				{
					result = "White";
				}
			}
			else
			{
				result = "Black";
			}
			return result;
		}

		// Token: 0x0600CB66 RID: 52070 RVA: 0x001DF0E8 File Offset: 0x001DD2E8
		public static EVisualNovelBlackScreenType FromString(string name)
		{
			EVisualNovelBlackScreenType result;
			if (!EVisualNovelBlackScreenTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelBlackScreenType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CB67 RID: 52071 RVA: 0x001DF111 File Offset: 0x001DD311
		public static bool TryFromString(string name, out EVisualNovelBlackScreenType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EVisualNovelBlackScreenType.Black;
				return false;
			}
			if (name == "Black")
			{
				value = EVisualNovelBlackScreenType.Black;
				return true;
			}
			if (!(name == "White"))
			{
				value = EVisualNovelBlackScreenType.Black;
				return false;
			}
			value = EVisualNovelBlackScreenType.White;
			return true;
		}

		// Token: 0x0600CB68 RID: 52072 RVA: 0x001DF14A File Offset: 0x001DD34A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Black",
				"White"
			};
		}

		// Token: 0x0600CB69 RID: 52073 RVA: 0x001DF162 File Offset: 0x001DD362
		public static EVisualNovelBlackScreenType[] GetValues()
		{
			return new EVisualNovelBlackScreenType[]
			{
				EVisualNovelBlackScreenType.Black,
				EVisualNovelBlackScreenType.White
			};
		}

		// Token: 0x0600CB6A RID: 52074 RVA: 0x001DF16E File Offset: 0x001DD36E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Black",
				"White"
			};
		}
	}
}
