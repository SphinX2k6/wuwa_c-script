using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C01 RID: 11265
public class __TsTaskLookForVisionDisplayTarget_InheritProxy : TsTaskLookForVisionDisplayTarget
{
	// Token: 0x0601C01E RID: 114718 RVA: 0x008ABAD4 File Offset: 0x008A9CD4
	[NullableContext(1)]
	public __TsTaskLookForVisionDisplayTarget_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskLookForVisionDisplayTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C01F RID: 114719 RVA: 0x008ABB07 File Offset: 0x008A9D07
	protected __TsTaskLookForVisionDisplayTarget_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C020 RID: 114720 RVA: 0x008ABB10 File Offset: 0x008A9D10
	protected unsafe override void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}
}
