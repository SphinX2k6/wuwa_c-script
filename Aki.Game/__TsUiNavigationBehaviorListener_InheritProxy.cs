using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038DA RID: 14554
public class __TsUiNavigationBehaviorListener_InheritProxy : TsUiNavigationBehaviorListener
{
	// Token: 0x0601EB0E RID: 125710 RVA: 0x00897894 File Offset: 0x00895A94
	[NullableContext(1)]
	public __TsUiNavigationBehaviorListener_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsUiNavigationBehaviorListener.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB0F RID: 125711 RVA: 0x008978C7 File Offset: 0x00895AC7
	protected __TsUiNavigationBehaviorListener_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EB10 RID: 125712 RVA: 0x008978D0 File Offset: 0x00895AD0
	protected override void __CPPCALL_AwakeBP_Implementation()
	{
		base.AwakeBP_Implementation();
	}

	// Token: 0x0601EB11 RID: 125713 RVA: 0x008978D8 File Offset: 0x00895AD8
	protected override void __CPPCALL_StartBP_Implementation()
	{
		base.StartBP_Implementation();
	}

	// Token: 0x0601EB12 RID: 125714 RVA: 0x008978E0 File Offset: 0x00895AE0
	protected unsafe override void __CPPCALL_OnNotifyNavigationEnterBP_Implementation(UUINavigationBehaviour.__OnNotifyNavigationEnterBP_FunctionParams* __Params)
	{
		ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(__Params->eventData);
		base.OnNotifyNavigationEnterBP_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601EB13 RID: 125715 RVA: 0x00897900 File Offset: 0x00895B00
	protected unsafe override void __CPPCALL_OnNotifyNavigationSelectBP_Implementation(UUINavigationBehaviour.__OnNotifyNavigationSelectBP_FunctionParams* __Params)
	{
		ULGUIPointerEventData orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(__Params->eventData);
		base.OnNotifyNavigationSelectBP_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601EB14 RID: 125716 RVA: 0x00897920 File Offset: 0x00895B20
	protected unsafe override void __CPPCALL_OnCheckCanSetNavigationBP_Implementation(UUINavigationBehaviour.__OnCheckCanSetNavigationBP_FunctionParams* __Params)
	{
		__Params->__Result = base.OnCheckCanSetNavigationBP_Implementation();
	}

	// Token: 0x0601EB15 RID: 125717 RVA: 0x0089792E File Offset: 0x00895B2E
	protected unsafe override void __CPPCALL_OnCheckLoopScrollChangeNavigationBP_Implementation(UUINavigationBehaviour.__OnCheckLoopScrollChangeNavigationBP_FunctionParams* __Params)
	{
		__Params->__Result = base.OnCheckLoopScrollChangeNavigationBP_Implementation();
	}

	// Token: 0x0601EB16 RID: 125718 RVA: 0x0089793C File Offset: 0x00895B3C
	protected override void __CPPCALL_OnEnableBP_Implementation()
	{
		base.OnEnableBP_Implementation();
	}

	// Token: 0x0601EB17 RID: 125719 RVA: 0x00897944 File Offset: 0x00895B44
	protected override void __CPPCALL_OnDisableBP_Implementation()
	{
		base.OnDisableBP_Implementation();
	}

	// Token: 0x0601EB18 RID: 125720 RVA: 0x0089794C File Offset: 0x00895B4C
	protected override void __CPPCALL_OnNotifyInteractiveBP_Implementation()
	{
		base.OnNotifyInteractiveBP_Implementation();
	}

	// Token: 0x0601EB19 RID: 125721 RVA: 0x00897954 File Offset: 0x00895B54
	protected override void __CPPCALL_OnNotifyNotInteractiveBP_Implementation()
	{
		base.OnNotifyNotInteractiveBP_Implementation();
	}

	// Token: 0x0601EB1A RID: 125722 RVA: 0x0089795C File Offset: 0x00895B5C
	protected override void __CPPCALL_OnPreDestroyBP_Implementation()
	{
		base.OnPreDestroyBP_Implementation();
	}
}
