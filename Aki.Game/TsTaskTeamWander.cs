using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000C6 RID: 198
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTeamWander.TsTaskTeamWander_C")]
public class TsTaskTeamWander : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000215 RID: 533
	// (get) Token: 0x06000B5F RID: 2911 RVA: 0x00038991 File Offset: 0x00036B91
	// (set) Token: 0x06000B60 RID: 2912 RVA: 0x000389A1 File Offset: 0x00036BA1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float AllyDetect
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTeamWander.__PropertyOffset_AllyDetect);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTeamWander.__PropertyOffset_AllyDetect) = value;
		}
	}

	// Token: 0x17000216 RID: 534
	// (get) Token: 0x06000B61 RID: 2913 RVA: 0x000389B2 File Offset: 0x00036BB2
	// (set) Token: 0x06000B62 RID: 2914 RVA: 0x000389C2 File Offset: 0x00036BC2
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float TurnSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTeamWander.__PropertyOffset_TurnSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTeamWander.__PropertyOffset_TurnSpeed) = value;
		}
	}

	// Token: 0x17000217 RID: 535
	// (get) Token: 0x06000B63 RID: 2915 RVA: 0x000389D3 File Offset: 0x00036BD3
	// (set) Token: 0x06000B64 RID: 2916 RVA: 0x000389E3 File Offset: 0x00036BE3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool WalkOff
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskTeamWander.__PropertyOffset_WalkOff) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskTeamWander.__PropertyOffset_WalkOff) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000B65 RID: 2917 RVA: 0x000389F4 File Offset: 0x00036BF4
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsAllyDetect = this.AllyDetect;
			this.TsTurnSpeed = this.TurnSpeed;
			this.TsWalkOff = this.WalkOff;
		}
	}

	// Token: 0x06000B66 RID: 2918 RVA: 0x00038A30 File Offset: 0x00036C30
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

	// Token: 0x06000B67 RID: 2919 RVA: 0x00038ACC File Offset: 0x00036CCC
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		this.CurrentMoveDirect = global::EMoveDirection.None;
		TsAiController tsAiController = ownerController as TsAiController;
		if (tsAiController == null)
		{
			return;
		}
		AiController aiController = tsAiController.AiController;
		if (!this.TsWalkOff)
		{
			BaseMoveComponent component = aiController.CharActorComp.Entity.GetComponent<BaseMoveComponent>();
			if (component != null)
			{
				component.SetWalkOffLedgeRecord(false);
			}
		}
		aiController.CharActorComp.Entity.GetComponent<CharacterUnifiedStateComponent>().SetMoveState(ECharMoveState.Walk);
		if (this.Destination == null)
		{
			this.Destination = Vector.Create();
			this.LastDestination = Vector.Create();
		}
		if (this.TmpDestinationToTarget == null)
		{
			this.TmpDestinationToTarget = Vector.Create();
			this.TmpSelfToTarget = Vector.Create();
			this.TmpVector = Vector.Create();
			this.TmpVector2 = Vector.Create();
			this.TmpDirection = Vector.Create();
			this.TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
		}
		if (this.BlockDirectionsCache == null)
		{
			this.BlockDirectionsCache = new HashSet<global::EMoveDirection>();
		}
		this.NavigationInterval = 3f;
		this.NextDetectAllyTime = 0.0;
		this.NextTriggerTime = Time.Instance.Now;
		this.FirstFrame = true;
	}

	// Token: 0x06000B68 RID: 2920 RVA: 0x00038C04 File Offset: 0x00036E04
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

	// Token: 0x06000B69 RID: 2921 RVA: 0x00038CA4 File Offset: 0x00036EA4
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
		EntityHandle currentTarget = aiController.AiHateList.GetCurrentTarget();
		if (currentTarget == null || !currentTarget.Valid)
		{
			base.Finish(true);
			return;
		}
		CharacterActorComponent component = currentTarget.Entity.GetComponent<CharacterActorComponent>();
		if (component == null)
		{
			base.Finish(true);
			return;
		}
		if (Time.Instance.Now < this.NextTriggerTime)
		{
			component.ActorLocationProxy.Subtraction(aiController.CharActorComp.ActorLocationProxy, this.TmpSelfToTarget);
			this.TmpDirection.DeepCopy(this.TmpSelfToTarget);
			BaseMoveComponent component2 = aiController.CharActorComp.Entity.GetComponent<BaseMoveComponent>();
			if (component2 == null || !component2.MoveController.IsMovingToLocation())
			{
				this.SetInputParams(aiController.CharActorComp, this.TmpSelfToTarget, this.TmpDirection);
			}
			return;
		}
		this.NextTriggerTime = Time.Instance.Now + 500.0;
		AiAreaMemberData aiTeamAreaMemberData = aiController.AiTeam.GetAiTeamAreaMemberData(aiController);
		if (aiTeamAreaMemberData == null || aiTeamAreaMemberData.AreaIndex < 0)
		{
			return;
		}
		if (this.FirstFrame)
		{
			this.FirstFrame = false;
			if (AiControllerLibrary.InTeamArea(aiController, aiTeamAreaMemberData, 1f))
			{
				base.Finish(true);
				return;
			}
		}
		else if (AiControllerLibrary.InTeamArea(aiController, aiTeamAreaMemberData, 0.5f))
		{
			base.Finish(true);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		Vector actorLocationProxy = component.ActorLocationProxy;
		float num = (aiTeamAreaMemberData.CachedControllerYaw + aiTeamAreaMemberData.AngleCenter) * 0.017453292f;
		this.TmpVector.Set(Math.Cos((double)num) * (double)aiTeamAreaMemberData.DistanceCenter, Math.Sin((double)num) * (double)aiTeamAreaMemberData.DistanceCenter, 0.0);
		aiTeamAreaMemberData.Group.GravityQuat.RotateVector(this.TmpVector, this.Destination);
		this.Destination.AdditionEqual(aiTeamAreaMemberData.CachedTargetLocation);
		GravityUtils.Instance.SetZnInGravityForActor(charActorComp, this.Destination, GravityUtils.Instance.GetZnInGravityForActor(charActorComp, charActorComp.ActorLocationProxy));
		actorLocationProxy.Subtraction(aiController.CharActorComp.ActorLocationProxy, this.TmpSelfToTarget);
		this.TmpDirection.DeepCopy(this.TmpSelfToTarget);
		actorLocationProxy.Subtraction(this.Destination, this.TmpDestinationToTarget);
		GravityUtils.Instance.ConvertToPlanarVectorForActor(charActorComp, this.TmpSelfToTarget);
		GravityUtils.Instance.ConvertToPlanarVectorForActor(charActorComp, this.TmpDestinationToTarget);
		double num2 = this.TmpSelfToTarget.Size();
		double num3 = this.TmpDestinationToTarget.Size();
		if (num2 < 0.0001)
		{
			charActorComp.ActorForwardProxy.Multiply(-1.0, this.TmpSelfToTarget);
		}
		else
		{
			this.TmpSelfToTarget.DivisionEqual(num2);
		}
		if (num3 < 0.0001)
		{
			charActorComp.ActorForwardProxy.Multiply(-1.0, this.TmpDestinationToTarget);
		}
		else
		{
			this.TmpDestinationToTarget.DivisionEqual(num3);
		}
		float num4 = GravityUtils.Instance.GetAngleOffsetInGravityForActor(charActorComp, this.TmpDestinationToTarget, this.TmpSelfToTarget) * 0.017453292f;
		double forwardBackwardLength = num2 - num3;
		double rightLeftLength = num3 * (double)num4;
		if (Time.Instance.Now > this.NextDetectAllyTime)
		{
			this.NextDetectAllyTime = Time.Instance.Now + 1000.0;
			AiControllerLibrary.AllyBlockDirections(aiController, this.TmpSelfToTarget, this.TsAllyDetect, this.BlockDirectionsCache);
		}
		this.UpdateCurrentMoveDirection(forwardBackwardLength, rightLeftLength, aiTeamAreaMemberData, this.BlockDirectionsCache, charActorComp.ActorLocationProxy, this.TmpSelfToTarget);
		if (this.NavigationInterval > 3f)
		{
			this.NavigationInterval = 0f;
			if (this.SetMoveToLocation(this.Destination, aiController.CharActorComp, component))
			{
				return;
			}
			this.StopMoveToLocation(aiController.CharActorComp);
		}
		BaseMoveComponent component3 = charActorComp.Entity.GetComponent<BaseMoveComponent>();
		if (component3 == null || !component3.MoveController.IsMovingToLocation())
		{
			this.SetInputParams(charActorComp, this.TmpSelfToTarget, this.TmpDirection);
		}
	}

	// Token: 0x06000B6A RID: 2922 RVA: 0x000390D8 File Offset: 0x000372D8
	private void UpdateCurrentMoveDirection(double forwardBackwardLength, double rightLeftLength, AiAreaMemberData areaMemberData, HashSet<global::EMoveDirection> blockDirections, Vector selfLocation, Vector forwardDirect)
	{
		if (forwardBackwardLength > (double)areaMemberData.MaxDistanceOffset)
		{
			this.CurrentMoveDirect = this.GetMoveDirectionForwardBackward(forwardBackwardLength);
			return;
		}
		if (rightLeftLength > (double)(areaMemberData.MaxAngleOffset * 0.017453292f * areaMemberData.DistanceCenter))
		{
			this.CurrentMoveDirect = this.GetMoveDirectionRightLeft(rightLeftLength);
			return;
		}
		ValueTuple<global::EMoveDirection, global::EMoveDirection> moveDirection = this.GetMoveDirection(forwardBackwardLength, rightLeftLength);
		global::EMoveDirection emoveDirection = moveDirection.Item1;
		global::EMoveDirection emoveDirection2 = moveDirection.Item2;
		if (blockDirections.Contains(emoveDirection2) || AiControllerLibrary.NavigationBlockDirectionE(base.AIOwner, selfLocation, forwardDirect, emoveDirection2, 100f, true))
		{
			emoveDirection2 = global::EMoveDirection.None;
		}
		if (blockDirections.Contains(emoveDirection) || AiControllerLibrary.NavigationBlockDirectionE(base.AIOwner, selfLocation, forwardDirect, emoveDirection, 100f, true))
		{
			emoveDirection = emoveDirection2;
			emoveDirection2 = global::EMoveDirection.None;
		}
		if (emoveDirection2 == global::EMoveDirection.None)
		{
			this.CurrentMoveDirect = emoveDirection;
			return;
		}
		if (this.CurrentMoveDirect == emoveDirection2)
		{
			if ((this.CurrentMoveDirect == global::EMoveDirection.Forward || this.CurrentMoveDirect == global::EMoveDirection.Backward) && this.NeedChangeDirect(forwardBackwardLength, rightLeftLength))
			{
				this.CurrentMoveDirect = emoveDirection;
				return;
			}
		}
		else
		{
			this.CurrentMoveDirect = emoveDirection;
		}
	}

	// Token: 0x06000B6B RID: 2923 RVA: 0x000391C0 File Offset: 0x000373C0
	private void StopMoveToLocation(CharacterActorComponent character)
	{
		BaseMoveComponent component = character.Entity.GetComponent<BaseMoveComponent>();
		if (component != null && component.MoveController.IsMovingToLocation())
		{
			component.MoveController.StopMoveToLocation("TsTaskTeamWander.StopMoveToLocation");
		}
		this.LastDestination.Reset();
	}

	// Token: 0x06000B6C RID: 2924 RVA: 0x00039204 File Offset: 0x00037404
	private bool SetMoveToLocation(Vector target, CharacterActorComponent actorComp, CharacterActorComponent targetCharacter)
	{
		this.TmpVector2.DeepCopy(target);
		BaseMoveComponent component = actorComp.Entity.GetComponent<BaseMoveComponent>();
		if (component == null)
		{
			return false;
		}
		if ((!this.LastDestination.IsNearlyZero(9.999999747378752E-05) || Vector.Dist(this.LastDestination, this.TmpVector2) < 100.0) && component.MoveController.IsMovingToLocation())
		{
			this.LastDestination.DeepCopy(this.TmpVector2);
			return true;
		}
		this.LastDestination.DeepCopy(this.TmpVector2);
		bool flag = (this.CurrentMoveDirect == global::EMoveDirection.Left || this.CurrentMoveDirect == global::EMoveDirection.Right) && actorComp.WanderDirectionType == EWanderDirectionType.FB;
		MoveToLocationController moveController = component.MoveController;
		MoveToPointConfigImpl moveToPointConfigImpl = new MoveToPointConfigImpl();
		moveToPointConfigImpl.Position = this.TmpVector2;
		moveToPointConfigImpl.UseNearestDirection = new bool?(!flag);
		moveToPointConfigImpl.FaceToPosition = (flag ? null : targetCharacter.ActorLocationProxy);
		moveToPointConfigImpl.ResetCondition = (() => false);
		return moveController.NavigateMoveToLocation(moveToPointConfigImpl, new bool?(true), false, "TsTaskTeamWander.SetMoveToLocation");
	}

	// Token: 0x06000B6D RID: 2925 RVA: 0x00039320 File Offset: 0x00037520
	private void SetInputParams(CharacterActorComponent actorComp, Vector faceToTargetActor, Vector forwardDirect)
	{
		if (this.CurrentMoveDirect == global::EMoveDirection.None)
		{
			AiControllerLibrary.ClearInput((TsAiController)base.AIOwner);
			return;
		}
		this.TmpVector.DeepCopy(forwardDirect);
		GravityUtils.Instance.TurnVectorByDirectionInGravityForActor(actorComp, this.TmpVector, this.CurrentMoveDirect);
		BaseUnifiedStateComponent component = actorComp.Entity.GetComponent<BaseUnifiedStateComponent>();
		if (component == null || component.MoveState != ECharMoveState.Walk)
		{
			AiControllerLibrary.TurnToDirect(actorComp, this.TmpVector, this.TsTurnSpeed, false, 0f);
			actorComp.SetInputDirect(actorComp.ActorForwardProxy, false);
			return;
		}
		AiControllerLibrary.InputNearestDirection(actorComp, this.TmpVector, this.TmpQuat, this.TmpVector2, this.TsTurnSpeed, true, faceToTargetActor);
	}

	// Token: 0x06000B6E RID: 2926 RVA: 0x000393D4 File Offset: 0x000375D4
	[NullableContext(0)]
	private ValueTuple<global::EMoveDirection, global::EMoveDirection> GetMoveDirection(double forwardBackwardLength, double rightLeftLength)
	{
		if (Math.Abs(forwardBackwardLength) > Math.Abs(rightLeftLength))
		{
			return new ValueTuple<global::EMoveDirection, global::EMoveDirection>(this.GetMoveDirectionForwardBackward(forwardBackwardLength), this.GetMoveDirectionRightLeft(rightLeftLength));
		}
		return new ValueTuple<global::EMoveDirection, global::EMoveDirection>(this.GetMoveDirectionRightLeft(rightLeftLength), this.GetMoveDirectionForwardBackward(forwardBackwardLength));
	}

	// Token: 0x06000B6F RID: 2927 RVA: 0x0003940B File Offset: 0x0003760B
	private global::EMoveDirection GetMoveDirectionForwardBackward(double length)
	{
		if (Math.Abs(length) < 10.0)
		{
			return global::EMoveDirection.None;
		}
		if (length <= 0.0)
		{
			return global::EMoveDirection.Backward;
		}
		return global::EMoveDirection.Forward;
	}

	// Token: 0x06000B70 RID: 2928 RVA: 0x0003942F File Offset: 0x0003762F
	private global::EMoveDirection GetMoveDirectionRightLeft(double length)
	{
		if (Math.Abs(length) < 10.0)
		{
			return global::EMoveDirection.None;
		}
		if (length <= 0.0)
		{
			return global::EMoveDirection.Left;
		}
		return global::EMoveDirection.Right;
	}

	// Token: 0x06000B71 RID: 2929 RVA: 0x00039454 File Offset: 0x00037654
	private bool NeedChangeDirect(double lengthMain, double lengthSecond)
	{
		double num = Math.Abs(lengthMain);
		if (num < 10.0)
		{
			return true;
		}
		double num2 = Math.Abs(lengthSecond);
		return num * 1.3 < num2 && num + 500.0 < num2;
	}

	// Token: 0x06000B72 RID: 2930 RVA: 0x0003949C File Offset: 0x0003769C
	protected override void OnClear()
	{
		TsAiController tsAiController = base.AIOwner as TsAiController;
		if (tsAiController != null)
		{
			BaseMoveComponent component = tsAiController.AiController.CharActorComp.Entity.GetComponent<BaseMoveComponent>();
			if (component != null)
			{
				component.MoveController.StopMoveToLocation("TsTaskTeamWander.OnClear");
			}
			this.LastDestination.Reset();
			AiControllerLibrary.ClearInput(tsAiController);
			if (!this.TsWalkOff && component != null)
			{
				component.SetWalkOffLedgeRecord(true);
			}
		}
	}

	// Token: 0x06000B73 RID: 2931 RVA: 0x00039504 File Offset: 0x00037704
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskTeamWander._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTeamWander.TsTaskTeamWander_C");
		}
		return TsTaskTeamWander._ClassPtr;
	}

	// Token: 0x06000B74 RID: 2932 RVA: 0x00039528 File Offset: 0x00037728
	public TsTaskTeamWander() : this(BuiltinUtils.AllocNativeUObject(TsTaskTeamWander.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000B75 RID: 2933 RVA: 0x00039550 File Offset: 0x00037750
	public TsTaskTeamWander(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTeamWander.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000B76 RID: 2934 RVA: 0x00039584 File Offset: 0x00037784
	protected TsTaskTeamWander(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000B77 RID: 2935 RVA: 0x00039628 File Offset: 0x00037828
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000B78 RID: 2936 RVA: 0x00039658 File Offset: 0x00037858
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x040008E2 RID: 2274
	private const int THREADHOLD_ABS = 500;

	// Token: 0x040008E3 RID: 2275
	private const double THREADHOLD_RATIO = 1.3;

	// Token: 0x040008E4 RID: 2276
	private const int THREADHOLD_ARRIVE = 10;

	// Token: 0x040008E5 RID: 2277
	private const int ALLY_DETECT_PERIOD = 1000;

	// Token: 0x040008E6 RID: 2278
	private const int TRIGGER_PERIOD = 500;

	// Token: 0x040008E7 RID: 2279
	private const int NAV_INTERVAL_TIME = 3;

	// Token: 0x040008E8 RID: 2280
	private bool IsInitTsVariables;

	// Token: 0x040008E9 RID: 2281
	private float TsAllyDetect;

	// Token: 0x040008EA RID: 2282
	private float TsTurnSpeed;

	// Token: 0x040008EB RID: 2283
	private bool TsWalkOff;

	// Token: 0x040008EC RID: 2284
	private global::EMoveDirection CurrentMoveDirect = global::EMoveDirection.None;

	// Token: 0x040008ED RID: 2285
	private double NextDetectAllyTime;

	// Token: 0x040008EE RID: 2286
	private Vector Destination = Vector.Create();

	// Token: 0x040008EF RID: 2287
	private Vector LastDestination = Vector.Create();

	// Token: 0x040008F0 RID: 2288
	private Vector TmpDestinationToTarget = Vector.Create();

	// Token: 0x040008F1 RID: 2289
	private Vector TmpSelfToTarget = Vector.Create();

	// Token: 0x040008F2 RID: 2290
	private Vector TmpDirection = Vector.Create();

	// Token: 0x040008F3 RID: 2291
	private Vector TmpVector = Vector.Create();

	// Token: 0x040008F4 RID: 2292
	private Vector TmpVector2 = Vector.Create();

	// Token: 0x040008F5 RID: 2293
	private Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x040008F6 RID: 2294
	private HashSet<global::EMoveDirection> BlockDirectionsCache = new HashSet<global::EMoveDirection>();

	// Token: 0x040008F7 RID: 2295
	private double NextTriggerTime;

	// Token: 0x040008F8 RID: 2296
	private bool FirstFrame;

	// Token: 0x040008F9 RID: 2297
	private float NavigationInterval;

	// Token: 0x040008FA RID: 2298
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTeamWander.TsTaskTeamWander_C";

	// Token: 0x040008FB RID: 2299
	private static IntPtr _ClassPtr;

	// Token: 0x040008FC RID: 2300
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040008FD RID: 2301
	private static int __PropertyOffset_AllyDetect;

	// Token: 0x040008FE RID: 2302
	private static int __PropertyOffset_TurnSpeed;

	// Token: 0x040008FF RID: 2303
	private static int __PropertyOffset_WalkOff;
}
