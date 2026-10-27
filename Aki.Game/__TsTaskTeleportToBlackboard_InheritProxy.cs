using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036CC RID: 14028
public class __TsTaskTeleportToBlackboard_InheritProxy : TsTaskTeleportToBlackboard
{
	// Token: 0x0601E3AF RID: 123823 RVA: 0x0088581C File Offset: 0x00883A1C
	[NullableContext(1)]
	public __TsTaskTeleportToBlackboard_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTeleportToBlackboard.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E3B0 RID: 123824 RVA: 0x0088584F File Offset: 0x00883A4F
	protected __TsTaskTeleportToBlackboard_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E3B1 RID: 123825 RVA: 0x00885858 File Offset: 0x00883A58
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
