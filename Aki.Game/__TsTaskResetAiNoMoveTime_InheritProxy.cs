using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036AC RID: 13996
public class __TsTaskResetAiNoMoveTime_InheritProxy : TsTaskResetAiNoMoveTime
{
	// Token: 0x0601E35D RID: 123741 RVA: 0x00884D24 File Offset: 0x00882F24
	[NullableContext(1)]
	public __TsTaskResetAiNoMoveTime_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskResetAiNoMoveTime.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E35E RID: 123742 RVA: 0x00884D57 File Offset: 0x00882F57
	protected __TsTaskResetAiNoMoveTime_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E35F RID: 123743 RVA: 0x00884D60 File Offset: 0x00882F60
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
