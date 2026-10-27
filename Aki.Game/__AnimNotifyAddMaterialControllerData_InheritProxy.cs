using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003968 RID: 14696
public class __AnimNotifyAddMaterialControllerData_InheritProxy : AnimNotifyAddMaterialControllerData
{
	// Token: 0x0601ED19 RID: 126233 RVA: 0x0089CC84 File Offset: 0x0089AE84
	[NullableContext(1)]
	public __AnimNotifyAddMaterialControllerData_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddMaterialControllerData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601ED1A RID: 126234 RVA: 0x0089CCB7 File Offset: 0x0089AEB7
	protected __AnimNotifyAddMaterialControllerData_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601ED1B RID: 126235 RVA: 0x0089CCC0 File Offset: 0x0089AEC0
	protected unsafe override void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601ED1C RID: 126236 RVA: 0x0089CCF3 File Offset: 0x0089AEF3
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetNotifyName_Implementation());
	}
}
