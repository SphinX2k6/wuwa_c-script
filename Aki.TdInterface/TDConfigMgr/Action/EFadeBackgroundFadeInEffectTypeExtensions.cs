using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002331 RID: 9009
	public static class EFadeBackgroundFadeInEffectTypeExtensions
	{
		// Token: 0x0600C4DB RID: 50395 RVA: 0x001CBD98 File Offset: 0x001C9F98
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

		// Token: 0x0600C4DC RID: 50396 RVA: 0x001CBDD0 File Offset: 0x001C9FD0
		public static EFadeBackgroundFadeInEffectType FromString(string name)
		{
			EFadeBackgroundFadeInEffectType result;
			if (!EFadeBackgroundFadeInEffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFadeBackgroundFadeInEffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C4DD RID: 50397 RVA: 0x001CBDF9 File Offset: 0x001C9FF9
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

		// Token: 0x0600C4DE RID: 50398 RVA: 0x001CBE32 File Offset: 0x001CA032
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Black",
				"ScreenEffect"
			};
		}

		// Token: 0x0600C4DF RID: 50399 RVA: 0x001CBE4A File Offset: 0x001CA04A
		public static EFadeBackgroundFadeInEffectType[] GetValues()
		{
			return new EFadeBackgroundFadeInEffectType[]
			{
				EFadeBackgroundFadeInEffectType.Black,
				EFadeBackgroundFadeInEffectType.ScreenEffect
			};
		}

		// Token: 0x0600C4E0 RID: 50400 RVA: 0x001CBE56 File Offset: 0x001CA056
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
