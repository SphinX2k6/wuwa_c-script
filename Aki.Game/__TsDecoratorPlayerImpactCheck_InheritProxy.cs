using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003594 RID: 13716
public class __TsDecoratorPlayerImpactCheck_InheritProxy : TsDecoratorPlayerImpactCheck
{
	// Token: 0x0601E05C RID: 122972 RVA: 0x0087E134 File Offset: 0x0087C334
	[NullableContext(1)]
	public __TsDecoratorPlayerImpactCheck_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorPlayerImpactCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E05D RID: 122973 RVA: 0x0087E167 File Offset: 0x0087C367
	protected __TsDecoratorPlayerImpactCheck_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E05E RID: 122974 RVA: 0x0087E170 File Offset: 0x0087C370
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
