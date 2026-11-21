using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002AD9 RID: 10969
public class __TsCompositeIfBlackboardIntCompare_InheritProxy : TsCompositeIfBlackboardIntCompare
{
	// Token: 0x0601BD0C RID: 113932 RVA: 0x008A51A8 File Offset: 0x008A33A8
	[NullableContext(1)]
	public __TsCompositeIfBlackboardIntCompare_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsCompositeIfBlackboardIntCompare.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BD0D RID: 113933 RVA: 0x008A51DB File Offset: 0x008A33DB
	protected __TsCompositeIfBlackboardIntCompare_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601BD0E RID: 113934 RVA: 0x008A51E4 File Offset: 0x008A33E4
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTComposite_If.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
