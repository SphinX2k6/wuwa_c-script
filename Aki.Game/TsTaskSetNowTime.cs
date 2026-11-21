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
	// Token: 0x170001FF RID: 511
	// (get) Token: 0x06000ADF RID: 2783 RVA: 0x00036EBD File Offset: 0x000350BD
	// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x00036ED1 File Offset: 0x000350D1
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

	// Token: 0x06000AE1 RID: 2785 RVA: 0x00036EE6 File Offset: 0x000350E6
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsBlackboardKey = this.BlackboardKey;
		}
	}

	// Token: 0x06000AE2 RID: 2786 RVA: 0x00036F0C File Offset: 0x0003510C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskSetNowTime) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskSetNowTime.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTickAI_Implementation(ownerController, controlledPawn, deltaSeconds);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000AE3 RID: 2787 RVA: 0x00036FC4 File Offset: 0x000351C4
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

	// Token: 0x06000AE4 RID: 2788 RVA: 0x00037072 File Offset: 0x00035272
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskSetNowTime._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSetNowTime.TsTaskSetNowTime_C");
		}
		return TsTaskSetNowTime._ClassPtr;
	}

	// Token: 0x06000AE5 RID: 2789 RVA: 0x00037098 File Offset: 0x00035298
	public TsTaskSetNowTime() : this(BuiltinUtils.AllocNativeUObject(TsTaskSetNowTime.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000AE6 RID: 2790 RVA: 0x000370C0 File Offset: 0x000352C0
	public TsTaskSetNowTime(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSetNowTime.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000AE7 RID: 2791 RVA: 0x000370F3 File Offset: 0x000352F3
	protected TsTaskSetNowTime(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000AE8 RID: 2792 RVA: 0x00037108 File Offset: 0x00035308
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x0400087D RID: 2173
	private bool IsInitTsVariables;

	// Token: 0x0400087E RID: 2174
	private string TsBlackboardKey = "";

	// Token: 0x0400087F RID: 2175
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSetNowTime.TsTaskSetNowTime_C";

	// Token: 0x04000880 RID: 2176
	private static IntPtr _ClassPtr;

	// Token: 0x04000881 RID: 2177
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000882 RID: 2178
	private static int __PropertyOffset_BlackboardKey;
}
