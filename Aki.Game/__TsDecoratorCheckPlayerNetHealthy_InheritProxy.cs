using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002B2D RID: 11053
public class __TsDecoratorCheckPlayerNetHealthy_InheritProxy : TsDecoratorCheckPlayerNetHealthy
{
	// Token: 0x0601BDE0 RID: 114144 RVA: 0x008A6E4C File Offset: 0x008A504C
	[NullableContext(1)]
	public __TsDecoratorCheckPlayerNetHealthy_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckPlayerNetHealthy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BDE1 RID: 114145 RVA: 0x008A6E7F File Offset: 0x008A507F
	protected __TsDecoratorCheckPlayerNetHealthy_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601BDE2 RID: 114146 RVA: 0x008A6E88 File Offset: 0x008A5088
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
