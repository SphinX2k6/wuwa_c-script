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
	// Token: 0x060008C8 RID: 2248 RVA: 0x0002D870 File Offset: 0x0002BA70
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskGamePlayCallFinish) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskGamePlayCallFinish.StaticClass(), out intPtr, out num))
		{
			this.ReceiveExecuteAI_Implementation(ownerController, controlledPawn);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x060008C9 RID: 2249 RVA: 0x0002D920 File Offset: 0x0002BB20
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		base.FinishExecute(true);
	}

	// Token: 0x060008CA RID: 2250 RVA: 0x0002D929 File Offset: 0x0002BB29
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskGamePlayCallFinish._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskGamePlayCallFinish.TsTaskGamePlayCallFinish_C");
		}
		return TsTaskGamePlayCallFinish._ClassPtr;
	}

	// Token: 0x060008CB RID: 2251 RVA: 0x0002D950 File Offset: 0x0002BB50
	public TsTaskGamePlayCallFinish() : this(BuiltinUtils.AllocNativeUObject(TsTaskGamePlayCallFinish.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060008CC RID: 2252 RVA: 0x0002D978 File Offset: 0x0002BB78
	[NullableContext(1)]
	public TsTaskGamePlayCallFinish(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskGamePlayCallFinish.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060008CD RID: 2253 RVA: 0x0002D9AB File Offset: 0x0002BBAB
	protected TsTaskGamePlayCallFinish(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060008CE RID: 2254 RVA: 0x0002D9B4 File Offset: 0x0002BBB4
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040006C2 RID: 1730
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskGamePlayCallFinish.TsTaskGamePlayCallFinish_C";

	// Token: 0x040006C3 RID: 1731
	private static IntPtr _ClassPtr;

	// Token: 0x040006C4 RID: 1732
	private static IntPtr _ClassDefaultObjectPtr;
}
