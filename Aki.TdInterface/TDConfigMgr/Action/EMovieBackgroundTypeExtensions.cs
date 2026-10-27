using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023A1 RID: 9121
	public static class EMovieBackgroundTypeExtensions
	{
		// Token: 0x0600C6D3 RID: 50899 RVA: 0x001D1D7C File Offset: 0x001CFF7C
		public static string ToEnumString(this EMovieBackgroundType value)
		{
			string result;
			if (value != EMovieBackgroundType.White)
			{
				if (value != EMovieBackgroundType.Black)
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

		// Token: 0x0600C6D4 RID: 50900 RVA: 0x001D1DB4 File Offset: 0x001CFFB4
		public static EMovieBackgroundType FromString(string name)
		{
			EMovieBackgroundType result;
			if (!EMovieBackgroundTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMovieBackgroundType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C6D5 RID: 50901 RVA: 0x001D1DDD File Offset: 0x001CFFDD
		public static bool TryFromString(string name, out EMovieBackgroundType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMovieBackgroundType.White;
				return false;
			}
			if (name == "White")
			{
				value = EMovieBackgroundType.White;
				return true;
			}
			if (!(name == "Black"))
			{
				value = EMovieBackgroundType.White;
				return false;
			}
			value = EMovieBackgroundType.Black;
			return true;
		}

		// Token: 0x0600C6D6 RID: 50902 RVA: 0x001D1E16 File Offset: 0x001D0016
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"White",
				"Black"
			};
		}

		// Token: 0x0600C6D7 RID: 50903 RVA: 0x001D1E2E File Offset: 0x001D002E
		public static EMovieBackgroundType[] GetValues()
		{
			return new EMovieBackgroundType[]
			{
				EMovieBackgroundType.White,
				EMovieBackgroundType.Black
			};
		}

		// Token: 0x0600C6D8 RID: 50904 RVA: 0x001D1E3A File Offset: 0x001D003A
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
