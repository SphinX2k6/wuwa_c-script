using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035E2 RID: 13794
public class __TsDecoratorTagCount_InheritProxy : TsDecoratorTagCount
{
	// Token: 0x0601E121 RID: 123169 RVA: 0x0087FBD4 File Offset: 0x0087DDD4
	[NullableContext(1)]
	public __TsDecoratorTagCount_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorTagCount.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E122 RID: 123170 RVA: 0x0087FC07 File Offset: 0x0087DE07
	protected __TsDecoratorTagCount_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E123 RID: 123171 RVA: 0x0087FC10 File Offset: 0x0087DE10
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
