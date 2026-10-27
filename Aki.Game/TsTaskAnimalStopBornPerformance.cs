using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.World.Controller;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200005A RID: 90
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/TsTaskAnimalStopBornPerformance.TsTaskAnimalStopBornPerformance_C")]
public class TsTaskAnimalStopBornPerformance : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000086 RID: 134
	// (get) Token: 0x06000380 RID: 896 RVA: 0x000102C3 File Offset: 0x0000E4C3
	// (set) Token: 0x06000381 RID: 897 RVA: 0x000102D3 File Offset: 0x0000E4D3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float GuaranteeTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskAnimalStopBornPerformance.__PropertyOffset_GuaranteeTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskAnimalStopBornPerformance.__PropertyOffset_GuaranteeTime) = value;
		}
	}

	// Token: 0x06000382 RID: 898 RVA: 0x000102E4 File Offset: 0x0000E4E4
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

	// Token: 0x06000383 RID: 899 RVA: 0x00010380 File Offset: 0x0000E580
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
			string message2 = "AnimalDebug StopBornPerformance1";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Tree", base.TreeAsset);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CurrentState", component.CurrentState());
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		if (AnimalStateMachineComponent.GetTsState(component.CurrentState()) != EAnimalPerformState.Born)
		{
			base.FinishExecute(true);
			return;
		}
		(component.GetState(EAnimalPerformState.Born) as AnimalPerformBornState).InterruptBornPerformance(delegate
		{
			base.FinishExecute(true);
		});
		this.ReceiveExecuteTime = Time.Instance.WorldTimeSeconds;
	}

	// Token: 0x06000384 RID: 900 RVA: 0x000104A0 File Offset: 0x0000E6A0
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

	// Token: 0x06000385 RID: 901 RVA: 0x00010540 File Offset: 0x0000E740
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
		if (this.ReceiveExecuteTime + (double)this.GuaranteeTime < Time.Instance.WorldTimeSeconds)
		{
			AnimalStateMachineComponent component = aiController.CharActorComp.Entity.GetComponent<AnimalStateMachineComponent>();
			if (ServerGmController.Instance.AnimalDebug)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.AI;
				ELogAuthor author2 = ELogAuthor.LCZ;
				string message2 = "AnimalDebug StopBornPerformance3";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Tree", base.TreeAsset);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CurrentState", component.CurrentState());
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			base.FinishExecute(true);
		}
	}

	// Token: 0x06000386 RID: 902 RVA: 0x00010643 File Offset: 0x0000E843
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskAnimalStopBornPerformance._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/TsTaskAnimalStopBornPerformance.TsTaskAnimalStopBornPerformance_C");
		}
		return TsTaskAnimalStopBornPerformance._ClassPtr;
	}

	// Token: 0x06000387 RID: 903 RVA: 0x00010668 File Offset: 0x0000E868
	public TsTaskAnimalStopBornPerformance() : this(BuiltinUtils.AllocNativeUObject(TsTaskAnimalStopBornPerformance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000388 RID: 904 RVA: 0x00010690 File Offset: 0x0000E890
	[NullableContext(1)]
	public TsTaskAnimalStopBornPerformance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAnimalStopBornPerformance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000389 RID: 905 RVA: 0x000106C3 File Offset: 0x0000E8C3
	protected TsTaskAnimalStopBornPerformance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600038A RID: 906 RVA: 0x000106CC File Offset: 0x0000E8CC
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600038B RID: 907 RVA: 0x000106FC File Offset: 0x0000E8FC
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000250 RID: 592
	private double ReceiveExecuteTime;

	// Token: 0x04000251 RID: 593
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/TsTaskAnimalStopBornPerformance.TsTaskAnimalStopBornPerformance_C";

	// Token: 0x04000252 RID: 594
	private static IntPtr _ClassPtr;

	// Token: 0x04000253 RID: 595
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000254 RID: 596
	private static int __PropertyOffset_GuaranteeTime;
}
