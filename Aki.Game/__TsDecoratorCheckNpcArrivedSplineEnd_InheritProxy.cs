using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003574 RID: 13684
public class __TsDecoratorCheckNpcArrivedSplineEnd_InheritProxy : TsDecoratorCheckNpcArrivedSplineEnd
{
	// Token: 0x0601E00C RID: 122892 RVA: 0x0087D674 File Offset: 0x0087B874
	[NullableContext(1)]
	public __TsDecoratorCheckNpcArrivedSplineEnd_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckNpcArrivedSplineEnd.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E00D RID: 122893 RVA: 0x0087D6A7 File Offset: 0x0087B8A7
	protected __TsDecoratorCheckNpcArrivedSplineEnd_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E00E RID: 122894 RVA: 0x0087D6B0 File Offset: 0x0087B8B0
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
