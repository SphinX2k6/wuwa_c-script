using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001FF0 RID: 8176
[NullableContext(1)]
[Nullable(0)]
public class CommonExchangeView : UiTickViewBase
{
	// Token: 0x0601003D RID: 65597 RVA: 0x003E6FBD File Offset: 0x003E51BD
	private CommonExchangeData GetExChangeData()
	{
		return ((CommonExchangeViewData)this.OpenParam).ExchangeData;
	}

	// Token: 0x0601003E RID: 65598 RVA: 0x003E6FCF File Offset: 0x003E51CF
	private int GetExChangeItemId()
	{
		return this.GetExChangeData().GetDestItemId();
	}

	// Token: 0x0601003F RID: 65599 RVA: 0x003E6FDC File Offset: 0x003E51DC
	public CommonExchangeView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010040 RID: 65600 RVA: 0x003E6FE8 File Offset: 0x003E51E8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 15;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIInteractionGroup));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIInteractionGroup));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.CancelBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.ConfirmBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06010041 RID: 65601 RVA: 0x003E7265 File Offset: 0x003E5465
	private TableTextArgNew GetExchangeTableText(int selectValue)
	{
		return new TableTextArgNew(TextConfig.Instance.GetTextContentIdById("ExChangeCount"), new <>z__ReadOnlySingleElementList<object>(selectValue));
	}

	// Token: 0x06010042 RID: 65602 RVA: 0x003E7286 File Offset: 0x003E5486
	private void ValueChangeFunction(int selectValue)
	{
		this.Refresh(selectValue);
	}

	// Token: 0x06010043 RID: 65603 RVA: 0x003E7290 File Offset: 0x003E5490
	protected override UniTask OnBeforeStartAsync()
	{
		CommonExchangeView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonExchangeView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010044 RID: 65604 RVA: 0x003E72D4 File Offset: 0x003E54D4
	protected override void OnStart()
	{
		IUiPopFrameInterface childPopView = this.ChildPopView;
		if (childPopView != null)
		{
			childPopView.PopItem.OverrideBackBtnCallBack(new Action(this.CancelBtn));
		}
		CommonExchangeData exChangeData = this.GetExChangeData();
		LguiUtil.Instance.SetLocalText(base.GetText(0), "ExChangeTitle", new <>z__ReadOnlySingleElementList<object>(exChangeData.GetDestName()));
		base.SetItemIcon(base.GetTexture(1), exChangeData.GetSrcItemId(), null, null);
		base.SetItemIcon(base.GetTexture(2), exChangeData.GetDestItemId(), null, null);
		base.SetItemIcon(base.GetTexture(5), exChangeData.GetSrcItemId(), null, null);
		this.InitNumberSelect();
		if (this.CurrentExchangeViewData.StartSliderValue > 0)
		{
			NumberSelectComponent numberSelect = this.NumberSelect;
			if (numberSelect != null)
			{
				numberSelect.ChangeValue(this.CurrentExchangeViewData.StartSliderValue, false);
			}
		}
		this.InitConfirmState();
	}

	// Token: 0x06010045 RID: 65605 RVA: 0x003E73BC File Offset: 0x003E55BC
	protected override void OnBeforeShow()
	{
		if (this.GetExChangeData().ShowPayGold)
		{
			CommonCurrencyItem currencyItem = this.CurrencyItem;
			if (currencyItem != null)
			{
				UUIItem originalItem = currencyItem.GetOriginalItem();
				if (originalItem != null)
				{
					IUiPopFrameInterface childPopView = this.ChildPopView;
					UUIItem inParent;
					if (childPopView == null)
					{
						inParent = null;
					}
					else
					{
						CommonPopViewBase popItem = childPopView.PopItem;
						inParent = ((popItem != null) ? popItem.GetCostParent() : null);
					}
					originalItem.SetUIParent(inParent, false);
				}
			}
			int playerMoney = PlayerInfoModel.Instance.GetPlayerMoney(4);
			this.CurrencyItem.RefreshTemp(4, playerMoney.ToString());
			this.CurrencyItem.RefreshAddButtonActive();
			this.CurrencyItem.SetBeforeButtonFunction(new Action(this.BeforeEnterPayShop));
			this.CurrencyItem.SetToPayShopFunction();
		}
		IUiPopFrameInterface childPopView2 = this.ChildPopView;
		if (childPopView2 == null)
		{
			return;
		}
		childPopView2.PopItem.SetCurrencyItemList(this.CurrentExchangeViewData.ShowCurrencyList.ToArray());
	}

	// Token: 0x06010046 RID: 65606 RVA: 0x003E7486 File Offset: 0x003E5686
	private void BeforeEnterPayShop()
	{
		base.CloseMe(null);
	}

	// Token: 0x06010047 RID: 65607 RVA: 0x003E7490 File Offset: 0x003E5690
	private void InitNumberSelect()
	{
		this.NumberSelect = new NumberSelectComponent(base.GetItem(13));
		this.NumberSelect.SetLimitMaxValueForce(99999);
		int maxExchangeTime = this.CurrentExchangeViewData.MaxExchangeTime;
		INumberSelectData data = new INumberSelectData
		{
			MaxNumber = maxExchangeTime,
			GetExchangeTableText = new Func<int, TableTextArgNew>(this.GetExchangeTableText),
			ValueChangeFunction = new Action<int>(this.ValueChangeFunction)
		};
		this.NumberSelect.Init(data);
		this.NumberSelect.SetMaxBtnShowState(true);
		this.NumberSelect.SetAddReduceButtonActive(true);
		this.NumberSelect.SetAddReduceButtonInteractive(maxExchangeTime > 1);
	}

	// Token: 0x06010048 RID: 65608 RVA: 0x003E7530 File Offset: 0x003E5730
	protected void SetMaxValue()
	{
		this.NumberSelect.SelectMax();
	}

	// Token: 0x06010049 RID: 65609 RVA: 0x003E7540 File Offset: 0x003E5740
	private void InitConfirmState()
	{
		int maxExchangeTime = this.CurrentExchangeViewData.MaxExchangeTime;
		base.GetInteractionGroup(10).SetInteractable(maxExchangeTime > 0);
	}

	// Token: 0x0601004A RID: 65610 RVA: 0x003E756C File Offset: 0x003E576C
	private void Refresh(int exchangeTime)
	{
		CommonExchangeData exChangeData = this.GetExChangeData();
		int exChangeItemId = this.GetExChangeItemId();
		int num = this.CurrentExchangeViewData.GetConsumeCount(exChangeItemId, exchangeTime);
		base.GetText(3).SetText(exChangeData.GetSrcName(), true);
		LguiUtil.Instance.SetLocalText(base.GetText(11), "ExChangeCountDescribe2", new <>z__ReadOnlySingleElementList<object>(num));
		int num2 = this.CurrentExchangeViewData.GetGainCount(exChangeItemId, exchangeTime);
		base.GetText(4).SetText(exChangeData.GetDestName(), true);
		LguiUtil.Instance.SetLocalText(base.GetText(12), "ExChangeCountDescribe2", new <>z__ReadOnlySingleElementList<object>(num2));
		UUIText text = base.GetText(6);
		int num3 = this.CurrentExchangeViewData.GetConsumeTotalCount(num, exchangeTime);
		text.SetText(num3.ToString(), true);
		int ownSrcItemNum = this.CurrentExchangeViewData.OwnSrcItemNum;
		UUIItem uuiitem = text;
		bool bUseChangeColor = ownSrcItemNum < num3;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		base.GetItem(14).SetUIActive(ownSrcItemNum < num3);
	}

	// Token: 0x0601004B RID: 65611 RVA: 0x003E7680 File Offset: 0x003E5880
	private void ConfirmBtn()
	{
		CommonExchangeData exChangeData = this.GetExChangeData();
		if (exChangeData != null && exChangeData.ConfirmCallBack != null)
		{
			int selectNumber = this.NumberSelect.GetSelectNumber();
			exChangeData.ConfirmCallBack(exChangeData.GetDestItemId(), selectNumber);
		}
		if (!exChangeData.ConfirmNoClose)
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x0601004C RID: 65612 RVA: 0x003E76CC File Offset: 0x003E58CC
	protected override void OnBeforeDestroy()
	{
		CommonCurrencyItem currencyItem = this.CurrencyItem;
		if (currencyItem == null)
		{
			return;
		}
		currencyItem.Destroy(null);
	}

	// Token: 0x0601004D RID: 65613 RVA: 0x003E76E0 File Offset: 0x003E58E0
	private void CancelBtn()
	{
		CommonExchangeData exChangeData = this.GetExChangeData();
		Action action = (exChangeData != null) ? exChangeData.CancelCallBack : null;
		if (action != null)
		{
			action();
		}
		base.CloseMe(null);
	}

	// Token: 0x04007699 RID: 30361
	[Nullable(2)]
	private NumberSelectComponent NumberSelect;

	// Token: 0x0400769A RID: 30362
	[Nullable(2)]
	private CommonCurrencyItem CurrencyItem;

	// Token: 0x0400769B RID: 30363
	[Nullable(2)]
	private CommonExchangeViewData CurrentExchangeViewData;

	// Token: 0x02008601 RID: 34305
	[NullableContext(0)]
	private class ECommonExchangeCom
	{
		// Token: 0x0402B9D1 RID: 178641
		public const int TitleText = 0;

		// Token: 0x0402B9D2 RID: 178642
		public const int SrcTexture = 1;

		// Token: 0x0402B9D3 RID: 178643
		public const int DestTexture = 2;

		// Token: 0x0402B9D4 RID: 178644
		public const int SrcNameText = 3;

		// Token: 0x0402B9D5 RID: 178645
		public const int DestNameText = 4;

		// Token: 0x0402B9D6 RID: 178646
		public const int ConsumeTexture = 5;

		// Token: 0x0402B9D7 RID: 178647
		public const int ConsumeCountText = 6;

		// Token: 0x0402B9D8 RID: 178648
		public const int CancelBtn = 7;

		// Token: 0x0402B9D9 RID: 178649
		public const int ConfirmBtn = 8;

		// Token: 0x0402B9DA RID: 178650
		public const int CancelInteractionGroup = 9;

		// Token: 0x0402B9DB RID: 178651
		public const int ConfirmInteractionGroup = 10;

		// Token: 0x0402B9DC RID: 178652
		public const int SrcNameCountText = 11;

		// Token: 0x0402B9DD RID: 178653
		public const int DestNameCountText = 12;

		// Token: 0x0402B9DE RID: 178654
		public const int NumberSelect = 13;

		// Token: 0x0402B9DF RID: 178655
		public const int NoEnoughItem = 14;
	}
}
