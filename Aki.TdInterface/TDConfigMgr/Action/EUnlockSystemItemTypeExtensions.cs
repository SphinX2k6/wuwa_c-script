using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002497 RID: 9367
	public static class EUnlockSystemItemTypeExtensions
	{
		// Token: 0x0600CB26 RID: 52006 RVA: 0x001DE7F8 File Offset: 0x001DC9F8
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

		// Token: 0x0600CB27 RID: 52007 RVA: 0x001DE858 File Offset: 0x001DCA58
		public static EUnlockSystemItemType FromString(string name)
		{
			EUnlockSystemItemType result;
			if (!EUnlockSystemItemTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EUnlockSystemItemType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CB28 RID: 52008 RVA: 0x001DE884 File Offset: 0x001DCA84
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

		// Token: 0x0600CB29 RID: 52009 RVA: 0x001DE8FE File Offset: 0x001DCAFE
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

		// Token: 0x0600CB2A RID: 52010 RVA: 0x001DE92E File Offset: 0x001DCB2E
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

		// Token: 0x0600CB2B RID: 52011 RVA: 0x001DE941 File Offset: 0x001DCB41
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
