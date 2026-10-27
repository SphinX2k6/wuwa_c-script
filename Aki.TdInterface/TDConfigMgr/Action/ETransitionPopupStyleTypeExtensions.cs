using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002483 RID: 9347
	public static class ETransitionPopupStyleTypeExtensions
	{
		// Token: 0x0600CACC RID: 51916 RVA: 0x001DD954 File Offset: 0x001DBB54
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

		// Token: 0x0600CACD RID: 51917 RVA: 0x001DD99C File Offset: 0x001DBB9C
		public static ETransitionPopupStyleType FromString(string name)
		{
			ETransitionPopupStyleType result;
			if (!ETransitionPopupStyleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETransitionPopupStyleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CACE RID: 51918 RVA: 0x001DD9C8 File Offset: 0x001DBBC8
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

		// Token: 0x0600CACF RID: 51919 RVA: 0x001DDA1E File Offset: 0x001DBC1E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LeftTopTip",
				"LeftBottomTransition",
				"ArtText"
			};
		}

		// Token: 0x0600CAD0 RID: 51920 RVA: 0x001DDA3E File Offset: 0x001DBC3E
		public static ETransitionPopupStyleType[] GetValues()
		{
			return new ETransitionPopupStyleType[]
			{
				ETransitionPopupStyleType.LeftTopTip,
				ETransitionPopupStyleType.LeftBottomTransition,
				ETransitionPopupStyleType.ArtText
			};
		}

		// Token: 0x0600CAD1 RID: 51921 RVA: 0x001DDA4E File Offset: 0x001DBC4E
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
