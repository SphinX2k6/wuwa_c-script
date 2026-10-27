using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003566 RID: 13670
public class __TsDecoratorCheckAnimalMoveRange_InheritProxy : TsDecoratorCheckAnimalMoveRange
{
	// Token: 0x0601DFE9 RID: 122857 RVA: 0x0087D1C0 File Offset: 0x0087B3C0
	[NullableContext(1)]
	public __TsDecoratorCheckAnimalMoveRange_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckAnimalMoveRange.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601DFEA RID: 122858 RVA: 0x0087D1F3 File Offset: 0x0087B3F3
	protected __TsDecoratorCheckAnimalMoveRange_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601DFEB RID: 122859 RVA: 0x0087D1FC File Offset: 0x0087B3FC
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
