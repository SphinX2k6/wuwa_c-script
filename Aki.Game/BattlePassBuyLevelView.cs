using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001802 RID: 6146
[NullableContext(1)]
[Nullable(0)]
public class BattlePassBuyLevelView : UiViewBase
{
	// Token: 0x0600F0FA RID: 61690 RVA: 0x0046CAC2 File Offset: 0x0046ACC2
	public BattlePassBuyLevelView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F0FB RID: 61691 RVA: 0x0046CACC File Offset: 0x0046ACCC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickCancel));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickBuy));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600F0FC RID: 61692 RVA: 0x0046CC9F File Offset: 0x0046AE9F
	private void OnClickCancel()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600F0FD RID: 61693 RVA: 0x0046CCA8 File Offset: 0x0046AEA8
	private void OnClickBuy()
	{
		BattlePassController.Instance.RequestBuyBattlePassLevel(this.NumberSelect.GetSelectNumber());
		base.CloseMe(null);
	}

	// Token: 0x0600F0FE RID: 61694 RVA: 0x0046CCC8 File Offset: 0x0046AEC8
	protected override void OnStart()
	{
		this.CurrentLevel = BattlePassModel.Instance.BattlePassLevel;
		BattlePass value = BattlePassConfig.Instance.GetBattlePassData(BattlePassModel.Instance.BattlePassId).Value;
		this.CostId = value.ConsumeId;
		ItemInfo value2 = ItemConfig.Instance.GetConfig(this.CostId).Value;
		this.CostCount = value.ConsumeCount;
		base.SetTextureByPath(value2.IconSmall, base.GetTexture(8), null, null);
		LguiUtil.Instance.SetLocalText(base.GetText(9), "CurrencyNotEnough", new <>z__ReadOnlySingleElementList<object>(ConfigMultiTextLang.GetLocalTextNew(value2.Name, null)));
		this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(0), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, null);
		this.RewardList = new List<TItem>();
	}

	// Token: 0x0600F0FF RID: 61695 RVA: 0x0046CDA9 File Offset: 0x0046AFA9
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.BattlePassMainViewHide, new Action(this.OnMainViewHide));
	}

	// Token: 0x0600F100 RID: 61696 RVA: 0x0046CDC7 File Offset: 0x0046AFC7
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.BattlePassMainViewHide, new Action(this.OnMainViewHide));
	}

	// Token: 0x0600F101 RID: 61697 RVA: 0x0046CDE5 File Offset: 0x0046AFE5
	private void OnMainViewHide()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600F102 RID: 61698 RVA: 0x0046CDF0 File Offset: 0x0046AFF0
	protected override void OnBeforeShow()
	{
		IUiPopFrameInterface childPopView = this.ChildPopView;
		CommonPopViewBase commonPopViewBase = (childPopView != null) ? childPopView.PopItem : null;
		if (commonPopViewBase != null)
		{
			commonPopViewBase.SetCurrencyItemList(new int[]
			{
				this.CostId
			}).Forget();
			CommonCurrencyItem commonCurrencyItem = commonPopViewBase.GetCurrencyComponent().GetCurrencyItemList()[0];
			commonCurrencyItem.SetBeforeButtonFunction(new Action(this.BeforeEnterPayShop));
			commonCurrencyItem.SetToPayShopFunction();
		}
		this.NumberSelect = new NumberSelectComponent(base.GetItem(5));
		INumberSelectData data = new INumberSelectData
		{
			MaxNumber = BattlePassModel.Instance.GetMaxLevel() - this.CurrentLevel,
			GetExchangeTableText = new Func<int, TableTextArgNew>(this.GetExchangeTableText),
			ValueChangeFunction = new Action<int>(this.ValueChangeFunction)
		};
		this.NumberSelect.Init(data);
	}

	// Token: 0x0600F103 RID: 61699 RVA: 0x0046CEB4 File Offset: 0x0046B0B4
	private void BeforeEnterPayShop()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600F104 RID: 61700 RVA: 0x0046CEBD File Offset: 0x0046B0BD
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600F105 RID: 61701 RVA: 0x0046CEC4 File Offset: 0x0046B0C4
	private TableTextArgNew GetExchangeTableText(int selectValue)
	{
		return new TableTextArgNew("Text_BattlePassLevelBuy2_Text", new <>z__ReadOnlySingleElementList<object>(selectValue));
	}

	// Token: 0x0600F106 RID: 61702 RVA: 0x0046CEDB File Offset: 0x0046B0DB
	private void ValueChangeFunction(int selectValue)
	{
		this.Refresh(selectValue);
	}

	// Token: 0x0600F107 RID: 61703 RVA: 0x0046CEE4 File Offset: 0x0046B0E4
	private void Refresh(int buyLevel)
	{
		int num = this.CurrentLevel + buyLevel;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "Text_BattlePassLevelBuy1_Text", new <>z__ReadOnlySingleElementList<object>(num));
		int num2 = buyLevel * this.CostCount;
		UUIText text = base.GetText(6);
		text.SetText(num2.ToString(), true);
		int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(this.CostId, 0);
		UUIItem uuiitem = text;
		bool bUseChangeColor = itemCountByConfigId < num2;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		base.GetButton(3).SetSelfInteractive(itemCountByConfigId >= num2);
		base.GetItem(7).SetUIActive(itemCountByConfigId < num2);
		this.TargetLevel = num;
		if (!this.IsRefreshingGrids)
		{
			this.RefreshGrids();
		}
	}

	// Token: 0x0600F108 RID: 61704 RVA: 0x0046CFA0 File Offset: 0x0046B1A0
	private void RefreshGrids()
	{
		int targetLevel = this.TargetLevel;
		if (targetLevel > 0)
		{
			this.TargetLevel = 0;
			this.RefreshingGrids(targetLevel).ContinueWith(new Action(this.RefreshGrids)).Forget();
		}
	}

	// Token: 0x0600F109 RID: 61705 RVA: 0x0046CFDC File Offset: 0x0046B1DC
	private UniTask RefreshingGrids(int targetLevel)
	{
		BattlePassBuyLevelView.<RefreshingGrids>d__24 <RefreshingGrids>d__;
		<RefreshingGrids>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshingGrids>d__.<>4__this = this;
		<RefreshingGrids>d__.targetLevel = targetLevel;
		<RefreshingGrids>d__.<>1__state = -1;
		<RefreshingGrids>d__.<>t__builder.Start<BattlePassBuyLevelView.<RefreshingGrids>d__24>(ref <RefreshingGrids>d__);
		return <RefreshingGrids>d__.<>t__builder.Task;
	}

	// Token: 0x0600F10A RID: 61706 RVA: 0x0046D027 File Offset: 0x0046B227
	protected override void OnDestroy()
	{
		this.TargetLevel = 0;
		this.RewardScrollView = null;
		this.RewardList.Clear();
		this.RewardList = null;
		this.NumberSelect.Destroy(null);
		this.NumberSelect = null;
	}

	// Token: 0x04008813 RID: 34835
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x04008814 RID: 34836
	[Nullable(2)]
	private List<TItem> RewardList;

	// Token: 0x04008815 RID: 34837
	[Nullable(2)]
	private NumberSelectComponent NumberSelect;

	// Token: 0x04008816 RID: 34838
	private int CurrentLevel;

	// Token: 0x04008817 RID: 34839
	private int CostId;

	// Token: 0x04008818 RID: 34840
	private int CostCount;

	// Token: 0x04008819 RID: 34841
	private int TargetLevel;

	// Token: 0x0400881A RID: 34842
	private bool IsRefreshingGrids;

	// Token: 0x02007A23 RID: 31267
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402796B RID: 162155
		ItemScrollView,
		// Token: 0x0402796C RID: 162156
		TxtTitle,
		// Token: 0x0402796D RID: 162157
		BtnCancel,
		// Token: 0x0402796E RID: 162158
		BtnBuy,
		// Token: 0x0402796F RID: 162159
		TxtDescribe,
		// Token: 0x04027970 RID: 162160
		NumberControlItem,
		// Token: 0x04027971 RID: 162161
		TxtCost,
		// Token: 0x04027972 RID: 162162
		InsufficientTip,
		// Token: 0x04027973 RID: 162163
		IconCost,
		// Token: 0x04027974 RID: 162164
		TxtInsufficient
	}
}
