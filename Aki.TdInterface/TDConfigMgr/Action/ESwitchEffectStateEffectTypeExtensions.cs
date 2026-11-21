using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026E4 RID: 9956
	public static class ESwitchEffectStateEffectTypeExtensions
	{
		// Token: 0x0600D65C RID: 54876 RVA: 0x001F24DC File Offset: 0x001F06DC
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

		// Token: 0x0600D65D RID: 54877 RVA: 0x001F2514 File Offset: 0x001F0714
		public static ESwitchEffectStateEffectType FromString(string name)
		{
			ESwitchEffectStateEffectType result;
			if (!ESwitchEffectStateEffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESwitchEffectStateEffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D65E RID: 54878 RVA: 0x001F253D File Offset: 0x001F073D
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

		// Token: 0x0600D65F RID: 54879 RVA: 0x001F2576 File Offset: 0x001F0776
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ScreenEffect",
				"TrailChain"
			};
		}

		// Token: 0x0600D660 RID: 54880 RVA: 0x001F258E File Offset: 0x001F078E
		public static ESwitchEffectStateEffectType[] GetValues()
		{
			return new ESwitchEffectStateEffectType[]
			{
				ESwitchEffectStateEffectType.ScreenEffect,
				ESwitchEffectStateEffectType.TrailChain
			};
		}

		// Token: 0x0600D661 RID: 54881 RVA: 0x001F259A File Offset: 0x001F079A
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
