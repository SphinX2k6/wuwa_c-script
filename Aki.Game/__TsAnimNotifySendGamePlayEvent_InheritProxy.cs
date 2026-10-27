using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003858 RID: 14424
public class __TsAnimNotifySendGamePlayEvent_InheritProxy : TsAnimNotifySendGamePlayEvent
{
	// Token: 0x0601E937 RID: 125239 RVA: 0x00892BDC File Offset: 0x00890DDC
	[NullableContext(1)]
	public __TsAnimNotifySendGamePlayEvent_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySendGamePlayEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E938 RID: 125240 RVA: 0x00892C0F File Offset: 0x00890E0F
	protected __TsAnimNotifySendGamePlayEvent_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E939 RID: 125241 RVA: 0x00892C18 File Offset: 0x00890E18
	protected unsafe override void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601E93A RID: 125242 RVA: 0x00892C4B File Offset: 0x00890E4B
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetNotifyName_Implementation());
	}
}
