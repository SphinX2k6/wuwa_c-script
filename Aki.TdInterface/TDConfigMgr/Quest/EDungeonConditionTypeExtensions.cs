using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200123A RID: 4666
	public static class EDungeonConditionTypeExtensions
	{
		// Token: 0x060069AC RID: 27052 RVA: 0x000FD0B8 File Offset: 0x000FB2B8
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

		// Token: 0x060069AD RID: 27053 RVA: 0x000FD0F0 File Offset: 0x000FB2F0
		public static EDungeonConditionType FromString(string name)
		{
			EDungeonConditionType result;
			if (!EDungeonConditionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDungeonConditionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060069AE RID: 27054 RVA: 0x000FD119 File Offset: 0x000FB319
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

		// Token: 0x060069AF RID: 27055 RVA: 0x000FD152 File Offset: 0x000FB352
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DungeonSubType",
				"DungeonId"
			};
		}

		// Token: 0x060069B0 RID: 27056 RVA: 0x000FD16A File Offset: 0x000FB36A
		public static EDungeonConditionType[] GetValues()
		{
			return new EDungeonConditionType[]
			{
				EDungeonConditionType.DungeonSubType,
				EDungeonConditionType.DungeonId
			};
		}

		// Token: 0x060069B1 RID: 27057 RVA: 0x000FD176 File Offset: 0x000FB376
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
