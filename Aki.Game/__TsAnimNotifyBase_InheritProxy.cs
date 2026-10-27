using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020037DA RID: 14298
public class __TsAnimNotifyBase_InheritProxy : TsAnimNotifyBase
{
	// Token: 0x0601E7BF RID: 124863 RVA: 0x0088FCE4 File Offset: 0x0088DEE4
	[NullableContext(1)]
	public __TsAnimNotifyBase_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E7C0 RID: 124864 RVA: 0x0088FD17 File Offset: 0x0088DF17
	protected __TsAnimNotifyBase_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E7C1 RID: 124865 RVA: 0x0088FD20 File Offset: 0x0088DF20
	protected unsafe override void __CPPCALL_K2_NotifyConditionCheck_Implementation(UKuroAnimNotify.__K2_NotifyConditionCheck_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_NotifyConditionCheck_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
