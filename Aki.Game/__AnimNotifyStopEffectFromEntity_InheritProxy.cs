using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003984 RID: 14724
public class __AnimNotifyStopEffectFromEntity_InheritProxy : AnimNotifyStopEffectFromEntity
{
	// Token: 0x0601EDEC RID: 126444 RVA: 0x0089FCF4 File Offset: 0x0089DEF4
	[NullableContext(1)]
	public __AnimNotifyStopEffectFromEntity_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStopEffectFromEntity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EDED RID: 126445 RVA: 0x0089FD27 File Offset: 0x0089DF27
	protected __AnimNotifyStopEffectFromEntity_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EDEE RID: 126446 RVA: 0x0089FD30 File Offset: 0x0089DF30
	protected unsafe override void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
