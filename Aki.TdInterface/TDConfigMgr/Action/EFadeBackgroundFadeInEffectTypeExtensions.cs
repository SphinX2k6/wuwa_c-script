using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025A2 RID: 9634
	public static class EFadeBackgroundFadeInEffectTypeExtensions
	{
		// Token: 0x0600D0B3 RID: 53427 RVA: 0x001E3E50 File Offset: 0x001E2050
		public static string ToEnumString(this EFadeBackgroundFadeInEffectType value)
		{
			string result;
			if (value != EFadeBackgroundFadeInEffectType.Black)
			{
				if (value != EFadeBackgroundFadeInEffectType.ScreenEffect)
				{
					result = value.ToString();
				}
				else
				{
					result = "ScreenEffect";
				}
			}
			else
			{
				result = "Black";
			}
			return result;
		}

		// Token: 0x0600D0B4 RID: 53428 RVA: 0x001E3E88 File Offset: 0x001E2088
		public static EFadeBackgroundFadeInEffectType FromString(string name)
		{
			EFadeBackgroundFadeInEffectType result;
			if (!EFadeBackgroundFadeInEffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFadeBackgroundFadeInEffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D0B5 RID: 53429 RVA: 0x001E3EB1 File Offset: 0x001E20B1
		public static bool TryFromString(string name, out EFadeBackgroundFadeInEffectType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EFadeBackgroundFadeInEffectType.Black;
				return false;
			}
			if (name == "Black")
			{
				value = EFadeBackgroundFadeInEffectType.Black;
				return true;
			}
			if (!(name == "ScreenEffect"))
			{
				value = EFadeBackgroundFadeInEffectType.Black;
				return false;
			}
			value = EFadeBackgroundFadeInEffectType.ScreenEffect;
			return true;
		}

		// Token: 0x0600D0B6 RID: 53430 RVA: 0x001E3EEA File Offset: 0x001E20EA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Black",
				"ScreenEffect"
			};
		}

		// Token: 0x0600D0B7 RID: 53431 RVA: 0x001E3F02 File Offset: 0x001E2102
		public static EFadeBackgroundFadeInEffectType[] GetValues()
		{
			return new EFadeBackgroundFadeInEffectType[]
			{
				EFadeBackgroundFadeInEffectType.Black,
				EFadeBackgroundFadeInEffectType.ScreenEffect
			};
		}

		// Token: 0x0600D0B8 RID: 53432 RVA: 0x001E3F0E File Offset: 0x001E210E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Black",
				"ScreenEffect"
			};
		}
	}
}
