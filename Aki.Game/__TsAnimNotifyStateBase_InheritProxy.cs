using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036FE RID: 14078
public class __TsAnimNotifyStateBase_InheritProxy : TsAnimNotifyStateBase
{
	// Token: 0x0601E4AF RID: 124079 RVA: 0x00888BEC File Offset: 0x00886DEC
	[NullableContext(1)]
	public __TsAnimNotifyStateBase_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E4B0 RID: 124080 RVA: 0x00888C1F File Offset: 0x00886E1F
	protected __TsAnimNotifyStateBase_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E4B1 RID: 124081 RVA: 0x00888C28 File Offset: 0x00886E28
	protected unsafe override void __CPPCALL_K2_NotifyBeginConditionCheck_Implementation(UKuroAnimNotifyState.__K2_NotifyBeginConditionCheck_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_NotifyBeginConditionCheck(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0601E4B2 RID: 124082 RVA: 0x00888C64 File Offset: 0x00886E64
	protected unsafe override void __CPPCALL_K2_NotifyTickConditionCheck_Implementation(UKuroAnimNotifyState.__K2_NotifyTickConditionCheck_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_NotifyTickConditionCheck(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x0601E4B3 RID: 124083 RVA: 0x00888CA0 File Offset: 0x00886EA0
	protected unsafe override void __CPPCALL_K2_NotifyEndConditionCheck_Implementation(UKuroAnimNotifyState.__K2_NotifyEndConditionCheck_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_NotifyEndConditionCheck(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
