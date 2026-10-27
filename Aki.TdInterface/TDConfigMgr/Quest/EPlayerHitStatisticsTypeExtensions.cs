using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001266 RID: 4710
	public static class EPlayerHitStatisticsTypeExtensions
	{
		// Token: 0x06006A72 RID: 27250 RVA: 0x000FF13C File Offset: 0x000FD33C
		public static string ToEnumString(this EPlayerHitStatisticsType value)
		{
			string result;
			if (value != EPlayerHitStatisticsType.HitCount)
			{
				if (value != EPlayerHitStatisticsType.BeDamage)
				{
					result = value.ToString();
				}
				else
				{
					result = "BeDamage";
				}
			}
			else
			{
				result = "HitCount";
			}
			return result;
		}

		// Token: 0x06006A73 RID: 27251 RVA: 0x000FF174 File Offset: 0x000FD374
		public static EPlayerHitStatisticsType FromString(string name)
		{
			EPlayerHitStatisticsType result;
			if (!EPlayerHitStatisticsTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlayerHitStatisticsType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006A74 RID: 27252 RVA: 0x000FF19D File Offset: 0x000FD39D
		public static bool TryFromString(string name, out EPlayerHitStatisticsType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPlayerHitStatisticsType.HitCount;
				return false;
			}
			if (name == "HitCount")
			{
				value = EPlayerHitStatisticsType.HitCount;
				return true;
			}
			if (!(name == "BeDamage"))
			{
				value = EPlayerHitStatisticsType.HitCount;
				return false;
			}
			value = EPlayerHitStatisticsType.BeDamage;
			return true;
		}

		// Token: 0x06006A75 RID: 27253 RVA: 0x000FF1D6 File Offset: 0x000FD3D6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"HitCount",
				"BeDamage"
			};
		}

		// Token: 0x06006A76 RID: 27254 RVA: 0x000FF1EE File Offset: 0x000FD3EE
		public static EPlayerHitStatisticsType[] GetValues()
		{
			return new EPlayerHitStatisticsType[]
			{
				EPlayerHitStatisticsType.HitCount,
				EPlayerHitStatisticsType.BeDamage
			};
		}

		// Token: 0x06006A77 RID: 27255 RVA: 0x000FF1FA File Offset: 0x000FD3FA
		public static string[] GetNames()
		{
			return new string[]
			{
				"HitCount",
				"BeDamage"
			};
		}
	}
}
