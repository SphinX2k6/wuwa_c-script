using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000B8 RID: 184
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskResetRandomWeights.TsTaskResetRandomWeights_C")]
public class TsTaskResetRandomWeights : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170001EB RID: 491
	// (get) Token: 0x06000A93 RID: 2707 RVA: 0x00035931 File Offset: 0x00033B31
	// (set) Token: 0x06000A94 RID: 2708 RVA: 0x00035945 File Offset: 0x00033B45
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string NodeKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskResetRandomWeights.__PropertyOffset_NodeKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskResetRandomWeights.__PropertyOffset_NodeKey)), value);
		}
	}

	// Token: 0x170001EC RID: 492
	// (get) Token: 0x06000A95 RID: 2709 RVA: 0x0003595A File Offset: 0x00033B5A
	// (set) Token: 0x06000A96 RID: 2710 RVA: 0x0003596A File Offset: 0x00033B6A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool ResetAll
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskResetRandomWeights.__PropertyOffset_ResetAll) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskResetRandomWeights.__PropertyOffset_ResetAll) = (value ? 1 : 0);
		}
	}

	// Token: 0x170001ED RID: 493
	// (get) Token: 0x06000A97 RID: 2711 RVA: 0x0003597C File Offset: 0x00033B7C
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<int> WeightsOverride
	{
		get
		{
			base.FastCheckIsValid();
			TArray<int> result;
			if ((result = this._WeightsOverride) == null)
			{
				result = (this._WeightsOverride = new TArray<int>(base.NativePtr + (IntPtr)TsTaskResetRandomWeights.__PropertyOffset_WeightsOverride, this));
			}
			return result;
		}
	}

	// Token: 0x06000A98 RID: 2712 RVA: 0x000359B8 File Offset: 0x00033BB8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskResetRandomWeights) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskResetRandomWeights.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000A99 RID: 2713 RVA: 0x00035A68 File Offset: 0x00033C68
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		if (((tsAiController != null) ? tsAiController.AiController : null) == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LJF;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		TsAiController tsAiController2 = ownerController as TsAiController;
		CharacterAiComponent characterAiComponent = (tsAiController2 != null) ? tsAiController2.GetAiComp() : null;
		if (characterAiComponent == null)
		{
			base.FinishExecute(false);
			return;
		}
		if (this.ResetAll)
		{
			characterAiComponent.ResetRandomNodes(null, this.WeightsOverride);
		}
		else
		{
			characterAiComponent.ResetRandomNodes(this.NodeKey, this.WeightsOverride);
		}
		base.FinishExecute(true);
	}

	// Token: 0x06000A9A RID: 2714 RVA: 0x00035B13 File Offset: 0x00033D13
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskResetRandomWeights._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskResetRandomWeights.TsTaskResetRandomWeights_C");
		}
		return TsTaskResetRandomWeights._ClassPtr;
	}

	// Token: 0x06000A9B RID: 2715 RVA: 0x00035B38 File Offset: 0x00033D38
	public TsTaskResetRandomWeights() : this(BuiltinUtils.AllocNativeUObject(TsTaskResetRandomWeights.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000A9C RID: 2716 RVA: 0x00035B60 File Offset: 0x00033D60
	public TsTaskResetRandomWeights(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskResetRandomWeights.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000A9D RID: 2717 RVA: 0x00035B93 File Offset: 0x00033D93
	protected TsTaskResetRandomWeights(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000A9E RID: 2718 RVA: 0x00035B9C File Offset: 0x00033D9C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000831 RID: 2097
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskResetRandomWeights.TsTaskResetRandomWeights_C";

	// Token: 0x04000832 RID: 2098
	private static IntPtr _ClassPtr;

	// Token: 0x04000833 RID: 2099
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000834 RID: 2100
	private static int __PropertyOffset_NodeKey;

	// Token: 0x04000835 RID: 2101
	private static int __PropertyOffset_ResetAll;

	// Token: 0x04000836 RID: 2102
	private static int __PropertyOffset_WeightsOverride;

	// Token: 0x04000837 RID: 2103
	[Nullable(2)]
	private TArray<int> _WeightsOverride;
}
