using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000930 RID: 2352
[NullableContext(1)]
[Nullable(0)]
public class RegressBpBuyLevelView : UiViewBase
{
	// Token: 0x060067E7 RID: 26599 RVA: 0x00207ECD File Offset: 0x002060CD
	public RegressBpBuyLevelView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060067E8 RID: 26600 RVA: 0x00207ED8 File Offset: 0x002060D8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUITexture)),
			new ValueTuple<int, Type>(9, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickCancel)),
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickBuy))
		};
	}

	// Token: 0x060067E9 RID: 26601 RVA: 0x00208008 File Offset: 0x00206208
	private void OnClickCancel()
	{
		base.CloseMe(null);
	}

	// Token: 0x060067EA RID: 26602 RVA: 0x00208011 File Offset: 0x00206211
	private void OnClickBuy()
	{
		ActivityRegressController.Instance.RequestBuyBattlePassLevel(this.NumberSelect.GetSelectNumber());
		base.CloseMe(null);
	}

	// Token: 0x060067EB RID: 26603 RVA: 0x00208030 File Offset: 0x00206230
	protected override void OnStart()
	{
		this.CurrentLevel = ActivityRegressModel.Instance.ActivityData.GetCurLevelProgressData().Level;
		RegressDisposableReward? regressDisposableReward = ActivityRegressConfig.Instance.GetRegressDisposableReward(ActivityRegressModel.Instance.ActivityData.Id);
		if (regressDisposableReward == null)
		{
			return;
		}
		this.CostId = regressDisposableReward.Value.BuyLvConsumeItem;
		ItemInfo? config = ItemConfig.Instance.GetConfig(this.CostId);
		this.CostCount = regressDisposableReward.Value.BuyLvConsumeNum;
		base.SetTextureByPath(config.Value.IconSmall, base.GetTexture(8), null, null);
		LguiUtil.Instance.SetLocalText(base.GetText(9), "CurrencyNotEnough", new <>z__ReadOnlySingleElementList<object>(ConfigMultiTextLang.GetLocalTextNew(config.Value.Name, null)));
		this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(0), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, null);
		this.RewardList = new List<TItem>();
	}

	// Token: 0x060067EC RID: 26604 RVA: 0x0020813F File Offset: 0x0020633F
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.BattlePassMainViewHide, new Action(this.OnMainViewHide));
	}

	// Token: 0x060067ED RID: 26605 RVA: 0x0020815D File Offset: 0x0020635D
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.BattlePassMainViewHide, new Action(this.OnMainViewHide));
	}

	// Token: 0x060067EE RID: 26606 RVA: 0x0020817B File Offset: 0x0020637B
	private void OnMainViewHide()
	{
		base.CloseMe(null);
	}

	// Token: 0x060067EF RID: 26607 RVA: 0x00208184 File Offset: 0x00206384
	protected override void OnBeforeShow()
	{
		IUiPopFrameInterface childPopView = this.ChildPopView;
		CommonPopViewBase commonPopViewBase = (childPopView != null) ? childPopView.PopItem : null;
		if (commonPopViewBase != null)
		{
			commonPopViewBase.SetCurrencyItemList(new int[]
			{
				this.CostId
			});
			CommonCurrencyItem commonCurrencyItem = commonPopViewBase.GetCurrencyComponent().GetCurrencyItemList()[0];
			commonCurrencyItem.SetBeforeButtonFunction(new Action(this.BeforeEnterPayShop));
			commonCurrencyItem.SetToPayShopFunction();
		}
		this.NumberSelect = new NumberSelectComponent(base.GetItem(5));
		INumberSelectData data = new INumberSelectData
		{
			MaxNumber = ActivityRegressModel.Instance.ActivityData.GetMaxLevel() - this.CurrentLevel,
			GetExchangeTableText = new Func<int, TableTextArgNew>(this.GetExchangeTableText),
			ValueChangeFunction = new Action<int>(this.ValueChangeFunction)
		};
		this.NumberSelect.Init(data);
	}

	// Token: 0x060067F0 RID: 26608 RVA: 0x00208249 File Offset: 0x00206449
	private void BeforeEnterPayShop()
	{
		base.CloseMe(null);
	}

	// Token: 0x060067F1 RID: 26609 RVA: 0x00208252 File Offset: 0x00206452
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x060067F2 RID: 26610 RVA: 0x00208259 File Offset: 0x00206459
	private TableTextArgNew GetExchangeTableText(int selectValue)
	{
		return new TableTextArgNew("Text_BattlePassLevelBuy2_Text", new <>z__ReadOnlySingleElementList<object>(selectValue));
	}

	// Token: 0x060067F3 RID: 26611 RVA: 0x00208270 File Offset: 0x00206470
	private void ValueChangeFunction(int selectValue)
	{
		this.Refresh(selectValue);
	}

	// Token: 0x060067F4 RID: 26612 RVA: 0x0020827C File Offset: 0x0020647C
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

	// Token: 0x060067F5 RID: 26613 RVA: 0x00208338 File Offset: 0x00206538
	private void RefreshGrids()
	{
		if (this.TargetLevel > 0)
		{
			int targetLevel = this.TargetLevel;
			this.TargetLevel = 0;
			this.RefreshingGridsAsync(targetLevel).ContinueWith(new Action(this.RefreshGrids));
		}
	}

	// Token: 0x060067F6 RID: 26614 RVA: 0x00208378 File Offset: 0x00206578
	private UniTask RefreshingGridsAsync(int targetLevel)
	{
		RegressBpBuyLevelView.<RefreshingGridsAsync>d__24 <RefreshingGridsAsync>d__;
		<RefreshingGridsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshingGridsAsync>d__.<>4__this = this;
		<RefreshingGridsAsync>d__.targetLevel = targetLevel;
		<RefreshingGridsAsync>d__.<>1__state = -1;
		<RefreshingGridsAsync>d__.<>t__builder.Start<RegressBpBuyLevelView.<RefreshingGridsAsync>d__24>(ref <RefreshingGridsAsync>d__);
		return <RefreshingGridsAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060067F7 RID: 26615 RVA: 0x002083C3 File Offset: 0x002065C3
	protected override void OnDestroy()
	{
		this.TargetLevel = 0;
		this.RewardScrollView = null;
		this.RewardList = null;
		this.NumberSelect.Destroy(null);
		this.NumberSelect = null;
	}

	// Token: 0x0400425F RID: 16991
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x04004260 RID: 16992
	[Nullable(2)]
	private List<TItem> RewardList;

	// Token: 0x04004261 RID: 16993
	[Nullable(2)]
	private NumberSelectComponent NumberSelect;

	// Token: 0x04004262 RID: 16994
	private int CurrentLevel;

	// Token: 0x04004263 RID: 16995
	private int CostId;

	// Token: 0x04004264 RID: 16996
	private int CostCount;

	// Token: 0x04004265 RID: 16997
	private int TargetLevel;

	// Token: 0x04004266 RID: 16998
	private bool IsRefreshingGrids;

	// Token: 0x02006C23 RID: 27683
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023899 RID: 145561
		public const int ItemScrollView = 0;

		// Token: 0x0402389A RID: 145562
		public const int TxtTitle = 1;

		// Token: 0x0402389B RID: 145563
		public const int BtnCancel = 2;

		// Token: 0x0402389C RID: 145564
		public const int BtnBuy = 3;

		// Token: 0x0402389D RID: 145565
		public const int TxtDescribe = 4;

		// Token: 0x0402389E RID: 145566
		public const int NumberControlItem = 5;

		// Token: 0x0402389F RID: 145567
		public const int TxtCost = 6;

		// Token: 0x040238A0 RID: 145568
		public const int InsufficientTip = 7;

		// Token: 0x040238A1 RID: 145569
		public const int IconCost = 8;

		// Token: 0x040238A2 RID: 145570
		public const int TxtInsufficient = 9;
	}
}
