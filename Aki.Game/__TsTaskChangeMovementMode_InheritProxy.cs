using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200365E RID: 13918
public class __TsTaskChangeMovementMode_InheritProxy : TsTaskChangeMovementMode
{
	// Token: 0x0601E285 RID: 123525 RVA: 0x00882EB4 File Offset: 0x008810B4
	[NullableContext(1)]
	public __TsTaskChangeMovementMode_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskChangeMovementMode.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E286 RID: 123526 RVA: 0x00882EE7 File Offset: 0x008810E7
	protected __TsTaskChangeMovementMode_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E287 RID: 123527 RVA: 0x00882EF0 File Offset: 0x008810F0
	protected override void __CPPCALL_InitTsVariables_Implementation()
	{
		base.InitTsVariables_Implementation();
	}

	// Token: 0x0601E288 RID: 123528 RVA: 0x00882EF8 File Offset: 0x008810F8
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
