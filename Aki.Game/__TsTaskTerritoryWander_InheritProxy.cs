using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036CE RID: 14030
public class __TsTaskTerritoryWander_InheritProxy : TsTaskTerritoryWander
{
	// Token: 0x0601E3B4 RID: 123828 RVA: 0x008858C4 File Offset: 0x00883AC4
	[NullableContext(1)]
	public __TsTaskTerritoryWander_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTerritoryWander.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E3B5 RID: 123829 RVA: 0x008858F7 File Offset: 0x00883AF7
	protected __TsTaskTerritoryWander_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E3B6 RID: 123830 RVA: 0x00885900 File Offset: 0x00883B00
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601E3B7 RID: 123831 RVA: 0x00885930 File Offset: 0x00883B30
	protected unsafe override void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x0601E3B8 RID: 123832 RVA: 0x00885963 File Offset: 0x00883B63
	protected override void __CPPCALL_FindWanderLocation_Implementation()
	{
		base.FindWanderLocation_Implementation();
	}

	// Token: 0x0601E3B9 RID: 123833 RVA: 0x0088596B File Offset: 0x00883B6B
	protected override void __CPPCALL_FindWanderPath_Implementation()
	{
		base.FindWanderPath_Implementation();
	}

	// Token: 0x0601E3BA RID: 123834 RVA: 0x00885973 File Offset: 0x00883B73
	protected override void __CPPCALL_DebugDraw_Implementation()
	{
		base.DebugDraw_Implementation();
	}
}
