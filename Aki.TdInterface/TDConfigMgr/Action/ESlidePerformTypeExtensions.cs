using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026BE RID: 9918
	public static class ESlidePerformTypeExtensions
	{
		// Token: 0x0600D5B1 RID: 54705 RVA: 0x001F0E20 File Offset: 0x001EF020
		public static string ToEnumString(this ESlidePerformType value)
		{
			string result;
			if (value == ESlidePerformType.SlopeSlide)
			{
				result = "SlopeSlide";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D5B2 RID: 54706 RVA: 0x001F0E48 File Offset: 0x001EF048
		public static ESlidePerformType FromString(string name)
		{
			ESlidePerformType result;
			if (!ESlidePerformTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESlidePerformType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D5B3 RID: 54707 RVA: 0x001F0E71 File Offset: 0x001EF071
		public static bool TryFromString(string name, out ESlidePerformType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESlidePerformType.SlopeSlide;
				return false;
			}
			if (name == "SlopeSlide")
			{
				value = ESlidePerformType.SlopeSlide;
				return true;
			}
			value = ESlidePerformType.SlopeSlide;
			return false;
		}

		// Token: 0x0600D5B4 RID: 54708 RVA: 0x001F0E96 File Offset: 0x001EF096
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SlopeSlide"
			};
		}

		// Token: 0x0600D5B5 RID: 54709 RVA: 0x001F0EA6 File Offset: 0x001EF0A6
		public static ESlidePerformType[] GetValues()
		{
			return new ESlidePerformType[1];
		}

		// Token: 0x0600D5B6 RID: 54710 RVA: 0x001F0EAE File Offset: 0x001EF0AE
		public static string[] GetNames()
		{
			return new string[]
			{
				"SlopeSlide"
			};
		}
	}
}
