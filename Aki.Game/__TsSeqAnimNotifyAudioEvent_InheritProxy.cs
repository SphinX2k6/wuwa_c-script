using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003880 RID: 14464
public class __TsSeqAnimNotifyAudioEvent_InheritProxy : TsSeqAnimNotifyAudioEvent
{
	// Token: 0x0601E9AD RID: 125357 RVA: 0x00893AB4 File Offset: 0x00891CB4
	[NullableContext(1)]
	public __TsSeqAnimNotifyAudioEvent_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSeqAnimNotifyAudioEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E9AE RID: 125358 RVA: 0x00893AE7 File Offset: 0x00891CE7
	protected __TsSeqAnimNotifyAudioEvent_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E9AF RID: 125359 RVA: 0x00893AF0 File Offset: 0x00891CF0
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetNotifyName_Implementation());
	}

	// Token: 0x0601E9B0 RID: 125360 RVA: 0x00893B04 File Offset: 0x00891D04
	protected unsafe override void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
