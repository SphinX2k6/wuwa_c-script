using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013A6 RID: 5030
	public static class EPlayerHitStatisticsTypeExtensions
	{
		// Token: 0x060070C5 RID: 28869 RVA: 0x0010CD68 File Offset: 0x0010AF68
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

		// Token: 0x060070C6 RID: 28870 RVA: 0x0010CDA0 File Offset: 0x0010AFA0
		public static EPlayerHitStatisticsType FromString(string name)
		{
			EPlayerHitStatisticsType result;
			if (!EPlayerHitStatisticsTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlayerHitStatisticsType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060070C7 RID: 28871 RVA: 0x0010CDC9 File Offset: 0x0010AFC9
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

		// Token: 0x060070C8 RID: 28872 RVA: 0x0010CE02 File Offset: 0x0010B002
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"HitCount",
				"BeDamage"
			};
		}

		// Token: 0x060070C9 RID: 28873 RVA: 0x0010CE1A File Offset: 0x0010B01A
		public static EPlayerHitStatisticsType[] GetValues()
		{
			return new EPlayerHitStatisticsType[]
			{
				EPlayerHitStatisticsType.HitCount,
				EPlayerHitStatisticsType.BeDamage
			};
		}

		// Token: 0x060070CA RID: 28874 RVA: 0x0010CE26 File Offset: 0x0010B026
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
