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
	// Token: 0x0600062E RID: 1582 RVA: 0x0001F26C File Offset: 0x0001D46C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveAbortAI(AAIController ownerController, APawn controlledPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveAbortAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTTask_BlueprintBase.__ReceiveAbortAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTTask_BlueprintBase.__ReceiveAbortAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveAbortAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0600062F RID: 1583 RVA: 0x0001F305 File Offset: 0x0001D505
	[NullableContext(2)]
	protected virtual void ReceiveAbortAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		base.FinishAbort();
		this.OnAbort();
		this.OnClear();
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x0001F319 File Offset: 0x0001D519
	protected void Finish(bool bSuccess)
	{
		base.FinishExecute(bSuccess);
		this.OnClear();
	}

	// Token: 0x06000631 RID: 1585 RVA: 0x0001F328 File Offset: 0x0001D528
	protected virtual void OnAbort()
	{
	}

	// Token: 0x06000632 RID: 1586 RVA: 0x0001F32A File Offset: 0x0001D52A
	protected virtual void OnClear()
	{
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x0001F32C File Offset: 0x0001D52C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskAbortImmediatelyBase._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAbortImmediatelyBase.TsTaskAbortImmediatelyBase_C");
		}
		return TsTaskAbortImmediatelyBase._ClassPtr;
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x0001F350 File Offset: 0x0001D550
	public TsTaskAbortImmediatelyBase() : this(BuiltinUtils.AllocNativeUObject(TsTaskAbortImmediatelyBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000635 RID: 1589 RVA: 0x0001F378 File Offset: 0x0001D578
	[NullableContext(1)]
	public TsTaskAbortImmediatelyBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAbortImmediatelyBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x0001F3AB File Offset: 0x0001D5AB
	protected TsTaskAbortImmediatelyBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000637 RID: 1591 RVA: 0x0001F3B4 File Offset: 0x0001D5B4
	protected unsafe virtual void __CPPCALL_ReceiveAbortAI_Implementation(UBTTask_BlueprintBase.__ReceiveAbortAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveAbortAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000484 RID: 1156
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAbortImmediatelyBase.TsTaskAbortImmediatelyBase_C";

	// Token: 0x04000485 RID: 1157
	private static IntPtr _ClassPtr;

	// Token: 0x04000486 RID: 1158
	private static IntPtr _ClassDefaultObjectPtr;
}
