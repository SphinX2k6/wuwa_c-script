using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E61 RID: 11873
public class __AnimNotifyWuWaGoAttackHit_InheritProxy : AnimNotifyWuWaGoAttackHit
{
	// Token: 0x0601C7FF RID: 116735 RVA: 0x008BC1C8 File Offset: 0x008BA3C8
	[NullableContext(1)]
	public __AnimNotifyWuWaGoAttackHit_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyWuWaGoAttackHit.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C800 RID: 116736 RVA: 0x008BC1FB File Offset: 0x008BA3FB
	protected __AnimNotifyWuWaGoAttackHit_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C801 RID: 116737 RVA: 0x008BC204 File Offset: 0x008BA404
	protected unsafe override void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
