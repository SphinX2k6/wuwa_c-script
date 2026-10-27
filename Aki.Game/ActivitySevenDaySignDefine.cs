using System;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

// Token: 0x020014FB RID: 5371
public static class ActivitySevenDaySignDefine
{
	// Token: 0x06009932 RID: 39218 RVA: 0x002123D4 File Offset: 0x002105D4
	public static void OpenSignActivityRewardPreviewWhenLocked(int itemId)
	{
		if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(itemId)) == InventoryDefine.EItemDataType.MotorDecorationItem)
		{
			ItemMotorPreview? config = ConfigItemMotorPreviewByItemId.GetConfig(itemId, true);
			if (config != null && config.Value.PreviewId > 0)
			{
				MotorcycleDiyController.Instance.OpenMotorGeneralPreviewView(config.Value.PreviewId);
				return;
			}
		}
		ItemController.Instance.OpenItemTipsByItemId(itemId, true, null);
	}
}
