using System;
using System.Collections.Generic;
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

// Token: 0x02001878 RID: 6264
[NullableContext(2)]
[Nullable(0)]
public class ExchangePopView : UiViewBase
{
	// Token: 0x170017D8 RID: 6104
	// (get) Token: 0x0600F804 RID: 63492 RVA: 0x00488BDB File Offset: 0x00486DDB
	private int BuyCount
	{
		get
		{
			return this.NumberSelect.GetSelectNumber();
		}
	}

	// Token: 0x0600F805 RID: 63493 RVA: 0x00488BE8 File Offset: 0x00486DE8
	[NullableContext(1)]
	public ExchangePopView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F806 RID: 63494 RVA: 0x00488BF8 File Offset: 0x00486DF8
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

	// Token: 0x0600F807 RID: 63495 RVA: 0x00488F00 File Offset: 0x00487100
	protected override void OnBeforeCreate()
	{
		ExchangePopData exchangePopData = (ExchangePopData)this.OpenParam;
		this.Goods = exchangePopData.PayShopGoods;
	}

	// Token: 0x0600F808 RID: 63496 RVA: 0x00488F28 File Offset: 0x00487128
	protected override UniTask OnCreateAsync()
	{
		ExchangePopView.<OnCreateAsync>d__14 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>4__this = this;
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<ExchangePopView.<OnCreateAsync>d__14>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F809 RID: 63497 RVA: 0x00488F6B File Offset: 0x0048716B
	private void CancelClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600F80A RID: 63498 RVA: 0x00488F74 File Offset: 0x00487174
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

	// Token: 0x0600F80B RID: 63499 RVA: 0x0048900C File Offset: 0x0048720C
	private bool NeedShowSecondConfirm()
	{
		PayShopGoodsData goodsData = this.Goods.GetGoodsData();
		return goodsData != null && goodsData.ConfirmLimitCount > 0 && this.BuyCount >= goodsData.ConfirmLimitCount;
	}

	// Token: 0x0600F80C RID: 63500 RVA: 0x00489048 File Offset: 0x00487248
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

	// Token: 0x0600F80D RID: 63501 RVA: 0x00489160 File Offset: 0x00487360
	private void SendBuyRequest()
	{
		PayShopGoodsData goodsData = this.Goods.GetGoodsData();
		PayShopController.Instance.SendRequestPayShopBuy(goodsData.Id, this.BuyCount);
	}

	// Token: 0x0600F80E RID: 63502 RVA: 0x0048918F File Offset: 0x0048738F
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.PayShopGoodsBuy, new Action(this.CancelClick));
		EventSystem.Instance.Add(EEventName.DiscountShopTimerRefresh, new Action(this.OnDiscountShopTimerRefresh));
	}

	// Token: 0x0600F80F RID: 63503 RVA: 0x004891C9 File Offset: 0x004873C9
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.PayShopGoodsBuy, new Action(this.CancelClick));
		EventSystem.Instance.Remove(EEventName.DiscountShopTimerRefresh, new Action(this.OnDiscountShopTimerRefresh));
	}

	// Token: 0x0600F810 RID: 63504 RVA: 0x00489203 File Offset: 0x00487403
	private void OnDiscountShopTimerRefresh()
	{
		this.RefreshView();
	}

	// Token: 0x0600F811 RID: 63505 RVA: 0x0048920B File Offset: 0x0048740B
	[NullableContext(1)]
	private TableTextArgNew GetExchangeTableText(int selectValue)
	{
		return new TableTextArgNew(TextConfig.Instance.GetTextContentIdById("BugCount"), new <>z__ReadOnlySingleElementList<object>(selectValue));
	}

	// Token: 0x0600F812 RID: 63506 RVA: 0x0048922C File Offset: 0x0048742C
	private void ValueChangeFunction(int selectValue)
	{
		this.SetPrice();
	}

	// Token: 0x0600F813 RID: 63507 RVA: 0x00489234 File Offset: 0x00487434
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

	// Token: 0x0600F814 RID: 63508 RVA: 0x004892F1 File Offset: 0x004874F1
	private void RefreshNumberSelectComponentButtonState()
	{
		if (this.NumberSelect.GetIfLimit())
		{
			this.NumberSelect.SetAddReduceButtonActive(true);
			this.NumberSelect.SetAddReduceButtonInteractive(false);
		}
	}

	// Token: 0x0600F815 RID: 63509 RVA: 0x00489318 File Offset: 0x00487518
	protected override void OnBeforeShow()
	{
		base.GetText(10).SetUIActive(false);
		base.GetText(16).SetUIActive(false);
		this.RefreshView();
		this.SetPriceIcon();
		this.RefreshCurrency().Forget();
	}

	// Token: 0x0600F816 RID: 63510 RVA: 0x00489350 File Offset: 0x00487550
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

	// Token: 0x0600F817 RID: 63511 RVA: 0x004893E0 File Offset: 0x004875E0
	private UniTask RefreshCurrency()
	{
		ExchangePopView.<RefreshCurrency>d__29 <RefreshCurrency>d__;
		<RefreshCurrency>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshCurrency>d__.<>4__this = this;
		<RefreshCurrency>d__.<>1__state = -1;
		<RefreshCurrency>d__.<>t__builder.Start<ExchangePopView.<RefreshCurrency>d__29>(ref <RefreshCurrency>d__);
		return <RefreshCurrency>d__.<>t__builder.Task;
	}

	// Token: 0x0600F818 RID: 63512 RVA: 0x00489423 File Offset: 0x00487623
	private void BeforeEnterPayShop()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600F819 RID: 63513 RVA: 0x0048942C File Offset: 0x0048762C
	protected override void OnBeforeDestroy()
	{
		this.NumberSelect.Destroy(null);
		this.ShowItem.Destroy(null);
		this.RemoveResellTimer();
	}

	// Token: 0x0600F81A RID: 63514 RVA: 0x0048944C File Offset: 0x0048764C
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
		if (itemConfigData != null && itemDataTypeByConfigId == InventoryDefine.EItemDataType.RoleItem && Array.IndexOf<int>(itemConfigData.ShowTypes, 30) >= 0)
		{
			this.BuyCountMax = 1;
		}
		if (Array.IndexOf<int>(itemConfigData.ShowTypes, 30) >= 0)
		{
			int[] resonantItemRoleId = RoleModel.Instance.GetResonantItemRoleId(goodsData.ItemId);
			int num2 = RoleModel.Instance.GetRoleLeftResonantCountWithInventoryItem(resonantItemRoleId[0]);
			num2 = ((num2 == 0) ? 1 : num2);
			this.BuyCountMax = ((this.BuyCountMax > num2) ? num2 : this.BuyCountMax);
		}
	}

	// Token: 0x0600F81B RID: 63515 RVA: 0x00489590 File Offset: 0x00487790
	protected void SetEndTime()
	{
		if (this.Goods.IsShowTimePreview())
		{
			base.GetText(1).SetUIActive(false);
			base.GetItem(15).SetUIActive(true);
			this.CurrentEndTimeShowState = true;
			base.GetText(14).SetUIActive(true);
			PayShopGoodsData goodsData = this.Goods.GetGoodsData();
			DateTime dataFromTimeStamp = TimeUtil.Instance.GetDataFromTimeStamp((double)goodsData.BeginTime);
			DateTime dataFromTimeStamp2 = TimeUtil.Instance.GetDataFromTimeStamp((double)goodsData.EndTime);
			string text = dataFromTimeStamp.ToString("yyyy.MM.dd HH:mm");
			string text2 = (dataFromTimeStamp2.Year == dataFromTimeStamp.Year) ? dataFromTimeStamp2.ToString("MM.dd HH:mm") : dataFromTimeStamp2.ToString("yyyy.MM.dd HH:mm");
			string item = StringUtils.Format("{0} ~ {1}", new string[]
			{
				text,
				text2
			});
			LguiUtil.Instance.SetLocalTextNew(base.GetText(14), "PreviewTimeText", new <>z__ReadOnlySingleElementList<object>(item));
			return;
		}
		ValueTuple<EPayCountTimeType, CommonDefine.IPayShowCountDownRemainTime, double> countDownData = this.Goods.GetCountDownData();
		if (countDownData.Item3 == 0.0)
		{
			base.GetItem(15).SetUIActive(false);
			this.CurrentEndTimeShowState = false;
			return;
		}
		CommonDefine.IPayShowCountDownRemainTime item2 = this.Goods.GetCountDownData().Item2;
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
		if (item2 != null)
		{
			base.GetItem(15).SetUIActive(true);
			this.CurrentEndTimeShowState = true;
			UUIText text3 = base.GetText(1);
			if (text3 != null)
			{
				text3.SetUIActive(true);
			}
			CommonDefine.PayShowCountDownRemainTime<string> payShowCountDownRemainTime = item2 as CommonDefine.PayShowCountDownRemainTime<string>;
			if (payShowCountDownRemainTime != null)
			{
				text3.SetText(payShowCountDownRemainTime.Value, true);
				return;
			}
			CommonDefine.IRemainTime remainTime = item2 as CommonDefine.IRemainTime;
			if (remainTime != null)
			{
				LguiUtil.Instance.SetLocalText(text3, remainTime.TextId, new <>z__ReadOnlySingleElementList<object>(remainTime.TimeValue));
				return;
			}
		}
		else
		{
			base.GetItem(15).SetUIActive(false);
			this.CurrentEndTimeShowState = false;
		}
	}

	// Token: 0x0600F81C RID: 63516 RVA: 0x004897C4 File Offset: 0x004879C4
	protected void SetInteractionGroup()
	{
		if (this.Goods.IsLocked() || this.Goods.IsSoldOut() || !this.Goods.IfCanBuy() || !this.Goods.GetPriceData().Enough)
		{
			this.BuyInteractionGroup.SetInteractable(false);
			return;
		}
		this.BuyInteractionGroup.SetInteractable(true);
	}

	// Token: 0x0600F81D RID: 63517 RVA: 0x00489824 File Offset: 0x00487A24
	protected void SetPriceIcon()
	{
		PayShopGoodsData goodsData = this.Goods.GetGoodsData();
		UUITexture texture = base.GetTexture(3);
		base.SetItemIcon(texture, goodsData.Price.Id, null, null);
		base.GetText(4).SetText((this.BuyCount * goodsData.GetNowPrice()).ToString(), true);
	}

	// Token: 0x0600F81E RID: 63518 RVA: 0x00489884 File Offset: 0x00487A84
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

	// Token: 0x0600F81F RID: 63519 RVA: 0x004898E4 File Offset: 0x00487AE4
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

	// Token: 0x0600F820 RID: 63520 RVA: 0x00489964 File Offset: 0x00487B64
	protected bool IsEnoughMoney()
	{
		CSharpScript.Game.Module.Inventory.ItemConfig itemConfig = this.Goods.GetGoodsData().GetItemConfig();
		if (itemConfig != null && itemConfig.ShowTypes != null && Array.IndexOf<int>(itemConfig.ShowTypes, 30) >= 0)
		{
			int roleId = RoleModel.Instance.GetResonantItemRoleId(this.Goods.GetGoodsData().ItemId)[0];
			int roleLeftResonantCountWithInventoryItem = RoleModel.Instance.GetRoleLeftResonantCountWithInventoryItem(roleId);
			if (this.BuyCount > roleLeftResonantCountWithInventoryItem)
			{
				return false;
			}
		}
		PayShopGoodsData goodsData = this.Goods.GetGoodsData();
		int id = goodsData.Price.Id;
		return InventoryModel.Instance.GetItemCountByConfigId(id, 0) >= goodsData.GetNowPrice() * this.BuyCount;
	}

	// Token: 0x0600F821 RID: 63521 RVA: 0x00489A0C File Offset: 0x00487C0C
	private void RefreshTimeItem()
	{
		string buyLimitText = this.Goods.GetBuyLimitText();
		bool uiactive = this.CurrentEndTimeShowState || !string.IsNullOrEmpty(buyLimitText);
		base.GetItem(8).SetUIActive(uiactive);
	}

	// Token: 0x0600F822 RID: 63522 RVA: 0x00489A48 File Offset: 0x00487C48
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

	// Token: 0x0600F823 RID: 63523 RVA: 0x00489AAC File Offset: 0x00487CAC
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

	// Token: 0x0600F824 RID: 63524 RVA: 0x00489B1E File Offset: 0x00487D1E
	protected void RemoveResellTimer()
	{
		if (this.ResellTimerId != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.ResellTimerId);
			this.ResellTimerId = null;
		}
	}

	// Token: 0x0600F825 RID: 63525 RVA: 0x00489B40 File Offset: 0x00487D40
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

	// Token: 0x04008AE3 RID: 35555
	[Nullable(1)]
	private const string COLOR = "FED12E";

	// Token: 0x04008AE4 RID: 35556
	private PayShopItem ShowItem;

	// Token: 0x04008AE5 RID: 35557
	protected PayShopGoods Goods;

	// Token: 0x04008AE6 RID: 35558
	private bool CurrentEndTimeShowState = true;

	// Token: 0x04008AE7 RID: 35559
	private UUIInteractionGroup BuyInteractionGroup;

	// Token: 0x04008AE8 RID: 35560
	protected TimerHandle ResellTimerId;

	// Token: 0x04008AE9 RID: 35561
	private int BuyCountMax;

	// Token: 0x04008AEA RID: 35562
	private NumberSelectComponent NumberSelect;

	// Token: 0x02007ABF RID: 31423
	[NullableContext(0)]
	private class EExchangePopViewDefine
	{
		// Token: 0x04027CBA RID: 163002
		public const int EndTimeIcon = 0;

		// Token: 0x04027CBB RID: 163003
		public const int EndTimeText = 1;

		// Token: 0x04027CBC RID: 163004
		public const int ItemAttach = 2;

		// Token: 0x04027CBD RID: 163005
		public const int CurrencyIcon = 3;

		// Token: 0x04027CBE RID: 163006
		public const int CurrencyCount = 4;

		// Token: 0x04027CBF RID: 163007
		public const int DescribeText = 5;

		// Token: 0x04027CC0 RID: 163008
		public const int CancelButton = 6;

		// Token: 0x04027CC1 RID: 163009
		public const int ConfirmButton = 7;

		// Token: 0x04027CC2 RID: 163010
		public const int DateTitleItem = 8;

		// Token: 0x04027CC3 RID: 163011
		public const int NumberSelect = 9;

		// Token: 0x04027CC4 RID: 163012
		public const int LeftTimeText = 10;

		// Token: 0x04027CC5 RID: 163013
		public const int ReSellItem = 11;

		// Token: 0x04027CC6 RID: 163014
		public const int ReSellText = 12;

		// Token: 0x04027CC7 RID: 163015
		public const int ItemPanel = 13;

		// Token: 0x04027CC8 RID: 163016
		public const int DownItemText = 14;

		// Token: 0x04027CC9 RID: 163017
		public const int EndTimeItem = 15;

		// Token: 0x04027CCA RID: 163018
		public const int LeftLimitText = 16;

		// Token: 0x04027CCB RID: 163019
		public const int ItemCurrentNum = 17;

		// Token: 0x04027CCC RID: 163020
		public const int TextCurrentNum = 18;
	}
}
