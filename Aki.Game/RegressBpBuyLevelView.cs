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

// Token: 0x0200147C RID: 5244
[NullableContext(1)]
[Nullable(0)]
public class RegressBpBuyLevelView : UiViewBase
{
	// Token: 0x06009452 RID: 37970 RVA: 0x001FEF69 File Offset: 0x001FD169
	public RegressBpBuyLevelView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009453 RID: 37971 RVA: 0x001FEF74 File Offset: 0x001FD174
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

	// Token: 0x06009454 RID: 37972 RVA: 0x001FF0A4 File Offset: 0x001FD2A4
	private void OnClickCancel()
	{
		base.CloseMe(null);
	}

	// Token: 0x06009455 RID: 37973 RVA: 0x001FF0AD File Offset: 0x001FD2AD
	private void OnClickBuy()
	{
		ActivityRegressController.Instance.RequestBuyBattlePassLevel(this.NumberSelect.GetSelectNumber());
		base.CloseMe(null);
	}

	// Token: 0x06009456 RID: 37974 RVA: 0x001FF0CC File Offset: 0x001FD2CC
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

	// Token: 0x06009457 RID: 37975 RVA: 0x001FF1DB File Offset: 0x001FD3DB
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.BattlePassMainViewHide, new Action(this.OnMainViewHide));
	}

	// Token: 0x06009458 RID: 37976 RVA: 0x001FF1F9 File Offset: 0x001FD3F9
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.BattlePassMainViewHide, new Action(this.OnMainViewHide));
	}

	// Token: 0x06009459 RID: 37977 RVA: 0x001FF217 File Offset: 0x001FD417
	private void OnMainViewHide()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600945A RID: 37978 RVA: 0x001FF220 File Offset: 0x001FD420
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

	// Token: 0x0600945B RID: 37979 RVA: 0x001FF2E5 File Offset: 0x001FD4E5
	private void BeforeEnterPayShop()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600945C RID: 37980 RVA: 0x001FF2EE File Offset: 0x001FD4EE
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600945D RID: 37981 RVA: 0x001FF2F5 File Offset: 0x001FD4F5
	private TableTextArgNew GetExchangeTableText(int selectValue)
	{
		return new TableTextArgNew("Text_BattlePassLevelBuy2_Text", new <>z__ReadOnlySingleElementList<object>(selectValue));
	}

	// Token: 0x0600945E RID: 37982 RVA: 0x001FF30C File Offset: 0x001FD50C
	private void ValueChangeFunction(int selectValue)
	{
		this.Refresh(selectValue);
	}

	// Token: 0x0600945F RID: 37983 RVA: 0x001FF318 File Offset: 0x001FD518
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

	// Token: 0x06009460 RID: 37984 RVA: 0x001FF3D4 File Offset: 0x001FD5D4
	private void RefreshGrids()
	{
		if (this.TargetLevel > 0)
		{
			int targetLevel = this.TargetLevel;
			this.TargetLevel = 0;
			this.RefreshingGridsAsync(targetLevel).ContinueWith(new Action(this.RefreshGrids));
		}
	}

	// Token: 0x06009461 RID: 37985 RVA: 0x001FF414 File Offset: 0x001FD614
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

	// Token: 0x06009462 RID: 37986 RVA: 0x001FF45F File Offset: 0x001FD65F
	protected override void OnDestroy()
	{
		this.TargetLevel = 0;
		this.RewardScrollView = null;
		this.RewardList = null;
		this.NumberSelect.Destroy(null);
		this.NumberSelect = null;
	}

	// Token: 0x040041C7 RID: 16839
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x040041C8 RID: 16840
	[Nullable(2)]
	private List<TItem> RewardList;

	// Token: 0x040041C9 RID: 16841
	[Nullable(2)]
	private NumberSelectComponent NumberSelect;

	// Token: 0x040041CA RID: 16842
	private int CurrentLevel;

	// Token: 0x040041CB RID: 16843
	private int CostId;

	// Token: 0x040041CC RID: 16844
	private int CostCount;

	// Token: 0x040041CD RID: 16845
	private int TargetLevel;

	// Token: 0x040041CE RID: 16846
	private bool IsRefreshingGrids;

	// Token: 0x02007A9F RID: 31391
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402857F RID: 165247
		public const int ItemScrollView = 0;

		// Token: 0x04028580 RID: 165248
		public const int TxtTitle = 1;

		// Token: 0x04028581 RID: 165249
		public const int BtnCancel = 2;

		// Token: 0x04028582 RID: 165250
		public const int BtnBuy = 3;

		// Token: 0x04028583 RID: 165251
		public const int TxtDescribe = 4;

		// Token: 0x04028584 RID: 165252
		public const int NumberControlItem = 5;

		// Token: 0x04028585 RID: 165253
		public const int TxtCost = 6;

		// Token: 0x04028586 RID: 165254
		public const int InsufficientTip = 7;

		// Token: 0x04028587 RID: 165255
		public const int IconCost = 8;

		// Token: 0x04028588 RID: 165256
		public const int TxtInsufficient = 9;
	}
}
