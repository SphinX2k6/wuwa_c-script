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
	// Token: 0x1700020E RID: 526
	// (get) Token: 0x06000B42 RID: 2882 RVA: 0x0003841C File Offset: 0x0003661C
	// (set) Token: 0x06000B43 RID: 2883 RVA: 0x00038455 File Offset: 0x00036655
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

	// Token: 0x06000B44 RID: 2884 RVA: 0x00038464 File Offset: 0x00036664
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

	// Token: 0x06000B45 RID: 2885 RVA: 0x00038504 File Offset: 0x00036704
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

	// Token: 0x06000B46 RID: 2886 RVA: 0x00038566 File Offset: 0x00036766
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskSwitchFsmState._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSwitchFsmState.TsTaskSwitchFsmState_C");
		}
		return TsTaskSwitchFsmState._ClassPtr;
	}

	// Token: 0x06000B47 RID: 2887 RVA: 0x0003858C File Offset: 0x0003678C
	public TsTaskSwitchFsmState() : this(BuiltinUtils.AllocNativeUObject(TsTaskSwitchFsmState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000B48 RID: 2888 RVA: 0x000385B4 File Offset: 0x000367B4
	public TsTaskSwitchFsmState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSwitchFsmState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000B49 RID: 2889 RVA: 0x000385E7 File Offset: 0x000367E7
	protected TsTaskSwitchFsmState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000B4A RID: 2890 RVA: 0x000385F0 File Offset: 0x000367F0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x040008CD RID: 2253
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSwitchFsmState.TsTaskSwitchFsmState_C";

	// Token: 0x040008CE RID: 2254
	private static IntPtr _ClassPtr;

	// Token: 0x040008CF RID: 2255
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040008D0 RID: 2256
	private static int __PropertyOffset_States;

	// Token: 0x040008D1 RID: 2257
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _States;
}
