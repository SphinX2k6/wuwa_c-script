using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019B6 RID: 6582
[NullableContext(1)]
[Nullable(0)]
public class TabComponentWithCaptionItem<[Nullable(0)] TTabItem> : UiPanelBase where TTabItem : CommonTabItemBase
{
	// Token: 0x0600C001 RID: 49153 RVA: 0x002B4FB1 File Offset: 0x002B31B1
	public TabComponentWithCaptionItem(UUIItem uiItem, CommonTabComponentData<TTabItem> data, Action closeCallBack, bool bAsync = false)
	{
		this.TabComponentData = data;
		this.OnCloseCallBack = closeCallBack;
		if (!bAsync)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}
	}

	// Token: 0x17001018 RID: 4120
	// (get) Token: 0x0600C002 RID: 49154 RVA: 0x002B4FDF File Offset: 0x002B31DF
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public TabComponent<TTabItem> TabComponent
	{
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		get
		{
			return this.TabComponentInternal;
		}
	}

	// Token: 0x0600C003 RID: 49155 RVA: 0x002B4FE8 File Offset: 0x002B31E8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C004 RID: 49156 RVA: 0x002B5074 File Offset: 0x002B3274
	protected override void OnStart()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(this.OnCloseCallBack);
		this.ScrollView = base.GetScrollViewWithScrollbar(1);
		this.TabComponentInternal = new TabComponent<TTabItem>(this.ScrollView.Content.Get().GetUIItem(), new Func<UUIItem, int?, TTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), null);
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600C005 RID: 49157 RVA: 0x002B50FE File Offset: 0x002B32FE
	private TTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return this.TabComponentData.ProxyCreate(uiItem, new int?(index.GetValueOrDefault()));
	}

	// Token: 0x0600C006 RID: 49158 RVA: 0x002B5120 File Offset: 0x002B3320
	private void ToggleCallBack(int index)
	{
		CommonTabData commonTabData = this.TabComponentData.GetCommonData(index);
		if (commonTabData != null && this.NeedCaptionSwitchWithToggle)
		{
			this.CaptionItem.SetTitleByTitleData(commonTabData.GetTitleData());
			this.CaptionItem.SetTitleIcon(commonTabData.GetSmallIcon());
		}
		this.TabComponentData.ToggleCallBack(index);
	}

	// Token: 0x0600C007 RID: 49159 RVA: 0x002B517D File Offset: 0x002B337D
	public void SetCloseCallBack(Action callBack)
	{
		this.OnCloseCallBack = callBack;
	}

	// Token: 0x0600C008 RID: 49160 RVA: 0x002B5186 File Offset: 0x002B3386
	public void RefreshTabItem(List<CommonTabItemData> dataArray, [Nullable(2)] Action callBack = null)
	{
		this.TabComponent.RefreshTabItem(dataArray, callBack);
	}

	// Token: 0x0600C009 RID: 49161 RVA: 0x002B5198 File Offset: 0x002B3398
	public UniTask RefreshTabItemAsync(List<CommonTabItemData> array, bool resetSelect = true)
	{
		TabComponentWithCaptionItem<TTabItem>.<RefreshTabItemAsync>d__17 <RefreshTabItemAsync>d__;
		<RefreshTabItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabItemAsync>d__.<>4__this = this;
		<RefreshTabItemAsync>d__.array = array;
		<RefreshTabItemAsync>d__.resetSelect = resetSelect;
		<RefreshTabItemAsync>d__.<>1__state = -1;
		<RefreshTabItemAsync>d__.<>t__builder.Start<TabComponentWithCaptionItem<TTabItem>.<RefreshTabItemAsync>d__17>(ref <RefreshTabItemAsync>d__);
		return <RefreshTabItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C00A RID: 49162 RVA: 0x002B51EC File Offset: 0x002B33EC
	[NullableContext(2)]
	public void RefreshTabItemByLength(int length, Action callBack = null)
	{
		List<CommonTabItemData> dataArray = this.CreateTabItemDataByLength(length);
		this.RefreshTabItem(dataArray, callBack);
	}

	// Token: 0x0600C00B RID: 49163 RVA: 0x002B520C File Offset: 0x002B340C
	public UniTask RefreshTabItemByLengthAsync(int length)
	{
		TabComponentWithCaptionItem<TTabItem>.<RefreshTabItemByLengthAsync>d__19 <RefreshTabItemByLengthAsync>d__;
		<RefreshTabItemByLengthAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshTabItemByLengthAsync>d__.<>4__this = this;
		<RefreshTabItemByLengthAsync>d__.length = length;
		<RefreshTabItemByLengthAsync>d__.<>1__state = -1;
		<RefreshTabItemByLengthAsync>d__.<>t__builder.Start<TabComponentWithCaptionItem<TTabItem>.<RefreshTabItemByLengthAsync>d__19>(ref <RefreshTabItemByLengthAsync>d__);
		return <RefreshTabItemByLengthAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C00C RID: 49164 RVA: 0x002B5258 File Offset: 0x002B3458
	public UniTask CreatePopupToggleTab(Action<EToggleState> callback)
	{
		TabComponentWithCaptionItem<TTabItem>.<CreatePopupToggleTab>d__20 <CreatePopupToggleTab>d__;
		<CreatePopupToggleTab>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreatePopupToggleTab>d__.<>4__this = this;
		<CreatePopupToggleTab>d__.callback = callback;
		<CreatePopupToggleTab>d__.<>1__state = -1;
		<CreatePopupToggleTab>d__.<>t__builder.Start<TabComponentWithCaptionItem<TTabItem>.<CreatePopupToggleTab>d__20>(ref <CreatePopupToggleTab>d__);
		return <CreatePopupToggleTab>d__.<>t__builder.Task;
	}

	// Token: 0x0600C00D RID: 49165 RVA: 0x002B52A3 File Offset: 0x002B34A3
	public EToggleState GetCaptionToggleState()
	{
		return this.CaptionItem.GetToggleState();
	}

	// Token: 0x0600C00E RID: 49166 RVA: 0x002B52B0 File Offset: 0x002B34B0
	public void SetPopupToggleName(string name)
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.SetToggleName(name);
	}

	// Token: 0x0600C00F RID: 49167 RVA: 0x002B52C3 File Offset: 0x002B34C3
	public void SetPopupToggleVisible(bool visible)
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.SetToggleVisible(visible);
	}

	// Token: 0x0600C010 RID: 49168 RVA: 0x002B52D8 File Offset: 0x002B34D8
	public List<CommonTabItemData> CreateTabItemDataByLength(int length)
	{
		List<CommonTabItemData> list = new List<CommonTabItemData>();
		for (int i = 0; i < length; i++)
		{
			list.Add(new CommonTabItemData
			{
				Index = i,
				Data = this.TabComponentData.GetCommonData(i)
			});
		}
		return list;
	}

	// Token: 0x0600C011 RID: 49169 RVA: 0x002B5323 File Offset: 0x002B3523
	public void SelectToggleByIndex(int index, bool bIgnored = false)
	{
		this.TabComponent.SelectToggleByIndex(index, bIgnored, true);
	}

	// Token: 0x0600C012 RID: 49170 RVA: 0x002B5334 File Offset: 0x002B3534
	public void ShowItem()
	{
		this.SequencePlayer.PlayLevelSequenceByName("Start", true, null, false);
	}

	// Token: 0x0600C013 RID: 49171 RVA: 0x002B535C File Offset: 0x002B355C
	public UniTask ShowItemAsync()
	{
		TabComponentWithCaptionItem<TTabItem>.<ShowItemAsync>d__27 <ShowItemAsync>d__;
		<ShowItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowItemAsync>d__.<>4__this = this;
		<ShowItemAsync>d__.<>1__state = -1;
		<ShowItemAsync>d__.<>t__builder.Start<TabComponentWithCaptionItem<TTabItem>.<ShowItemAsync>d__27>(ref <ShowItemAsync>d__);
		return <ShowItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C014 RID: 49172 RVA: 0x002B53A0 File Offset: 0x002B35A0
	public void HideItem()
	{
		this.SequencePlayer.PlayLevelSequenceByName("Close", true, null, false);
	}

	// Token: 0x0600C015 RID: 49173 RVA: 0x002B53C8 File Offset: 0x002B35C8
	public int GetSelectedIndex()
	{
		return this.TabComponent.GetSelectedIndex();
	}

	// Token: 0x0600C016 RID: 49174 RVA: 0x002B53D8 File Offset: 0x002B35D8
	public void ScrollToToggleByIndex(int index)
	{
		TTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
		this.ScrollView.ScrollTo(tabItemByIndex.GetRootItem(), false);
	}

	// Token: 0x0600C017 RID: 49175 RVA: 0x002B540C File Offset: 0x002B360C
	public void LateScrollToToggleByIndex(int index)
	{
		TTabItem tabItem = this.TabComponent.GetTabItemByIndex(index);
		TTimerAction <>9__1;
		this.ScrollView.OnLateUpdate.Bind(delegate(float _)
		{
			TimerSystemInstance gameplayTimeInstance = TimerSystem.GameplayTimeInstance;
			TTimerAction action;
			if ((action = <>9__1) == null)
			{
				action = (<>9__1 = delegate(float __)
				{
					this.ScrollView.ScrollTo(tabItem.GetRootItem(), false);
				});
			}
			gameplayTimeInstance.Next(action, null, null);
			this.ScrollView.OnLateUpdate.Unbind();
		});
	}

	// Token: 0x0600C018 RID: 49176 RVA: 0x002B5454 File Offset: 0x002B3654
	[NullableContext(2)]
	public TTabItem GetTabItemByIndex(int index)
	{
		return this.TabComponent.GetTabItemByIndex(index);
	}

	// Token: 0x0600C019 RID: 49177 RVA: 0x002B5462 File Offset: 0x002B3662
	public Dictionary<int, TTabItem> GetTabItemMap()
	{
		return this.TabComponent.GetTabItemMap();
	}

	// Token: 0x0600C01A RID: 49178 RVA: 0x002B546F File Offset: 0x002B366F
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public TabComponent<TTabItem> GetTabComponent()
	{
		return this.TabComponent;
	}

	// Token: 0x0600C01B RID: 49179 RVA: 0x002B5477 File Offset: 0x002B3677
	public void SetCanChange(Func<int, bool?, bool> callback)
	{
		this.TabComponent.SetCanChange(callback);
	}

	// Token: 0x0600C01C RID: 49180 RVA: 0x002B5485 File Offset: 0x002B3685
	public void SetTabRootActive(bool active)
	{
		base.GetItem(2).SetUIActive(active);
	}

	// Token: 0x0600C01D RID: 49181 RVA: 0x002B5494 File Offset: 0x002B3694
	public void SetRootActive(bool active)
	{
		base.GetItem(2).SetUIActive(active);
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.SetUiActive(active);
	}

	// Token: 0x0600C01E RID: 49182 RVA: 0x002B54B4 File Offset: 0x002B36B4
	public UniTask SetCurrencyItemList(List<int> itemIdList)
	{
		TabComponentWithCaptionItem<TTabItem>.<SetCurrencyItemList>d__38 <SetCurrencyItemList>d__;
		<SetCurrencyItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetCurrencyItemList>d__.<>4__this = this;
		<SetCurrencyItemList>d__.itemIdList = itemIdList;
		<SetCurrencyItemList>d__.<>1__state = -1;
		<SetCurrencyItemList>d__.<>t__builder.Start<TabComponentWithCaptionItem<TTabItem>.<SetCurrencyItemList>d__38>(ref <SetCurrencyItemList>d__);
		return <SetCurrencyItemList>d__.<>t__builder.Task;
	}

	// Token: 0x0600C01F RID: 49183 RVA: 0x002B54FF File Offset: 0x002B36FF
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<CommonCurrencyItem> GetCurrencyItemList()
	{
		return this.CaptionItem.GetCurrencyItemList();
	}

	// Token: 0x0600C020 RID: 49184 RVA: 0x002B550C File Offset: 0x002B370C
	public void SetHelpButtonShowState(bool state)
	{
		this.CaptionItem.SetHelpBtnActive(state);
	}

	// Token: 0x0600C021 RID: 49185 RVA: 0x002B551A File Offset: 0x002B371A
	public void SetHelpButtonCallBack(Action call)
	{
		this.CaptionItem.SetHelpCallBack(call);
	}

	// Token: 0x0600C022 RID: 49186 RVA: 0x002B5528 File Offset: 0x002B3728
	public void SetCloseBtnRaycast(bool state)
	{
		this.CaptionItem.SetCloseBtnRaycast(state);
	}

	// Token: 0x0600C023 RID: 49187 RVA: 0x002B5536 File Offset: 0x002B3736
	public void SetCloseBtnShowState(bool state)
	{
		this.CaptionItem.SetCloseBtnShowState(state);
	}

	// Token: 0x0600C024 RID: 49188 RVA: 0x002B5544 File Offset: 0x002B3744
	public void SetHomeBtnShowState(bool state)
	{
		this.CaptionItem.SetHomeBtnShowState(state);
	}

	// Token: 0x0600C025 RID: 49189 RVA: 0x002B5554 File Offset: 0x002B3754
	public void SetTabComponentShowState(bool state)
	{
		this.ScrollView.RootUIComp.Get().SetUIActive(state);
	}

	// Token: 0x0600C026 RID: 49190 RVA: 0x002B557A File Offset: 0x002B377A
	protected override void OnBeforeDestroy()
	{
		if (this.TabComponentInternal != null)
		{
			this.TabComponentInternal.Destroy(null);
			this.TabComponentInternal = null;
		}
		if (this.CaptionItem != null)
		{
			this.CaptionItem.Destroy(null);
			this.CaptionItem = null;
		}
	}

	// Token: 0x0600C027 RID: 49191 RVA: 0x002B55B2 File Offset: 0x002B37B2
	public void SetTitle(string title)
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.SetTitle(title);
	}

	// Token: 0x0600C028 RID: 49192 RVA: 0x002B55C8 File Offset: 0x002B37C8
	public void SetTitleByTextIdAndArgNew(string textId, params string[] args)
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.SetTitleByTextIdAndArgNew(textId, args);
	}

	// Token: 0x0600C029 RID: 49193 RVA: 0x002B55E9 File Offset: 0x002B37E9
	public void SetTitleIcon(string iconPath)
	{
		this.CaptionItem.SetTitleIcon(iconPath);
	}

	// Token: 0x0600C02A RID: 49194 RVA: 0x002B55F7 File Offset: 0x002B37F7
	public void SetTitleIconVisible(bool state)
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.SetTitleIconVisible(state);
	}

	// Token: 0x0600C02B RID: 49195 RVA: 0x002B560A File Offset: 0x002B380A
	[NullableContext(2)]
	public UUIItem GetCostContent()
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return null;
		}
		return captionItem.GetCostContent();
	}

	// Token: 0x0600C02C RID: 49196 RVA: 0x002B561D File Offset: 0x002B381D
	[NullableContext(2)]
	public UUIScrollViewWithScrollbarComponent GetScrollView()
	{
		return this.ScrollView;
	}

	// Token: 0x0600C02D RID: 49197 RVA: 0x002B5628 File Offset: 0x002B3828
	public void SetScrollViewVisible(bool state)
	{
		base.GetScrollViewWithScrollbar(1).RootUIComp.Get().SetUIActive(state);
	}

	// Token: 0x0600C02E RID: 49198 RVA: 0x002B564F File Offset: 0x002B384F
	protected override bool DestroyOverride()
	{
		return true;
	}

	// Token: 0x04005654 RID: 22100
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04005655 RID: 22101
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private readonly CommonTabComponentData<TTabItem> TabComponentData;

	// Token: 0x04005656 RID: 22102
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<TTabItem> TabComponentInternal;

	// Token: 0x04005657 RID: 22103
	[Nullable(2)]
	private UUIScrollViewWithScrollbarComponent ScrollView;

	// Token: 0x04005658 RID: 22104
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04005659 RID: 22105
	[Nullable(2)]
	private Action OnCloseCallBack;

	// Token: 0x0400565A RID: 22106
	public bool NeedCaptionSwitchWithToggle = true;

	// Token: 0x02007EDB RID: 32475
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402973D RID: 169789
		public const int CaptionItem = 0;

		// Token: 0x0402973E RID: 169790
		public const int ScrollView = 1;

		// Token: 0x0402973F RID: 169791
		public const int TabRootNode = 2;
	}
}
