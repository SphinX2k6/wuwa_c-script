using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Shop;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x020013E7 RID: 5095
[NullableContext(1)]
[Nullable(0)]
public class PinballShopExchangePopViewProxy : AbstractGameplayShopExchangePopViewProxy
{
	// Token: 0x06008FD1 RID: 36817 RVA: 0x001F1A60 File Offset: 0x001EFC60
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

	// Token: 0x06008FD2 RID: 36818 RVA: 0x001F1A8F File Offset: 0x001EFC8F
	public void UpdateShopItemResource()
	{
		base.ShopItemResource = "UiItem_CatapultStoryShopItem";
	}

	// Token: 0x06008FD3 RID: 36819 RVA: 0x001F1A9C File Offset: 0x001EFC9C
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

	// Token: 0x06008FD4 RID: 36820 RVA: 0x001F1AEC File Offset: 0x001EFCEC
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

	// Token: 0x06008FD5 RID: 36821 RVA: 0x001F1B38 File Offset: 0x001EFD38
	public void UpdatePrice()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		int nowPrice = this.GoodsData.GetGoodsData().GetNowPrice();
		base.Price = nowPrice;
	}

	// Token: 0x06008FD6 RID: 36822 RVA: 0x001F1B68 File Offset: 0x001EFD68
	public void UpdateDescribeText()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		string attributesDescription = InventoryConfig.Instance.GetItemConfigData(this.GoodsData.GetGoodsData().ItemId).AttributesDescription;
		base.DescribeTextData.SetData(new TableTextArgNew(attributesDescription, Array.Empty<object>()));
	}

	// Token: 0x06008FD7 RID: 36823 RVA: 0x001F1BB4 File Offset: 0x001EFDB4
	public void UpdateLeftTime()
	{
		base.LeftTimeItemVisible = false;
		base.LeftTimeTextVisible = false;
	}

	// Token: 0x06008FD8 RID: 36824 RVA: 0x001F1BC4 File Offset: 0x001EFDC4
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

	// Token: 0x06008FD9 RID: 36825 RVA: 0x001F1CCC File Offset: 0x001EFECC
	private string GetCurrencyName()
	{
		if (this.GoodsData == null)
		{
			return "";
		}
		int currencyId = this.GoodsData.GetPriceData().CurrencyId;
		return ConfigMultiTextLang.GetLocalTextNew(InventoryConfig.Instance.GetItemConfigData(currencyId).Name, null) ?? "";
	}

	// Token: 0x06008FDA RID: 36826 RVA: 0x001F1D18 File Offset: 0x001EFF18
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

	// Token: 0x06008FDB RID: 36827 RVA: 0x001F1D60 File Offset: 0x001EFF60
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

	// Token: 0x06008FDC RID: 36828 RVA: 0x001F1DB8 File Offset: 0x001EFFB8
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

	// Token: 0x06008FDD RID: 36829 RVA: 0x001F1E40 File Offset: 0x001F0040
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(payShopBuyResponse.ErrorCode, 25381, null, true, true);
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

	// Token: 0x06008FDE RID: 36830 RVA: 0x001F1EC4 File Offset: 0x001F00C4
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

	// Token: 0x06008FDF RID: 36831 RVA: 0x001F1F1C File Offset: 0x001F011C
	public override UiPanelBase ShopItemCreate()
	{
		this.ShopItem = new PinballShopItem();
		return this.ShopItem;
	}

	// Token: 0x06008FE0 RID: 36832 RVA: 0x001F1F30 File Offset: 0x001F0130
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

	// Token: 0x06008FE1 RID: 36833 RVA: 0x001F1F70 File Offset: 0x001F0170
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

	// Token: 0x06008FE2 RID: 36834 RVA: 0x001F1FBD File Offset: 0x001F01BD
	public override void OnResellTimeRefresh()
	{
		this.UpdateLeftTime();
		this.UpdateLockData();
	}

	// Token: 0x06008FE3 RID: 36835 RVA: 0x001F1FCC File Offset: 0x001F01CC
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
		if (itemConfigData != null && itemDataTypeByConfigId == InventoryDefine.EItemDataType.RoleItem && itemConfigData.ShowTypes.Contains(30))
		{
			num2 = 1;
		}
		if (itemConfigData.ShowTypes.Contains(30))
		{
			int[] resonantItemRoleId = RoleModel.Instance.GetResonantItemRoleId(goodsData.ItemId);
			int num3 = RoleModel.Instance.GetRoleLeftResonantCountWithInventoryItem(resonantItemRoleId[0]);
			num3 = ((num3 == 0) ? 1 : num3);
			num2 = ((num2 > num3) ? num3 : num2);
		}
		base.MaxBuyCount = num2;
	}

	// Token: 0x06008FE4 RID: 36836 RVA: 0x001F20EE File Offset: 0x001F02EE
	public void UpdateExchangeTableTextId()
	{
		base.ExchangeTableTextId = "";
	}

	// Token: 0x04003F97 RID: 16279
	[Nullable(2)]
	protected PayShopGoods GoodsData;

	// Token: 0x04003F98 RID: 16280
	[Nullable(2)]
	public UiPanelBase ShopItem;
}
