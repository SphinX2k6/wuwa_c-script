using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200396A RID: 14698
public class __AnimNotifyAddMaterialControllerDataGroup_InheritProxy : AnimNotifyAddMaterialControllerDataGroup
{
	// Token: 0x0601ED1F RID: 126239 RVA: 0x0089CD44 File Offset: 0x0089AF44
	[NullableContext(1)]
	public __AnimNotifyAddMaterialControllerDataGroup_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyAddMaterialControllerDataGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601ED20 RID: 126240 RVA: 0x0089CD77 File Offset: 0x0089AF77
	protected __AnimNotifyAddMaterialControllerDataGroup_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601ED21 RID: 126241 RVA: 0x0089CD80 File Offset: 0x0089AF80
	protected unsafe override void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601ED22 RID: 126242 RVA: 0x0089CDB3 File Offset: 0x0089AFB3
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetNotifyName_Implementation());
	}
}
