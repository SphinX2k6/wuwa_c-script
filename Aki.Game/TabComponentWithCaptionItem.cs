using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000E74 RID: 3700
[NullableContext(1)]
[Nullable(0)]
public class TabComponentWithCaptionItem<[Nullable(0)] TTabItem> : UiPanelBase where TTabItem : CommonTabItemBase
{
	// Token: 0x0600940B RID: 37899 RVA: 0x002BFF41 File Offset: 0x002BE141
	public TabComponentWithCaptionItem(UUIItem uiItem, CommonTabComponentData<TTabItem> data, Action closeCallBack, bool bAsync = false)
	{
		this.TabComponentData = data;
		this.OnCloseCallBack = closeCallBack;
		if (!bAsync)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}
	}

	// Token: 0x1700103D RID: 4157
	// (get) Token: 0x0600940C RID: 37900 RVA: 0x002BFF6F File Offset: 0x002BE16F
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

	// Token: 0x0600940D RID: 37901 RVA: 0x002BFF78 File Offset: 0x002BE178
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

	// Token: 0x0600940E RID: 37902 RVA: 0x002C0004 File Offset: 0x002BE204
	protected override void OnStart()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(this.OnCloseCallBack);
		this.ScrollView = base.GetScrollViewWithScrollbar(1);
		this.TabComponentInternal = new TabComponent<TTabItem>(this.ScrollView.Content.Get().GetUIItem(), new Func<UUIItem, int?, TTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), null);
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600940F RID: 37903 RVA: 0x002C008E File Offset: 0x002BE28E
	private TTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return this.TabComponentData.ProxyCreate(uiItem, new int?(index.GetValueOrDefault()));
	}

	// Token: 0x06009410 RID: 37904 RVA: 0x002C00B0 File Offset: 0x002BE2B0
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

	// Token: 0x06009411 RID: 37905 RVA: 0x002C010D File Offset: 0x002BE30D
	public void SetCloseCallBack(Action callBack)
	{
		this.OnCloseCallBack = callBack;
	}

	// Token: 0x06009412 RID: 37906 RVA: 0x002C0116 File Offset: 0x002BE316
	public void RefreshTabItem(List<CommonTabItemData> dataArray, [Nullable(2)] Action callBack = null)
	{
		this.TabComponent.RefreshTabItem(dataArray, callBack);
	}

	// Token: 0x06009413 RID: 37907 RVA: 0x002C0128 File Offset: 0x002BE328
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

	// Token: 0x06009414 RID: 37908 RVA: 0x002C017C File Offset: 0x002BE37C
	[NullableContext(2)]
	public void RefreshTabItemByLength(int length, Action callBack = null)
	{
		List<CommonTabItemData> dataArray = this.CreateTabItemDataByLength(length);
		this.RefreshTabItem(dataArray, callBack);
	}

	// Token: 0x06009415 RID: 37909 RVA: 0x002C019C File Offset: 0x002BE39C
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

	// Token: 0x06009416 RID: 37910 RVA: 0x002C01E8 File Offset: 0x002BE3E8
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

	// Token: 0x06009417 RID: 37911 RVA: 0x002C0233 File Offset: 0x002BE433
	public EToggleState GetCaptionToggleState()
	{
		return this.CaptionItem.GetToggleState();
	}

	// Token: 0x06009418 RID: 37912 RVA: 0x002C0240 File Offset: 0x002BE440
	public void SetPopupToggleName(string name)
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.SetToggleName(name);
	}

	// Token: 0x06009419 RID: 37913 RVA: 0x002C0253 File Offset: 0x002BE453
	public void SetPopupToggleVisible(bool visible)
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.SetToggleVisible(visible);
	}

	// Token: 0x0600941A RID: 37914 RVA: 0x002C0268 File Offset: 0x002BE468
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

	// Token: 0x0600941B RID: 37915 RVA: 0x002C02B3 File Offset: 0x002BE4B3
	public void SelectToggleByIndex(int index, bool bIgnored = false)
	{
		this.TabComponent.SelectToggleByIndex(index, bIgnored, true);
	}

	// Token: 0x0600941C RID: 37916 RVA: 0x002C02C4 File Offset: 0x002BE4C4
	public void ShowItem()
	{
		this.SequencePlayer.PlayLevelSequenceByName("Start", true, null, false);
	}

	// Token: 0x0600941D RID: 37917 RVA: 0x002C02EC File Offset: 0x002BE4EC
	public UniTask ShowItemAsync()
	{
		TabComponentWithCaptionItem<TTabItem>.<ShowItemAsync>d__27 <ShowItemAsync>d__;
		<ShowItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowItemAsync>d__.<>4__this = this;
		<ShowItemAsync>d__.<>1__state = -1;
		<ShowItemAsync>d__.<>t__builder.Start<TabComponentWithCaptionItem<TTabItem>.<ShowItemAsync>d__27>(ref <ShowItemAsync>d__);
		return <ShowItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600941E RID: 37918 RVA: 0x002C0330 File Offset: 0x002BE530
	public void HideItem()
	{
		this.SequencePlayer.PlayLevelSequenceByName("Close", true, null, false);
	}

	// Token: 0x0600941F RID: 37919 RVA: 0x002C0358 File Offset: 0x002BE558
	public int GetSelectedIndex()
	{
		return this.TabComponent.GetSelectedIndex();
	}

	// Token: 0x06009420 RID: 37920 RVA: 0x002C0368 File Offset: 0x002BE568
	public void ScrollToToggleByIndex(int index)
	{
		TTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
		this.ScrollView.ScrollTo(tabItemByIndex.GetRootItem(), false);
	}

	// Token: 0x06009421 RID: 37921 RVA: 0x002C039C File Offset: 0x002BE59C
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

	// Token: 0x06009422 RID: 37922 RVA: 0x002C03E4 File Offset: 0x002BE5E4
	[NullableContext(2)]
	public TTabItem GetTabItemByIndex(int index)
	{
		return this.TabComponent.GetTabItemByIndex(index);
	}

	// Token: 0x06009423 RID: 37923 RVA: 0x002C03F2 File Offset: 0x002BE5F2
	public Dictionary<int, TTabItem> GetTabItemMap()
	{
		return this.TabComponent.GetTabItemMap();
	}

	// Token: 0x06009424 RID: 37924 RVA: 0x002C03FF File Offset: 0x002BE5FF
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public TabComponent<TTabItem> GetTabComponent()
	{
		return this.TabComponent;
	}

	// Token: 0x06009425 RID: 37925 RVA: 0x002C0407 File Offset: 0x002BE607
	public void SetCanChange(Func<int, bool?, bool> callback)
	{
		this.TabComponent.SetCanChange(callback);
	}

	// Token: 0x06009426 RID: 37926 RVA: 0x002C0415 File Offset: 0x002BE615
	public void SetTabRootActive(bool active)
	{
		base.GetItem(2).SetUIActive(active);
	}

	// Token: 0x06009427 RID: 37927 RVA: 0x002C0424 File Offset: 0x002BE624
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

	// Token: 0x06009428 RID: 37928 RVA: 0x002C0444 File Offset: 0x002BE644
	public UniTask SetCurrencyItemList(IEnumerable<int> itemIdList)
	{
		TabComponentWithCaptionItem<TTabItem>.<SetCurrencyItemList>d__38 <SetCurrencyItemList>d__;
		<SetCurrencyItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetCurrencyItemList>d__.<>4__this = this;
		<SetCurrencyItemList>d__.itemIdList = itemIdList;
		<SetCurrencyItemList>d__.<>1__state = -1;
		<SetCurrencyItemList>d__.<>t__builder.Start<TabComponentWithCaptionItem<TTabItem>.<SetCurrencyItemList>d__38>(ref <SetCurrencyItemList>d__);
		return <SetCurrencyItemList>d__.<>t__builder.Task;
	}

	// Token: 0x06009429 RID: 37929 RVA: 0x002C048F File Offset: 0x002BE68F
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<CommonCurrencyItem> GetCurrencyItemList()
	{
		return this.CaptionItem.GetCurrencyItemList();
	}

	// Token: 0x0600942A RID: 37930 RVA: 0x002C049C File Offset: 0x002BE69C
	public void SetHelpButtonShowState(bool state)
	{
		this.CaptionItem.SetHelpBtnActive(state);
	}

	// Token: 0x0600942B RID: 37931 RVA: 0x002C04AA File Offset: 0x002BE6AA
	public void SetHelpButtonCallBack(Action call)
	{
		this.CaptionItem.SetHelpCallBack(call);
	}

	// Token: 0x0600942C RID: 37932 RVA: 0x002C04B8 File Offset: 0x002BE6B8
	public void SetCloseBtnRaycast(bool state)
	{
		this.CaptionItem.SetCloseBtnRaycast(state);
	}

	// Token: 0x0600942D RID: 37933 RVA: 0x002C04C6 File Offset: 0x002BE6C6
	public void SetCloseBtnShowState(bool state)
	{
		this.CaptionItem.SetCloseBtnShowState(state);
	}

	// Token: 0x0600942E RID: 37934 RVA: 0x002C04D4 File Offset: 0x002BE6D4
	public void SetHomeBtnShowState(bool state)
	{
		this.CaptionItem.SetHomeBtnShowState(state);
	}

	// Token: 0x0600942F RID: 37935 RVA: 0x002C04E4 File Offset: 0x002BE6E4
	public void SetTabComponentShowState(bool state)
	{
		this.ScrollView.RootUIComp.Get().SetUIActive(state);
	}

	// Token: 0x06009430 RID: 37936 RVA: 0x002C050A File Offset: 0x002BE70A
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

	// Token: 0x06009431 RID: 37937 RVA: 0x002C0542 File Offset: 0x002BE742
	public void SetTitle(string title)
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.SetTitle(title);
	}

	// Token: 0x06009432 RID: 37938 RVA: 0x002C0558 File Offset: 0x002BE758
	public void SetTitleByTextIdAndArgNew(string textId, params string[] args)
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.SetTitleByTextIdAndArgNew(textId, args);
	}

	// Token: 0x06009433 RID: 37939 RVA: 0x002C0579 File Offset: 0x002BE779
	public void SetTitleIcon(string iconPath)
	{
		this.CaptionItem.SetTitleIcon(iconPath);
	}

	// Token: 0x06009434 RID: 37940 RVA: 0x002C0587 File Offset: 0x002BE787
	public void SetTitleIconVisible(bool state)
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.SetTitleIconVisible(state);
	}

	// Token: 0x06009435 RID: 37941 RVA: 0x002C059A File Offset: 0x002BE79A
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

	// Token: 0x06009436 RID: 37942 RVA: 0x002C05AD File Offset: 0x002BE7AD
	[NullableContext(2)]
	public UUIScrollViewWithScrollbarComponent GetScrollView()
	{
		return this.ScrollView;
	}

	// Token: 0x06009437 RID: 37943 RVA: 0x002C05B8 File Offset: 0x002BE7B8
	public void SetScrollViewVisible(bool state)
	{
		base.GetScrollViewWithScrollbar(1).RootUIComp.Get().SetUIActive(state);
	}

	// Token: 0x06009438 RID: 37944 RVA: 0x002C05DF File Offset: 0x002BE7DF
	protected override bool DestroyOverride()
	{
		return true;
	}

	// Token: 0x04005706 RID: 22278
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04005707 RID: 22279
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private readonly CommonTabComponentData<TTabItem> TabComponentData;

	// Token: 0x04005708 RID: 22280
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<TTabItem> TabComponentInternal;

	// Token: 0x04005709 RID: 22281
	[Nullable(2)]
	private UUIScrollViewWithScrollbarComponent ScrollView;

	// Token: 0x0400570A RID: 22282
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x0400570B RID: 22283
	[Nullable(2)]
	private Action OnCloseCallBack;

	// Token: 0x0400570C RID: 22284
	public bool NeedCaptionSwitchWithToggle = true;

	// Token: 0x0200706A RID: 28778
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04024A7A RID: 150138
		public const int CaptionItem = 0;

		// Token: 0x04024A7B RID: 150139
		public const int ScrollView = 1;

		// Token: 0x04024A7C RID: 150140
		public const int TabRootNode = 2;
	}
}
