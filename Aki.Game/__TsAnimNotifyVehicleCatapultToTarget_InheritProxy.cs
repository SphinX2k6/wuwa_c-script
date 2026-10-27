using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003878 RID: 14456
public class __TsAnimNotifyVehicleCatapultToTarget_InheritProxy : TsAnimNotifyVehicleCatapultToTarget
{
	// Token: 0x0601E995 RID: 125333 RVA: 0x008937B4 File Offset: 0x008919B4
	[NullableContext(1)]
	public __TsAnimNotifyVehicleCatapultToTarget_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyVehicleCatapultToTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E996 RID: 125334 RVA: 0x008937E7 File Offset: 0x008919E7
	protected __TsAnimNotifyVehicleCatapultToTarget_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E997 RID: 125335 RVA: 0x008937F0 File Offset: 0x008919F0
	protected unsafe override void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_Notify(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601E998 RID: 125336 RVA: 0x00893823 File Offset: 0x00891A23
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetNotifyName());
	}
}
