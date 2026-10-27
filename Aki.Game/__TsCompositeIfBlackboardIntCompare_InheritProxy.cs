using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003564 RID: 13668
public class __TsCompositeIfBlackboardIntCompare_InheritProxy : TsCompositeIfBlackboardIntCompare
{
	// Token: 0x0601DFE4 RID: 122852 RVA: 0x0087D114 File Offset: 0x0087B314
	[NullableContext(1)]
	public __TsCompositeIfBlackboardIntCompare_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsCompositeIfBlackboardIntCompare.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601DFE5 RID: 122853 RVA: 0x0087D147 File Offset: 0x0087B347
	protected __TsCompositeIfBlackboardIntCompare_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601DFE6 RID: 122854 RVA: 0x0087D150 File Offset: 0x0087B350
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTComposite_If.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
