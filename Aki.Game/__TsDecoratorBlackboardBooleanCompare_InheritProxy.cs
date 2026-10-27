using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200359C RID: 13724
public class __TsDecoratorBlackboardBooleanCompare_InheritProxy : TsDecoratorBlackboardBooleanCompare
{
	// Token: 0x0601E070 RID: 122992 RVA: 0x0087E3E4 File Offset: 0x0087C5E4
	[NullableContext(1)]
	public __TsDecoratorBlackboardBooleanCompare_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboardBooleanCompare.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E071 RID: 122993 RVA: 0x0087E417 File Offset: 0x0087C617
	protected __TsDecoratorBlackboardBooleanCompare_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E072 RID: 122994 RVA: 0x0087E420 File Offset: 0x0087C620
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
