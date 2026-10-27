using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003628 RID: 13864
public class __TsTaskFindNearestInteractiveTarget_InheritProxy : TsTaskFindNearestInteractiveTarget
{
	// Token: 0x0601E1DD RID: 123357 RVA: 0x00881584 File Offset: 0x0087F784
	[NullableContext(1)]
	public __TsTaskFindNearestInteractiveTarget_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskFindNearestInteractiveTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E1DE RID: 123358 RVA: 0x008815B7 File Offset: 0x0087F7B7
	protected __TsTaskFindNearestInteractiveTarget_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E1DF RID: 123359 RVA: 0x008815C0 File Offset: 0x0087F7C0
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
