using System;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.PayShop
{
	// Token: 0x02005356 RID: 21334
	public static class PayShopUtil
	{
		// Token: 0x0603682A RID: 223274 RVA: 0x00CE852C File Offset: 0x00CE672C
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
