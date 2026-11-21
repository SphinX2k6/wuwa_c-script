using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B2B RID: 11051
public class __TsDecoratorCheckMoveStuck_InheritProxy : TsDecoratorCheckMoveStuck
{
	// Token: 0x0601BDD9 RID: 114137 RVA: 0x008A6D34 File Offset: 0x008A4F34
	[NullableContext(1)]
	public __TsDecoratorCheckMoveStuck_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckMoveStuck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BDDA RID: 114138 RVA: 0x008A6D67 File Offset: 0x008A4F67
	protected __TsDecoratorCheckMoveStuck_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601BDDB RID: 114139 RVA: 0x008A6D70 File Offset: 0x008A4F70
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601BDDC RID: 114140 RVA: 0x008A6DA4 File Offset: 0x008A4FA4
	protected unsafe override void __CPPCALL_ReceiveExecutionFinishAI_Implementation(UBTDecorator_BlueprintBase.__ReceiveExecutionFinishAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		EBTNodeResult nodeResult = __Params->NodeResult;
		base.ReceiveExecutionFinishAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, nodeResult);
	}

	// Token: 0x0601BDDD RID: 114141 RVA: 0x008A6DE0 File Offset: 0x008A4FE0
	protected unsafe override void __CPPCALL_ReceiveObserverDeactivatedAI_Implementation(UBTDecorator_BlueprintBase.__ReceiveObserverDeactivatedAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveObserverDeactivatedAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
