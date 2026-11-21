using System;

// Token: 0x0200148D RID: 5261
public class PayShopCouponItemUseLogic : ItemUseLogicBase
{
	// Token: 0x0600D295 RID: 53909 RVA: 0x003E790D File Offset: 0x003E5B0D
	public override bool CheckUseCondition(int itemId, int num)
	{
		return InventoryModel.Instance.GetCommonItemData(itemId, 0) != null;
	}

	// Token: 0x0600D296 RID: 53910 RVA: 0x003E7920 File Offset: 0x003E5B20
	public override void OnUse(int itemId, int num)
	{
		PayShopViewData payShopViewData = new PayShopViewData();
		payShopViewData.PayShopId = PayShopDefine.EPayShopTabType.SkinShop;
		PayShopController.Instance.OpenPayShopView(payShopViewData, null);
	}
}
