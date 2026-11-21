using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025A4 RID: 9636
	public static class EFadeBackgroundFadeOutEffectTypeExtensions
	{
		// Token: 0x0600D0BC RID: 53436 RVA: 0x001E3F64 File Offset: 0x001E2164
		public static string ToEnumString(this EFadeBackgroundFadeOutEffectType value)
		{
			string result;
			if (value != EFadeBackgroundFadeOutEffectType.Black)
			{
				if (value != EFadeBackgroundFadeOutEffectType.ScreenEffect)
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

		// Token: 0x0600D0BD RID: 53437 RVA: 0x001E3F9C File Offset: 0x001E219C
		public static EFadeBackgroundFadeOutEffectType FromString(string name)
		{
			EFadeBackgroundFadeOutEffectType result;
			if (!EFadeBackgroundFadeOutEffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFadeBackgroundFadeOutEffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D0BE RID: 53438 RVA: 0x001E3FC5 File Offset: 0x001E21C5
		public static bool TryFromString(string name, out EFadeBackgroundFadeOutEffectType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EFadeBackgroundFadeOutEffectType.Black;
				return false;
			}
			if (name == "Black")
			{
				value = EFadeBackgroundFadeOutEffectType.Black;
				return true;
			}
			if (!(name == "ScreenEffect"))
			{
				value = EFadeBackgroundFadeOutEffectType.Black;
				return false;
			}
			value = EFadeBackgroundFadeOutEffectType.ScreenEffect;
			return true;
		}

		// Token: 0x0600D0BF RID: 53439 RVA: 0x001E3FFE File Offset: 0x001E21FE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Black",
				"ScreenEffect"
			};
		}

		// Token: 0x0600D0C0 RID: 53440 RVA: 0x001E4016 File Offset: 0x001E2216
		public static EFadeBackgroundFadeOutEffectType[] GetValues()
		{
			return new EFadeBackgroundFadeOutEffectType[]
			{
				EFadeBackgroundFadeOutEffectType.Black,
				EFadeBackgroundFadeOutEffectType.ScreenEffect
			};
		}

		// Token: 0x0600D0C1 RID: 53441 RVA: 0x001E4022 File Offset: 0x001E2222
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
