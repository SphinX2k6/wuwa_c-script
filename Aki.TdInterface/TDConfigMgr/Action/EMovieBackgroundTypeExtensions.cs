using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200262C RID: 9772
	public static class EMovieBackgroundTypeExtensions
	{
		// Token: 0x0600D320 RID: 54048 RVA: 0x001EAF1C File Offset: 0x001E911C
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

		// Token: 0x0600D321 RID: 54049 RVA: 0x001EAF54 File Offset: 0x001E9154
		public static EMovieBackgroundType FromString(string name)
		{
			EMovieBackgroundType result;
			if (!EMovieBackgroundTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMovieBackgroundType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D322 RID: 54050 RVA: 0x001EAF7D File Offset: 0x001E917D
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

		// Token: 0x0600D323 RID: 54051 RVA: 0x001EAFB6 File Offset: 0x001E91B6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"White",
				"Black"
			};
		}

		// Token: 0x0600D324 RID: 54052 RVA: 0x001EAFCE File Offset: 0x001E91CE
		public static EMovieBackgroundType[] GetValues()
		{
			return new EMovieBackgroundType[]
			{
				EMovieBackgroundType.White,
				EMovieBackgroundType.Black
			};
		}

		// Token: 0x0600D325 RID: 54053 RVA: 0x001EAFDA File Offset: 0x001E91DA
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
