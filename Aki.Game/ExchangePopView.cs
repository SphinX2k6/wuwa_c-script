using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002393 RID: 9107
[NullableContext(2)]
[Nullable(0)]
public class ExchangePopView : UiViewBase
{
	// Token: 0x1700179E RID: 6046
	// (get) Token: 0x06012352 RID: 74578 RVA: 0x0047B88B File Offset: 0x00479A8B
	private int BuyCount
	{
		get
		{
			return this.NumberSelect.GetSelectNumber();
		}
	}

	// Token: 0x06012353 RID: 74579 RVA: 0x0047B898 File Offset: 0x00479A98
	[NullableContext(1)]
	public ExchangePopView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06012354 RID: 74580 RVA: 0x0047B8A8 File Offset: 0x00479AA8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 19;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.CancelClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.ConfirmClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06012355 RID: 74581 RVA: 0x0047BBB0 File Offset: 0x00479DB0
	protected override void OnBeforeCreate()
	{
		ExchangePopData exchangePopData = (ExchangePopData)this.OpenParam;
		this.Goods = exchangePopData.PayShopGoods;
	}

	// Token: 0x06012356 RID: 74582 RVA: 0x0047BBD8 File Offset: 0x00479DD8
	protected override UniTask OnCreateAsync()
	{
		ExchangePopView.<OnCreateAsync>d__14 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>4__this = this;
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<ExchangePopView.<OnCreateAsync>d__14>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012357 RID: 74583 RVA: 0x0047BC1B File Offset: 0x00479E1B
	private void CancelClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06012358 RID: 74584 RVA: 0x0047BC24 File Offset: 0x00479E24
	private void ConfirmClick()
	{
		PayShopGoodsData goodsData = this.Goods.GetGoodsData();
		if (!this.IsEnoughMoney())
		{
			TableTextArgNew tableTextArgNew = new TableTextArgNew(InventoryConfig.Instance.GetItemConfigData(goodsData.Price.Id).Name, Array.Empty<object>());
			ScrollingTipsController.Instance.ShowTipsById("ShopResourceNotEnough", new object[]
			{
				tableTextArgNew
			});
			return;
		}
		ExchangePopData exchangePopData = (ExchangePopData)this.OpenParam;
		if (exchangePopData.CheckIfCanBuy != null && !exchangePopData.CheckIfCanBuy())
		{
			return;
		}
		if (this.NeedShowSecondConfirm())
		{
			this.ShowBuySecondConfirmBox();
			return;
		}
		this.SendBuyRequest();
	}

	// Token: 0x06012359 RID: 74585 RVA: 0x0047BCBC File Offset: 0x00479EBC
	private bool NeedShowSecondConfirm()
	{
		PayShopGoodsData goodsData = this.Goods.GetGoodsData();
		return goodsData != null && goodsData.ConfirmLimitCount > 0 && this.BuyCount >= goodsData.ConfirmLimitCount;
	}

	// Token: 0x0601235A RID: 74586 RVA: 0x0047BCF8 File Offset: 0x00479EF8
	private void ShowBuySecondConfirmBox()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.BuyItemSecondConfirm);
		confirmBoxDataNew.CanClickDuringTimer = false;
		confirmBoxDataNew.FunctionMap[2] = new Action(this.SendBuyRequest);
		PayShopGoodsData goodsData = this.Goods.GetGoodsData();
		CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(goodsData.Price.Id);
		string str = StringUtils.Format("<texture={0}>", new string[]
		{
			itemConfigData.IconSmall
		});
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(itemConfigData.Name, null);
		int num = this.BuyCount * goodsData.GetNowPrice();
		CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData2 = InventoryConfig.Instance.GetItemConfigData(goodsData.ItemId);
		string str2 = StringUtils.Format("<texture={0}>", new string[]
		{
			itemConfigData2.IconSmall
		});
		string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(itemConfigData2.Name, null);
		confirmBoxDataNew.SetTextArgs(new string[]
		{
			str + localTextNew,
			num.ToString(),
			str2 + localTextNew2,
			this.BuyCount.ToString()
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0601235B RID: 74587 RVA: 0x0047BE10 File Offset: 0x0047A010
	private void SendBuyRequest()
	{
		PayShopGoodsData goodsData = this.Goods.GetGoodsData();
		PayShopController.Instance.SendRequestPayShopBuy(goodsData.Id, this.BuyCount);
	}

	// Token: 0x0601235C RID: 74588 RVA: 0x0047BE3F File Offset: 0x0047A03F
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.PayShopGoodsBuy, new Action(this.CancelClick));
		EventSystem.Instance.Add(EEventName.DiscountShopTimerRefresh, new Action(this.OnDiscountShopTimerRefresh));
	}

