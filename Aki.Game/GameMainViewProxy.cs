using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.GameMainView.CommonChildPanel;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CB0 RID: 7344
[NullableContext(1)]
[Nullable(0)]
public abstract class GameMainViewProxy
{
	// Token: 0x170011FF RID: 4607
	// (get) Token: 0x0600DDC2 RID: 56770
	protected abstract EBattleUiCommonChildVisibleReason? BattleUiCommonChildVisibleReason { get; }

	// Token: 0x0600DDC3 RID: 56771 RVA: 0x0033D985 File Offset: 0x0033BB85
	public void RegisterView(CommonGameMainView view)
	{
		this.View = view;
	}

	// Token: 0x0600DDC4 RID: 56772 RVA: 0x0033D990 File Offset: 0x0033BB90
	public UniTask BeforeStartAsync()
	{
		GameMainViewProxy.<BeforeStartAsync>d__12 <BeforeStartAsync>d__;
		<BeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<BeforeStartAsync>d__.<>4__this = this;
		<BeforeStartAsync>d__.<>1__state = -1;
		<BeforeStartAsync>d__.<>t__builder.Start<GameMainViewProxy.<BeforeStartAsync>d__12>(ref <BeforeStartAsync>d__);
		return <BeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DDC5 RID: 56773 RVA: 0x0033D9D3 File Offset: 0x0033BBD3
	public void Start()
	{
		this.SetJoystickPanelHierarchyIndex();
		this.OnStart();
		this.AddEventListenerByStart();
	}

	// Token: 0x0600DDC6 RID: 56774 RVA: 0x0033D9E8 File Offset: 0x0033BBE8
	public void BeforeShow()
	{
		foreach (BattleChildViewPanel battleChildViewPanel in this.ChildPanelMap.Values)
		{
			if (battleChildViewPanel.CheckBattleChildViewPanelShowCondition())
			{
				battleChildViewPanel.ShowBattleChildViewPanel();
			}
		}
		this.OnBeforeShow(!this.IsFirstShow);
		this.IsFirstShow = true;
	}

	// Token: 0x0600DDC7 RID: 56775 RVA: 0x0033DA60 File Offset: 0x0033BC60
	public void AfterShow()
	{
		this.ApplyTouchUiEditData();
		this.OnAfterShow();
		this.RegisterForceShowCursorIfNeeded();
		this.TryAddBattleUiCommonChildVisibleReason();
		EventSystem.Instance.Emit(EEventName.ActiveBattleView);
		EventSystem.Instance.Emit(EEventName.RedDotStart);
	}

	// Token: 0x0600DDC8 RID: 56776 RVA: 0x0033DA9A File Offset: 0x0033BC9A
	public void BeforeHide()
	{
		this.OnBeforeHide();
		this.UnregisterForceShowCursorIfNeeded();
		this.HideViewOperation();
		EventSystem.Instance.Emit(EEventName.DisActiveBattleView);
	}

	// Token: 0x0600DDC9 RID: 56777 RVA: 0x0033DAC0 File Offset: 0x0033BCC0
	public void AfterHide()
	{
		foreach (BattleChildViewPanel battleChildViewPanel in this.ChildPanelMap.Values)
		{
			battleChildViewPanel.HideBattleChildViewPanel();
		}
		this.OnAfterHide();
		this.TryRemoveBattleUiCommonChildVisibleReason();
	}

	// Token: 0x0600DDCA RID: 56778 RVA: 0x0033DB24 File Offset: 0x0033BD24
	private void AddEventListenerByStart()
	{
		EventSystem.Instance.Add(EEventName.OnRouletteViewVisibleChanged, new Action<bool>(this.OnRouletteViewVisibleChanged));
		this.OnAddEventListenerByStart();
	}

	// Token: 0x0600DDCB RID: 56779 RVA: 0x0033DB48 File Offset: 0x0033BD48
	private void RemoveEventListenerForStart()
	{
		EventSystem.Instance.Remove(EEventName.OnRouletteViewVisibleChanged, new Action<bool>(this.OnRouletteViewVisibleChanged));
		this.OnRemoveEventListenerForStart();
	}

	// Token: 0x0600DDCC RID: 56780 RVA: 0x0033DB6C File Offset: 0x0033BD6C
	public void AddEventListener()
	{
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
		this.OnAddEventListener();
	}

	// Token: 0x0600DDCD RID: 56781 RVA: 0x0033DB90 File Offset: 0x0033BD90
	public void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
		this.OnRemoveEventListener();
	}

