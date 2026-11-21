using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200138C RID: 5004
	public static class EInformationViewTypeExtensions
	{
		// Token: 0x06007050 RID: 28752 RVA: 0x0010B9A8 File Offset: 0x00109BA8
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

		// Token: 0x06007051 RID: 28753 RVA: 0x0010B9F0 File Offset: 0x00109BF0
		public static EInformationViewType FromString(string name)
		{
			EInformationViewType result;
			if (!EInformationViewTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInformationViewType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007052 RID: 28754 RVA: 0x0010BA1C File Offset: 0x00109C1C
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

		// Token: 0x06007053 RID: 28755 RVA: 0x0010BA72 File Offset: 0x00109C72
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LevelPlay",
				"BossRushBuffInfo",
				"DangoAbyss"
			};
		}

		// Token: 0x06007054 RID: 28756 RVA: 0x0010BA92 File Offset: 0x00109C92
		public static EInformationViewType[] GetValues()
		{
			return new EInformationViewType[]
			{
				EInformationViewType.LevelPlay,
				EInformationViewType.BossRushBuffInfo,
				EInformationViewType.DangoAbyss
			};
		}

		// Token: 0x06007055 RID: 28757 RVA: 0x0010BAA2 File Offset: 0x00109CA2
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
