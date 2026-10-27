using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036A2 RID: 13986
public class __TsTaskPlayWalkingOverlayMontage_InheritProxy : TsTaskPlayWalkingOverlayMontage
{
	// Token: 0x0601E342 RID: 123714 RVA: 0x00884970 File Offset: 0x00882B70
	[NullableContext(1)]
	public __TsTaskPlayWalkingOverlayMontage_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPlayWalkingOverlayMontage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E343 RID: 123715 RVA: 0x008849A3 File Offset: 0x00882BA3
	protected __TsTaskPlayWalkingOverlayMontage_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E344 RID: 123716 RVA: 0x008849AC File Offset: 0x00882BAC
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
