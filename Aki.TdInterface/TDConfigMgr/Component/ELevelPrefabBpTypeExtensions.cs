using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200098A RID: 2442
	public static class ELevelPrefabBpTypeExtensions
	{
		// Token: 0x0600369E RID: 13982 RVA: 0x0008E414 File Offset: 0x0008C614
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

		// Token: 0x0600369F RID: 13983 RVA: 0x0008E45C File Offset: 0x0008C65C
		public static ELevelPrefabBpType FromString(string name)
		{
			ELevelPrefabBpType result;
			if (!ELevelPrefabBpTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELevelPrefabBpType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x0008E488 File Offset: 0x0008C688
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

		// Token: 0x060036A1 RID: 13985 RVA: 0x0008E4DE File Offset: 0x0008C6DE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Item",
				"InteractedBox",
				"PhysicsItem"
			};
		}

		// Token: 0x060036A2 RID: 13986 RVA: 0x0008E4FE File Offset: 0x0008C6FE
		public static ELevelPrefabBpType[] GetValues()
		{
			return new ELevelPrefabBpType[]
			{
				ELevelPrefabBpType.Item,
				ELevelPrefabBpType.InteractedBox,
				ELevelPrefabBpType.PhysicsItem
			};
		}

		// Token: 0x060036A3 RID: 13987 RVA: 0x0008E50E File Offset: 0x0008C70E
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
