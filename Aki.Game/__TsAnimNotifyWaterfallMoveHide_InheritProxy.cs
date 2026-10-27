using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200387C RID: 14460
public class __TsAnimNotifyWaterfallMoveHide_InheritProxy : TsAnimNotifyWaterfallMoveHide
{
	// Token: 0x0601E9A1 RID: 125345 RVA: 0x00893934 File Offset: 0x00891B34
	[NullableContext(1)]
	public __TsAnimNotifyWaterfallMoveHide_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyWaterfallMoveHide.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E9A2 RID: 125346 RVA: 0x00893967 File Offset: 0x00891B67
	protected __TsAnimNotifyWaterfallMoveHide_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E9A3 RID: 125347 RVA: 0x00893970 File Offset: 0x00891B70
	protected unsafe override void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601E9A4 RID: 125348 RVA: 0x008939A3 File Offset: 0x00891BA3
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetNotifyName_Implementation());
	}
}
