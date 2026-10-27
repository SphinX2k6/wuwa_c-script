using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004945 RID: 18757
	[NullableContext(1)]
	[Nullable(0)]
	public class UiNavigationLogic : IStaticVariableResetter
	{
		// Token: 0x06030F11 RID: 200465 RVA: 0x00B5C70A File Offset: 0x00B5A90A
		static UiNavigationLogic()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiNavigationLogic.CreateStaticDefaultValue), new Action(UiNavigationLogic.ResetStaticDefaultValue));
		}

		// Token: 0x06030F12 RID: 200466 RVA: 0x00B5C729 File Offset: 0x00B5A929
		public static void InitNavigationDelegate(ULGUIEventSystem eventSystem)
		{
			FLGUITryFindNavigationDelegate tryFindNavigationDelegate = eventSystem.TryFindNavigationDelegate;
			Func<ELGUINavigationDirection, UUISelectableComponent, USceneComponent> callback;
			if ((callback = UiNavigationLogic.<>O.<0>__TryFindNavigationDelegate) == null)
			{
				callback = (UiNavigationLogic.<>O.<0>__TryFindNavigationDelegate = new Func<ELGUINavigationDirection, UUISelectableComponent, USceneComponent>(UiNavigationLogic.TryFindNavigationDelegate));
			}
			tryFindNavigationDelegate.Bind(callback);
		}

		// Token: 0x06030F13 RID: 200467 RVA: 0x00B5C751 File Offset: 0x00B5A951
		public static void ClearNavigationDelegate(ULGUIEventSystem eventSystem)
		{
			eventSystem.TryFindNavigationDelegate.Unbind();
		}

		// Token: 0x06030F14 RID: 200468 RVA: 0x00B5C760 File Offset: 0x00B5A960
		[NullableContext(2)]
		public static USceneComponent TryFindNavigationDelegate(ELGUINavigationDirection direction, UUISelectableComponent selectable)
		{
			if (direction == ELGUINavigationDirection.None && selectable == null)
			{
				ULGUIEventSystem lguiEventSystem = LguiEventSystemManager.Instance.LguiEventSystem;
				if (lguiEventSystem == null)
				{
					return null;
				}
				return lguiEventSystem.navigationComponent;
			}
			else
			{
				if (UiNavigationGlobalData.IsBlockNavigation)
				{
					return null;
				}
				USceneComponent sceneComponent;
				if (selectable == null)
				{
					ULGUIEventSystem lguiEventSystem2 = LguiEventSystemManager.Instance.LguiEventSystem;
					sceneComponent = ((lguiEventSystem2 != null) ? lguiEventSystem2.navigationComponent : null);
				}
				else
				{
					sceneComponent = selectable.GetRootComponent();
				}
				TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = UiNavigationLogic.FindListener(sceneComponent);
				if (tsUiNavigationBehaviorListener == null)
				{
					return null;
				}
				TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener2 = UiNavigationLogic.FindNavigation(tsUiNavigationBehaviorListener, direction);
				TsUiNavigationPanelConfig panelConfig = tsUiNavigationBehaviorListener.PanelConfig;
				if (panelConfig != null && panelConfig.CanOverrideFindNavigation(direction, tsUiNavigationBehaviorListener, tsUiNavigationBehaviorListener2))
				{
					TsUiNavigationPanelConfig panelConfig2 = tsUiNavigationBehaviorListener.PanelConfig;
					TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener3 = (panelConfig2 != null) ? panelConfig2.HandleOverrideFindNavigation(direction, tsUiNavigationBehaviorListener, tsUiNavigationBehaviorListener2) : null;
					if (tsUiNavigationBehaviorListener3 == null)
					{
						return null;
					}
					return tsUiNavigationBehaviorListener3.GetSceneComponent();
				}
				else
				{
					UiNavigationLogic.HandleScrollViewLogic(tsUiNavigationBehaviorListener, tsUiNavigationBehaviorListener2, direction);
					UiNavigationLogic.HandleNavigateAudio(tsUiNavigationBehaviorListener2);
					if (tsUiNavigationBehaviorListener2 == null)
					{
						return null;
					}
					return tsUiNavigationBehaviorListener2.GetSceneComponent();
				}
			}
		}

		// Token: 0x06030F15 RID: 200469 RVA: 0x00B5C817 File Offset: 0x00B5AA17
		private static bool CheckIsUsefulDirection(UUIScrollViewWithScrollbarComponent scrollView, ELGUINavigationDirection direction)
		{
			if (scrollView.Horizontal)
			{
				return direction == ELGUINavigationDirection.Right || direction == ELGUINavigationDirection.Left;
			}
			return direction == ELGUINavigationDirection.Down || direction == ELGUINavigationDirection.Up;
		}

		// Token: 0x06030F16 RID: 200470 RVA: 0x00B5C836 File Offset: 0x00B5AA36
		[NullableContext(2)]
		private static bool CheckNavigationConfig(bool isMoveRightOrDown, NavigationGroup group)
		{
			return group != null && ((group.SlideToRightOrDown && isMoveRightOrDown) || (group.SlideToLeftOrTop && !isMoveRightOrDown));
		}

		// Token: 0x06030F17 RID: 200471 RVA: 0x00B5C858 File Offset: 0x00B5AA58
		private static void HandleNormalScrollViewLogic(TsUiNavigationBehaviorListener originalListener, [Nullable(2)] TsUiNavigationBehaviorListener targetListener, ELGUINavigationDirection direction)
		{
			UiNavigationScrollProxy scrollProxy = originalListener.ScrollProxy;
			UUIScrollViewWithScrollbarComponent uuiscrollViewWithScrollbarComponent = (scrollProxy != null) ? scrollProxy.ScrollView : null;
			NavigationGroup navigationGroup = originalListener.GetNavigationGroup();
			bool flag = direction == ELGUINavigationDirection.Right || direction == ELGUINavigationDirection.Down;
			if (UiNavigationLogic.CheckNavigationConfig(flag, navigationGroup) && UiNavigationLogic.CheckIsUsefulDirection(uuiscrollViewWithScrollbarComponent, direction))
			{
				if (targetListener == null)
				{
					bool flag2 = !flag;
					if (uuiscrollViewWithScrollbarComponent != null)
					{
						uuiscrollViewWithScrollbarComponent.SetScrollProgress(!flag2);
					}
					UiNavigationModel instance = UiNavigationModel.Instance;
					if (instance != null)
					{
						instance.RepeatMove();
					}
					UiNavigationViewManager.Instance.RefreshCurrentHotKey();
					return;
				}
				if (!UiNavigationModeModule.FindOppositeNavigationResult.IsOppositeNavigationPositive)
				{
					if (uuiscrollViewWithScrollbarComponent != null)
					{
						uuiscrollViewWithScrollbarComponent.SetScrollProgress(!flag);
					}
					UiNavigationModel instance2 = UiNavigationModel.Instance;
					if (instance2 != null)
					{
						instance2.RepeatMove();
					}
					UiNavigationViewManager.Instance.RefreshCurrentHotKey();
				}
			}
		}

		// Token: 0x06030F18 RID: 200472 RVA: 0x00B5C904 File Offset: 0x00B5AB04
		private static void HandleDynamicScrollViewLogic([Nullable(2)] TsUiNavigationBehaviorListener originalListener, TsUiNavigationBehaviorListener targetListener, ELGUINavigationDirection direction)
		{
			NavigationGroup navigationGroup = targetListener.GetNavigationGroup();
			UiNavigationScrollProxy scrollProxy = targetListener.ScrollProxy;
			bool flag;
			if (scrollProxy == null)
			{
				flag = false;
			}
			else
			{
				UUIScrollViewWithScrollbarComponent scrollView = scrollProxy.ScrollView;
				flag = ((scrollView != null) ? new bool?(scrollView.Horizontal) : null).GetValueOrDefault();
			}
			UINavigationWrapMode mode = flag ? navigationGroup.HorizontalWrapMode : navigationGroup.VerticalWrapMode;
			UiNavigationScrollProxy scrollProxy2 = targetListener.ScrollProxy;
			UUIDynScrollViewComponent uuidynScrollViewComponent = ((scrollProxy2 != null) ? scrollProxy2.ScrollView : null) as UUIDynScrollViewComponent;
			bool bReversed = (direction == ELGUINavigationDirection.Right || direction == ELGUINavigationDirection.Down) != UiNavigationModeModule.FindOppositeNavigationResult.IsOppositeNavigationPositive;
			uuidynScrollViewComponent.NavigateScrollToUIItem((targetListener != null) ? targetListener.GetRootComponent() : null, bReversed, mode);
		}

		// Token: 0x06030F19 RID: 200473 RVA: 0x00B5C9A1 File Offset: 0x00B5ABA1
		[NullableContext(2)]
		private static void HandleScrollViewLogic(TsUiNavigationBehaviorListener originalListener, TsUiNavigationBehaviorListener targetListener, ELGUINavigationDirection direction)
		{
			if (originalListener != null && originalListener.HasNormalScrollView())
			{
				UiNavigationLogic.HandleNormalScrollViewLogic(originalListener, targetListener, direction);
			}
			if (targetListener != null && targetListener.HasDynamicScrollView())
			{
				UiNavigationLogic.HandleDynamicScrollViewLogic(originalListener, targetListener, direction);
			}
		}

		// Token: 0x06030F1A RID: 200474 RVA: 0x00B5C9C9 File Offset: 0x00B5ABC9
		[NullableContext(2)]
		private static void HandleNavigateAudio(TsUiNavigationBehaviorListener listener)
		{
			if (listener != null)
			{
				AudioSystem.Instance.PostEvent("play_ui_gamepad_navigation_common");
			}
		}

		// Token: 0x06030F1B RID: 200475 RVA: 0x00B5C9E0 File Offset: 0x00B5ABE0
		[return: Nullable(2)]
		private static TsUiNavigationBehaviorListener FindNavigation(TsUiNavigationBehaviorListener listener, ELGUINavigationDirection direction)
		{
			TsUiNavigationPanelConfig panelConfig = listener.PanelConfig;
			if (panelConfig == null || !panelConfig.IsAllowNavigate())
			{
				return null;
			}
			if (!listener.GetNavigationComponent().CheckFindNavigationBefore())
			{
				return null;
			}
			NavigationGroup navigationGroup = listener.GetNavigationGroup();
			USceneComponent sceneComponent;
			if (navigationGroup != null && navigationGroup.GroupType == 0)
			{
				sceneComponent = UiNavigationLogic.FindNormalNavigation(listener, direction, navigationGroup.AllowNavigationInSelfDynamic);
			}
			else
			{
				sceneComponent = listener.FindNavigation(direction);
			}
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = UiNavigationLogic.FindListener(sceneComponent);
			if (!listener.GetNavigationComponent().CheckFindNavigationAfter(tsUiNavigationBehaviorListener))
			{
				return null;
			}
			return tsUiNavigationBehaviorListener;
		}

		// Token: 0x06030F1C RID: 200476 RVA: 0x00B5CA5C File Offset: 0x00B5AC5C
		[return: Nullable(2)]
		private static USceneComponent FindNormalNavigation(TsUiNavigationBehaviorListener listener, ELGUINavigationDirection direction, bool isAllowNavigationInSelfDynamic)
		{
			USceneComponent usceneComponent = listener.FindNavigation(direction);
			if (isAllowNavigationInSelfDynamic)
			{
				return usceneComponent;
			}
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = UiNavigationLogic.FindListener(usceneComponent);
			if (tsUiNavigationBehaviorListener == null)
			{
				return usceneComponent;
			}
			if (listener.ScrollViewActor == null && tsUiNavigationBehaviorListener.ScrollViewActor == null && listener.LayoutActor == null && tsUiNavigationBehaviorListener.LayoutActor == null)
			{
				return listener.GetSceneComponent();
			}
			if (listener.ScrollViewActor != tsUiNavigationBehaviorListener.ScrollViewActor)
			{
				return listener.GetSceneComponent();
			}
			if (listener.LayoutActor != tsUiNavigationBehaviorListener.LayoutActor)
			{
				return listener.GetSceneComponent();
			}
			return usceneComponent;
		}

		// Token: 0x06030F1D RID: 200477 RVA: 0x00B5CAD4 File Offset: 0x00B5ACD4
		[NullableContext(2)]
		private static TsUiNavigationBehaviorListener FindListener(USceneComponent sceneComponent)
		{
			object obj;
			if (sceneComponent == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = sceneComponent.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(TsUiNavigationBehaviorListener.StaticClass()) : null);
			}
			return obj as TsUiNavigationBehaviorListener;
		}

		// Token: 0x06030F1E RID: 200478 RVA: 0x00B5CB00 File Offset: 0x00B5AD00
		public static TsUiNavigationPanelConfig FindUiNavigationPanelConfig(AActor actor)
		{
			AActor attachParentActor = actor.GetAttachParentActor();
			TsUiNavigationPanelConfig tsUiNavigationPanelConfig = null;
			while (attachParentActor != null)
			{
				tsUiNavigationPanelConfig = (attachParentActor.GetComponentByClass(TsUiNavigationPanelConfig.StaticClass()) as TsUiNavigationPanelConfig);
				if (tsUiNavigationPanelConfig != null)
				{
					break;
				}
				attachParentActor = attachParentActor.GetAttachParentActor();
			}
			return tsUiNavigationPanelConfig;
		}

		// Token: 0x06030F1F RID: 200479 RVA: 0x00B5CB3C File Offset: 0x00B5AD3C
		public static TsUiNavigationBehaviorListener FindUpNavigationListener(AActor actor)
		{
			AActor attachParentActor = actor.GetAttachParentActor();
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = null;
			while (attachParentActor != null && !(attachParentActor.GetComponentByClass(TsUiNavigationPanelConfig.StaticClass()) is TsUiNavigationPanelConfig))
			{
				tsUiNavigationBehaviorListener = (attachParentActor.GetComponentByClass(TsUiNavigationBehaviorListener.StaticClass()) as TsUiNavigationBehaviorListener);
				if (tsUiNavigationBehaviorListener != null)
				{
					break;
				}
				attachParentActor = attachParentActor.GetAttachParentActor();
			}
			return tsUiNavigationBehaviorListener;
		}

		// Token: 0x06030F20 RID: 200480 RVA: 0x00B5CB90 File Offset: 0x00B5AD90
		public static void BindHotKeyComponentAction(HotKeyComponent hotKeyComponent, bool bAdd)
		{
			UiNavigationModel instance = UiNavigationModel.Instance;
			string actionName = hotKeyComponent.GetActionName();
			if (string.IsNullOrEmpty(actionName))
			{
				return;
			}
			HashSet<HotKeyComponent> orAddActionHotKeyComponentSet = instance.GetOrAddActionHotKeyComponentSet(actionName);
			if (bAdd)
			{
				if (orAddActionHotKeyComponentSet.Count <= 0)
				{
					InputDistributeController.Instance.BindAction(actionName, UiNavigationLogic.OnInputAction);
				}
				if (orAddActionHotKeyComponentSet.Contains(hotKeyComponent))
				{
					return;
				}
				orAddActionHotKeyComponentSet.Add(hotKeyComponent);
				return;
			}
			else
			{
				if (orAddActionHotKeyComponentSet.Count <= 0)
				{
					return;
				}
				orAddActionHotKeyComponentSet.Remove(hotKeyComponent);
				if (orAddActionHotKeyComponentSet.Count <= 0)
				{
					InputDistributeController.Instance.UnBindAction(actionName, UiNavigationLogic.OnInputAction);
				}
				return;
			}
		}

		// Token: 0x06030F21 RID: 200481 RVA: 0x00B5CC18 File Offset: 0x00B5AE18
		public static void BindHotKeyComponentAxis(HotKeyComponent hotKeyComponent, bool bAdd)
		{
			UiNavigationModel instance = UiNavigationModel.Instance;
			string axisName = hotKeyComponent.GetAxisName();
			if (string.IsNullOrEmpty(axisName))
			{
				return;
			}
			HashSet<HotKeyComponent> orAddAxisHotKeyComponentsSet = instance.GetOrAddAxisHotKeyComponentsSet(axisName);
			if (bAdd)
			{
				if (orAddAxisHotKeyComponentsSet.Count <= 0)
				{
					InputDistributeController.Instance.BindAxis(axisName, UiNavigationLogic.OnInputAxis);
				}
				if (orAddAxisHotKeyComponentsSet.Contains(hotKeyComponent))
				{
					return;
				}
				orAddAxisHotKeyComponentsSet.Add(hotKeyComponent);
				return;
			}
			else
			{
				if (orAddAxisHotKeyComponentsSet.Count == 0)
				{
					return;
				}
				orAddAxisHotKeyComponentsSet.Remove(hotKeyComponent);
				if (orAddAxisHotKeyComponentsSet.Count == 0)
				{
					InputDistributeController.Instance.UnBindAxis(axisName, UiNavigationLogic.OnInputAxis);
				}
				return;
			}
		}

		// Token: 0x06030F22 RID: 200482 RVA: 0x00B5CC9C File Offset: 0x00B5AE9C
		[NullableContext(2)]
		public static bool HasActiveListenerInGroup(NavigationGroup groupConfig)
		{
			if (groupConfig == null)
			{
				return false;
			}
			int i = 0;
			int count = groupConfig.ListenerList.Count;
			while (i < count)
			{
				if (groupConfig.ListenerList[i].IsListenerActive())
				{
					return true;
				}
				i++;
			}
			return false;
		}

		// Token: 0x06030F23 RID: 200483 RVA: 0x00B5CCDC File Offset: 0x00B5AEDC
		[NullableContext(2)]
		public static void UpdateNavigationListener(TsUiNavigationBehaviorListener listener)
		{
			UiNavigationModel instance = UiNavigationModel.Instance;
			if (instance == null)
			{
				return;
			}
			ULGUIEventSystem lguiEventSystem = LguiEventSystemManager.Instance.LguiEventSystem;
			TWeakObjectPtr<UUIItem>? tweakObjectPtr = (listener != null) ? new TWeakObjectPtr<UUIItem>?(listener.RootUIComp) : null;
			lguiEventSystem.navigationComponent = ((tweakObjectPtr != null) ? tweakObjectPtr.GetValueOrDefault() : null);
			instance.SetCursorFollowItem(listener);
			UiNavigationLogic.MemoryGroupConfigLastSelect(listener);
			EventSystem.Instance.Emit(EEventName.UpdateNavigationListener);
		}

		// Token: 0x06030F24 RID: 200484 RVA: 0x00B5CD54 File Offset: 0x00B5AF54
		public static void UpdateSameNavigationListener(TsUiNavigationBehaviorListener listener)
		{
			if (LguiEventSystemManager.Instance.LguiEventSystem.navigationComponent != listener.RootUIComp.Get())
			{
				return;
			}
			UiNavigationModel instance = UiNavigationModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.SetCursorFollowItem(listener);
			UiNavigationLogic.MemoryGroupConfigLastSelect(listener);
			EventSystem.Instance.Emit(EEventName.UpdateNavigationListener);
		}

		// Token: 0x06030F25 RID: 200485 RVA: 0x00B5CDA8 File Offset: 0x00B5AFA8
		[NullableContext(2)]
		public static void MemoryGroupConfigLastSelect(TsUiNavigationBehaviorListener listener)
		{
			if (listener == null)
			{
				return;
			}
			NavigationGroup navigationGroup = listener.GetNavigationGroup();
			if (navigationGroup == null)
			{
				Log.Instance.Error(ELogModule.UiNavigation, ELogAuthor.XXJ, "[MemoryGroupConfigLastSelect]查找不到当前导航的导航组,逻辑上有问题", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (navigationGroup.SelectableMemory)
			{
				navigationGroup.LastSelectListener = listener;
			}
		}

		// Token: 0x06030F26 RID: 200486 RVA: 0x00B5CDF4 File Offset: 0x00B5AFF4
		public static void HandleInputControllerTypeChange()
		{
			bool flag = Info.Instance.IsInGamepad();
			TsLguiEventSystemActor lguiEventSystemActor = LguiEventSystemManager.Instance.LguiEventSystemActor;
			if (lguiEventSystemActor == null)
			{
				UiNavigationModel.Instance.SetIsUseMouse(!flag);
				return;
			}
			if (lguiEventSystemActor.GetPointerEventData(0f, false) == null)
			{
				UiNavigationModel.Instance.SetIsUseMouse(!flag);
				return;
			}
			UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
			bool flag2 = currentViewHandle == null || currentViewHandle.GetCurrentPanel().AllowNavigateInKeyBoard;
			if (flag)
			{
				lguiEventSystemActor.SetIsUseMouse(false);
				lguiEventSystemActor.SwitchToNavigationInputType();
				lguiEventSystemActor.UpdateNavigationListener(null);
				UiNavigationModel.Instance.SetIsUseMouse(false);
				if (!flag2)
				{
					EventSystem.Instance.Emit(EEventName.ResetNavigationListener);
				}
				return;
			}
			if (!flag2)
			{
				UiNavigationModel.Instance.SetIsUseMouse(true);
				EventSystem.Instance.Emit(EEventName.ResetNavigationListener);
				return;
			}
			UiNavigationModel.Instance.SetIsUseMouse(!flag);
		}

		// Token: 0x06030F27 RID: 200487 RVA: 0x00B5CEC8 File Offset: 0x00B5B0C8
		public static void ForceChangeInputType()
		{
			if (!Info.Instance.IsInKeyBoard())
			{
				return;
			}
			UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
			if (currentViewHandle == null)
			{
				return;
			}
			if (currentViewHandle.GetCurrentPanel().IsAllowNavigate())
			{
				return;
			}
			TsLguiEventSystemActor lguiEventSystemActor = LguiEventSystemManager.Instance.LguiEventSystemActor;
			if (lguiEventSystemActor == null)
			{
				return;
			}
			if (lguiEventSystemActor.GetPointerEventData(0f, false).inputType == ELGUIPointerInputType.Navigation)
			{
				lguiEventSystemActor.SetIsForceChange(true);
			}
		}

		// Token: 0x06030F28 RID: 200488 RVA: 0x00B5CF2C File Offset: 0x00B5B12C
		public static void ExecuteInputNavigation(string actionName, InputDistributeDefine.EActionType actionType)
		{
			if (actionType == InputDistributeDefine.EActionType.Release)
			{
				if (UiNavigationLogic.IsPress)
				{
					UiNavigationLogic.IsPress = false;
					LguiEventSystemManager.Instance.InputNavigation(actionName, InputDistributeDefine.EActionType.Release);
					return;
				}
			}
			else
			{
				UiNavigationViewHandle currentViewHandle = UiNavigationViewManager.Instance.GetCurrentViewHandle();
				if (currentViewHandle == null)
				{
					return;
				}
				if (currentViewHandle.GetFocusListener() == null)
				{
					return;
				}
				UiNavigationLogic.IsPress = true;
				LguiEventSystemManager.Instance.InputNavigation(actionName, InputDistributeDefine.EActionType.Press);
			}
		}

		// Token: 0x06030F29 RID: 200489 RVA: 0x00B5CF84 File Offset: 0x00B5B184
		public static void ExecuteInterfaceMethod<[Nullable(2)] T>(object obj, string methodName, params object[] args)
		{
			MethodInfo method = obj.GetType().GetMethod(methodName);
			if (method != null)
			{
				method.Invoke(obj, args);
			}
		}

		// Token: 0x06030F2A RID: 200490 RVA: 0x00B5CFB0 File Offset: 0x00B5B1B0
		public static void CreateStaticDefaultValue()
		{
			UiNavigationLogic.OnInputAction = delegate(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification _)
			{
				UiNavigationModel instance = UiNavigationModel.Instance;
				if (instance == null)
				{
					return;
				}
				foreach (HotKeyComponent hotKeyComponent in new HashSet<HotKeyComponent>(instance.GetActionHotKeyComponentSet(actionName)))
				{
					if (hotKeyComponent.IsHotKeyActive())
					{
						if (actionType == InputDistributeDefine.EActionType.Press)
						{
							hotKeyComponent.Press();
						}
						else
						{
							hotKeyComponent.Release();
						}
					}
				}
			};
			UiNavigationLogic.OnInputAxis = delegate(string axisName, float value, InputIdentification _)
			{
				UiNavigationModel instance = UiNavigationModel.Instance;
				if (instance == null)
				{
					return;
				}
				foreach (HotKeyComponent hotKeyComponent in new HashSet<HotKeyComponent>(instance.GetAxisHotKeyComponentSet(axisName)))
				{
					if (hotKeyComponent.IsAllowTickContinue())
					{
						hotKeyComponent.InputAxis(axisName, value);
					}
				}
			};
			UiNavigationLogic.IsPress = false;
		}

		// Token: 0x06030F2B RID: 200491 RVA: 0x00B5D00B File Offset: 0x00B5B20B
		public static void ResetStaticDefaultValue()
		{
			UiNavigationLogic.OnInputAction = null;
			UiNavigationLogic.OnInputAxis = null;
			UiNavigationLogic.IsPress = false;
		}

		// Token: 0x0401A453 RID: 107603
		private static TInputHandle<InputDistributeDefine.EActionType> OnInputAction;

		// Token: 0x0401A454 RID: 107604
		private static TInputHandle<float> OnInputAxis;

		// Token: 0x0401A455 RID: 107605
		private static bool IsPress;

		// Token: 0x0200ABAB RID: 43947
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040342FB RID: 213755
			[Nullable(new byte[]
			{
				0,
				2,
				2
			})]
			public static Func<ELGUINavigationDirection, UUISelectableComponent, USceneComponent> <0>__TryFindNavigationDelegate;
		}
	}
}
