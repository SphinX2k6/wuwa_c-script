using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039C4 RID: 14788
public class __TsLguiEventSystemActor_InheritProxy : TsLguiEventSystemActor
{
	// Token: 0x0601EEF3 RID: 126707 RVA: 0x008A2DEC File Offset: 0x008A0FEC
	[NullableContext(1)]
	public __TsLguiEventSystemActor_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsLguiEventSystemActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EEF4 RID: 126708 RVA: 0x008A2E1F File Offset: 0x008A101F
	protected __TsLguiEventSystemActor_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EEF5 RID: 126709 RVA: 0x008A2E28 File Offset: 0x008A1028
	protected unsafe override void __CPPCALL_InputTrigger_Implementation(TsLguiEventSystemActor.__InputTrigger_FunctionParams* __Params)
	{
		EMouseButtonType mouseButtonType = (EMouseButtonType)__Params->mouseButtonType;
		base.InputTrigger_Implementation(__Params->triggerPress, mouseButtonType);
	}

	// Token: 0x0601EEF6 RID: 126710 RVA: 0x008A2E4C File Offset: 0x008A104C
	protected unsafe override void __CPPCALL_InputNavigation_Implementation(TsLguiEventSystemActor.__InputNavigation_FunctionParams* __Params)
	{
		ELGUINavigationDirection direction = (ELGUINavigationDirection)__Params->direction;
		base.InputNavigation_Implementation(direction, __Params->pressOrRelease, __Params->forceNavigation);
	}

	// Token: 0x0601EEF7 RID: 126711 RVA: 0x008A2E73 File Offset: 0x008A1073
	protected unsafe override void __CPPCALL_InputTriggerForNavigation_Implementation(TsLguiEventSystemActor.__InputTriggerForNavigation_FunctionParams* __Params)
	{
		base.InputTriggerForNavigation_Implementation(__Params->triggerPress);
	}

	// Token: 0x0601EEF8 RID: 126712 RVA: 0x008A2E81 File Offset: 0x008A1081
	protected unsafe override void __CPPCALL_InputScroll_Implementation(TsLguiEventSystemActor.__InputScroll_FunctionParams* __Params)
	{
		base.InputScroll_Implementation(__Params->axisValue);
	}

	// Token: 0x0601EEF9 RID: 126713 RVA: 0x008A2E8F File Offset: 0x008A108F
	protected unsafe override void __CPPCALL_InputTouchTrigger_Implementation(TsLguiEventSystemActor.__InputTouchTrigger_FunctionParams* __Params)
	{
		base.InputTouchTrigger_Implementation(__Params->touchPress, __Params->touchId, __Params->touchPointPosition);
	}

	// Token: 0x0601EEFA RID: 126714 RVA: 0x008A2EA9 File Offset: 0x008A10A9
	protected unsafe override void __CPPCALL_InputTouchMove_Implementation(TsLguiEventSystemActor.__InputTouchMove_FunctionParams* __Params)
	{
		base.InputTouchMove_Implementation(__Params->touchId, __Params->touchPointPosition);
	}

	// Token: 0x0601EEFB RID: 126715 RVA: 0x008A2EBD File Offset: 0x008A10BD
	protected unsafe override void __CPPCALL_GetNowHitComponent_Implementation(TsLguiEventSystemActor.__GetNowHitComponent_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		UUIItem nowHitComponent_Implementation = base.GetNowHitComponent_Implementation();
		ptr = ((nowHitComponent_Implementation != null) ? nowHitComponent_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601EEFC RID: 126716 RVA: 0x008A2EDA File Offset: 0x008A10DA
	protected unsafe override void __CPPCALL_GetPointerEventData_Implementation(TsLguiEventSystemActor.__GetPointerEventData_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		ULGUIPointerEventData pointerEventData_Implementation = base.GetPointerEventData_Implementation(__Params->pointerId, __Params->createIfNotExist);
		ptr = ((pointerEventData_Implementation != null) ? pointerEventData_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601EEFD RID: 126717 RVA: 0x008A2F04 File Offset: 0x008A1104
	protected unsafe override void __CPPCALL_IsPointerEventDataLineTrace_Implementation(TsLguiEventSystemActor.__IsPointerEventDataLineTrace_FunctionParams* __Params)
	{
		ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(__Params->pointerEventData);
		__Params->__Result = base.IsPointerEventDataLineTrace_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601EEFE RID: 126718 RVA: 0x008A2F2C File Offset: 0x008A112C
	protected unsafe override void __CPPCALL_SetClickThresholdWithInputKeyType_Implementation(TsLguiEventSystemActor.__SetClickThresholdWithInputKeyType_FunctionParams* __Params)
	{
		EInputKeyType inputKeyType = (EInputKeyType)__Params->inputKeyType;
		base.SetClickThresholdWithInputKeyType_Implementation(inputKeyType);
	}
}
