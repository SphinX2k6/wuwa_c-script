using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039B6 RID: 14774
public class __AnimNotifyDaiyuAnimEnd_InheritProxy : AnimNotifyDaiyuAnimEnd
{
	// Token: 0x0601EE5D RID: 126557 RVA: 0x008A0BDC File Offset: 0x0089EDDC
	[NullableContext(1)]
	public __AnimNotifyDaiyuAnimEnd_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyDaiyuAnimEnd.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE5E RID: 126558 RVA: 0x008A0C0F File Offset: 0x0089EE0F
	protected __AnimNotifyDaiyuAnimEnd_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EE5F RID: 126559 RVA: 0x008A0C18 File Offset: 0x0089EE18
	protected unsafe override void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
