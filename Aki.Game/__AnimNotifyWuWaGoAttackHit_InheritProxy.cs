using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038E8 RID: 14568
public class __AnimNotifyWuWaGoAttackHit_InheritProxy : AnimNotifyWuWaGoAttackHit
{
	// Token: 0x0601EB47 RID: 125767 RVA: 0x00897D24 File Offset: 0x00895F24
	[NullableContext(1)]
	public __AnimNotifyWuWaGoAttackHit_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyWuWaGoAttackHit.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EB48 RID: 125768 RVA: 0x00897D57 File Offset: 0x00895F57
	protected __AnimNotifyWuWaGoAttackHit_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EB49 RID: 125769 RVA: 0x00897D60 File Offset: 0x00895F60
	protected unsafe override void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
