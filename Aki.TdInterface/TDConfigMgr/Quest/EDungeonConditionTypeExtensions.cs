using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200137A RID: 4986
	public static class EDungeonConditionTypeExtensions
	{
		// Token: 0x06006FFF RID: 28671 RVA: 0x0010AC84 File Offset: 0x00108E84
		public static string ToEnumString(this EDungeonConditionType value)
		{
			string result;
			if (value != EDungeonConditionType.DungeonSubType)
			{
				if (value != EDungeonConditionType.DungeonId)
				{
					result = value.ToString();
				}
				else
				{
					result = "DungeonId";
				}
			}
			else
			{
				result = "DungeonSubType";
			}
			return result;
		}

		// Token: 0x06007000 RID: 28672 RVA: 0x0010ACBC File Offset: 0x00108EBC
		public static EDungeonConditionType FromString(string name)
		{
			EDungeonConditionType result;
			if (!EDungeonConditionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDungeonConditionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007001 RID: 28673 RVA: 0x0010ACE5 File Offset: 0x00108EE5
		public static bool TryFromString(string name, out EDungeonConditionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDungeonConditionType.DungeonSubType;
				return false;
			}
			if (name == "DungeonSubType")
			{
				value = EDungeonConditionType.DungeonSubType;
				return true;
			}
			if (!(name == "DungeonId"))
			{
				value = EDungeonConditionType.DungeonSubType;
				return false;
			}
			value = EDungeonConditionType.DungeonId;
			return true;
		}

		// Token: 0x06007002 RID: 28674 RVA: 0x0010AD1E File Offset: 0x00108F1E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DungeonSubType",
				"DungeonId"
			};
		}

		// Token: 0x06007003 RID: 28675 RVA: 0x0010AD36 File Offset: 0x00108F36
		public static EDungeonConditionType[] GetValues()
		{
			return new EDungeonConditionType[]
			{
				EDungeonConditionType.DungeonSubType,
				EDungeonConditionType.DungeonId
			};
		}

		// Token: 0x06007004 RID: 28676 RVA: 0x0010AD42 File Offset: 0x00108F42
		public static string[] GetNames()
		{
			return new string[]
			{
				"DungeonSubType",
				"DungeonId"
			};
		}
	}
}
