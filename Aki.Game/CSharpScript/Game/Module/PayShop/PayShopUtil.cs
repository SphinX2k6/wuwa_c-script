using System;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.PayShop
{
	// Token: 0x02004339 RID: 17209
	public static class PayShopUtil
	{
		// Token: 0x0602B770 RID: 178032 RVA: 0x00C373B4 File Offset: 0x00C355B4
		public static void OpenItemPreview(InventoryDefine.EItemDataType itemType, int itemId)
		{
			if (itemType == InventoryDefine.EItemDataType.OrnamentItem)
			{
				RoleController.Instance.OpenOrnamentPreviewView(itemId, null);
				return;
			}
			if (itemType == InventoryDefine.EItemDataType.MotorDecorationItem)
			{
				ItemMotorPreview? config = ConfigItemMotorPreviewByItemId.GetConfig(itemId, true);
				if (config != null)
				{
					MotorcycleDiyController.Instance.OpenMotorGeneralPreviewView(config.Value.PreviewId);
				}
			}
		}
	}
}
