using System;

// Token: 0x02001484 RID: 5252
public class BirthdayItemUseLogic : ItemUseLogicBase
{
	// Token: 0x0600D26B RID: 53867 RVA: 0x003E6FE0 File Offset: 0x003E51E0
	public override bool CheckUseCondition(int itemId, int num)
	{
		return InventoryModel.Instance.GetCommonItemData(itemId, 0) != null;
	}

	// Token: 0x0600D26C RID: 53868 RVA: 0x003E6FF1 File Offset: 0x003E51F1
	public override void OnUse(int itemId, int num)
	{
		BirthdayController.Instance.UseBirthdayItem(itemId);
	}
}
