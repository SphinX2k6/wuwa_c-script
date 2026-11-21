using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002690 RID: 9872
	public static class ERoverRogueActivateTypeExtensions
	{
		// Token: 0x0600D4E2 RID: 54498 RVA: 0x001EEAC0 File Offset: 0x001ECCC0
		public static string ToEnumString(this ERoverRogueActivateType value)
		{
			string result;
			switch (value)
			{
			case ERoverRogueActivateType.Shop:
				result = "Shop";
				break;
			case ERoverRogueActivateType.Event:
				result = "Event";
				break;
			case ERoverRogueActivateType.BlessGroup:
				result = "BlessGroup";
				break;
			case ERoverRogueActivateType.Loot:
				result = "Loot";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D4E3 RID: 54499 RVA: 0x001EEB14 File Offset: 0x001ECD14
		public static ERoverRogueActivateType FromString(string name)
		{
			ERoverRogueActivateType result;
			if (!ERoverRogueActivateTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERoverRogueActivateType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D4E4 RID: 54500 RVA: 0x001EEB40 File Offset: 0x001ECD40
		public static bool TryFromString(string name, out ERoverRogueActivateType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERoverRogueActivateType.Shop;
				return false;
			}
			if (name == "Shop")
			{
				value = ERoverRogueActivateType.Shop;
				return true;
			}
			if (name == "Event")
			{
				value = ERoverRogueActivateType.Event;
				return true;
			}
			if (name == "BlessGroup")
			{
				value = ERoverRogueActivateType.BlessGroup;
				return true;
			}
			if (!(name == "Loot"))
			{
				value = ERoverRogueActivateType.Shop;
				return false;
			}
			value = ERoverRogueActivateType.Loot;
			return true;
		}

		// Token: 0x0600D4E5 RID: 54501 RVA: 0x001EEBA8 File Offset: 0x001ECDA8
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Shop",
				"Event",
				"BlessGroup",
				"Loot"
			};
		}

		// Token: 0x0600D4E6 RID: 54502 RVA: 0x001EEBD0 File Offset: 0x001ECDD0
		public static ERoverRogueActivateType[] GetValues()
		{
			return new ERoverRogueActivateType[]
			{
				ERoverRogueActivateType.Shop,
				ERoverRogueActivateType.Event,
				ERoverRogueActivateType.BlessGroup,
				ERoverRogueActivateType.Loot
			};
		}

		// Token: 0x0600D4E7 RID: 54503 RVA: 0x001EEBE3 File Offset: 0x001ECDE3
		public static string[] GetNames()
		{
			return new string[]
			{
				"Shop",
				"Event",
				"BlessGroup",
				"Loot"
			};
		}
	}
}
