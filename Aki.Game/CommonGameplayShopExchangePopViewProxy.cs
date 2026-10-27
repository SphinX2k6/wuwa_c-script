using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;

// Token: 0x0200233E RID: 9022
[NullableContext(1)]
[Nullable(0)]
public class CommonGameplayShopExchangePopViewProxy : AbstractGameplayShopExchangePopViewProxy
{
	// Token: 0x06011E2B RID: 73259 RVA: 0x004666A0 File Offset: 0x004648A0
	public virtual void UpdateShopItemData()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		CommonGameplayExchangeShopItemProxy commonGameplayExchangeShopItemProxy = new CommonGameplayExchangeShopItemProxy();
		commonGameplayExchangeShopItemProxy.UpdateFromPayShopGoods(this.GoodsData);
		base.ShopItemProxy = commonGameplayExchangeShopItemProxy;
		this.UpdateShopItemResource();
	}

	// Token: 0x06011E2C RID: 73260 RVA: 0x004666D5 File Offset: 0x004648D5
	public virtual void UpdateShopItemResource()
	{
		base.ShopItemResource = "UiItem_ShopItem";
	}

	// Token: 0x06011E2D RID: 73261 RVA: 0x004666E4 File Offset: 0x004648E4
	public virtual void UpdateTipTitleItem()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		string buyLimitText = this.GoodsData.GetBuyLimitText();
		base.TipTitleItemVisible = !StringUtils.IsEmpty(buyLimitText);
	}

	// Token: 0x06011E2E RID: 73262 RVA: 0x00466718 File Offset: 0x00464918
	public void UpdateCurrency()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		int currencyId = this.GoodsData.GetPriceData().CurrencyId;
		base.CurrencyId = currencyId;
		base.CurrencyIdList = new List<int>
		{
			currencyId
		};
	}

	// Token: 0x06011E2F RID: 73263 RVA: 0x00466758 File Offset: 0x00464958
	public void UpdatePrice()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		int nowPrice = this.GoodsData.GetGoodsData().GetNowPrice();
		base.Price = nowPrice;
	}

	// Token: 0x06011E30 RID: 73264 RVA: 0x00466788 File Offset: 0x00464988
	public void UpdateDescribeText()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		TableTextArgNew data = new TableTextArgNew(InventoryConfig.Instance.GetItemConfigData(this.GoodsData.GetGoodsData().ItemId).AttributesDescription, Array.Empty<object>());
		base.DescribeTextData.SetData(data);
	}

	// Token: 0x06011E31 RID: 73265 RVA: 0x004667D4 File Offset: 0x004649D4
	public void UpdateLeftTime()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		ValueTuple<EPayCountTimeType, CommonDefine.IPayShowCountDownRemainTime, double> countDownData = this.GoodsData.GetCountDownData();
		if (countDownData.Item3 == 0.0)
		{
			base.LeftTimeItemVisible = false;
			return;
		}
		base.LeftTimeTextVisible = (countDownData.Item1 == EPayCountTimeType.NeverResell);
		if (base.LeftTimeTextVisible)
		{
			base.LeftTimeTextData.SetData(new TableTextArgNew("DownShopItem", Array.Empty<object>()));
		}
		CommonDefine.IPayShowCountDownRemainTime item = countDownData.Item2;
		bool flag = item != null;
		base.LeftTimeItemVisible = flag;
		if (flag)
		{
			CommonDefine.PayShowCountDownRemainTime<string> payShowCountDownRemainTime = item as CommonDefine.PayShowCountDownRemainTime<string>;
			if (payShowCountDownRemainTime != null)
			{
				base.LeftTimeTextData.SetContent(payShowCountDownRemainTime.Value);
				return;
			}
			CommonDefine.IRemainTime remainTime = item as CommonDefine.IRemainTime;
			if (remainTime != null)
			{
				base.LeftTimeTextData.SetData(new TableTextArgNew(remainTime.TextId, new <>z__ReadOnlySingleElementList<object>(remainTime.TimeValue)));
			}
		}
	}

	// Token: 0x06011E32 RID: 73266 RVA: 0x004668A8 File Offset: 0x00464AA8
	public void UpdateLockData()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		if (this.GoodsData.GetIfNeedExtraLimitText())
		{
			string extraLimitText = this.GoodsData.GetExtraLimitText();
			if (extraLimitText != null)
			{
				base.LockItemVisible = true;
				base.LockTextData.SetData(new TableTextArgNew(extraLimitText, Array.Empty<object>()));
				return;
			}
			base.LockItemVisible = false;
			return;
		}
		else if (!this.CheckMoneyEnough())
		{
			base.LockItemVisible = true;
			string exchangePopViewResellText = this.GoodsData.GetExchangePopViewResellText();
			if (!StringUtils.IsEmpty(exchangePopViewResellText))
			{
				base.LockTextData.SetData(new TableTextArgNew(exchangePopViewResellText, Array.Empty<object>()));
				return;
			}
			string currencyName = this.GetCurrencyName();
			base.LockTextData.SetData(new TableTextArgNew("CurrencyNotEnough", new <>z__ReadOnlySingleElementList<object>(currencyName)));
			return;
		}
		else
		{
			if (this.GoodsData.GetCountDownData().Item2 == null)
			{
				base.LockItemVisible = false;
				return;
			}
			string exchangePopViewResellText2 = this.GoodsData.GetExchangePopViewResellText();
			if (!StringUtils.IsEmpty(exchangePopViewResellText2))
			{
				base.LockItemVisible = true;
				base.LockTextData.SetData(new TableTextArgNew(exchangePopViewResellText2, Array.Empty<object>()));
				return;
			}
			base.LockItemVisible = false;
			return;
		}
	}

	// Token: 0x06011E33 RID: 73267 RVA: 0x004669B0 File Offset: 0x00464BB0
	private string GetCurrencyName()
	{
		if (this.GoodsData == null)
		{
			return "";
		}
		int currencyId = this.GoodsData.GetPriceData().CurrencyId;
		return ConfigMultiTextLang.GetLocalTextNew(InventoryConfig.Instance.GetItemConfigData(currencyId).Name, null) ?? "";
	}

	// Token: 0x06011E34 RID: 73268 RVA: 0x004669FB File Offset: 0x00464BFB
	public void UpdateFromPayShopGoods(PayShopGoods payShopGoods)
	{
		this.GoodsData = payShopGoods;
		this.UpdateShopItemData();
		this.UpdateTipTitleItem();
		this.UpdateCurrency();
		this.UpdatePrice();
		this.UpdateDescribeText();
		this.UpdateLeftTime();
		this.UpdateLockData();
	}

	// Token: 0x06011E35 RID: 73269 RVA: 0x00466A30 File Offset: 0x00464C30
	public override void OnConfirmButtonClick(int viewId)
	{
		if (this.GoodsData == null)
		{
			return;
		}
		if (!this.CheckMoneyEnough())
		{
			PayShopGoodsData goodsData = this.GoodsData.GetGoodsData();
			TableTextArgNew tableTextArgNew = new TableTextArgNew(InventoryConfig.Instance.GetItemConfigData(goodsData.Price.Id).Name, Array.Empty<object>());
			ScrollingTipsController.Instance.ShowTipsById("ShopResourceNotEnough", new object[]
			{
				tableTextArgNew
			});
			return;
		}
		this.SendBuyRequest(delegate(bool buySuccess, [Nullable(new byte[]
		{
			2,
			1
		})] List<ActivityBuyItem> buyFailedItems)
		{
			if (buySuccess)
			{
				UiManager.Instance.CloseViewById(viewId, null);
			}
		});
	}

	// Token: 0x06011E36 RID: 73270 RVA: 0x00466AB8 File Offset: 0x00464CB8
	protected void SendBuyRequest([Nullable(new byte[]
	{
		2,
		2,
		1
	})] Action<bool, List<ActivityBuyItem>> callBack = null)
	{
		if (this.GoodsData == null)
		{
			return;
		}
		PayShopGoodsData goodsData = this.GoodsData.GetGoodsData();
		List<ActivityBuyItem> list = new List<ActivityBuyItem>();
		ActivityBuyItem activityBuyItem = ActivityBuyItem.Create();
		activityBuyItem.Id = goodsData.Id;
		activityBuyItem.Count = base.BuyCount;
		list.Add(activityBuyItem);
		PayShopController.Instance.ActivityPayShopBuyRequest(list, callBack);
	}

	// Token: 0x06011E37 RID: 73271 RVA: 0x00466B14 File Offset: 0x00464D14
	public override bool CheckConfirmButtonCanInteract()
	{
		if (this.GoodsData == null)
		{
			return false;
		}
		bool flag = this.GoodsData.IfCanBuy();
		bool enough = this.GoodsData.GetPriceData().Enough;
		bool flag2 = this.GoodsData.IsLocked();
		bool flag3 = this.GoodsData.IsSoldOut();
		return flag && enough && !flag2 && !flag3;
	}

	// Token: 0x06011E38 RID: 73272 RVA: 0x00466B6C File Offset: 0x00464D6C
	public override UiPanelBase ShopItemCreate()
	{
		this.ShopItem = new GameplayShopItem();
		return this.ShopItem;
	}

	// Token: 0x06011E39 RID: 73273 RVA: 0x00466B7F File Offset: 0x00464D7F
	public override void ShopItemRefresh()
	{
		if (this.ShopItem == null || base.ShopItemProxy == null)
		{
			return;
		}
		GameplayShopItem gameplayShopItem = this.ShopItem as GameplayShopItem;
		if (gameplayShopItem == null)
		{
			return;
		}
		gameplayShopItem.RefreshByData((IGameplayShopItemProxy)base.ShopItemProxy);
	}

	// Token: 0x06011E3A RID: 73274 RVA: 0x00466BB4 File Offset: 0x00464DB4
	public override bool CheckMoneyEnough()
	{
		if (this.GoodsData == null)
		{
			return false;
		}
		PayShopGoodsData goodsData = this.GoodsData.GetGoodsData();
		int id = goodsData.Price.Id;
		return InventoryModel.Instance.GetItemCountByConfigId(id, 0) >= goodsData.GetNowPrice() * base.BuyCount;
	}

	// Token: 0x06011E3B RID: 73275 RVA: 0x00466C01 File Offset: 0x00464E01
	public override void OnResellTimeRefresh()
	{
	}

	// Token: 0x04008782 RID: 34690
	[Nullable(2)]
	protected PayShopGoods GoodsData;

	// Token: 0x04008783 RID: 34691
	[Nullable(2)]
	public UiPanelBase ShopItem;
}
