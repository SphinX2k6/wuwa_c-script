using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002224 RID: 8740
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class UiNavigationNewController : UiControllerBase
{
	// Token: 0x170020BF RID: 8383
	// (get) Token: 0x060158D7 RID: 88279 RVA: 0x00640DE0 File Offset: 0x0063EFE0
	protected override bool IsTickEvenPausedInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x060158D8 RID: 88280 RVA: 0x00640DE4 File Offset: 0x0063EFE4
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

	// Token: 0x060158D9 RID: 88281 RVA: 0x00640E28 File Offset: 0x0063F028
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

	// Token: 0x060158DA RID: 88282 RVA: 0x00640F38 File Offset: 0x0063F138
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

	// Token: 0x060158DB RID: 88283 RVA: 0x00640F84 File Offset: 0x0063F184
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

	// Token: 0x060158DC RID: 88284 RVA: 0x00640FD0 File Offset: 0x0063F1D0
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

	// Token: 0x060158DD RID: 88285 RVA: 0x006410F8 File Offset: 0x0063F2F8
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

	// Token: 0x060158DE RID: 88286 RVA: 0x00641220 File Offset: 0x0063F420
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

	// Token: 0x060158DF RID: 88287 RVA: 0x00641294 File Offset: 0x0063F494
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

	// Token: 0x060158E0 RID: 88288 RVA: 0x006412C8 File Offset: 0x0063F4C8
	private void OnNavigationTagChanged(string tagName, bool tagExist)
	{
		if (!tagExist)
		{
			Log.Instance.Info(ELogModule.UiNavigation, ELogAuthor.XXJ, "导航的输入分发被删除,需要抬起持续输入的按钮", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiNavigationJoystickInput.ResetJoystickActionInput();
		}
	}

	// Token: 0x060158E1 RID: 88289 RVA: 0x006412FC File Offset: 0x0063F4FC
	private void InputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
	{
		if (last == EInputControllerMainType.Gamepad || last == EInputControllerMainType.Keyboard)
		{
			Log.Instance.Info(ELogModule.UiNavigation, ELogAuthor.XXJ, "输入总类型发生变更,需要抬起持续输入的按钮", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiNavigationJoystickInput.ResetJoystickActionInput();
		}
	}

	// Token: 0x060158E2 RID: 88290 RVA: 0x00641338 File Offset: 0x0063F538
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

	// Token: 0x060158E3 RID: 88291 RVA: 0x006413C4 File Offset: 0x0063F5C4
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

	// Token: 0x060158E4 RID: 88292 RVA: 0x00641412 File Offset: 0x0063F612
	private void OnInputNavigation(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
	{
		UiNavigationJoystickInput.TriggerActionInputTick(actionName, actionType);
	}

	// Token: 0x060158E5 RID: 88293 RVA: 0x0064141C File Offset: 0x0063F61C
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

	// Token: 0x060158E6 RID: 88294 RVA: 0x0064144D File Offset: 0x0063F64D
	protected override void OnTick(float delta)
	{
		UiNavigationJoystickInput.Tick(delta);
		UiNavigationModel.Instance.Tick(delta);
	}

	// Token: 0x060158E7 RID: 88295 RVA: 0x00641460 File Offset: 0x0063F660
	public void HotKeyCloseView()
	{
		TsUiNavigationBehaviorListener currentNavigationActiveListenerByTag = this.GetCurrentNavigationActiveListenerByTag("tag1", true);
		if (Info.Instance.IsInGamepad() && this.JumpNavigationGroup(ELGUINavigationDirection.Prev))
		{
			INavigationInteractPrevGroup navigationInteractPrevGroup = ((currentNavigationActiveListenerByTag != null) ? currentNavigationActiveListenerByTag.GetNavigationComponent() : null) as INavigationInteractPrevGroup;
			if (navigationInteractPrevGroup == null)
			{
				return;
			}
			navigationInteractPrevGroup.InteractClickPrevGroup();
			return;
		}
		else
		{
			if (currentNavigationActiveListenerByTag == null)
			{
				return;
			}
			this.ClickButtonInternal(currentNavigationActiveListenerByTag);
			return;
		}
	}

	// Token: 0x060158E8 RID: 88296 RVA: 0x006414B8 File Offset: 0x0063F6B8
	public void ClickButton(string tag)
	{
		TsUiNavigationBehaviorListener currentNavigationActiveListenerByTag = this.GetCurrentNavigationActiveListenerByTag(tag, true);
		if (currentNavigationActiveListenerByTag == null)
		{
			return;
		}
		this.ClickButtonInternal(currentNavigationActiveListenerByTag);
	}

	// Token: 0x060158E9 RID: 88297 RVA: 0x006414DC File Offset: 0x0063F6DC
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

	// Token: 0x060158EA RID: 88298 RVA: 0x00641508 File Offset: 0x0063F708
	private void ClickButtonInternal(TsUiNavigationBehaviorListener listener)
	{
		if (this.InMaskState())
		{
			return;
		}
		if (this.SimulateClickItem(listener.GetBehaviorComponent().RootUIComp, new FVector2D?(listener.ClickPivot)))
		{
			INavigationInteractClick navigationInteractClick = listener.GetNavigationComponent() as INavigationInteractClick;
			if (navigationInteractClick != null)
			{
				navigationInteractClick.InteractClickHandle();
			}
			UiNavigationModel instance = UiNavigationModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.RepeatMove();
			return;
		}
		else
		{
			INavigationInteractFailClick navigationInteractFailClick = listener.GetNavigationComponent() as INavigationInteractFailClick;
			if (navigationInteractFailClick == null)
			{
				return;
			}
			navigationInteractFailClick.InteractClickFailHandle();
			return;
		}
	}

	// Token: 0x060158EB RID: 88299 RVA: 0x0064157C File Offset: 0x0063F77C
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

	// Token: 0x060158EC RID: 88300 RVA: 0x006415E0 File Offset: 0x0063F7E0
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

	// Token: 0x060158ED RID: 88301 RVA: 0x0064161B File Offset: 0x0063F81B
	[NullableContext(2)]
	public bool InteractRelease(int configId, TsUiNavigationBehaviorListener listener)
	{
		return listener != null && this.PointDownUpInternal(listener, false, configId, this.DefaultPivot);
	}

	// Token: 0x060158EE RID: 88302 RVA: 0x00641634 File Offset: 0x0063F834
	public void InteractClick()
	{
		TsUiNavigationBehaviorListener currentNavigationFocusListener = this.GetCurrentNavigationFocusListener();
		this.InteractClickByListener(currentNavigationFocusListener);
	}

	// Token: 0x060158EF RID: 88303 RVA: 0x0064164F File Offset: 0x0063F84F
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

	// Token: 0x060158F0 RID: 88304 RVA: 0x00641668 File Offset: 0x0063F868
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

	// Token: 0x060158F1 RID: 88305 RVA: 0x00641690 File Offset: 0x0063F890
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

	// Token: 0x060158F2 RID: 88306 RVA: 0x006416B8 File Offset: 0x0063F8B8
	public void ScrollBarChangeScheduleByListener(TsUiNavigationBehaviorListener listener, float value)
	{
		UUIScrollViewComponent uuiscrollViewComponent = listener.GetBehaviorComponent() as UUIScrollViewComponent;
		if (uuiscrollViewComponent == null)
		{
			return;
		}
		this.HandleScrollbarComponentSetValue(uuiscrollViewComponent, value);
	}

	// Token: 0x060158F3 RID: 88307 RVA: 0x006416E0 File Offset: 0x0063F8E0
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

	// Token: 0x060158F4 RID: 88308 RVA: 0x0064170C File Offset: 0x0063F90C
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

	// Token: 0x060158F5 RID: 88309 RVA: 0x00641734 File Offset: 0x0063F934
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
		List<TsUiNavigationBehaviorListener> list = new List<TsUiNavigationBehaviorListener>();
		foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener in navigationGroup.ListenerList)
		{
			if (tsUiNavigationBehaviorListener.IsCanFocus())
			{
				list.Add(tsUiNavigationBehaviorListener);
			}
		}
		List<TsUiNavigationBehaviorListener> list2 = new List<TsUiNavigationBehaviorListener>();
		foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener2 in list)
		{
			if (tsUiNavigationBehaviorListener2.IsSelectedToggle())
			{
				list2.Add(tsUiNavigationBehaviorListener2);
			}
		}
		if (list2.Count == 1)
		{
			uuiextendToggle = (list2[0].GetSelectableComponent() as UUIExtendToggle);
		}
		else if (list2.Count > 1)
		{
			List<int> list3 = new List<int>();
			foreach (TsUiNavigationBehaviorListener item in list2)
			{
				list3.Add(list.IndexOf(item));
			}
			list3.Sort();
			bool flag = true;
			for (int i = 1; i < list3.Count; i++)
			{
				if (list3[i] != list3[i - 1] + 1)
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				List<TsUiNavigationBehaviorListener> list4 = list;
				List<int> list5 = list3;
				uuiextendToggle = (list4[list5[list5.Count - 1]].GetSelectableComponent() as UUIExtendToggle);
			}
			else
			{
				int num;
				if (direction != ELGUINavigationDirection.Right && direction != ELGUINavigationDirection.Down && direction != ELGUINavigationDirection.Next)
				{
					num = list3[0];
				}
				else
				{
					List<int> list6 = list3;
					num = list6[list6.Count - 1];
				}
				int index = num;
				uuiextendToggle = (list[index].GetSelectableComponent() as UUIExtendToggle);
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
		TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener3 = uuiextendToggle2.GetOwner().GetComponentByClass(TsUiNavigationBehaviorListener.StaticClass()) as TsUiNavigationBehaviorListener;
		if (uuiextendToggle2.bAutoScrollOnSelected && tsUiNavigationBehaviorListener3 != null)
		{
			UiNavigationScrollProxy scrollProxy = tsUiNavigationBehaviorListener3.ScrollProxy;
			bool? flag2;
			if (scrollProxy == null)
			{
				flag2 = null;
			}
			else
			{
				UUIScrollViewWithScrollbarComponent scrollView = scrollProxy.ScrollView;
				flag2 = ((scrollView != null) ? new bool?(scrollView.IsValid()) : null);
			}
			bool? flag3 = flag2;
			if (flag3.GetValueOrDefault())
			{
				this.NavigateScrollTo(tsUiNavigationBehaviorListener3);
			}
		}
		this.ClickButtonInternal(tsUiNavigationBehaviorListener3);
		if (navigationGroup.RefreshNavigation)
		{
			this.MarkViewHandleRefreshNavigationDirty();
		}
	}

	// Token: 0x060158F6 RID: 88310 RVA: 0x00641A9C File Offset: 0x0063FC9C
	public void MarkViewHandleRefreshNavigationDirty()
	{
		UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
		if (currentViewHandle == null)
		{
			return;
		}
		currentViewHandle.MarkRefreshNavigationDirty(0);
	}

	// Token: 0x060158F7 RID: 88311 RVA: 0x00641AB4 File Offset: 0x0063FCB4
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

	// Token: 0x060158F8 RID: 88312 RVA: 0x00641AF0 File Offset: 0x0063FCF0
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

	// Token: 0x060158F9 RID: 88313 RVA: 0x00641B40 File Offset: 0x0063FD40
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

	// Token: 0x060158FA RID: 88314 RVA: 0x00641B78 File Offset: 0x0063FD78
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

	// Token: 0x060158FB RID: 88315 RVA: 0x00641C04 File Offset: 0x0063FE04
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

	// Token: 0x060158FC RID: 88316 RVA: 0x00641C70 File Offset: 0x0063FE70
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

	// Token: 0x060158FD RID: 88317 RVA: 0x00641CB4 File Offset: 0x0063FEB4
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

	// Token: 0x060158FE RID: 88318 RVA: 0x00641D10 File Offset: 0x0063FF10
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

	// Token: 0x060158FF RID: 88319 RVA: 0x00641DDC File Offset: 0x0063FFDC
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

	// Token: 0x06015900 RID: 88320 RVA: 0x00641E44 File Offset: 0x00640044
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

	// Token: 0x06015901 RID: 88321 RVA: 0x00641E70 File Offset: 0x00640070
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

	// Token: 0x06015902 RID: 88322 RVA: 0x00641F1C File Offset: 0x0064011C
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

	// Token: 0x06015903 RID: 88323 RVA: 0x00641F89 File Offset: 0x00640189
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

	// Token: 0x06015904 RID: 88324 RVA: 0x00641FB8 File Offset: 0x006401B8
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

	// Token: 0x06015905 RID: 88325 RVA: 0x0064200B File Offset: 0x0064020B
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

	// Token: 0x06015906 RID: 88326 RVA: 0x00642038 File Offset: 0x00640238
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

	// Token: 0x06015907 RID: 88327 RVA: 0x006420A0 File Offset: 0x006402A0
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

	// Token: 0x06015908 RID: 88328 RVA: 0x00642154 File Offset: 0x00640354
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

	// Token: 0x06015909 RID: 88329 RVA: 0x006421D4 File Offset: 0x006403D4
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

	// Token: 0x0601590A RID: 88330 RVA: 0x0064224C File Offset: 0x0064044C
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

	// Token: 0x0601590B RID: 88331 RVA: 0x00642298 File Offset: 0x00640498
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

	// Token: 0x0601590C RID: 88332 RVA: 0x00642320 File Offset: 0x00640520
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

	// Token: 0x0601590D RID: 88333 RVA: 0x006423B8 File Offset: 0x006405B8
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

	// Token: 0x0601590E RID: 88334 RVA: 0x00642414 File Offset: 0x00640614
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

	// Token: 0x0601590F RID: 88335 RVA: 0x006424C8 File Offset: 0x006406C8
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

	// Token: 0x06015910 RID: 88336 RVA: 0x00642534 File Offset: 0x00640734
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

	// Token: 0x06015911 RID: 88337 RVA: 0x006425A8 File Offset: 0x006407A8
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

	// Token: 0x06015912 RID: 88338 RVA: 0x0064261C File Offset: 0x0064081C
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

	// Token: 0x06015913 RID: 88339 RVA: 0x00642660 File Offset: 0x00640860
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

	// Token: 0x06015914 RID: 88340 RVA: 0x00642694 File Offset: 0x00640894
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

	// Token: 0x06015915 RID: 88341 RVA: 0x006426F8 File Offset: 0x006408F8
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

	// Token: 0x06015916 RID: 88342 RVA: 0x00642754 File Offset: 0x00640954
	public void SliderComponentSetValue(string tag, float value)
	{
		TsUiNavigationBehaviorListener currentNavigationActiveListenerByTag = this.GetCurrentNavigationActiveListenerByTag(tag, false);
		if (currentNavigationActiveListenerByTag == null)
		{
			return;
		}
		this.HandleSliderComponentValue(currentNavigationActiveListenerByTag.GetSelectableComponent(), value);
	}

	// Token: 0x06015917 RID: 88343 RVA: 0x0064277C File Offset: 0x0064097C
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

	// Token: 0x06015918 RID: 88344 RVA: 0x006427D8 File Offset: 0x006409D8
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

	// Token: 0x06015919 RID: 88345 RVA: 0x00642834 File Offset: 0x00640A34
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

	// Token: 0x0601591A RID: 88346 RVA: 0x00642870 File Offset: 0x00640A70
	private void HandleVerticalScrollbarComponentSetValue(ULGUIBehaviour behavior, float value)
	{
		UUIScrollViewComponent uuiscrollViewComponent = behavior as UUIScrollViewComponent;
		if (uuiscrollViewComponent != null)
		{
			uuiscrollViewComponent.SetVerticalVelocity(value * 800f);
		}
	}

	// Token: 0x0601591B RID: 88347 RVA: 0x00642894 File Offset: 0x00640A94
	private void HandleHorizontalScrollbarComponentSetValue(ULGUIBehaviour behavior, float value)
	{
		UUIScrollViewComponent uuiscrollViewComponent = behavior as UUIScrollViewComponent;
		if (uuiscrollViewComponent != null)
		{
			uuiscrollViewComponent.SetHorizontalVelocity(value * 800f);
		}
	}

	// Token: 0x0601591C RID: 88348 RVA: 0x006428B8 File Offset: 0x00640AB8
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

	// Token: 0x0601591D RID: 88349 RVA: 0x0064292C File Offset: 0x00640B2C
	public void DraggableComponentNavigate(string tag, bool toNext)
	{
		TsUiNavigationBehaviorListener currentNavigationActiveListenerByTag = this.GetCurrentNavigationActiveListenerByTag(tag, false);
		if (currentNavigationActiveListenerByTag == null)
		{
			return;
		}
		this.HandleDraggableComponentNavigate(currentNavigationActiveListenerByTag.GetBehaviorComponent(), toNext);
	}

	// Token: 0x0601591E RID: 88350 RVA: 0x00642954 File Offset: 0x00640B54
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

	// Token: 0x0601591F RID: 88351 RVA: 0x006429B0 File Offset: 0x00640BB0
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

	// Token: 0x06015920 RID: 88352 RVA: 0x006429D8 File Offset: 0x00640BD8
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

	// Token: 0x06015921 RID: 88353 RVA: 0x00642A94 File Offset: 0x00640C94
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

	// Token: 0x06015922 RID: 88354 RVA: 0x00642AEC File Offset: 0x00640CEC
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

	// Token: 0x06015923 RID: 88355 RVA: 0x00642BC4 File Offset: 0x00640DC4
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

	// Token: 0x06015924 RID: 88356 RVA: 0x00642CAC File Offset: 0x00640EAC
	public void ResetNavigationFocusForViewWithDirtyCheck()
	{
		if (!Info.Instance.IsInTouch())
		{
			Log.Instance.Info(ELogModule.UiNavigation, ELogAuthor.XXJ, "业务重置了导航对象", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.SwitchNavigationFocus(null);
		}
	}

	// Token: 0x06015925 RID: 88357 RVA: 0x00642CEC File Offset: 0x00640EEC
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

	// Token: 0x06015926 RID: 88358 RVA: 0x00642DBC File Offset: 0x00640FBC
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

	// Token: 0x06015927 RID: 88359 RVA: 0x00642E18 File Offset: 0x00641018
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

	// Token: 0x06015928 RID: 88360 RVA: 0x00642E64 File Offset: 0x00641064
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

	// Token: 0x06015929 RID: 88361 RVA: 0x00642F84 File Offset: 0x00641184
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

	// Token: 0x0601592A RID: 88362 RVA: 0x00643000 File Offset: 0x00641200
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

	// Token: 0x0601592B RID: 88363 RVA: 0x006430C6 File Offset: 0x006412C6
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

	// Token: 0x0601592C RID: 88364 RVA: 0x006430F4 File Offset: 0x006412F4
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

	// Token: 0x0601592D RID: 88365 RVA: 0x0064312C File Offset: 0x0064132C
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

	// Token: 0x0601592E RID: 88366 RVA: 0x006431A0 File Offset: 0x006413A0
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

	// Token: 0x0601592F RID: 88367 RVA: 0x00643220 File Offset: 0x00641420
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

	// Token: 0x06015930 RID: 88368 RVA: 0x00643280 File Offset: 0x00641480
	public void ActiveTextInput(string tag)
	{
		TsUiNavigationBehaviorListener currentNavigationActiveListenerByTag = this.GetCurrentNavigationActiveListenerByTag(tag, false);
		if (currentNavigationActiveListenerByTag == null)
		{
			return;
		}
		(currentNavigationActiveListenerByTag.GetBehaviorComponent() as UUITextInputComponent).ActivateInputText();
	}

	// Token: 0x06015931 RID: 88369 RVA: 0x006432AC File Offset: 0x006414AC
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

	// Token: 0x06015932 RID: 88370 RVA: 0x006432E4 File Offset: 0x006414E4
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

	// Token: 0x06015933 RID: 88371 RVA: 0x006433AC File Offset: 0x006415AC
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

	// Token: 0x06015934 RID: 88372 RVA: 0x00643430 File Offset: 0x00641630
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

	// Token: 0x06015935 RID: 88373 RVA: 0x00643497 File Offset: 0x00641697
	public bool IsGamepadHitListenerUseDrag()
	{
		return Info.Instance.IsInGamepad() && UiNavigationViewManager.Instance.GetCurrentViewHandle().IsGamepadHitListenerUseDrag();
	}

	// Token: 0x06015936 RID: 88374 RVA: 0x006434B8 File Offset: 0x006416B8
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

	// Token: 0x06015937 RID: 88375 RVA: 0x006434F4 File Offset: 0x006416F4
	public void GamepadControlMouseMoveForward(float value)
	{
		UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
		if (currentViewHandle == null)
		{
			return;
		}
		currentViewHandle.SetGamepadMouseMoveForward(value);
	}

	// Token: 0x06015938 RID: 88376 RVA: 0x00643518 File Offset: 0x00641718
	public void GamepadControlMouseMoveRight(float value)
	{
		UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
		if (currentViewHandle == null)
		{
			return;
		}
		currentViewHandle.SetGamepadMouseMoveRight(value);
	}

	// Token: 0x06015939 RID: 88377 RVA: 0x0064353B File Offset: 0x0064173B
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

	// Token: 0x0601593A RID: 88378 RVA: 0x00643558 File Offset: 0x00641758
	private bool InMaskState()
	{
		return UiLayer.Instance.IsInMask() || !ReConnectModel.Instance.IsRpcEmpty();
	}

	// Token: 0x0601593B RID: 88379 RVA: 0x00643578 File Offset: 0x00641778
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

	// Token: 0x0601593C RID: 88380 RVA: 0x006435F0 File Offset: 0x006417F0
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

	// Token: 0x0601593D RID: 88381 RVA: 0x00643620 File Offset: 0x00641820
	public bool IsNavigationMousePositionDragging()
	{
		if (Info.Instance.IsInTouch())
		{
			return false;
		}
		UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
		return currentViewHandle != null && currentViewHandle.IsNavigationMousePositionDragging();
	}

	// Token: 0x0601593E RID: 88382 RVA: 0x00643654 File Offset: 0x00641854
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

	// Token: 0x0601593F RID: 88383 RVA: 0x00643684 File Offset: 0x00641884
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

	// Token: 0x06015940 RID: 88384 RVA: 0x006436F0 File Offset: 0x006418F0
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

	// Token: 0x170020C0 RID: 8384
	// (get) Token: 0x06015941 RID: 88385 RVA: 0x00643721 File Offset: 0x00641921
	public static UiNavigationNewController Instance
	{
		get
		{
			return UiNavigationNewController._Instance;
		}
	}

	// Token: 0x06015942 RID: 88386 RVA: 0x00643728 File Offset: 0x00641928
	public static UiNavigationNewController GetOrCreateInstance()
	{
		if (UiNavigationNewController._Instance == null)
		{
			UiNavigationNewController.CreateInstance();
		}
		return UiNavigationNewController._Instance;
	}

	// Token: 0x06015943 RID: 88387 RVA: 0x0064373C File Offset: 0x0064193C
	public static bool CreateInstance()
	{
		if (UiNavigationNewController._Instance != null)
		{
			return true;
		}
		UiNavigationNewController._Instance = new UiNavigationNewController();
		return true;
	}

	// Token: 0x06015944 RID: 88388 RVA: 0x00643752 File Offset: 0x00641952
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015945 RID: 88389 RVA: 0x00643754 File Offset: 0x00641954
	public static void ResetStaticDefaultValue()
	{
		UiNavigationNewController._Instance = null;
	}

	// Token: 0x06015946 RID: 88390 RVA: 0x0064375C File Offset: 0x0064195C
	static UiNavigationNewController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiNavigationNewController.CreateStaticDefaultValue), new Action(UiNavigationNewController.ResetStaticDefaultValue));
	}

	// Token: 0x0400B654 RID: 46676
	protected Vector2D DefaultPivot = Vector2D.Create(0.5, 0.5);

	// Token: 0x0400B655 RID: 46677
	[Nullable(2)]
	private static UiNavigationNewController _Instance;
}
