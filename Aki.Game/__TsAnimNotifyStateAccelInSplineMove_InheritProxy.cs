using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036E6 RID: 14054
public class __TsAnimNotifyStateAccelInSplineMove_InheritProxy : TsAnimNotifyStateAccelInSplineMove
{
	// Token: 0x0601E458 RID: 123992 RVA: 0x00887F40 File Offset: 0x00886140
	[NullableContext(1)]
	public __TsAnimNotifyStateAccelInSplineMove_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAccelInSplineMove.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E459 RID: 123993 RVA: 0x00887F73 File Offset: 0x00886173
	protected __TsAnimNotifyStateAccelInSplineMove_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E45A RID: 123994 RVA: 0x00887F7C File Offset: 0x0088617C
	protected unsafe override void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x0601E45B RID: 123995 RVA: 0x00887FB8 File Offset: 0x008861B8
	protected unsafe override void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = base.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
