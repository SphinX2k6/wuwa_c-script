using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200361E RID: 13854
public class __TsTaskPatrolWithEvents_InheritProxy : TsTaskPatrolWithEvents
{
	// Token: 0x0601E1C1 RID: 123329 RVA: 0x008811A0 File Offset: 0x0087F3A0
	[NullableContext(1)]
	public __TsTaskPatrolWithEvents_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPatrolWithEvents.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E1C2 RID: 123330 RVA: 0x008811D3 File Offset: 0x0087F3D3
	protected __TsTaskPatrolWithEvents_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E1C3 RID: 123331 RVA: 0x008811DC File Offset: 0x0087F3DC
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
