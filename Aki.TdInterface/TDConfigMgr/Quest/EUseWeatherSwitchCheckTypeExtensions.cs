using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012B6 RID: 4790
	public static class EUseWeatherSwitchCheckTypeExtensions
	{
		// Token: 0x06006BDA RID: 27610 RVA: 0x001039E8 File Offset: 0x00101BE8
		public static string ToEnumString(this EUseWeatherSwitchCheckType value)
		{
			string result;
			if (value != EUseWeatherSwitchCheckType.SpecifiedWeather)
			{
				if (value != EUseWeatherSwitchCheckType.AnyWeather)
				{
					result = value.ToString();
				}
				else
				{
					result = "AnyWeather";
				}
			}
			else
			{
				result = "SpecifiedWeather";
			}
			return result;
		}

		// Token: 0x06006BDB RID: 27611 RVA: 0x00103A20 File Offset: 0x00101C20
		public static EUseWeatherSwitchCheckType FromString(string name)
		{
			EUseWeatherSwitchCheckType result;
			if (!EUseWeatherSwitchCheckTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EUseWeatherSwitchCheckType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006BDC RID: 27612 RVA: 0x00103A49 File Offset: 0x00101C49
		public static bool TryFromString(string name, out EUseWeatherSwitchCheckType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EUseWeatherSwitchCheckType.SpecifiedWeather;
				return false;
			}
			if (name == "SpecifiedWeather")
			{
				value = EUseWeatherSwitchCheckType.SpecifiedWeather;
				return true;
			}
			if (!(name == "AnyWeather"))
			{
				value = EUseWeatherSwitchCheckType.SpecifiedWeather;
				return false;
			}
			value = EUseWeatherSwitchCheckType.AnyWeather;
			return true;
		}

		// Token: 0x06006BDD RID: 27613 RVA: 0x00103A82 File Offset: 0x00101C82
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SpecifiedWeather",
				"AnyWeather"
			};
		}

		// Token: 0x06006BDE RID: 27614 RVA: 0x00103A9A File Offset: 0x00101C9A
		public static EUseWeatherSwitchCheckType[] GetValues()
		{
			return new EUseWeatherSwitchCheckType[]
			{
				EUseWeatherSwitchCheckType.SpecifiedWeather,
				EUseWeatherSwitchCheckType.AnyWeather
			};
		}

		// Token: 0x06006BDF RID: 27615 RVA: 0x00103AA6 File Offset: 0x00101CA6
		public static string[] GetNames()
		{
			return new string[]
			{
				"SpecifiedWeather",
				"AnyWeather"
			};
		}
	}
}
