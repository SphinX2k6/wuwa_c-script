using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025A6 RID: 9638
	public static class EFadeBackgroundTypeExtensions
	{
		// Token: 0x0600D0C5 RID: 53445 RVA: 0x001E4078 File Offset: 0x001E2278
		public static string ToEnumString(this EFadeBackgroundType value)
		{
			string result;
			switch (value)
			{
			case EFadeBackgroundType.Spine:
				result = "Spine";
				break;
			case EFadeBackgroundType.BackgroundImage:
				result = "BackgroundImage";
				break;
			case EFadeBackgroundType.UiPrefab:
				result = "UiPrefab";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D0C6 RID: 53446 RVA: 0x001E40C0 File Offset: 0x001E22C0
		public static EFadeBackgroundType FromString(string name)
		{
			EFadeBackgroundType result;
			if (!EFadeBackgroundTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFadeBackgroundType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D0C7 RID: 53447 RVA: 0x001E40EC File Offset: 0x001E22EC
		public static bool TryFromString(string name, out EFadeBackgroundType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EFadeBackgroundType.Spine;
				return false;
			}
			if (name == "Spine")
			{
				value = EFadeBackgroundType.Spine;
				return true;
			}
			if (name == "BackgroundImage")
			{
				value = EFadeBackgroundType.BackgroundImage;
				return true;
			}
			if (!(name == "UiPrefab"))
			{
				value = EFadeBackgroundType.Spine;
				return false;
			}
			value = EFadeBackgroundType.UiPrefab;
			return true;
		}

		// Token: 0x0600D0C8 RID: 53448 RVA: 0x001E4142 File Offset: 0x001E2342
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Spine",
				"BackgroundImage",
				"UiPrefab"
			};
		}

		// Token: 0x0600D0C9 RID: 53449 RVA: 0x001E4162 File Offset: 0x001E2362
		public static EFadeBackgroundType[] GetValues()
		{
			return new EFadeBackgroundType[]
			{
				EFadeBackgroundType.Spine,
				EFadeBackgroundType.BackgroundImage,
				EFadeBackgroundType.UiPrefab
			};
		}

		// Token: 0x0600D0CA RID: 53450 RVA: 0x001E4172 File Offset: 0x001E2372
		public static string[] GetNames()
		{
			return new string[]
			{
				"Spine",
				"BackgroundImage",
				"UiPrefab"
			};
		}
	}
}
