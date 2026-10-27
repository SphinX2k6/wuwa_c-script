using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002475 RID: 9333
	public static class ETimeStampTypeExtensions
	{
		// Token: 0x0600CA8D RID: 51853 RVA: 0x001DD15C File Offset: 0x001DB35C
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

		// Token: 0x0600CA8E RID: 51854 RVA: 0x001DD194 File Offset: 0x001DB394
		public static ETimeStampType FromString(string name)
		{
			ETimeStampType result;
			if (!ETimeStampTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETimeStampType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CA8F RID: 51855 RVA: 0x001DD1BD File Offset: 0x001DB3BD
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

		// Token: 0x0600CA90 RID: 51856 RVA: 0x001DD1F6 File Offset: 0x001DB3F6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DungeonBegin",
				"DungeonFinish"
			};
		}

		// Token: 0x0600CA91 RID: 51857 RVA: 0x001DD20E File Offset: 0x001DB40E
		public static ETimeStampType[] GetValues()
		{
			return new ETimeStampType[]
			{
				ETimeStampType.DungeonBegin,
				ETimeStampType.DungeonFinish
			};
		}

		// Token: 0x0600CA92 RID: 51858 RVA: 0x001DD21A File Offset: 0x001DB41A
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
