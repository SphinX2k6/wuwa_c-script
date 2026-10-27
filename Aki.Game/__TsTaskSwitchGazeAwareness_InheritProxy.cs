using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036C8 RID: 14024
public class __TsTaskSwitchGazeAwareness_InheritProxy : TsTaskSwitchGazeAwareness
{
	// Token: 0x0601E3A4 RID: 123812 RVA: 0x00885698 File Offset: 0x00883898
	[NullableContext(1)]
	public __TsTaskSwitchGazeAwareness_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSwitchGazeAwareness.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E3A5 RID: 123813 RVA: 0x008856CB File Offset: 0x008838CB
	protected __TsTaskSwitchGazeAwareness_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E3A6 RID: 123814 RVA: 0x008856D4 File Offset: 0x008838D4
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
