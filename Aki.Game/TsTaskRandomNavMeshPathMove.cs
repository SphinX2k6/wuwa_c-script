using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000B6 RID: 182
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskRandomNavMeshPathMove.TsTaskRandomNavMeshPathMove_C")]
public class TsTaskRandomNavMeshPathMove : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170001E0 RID: 480
	// (get) Token: 0x06000A68 RID: 2664 RVA: 0x00033CDD File Offset: 0x00031EDD
	// (set) Token: 0x06000A69 RID: 2665 RVA: 0x00033CED File Offset: 0x00031EED
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int MoveState
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskRandomNavMeshPathMove.__PropertyOffset_MoveState);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskRandomNavMeshPathMove.__PropertyOffset_MoveState) = value;
		}
	}

	// Token: 0x170001E1 RID: 481
	// (get) Token: 0x06000A6A RID: 2666 RVA: 0x00033CFE File Offset: 0x00031EFE
	// (set) Token: 0x06000A6B RID: 2667 RVA: 0x00033D12 File Offset: 0x00031F12
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardLocation
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskRandomNavMeshPathMove.__PropertyOffset_BlackboardLocation)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskRandomNavMeshPathMove.__PropertyOffset_BlackboardLocation)), value);
		}
	}

	// Token: 0x170001E2 RID: 482
	// (get) Token: 0x06000A6C RID: 2668 RVA: 0x00033D27 File Offset: 0x00031F27
	// (set) Token: 0x06000A6D RID: 2669 RVA: 0x00033D37 File Offset: 0x00031F37
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int Sampling
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskRandomNavMeshPathMove.__PropertyOffset_Sampling);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskRandomNavMeshPathMove.__PropertyOffset_Sampling) = value;
		}
	}

	// Token: 0x170001E3 RID: 483
	// (get) Token: 0x06000A6E RID: 2670 RVA: 0x00033D48 File Offset: 0x00031F48
	// (set) Token: 0x06000A6F RID: 2671 RVA: 0x00033D58 File Offset: 0x00031F58
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int RandomRange
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskRandomNavMeshPathMove.__PropertyOffset_RandomRange);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskRandomNavMeshPathMove.__PropertyOffset_RandomRange) = value;
		}
	}

	// Token: 0x170001E4 RID: 484
	// (get) Token: 0x06000A70 RID: 2672 RVA: 0x00033D69 File Offset: 0x00031F69
	// (set) Token: 0x06000A71 RID: 2673 RVA: 0x00033D79 File Offset: 0x00031F79
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float EndDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskRandomNavMeshPathMove.__PropertyOffset_EndDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskRandomNavMeshPathMove.__PropertyOffset_EndDistance) = value;
		}
	}

	// Token: 0x170001E5 RID: 485
	// (get) Token: 0x06000A72 RID: 2674 RVA: 0x00033D8A File Offset: 0x00031F8A
	// (set) Token: 0x06000A73 RID: 2675 RVA: 0x00033D9A File Offset: 0x00031F9A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float TurnSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskRandomNavMeshPathMove.__PropertyOffset_TurnSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskRandomNavMeshPathMove.__PropertyOffset_TurnSpeed) = value;
		}
	}

	// Token: 0x170001E6 RID: 486
	// (get) Token: 0x06000A74 RID: 2676 RVA: 0x00033DAB File Offset: 0x00031FAB
	// (set) Token: 0x06000A75 RID: 2677 RVA: 0x00033DBB File Offset: 0x00031FBB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool OpenDebugNode
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskRandomNavMeshPathMove.__PropertyOffset_OpenDebugNode) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskRandomNavMeshPathMove.__PropertyOffset_OpenDebugNode) = (value ? 1 : 0);
		}
	}

	// Token: 0x170001E7 RID: 487
	// (get) Token: 0x06000A76 RID: 2678 RVA: 0x00033DCC File Offset: 0x00031FCC
	// (set) Token: 0x06000A77 RID: 2679 RVA: 0x00033DDC File Offset: 0x00031FDC
	[UProperty(EPropertyFlags.CPF_None)]
	private unsafe bool IsEditor
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskRandomNavMeshPathMove.__PropertyOffset_IsEditor) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskRandomNavMeshPathMove.__PropertyOffset_IsEditor) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000A78 RID: 2680 RVA: 0x00033DF0 File Offset: 0x00031FF0
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsMoveState = this.MoveState;
			this.TsBlackboardLocation = this.BlackboardLocation;
			this.TsSampling = this.Sampling;
			this.TsRandomRange = this.RandomRange;
			this.TsEndDistance = this.EndDistance;
			this.TsTurnSpeed = this.TurnSpeed;
			this.TsOpenDebugNode = this.OpenDebugNode;
		}
	}

	// Token: 0x06000A79 RID: 2681 RVA: 0x00033E68 File Offset: 0x00032068
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

	// Token: 0x06000A7A RID: 2682 RVA: 0x00033F04 File Offset: 0x00032104
	[NullableContext(2)]
	protected unsafe virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
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
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		Aki.Protocol.Vector vectorValueByEntity = BlackboardController.Instance.GetVectorValueByEntity(aiController.CharAiDesignComp.Entity.Id, this.TsBlackboardLocation);
		if (vectorValueByEntity == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "TsTaskMoveToLocation没有获取到目标坐标";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BehaviorTree", base.TreeAsset);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BlackboardLocation", this.TsBlackboardLocation);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.FoundPath = false;
			return;
		}
		this.SelectedTargetLocation = new FVectorDouble?(WorldGlobal.ToUeVector(vectorValueByEntity));
		this.FindRandomPath(ownerController, charActorComp.ActorLocation, this.SelectedTargetLocation.Value);
		this.FoundPath = (this.NavigationPath.Count > 0);
		this.CurrentNavigationIndex = 1;
		CharacterAiComponent charAiDesignComp = aiController.CharAiDesignComp;
		CharacterUnifiedStateComponent characterUnifiedStateComponent = (charAiDesignComp != null) ? charAiDesignComp.Entity.GetComponent<CharacterUnifiedStateComponent>() : null;
		if (characterUnifiedStateComponent != null && characterUnifiedStateComponent.Valid)
		{
			switch (this.TsMoveState)
			{
			case 1:
				characterUnifiedStateComponent.SetMoveState(global::ECharMoveState.Walk);
				break;
			case 2:
				characterUnifiedStateComponent.SetMoveState(global::ECharMoveState.Run);
				break;
			case 3:
				characterUnifiedStateComponent.SetMoveState(global::ECharMoveState.Sprint);
				break;
			}
		}
		this.IsEditor = GlobalData.IsPlayInEditor;
	}

	// Token: 0x06000A7B RID: 2683 RVA: 0x000340A4 File Offset: 0x000322A4
	private void FindRandomPath(AAIController controller, FVectorDouble startPoint, FVectorDouble endPoint)
	{
		if (this.NavigationPath == null)
		{
			this.NavigationPath = new List<global::Vector>();
		}
		global::Vector vector = global::Vector.Create(startPoint);
		global::Vector v = global::Vector.Create(endPoint);
		global::Vector vector2 = global::Vector.Create(endPoint);
		vector2.Subtraction(vector, vector2);
		double num = global::Vector.Dist(vector, v);
		if (num < (double)this.TsRandomRange || this.TsSampling < 1)
		{
			this.FoundPath = AiControllerLibrary.NavigationFindPath(controller, startPoint, endPoint, this.NavigationPath, null, null);
			return;
		}
		FVectorDouble from = startPoint;
		double num2 = num / (double)(this.TsSampling + 1);
		for (int i = 0; i < this.TsSampling; i++)
		{
			global::Vector vector3 = global::Vector.Create();
			vector2.Multiply((double)(i + 1) * num2, vector3);
			vector3.Addition(global::Vector.Create(startPoint), vector3);
			vector3 = this.CalculateRandomPosition(vector3);
			List<global::Vector> list = new List<global::Vector>();
			if (AiControllerLibrary.NavigationFindPath(controller, from, vector3.ToUeVector(false), list, null, null))
			{
				this.NavigationPath.AddRange(list);
			}
			from = vector3.ToUeVector(false);
		}
		List<global::Vector> list2 = new List<global::Vector>();
		if (AiControllerLibrary.NavigationFindPath(controller, from, endPoint, list2, null, null))
		{
			this.NavigationPath.AddRange(list2);
		}
	}

	// Token: 0x06000A7C RID: 2684 RVA: 0x00034214 File Offset: 0x00032414
	private global::Vector CalculateRandomPosition(global::Vector point)
	{
		float randomFloatNumber = MathUtils.Instance.GetRandomFloatNumber(0f, 360f);
		global::Vector vector = global::Vector.Create(global::Vector.ForwardVector);
		vector.RotateAngleAxis((double)randomFloatNumber, global::Vector.UpVectorProxy, vector);
		float randomFloatNumber2 = MathUtils.Instance.GetRandomFloatNumber(0f, (float)this.TsRandomRange);
		global::Vector vector2 = vector;
		vector2.Multiply((double)randomFloatNumber2, vector2).Addition(point, vector2);
		return vector2;
	}

	// Token: 0x06000A7D RID: 2685 RVA: 0x00034280 File Offset: 0x00032480
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

	// Token: 0x06000A7E RID: 2686 RVA: 0x00034320 File Offset: 0x00032520
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		if (this.FoundPath)
		{
			TsAiController tsAiController = ownerController as TsAiController;
			if (tsAiController != null)
			{
				CharacterActorComponent charActorComp = tsAiController.AiController.CharActorComp;
				global::Vector vector = this.NavigationPath[this.CurrentNavigationIndex];
				if (this.TsOpenDebugNode && this.IsEditor)
				{
					int segments = 10;
					int num = 30;
					UKismetSystemLibrary.D_DrawDebugSphere(this, vector.ToUeVector(false), (float)num, segments, new FLinearColor?(ColorUtils.LinearRed), 0f, 0f);
				}
				global::Vector vector2 = global::Vector.Create(vector);
				vector2.Subtraction(charActorComp.ActorLocationProxy, vector2);
				vector2.Z = 0.0;
				double num2 = vector2.Size();
				if (this.CurrentNavigationIndex == this.NavigationPath.Count - 1 && num2 < (double)this.TsEndDistance)
				{
					base.Finish(true);
					return;
				}
				if (num2 < 10.0)
				{
					this.CurrentNavigationIndex++;
				}
				vector2.DivisionEqual(num2);
				charActorComp.SetInputDirect(vector2, true);
				AiControllerLibrary.TurnToDirect(charActorComp, vector2, this.TsTurnSpeed, false, 0f);
				return;
			}
		}
		base.Finish(false);
	}

	// Token: 0x06000A7F RID: 2687 RVA: 0x0003443C File Offset: 0x0003263C
	protected override void OnClear()
	{
		TsAiController tsAiController = base.AIOwner as TsAiController;
		if (tsAiController != null)
		{
			AiControllerLibrary.ClearInput(tsAiController);
		}
	}

	// Token: 0x06000A80 RID: 2688 RVA: 0x0003445E File Offset: 0x0003265E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskRandomNavMeshPathMove._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskRandomNavMeshPathMove.TsTaskRandomNavMeshPathMove_C");
		}
		return TsTaskRandomNavMeshPathMove._ClassPtr;
	}

	// Token: 0x06000A81 RID: 2689 RVA: 0x00034484 File Offset: 0x00032684
	public TsTaskRandomNavMeshPathMove() : this(BuiltinUtils.AllocNativeUObject(TsTaskRandomNavMeshPathMove.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000A82 RID: 2690 RVA: 0x000344AC File Offset: 0x000326AC
	public TsTaskRandomNavMeshPathMove(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskRandomNavMeshPathMove.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000A83 RID: 2691 RVA: 0x000344DF File Offset: 0x000326DF
	protected TsTaskRandomNavMeshPathMove(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000A84 RID: 2692 RVA: 0x000344F4 File Offset: 0x000326F4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000A85 RID: 2693 RVA: 0x00034524 File Offset: 0x00032724
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x0400080E RID: 2062
	private const double NAVIGATION_COMPLETE_DISTANCE = 10.0;

	// Token: 0x0400080F RID: 2063
	private FVectorDouble? SelectedTargetLocation;

	// Token: 0x04000810 RID: 2064
	private bool FoundPath;

	// Token: 0x04000811 RID: 2065
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::Vector> NavigationPath;

	// Token: 0x04000812 RID: 2066
	private int CurrentNavigationIndex;

	// Token: 0x04000813 RID: 2067
	private bool IsInitTsVariables;

	// Token: 0x04000814 RID: 2068
	private int TsMoveState;

	// Token: 0x04000815 RID: 2069
	private string TsBlackboardLocation = "";

	// Token: 0x04000816 RID: 2070
	private int TsSampling;

	// Token: 0x04000817 RID: 2071
	private int TsRandomRange;

	// Token: 0x04000818 RID: 2072
	private float TsEndDistance;

	// Token: 0x04000819 RID: 2073
	private float TsTurnSpeed;

	// Token: 0x0400081A RID: 2074
	private bool TsOpenDebugNode;

	// Token: 0x0400081B RID: 2075
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskRandomNavMeshPathMove.TsTaskRandomNavMeshPathMove_C";

	// Token: 0x0400081C RID: 2076
	private static IntPtr _ClassPtr;

	// Token: 0x0400081D RID: 2077
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400081E RID: 2078
	private static int __PropertyOffset_MoveState;

	// Token: 0x0400081F RID: 2079
	private static int __PropertyOffset_BlackboardLocation;

	// Token: 0x04000820 RID: 2080
	private static int __PropertyOffset_Sampling;

	// Token: 0x04000821 RID: 2081
	private static int __PropertyOffset_RandomRange;

	// Token: 0x04000822 RID: 2082
	private static int __PropertyOffset_EndDistance;

	// Token: 0x04000823 RID: 2083
	private static int __PropertyOffset_TurnSpeed;

	// Token: 0x04000824 RID: 2084
	private static int __PropertyOffset_OpenDebugNode;

	// Token: 0x04000825 RID: 2085
	private static int __PropertyOffset_IsEditor;
}
