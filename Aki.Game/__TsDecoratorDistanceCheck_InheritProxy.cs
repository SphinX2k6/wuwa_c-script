using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003582 RID: 13698
public class __TsDecoratorDistanceCheck_InheritProxy : TsDecoratorDistanceCheck
{
	// Token: 0x0601E02F RID: 122927 RVA: 0x0087DB28 File Offset: 0x0087BD28
	[NullableContext(1)]
	public __TsDecoratorDistanceCheck_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorDistanceCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E030 RID: 122928 RVA: 0x0087DB5B File Offset: 0x0087BD5B
	protected __TsDecoratorDistanceCheck_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E031 RID: 122929 RVA: 0x0087DB64 File Offset: 0x0087BD64
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
