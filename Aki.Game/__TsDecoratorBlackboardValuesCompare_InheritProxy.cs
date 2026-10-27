using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200356C RID: 13676
public class __TsDecoratorBlackboardValuesCompare_InheritProxy : TsDecoratorBlackboardValuesCompare
{
	// Token: 0x0601DFF8 RID: 122872 RVA: 0x0087D3C4 File Offset: 0x0087B5C4
	[NullableContext(1)]
	public __TsDecoratorBlackboardValuesCompare_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorBlackboardValuesCompare.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601DFF9 RID: 122873 RVA: 0x0087D3F7 File Offset: 0x0087B5F7
	protected __TsDecoratorBlackboardValuesCompare_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601DFFA RID: 122874 RVA: 0x0087D400 File Offset: 0x0087B600
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
