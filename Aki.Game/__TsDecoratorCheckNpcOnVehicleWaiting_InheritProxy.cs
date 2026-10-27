using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003578 RID: 13688
public class __TsDecoratorCheckNpcOnVehicleWaiting_InheritProxy : TsDecoratorCheckNpcOnVehicleWaiting
{
	// Token: 0x0601E016 RID: 122902 RVA: 0x0087D7CC File Offset: 0x0087B9CC
	[NullableContext(1)]
	public __TsDecoratorCheckNpcOnVehicleWaiting_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckNpcOnVehicleWaiting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E017 RID: 122903 RVA: 0x0087D7FF File Offset: 0x0087B9FF
	protected __TsDecoratorCheckNpcOnVehicleWaiting_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E018 RID: 122904 RVA: 0x0087D808 File Offset: 0x0087BA08
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
