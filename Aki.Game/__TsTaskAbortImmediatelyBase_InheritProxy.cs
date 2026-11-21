using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002BB3 RID: 11187
public class __TsTaskAbortImmediatelyBase_InheritProxy : TsTaskAbortImmediatelyBase
{
	// Token: 0x0601BF42 RID: 114498 RVA: 0x008A9E88 File Offset: 0x008A8088
	[NullableContext(1)]
	public __TsTaskAbortImmediatelyBase_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAbortImmediatelyBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BF43 RID: 114499 RVA: 0x008A9EBB File Offset: 0x008A80BB
	protected __TsTaskAbortImmediatelyBase_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601BF44 RID: 114500 RVA: 0x008A9EC4 File Offset: 0x008A80C4
	protected unsafe override void __CPPCALL_ReceiveAbortAI_Implementation(UBTTask_BlueprintBase.__ReceiveAbortAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveAbortAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
