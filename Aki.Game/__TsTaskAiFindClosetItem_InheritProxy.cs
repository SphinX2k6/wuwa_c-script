using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003644 RID: 13892
public class __TsTaskAiFindClosetItem_InheritProxy : TsTaskAiFindClosetItem
{
	// Token: 0x0601E229 RID: 123433 RVA: 0x00881FF0 File Offset: 0x008801F0
	[NullableContext(1)]
	public __TsTaskAiFindClosetItem_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAiFindClosetItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E22A RID: 123434 RVA: 0x00882023 File Offset: 0x00880223
	protected __TsTaskAiFindClosetItem_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E22B RID: 123435 RVA: 0x0088202C File Offset: 0x0088022C
	protected override void __CPPCALL_InitTsVariables_Implementation()
	{
		base.InitTsVariables_Implementation();
	}

	// Token: 0x0601E22C RID: 123436 RVA: 0x00882034 File Offset: 0x00880234
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
