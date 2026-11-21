using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002564 RID: 9572
	public static class ECustomScreenTypeExtensions
	{
		// Token: 0x0600CF9C RID: 53148 RVA: 0x001E1734 File Offset: 0x001DF934
		public static string ToEnumString(this ECustomScreenType value)
		{
			string result;
			switch (value)
			{
			case ECustomScreenType.Spine:
				result = "Spine";
				break;
			case ECustomScreenType.BackgroundImage:
				result = "BackgroundImage";
				break;
			case ECustomScreenType.Loading:
				result = "Loading";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600CF9D RID: 53149 RVA: 0x001E177C File Offset: 0x001DF97C
		public static ECustomScreenType FromString(string name)
		{
			ECustomScreenType result;
			if (!ECustomScreenTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECustomScreenType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CF9E RID: 53150 RVA: 0x001E17A8 File Offset: 0x001DF9A8
		public static bool TryFromString(string name, out ECustomScreenType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ECustomScreenType.Spine;
				return false;
			}
			if (name == "Spine")
			{
				value = ECustomScreenType.Spine;
				return true;
			}
			if (name == "BackgroundImage")
			{
				value = ECustomScreenType.BackgroundImage;
				return true;
			}
			if (!(name == "Loading"))
			{
				value = ECustomScreenType.Spine;
				return false;
			}
			value = ECustomScreenType.Loading;
			return true;
		}

		// Token: 0x0600CF9F RID: 53151 RVA: 0x001E17FE File Offset: 0x001DF9FE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Spine",
				"BackgroundImage",
				"Loading"
			};
		}

		// Token: 0x0600CFA0 RID: 53152 RVA: 0x001E181E File Offset: 0x001DFA1E
		public static ECustomScreenType[] GetValues()
		{
			return new ECustomScreenType[]
			{
				ECustomScreenType.Spine,
				ECustomScreenType.BackgroundImage,
				ECustomScreenType.Loading
			};
		}

		// Token: 0x0600CFA1 RID: 53153 RVA: 0x001E182E File Offset: 0x001DFA2E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Spine",
				"BackgroundImage",
				"Loading"
			};
		}
	}
}
