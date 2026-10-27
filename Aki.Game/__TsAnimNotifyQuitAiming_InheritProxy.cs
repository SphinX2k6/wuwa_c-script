using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003842 RID: 14402
public class __TsAnimNotifyQuitAiming_InheritProxy : TsAnimNotifyQuitAiming
{
	// Token: 0x0601E8F6 RID: 125174 RVA: 0x008923D0 File Offset: 0x008905D0
	[NullableContext(1)]
	public __TsAnimNotifyQuitAiming_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyQuitAiming.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E8F7 RID: 125175 RVA: 0x00892403 File Offset: 0x00890603
	protected __TsAnimNotifyQuitAiming_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E8F8 RID: 125176 RVA: 0x0089240C File Offset: 0x0089060C
	protected unsafe override void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601E8F9 RID: 125177 RVA: 0x0089243F File Offset: 0x0089063F
	protected unsafe override void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetNotifyName_Implementation());
	}
}
