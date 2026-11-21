using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002726 RID: 10022
	public static class ETransitionPopupStyleTypeExtensions
	{
		// Token: 0x0600D785 RID: 55173 RVA: 0x001F7B1C File Offset: 0x001F5D1C
		public static string ToEnumString(this ETransitionPopupStyleType value)
		{
			string result;
			switch (value)
			{
			case ETransitionPopupStyleType.LeftTopTip:
				result = "LeftTopTip";
				break;
			case ETransitionPopupStyleType.LeftBottomTransition:
				result = "LeftBottomTransition";
				break;
			case ETransitionPopupStyleType.ArtText:
				result = "ArtText";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D786 RID: 55174 RVA: 0x001F7B64 File Offset: 0x001F5D64
		public static ETransitionPopupStyleType FromString(string name)
		{
			ETransitionPopupStyleType result;
			if (!ETransitionPopupStyleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETransitionPopupStyleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D787 RID: 55175 RVA: 0x001F7B90 File Offset: 0x001F5D90
		public static bool TryFromString(string name, out ETransitionPopupStyleType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETransitionPopupStyleType.LeftTopTip;
				return false;
			}
			if (name == "LeftTopTip")
			{
				value = ETransitionPopupStyleType.LeftTopTip;
				return true;
			}
			if (name == "LeftBottomTransition")
			{
				value = ETransitionPopupStyleType.LeftBottomTransition;
				return true;
			}
			if (!(name == "ArtText"))
			{
				value = ETransitionPopupStyleType.LeftTopTip;
				return false;
			}
			value = ETransitionPopupStyleType.ArtText;
			return true;
		}

		// Token: 0x0600D788 RID: 55176 RVA: 0x001F7BE6 File Offset: 0x001F5DE6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LeftTopTip",
				"LeftBottomTransition",
				"ArtText"
			};
		}

		// Token: 0x0600D789 RID: 55177 RVA: 0x001F7C06 File Offset: 0x001F5E06
		public static ETransitionPopupStyleType[] GetValues()
		{
			return new ETransitionPopupStyleType[]
			{
				ETransitionPopupStyleType.LeftTopTip,
				ETransitionPopupStyleType.LeftBottomTransition,
				ETransitionPopupStyleType.ArtText
			};
		}

		// Token: 0x0600D78A RID: 55178 RVA: 0x001F7C16 File Offset: 0x001F5E16
		public static string[] GetNames()
		{
			return new string[]
			{
				"LeftTopTip",
				"LeftBottomTransition",
				"ArtText"
			};
		}
	}
}
