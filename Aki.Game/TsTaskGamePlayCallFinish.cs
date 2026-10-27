using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000A3 RID: 163
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskGamePlayCallFinish.TsTaskGamePlayCallFinish_C")]
public class TsTaskGamePlayCallFinish : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x060008C4 RID: 2244 RVA: 0x0002C95C File Offset: 0x0002AB5C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveExecuteAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams) & -16L);
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

	// Token: 0x060008C5 RID: 2245 RVA: 0x0002C9F5 File Offset: 0x0002ABF5
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		base.FinishExecute(true);
	}

	// Token: 0x060008C6 RID: 2246 RVA: 0x0002C9FE File Offset: 0x0002ABFE
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskGamePlayCallFinish._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskGamePlayCallFinish.TsTaskGamePlayCallFinish_C");
		}
		return TsTaskGamePlayCallFinish._ClassPtr;
	}

	// Token: 0x060008C7 RID: 2247 RVA: 0x0002CA24 File Offset: 0x0002AC24
	public TsTaskGamePlayCallFinish() : this(BuiltinUtils.AllocNativeUObject(TsTaskGamePlayCallFinish.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060008C8 RID: 2248 RVA: 0x0002CA4C File Offset: 0x0002AC4C
	[NullableContext(1)]
	public TsTaskGamePlayCallFinish(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskGamePlayCallFinish.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060008C9 RID: 2249 RVA: 0x0002CA7F File Offset: 0x0002AC7F
	protected TsTaskGamePlayCallFinish(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060008CA RID: 2250 RVA: 0x0002CA88 File Offset: 0x0002AC88
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040006BE RID: 1726
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskGamePlayCallFinish.TsTaskGamePlayCallFinish_C";

	// Token: 0x040006BF RID: 1727
	private static IntPtr _ClassPtr;

	// Token: 0x040006C0 RID: 1728
	private static IntPtr _ClassDefaultObjectPtr;
}
