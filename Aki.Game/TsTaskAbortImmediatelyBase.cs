using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000080 RID: 128
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAbortImmediatelyBase.TsTaskAbortImmediatelyBase_C")]
public class TsTaskAbortImmediatelyBase : UBTTask_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06000632 RID: 1586 RVA: 0x0001FEAC File Offset: 0x0001E0AC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveAbortAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskAbortImmediatelyBase) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveAbortAI"), TsTaskAbortImmediatelyBase.StaticClass(), out intPtr, out num))
		{
			this.ReceiveAbortAI_Implementation(ownerController, controlledPawn);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveAbortAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveAbortAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveAbortAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x0001FF5C File Offset: 0x0001E15C
	[NullableContext(2)]
	protected virtual void ReceiveAbortAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		base.FinishAbort();
		this.OnAbort();
		this.OnClear();
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x0001FF70 File Offset: 0x0001E170
	protected void Finish(bool bSuccess)
	{
		base.FinishExecute(bSuccess);
		this.OnClear();
	}

	// Token: 0x06000635 RID: 1589 RVA: 0x0001FF7F File Offset: 0x0001E17F
	protected virtual void OnAbort()
	{
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x0001FF81 File Offset: 0x0001E181
	protected virtual void OnClear()
	{
	}

	// Token: 0x06000637 RID: 1591 RVA: 0x0001FF83 File Offset: 0x0001E183
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskAbortImmediatelyBase._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAbortImmediatelyBase.TsTaskAbortImmediatelyBase_C");
		}
		return TsTaskAbortImmediatelyBase._ClassPtr;
	}

	// Token: 0x06000638 RID: 1592 RVA: 0x0001FFA8 File Offset: 0x0001E1A8
	public TsTaskAbortImmediatelyBase() : this(BuiltinUtils.AllocNativeUObject(TsTaskAbortImmediatelyBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x0001FFD0 File Offset: 0x0001E1D0
	[NullableContext(1)]
	public TsTaskAbortImmediatelyBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAbortImmediatelyBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x00020003 File Offset: 0x0001E203
	protected TsTaskAbortImmediatelyBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x0002000C File Offset: 0x0001E20C
	protected unsafe virtual void __CPPCALL_ReceiveAbortAI_Implementation(UBTTask_BlueprintBase.__ReceiveAbortAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveAbortAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000488 RID: 1160
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAbortImmediatelyBase.TsTaskAbortImmediatelyBase_C";

	// Token: 0x04000489 RID: 1161
	private static IntPtr _ClassPtr;

	// Token: 0x0400048A RID: 1162
	private static IntPtr _ClassDefaultObjectPtr;
}
