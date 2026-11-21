using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002DE3 RID: 11747
public class __TsAnimNotifySummonGongduolaSetLocAndRot_InheritProxy : TsAnimNotifySummonGongduolaSetLocAndRot
{
	// Token: 0x0601C666 RID: 116326 RVA: 0x008B9698 File Offset: 0x008B7898
	[NullableContext(1)]
	public __TsAnimNotifySummonGongduolaSetLocAndRot_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySummonGongduolaSetLocAndRot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C667 RID: 116327 RVA: 0x008B96CB File Offset: 0x008B78CB
	protected __TsAnimNotifySummonGongduolaSetLocAndRot_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C668 RID: 116328 RVA: 0x008B96D4 File Offset: 0x008B78D4
	protected unsafe override void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
