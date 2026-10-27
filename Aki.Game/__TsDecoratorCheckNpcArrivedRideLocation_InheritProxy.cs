using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003572 RID: 13682
public class __TsDecoratorCheckNpcArrivedRideLocation_InheritProxy : TsDecoratorCheckNpcArrivedRideLocation
{
	// Token: 0x0601E007 RID: 122887 RVA: 0x0087D5C8 File Offset: 0x0087B7C8
	[NullableContext(1)]
	public __TsDecoratorCheckNpcArrivedRideLocation_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckNpcArrivedRideLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E008 RID: 122888 RVA: 0x0087D5FB File Offset: 0x0087B7FB
	protected __TsDecoratorCheckNpcArrivedRideLocation_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E009 RID: 122889 RVA: 0x0087D604 File Offset: 0x0087B804
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
