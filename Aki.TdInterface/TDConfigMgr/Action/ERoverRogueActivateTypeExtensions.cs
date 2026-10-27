using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023F9 RID: 9209
	public static class ERoverRogueActivateTypeExtensions
	{
		// Token: 0x0600C85F RID: 51295 RVA: 0x001D5314 File Offset: 0x001D3514
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

		// Token: 0x0600C860 RID: 51296 RVA: 0x001D5368 File Offset: 0x001D3568
		public static ERoverRogueActivateType FromString(string name)
		{
			ERoverRogueActivateType result;
			if (!ERoverRogueActivateTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERoverRogueActivateType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C861 RID: 51297 RVA: 0x001D5394 File Offset: 0x001D3594
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

		// Token: 0x0600C862 RID: 51298 RVA: 0x001D53FC File Offset: 0x001D35FC
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

		// Token: 0x0600C863 RID: 51299 RVA: 0x001D5424 File Offset: 0x001D3624
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

		// Token: 0x0600C864 RID: 51300 RVA: 0x001D5437 File Offset: 0x001D3637
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
