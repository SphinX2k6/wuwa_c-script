using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200124C RID: 4684
	public static class EInformationViewTypeExtensions
	{
		// Token: 0x060069FD RID: 27133 RVA: 0x000FDD7C File Offset: 0x000FBF7C
		public static string ToEnumString(this EInformationViewType value)
		{
			string result;
			switch (value)
			{
			case EInformationViewType.LevelPlay:
				result = "LevelPlay";
				break;
			case EInformationViewType.BossRushBuffInfo:
				result = "BossRushBuffInfo";
				break;
			case EInformationViewType.DangoAbyss:
				result = "DangoAbyss";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060069FE RID: 27134 RVA: 0x000FDDC4 File Offset: 0x000FBFC4
		public static EInformationViewType FromString(string name)
		{
			EInformationViewType result;
			if (!EInformationViewTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInformationViewType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060069FF RID: 27135 RVA: 0x000FDDF0 File Offset: 0x000FBFF0
		public static bool TryFromString(string name, out EInformationViewType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EInformationViewType.LevelPlay;
				return false;
			}
			if (name == "LevelPlay")
			{
				value = EInformationViewType.LevelPlay;
				return true;
			}
			if (name == "BossRushBuffInfo")
			{
				value = EInformationViewType.BossRushBuffInfo;
				return true;
			}
			if (!(name == "DangoAbyss"))
			{
				value = EInformationViewType.LevelPlay;
				return false;
			}
			value = EInformationViewType.DangoAbyss;
			return true;
		}

		// Token: 0x06006A00 RID: 27136 RVA: 0x000FDE46 File Offset: 0x000FC046
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LevelPlay",
				"BossRushBuffInfo",
				"DangoAbyss"
			};
		}

		// Token: 0x06006A01 RID: 27137 RVA: 0x000FDE66 File Offset: 0x000FC066
		public static EInformationViewType[] GetValues()
		{
			return new EInformationViewType[]
			{
				EInformationViewType.LevelPlay,
				EInformationViewType.BossRushBuffInfo,
				EInformationViewType.DangoAbyss
			};
		}

		// Token: 0x06006A02 RID: 27138 RVA: 0x000FDE76 File Offset: 0x000FC076
		public static string[] GetNames()
		{
			return new string[]
			{
				"LevelPlay",
				"BossRushBuffInfo",
				"DangoAbyss"
			};
		}
	}
}
