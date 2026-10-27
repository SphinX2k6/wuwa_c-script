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
	// Token: 0x170001E8 RID: 488
	// (get) Token: 0x06000A8D RID: 2701 RVA: 0x00034749 File Offset: 0x00032949
	// (set) Token: 0x06000A8E RID: 2702 RVA: 0x0003475D File Offset: 0x0003295D
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

	// Token: 0x170001E9 RID: 489
	// (get) Token: 0x06000A8F RID: 2703 RVA: 0x00034772 File Offset: 0x00032972
	// (set) Token: 0x06000A90 RID: 2704 RVA: 0x00034782 File Offset: 0x00032982
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

	// Token: 0x170001EA RID: 490
	// (get) Token: 0x06000A91 RID: 2705 RVA: 0x00034794 File Offset: 0x00032994
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

	// Token: 0x06000A92 RID: 2706 RVA: 0x000347D0 File Offset: 0x000329D0
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

	// Token: 0x06000A93 RID: 2707 RVA: 0x0003486C File Offset: 0x00032A6C
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

	// Token: 0x06000A94 RID: 2708 RVA: 0x00034917 File Offset: 0x00032B17
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskResetRandomWeights._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskResetRandomWeights.TsTaskResetRandomWeights_C");
		}
		return TsTaskResetRandomWeights._ClassPtr;
	}

	// Token: 0x06000A95 RID: 2709 RVA: 0x0003493C File Offset: 0x00032B3C
	public TsTaskResetRandomWeights() : this(BuiltinUtils.AllocNativeUObject(TsTaskResetRandomWeights.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000A96 RID: 2710 RVA: 0x00034964 File Offset: 0x00032B64
	public TsTaskResetRandomWeights(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskResetRandomWeights.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000A97 RID: 2711 RVA: 0x00034997 File Offset: 0x00032B97
	protected TsTaskResetRandomWeights(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000A98 RID: 2712 RVA: 0x000349A0 File Offset: 0x00032BA0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000829 RID: 2089
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskResetRandomWeights.TsTaskResetRandomWeights_C";

	// Token: 0x0400082A RID: 2090
	private static IntPtr _ClassPtr;

	// Token: 0x0400082B RID: 2091
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400082C RID: 2092
	private static int __PropertyOffset_NodeKey;

	// Token: 0x0400082D RID: 2093
	private static int __PropertyOffset_ResetAll;

	// Token: 0x0400082E RID: 2094
	private static int __PropertyOffset_WeightsOverride;

	// Token: 0x0400082F RID: 2095
	[Nullable(2)]
	private TArray<int> _WeightsOverride;
}
