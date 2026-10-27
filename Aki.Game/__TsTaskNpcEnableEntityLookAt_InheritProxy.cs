using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003614 RID: 13844
public class __TsTaskNpcEnableEntityLookAt_InheritProxy : TsTaskNpcEnableEntityLookAt
{
	// Token: 0x0601E1A5 RID: 123301 RVA: 0x00880DBC File Offset: 0x0087EFBC
	[NullableContext(1)]
	public __TsTaskNpcEnableEntityLookAt_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcEnableEntityLookAt.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E1A6 RID: 123302 RVA: 0x00880DEF File Offset: 0x0087EFEF
	protected __TsTaskNpcEnableEntityLookAt_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E1A7 RID: 123303 RVA: 0x00880DF8 File Offset: 0x0087EFF8
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
