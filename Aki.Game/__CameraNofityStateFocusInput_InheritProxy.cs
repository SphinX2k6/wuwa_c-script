using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003888 RID: 14472
public class __CameraNofityStateFocusInput_InheritProxy : CameraNofityStateFocusInput
{
	// Token: 0x0601E9C3 RID: 125379 RVA: 0x00893D6C File Offset: 0x00891F6C
	[NullableContext(1)]
	public __CameraNofityStateFocusInput_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CameraNofityStateFocusInput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E9C4 RID: 125380 RVA: 0x00893D9F File Offset: 0x00891F9F
	protected __CameraNofityStateFocusInput_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E9C5 RID: 125381 RVA: 0x00893DA8 File Offset: 0x00891FA8
	protected unsafe override void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0601E9C6 RID: 125382 RVA: 0x00893DE4 File Offset: 0x00891FE4
	protected unsafe override void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601E9C7 RID: 125383 RVA: 0x00893E17 File Offset: 0x00892017
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetNotifyName_Implementation());
	}
}
