using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200397C RID: 14716
public class __AnimNotifyStateEffect_InheritProxy : AnimNotifyStateEffect
{
	// Token: 0x0601EDCC RID: 126412 RVA: 0x0089F898 File Offset: 0x0089DA98
	[NullableContext(1)]
	public __AnimNotifyStateEffect_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EDCD RID: 126413 RVA: 0x0089F8CB File Offset: 0x0089DACB
	protected __AnimNotifyStateEffect_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EDCE RID: 126414 RVA: 0x0089F8D4 File Offset: 0x0089DAD4
	protected unsafe override void __CPPCALL_K2_ValidateAssets_Implementation(UKuroAnimNotifyState.__K2_ValidateAssets_FunctionParams* __Params)
	{
		__Params->__Result = base.K2_ValidateAssets_Implementation();
	}

	// Token: 0x0601EDCF RID: 126415 RVA: 0x0089F8E4 File Offset: 0x0089DAE4
	protected unsafe override void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0601EDD0 RID: 126416 RVA: 0x0089F920 File Offset: 0x0089DB20
	protected unsafe override void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x0601EDD1 RID: 126417 RVA: 0x0089F95C File Offset: 0x0089DB5C
	protected unsafe override void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601EDD2 RID: 126418 RVA: 0x0089F98F File Offset: 0x0089DB8F
	protected unsafe override void __CPPCALL_K2_PostChangeProperty_Implementation(UKuroAnimNotifyState.__K2_PostChangeProperty_FunctionParams* __Params)
	{
		__Params->__Result = base.K2_PostChangeProperty_Implementation(__Params->PropertyName);
	}

	// Token: 0x0601EDD3 RID: 126419 RVA: 0x0089F9A3 File Offset: 0x0089DBA3
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetNotifyName_Implementation());
	}
}
