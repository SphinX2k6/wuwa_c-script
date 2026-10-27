using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000BC RID: 188
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSetNowTime.TsTaskSetNowTime_C")]
public class TsTaskSetNowTime : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170001FC RID: 508
	// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x00035DA5 File Offset: 0x00033FA5
	// (set) Token: 0x06000ADA RID: 2778 RVA: 0x00035DB9 File Offset: 0x00033FB9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskSetNowTime.__PropertyOffset_BlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskSetNowTime.__PropertyOffset_BlackboardKey)), value);
		}
	}

	// Token: 0x06000ADB RID: 2779 RVA: 0x00035DCE File Offset: 0x00033FCE
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsBlackboardKey = this.BlackboardKey;
		}
	}

	// Token: 0x06000ADC RID: 2780 RVA: 0x00035DF4 File Offset: 0x00033FF4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveTickAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
			ptr2->DeltaSeconds = deltaSeconds;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000ADD RID: 2781 RVA: 0x00035E94 File Offset: 0x00034094
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		this.InitTsVariables();
		if (this.TsBlackboardKey != "")
		{
			int id = aiController.CharActorComp.Entity.Id;
			int value = (int)Time.Instance.WorldTime;
			BlackboardController.Instance.SetIntValueByEntity(id, this.TsBlackboardKey, value);
		}
		base.FinishExecute(true);
	}

	// Token: 0x06000ADE RID: 2782 RVA: 0x00035F42 File Offset: 0x00034142
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskSetNowTime._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSetNowTime.TsTaskSetNowTime_C");
		}
		return TsTaskSetNowTime._ClassPtr;
	}

	// Token: 0x06000ADF RID: 2783 RVA: 0x00035F68 File Offset: 0x00034168
	public TsTaskSetNowTime() : this(BuiltinUtils.AllocNativeUObject(TsTaskSetNowTime.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000AE0 RID: 2784 RVA: 0x00035F90 File Offset: 0x00034190
	public TsTaskSetNowTime(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSetNowTime.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000AE1 RID: 2785 RVA: 0x00035FC3 File Offset: 0x000341C3
	protected TsTaskSetNowTime(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000AE2 RID: 2786 RVA: 0x00035FD8 File Offset: 0x000341D8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000875 RID: 2165
	private bool IsInitTsVariables;

	// Token: 0x04000876 RID: 2166
	private string TsBlackboardKey = "";

	// Token: 0x04000877 RID: 2167
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSetNowTime.TsTaskSetNowTime_C";

	// Token: 0x04000878 RID: 2168
	private static IntPtr _ClassPtr;

	// Token: 0x04000879 RID: 2169
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400087A RID: 2170
	private static int __PropertyOffset_BlackboardKey;
}
