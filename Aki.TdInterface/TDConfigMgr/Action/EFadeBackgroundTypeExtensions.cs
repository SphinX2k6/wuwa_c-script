using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002335 RID: 9013
	public static class EFadeBackgroundTypeExtensions
	{
		// Token: 0x0600C4ED RID: 50413 RVA: 0x001CBFC0 File Offset: 0x001CA1C0
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

		// Token: 0x0600C4EE RID: 50414 RVA: 0x001CC008 File Offset: 0x001CA208
		public static EFadeBackgroundType FromString(string name)
		{
			EFadeBackgroundType result;
			if (!EFadeBackgroundTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFadeBackgroundType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C4EF RID: 50415 RVA: 0x001CC034 File Offset: 0x001CA234
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

		// Token: 0x0600C4F0 RID: 50416 RVA: 0x001CC08A File Offset: 0x001CA28A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Spine",
				"BackgroundImage",
				"UiPrefab"
			};
		}

		// Token: 0x0600C4F1 RID: 50417 RVA: 0x001CC0AA File Offset: 0x001CA2AA
		public static EFadeBackgroundType[] GetValues()
		{
			return new EFadeBackgroundType[]
			{
				EFadeBackgroundType.Spine,
				EFadeBackgroundType.BackgroundImage,
				EFadeBackgroundType.UiPrefab
			};
		}

		// Token: 0x0600C4F2 RID: 50418 RVA: 0x001CC0BA File Offset: 0x001CA2BA
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
