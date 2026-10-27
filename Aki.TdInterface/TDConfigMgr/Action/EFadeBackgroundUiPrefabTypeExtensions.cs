using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002337 RID: 9015
	public static class EFadeBackgroundUiPrefabTypeExtensions
	{
		// Token: 0x0600C4F6 RID: 50422 RVA: 0x001CC118 File Offset: 0x001CA318
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

		// Token: 0x0600C4F7 RID: 50423 RVA: 0x001CC140 File Offset: 0x001CA340
		public static EFadeBackgroundUiPrefabType FromString(string name)
		{
			EFadeBackgroundUiPrefabType result;
			if (!EFadeBackgroundUiPrefabTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFadeBackgroundUiPrefabType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C4F8 RID: 50424 RVA: 0x001CC169 File Offset: 0x001CA369
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

		// Token: 0x0600C4F9 RID: 50425 RVA: 0x001CC18E File Offset: 0x001CA38E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BlackScreenWhiteText"
			};
		}

		// Token: 0x0600C4FA RID: 50426 RVA: 0x001CC19E File Offset: 0x001CA39E
		public static EFadeBackgroundUiPrefabType[] GetValues()
		{
			return new EFadeBackgroundUiPrefabType[1];
		}

		// Token: 0x0600C4FB RID: 50427 RVA: 0x001CC1A6 File Offset: 0x001CA3A6
		public static string[] GetNames()
		{
			return new string[]
			{
				"BlackScreenWhiteText"
			};
		}
	}
}
