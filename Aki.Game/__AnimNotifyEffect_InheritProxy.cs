using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EF5 RID: 12021
public class __AnimNotifyEffect_InheritProxy : AnimNotifyEffect
{
	// Token: 0x0601C9F1 RID: 117233 RVA: 0x008BF670 File Offset: 0x008BD870
	[NullableContext(1)]
	public __AnimNotifyEffect_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C9F2 RID: 117234 RVA: 0x008BF6A3 File Offset: 0x008BD8A3
	protected __AnimNotifyEffect_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C9F3 RID: 117235 RVA: 0x008BF6AC File Offset: 0x008BD8AC
	protected unsafe override void __CPPCALL_K2_ValidateAssets_Implementation(UKuroAnimNotify.__K2_ValidateAssets_FunctionParams* __Params)
	{
		__Params->__Result = base.K2_ValidateAssets_Implementation();
	}

	// Token: 0x0601C9F4 RID: 117236 RVA: 0x008BF6BC File Offset: 0x008BD8BC
	protected unsafe override void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601C9F5 RID: 117237 RVA: 0x008BF6EF File Offset: 0x008BD8EF
	protected unsafe override void __CPPCALL_K2_PostChangeProperty_Implementation(UKuroAnimNotify.__K2_PostChangeProperty_FunctionParams* __Params)
	{
		__Params->__Result = base.K2_PostChangeProperty_Implementation(__Params->PropertyName);
	}

	// Token: 0x0601C9F6 RID: 117238 RVA: 0x008BF703 File Offset: 0x008BD903
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetNotifyName_Implementation());
	}
}
