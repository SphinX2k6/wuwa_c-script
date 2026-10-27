using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200363E RID: 13886
public class __TsTaskAbortImmediatelyBase_InheritProxy : TsTaskAbortImmediatelyBase
{
	// Token: 0x0601E21A RID: 123418 RVA: 0x00881DF4 File Offset: 0x0087FFF4
	[NullableContext(1)]
	public __TsTaskAbortImmediatelyBase_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAbortImmediatelyBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E21B RID: 123419 RVA: 0x00881E27 File Offset: 0x00880027
	protected __TsTaskAbortImmediatelyBase_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E21C RID: 123420 RVA: 0x00881E30 File Offset: 0x00880030
	protected unsafe override void __CPPCALL_ReceiveAbortAI_Implementation(UBTTask_BlueprintBase.__ReceiveAbortAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveAbortAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
