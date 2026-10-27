using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003982 RID: 14722
public class __AnimNotifyStateTrail_InheritProxy : AnimNotifyStateTrail
{
	// Token: 0x0601EDE5 RID: 126437 RVA: 0x0089FBFC File Offset: 0x0089DDFC
	[NullableContext(1)]
	public __AnimNotifyStateTrail_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateTrail.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EDE6 RID: 126438 RVA: 0x0089FC2F File Offset: 0x0089DE2F
	protected __AnimNotifyStateTrail_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EDE7 RID: 126439 RVA: 0x0089FC38 File Offset: 0x0089DE38
	protected unsafe override void __CPPCALL_K2_ValidateAssets_Implementation(UKuroAnimNotifyState.__K2_ValidateAssets_FunctionParams* __Params)
	{
		__Params->__Result = base.K2_ValidateAssets_Implementation();
	}

	// Token: 0x0601EDE8 RID: 126440 RVA: 0x0089FC48 File Offset: 0x0089DE48
	protected unsafe override void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0601EDE9 RID: 126441 RVA: 0x0089FC84 File Offset: 0x0089DE84
	protected unsafe override void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
