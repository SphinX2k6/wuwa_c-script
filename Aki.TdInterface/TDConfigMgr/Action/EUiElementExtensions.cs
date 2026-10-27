using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200248F RID: 9359
	public static class EUiElementExtensions
	{
		// Token: 0x0600CB02 RID: 51970 RVA: 0x001DE3D4 File Offset: 0x001DC5D4
		public static string ToEnumString(this EUiElement value)
		{
			string result;
			if (value == EUiElement.Guide)
			{
				result = "Guide";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600CB03 RID: 51971 RVA: 0x001DE3FC File Offset: 0x001DC5FC
		public static EUiElement FromString(string name)
		{
			EUiElement result;
			if (!EUiElementExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EUiElement 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CB04 RID: 51972 RVA: 0x001DE425 File Offset: 0x001DC625
		public static bool TryFromString(string name, out EUiElement value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EUiElement.Guide;
				return false;
			}
			if (name == "Guide")
			{
				value = EUiElement.Guide;
				return true;
			}
			value = EUiElement.Guide;
			return false;
		}

		// Token: 0x0600CB05 RID: 51973 RVA: 0x001DE44A File Offset: 0x001DC64A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Guide"
			};
		}

		// Token: 0x0600CB06 RID: 51974 RVA: 0x001DE45A File Offset: 0x001DC65A
		public static EUiElement[] GetValues()
		{
			return new EUiElement[1];
		}

		// Token: 0x0600CB07 RID: 51975 RVA: 0x001DE462 File Offset: 0x001DC662
		public static string[] GetNames()
		{
			return new string[]
			{
				"Guide"
			};
		}
	}
}
