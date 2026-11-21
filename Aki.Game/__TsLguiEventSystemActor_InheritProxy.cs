using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F3F RID: 12095
public class __TsLguiEventSystemActor_InheritProxy : TsLguiEventSystemActor
{
	// Token: 0x0601CADF RID: 117471 RVA: 0x008C0ED4 File Offset: 0x008BF0D4
	[NullableContext(1)]
	public __TsLguiEventSystemActor_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsLguiEventSystemActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CAE0 RID: 117472 RVA: 0x008C0F07 File Offset: 0x008BF107
	protected __TsLguiEventSystemActor_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601CAE1 RID: 117473 RVA: 0x008C0F10 File Offset: 0x008BF110
	protected unsafe override void __CPPCALL_InputTrigger_Implementation(TsLguiEventSystemActor.__InputTrigger_FunctionParams* __Params)
	{
		EMouseButtonType mouseButtonType = (EMouseButtonType)__Params->mouseButtonType;
		base.InputTrigger_Implementation(__Params->triggerPress, mouseButtonType);
	}

	// Token: 0x0601CAE2 RID: 117474 RVA: 0x008C0F34 File Offset: 0x008BF134
	protected unsafe override void __CPPCALL_InputNavigation_Implementation(TsLguiEventSystemActor.__InputNavigation_FunctionParams* __Params)
	{
		ELGUINavigationDirection direction = (ELGUINavigationDirection)__Params->direction;
		base.InputNavigation_Implementation(direction, __Params->pressOrRelease, __Params->forceNavigation);
	}

	// Token: 0x0601CAE3 RID: 117475 RVA: 0x008C0F5B File Offset: 0x008BF15B
	protected unsafe override void __CPPCALL_InputTriggerForNavigation_Implementation(TsLguiEventSystemActor.__InputTriggerForNavigation_FunctionParams* __Params)
	{
		base.InputTriggerForNavigation_Implementation(__Params->triggerPress);
	}

	// Token: 0x0601CAE4 RID: 117476 RVA: 0x008C0F69 File Offset: 0x008BF169
	protected unsafe override void __CPPCALL_InputScroll_Implementation(TsLguiEventSystemActor.__InputScroll_FunctionParams* __Params)
	{
		base.InputScroll_Implementation(__Params->axisValue);
	}

	// Token: 0x0601CAE5 RID: 117477 RVA: 0x008C0F77 File Offset: 0x008BF177
	protected unsafe override void __CPPCALL_InputTouchTrigger_Implementation(TsLguiEventSystemActor.__InputTouchTrigger_FunctionParams* __Params)
	{
		base.InputTouchTrigger_Implementation(__Params->touchPress, __Params->touchId, __Params->touchPointPosition);
	}

	// Token: 0x0601CAE6 RID: 117478 RVA: 0x008C0F91 File Offset: 0x008BF191
	protected unsafe override void __CPPCALL_InputTouchMove_Implementation(TsLguiEventSystemActor.__InputTouchMove_FunctionParams* __Params)
	{
		base.InputTouchMove_Implementation(__Params->touchId, __Params->touchPointPosition);
	}

	// Token: 0x0601CAE7 RID: 117479 RVA: 0x008C0FA5 File Offset: 0x008BF1A5
	protected unsafe override void __CPPCALL_GetNowHitComponent_Implementation(TsLguiEventSystemActor.__GetNowHitComponent_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		UUIItem nowHitComponent_Implementation = base.GetNowHitComponent_Implementation();
		ptr = ((nowHitComponent_Implementation != null) ? nowHitComponent_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601CAE8 RID: 117480 RVA: 0x008C0FC2 File Offset: 0x008BF1C2
	protected unsafe override void __CPPCALL_GetPointerEventData_Implementation(TsLguiEventSystemActor.__GetPointerEventData_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		ULGUIPointerEventData pointerEventData_Implementation = base.GetPointerEventData_Implementation(__Params->pointerId, __Params->createIfNotExist);
		ptr = ((pointerEventData_Implementation != null) ? pointerEventData_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601CAE9 RID: 117481 RVA: 0x008C0FEC File Offset: 0x008BF1EC
	protected unsafe override void __CPPCALL_IsPointerEventDataLineTrace_Implementation(TsLguiEventSystemActor.__IsPointerEventDataLineTrace_FunctionParams* __Params)
	{
		ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(__Params->pointerEventData);
		__Params->__Result = base.IsPointerEventDataLineTrace_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601CAEA RID: 117482 RVA: 0x008C1014 File Offset: 0x008BF214
	protected unsafe override void __CPPCALL_SetClickThresholdWithInputKeyType_Implementation(TsLguiEventSystemActor.__SetClickThresholdWithInputKeyType_FunctionParams* __Params)
	{
		EInputKeyType inputKeyType = (EInputKeyType)__Params->inputKeyType;
		base.SetClickThresholdWithInputKeyType_Implementation(inputKeyType);
	}
}
