using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003654 RID: 13908
public class __TsTaskBigAnimalEscape_InheritProxy : TsTaskBigAnimalEscape
{
	// Token: 0x0601E25D RID: 123485 RVA: 0x008827F0 File Offset: 0x008809F0
	[NullableContext(1)]
	public __TsTaskBigAnimalEscape_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskBigAnimalEscape.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E25E RID: 123486 RVA: 0x00882823 File Offset: 0x00880A23
	protected __TsTaskBigAnimalEscape_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E25F RID: 123487 RVA: 0x0088282C File Offset: 0x00880A2C
	protected override void __CPPCALL_InitTsVariables_Implementation()
	{
		base.InitTsVariables_Implementation();
	}

	// Token: 0x0601E260 RID: 123488 RVA: 0x00882834 File Offset: 0x00880A34
	protected unsafe override void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601E261 RID: 123489 RVA: 0x00882861 File Offset: 0x00880A61
	protected override void __CPPCALL_InitData_Implementation()
	{
		base.InitData_Implementation();
	}

	// Token: 0x0601E262 RID: 123490 RVA: 0x00882869 File Offset: 0x00880A69
	protected override void __CPPCALL_FindMovePath_Implementation()
	{
		base.FindMovePath_Implementation();
	}

	// Token: 0x0601E263 RID: 123491 RVA: 0x00882871 File Offset: 0x00880A71
	protected override void __CPPCALL_GenerateFailurePath_Implementation()
	{
		base.GenerateFailurePath_Implementation();
	}

	// Token: 0x0601E264 RID: 123492 RVA: 0x0088287C File Offset: 0x00880A7C
	protected unsafe override void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		base.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}
}
