using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003612 RID: 13842
public class __TsTaskNpcDisableEntityLookAt_InheritProxy : TsTaskNpcDisableEntityLookAt
{
	// Token: 0x0601E1A0 RID: 123296 RVA: 0x00880D14 File Offset: 0x0087EF14
	[NullableContext(1)]
	public __TsTaskNpcDisableEntityLookAt_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcDisableEntityLookAt.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E1A1 RID: 123297 RVA: 0x00880D47 File Offset: 0x0087EF47
	protected __TsTaskNpcDisableEntityLookAt_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E1A2 RID: 123298 RVA: 0x00880D50 File Offset: 0x0087EF50
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
