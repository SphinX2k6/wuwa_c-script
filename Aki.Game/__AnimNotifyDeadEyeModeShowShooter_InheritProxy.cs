using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038B8 RID: 14520
public class __AnimNotifyDeadEyeModeShowShooter_InheritProxy : AnimNotifyDeadEyeModeShowShooter
{
	// Token: 0x0601EA92 RID: 125586 RVA: 0x008964B8 File Offset: 0x008946B8
	[NullableContext(1)]
	public __AnimNotifyDeadEyeModeShowShooter_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyDeadEyeModeShowShooter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA93 RID: 125587 RVA: 0x008964EB File Offset: 0x008946EB
	protected __AnimNotifyDeadEyeModeShowShooter_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EA94 RID: 125588 RVA: 0x008964F4 File Offset: 0x008946F4
	protected unsafe override void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
