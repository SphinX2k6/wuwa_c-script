using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003818 RID: 14360
public class __TsAnimNotifyDisableUiMotorSoarWing_InheritProxy : TsAnimNotifyDisableUiMotorSoarWing
{
	// Token: 0x0601E878 RID: 125048 RVA: 0x00891410 File Offset: 0x0088F610
	[NullableContext(1)]
	public __TsAnimNotifyDisableUiMotorSoarWing_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyDisableUiMotorSoarWing.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E879 RID: 125049 RVA: 0x00891443 File Offset: 0x0088F643
	protected __TsAnimNotifyDisableUiMotorSoarWing_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E87A RID: 125050 RVA: 0x0089144C File Offset: 0x0088F64C
	protected unsafe override void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_Notify(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601E87B RID: 125051 RVA: 0x0089147F File Offset: 0x0088F67F
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetNotifyName());
	}
}
