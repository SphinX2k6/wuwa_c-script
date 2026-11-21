using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.GameMainView.CommonChildPanel;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001172 RID: 4466
[NullableContext(1)]
[Nullable(0)]
public abstract class GameMainViewProxy
{
	// Token: 0x17001229 RID: 4649
	// (get) Token: 0x0600B1DF RID: 45535
	protected abstract EBattleUiCommonChildVisibleReason? BattleUiCommonChildVisibleReason { get; }

	// Token: 0x0600B1E0 RID: 45536 RVA: 0x003493C1 File Offset: 0x003475C1
	public void RegisterView(CommonGameMainView view)
	{
		this.View = view;
	}

	// Token: 0x0600B1E1 RID: 45537 RVA: 0x003493CC File Offset: 0x003475CC
	public UniTask BeforeStartAsync()
	{
		GameMainViewProxy.<BeforeStartAsync>d__12 <BeforeStartAsync>d__;
		<BeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<BeforeStartAsync>d__.<>4__this = this;
		<BeforeStartAsync>d__.<>1__state = -1;
		<BeforeStartAsync>d__.<>t__builder.Start<GameMainViewProxy.<BeforeStartAsync>d__12>(ref <BeforeStartAsync>d__);
		return <BeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B1E2 RID: 45538 RVA: 0x0034940F File Offset: 0x0034760F
	public void Start()
	{
		this.SetJoystickPanelHierarchyIndex();
		this.OnStart();
		this.AddEventListenerByStart();
	}

	// Token: 0x0600B1E3 RID: 45539 RVA: 0x00349424 File Offset: 0x00347624
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

	// Token: 0x0600B1E4 RID: 45540 RVA: 0x0034949C File Offset: 0x0034769C
	public void AfterShow()
	{
		this.ApplyTouchUiEditData();
		this.OnAfterShow();
		this.RegisterForceShowCursorIfNeeded();
		this.TryAddBattleUiCommonChildVisibleReason();
		EventSystem.Instance.Emit(EEventName.ActiveBattleView);
		EventSystem.Instance.Emit(EEventName.RedDotStart);
	}

	// Token: 0x0600B1E5 RID: 45541 RVA: 0x003494D6 File Offset: 0x003476D6
	public void BeforeHide()
	{
		this.OnBeforeHide();
		this.UnregisterForceShowCursorIfNeeded();
		this.HideViewOperation();
		EventSystem.Instance.Emit(EEventName.DisActiveBattleView);
	}

	// Token: 0x0600B1E6 RID: 45542 RVA: 0x003494FC File Offset: 0x003476FC
	public void AfterHide()
	{
		foreach (BattleChildViewPanel battleChildViewPanel in this.ChildPanelMap.Values)
		{
			battleChildViewPanel.HideBattleChildViewPanel();
		}
		this.OnAfterHide();
		this.TryRemoveBattleUiCommonChildVisibleReason();
	}

	// Token: 0x0600B1E7 RID: 45543 RVA: 0x00349560 File Offset: 0x00347760
	private void AddEventListenerByStart()
	{
		EventSystem.Instance.Add(EEventName.OnRouletteViewVisibleChanged, new Action<bool>(this.OnRouletteViewVisibleChanged));
		this.OnAddEventListenerByStart();
	}

	// Token: 0x0600B1E8 RID: 45544 RVA: 0x00349584 File Offset: 0x00347784
	private void RemoveEventListenerForStart()
	{
		EventSystem.Instance.Remove(EEventName.OnRouletteViewVisibleChanged, new Action<bool>(this.OnRouletteViewVisibleChanged));
		this.OnRemoveEventListenerForStart();
	}

	// Token: 0x0600B1E9 RID: 45545 RVA: 0x003495A8 File Offset: 0x003477A8
	public void AddEventListener()
	{
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
		this.OnAddEventListener();
	}

	// Token: 0x0600B1EA RID: 45546 RVA: 0x003495CC File Offset: 0x003477CC
	public void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
		this.OnRemoveEventListener();
	}

	// Token: 0x0600B1EB RID: 45547 RVA: 0x003495F0 File Offset: 0x003477F0
	public void BeforeDestroy()
	{
		this.RemoveEventListenerForStart();
		this.UnregisterForceShowCursorIfNeeded();
		this.ResetAllChildViewPanels();
		this.PanelResIdMap.Clear();
		this.OnBeforeDestroy();
	}

