using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002ADF RID: 10975
public class __TsDecoratorIsInCasketElementalField_InheritProxy : TsDecoratorIsInCasketElementalField
{
	// Token: 0x0601BD1B RID: 113947 RVA: 0x008A53AC File Offset: 0x008A35AC
	[NullableContext(1)]
	public __TsDecoratorIsInCasketElementalField_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorIsInCasketElementalField.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BD1C RID: 113948 RVA: 0x008A53DF File Offset: 0x008A35DF
	protected __TsDecoratorIsInCasketElementalField_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601BD1D RID: 113949 RVA: 0x008A53E8 File Offset: 0x008A35E8
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
