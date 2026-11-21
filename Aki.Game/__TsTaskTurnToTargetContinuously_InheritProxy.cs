using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C49 RID: 11337
public class __TsTaskTurnToTargetContinuously_InheritProxy : TsTaskTurnToTargetContinuously
{
	// Token: 0x0601C0E0 RID: 114912 RVA: 0x008AD4E8 File Offset: 0x008AB6E8
	[NullableContext(1)]
	public __TsTaskTurnToTargetContinuously_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTurnToTargetContinuously.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C0E1 RID: 114913 RVA: 0x008AD51B File Offset: 0x008AB71B
	protected __TsTaskTurnToTargetContinuously_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C0E2 RID: 114914 RVA: 0x008AD524 File Offset: 0x008AB724
	protected unsafe override void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}
}
