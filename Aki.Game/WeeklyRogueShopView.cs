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

// Token: 0x020022B3 RID: 8883
[NullableContext(1)]
[Nullable(0)]
public class WeeklyRogueShopView : UiViewBase
{
	// Token: 0x06015EFC RID: 89852 RVA: 0x0065C57B File Offset: 0x0065A77B
	public WeeklyRogueShopView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06015EFD RID: 89853 RVA: 0x0065C584 File Offset: 0x0065A784
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

	// Token: 0x06015EFE RID: 89854 RVA: 0x0065C6A0 File Offset: 0x0065A8A0
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

	// Token: 0x06015EFF RID: 89855 RVA: 0x0065C774 File Offset: 0x0065A974
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

	// Token: 0x06015F00 RID: 89856 RVA: 0x0065C848 File Offset: 0x0065AA48
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyRogueShopView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRogueShopView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015F01 RID: 89857 RVA: 0x0065C88C File Offset: 0x0065AA8C
	protected override void OnAfterShow()
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName("Show", false, null, false);
	}

	// Token: 0x06015F02 RID: 89858 RVA: 0x0065C8B4 File Offset: 0x0065AAB4
	private void RefreshCanBuyText()
	{
		LoopScrollView<WeeklyRogueTokenGrid, RogueWeeklyEntry> goodsLayout = this.GoodsLayout;
		if (goodsLayout == null)
		{
			return;
		}
		goodsLayout.RefreshAllGridProxies();
	}

	// Token: 0x06015F03 RID: 89859 RVA: 0x0065C8C6 File Offset: 0x0065AAC6
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

	// Token: 0x06015F04 RID: 89860 RVA: 0x0065C8E8 File Offset: 0x0065AAE8
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

	// Token: 0x06015F05 RID: 89861 RVA: 0x0065C915 File Offset: 0x0065AB15
	private void OnPlayerCurrencyChange(int _)
	{
		this.OnCurrencyUpdate();
	}

	// Token: 0x06015F06 RID: 89862 RVA: 0x0065C91D File Offset: 0x0065AB1D
	private void OnAddCommonItemList(IReadOnlyList<IProto_NormalItem> protoNormalItems)
	{
		this.OnCurrencyUpdate();
	}

	// Token: 0x06015F07 RID: 89863 RVA: 0x0065C925 File Offset: 0x0065AB25
	private void OnRemoveCommonItem(IReadOnlyList<int> readOnlyList)
	{
		this.OnCurrencyUpdate();
	}

	// Token: 0x06015F08 RID: 89864 RVA: 0x0065C92D File Offset: 0x0065AB2D
	private void OnCommonItemCountRefresh(IProto_NormalItem protoNormalItem, int i, int arg3)
	{
		this.OnCurrencyUpdate();
	}

	// Token: 0x06015F09 RID: 89865 RVA: 0x0065C935 File Offset: 0x0065AB35
	private void OnCurrencyUpdate()
	{
		this.RefreshCanBuyText();
	}

	// Token: 0x06015F0A RID: 89866 RVA: 0x0065C93D File Offset: 0x0065AB3D
	private void OnBtnInfo()
	{
		UiManager.Instance.OpenView(EUiViewName.WeeklyRogueInfo, null, null);
	}

	// Token: 0x06015F0B RID: 89867 RVA: 0x0065C950 File Offset: 0x0065AB50
	private WeeklyRogueTokenGrid CreateGoodsItem()
	{
		return new WeeklyRogueTokenGrid();
	}

	// Token: 0x06015F0C RID: 89868 RVA: 0x0065C958 File Offset: 0x0065AB58
	public UniTask RefreshItemList()
	{
		WeeklyRogueShopView.<RefreshItemList>d__21 <RefreshItemList>d__;
		<RefreshItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshItemList>d__.<>4__this = this;
		<RefreshItemList>d__.<>1__state = -1;
		<RefreshItemList>d__.<>t__builder.Start<WeeklyRogueShopView.<RefreshItemList>d__21>(ref <RefreshItemList>d__);
		return <RefreshItemList>d__.<>t__builder.Task;
	}

	// Token: 0x0400B872 RID: 47218
	[Nullable(2)]
	public LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400B873 RID: 47219
	[Nullable(2)]
	public PopupCaptionItem CaptionItem;

	// Token: 0x0400B874 RID: 47220
	[Nullable(2)]
	public WeeklyRogueShopDetail DetailPanel;

	// Token: 0x0400B875 RID: 47221
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public LoopScrollView<WeeklyRogueTokenGrid, RogueWeeklyEntry> GoodsLayout;

	// Token: 0x02008522 RID: 34082
	[NullableContext(0)]
	private enum EWeeklyRogueShopDefine
	{
		// Token: 0x0402AE9A RID: 175770
		CaptionItem,
		// Token: 0x0402AE9B RID: 175771
		PanelInfo,
		// Token: 0x0402AE9C RID: 175772
		ElementPanel,
		// Token: 0x0402AE9D RID: 175773
		BtnRefresh,
		// Token: 0x0402AE9E RID: 175774
		TxtRefresh,
		// Token: 0x0402AE9F RID: 175775
		LoopView,
		// Token: 0x0402AEA0 RID: 175776
		LoopViewItem,
		// Token: 0x0402AEA1 RID: 175777
		RefreshItemIcon,
		// Token: 0x0402AEA2 RID: 175778
		RefreshText,
		// Token: 0x0402AEA3 RID: 175779
		BtnInfo
	}
}
