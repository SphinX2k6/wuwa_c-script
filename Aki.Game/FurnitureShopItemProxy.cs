using System;
using CSharpScript.Game.Ui;

// Token: 0x02000F76 RID: 3958
public class FurnitureShopItemProxy : CommonGameplayShopItemProxy
{
	// Token: 0x06006553 RID: 25939 RVA: 0x001427A0 File Offset: 0x001409A0
	public override void UpdateLeftTime()
	{
		base.LeftTimeItemVisible = false;
	}

	// Token: 0x06006554 RID: 25940 RVA: 0x001427A9 File Offset: 0x001409A9
	public override void UpdateBuyLimitCountText()
	{
		base.BuyLimitCountTextVisible = false;
	}

	// Token: 0x06006555 RID: 25941 RVA: 0x001427B2 File Offset: 0x001409B2
	public override void UpdateRedDot()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		base.RedDotVisible = FurnitureModel.Instance.CheckFurnitureShopItemRedDotByData(this.GoodsData);
	}

	// Token: 0x06006556 RID: 25942 RVA: 0x001427D4 File Offset: 0x001409D4
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
