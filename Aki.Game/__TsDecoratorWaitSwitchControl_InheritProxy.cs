using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020035E4 RID: 13796
public class __TsDecoratorWaitSwitchControl_InheritProxy : TsDecoratorWaitSwitchControl
{
	// Token: 0x0601E126 RID: 123174 RVA: 0x0087FC80 File Offset: 0x0087DE80
	[NullableContext(1)]
	public __TsDecoratorWaitSwitchControl_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorWaitSwitchControl.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E127 RID: 123175 RVA: 0x0087FCB3 File Offset: 0x0087DEB3
	protected __TsDecoratorWaitSwitchControl_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E128 RID: 123176 RVA: 0x0087FCBC File Offset: 0x0087DEBC
	protected unsafe override void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = base.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
