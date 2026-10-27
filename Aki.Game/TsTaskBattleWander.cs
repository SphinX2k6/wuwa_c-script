using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200008A RID: 138
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskBattleWander.TsTaskBattleWander_C")]
public class TsTaskBattleWander : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000113 RID: 275
	// (get) Token: 0x060006CB RID: 1739 RVA: 0x00021A05 File Offset: 0x0001FC05
	// (set) Token: 0x060006CC RID: 1740 RVA: 0x00021A15 File Offset: 0x0001FC15
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int MoveState
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskBattleWander.__PropertyOffset_MoveState);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskBattleWander.__PropertyOffset_MoveState) = value;
		}
	}

	// Token: 0x17000114 RID: 276
	// (get) Token: 0x060006CD RID: 1741 RVA: 0x00021A26 File Offset: 0x0001FC26
	// (set) Token: 0x060006CE RID: 1742 RVA: 0x00021A36 File Offset: 0x0001FC36
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float AllyDetect
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskBattleWander.__PropertyOffset_AllyDetect);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskBattleWander.__PropertyOffset_AllyDetect) = value;
		}
	}

	// Token: 0x17000115 RID: 277
	// (get) Token: 0x060006CF RID: 1743 RVA: 0x00021A47 File Offset: 0x0001FC47
	// (set) Token: 0x060006D0 RID: 1744 RVA: 0x00021A57 File Offset: 0x0001FC57
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool WalkOff
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskBattleWander.__PropertyOffset_WalkOff) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskBattleWander.__PropertyOffset_WalkOff) = (value ? 1 : 0);
		}
	}

	// Token: 0x060006D1 RID: 1745 RVA: 0x00021A68 File Offset: 0x0001FC68
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void InitTsVariables()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("InitTsVariables"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x060006D2 RID: 1746 RVA: 0x00021AD8 File Offset: 0x0001FCD8
	protected void InitTsVariables_Implementation()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsMoveState = this.MoveState;
			this.TsAllyDetect = this.AllyDetect;
			this.TsWalkOff = this.WalkOff;
		}
		if (this.TmpVector == null)
		{
			this.TmpVector = global::Vector.Create();
			this.TmpOffset = global::Vector.Create();
			this.TmpVector2 = global::Vector.Create();
			this.TmpDirection = global::Vector.Create();
			this.TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
			this.LastDestination = global::Vector.Create();
		}
	}

	// Token: 0x060006D3 RID: 1747 RVA: 0x00021B90 File Offset: 0x0001FD90
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

	// Token: 0x060006D4 RID: 1748 RVA: 0x00021C2C File Offset: 0x0001FE2C
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		this.DistanceIndex = 4;
		TsAiController tsAiController = ownerController as TsAiController;
		if (tsAiController == null)
		{
			return;
		}
		AiController aiController = tsAiController.AiController;
		if (!this.TsWalkOff)
		{
			CharacterMoveComponent component = aiController.CharActorComp.Entity.GetComponent<CharacterMoveComponent>();
			if (component != null)
			{
				component.SetWalkOffLedgeRecord(false);
			}
		}
		AiWanderInfos aiWanderInfos = aiController.AiWanderInfos;
		if (((aiWanderInfos != null) ? aiWanderInfos.AiBattleWanderGroups : null) == null || aiController.AiWanderInfos.AiBattleWanderGroups.Count == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "没有配置战斗游荡";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AiBaseId", aiController.AiBase.Value.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.EndTime = Time.Instance.WorldTime + aiController.AiWanderInfos.RandomBattleWanderEndTime();
		aiController.AiWanderInfos.BattleWanderAddTime = 0f;
		this.NextPickDirectTime = 0.0;
		this.NextTriggerTime = 0.0;
		this.NavigationInterval = 3f;
		this.DistanceIndex = -1;
		this.DirectIndex = global::EMoveDirection.None;
	}

	// Token: 0x060006D5 RID: 1749 RVA: 0x00021D44 File Offset: 0x0001FF44
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

	// Token: 0x060006D6 RID: 1750 RVA: 0x00021DE4 File Offset: 0x0001FFE4
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		this.NavigationInterval += deltaSeconds;
		TsAiController tsAiController = ownerController as TsAiController;
		if (tsAiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.Finish(false);
			return;
		}
		AiController aiController = tsAiController.AiController;
		AiWanderInfos aiWanderInfos = aiController.AiWanderInfos;
		if (((aiWanderInfos != null) ? aiWanderInfos.AiBattleWanderGroups : null) == null || aiController.AiWanderInfos.AiBattleWanderGroups.Count == 0)
		{
			base.Finish(false);
			return;
		}
		if (this.EndTime + (double)aiController.AiWanderInfos.BattleWanderAddTime < Time.Instance.WorldTime)
		{
			base.Finish(true);
			return;
		}
		AiBattleWanderGroup wanderData = this.GetWanderData(aiController);
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		EntityHandle currentTarget = aiController.AiHateList.GetCurrentTarget();
		if (currentTarget == null || !currentTarget.Valid)
		{
			base.Finish(false);
			return;
		}
		CharacterActorComponent component = currentTarget.Entity.GetComponent<CharacterActorComponent>();
		if (component == null)
		{
			base.Finish(false);
			return;
		}
		if (Time.Instance.Now < this.NextTriggerTime)
		{
			this.SetInputParams(tsAiController.AiController.CharActorComp, component, wanderData);
			return;
		}
		this.NextTriggerTime = Time.Instance.Now + 500.0;
		component.ActorLocationProxy.Subtraction(charActorComp.ActorLocationProxy, this.TmpOffset);
		GravityUtils.Instance.ConvertToPlanarVectorForActor(charActorComp, this.TmpOffset);
		double num = this.TmpOffset.Size();
		if (num < 1E-08)
		{
			charActorComp.ActorForwardProxy.Multiply(-1.0, this.TmpVector);
			charActorComp.SetInputDirect(this.TmpVector, false);
			return;
		}
		if (num <= (double)wanderData.DistanceRange(0))
		{
			this.DistanceIndex = 0;
			this.DirectIndex = global::EMoveDirection.Backward;
		}
		else if (num > (double)wanderData.DistanceRange(3))
		{
			this.DistanceIndex = 4;
			this.DirectIndex = global::EMoveDirection.Forward;
		}
		else if (this.NextPickDirectTime < Time.Instance.WorldTime)
		{
			this.PickDirect(aiController, wanderData);
			this.NextPickDirectTime = Time.Instance.WorldTime + MathUtils.Instance.GetRandomRange((double)wanderData.WanderTime.Value.Min, (double)wanderData.WanderTime.Value.Max);
		}
		this.SetInputParams(tsAiController.AiController.CharActorComp, component, wanderData);
	}

	// Token: 0x060006D7 RID: 1751 RVA: 0x00022064 File Offset: 0x00020264
	protected override void OnClear()
	{
		TsAiController tsAiController = base.AIOwner as TsAiController;
		if (tsAiController != null)
		{
			BaseMoveComponent component = tsAiController.AiController.CharActorComp.Entity.GetComponent<BaseMoveComponent>();
			if (component != null)
			{
				component.MoveController.StopMoveToLocation("TsTaskBattleWander.OnClear");
			}
			this.LastDestination.Reset();
			AiControllerLibrary.ClearInput(tsAiController);
			if (!this.TsWalkOff && component != null)
			{
				component.SetWalkOffLedgeRecord(true);
			}
		}
	}

	// Token: 0x060006D8 RID: 1752 RVA: 0x000220CC File Offset: 0x000202CC
	private AiBattleWanderGroup GetWanderData(AiController aiController)
	{
		return aiController.AiWanderInfos.GetCurrentBattleWander();
	}

	// Token: 0x060006D9 RID: 1753 RVA: 0x000220DC File Offset: 0x000202DC
	private bool PickDirect(AiController aiController, AiBattleWanderGroup wanderData)
	{
		EntityHandle currentTarget = aiController.AiHateList.GetCurrentTarget();
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (currentTarget == null || !currentTarget.Valid)
		{
			return false;
		}
		CharacterActorComponent component = currentTarget.Entity.GetComponent<CharacterActorComponent>();
		if (component == null)
		{
			return false;
		}
		component.ActorLocationProxy.Subtraction(charActorComp.ActorLocationProxy, this.TmpOffset);
		GravityUtils.Instance.ConvertToPlanarVectorForActor(charActorComp, this.TmpOffset);
		double distance = this.TmpOffset.Size() - (double)charActorComp.ScaledRadius - (double)component.ScaledRadius;
		this.DistanceIndex = this.FindDistanceIndexByDistance(wanderData, distance);
		this.FindDirectByWeights(wanderData);
		this.CheckNavigationAndAllyBlock(aiController, this.TmpOffset, distance);
		CharacterUnifiedStateComponent component2 = aiController.CharAiDesignComp.Entity.GetComponent<CharacterUnifiedStateComponent>();
		if (component2.Valid)
		{
			switch (this.TsMoveState)
			{
			case 1:
				component2.SetMoveState(ECharMoveState.Walk);
				break;
			case 2:
				component2.SetMoveState(ECharMoveState.Run);
				break;
			case 3:
				component2.SetMoveState(ECharMoveState.Sprint);
				break;
			}
		}
		return true;
	}

	// Token: 0x060006DA RID: 1754 RVA: 0x000221E0 File Offset: 0x000203E0
	private int FindDistanceIndexByDistance(AiBattleWanderGroup wanderData, double distance)
	{
		int num = 0;
		while (num < 4 && distance > (double)wanderData.DistanceRange(num))
		{
			num++;
		}
		return num;
	}

	// Token: 0x060006DB RID: 1755 RVA: 0x00022208 File Offset: 0x00020408
	private void FindDirectByWeights(AiBattleWanderGroup wanderData)
	{
		if (this.DistanceIndex == 0)
		{
			this.DirectIndex = global::EMoveDirection.Backward;
			return;
		}
		if (this.DistanceIndex == 4)
		{
			this.DirectIndex = global::EMoveDirection.Forward;
			return;
		}
		int distanceIndex = this.DistanceIndex;
		float[] array;
		if (distanceIndex != 1)
		{
			if (distanceIndex != 2)
			{
				array = wanderData.FarActionRates();
			}
			else
			{
				array = wanderData.MiddleActionRates();
			}
		}
		else
		{
			array = wanderData.NearActionRates();
		}
		double num = MathUtils.Instance.GetRandomRange(0.0, 100.0);
		int num2 = 0;
		while (num2 < array.Length && num >= (double)array[num2])
		{
			num -= (double)array[num2];
			num2++;
		}
		this.DirectIndex = (global::EMoveDirection)num2;
	}

	// Token: 0x060006DC RID: 1756 RVA: 0x000222A4 File Offset: 0x000204A4
	private void CheckNavigationAndAllyBlock(AiController aiController, global::Vector offset, double distance)
	{
		if (this.DirectIndex == global::EMoveDirection.None)
		{
			return;
		}
		if (distance <= 1E-08)
		{
			return;
		}
		this.TmpVector.DeepCopy(offset);
		this.TmpVector.DivisionEqual(distance);
		if (AiControllerLibrary.AllyOnPath(aiController, this.TmpVector, this.TsAllyDetect, this.DirectIndex))
		{
			this.DirectIndex = global::EMoveDirection.None;
			return;
		}
		GravityUtils.Instance.TurnVectorByDirectionInGravityForActor(aiController.CharActorComp, this.TmpVector, this.DirectIndex);
	}

	// Token: 0x060006DD RID: 1757 RVA: 0x00022320 File Offset: 0x00020520
	private void SetInputParams(CharacterActorComponent character, CharacterActorComponent targetCharacter, AiBattleWanderGroup wanderData)
	{
		targetCharacter.ActorLocationProxy.Subtraction(character.ActorLocationProxy, this.TmpOffset);
		this.TmpDirection.DeepCopy(this.TmpOffset);
		GravityUtils.Instance.TurnVectorByDirectionInGravityForActor(character, this.TmpOffset, this.DirectIndex);
		float turnSpeed = (this.TsMoveState == 2) ? wanderData.RunTurnSpeed : wanderData.TurnSpeeds((int)this.DirectIndex);
		if (this.NavigationInterval > 3f)
		{
			this.NavigationInterval = 0f;
			if (this.SetMoveToLocation(this.TmpOffset, character, turnSpeed, targetCharacter.ActorLocationProxy))
			{
				return;
			}
			this.StopMoveToLocation(character);
		}
		if (this.DirectIndex != global::EMoveDirection.None && AiControllerLibrary.NavigationBlockDirectionE(base.AIOwner, character.ActorLocationProxy, character.ActorForwardProxy, this.DirectIndex, 100f, true))
		{
			this.DirectIndex = global::EMoveDirection.None;
			character.ClearInput(false, true);
			return;
		}
		BaseMoveComponent component = character.Entity.GetComponent<BaseMoveComponent>();
		if (component == null || !component.MoveController.IsMovingToLocation())
		{
			BaseUnifiedStateComponent component2 = character.Entity.GetComponent<BaseUnifiedStateComponent>();
			if (component2 == null || component2.MoveState != ECharMoveState.Walk)
			{
				AiControllerLibrary.TurnToDirect(character, this.TmpOffset, turnSpeed, false, 0f);
				character.SetInputDirect(character.ActorForwardProxy, false);
				return;
			}
			AiControllerLibrary.InputNearestDirection(character, this.TmpOffset, this.TmpQuat, this.TmpVector2, turnSpeed, true, this.TmpDirection);
		}
	}

	// Token: 0x060006DE RID: 1758 RVA: 0x00022484 File Offset: 0x00020684
	private void StopMoveToLocation(CharacterActorComponent character)
	{
		BaseMoveComponent component = character.Entity.GetComponent<BaseMoveComponent>();
		if (component != null && component.MoveController.IsMovingToLocation() && component != null)
		{
			component.MoveController.StopMoveToLocation("TsTaskBattleWander.StopMoveToLocation");
		}
		this.LastDestination.Reset();
	}

	// Token: 0x060006DF RID: 1759 RVA: 0x000224CC File Offset: 0x000206CC
	private bool SetMoveToLocation(global::Vector target, CharacterActorComponent actorComp, float turnSpeed, global::Vector facingDirection)
	{
		this.TmpVector2.DeepCopy(target);
		this.TmpVector2.AdditionEqual(actorComp.ActorLocationProxy);
		BaseMoveComponent component = actorComp.Entity.GetComponent<BaseMoveComponent>();
		if (component == null)
		{
			return false;
		}
		if ((!this.LastDestination.IsNearlyZero(9.999999747378752E-05) || global::Vector.Dist(this.LastDestination, this.TmpVector2) < 100.0) && component.MoveController.IsMovingToLocation())
		{
			this.LastDestination.DeepCopy(this.TmpVector2);
			return true;
		}
		this.LastDestination.DeepCopy(this.TmpVector2);
		bool flag = (this.DirectIndex == global::EMoveDirection.Left || this.DirectIndex == global::EMoveDirection.Right) && actorComp.WanderDirectionType == EWanderDirectionType.FB;
		MoveToLocationController moveController = component.MoveController;
		MoveToPointConfigImpl moveToPointConfigImpl = new MoveToPointConfigImpl();
		moveToPointConfigImpl.Position = this.TmpVector2;
		moveToPointConfigImpl.TurnSpeed = new float?(turnSpeed);
		moveToPointConfigImpl.UseNearestDirection = new bool?(!flag);
		moveToPointConfigImpl.FaceToPosition = (flag ? null : facingDirection);
		moveToPointConfigImpl.ResetCondition = (() => false);
		return moveController.NavigateMoveToLocation(moveToPointConfigImpl, new bool?(true), false, "TsTaskBattleWander.SetMoveToLocation");
	}

	// Token: 0x060006E0 RID: 1760 RVA: 0x00022600 File Offset: 0x00020800
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskBattleWander._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskBattleWander.TsTaskBattleWander_C");
		}
		return TsTaskBattleWander._ClassPtr;
	}

	// Token: 0x060006E1 RID: 1761 RVA: 0x00022624 File Offset: 0x00020824
	public TsTaskBattleWander() : this(BuiltinUtils.AllocNativeUObject(TsTaskBattleWander.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060006E2 RID: 1762 RVA: 0x0002264C File Offset: 0x0002084C
	public TsTaskBattleWander(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskBattleWander.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060006E3 RID: 1763 RVA: 0x00022680 File Offset: 0x00020880
	protected TsTaskBattleWander(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060006E4 RID: 1764 RVA: 0x00022701 File Offset: 0x00020901
	protected virtual void __CPPCALL_InitTsVariables_Implementation()
	{
		this.InitTsVariables_Implementation();
	}

	// Token: 0x060006E5 RID: 1765 RVA: 0x0002270C File Offset: 0x0002090C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060006E6 RID: 1766 RVA: 0x0002273C File Offset: 0x0002093C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x040004ED RID: 1261
	private const int MAX_DISTANCE_INDEX = 4;

	// Token: 0x040004EE RID: 1262
	private const int SUM_WEIGHT = 100;

	// Token: 0x040004EF RID: 1263
	private const int TRIGGER_PERIOD = 500;

	// Token: 0x040004F0 RID: 1264
	private const int NAV_INTERVAL_TIME = 3;

	// Token: 0x040004F1 RID: 1265
	private bool IsInitTsVariables;

	// Token: 0x040004F2 RID: 1266
	private int TsMoveState;

	// Token: 0x040004F3 RID: 1267
	private float TsAllyDetect;

	// Token: 0x040004F4 RID: 1268
	private bool TsWalkOff;

	// Token: 0x040004F5 RID: 1269
	private int DistanceIndex;

	// Token: 0x040004F6 RID: 1270
	private global::EMoveDirection DirectIndex = global::EMoveDirection.None;

	// Token: 0x040004F7 RID: 1271
	private double EndTime;

	// Token: 0x040004F8 RID: 1272
	private double NextPickDirectTime;

	// Token: 0x040004F9 RID: 1273
	private global::Vector TmpVector = global::Vector.Create();

	// Token: 0x040004FA RID: 1274
	private global::Vector TmpOffset = global::Vector.Create();

	// Token: 0x040004FB RID: 1275
	private global::Vector TmpDirection = global::Vector.Create();

	// Token: 0x040004FC RID: 1276
	private global::Vector TmpVector2 = global::Vector.Create();

	// Token: 0x040004FD RID: 1277
	private global::Vector LastDestination = global::Vector.Create();

	// Token: 0x040004FE RID: 1278
	private Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x040004FF RID: 1279
	private double NextTriggerTime;

	// Token: 0x04000500 RID: 1280
	private float NavigationInterval;

	// Token: 0x04000501 RID: 1281
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskBattleWander.TsTaskBattleWander_C";

	// Token: 0x04000502 RID: 1282
	private static IntPtr _ClassPtr;

	// Token: 0x04000503 RID: 1283
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000504 RID: 1284
	private static int __PropertyOffset_MoveState;

	// Token: 0x04000505 RID: 1285
	private static int __PropertyOffset_AllyDetect;

	// Token: 0x04000506 RID: 1286
	private static int __PropertyOffset_WalkOff;
}
