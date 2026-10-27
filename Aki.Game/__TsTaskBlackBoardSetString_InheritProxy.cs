using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003656 RID: 13910
public class __TsTaskBlackBoardSetString_InheritProxy : TsTaskBlackBoardSetString
{
	// Token: 0x0601E26B RID: 123499 RVA: 0x00882AAC File Offset: 0x00880CAC
	[NullableContext(1)]
	public __TsTaskBlackBoardSetString_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskBlackBoardSetString.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E26C RID: 123500 RVA: 0x00882ADF File Offset: 0x00880CDF
	protected __TsTaskBlackBoardSetString_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E26D RID: 123501 RVA: 0x00882AE8 File Offset: 0x00880CE8
	protected override void __CPPCALL_InitTsVariables_Implementation()
	{
		base.InitTsVariables_Implementation();
	}

	// Token: 0x0601E26E RID: 123502 RVA: 0x00882AF0 File Offset: 0x00880CF0
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}
}
