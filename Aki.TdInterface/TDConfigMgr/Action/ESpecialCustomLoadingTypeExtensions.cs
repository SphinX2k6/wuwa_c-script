using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026C2 RID: 9922
	public static class ESpecialCustomLoadingTypeExtensions
	{
		// Token: 0x0600D5C3 RID: 54723 RVA: 0x001F1010 File Offset: 0x001EF210
		public static string ToEnumString(this ESpecialCustomLoadingType value)
		{
			string result;
			if (value == ESpecialCustomLoadingType.HonamiStory)
			{
				result = "HonamiStory";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D5C4 RID: 54724 RVA: 0x001F1038 File Offset: 0x001EF238
		public static ESpecialCustomLoadingType FromString(string name)
		{
			ESpecialCustomLoadingType result;
			if (!ESpecialCustomLoadingTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESpecialCustomLoadingType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D5C5 RID: 54725 RVA: 0x001F1061 File Offset: 0x001EF261
		public static bool TryFromString(string name, out ESpecialCustomLoadingType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESpecialCustomLoadingType.HonamiStory;
				return false;
			}
			if (name == "HonamiStory")
			{
				value = ESpecialCustomLoadingType.HonamiStory;
				return true;
			}
			value = ESpecialCustomLoadingType.HonamiStory;
			return false;
		}

		// Token: 0x0600D5C6 RID: 54726 RVA: 0x001F1086 File Offset: 0x001EF286
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"HonamiStory"
			};
		}

		// Token: 0x0600D5C7 RID: 54727 RVA: 0x001F1096 File Offset: 0x001EF296
		public static ESpecialCustomLoadingType[] GetValues()
		{
			return new ESpecialCustomLoadingType[1];
		}

		// Token: 0x0600D5C8 RID: 54728 RVA: 0x001F109E File Offset: 0x001EF29E
		public static string[] GetNames()
		{
			return new string[]
			{
				"HonamiStory"
			};
		}
	}
}
