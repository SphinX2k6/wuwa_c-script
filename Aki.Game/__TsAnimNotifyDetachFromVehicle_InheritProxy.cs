using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003810 RID: 14352
public class __TsAnimNotifyDetachFromVehicle_InheritProxy : TsAnimNotifyDetachFromVehicle
{
	// Token: 0x0601E860 RID: 125024 RVA: 0x00891110 File Offset: 0x0088F310
	[NullableContext(1)]
	public __TsAnimNotifyDetachFromVehicle_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDetachFromVehicle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E861 RID: 125025 RVA: 0x00891143 File Offset: 0x0088F343
	protected __TsAnimNotifyDetachFromVehicle_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E862 RID: 125026 RVA: 0x0089114C File Offset: 0x0088F34C
	protected unsafe override void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601E863 RID: 125027 RVA: 0x0089117F File Offset: 0x0088F37F
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetNotifyName_Implementation());
	}
}
