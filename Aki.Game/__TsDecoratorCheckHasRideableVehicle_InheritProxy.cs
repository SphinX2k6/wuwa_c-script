using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003570 RID: 13680
public class __TsDecoratorCheckHasRideableVehicle_InheritProxy : TsDecoratorCheckHasRideableVehicle
{
	// Token: 0x0601E002 RID: 122882 RVA: 0x0087D51C File Offset: 0x0087B71C
	[NullableContext(1)]
	public __TsDecoratorCheckHasRideableVehicle_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckHasRideableVehicle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E003 RID: 122883 RVA: 0x0087D54F File Offset: 0x0087B74F
	protected __TsDecoratorCheckHasRideableVehicle_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E004 RID: 122884 RVA: 0x0087D558 File Offset: 0x0087B758
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
