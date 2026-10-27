using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal;
using CSharpScript.Game.World.Controller;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000060 RID: 96
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/TsTaskSwitchAnimalState.TsTaskSwitchAnimalState_C")]
public class TsTaskSwitchAnimalState : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000094 RID: 148
	// (get) Token: 0x060003DF RID: 991 RVA: 0x00012D05 File Offset: 0x00010F05
	// (set) Token: 0x060003E0 RID: 992 RVA: 0x00012D15 File Offset: 0x00010F15
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EAnimalEcologicalState State
	{
		get
		{
			return (EAnimalEcologicalState)(*(base.NativePtr + (IntPtr)TsTaskSwitchAnimalState.__PropertyOffset_State));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSwitchAnimalState.__PropertyOffset_State) = (byte)value;
		}
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x00012D28 File Offset: 0x00010F28
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

	// Token: 0x060003E2 RID: 994 RVA: 0x00012DC4 File Offset: 0x00010FC4
	[NullableContext(2)]
	protected unsafe virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.CJH;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		AnimalStateMachineComponent component = aiController.CharActorComp.Entity.GetComponent<AnimalStateMachineComponent>();
		if (ServerGmController.Instance.AnimalDebug)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.AI;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "AnimalDebug SwitchAnimalState";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Tree", base.TreeAsset);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CurrentState", component.CurrentState());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TargetState", this.State);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		if (component.CurrentState() == this.State)
		{
			base.FinishExecute(true);
			return;
		}
		component.SwitchState(AnimalStateMachineComponent.GetTsState(this.State));
		this.WaitTime = (double)component.GetWaitTime();
		this.ReceiveExecuteTime = Time.Instance.WorldTimeSeconds;
	}

	// Token: 0x060003E3 RID: 995 RVA: 0x00012F0C File Offset: 0x0001110C
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

	// Token: 0x060003E4 RID: 996 RVA: 0x00012FAC File Offset: 0x000111AC
	[NullableContext(2)]
	protected unsafe virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.CJH;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		if (this.ReceiveExecuteTime + this.WaitTime < Time.Instance.WorldTimeSeconds)
		{
			AnimalStateMachineComponent component = aiController.CharActorComp.Entity.GetComponent<AnimalStateMachineComponent>();
			component.SwitchState(AnimalStateMachineComponent.GetTsState(EAnimalEcologicalState.None));
			if (ServerGmController.Instance.AnimalDebug)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.AI;
				ELogAuthor author2 = ELogAuthor.LCZ;
				string message2 = "AnimalDebug SwitchAnimalState2";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Tree", base.TreeAsset);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CurrentState", component.CurrentState());
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			base.FinishExecute(true);
		}
	}

	// Token: 0x060003E5 RID: 997 RVA: 0x000130BC File Offset: 0x000112BC
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

	// Token: 0x060003E6 RID: 998 RVA: 0x00013158 File Offset: 0x00011358
	[NullableContext(2)]
	protected override void ReceiveAbortAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			base.FinishAbort();
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		Entity entity = (charActorComp != null) ? charActorComp.Entity : null;
		AnimalStateMachineComponent animalStateMachineComponent = (entity != null) ? entity.GetComponent<AnimalStateMachineComponent>() : null;
		if (animalStateMachineComponent != null)
		{
			animalStateMachineComponent.SwitchState(AnimalStateMachineComponent.GetTsState(EAnimalEcologicalState.None));
		}
		base.FinishAbort();
	}

	// Token: 0x060003E7 RID: 999 RVA: 0x000131B7 File Offset: 0x000113B7
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskSwitchAnimalState._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/TsTaskSwitchAnimalState.TsTaskSwitchAnimalState_C");
		}
		return TsTaskSwitchAnimalState._ClassPtr;
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x000131DC File Offset: 0x000113DC
	public TsTaskSwitchAnimalState() : this(BuiltinUtils.AllocNativeUObject(TsTaskSwitchAnimalState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060003E9 RID: 1001 RVA: 0x00013204 File Offset: 0x00011404
	[NullableContext(1)]
	public TsTaskSwitchAnimalState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSwitchAnimalState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060003EA RID: 1002 RVA: 0x00013237 File Offset: 0x00011437
	protected TsTaskSwitchAnimalState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060003EB RID: 1003 RVA: 0x00013240 File Offset: 0x00011440
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060003EC RID: 1004 RVA: 0x00013270 File Offset: 0x00011470
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x060003ED RID: 1005 RVA: 0x000132A4 File Offset: 0x000114A4
	protected unsafe override void __CPPCALL_ReceiveAbortAI_Implementation(UBTTask_BlueprintBase.__ReceiveAbortAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveAbortAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040002AA RID: 682
	private double ReceiveExecuteTime;

	// Token: 0x040002AB RID: 683
	private double WaitTime;

	// Token: 0x040002AC RID: 684
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/TsTaskSwitchAnimalState.TsTaskSwitchAnimalState_C";

	// Token: 0x040002AD RID: 685
	private static IntPtr _ClassPtr;

	// Token: 0x040002AE RID: 686
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040002AF RID: 687
	private static int __PropertyOffset_State;
}
