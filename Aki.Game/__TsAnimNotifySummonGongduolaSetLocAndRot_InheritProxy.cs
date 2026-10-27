using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200386A RID: 14442
public class __TsAnimNotifySummonGongduolaSetLocAndRot_InheritProxy : TsAnimNotifySummonGongduolaSetLocAndRot
{
	// Token: 0x0601E96D RID: 125293 RVA: 0x0089329C File Offset: 0x0089149C
	[NullableContext(1)]
	public __TsAnimNotifySummonGongduolaSetLocAndRot_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySummonGongduolaSetLocAndRot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E96E RID: 125294 RVA: 0x008932CF File Offset: 0x008914CF
	protected __TsAnimNotifySummonGongduolaSetLocAndRot_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E96F RID: 125295 RVA: 0x008932D8 File Offset: 0x008914D8
	protected unsafe override void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
