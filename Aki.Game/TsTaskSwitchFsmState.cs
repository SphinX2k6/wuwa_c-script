using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000C4 RID: 196
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSwitchFsmState.TsTaskSwitchFsmState_C")]
public class TsTaskSwitchFsmState : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000211 RID: 529
	// (get) Token: 0x06000B48 RID: 2888 RVA: 0x000395F4 File Offset: 0x000377F4
	// (set) Token: 0x06000B49 RID: 2889 RVA: 0x0003962D File Offset: 0x0003782D
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<string> States
	{
		get
		{
			base.FastCheckIsValid();
			TArray<string> result;
			if ((result = this._States) == null)
			{
				result = (this._States = new TArray<string>(base.NativePtr + (IntPtr)TsTaskSwitchFsmState.__PropertyOffset_States, this));
			}
			return result;
		}
		set
		{
			this.States.CopyAssign(value);
		}
	}

	// Token: 0x06000B4A RID: 2890 RVA: 0x0003963C File Offset: 0x0003783C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskSwitchFsmState) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskSwitchFsmState.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000B4B RID: 2891 RVA: 0x000396F4 File Offset: 0x000378F4
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		if (((tsAiController != null) ? tsAiController.AiController : null) == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
		}
		base.FinishExecute(true);
	}

	// Token: 0x06000B4C RID: 2892 RVA: 0x00039756 File Offset: 0x00037956
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskSwitchFsmState._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSwitchFsmState.TsTaskSwitchFsmState_C");
		}
		return TsTaskSwitchFsmState._ClassPtr;
	}

	// Token: 0x06000B4D RID: 2893 RVA: 0x0003977C File Offset: 0x0003797C
	public TsTaskSwitchFsmState() : this(BuiltinUtils.AllocNativeUObject(TsTaskSwitchFsmState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000B4E RID: 2894 RVA: 0x000397A4 File Offset: 0x000379A4
	public TsTaskSwitchFsmState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSwitchFsmState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000B4F RID: 2895 RVA: 0x000397D7 File Offset: 0x000379D7
	protected TsTaskSwitchFsmState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000B50 RID: 2896 RVA: 0x000397E0 File Offset: 0x000379E0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x040008D5 RID: 2261
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSwitchFsmState.TsTaskSwitchFsmState_C";

	// Token: 0x040008D6 RID: 2262
	private static IntPtr _ClassPtr;

	// Token: 0x040008D7 RID: 2263
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040008D8 RID: 2264
	private static int __PropertyOffset_States;

	// Token: 0x040008D9 RID: 2265
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _States;
}
