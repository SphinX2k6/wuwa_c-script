using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E33 RID: 11827
public class __AnimNotifyTriggerDeadEyeMode_InheritProxy : AnimNotifyTriggerDeadEyeMode
{
	// Token: 0x0601C764 RID: 116580 RVA: 0x008BB3C0 File Offset: 0x008B95C0
	[NullableContext(1)]
	public __AnimNotifyTriggerDeadEyeMode_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyTriggerDeadEyeMode.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C765 RID: 116581 RVA: 0x008BB3F3 File Offset: 0x008B95F3
	protected __AnimNotifyTriggerDeadEyeMode_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C766 RID: 116582 RVA: 0x008BB3FC File Offset: 0x008B95FC
	protected unsafe override void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
