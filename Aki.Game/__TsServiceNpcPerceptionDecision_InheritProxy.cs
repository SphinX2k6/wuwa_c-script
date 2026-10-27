using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035EC RID: 13804
public class __TsServiceNpcPerceptionDecision_InheritProxy : TsServiceNpcPerceptionDecision
{
	// Token: 0x0601E13B RID: 123195 RVA: 0x0087FF60 File Offset: 0x0087E160
	[NullableContext(1)]
	public __TsServiceNpcPerceptionDecision_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsServiceNpcPerceptionDecision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E13C RID: 123196 RVA: 0x0087FF93 File Offset: 0x0087E193
	protected __TsServiceNpcPerceptionDecision_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E13D RID: 123197 RVA: 0x0087FF9C File Offset: 0x0087E19C
	protected unsafe override void __CPPCALL_ReceiveTickAI_Implementation(UBTService_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}
}
