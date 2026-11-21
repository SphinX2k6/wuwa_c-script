using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002732 RID: 10034
	public static class EUiElementExtensions
	{
		// Token: 0x0600D7BB RID: 55227 RVA: 0x001F859C File Offset: 0x001F679C
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

		// Token: 0x0600D7BC RID: 55228 RVA: 0x001F85C4 File Offset: 0x001F67C4
		public static EUiElement FromString(string name)
		{
			EUiElement result;
			if (!EUiElementExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EUiElement 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D7BD RID: 55229 RVA: 0x001F85ED File Offset: 0x001F67ED
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

		// Token: 0x0600D7BE RID: 55230 RVA: 0x001F8612 File Offset: 0x001F6812
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Guide"
			};
		}

		// Token: 0x0600D7BF RID: 55231 RVA: 0x001F8622 File Offset: 0x001F6822
		public static EUiElement[] GetValues()
		{
			return new EUiElement[1];
		}

		// Token: 0x0600D7C0 RID: 55232 RVA: 0x001F862A File Offset: 0x001F682A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Guide"
			};
		}
	}
}
