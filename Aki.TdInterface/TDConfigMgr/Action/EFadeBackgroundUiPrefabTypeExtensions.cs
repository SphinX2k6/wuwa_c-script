using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025A8 RID: 9640
	public static class EFadeBackgroundUiPrefabTypeExtensions
	{
		// Token: 0x0600D0CE RID: 53454 RVA: 0x001E41D0 File Offset: 0x001E23D0
		public static string ToEnumString(this EFadeBackgroundUiPrefabType value)
		{
			string result;
			if (value == EFadeBackgroundUiPrefabType.BlackScreenWhiteText)
			{
				result = "BlackScreenWhiteText";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D0CF RID: 53455 RVA: 0x001E41F8 File Offset: 0x001E23F8
		public static EFadeBackgroundUiPrefabType FromString(string name)
		{
			EFadeBackgroundUiPrefabType result;
			if (!EFadeBackgroundUiPrefabTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFadeBackgroundUiPrefabType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D0D0 RID: 53456 RVA: 0x001E4221 File Offset: 0x001E2421
		public static bool TryFromString(string name, out EFadeBackgroundUiPrefabType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EFadeBackgroundUiPrefabType.BlackScreenWhiteText;
				return false;
			}
			if (name == "BlackScreenWhiteText")
			{
				value = EFadeBackgroundUiPrefabType.BlackScreenWhiteText;
				return true;
			}
			value = EFadeBackgroundUiPrefabType.BlackScreenWhiteText;
			return false;
		}

		// Token: 0x0600D0D1 RID: 53457 RVA: 0x001E4246 File Offset: 0x001E2446
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BlackScreenWhiteText"
			};
		}

		// Token: 0x0600D0D2 RID: 53458 RVA: 0x001E4256 File Offset: 0x001E2456
		public static EFadeBackgroundUiPrefabType[] GetValues()
		{
			return new EFadeBackgroundUiPrefabType[1];
		}

		// Token: 0x0600D0D3 RID: 53459 RVA: 0x001E425E File Offset: 0x001E245E
		public static string[] GetNames()
		{
			return new string[]
			{
				"BlackScreenWhiteText"
			};
		}
	}
}
