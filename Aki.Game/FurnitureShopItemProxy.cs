using System;
using CSharpScript.Game.Ui;

// Token: 0x0200042B RID: 1067
public class FurnitureShopItemProxy : CommonGameplayShopItemProxy
{
	// Token: 0x060038EB RID: 14571 RVA: 0x0014B03C File Offset: 0x0014923C
	public override void UpdateLeftTime()
	{
		base.LeftTimeItemVisible = false;
	}

	// Token: 0x060038EC RID: 14572 RVA: 0x0014B045 File Offset: 0x00149245
	public override void UpdateBuyLimitCountText()
	{
		base.BuyLimitCountTextVisible = false;
	}

	// Token: 0x060038ED RID: 14573 RVA: 0x0014B04E File Offset: 0x0014924E
	public override void UpdateRedDot()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		base.RedDotVisible = FurnitureModel.Instance.CheckFurnitureShopItemRedDotByData(this.GoodsData);
	}

	// Token: 0x060038EE RID: 14574 RVA: 0x0014B070 File Offset: 0x00149270
	public override void OnBuyButtonClick()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		FurnitureShopExchangePopViewProxy furnitureShopExchangePopViewProxy = new FurnitureShopExchangePopViewProxy();
		furnitureShopExchangePopViewProxy.UpdateFromPayShopGoods(this.GoodsData);
		UiManager.Instance.OpenView(EUiViewName.GameplayExchangePopView, furnitureShopExchangePopViewProxy, null);
	}
}
