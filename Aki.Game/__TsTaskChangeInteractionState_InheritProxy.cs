using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200365C RID: 13916
public class __TsTaskChangeInteractionState_InheritProxy : TsTaskChangeInteractionState
{
	// Token: 0x0601E27E RID: 123518 RVA: 0x00882D94 File Offset: 0x00880F94
	[NullableContext(1)]
	public __TsTaskChangeInteractionState_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskChangeInteractionState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E27F RID: 123519 RVA: 0x00882DC7 File Offset: 0x00880FC7
	protected __TsTaskChangeInteractionState_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E280 RID: 123520 RVA: 0x00882DD0 File Offset: 0x00880FD0
	protected override void __CPPCALL_InitTsVariables_Implementation()
	{
		base.InitTsVariables_Implementation();
	}

	// Token: 0x0601E281 RID: 123521 RVA: 0x00882DD8 File Offset: 0x00880FD8
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
