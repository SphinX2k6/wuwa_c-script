using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A3D RID: 2621
	public static class ELevelPrefabBpTypeExtensions
	{
		// Token: 0x06003A25 RID: 14885 RVA: 0x00096380 File Offset: 0x00094580
		public static string ToEnumString(this ELevelPrefabBpType value)
		{
			string result;
			switch (value)
			{
			case ELevelPrefabBpType.Item:
				result = "Item";
				break;
			case ELevelPrefabBpType.InteractedBox:
				result = "InteractedBox";
				break;
			case ELevelPrefabBpType.PhysicsItem:
				result = "PhysicsItem";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003A26 RID: 14886 RVA: 0x000963C8 File Offset: 0x000945C8
		public static ELevelPrefabBpType FromString(string name)
		{
			ELevelPrefabBpType result;
			if (!ELevelPrefabBpTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELevelPrefabBpType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003A27 RID: 14887 RVA: 0x000963F4 File Offset: 0x000945F4
		public static bool TryFromString(string name, out ELevelPrefabBpType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELevelPrefabBpType.Item;
				return false;
			}
			if (name == "Item")
			{
				value = ELevelPrefabBpType.Item;
				return true;
			}
			if (name == "InteractedBox")
			{
				value = ELevelPrefabBpType.InteractedBox;
				return true;
			}
			if (!(name == "PhysicsItem"))
			{
				value = ELevelPrefabBpType.Item;
				return false;
			}
			value = ELevelPrefabBpType.PhysicsItem;
			return true;
		}

		// Token: 0x06003A28 RID: 14888 RVA: 0x0009644A File Offset: 0x0009464A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Item",
				"InteractedBox",
				"PhysicsItem"
			};
		}

		// Token: 0x06003A29 RID: 14889 RVA: 0x0009646A File Offset: 0x0009466A
		public static ELevelPrefabBpType[] GetValues()
		{
			return new ELevelPrefabBpType[]
			{
				ELevelPrefabBpType.Item,
				ELevelPrefabBpType.InteractedBox,
				ELevelPrefabBpType.PhysicsItem
			};
		}

		// Token: 0x06003A2A RID: 14890 RVA: 0x0009647A File Offset: 0x0009467A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Item",
				"InteractedBox",
				"PhysicsItem"
			};
		}
	}
}
