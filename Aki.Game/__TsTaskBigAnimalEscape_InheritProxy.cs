using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002BC9 RID: 11209
public class __TsTaskBigAnimalEscape_InheritProxy : TsTaskBigAnimalEscape
{
	// Token: 0x0601BF80 RID: 114560 RVA: 0x008AA654 File Offset: 0x008A8854
	[NullableContext(1)]
	public __TsTaskBigAnimalEscape_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskBigAnimalEscape.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601BF81 RID: 114561 RVA: 0x008AA687 File Offset: 0x008A8887
	protected __TsTaskBigAnimalEscape_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601BF82 RID: 114562 RVA: 0x008AA690 File Offset: 0x008A8890
	protected override void __CPPCALL_InitTsVariables_Implementation()
	{
		base.InitTsVariables_Implementation();
	}

	// Token: 0x0601BF83 RID: 114563 RVA: 0x008AA698 File Offset: 0x008A8898
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601BF84 RID: 114564 RVA: 0x008AA6C5 File Offset: 0x008A88C5
	protected override void __CPPCALL_InitData_Implementation()
	{
		base.InitData_Implementation();
	}

	// Token: 0x0601BF85 RID: 114565 RVA: 0x008AA6CD File Offset: 0x008A88CD
	protected override void __CPPCALL_FindMovePath_Implementation()
	{
		base.FindMovePath_Implementation();
	}

	// Token: 0x0601BF86 RID: 114566 RVA: 0x008AA6D5 File Offset: 0x008A88D5
	protected override void __CPPCALL_GenerateFailurePath_Implementation()
	{
		base.GenerateFailurePath_Implementation();
	}

	// Token: 0x0601BF87 RID: 114567 RVA: 0x008AA6E0 File Offset: 0x008A88E0
	protected unsafe override void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}
}
