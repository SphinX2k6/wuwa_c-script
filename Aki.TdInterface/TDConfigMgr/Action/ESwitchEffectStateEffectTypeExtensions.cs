using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002443 RID: 9283
	public static class ESwitchEffectStateEffectTypeExtensions
	{
		// Token: 0x0600C9AC RID: 51628 RVA: 0x001D8614 File Offset: 0x001D6814
		public static string ToEnumString(this ESwitchEffectStateEffectType value)
		{
			string result;
			if (value != ESwitchEffectStateEffectType.ScreenEffect)
			{
				if (value != ESwitchEffectStateEffectType.TrailChain)
				{
					result = value.ToString();
				}
				else
				{
					result = "TrailChain";
				}
			}
			else
			{
				result = "ScreenEffect";
			}
			return result;
		}

		// Token: 0x0600C9AD RID: 51629 RVA: 0x001D864C File Offset: 0x001D684C
		public static ESwitchEffectStateEffectType FromString(string name)
		{
			ESwitchEffectStateEffectType result;
			if (!ESwitchEffectStateEffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESwitchEffectStateEffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C9AE RID: 51630 RVA: 0x001D8675 File Offset: 0x001D6875
		public static bool TryFromString(string name, out ESwitchEffectStateEffectType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESwitchEffectStateEffectType.ScreenEffect;
				return false;
			}
			if (name == "ScreenEffect")
			{
				value = ESwitchEffectStateEffectType.ScreenEffect;
				return true;
			}
			if (!(name == "TrailChain"))
			{
				value = ESwitchEffectStateEffectType.ScreenEffect;
				return false;
			}
			value = ESwitchEffectStateEffectType.TrailChain;
			return true;
		}

		// Token: 0x0600C9AF RID: 51631 RVA: 0x001D86AE File Offset: 0x001D68AE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ScreenEffect",
				"TrailChain"
			};
		}

		// Token: 0x0600C9B0 RID: 51632 RVA: 0x001D86C6 File Offset: 0x001D68C6
		public static ESwitchEffectStateEffectType[] GetValues()
		{
			return new ESwitchEffectStateEffectType[]
			{
				ESwitchEffectStateEffectType.ScreenEffect,
				ESwitchEffectStateEffectType.TrailChain
			};
		}

		// Token: 0x0600C9B1 RID: 51633 RVA: 0x001D86D2 File Offset: 0x001D68D2
		public static string[] GetNames()
		{
			return new string[]
			{
				"ScreenEffect",
				"TrailChain"
			};
		}
	}
}
