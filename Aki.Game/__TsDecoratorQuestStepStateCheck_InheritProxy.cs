using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200358A RID: 13706
public class __TsDecoratorQuestStepStateCheck_InheritProxy : TsDecoratorQuestStepStateCheck
{
	// Token: 0x0601E043 RID: 122947 RVA: 0x0087DDD8 File Offset: 0x0087BFD8
	[NullableContext(1)]
	public __TsDecoratorQuestStepStateCheck_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorQuestStepStateCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E044 RID: 122948 RVA: 0x0087DE0B File Offset: 0x0087C00B
	protected __TsDecoratorQuestStepStateCheck_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E045 RID: 122949 RVA: 0x0087DE14 File Offset: 0x0087C014
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
