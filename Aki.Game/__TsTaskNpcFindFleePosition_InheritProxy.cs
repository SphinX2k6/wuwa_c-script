using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003630 RID: 13872
public class __TsTaskNpcFindFleePosition_InheritProxy : TsTaskNpcFindFleePosition
{
	// Token: 0x0601E1F3 RID: 123379 RVA: 0x0088188C File Offset: 0x0087FA8C
	[NullableContext(1)]
	public __TsTaskNpcFindFleePosition_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcFindFleePosition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E1F4 RID: 123380 RVA: 0x008818BF File Offset: 0x0087FABF
	protected __TsTaskNpcFindFleePosition_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E1F5 RID: 123381 RVA: 0x008818C8 File Offset: 0x0087FAC8
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
