using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200397E RID: 14718
public class __AnimNotifyStateGhost_InheritProxy : AnimNotifyStateGhost
{
	// Token: 0x0601EDD6 RID: 126422 RVA: 0x0089F9F4 File Offset: 0x0089DBF4
	[NullableContext(1)]
	public __AnimNotifyStateGhost_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateGhost.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EDD7 RID: 126423 RVA: 0x0089FA27 File Offset: 0x0089DC27
	protected __AnimNotifyStateGhost_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EDD8 RID: 126424 RVA: 0x0089FA30 File Offset: 0x0089DC30
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetNotifyName_Implementation());
	}

	// Token: 0x0601EDD9 RID: 126425 RVA: 0x0089FA44 File Offset: 0x0089DC44
	protected unsafe override void __CPPCALL_K2_ValidateAssets_Implementation(UKuroAnimNotifyState.__K2_ValidateAssets_FunctionParams* __Params)
	{
		__Params->__Result = base.K2_ValidateAssets_Implementation();
	}

	// Token: 0x0601EDDA RID: 126426 RVA: 0x0089FA54 File Offset: 0x0089DC54
	protected unsafe override void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0601EDDB RID: 126427 RVA: 0x0089FA90 File Offset: 0x0089DC90
	protected unsafe override void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
