using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200007B RID: 123
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskNpcPatrol.TsTaskNpcPatrol_C")]
public class TsTaskNpcPatrol : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000EC RID: 236
	// (get) Token: 0x060005C9 RID: 1481 RVA: 0x0001CFB3 File Offset: 0x0001B1B3
	// (set) Token: 0x060005CA RID: 1482 RVA: 0x0001CFC3 File Offset: 0x0001B1C3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DebugMode
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskNpcPatrol.__PropertyOffset_DebugMode) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskNpcPatrol.__PropertyOffset_DebugMode) = (value ? 1 : 0);
		}
	}

	// Token: 0x170000ED RID: 237
	// (get) Token: 0x060005CB RID: 1483 RVA: 0x0001CFD4 File Offset: 0x0001B1D4
	// (set) Token: 0x060005CC RID: 1484 RVA: 0x0001CFE4 File Offset: 0x0001B1E4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int MoveState
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskNpcPatrol.__PropertyOffset_MoveState);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskNpcPatrol.__PropertyOffset_MoveState) = value;
		}
	}

	// Token: 0x170000EE RID: 238
	// (get) Token: 0x060005CD RID: 1485 RVA: 0x0001CFF5 File Offset: 0x0001B1F5
	// (set) Token: 0x060005CE RID: 1486 RVA: 0x0001D005 File Offset: 0x0001B205
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool MoveOnePath
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskNpcPatrol.__PropertyOffset_MoveOnePath) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskNpcPatrol.__PropertyOffset_MoveOnePath) = (value ? 1 : 0);
		}
	}

	// Token: 0x170000EF RID: 239
	// (get) Token: 0x060005CF RID: 1487 RVA: 0x0001D016 File Offset: 0x0001B216
	// (set) Token: 0x060005D0 RID: 1488 RVA: 0x0001D026 File Offset: 0x0001B226
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool UseSimpleMove
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskNpcPatrol.__PropertyOffset_UseSimpleMove) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskNpcPatrol.__PropertyOffset_UseSimpleMove) = (value ? 1 : 0);
		}
	}

	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x060005D1 RID: 1489 RVA: 0x0001D037 File Offset: 0x0001B237
	// (set) Token: 0x060005D2 RID: 1490 RVA: 0x0001D047 File Offset: 0x0001B247
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float RaycastLength
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskNpcPatrol.__PropertyOffset_RaycastLength);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskNpcPatrol.__PropertyOffset_RaycastLength) = value;
		}
	}

	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x060005D3 RID: 1491 RVA: 0x0001D058 File Offset: 0x0001B258
	// (set) Token: 0x060005D4 RID: 1492 RVA: 0x0001D068 File Offset: 0x0001B268
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float ChangeMoveTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskNpcPatrol.__PropertyOffset_ChangeMoveTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskNpcPatrol.__PropertyOffset_ChangeMoveTime) = value;
		}
	}

	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x060005D5 RID: 1493 RVA: 0x0001D079 File Offset: 0x0001B279
	// (set) Token: 0x060005D6 RID: 1494 RVA: 0x0001D089 File Offset: 0x0001B289
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float ChangeMoveAngle
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskNpcPatrol.__PropertyOffset_ChangeMoveAngle);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskNpcPatrol.__PropertyOffset_ChangeMoveAngle) = value;
		}
	}

	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x060005D7 RID: 1495 RVA: 0x0001D09A File Offset: 0x0001B29A
	// (set) Token: 0x060005D8 RID: 1496 RVA: 0x0001D0AA File Offset: 0x0001B2AA
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MaxChangeAngle
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskNpcPatrol.__PropertyOffset_MaxChangeAngle);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskNpcPatrol.__PropertyOffset_MaxChangeAngle) = value;
		}
	}

	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x060005D9 RID: 1497 RVA: 0x0001D0BB File Offset: 0x0001B2BB
	// (set) Token: 0x060005DA RID: 1498 RVA: 0x0001D0CB File Offset: 0x0001B2CB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float ChangeMoveDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskNpcPatrol.__PropertyOffset_ChangeMoveDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskNpcPatrol.__PropertyOffset_ChangeMoveDistance) = value;
		}
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x0001D0DC File Offset: 0x0001B2DC
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsDebugMode = this.DebugMode;
			this.TsMoveState = this.MoveState;
			this.TsMoveOnePath = this.MoveOnePath;
			this.TsUseSimpleMove = this.UseSimpleMove;
			this.TsRaycastLength = this.RaycastLength;
			this.TsChangeMoveTime = this.ChangeMoveTime;
			this.TsChangeMoveAngle = this.ChangeMoveAngle;
			this.TsMaxChangeAngle = this.MaxChangeAngle;
			this.TsChangeMoveDistance = this.ChangeMoveDistance;
		}
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x0001D16C File Offset: 0x0001B36C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskNpcPatrol) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskNpcPatrol.StaticClass(), out intPtr, out num))
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

	// Token: 0x060005DD RID: 1501 RVA: 0x0001D21C File Offset: 0x0001B41C
	protected unsafe virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		if (!(ownerController is TsAiController))
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
		AiController aiController = ((TsAiController)ownerController).AiController;
		this.PatrolLogic = aiController.AiPatrol;
		this.PatrolConfig = this.PatrolLogic.GetConfig();
		if (this.PatrolConfig == null)
		{
			base.Finish(false);
			return;
		}
		this.ActorComp = aiController.CharActorComp;
		if (GlobalData.IsPlayInEditor)
		{
			this.DebugComp = this.ActorComp.Actor.TsCharacterDebugComponent;
		}
		this.Entity = aiController.CharAiDesignComp.Entity;
		this.InitBaseInfo();
		this.InitTraceElement();
		if (AiPatrolController.OpenNpcPatrolDebugMode)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.AI;
			ELogAuthor author2 = ELogAuthor.CWZ;
			string message2 = "NPC开始巡逻";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.EntityConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IsLogicAutonomousProxy", this.ActorComp.IsAutonomousProxy);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("IsMoveAutonomousProxy", this.ActorComp.IsMoveAutonomousProxy);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		if (this.HandleMoveEnd == null)
		{
			this.HandleMoveEnd = new Action<ELevelEventState>(this.ExecuteMoveEnd);
		}
		this.PatrolLogic.GeneratePatrol(false);
		this.InitPatrolInfo();
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x0001D3BC File Offset: 0x0001B5BC
	private void InitBaseInfo()
	{
		if (this.CacheVector == null)
		{
			this.CacheCrossVector = Vector.Create();
			this.CacheVector = Vector.Create();
			this.SingleMoveForward = Vector.Create();
		}
		this.MoveComp = this.Entity.GetComponent<BaseMoveComponent>();
		this.StateComp = this.Entity.GetComponent<CharacterUnifiedStateComponent>();
		this.AnimComp = this.Entity.GetComponent<CharacterAnimationComponent>();
		this.AiComp = this.Entity.GetComponent<CharacterAiComponent>();
		this.CurTime = 0f;
		this.IsInit = false;
		this.IsPause = false;
		this.ForceExit = false;
		this.EntityConfigId = this.ActorComp.CreatureData.GetPbDataId();
		this.IsDebugEntity = false;
		int[] debug_CONFIG_ID = this.DEBUG_CONFIG_ID;
		for (int i = 0; i < debug_CONFIG_ID.Length; i++)
		{
			if (debug_CONFIG_ID[i] == this.EntityConfigId)
			{
				this.IsDebugEntity = true;
				break;
			}
		}
		if (this.DebugComp != null)
		{
			this.DebugComp.ClearDebugPatrolPoints();
		}
		if (this.IsDebugEntity && AiPatrolController.OpenNpcPatrolDebugMode)
		{
			this.ChangeStateHandle = new Action<ECharMoveState, ECharMoveState>(this.HandleChangedState);
			EventSystem.Instance.AddWithTarget<ECharMoveState, ECharMoveState>(this.Entity, EEventName.CharOnUnifiedMoveStateChanged, this.ChangeStateHandle);
		}
	}

	// Token: 0x060005DF RID: 1503 RVA: 0x0001D4EC File Offset: 0x0001B6EC
	private void HandleChangedState(ECharMoveState oldState, ECharMoveState newState)
	{
		if (this.IsInit)
		{
			if (newState == ECharMoveState.Other)
			{
				this.ForceExit = true;
				return;
			}
			if (this.AiComp.AiController.AiPatrol.CheckMoveStateChanged(this.StateComp, this.TsMoveState))
			{
				TimerSystem.Instance.Next(delegate(float _)
				{
					CharacterAiComponent aiComp = this.AiComp;
					AiPatrolController aiPatrolController;
					if (aiComp == null)
					{
						aiPatrolController = null;
					}
					else
					{
						AiController aiController = aiComp.AiController;
						aiPatrolController = ((aiController != null) ? aiController.AiPatrol : null);
					}
					AiPatrolController aiPatrolController2 = aiPatrolController;
					if (aiPatrolController2 != null)
					{
						aiPatrolController2.ChangeMoveState(this.StateComp, this.TsMoveState);
					}
				}, null, null);
			}
		}
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x0001D548 File Offset: 0x0001B748
	private void InitTraceElement()
	{
		if (this.TraceElement == null)
		{
			this.TraceElement = new UTraceBoxElement();
			this.TraceElement.bIsSingle = true;
			this.TraceElement.bIgnoreSelf = true;
			this.TraceElement.SetBoxHalfSize(this.TsRaycastLength / 2f, 20f, this.ActorComp.HalfHeight / 2f);
			this.TraceElement.DrawTime = 0.5f;
			TraceElementCommon.Instance.SetTraceColor(this.TraceElement, ColorUtils.LinearGreen);
			TraceElementCommon.Instance.SetTraceHitColor(this.TraceElement, ColorUtils.LinearRed);
			this.TraceElement.AddObjectTypeQuery(KuroObjectTypeQuery.Pawn);
			this.TraceElement.SetDrawDebugTrace(this.TsDebugMode ? EDrawDebugTrace.ForDuration : EDrawDebugTrace.None);
		}
		this.TraceElement.WorldContextObject = this.ActorComp.Owner;
	}

	// Token: 0x060005E1 RID: 1505 RVA: 0x0001D628 File Offset: 0x0001B828
	private void InitPatrolInfo()
	{
		Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
		CreatureDataComponent creatureData = this.ActorComp.CreatureData;
		this.PatrolLogic.StartPatrol(false, null);
		creatureData.SetPosAbnormal(false);
		this.PatrolLogic.ResetBaseInfoByMainPoint(this.MoveComp, this.StateComp, this.TsMoveState);
		if (this.TsDebugMode && this.DebugComp != null)
		{
			this.DebugComp.SaveDebugPatrolPoint(actorLocationProxy);
		}
		this.MoveToPatrolPoint();
		this.IsInit = true;
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x0001D6A8 File Offset: 0x0001B8A8
	private void MoveToPatrolPoint()
	{
		PatrolPoint patrolPoint = this.PatrolLogic.PatrolPoint;
		if (patrolPoint == null)
		{
			base.Finish(false);
			return;
		}
		this.CacheVector.FromUeVector(patrolPoint.Point);
		this.CacheVector.SubtractionEqual(this.ActorComp.ActorLocationProxy);
		this.CacheVector.Normalize(9.99999993922529E-09);
		this.SingleMoveForward.FromUeVector(this.CacheVector);
		MoveCharacterPoint item = new MoveCharacterPoint
		{
			Index = 0,
			Position = patrolPoint.Point,
			MoveState = new EPatrolMoveState?((EPatrolMoveState)this.TsMoveState)
		};
		List<MoveCharacterPoint> value = new List<MoveCharacterPoint>
		{
			item
		};
		MoveCharacterConfig config = new MoveCharacterConfig
		{
			Points = value,
			Navigation = true,
			IsFly = this.PatrolConfig.ContainZ,
			DebugMode = this.TsDebugMode,
			Loop = false,
			Callback = this.HandleMoveEnd,
			ReturnFalseWhenNavigationFailed = false
		};
		this.MoveComp.MoveAlongPath(config, "TsTaskNpcPatrol.MoveToPatrolPoint");
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x0001D7B4 File Offset: 0x0001B9B4
	private void ExecuteMoveEnd(ELevelEventState result)
	{
		if (result == ELevelEventState.Success)
		{
			PatrolPoint patrolPoint = this.PatrolLogic.PatrolPoint;
			if (this.CheckMoveEnd(patrolPoint))
			{
				this.PatrolLogic.PatrolFinish();
				base.Finish(true);
				return;
			}
			if (patrolPoint != this.PatrolLogic.PatrolPoint)
			{
				patrolPoint = this.PatrolLogic.PatrolPoint;
				if (patrolPoint == null)
				{
					base.Finish(true);
					return;
				}
				if (patrolPoint.IsMain)
				{
					this.PatrolLogic.ResetBaseInfoByMainPoint(this.MoveComp, this.StateComp, this.TsMoveState);
				}
				this.MoveToPatrolPoint();
				return;
			}
		}
		else
		{
			if (result == ELevelEventState.Failure)
			{
				base.Finish(false);
				return;
			}
			if (result == ELevelEventState.Error)
			{
				this.PatrolError();
			}
		}
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x0001D854 File Offset: 0x0001BA54
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskNpcPatrol) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskNpcPatrol.StaticClass(), out intPtr, out num))
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

	// Token: 0x060005E5 RID: 1509 RVA: 0x0001D90C File Offset: 0x0001BB0C
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
		if (this.ChangeMoveTimeInternal > 0f)
		{
			this.ChangeMoveTimeInternal -= deltaSeconds;
			if (this.ChangeMoveTimeInternal < 0f)
			{
				this.MoveToPatrolPoint();
			}
		}
		this.CurTime += deltaSeconds;
		if (this.CurTime > 0.5f)
		{
			this.CurTime = 0f;
			this.ExecuteObstacle();
		}
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x0001D98C File Offset: 0x0001BB8C
	private void ExecuteObstacle()
	{
		if (this.IsDebugEntity && AiPatrolController.OpenNpcPatrolDebugMode && this.DebugComp != null)
		{
			this.DebugComp.SaveDebugPatrolPoint(this.ActorComp.ActorLocationProxy);
		}
		if (!this.GetObstacleLocation())
		{
			return;
		}
		Vector currentToLocation = this.MoveComp.MoveController.GetCurrentToLocation();
		Vector vector = this.CalculateAmendForward(currentToLocation);
		if (Math.Abs(MathUtils.Instance.GetAngleByVectorDot(this.SingleMoveForward, vector)) > (double)this.TsMaxChangeAngle)
		{
			return;
		}
		this.CalculateAmendMovePoint(vector);
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x0001DA1C File Offset: 0x0001BC1C
	[NullableContext(1)]
	private Vector CalculateAmendForward(Vector toLocation)
	{
		this.CacheVector.FromUeVector(toLocation);
		this.CacheVector.SubtractionEqual(this.ActorComp.ActorLocationProxy);
		this.CacheVector.Z = 0.0;
		this.CacheVector.Normalize(9.99999993922529E-09);
		Vector.CrossProduct(this.ActorComp.ActorForwardProxy, this.CacheVector, this.CacheCrossVector);
		this.CacheVector.FromUeVector(this.ActorComp.ActorForwardProxy);
		if (this.CacheCrossVector.Z > 0.0)
		{
			this.CacheVector.RotateAngleAxis((double)(-(double)this.TsChangeMoveAngle), Vector.UpVectorProxy, this.CacheVector);
		}
		else
		{
			this.CacheVector.RotateAngleAxis((double)this.TsChangeMoveAngle, Vector.UpVectorProxy, this.CacheVector);
		}
		return this.CacheVector;
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x0001DB00 File Offset: 0x0001BD00
	[NullableContext(1)]
	private void CalculateAmendMovePoint(Vector newForward)
	{
		this.CacheVector.FromUeVector(newForward);
		this.CacheVector.MultiplyEqual((double)this.TsChangeMoveDistance);
		this.CacheVector.AdditionEqual(this.ActorComp.ActorLocationProxy);
		MoveCharacterPoint item = new MoveCharacterPoint
		{
			Index = 0,
			Position = this.CacheVector,
			MoveState = new EPatrolMoveState?((EPatrolMoveState)this.TsMoveState)
		};
		List<MoveCharacterPoint> value = new List<MoveCharacterPoint>
		{
			item
		};
		MoveCharacterConfig config = new MoveCharacterConfig
		{
			Points = value,
			Navigation = true,
			IsFly = this.PatrolConfig.ContainZ,
			DebugMode = this.TsDebugMode,
			Loop = false,
			Callback = this.HandleMoveEnd,
			ReturnFalseWhenNavigationFailed = false
		};
		this.MoveComp.MoveAlongPath(config, "TsTaskNpcPatrol.CalculateAmendMovePoint");
		this.ChangeMoveTimeInternal = this.TsChangeMoveTime;
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x0001DBE8 File Offset: 0x0001BDE8
	private unsafe bool GetObstacleLocation()
	{
		this.CacheVector.FromUeVector(this.ActorComp.ActorForwardProxy);
		this.CacheVector.MultiplyEqual((double)this.TraceElement.HalfSizeX);
		this.CacheVector.AdditionEqual(this.ActorComp.ActorLocationProxy);
		TraceElementCommon.Instance.SetStartLocation(this.TraceElement, this.CacheVector);
		TraceElementCommon.Instance.SetEndLocation(this.TraceElement, this.CacheVector);
		TraceElementCommon.Instance.SetBoxOrientation(this.TraceElement, this.ActorComp.ActorRotationProxy);
		bool flag = TraceElementCommon.Instance.BoxTrace(this.TraceElement, "TsTaskNpcPatrol_GetObstacleLocation");
		UKuroHitResult hitResult = this.TraceElement.HitResult;
		if (!flag || !hitResult.bBlockingHit)
		{
			return false;
		}
		TraceElementCommon.Instance.GetImpactPoint(hitResult, 0, this.CacheVector);
		if (this.IsDebugEntity && AiPatrolController.OpenNpcPatrolDebugMode)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Level;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "NPC巡逻，碰撞到实体";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.EntityConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Actor", hitResult.Actors.Get(0).GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("NowLocation", this.ActorComp.ActorLocationProxy);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("HitLocation", this.CacheVector);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
		return true;
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x0001DD88 File Offset: 0x0001BF88
	[NullableContext(1)]
	private bool CheckMoveEnd(PatrolPoint curPoint)
	{
		bool result = false;
		if (this.ChangeMoveTimeInternal > 0f)
		{
			this.ChangeMoveTimeInternal = 0f;
			this.MoveToPatrolPoint();
		}
		else
		{
			result = this.PatrolLogic.CheckPatrolEnd();
			if (this.TsMoveOnePath && curPoint.IsMain && !curPoint.IsIgnorePoint && curPoint.Actions != null)
			{
				LevelGeneralController.Instance.ExecuteActionsNew(curPoint.Actions, EntityContext.Create(this.Entity.Id, null), null);
			}
		}
		return result;
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x0001DE10 File Offset: 0x0001C010
	private unsafe void PatrolError()
	{
		this.IsPause = true;
		if (AiPatrolController.OpenNpcPatrolDebugMode)
		{
			Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
			Vector actorLocationProxy2 = Global.BaseCharacter.CharacterActorComponent.ActorLocationProxy;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "NPC巡逻，触发异常停止";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.EntityConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityActive", this.Entity.Active);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("HasMove", this.MoveComp.HasMoveInput);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("TickInterval", this.Entity.GetTickInterval());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("HasModelBuffer", this.AnimComp.HasModelBuffer());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("WasRecentlyRenderedOnScreen", this.ActorComp.Owner.WasRecentlyRenderedOnScreen(0.2f));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("CustomTimeDilation", this.ActorComp.Owner.CustomTimeDilation);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
			Vector point = this.PatrolLogic.PatrolPoint.Point;
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.AI;
			ELogAuthor author2 = ELogAuthor.CWZ;
			string message2 = "NPC巡逻，巡逻信息";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("PlayerDist", Math.Ceiling(Vector.Dist2D(actorLocationProxy, actorLocationProxy2)));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("PatrolDist", Math.Ceiling(Vector.Dist2D(actorLocationProxy, point)));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("PatrolIndex", this.PatrolLogic.PatrolIndex);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("NowLocation", actorLocationProxy);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("ToLocation", point);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 5));
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.AI;
			ELogAuthor author3 = ELogAuthor.CWZ;
			string message3 = "NPC巡逻，角色输入信息";
			<>y__InlineArray10<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray10<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("SimpleMove", this.TsUseSimpleMove);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1);
			string item = "MoveState";
			CharacterUnifiedStateComponent stateComp = this.StateComp;
			ptr = new ValueTuple<string, object>(item, (stateComp != null) ? new ECharMoveState?(stateComp.MoveState) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("MovementMode", this.MoveComp.CharacterMovement.MovementMode);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("MoveSpeed", this.MoveComp.Speed);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 4) = new ValueTuple<string, object>("MaxSpeed", this.MoveComp.CharacterMovement.MaxWalkSpeed);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 5) = new ValueTuple<string, object>("MoveInput", this.ActorComp.Actor.K2_GetMovementInputVector());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 6) = new ValueTuple<string, object>("InputDirect", this.ActorComp.InputDirectProxy);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 7) = new ValueTuple<string, object>("InputFacing", this.ActorComp.InputFacingProxy);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 8) = new ValueTuple<string, object>("ActorForward", this.ActorComp.ActorForwardProxy);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 9) = new ValueTuple<string, object>("Velocity", this.ActorComp.Owner.D_GetVelocity());
			instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray10<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 10));
			UKuroAnimInstance ukuroAnimInstance = this.AnimComp.MainAnimInstance as UKuroAnimInstance;
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.AI;
			ELogAuthor author4 = ELogAuthor.CWZ;
			string message4 = "NPC巡逻，角色ABP动画详细信息";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Anims", ukuroAnimInstance.GetDebugAnimNodeString());
			instance4.Warn(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		this.ActorComp.CreatureData.RequestPosAbnormal();
		this.ActorComp.ClearInput(false, true);
		this.AnimComp.StopModelBuffer();
		this.MoveComp.StopMove(true, "TsTaskNpcPatrol.PatrolError");
		this.MoveComp.IsSpecialMove = false;
		this.MoveComp.HasMoveInput = false;
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x0001E2BC File Offset: 0x0001C4BC
	protected override void OnAbort()
	{
		AiPatrolController patrolLogic = this.PatrolLogic;
		if (patrolLogic == null)
		{
			return;
		}
		patrolLogic.PatrolFinish();
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x0001E2D0 File Offset: 0x0001C4D0
	protected override void OnClear()
	{
		if (!(base.AIOwner is TsAiController))
		{
			return;
		}
		if (AiPatrolController.OpenNpcPatrolDebugMode)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "NPC退出巡逻";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", this.EntityConfigId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		if (this.MoveComp != null)
		{
			if (this.TsMoveOnePath)
			{
				this.MoveComp.SetForceSpeed(Vector.ZeroVectorProxy);
			}
			this.MoveComp.IsSpecialMove = false;
			this.MoveComp.HasMoveInput = false;
		}
		if (this.IsDebugEntity && AiPatrolController.OpenNpcPatrolDebugMode)
		{
			EventSystem.Instance.RemoveWithTarget<ECharMoveState, ECharMoveState>(this.Entity, EEventName.CharOnUnifiedMoveStateChanged, this.ChangeStateHandle);
		}
		this.Entity = null;
		this.ActorComp = null;
		this.DebugComp = null;
		this.MoveComp = null;
		this.StateComp = null;
		this.AnimComp = null;
		this.AiComp = null;
		this.PatrolLogic = null;
		this.PatrolConfig = null;
		this.CurTime = 0f;
		this.IsPause = false;
		this.ForceExit = false;
		this.IsInit = false;
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x0001E3E5 File Offset: 0x0001C5E5
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskNpcPatrol._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskNpcPatrol.TsTaskNpcPatrol_C");
		}
		return TsTaskNpcPatrol._ClassPtr;
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x0001E40C File Offset: 0x0001C60C
	public TsTaskNpcPatrol() : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcPatrol.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x0001E434 File Offset: 0x0001C634
	[NullableContext(1)]
	public TsTaskNpcPatrol(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcPatrol.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060005F1 RID: 1521 RVA: 0x0001E467 File Offset: 0x0001C667
	protected TsTaskNpcPatrol(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060005F2 RID: 1522 RVA: 0x0001E48C File Offset: 0x0001C68C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060005F3 RID: 1523 RVA: 0x0001E4BC File Offset: 0x0001C6BC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000430 RID: 1072
	[Nullable(1)]
	private const string PROFILE_KEY = "TsTaskNpcPatrol_GetObstacleLocation";

	// Token: 0x04000431 RID: 1073
	private const float CHECK_RAYCAST_INTERVAL = 0.5f;

	// Token: 0x04000432 RID: 1074
	[Nullable(1)]
	private readonly int[] DEBUG_CONFIG_ID = new int[]
	{
		109002526,
		109002530
	};

	// Token: 0x04000433 RID: 1075
	private Entity Entity;

	// Token: 0x04000434 RID: 1076
	private CharacterActorComponent ActorComp;

	// Token: 0x04000435 RID: 1077
	private BaseMoveComponent MoveComp;

	// Token: 0x04000436 RID: 1078
	private CharacterUnifiedStateComponent StateComp;

	// Token: 0x04000437 RID: 1079
	private CharacterAnimationComponent AnimComp;

	// Token: 0x04000438 RID: 1080
	private CharacterAiComponent AiComp;

	// Token: 0x04000439 RID: 1081
	private Vector CacheCrossVector;

	// Token: 0x0400043A RID: 1082
	private Vector CacheVector;

	// Token: 0x0400043B RID: 1083
	private Vector SingleMoveForward;

	// Token: 0x0400043C RID: 1084
	private float CurTime;

	// Token: 0x0400043D RID: 1085
	private float ChangeMoveTimeInternal;

	// Token: 0x0400043E RID: 1086
	private UTraceBoxElement TraceElement;

	// Token: 0x0400043F RID: 1087
	private bool IsInit;

	// Token: 0x04000440 RID: 1088
	private bool IsPause;

	// Token: 0x04000441 RID: 1089
	private bool ForceExit;

	// Token: 0x04000442 RID: 1090
	private int EntityConfigId;

	// Token: 0x04000443 RID: 1091
	private bool IsDebugEntity;

	// Token: 0x04000444 RID: 1092
	private TsCharacterDebugComponent DebugComp;

	// Token: 0x04000445 RID: 1093
	private AiPatrolController PatrolLogic;

	// Token: 0x04000446 RID: 1094
	private AiPatrolConfig PatrolConfig;

	// Token: 0x04000447 RID: 1095
	private bool IsInitTsVariables;

	// Token: 0x04000448 RID: 1096
	private bool TsDebugMode;

	// Token: 0x04000449 RID: 1097
	private int TsMoveState;

	// Token: 0x0400044A RID: 1098
	private bool TsMoveOnePath;

	// Token: 0x0400044B RID: 1099
	private bool TsUseSimpleMove;

	// Token: 0x0400044C RID: 1100
	private float TsRaycastLength;

	// Token: 0x0400044D RID: 1101
	private float TsChangeMoveTime;

	// Token: 0x0400044E RID: 1102
	private float TsChangeMoveAngle;

	// Token: 0x0400044F RID: 1103
	private float TsMaxChangeAngle;

	// Token: 0x04000450 RID: 1104
	private float TsChangeMoveDistance;

	// Token: 0x04000451 RID: 1105
	private Action<ELevelEventState> HandleMoveEnd;

	// Token: 0x04000452 RID: 1106
	private Action<ECharMoveState, ECharMoveState> ChangeStateHandle;

	// Token: 0x04000453 RID: 1107
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskNpcPatrol.TsTaskNpcPatrol_C";

	// Token: 0x04000454 RID: 1108
	private static IntPtr _ClassPtr;

	// Token: 0x04000455 RID: 1109
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000456 RID: 1110
	private static int __PropertyOffset_DebugMode;

	// Token: 0x04000457 RID: 1111
	private static int __PropertyOffset_MoveState;

	// Token: 0x04000458 RID: 1112
	private static int __PropertyOffset_MoveOnePath;

	// Token: 0x04000459 RID: 1113
	private static int __PropertyOffset_UseSimpleMove;

	// Token: 0x0400045A RID: 1114
	private static int __PropertyOffset_RaycastLength;

	// Token: 0x0400045B RID: 1115
	private static int __PropertyOffset_ChangeMoveTime;

	// Token: 0x0400045C RID: 1116
	private static int __PropertyOffset_ChangeMoveAngle;

	// Token: 0x0400045D RID: 1117
	private static int __PropertyOffset_MaxChangeAngle;

	// Token: 0x0400045E RID: 1118
	private static int __PropertyOffset_ChangeMoveDistance;
}
