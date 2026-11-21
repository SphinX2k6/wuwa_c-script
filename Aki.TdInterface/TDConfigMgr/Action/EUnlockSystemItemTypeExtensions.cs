using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200273A RID: 10042
	public static class EUnlockSystemItemTypeExtensions
	{
		// Token: 0x0600D7DF RID: 55263 RVA: 0x001F89C0 File Offset: 0x001F6BC0
		public static string ToEnumString(this EUnlockSystemItemType value)
		{
			string result;
			switch (value)
			{
			case EUnlockSystemItemType.CookSystem:
				result = "CookSystem";
				break;
			case EUnlockSystemItemType.AtlasSystem:
				result = "AtlasSystem";
				break;
			case EUnlockSystemItemType.AchievementSystem:
				result = "AchievementSystem";
				break;
			case EUnlockSystemItemType.PhotoMemoryCollect:
				result = "MemoirsSystem";
				break;
			case EUnlockSystemItemType.DangoCollect:
				result = "DangoCollect";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D7E0 RID: 55264 RVA: 0x001F8A20 File Offset: 0x001F6C20
		public static EUnlockSystemItemType FromString(string name)
		{
			EUnlockSystemItemType result;
			if (!EUnlockSystemItemTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EUnlockSystemItemType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D7E1 RID: 55265 RVA: 0x001F8A4C File Offset: 0x001F6C4C
		public static bool TryFromString(string name, out EUnlockSystemItemType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EUnlockSystemItemType.CookSystem;
				return false;
			}
			if (name == "CookSystem")
			{
				value = EUnlockSystemItemType.CookSystem;
				return true;
			}
			if (name == "AtlasSystem")
			{
				value = EUnlockSystemItemType.AtlasSystem;
				return true;
			}
			if (name == "AchievementSystem")
			{
				value = EUnlockSystemItemType.AchievementSystem;
				return true;
			}
			if (name == "MemoirsSystem")
			{
				value = EUnlockSystemItemType.PhotoMemoryCollect;
				return true;
			}
			if (!(name == "DangoCollect"))
			{
				value = EUnlockSystemItemType.CookSystem;
				return false;
			}
			value = EUnlockSystemItemType.DangoCollect;
			return true;
		}

		// Token: 0x0600D7E2 RID: 55266 RVA: 0x001F8AC6 File Offset: 0x001F6CC6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CookSystem",
				"AtlasSystem",
				"AchievementSystem",
				"MemoirsSystem",
				"DangoCollect"
			};
		}

		// Token: 0x0600D7E3 RID: 55267 RVA: 0x001F8AF6 File Offset: 0x001F6CF6
		public static EUnlockSystemItemType[] GetValues()
		{
			return new EUnlockSystemItemType[]
			{
				EUnlockSystemItemType.CookSystem,
				EUnlockSystemItemType.AtlasSystem,
				EUnlockSystemItemType.AchievementSystem,
				EUnlockSystemItemType.PhotoMemoryCollect,
				EUnlockSystemItemType.DangoCollect
			};
		}

		// Token: 0x0600D7E4 RID: 55268 RVA: 0x001F8B09 File Offset: 0x001F6D09
		public static string[] GetNames()
		{
			return new string[]
			{
				"CookSystem",
				"AtlasSystem",
				"AchievementSystem",
				"PhotoMemoryCollect",
				"DangoCollect"
			};
		}
	}
}
