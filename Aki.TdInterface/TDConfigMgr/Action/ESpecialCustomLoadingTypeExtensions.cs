using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002423 RID: 9251
	public static class ESpecialCustomLoadingTypeExtensions
	{
		// Token: 0x0600C91C RID: 51484 RVA: 0x001D733C File Offset: 0x001D553C
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

		// Token: 0x0600C91D RID: 51485 RVA: 0x001D7364 File Offset: 0x001D5564
		public static ESpecialCustomLoadingType FromString(string name)
		{
			ESpecialCustomLoadingType result;
			if (!ESpecialCustomLoadingTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESpecialCustomLoadingType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C91E RID: 51486 RVA: 0x001D738D File Offset: 0x001D558D
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

		// Token: 0x0600C91F RID: 51487 RVA: 0x001D73B2 File Offset: 0x001D55B2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"HonamiStory"
			};
		}

		// Token: 0x0600C920 RID: 51488 RVA: 0x001D73C2 File Offset: 0x001D55C2
		public static ESpecialCustomLoadingType[] GetValues()
		{
			return new ESpecialCustomLoadingType[1];
		}

		// Token: 0x0600C921 RID: 51489 RVA: 0x001D73CA File Offset: 0x001D55CA
		public static string[] GetNames()
		{
			return new string[]
			{
				"HonamiStory"
			};
		}
	}
}
