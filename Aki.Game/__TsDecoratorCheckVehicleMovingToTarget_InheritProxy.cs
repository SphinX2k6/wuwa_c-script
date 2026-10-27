using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200357E RID: 13694
public class __TsDecoratorCheckVehicleMovingToTarget_InheritProxy : TsDecoratorCheckVehicleMovingToTarget
{
	// Token: 0x0601E025 RID: 122917 RVA: 0x0087D9D0 File Offset: 0x0087BBD0
	[NullableContext(1)]
	public __TsDecoratorCheckVehicleMovingToTarget_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckVehicleMovingToTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E026 RID: 122918 RVA: 0x0087DA03 File Offset: 0x0087BC03
	protected __TsDecoratorCheckVehicleMovingToTarget_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E027 RID: 122919 RVA: 0x0087DA0C File Offset: 0x0087BC0C
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
