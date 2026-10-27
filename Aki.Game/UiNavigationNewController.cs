using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002CCB RID: 11467
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class UiNavigationNewController : UiControllerBase
{
	// Token: 0x1700206C RID: 8300
	// (get) Token: 0x0601805A RID: 98394 RVA: 0x0061B1E4 File Offset: 0x006193E4
	protected override bool IsTickEvenPausedInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0601805B RID: 98395 RVA: 0x0061B1E8 File Offset: 0x006193E8
	[NullableContext(2)]
	private NavigationScrollbarData GetCurrentNavigationScrollbarData()
	{
		UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
		if (currentViewHandle == null)
		{
			Log.Instance.Info(ELogModule.UiNavigation, ELogAuthor.XXJ, "[GetCurrentNavigationScrollbarData]查找不到当前的导航句柄", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return currentViewHandle.GetScrollbarData();
	}

	// Token: 0x0601805C RID: 98396 RVA: 0x0061B22C File Offset: 0x0061942C
	[return: Nullable(2)]
	public unsafe TsUiNavigationBehaviorListener GetCurrentNavigationActiveListenerByTag(string tag, bool isAllowEmpty = false)
	{
		UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
		if (currentViewHandle == null)
		{
			Log.Instance.Info(ELogModule.UiNavigation, ELogAuthor.XXJ, "[GetCurrentNavigationActiveListenerByTag]查找不到当前的导航句柄", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		if (!currentViewHandle.GetIsActive())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiNavigation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[GetCurrentNavigationActiveListenerByTag]当前的导航句柄不在显示中";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Tag", tag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ViewName", currentViewHandle.ViewName);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		TsUiNavigationBehaviorListener activeListenerByTag = currentViewHandle.GetActiveListenerByTag(tag);
		if (activeListenerByTag == null && !isAllowEmpty)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.UiNavigation;
			ELogAuthor author2 = ELogAuthor.XXJ;
			string message2 = "[GetCurrentNavigationActiveListenerByTag]查找不到对应的按钮";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Tag", tag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ViewName", currentViewHandle.ViewName);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return null;
		}
		return activeListenerByTag;
	}

	// Token: 0x0601805D RID: 98397 RVA: 0x0061B33C File Offset: 0x0061953C
	[NullableContext(2)]
	public TsUiNavigationBehaviorListener GetCurrentNavigationFocusListener()
	{
		UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
		if (currentViewHandle == null)
		{
			Log.Instance.Info(ELogModule.UiNavigation, ELogAuthor.XXJ, "[GetCurrentNavigationFocusListener]查找不到当前的导航句柄", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		TsUiNavigationBehaviorListener focusListener = currentViewHandle.GetFocusListener();
		if (focusListener == null)
		{
			return null;
		}
		return focusListener;
	}

	// Token: 0x0601805E RID: 98398 RVA: 0x0061B388 File Offset: 0x00619588
	[NullableContext(2)]
	private NavigationGroup GetCurrentNavigationListenerGroup()
	{
		TsUiNavigationBehaviorListener currentNavigationFocusListener = this.GetCurrentNavigationFocusListener();
		if (currentNavigationFocusListener == null)
		{
			return null;
		}
		UiNavigationLogic.MemoryGroupConfigLastSelect(currentNavigationFocusListener);
		NavigationGroup navigationGroup = currentNavigationFocusListener.GetNavigationGroup();
		if (navigationGroup == null)
		{
			Log.Instance.Error(ELogModule.UiNavigation, ELogAuthor.XXJ, "[GetCurrentNavigationListenerGroup]查找不到当前导航的导航组,逻辑上有问题", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return navigationGroup;
	}

	// Token: 0x0601805F RID: 98399 RVA: 0x0061B3D4 File Offset: 0x006195D4
	protected unsafe override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.LoadLguiEventSystemActor, new Action(this.Initialize));
		EventSystem.Instance.Add(EEventName.DestroyLguiEventSystemActor, new Action(this.Destroy));
		EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.InputControllerMainTypeChange));
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
		EventSystem.Instance.Add(EEventName.PointerInputTypeChange, new Action<ELGUIPointerInputType>(this.PointerInputTypeChange));
		int num = 4;
		List<string> list = new List<string>(num);
		CollectionsMarshal.SetCount<string>(list, num);
		Span<string> span = CollectionsMarshal.AsSpan<string>(list);
		int num2 = 0;
		*span[num2] = "UI方向上";
		num2++;
		*span[num2] = "UI方向下";
		num2++;
		*span[num2] = "UI方向左";
		num2++;
		*span[num2] = "UI方向右";
		List<string> actionNames = list;
		InputDistributeController.Instance.BindActions(actionNames, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputNavigation));
		InputDistributeController.Instance.BindAction("手柄引导下一步", new TInputHandle<InputDistributeDefine.EActionType>(this.OnGuideInputNavigation));
	}

	// Token: 0x06018060 RID: 98400 RVA: 0x0061B4FC File Offset: 0x006196FC
	protected unsafe override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.LoadLguiEventSystemActor, new Action(this.Initialize));
		EventSystem.Instance.Remove(EEventName.DestroyLguiEventSystemActor, new Action(this.Destroy));
		EventSystem.Instance.Remove(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.InputControllerMainTypeChange));
		EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
		EventSystem.Instance.Remove(EEventName.PointerInputTypeChange, new Action<ELGUIPointerInputType>(this.PointerInputTypeChange));
		int num = 4;
		List<string> list = new List<string>(num);
		CollectionsMarshal.SetCount<string>(list, num);
		Span<string> span = CollectionsMarshal.AsSpan<string>(list);
		int num2 = 0;
		*span[num2] = "UI方向上";
		num2++;
		*span[num2] = "UI方向下";
		num2++;
		*span[num2] = "UI方向左";
		num2++;
		*span[num2] = "UI方向右";
		List<string> actionNames = list;
		InputDistributeController.Instance.UnBindActions(actionNames, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputNavigation));
		InputDistributeController.Instance.UnBindAction("手柄引导下一步", new TInputHandle<InputDistributeDefine.EActionType>(this.OnGuideInputNavigation));
	}

	// Token: 0x06018061 RID: 98401 RVA: 0x0061B624 File Offset: 0x00619824
	private void Initialize()
	{
		ULGUIEventSystem lguiEventSystem = LguiEventSystemManager.Instance.LguiEventSystem;
		if (lguiEventSystem == null)
		{
			return;
		}
		UiNavigationLogic.InitNavigationDelegate(LguiEventSystemManager.Instance.LguiEventSystem);
		lguiEventSystem.HighlightWhenMouseMoveOut = UiNavigationConfig.Instance.GetHighlightWhenMouseMoveOut();
		UUISelectableComponent.SetShieldMobileHighlight(UiNavigationConfig.Instance.GetMobileHighlight());
		UUISelectableComponent.SetShieldPCPress(UiNavigationConfig.Instance.GetPcPress());
		InputDistributeModel.Instance.AddInputDistributeTagChangedListener("UiInputRoot.Navigation", new TInputTagChangedCallback(this.OnNavigationTagChanged));
	}

	// Token: 0x06018062 RID: 98402 RVA: 0x0061B698 File Offset: 0x00619898
	private void Destroy()
	{
		UiNavigationLogic.ClearNavigationDelegate(LguiEventSystemManager.Instance.LguiEventSystem);
		InputDistributeModel instance = InputDistributeModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.RemoveInputDistributeTagChangedListener("UiInputRoot.Navigation", new TInputTagChangedCallback(this.OnNavigationTagChanged));
	}

	// Token: 0x06018063 RID: 98403 RVA: 0x0061B6CC File Offset: 0x006198CC
	private void OnNavigationTagChanged(string tagName, bool tagExist)
	{
		if (!tagExist)
		{
			Log.Instance.Info(ELogModule.UiNavigation, ELogAuthor.XXJ, "导航的输入分发被删除,需要抬起持续输入的按钮", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiNavigationJoystickInput.ResetJoystickActionInput();
		}
	}

	// Token: 0x06018064 RID: 98404 RVA: 0x0061B700 File Offset: 0x00619900
	private void InputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
	{
		if (last == EInputControllerMainType.Gamepad || last == EInputControllerMainType.Keyboard)
		{
			Log.Instance.Info(ELogModule.UiNavigation, ELogAuthor.XXJ, "输入总类型发生变更,需要抬起持续输入的按钮", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiNavigationJoystickInput.ResetJoystickActionInput();
		}
	}

	// Token: 0x06018065 RID: 98405 RVA: 0x0061B73C File Offset: 0x0061993C
	private unsafe void InputControllerChange(EInputControllerType last, EInputControllerType now)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.UiNavigation;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "[InputChange]输入类型改变!";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("last", last);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("now", now);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		UiNavigationModel.Instance.InputControllerModeChange();
		UiNavigationLogic.HandleInputControllerTypeChange();
		UiNavigationLogic.ForceChangeInputType();
		UiNavigationViewManager.Instance.RefreshCurrentHotKey();
	}

	// Token: 0x06018066 RID: 98406 RVA: 0x0061B7C8 File Offset: 0x006199C8
	private void PointerInputTypeChange(ELGUIPointerInputType type)
	{
		if (Info.Instance.IsInGamepad())
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.UiNavigation;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "[InputChange]输入类型改变!";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("InputType", type);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		UiNavigationLogic.HandleInputControllerTypeChange();
	}

	// Token: 0x06018067 RID: 98407 RVA: 0x0061B816 File Offset: 0x00619A16
	private void OnInputNavigation(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
	{
		UiNavigationJoystickInput.TriggerActionInputTick(actionName, actionType);
	}

	// Token: 0x06018068 RID: 98408 RVA: 0x0061B820 File Offset: 0x00619A20
	private void OnGuideInputNavigation(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
	{
		UiNavigationModel instance = UiNavigationModel.Instance;
		if (instance == null)
		{
			return;
		}
		if (instance.GuideFocusListener != null)
		{
			this.ClickButtonInternal(instance.GuideFocusListener);
			this.ResetNavigationFocusForGuide();
		}
	}

	// Token: 0x06018069 RID: 98409 RVA: 0x0061B851 File Offset: 0x00619A51
	protected override void OnTick(float delta)
	{
		UiNavigationJoystickInput.Tick(delta);
		UiNavigationModel.Instance.Tick(delta);
	}

	// Token: 0x0601806A RID: 98410 RVA: 0x0061B864 File Offset: 0x00619A64
	public void HotKeyCloseView()
	{
		TsUiNavigationBehaviorListener currentNavigationActiveListenerByTag = this.GetCurrentNavigationActiveListenerByTag("tag1", true);
		if (Info.Instance.IsInGamepad() && this.JumpNavigationGroup(ELGUINavigationDirection.Prev))
		{
			UiNavigationLogic.ExecuteInterfaceMethod<INavigationInteractPrevGroup>(currentNavigationActiveListenerByTag.GetNavigationComponent(), "InteractClickPrevGroup", Array.Empty<object>());
			return;
		}
		if (currentNavigationActiveListenerByTag == null)
		{
			return;
		}
		this.ClickButtonInternal(currentNavigationActiveListenerByTag);
	}

	// Token: 0x0601806B RID: 98411 RVA: 0x0061B8B4 File Offset: 0x00619AB4
	public void ClickButton(string tag)
	{
		TsUiNavigationBehaviorListener currentNavigationActiveListenerByTag = this.GetCurrentNavigationActiveListenerByTag(tag, true);
		if (currentNavigationActiveListenerByTag == null)
		{
			return;
		}
		this.ClickButtonInternal(currentNavigationActiveListenerByTag);
	}

	// Token: 0x0601806C RID: 98412 RVA: 0x0061B8D8 File Offset: 0x00619AD8
	public bool SimulateClickItem(UUIItem uiItem, FVector2D? pivot)
	{
		TsLguiEventSystemActor lguiEventSystemActor = LguiEventSystemManager.Instance.LguiEventSystemActor;
		if (lguiEventSystemActor == null)
		{
			return false;
		}
		int pointerId = UiNavigationInputEventData.ActivateInputEventDataOnce();
		return lguiEventSystemActor.SimulateClickButton(pointerId, uiItem, pivot);
	}

	// Token: 0x0601806D RID: 98413 RVA: 0x0061B904 File Offset: 0x00619B04
	private void ClickButtonInternal(TsUiNavigationBehaviorListener listener)
	{
		if (this.InMaskState())
		{
			return;
		}
		if (!this.SimulateClickItem(listener.GetBehaviorComponent().RootUIComp, new FVector2D?(listener.ClickPivot)))
		{
			UiNavigationLogic.ExecuteInterfaceMethod<INavigationInteractFailClick>(listener.GetNavigationComponent(), "InteractClickFailHandle", Array.Empty<object>());
			return;
		}
		UiNavigationLogic.ExecuteInterfaceMethod<INavigationInteractClick>(listener.GetNavigationComponent(), "InteractClickHandle", Array.Empty<object>());
		UiNavigationModel instance = UiNavigationModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.RepeatMove();
	}

	// Token: 0x0601806E RID: 98414 RVA: 0x0061B978 File Offset: 0x00619B78
	public void ClickButtonInside(string tag)
	{
		TsUiNavigationBehaviorListener currentNavigationFocusListener = this.GetCurrentNavigationFocusListener();
		if (currentNavigationFocusListener == null)
		{
			return;
		}
		TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = this.GetFocusListenerInsideListenerByTag(currentNavigationFocusListener, tag);
		if (tsUiNavigationBehaviorListener == null)
		{
			tsUiNavigationBehaviorListener = currentNavigationFocusListener.GetChildListenerByTag(tag);
		}
		if (tsUiNavigationBehaviorListener == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiNavigation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[ClickButtonInside]查找不到对应的热键按钮";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Tag", tag);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.ClickButtonInternal(tsUiNavigationBehaviorListener);
	}

	// Token: 0x0601806F RID: 98415 RVA: 0x0061B9DC File Offset: 0x00619BDC
	public bool Interact(bool bPress, int configId)
	{
		TsUiNavigationBehaviorListener currentNavigationFocusListener = this.GetCurrentNavigationFocusListener();
		if (currentNavigationFocusListener == null)
		{
			return false;
		}
		if (bPress)
		{
			return this.PointDownUpInternal(currentNavigationFocusListener, true, configId, this.DefaultPivot);
		}
		return this.PointDownUpInternal(currentNavigationFocusListener, false, configId, this.DefaultPivot);
	}

	// Token: 0x06018070 RID: 98416 RVA: 0x0061BA17 File Offset: 0x00619C17
	[NullableContext(2)]
	public bool InteractRelease(int configId, TsUiNavigationBehaviorListener listener)
	{
		return listener != null && this.PointDownUpInternal(listener, false, configId, this.DefaultPivot);
	}

	// Token: 0x06018071 RID: 98417 RVA: 0x0061BA30 File Offset: 0x00619C30
	public void InteractClick()
	{
		TsUiNavigationBehaviorListener currentNavigationFocusListener = this.GetCurrentNavigationFocusListener();
		this.InteractClickByListener(currentNavigationFocusListener);
	}

	// Token: 0x06018072 RID: 98418 RVA: 0x0061BA4B File Offset: 0x00619C4B
	[NullableContext(2)]
	public void InteractClickByListener(TsUiNavigationBehaviorListener listener)
	{
		if (listener == null)
		{
			return;
		}
		UiNavigationGlobalData.IsAllowLoopScrollInteractHighlight = true;
		this.ClickButtonInternal(listener);
		UiNavigationGlobalData.IsAllowLoopScrollInteractHighlight = false;
	}

	// Token: 0x06018073 RID: 98419 RVA: 0x0061BA64 File Offset: 0x00619C64
	public void FindScrollbar(bool isNext)
	{
		NavigationScrollbarData currentNavigationScrollbarData = this.GetCurrentNavigationScrollbarData();
		if (currentNavigationScrollbarData == null)
		{
			return;
		}
		if (isNext)
		{
			currentNavigationScrollbarData.FindNextScrollbar();
			return;
		}
		currentNavigationScrollbarData.FindPrevScrollbar();
	}

	// Token: 0x06018074 RID: 98420 RVA: 0x0061BA8C File Offset: 0x00619C8C
	public void ScrollBarChangeSchedule(float value)
	{
		NavigationScrollbarData currentNavigationScrollbarData = this.GetCurrentNavigationScrollbarData();
		if (currentNavigationScrollbarData == null)
		{
			return;
		}
		UUIScrollViewComponent currentScrollbar = currentNavigationScrollbarData.GetCurrentScrollbar();
		this.HandleScrollbarComponentSetValue(currentScrollbar, value);
	}

	// Token: 0x06018075 RID: 98421 RVA: 0x0061BAB4 File Offset: 0x00619CB4
	public void ScrollBarChangeScheduleByListener(TsUiNavigationBehaviorListener listener, float value)
	{
		UUIScrollViewComponent uuiscrollViewComponent = listener.GetBehaviorComponent() as UUIScrollViewComponent;
		if (uuiscrollViewComponent == null)
		{
			return;
		}
		this.HandleScrollbarComponentSetValue(uuiscrollViewComponent, value);
	}

	// Token: 0x06018076 RID: 98422 RVA: 0x0061BADC File Offset: 0x00619CDC
	public void VerticalScrollBarChangeSchedule(float value)
	{
		NavigationScrollbarData currentNavigationScrollbarData = this.GetCurrentNavigationScrollbarData();
		if (currentNavigationScrollbarData == null)
		{
			return;
		}
		UUIScrollViewComponent currentScrollbar = currentNavigationScrollbarData.GetCurrentScrollbar();
		if (currentScrollbar == null)
		{
			return;
		}
		this.HandleVerticalScrollbarComponentSetValue(currentScrollbar, value);
	}

	// Token: 0x06018077 RID: 98423 RVA: 0x0061BB08 File Offset: 0x00619D08
	public void HorizontalScrollBarChangeSchedule(float value)
	{
		NavigationScrollbarData currentNavigationScrollbarData = this.GetCurrentNavigationScrollbarData();
		if (currentNavigationScrollbarData == null)
		{
			return;
		}
		UUIScrollViewComponent currentScrollbar = currentNavigationScrollbarData.GetCurrentScrollbar();
		this.HandleHorizontalScrollbarComponentSetValue(currentScrollbar, value);
	}

	// Token: 0x06018078 RID: 98424 RVA: 0x0061BB30 File Offset: 0x00619D30
	public void BookMarkNavigation(ELGUINavigationDirection direction, string tag)
	{
		TsUiNavigationBehaviorListener currentNavigationActiveListenerByTag = this.GetCurrentNavigationActiveListenerByTag(tag, false);
		if (currentNavigationActiveListenerByTag == null)
		{
			return;
		}
		NavigationGroup navigationGroup = currentNavigationActiveListenerByTag.GetNavigationGroup();
		if (navigationGroup == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiNavigation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[BookMarkNavigation]查找不到对应的导航组";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Tag", tag);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		UUIExtendToggle uuiextendToggle = null;
		List<TsUiNavigationBehaviorListener> canFocusListeners = (from l in navigationGroup.ListenerList
		where l.IsCanFocus()
		select l).ToList<TsUiNavigationBehaviorListener>();
		List<TsUiNavigationBehaviorListener> list = (from l in canFocusListeners
		where l.IsSelectedToggle()
		select l).ToList<TsUiNavigationBehaviorListener>();
		if (list.Count == 1)
		{
			uuiextendToggle = (list[0].GetSelectableComponent() as UUIExtendToggle);
		}
		else if (list.Count > 1)
		{
			List<int> indices = (from l in list
			select canFocusListeners.IndexOf(l) into x
			orderby x
			select x).ToList<int>();
			if (!indices.Select((int val, int idx) => new ValueTuple<int, int>(val, idx)).All(([TupleElementNames(new string[]
			{
				"val",
				"idx"
			})] ValueTuple<int, int> x) => x.Item2 == 0 || x.Item1 == indices[x.Item2 - 1] + 1))
			{
				List<TsUiNavigationBehaviorListener> canFocusListeners2 = canFocusListeners;
				List<int> indices3 = indices;
				uuiextendToggle = (canFocusListeners2[indices3[indices3.Count - 1]].GetSelectableComponent() as UUIExtendToggle);
			}
			else
			{
				int num;
				if (direction != ELGUINavigationDirection.Right && direction != ELGUINavigationDirection.Down && direction != ELGUINavigationDirection.Next)
				{
					num = indices[0];
				}
				else
				{
					List<int> indices2 = indices;
					num = indices2[indices2.Count - 1];
				}
				int index = num;
				uuiextendToggle = (canFocusListeners[index].GetSelectableComponent() as UUIExtendToggle);
			}
		}
		USceneComponent usceneComponent = UiNavigationLogic.TryFindNavigationDelegate(direction, uuiextendToggle);
		object obj;
		if (usceneComponent == null)
		{
			obj = null;
		}
		else
		{
			AActor owner = usceneComponent.GetOwner();
			obj = ((owner != null) ? owner.GetComponentByClass(UUIExtendToggle.StaticClass()) : null);
		}
		UUIExtendToggle uuiextendToggle2 = obj as UUIExtendToggle;
		if (uuiextendToggle2 == null || uuiextendToggle == uuiextendToggle2)
		{
			ELGUINavigationDirection? elguinavigationDirection = null;
			switch (direction)
			{
			case ELGUINavigationDirection.Left:
				elguinavigationDirection = new ELGUINavigationDirection?(ELGUINavigationDirection.Up);
				break;
			case ELGUINavigationDirection.Right:
				elguinavigationDirection = new ELGUINavigationDirection?(ELGUINavigationDirection.Down);
				break;
			case ELGUINavigationDirection.Up:
				elguinavigationDirection = new ELGUINavigationDirection?(ELGUINavigationDirection.Left);
				break;
			case ELGUINavigationDirection.Down:
				elguinavigationDirection = new ELGUINavigationDirection?(ELGUINavigationDirection.Right);
				break;
			default:
				elguinavigationDirection = new ELGUINavigationDirection?(ELGUINavigationDirection.None);
				break;
			}
			USceneComponent usceneComponent2 = UiNavigationLogic.TryFindNavigationDelegate(elguinavigationDirection.Value, uuiextendToggle);
			object obj2;
			if (usceneComponent2 == null)
			{
				obj2 = null;
			}
			else
			{
				AActor owner2 = usceneComponent2.GetOwner();
				obj2 = ((owner2 != null) ? owner2.GetComponentByClass(UUIExtendToggle.StaticClass()) : null);
			}
			uuiextendToggle2 = (obj2 as UUIExtendToggle);
		}
		if (uuiextendToggle2 == null)
		{
			return;
		}
		TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = uuiextendToggle2.GetOwner().GetComponentByClass(TsUiNavigationBehaviorListener.StaticClass()) as TsUiNavigationBehaviorListener;
		if (uuiextendToggle2.bAutoScrollOnSelected && tsUiNavigationBehaviorListener != null)
		{
			UiNavigationScrollProxy scrollProxy = tsUiNavigationBehaviorListener.ScrollProxy;
			bool? flag;
			if (scrollProxy == null)
			{
				flag = null;
			}
			else
			{
				UUIScrollViewWithScrollbarComponent scrollView = scrollProxy.ScrollView;
				flag = ((scrollView != null) ? new bool?(scrollView.IsValid()) : null);
			}
			bool? flag2 = flag;
			if (flag2.GetValueOrDefault())
			{
				this.NavigateScrollTo(tsUiNavigationBehaviorListener);
			}
		}
		this.ClickButtonInternal(tsUiNavigationBehaviorListener);
		if (navigationGroup.RefreshNavigation)
		{
			this.MarkViewHandleRefreshNavigationDirty();
		}
	}

	// Token: 0x06018079 RID: 98425 RVA: 0x0061BE6C File Offset: 0x0061A06C
	public void MarkViewHandleRefreshNavigationDirty()
	{
		UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
		if (currentViewHandle == null)
		{
			return;
		}
		currentViewHandle.MarkRefreshNavigationDirty(0);
	}

	// Token: 0x0601807A RID: 98426 RVA: 0x0061BE84 File Offset: 0x0061A084
	public void MarkViewHandleRefreshNavigationDirtyByGroupItem(UUIItem uiItem)
	{
		TsUiNavigationPanelConfig tsUiNavigationPanelConfig = uiItem.GetOwner().GetComponentByClass(TsUiNavigationPanelConfig.StaticClass()) as TsUiNavigationPanelConfig;
		if (tsUiNavigationPanelConfig != null)
		{
			UiNavigationViewHandle viewHandle = tsUiNavigationPanelConfig.ViewHandle;
			if (viewHandle == null)
			{
				return;
			}
			viewHandle.MarkRefreshNavigationDirty(0);
		}
	}

	// Token: 0x0601807B RID: 98427 RVA: 0x0061BEC0 File Offset: 0x0061A0C0
	public bool JumpNavigationGroupByTag(string tag)
	{
		NavigationGroup currentNavigationListenerGroup = this.GetCurrentNavigationListenerGroup();
		if (currentNavigationListenerGroup == null)
		{
			return false;
		}
		if (StringUtils.IsBlank(tag))
		{
			return this.JumpNavigationGroup(ELGUINavigationDirection.Next);
		}
		string text;
		string nextGroupName = currentNavigationListenerGroup.GroupNameMap.TryGetValue(tag, out text) ? text : string.Empty;
		return this.JumpNavigationGroupByName(currentNavigationListenerGroup.GroupName, nextGroupName);
	}

	// Token: 0x0601807C RID: 98428 RVA: 0x0061BF10 File Offset: 0x0061A110
	public bool JumpNavigationGroupByName(string lastGroupName, string nextGroupName)
	{
		UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
		bool flag = this.ChangeFocusListenerByGroupName(currentViewHandle, nextGroupName);
		if (flag)
		{
			NavigationGroup activeNavigationGroupByNameCheckAll = currentViewHandle.GetActiveNavigationGroupByNameCheckAll(nextGroupName);
			if (activeNavigationGroupByNameCheckAll != null)
			{
				activeNavigationGroupByNameCheckAll.PrevGroupName = lastGroupName;
			}
		}
		return flag;
	}

	// Token: 0x0601807D RID: 98429 RVA: 0x0061BF48 File Offset: 0x0061A148
	public bool JumpNavigationGroup(ELGUINavigationDirection direction)
	{
		NavigationGroup currentNavigationListenerGroup = this.GetCurrentNavigationListenerGroup();
		if (currentNavigationListenerGroup == null)
		{
			return false;
		}
		UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
		if (direction == ELGUINavigationDirection.Next)
		{
			return this.ChangeFocusListenerByGroupName(currentViewHandle, currentNavigationListenerGroup.NextGroupName);
		}
		if (direction != ELGUINavigationDirection.Prev)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiNavigation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "导航组跳转方向错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("direction", direction);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		bool flag = this.ChangeFocusListenerByGroupName(currentViewHandle, currentNavigationListenerGroup.PrevGroupName);
		if (flag && currentNavigationListenerGroup.SelectableMemory)
		{
			currentNavigationListenerGroup.LastSelectListener = null;
		}
		return flag;
	}

	// Token: 0x0601807E RID: 98430 RVA: 0x0061BFD4 File Offset: 0x0061A1D4
	private bool ChangeFocusListenerByGroupName(UiNavigationViewHandle viewHandle, string groupName)
	{
		if (UiNavigationGlobalData.IsBlockNavigation)
		{
			return false;
		}
		NavigationGroup activeNavigationGroupByNameCheckAll = viewHandle.GetActiveNavigationGroupByNameCheckAll(groupName);
		if (activeNavigationGroupByNameCheckAll == null)
		{
			return false;
		}
		TsUiNavigationBehaviorListener canNavigationListenerInGroup = this.GetCanNavigationListenerInGroup(activeNavigationGroupByNameCheckAll);
		if (canNavigationListenerInGroup == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiNavigation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[ChangeFocusListenerByGroupName]找不到可跳转的导航对象";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("GroupName", groupName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		this.NavigateScrollTo(canNavigationListenerInGroup);
		this.SwitchNavigationFocus(canNavigationListenerInGroup);
		return true;
	}

	// Token: 0x0601807F RID: 98431 RVA: 0x0061C040 File Offset: 0x0061A240
	private void NavigateScrollTo(TsUiNavigationBehaviorListener listener)
	{
		UiNavigationScrollProxy scrollProxy = listener.ScrollProxy;
		if (((scrollProxy != null) ? scrollProxy.ScrollView : null) == null)
		{
			return;
		}
		UUISelectableComponent selectableComponent = listener.GetSelectableComponent();
		if (selectableComponent == null)
		{
			return;
		}
		listener.ScrollProxy.ScrollView.ScrollTo(selectableComponent.GetRootComponent(), false);
	}

	// Token: 0x06018080 RID: 98432 RVA: 0x0061C084 File Offset: 0x0061A284
	[return: Nullable(2)]
	private TsUiNavigationBehaviorListener GetCanNavigationListenerInGroup(NavigationGroup groupConfig)
	{
		if (groupConfig == null)
		{
			Log.Instance.Info(ELogModule.UiNavigation, ELogAuthor.XXJ, "[GetActiveListenerInGroup]找不到导航组", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		if (groupConfig.SelectableMemory && groupConfig.LastSelectListener != null)
		{
			TsUiNavigationBehaviorListener lastSelectListener = groupConfig.LastSelectListener;
			if (lastSelectListener.IsCanFocus())
			{
				return lastSelectListener;
			}
		}
		return this.FindListenerByGroupConfig(groupConfig);
	}

	// Token: 0x06018081 RID: 98433 RVA: 0x0061C0E0 File Offset: 0x0061A2E0
	[NullableContext(2)]
	private static TsUiNavigationBehaviorListener GetLastCanNavigationListenerInGroup(NavigationGroup groupConfig)
	{
		if (groupConfig == null)
		{
			Log.Instance.Info(ELogModule.UiNavigation, ELogAuthor.XXJ, "[GetLastCanNavigationListenerInGroup]找不到导航组", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		List<TsUiNavigationBehaviorListener> listenerList = groupConfig.ListenerList;
		if (listenerList.Count <= 0)
		{
			return null;
		}
		List<TsUiNavigationBehaviorListener> list = new List<TsUiNavigationBehaviorListener>(listenerList);
		list.Sort((TsUiNavigationBehaviorListener a, TsUiNavigationBehaviorListener b) => b.RootUIComp.Get().GetFlattenHierarchyIndex().CompareTo(a.RootUIComp.Get().GetFlattenHierarchyIndex()));
		for (int i = 0; i < list.Count; i++)
		{
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = list[i];
			if (tsUiNavigationBehaviorListener.IsCanFocus())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiNavigation;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "[GetLastCanNavigationListenerInGroup]找到最后一个可导航对象";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("i", i);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return tsUiNavigationBehaviorListener;
			}
		}
		return null;
	}

	// Token: 0x06018082 RID: 98434 RVA: 0x0061C1AC File Offset: 0x0061A3AC
	[return: Nullable(2)]
	private TsUiNavigationBehaviorListener FindListenerByGroupConfig(NavigationGroup groupConfig)
	{
		if (groupConfig.DefaultListener != null)
		{
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = groupConfig.DefaultListener;
			if (tsUiNavigationBehaviorListener.IsIgnoreScrollOrLayoutCheckInSwitchGroup())
			{
				return this.FindLoopOrLayoutListener(groupConfig);
			}
			if (tsUiNavigationBehaviorListener.GetNavigationGroup() != null && tsUiNavigationBehaviorListener.GetNavigationGroup().SuitableListenerByNoDynamic)
			{
				TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener2 = this.FindSuitableListenerWithoutLayout(groupConfig);
				if (tsUiNavigationBehaviorListener2 != null)
				{
					tsUiNavigationBehaviorListener = tsUiNavigationBehaviorListener2;
				}
			}
			if (!tsUiNavigationBehaviorListener.IsScrollOrLayoutActor() && tsUiNavigationBehaviorListener.IsCanFocus())
			{
				return tsUiNavigationBehaviorListener;
			}
		}
		return this.FindLoopOrDynListener(groupConfig);
	}

	// Token: 0x06018083 RID: 98435 RVA: 0x0061C214 File Offset: 0x0061A414
	[return: Nullable(2)]
	public TsUiNavigationBehaviorListener FindLoopOrDynListener(NavigationGroup groupConfig)
	{
		TsUiNavigationBehaviorListener defaultListener = groupConfig.DefaultListener;
		if (defaultListener != null)
		{
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = this.FindLoopOrLayoutListenerWithDefault(groupConfig, defaultListener);
			if (tsUiNavigationBehaviorListener != null)
			{
				return tsUiNavigationBehaviorListener;
			}
		}
		return this.FindLoopOrLayoutListener(groupConfig);
	}

	// Token: 0x06018084 RID: 98436 RVA: 0x0061C240 File Offset: 0x0061A440
	[return: Nullable(2)]
	private TsUiNavigationBehaviorListener FindDynListenerWithoutDefault(NavigationGroup groupConfig, TsUiNavigationBehaviorListener defaultListener)
	{
		TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = null;
		UiNavigationScrollProxy scrollProxy = defaultListener.ScrollProxy;
		TArray<TWeakObjectPtr<AUIBaseActor>> displayItemArray = (((scrollProxy != null) ? scrollProxy.ScrollView : null) as UUIDynScrollViewComponent).DisplayItemArray;
		int i = 0;
		int num = displayItemArray.Num();
		while (i < num)
		{
			TWeakObjectPtr<AUIBaseActor> weak = displayItemArray.Get(i);
			List<TsUiNavigationBehaviorListener> dynListenerListInGroup = this.GetDynListenerListInGroup(weak, groupConfig);
			if (dynListenerListInGroup.Count != 0)
			{
				int j = 0;
				int count = dynListenerListInGroup.Count;
				while (j < count)
				{
					TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener2 = dynListenerListInGroup[j];
					if (tsUiNavigationBehaviorListener == null && tsUiNavigationBehaviorListener2.IsCanFocus())
					{
						tsUiNavigationBehaviorListener = tsUiNavigationBehaviorListener2;
					}
					if (tsUiNavigationBehaviorListener2.IsInDynScrollDisplay() && tsUiNavigationBehaviorListener2.IsInScrollOrLayoutCanFocus())
					{
						return tsUiNavigationBehaviorListener2;
					}
					j++;
				}
			}
			i++;
		}
		return tsUiNavigationBehaviorListener;
	}

	// Token: 0x06018085 RID: 98437 RVA: 0x0061C2EC File Offset: 0x0061A4EC
	[return: Nullable(2)]
	private TsUiNavigationBehaviorListener FindMultiTemplateScrollListenerWithoutDefault(NavigationGroup groupConfig, TsUiNavigationBehaviorListener defaultListener)
	{
		TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = null;
		AActor scrollOrLayoutActor = defaultListener.GetScrollOrLayoutActor();
		List<TsUiNavigationBehaviorListener> multiTemplateScrollSortListenerList = groupConfig.MultiTemplateScrollSortListenerList;
		int i = 0;
		int count = multiTemplateScrollSortListenerList.Count;
		while (i < count)
		{
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener2 = multiTemplateScrollSortListenerList[i];
			if (tsUiNavigationBehaviorListener == null && tsUiNavigationBehaviorListener2.IsCanFocus())
			{
				tsUiNavigationBehaviorListener = tsUiNavigationBehaviorListener2;
			}
			if (tsUiNavigationBehaviorListener2.IsInScrollDisplayByGridActor() && (scrollOrLayoutActor == null || tsUiNavigationBehaviorListener2.GetScrollOrLayoutActor() == scrollOrLayoutActor) && tsUiNavigationBehaviorListener2.IsInScrollOrLayoutCanFocus())
			{
				return tsUiNavigationBehaviorListener2;
			}
			i++;
		}
		return tsUiNavigationBehaviorListener;
	}

	// Token: 0x06018086 RID: 98438 RVA: 0x0061C359 File Offset: 0x0061A559
	[return: Nullable(2)]
	private TsUiNavigationBehaviorListener FindLoopOrLayoutListenerWithoutDefault(NavigationGroup groupConfig, TsUiNavigationBehaviorListener listener)
	{
		if (listener.HasDynamicScrollView())
		{
			return this.FindDynListenerWithoutDefault(groupConfig, listener);
		}
		if (listener.HasMultiTemplateScrollView())
		{
			return this.FindMultiTemplateScrollListenerWithoutDefault(groupConfig, listener);
		}
		if (listener.IsInScrollOrLayoutCanFocus())
		{
			return listener;
		}
		return null;
	}

	// Token: 0x06018087 RID: 98439 RVA: 0x0061C388 File Offset: 0x0061A588
	[return: Nullable(2)]
	private TsUiNavigationBehaviorListener FindLoopOrLayoutListener(NavigationGroup groupConfig)
	{
		TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = null;
		int i = 0;
		int count = groupConfig.ListenerList.Count;
		while (i < count)
		{
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener2 = groupConfig.ListenerList[i];
			if (tsUiNavigationBehaviorListener == null && tsUiNavigationBehaviorListener2.IsCanFocus())
			{
				tsUiNavigationBehaviorListener = tsUiNavigationBehaviorListener2;
			}
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener3 = this.FindLoopOrLayoutListenerWithoutDefault(groupConfig, tsUiNavigationBehaviorListener2);
			if (tsUiNavigationBehaviorListener3 != null)
			{
				return tsUiNavigationBehaviorListener3;
			}
			i++;
		}
		return tsUiNavigationBehaviorListener;
	}

	// Token: 0x06018088 RID: 98440 RVA: 0x0061C3DB File Offset: 0x0061A5DB
	[return: Nullable(2)]
	private TsUiNavigationBehaviorListener FindLoopOrLayoutListenerWithDefault(NavigationGroup groupConfig, TsUiNavigationBehaviorListener defaultListener)
	{
		if (defaultListener.HasDynamicScrollView())
		{
			return this.FindDynListenerWithDefault(groupConfig, defaultListener);
		}
		if (defaultListener.HasMultiTemplateScrollView())
		{
			return this.FindMultiTemplateScrollListenerWithDefault(groupConfig, defaultListener);
		}
		return this.FindLoopListenerWithDefault(groupConfig, defaultListener);
	}

	// Token: 0x06018089 RID: 98441 RVA: 0x0061C408 File Offset: 0x0061A608
	private List<TsUiNavigationBehaviorListener> GetDynListenerListInGroup(AUIBaseActor baseActor, NavigationGroup groupConfig)
	{
		TArray<UActorComponent> componentsInChildren = ULGUIBPLibrary.GetComponentsInChildren(baseActor, TsUiNavigationBehaviorListener.StaticClass(), true);
		List<TsUiNavigationBehaviorListener> list = new List<TsUiNavigationBehaviorListener>();
		for (int i = componentsInChildren.Num() - 1; i >= 0; i--)
		{
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = componentsInChildren.Get(i) as TsUiNavigationBehaviorListener;
			if (tsUiNavigationBehaviorListener.GroupName == groupConfig.GroupName && tsUiNavigationBehaviorListener.IsCanFocus())
			{
				list.Add(tsUiNavigationBehaviorListener);
			}
		}
		return list;
	}

	// Token: 0x0601808A RID: 98442 RVA: 0x0061C470 File Offset: 0x0061A670
	[return: Nullable(2)]
	private TsUiNavigationBehaviorListener FindDynListenerWithDefault(NavigationGroup groupConfig, TsUiNavigationBehaviorListener defaultListener)
	{
		TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = null;
		UiNavigationScrollProxy scrollProxy = defaultListener.ScrollProxy;
		TArray<TWeakObjectPtr<AUIBaseActor>> displayItemArray = (((scrollProxy != null) ? scrollProxy.ScrollView : null) as UUIDynScrollViewComponent).DisplayItemArray;
		int i = 0;
		int num = displayItemArray.Num();
		while (i < num)
		{
			List<TsUiNavigationBehaviorListener> dynListenerListInGroup = this.GetDynListenerListInGroup(displayItemArray.Get(i).Get(), groupConfig);
			if (dynListenerListInGroup.Count != 0)
			{
				int j = 0;
				int count = dynListenerListInGroup.Count;
				while (j < count)
				{
					TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener2 = dynListenerListInGroup[j];
					if (tsUiNavigationBehaviorListener2.IsInDynScrollDisplay() && tsUiNavigationBehaviorListener2.IsScrollOrLayoutActor())
					{
						if (tsUiNavigationBehaviorListener == null && tsUiNavigationBehaviorListener2.IsCanFocus())
						{
							tsUiNavigationBehaviorListener = tsUiNavigationBehaviorListener2;
						}
						if (tsUiNavigationBehaviorListener2.IsInScrollOrLayoutCanFocus())
						{
							return tsUiNavigationBehaviorListener2;
						}
					}
					j++;
				}
			}
			i++;
		}
		return tsUiNavigationBehaviorListener;
	}

	// Token: 0x0601808B RID: 98443 RVA: 0x0061C524 File Offset: 0x0061A724
	[return: Nullable(2)]
	private TsUiNavigationBehaviorListener FindLoopListenerWithDefault(NavigationGroup groupConfig, TsUiNavigationBehaviorListener defaultListener)
	{
		TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = null;
		AActor scrollOrLayoutActor = defaultListener.GetScrollOrLayoutActor();
		List<TsUiNavigationBehaviorListener> loopScrollSortListenerList = groupConfig.LoopScrollSortListenerList;
		int i = 0;
		int count = loopScrollSortListenerList.Count;
		while (i < count)
		{
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener2 = loopScrollSortListenerList[i];
			if (tsUiNavigationBehaviorListener2.IsScrollOrLayoutActor() && tsUiNavigationBehaviorListener2.IsInNormalScrollDisplayByGridActor() && tsUiNavigationBehaviorListener2.IsInLoopScrollDisplayByGridActor())
			{
				if (tsUiNavigationBehaviorListener == null && tsUiNavigationBehaviorListener2.IsCanFocus())
				{
					tsUiNavigationBehaviorListener = tsUiNavigationBehaviorListener2;
				}
				if ((scrollOrLayoutActor == null || tsUiNavigationBehaviorListener2.GetScrollOrLayoutActor() == scrollOrLayoutActor) && tsUiNavigationBehaviorListener2.IsInScrollOrLayoutCanFocus())
				{
					return tsUiNavigationBehaviorListener2;
				}
			}
			i++;
		}
		return tsUiNavigationBehaviorListener;
	}

	// Token: 0x0601808C RID: 98444 RVA: 0x0061C5A4 File Offset: 0x0061A7A4
	[return: Nullable(2)]
	private TsUiNavigationBehaviorListener FindMultiTemplateScrollListenerWithDefault(NavigationGroup groupConfig, TsUiNavigationBehaviorListener defaultListener)
	{
		TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = null;
		AActor scrollOrLayoutActor = defaultListener.GetScrollOrLayoutActor();
		List<TsUiNavigationBehaviorListener> multiTemplateScrollSortListenerList = groupConfig.MultiTemplateScrollSortListenerList;
		int i = 0;
		int count = multiTemplateScrollSortListenerList.Count;
		while (i < count)
		{
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener2 = multiTemplateScrollSortListenerList[i];
			if (tsUiNavigationBehaviorListener2.IsScrollOrLayoutActor() && tsUiNavigationBehaviorListener2.IsInScrollDisplayByGridActor())
			{
				if (tsUiNavigationBehaviorListener == null && tsUiNavigationBehaviorListener2.IsCanFocus())
				{
					tsUiNavigationBehaviorListener = tsUiNavigationBehaviorListener2;
				}
				if ((scrollOrLayoutActor == null || tsUiNavigationBehaviorListener2.GetScrollOrLayoutActor() == scrollOrLayoutActor) && tsUiNavigationBehaviorListener2.IsInScrollOrLayoutCanFocus())
				{
					return tsUiNavigationBehaviorListener2;
				}
			}
			i++;
		}
		return tsUiNavigationBehaviorListener;
	}

	// Token: 0x0601808D RID: 98445 RVA: 0x0061C61C File Offset: 0x0061A81C
	[return: Nullable(2)]
	public TsUiNavigationBehaviorListener FindSuitableListenerWithoutLayout(NavigationGroup groupConfig)
	{
		TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = null;
		int i = 0;
		int count = groupConfig.ListenerList.Count;
		while (i < count)
		{
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener2 = groupConfig.ListenerList[i];
			if (tsUiNavigationBehaviorListener == null && tsUiNavigationBehaviorListener2.IsCanFocus())
			{
				tsUiNavigationBehaviorListener = tsUiNavigationBehaviorListener2;
			}
			if (tsUiNavigationBehaviorListener2.IsInScrollOrLayoutCanFocus())
			{
				return tsUiNavigationBehaviorListener2;
			}
			i++;
		}
		return tsUiNavigationBehaviorListener;
	}

	// Token: 0x0601808E RID: 98446 RVA: 0x0061C668 File Offset: 0x0061A868
	[return: Nullable(2)]
	public TsUiNavigationBehaviorListener GetCanFocusInsideListener(TsUiNavigationBehaviorListener listener)
	{
		HashSet<string> insideGroupNameSet = listener.GetNavigationGroup().InsideGroupNameSet;
		TArray<UActorComponent> componentsInChildrenWithHirerarchyIndex = ULGUIBPLibrary.GetComponentsInChildrenWithHirerarchyIndex(listener.InsideGroupActor as AUIBaseActor, TsUiNavigationBehaviorListener.StaticClass(), true);
		if (componentsInChildrenWithHirerarchyIndex == null)
		{
			return null;
		}
		int i = 0;
		int num = componentsInChildrenWithHirerarchyIndex.Num();
		while (i < num)
		{
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = componentsInChildrenWithHirerarchyIndex.Get(i) as TsUiNavigationBehaviorListener;
			if (!StringUtils.IsEmpty(tsUiNavigationBehaviorListener.GroupName) && insideGroupNameSet.Contains(tsUiNavigationBehaviorListener.GroupName) && tsUiNavigationBehaviorListener.IsCanFocus())
			{
				return tsUiNavigationBehaviorListener;
			}
			i++;
		}
		return null;
	}

	// Token: 0x0601808F RID: 98447 RVA: 0x0061C6F0 File Offset: 0x0061A8F0
	public List<TsUiNavigationBehaviorListener> GetCanFocusInsideListenerList(TsUiNavigationBehaviorListener listener)
	{
		HashSet<string> insideGroupNameSet = listener.GetNavigationGroup().InsideGroupNameSet;
		TArray<UActorComponent> componentsInChildrenWithHirerarchyIndex = ULGUIBPLibrary.GetComponentsInChildrenWithHirerarchyIndex(listener.InsideGroupActor as AUIBaseActor, TsUiNavigationBehaviorListener.StaticClass(), true);
		if (componentsInChildrenWithHirerarchyIndex == null)
		{
			return new List<TsUiNavigationBehaviorListener>();
		}
		List<TsUiNavigationBehaviorListener> list = new List<TsUiNavigationBehaviorListener>();
		int i = 0;
		int num = componentsInChildrenWithHirerarchyIndex.Num();
		while (i < num)
		{
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = componentsInChildrenWithHirerarchyIndex.Get(i) as TsUiNavigationBehaviorListener;
			if (!StringUtils.IsEmpty(tsUiNavigationBehaviorListener.GroupName) && insideGroupNameSet.Contains(tsUiNavigationBehaviorListener.GroupName) && tsUiNavigationBehaviorListener.IsCanFocus())
			{
				list.Add(tsUiNavigationBehaviorListener);
			}
			i++;
		}
		return list;
	}

	// Token: 0x06018090 RID: 98448 RVA: 0x0061C788 File Offset: 0x0061A988
	public bool IsInFocusInsideListenerList(TsUiNavigationBehaviorListener parent, TsUiNavigationBehaviorListener target)
	{
		if (StringUtils.IsEmpty(target.GroupName))
		{
			return false;
		}
		HashSet<string> insideGroupNameSet = parent.GetNavigationGroup().InsideGroupNameSet;
		TArray<UActorComponent> componentsInChildren = ULGUIBPLibrary.GetComponentsInChildren(parent.InsideGroupActor, TsUiNavigationBehaviorListener.StaticClass(), true);
		return componentsInChildren != null && insideGroupNameSet.Contains(target.GroupName) && componentsInChildren.Contains(target);
	}

	// Token: 0x06018091 RID: 98449 RVA: 0x0061C7E4 File Offset: 0x0061A9E4
	public void JumpInsideNavigationGroup()
	{
		NavigationGroup currentNavigationListenerGroup = this.GetCurrentNavigationListenerGroup();
		if (currentNavigationListenerGroup == null)
		{
			return;
		}
		TsUiNavigationBehaviorListener currentNavigationFocusListener = this.GetCurrentNavigationFocusListener();
		TsUiNavigationBehaviorListener canFocusInsideListener = this.GetCanFocusInsideListener(currentNavigationFocusListener);
		if (canFocusInsideListener == null)
		{
			List<string> list = new List<string>();
			foreach (string item in currentNavigationListenerGroup.InsideGroupNameSet)
			{
				list.Add(item);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiNavigation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[JumpInsideNavigationGroup]查找不到内部有可导航对象";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("InsideGroupName", list.ToArray());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.SwitchNavigationFocus(canFocusInsideListener);
	}

	// Token: 0x06018092 RID: 98450 RVA: 0x0061C898 File Offset: 0x0061AA98
	public void SimulationPointUp(string tag, int configId, Vector2D pivot = null)
	{
		pivot = (pivot ?? this.DefaultPivot);
		TsUiNavigationBehaviorListener currentNavigationActiveListenerByTag = this.GetCurrentNavigationActiveListenerByTag(tag, true);
		if (currentNavigationActiveListenerByTag == null)
		{
			TsLguiEventSystemActor lguiEventSystemActor = LguiEventSystemManager.Instance.LguiEventSystemActor;
			if (lguiEventSystemActor != null)
			{
				List<int> list = UiNavigationInputEventData.TryClearUnValidData();
				int i = 0;
				int count = list.Count;
				while (i < count)
				{
					int pointerId = list[i];
					lguiEventSystemActor.ResetNowIsTriggerPressed(pointerId);
					i++;
				}
			}
			return;
		}
		this.PointDownUpInternal(currentNavigationActiveListenerByTag, false, configId, pivot);
	}

	// Token: 0x06018093 RID: 98451 RVA: 0x0061C904 File Offset: 0x0061AB04
	public void SimulationPointUpInside(string tag, int configId, [Nullable(2)] TsUiNavigationBehaviorListener listener)
	{
		if (listener != null)
		{
			this.PointDownUpInternal(listener, false, configId, this.DefaultPivot);
			return;
		}
		TsUiNavigationBehaviorListener currentNavigationFocusListener = this.GetCurrentNavigationFocusListener();
		if (currentNavigationFocusListener == null)
		{
			return;
		}
		TsUiNavigationBehaviorListener childListenerByTag = currentNavigationFocusListener.GetChildListenerByTag(tag);
		if (childListenerByTag == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiNavigation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[SimulationPointUpInside]查找不到对应的热键按钮";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Tag", tag);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.PointDownUpInternal(childListenerByTag, false, configId, this.DefaultPivot);
	}

	// Token: 0x06018094 RID: 98452 RVA: 0x0061C978 File Offset: 0x0061AB78
	private bool PointDownUpInternal(TsUiNavigationBehaviorListener listener, bool isPress, int configId, Vector2D pivot)
	{
		if (isPress && this.InMaskState())
		{
			return false;
		}
		TsLguiEventSystemActor lguiEventSystemActor = LguiEventSystemManager.Instance.LguiEventSystemActor;
		if (lguiEventSystemActor == null)
		{
			return false;
		}
		if (isPress)
		{
			int pointerId = UiNavigationInputEventData.CreateInputEventData(configId, listener);
			return lguiEventSystemActor.SimulationPointerDownUp(pointerId, listener.RootUIComp, true, pivot.ToUeVector2D(false));
		}
		int pointerId2 = UiNavigationInputEventData.RecycleInputEventData(configId, listener);
		return lguiEventSystemActor.SimulationPointerDownUp(pointerId2, listener.RootUIComp, false, pivot.ToUeVector2D(false));
	}

	// Token: 0x06018095 RID: 98453 RVA: 0x0061C9EC File Offset: 0x0061ABEC
	[NullableContext(2)]
	public bool GamepadInteractSimulationPointer(ULGUIBehaviour selectableComponent, bool isPress)
	{
		if (selectableComponent == null)
		{
			return false;
		}
		TsLguiEventSystemActor lguiEventSystemActor = LguiEventSystemManager.Instance.LguiEventSystemActor;
		return lguiEventSystemActor != null && lguiEventSystemActor.SimulationPointerDownUp(0, selectableComponent.RootUIComp, isPress, this.DefaultPivot.ToUeVector2D(false));
	}

	// Token: 0x06018096 RID: 98454 RVA: 0x0061CA30 File Offset: 0x0061AC30
	public void SimulationPointDown(string tag, int configId, Vector2D pivot = null)
	{
		pivot = (pivot ?? this.DefaultPivot);
		TsUiNavigationBehaviorListener currentNavigationActiveListenerByTag = this.GetCurrentNavigationActiveListenerByTag(tag, true);
		if (currentNavigationActiveListenerByTag == null)
		{
			return;
		}
		this.PointDownUpInternal(currentNavigationActiveListenerByTag, true, configId, pivot);
	}

	// Token: 0x06018097 RID: 98455 RVA: 0x0061CA64 File Offset: 0x0061AC64
	[return: Nullable(2)]
	public TsUiNavigationBehaviorListener SimulationPointDownInside(string tag, int configId)
	{
		TsUiNavigationBehaviorListener currentNavigationFocusListener = this.GetCurrentNavigationFocusListener();
		if (currentNavigationFocusListener == null)
		{
			return null;
		}
		TsUiNavigationBehaviorListener childListenerByTag = currentNavigationFocusListener.GetChildListenerByTag(tag);
		if (childListenerByTag == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiNavigation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[SimulationPointDownInside]查找不到对应的热键按钮";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Tag", tag);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		this.PointDownUpInternal(childListenerByTag, true, configId, this.DefaultPivot);
		return childListenerByTag;
	}

	// Token: 0x06018098 RID: 98456 RVA: 0x0061CAC8 File Offset: 0x0061ACC8
	public void FindTarget(ELGUINavigationDirection direction)
	{
		TsUiNavigationBehaviorListener currentNavigationFocusListener = this.GetCurrentNavigationFocusListener();
		if (currentNavigationFocusListener == null)
		{
			return;
		}
		UUISelectableComponent selectableComponent = currentNavigationFocusListener.GetSelectableComponent();
		USceneComponent usceneComponent = UiNavigationLogic.TryFindNavigationDelegate(direction, selectableComponent);
		if (usceneComponent == selectableComponent.RootUIComp.Get())
		{
			return;
		}
		TsUiNavigationBehaviorListener listener = usceneComponent.GetOwner().GetComponentByClass(TsUiNavigationBehaviorListener.StaticClass()) as TsUiNavigationBehaviorListener;
		this.NavigateScrollTo(listener);
	}

	// Token: 0x06018099 RID: 98457 RVA: 0x0061CB24 File Offset: 0x0061AD24
	public void SliderComponentSetValue(string tag, float value)
	{
		TsUiNavigationBehaviorListener currentNavigationActiveListenerByTag = this.GetCurrentNavigationActiveListenerByTag(tag, false);
		if (currentNavigationActiveListenerByTag == null)
		{
			return;
		}
		this.HandleSliderComponentValue(currentNavigationActiveListenerByTag.GetSelectableComponent(), value);
	}

	// Token: 0x0601809A RID: 98458 RVA: 0x0061CB4C File Offset: 0x0061AD4C
	public void SliderInsideComponentSetValue(string tag, float value)
	{
		TsUiNavigationBehaviorListener currentNavigationFocusListener = this.GetCurrentNavigationFocusListener();
		if (currentNavigationFocusListener == null)
		{
			return;
		}
		TsUiNavigationBehaviorListener focusListenerInsideListenerByTag = this.GetFocusListenerInsideListenerByTag(currentNavigationFocusListener, tag);
		if (focusListenerInsideListenerByTag == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiNavigation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[SliderInsideComponentSetValue]查找不到对应的热键按钮";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Tag", tag);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.HandleSliderComponentValue(focusListenerInsideListenerByTag.GetSelectableComponent(), value);
	}

	// Token: 0x0601809B RID: 98459 RVA: 0x0061CBA8 File Offset: 0x0061ADA8
	public void ScrollbarInsideComponentSetValue(string tag, float value)
	{
		TsUiNavigationBehaviorListener currentNavigationFocusListener = this.GetCurrentNavigationFocusListener();
		if (currentNavigationFocusListener == null)
		{
			return;
		}
		TsUiNavigationBehaviorListener focusListenerInsideListenerByTag = this.GetFocusListenerInsideListenerByTag(currentNavigationFocusListener, tag);
		if (focusListenerInsideListenerByTag == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiNavigation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[ScrollbarInsideComponentSetValue]查找不到对应的热键按钮";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Tag", tag);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.HandleScrollbarComponentSetValue(focusListenerInsideListenerByTag.GetBehaviorComponent(), value);
	}

	// Token: 0x0601809C RID: 98460 RVA: 0x0061CC04 File Offset: 0x0061AE04
	private void HandleScrollbarComponentSetValue(ULGUIBehaviour behavior, float value)
	{
		UUIScrollViewComponent uuiscrollViewComponent = behavior as UUIScrollViewComponent;
		if (uuiscrollViewComponent != null)
		{
			if (uuiscrollViewComponent.Vertical)
			{
				uuiscrollViewComponent.SetVelocity(value * 800f);
				return;
			}
			uuiscrollViewComponent.SetVelocity(-value * 800f);
		}
	}

	// Token: 0x0601809D RID: 98461 RVA: 0x0061CC40 File Offset: 0x0061AE40
	private void HandleVerticalScrollbarComponentSetValue(ULGUIBehaviour behavior, float value)
	{
		UUIScrollViewComponent uuiscrollViewComponent = behavior as UUIScrollViewComponent;
		if (uuiscrollViewComponent != null)
		{
			uuiscrollViewComponent.SetVerticalVelocity(value * 800f);
		}
	}

	// Token: 0x0601809E RID: 98462 RVA: 0x0061CC64 File Offset: 0x0061AE64
	private void HandleHorizontalScrollbarComponentSetValue(ULGUIBehaviour behavior, float value)
	{
		UUIScrollViewComponent uuiscrollViewComponent = behavior as UUIScrollViewComponent;
		if (uuiscrollViewComponent != null)
		{
			uuiscrollViewComponent.SetHorizontalVelocity(value * 800f);
		}
	}

	// Token: 0x0601809F RID: 98463 RVA: 0x0061CC88 File Offset: 0x0061AE88
	private void HandleSliderComponentValue(UUISelectableComponent selectableComponent, float value)
	{
		UUISliderComponent uuisliderComponent = selectableComponent as UUISliderComponent;
		if (uuisliderComponent != null)
		{
			float value2 = uuisliderComponent.Value;
			uuisliderComponent.SetProgressIncrement(value, uuisliderComponent.WholeNumbers, true);
			if (value2 == uuisliderComponent.Value)
			{
				if (value > 0f && value2 != uuisliderComponent.MaxValue)
				{
					uuisliderComponent.SetValueWithAudio(value2 + 1f, true);
					return;
				}
				if (value < 0f && value2 != uuisliderComponent.MinValue)
				{
					uuisliderComponent.SetValueWithAudio(value2 - 1f, true);
				}
			}
		}
	}

	// Token: 0x060180A0 RID: 98464 RVA: 0x0061CCFC File Offset: 0x0061AEFC
	public void DraggableComponentNavigate(string tag, bool toNext)
	{
		TsUiNavigationBehaviorListener currentNavigationActiveListenerByTag = this.GetCurrentNavigationActiveListenerByTag(tag, false);
		if (currentNavigationActiveListenerByTag == null)
		{
			return;
		}
		this.HandleDraggableComponentNavigate(currentNavigationActiveListenerByTag.GetBehaviorComponent(), toNext);
	}

	// Token: 0x060180A1 RID: 98465 RVA: 0x0061CD24 File Offset: 0x0061AF24
	public void DraggableInsideComponentNavigate(string tag, bool toNext)
	{
		TsUiNavigationBehaviorListener currentNavigationFocusListener = this.GetCurrentNavigationFocusListener();
		if (currentNavigationFocusListener == null)
		{
			return;
		}
		TsUiNavigationBehaviorListener focusListenerInsideListenerByTag = this.GetFocusListenerInsideListenerByTag(currentNavigationFocusListener, tag);
		if (focusListenerInsideListenerByTag == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiNavigation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[ScrollbarInsideComponentSetValue]查找不到对应的热键按钮";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Tag", tag);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.HandleDraggableComponentNavigate(focusListenerInsideListenerByTag.GetBehaviorComponent(), toNext);
	}

	// Token: 0x060180A2 RID: 98466 RVA: 0x0061CD80 File Offset: 0x0061AF80
	private void HandleDraggableComponentNavigate(ULGUIBehaviour behavior, bool toNext)
	{
		UUIDraggableComponent uuidraggableComponent = behavior as UUIDraggableComponent;
		if (uuidraggableComponent != null)
		{
			if (!toNext)
			{
				uuidraggableComponent.NotifyNavigateToPrev();
				return;
			}
			uuidraggableComponent.NotifyNavigateToNext();
		}
	}

	// Token: 0x060180A3 RID: 98467 RVA: 0x0061CDA8 File Offset: 0x0061AFA8
	[NullableContext(2)]
	public void SwitchNavigationFocus(TsUiNavigationBehaviorListener listener)
	{
		UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
		if (currentViewHandle == null || currentViewHandle.HasGamepadControlMouse())
		{
			return;
		}
		if (LguiEventSystemManager.Instance.LguiEventSystem.navigationComponent == null && this.GetCurrentNavigationFocusListener() == null && listener == null)
		{
			return;
		}
		UiNavigationGlobalData.IsAllowCrossNavigationGroup = true;
		if (LguiEventSystemManager.Instance.LguiEventSystem.navigationComponent == null)
		{
			ULGUIPointerEventData pointerEventData = LguiEventSystemManager.Instance.GetPointerEventData(0, false);
			ULGUIEventSystem lguiEventSystem = LguiEventSystemManager.Instance.LguiEventSystem;
			if (lguiEventSystem != null)
			{
				lguiEventSystem.SetSelectComponent(null, pointerEventData, ELGUIEventFireType.TargetActorAndAllItsComponents);
			}
		}
		TsLguiEventSystemActor lguiEventSystemActor = LguiEventSystemManager.Instance.LguiEventSystemActor;
		USceneComponent component = (listener != null) ? listener.GetSceneComponent() : null;
		if (lguiEventSystemActor != null)
		{
			lguiEventSystemActor.UpdateNavigationListener(component);
		}
		if (listener == null)
		{
			UiNavigationViewManager.Instance.GetCurrentViewHandle().UpdateFocus(null);
		}
		UiNavigationGlobalData.IsAllowCrossNavigationGroup = false;
	}

	// Token: 0x060180A4 RID: 98468 RVA: 0x0061CE64 File Offset: 0x0061B064
	[NullableContext(2)]
	public bool SwitchNavigationFocusWithDirtyCheck(TsUiNavigationBehaviorListener listener)
	{
		UiNavigationViewHandle uiNavigationViewHandle;
		if (listener == null)
		{
			uiNavigationViewHandle = null;
		}
		else
		{
			TsUiNavigationPanelConfig panelConfig = listener.PanelConfig;
			uiNavigationViewHandle = ((panelConfig != null) ? panelConfig.ViewHandle : null);
		}
		UiNavigationViewHandle uiNavigationViewHandle2 = uiNavigationViewHandle;
		if (uiNavigationViewHandle2 == null)
		{
			Log.Instance.Info(ELogModule.UiNavigation, ELogAuthor.XXJ, "[SwitchNavigationFocusWithDirtyCheck]查找不到当前的导航句柄", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		if (uiNavigationViewHandle2 != null)
		{
			uiNavigationViewHandle2.MarkSwitchNavigationFocusDirty(listener);
		}
		return true;
	}

	// Token: 0x060180A5 RID: 98469 RVA: 0x0061CEBC File Offset: 0x0061B0BC
	public bool SetNavigationFocusForView(UUIItem uiItem, bool checkDirty = false, bool waitListenerActive = false, bool suppressDefaultFind = false)
	{
		if (Info.Instance.IsInTouch())
		{
			return false;
		}
		if (waitListenerActive)
		{
			UiNavigationViewManager.Instance.SetNavigationFocusForView(uiItem, checkDirty, suppressDefaultFind);
			return true;
		}
		if (uiItem == null || !uiItem.IsValid())
		{
			return false;
		}
		object obj;
		if (uiItem == null)
		{
			obj = null;
		}
		else
		{
			AActor owner = uiItem.GetOwner();
			obj = ((owner != null) ? owner.GetComponentByClass(TsUiNavigationBehaviorListener.StaticClass()) : null);
		}
		TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = obj as TsUiNavigationBehaviorListener;
		if (tsUiNavigationBehaviorListener == null)
		{
			return false;
		}
		if (StringUtils.IsBlank(tsUiNavigationBehaviorListener.GroupName))
		{
			return false;
		}
		NavigationGroup navigationGroup = tsUiNavigationBehaviorListener.GetNavigationGroup();
		if (navigationGroup == null || navigationGroup.GroupType == 2)
		{
			return false;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.UiNavigation;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "业务设置了导航对象";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("名字", uiItem.displayName);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (checkDirty)
		{
			return this.SwitchNavigationFocusWithDirtyCheck(tsUiNavigationBehaviorListener);
		}
		this.SwitchNavigationFocus(tsUiNavigationBehaviorListener);
		return true;
	}

	// Token: 0x060180A6 RID: 98470 RVA: 0x0061CF94 File Offset: 0x0061B194
	public void SetNavigationFocusForViewByRootItem(UUIItem uiItem, string targetGroupName, bool checkDirty = false)
	{
		if (Info.Instance.IsInGamepad())
		{
			if (!uiItem.IsValid())
			{
				return;
			}
			TArray<UActorComponent> componentsInChildren = ULGUIBPLibrary.GetComponentsInChildren(uiItem.GetOwner(), TsUiNavigationBehaviorListener.StaticClass(), true);
			if (componentsInChildren.Num() == 0)
			{
				return;
			}
			int i = 0;
			int num = componentsInChildren.Num();
			while (i < num)
			{
				TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = componentsInChildren.Get(i) as TsUiNavigationBehaviorListener;
				if (!StringUtils.IsBlank(tsUiNavigationBehaviorListener.GroupName) && !(tsUiNavigationBehaviorListener.GroupName != targetGroupName))
				{
					NavigationGroup navigationGroup = tsUiNavigationBehaviorListener.GetNavigationGroup();
					if (navigationGroup != null && navigationGroup.GroupType != 2)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.UiNavigation;
						ELogAuthor author = ELogAuthor.XXJ;
						string message = "业务设置了导航对象";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("名字", uiItem.displayName);
						instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						if (checkDirty)
						{
							this.SwitchNavigationFocusWithDirtyCheck(tsUiNavigationBehaviorListener);
							return;
						}
						this.SwitchNavigationFocus(tsUiNavigationBehaviorListener);
						return;
					}
				}
				i++;
			}
		}
	}

	// Token: 0x060180A7 RID: 98471 RVA: 0x0061D07C File Offset: 0x0061B27C
	public void ResetNavigationFocusForViewWithDirtyCheck()
	{
		if (!Info.Instance.IsInTouch())
		{
			Log.Instance.Info(ELogModule.UiNavigation, ELogAuthor.XXJ, "业务重置了导航对象", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.SwitchNavigationFocus(null);
		}
	}

	// Token: 0x060180A8 RID: 98472 RVA: 0x0061D0BC File Offset: 0x0061B2BC
	public void SetNavigationFocusForViewSameGroup(UUIItem uiItem)
	{
		if (Info.Instance.IsInGamepad())
		{
			if (uiItem == null || !uiItem.IsValid())
			{
				return;
			}
			object obj;
			if (uiItem == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = uiItem.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(TsUiNavigationBehaviorListener.StaticClass()) : null);
			}
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = obj as TsUiNavigationBehaviorListener;
			if (tsUiNavigationBehaviorListener == null)
			{
				return;
			}
			if (StringUtils.IsBlank(tsUiNavigationBehaviorListener.GroupName))
			{
				return;
			}
			NavigationGroup navigationGroup = tsUiNavigationBehaviorListener.GetNavigationGroup();
			if (navigationGroup == null || navigationGroup.GroupType == 2)
			{
				return;
			}
			TsUiNavigationBehaviorListener currentNavigationFocusListener = this.GetCurrentNavigationFocusListener();
			if (currentNavigationFocusListener != null && currentNavigationFocusListener.GroupName != tsUiNavigationBehaviorListener.GroupName)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiNavigation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "业务设置了导航对象";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("名字", uiItem.displayName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.SwitchNavigationFocus(tsUiNavigationBehaviorListener);
		}
	}

	// Token: 0x060180A9 RID: 98473 RVA: 0x0061D18C File Offset: 0x0061B38C
	private void SetNavigationMousePositionForGuide(UUIItem uiItem)
	{
		UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
		if (currentViewHandle == null)
		{
			return;
		}
		if (currentViewHandle.HasGamepadControlMouse())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiNavigation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "引导设置了光标位置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("名字", uiItem.displayName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			currentViewHandle.UpdateMousePositionForGuide(uiItem);
		}
	}

	// Token: 0x060180AA RID: 98474 RVA: 0x0061D1E8 File Offset: 0x0061B3E8
	public void RefreshNavigationMousePositionForGuide(UUIItem uiItem)
	{
		if (!Info.Instance.IsInGamepad())
		{
			return;
		}
		if (uiItem == null || !uiItem.IsValid())
		{
			return;
		}
		UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
		if (currentViewHandle == null)
		{
			return;
		}
		if (currentViewHandle.HasGamepadControlMouse())
		{
			currentViewHandle.UpdateMousePositionByItem(uiItem);
		}
	}

	// Token: 0x060180AB RID: 98475 RVA: 0x0061D234 File Offset: 0x0061B434
	public void SetNavigationFocusForGuide(UUIItem uiItem)
	{
		if (Info.Instance.IsInGamepad())
		{
			if (uiItem == null || !uiItem.IsValid())
			{
				return;
			}
			object obj;
			if (uiItem == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = uiItem.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(TsUiNavigationBehaviorListener.StaticClass()) : null);
			}
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = obj as TsUiNavigationBehaviorListener;
			if (tsUiNavigationBehaviorListener == null)
			{
				this.SetNavigationMousePositionForGuide(uiItem);
				return;
			}
			UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
			if (currentViewHandle != null && currentViewHandle.HasGamepadControlMouse())
			{
				this.SetNavigationMousePositionForGuide(uiItem);
			}
			if (StringUtils.IsBlank(tsUiNavigationBehaviorListener.GroupName))
			{
				return;
			}
			NavigationGroup navigationGroup = tsUiNavigationBehaviorListener.GetNavigationGroup();
			if (navigationGroup == null || navigationGroup.GroupType == 2)
			{
				return;
			}
			if (navigationGroup.GroupType == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiNavigation;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "引导设置了导航对象";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("名字", uiItem.displayName);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.SwitchNavigationFocus(tsUiNavigationBehaviorListener);
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.UiNavigation;
			ELogAuthor author2 = ELogAuthor.XXJ;
			string message2 = "引导设置了非导航对象";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("名字", uiItem.displayName);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			UiNavigationModel.Instance.SetGuideFocusListener(tsUiNavigationBehaviorListener);
		}
	}

	// Token: 0x060180AC RID: 98476 RVA: 0x0061D354 File Offset: 0x0061B554
	public void SetNavigationMousePositionForView(UUIItem uiItem)
	{
		if (!Info.Instance.IsInGamepad())
		{
			return;
		}
		if (uiItem == null || !uiItem.IsValid())
		{
			return;
		}
		UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
		if (currentViewHandle == null)
		{
			return;
		}
		if (currentViewHandle.HasGamepadControlMouse())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiNavigation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "业务设置了模拟光标位置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("名字", uiItem.displayName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			currentViewHandle.UpdateMousePositionByItem(uiItem);
		}
	}

	// Token: 0x060180AD RID: 98477 RVA: 0x0061D3D0 File Offset: 0x0061B5D0
	public void MarkViewHandleRefreshNavigationDirtyByItem(UUIItem uiItem)
	{
		if (!Info.Instance.IsInTouch())
		{
			if (uiItem == null || !uiItem.IsValid())
			{
				return;
			}
			object obj;
			if (uiItem == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = uiItem.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(TsUiNavigationBehaviorListener.StaticClass()) : null);
			}
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = obj as TsUiNavigationBehaviorListener;
			if (tsUiNavigationBehaviorListener == null)
			{
				return;
			}
			if (StringUtils.IsBlank(tsUiNavigationBehaviorListener.GroupName))
			{
				return;
			}
			NavigationGroup navigationGroup = tsUiNavigationBehaviorListener.GetNavigationGroup();
			if (navigationGroup == null || navigationGroup.GroupType == 2)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiNavigation;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "业务刷新界面导航对象查找";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("名字", uiItem.displayName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			TsUiNavigationPanelConfig panelConfig = tsUiNavigationBehaviorListener.PanelConfig;
			if (panelConfig == null)
			{
				return;
			}
			UiNavigationViewHandle viewHandle = panelConfig.ViewHandle;
			if (viewHandle == null)
			{
				return;
			}
			viewHandle.MarkRefreshNavigationDirty(0);
		}
	}

	// Token: 0x060180AE RID: 98478 RVA: 0x0061D496 File Offset: 0x0061B696
	[NullableContext(2)]
	public void MarkViewHandleRefreshNavigationDirtyByListener(TsUiNavigationBehaviorListener listener)
	{
		if (!Info.Instance.IsInTouch())
		{
			if (listener == null)
			{
				return;
			}
			TsUiNavigationPanelConfig panelConfig = listener.PanelConfig;
			if (panelConfig == null)
			{
				return;
			}
			UiNavigationViewHandle viewHandle = panelConfig.ViewHandle;
			if (viewHandle == null)
			{
				return;
			}
			viewHandle.MarkRefreshNavigationDirty(0);
		}
	}

	// Token: 0x060180AF RID: 98479 RVA: 0x0061D4C4 File Offset: 0x0061B6C4
	public void ResetNavigationFocusForGuide()
	{
		if (Info.Instance.IsInGamepad())
		{
			UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
			if (currentViewHandle != null)
			{
				currentViewHandle.ResetNavigationFocusForGuide();
			}
			UiNavigationModel.Instance.ResetGuideFocusListener();
		}
	}

	// Token: 0x060180B0 RID: 98480 RVA: 0x0061D4FC File Offset: 0x0061B6FC
	[return: Nullable(2)]
	public UUIItem GetNoneTagNavigateItemByUiItem(UUIItem uiItem)
	{
		TArray<UActorComponent> componentsInChildren = ULGUIBPLibrary.GetComponentsInChildren(uiItem.GetOwner(), TsUiNavigationBehaviorListener.StaticClass(), true);
		if (componentsInChildren == null)
		{
			return null;
		}
		for (int i = componentsInChildren.Num() - 1; i >= 0; i--)
		{
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = componentsInChildren.Get(i) as TsUiNavigationBehaviorListener;
			if (tsUiNavigationBehaviorListener.TagArray != null && tsUiNavigationBehaviorListener.TagArray.Num() <= 0 && tsUiNavigationBehaviorListener.IsCanFocus())
			{
				return tsUiNavigationBehaviorListener.RootUIComp;
			}
		}
		return null;
	}

	// Token: 0x060180B1 RID: 98481 RVA: 0x0061D570 File Offset: 0x0061B770
	[return: Nullable(2)]
	public TsUiNavigationBehaviorListener GetFocusListenerInsideListenerByTag(TsUiNavigationBehaviorListener listener, string tag)
	{
		AActor aactor = listener.InsideActorMap.GetValueOrDefault(tag);
		if (aactor == null)
		{
			aactor = listener.GetOwner();
		}
		TArray<UActorComponent> componentsInChildren = ULGUIBPLibrary.GetComponentsInChildren(aactor, TsUiNavigationBehaviorListener.StaticClass(), true);
		if (componentsInChildren == null)
		{
			return null;
		}
		for (int i = componentsInChildren.Num() - 1; i >= 0; i--)
		{
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = componentsInChildren.Get(i) as TsUiNavigationBehaviorListener;
			TArray<string> tagArray = tsUiNavigationBehaviorListener.TagArray;
			if (tagArray != null && tagArray.Contains(tag) && tsUiNavigationBehaviorListener.IsCanFocus())
			{
				return tsUiNavigationBehaviorListener;
			}
		}
		return null;
	}

	// Token: 0x060180B2 RID: 98482 RVA: 0x0061D5F0 File Offset: 0x0061B7F0
	public List<TsUiNavigationBehaviorListener> GetMarkBookActiveListenerList([Nullable(2)] NavigationGroup groupConfig)
	{
		if (groupConfig == null)
		{
			return new List<TsUiNavigationBehaviorListener>();
		}
		if (groupConfig.GroupType != 1)
		{
			return new List<TsUiNavigationBehaviorListener>();
		}
		List<TsUiNavigationBehaviorListener> list = new List<TsUiNavigationBehaviorListener>();
		int i = 0;
		int count = groupConfig.ListenerList.Count;
		while (i < count)
		{
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = groupConfig.ListenerList[i];
			if (tsUiNavigationBehaviorListener.IsListenerActive())
			{
				list.Add(tsUiNavigationBehaviorListener);
			}
			i++;
		}
		return list;
	}

	// Token: 0x060180B3 RID: 98483 RVA: 0x0061D650 File Offset: 0x0061B850
	public void ActiveTextInput(string tag)
	{
		TsUiNavigationBehaviorListener currentNavigationActiveListenerByTag = this.GetCurrentNavigationActiveListenerByTag(tag, false);
		if (currentNavigationActiveListenerByTag == null)
		{
			return;
		}
		(currentNavigationActiveListenerByTag.GetBehaviorComponent() as UUITextInputComponent).ActivateInputText();
	}

	// Token: 0x060180B4 RID: 98484 RVA: 0x0061D67C File Offset: 0x0061B87C
	public void ActiveTextInputInside(string tag)
	{
		TsUiNavigationBehaviorListener currentNavigationFocusListener = this.GetCurrentNavigationFocusListener();
		if (currentNavigationFocusListener == null)
		{
			return;
		}
		TsUiNavigationBehaviorListener focusListenerInsideListenerByTag = this.GetFocusListenerInsideListenerByTag(currentNavigationFocusListener, tag);
		if (focusListenerInsideListenerByTag == null)
		{
			return;
		}
		(focusListenerInsideListenerByTag.GetBehaviorComponent() as UUITextInputComponent).ActivateInputText();
	}

	// Token: 0x060180B5 RID: 98485 RVA: 0x0061D6B4 File Offset: 0x0061B8B4
	public void HandleCommonConsumeNavigation(string tag)
	{
		if (StringUtils.IsBlank(tag))
		{
			return;
		}
		NavigationGroup currentNavigationListenerGroup = this.GetCurrentNavigationListenerGroup();
		if (currentNavigationListenerGroup == null)
		{
			return;
		}
		string text = (!string.IsNullOrEmpty(tag)) ? currentNavigationListenerGroup.GroupNameMap.GetValueOrDefault(tag) : currentNavigationListenerGroup.NextGroupName;
		if (StringUtils.IsEmpty(text))
		{
			return;
		}
		UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
		NavigationGroup activeNavigationGroupByNameCheckAll = currentViewHandle.GetActiveNavigationGroupByNameCheckAll(text);
		if (activeNavigationGroupByNameCheckAll == null)
		{
			return;
		}
		if (activeNavigationGroupByNameCheckAll.ActiveListenerList.Count > 1)
		{
			if (this.ChangeFocusListenerByGroupName(currentViewHandle, text))
			{
				activeNavigationGroupByNameCheckAll.PrevGroupName = currentNavigationListenerGroup.GroupName;
				return;
			}
		}
		else if (activeNavigationGroupByNameCheckAll.ActiveListenerList.Count == 1)
		{
			TsUiNavigationBehaviorListener focusListener = currentViewHandle.GetFocusListener();
			bool flag = focusListener.IsInScrollOrLayoutCanFocus();
			TsUiNavigationBehaviorListener listener = activeNavigationGroupByNameCheckAll.ActiveListenerList[0];
			this.ClickButtonInternal(listener);
			if (flag && !focusListener.IsInScrollOrLayoutCanFocus())
			{
				this.MarkViewHandleRefreshNavigationDirty();
			}
		}
	}

	// Token: 0x060180B6 RID: 98486 RVA: 0x0061D77C File Offset: 0x0061B97C
	public void HandleCommonConsumeNavigationToLast(string tag)
	{
		if (StringUtils.IsBlank(tag))
		{
			return;
		}
		NavigationGroup currentNavigationListenerGroup = this.GetCurrentNavigationListenerGroup();
		if (currentNavigationListenerGroup == null)
		{
			return;
		}
		string text = (!string.IsNullOrEmpty(tag)) ? currentNavigationListenerGroup.GroupNameMap.GetValueOrDefault(tag) : currentNavigationListenerGroup.NextGroupName;
		if (StringUtils.IsEmpty(text))
		{
			return;
		}
		NavigationGroup activeNavigationGroupByNameCheckAll = UiNavigationViewManager.Instance.GetCurrentViewHandle().GetActiveNavigationGroupByNameCheckAll(text);
		if (activeNavigationGroupByNameCheckAll == null)
		{
			return;
		}
		TsUiNavigationBehaviorListener lastCanNavigationListenerInGroup = UiNavigationNewController.GetLastCanNavigationListenerInGroup(activeNavigationGroupByNameCheckAll);
		if (lastCanNavigationListenerInGroup == null)
		{
			return;
		}
		this.NavigateScrollTo(lastCanNavigationListenerInGroup);
		this.SwitchNavigationFocus(lastCanNavigationListenerInGroup);
		activeNavigationGroupByNameCheckAll.PrevGroupName = currentNavigationListenerGroup.GroupName;
	}

	// Token: 0x060180B7 RID: 98487 RVA: 0x0061D800 File Offset: 0x0061BA00
	public void HandleCommonConsumeNavigationInside()
	{
		TsUiNavigationBehaviorListener currentNavigationFocusListener = this.GetCurrentNavigationFocusListener();
		if (currentNavigationFocusListener == null)
		{
			return;
		}
		List<TsUiNavigationBehaviorListener> canFocusInsideListenerList = this.GetCanFocusInsideListenerList(currentNavigationFocusListener);
		if (canFocusInsideListenerList.Count > 1)
		{
			TsUiNavigationBehaviorListener listener = canFocusInsideListenerList[0];
			this.SwitchNavigationFocus(listener);
			return;
		}
		if (canFocusInsideListenerList.Count == 1)
		{
			bool flag = currentNavigationFocusListener.IsInScrollOrLayoutCanFocus();
			TsUiNavigationBehaviorListener listener2 = canFocusInsideListenerList[0];
			this.ClickButtonInternal(listener2);
			if (flag && !currentNavigationFocusListener.IsInScrollOrLayoutCanFocus())
			{
				this.MarkViewHandleRefreshNavigationDirty();
			}
		}
	}

	// Token: 0x060180B8 RID: 98488 RVA: 0x0061D867 File Offset: 0x0061BA67
	public bool IsGamepadHitListenerUseDrag()
	{
		return Info.Instance.IsInGamepad() && UiNavigationViewManager.Instance.GetCurrentViewHandle().IsGamepadHitListenerUseDrag();
	}

	// Token: 0x060180B9 RID: 98489 RVA: 0x0061D888 File Offset: 0x0061BA88
	public void SimulationPointerTrigger(bool isPress)
	{
		TsLguiEventSystemActor lguiEventSystemActor = LguiEventSystemManager.Instance.LguiEventSystemActor;
		if (lguiEventSystemActor == null)
		{
			return;
		}
		lguiEventSystemActor.SimulationPointerTrigger(0, isPress);
		UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
		if (currentViewHandle == null)
		{
			return;
		}
		currentViewHandle.SetGamepadMouseTrigger(isPress);
	}

	// Token: 0x060180BA RID: 98490 RVA: 0x0061D8C4 File Offset: 0x0061BAC4
	public void GamepadControlMouseMoveForward(float value)
	{
		UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
		if (currentViewHandle == null)
		{
			return;
		}
		currentViewHandle.SetGamepadMouseMoveForward(value);
	}

	// Token: 0x060180BB RID: 98491 RVA: 0x0061D8E8 File Offset: 0x0061BAE8
	public void GamepadControlMouseMoveRight(float value)
	{
		UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
		if (currentViewHandle == null)
		{
			return;
		}
		currentViewHandle.SetGamepadMouseMoveRight(value);
	}

	// Token: 0x060180BC RID: 98492 RVA: 0x0061D90B File Offset: 0x0061BB0B
	public void RepeatCursorMove()
	{
		if (Info.Instance.IsInGamepad())
		{
			UiNavigationModel instance = UiNavigationModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.RepeatMove();
		}
	}

	// Token: 0x060180BD RID: 98493 RVA: 0x0061D928 File Offset: 0x0061BB28
	private bool InMaskState()
	{
		return UiLayer.Instance.IsInMask() || !ReConnectModel.Instance.IsRpcEmpty();
	}

	// Token: 0x060180BE RID: 98494 RVA: 0x0061D948 File Offset: 0x0061BB48
	public List<TsUiNavigationBehaviorListener> GetDynamicScrollListenerListByListener(TsUiNavigationBehaviorListener listener)
	{
		NavigationGroup navigationGroup = listener.GetNavigationGroup();
		if (navigationGroup == null)
		{
			return new List<TsUiNavigationBehaviorListener>();
		}
		UiNavigationScrollProxy scrollProxy = listener.ScrollProxy;
		TArray<TWeakObjectPtr<AUIBaseActor>> displayItemArray = (((scrollProxy != null) ? scrollProxy.ScrollView : null) as UUIDynScrollViewComponent).DisplayItemArray;
		List<TsUiNavigationBehaviorListener> list = new List<TsUiNavigationBehaviorListener>();
		int i = 0;
		int num = displayItemArray.Num();
		while (i < num)
		{
			TWeakObjectPtr<AUIBaseActor> weak = displayItemArray.Get(i);
			List<TsUiNavigationBehaviorListener> dynListenerListInGroup = this.GetDynListenerListInGroup(weak, navigationGroup);
			list.AddRange(dynListenerListInGroup);
			i++;
		}
		return list;
	}

	// Token: 0x060180BF RID: 98495 RVA: 0x0061D9C0 File Offset: 0x0061BBC0
	public void NotifyNavigationMousePositionDragState(bool state)
	{
		if (Info.Instance.IsInTouch())
		{
			return;
		}
		UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
		if (currentViewHandle == null)
		{
			return;
		}
		currentViewHandle.NotifyNavigationMousePositionDragState(state);
	}

	// Token: 0x060180C0 RID: 98496 RVA: 0x0061D9F0 File Offset: 0x0061BBF0
	public bool IsNavigationMousePositionDragging()
	{
		if (Info.Instance.IsInTouch())
		{
			return false;
		}
		UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
		return currentViewHandle != null && currentViewHandle.IsNavigationMousePositionDragging();
	}

	// Token: 0x060180C1 RID: 98497 RVA: 0x0061DA24 File Offset: 0x0061BC24
	public void SetLockUseDragState(bool lockState)
	{
		if (Info.Instance.IsInTouch())
		{
			return;
		}
		UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
		if (currentViewHandle == null)
		{
			return;
		}
		currentViewHandle.SetLockUseDragState(lockState);
	}

	// Token: 0x060180C2 RID: 98498 RVA: 0x0061DA54 File Offset: 0x0061BC54
	public void SetLockUseDragStateByPanelItem(UUIItem uiItem, bool lockState)
	{
		if (Info.Instance.IsInTouch())
		{
			return;
		}
		if (uiItem == null || !uiItem.IsValid())
		{
			return;
		}
		object obj;
		if (uiItem == null)
		{
			obj = null;
		}
		else
		{
			AActor owner = uiItem.GetOwner();
			obj = ((owner != null) ? owner.GetComponentByClass(TsUiNavigationPanelConfig.StaticClass()) : null);
		}
		TsUiNavigationPanelConfig tsUiNavigationPanelConfig = obj as TsUiNavigationPanelConfig;
		if (tsUiNavigationPanelConfig == null)
		{
			return;
		}
		UiNavigationViewHandle viewHandle = tsUiNavigationPanelConfig.ViewHandle;
		if (viewHandle == null)
		{
			return;
		}
		viewHandle.SetLockUseDragState(lockState);
	}

	// Token: 0x060180C3 RID: 98499 RVA: 0x0061DAC0 File Offset: 0x0061BCC0
	[NullableContext(2)]
	public Vector2D GetMouseViewportPosition()
	{
		if (!Info.Instance.IsInGamepad())
		{
			return null;
		}
		UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
		if (currentViewHandle == null)
		{
			return null;
		}
		return currentViewHandle.GetMouseViewportPosition();
	}

	// Token: 0x1700206D RID: 8301
	// (get) Token: 0x060180C4 RID: 98500 RVA: 0x0061DAF1 File Offset: 0x0061BCF1
	public static UiNavigationNewController Instance
	{
		get
		{
			return UiNavigationNewController._Instance;
		}
	}

	// Token: 0x060180C5 RID: 98501 RVA: 0x0061DAF8 File Offset: 0x0061BCF8
	public static UiNavigationNewController GetOrCreateInstance()
	{
		if (UiNavigationNewController._Instance == null)
		{
			UiNavigationNewController.CreateInstance();
		}
		return UiNavigationNewController._Instance;
	}

	// Token: 0x060180C6 RID: 98502 RVA: 0x0061DB0C File Offset: 0x0061BD0C
	public static bool CreateInstance()
	{
		if (UiNavigationNewController._Instance != null)
		{
			return true;
		}
		UiNavigationNewController._Instance = new UiNavigationNewController();
		return true;
	}

	// Token: 0x060180C7 RID: 98503 RVA: 0x0061DB22 File Offset: 0x0061BD22
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060180C8 RID: 98504 RVA: 0x0061DB24 File Offset: 0x0061BD24
	public static void ResetStaticDefaultValue()
	{
		UiNavigationNewController._Instance = null;
	}

	// Token: 0x060180C9 RID: 98505 RVA: 0x0061DB2C File Offset: 0x0061BD2C
	static UiNavigationNewController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiNavigationNewController.CreateStaticDefaultValue), new Action(UiNavigationNewController.ResetStaticDefaultValue));
	}

	// Token: 0x0400B2E8 RID: 45800
	protected Vector2D DefaultPivot = Vector2D.Create(0.5, 0.5);

	// Token: 0x0400B2E9 RID: 45801
	[Nullable(2)]
	private static UiNavigationNewController _Instance;
}
