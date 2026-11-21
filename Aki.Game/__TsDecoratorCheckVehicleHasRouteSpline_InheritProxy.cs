using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002AF1 RID: 10993
public class __TsDecoratorCheckVehicleHasRouteSpline_InheritProxy : TsDecoratorCheckVehicleHasRouteSpline
{
	// Token: 0x0601BD48 RID: 113992 RVA: 0x008A59B8 File Offset: 0x008A3BB8
	[NullableContext(1)]
	public __TsDecoratorCheckVehicleHasRouteSpline_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckVehicleHasRouteSpline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BD49 RID: 113993 RVA: 0x008A59EB File Offset: 0x008A3BEB
	protected __TsDecoratorCheckVehicleHasRouteSpline_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601BD4A RID: 113994 RVA: 0x008A59F4 File Offset: 0x008A3BF4
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