	// Token: 0x0601235D RID: 74589 RVA: 0x0047BE79 File Offset: 0x0047A079
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.PayShopGoodsBuy, new Action(this.CancelClick));
		EventSystem.Instance.Remove(EEventName.DiscountShopTimerRefresh, new Action(this.OnDiscountShopTimerRefresh));
	}

	// Token: 0x0601235E RID: 74590 RVA: 0x0047BEB3 File Offset: 0x0047A0B3
	private void OnDiscountShopTimerRefresh()
	{
		this.RefreshView();
	}

	// Token: 0x0601235F RID: 74591 RVA: 0x0047BEBB File Offset: 0x0047A0BB
	[NullableContext(1)]
	private TableTextArgNew GetExchangeTableText(int selectValue)
	{
		return new TableTextArgNew(TextConfig.Instance.GetTextContentIdById("BugCount"), new <>z__ReadOnlySingleElementList<object>(selectValue));
	}

	// Token: 0x06012360 RID: 74592 RVA: 0x0047BEDC File Offset: 0x0047A0DC
	private void ValueChangeFunction(int selectValue)
	{
		this.SetPrice();
	}

	// Token: 0x06012361 RID: 74593 RVA: 0x0047BEE4 File Offset: 0x0047A0E4
	protected override void OnStart()
	{
		this.SetMaxCanBuyCount();
		this.BuyInteractionGroup = (base.GetButton(7).GetOwner().GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup);
		this.NumberSelect = new NumberSelectComponent(base.GetItem(9));
		INumberSelectData data = new INumberSelectData
		{
			MaxNumber = this.BuyCountMax,
			GetExchangeTableText = new Func<int, TableTextArgNew>(this.GetExchangeTableText),
			ValueChangeFunction = new Action<int>(this.ValueChangeFunction)
		};
		this.NumberSelect.Init(data);
		this.NumberSelect.SetMaxBtnShowState(this.Goods.GetGoodsData().IsBuyMaxButton);
		this.RefreshNumberSelectComponentButtonState();
		base.GetItem(13).SetUIActive(true);
	}

	// Token: 0x06012362 RID: 74594 RVA: 0x0047BFA1 File Offset: 0x0047A1A1
	private void RefreshNumberSelectComponentButtonState()
	{
		if (this.NumberSelect.GetIfLimit())
		{
			this.NumberSelect.SetAddReduceButtonActive(true);
			this.NumberSelect.SetAddReduceButtonInteractive(false);
		}
	}

	// Token: 0x06012363 RID: 74595 RVA: 0x0047BFC8 File Offset: 0x0047A1C8
	protected override void OnBeforeShow()
	{
		base.GetText(10).SetUIActive(false);
		base.GetText(16).SetUIActive(false);
		this.RefreshView();
		this.SetPriceIcon();
		this.RefreshCurrency().Forget();
	}

	// Token: 0x06012364 RID: 74596 RVA: 0x0047C000 File Offset: 0x0047A200
	private void RefreshView()
	{
		UUIItem item = base.GetItem(2);
		this.ShowItem.GetOriginalItem().SetUIParent(item, false);
		this.ShowItem.HideExchangePopViewElement();
		if (this.Goods.GetGoodsData().HasOnceBuyLimit())
		{
			this.ShowItem.SetNeedShowOnceBuyLimit(true);
		}
		this.ShowItem.Refresh(this.Goods, false, 0);
		this.SetEndTime();
		this.SetInteractionGroup();
		this.SetNameAndDescribe();
		this.RefreshReSellText();
		this.RefreshLeftTimeText();
		this.RefreshTimeItem();
		this.RefreshCurrentNum();
	}

	// Token: 0x06012365 RID: 74597 RVA: 0x0047C090 File Offset: 0x0047A290
	private UniTask RefreshCurrency()
	{
		ExchangePopView.<RefreshCurrency>d__29 <RefreshCurrency>d__;
		<RefreshCurrency>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshCurrency>d__.<>4__this = this;
		<RefreshCurrency>d__.<>1__state = -1;
		<RefreshCurrency>d__.<>t__builder.Start<ExchangePopView.<RefreshCurrency>d__29>(ref <RefreshCurrency>d__);
		return <RefreshCurrency>d__.<>t__builder.Task;
	}

	// Token: 0x06012366 RID: 74598 RVA: 0x0047C0D3 File Offset: 0x0047A2D3
	private void BeforeEnterPayShop()
	{
		base.CloseMe(null);
	}

	// Token: 0x06012367 RID: 74599 RVA: 0x0047C0DC File Offset: 0x0047A2DC
	protected override void OnBeforeDestroy()
	{
		this.NumberSelect.Destroy(null);
		this.ShowItem.Destroy(null);
		this.RemoveResellTimer();
	}

	// Token: 0x06012368 RID: 74600 RVA: 0x0047C0FC File Offset: 0x0047A2FC
	protected void SetMaxCanBuyCount()
	{
		ExchangePopData exchangePopData = (ExchangePopData)this.OpenParam;
		if (exchangePopData.GetMaxBuyCount != null)
		{
			this.BuyCountMax = exchangePopData.GetMaxBuyCount();
			return;
		}
		PayShopGoodsData goodsData = this.Goods.GetGoodsData();
		int id = goodsData.Price.Id;
		int num = InventoryModel.Instance.GetItemCountByConfigId(id, 0) / goodsData.GetNowPrice();
		if (goodsData.HasBuyLimit())
		{
			this.BuyCountMax = Math.Min(goodsData.GetRemainingCount(), num);
		}
		else
		{
			this.BuyCountMax = num;
		}
		if (goodsData.HasOnceBuyLimit())
		{
			this.BuyCountMax = Math.Min(this.BuyCountMax, goodsData.OnceBuyLimit);
		}
		CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(goodsData.ItemId);
		InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(goodsData.ItemId));
		if (itemConfigData != null && itemDataTypeByConfigId == InventoryDefine.EItemDataType.RoleItem && itemConfigData.ShowTypes.ToList<int>().Contains(30))
		{
			this.BuyCountMax = 1;
		}
		if (itemConfigData.ShowTypes.ToList<int>().Contains(30))
		{
			int[] resonantItemRoleId = RoleModel.Instance.GetResonantItemRoleId(goodsData.ItemId);
			int num2 = RoleModel.Instance.GetRoleLeftResonantCountWithInventoryItem(resonantItemRoleId[0]);
			num2 = ((num2 == 0) ? 1 : num2);
			this.BuyCountMax = ((this.BuyCountMax > num2) ? num2 : this.BuyCountMax);
		}
	}

	// Token: 0x06012369 RID: 74601 RVA: 0x0047C248 File Offset: 0x0047A448
	protected void SetEndTime()
	{
		ValueTuple<EPayCountTimeType, CommonDefine.IPayShowCountDownRemainTime, double> countDownData = this.Goods.GetCountDownData();
		if (countDownData.Item3 == 0.0)
		{
			base.GetItem(15).SetUIActive(false);
			this.CurrentEndTimeShowState = false;
			return;
		}
		CommonDefine.IPayShowCountDownRemainTime item = this.Goods.GetCountDownData().Item2;
		base.GetText(14).SetUIActive(countDownData.Item1 == EPayCountTimeType.NeverResell);
		if (countDownData.Item1 == EPayCountTimeType.NeverResell)
		{
			base.GetText(14).ShowTextNew("DownShopItem");
		}
		else if (countDownData.Item1 == EPayCountTimeType.Resell)
		{
			base.GetText(14).ShowTextNew("ReUpShopItem");
		}
		else if (countDownData.Item1 == EPayCountTimeType.Discount)
		{
			base.GetText(14).ShowTextNew("DiscountItem");
		}
		if (item != null)
		{
			base.GetItem(15).SetUIActive(true);
			this.CurrentEndTimeShowState = true;
			UUIText text = base.GetText(1);
			CommonDefine.PayShowCountDownRemainTime<string> payShowCountDownRemainTime = item as CommonDefine.PayShowCountDownRemainTime<string>;
			if (payShowCountDownRemainTime != null)
			{
				text.SetText(payShowCountDownRemainTime.Value, true);
				return;
			}
			CommonDefine.IRemainTime remainTime = item as CommonDefine.IRemainTime;
			if (remainTime != null)
			{
				LguiUtil.Instance.SetLocalText(text, remainTime.TextId, new <>z__ReadOnlySingleElementList<object>(remainTime.TimeValue));
				return;
			}
		}
		else
		{
			base.GetItem(15).SetUIActive(false);
			this.CurrentEndTimeShowState = false;
		}
	}

	// Token: 0x0601236A RID: 74602 RVA: 0x0047C384 File Offset: 0x0047A584
	protected void SetInteractionGroup()
	{
		if (this.Goods.IsLocked() || this.Goods.IsSoldOut() || !this.Goods.IfCanBuy() || !this.Goods.GetPriceData().Enough)
		{
			this.BuyInteractionGroup.SetInteractable(false);
			return;
		}
		this.BuyInteractionGroup.SetInteractable(true);
	}

	// Token: 0x0601236B RID: 74603 RVA: 0x0047C3E4 File Offset: 0x0047A5E4
	protected void SetPriceIcon()
	{
		PayShopGoodsData goodsData = this.Goods.GetGoodsData();
		UUITexture texture = base.GetTexture(3);
		base.SetItemIcon(texture, goodsData.Price.Id, null, null);
		base.GetText(4).SetText((this.BuyCount * goodsData.GetNowPrice()).ToString(), true);
	}

	// Token: 0x0601236C RID: 74604 RVA: 0x0047C444 File Offset: 0x0047A644
	protected void SetPrice()
	{
		PayShopGoodsData goodsData = this.Goods.GetGoodsData();
		UUIText text = base.GetText(4);
		int num = this.BuyCount * goodsData.GetNowPrice();
		bool flag = this.IsEnoughMoney();
		UUIItem uuiitem = text;
		bool bUseChangeColor = !flag;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		text.SetText(num.ToString(), true);
	}

	// Token: 0x0601236D RID: 74605 RVA: 0x0047C4A4 File Offset: 0x0047A6A4
	protected void SetNameAndDescribe()
	{
		PayShopGoodsData goodsData = this.Goods.GetGoodsData();
		string key;
		if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(goodsData.ItemId)) == InventoryDefine.EItemDataType.RoleItem)
		{
			key = RoleConfig.Instance.GetRoleConfig(goodsData.ItemId).Value.Introduction;
		}
		else
		{
			key = InventoryConfig.Instance.GetItemConfigData(goodsData.ItemId).AttributesDescription;
		}
		base.GetText(5).ShowTextNew(key);
	}

	// Token: 0x0601236E RID: 74606 RVA: 0x0047C524 File Offset: 0x0047A724
	protected bool IsEnoughMoney()
	{
		CSharpScript.Game.Module.Inventory.ItemConfig itemConfig = this.Goods.GetGoodsData().GetItemConfig();
		if (itemConfig != null)
		{
			int[] showTypes = itemConfig.ShowTypes;
			if (showTypes != null && showTypes.ToList<int>().Contains(30))
			{
				int roleId = RoleModel.Instance.GetResonantItemRoleId(this.Goods.GetGoodsData().ItemId)[0];
				int roleLeftResonantCountWithInventoryItem = RoleModel.Instance.GetRoleLeftResonantCountWithInventoryItem(roleId);
				if (this.BuyCount > roleLeftResonantCountWithInventoryItem)
				{
					return false;
				}
			}
		}
		PayShopGoodsData goodsData = this.Goods.GetGoodsData();
		int id = goodsData.Price.Id;
		return InventoryModel.Instance.GetItemCountByConfigId(id, 0) >= goodsData.GetNowPrice() * this.BuyCount;
	}

	// Token: 0x0601236F RID: 74607 RVA: 0x0047C5CC File Offset: 0x0047A7CC
	private void RefreshTimeItem()
	{
		string buyLimitText = this.Goods.GetBuyLimitText();
		bool uiactive = this.CurrentEndTimeShowState || !string.IsNullOrEmpty(buyLimitText);
		base.GetItem(8).SetUIActive(uiactive);
	}

	// Token: 0x06012370 RID: 74608 RVA: 0x0047C608 File Offset: 0x0047A808
	private void RefreshLeftTimeText()
	{
		string exchangeViewShopTipsText = this.Goods.GetExchangeViewShopTipsText();
		UUIText text;
		if (this.CurrentEndTimeShowState)
		{
			text = base.GetText(10);
		}
		else
		{
			text = base.GetText(16);
		}
		text.SetUIActive(exchangeViewShopTipsText != "");
		text.SetText(exchangeViewShopTipsText, true);
		if (text != null)
		{
			text.SetColor(FColor.FromHex("FED12E"));
		}
	}

	// Token: 0x06012371 RID: 74609 RVA: 0x0047C66C File Offset: 0x0047A86C
	private void RefreshCurrentNum()
	{
		PayShopGoodsData goodsData = this.Goods.GetGoodsData();
		if (goodsData.IsShowHaveNum)
		{
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(goodsData.ItemId, 0);
			base.GetItem(17).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(18), "CurrentHoldText", new <>z__ReadOnlySingleElementList<object>(itemCountByConfigId));
			return;
		}
		base.GetItem(17).SetUIActive(false);
	}

	// Token: 0x06012372 RID: 74610 RVA: 0x0047C6DE File Offset: 0x0047A8DE
	protected void RemoveResellTimer()
	{
		if (this.ResellTimerId != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.ResellTimerId);
			this.ResellTimerId = null;
		}
	}

	// Token: 0x06012373 RID: 74611 RVA: 0x0047C700 File Offset: 0x0047A900
	private void RefreshReSellText()
	{
		this.RemoveResellTimer();
		string exchangePopViewResellText = this.Goods.GetExchangePopViewResellText();
		if (this.Goods.GetIfNeedExtraLimitText())
		{
			string extraLimitText = this.Goods.GetExtraLimitText();
			if (!string.IsNullOrEmpty(extraLimitText))
			{
				base.GetItem(11).SetUIActive(true);
				base.GetText(12).ShowTextNew(extraLimitText);
			}
			return;
		}
		if (!this.Goods.GetPriceData().Enough)
		{
			base.GetItem(11).SetUIActive(true);
			if (!string.IsNullOrEmpty(exchangePopViewResellText))
			{
				base.GetText(12).ShowTextNew(exchangePopViewResellText);
				return;
			}
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(InventoryConfig.Instance.GetItemConfigData(this.Goods.GetPriceData().CurrencyId).Name, null);
			LguiUtil.Instance.SetLocalText(base.GetText(12), "CurrencyNotEnough", new <>z__ReadOnlySingleElementList<object>(localTextNew));
			return;
		}
		else
		{
			ValueTuple<EPayCountTimeType, CommonDefine.IPayShowCountDownRemainTime, double> countDownData = this.Goods.GetCountDownData();
			if (countDownData.Item1 != EPayCountTimeType.Resell && !this.Goods.GetPriceData().Enough)
			{
				base.GetItem(11).SetUIActive(true);
				string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(CSharpScript.Game.Module.Item.ItemConfig.Instance.GetConfig(this.Goods.GetPriceData().CurrencyId).Value.Name, null);
				LguiUtil.Instance.SetLocalText(base.GetText(12), "CurrencyNotEnough", new <>z__ReadOnlySingleElementList<object>(localTextNew2));
				return;
			}
			if (countDownData.Item2 == null)
			{
				base.GetItem(11).SetUIActive(false);
				base.GetText(12).SetUIActive(false);
				return;
			}
			if (!string.IsNullOrEmpty(exchangePopViewResellText))
			{
				base.GetItem(11).SetUIActive(true);
				base.GetText(12).ShowTextNew(exchangePopViewResellText);
			}
			else
			{
				base.GetItem(11).SetUIActive(false);
			}
			if (countDownData.Item3 > 0.0)
			{
				this.ResellTimerId = TimerSystem.RealTimeInstance.Delay(delegate(float _)
				{
					this.RefreshReSellText();
				}, (float)countDownData.Item3 * 1000f, null, null, false, 1f);
			}
			return;
		}
	}

	// Token: 0x0400899C RID: 35228
	[Nullable(1)]
	private const string COLOR = "FED12E";

	// Token: 0x0400899D RID: 35229
	private PayShopItem ShowItem;

	// Token: 0x0400899E RID: 35230
	protected PayShopGoods Goods;

	// Token: 0x0400899F RID: 35231
	private bool CurrentEndTimeShowState = true;

	// Token: 0x040089A0 RID: 35232
	private UUIInteractionGroup BuyInteractionGroup;

	// Token: 0x040089A1 RID: 35233
	protected TimerHandle ResellTimerId;

	// Token: 0x040089A2 RID: 35234
	private int BuyCountMax;

	// Token: 0x040089A3 RID: 35235
	private NumberSelectComponent NumberSelect;

	// Token: 0x02008934 RID: 35124
	[NullableContext(0)]
	private class EExchangePopViewDefine
	{
		// Token: 0x0402C99C RID: 182684
		public const int EndTimeIcon = 0;

		// Token: 0x0402C99D RID: 182685
		public const int EndTimeText = 1;

		// Token: 0x0402C99E RID: 182686
		public const int ItemAttach = 2;

		// Token: 0x0402C99F RID: 182687
		public const int CurrencyIcon = 3;

		// Token: 0x0402C9A0 RID: 182688
		public const int CurrencyCount = 4;

		// Token: 0x0402C9A1 RID: 182689
		public const int DescribeText = 5;

		// Token: 0x0402C9A2 RID: 182690
		public const int CancelButton = 6;

		// Token: 0x0402C9A3 RID: 182691
		public const int ConfirmButton = 7;

		// Token: 0x0402C9A4 RID: 182692
		public const int DateTitleItem = 8;

		// Token: 0x0402C9A5 RID: 182693
		public const int NumberSelect = 9;

		// Token: 0x0402C9A6 RID: 182694
		public const int LeftTimeText = 10;

		// Token: 0x0402C9A7 RID: 182695
		public const int ReSellItem = 11;

		// Token: 0x0402C9A8 RID: 182696
		public const int ReSellText = 12;

		// Token: 0x0402C9A9 RID: 182697
		public const int ItemPanel = 13;

		// Token: 0x0402C9AA RID: 182698
		public const int DownItemText = 14;

		// Token: 0x0402C9AB RID: 182699
		public const int EndTimeItem = 15;

		// Token: 0x0402C9AC RID: 182700
		public const int LeftLimitText = 16;

		// Token: 0x0402C9AD RID: 182701
		public const int ItemCurrentNum = 17;

		// Token: 0x0402C9AE RID: 182702
		public const int TextCurrentNum = 18;
	}
}