	// Token: 0x0600DDCE RID: 56782 RVA: 0x0033DBB4 File Offset: 0x0033BDB4
	public void BeforeDestroy()
	{
		this.RemoveEventListenerForStart();
		this.UnregisterForceShowCursorIfNeeded();
		this.ResetAllChildViewPanels();
		this.PanelResIdMap.Clear();
		this.OnBeforeDestroy();
	}

	// Token: 0x0600DDCF RID: 56783 RVA: 0x0033DBDC File Offset: 0x0033BDDC
	public void Tick(float delta)
	{
		foreach (BattleChildViewPanel battleChildViewPanel in this.TickPanelList)
		{
			if (battleChildViewPanel.GetVisible())
			{
				battleChildViewPanel.OnTickBattleChildViewPanel(delta);
			}
		}
		this.OnTick(delta);
	}

	// Token: 0x0600DDD0 RID: 56784 RVA: 0x0033DC40 File Offset: 0x0033BE40
	public void AfterTick(float delta)
	{
		foreach (BattleChildViewPanel battleChildViewPanel in this.TickPanelList)
		{
			if (battleChildViewPanel.GetVisible())
			{
				battleChildViewPanel.OnAfterTickBattleChildViewPanel(delta);
			}
		}
		this.OnAfterTick(delta);
	}

