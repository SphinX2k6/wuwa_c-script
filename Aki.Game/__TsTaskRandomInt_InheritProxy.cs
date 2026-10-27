using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036A8 RID: 13992
public class __TsTaskRandomInt_InheritProxy : TsTaskRandomInt
{
	// Token: 0x0601E352 RID: 123730 RVA: 0x00884BA0 File Offset: 0x00882DA0
	[NullableContext(1)]
	public __TsTaskRandomInt_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskRandomInt.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E353 RID: 123731 RVA: 0x00884BD3 File Offset: 0x00882DD3
	protected __TsTaskRandomInt_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E354 RID: 123732 RVA: 0x00884BDC File Offset: 0x00882DDC
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
