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
	// Token: 0x17000218 RID: 536
	// (get) Token: 0x06000B65 RID: 2917 RVA: 0x00039B95 File Offset: 0x00037D95
	// (set) Token: 0x06000B66 RID: 2918 RVA: 0x00039BA5 File Offset: 0x00037DA5
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

	// Token: 0x17000219 RID: 537
	// (get) Token: 0x06000B67 RID: 2919 RVA: 0x00039BB6 File Offset: 0x00037DB6
	// (set) Token: 0x06000B68 RID: 2920 RVA: 0x00039BC6 File Offset: 0x00037DC6
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

	// Token: 0x1700021A RID: 538
	// (get) Token: 0x06000B69 RID: 2921 RVA: 0x00039BD7 File Offset: 0x00037DD7
	// (set) Token: 0x06000B6A RID: 2922 RVA: 0x00039BE7 File Offset: 0x00037DE7
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

	// Token: 0x06000B6B RID: 2923 RVA: 0x00039BF8 File Offset: 0x00037DF8
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

	// Token: 0x06000B6C RID: 2924 RVA: 0x00039C34 File Offset: 0x00037E34
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskTeamWander) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskTeamWander.StaticClass(), out intPtr, out num))
		{
			this.ReceiveExecuteAI_Implementation(ownerController, controlledPawn);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000B6D RID: 2925 RVA: 0x00039CE4 File Offset: 0x00037EE4
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		this.CurrentMoveDirect = EMoveDirection.None;
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
			this.BlockDirectionsCache = new HashSet<EMoveDirection>();
		}
		this.NavigationInterval = 3f;
		this.NextDetectAllyTime = 0.0;
		this.NextTriggerTime = Time.Instance.Now;
		this.FirstFrame = true;
	}

	// Token: 0x06000B6E RID: 2926 RVA: 0x00039E1C File Offset: 0x0003801C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskTeamWander) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskTeamWander.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000B6F RID: 2927 RVA: 0x00039ED4 File Offset: 0x000380D4
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

	// Token: 0x06000B70 RID: 2928 RVA: 0x0003A308 File Offset: 0x00038508
	private void UpdateCurrentMoveDirection(double forwardBackwardLength, double rightLeftLength, AiAreaMemberData areaMemberData, HashSet<EMoveDirection> blockDirections, Vector selfLocation, Vector forwardDirect)
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
		ValueTuple<EMoveDirection, EMoveDirection> moveDirection = this.GetMoveDirection(forwardBackwardLength, rightLeftLength);
		EMoveDirection emoveDirection = moveDirection.Item1;
		EMoveDirection emoveDirection2 = moveDirection.Item2;
		if (blockDirections.Contains(emoveDirection2) || AiControllerLibrary.NavigationBlockDirectionE(base.AIOwner, selfLocation, forwardDirect, emoveDirection2, 100f, true))
		{
			emoveDirection2 = EMoveDirection.None;
		}
		if (blockDirections.Contains(emoveDirection) || AiControllerLibrary.NavigationBlockDirectionE(base.AIOwner, selfLocation, forwardDirect, emoveDirection, 100f, true))
		{
			emoveDirection = emoveDirection2;
			emoveDirection2 = EMoveDirection.None;
		}
		if (emoveDirection2 == EMoveDirection.None)
		{
			this.CurrentMoveDirect = emoveDirection;
			return;
		}
		if (this.CurrentMoveDirect == emoveDirection2)
		{
			if ((this.CurrentMoveDirect == EMoveDirection.Forward || this.CurrentMoveDirect == EMoveDirection.Backward) && this.NeedChangeDirect(forwardBackwardLength, rightLeftLength))
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

	// Token: 0x06000B71 RID: 2929 RVA: 0x0003A3F0 File Offset: 0x000385F0
	private void StopMoveToLocation(CharacterActorComponent character)
	{
		BaseMoveComponent component = character.Entity.GetComponent<BaseMoveComponent>();
		if (component != null && component.MoveController.IsMovingToLocation())
		{
			component.MoveController.StopMoveToLocation("TsTaskTeamWander.StopMoveToLocation");
		}
		this.LastDestination.Reset();
	}

	// Token: 0x06000B72 RID: 2930 RVA: 0x0003A434 File Offset: 0x00038634
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
		bool flag = (this.CurrentMoveDirect == EMoveDirection.Left || this.CurrentMoveDirect == EMoveDirection.Right) && actorComp.WanderDirectionType == EWanderDirectionType.FB;
		MoveToLocationController moveController = component.MoveController;
		MoveToPointConfigImpl moveToPointConfigImpl = new MoveToPointConfigImpl();
		moveToPointConfigImpl.Position = this.TmpVector2;
		moveToPointConfigImpl.UseNearestDirection = new bool?(!flag);
		moveToPointConfigImpl.FaceToPosition = (flag ? null : targetCharacter.ActorLocationProxy);
		moveToPointConfigImpl.ResetCondition = (() => false);
		return moveController.NavigateMoveToLocation(moveToPointConfigImpl, new bool?(true), false, "TsTaskTeamWander.SetMoveToLocation");
	}

	// Token: 0x06000B73 RID: 2931 RVA: 0x0003A550 File Offset: 0x00038750
	private void SetInputParams(CharacterActorComponent actorComp, Vector faceToTargetActor, Vector forwardDirect)
	{
		if (this.CurrentMoveDirect == EMoveDirection.None)
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
			actorComp.SetInputDirect(actorComp.ActorForwardProxy, false, EInputDirectSpace.World);
			return;
		}
		AiControllerLibrary.InputNearestDirection(actorComp, this.TmpVector, this.TmpQuat, this.TmpVector2, this.TsTurnSpeed, true, faceToTargetActor);
	}

	// Token: 0x06000B74 RID: 2932 RVA: 0x0003A605 File Offset: 0x00038805
	[NullableContext(0)]
	private ValueTuple<EMoveDirection, EMoveDirection> GetMoveDirection(double forwardBackwardLength, double rightLeftLength)
	{
		if (Math.Abs(forwardBackwardLength) > Math.Abs(rightLeftLength))
		{
			return new ValueTuple<EMoveDirection, EMoveDirection>(this.GetMoveDirectionForwardBackward(forwardBackwardLength), this.GetMoveDirectionRightLeft(rightLeftLength));
		}
		return new ValueTuple<EMoveDirection, EMoveDirection>(this.GetMoveDirectionRightLeft(rightLeftLength), this.GetMoveDirectionForwardBackward(forwardBackwardLength));
	}

	// Token: 0x06000B75 RID: 2933 RVA: 0x0003A63C File Offset: 0x0003883C
	private EMoveDirection GetMoveDirectionForwardBackward(double length)
	{
		if (Math.Abs(length) < 10.0)
		{
			return EMoveDirection.None;
		}
		if (length <= 0.0)
		{
			return EMoveDirection.Backward;
		}
		return EMoveDirection.Forward;
	}

	// Token: 0x06000B76 RID: 2934 RVA: 0x0003A660 File Offset: 0x00038860
	private EMoveDirection GetMoveDirectionRightLeft(double length)
	{
		if (Math.Abs(length) < 10.0)
		{
			return EMoveDirection.None;
		}
		if (length <= 0.0)
		{
			return EMoveDirection.Left;
		}
		return EMoveDirection.Right;
	}

	// Token: 0x06000B77 RID: 2935 RVA: 0x0003A684 File Offset: 0x00038884
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

	// Token: 0x06000B78 RID: 2936 RVA: 0x0003A6CC File Offset: 0x000388CC
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

	// Token: 0x06000B79 RID: 2937 RVA: 0x0003A734 File Offset: 0x00038934
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskTeamWander._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTeamWander.TsTaskTeamWander_C");
		}
		return TsTaskTeamWander._ClassPtr;
	}

	// Token: 0x06000B7A RID: 2938 RVA: 0x0003A758 File Offset: 0x00038958
	public TsTaskTeamWander() : this(BuiltinUtils.AllocNativeUObject(TsTaskTeamWander.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000B7B RID: 2939 RVA: 0x0003A780 File Offset: 0x00038980
	public TsTaskTeamWander(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskTeamWander.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000B7C RID: 2940 RVA: 0x0003A7B4 File Offset: 0x000389B4
	protected TsTaskTeamWander(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000B7D RID: 2941 RVA: 0x0003A858 File Offset: 0x00038A58
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000B7E RID: 2942 RVA: 0x0003A888 File Offset: 0x00038A88
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x040008EA RID: 2282
	private const int THREADHOLD_ABS = 500;

	// Token: 0x040008EB RID: 2283
	private const double THREADHOLD_RATIO = 1.3;

	// Token: 0x040008EC RID: 2284
	private const int THREADHOLD_ARRIVE = 10;

	// Token: 0x040008ED RID: 2285
	private const int ALLY_DETECT_PERIOD = 1000;

	// Token: 0x040008EE RID: 2286
	private const int TRIGGER_PERIOD = 500;

	// Token: 0x040008EF RID: 2287
	private const int NAV_INTERVAL_TIME = 3;

	// Token: 0x040008F0 RID: 2288
	private bool IsInitTsVariables;

	// Token: 0x040008F1 RID: 2289
	private float TsAllyDetect;

	// Token: 0x040008F2 RID: 2290
	private float TsTurnSpeed;

	// Token: 0x040008F3 RID: 2291
	private bool TsWalkOff;

	// Token: 0x040008F4 RID: 2292
	private EMoveDirection CurrentMoveDirect = EMoveDirection.None;

	// Token: 0x040008F5 RID: 2293
	private double NextDetectAllyTime;

	// Token: 0x040008F6 RID: 2294
	private Vector Destination = Vector.Create();

	// Token: 0x040008F7 RID: 2295
	private Vector LastDestination = Vector.Create();

	// Token: 0x040008F8 RID: 2296
	private Vector TmpDestinationToTarget = Vector.Create();

	// Token: 0x040008F9 RID: 2297
	private Vector TmpSelfToTarget = Vector.Create();

	// Token: 0x040008FA RID: 2298
	private Vector TmpDirection = Vector.Create();

	// Token: 0x040008FB RID: 2299
	private Vector TmpVector = Vector.Create();

	// Token: 0x040008FC RID: 2300
	private Vector TmpVector2 = Vector.Create();

	// Token: 0x040008FD RID: 2301
	private Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x040008FE RID: 2302
	private HashSet<EMoveDirection> BlockDirectionsCache = new HashSet<EMoveDirection>();

	// Token: 0x040008FF RID: 2303
	private double NextTriggerTime;

	// Token: 0x04000900 RID: 2304
	private bool FirstFrame;

	// Token: 0x04000901 RID: 2305
	private float NavigationInterval;

	// Token: 0x04000902 RID: 2306
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskTeamWander.TsTaskTeamWander_C";

	// Token: 0x04000903 RID: 2307
	private static IntPtr _ClassPtr;

	// Token: 0x04000904 RID: 2308
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000905 RID: 2309
	private static int __PropertyOffset_AllyDetect;

	// Token: 0x04000906 RID: 2310
	private static int __PropertyOffset_TurnSpeed;

	// Token: 0x04000907 RID: 2311
	private static int __PropertyOffset_WalkOff;
}
