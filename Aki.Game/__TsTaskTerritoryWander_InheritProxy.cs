using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C43 RID: 11331
public class __TsTaskTerritoryWander_InheritProxy : TsTaskTerritoryWander
{
	// Token: 0x0601C0CD RID: 114893 RVA: 0x008AD29C File Offset: 0x008AB49C
	[NullableContext(1)]
	public __TsTaskTerritoryWander_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTerritoryWander.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C0CE RID: 114894 RVA: 0x008AD2CF File Offset: 0x008AB4CF
	protected __TsTaskTerritoryWander_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C0CF RID: 114895 RVA: 0x008AD2D8 File Offset: 0x008AB4D8
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601C0D0 RID: 114896 RVA: 0x008AD308 File Offset: 0x008AB508
	protected unsafe override void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x0601C0D1 RID: 114897 RVA: 0x008AD33B File Offset: 0x008AB53B
	protected override void __CPPCALL_FindWanderLocation_Implementation()
	{
		base.FindWanderLocation_Implementation();
	}

	// Token: 0x0601C0D2 RID: 114898 RVA: 0x008AD343 File Offset: 0x008AB543
	protected override void __CPPCALL_FindWanderPath_Implementation()
	{
		base.FindWanderPath_Implementation();
	}

	// Token: 0x0601C0D3 RID: 114899 RVA: 0x008AD34B File Offset: 0x008AB54B
	protected override void __CPPCALL_DebugDraw_Implementation()
	{
		base.DebugDraw_Implementation();
	}
}
