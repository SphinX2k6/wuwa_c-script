using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200356A RID: 13674
public class __TsDecoratorIsInCasketElementalField_InheritProxy : TsDecoratorIsInCasketElementalField
{
	// Token: 0x0601DFF3 RID: 122867 RVA: 0x0087D318 File Offset: 0x0087B518
	[NullableContext(1)]
	public __TsDecoratorIsInCasketElementalField_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorIsInCasketElementalField.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601DFF4 RID: 122868 RVA: 0x0087D34B File Offset: 0x0087B54B
	protected __TsDecoratorIsInCasketElementalField_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601DFF5 RID: 122869 RVA: 0x0087D354 File Offset: 0x0087B554
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
