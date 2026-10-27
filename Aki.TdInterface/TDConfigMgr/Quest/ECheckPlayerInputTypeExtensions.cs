using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200122E RID: 4654
	public static class ECheckPlayerInputTypeExtensions
	{
		// Token: 0x06006976 RID: 26998 RVA: 0x000FB680 File Offset: 0x000F9880
		public static string ToEnumString(this ECheckPlayerInputType value)
		{
			string result;
			if (value == ECheckPlayerInputType.PressButton)
			{
				result = "PressButton";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06006977 RID: 26999 RVA: 0x000FB6A8 File Offset: 0x000F98A8
		public static ECheckPlayerInputType FromString(string name)
		{
			ECheckPlayerInputType result;
			if (!ECheckPlayerInputTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECheckPlayerInputType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006978 RID: 27000 RVA: 0x000FB6D1 File Offset: 0x000F98D1
		public static bool TryFromString(string name, out ECheckPlayerInputType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ECheckPlayerInputType.PressButton;
				return false;
			}
			if (name == "PressButton")
			{
				value = ECheckPlayerInputType.PressButton;
				return true;
			}
			value = ECheckPlayerInputType.PressButton;
			return false;
		}

		// Token: 0x06006979 RID: 27001 RVA: 0x000FB6F6 File Offset: 0x000F98F6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PressButton"
			};
		}

		// Token: 0x0600697A RID: 27002 RVA: 0x000FB706 File Offset: 0x000F9906
		public static ECheckPlayerInputType[] GetValues()
		{
			return new ECheckPlayerInputType[1];
		}

		// Token: 0x0600697B RID: 27003 RVA: 0x000FB70E File Offset: 0x000F990E
		public static string[] GetNames()
		{
			return new string[]
			{
				"PressButton"
			};
		}
	}
}
