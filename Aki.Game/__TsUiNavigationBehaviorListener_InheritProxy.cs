using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E53 RID: 11859
public class __TsUiNavigationBehaviorListener_InheritProxy : TsUiNavigationBehaviorListener
{
	// Token: 0x0601C7C6 RID: 116678 RVA: 0x008BBD38 File Offset: 0x008B9F38
	[NullableContext(1)]
	public __TsUiNavigationBehaviorListener_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationBehaviorListener.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C7C7 RID: 116679 RVA: 0x008BBD6B File Offset: 0x008B9F6B
	protected __TsUiNavigationBehaviorListener_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C7C8 RID: 116680 RVA: 0x008BBD74 File Offset: 0x008B9F74
	protected override void __CPPCALL_AwakeBP_Implementation()
	{
		base.AwakeBP_Implementation();
	}

	// Token: 0x0601C7C9 RID: 116681 RVA: 0x008BBD7C File Offset: 0x008B9F7C
	protected override void __CPPCALL_StartBP_Implementation()
	{
		base.StartBP_Implementation();
	}

	// Token: 0x0601C7CA RID: 116682 RVA: 0x008BBD84 File Offset: 0x008B9F84
	protected unsafe override void __CPPCALL_OnNotifyNavigationEnterBP_Implementation(UUINavigationBehaviour.__OnNotifyNavigationEnterBP_FunctionParams* __Params)
	{
		ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(__Params->eventData);
		base.OnNotifyNavigationEnterBP_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C7CB RID: 116683 RVA: 0x008BBDA4 File Offset: 0x008B9FA4
	protected unsafe override void __CPPCALL_OnNotifyNavigationSelectBP_Implementation(UUINavigationBehaviour.__OnNotifyNavigationSelectBP_FunctionParams* __Params)
	{
		ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(__Params->eventData);
		base.OnNotifyNavigationSelectBP_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C7CC RID: 116684 RVA: 0x008BBDC4 File Offset: 0x008B9FC4
	protected unsafe override void __CPPCALL_OnCheckCanSetNavigationBP_Implementation(UUINavigationBehaviour.__OnCheckCanSetNavigationBP_FunctionParams* __Params)
	{
		__Params->__Result = base.OnCheckCanSetNavigationBP_Implementation();
	}

	// Token: 0x0601C7CD RID: 116685 RVA: 0x008BBDD2 File Offset: 0x008B9FD2
	protected unsafe override void __CPPCALL_OnCheckLoopScrollChangeNavigationBP_Implementation(UUINavigationBehaviour.__OnCheckLoopScrollChangeNavigationBP_FunctionParams* __Params)
	{
		__Params->__Result = base.OnCheckLoopScrollChangeNavigationBP_Implementation();
	}

	// Token: 0x0601C7CE RID: 116686 RVA: 0x008BBDE0 File Offset: 0x008B9FE0
	protected override void __CPPCALL_OnEnableBP_Implementation()
	{
		base.OnEnableBP_Implementation();
	}

	// Token: 0x0601C7CF RID: 116687 RVA: 0x008BBDE8 File Offset: 0x008B9FE8
	protected override void __CPPCALL_OnDisableBP_Implementation()
	{
		base.OnDisableBP_Implementation();
	}

	// Token: 0x0601C7D0 RID: 116688 RVA: 0x008BBDF0 File Offset: 0x008B9FF0
	protected override void __CPPCALL_OnNotifyInteractiveBP_Implementation()
	{
		base.OnNotifyInteractiveBP_Implementation();
	}

	// Token: 0x0601C7D1 RID: 116689 RVA: 0x008BBDF8 File Offset: 0x008B9FF8
	protected override void __CPPCALL_OnNotifyNotInteractiveBP_Implementation()
	{
		base.OnNotifyNotInteractiveBP_Implementation();
	}

	// Token: 0x0601C7D2 RID: 116690 RVA: 0x008BBE00 File Offset: 0x008BA000
	protected override void __CPPCALL_OnPreDestroyBP_Implementation()
	{
		base.OnPreDestroyBP_Implementation();
	}
}
