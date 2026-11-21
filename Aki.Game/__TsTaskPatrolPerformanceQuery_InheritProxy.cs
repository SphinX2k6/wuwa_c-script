using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C0B RID: 11275
public class __TsTaskPatrolPerformanceQuery_InheritProxy : TsTaskPatrolPerformanceQuery
{
	// Token: 0x0601C03B RID: 114747 RVA: 0x008ABEF0 File Offset: 0x008AA0F0
	[NullableContext(1)]
	public __TsTaskPatrolPerformanceQuery_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPatrolPerformanceQuery.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C03C RID: 114748 RVA: 0x008ABF23 File Offset: 0x008AA123
	protected __TsTaskPatrolPerformanceQuery_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C03D RID: 114749 RVA: 0x008ABF2C File Offset: 0x008AA12C
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
