using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003672 RID: 13938
public class __TsTaskFindNearestWanderPoint_InheritProxy : TsTaskFindNearestWanderPoint
{
	// Token: 0x0601E2BD RID: 123581 RVA: 0x008836A0 File Offset: 0x008818A0
	[NullableContext(1)]
	public __TsTaskFindNearestWanderPoint_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskFindNearestWanderPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E2BE RID: 123582 RVA: 0x008836D3 File Offset: 0x008818D3
	protected __TsTaskFindNearestWanderPoint_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E2BF RID: 123583 RVA: 0x008836DC File Offset: 0x008818DC
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
