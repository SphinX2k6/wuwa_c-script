using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B87 RID: 11143
public class __TsTaskNpcDisableEntityLookAt_InheritProxy : TsTaskNpcDisableEntityLookAt
{
	// Token: 0x0601BEC8 RID: 114376 RVA: 0x008A8DA8 File Offset: 0x008A6FA8
	[NullableContext(1)]
	public __TsTaskNpcDisableEntityLookAt_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcDisableEntityLookAt.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BEC9 RID: 114377 RVA: 0x008A8DDB File Offset: 0x008A6FDB
	protected __TsTaskNpcDisableEntityLookAt_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601BECA RID: 114378 RVA: 0x008A8DE4 File Offset: 0x008A6FE4
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
