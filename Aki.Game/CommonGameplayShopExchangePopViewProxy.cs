using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;

// Token: 0x02001823 RID: 6179
[NullableContext(1)]
[Nullable(0)]
public class CommonGameplayShopExchangePopViewProxy : AbstractGameplayShopExchangePopViewProxy
{
	// Token: 0x0600F2DB RID: 62171 RVA: 0x00473768 File Offset: 0x00471968
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

	// Token: 0x0600F2DC RID: 62172 RVA: 0x0047379D File Offset: 0x0047199D
	public virtual void UpdateShopItemResource()
	{
		base.ShopItemResource = "UiItem_ShopItem";
	}

	// Token: 0x0600F2DD RID: 62173 RVA: 0x004737AC File Offset: 0x004719AC
	public virtual void UpdateTipTitleItem()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		string buyLimitText = this.GoodsData.GetBuyLimitText();
		base.TipTitleItemVisible = !StringUtils.IsEmpty(buyLimitText);
	}

	// Token: 0x0600F2DE RID: 62174 RVA: 0x004737E0 File Offset: 0x004719E0
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

	// Token: 0x0600F2DF RID: 62175 RVA: 0x00473820 File Offset: 0x00471A20
	public void UpdatePrice()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		int nowPrice = this.GoodsData.GetGoodsData().GetNowPrice();
		base.Price = nowPrice;
	}

	// Token: 0x0600F2E0 RID: 62176 RVA: 0x00473850 File Offset: 0x00471A50
	public void UpdateDescribeText()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		TableTextArgNew data = new TableTextArgNew(InventoryConfig.Instance.GetItemConfigData(this.GoodsData.GetGoodsData().ItemId).AttributesDescription, Array.Empty<object>());
		base.DescribeTextData.SetData(data);
	}

	// Token: 0x0600F2E1 RID: 62177 RVA: 0x0047389C File Offset: 0x00471A9C
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

	// Token: 0x0600F2E2 RID: 62178 RVA: 0x00473970 File Offset: 0x00471B70
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

	// Token: 0x0600F2E3 RID: 62179 RVA: 0x00473A78 File Offset: 0x00471C78
	private string GetCurrencyName()
	{
		if (this.GoodsData == null)
		{
			return "";
		}
		int currencyId = this.GoodsData.GetPriceData().CurrencyId;
		return ConfigMultiTextLang.GetLocalTextNew(InventoryConfig.Instance.GetItemConfigData(currencyId).Name, null) ?? "";
	}

	// Token: 0x0600F2E4 RID: 62180 RVA: 0x00473AC3 File Offset: 0x00471CC3
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

	// Token: 0x0600F2E5 RID: 62181 RVA: 0x00473AF8 File Offset: 0x00471CF8
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

	// Token: 0x0600F2E6 RID: 62182 RVA: 0x00473B80 File Offset: 0x00471D80
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

	// Token: 0x0600F2E7 RID: 62183 RVA: 0x00473BDC File Offset: 0x00471DDC
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

	// Token: 0x0600F2E8 RID: 62184 RVA: 0x00473C34 File Offset: 0x00471E34
	public override UiPanelBase ShopItemCreate()
	{
		this.ShopItem = new GameplayShopItem();
		return this.ShopItem;
	}

	// Token: 0x0600F2E9 RID: 62185 RVA: 0x00473C47 File Offset: 0x00471E47
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

	// Token: 0x0600F2EA RID: 62186 RVA: 0x00473C7C File Offset: 0x00471E7C
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

	// Token: 0x0600F2EB RID: 62187 RVA: 0x00473CC9 File Offset: 0x00471EC9
	public override void OnResellTimeRefresh()
	{
	}

	// Token: 0x040088C5 RID: 35013
	[Nullable(2)]
	protected PayShopGoods GoodsData;

	// Token: 0x040088C6 RID: 35014
	[Nullable(2)]
	public UiPanelBase ShopItem;
}
