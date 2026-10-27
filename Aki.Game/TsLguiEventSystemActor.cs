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

// Token: 0x020034A0 RID: 13472
[UClass("/Game/Aki/TypeScript/Game/Ui/LguiEventSystem/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Ui/LguiEventSystem/TsLguiEventSystemActor.TsLguiEventSystemActor_C")]
public class TsLguiEventSystemActor : ALGUIEventSystemActor, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601D51C RID: 120092 RVA: 0x0082C9E2 File Offset: 0x0082ABE2
	static TsLguiEventSystemActor()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsLguiEventSystemActor.CreateStaticDefaultValue), new Action(TsLguiEventSystemActor.ResetStaticDefaultValue));
	}

	// Token: 0x170028B2 RID: 10418
	// (get) Token: 0x0601D51D RID: 120093 RVA: 0x0082CA01 File Offset: 0x0082AC01
	// (set) Token: 0x0601D51E RID: 120094 RVA: 0x0082CA15 File Offset: 0x0082AC15
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

	// Token: 0x170028B3 RID: 10419
	// (get) Token: 0x0601D51F RID: 120095 RVA: 0x0082CA2A File Offset: 0x0082AC2A
	// (set) Token: 0x0601D520 RID: 120096 RVA: 0x0082CA3E File Offset: 0x0082AC3E
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

	// Token: 0x170028B4 RID: 10420
	// (get) Token: 0x0601D521 RID: 120097 RVA: 0x0082CA53 File Offset: 0x0082AC53
	// (set) Token: 0x0601D522 RID: 120098 RVA: 0x0082CA5B File Offset: 0x0082AC5B
	[Nullable(2)]
	private ULGUI_PointerInputModule CurrentInputModule { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x170028B5 RID: 10421
	// (get) Token: 0x0601D523 RID: 120099 RVA: 0x0082CA64 File Offset: 0x0082AC64
	// (set) Token: 0x0601D524 RID: 120100 RVA: 0x0082CA74 File Offset: 0x0082AC74
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

	// Token: 0x0601D525 RID: 120101 RVA: 0x0082CA88 File Offset: 0x0082AC88
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

	// Token: 0x0601D526 RID: 120102 RVA: 0x0082CAF8 File Offset: 0x0082ACF8
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

	// Token: 0x0601D527 RID: 120103 RVA: 0x0082CB5D File Offset: 0x0082AD5D
	private void AddEvents()
	{
		this.ShowTypeChange = delegate(EOperationType last, EOperationType now)
		{
			this.RefreshCurrentInputModule();
		};
		CSharpScript.Game.Common.Event.EventSystem.Instance.Add<EOperationType, EOperationType>(EEventName.ShowTypeChange, this.ShowTypeChange);
	}

	// Token: 0x0601D528 RID: 120104 RVA: 0x0082CB87 File Offset: 0x0082AD87
	private void RemoveEvents()
	{
		CSharpScript.Game.Common.Event.EventSystem.Instance.Remove<EOperationType, EOperationType>(EEventName.ShowTypeChange, this.ShowTypeChange);
	}

	// Token: 0x0601D529 RID: 120105 RVA: 0x0082CBA0 File Offset: 0x0082ADA0
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

	// Token: 0x0601D52A RID: 120106 RVA: 0x0082CBED File Offset: 0x0082ADED
	private void UnRegisterControllerChange()
	{
		ULGUIEventSystem eventSystem = base.EventSystem;
		if (eventSystem == null)
		{
			return;
		}
		eventSystem.OnConnectionChanged.Remove(this.ControllerConnectChange);
	}

	// Token: 0x0601D52B RID: 120107 RVA: 0x0082CC0C File Offset: 0x0082AE0C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void InputTrigger(bool triggerPress, EMouseButtonType mouseButtonType)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("InputTrigger"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsLguiEventSystemActor.__InputTrigger_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsLguiEventSystemActor.__InputTrigger_FunctionParams*)ptr + 15L / (long)sizeof(TsLguiEventSystemActor.__InputTrigger_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->triggerPress = triggerPress;
			*(&ptr2->mouseButtonType) = (byte)mouseButtonType;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601D52C RID: 120108 RVA: 0x0082CC8C File Offset: 0x0082AE8C
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

	// Token: 0x0601D52D RID: 120109 RVA: 0x0082CCCC File Offset: 0x0082AECC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void InputNavigation(ELGUINavigationDirection direction, bool pressOrRelease, bool forceNavigation = false)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("InputNavigation"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsLguiEventSystemActor.__InputNavigation_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsLguiEventSystemActor.__InputNavigation_FunctionParams*)ptr + 15L / (long)sizeof(TsLguiEventSystemActor.__InputNavigation_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->direction) = (byte)direction;
			ptr2->pressOrRelease = pressOrRelease;
			ptr2->forceNavigation = forceNavigation;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601D52E RID: 120110 RVA: 0x0082CD52 File Offset: 0x0082AF52
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

	// Token: 0x0601D52F RID: 120111 RVA: 0x0082CD7C File Offset: 0x0082AF7C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void InputTriggerForNavigation(bool triggerPress)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("InputTriggerForNavigation"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsLguiEventSystemActor.__InputTriggerForNavigation_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsLguiEventSystemActor.__InputTriggerForNavigation_FunctionParams*)ptr + 15L / (long)sizeof(TsLguiEventSystemActor.__InputTriggerForNavigation_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->triggerPress = triggerPress;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601D530 RID: 120112 RVA: 0x0082CDF2 File Offset: 0x0082AFF2
	protected void InputTriggerForNavigation_Implementation(bool triggerPress)
	{
		if (this.CurrentInputModule == null)
		{
			return;
		}
		TsLguiEventSystemActor.InputType = ELGUIPointerInputType.Navigation;
		this.CurrentInputModule.InputTriggerForNavigation(triggerPress);
	}

	// Token: 0x0601D531 RID: 120113 RVA: 0x0082CE0F File Offset: 0x0082B00F
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

	// Token: 0x0601D532 RID: 120114 RVA: 0x0082CE34 File Offset: 0x0082B034
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void InputScroll(float axisValue)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("InputScroll"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsLguiEventSystemActor.__InputScroll_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsLguiEventSystemActor.__InputScroll_FunctionParams*)ptr + 15L / (long)sizeof(TsLguiEventSystemActor.__InputScroll_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->axisValue = axisValue;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601D533 RID: 120115 RVA: 0x0082CEAC File Offset: 0x0082B0AC
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

	// Token: 0x0601D534 RID: 120116 RVA: 0x0082CF0C File Offset: 0x0082B10C
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

	// Token: 0x0601D535 RID: 120117 RVA: 0x0082CF60 File Offset: 0x0082B160
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void InputTouchTrigger(bool touchPress, int touchId, FVector touchPointPosition)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("InputTouchTrigger"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsLguiEventSystemActor.__InputTouchTrigger_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsLguiEventSystemActor.__InputTouchTrigger_FunctionParams*)ptr + 15L / (long)sizeof(TsLguiEventSystemActor.__InputTouchTrigger_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->touchPress = touchPress;
			ptr2->touchId = touchId;
			ptr2->touchPointPosition = touchPointPosition;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601D536 RID: 120118 RVA: 0x0082CFE4 File Offset: 0x0082B1E4
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

	// Token: 0x0601D537 RID: 120119 RVA: 0x0082D028 File Offset: 0x0082B228
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void InputTouchMove(int touchId, FVector touchPointPosition)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("InputTouchMove"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsLguiEventSystemActor.__InputTouchMove_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsLguiEventSystemActor.__InputTouchMove_FunctionParams*)ptr + 15L / (long)sizeof(TsLguiEventSystemActor.__InputTouchMove_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->touchId = touchId;
			ptr2->touchPointPosition = touchPointPosition;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601D538 RID: 120120 RVA: 0x0082D0A8 File Offset: 0x0082B2A8
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

	// Token: 0x0601D539 RID: 120121 RVA: 0x0082D10F File Offset: 0x0082B30F
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

	// Token: 0x0601D53A RID: 120122 RVA: 0x0082D148 File Offset: 0x0082B348
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual UUIItem GetNowHitComponent()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNowHitComponent"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsLguiEventSystemActor.__GetNowHitComponent_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsLguiEventSystemActor.__GetNowHitComponent_FunctionParams*)ptr + 15L / (long)sizeof(TsLguiEventSystemActor.__GetNowHitComponent_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		UUIItem orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIItem>(ptr2->__Result);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return orCreateUObjectByNativePointer;
	}

	// Token: 0x0601D53B RID: 120123 RVA: 0x0082D1C2 File Offset: 0x0082B3C2
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

	// Token: 0x0601D53C RID: 120124 RVA: 0x0082D1D8 File Offset: 0x0082B3D8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual ULGUIPointerEventData GetPointerEventData(float pointerId, bool createIfNotExist = false)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetPointerEventData"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsLguiEventSystemActor.__GetPointerEventData_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsLguiEventSystemActor.__GetPointerEventData_FunctionParams*)ptr + 15L / (long)sizeof(TsLguiEventSystemActor.__GetPointerEventData_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->pointerId = pointerId;
			ptr2->createIfNotExist = createIfNotExist;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(ptr2->__Result);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return orCreateUObjectByNativePointer;
	}

	// Token: 0x0601D53D RID: 120125 RVA: 0x0082D260 File Offset: 0x0082B460
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

	// Token: 0x0601D53E RID: 120126 RVA: 0x0082D278 File Offset: 0x0082B478
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool IsPointerEventDataLineTrace(ULGUIPointerEventData pointerEventData)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("IsPointerEventDataLineTrace"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsLguiEventSystemActor.__IsPointerEventDataLineTrace_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsLguiEventSystemActor.__IsPointerEventDataLineTrace_FunctionParams*)ptr + 15L / (long)sizeof(TsLguiEventSystemActor.__IsPointerEventDataLineTrace_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->pointerEventData) = ((pointerEventData != null) ? pointerEventData.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601D53F RID: 120127 RVA: 0x0082D302 File Offset: 0x0082B502
	[NullableContext(1)]
	protected bool IsPointerEventDataLineTrace_Implementation(ULGUIPointerEventData pointerEventData)
	{
		return this.CurrentInputModule != null && !this.CurrentInputModule.IsPointerEventDataLineTrace(pointerEventData);
	}

	// Token: 0x0601D540 RID: 120128 RVA: 0x0082D320 File Offset: 0x0082B520
	[NullableContext(1)]
	public bool SimulateClickButton(int pointerId, UUIItem uiItem, FVector2D? pivot)
	{
		pivot = new FVector2D?(pivot ?? new FVector2D(0.5f, 0.5f));
		ULGUI_StandaloneInputModule standaloneInputModule = this.StandaloneInputModule;
		return standaloneInputModule != null && standaloneInputModule.SimulationLineTrace(pointerId, uiItem, pivot);
	}

	// Token: 0x0601D541 RID: 120129 RVA: 0x0082D36C File Offset: 0x0082B56C
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

	// Token: 0x0601D542 RID: 120130 RVA: 0x0082D397 File Offset: 0x0082B597
	public void SimulationPointerTrigger(int pointerId, bool isPress)
	{
		ULGUI_StandaloneInputModule standaloneInputModule = this.StandaloneInputModule;
		if (standaloneInputModule == null)
		{
			return;
		}
		standaloneInputModule.SimulationPointerTrigger(pointerId, isPress);
	}

	// Token: 0x0601D543 RID: 120131 RVA: 0x0082D3AB File Offset: 0x0082B5AB
	public void ResetNowIsTriggerPressed(int pointerId)
	{
		ULGUI_StandaloneInputModule standaloneInputModule = this.StandaloneInputModule;
		if (standaloneInputModule == null)
		{
			return;
		}
		standaloneInputModule.ResetNowIsTriggerPressed(pointerId);
	}

	// Token: 0x0601D544 RID: 120132 RVA: 0x0082D3BE File Offset: 0x0082B5BE
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

	// Token: 0x0601D545 RID: 120133 RVA: 0x0082D3D1 File Offset: 0x0082B5D1
	public void SetIsUseMouse(bool value)
	{
		ULGUI_StandaloneInputModule standaloneInputModule = this.StandaloneInputModule;
		if (standaloneInputModule == null)
		{
			return;
		}
		standaloneInputModule.SetIsForceChange(value);
	}

	// Token: 0x0601D546 RID: 120134 RVA: 0x0082D3E4 File Offset: 0x0082B5E4
	public void SetIsForceChange(bool value)
	{
		ULGUI_StandaloneInputModule standaloneInputModule = this.StandaloneInputModule;
		if (standaloneInputModule == null)
		{
			return;
		}
		standaloneInputModule.SetIsForceChange(value);
	}

	// Token: 0x0601D547 RID: 120135 RVA: 0x0082D3F8 File Offset: 0x0082B5F8
	public void SetPrevMousePosition(float x, float y)
	{
		ULGUIPointerEventData pointerEventData = this.GetPointerEventData(0f, true);
		if (pointerEventData != null)
		{
			pointerEventData.prevMousePos = new FVector2D(x, y);
		}
	}

	// Token: 0x0601D548 RID: 120136 RVA: 0x0082D422 File Offset: 0x0082B622
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

	// Token: 0x0601D549 RID: 120137 RVA: 0x0082D460 File Offset: 0x0082B660
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void SetClickThresholdWithInputKeyType(EInputKeyType inputKeyType)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetClickThresholdWithInputKeyType"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsLguiEventSystemActor.__SetClickThresholdWithInputKeyType_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsLguiEventSystemActor.__SetClickThresholdWithInputKeyType_FunctionParams*)ptr + 15L / (long)sizeof(TsLguiEventSystemActor.__SetClickThresholdWithInputKeyType_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->inputKeyType) = (byte)inputKeyType;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601D54A RID: 120138 RVA: 0x0082D4D8 File Offset: 0x0082B6D8
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

	// Token: 0x0601D54B RID: 120139 RVA: 0x0082D537 File Offset: 0x0082B737
	public void OverrideMousePosition(FVector2D vector2D)
	{
		ULGUI_StandaloneInputModule standaloneInputModule = this.StandaloneInputModule;
		if (standaloneInputModule == null)
		{
			return;
		}
		standaloneInputModule.InputOverrideMousePosition(vector2D);
	}

	// Token: 0x0601D54C RID: 120140 RVA: 0x0082D54B File Offset: 0x0082B74B
	public void SetIsOverrideMousePosition(bool value)
	{
		if (this.StandaloneInputModule != null)
		{
			this.StandaloneInputModule.bOverrideMousePosition = value;
		}
	}

	// Token: 0x0601D54D RID: 120141 RVA: 0x0082D561 File Offset: 0x0082B761
	public bool IsInPointerInputType()
	{
		return TsLguiEventSystemActor.InputType == ELGUIPointerInputType.Pointer;
	}

	// Token: 0x0601D54E RID: 120142 RVA: 0x0082D56B File Offset: 0x0082B76B
	public bool IsInNavigationInputType()
	{
		return TsLguiEventSystemActor.InputType == ELGUIPointerInputType.Navigation;
	}

	// Token: 0x0601D54F RID: 120143 RVA: 0x0082D578 File Offset: 0x0082B778
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

	// Token: 0x0601D550 RID: 120144 RVA: 0x0082D5B9 File Offset: 0x0082B7B9
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

	// Token: 0x0601D551 RID: 120145 RVA: 0x0082D5ED File Offset: 0x0082B7ED
	private void BroadCastInputType()
	{
		TsLguiEventSystemActor.InputType = base.EventSystem.defaultInputType;
		CSharpScript.Game.Common.Event.EventSystem.Instance.Emit<ELGUIPointerInputType>(EEventName.PointerInputTypeChange, base.EventSystem.defaultInputType);
	}

	// Token: 0x0601D552 RID: 120146 RVA: 0x0082D61A File Offset: 0x0082B81A
	private static void ChangeController(ELGUIPointerInputType type)
	{
		TsLguiEventSystemActor.InputType = type;
		if (type == ELGUIPointerInputType.Pointer)
		{
			Info.Instance.SwitchInputControllerType(EInputControllerType.Keyboard, "MouseMove");
		}
		CSharpScript.Game.Common.Event.EventSystem.Instance.Emit<ELGUIPointerInputType>(EEventName.PointerInputTypeChange, type);
	}

	// Token: 0x0601D553 RID: 120147 RVA: 0x0082D646 File Offset: 0x0082B846
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601D554 RID: 120148 RVA: 0x0082D648 File Offset: 0x0082B848
	public static void ResetStaticDefaultValue()
	{
		TsLguiEventSystemActor.InputType = ELGUIPointerInputType.None;
	}

	// Token: 0x0601D555 RID: 120149 RVA: 0x0082D650 File Offset: 0x0082B850
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsLguiEventSystemActor._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Ui/LguiEventSystem/TsLguiEventSystemActor.TsLguiEventSystemActor_C");
		}
		return TsLguiEventSystemActor._ClassPtr;
	}

	// Token: 0x0601D556 RID: 120150 RVA: 0x0082D674 File Offset: 0x0082B874
	public TsLguiEventSystemActor() : this(BuiltinUtils.AllocNativeUObject(TsLguiEventSystemActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D557 RID: 120151 RVA: 0x0082D69C File Offset: 0x0082B89C
	[NullableContext(1)]
	public TsLguiEventSystemActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsLguiEventSystemActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D558 RID: 120152 RVA: 0x0082D6CF File Offset: 0x0082B8CF
	protected TsLguiEventSystemActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601D559 RID: 120153 RVA: 0x0082D6FC File Offset: 0x0082B8FC
	protected unsafe virtual void __CPPCALL_InputTrigger_Implementation(TsLguiEventSystemActor.__InputTrigger_FunctionParams* __Params)
	{
		EMouseButtonType mouseButtonType = (EMouseButtonType)__Params->mouseButtonType;
		this.InputTrigger_Implementation(__Params->triggerPress, mouseButtonType);
	}

	// Token: 0x0601D55A RID: 120154 RVA: 0x0082D720 File Offset: 0x0082B920
	protected unsafe virtual void __CPPCALL_InputNavigation_Implementation(TsLguiEventSystemActor.__InputNavigation_FunctionParams* __Params)
	{
		ELGUINavigationDirection direction = (ELGUINavigationDirection)__Params->direction;
		this.InputNavigation_Implementation(direction, __Params->pressOrRelease, __Params->forceNavigation);
	}

	// Token: 0x0601D55B RID: 120155 RVA: 0x0082D747 File Offset: 0x0082B947
	protected unsafe virtual void __CPPCALL_InputTriggerForNavigation_Implementation(TsLguiEventSystemActor.__InputTriggerForNavigation_FunctionParams* __Params)
	{
		this.InputTriggerForNavigation_Implementation(__Params->triggerPress);
	}

	// Token: 0x0601D55C RID: 120156 RVA: 0x0082D755 File Offset: 0x0082B955
	protected unsafe virtual void __CPPCALL_InputScroll_Implementation(TsLguiEventSystemActor.__InputScroll_FunctionParams* __Params)
	{
		this.InputScroll_Implementation(__Params->axisValue);
	}

	// Token: 0x0601D55D RID: 120157 RVA: 0x0082D763 File Offset: 0x0082B963
	protected unsafe virtual void __CPPCALL_InputTouchTrigger_Implementation(TsLguiEventSystemActor.__InputTouchTrigger_FunctionParams* __Params)
	{
		this.InputTouchTrigger_Implementation(__Params->touchPress, __Params->touchId, __Params->touchPointPosition);
	}

	// Token: 0x0601D55E RID: 120158 RVA: 0x0082D77D File Offset: 0x0082B97D
	protected unsafe virtual void __CPPCALL_InputTouchMove_Implementation(TsLguiEventSystemActor.__InputTouchMove_FunctionParams* __Params)
	{
		this.InputTouchMove_Implementation(__Params->touchId, __Params->touchPointPosition);
	}

	// Token: 0x0601D55F RID: 120159 RVA: 0x0082D791 File Offset: 0x0082B991
	protected unsafe virtual void __CPPCALL_GetNowHitComponent_Implementation(TsLguiEventSystemActor.__GetNowHitComponent_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		UUIItem nowHitComponent_Implementation = this.GetNowHitComponent_Implementation();
		ptr = ((nowHitComponent_Implementation != null) ? nowHitComponent_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601D560 RID: 120160 RVA: 0x0082D7AE File Offset: 0x0082B9AE
	protected unsafe virtual void __CPPCALL_GetPointerEventData_Implementation(TsLguiEventSystemActor.__GetPointerEventData_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		ULGUIPointerEventData pointerEventData_Implementation = this.GetPointerEventData_Implementation(__Params->pointerId, __Params->createIfNotExist);
		ptr = ((pointerEventData_Implementation != null) ? pointerEventData_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601D561 RID: 120161 RVA: 0x0082D7D8 File Offset: 0x0082B9D8
	protected unsafe virtual void __CPPCALL_IsPointerEventDataLineTrace_Implementation(TsLguiEventSystemActor.__IsPointerEventDataLineTrace_FunctionParams* __Params)
	{
		ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(__Params->pointerEventData);
		__Params->__Result = this.IsPointerEventDataLineTrace_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601D562 RID: 120162 RVA: 0x0082D800 File Offset: 0x0082BA00
	protected unsafe virtual void __CPPCALL_SetClickThresholdWithInputKeyType_Implementation(TsLguiEventSystemActor.__SetClickThresholdWithInputKeyType_FunctionParams* __Params)
	{
		EInputKeyType inputKeyType = (EInputKeyType)__Params->inputKeyType;
		this.SetClickThresholdWithInputKeyType_Implementation(inputKeyType);
	}

	// Token: 0x0400E70A RID: 59146
	[Nullable(2)]
	private FLGUIDelegateHandleWrapper HandleWrapper;

	// Token: 0x0400E70B RID: 59147
	private static ELGUIPointerInputType InputType;

	// Token: 0x0400E70C RID: 59148
	[Nullable(1)]
	private Action<EOperationType, EOperationType> ShowTypeChange;

	// Token: 0x0400E70D RID: 59149
	[Nullable(1)]
	private Action<bool, int, int> ControllerConnectChange;

	// Token: 0x0400E70E RID: 59150
	private readonly float TouchClickThreshold = 10f;

	// Token: 0x0400E70F RID: 59151
	private readonly float MouseClickThreshold = 5f;

	// Token: 0x0400E710 RID: 59152
	private readonly float GamepadClickThreshold = 5f;

	// Token: 0x0400E711 RID: 59153
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Ui/LguiEventSystem/TsLguiEventSystemActor.TsLguiEventSystemActor_C";

	// Token: 0x0400E712 RID: 59154
	private static IntPtr _ClassPtr;

	// Token: 0x0400E713 RID: 59155
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E714 RID: 59156
	private static int __PropertyOffset_StandaloneInputModule;

	// Token: 0x0400E715 RID: 59157
	private static int __PropertyOffset_TouchInputModule;

	// Token: 0x0400E716 RID: 59158
	private static int __PropertyOffset_NavigationEnable;

	// Token: 0x02009826 RID: 38950
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 2)]
	protected ref struct __InputTrigger_FunctionParams
	{
		// Token: 0x04030854 RID: 198740
		[FieldOffset(0)]
		public bool triggerPress;

		// Token: 0x04030855 RID: 198741
		[FieldOffset(1)]
		public byte mouseButtonType;
	}

	// Token: 0x02009827 RID: 38951
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 3)]
	protected ref struct __InputNavigation_FunctionParams
	{
		// Token: 0x04030856 RID: 198742
		[FieldOffset(0)]
		public byte direction;

		// Token: 0x04030857 RID: 198743
		[FieldOffset(1)]
		public bool pressOrRelease;

		// Token: 0x04030858 RID: 198744
		[FieldOffset(2)]
		public bool forceNavigation;
	}

	// Token: 0x02009828 RID: 38952
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __InputTriggerForNavigation_FunctionParams
	{
		// Token: 0x04030859 RID: 198745
		[FieldOffset(0)]
		public bool triggerPress;
	}

	// Token: 0x02009829 RID: 38953
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __InputScroll_FunctionParams
	{
		// Token: 0x0403085A RID: 198746
		[FieldOffset(0)]
		public float axisValue;
	}

	// Token: 0x0200982A RID: 38954
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 20)]
	protected ref struct __InputTouchTrigger_FunctionParams
	{
		// Token: 0x0403085B RID: 198747
		[FieldOffset(0)]
		public bool touchPress;

		// Token: 0x0403085C RID: 198748
		[FieldOffset(4)]
		public int touchId;

		// Token: 0x0403085D RID: 198749
		[FieldOffset(8)]
		public FVector touchPointPosition;
	}

	// Token: 0x0200982B RID: 38955
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __InputTouchMove_FunctionParams
	{
		// Token: 0x0403085E RID: 198750
		[FieldOffset(0)]
		public int touchId;

		// Token: 0x0403085F RID: 198751
		[FieldOffset(4)]
		public FVector touchPointPosition;
	}

	// Token: 0x0200982C RID: 38956
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __GetNowHitComponent_FunctionParams
	{
		// Token: 0x04030860 RID: 198752
		[FieldOffset(0)]
		public IntPtr __Result;
	}

	// Token: 0x0200982D RID: 38957
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetPointerEventData_FunctionParams
	{
		// Token: 0x04030861 RID: 198753
		[FieldOffset(0)]
		public float pointerId;

		// Token: 0x04030862 RID: 198754
		[FieldOffset(4)]
		public bool createIfNotExist;

		// Token: 0x04030863 RID: 198755
		[FieldOffset(8)]
		public IntPtr __Result;
	}

	// Token: 0x0200982E RID: 38958
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __IsPointerEventDataLineTrace_FunctionParams
	{
		// Token: 0x04030864 RID: 198756
		[FieldOffset(0)]
		public IntPtr pointerEventData;

		// Token: 0x04030865 RID: 198757
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x0200982F RID: 38959
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __SetClickThresholdWithInputKeyType_FunctionParams
	{
		// Token: 0x04030866 RID: 198758
		[FieldOffset(0)]
		public byte inputKeyType;
	}

	// Token: 0x02009830 RID: 38960
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04030867 RID: 198759
		public static Action<ELGUIPointerInputType> <0>__ChangeController;
	}
}
