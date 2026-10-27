using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000AB RID: 171
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPatrolLogic.TsTaskPatrolLogic_C")]
public class TsTaskPatrolLogic : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170001A7 RID: 423
	// (get) Token: 0x0600096E RID: 2414 RVA: 0x0002FB3B File Offset: 0x0002DD3B
	// (set) Token: 0x0600096F RID: 2415 RVA: 0x0002FB4B File Offset: 0x0002DD4B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int MoveState
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPatrolLogic.__PropertyOffset_MoveState);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPatrolLogic.__PropertyOffset_MoveState) = value;
		}
	}

	// Token: 0x170001A8 RID: 424
	// (get) Token: 0x06000970 RID: 2416 RVA: 0x0002FB5C File Offset: 0x0002DD5C
	// (set) Token: 0x06000971 RID: 2417 RVA: 0x0002FB6C File Offset: 0x0002DD6C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool MoveOnePath
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPatrolLogic.__PropertyOffset_MoveOnePath) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPatrolLogic.__PropertyOffset_MoveOnePath) = (value ? 1 : 0);
		}
	}

	// Token: 0x170001A9 RID: 425
	// (get) Token: 0x06000972 RID: 2418 RVA: 0x0002FB7D File Offset: 0x0002DD7D
	// (set) Token: 0x06000973 RID: 2419 RVA: 0x0002FB8D File Offset: 0x0002DD8D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool UseLastMoveIndex
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPatrolLogic.__PropertyOffset_UseLastMoveIndex) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPatrolLogic.__PropertyOffset_UseLastMoveIndex) = (value ? 1 : 0);
		}
	}

	// Token: 0x170001AA RID: 426
	// (get) Token: 0x06000974 RID: 2420 RVA: 0x0002FB9E File Offset: 0x0002DD9E
	// (set) Token: 0x06000975 RID: 2421 RVA: 0x0002FBAE File Offset: 0x0002DDAE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MoveSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPatrolLogic.__PropertyOffset_MoveSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPatrolLogic.__PropertyOffset_MoveSpeed) = value;
		}
	}

	// Token: 0x170001AB RID: 427
	// (get) Token: 0x06000976 RID: 2422 RVA: 0x0002FBBF File Offset: 0x0002DDBF
	// (set) Token: 0x06000977 RID: 2423 RVA: 0x0002FBCF File Offset: 0x0002DDCF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool CheckObstacles
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPatrolLogic.__PropertyOffset_CheckObstacles) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPatrolLogic.__PropertyOffset_CheckObstacles) = (value ? 1 : 0);
		}
	}

	// Token: 0x170001AC RID: 428
	// (get) Token: 0x06000978 RID: 2424 RVA: 0x0002FBE0 File Offset: 0x0002DDE0
	// (set) Token: 0x06000979 RID: 2425 RVA: 0x0002FBF0 File Offset: 0x0002DDF0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CheckObstacleTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPatrolLogic.__PropertyOffset_CheckObstacleTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPatrolLogic.__PropertyOffset_CheckObstacleTime) = value;
		}
	}

	// Token: 0x170001AD RID: 429
	// (get) Token: 0x0600097A RID: 2426 RVA: 0x0002FC01 File Offset: 0x0002DE01
	// (set) Token: 0x0600097B RID: 2427 RVA: 0x0002FC11 File Offset: 0x0002DE11
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CheckObstacleLength
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPatrolLogic.__PropertyOffset_CheckObstacleLength);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPatrolLogic.__PropertyOffset_CheckObstacleLength) = value;
		}
	}

	// Token: 0x0600097C RID: 2428 RVA: 0x0002FC24 File Offset: 0x0002DE24
	private void InitTsVariables()
	{
		this.TsMoveState = this.MoveState;
		this.TsMoveOnePath = this.MoveOnePath;
		this.TsCheckObstacleLength = this.CheckObstacleLength;
		this.TsCheckObstacleTime = this.CheckObstacleTime;
		this.TsCheckObstacles = this.CheckObstacles;
		this.TsUseLastMoveIndex = this.UseLastMoveIndex;
		this.TsMoveSpeed = this.MoveSpeed;
		this.IsInitTsVariables = true;
	}

	// Token: 0x0600097D RID: 2429 RVA: 0x0002FC8C File Offset: 0x0002DE8C
	[NullableContext(1)]
	private void InitComp(AiController aiController)
	{
		this.FrameRate = (float)GameSettingsDeviceRender.Instance.FrameRate;
		this.FrameSeconds = GameSettingsDeviceRender.Instance.FrameSeconds;
		this.PatrolLogic = aiController.AiPatrol;
		this.PatrolConfig = this.PatrolLogic.GetConfig();
		if (this.PatrolConfig == null)
		{
			base.Finish(false);
			return;
		}
		this.IsMoveFlyingState = this.PatrolConfig.ContainZ;
		this.Entity = aiController.CharAiDesignComp.Entity;
		this.ActorComp = aiController.CharActorComp;
		this.MoveComp = this.Entity.GetComponent<BaseMoveComponent>();
		if (this.IsMoveFlyingState && this.MoveComp != null)
		{
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
				{
					Mode = EMovementMode.MOVE_Flying,
					Context = "[TsTaskPatrolLogic.InitComp]"
				});
			}
		}
		this.StateComp = this.Entity.GetComponent<BaseUnifiedStateComponent>();
		this.AnimComp = this.Entity.GetComponent<CharacterAnimationComponent>();
		if (!this.PatrolLogic.IsInitialized)
		{
			this.PatrolLogic.GeneratePatrol(false);
		}
		this.IsSplineLoading = true;
		this.IsInitComp = true;
	}

	// Token: 0x0600097E RID: 2430 RVA: 0x0002FDAC File Offset: 0x0002DFAC
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

	// Token: 0x0600097F RID: 2431 RVA: 0x0002FE48 File Offset: 0x0002E048
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.InitTsVariables();
		}
		if (!this.IsInitComp)
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
			this.InitComp(aiController);
		}
		this.InitBaseInfo();
		if (this.TraceElement == null)
		{
			this.InitTraceElement();
		}
	}

	// Token: 0x06000980 RID: 2432 RVA: 0x0002FEDE File Offset: 0x0002E0DE
	private void InitBaseInfo()
	{
		if (this.CacheVector == null)
		{
			this.CacheVector = Vector.Create();
		}
		this.CurTime = 0f;
		this.IsPause = false;
		this.ForceExit = false;
		this.IsAvoidObstacles = false;
	}

	// Token: 0x06000981 RID: 2433 RVA: 0x0002FF14 File Offset: 0x0002E114
	private void InitTraceElement()
	{
		this.TraceElement = new UTraceCapsuleElement();
		this.TraceElement.bIsSingle = true;
		this.TraceElement.bIgnoreSelf = true;
		this.TraceElement.AddObjectTypeQuery(KuroObjectTypeQuery.Pawn);
		this.TraceElement.HalfHeight = this.ActorComp.DefaultHalfHeight;
		this.TraceElement.Radius = this.ActorComp.DefaultRadius;
		this.TraceElement.WorldContextObject = this.ActorComp.Owner;
	}

	// Token: 0x06000982 RID: 2434 RVA: 0x0002FF96 File Offset: 0x0002E196
	[NullableContext(1)]
	private bool SetTraceElement(Vector startLocation, Vector endLocation)
	{
		TraceElementCommon.Instance.SetStartLocation(this.TraceElement, startLocation);
		TraceElementCommon.Instance.SetEndLocation(this.TraceElement, endLocation);
		return TraceElementCommon.Instance.CapsuleTrace(this.TraceElement, "TsTaskNpcPatrol_GetObstacleLocation");
	}

	// Token: 0x06000983 RID: 2435 RVA: 0x0002FFD0 File Offset: 0x0002E1D0
	private void CallOutside()
	{
		if (GlobalData.BpEventManager == null)
		{
			return;
		}
		AiPatrolController patrolLogic = this.PatrolLogic;
		PatrolPoint patrolPoint = (patrolLogic != null) ? patrolLogic.PatrolPoint : null;
		if (patrolPoint == null || !patrolPoint.IsMain)
		{
			return;
		}
		GlobalData.BpEventManager.AI巡逻达到样条点.Broadcast(this.ActorComp.Actor, this.PatrolLogic.PatrolIndex);
	}

	// Token: 0x06000984 RID: 2436 RVA: 0x0003002C File Offset: 0x0002E22C
	private void InitPatrolInfo()
	{
		CreatureDataComponent creatureData = this.ActorComp.CreatureData;
		this.PatrolLogic.StartPatrol(this.TsUseLastMoveIndex, new Action(this.CallOutside));
		creatureData.SetPosAbnormal(false);
		this.PatrolLogic.ResetBaseInfoByMainPoint(this.MoveComp, this.StateComp, this.TsMoveState);
	}

	// Token: 0x06000985 RID: 2437 RVA: 0x00030084 File Offset: 0x0002E284
	private bool CheckSplineLoading()
	{
		if (this.IsSplineLoading)
		{
			AiPatrolController patrolLogic = this.PatrolLogic;
			if (patrolLogic != null && patrolLogic.IsInitialized)
			{
				this.IsSplineLoading = false;
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000986 RID: 2438 RVA: 0x000300AC File Offset: 0x0002E2AC
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

	// Token: 0x06000987 RID: 2439 RVA: 0x0003014C File Offset: 0x0002E34C
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		if (this.ForceExit)
		{
			base.Finish(false);
			return;
		}
		if (this.IsPause)
		{
			return;
		}
		if (this.CheckSplineLoading())
		{
			this.InitPatrolInfo();
			this.PatrolLogic.CheckPatrolEnd();
			return;
		}
		this.CurTime += deltaSeconds;
		if (this.TsCheckObstacles && this.CurTime > this.TsCheckObstacleTime)
		{
			this.CurTime = 0f;
			this.ExecuteObstacle();
			if (this.IsAvoidObstacles)
			{
				return;
			}
		}
		if (this.PatrolLogic == null || this.CheckMoveEnd(this.PatrolLogic.PatrolPoint))
		{
			this.PatrolFinish();
			base.Finish(true);
			return;
		}
		if (!this.CheckCanMove())
		{
			return;
		}
		this.MoveToPatrolPoint(deltaSeconds);
	}

	// Token: 0x06000988 RID: 2440 RVA: 0x00030204 File Offset: 0x0002E404
	private bool CheckCanMove()
	{
		return !this.ForceExit && !this.IsPause && this.MoveComp != null && this.MoveComp.CanMove() && this.MoveComp.CanUpdateMovingRotation();
	}

	// Token: 0x06000989 RID: 2441 RVA: 0x0003023C File Offset: 0x0002E43C
	private void MoveToPatrolPoint(float deltaSeconds)
	{
		this.CacheVector.FromUeVector(this.PatrolLogic.PatrolPoint.Point);
		this.CacheVector.SubtractionEqual(this.ActorComp.ActorLocationProxy);
		if (!this.IsMoveFlyingState)
		{
			this.CacheVector.Z -= (double)this.ActorComp.HalfHeight;
		}
		double x = this.CacheVector.X;
		double y = this.CacheVector.Y;
		double z = this.CacheVector.Z;
		this.CacheVector.Z = 0.0;
		double distance = this.CacheVector.Size();
		this.CacheVector.Z = z;
		this.TurnToDirect(this.CacheVector, distance, deltaSeconds);
		this.CacheVector.Set(x, y, z);
		this.MoveCharacter(this.CacheVector, distance, deltaSeconds);
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x0003031C File Offset: 0x0002E51C
	private bool TurnToNextPoint()
	{
		AiPatrolController patrolLogic = this.PatrolLogic;
		if (((patrolLogic != null) ? patrolLogic.PatrolPoint : null) == null)
		{
			return false;
		}
		this.CacheVector.FromUeVector(this.PatrolLogic.PatrolPoint.Point);
		this.CacheVector.SubtractionEqual(this.ActorComp.ActorLocationProxy);
		return this.CacheVector.Size() < 100.0 && this.PatrolLogic.CheckPatrolEnd();
	}

	// Token: 0x0600098B RID: 2443 RVA: 0x00030394 File Offset: 0x0002E594
	[NullableContext(1)]
	private bool CheckMoveEnd(PatrolPoint curPoint)
	{
		if (this.TurnToNextPoint())
		{
			return true;
		}
		if (curPoint != this.PatrolLogic.PatrolPoint)
		{
			if (this.TsMoveOnePath && curPoint.IsMain && !curPoint.IsIgnorePoint && curPoint.Actions != null)
			{
				LevelGeneralController.Instance.ExecuteActionsNew(curPoint.Actions, EntityContext.Create(this.Entity.Id, null), null);
			}
			if (this.PatrolLogic.PatrolPoint.IsMain)
			{
				this.CallOutside();
				this.PatrolLogic.ResetBaseInfoByMainPoint(this.MoveComp, this.StateComp, this.TsMoveState);
			}
		}
		return false;
	}

	// Token: 0x0600098C RID: 2444 RVA: 0x0003043C File Offset: 0x0002E63C
	[NullableContext(1)]
	private void TurnToDirect(Vector moveDirect, double distance, float deltaSeconds)
	{
		this.CacheVector.FromUeVector(moveDirect);
		this.CacheVector.Normalize(9.99999993922529E-09);
		float speed = 540f;
		if (distance < 100.0)
		{
			speed = 10000f;
		}
		this.MoveComp.SmoothCharacterRotation(Rotator.Create(0f, (float)MathUtils.Instance.GetAngleByVector2D(this.CacheVector), 0f), speed, deltaSeconds, false, "Movement.SmoothCharacterRotation", true);
	}

	// Token: 0x0600098D RID: 2445 RVA: 0x000304B8 File Offset: 0x0002E6B8
	[NullableContext(1)]
	private void MoveCharacter(Vector moveDirect, double distance, float deltaSeconds)
	{
		this.CacheVector.FromUeVector(moveDirect);
		this.CacheVector.Normalize(9.99999993922529E-09);
		if (!this.CacheVector.IsNearlyZero(9.999999747378752E-05))
		{
			float num = this.TsMoveSpeed / this.FrameRate * (deltaSeconds / this.FrameSeconds);
			float num2 = deltaSeconds;
			this.CacheVector.Addition(this.ActorComp.ActorForwardProxy, this.CacheVector);
			this.CacheVector.Normalize(9.99999993922529E-09);
			this.CacheVector.MultiplyEqual((double)num);
			CharacterAnimationComponent animComp = this.AnimComp;
			FTransformDouble? ftransformDouble = (animComp != null) ? new FTransformDouble?(animComp.GetMeshTransform()) : null;
			if ((double)num > distance)
			{
				num2 = (float)(distance / (double)this.TsMoveSpeed);
				this.SetPatrolPointLocation();
			}
			else
			{
				this.MoveComp.MoveCharacter(this.CacheVector, num2, "");
			}
			CharacterAnimationComponent animComp2 = this.AnimComp;
			if (animComp2 != null && animComp2.Valid && this.Entity.GetTickInterval() > 1)
			{
				AActor owner = this.ActorComp.Owner;
				if (owner != null && owner.WasRecentlyRenderedOnScreen(0.2f) && ftransformDouble != null)
				{
					this.AnimComp.SetModelBuffer(ftransformDouble.Value, num2 * 1000f * CharacterModel.Instance.InverseSelfCenteredTimeDilation);
				}
			}
		}
		else if (this.Entity.GetTickInterval() <= 1)
		{
			this.AnimComp.StopModelBuffer();
		}
		this.MoveComp.IsSpecialMove = true;
		this.MoveComp.HasMoveInput = true;
		this.MoveComp.Speed = this.TsMoveSpeed;
	}

	// Token: 0x0600098E RID: 2446 RVA: 0x0003065C File Offset: 0x0002E85C
	private void SetPatrolPointLocation()
	{
		this.CacheVector.FromUeVector(this.PatrolLogic.PatrolPoint.Point);
		if (!this.IsMoveFlyingState)
		{
			this.CacheVector.Z += (double)this.ActorComp.HalfHeight;
		}
		this.ActorComp.SetActorLocation(this.CacheVector.ToUeVector(false), "角色移动到位置.MoveCharacter", false);
	}

	// Token: 0x0600098F RID: 2447 RVA: 0x000306C8 File Offset: 0x0002E8C8
	private void ExecuteObstacle()
	{
		AiPatrolController patrolLogic = this.PatrolLogic;
		bool flag;
		if (patrolLogic == null)
		{
			flag = (null != null);
		}
		else
		{
			PatrolPoint patrolPoint = patrolLogic.PatrolPoint;
			flag = (((patrolPoint != null) ? patrolPoint.Point : null) != null);
		}
		if (!flag)
		{
			this.IsAvoidObstacles = false;
			return;
		}
		this.CacheVector.FromUeVector(this.PatrolLogic.PatrolPoint.Point);
		this.CacheVector.SubtractionEqual(this.ActorComp.ActorLocationProxy);
		this.CacheVector.Z = 0.0;
		this.CacheVector.Normalize(9.99999993922529E-09);
		this.CacheVector.MultiplyEqual((double)this.TsCheckObstacleLength);
		this.CacheVector.AdditionEqual(this.ActorComp.ActorLocationProxy);
		bool flag2 = this.SetTraceElement(this.ActorComp.ActorLocationProxy, this.CacheVector);
		UKuroHitResult hitResult = this.TraceElement.HitResult;
		if (!flag2 || (hitResult == null || !hitResult.bBlockingHit))
		{
			this.IsAvoidObstacles = false;
			return;
		}
		if (!this.IsAvoidObstacles)
		{
			this.StopMove();
		}
		this.IsAvoidObstacles = true;
	}

	// Token: 0x06000990 RID: 2448 RVA: 0x000307D8 File Offset: 0x0002E9D8
	private void StopMove()
	{
		if (this.AnimComp != null)
		{
			this.AnimComp.StopModelBuffer();
		}
		if (this.MoveComp != null)
		{
			this.MoveComp.Speed = 0f;
			this.MoveComp.HasMoveInput = false;
			this.MoveComp.IsSpecialMove = false;
			this.MoveComp.StopMove(true, "TsTaskPatrolLogic.OnClear");
		}
		if (this.ActorComp != null)
		{
			this.ActorComp.ClearInput(false, true);
		}
	}

	// Token: 0x06000991 RID: 2449 RVA: 0x0003084E File Offset: 0x0002EA4E
	private void PatrolFinish()
	{
		this.ForceExit = true;
		this.StopMove();
		this.CallOutside();
		AiPatrolController patrolLogic = this.PatrolLogic;
		if (patrolLogic == null)
		{
			return;
		}
		patrolLogic.PatrolFinish();
	}

	// Token: 0x06000992 RID: 2450 RVA: 0x00030873 File Offset: 0x0002EA73
	protected override void OnAbort()
	{
		this.PatrolFinish();
	}

	// Token: 0x06000993 RID: 2451 RVA: 0x0003087B File Offset: 0x0002EA7B
	protected override void OnClear()
	{
		if (!(base.AIOwner is TsAiController))
		{
			return;
		}
		this.StopMove();
		this.CurTime = 0f;
		this.ForceExit = false;
		this.IsPause = false;
	}

	// Token: 0x06000994 RID: 2452 RVA: 0x000308AA File Offset: 0x0002EAAA
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskPatrolLogic._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPatrolLogic.TsTaskPatrolLogic_C");
		}
		return TsTaskPatrolLogic._ClassPtr;
	}

	// Token: 0x06000995 RID: 2453 RVA: 0x000308D0 File Offset: 0x0002EAD0
	public TsTaskPatrolLogic() : this(BuiltinUtils.AllocNativeUObject(TsTaskPatrolLogic.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000996 RID: 2454 RVA: 0x000308F8 File Offset: 0x0002EAF8
	[NullableContext(1)]
	public TsTaskPatrolLogic(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPatrolLogic.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000997 RID: 2455 RVA: 0x0003092B File Offset: 0x0002EB2B
	protected TsTaskPatrolLogic(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000998 RID: 2456 RVA: 0x00030940 File Offset: 0x0002EB40
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000999 RID: 2457 RVA: 0x00030970 File Offset: 0x0002EB70
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000742 RID: 1858
	[Nullable(1)]
	private const string PROFILE_KEY = "TsTaskNpcPatrol_GetObstacleLocation";

	// Token: 0x04000743 RID: 1859
	private const float PATROL_TURN_SPEED = 540f;

	// Token: 0x04000744 RID: 1860
	private const float NO_FORWARD_DISTANCE = 100f;

	// Token: 0x04000745 RID: 1861
	private const float NO_FORWARD_TURN_SPEED = 10000f;

	// Token: 0x04000746 RID: 1862
	private int TsMoveState;

	// Token: 0x04000747 RID: 1863
	private bool TsMoveOnePath;

	// Token: 0x04000748 RID: 1864
	private bool TsUseLastMoveIndex;

	// Token: 0x04000749 RID: 1865
	private float TsMoveSpeed;

	// Token: 0x0400074A RID: 1866
	private bool TsCheckObstacles;

	// Token: 0x0400074B RID: 1867
	private float TsCheckObstacleTime;

	// Token: 0x0400074C RID: 1868
	private float TsCheckObstacleLength;

	// Token: 0x0400074D RID: 1869
	private Entity Entity;

	// Token: 0x0400074E RID: 1870
	private CharacterActorComponent ActorComp;

	// Token: 0x0400074F RID: 1871
	private BaseMoveComponent MoveComp;

	// Token: 0x04000750 RID: 1872
	private BaseUnifiedStateComponent StateComp;

	// Token: 0x04000751 RID: 1873
	private CharacterAnimationComponent AnimComp;

	// Token: 0x04000752 RID: 1874
	private AiPatrolController PatrolLogic;

	// Token: 0x04000753 RID: 1875
	private AiPatrolConfig PatrolConfig;

	// Token: 0x04000754 RID: 1876
	private UTraceCapsuleElement TraceElement;

	// Token: 0x04000755 RID: 1877
	private bool IsSplineLoading;

	// Token: 0x04000756 RID: 1878
	private bool IsInitTsVariables;

	// Token: 0x04000757 RID: 1879
	private bool IsInitComp;

	// Token: 0x04000758 RID: 1880
	private bool IsAvoidObstacles;

	// Token: 0x04000759 RID: 1881
	[Nullable(1)]
	private Vector CacheVector = Vector.Create();

	// Token: 0x0400075A RID: 1882
	private float CurTime;

	// Token: 0x0400075B RID: 1883
	private bool IsMoveFlyingState;

	// Token: 0x0400075C RID: 1884
	private float FrameSeconds;

	// Token: 0x0400075D RID: 1885
	private float FrameRate;

	// Token: 0x0400075E RID: 1886
	private bool IsPause;

	// Token: 0x0400075F RID: 1887
	private bool ForceExit;

	// Token: 0x04000760 RID: 1888
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPatrolLogic.TsTaskPatrolLogic_C";

	// Token: 0x04000761 RID: 1889
	private static IntPtr _ClassPtr;

	// Token: 0x04000762 RID: 1890
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000763 RID: 1891
	private static int __PropertyOffset_MoveState;

	// Token: 0x04000764 RID: 1892
	private static int __PropertyOffset_MoveOnePath;

	// Token: 0x04000765 RID: 1893
	private static int __PropertyOffset_UseLastMoveIndex;

	// Token: 0x04000766 RID: 1894
	private static int __PropertyOffset_MoveSpeed;

	// Token: 0x04000767 RID: 1895
	private static int __PropertyOffset_CheckObstacles;

	// Token: 0x04000768 RID: 1896
	private static int __PropertyOffset_CheckObstacleTime;

	// Token: 0x04000769 RID: 1897
	private static int __PropertyOffset_CheckObstacleLength;
}
