using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035E8 RID: 13800
public class __TsDecoratorWeatherStateCheck_InheritProxy : TsDecoratorWeatherStateCheck
{
	// Token: 0x0601E130 RID: 123184 RVA: 0x0087FDD8 File Offset: 0x0087DFD8
	[NullableContext(1)]
	public __TsDecoratorWeatherStateCheck_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorWeatherStateCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E131 RID: 123185 RVA: 0x0087FE0B File Offset: 0x0087E00B
	protected __TsDecoratorWeatherStateCheck_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E132 RID: 123186 RVA: 0x0087FE14 File Offset: 0x0087E014
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
