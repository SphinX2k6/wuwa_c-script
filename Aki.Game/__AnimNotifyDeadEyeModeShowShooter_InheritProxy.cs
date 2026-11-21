using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E31 RID: 11825
public class __AnimNotifyDeadEyeModeShowShooter_InheritProxy : AnimNotifyDeadEyeModeShowShooter
{
	// Token: 0x0601C75F RID: 116575 RVA: 0x008BB314 File Offset: 0x008B9514
	[NullableContext(1)]
	public __AnimNotifyDeadEyeModeShowShooter_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyDeadEyeModeShowShooter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C760 RID: 116576 RVA: 0x008BB347 File Offset: 0x008B9547
	protected __AnimNotifyDeadEyeModeShowShooter_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C761 RID: 116577 RVA: 0x008BB350 File Offset: 0x008B9550
	protected unsafe override void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
