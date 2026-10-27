using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035B6 RID: 13750
public class __TsDecoratorCheckMoveStuck_InheritProxy : TsDecoratorCheckMoveStuck
{
	// Token: 0x0601E0B1 RID: 123057 RVA: 0x0087ECA0 File Offset: 0x0087CEA0
	[NullableContext(1)]
	public __TsDecoratorCheckMoveStuck_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckMoveStuck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E0B2 RID: 123058 RVA: 0x0087ECD3 File Offset: 0x0087CED3
	protected __TsDecoratorCheckMoveStuck_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E0B3 RID: 123059 RVA: 0x0087ECDC File Offset: 0x0087CEDC
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601E0B4 RID: 123060 RVA: 0x0087ED10 File Offset: 0x0087CF10
	protected unsafe override void __CPPCALL_ReceiveExecutionFinishAI_Implementation(UBTDecorator_BlueprintBase.__ReceiveExecutionFinishAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		EBTNodeResult nodeResult = __Params->NodeResult;
		base.ReceiveExecutionFinishAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, nodeResult);
	}

	// Token: 0x0601E0B5 RID: 123061 RVA: 0x0087ED4C File Offset: 0x0087CF4C
	protected unsafe override void __CPPCALL_ReceiveObserverDeactivatedAI_Implementation(UBTDecorator_BlueprintBase.__ReceiveObserverDeactivatedAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveObserverDeactivatedAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