	// Token: 0x0600B1EC RID: 45548 RVA: 0x00349618 File Offset: 0x00347818
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

	// Token: 0x0600B1ED RID: 45549 RVA: 0x0034967C File Offset: 0x0034787C
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

	// Token: 0x0600B1EE RID: 45550 RVA: 0x003496E0 File Offset: 0x003478E0
	public UniTask PlayHideSequenceAsync()
	{
		GameMainViewProxy.<PlayHideSequenceAsync>d__25 <PlayHideSequenceAsync>d__;
		<PlayHideSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayHideSequenceAsync>d__.<>4__this = this;
		<PlayHideSequenceAsync>d__.<>1__state = -1;
		<PlayHideSequenceAsync>d__.<>t__builder.Start<GameMainViewProxy.<PlayHideSequenceAsync>d__25>(ref <PlayHideSequenceAsync>d__);
		return <PlayHideSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B1EF RID: 45551 RVA: 0x00349724 File Offset: 0x00347924
	private UniTask StartAsyncInner()
	{
		GameMainViewProxy.<StartAsyncInner>d__26 <StartAsyncInner>d__;
		<StartAsyncInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<StartAsyncInner>d__.<>4__this = this;
		<StartAsyncInner>d__.<>1__state = -1;
		<StartAsyncInner>d__.<>t__builder.Start<GameMainViewProxy.<StartAsyncInner>d__26>(ref <StartAsyncInner>d__);
		return <StartAsyncInner>d__.<>t__builder.Task;
	}

	// Token: 0x0600B1F0 RID: 45552 RVA: 0x00349767 File Offset: 0x00347967
	private void SetJoystickPanelHierarchyIndex()
	{
		if (this.JoystickPanel != null)
		{
			this.JoystickPanel.GetOriginalItem().SetAsFirstHierarchy();
		}
	}

	// Token: 0x0600B1F1 RID: 45553 RVA: 0x00349784 File Offset: 0x00347984
	private UniTask CreateJoystickPanel()
	{
		GameMainViewProxy.<CreateJoystickPanel>d__28 <CreateJoystickPanel>d__;
		<CreateJoystickPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateJoystickPanel>d__.<>4__this = this;
		<CreateJoystickPanel>d__.<>1__state = -1;
		<CreateJoystickPanel>d__.<>t__builder.Start<GameMainViewProxy.<CreateJoystickPanel>d__28>(ref <CreateJoystickPanel>d__);
		return <CreateJoystickPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B1F2 RID: 45554 RVA: 0x003497C8 File Offset: 0x003479C8
	private UniTask CreateJoystickPanelInner()
	{
		GameMainViewProxy.<CreateJoystickPanelInner>d__29 <CreateJoystickPanelInner>d__;
		<CreateJoystickPanelInner>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateJoystickPanelInner>d__.<>4__this = this;
		<CreateJoystickPanelInner>d__.<>1__state = -1;
		<CreateJoystickPanelInner>d__.<>t__builder.Start<GameMainViewProxy.<CreateJoystickPanelInner>d__29>(ref <CreateJoystickPanelInner>d__);
		return <CreateJoystickPanelInner>d__.<>t__builder.Task;
	}

	// Token: 0x0600B1F3 RID: 45555 RVA: 0x0034980C File Offset: 0x00347A0C
	private UniTask CreatePositionPanel()
	{
		GameMainViewProxy.<CreatePositionPanel>d__30 <CreatePositionPanel>d__;
		<CreatePositionPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreatePositionPanel>d__.<>4__this = this;
		<CreatePositionPanel>d__.<>1__state = -1;
		<CreatePositionPanel>d__.<>t__builder.Start<GameMainViewProxy.<CreatePositionPanel>d__30>(ref <CreatePositionPanel>d__);
		return <CreatePositionPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600B1F4 RID: 45556 RVA: 0x0034984F File Offset: 0x00347A4F
	private void InputControllerChange(EInputControllerType last, EInputControllerType now)
	{
		this.CreateJoystickPanel().Forget();
		this.OnInputControllerChange();
	}

	// Token: 0x0600B1F5 RID: 45557 RVA: 0x00349864 File Offset: 0x00347A64
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

	// Token: 0x0600B1F6 RID: 45558 RVA: 0x00349940 File Offset: 0x00347B40
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

	// Token: 0x0600B1F7 RID: 45559 RVA: 0x003499B0 File Offset: 0x00347BB0
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

	// Token: 0x0600B1F8 RID: 45560 RVA: 0x00349A38 File Offset: 0x00347C38
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

	// Token: 0x0600B1F9 RID: 45561 RVA: 0x00349AAE File Offset: 0x00347CAE
	protected virtual UniTask OnBeforeStartAsync()
	{
		return UniTask.CompletedTask;
	}

	// Token: 0x0600B1FA RID: 45562 RVA: 0x00349AB5 File Offset: 0x00347CB5
	protected virtual void OnStart()
	{
	}

	// Token: 0x0600B1FB RID: 45563 RVA: 0x00349AB7 File Offset: 0x00347CB7
	protected virtual void OnBeforeShow(bool isFirstShow)
	{
	}

	// Token: 0x0600B1FC RID: 45564 RVA: 0x00349AB9 File Offset: 0x00347CB9
	protected virtual void OnAfterShow()
	{
	}

	// Token: 0x0600B1FD RID: 45565 RVA: 0x00349ABB File Offset: 0x00347CBB
	protected virtual void OnBeforeHide()
	{
	}

	// Token: 0x0600B1FE RID: 45566 RVA: 0x00349ABD File Offset: 0x00347CBD
	protected virtual void OnAfterHide()
	{
	}

	// Token: 0x0600B1FF RID: 45567 RVA: 0x00349ABF File Offset: 0x00347CBF
	protected virtual void OnAddEventListenerByStart()
	{
	}

	// Token: 0x0600B200 RID: 45568 RVA: 0x00349AC1 File Offset: 0x00347CC1
	protected virtual void OnRemoveEventListenerForStart()
	{
	}

	// Token: 0x0600B201 RID: 45569 RVA: 0x00349AC3 File Offset: 0x00347CC3
	protected virtual void OnAddEventListener()
	{
	}

	// Token: 0x0600B202 RID: 45570 RVA: 0x00349AC5 File Offset: 0x00347CC5
	protected virtual void OnRemoveEventListener()
	{
	}

	// Token: 0x0600B203 RID: 45571 RVA: 0x00349AC7 File Offset: 0x00347CC7
	protected virtual void OnBeforeDestroy()
	{
	}

	// Token: 0x0600B204 RID: 45572 RVA: 0x00349AC9 File Offset: 0x00347CC9
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x0600B205 RID: 45573 RVA: 0x00349ACB File Offset: 0x00347CCB
	protected virtual void OnAfterTick(float delta)
	{
	}

	// Token: 0x0600B206 RID: 45574 RVA: 0x00349ACD File Offset: 0x00347CCD
	protected virtual void OnInputControllerChange()
	{
	}

	// Token: 0x0600B207 RID: 45575 RVA: 0x00349ACF File Offset: 0x00347CCF
	protected virtual void OnRouletteViewVisibleChangedInner(bool visible)
	{
	}

	// Token: 0x0600B208 RID: 45576 RVA: 0x00349AD1 File Offset: 0x00347CD1
	protected virtual void HideViewOperation()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.PhantomExploreView))
		{
			UiManager.Instance.CloseView(EUiViewName.PhantomExploreView, null);
		}
	}

