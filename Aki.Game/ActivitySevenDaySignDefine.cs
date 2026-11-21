using System;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

// Token: 0x020009B3 RID: 2483
public static class ActivitySevenDaySignDefine
{
	// Token: 0x06006D0C RID: 27916 RVA: 0x0021C0EC File Offset: 0x0021A2EC
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
		ItemController.Instance.OpenItemTipsByItemId(itemId, true, null, false);
	}
}
