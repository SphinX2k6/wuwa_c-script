using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002716 RID: 10006
	public static class ETimeStampTypeExtensions
	{
		// Token: 0x0600D73D RID: 55101 RVA: 0x001F7210 File Offset: 0x001F5410
		public static string ToEnumString(this ETimeStampType value)
		{
			string result;
			if (value != ETimeStampType.DungeonBegin)
			{
				if (value != ETimeStampType.DungeonFinish)
				{
					result = value.ToString();
				}
				else
				{
					result = "DungeonFinish";
				}
			}
			else
			{
				result = "DungeonBegin";
			}
			return result;
		}

		// Token: 0x0600D73E RID: 55102 RVA: 0x001F7248 File Offset: 0x001F5448
		public static ETimeStampType FromString(string name)
		{
			ETimeStampType result;
			if (!ETimeStampTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETimeStampType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D73F RID: 55103 RVA: 0x001F7271 File Offset: 0x001F5471
		public static bool TryFromString(string name, out ETimeStampType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETimeStampType.DungeonBegin;
				return false;
			}
			if (name == "DungeonBegin")
			{
				value = ETimeStampType.DungeonBegin;
				return true;
			}
			if (!(name == "DungeonFinish"))
			{
				value = ETimeStampType.DungeonBegin;
				return false;
			}
			value = ETimeStampType.DungeonFinish;
			return true;
		}

		// Token: 0x0600D740 RID: 55104 RVA: 0x001F72AA File Offset: 0x001F54AA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DungeonBegin",
				"DungeonFinish"
			};
		}

		// Token: 0x0600D741 RID: 55105 RVA: 0x001F72C2 File Offset: 0x001F54C2
		public static ETimeStampType[] GetValues()
		{
			return new ETimeStampType[]
			{
				ETimeStampType.DungeonBegin,
				ETimeStampType.DungeonFinish
			};
		}

		// Token: 0x0600D742 RID: 55106 RVA: 0x001F72CE File Offset: 0x001F54CE
		public static string[] GetNames()
		{
			return new string[]
			{
				"DungeonBegin",
				"DungeonFinish"
			};
		}
	}
}
