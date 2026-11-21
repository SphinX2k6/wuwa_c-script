using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020014C3 RID: 5315
[NullableContext(1)]
[Nullable(0)]
public class CommonExchangeView : UiTickViewBase
{
	// Token: 0x0600D4A5 RID: 54437 RVA: 0x003F35B5 File Offset: 0x003F17B5
	private CommonExchangeData GetExChangeData()
	{
		return ((CommonExchangeViewData)this.OpenParam).ExchangeData;
	}

	// Token: 0x0600D4A6 RID: 54438 RVA: 0x003F35C7 File Offset: 0x003F17C7
	private int GetExChangeItemId()
	{
		return this.GetExChangeData().GetDestItemId();
	}

	// Token: 0x0600D4A7 RID: 54439 RVA: 0x003F35D4 File Offset: 0x003F17D4
	public CommonExchangeView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D4A8 RID: 54440 RVA: 0x003F35E0 File Offset: 0x003F17E0
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

	// Token: 0x0600D4A9 RID: 54441 RVA: 0x003F385D File Offset: 0x003F1A5D
	private TableTextArgNew GetExchangeTableText(int selectValue)
	{
		return new TableTextArgNew(TextConfig.Instance.GetTextContentIdById("ExChangeCount"), new <>z__ReadOnlySingleElementList<object>(selectValue));
	}

	// Token: 0x0600D4AA RID: 54442 RVA: 0x003F387E File Offset: 0x003F1A7E
	private void ValueChangeFunction(int selectValue)
	{
		this.Refresh(selectValue);
	}

	// Token: 0x0600D4AB RID: 54443 RVA: 0x003F3888 File Offset: 0x003F1A88
	protected override UniTask OnBeforeStartAsync()
	{
		CommonExchangeView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonExchangeView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D4AC RID: 54444 RVA: 0x003F38CC File Offset: 0x003F1ACC
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

	// Token: 0x0600D4AD RID: 54445 RVA: 0x003F39B4 File Offset: 0x003F1BB4
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

	// Token: 0x0600D4AE RID: 54446 RVA: 0x003F3A7E File Offset: 0x003F1C7E
	private void BeforeEnterPayShop()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600D4AF RID: 54447 RVA: 0x003F3A88 File Offset: 0x003F1C88
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

	// Token: 0x0600D4B0 RID: 54448 RVA: 0x003F3B28 File Offset: 0x003F1D28
	protected void SetMaxValue()
	{
		this.NumberSelect.SelectMax();
	}

	// Token: 0x0600D4B1 RID: 54449 RVA: 0x003F3B38 File Offset: 0x003F1D38
	private void InitConfirmState()
	{
		int maxExchangeTime = this.CurrentExchangeViewData.MaxExchangeTime;
		base.GetInteractionGroup(10).SetInteractable(maxExchangeTime > 0);
	}

	// Token: 0x0600D4B2 RID: 54450 RVA: 0x003F3B64 File Offset: 0x003F1D64
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

	// Token: 0x0600D4B3 RID: 54451 RVA: 0x003F3C78 File Offset: 0x003F1E78
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

	// Token: 0x0600D4B4 RID: 54452 RVA: 0x003F3CC4 File Offset: 0x003F1EC4
	protected override void OnBeforeDestroy()
	{
		CommonCurrencyItem currencyItem = this.CurrencyItem;
		if (currencyItem == null)
		{
			return;
		}
		currencyItem.Destroy(null);
	}

	// Token: 0x0600D4B5 RID: 54453 RVA: 0x003F3CD8 File Offset: 0x003F1ED8
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

	// Token: 0x04007782 RID: 30594
	[Nullable(2)]
	private NumberSelectComponent NumberSelect;

	// Token: 0x04007783 RID: 30595
	[Nullable(2)]
	private CommonCurrencyItem CurrencyItem;

	// Token: 0x04007784 RID: 30596
	[Nullable(2)]
	private CommonExchangeViewData CurrentExchangeViewData;

	// Token: 0x02007788 RID: 30600
	[NullableContext(0)]
	private class ECommonExchangeCom
	{
		// Token: 0x04026CE0 RID: 158944
		public const int TitleText = 0;

		// Token: 0x04026CE1 RID: 158945
		public const int SrcTexture = 1;

		// Token: 0x04026CE2 RID: 158946
		public const int DestTexture = 2;

		// Token: 0x04026CE3 RID: 158947
		public const int SrcNameText = 3;

		// Token: 0x04026CE4 RID: 158948
		public const int DestNameText = 4;

		// Token: 0x04026CE5 RID: 158949
		public const int ConsumeTexture = 5;

		// Token: 0x04026CE6 RID: 158950
		public const int ConsumeCountText = 6;

		// Token: 0x04026CE7 RID: 158951
		public const int CancelBtn = 7;

		// Token: 0x04026CE8 RID: 158952
		public const int ConfirmBtn = 8;

		// Token: 0x04026CE9 RID: 158953
		public const int CancelInteractionGroup = 9;

		// Token: 0x04026CEA RID: 158954
		public const int ConfirmInteractionGroup = 10;

		// Token: 0x04026CEB RID: 158955
		public const int SrcNameCountText = 11;

		// Token: 0x04026CEC RID: 158956
		public const int DestNameCountText = 12;

		// Token: 0x04026CED RID: 158957
		public const int NumberSelect = 13;

		// Token: 0x04026CEE RID: 158958
		public const int NoEnoughItem = 14;
	}
}
