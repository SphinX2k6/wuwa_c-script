using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066C8 RID: 26312
	public static class EDropCatchResourceIdExtensions
	{
		// Token: 0x06041CD7 RID: 269527 RVA: 0x00FF5938 File Offset: 0x00FF3B38
		public static string ToEnumString(this EDropCatchResourceId value)
		{
			string result;
			switch (value)
			{
			case EDropCatchResourceId.DropItem:
				result = "UiItem_GoldCatchPnlDropItem";
				break;
			case EDropCatchResourceId.Role:
				result = "UiItem_GoldCatchPnlRole";
				break;
			case EDropCatchResourceId.RoleBuff:
				result = "UiItem_GoldCatchPnlRoleBuff";
				break;
			case EDropCatchResourceId.CountDown:
				result = "UiItem_GoldCatchCountdown";
				break;
			case EDropCatchResourceId.RoleFx:
				result = "UiItem_RoleFx";
				break;
			case EDropCatchResourceId.DropItemFx:
				result = "UiItem_DropItemFx";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06041CD8 RID: 269528 RVA: 0x00FF59A4 File Offset: 0x00FF3BA4
		public static EDropCatchResourceId FromString(string name)
		{
			EDropCatchResourceId result;
			if (!EDropCatchResourceIdExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDropCatchResourceId 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06041CD9 RID: 269529 RVA: 0x00FF59D0 File Offset: 0x00FF3BD0
		public static bool TryFromString(string name, out EDropCatchResourceId value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDropCatchResourceId.DropItem;
				return false;
			}
			if (name == "UiItem_GoldCatchPnlDropItem")
			{
				value = EDropCatchResourceId.DropItem;
				return true;
			}
			if (name == "UiItem_GoldCatchPnlRole")
			{
				value = EDropCatchResourceId.Role;
				return true;
			}
			if (name == "UiItem_GoldCatchPnlRoleBuff")
			{
				value = EDropCatchResourceId.RoleBuff;
				return true;
			}
			if (name == "UiItem_GoldCatchCountdown")
			{
				value = EDropCatchResourceId.CountDown;
				return true;
			}
			if (name == "UiItem_RoleFx")
			{
				value = EDropCatchResourceId.RoleFx;
				return true;
			}
			if (!(name == "UiItem_DropItemFx"))
			{
				value = EDropCatchResourceId.DropItem;
				return false;
			}
			value = EDropCatchResourceId.DropItemFx;
			return true;
		}

		// Token: 0x06041CDA RID: 269530 RVA: 0x00FF5A5C File Offset: 0x00FF3C5C
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"UiItem_GoldCatchPnlDropItem",
				"UiItem_GoldCatchPnlRole",
				"UiItem_GoldCatchPnlRoleBuff",
				"UiItem_GoldCatchCountdown",
				"UiItem_RoleFx",
				"UiItem_DropItemFx"
			};
		}

		// Token: 0x06041CDB RID: 269531 RVA: 0x00FF5A94 File Offset: 0x00FF3C94
		public static EDropCatchResourceId[] GetValues()
		{
			return new EDropCatchResourceId[]
			{
				EDropCatchResourceId.DropItem,
				EDropCatchResourceId.Role,
				EDropCatchResourceId.RoleBuff,
				EDropCatchResourceId.CountDown,
				EDropCatchResourceId.RoleFx,
				EDropCatchResourceId.DropItemFx
			};
		}

		// Token: 0x06041CDC RID: 269532 RVA: 0x00FF5AA7 File Offset: 0x00FF3CA7
		public static string[] GetNames()
		{
			return new string[]
			{
				"DropItem",
				"Role",
				"RoleBuff",
				"CountDown",
				"RoleFx",
				"DropItemFx"
			};
		}
	}
}
