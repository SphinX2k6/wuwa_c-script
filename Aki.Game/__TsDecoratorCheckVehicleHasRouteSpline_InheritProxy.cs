using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200357C RID: 13692
public class __TsDecoratorCheckVehicleHasRouteSpline_InheritProxy : TsDecoratorCheckVehicleHasRouteSpline
{
	// Token: 0x0601E020 RID: 122912 RVA: 0x0087D924 File Offset: 0x0087BB24
	[NullableContext(1)]
	public __TsDecoratorCheckVehicleHasRouteSpline_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckVehicleHasRouteSpline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E021 RID: 122913 RVA: 0x0087D957 File Offset: 0x0087BB57
	protected __TsDecoratorCheckVehicleHasRouteSpline_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E022 RID: 122914 RVA: 0x0087D960 File Offset: 0x0087BB60
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
