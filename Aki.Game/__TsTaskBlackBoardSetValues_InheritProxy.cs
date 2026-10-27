using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003658 RID: 13912
public class __TsTaskBlackBoardSetValues_InheritProxy : TsTaskBlackBoardSetValues
{
	// Token: 0x0601E272 RID: 123506 RVA: 0x00882BCC File Offset: 0x00880DCC
	[NullableContext(1)]
	public __TsTaskBlackBoardSetValues_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskBlackBoardSetValues.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E273 RID: 123507 RVA: 0x00882BFF File Offset: 0x00880DFF
	protected __TsTaskBlackBoardSetValues_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E274 RID: 123508 RVA: 0x00882C08 File Offset: 0x00880E08
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
