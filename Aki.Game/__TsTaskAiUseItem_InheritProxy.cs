using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200364C RID: 13900
public class __TsTaskAiUseItem_InheritProxy : TsTaskAiUseItem
{
	// Token: 0x0601E244 RID: 123460 RVA: 0x0088242C File Offset: 0x0088062C
	[NullableContext(1)]
	public __TsTaskAiUseItem_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAiUseItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E245 RID: 123461 RVA: 0x0088245F File Offset: 0x0088065F
	protected __TsTaskAiUseItem_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E246 RID: 123462 RVA: 0x00882468 File Offset: 0x00880668
	protected override void __CPPCALL_InitTsVariables_Implementation()
	{
		base.InitTsVariables_Implementation();
	}

	// Token: 0x0601E247 RID: 123463 RVA: 0x00882470 File Offset: 0x00880670
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
