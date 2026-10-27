using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200397A RID: 14714
public class __AnimNotifyEffect_InheritProxy : AnimNotifyEffect
{
	// Token: 0x0601EDC4 RID: 126404 RVA: 0x0089F7B4 File Offset: 0x0089D9B4
	[NullableContext(1)]
	public __AnimNotifyEffect_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EDC5 RID: 126405 RVA: 0x0089F7E7 File Offset: 0x0089D9E7
	protected __AnimNotifyEffect_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EDC6 RID: 126406 RVA: 0x0089F7F0 File Offset: 0x0089D9F0
	protected unsafe override void __CPPCALL_K2_ValidateAssets_Implementation(UKuroAnimNotify.__K2_ValidateAssets_FunctionParams* __Params)
	{
		__Params->__Result = base.K2_ValidateAssets_Implementation();
	}

	// Token: 0x0601EDC7 RID: 126407 RVA: 0x0089F800 File Offset: 0x0089DA00
	protected unsafe override void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601EDC8 RID: 126408 RVA: 0x0089F833 File Offset: 0x0089DA33
	protected unsafe override void __CPPCALL_K2_PostChangeProperty_Implementation(UKuroAnimNotify.__K2_PostChangeProperty_FunctionParams* __Params)
	{
		__Params->__Result = base.K2_PostChangeProperty_Implementation(__Params->PropertyName);
	}

	// Token: 0x0601EDC9 RID: 126409 RVA: 0x0089F847 File Offset: 0x0089DA47
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetNotifyName_Implementation());
	}
}
