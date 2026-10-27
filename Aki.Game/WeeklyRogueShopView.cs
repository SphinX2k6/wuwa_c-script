using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002D59 RID: 11609
[NullableContext(1)]
[Nullable(0)]
public class WeeklyRogueShopView : UiViewBase
{
	// Token: 0x0601865A RID: 99930 RVA: 0x0063656B File Offset: 0x0063476B
	public WeeklyRogueShopView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0601865B RID: 99931 RVA: 0x00636574 File Offset: 0x00634774
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(5, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUITexture)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(9, new Action(this.OnBtnInfo))
		};
	}

	// Token: 0x0601865C RID: 99932 RVA: 0x00636690 File Offset: 0x00634890
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.WeeklyRogueShopSelect, new Action<int, RogueWeeklyEntry>(this.OnSelectItem));
		EventSystem.Instance.Add(EEventName.WeeklyRogueSelectOption, new Action(this.OnBuyItem));
		EventSystem.Instance.Add(EEventName.PayShopGoodsBuy, new Action(this.OnCurrencyUpdate));
		EventSystem.Instance.Add<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnPlayerCurrencyChange));
		EventSystem.Instance.Add<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
		EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.OnRemoveCommonItem, new Action<IReadOnlyList<int>>(this.OnRemoveCommonItem));
		EventSystem.Instance.Add<IProto_NormalItem, int, int>(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.OnCommonItemCountRefresh));
	}

	// Token: 0x0601865D RID: 99933 RVA: 0x00636764 File Offset: 0x00634964
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.WeeklyRogueShopSelect, new Action<int, RogueWeeklyEntry>(this.OnSelectItem));
		EventSystem.Instance.Remove(EEventName.WeeklyRogueSelectOption, new Action(this.OnBuyItem));
		EventSystem.Instance.Remove(EEventName.PayShopGoodsBuy, new Action(this.OnCurrencyUpdate));
		EventSystem.Instance.Remove<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnPlayerCurrencyChange));
		EventSystem.Instance.Remove<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
		EventSystem.Instance.Remove<IReadOnlyList<int>>(EEventName.OnRemoveCommonItem, new Action<IReadOnlyList<int>>(this.OnRemoveCommonItem));
		EventSystem.Instance.Remove<IProto_NormalItem, int, int>(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.OnCommonItemCountRefresh));
	}

	// Token: 0x0601865E RID: 99934 RVA: 0x00636838 File Offset: 0x00634A38
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyRogueShopView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRogueShopView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601865F RID: 99935 RVA: 0x0063687C File Offset: 0x00634A7C
	protected override void OnAfterShow()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Show", false, null, false);
	}

	// Token: 0x06018660 RID: 99936 RVA: 0x006368A4 File Offset: 0x00634AA4
	private void RefreshCanBuyText()
	{
		LoopScrollView<WeeklyRogueTokenGrid, RogueWeeklyEntry> goodsLayout = this.GoodsLayout;
		if (goodsLayout == null)
		{
			return;
		}
		goodsLayout.RefreshAllGridProxies();
	}

	// Token: 0x06018661 RID: 99937 RVA: 0x006368B6 File Offset: 0x00634AB6
	private void OnSelectItem(int gridIndex, RogueWeeklyEntry data)
	{
		this.DetailPanel.Refresh(data);
		LoopScrollView<WeeklyRogueTokenGrid, RogueWeeklyEntry> goodsLayout = this.GoodsLayout;
		if (goodsLayout == null)
		{
			return;
		}
		goodsLayout.SelectGridProxy(gridIndex, false);
	}

	// Token: 0x06018662 RID: 99938 RVA: 0x006368D8 File Offset: 0x00634AD8
	private void OnBuyItem()
	{
		UiAsyncTask task = new UiAsyncTask("RefreshWeeklyRogueShop", delegate()
		{
			WeeklyRogueShopView.<<OnBuyItem>b__13_0>d <<OnBuyItem>b__13_0>d;
			<<OnBuyItem>b__13_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnBuyItem>b__13_0>d.<>4__this = this;
			<<OnBuyItem>b__13_0>d.<>1__state = -1;
			<<OnBuyItem>b__13_0>d.<>t__builder.Start<WeeklyRogueShopView.<<OnBuyItem>b__13_0>d>(ref <<OnBuyItem>b__13_0>d);
			return <<OnBuyItem>b__13_0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
	}

	// Token: 0x06018663 RID: 99939 RVA: 0x00636905 File Offset: 0x00634B05
	private void OnPlayerCurrencyChange(int _)
	{
		this.OnCurrencyUpdate();
	}

	// Token: 0x06018664 RID: 99940 RVA: 0x0063690D File Offset: 0x00634B0D
	private void OnAddCommonItemList(IReadOnlyList<IProto_NormalItem> protoNormalItems)
	{
		this.OnCurrencyUpdate();
	}

	// Token: 0x06018665 RID: 99941 RVA: 0x00636915 File Offset: 0x00634B15
	private void OnRemoveCommonItem(IReadOnlyList<int> readOnlyList)
	{
		this.OnCurrencyUpdate();
	}

	// Token: 0x06018666 RID: 99942 RVA: 0x0063691D File Offset: 0x00634B1D
	private void OnCommonItemCountRefresh(IProto_NormalItem protoNormalItem, int i, int arg3)
	{
		this.OnCurrencyUpdate();
	}

	// Token: 0x06018667 RID: 99943 RVA: 0x00636925 File Offset: 0x00634B25
	private void OnCurrencyUpdate()
	{
		this.RefreshCanBuyText();
	}

	// Token: 0x06018668 RID: 99944 RVA: 0x0063692D File Offset: 0x00634B2D
	private void OnBtnInfo()
	{
		UiManager.Instance.OpenView(EUiViewName.WeeklyRogueInfo, null, null);
	}

	// Token: 0x06018669 RID: 99945 RVA: 0x00636940 File Offset: 0x00634B40
	private WeeklyRogueTokenGrid CreateGoodsItem()
	{
		return new WeeklyRogueTokenGrid();
	}

	// Token: 0x0601866A RID: 99946 RVA: 0x00636948 File Offset: 0x00634B48
	public UniTask RefreshItemList()
	{
		WeeklyRogueShopView.<RefreshItemList>d__21 <RefreshItemList>d__;
		<RefreshItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshItemList>d__.<>4__this = this;
		<RefreshItemList>d__.<>1__state = -1;
		<RefreshItemList>d__.<>t__builder.Start<WeeklyRogueShopView.<RefreshItemList>d__21>(ref <RefreshItemList>d__);
		return <RefreshItemList>d__.<>t__builder.Task;
	}

	// Token: 0x0400B4FD RID: 46333
	[Nullable(2)]
	public LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400B4FE RID: 46334
	[Nullable(2)]
	public PopupCaptionItem CaptionItem;

	// Token: 0x0400B4FF RID: 46335
	[Nullable(2)]
	public WeeklyRogueShopDetail DetailPanel;

	// Token: 0x0400B500 RID: 46336
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public LoopScrollView<WeeklyRogueTokenGrid, RogueWeeklyEntry> GoodsLayout;

	// Token: 0x020092FB RID: 37627
	[NullableContext(0)]
	private enum EWeeklyRogueShopDefine
	{
		// Token: 0x0402F812 RID: 194578
		CaptionItem,
		// Token: 0x0402F813 RID: 194579
		PanelInfo,
		// Token: 0x0402F814 RID: 194580
		ElementPanel,
		// Token: 0x0402F815 RID: 194581
		BtnRefresh,
		// Token: 0x0402F816 RID: 194582
		TxtRefresh,
		// Token: 0x0402F817 RID: 194583
		LoopView,
		// Token: 0x0402F818 RID: 194584
		LoopViewItem,
		// Token: 0x0402F819 RID: 194585
		RefreshItemIcon,
		// Token: 0x0402F81A RID: 194586
		RefreshText,
		// Token: 0x0402F81B RID: 194587
		BtnInfo
	}
}
