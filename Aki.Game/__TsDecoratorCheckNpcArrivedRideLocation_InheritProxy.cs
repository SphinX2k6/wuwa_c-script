using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002AE7 RID: 10983
public class __TsDecoratorCheckNpcArrivedRideLocation_InheritProxy : TsDecoratorCheckNpcArrivedRideLocation
{
	// Token: 0x0601BD2F RID: 113967 RVA: 0x008A565C File Offset: 0x008A385C
	[NullableContext(1)]
	public __TsDecoratorCheckNpcArrivedRideLocation_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckNpcArrivedRideLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BD30 RID: 113968 RVA: 0x008A568F File Offset: 0x008A388F
	protected __TsDecoratorCheckNpcArrivedRideLocation_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601BD31 RID: 113969 RVA: 0x008A5698 File Offset: 0x008A3898
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
