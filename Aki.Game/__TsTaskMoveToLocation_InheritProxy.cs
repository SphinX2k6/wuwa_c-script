using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003690 RID: 13968
public class __TsTaskMoveToLocation_InheritProxy : TsTaskMoveToLocation
{
	// Token: 0x0601E310 RID: 123664 RVA: 0x00884284 File Offset: 0x00882484
	[NullableContext(1)]
	public __TsTaskMoveToLocation_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskMoveToLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E311 RID: 123665 RVA: 0x008842B7 File Offset: 0x008824B7
	protected __TsTaskMoveToLocation_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E312 RID: 123666 RVA: 0x008842C0 File Offset: 0x008824C0
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601E313 RID: 123667 RVA: 0x008842F0 File Offset: 0x008824F0
	protected unsafe override void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}
}
