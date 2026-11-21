using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Cursor;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002A14 RID: 10772
[UClass("/Game/Aki/TypeScript/Game/Ui/LguiEventSystem/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Ui/LguiEventSystem/TsLguiEventSystemActor.TsLguiEventSystemActor_C")]
public class TsLguiEventSystemActor : ALGUIEventSystemActor, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601B219 RID: 111129 RVA: 0x00853AAE File Offset: 0x00851CAE
	static TsLguiEventSystemActor()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsLguiEventSystemActor.CreateStaticDefaultValue), new Action(TsLguiEventSystemActor.ResetStaticDefaultValue));
	}

	// Token: 0x17002C4A RID: 11338
	// (get) Token: 0x0601B21A RID: 111130 RVA: 0x00853ACD File Offset: 0x00851CCD
	// (set) Token: 0x0601B21B RID: 111131 RVA: 0x00853AE1 File Offset: 0x00851CE1
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	private unsafe ULGUI_StandaloneInputModule StandaloneInputModule
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<ULGUI_StandaloneInputModule>(base.NativePtr / (IntPtr)sizeof(void*) + TsLguiEventSystemActor.__PropertyOffset_StandaloneInputModule);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsLguiEventSystemActor.__PropertyOffset_StandaloneInputModule, value);
		}
	}

	// Token: 0x17002C4B RID: 11339
	// (get) Token: 0x0601B21C RID: 111132 RVA: 0x00853AF6 File Offset: 0x00851CF6
	// (set) Token: 0x0601B21D RID: 111133 RVA: 0x00853B0A File Offset: 0x00851D0A
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	private unsafe ULGUI_TouchInputModule TouchInputModule
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<ULGUI_TouchInputModule>(base.NativePtr / (IntPtr)sizeof(void*) + TsLguiEventSystemActor.__PropertyOffset_TouchInputModule);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsLguiEventSystemActor.__PropertyOffset_TouchInputModule, value);
		}
	}

	// Token: 0x17002C4C RID: 11340
	// (get) Token: 0x0601B21E RID: 111134 RVA: 0x00853B1F File Offset: 0x00851D1F
	// (set) Token: 0x0601B21F RID: 111135 RVA: 0x00853B27 File Offset: 0x00851D27
	[Nullable(2)]
	private ULGUI_PointerInputModule CurrentInputModule { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17002C4D RID: 11341
	// (get) Token: 0x0601B220 RID: 111136 RVA: 0x00853B30 File Offset: 0x00851D30
	// (set) Token: 0x0601B221 RID: 111137 RVA: 0x00853B40 File Offset: 0x00851D40
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool NavigationEnable
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsLguiEventSystemActor.__PropertyOffset_NavigationEnable) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsLguiEventSystemActor.__PropertyOffset_NavigationEnable) = (value ? 1 : 0);
		}
	}

	// Token: 0x0601B222 RID: 111138 RVA: 0x00853B54 File Offset: 0x00851D54
	public void InitializeLguiEventSystemActor()
	{
		this.RefreshCurrentInputModule();
		ULGUI_StandaloneInputModule standaloneInputModule = this.StandaloneInputModule;
		FLGUIDelegateHandleWrapper handleWrapper;
		if (standaloneInputModule == null)
		{
			handleWrapper = null;
		}
		else
		{
			Action<ELGUIPointerInputType> callback;
			if ((callback = TsLguiEventSystemActor.<>O.<0>__ChangeController) == null)
			{
				callback = (TsLguiEventSystemActor.<>O.<0>__ChangeController = new Action<ELGUIPointerInputType>(TsLguiEventSystemActor.ChangeController));
			}
			FLGUIPointerInputChange_DynamicDelegate flguipointerInputChange_DynamicDelegate = DelegateUtils.ToManualReleaseDelegate<FLGUIPointerInputChange_DynamicDelegate>(callback);
			handleWrapper = standaloneInputModule.RegisterInputChangeEvent(flguipointerInputChange_DynamicDelegate);
		}
		this.HandleWrapper = handleWrapper;
		this.AddEvents();
		this.RegisterControllerChange();
		CursorController.Instance.SetWindowCursorStyle();
		this.RegisterPointEnterExitEvent();
		this.BroadCastInputType();
	}

	// Token: 0x0601B223 RID: 111139 RVA: 0x00853BC4 File Offset: 0x00851DC4
	public void ResetLguiEventSystemActor()
	{
		if (this.HandleWrapper != null)
		{
			ULGUI_StandaloneInputModule standaloneInputModule = this.StandaloneInputModule;
			if (standaloneInputModule != null)
			{
				standaloneInputModule.UnregisterInputChangeEvent(this.HandleWrapper);
			}
		}
		Action<ELGUIPointerInputType> callBack;
		if ((callBack = TsLguiEventSystemActor.<>O.<0>__ChangeController) == null)
		{
			callBack = (TsLguiEventSystemActor.<>O.<0>__ChangeController = new Action<ELGUIPointerInputType>(TsLguiEventSystemActor.ChangeController));
		}
		DelegateUtils.ReleaseManualReleaseDelegate(callBack);
		this.HandleWrapper = null;
		this.UnRegisterControllerChange();
		this.RemoveEvents();
		this.UnRegisterPointEnterExitEvent();
	}

	// Token: 0x0601B224 RID: 111140 RVA: 0x00853C29 File Offset: 0x00851E29
	private void AddEvents()
	{
		this.ShowTypeChange = delegate(EOperationType last, EOperationType now)
		{
			this.RefreshCurrentInputModule();
		};
		CSharpScript.Game.Common.Event.EventSystem.Instance.Add<EOperationType, EOperationType>(EEventName.ShowTypeChange, this.ShowTypeChange);
	}

	// Token: 0x0601B225 RID: 111141 RVA: 0x00853C53 File Offset: 0x00851E53
	private void RemoveEvents()
	{
		CSharpScript.Game.Common.Event.EventSystem.Instance.Remove<EOperationType, EOperationType>(EEventName.ShowTypeChange, this.ShowTypeChange);
	}

	// Token: 0x0601B226 RID: 111142 RVA: 0x00853C6C File Offset: 0x00851E6C
	private void RegisterControllerChange()
	{
		this.ControllerConnectChange = delegate(bool bIsConnected, int platformUserId, int controllerId)
		{
			CSharpScript.Game.Common.Event.EventSystem.Instance.Emit<bool, int, int>(EEventName.ControllerConnectChange, bIsConnected, platformUserId, controllerId);
		};
		ULGUIEventSystem eventSystem = base.EventSystem;
		if (eventSystem == null)
		{
			return;
		}
		eventSystem.OnConnectionChanged.Add(this.ControllerConnectChange);
	}

	// Token: 0x0601B227 RID: 111143 RVA: 0x00853CB9 File Offset: 0x00851EB9
	private void UnRegisterControllerChange()
	{
		ULGUIEventSystem eventSystem = base.EventSystem;
		if (eventSystem == null)
		{
			return;
		}
		eventSystem.OnConnectionChanged.Remove(this.ControllerConnectChange);
	}

	// Token: 0x0601B228 RID: 111144 RVA: 0x00853CD8 File Offset: 0x00851ED8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void InputTrigger(bool triggerPress, EMouseButtonType mouseButtonType)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsLguiEventSystemActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("InputTrigger"), TsLguiEventSystemActor.StaticClass(), out intPtr, out num))
		{
			this.InputTrigger_Implementation(triggerPress, mouseButtonType);
			return;
		}
		TsLguiEventSystemActor.__InputTrigger_FunctionParams* ptr = stackalloc TsLguiEventSystemActor.__InputTrigger_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsLguiEventSystemActor.__InputTrigger_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->triggerPress = triggerPress;
		*(&ptr->mouseButtonType) = (byte)mouseButtonType;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601B229 RID: 111145 RVA: 0x00853D70 File Offset: 0x00851F70
	protected void InputTrigger_Implementation(bool triggerPress, EMouseButtonType mouseButtonType)
	{
		if (Info.Instance.IsInTouch())
		{
			return;
		}
		APlayerController playerController = Global.PlayerController;
		if (playerController == null)
		{
			return;
		}
		if (!playerController.bShowMouseCursor)
		{
			return;
		}
		ULGUI_StandaloneInputModule standaloneInputModule = this.StandaloneInputModule;
		if (standaloneInputModule == null)
		{
			return;
		}
		standaloneInputModule.InputTrigger(triggerPress, mouseButtonType);
	}

	// Token: 0x0601B22A RID: 111146 RVA: 0x00853DB0 File Offset: 0x00851FB0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void InputNavigation(ELGUINavigationDirection direction, bool pressOrRelease, bool forceNavigation = false)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsLguiEventSystemActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("InputNavigation"), TsLguiEventSystemActor.StaticClass(), out intPtr, out num))
		{
			this.InputNavigation_Implementation(direction, pressOrRelease, forceNavigation);
			return;
		}
		TsLguiEventSystemActor.__InputNavigation_FunctionParams* ptr = stackalloc TsLguiEventSystemActor.__InputNavigation_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsLguiEventSystemActor.__InputNavigation_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->direction) = (byte)direction;
		ptr->pressOrRelease = pressOrRelease;
		ptr->forceNavigation = forceNavigation;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601B22B RID: 111147 RVA: 0x00853E4E File Offset: 0x0085204E
	protected void InputNavigation_Implementation(ELGUINavigationDirection direction, bool pressOrRelease, bool forceNavigation = false)
	{
		if (!this.NavigationEnable && !forceNavigation)
		{
			return;
		}
		if (this.CurrentInputModule == null)
		{
			return;
		}
		TsLguiEventSystemActor.InputType = ELGUIPointerInputType.Navigation;
		this.CurrentInputModule.InputNavigation(direction, pressOrRelease);
	}

	// Token: 0x0601B22C RID: 111148 RVA: 0x00853E78 File Offset: 0x00852078
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void InputTriggerForNavigation(bool triggerPress)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsLguiEventSystemActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("InputTriggerForNavigation"), TsLguiEventSystemActor.StaticClass(), out intPtr, out num))
		{
			this.InputTriggerForNavigation_Implementation(triggerPress);
			return;
		}
		TsLguiEventSystemActor.__InputTriggerForNavigation_FunctionParams* ptr = stackalloc TsLguiEventSystemActor.__InputTriggerForNavigation_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsLguiEventSystemActor.__InputTriggerForNavigation_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->triggerPress = triggerPress;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601B22D RID: 111149 RVA: 0x00853F04 File Offset: 0x00852104
	protected void InputTriggerForNavigation_Implementation(bool triggerPress)
	{
		if (this.CurrentInputModule == null)
		{
			return;
		}
		TsLguiEventSystemActor.InputType = ELGUIPointerInputType.Navigation;
		this.CurrentInputModule.InputTriggerForNavigation(triggerPress);
	}

	// Token: 0x0601B22E RID: 111150 RVA: 0x00853F21 File Offset: 0x00852121
	public void SwitchToNavigationInputType()
	{
		if (this.CurrentInputModule == null)
		{
			return;
		}
		if (TsLguiEventSystemActor.InputType == ELGUIPointerInputType.Navigation)
		{
			return;
		}
		TsLguiEventSystemActor.InputType = ELGUIPointerInputType.Navigation;
		this.CurrentInputModule.SwitchToNavigationInputType();
	}

	// Token: 0x0601B22F RID: 111151 RVA: 0x00853F48 File Offset: 0x00852148
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void InputScroll(float axisValue)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsLguiEventSystemActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("InputScroll"), TsLguiEventSystemActor.StaticClass(), out intPtr, out num))
		{
			this.InputScroll_Implementation(axisValue);
			return;
		}
		TsLguiEventSystemActor.__InputScroll_FunctionParams* ptr = stackalloc TsLguiEventSystemActor.__InputScroll_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsLguiEventSystemActor.__InputScroll_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->axisValue = axisValue;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601B230 RID: 111152 RVA: 0x00853FD4 File Offset: 0x008521D4
	protected void InputScroll_Implementation(float axisValue)
	{
		ULGUI_StandaloneInputModule standaloneInputModule = this.StandaloneInputModule;
		if (standaloneInputModule != null)
		{
			standaloneInputModule.InputScroll(axisValue);
		}
		if (Info.Instance.IsInTouch())
		{
			return;
		}
		if (axisValue != 0f)
		{
			ULGUIPointerEventData pointerEventData = this.GetPointerEventData(0f, true);
			if (pointerEventData != null && pointerEventData.inputType != ELGUIPointerInputType.Pointer)
			{
				pointerEventData.inputType = ELGUIPointerInputType.Pointer;
				TsLguiEventSystemActor.ChangeController(pointerEventData.inputType);
			}
		}
	}

	// Token: 0x0601B231 RID: 111153 RVA: 0x00854034 File Offset: 0x00852234
	public void InputScrollByGamepad(float axisValue)
	{
		ULGUI_StandaloneInputModule standaloneInputModule = this.StandaloneInputModule;
		if (standaloneInputModule != null)
		{
			standaloneInputModule.InputScroll(axisValue);
		}
		if (axisValue != 0f)
		{
			ULGUIPointerEventData pointerEventData = this.GetPointerEventData(0f, true);
			if (pointerEventData != null && pointerEventData.inputType != ELGUIPointerInputType.Navigation)
			{
				pointerEventData.inputType = ELGUIPointerInputType.Navigation;
				TsLguiEventSystemActor.ChangeController(pointerEventData.inputType);
			}
		}
	}

	// Token: 0x0601B232 RID: 111154 RVA: 0x00854088 File Offset: 0x00852288
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void InputTouchTrigger(bool touchPress, int touchId, FVector touchPointPosition)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsLguiEventSystemActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("InputTouchTrigger"), TsLguiEventSystemActor.StaticClass(), out intPtr, out num))
		{
			this.InputTouchTrigger_Implementation(touchPress, touchId, touchPointPosition);
			return;
		}
		TsLguiEventSystemActor.__InputTouchTrigger_FunctionParams* ptr = stackalloc TsLguiEventSystemActor.__InputTouchTrigger_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsLguiEventSystemActor.__InputTouchTrigger_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->touchPress = touchPress;
		ptr->touchId = touchId;
		ptr->touchPointPosition = touchPointPosition;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601B233 RID: 111155 RVA: 0x00854124 File Offset: 0x00852324
	protected void InputTouchTrigger_Implementation(bool touchPress, int touchId, FVector touchPointPosition)
	{
		int inTouchID = touchId;
		if (Info.Instance.IsMobileInputModel() && Info.Instance.IsInGamepad())
		{
			inTouchID = touchId + 1000;
		}
		ULGUI_TouchInputModule touchInputModule = this.TouchInputModule;
		if (touchInputModule == null)
		{
			return;
		}
		touchInputModule.InputTouchTrigger(touchPress, inTouchID, touchPointPosition);
	}

	// Token: 0x0601B234 RID: 111156 RVA: 0x00854168 File Offset: 0x00852368
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void InputTouchMove(int touchId, FVector touchPointPosition)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsLguiEventSystemActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("InputTouchMove"), TsLguiEventSystemActor.StaticClass(), out intPtr, out num))
		{
			this.InputTouchMove_Implementation(touchId, touchPointPosition);
			return;
		}
		TsLguiEventSystemActor.__InputTouchMove_FunctionParams* ptr = stackalloc TsLguiEventSystemActor.__InputTouchMove_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsLguiEventSystemActor.__InputTouchMove_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->touchId = touchId;
		ptr->touchPointPosition = touchPointPosition;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601B235 RID: 111157 RVA: 0x008541FC File Offset: 0x008523FC
	protected void InputTouchMove_Implementation(int touchId, FVector touchPointPosition)
	{
		if (Info.Instance.IsMobileInputModel() && Info.Instance.IsInGamepad())
		{
			int inTouchID = touchId + 1000;
			ULGUI_TouchInputModule touchInputModule = this.TouchInputModule;
			if (touchInputModule != null)
			{
				touchInputModule.InputTouchMoved(inTouchID, touchPointPosition);
			}
			ULGUI_TouchInputModule touchInputModule2 = this.TouchInputModule;
			if (touchInputModule2 == null)
			{
				return;
			}
			touchInputModule2.RefreshProcessInput();
			return;
		}
		else
		{
			ULGUI_TouchInputModule touchInputModule3 = this.TouchInputModule;
			if (touchInputModule3 == null)
			{
				return;
			}
			touchInputModule3.InputTouchMoved(touchId, touchPointPosition);
			return;
		}
	}

	// Token: 0x0601B236 RID: 111158 RVA: 0x00854263 File Offset: 0x00852463
	public void RefreshCurrentInputModule()
	{
		if (Info.Instance.IsInTouch())
		{
			this.CurrentInputModule = this.TouchInputModule;
		}
		else
		{
			this.CurrentInputModule = this.StandaloneInputModule;
		}
		ULGUI_PointerInputModule currentInputModule = this.CurrentInputModule;
		if (currentInputModule == null)
		{
			return;
		}
		currentInputModule.Activate(false);
	}

	// Token: 0x0601B237 RID: 111159 RVA: 0x0085429C File Offset: 0x0085249C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual UUIItem GetNowHitComponent()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsLguiEventSystemActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNowHitComponent"), TsLguiEventSystemActor.StaticClass(), out intPtr, out num))
		{
			return this.GetNowHitComponent_Implementation();
		}
		TsLguiEventSystemActor.__GetNowHitComponent_FunctionParams* ptr = stackalloc TsLguiEventSystemActor.__GetNowHitComponent_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsLguiEventSystemActor.__GetNowHitComponent_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UUIItem orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIItem>(ptr->__Result);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return orCreateUObjectByNativePointer;
	}

	// Token: 0x0601B238 RID: 111160 RVA: 0x0085432B File Offset: 0x0085252B
	[NullableContext(2)]
	protected UUIItem GetNowHitComponent_Implementation()
	{
		ULGUI_PointerInputModule currentInputModule = this.CurrentInputModule;
		if (currentInputModule == null)
		{
			return null;
		}
		return currentInputModule.GetNowHitComponent();
	}

	// Token: 0x0601B239 RID: 111161 RVA: 0x00854340 File Offset: 0x00852540
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual ULGUIPointerEventData GetPointerEventData(float pointerId, bool createIfNotExist = false)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsLguiEventSystemActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetPointerEventData"), TsLguiEventSystemActor.StaticClass(), out intPtr, out num))
		{
			return this.GetPointerEventData_Implementation(pointerId, createIfNotExist);
		}
		TsLguiEventSystemActor.__GetPointerEventData_FunctionParams* ptr = stackalloc TsLguiEventSystemActor.__GetPointerEventData_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsLguiEventSystemActor.__GetPointerEventData_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->pointerId = pointerId;
		ptr->createIfNotExist = createIfNotExist;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(ptr->__Result);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return orCreateUObjectByNativePointer;
	}

	// Token: 0x0601B23A RID: 111162 RVA: 0x008543DF File Offset: 0x008525DF
	[NullableContext(2)]
	protected ULGUIPointerEventData GetPointerEventData_Implementation(float pointerId, bool createIfNotExist = false)
	{
		ULGUI_PointerInputModule currentInputModule = this.CurrentInputModule;
		if (currentInputModule == null)
		{
			return null;
		}
		return currentInputModule.GetPointerEventData((int)pointerId, createIfNotExist);
	}

	// Token: 0x0601B23B RID: 111163 RVA: 0x008543F8 File Offset: 0x008525F8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool IsPointerEventDataLineTrace(ULGUIPointerEventData pointerEventData)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsLguiEventSystemActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("IsPointerEventDataLineTrace"), TsLguiEventSystemActor.StaticClass(), out intPtr, out num))
		{
			return this.IsPointerEventDataLineTrace_Implementation(pointerEventData);
		}
		TsLguiEventSystemActor.__IsPointerEventDataLineTrace_FunctionParams* ptr = stackalloc TsLguiEventSystemActor.__IsPointerEventDataLineTrace_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsLguiEventSystemActor.__IsPointerEventDataLineTrace_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->pointerEventData) = ((pointerEventData != null) ? pointerEventData.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601B23C RID: 111164 RVA: 0x00854498 File Offset: 0x00852698
	[NullableContext(1)]
	protected bool IsPointerEventDataLineTrace_Implementation(ULGUIPointerEventData pointerEventData)
	{
		return this.CurrentInputModule != null && !this.CurrentInputModule.IsPointerEventDataLineTrace(pointerEventData);
	}

	// Token: 0x0601B23D RID: 111165 RVA: 0x008544B4 File Offset: 0x008526B4
	[NullableContext(1)]
	public bool SimulateClickButton(int pointerId, UUIItem uiItem, FVector2D? pivot)
	{
		pivot = new FVector2D?(pivot ?? new FVector2D(0.5f, 0.5f));
		ULGUI_StandaloneInputModule standaloneInputModule = this.StandaloneInputModule;
		return standaloneInputModule != null && standaloneInputModule.SimulationLineTrace(pointerId, uiItem, pivot);
	}

	// Token: 0x0601B23E RID: 111166 RVA: 0x00854500 File Offset: 0x00852700
	[NullableContext(1)]
	public bool SimulationPointerDownUp(int pointerId, UUIItem uiItem, bool isPress, FVector2D pivot)
	{
		ULGUI_StandaloneInputModule standaloneInputModule = this.StandaloneInputModule;
		if (standaloneInputModule == null)
		{
			return false;
		}
		FVector2D? fvector2D = new FVector2D?(pivot);
		return standaloneInputModule.SimulationPointerDownUp(pointerId, uiItem, isPress, fvector2D);
	}

	// Token: 0x0601B23F RID: 111167 RVA: 0x0085452B File Offset: 0x0085272B
	public void SimulationPointerTrigger(int pointerId, bool isPress)
	{
		ULGUI_StandaloneInputModule standaloneInputModule = this.StandaloneInputModule;
		if (standaloneInputModule == null)
		{
			return;
		}
		standaloneInputModule.SimulationPointerTrigger(pointerId, isPress);
	}

	// Token: 0x0601B240 RID: 111168 RVA: 0x0085453F File Offset: 0x0085273F
	public void ResetNowIsTriggerPressed(int pointerId)
	{
		ULGUI_StandaloneInputModule standaloneInputModule = this.StandaloneInputModule;
		if (standaloneInputModule == null)
		{
			return;
		}
		standaloneInputModule.ResetNowIsTriggerPressed(pointerId);
	}

	// Token: 0x0601B241 RID: 111169 RVA: 0x00854552 File Offset: 0x00852752
	[NullableContext(2)]
	public void UpdateNavigationListener(USceneComponent component)
	{
		ULGUI_StandaloneInputModule standaloneInputModule = this.StandaloneInputModule;
		if (standaloneInputModule == null)
		{
			return;
		}
		standaloneInputModule.UpdateNavigation(component);
	}

	// Token: 0x0601B242 RID: 111170 RVA: 0x00854565 File Offset: 0x00852765
	public void SetIsUseMouse(bool value)
	{
		ULGUI_StandaloneInputModule standaloneInputModule = this.StandaloneInputModule;
		if (standaloneInputModule == null)
		{
			return;
		}
		standaloneInputModule.SetIsForceChange(value);
	}

	// Token: 0x0601B243 RID: 111171 RVA: 0x00854578 File Offset: 0x00852778
	public void SetIsForceChange(bool value)
	{
		ULGUI_StandaloneInputModule standaloneInputModule = this.StandaloneInputModule;
		if (standaloneInputModule == null)
		{
			return;
		}
		standaloneInputModule.SetIsForceChange(value);
	}

	// Token: 0x0601B244 RID: 111172 RVA: 0x0085458C File Offset: 0x0085278C
	public void SetPrevMousePosition(float x, float y)
	{
		ULGUIPointerEventData pointerEventData = this.GetPointerEventData(0f, true);
		if (pointerEventData != null)
		{
			pointerEventData.prevMousePos = new FVector2D(x, y);
		}
	}

	// Token: 0x0601B245 RID: 111173 RVA: 0x008545B6 File Offset: 0x008527B6
	public void SetCurrentInputKeyType(EInputKeyType inputKeyType)
	{
		if (Info.Instance.IsInTouch())
		{
			ULGUI_TouchInputModule touchInputModule = this.TouchInputModule;
			if (touchInputModule != null)
			{
				touchInputModule.SetCurrentInputKeyType(inputKeyType);
			}
		}
		else
		{
			ULGUI_StandaloneInputModule standaloneInputModule = this.StandaloneInputModule;
			if (standaloneInputModule != null)
			{
				standaloneInputModule.SetCurrentInputKeyType(inputKeyType);
			}
		}
		this.SetClickThresholdWithInputKeyType(inputKeyType);
	}

	// Token: 0x0601B246 RID: 111174 RVA: 0x008545F4 File Offset: 0x008527F4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void SetClickThresholdWithInputKeyType(EInputKeyType inputKeyType)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsLguiEventSystemActor) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetClickThresholdWithInputKeyType"), TsLguiEventSystemActor.StaticClass(), out intPtr, out num))
		{
			this.SetClickThresholdWithInputKeyType_Implementation(inputKeyType);
			return;
		}
		TsLguiEventSystemActor.__SetClickThresholdWithInputKeyType_FunctionParams* ptr = stackalloc TsLguiEventSystemActor.__SetClickThresholdWithInputKeyType_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsLguiEventSystemActor.__SetClickThresholdWithInputKeyType_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->inputKeyType) = (byte)inputKeyType;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601B247 RID: 111175 RVA: 0x00854684 File Offset: 0x00852884
	protected void SetClickThresholdWithInputKeyType_Implementation(EInputKeyType inputKeyType)
	{
		if (this.StandaloneInputModule != null)
		{
			switch (inputKeyType)
			{
			case EInputKeyType.KeyboardOrMouse:
				this.StandaloneInputModule.SetClickThreshold(this.MouseClickThreshold);
				return;
			case EInputKeyType.Gamepad:
				this.StandaloneInputModule.SetClickThreshold(this.GamepadClickThreshold);
				break;
			case EInputKeyType.Touch:
				this.StandaloneInputModule.SetClickThreshold(this.TouchClickThreshold);
				return;
			default:
				return;
			}
		}
	}

	// Token: 0x0601B248 RID: 111176 RVA: 0x008546E3 File Offset: 0x008528E3
	public void OverrideMousePosition(FVector2D vector2D)
	{
		ULGUI_StandaloneInputModule standaloneInputModule = this.StandaloneInputModule;
		if (standaloneInputModule == null)
		{
			return;
		}
		standaloneInputModule.InputOverrideMousePosition(vector2D);
	}

	// Token: 0x0601B249 RID: 111177 RVA: 0x008546F7 File Offset: 0x008528F7
	public void SetIsOverrideMousePosition(bool value)
	{
		if (this.StandaloneInputModule != null)
		{
			this.StandaloneInputModule.bOverrideMousePosition = value;
		}
	}

	// Token: 0x0601B24A RID: 111178 RVA: 0x0085470D File Offset: 0x0085290D
	public bool IsInPointerInputType()
	{
		return TsLguiEventSystemActor.InputType == ELGUIPointerInputType.Pointer;
	}

	// Token: 0x0601B24B RID: 111179 RVA: 0x00854717 File Offset: 0x00852917
	public bool IsInNavigationInputType()
	{
		return TsLguiEventSystemActor.InputType == ELGUIPointerInputType.Navigation;
	}

	// Token: 0x0601B24C RID: 111180 RVA: 0x00854724 File Offset: 0x00852924
	private void RegisterPointEnterExitEvent()
	{
		if (Info.Instance.IsPcOrGamepadPlatform())
		{
			ULGUIEventSystem eventSystem = base.EventSystem;
			if (eventSystem == null)
			{
				return;
			}
			FLGUIPointerEnterExit_DynamicDelegate flguipointerEnterExit_DynamicDelegate = DelegateUtils.ToManualReleaseDelegate<FLGUIPointerEnterExit_DynamicDelegate>(new Action<bool>(CursorController.Instance.CursorEnterExit));
			eventSystem.RegisterPointerEnterExitEvent(flguipointerEnterExit_DynamicDelegate);
		}
	}

	// Token: 0x0601B24D RID: 111181 RVA: 0x00854765 File Offset: 0x00852965
	private void UnRegisterPointEnterExitEvent()
	{
		if (Info.Instance.IsPcOrGamepadPlatform())
		{
			ULGUIEventSystem eventSystem = base.EventSystem;
			if (eventSystem != null)
			{
				eventSystem.UnRegisterPointerEnterExitEvent();
			}
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<bool>(CursorController.Instance.CursorEnterExit));
		}
	}

	// Token: 0x0601B24E RID: 111182 RVA: 0x00854799 File Offset: 0x00852999
	private void BroadCastInputType()
	{
		TsLguiEventSystemActor.InputType = base.EventSystem.defaultInputType;
		CSharpScript.Game.Common.Event.EventSystem.Instance.Emit<ELGUIPointerInputType>(EEventName.PointerInputTypeChange, base.EventSystem.defaultInputType);
	}

	// Token: 0x0601B24F RID: 111183 RVA: 0x008547C6 File Offset: 0x008529C6
	private static void ChangeController(ELGUIPointerInputType type)
	{
		TsLguiEventSystemActor.InputType = type;
		if (type == ELGUIPointerInputType.Pointer)
		{
			Info.Instance.SwitchInputControllerType(EInputControllerType.Keyboard, "MouseMove");
		}
		CSharpScript.Game.Common.Event.EventSystem.Instance.Emit<ELGUIPointerInputType>(EEventName.PointerInputTypeChange, type);
	}

	// Token: 0x0601B250 RID: 111184 RVA: 0x008547F2 File Offset: 0x008529F2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B251 RID: 111185 RVA: 0x008547F4 File Offset: 0x008529F4
	public static void ResetStaticDefaultValue()
	{
		TsLguiEventSystemActor.InputType = ELGUIPointerInputType.None;
	}

	// Token: 0x0601B252 RID: 111186 RVA: 0x008547FC File Offset: 0x008529FC
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsLguiEventSystemActor._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Ui/LguiEventSystem/TsLguiEventSystemActor.TsLguiEventSystemActor_C");
		}
		return TsLguiEventSystemActor._ClassPtr;
	}

	// Token: 0x0601B253 RID: 111187 RVA: 0x00854820 File Offset: 0x00852A20
	public TsLguiEventSystemActor() : this(BuiltinUtils.AllocNativeUObject(TsLguiEventSystemActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601B254 RID: 111188 RVA: 0x00854848 File Offset: 0x00852A48
	[NullableContext(1)]
	public TsLguiEventSystemActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsLguiEventSystemActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601B255 RID: 111189 RVA: 0x0085487B File Offset: 0x00852A7B
	protected TsLguiEventSystemActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601B256 RID: 111190 RVA: 0x008548A8 File Offset: 0x00852AA8
	protected unsafe virtual void __CPPCALL_InputTrigger_Implementation(TsLguiEventSystemActor.__InputTrigger_FunctionParams* __Params)
	{
		EMouseButtonType mouseButtonType = (EMouseButtonType)__Params->mouseButtonType;
		this.InputTrigger_Implementation(__Params->triggerPress, mouseButtonType);
	}

	// Token: 0x0601B257 RID: 111191 RVA: 0x008548CC File Offset: 0x00852ACC
	protected unsafe virtual void __CPPCALL_InputNavigation_Implementation(TsLguiEventSystemActor.__InputNavigation_FunctionParams* __Params)
	{
		ELGUINavigationDirection direction = (ELGUINavigationDirection)__Params->direction;
		this.InputNavigation_Implementation(direction, __Params->pressOrRelease, __Params->forceNavigation);
	}

	// Token: 0x0601B258 RID: 111192 RVA: 0x008548F3 File Offset: 0x00852AF3
	protected unsafe virtual void __CPPCALL_InputTriggerForNavigation_Implementation(TsLguiEventSystemActor.__InputTriggerForNavigation_FunctionParams* __Params)
	{
		this.InputTriggerForNavigation_Implementation(__Params->triggerPress);
	}

	// Token: 0x0601B259 RID: 111193 RVA: 0x00854901 File Offset: 0x00852B01
	protected unsafe virtual void __CPPCALL_InputScroll_Implementation(TsLguiEventSystemActor.__InputScroll_FunctionParams* __Params)
	{
		this.InputScroll_Implementation(__Params->axisValue);
	}

	// Token: 0x0601B25A RID: 111194 RVA: 0x0085490F File Offset: 0x00852B0F
	protected unsafe virtual void __CPPCALL_InputTouchTrigger_Implementation(TsLguiEventSystemActor.__InputTouchTrigger_FunctionParams* __Params)
	{
		this.InputTouchTrigger_Implementation(__Params->touchPress, __Params->touchId, __Params->touchPointPosition);
	}

	// Token: 0x0601B25B RID: 111195 RVA: 0x00854929 File Offset: 0x00852B29
	protected unsafe virtual void __CPPCALL_InputTouchMove_Implementation(TsLguiEventSystemActor.__InputTouchMove_FunctionParams* __Params)
	{
		this.InputTouchMove_Implementation(__Params->touchId, __Params->touchPointPosition);
	}

	// Token: 0x0601B25C RID: 111196 RVA: 0x0085493D File Offset: 0x00852B3D
	protected unsafe virtual void __CPPCALL_GetNowHitComponent_Implementation(TsLguiEventSystemActor.__GetNowHitComponent_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		UUIItem nowHitComponent_Implementation = this.GetNowHitComponent_Implementation();
		ptr = ((nowHitComponent_Implementation != null) ? nowHitComponent_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601B25D RID: 111197 RVA: 0x0085495A File Offset: 0x00852B5A
	protected unsafe virtual void __CPPCALL_GetPointerEventData_Implementation(TsLguiEventSystemActor.__GetPointerEventData_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		ULGUIPointerEventData pointerEventData_Implementation = this.GetPointerEventData_Implementation(__Params->pointerId, __Params->createIfNotExist);
		ptr = ((pointerEventData_Implementation != null) ? pointerEventData_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601B25E RID: 111198 RVA: 0x00854984 File Offset: 0x00852B84
	protected unsafe virtual void __CPPCALL_IsPointerEventDataLineTrace_Implementation(TsLguiEventSystemActor.__IsPointerEventDataLineTrace_FunctionParams* __Params)
	{
		ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(__Params->pointerEventData);
		__Params->__Result = this.IsPointerEventDataLineTrace_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601B25F RID: 111199 RVA: 0x008549AC File Offset: 0x00852BAC
	protected unsafe virtual void __CPPCALL_SetClickThresholdWithInputKeyType_Implementation(TsLguiEventSystemActor.__SetClickThresholdWithInputKeyType_FunctionParams* __Params)
	{
		EInputKeyType inputKeyType = (EInputKeyType)__Params->inputKeyType;
		this.SetClickThresholdWithInputKeyType_Implementation(inputKeyType);
	}

	// Token: 0x0400EBBE RID: 60350
	[Nullable(2)]
	private FLGUIDelegateHandleWrapper HandleWrapper;

	// Token: 0x0400EBBF RID: 60351
	private static ELGUIPointerInputType InputType;

	// Token: 0x0400EBC0 RID: 60352
	[Nullable(1)]
	private Action<EOperationType, EOperationType> ShowTypeChange;

	// Token: 0x0400EBC1 RID: 60353
	[Nullable(1)]
	private Action<bool, int, int> ControllerConnectChange;

	// Token: 0x0400EBC2 RID: 60354
	private readonly float TouchClickThreshold = 10f;

	// Token: 0x0400EBC3 RID: 60355
	private readonly float MouseClickThreshold = 5f;

	// Token: 0x0400EBC4 RID: 60356
	private readonly float GamepadClickThreshold = 5f;

	// Token: 0x0400EBC5 RID: 60357
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Ui/LguiEventSystem/TsLguiEventSystemActor.TsLguiEventSystemActor_C";

	// Token: 0x0400EBC6 RID: 60358
	private static IntPtr _ClassPtr;

	// Token: 0x0400EBC7 RID: 60359
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400EBC8 RID: 60360
	private static int __PropertyOffset_StandaloneInputModule;

	// Token: 0x0400EBC9 RID: 60361
	private static int __PropertyOffset_TouchInputModule;

	// Token: 0x0400EBCA RID: 60362
	private static int __PropertyOffset_NavigationEnable;

	// Token: 0x02008A4A RID: 35402
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 2)]
	protected ref struct __InputTrigger_FunctionParams
	{
		// Token: 0x0402BEE4 RID: 179940
		[FieldOffset(0)]
		public bool triggerPress;

		// Token: 0x0402BEE5 RID: 179941
		[FieldOffset(1)]
		public byte mouseButtonType;
	}

	// Token: 0x02008A4B RID: 35403
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 3)]
	protected ref struct __InputNavigation_FunctionParams
	{
		// Token: 0x0402BEE6 RID: 179942
		[FieldOffset(0)]
		public byte direction;

		// Token: 0x0402BEE7 RID: 179943
		[FieldOffset(1)]
		public bool pressOrRelease;

		// Token: 0x0402BEE8 RID: 179944
		[FieldOffset(2)]
		public bool forceNavigation;
	}

	// Token: 0x02008A4C RID: 35404
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __InputTriggerForNavigation_FunctionParams
	{
		// Token: 0x0402BEE9 RID: 179945
		[FieldOffset(0)]
		public bool triggerPress;
	}

	// Token: 0x02008A4D RID: 35405
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __InputScroll_FunctionParams
	{
		// Token: 0x0402BEEA RID: 179946
		[FieldOffset(0)]
		public float axisValue;
	}

	// Token: 0x02008A4E RID: 35406
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 20)]
	protected ref struct __InputTouchTrigger_FunctionParams
	{
		// Token: 0x0402BEEB RID: 179947
		[FieldOffset(0)]
		public bool touchPress;

		// Token: 0x0402BEEC RID: 179948
		[FieldOffset(4)]
		public int touchId;

		// Token: 0x0402BEED RID: 179949
		[FieldOffset(8)]
		public FVector touchPointPosition;
	}

	// Token: 0x02008A4F RID: 35407
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __InputTouchMove_FunctionParams
	{
		// Token: 0x0402BEEE RID: 179950
		[FieldOffset(0)]
		public int touchId;

		// Token: 0x0402BEEF RID: 179951
		[FieldOffset(4)]
		public FVector touchPointPosition;
	}

	// Token: 0x02008A50 RID: 35408
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __GetNowHitComponent_FunctionParams
	{
		// Token: 0x0402BEF0 RID: 179952
		[FieldOffset(0)]
		public IntPtr __Result;
	}

	// Token: 0x02008A51 RID: 35409
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetPointerEventData_FunctionParams
	{
		// Token: 0x0402BEF1 RID: 179953
		[FieldOffset(0)]
		public float pointerId;

		// Token: 0x0402BEF2 RID: 179954
		[FieldOffset(4)]
		public bool createIfNotExist;

		// Token: 0x0402BEF3 RID: 179955
		[FieldOffset(8)]
		public IntPtr __Result;
	}

	// Token: 0x02008A52 RID: 35410
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __IsPointerEventDataLineTrace_FunctionParams
	{
		// Token: 0x0402BEF4 RID: 179956
		[FieldOffset(0)]
		public IntPtr pointerEventData;

		// Token: 0x0402BEF5 RID: 179957
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x02008A53 RID: 35411
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __SetClickThresholdWithInputKeyType_FunctionParams
	{
		// Token: 0x0402BEF6 RID: 179958
		[FieldOffset(0)]
		public byte inputKeyType;
	}

	// Token: 0x02008A54 RID: 35412
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402BEF7 RID: 179959
		public static Action<ELGUIPointerInputType> <0>__ChangeController;
	}
}
