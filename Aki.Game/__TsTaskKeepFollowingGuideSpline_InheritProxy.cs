using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003602 RID: 13826
public class __TsTaskKeepFollowingGuideSpline_InheritProxy : TsTaskKeepFollowingGuideSpline
{
	// Token: 0x0601E176 RID: 123254 RVA: 0x0088076C File Offset: 0x0087E96C
	[NullableContext(1)]
	public __TsTaskKeepFollowingGuideSpline_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskKeepFollowingGuideSpline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E177 RID: 123255 RVA: 0x0088079F File Offset: 0x0087E99F
	protected __TsTaskKeepFollowingGuideSpline_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E178 RID: 123256 RVA: 0x008807A8 File Offset: 0x0087E9A8
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
