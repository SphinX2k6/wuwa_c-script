using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002333 RID: 9011
	public static class EFadeBackgroundFadeOutEffectTypeExtensions
	{
		// Token: 0x0600C4E4 RID: 50404 RVA: 0x001CBEAC File Offset: 0x001CA0AC
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

		// Token: 0x0600C4E5 RID: 50405 RVA: 0x001CBEE4 File Offset: 0x001CA0E4
		public static EFadeBackgroundFadeOutEffectType FromString(string name)
		{
			EFadeBackgroundFadeOutEffectType result;
			if (!EFadeBackgroundFadeOutEffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFadeBackgroundFadeOutEffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C4E6 RID: 50406 RVA: 0x001CBF0D File Offset: 0x001CA10D
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

		// Token: 0x0600C4E7 RID: 50407 RVA: 0x001CBF46 File Offset: 0x001CA146
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Black",
				"ScreenEffect"
			};
		}

		// Token: 0x0600C4E8 RID: 50408 RVA: 0x001CBF5E File Offset: 0x001CA15E
		public static EFadeBackgroundFadeOutEffectType[] GetValues()
		{
			return new EFadeBackgroundFadeOutEffectType[]
			{
				EFadeBackgroundFadeOutEffectType.Black,
				EFadeBackgroundFadeOutEffectType.ScreenEffect
			};
		}

		// Token: 0x0600C4E9 RID: 50409 RVA: 0x001CBF6A File Offset: 0x001CA16A
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
