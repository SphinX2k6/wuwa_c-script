using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Shop;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x0200089B RID: 2203
[NullableContext(1)]
[Nullable(0)]
public class PinballShopExchangePopViewProxy : AbstractGameplayShopExchangePopViewProxy
{
	// Token: 0x06006366 RID: 25446 RVA: 0x001FA59C File Offset: 0x001F879C
	public void UpdateShopItemData()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		PinballExchangeShopItemProxy pinballExchangeShopItemProxy = new PinballExchangeShopItemProxy();
		pinballExchangeShopItemProxy.UpdateFromPayShopGoods(this.GoodsData);
		base.ShopItemProxy = pinballExchangeShopItemProxy;
	}

	// Token: 0x06006367 RID: 25447 RVA: 0x001FA5CB File Offset: 0x001F87CB
	public void UpdateShopItemResource()
	{
		base.ShopItemResource = "UiItem_CatapultStoryShopItem";
	}

	// Token: 0x06006368 RID: 25448 RVA: 0x001FA5D8 File Offset: 0x001F87D8
	public void UpdateTipTitleItem()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		string buyLimitText = this.GoodsData.GetBuyLimitText();
		base.TipTitleItemVisible = !StringUtils.IsEmpty(buyLimitText);
		if (base.TipTitleItemVisible)
		{
			base.LimitTextData.SetData(new TableTextArgNew(buyLimitText, Array.Empty<object>()));
		}
	}

	// Token: 0x06006369 RID: 25449 RVA: 0x001FA628 File Offset: 0x001F8828
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
		base.CurrencyItemResourceId = "UiItem_CostBtn";
	}

	// Token: 0x0600636A RID: 25450 RVA: 0x001FA674 File Offset: 0x001F8874
	public void UpdatePrice()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		int nowPrice = this.GoodsData.GetGoodsData().GetNowPrice();
		base.Price = nowPrice;
	}

	// Token: 0x0600636B RID: 25451 RVA: 0x001FA6A4 File Offset: 0x001F88A4
	public void UpdateDescribeText()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		string attributesDescription = InventoryConfig.Instance.GetItemConfigData(this.GoodsData.GetGoodsData().ItemId).AttributesDescription;
		base.DescribeTextData.SetData(new TableTextArgNew(attributesDescription, Array.Empty<object>()));
	}

	// Token: 0x0600636C RID: 25452 RVA: 0x001FA6F0 File Offset: 0x001F88F0
	public void UpdateLeftTime()
	{
		base.LeftTimeItemVisible = false;
		base.LeftTimeTextVisible = false;
	}

	// Token: 0x0600636D RID: 25453 RVA: 0x001FA700 File Offset: 0x001F8900
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

	// Token: 0x0600636E RID: 25454 RVA: 0x001FA808 File Offset: 0x001F8A08
	private string GetCurrencyName()
	{
		if (this.GoodsData == null)
		{
			return "";
		}
		int currencyId = this.GoodsData.GetPriceData().CurrencyId;
		return ConfigMultiTextLang.GetLocalTextNew(InventoryConfig.Instance.GetItemConfigData(currencyId).Name, null) ?? "";
	}

	// Token: 0x0600636F RID: 25455 RVA: 0x001FA854 File Offset: 0x001F8A54
	public void UpdateLimitTextData()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		string buyLimitText = this.GoodsData.GetBuyLimitText();
		base.LimitTextItemVisible = !StringUtils.IsEmpty(buyLimitText);
		if (base.LimitTextItemVisible)
		{
			base.LimitTextData.SetContent(buyLimitText);
		}
	}

	// Token: 0x06006370 RID: 25456 RVA: 0x001FA89C File Offset: 0x001F8A9C
	public void UpdateFromPayShopGoods(PayShopGoods payShopGoods)
	{
		this.GoodsData = payShopGoods;
		this.UpdateShopItemData();
		this.UpdateShopItemResource();
		this.UpdateTipTitleItem();
		this.UpdateCurrency();
		this.UpdatePrice();
		this.UpdateDescribeText();
		this.UpdateLeftTime();
		this.UpdateLimitTextData();
		this.UpdateLockData();
		this.UpdateMaxBuyCount();
		this.UpdateExchangeTableTextId();
	}

	// Token: 0x06006371 RID: 25457 RVA: 0x001FA8F4 File Offset: 0x001F8AF4
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

	// Token: 0x06006372 RID: 25458 RVA: 0x001FA97C File Offset: 0x001F8B7C
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
		PayShopBuyRequest payShopBuyRequest = PayShopBuyRequest.Create();
		payShopBuyRequest.Id = goodsData.Id;
		payShopBuyRequest.Count = base.BuyCount;
		payShopBuyRequest.Version = PayShopModel.Instance.Version;
		Net.Instance.Call(ERequestMessageId.PayShopBuyRequest, payShopBuyRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PayShopBuyResponse payShopBuyResponse = (PayShopBuyResponse)msg;
			if (payShopBuyResponse == null)
			{
				Action<bool, List<ActivityBuyItem>> callBack2 = callBack;
				if (callBack2 == null)
				{
					return;
				}
				callBack2(false, null);
				return;
			}
			else if (payShopBuyResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
			{
				PayShopModel.Instance.UpdatePayShopGoodsCount(payShopBuyResponse.Id, payShopBuyResponse.Count);
				List<ActivityBuyItem> p = new List<ActivityBuyItem>
				{
					new ActivityBuyItem
					{
						Id = payShopBuyResponse.Id,
						Count = payShopBuyResponse.Count
					}
				};
				EventSystem.Instance.Emit<int, IReadOnlyList<ActivityBuyItem>, string>(EEventName.ActivityPayShopGoodsBuy, goodsData.ShopId, p, PayShopModel.Instance.Version);
				EventSystem.Instance.Emit(EEventName.PayShopGoodsBuy);
				Action<bool, List<ActivityBuyItem>> callBack3 = callBack;
				if (callBack3 == null)
				{
					return;
				}
				callBack3(true, null);
				return;
			}
			else
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(payShopBuyResponse.ErrorCode, 19539, null, true, true);
				Action<bool, List<ActivityBuyItem>> callBack4 = callBack;
				if (callBack4 == null)
				{
					return;
				}
				callBack4(false, null);
				return;
			}
		}, 0);
	}

	// Token: 0x06006373 RID: 25459 RVA: 0x001FAA00 File Offset: 0x001F8C00
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

	// Token: 0x06006374 RID: 25460 RVA: 0x001FAA58 File Offset: 0x001F8C58
	public override UiPanelBase ShopItemCreate()
	{
		this.ShopItem = new PinballShopItem();
		return this.ShopItem;
	}

	// Token: 0x06006375 RID: 25461 RVA: 0x001FAA6C File Offset: 0x001F8C6C
	public override void ShopItemRefresh()
	{
		PinballShopItem pinballShopItem = this.ShopItem as PinballShopItem;
		PinballExchangeShopItemProxy pinballExchangeShopItemProxy = base.ShopItemProxy as PinballExchangeShopItemProxy;
		if (pinballShopItem == null || pinballExchangeShopItemProxy == null)
		{
			return;
		}
		pinballShopItem.RefreshByData(pinballExchangeShopItemProxy);
		pinballShopItem.HideItemCost();
		pinballShopItem.SetItemFrameVisible(false);
	}

	// Token: 0x06006376 RID: 25462 RVA: 0x001FAAAC File Offset: 0x001F8CAC
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

	// Token: 0x06006377 RID: 25463 RVA: 0x001FAAF9 File Offset: 0x001F8CF9
	public override void OnResellTimeRefresh()
	{
		this.UpdateLeftTime();
		this.UpdateLockData();
	}

	// Token: 0x06006378 RID: 25464 RVA: 0x001FAB08 File Offset: 0x001F8D08
	public void UpdateMaxBuyCount()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		PayShopGoodsData goodsData = this.GoodsData.GetGoodsData();
		if (goodsData == null)
		{
			return;
		}
		int id = goodsData.Price.Id;
		int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(id, 0);
		int nowPrice = goodsData.GetNowPrice();
		int num = (nowPrice > 0) ? (itemCountByConfigId / nowPrice) : int.MaxValue;
		int num2;
		if (goodsData.HasBuyLimit())
		{
			num2 = Math.Min(goodsData.GetRemainingCount(), num);
		}
		else
		{
			num2 = num;
		}
		if (goodsData.HasOnceBuyLimit())
		{
			num2 = Math.Min(num2, goodsData.OnceBuyLimit);
		}
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(goodsData.ItemId);
		InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(goodsData.ItemId));
		if (itemConfigData != null && itemDataTypeByConfigId == InventoryDefine.EItemDataType.RoleItem && Array.IndexOf<int>(itemConfigData.ShowTypes, 30) >= 0)
		{
			num2 = 1;
		}
		if (Array.IndexOf<int>(itemConfigData.ShowTypes, 30) >= 0)
		{
			int[] resonantItemRoleId = RoleModel.Instance.GetResonantItemRoleId(goodsData.ItemId);
			int num3 = RoleModel.Instance.GetRoleLeftResonantCountWithInventoryItem(resonantItemRoleId[0]);
			num3 = ((num3 == 0) ? 1 : num3);
			num2 = ((num2 > num3) ? num3 : num2);
		}
		base.MaxBuyCount = num2;
	}

	// Token: 0x06006379 RID: 25465 RVA: 0x001FAC2C File Offset: 0x001F8E2C
	public void UpdateExchangeTableTextId()
	{
		base.ExchangeTableTextId = "";
	}

	// Token: 0x0400402F RID: 16431
	[Nullable(2)]
	protected PayShopGoods GoodsData;

	// Token: 0x04004030 RID: 16432
	[Nullable(2)]
	public UiPanelBase ShopItem;
}
