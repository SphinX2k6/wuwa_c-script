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

// Token: 0x0200231D RID: 8989
[NullableContext(1)]
[Nullable(0)]
public class BattlePassBuyLevelView : UiViewBase
{
	// Token: 0x06011C4A RID: 72778 RVA: 0x0045FA1A File Offset: 0x0045DC1A
	public BattlePassBuyLevelView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011C4B RID: 72779 RVA: 0x0045FA24 File Offset: 0x0045DC24
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

	// Token: 0x06011C4C RID: 72780 RVA: 0x0045FBF7 File Offset: 0x0045DDF7
	private void OnClickCancel()
	{
		base.CloseMe(null);
	}

	// Token: 0x06011C4D RID: 72781 RVA: 0x0045FC00 File Offset: 0x0045DE00
	private void OnClickBuy()
	{
		BattlePassController.Instance.RequestBuyBattlePassLevel(this.NumberSelect.GetSelectNumber());
		base.CloseMe(null);
	}

	// Token: 0x06011C4E RID: 72782 RVA: 0x0045FC20 File Offset: 0x0045DE20
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

	// Token: 0x06011C4F RID: 72783 RVA: 0x0045FD01 File Offset: 0x0045DF01
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.BattlePassMainViewHide, new Action(this.OnMainViewHide));
	}

	// Token: 0x06011C50 RID: 72784 RVA: 0x0045FD1F File Offset: 0x0045DF1F
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.BattlePassMainViewHide, new Action(this.OnMainViewHide));
	}

	// Token: 0x06011C51 RID: 72785 RVA: 0x0045FD3D File Offset: 0x0045DF3D
	private void OnMainViewHide()
	{
		base.CloseMe(null);
	}

	// Token: 0x06011C52 RID: 72786 RVA: 0x0045FD48 File Offset: 0x0045DF48
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

	// Token: 0x06011C53 RID: 72787 RVA: 0x0045FE0C File Offset: 0x0045E00C
	private void BeforeEnterPayShop()
	{
		base.CloseMe(null);
	}

	// Token: 0x06011C54 RID: 72788 RVA: 0x0045FE15 File Offset: 0x0045E015
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06011C55 RID: 72789 RVA: 0x0045FE1C File Offset: 0x0045E01C
	private TableTextArgNew GetExchangeTableText(int selectValue)
	{
		return new TableTextArgNew("Text_BattlePassLevelBuy2_Text", new <>z__ReadOnlySingleElementList<object>(selectValue));
	}

	// Token: 0x06011C56 RID: 72790 RVA: 0x0045FE33 File Offset: 0x0045E033
	private void ValueChangeFunction(int selectValue)
	{
		this.Refresh(selectValue);
	}

	// Token: 0x06011C57 RID: 72791 RVA: 0x0045FE3C File Offset: 0x0045E03C
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

	// Token: 0x06011C58 RID: 72792 RVA: 0x0045FEF8 File Offset: 0x0045E0F8
	private void RefreshGrids()
	{
		int targetLevel = this.TargetLevel;
		if (targetLevel > 0)
		{
			this.TargetLevel = 0;
			this.RefreshingGrids(targetLevel).ContinueWith(new Action(this.RefreshGrids)).Forget();
		}
	}

	// Token: 0x06011C59 RID: 72793 RVA: 0x0045FF34 File Offset: 0x0045E134
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

	// Token: 0x06011C5A RID: 72794 RVA: 0x0045FF7F File Offset: 0x0045E17F
	protected override void OnDestroy()
	{
		this.TargetLevel = 0;
		this.RewardScrollView = null;
		this.RewardList.Clear();
		this.RewardList = null;
		this.NumberSelect.Destroy(null);
		this.NumberSelect = null;
	}

	// Token: 0x040086D0 RID: 34512
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x040086D1 RID: 34513
	[Nullable(2)]
	private List<TItem> RewardList;

	// Token: 0x040086D2 RID: 34514
	[Nullable(2)]
	private NumberSelectComponent NumberSelect;

	// Token: 0x040086D3 RID: 34515
	private int CurrentLevel;

	// Token: 0x040086D4 RID: 34516
	private int CostId;

	// Token: 0x040086D5 RID: 34517
	private int CostCount;

	// Token: 0x040086D6 RID: 34518
	private int TargetLevel;

	// Token: 0x040086D7 RID: 34519
	private bool IsRefreshingGrids;

	// Token: 0x0200889A RID: 34970
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402C657 RID: 181847
		ItemScrollView,
		// Token: 0x0402C658 RID: 181848
		TxtTitle,
		// Token: 0x0402C659 RID: 181849
		BtnCancel,
		// Token: 0x0402C65A RID: 181850
		BtnBuy,
		// Token: 0x0402C65B RID: 181851
		TxtDescribe,
		// Token: 0x0402C65C RID: 181852
		NumberControlItem,
		// Token: 0x0402C65D RID: 181853
		TxtCost,
		// Token: 0x0402C65E RID: 181854
		InsufficientTip,
		// Token: 0x0402C65F RID: 181855
		IconCost,
		// Token: 0x0402C660 RID: 181856
		TxtInsufficient
	}
}
