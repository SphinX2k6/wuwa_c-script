using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003580 RID: 13696
public class __TsDecoratorCheckVehicleWaiting_InheritProxy : TsDecoratorCheckVehicleWaiting
{
	// Token: 0x0601E02A RID: 122922 RVA: 0x0087DA7C File Offset: 0x0087BC7C
	[NullableContext(1)]
	public __TsDecoratorCheckVehicleWaiting_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckVehicleWaiting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E02B RID: 122923 RVA: 0x0087DAAF File Offset: 0x0087BCAF
	protected __TsDecoratorCheckVehicleWaiting_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E02C RID: 122924 RVA: 0x0087DAB8 File Offset: 0x0087BCB8
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