	// Token: 0x0600B209 RID: 45577 RVA: 0x00349AF4 File Offset: 0x00347CF4
	protected virtual bool ShouldCreateJoystickPanel()
	{
		return true;
	}

	// Token: 0x0600B20A RID: 45578 RVA: 0x00349AF8 File Offset: 0x00347CF8
	protected virtual UniTask OnPlayingHideSequenceAsync()
	{
		GameMainViewProxy.<OnPlayingHideSequenceAsync>d__53 <OnPlayingHideSequenceAsync>d__;
		<OnPlayingHideSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingHideSequenceAsync>d__.<>1__state = -1;
		<OnPlayingHideSequenceAsync>d__.<>t__builder.Start<GameMainViewProxy.<OnPlayingHideSequenceAsync>d__53>(ref <OnPlayingHideSequenceAsync>d__);
		return <OnPlayingHideSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B20B RID: 45579 RVA: 0x00349B33 File Offset: 0x00347D33
	public virtual bool NeedUiCameraBehavior()
	{
		return false;
	}

	// Token: 0x0600B20C RID: 45580 RVA: 0x00349B36 File Offset: 0x00347D36
	public virtual void PushCameraHandleByOpenView(EUiViewName viewName, int viewId, EUiCameraHandleOperationType operationType)
	{
	}

	// Token: 0x0600B20D RID: 45581 RVA: 0x00349B38 File Offset: 0x00347D38
	public virtual void PopCameraHandleByCloseView(EUiViewName viewName, EUiViewName? nextViewName, int closeViewId, EUiCameraHandleOperationType operationType)
	{
	}

	// Token: 0x0600B20E RID: 45582 RVA: 0x00349B3C File Offset: 0x00347D3C
	private void TryAddBattleUiCommonChildVisibleReason()
	{
		if (this.BattleUiCommonChildVisibleReason != null)
		{
			BattleUiModel.Instance.ChildViewData.AddBattleUiCommonChildVisibleReason(this.BattleUiCommonChildVisibleReason.Value);
		}
	}

	// Token: 0x0600B20F RID: 45583 RVA: 0x00349B78 File Offset: 0x00347D78
	private void TryRemoveBattleUiCommonChildVisibleReason()
	{
		if (this.BattleUiCommonChildVisibleReason != null)
		{
			BattleUiModel.Instance.ChildViewData.RemoveBattleUiCommonChildVisibleReason(this.BattleUiCommonChildVisibleReason.Value);
		}
	}

	// Token: 0x1700122A RID: 4650
	// (get) Token: 0x0600B210 RID: 45584 RVA: 0x00349BB2 File Offset: 0x00347DB2
	protected virtual bool NeedForceShowCursor
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700122B RID: 4651
	// (get) Token: 0x0600B211 RID: 45585 RVA: 0x00349BB5 File Offset: 0x00347DB5
	private string ForceShowCursorTag
	{
		get
		{
			return "GameMainViewProxyForceShowCursor_" + base.GetType().Name;
		}
	}

	// Token: 0x0600B212 RID: 45586 RVA: 0x00349BCC File Offset: 0x00347DCC
	private void RegisterForceShowCursorIfNeeded()
	{
		if (!this.NeedForceShowCursor || this.ForceShowCursorRegistered)
		{
			return;
		}
		this.ForceShowCursorRegistered = true;
		InputExtraShowCursorCenter.Instance.RegisterExtraRefreshData(this.ForceShowCursorTag, new GameMainViewProxy.ForceShowCursor());
	}

	// Token: 0x0600B213 RID: 45587 RVA: 0x00349BFB File Offset: 0x00347DFB
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

	// Token: 0x0600B214 RID: 45588 RVA: 0x00349C30 File Offset: 0x00347E30
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

	// Token: 0x040066A1 RID: 26273
	[Nullable(2)]
	protected CommonGameMainView View;

	// Token: 0x040066A2 RID: 26274
	protected Dictionary<Type, BattleChildViewPanel> ChildPanelMap = new Dictionary<Type, BattleChildViewPanel>();

	// Token: 0x040066A3 RID: 26275
	protected List<BattleChildViewPanel> TickPanelList = new List<BattleChildViewPanel>();

	// Token: 0x040066A4 RID: 26276
	[Nullable(2)]
	protected JoystickPanel JoystickPanel;

	// Token: 0x040066A5 RID: 26277
	protected int JoystickPanelOriginalIndex;

	// Token: 0x040066A6 RID: 26278
	[Nullable(2)]
	protected PositionPanel PositionPanel;

	// Token: 0x040066A7 RID: 26279
	protected bool IsFirstShow;

	// Token: 0x040066A8 RID: 26280
	protected readonly Dictionary<string, UiPanelBase> PanelResIdMap = new Dictionary<string, UiPanelBase>();

	// Token: 0x040066A9 RID: 26281
	protected ECommonTouchUiEditGroup? TouchUiEditGroup;

	// Token: 0x040066AA RID: 26282
	private bool ForceShowCursorRegistered;

	// Token: 0x0200741B RID: 29723
	[NullableContext(0)]
	private sealed class ForceShowCursor : IExtraShowCursor
	{
		// Token: 0x06040730 RID: 263984 RVA: 0x012EEAFA File Offset: 0x012ECCFA
		public bool IsShowCursor()
		{
			return true;
		}
	}
}
