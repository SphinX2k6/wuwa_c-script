using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003604 RID: 13828
public class __TsTaskKeepFollowingWithSpline_InheritProxy : TsTaskKeepFollowingWithSpline
{
	// Token: 0x0601E17B RID: 123259 RVA: 0x00880814 File Offset: 0x0087EA14
	[NullableContext(1)]
	public __TsTaskKeepFollowingWithSpline_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskKeepFollowingWithSpline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E17C RID: 123260 RVA: 0x00880847 File Offset: 0x0087EA47
	protected __TsTaskKeepFollowingWithSpline_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E17D RID: 123261 RVA: 0x00880850 File Offset: 0x0087EA50
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
