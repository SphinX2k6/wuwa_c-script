using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002748 RID: 10056
	public static class EVisualNovelBlackScreenTypeExtensions
	{
		// Token: 0x0600D81E RID: 55326 RVA: 0x001F9278 File Offset: 0x001F7478
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

		// Token: 0x0600D81F RID: 55327 RVA: 0x001F92B0 File Offset: 0x001F74B0
		public static EVisualNovelBlackScreenType FromString(string name)
		{
			EVisualNovelBlackScreenType result;
			if (!EVisualNovelBlackScreenTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelBlackScreenType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D820 RID: 55328 RVA: 0x001F92D9 File Offset: 0x001F74D9
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

		// Token: 0x0600D821 RID: 55329 RVA: 0x001F9312 File Offset: 0x001F7512
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Black",
				"White"
			};
		}

		// Token: 0x0600D822 RID: 55330 RVA: 0x001F932A File Offset: 0x001F752A
		public static EVisualNovelBlackScreenType[] GetValues()
		{
			return new EVisualNovelBlackScreenType[]
			{
				EVisualNovelBlackScreenType.Black,
				EVisualNovelBlackScreenType.White
			};
		}

		// Token: 0x0600D823 RID: 55331 RVA: 0x001F9336 File Offset: 0x001F7536
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
