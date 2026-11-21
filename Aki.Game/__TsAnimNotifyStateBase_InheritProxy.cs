using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C73 RID: 11379
public class __TsAnimNotifyStateBase_InheritProxy : TsAnimNotifyStateBase
{
	// Token: 0x0601C198 RID: 115096 RVA: 0x008AED78 File Offset: 0x008ACF78
	[NullableContext(1)]
	public __TsAnimNotifyStateBase_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C199 RID: 115097 RVA: 0x008AEDAB File Offset: 0x008ACFAB
	protected __TsAnimNotifyStateBase_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C19A RID: 115098 RVA: 0x008AEDB4 File Offset: 0x008ACFB4
	protected unsafe override void __CPPCALL_K2_NotifyBeginConditionCheck_Implementation(UKuroAnimNotifyState.__K2_NotifyBeginConditionCheck_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_NotifyBeginConditionCheck(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0601C19B RID: 115099 RVA: 0x008AEDF0 File Offset: 0x008ACFF0
	protected unsafe override void __CPPCALL_K2_NotifyTickConditionCheck_Implementation(UKuroAnimNotifyState.__K2_NotifyTickConditionCheck_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_NotifyTickConditionCheck(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x0601C19C RID: 115100 RVA: 0x008AEE2C File Offset: 0x008AD02C
	protected unsafe override void __CPPCALL_K2_NotifyEndConditionCheck_Implementation(UKuroAnimNotifyState.__K2_NotifyEndConditionCheck_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_NotifyEndConditionCheck(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
