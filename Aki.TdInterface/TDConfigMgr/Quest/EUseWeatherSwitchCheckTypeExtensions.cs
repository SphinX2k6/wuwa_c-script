using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013FC RID: 5116
	public static class EUseWeatherSwitchCheckTypeExtensions
	{
		// Token: 0x06007248 RID: 29256 RVA: 0x001119B0 File Offset: 0x0010FBB0
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

		// Token: 0x06007249 RID: 29257 RVA: 0x001119E8 File Offset: 0x0010FBE8
		public static EUseWeatherSwitchCheckType FromString(string name)
		{
			EUseWeatherSwitchCheckType result;
			if (!EUseWeatherSwitchCheckTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EUseWeatherSwitchCheckType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600724A RID: 29258 RVA: 0x00111A11 File Offset: 0x0010FC11
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

		// Token: 0x0600724B RID: 29259 RVA: 0x00111A4A File Offset: 0x0010FC4A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SpecifiedWeather",
				"AnyWeather"
			};
		}

		// Token: 0x0600724C RID: 29260 RVA: 0x00111A62 File Offset: 0x0010FC62
		public static EUseWeatherSwitchCheckType[] GetValues()
		{
			return new EUseWeatherSwitchCheckType[]
			{
				EUseWeatherSwitchCheckType.SpecifiedWeather,
				EUseWeatherSwitchCheckType.AnyWeather
			};
		}

		// Token: 0x0600724D RID: 29261 RVA: 0x00111A6E File Offset: 0x0010FC6E
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