	// Token: 0x0600DDD1 RID: 56785 RVA: 0x0033DCA4 File Offset: 0x0033BEA4
	public UniTask PlayHideSequenceAsync()
	{
		GameMainViewProxy.<PlayHideSequenceAsync>d__25 <PlayHideSequenceAsync>d__;
		<PlayHideSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayHideSequenceAsync>d__.<>4__this = this;
		<PlayHideSequenceAsync>d__.<>1__state = -1;
		<PlayHideSequenceAsync>d__.<>t__builder.Start<GameMainViewProxy.<PlayHideSequenceAsync>d__25>(ref <PlayHideSequenceAsync>d__);
		return <PlayHideSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DDD2 RID: 56786 RVA: 0x0033DCE8 File Offset: 0x0033BEE8
	private UniTask StartAsyncInner()
	{
		GameMainViewProxy.<StartAsyncInner>d__26 <StartAsyncInner>d__;
		<StartAsyncInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<StartAsyncInner>d__.<>4__this = this;
		<StartAsyncInner>d__.<>1__state = -1;
		<StartAsyncInner>d__.<>t__builder.Start<GameMainViewProxy.<StartAsyncInner>d__26>(ref <StartAsyncInner>d__);
		return <StartAsyncInner>d__.<>t__builder.Task;
	}

	// Token: 0x0600DDD3 RID: 56787 RVA: 0x0033DD2B File Offset: 0x0033BF2B
	private void SetJoystickPanelHierarchyIndex()
	{
		if (this.JoystickPanel != null)
		{
			this.JoystickPanel.GetOriginalItem().SetAsFirstHierarchy();
		}
	}

	// Token: 0x0600DDD4 RID: 56788 RVA: 0x0033DD48 File Offset: 0x0033BF48
	private UniTask CreateJoystickPanel()
	{
		GameMainViewProxy.<CreateJoystickPanel>d__28 <CreateJoystickPanel>d__;
		<CreateJoystickPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateJoystickPanel>d__.<>4__this = this;
		<CreateJoystickPanel>d__.<>1__state = -1;
		<CreateJoystickPanel>d__.<>t__builder.Start<GameMainViewProxy.<CreateJoystickPanel>d__28>(ref <CreateJoystickPanel>d__);
		return <CreateJoystickPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600DDD5 RID: 56789 RVA: 0x0033DD8C File Offset: 0x0033BF8C
	private UniTask CreateJoystickPanelInner()
	{
		GameMainViewProxy.<CreateJoystickPanelInner>d__29 <CreateJoystickPanelInner>d__;
		<CreateJoystickPanelInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateJoystickPanelInner>d__.<>4__this = this;
		<CreateJoystickPanelInner>d__.<>1__state = -1;
		<CreateJoystickPanelInner>d__.<>t__builder.Start<GameMainViewProxy.<CreateJoystickPanelInner>d__29>(ref <CreateJoystickPanelInner>d__);
		return <CreateJoystickPanelInner>d__.<>t__builder.Task;
	}

	// Token: 0x0600DDD6 RID: 56790 RVA: 0x0033DDD0 File Offset: 0x0033BFD0
	private UniTask CreatePositionPanel()
	{
		GameMainViewProxy.<CreatePositionPanel>d__30 <CreatePositionPanel>d__;
		<CreatePositionPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreatePositionPanel>d__.<>4__this = this;
		<CreatePositionPanel>d__.<>1__state = -1;
		<CreatePositionPanel>d__.<>t__builder.Start<GameMainViewProxy.<CreatePositionPanel>d__30>(ref <CreatePositionPanel>d__);
		return <CreatePositionPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600DDD7 RID: 56791 RVA: 0x0033DE13 File Offset: 0x0033C013
	private void InputControllerChange(EInputControllerType last, EInputControllerType now)
	{
		this.CreateJoystickPanel().Forget();
		this.OnInputControllerChange();
	}

	// Token: 0x0600DDD8 RID: 56792 RVA: 0x0033DE28 File Offset: 0x0033C028
	private void OnRouletteViewVisibleChanged(bool visible)
	{
		if (Info.Instance.IsInTouch() && this.JoystickPanel != null)
		{
			if (visible)
			{
				this.JoystickPanelOriginalIndex = this.JoystickPanel.GetOriginalItem().GetHierarchyIndex();
				this.JoystickPanel.GetOriginalItem().SetUIParent(this.View.GetRootItem(), false);
			}
			else
			{
				this.JoystickPanel.GetOriginalItem().SetUIParent(this.View.GetContentPanel(), false);
				this.JoystickPanel.GetOriginalItem().SetHierarchyIndex(this.JoystickPanelOriginalIndex);
				this.JoystickPanelOriginalIndex = 0;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CommonGameMainView;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "轮盘界面显隐，调整摇杆面板层级";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("visible", visible);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		this.View.SetMaskItemActive(visible);
		this.OnRouletteViewVisibleChangedInner(visible);
	}

	// Token: 0x0600DDD9 RID: 56793 RVA: 0x0033DF04 File Offset: 0x0033C104
	private void ResetAllChildViewPanels()
	{
		foreach (BattleChildViewPanel battleChildViewPanel in this.ChildPanelMap.Values)
		{
			if (battleChildViewPanel != null)
			{
				battleChildViewPanel.Reset();
			}
		}
		this.ChildPanelMap.Clear();
		this.TickPanelList.Clear();
	}

	// Token: 0x0600DDDA RID: 56794 RVA: 0x0033DF74 File Offset: 0x0033C174
	private void ApplyTouchUiEditData()
	{
		if (this.TouchUiEditGroup == null)
		{
			return;
		}
		if (!Info.Instance.IsInTouch())
		{
			return;
		}
		foreach (KeyValuePair<string, UiPanelBase> keyValuePair in this.PanelResIdMap)
		{
			TouchUiEditApplyHelper.ApplyCommonTouchUiEditData(this.TouchUiEditGroup.Value, keyValuePair.Value, keyValuePair.Key);
		}
	}

	// Token: 0x0600DDDB RID: 56795 RVA: 0x0033DFFC File Offset: 0x0033C1FC
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	protected UniTask<T> CreateChildPanel<[Nullable(0)] T>(string resourceId, UUIItem parentItem, Type panelClass, bool bShow = true, bool bTick = false, EBattleUiChild childType = EBattleUiChild.Common) where T : BattleChildViewPanel
	{
		GameMainViewProxy.<CreateChildPanel>d__35<T> <CreateChildPanel>d__;
		<CreateChildPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder<T>.Create();
		<CreateChildPanel>d__.<>4__this = this;
		<CreateChildPanel>d__.resourceId = resourceId;
		<CreateChildPanel>d__.parentItem = parentItem;
		<CreateChildPanel>d__.panelClass = panelClass;
		<CreateChildPanel>d__.bShow = bShow;
		<CreateChildPanel>d__.bTick = bTick;
		<CreateChildPanel>d__.childType = childType;
		<CreateChildPanel>d__.<>1__state = -1;
		<CreateChildPanel>d__.<>t__builder.Start<GameMainViewProxy.<CreateChildPanel>d__35<T>>(ref <CreateChildPanel>d__);
		return <CreateChildPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600DDDC RID: 56796 RVA: 0x0033E072 File Offset: 0x0033C272
	protected virtual UniTask OnBeforeStartAsync()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600DDDD RID: 56797 RVA: 0x0033E079 File Offset: 0x0033C279
	protected virtual void OnStart()
	{
	}

	// Token: 0x0600DDDE RID: 56798 RVA: 0x0033E07B File Offset: 0x0033C27B
	protected virtual void OnBeforeShow(bool isFirstShow)
	{
	}

	// Token: 0x0600DDDF RID: 56799 RVA: 0x0033E07D File Offset: 0x0033C27D
	protected virtual void OnAfterShow()
	{
	}

	// Token: 0x0600DDE0 RID: 56800 RVA: 0x0033E07F File Offset: 0x0033C27F
	protected virtual void OnBeforeHide()
	{
	}

	// Token: 0x0600DDE1 RID: 56801 RVA: 0x0033E081 File Offset: 0x0033C281
	protected virtual void OnAfterHide()
	{
	}

	// Token: 0x0600DDE2 RID: 56802 RVA: 0x0033E083 File Offset: 0x0033C283
	protected virtual void OnAddEventListenerByStart()
	{
	}

	// Token: 0x0600DDE3 RID: 56803 RVA: 0x0033E085 File Offset: 0x0033C285
	protected virtual void OnRemoveEventListenerForStart()
	{
	}

	// Token: 0x0600DDE4 RID: 56804 RVA: 0x0033E087 File Offset: 0x0033C287
	protected virtual void OnAddEventListener()
	{
	}

	// Token: 0x0600DDE5 RID: 56805 RVA: 0x0033E089 File Offset: 0x0033C289
	protected virtual void OnRemoveEventListener()
	{
	}

	// Token: 0x0600DDE6 RID: 56806 RVA: 0x0033E08B File Offset: 0x0033C28B
	protected virtual void OnBeforeDestroy()
	{
	}

	// Token: 0x0600DDE7 RID: 56807 RVA: 0x0033E08D File Offset: 0x0033C28D
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x0600DDE8 RID: 56808 RVA: 0x0033E08F File Offset: 0x0033C28F
	protected virtual void OnAfterTick(float delta)
	{
	}

	// Token: 0x0600DDE9 RID: 56809 RVA: 0x0033E091 File Offset: 0x0033C291
	protected virtual void OnInputControllerChange()
	{
	}

	// Token: 0x0600DDEA RID: 56810 RVA: 0x0033E093 File Offset: 0x0033C293
	protected virtual void OnRouletteViewVisibleChangedInner(bool visible)
	{
	}

	// Token: 0x0600DDEB RID: 56811 RVA: 0x0033E095 File Offset: 0x0033C295
	protected virtual void HideViewOperation()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.PhantomExploreView))
		{
			UiManager.Instance.CloseView(EUiViewName.PhantomExploreView, null);
		}
	}

	// Token: 0x0600DDEC RID: 56812 RVA: 0x0033E0B8 File Offset: 0x0033C2B8
	protected virtual bool ShouldCreateJoystickPanel()
	{
		return true;
	}

	// Token: 0x0600DDED RID: 56813 RVA: 0x0033E0BC File Offset: 0x0033C2BC
	protected virtual UniTask OnPlayingHideSequenceAsync()
	{
		GameMainViewProxy.<OnPlayingHideSequenceAsync>d__53 <OnPlayingHideSequenceAsync>d__;
		<OnPlayingHideSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingHideSequenceAsync>d__.<>1__state = -1;
		<OnPlayingHideSequenceAsync>d__.<>t__builder.Start<GameMainViewProxy.<OnPlayingHideSequenceAsync>d__53>(ref <OnPlayingHideSequenceAsync>d__);
		return <OnPlayingHideSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DDEE RID: 56814 RVA: 0x0033E0F7 File Offset: 0x0033C2F7
	public virtual bool NeedUiCameraBehavior()
	{
		return false;
	}

	// Token: 0x0600DDEF RID: 56815 RVA: 0x0033E0FA File Offset: 0x0033C2FA
	public virtual void PushCameraHandle(EUiViewName viewName, int viewId, bool isBlend)
	{
	}

	// Token: 0x0600DDF0 RID: 56816 RVA: 0x0033E0FC File Offset: 0x0033C2FC
	public virtual void PopCameraHandle(EUiViewName viewName, UiViewInfo stackTopInfo, int closeViewId, bool popOrDelete)
	{
	}

	// Token: 0x0600DDF1 RID: 56817 RVA: 0x0033E100 File Offset: 0x0033C300
	private void TryAddBattleUiCommonChildVisibleReason()
	{
		if (this.BattleUiCommonChildVisibleReason != null)
		{
			BattleUiModel.Instance.ChildViewData.AddBattleUiCommonChildVisibleReason(this.BattleUiCommonChildVisibleReason.Value);
		}
	}

	// Token: 0x0600DDF2 RID: 56818 RVA: 0x0033E13C File Offset: 0x0033C33C
	private void TryRemoveBattleUiCommonChildVisibleReason()
	{
		if (this.BattleUiCommonChildVisibleReason != null)
		{
			BattleUiModel.Instance.ChildViewData.RemoveBattleUiCommonChildVisibleReason(this.BattleUiCommonChildVisibleReason.Value);
		}
	}

	// Token: 0x17001200 RID: 4608
	// (get) Token: 0x0600DDF3 RID: 56819 RVA: 0x0033E176 File Offset: 0x0033C376
	protected virtual bool NeedForceShowCursor
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17001201 RID: 4609
	// (get) Token: 0x0600DDF4 RID: 56820 RVA: 0x0033E179 File Offset: 0x0033C379
	private string ForceShowCursorTag
	{
		get
		{
			return "GameMainViewProxyForceShowCursor_" + base.GetType().Name;
		}
	}

	// Token: 0x0600DDF5 RID: 56821 RVA: 0x0033E190 File Offset: 0x0033C390
	private void RegisterForceShowCursorIfNeeded()
	{
		if (!this.NeedForceShowCursor || this.ForceShowCursorRegistered)
		{
			return;
		}
		this.ForceShowCursorRegistered = true;
		InputExtraShowCursorCenter.Instance.RegisterExtraRefreshData(this.ForceShowCursorTag, new GameMainViewProxy.ForceShowCursor());
	}

	// Token: 0x0600DDF6 RID: 56822 RVA: 0x0033E1BF File Offset: 0x0033C3BF
	private void UnregisterForceShowCursorIfNeeded()
	{
		if (!this.ForceShowCursorRegistered)
		{
			return;
		}
		this.ForceShowCursorRegistered = false;
		InputExtraShowCursorCenter.Instance.UnRegisterExtraRefreshData(this.ForceShowCursorTag);
		EventSystem.Instance.Emit(EEventName.RefreshCursor);
	}

	// Token: 0x0600DDF7 RID: 56823 RVA: 0x0033E1F4 File Offset: 0x0033C3F4
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public virtual UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length < 2)
		{
			return null;
		}
		string key = configParams[0];
		string text = configParams[1];
		UiPanelBase uiPanelBase;
		this.PanelResIdMap.TryGetValue(key, out uiPanelBase);
		if (text == "-1")
		{
			if (uiPanelBase == null)
			{
				return null;
			}
			return uiPanelBase.GetGuideUiItemAndUiItemForShowEx(configParams);
		}
		else
		{
			UUIItem uuiitem = (uiPanelBase != null) ? uiPanelBase.GetGuideUiItem(text) : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}
	}

	// Token: 0x040065C2 RID: 26050
	[Nullable(2)]
	protected CommonGameMainView View;

	// Token: 0x040065C3 RID: 26051
	protected Dictionary<Type, BattleChildViewPanel> ChildPanelMap = new Dictionary<Type, BattleChildViewPanel>();

	// Token: 0x040065C4 RID: 26052
	protected List<BattleChildViewPanel> TickPanelList = new List<BattleChildViewPanel>();

	// Token: 0x040065C5 RID: 26053
	[Nullable(2)]
	protected JoystickPanel JoystickPanel;

	// Token: 0x040065C6 RID: 26054
	protected int JoystickPanelOriginalIndex;

	// Token: 0x040065C7 RID: 26055
	[Nullable(2)]
	protected PositionPanel PositionPanel;

	// Token: 0x040065C8 RID: 26056
	protected bool IsFirstShow;

	// Token: 0x040065C9 RID: 26057
	protected readonly Dictionary<string, UiPanelBase> PanelResIdMap = new Dictionary<string, UiPanelBase>();

	// Token: 0x040065CA RID: 26058
	protected ECommonTouchUiEditGroup? TouchUiEditGroup;

	// Token: 0x040065CB RID: 26059
	private bool ForceShowCursorRegistered;

	// Token: 0x02008291 RID: 33425
	[NullableContext(0)]
	private sealed class ForceShowCursor : IExtraShowCursor
	{
		// Token: 0x0604A327 RID: 303911 RVA: 0x0134B662 File Offset: 0x01349862
		public bool IsShowCursor()
		{
			return true;
		}
	}
}
