using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200365A RID: 13914
public class __TsTaskCalculateBackwardPosition_InheritProxy : TsTaskCalculateBackwardPosition
{
	// Token: 0x0601E277 RID: 123511 RVA: 0x00882C74 File Offset: 0x00880E74
	[NullableContext(1)]
	public __TsTaskCalculateBackwardPosition_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskCalculateBackwardPosition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E278 RID: 123512 RVA: 0x00882CA7 File Offset: 0x00880EA7
	protected __TsTaskCalculateBackwardPosition_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E279 RID: 123513 RVA: 0x00882CB0 File Offset: 0x00880EB0
	protected override void __CPPCALL_InitTsVariables_Implementation()
	{
		base.InitTsVariables_Implementation();
	}

	// Token: 0x0601E27A RID: 123514 RVA: 0x00882CB8 File Offset: 0x00880EB8
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
