using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200241F RID: 9247
	public static class ESlidePerformTypeExtensions
	{
		// Token: 0x0600C90A RID: 51466 RVA: 0x001D714C File Offset: 0x001D534C
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

		// Token: 0x0600C90B RID: 51467 RVA: 0x001D7174 File Offset: 0x001D5374
		public static ESlidePerformType FromString(string name)
		{
			ESlidePerformType result;
			if (!ESlidePerformTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESlidePerformType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C90C RID: 51468 RVA: 0x001D719D File Offset: 0x001D539D
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

		// Token: 0x0600C90D RID: 51469 RVA: 0x001D71C2 File Offset: 0x001D53C2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SlopeSlide"
			};
		}

		// Token: 0x0600C90E RID: 51470 RVA: 0x001D71D2 File Offset: 0x001D53D2
		public static ESlidePerformType[] GetValues()
		{
			return new ESlidePerformType[1];
		}

		// Token: 0x0600C90F RID: 51471 RVA: 0x001D71DA File Offset: 0x001D53DA
		public static string[] GetNames()
		{
			return new string[]
			{
				"SlopeSlide"
			};
		}
	}
}
