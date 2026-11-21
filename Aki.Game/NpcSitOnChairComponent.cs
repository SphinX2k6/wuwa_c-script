using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.NewWorld.Pawn.Controllers;
using NpcSitOnChair;
using UnrealEngine;

// Token: 0x02002754 RID: 10068
[NullableContext(1)]
[Nullable(0)]
public class NpcSitOnChairComponent : EntityComponent
{
	// Token: 0x1700284D RID: 10317
	// (get) Token: 0x06019444 RID: 103492 RVA: 0x007B731D File Offset: 0x007B551D
	// (set) Token: 0x06019445 RID: 103493 RVA: 0x007B7325 File Offset: 0x007B5525
	public NpcSitOnChair.ETaskPhase Phase
	{
		get
		{
			return this.PhaseInternal;
		}
		set
		{
			if (this.PhaseInternal == value)
			{
				return;
			}
			this.PhaseInternal = value;
		}
	}

	// Token: 0x1700284E RID: 10318
	// (get) Token: 0x06019446 RID: 103494 RVA: 0x007B7338 File Offset: 0x007B5538
	public bool IsSitOnChairTaskRunning
	{
		get
		{
			return this.Params != null;
		}
	}

	// Token: 0x1700284F RID: 10319
	// (get) Token: 0x06019447 RID: 103495 RVA: 0x007B7343 File Offset: 0x007B5543
	[Nullable(2)]
	public Entity CurrentChairEntity
	{
		[NullableContext(2)]
		get
		{
			if (this.Phase != NpcSitOnChair.ETaskPhase.SitOnChair || !this.IsExecutePlayMontage)
			{
				return null;
			}
			PawnChairController chairController = this.ChairController;
			if (chairController == null)
			{
				return null;
			}
			return chairController.Entity;
		}
	}

	// Token: 0x06019448 RID: 103496 RVA: 0x007B736C File Offset: 0x007B556C
	protected override bool OnStart()
	{
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		this.MoveComp = base.Entity.GetComponent<BaseMoveComponent>();
		this.PerformComp = base.Entity.GetComponent<BasePerformComponent>();
		this.AnimComp = base.Entity.GetComponent<CharacterAnimationComponent>();
		CharacterAnimationComponent animComp = this.AnimComp;
		if (((animComp != null) ? animComp.MainAnimInstance : null) != null && this.IsRoleAnimInstance())
		{
			this.IsRoleNpc = true;
		}
		return true;
	}

	// Token: 0x06019449 RID: 103497 RVA: 0x007B73E4 File Offset: 0x007B55E4
	private bool IsRoleAnimInstance()
	{
		CharacterAnimationComponent animComp = this.AnimComp;
		UAnimInstance @object = (animComp != null) ? animComp.MainAnimInstance : null;
		return UKuroStaticLibrary.IsObjectClassByName(@object, CharacterNameDefines.Instance.ABP_BASEROLENPC) || UKuroStaticLibrary.IsObjectClassByName(@object, CharacterNameDefines.Instance.ABP_BASEROLE);
	}

	// Token: 0x0601944A RID: 103498 RVA: 0x007B7428 File Offset: 0x007B5628
	protected override void OnActivate()
	{
	}

	// Token: 0x0601944B RID: 103499 RVA: 0x007B742A File Offset: 0x007B562A
	protected override void OnTick(float deltaTime)
	{
		if (this.Params != null && !this.IsAbortRequested && this.Params.InterruptCondition())
		{
			this.AbortGracefully();
			return;
		}
		if (this.IsExecuting)
		{
			this.NpcSitOnChairTick();
		}
	}

	// Token: 0x0601944C RID: 103500 RVA: 0x007B7463 File Offset: 0x007B5663
	protected override bool OnEnd()
	{
		this.AbortImmediately();
		return true;
	}

	// Token: 0x0601944D RID: 103501 RVA: 0x007B746C File Offset: 0x007B566C
	public void RequestExit()
	{
		if (this.Params != null)
		{
			this.AbortGracefully();
		}
	}

	// Token: 0x0601944E RID: 103502 RVA: 0x007B747C File Offset: 0x007B567C
	public void StartNpcSitOnChair(INpcSitOnChairParams @params)
	{
		if (this.ActorComp == null)
		{
			return;
		}
		if (this.Params != null)
		{
			this.AbortImmediately();
		}
		this.FlowId++;
		int flowId = this.FlowId;
		this.IsAbortRequested = false;
		this.Params = @params;
		BaseMoveComponent moveComp = this.MoveComp;
		bool flag;
		if (moveComp == null)
		{
			flag = true;
		}
		else
		{
			UCharacterMovementComponent characterMovement = moveComp.CharacterMovement;
			flag = !((characterMovement != null) ? new bool?(characterMovement.IsValid()) : null).GetValueOrDefault();
		}
		if (flag)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[NpcSitOnChairComponent] MoveComp不合法";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", this.ActorComp.CreatureData.GetPbDataId());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.AbortImmediately();
			return;
		}
		EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(this.Params.ChairEntityId);
		object obj;
		if (entityByPbDataId == null)
		{
			obj = null;
		}
		else
		{
			WorldEntity entity = entityByPbDataId.Entity;
			if (entity == null)
			{
				obj = null;
			}
			else
			{
				PawnInteractNewComponent component = entity.GetComponent<PawnInteractNewComponent>();
				obj = ((component != null) ? component.GetSubEntityInteractLogicController() : null);
			}
		}
		this.ChairController = (obj as PawnChairController);
		if (this.ChairController == null || !this.ChairController.IsSceneInteractionLoadCompleted())
		{
			this.AbortImmediately();
			return;
		}
		if (!this.IsRoleNpc && string.IsNullOrEmpty(this.Params.MontagePath))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.CWZ;
			string message2 = "[NpcSitOnChairComponent] 无效的Montage路径";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("PbDataId", this.ActorComp.CreatureData.GetPbDataId());
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			this.AbortImmediately();
			return;
		}
		if (!this.TryPossessAndLockChair())
		{
			this.AbortImmediately();
			return;
		}
		this.DelayExecuteAction(delegate
		{
			if (!this.IsCurrentFlow(flowId))
			{
				return;
			}
			this.Phase = NpcSitOnChair.ETaskPhase.Execute;
			this.IsExecuting = true;
		}, 2000, this.LastFinishTime);
	}

	// Token: 0x0601944F RID: 103503 RVA: 0x007B763C File Offset: 0x007B583C
	private void NpcSitOnChairTick()
	{
		switch (this.Phase)
		{
		case NpcSitOnChair.ETaskPhase.Execute:
			this.Phase = NpcSitOnChair.ETaskPhase.MoveNearby;
			return;
		case NpcSitOnChair.ETaskPhase.MoveNearby:
			this.ExecuteMoveNearby();
			return;
		case NpcSitOnChair.ETaskPhase.MoveClose:
			this.ExecuteMoveClose();
			return;
		case NpcSitOnChair.ETaskPhase.TurnTo:
			this.ExecuteTurnTo();
			if (GravityUtils.Instance.GetAngleOffsetFromCurrentToInputAbs(this.ActorComp) < 10f)
			{
				this.MoveComp.CharacterMovement.MovementMode = this.MovementMode;
				this.Phase = NpcSitOnChair.ETaskPhase.SitOnChair;
				return;
			}
			break;
		case NpcSitOnChair.ETaskPhase.SitOnChair:
			this.ExecutePlaySitOnChairAnim();
			return;
		case NpcSitOnChair.ETaskPhase.MoveAway:
			this.ExecuteMoveAway();
			this.TickRoleNpcStandUp();
			return;
		case NpcSitOnChair.ETaskPhase.Finish:
			this.CompleteTask();
			return;
		default:
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[NpcSitOnChairComponent] 阶段切换出错";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CurPhase", this.Phase);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			break;
		}
		}
	}

	// Token: 0x06019450 RID: 103504 RVA: 0x007B7718 File Offset: 0x007B5918
	private void NpcSitOnChairEnd()
	{
		this.ReleaseChairPossession();
		this.UnlockChairInteract();
		this.FlowId++;
		this.Phase = NpcSitOnChair.ETaskPhase.None;
		this.MovementMode = EMovementMode.MOVE_None;
		this.IsExecuteMoveNearby = false;
		this.IsExecuteMoveClose = false;
		this.IsExecuteTurnTo = false;
		this.IsExecutePlayMontage = false;
		this.IsExecuteMoveAway = false;
		this.IsAlignedToChair = false;
		this.MoveHandleId = 0;
		this.Params = null;
		this.ChairController = null;
		this.IsExecuting = false;
		this.CloseMoveLocation.Reset();
		this.ClearExitSitTimerHandle();
	}

	// Token: 0x06019451 RID: 103505 RVA: 0x007B77A4 File Offset: 0x007B59A4
	private bool TryPossessAndLockChair()
	{
		PawnChairController chairController = this.ChairController;
		Entity entity = base.Entity;
		PawnInteractNewComponent pawnInteractNewComponent;
		if (chairController == null)
		{
			pawnInteractNewComponent = null;
		}
		else
		{
			Entity entity2 = chairController.Entity;
			pawnInteractNewComponent = ((entity2 != null) ? entity2.GetComponent<PawnInteractNewComponent>() : null);
		}
		PawnInteractNewComponent pawnInteractNewComponent2 = pawnInteractNewComponent;
		if (chairController == null || entity == null || pawnInteractNewComponent2 == null || this.IsChairPossessed || this.IsChairInteractLocked || chairController.IsPossessed() || !pawnInteractNewComponent2.CanInteraction || pawnInteractNewComponent2.GetIsExecutingInteract())
		{
			return false;
		}
		if (!chairController.Possess(entity, false))
		{
			return false;
		}
		this.IsChairPossessed = true;
		this.LastChairClientCanInteraction = pawnInteractNewComponent2.GetClientCanInteraction();
		this.IsChairInteractLocked = true;
		pawnInteractNewComponent2.SetInteractionState(false, "NpcSitOnChairComponent.TryPossessAndLockChair");
		return true;
	}

	// Token: 0x06019452 RID: 103506 RVA: 0x007B7840 File Offset: 0x007B5A40
	private void ReleaseChairPossession()
	{
		if (!this.IsChairPossessed)
		{
			return;
		}
		PawnChairController chairController = this.ChairController;
		Entity entity = base.Entity;
		if (chairController != null && entity != null && chairController.IsPossessedBy(entity))
		{
			chairController.UnPossess(entity);
		}
		this.IsChairPossessed = false;
	}

	// Token: 0x06019453 RID: 103507 RVA: 0x007B7884 File Offset: 0x007B5A84
	private void UnlockChairInteract()
	{
		if (!this.IsChairInteractLocked)
		{
			return;
		}
		PawnChairController chairController = this.ChairController;
		PawnInteractNewComponent pawnInteractNewComponent;
		if (chairController == null)
		{
			pawnInteractNewComponent = null;
		}
		else
		{
			Entity entity = chairController.Entity;
			pawnInteractNewComponent = ((entity != null) ? entity.GetComponent<PawnInteractNewComponent>() : null);
		}
		PawnInteractNewComponent pawnInteractNewComponent2 = pawnInteractNewComponent;
		if (pawnInteractNewComponent2 != null)
		{
			pawnInteractNewComponent2.SetInteractionState(this.LastChairClientCanInteraction, "NpcSitOnChairComponent.UnlockChairInteract");
		}
		this.IsChairInteractLocked = false;
		this.LastChairClientCanInteraction = true;
	}

	// Token: 0x06019454 RID: 103508 RVA: 0x007B78DC File Offset: 0x007B5ADC
	private void AbortGracefully()
	{
		if (this.IsAbortRequested)
		{
			return;
		}
		NpcSitOnChair.ETaskPhase phase = this.Phase;
		if (phase != NpcSitOnChair.ETaskPhase.SitOnChair)
		{
			if (phase - NpcSitOnChair.ETaskPhase.MoveAway > 1)
			{
				this.AbortImmediately();
				return;
			}
			this.IsAbortRequested = true;
			return;
		}
		else
		{
			if (!this.IsExecutePlayMontage)
			{
				this.AbortImmediately();
				return;
			}
			this.IsAbortRequested = true;
			this.RequestMoveAwayAfterSitDown();
			return;
		}
	}

	// Token: 0x06019455 RID: 103509 RVA: 0x007B7930 File Offset: 0x007B5B30
	public void AbortImmediately()
	{
		if (this.Params == null)
		{
			this.ClearExitSitTimerHandle();
			return;
		}
		Action abort = this.Params.Abort;
		NpcSitOnChair.ETaskPhase phase = this.Phase;
		this.FlowId++;
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null)
		{
			actorComp.ClearInput(false, true);
		}
		BaseMoveComponent moveComp = this.MoveComp;
		UCharacterMovementComponent ucharacterMovementComponent = (moveComp != null) ? moveComp.CharacterMovement : null;
		if (this.MovementMode != EMovementMode.MOVE_None && ucharacterMovementComponent != null && ucharacterMovementComponent.IsValid())
		{
			ucharacterMovementComponent.MovementMode = this.MovementMode;
		}
		bool flag = phase == NpcSitOnChair.ETaskPhase.SitOnChair || phase == NpcSitOnChair.ETaskPhase.MoveAway;
		if (flag && this.IsExecutePlayMontage)
		{
			this.PlayStandUpAnim();
		}
		if ((phase == NpcSitOnChair.ETaskPhase.MoveClose || phase == NpcSitOnChair.ETaskPhase.TurnTo || flag) && !this.ChairNearbyPos.IsNearlyZero(9.999999747378752E-05))
		{
			this.SetActorLocation(this.ChairNearbyPos, "AbortImmediately.立即离开椅子");
		}
		this.OnMoveAwayEnd();
		this.LastFinishTime = Time.Instance.Now;
		this.NpcSitOnChairEnd();
		if (abort == null)
		{
			return;
		}
		abort();
	}

	// Token: 0x06019456 RID: 103510 RVA: 0x007B7A30 File Offset: 0x007B5C30
	private void CompleteTask()
	{
		object obj;
		if (!this.IsAbortRequested)
		{
			INpcSitOnChairParams @params = this.Params;
			obj = ((@params != null) ? @params.Finish : null);
		}
		else
		{
			INpcSitOnChairParams params2 = this.Params;
			obj = ((params2 != null) ? params2.Abort : null);
		}
		this.LastFinishTime = Time.Instance.Now;
		this.NpcSitOnChairEnd();
		object obj2 = obj;
		if (obj2 == null)
		{
			return;
		}
		obj2();
	}

	// Token: 0x06019457 RID: 103511 RVA: 0x007B7A8C File Offset: 0x007B5C8C
	private void ExecuteMoveNearby()
	{
		if (this.IsExecuteMoveNearby)
		{
			return;
		}
		this.IsExecuteMoveNearby = true;
		Vector sitLocation = this.ChairController.GetSitLocation();
		this.ChairController.GetForwardDirection().Multiply(50.0, this.ChairNearbyPos);
		this.ChairNearbyPos.AdditionEqual(sitLocation);
		double distSquared2dForActor = GravityUtils.Instance.GetDistSquared2dForActor(this.ActorComp, this.ChairNearbyPos, this.ActorComp.ActorLocationProxy);
		if (distSquared2dForActor < 2500.0 && this.AnimComp != null)
		{
			this.SkipMoveToChair();
			return;
		}
		MoveCharacterPoint moveCharacterPoint = new MoveCharacterPoint
		{
			Index = 0,
			Position = this.ChairNearbyPos,
			MoveState = new EPatrolMoveState?((distSquared2dForActor > 160000.0) ? EPatrolMoveState.Run : EPatrolMoveState.Walk),
			MoveSpeed = new float?((float)((distSquared2dForActor > 160000.0) ? 400 : 100))
		};
		MoveCharacterConfig config = new MoveCharacterConfig
		{
			Points = new MoveCharacterPoint[]
			{
				moveCharacterPoint
			},
			Navigation = true,
			IsFly = false,
			DebugMode = true,
			Loop = false,
			Distance = new float?((float)5),
			Callback = delegate(ELevelEventState result)
			{
				this.StopCurrentMove();
				if (result == ELevelEventState.Failure)
				{
					this.ChairController.IgnoreCollision();
					INpcSitOnChairParams @params = this.Params;
					bool flag;
					if (@params == null)
					{
						flag = false;
					}
					else
					{
						int[] teleportEffect = @params.TeleportEffect;
						int? num = (teleportEffect != null) ? new int?(teleportEffect.Length) : null;
						int i = 0;
						flag = (num.GetValueOrDefault() > i & num != null);
					}
					if (flag)
					{
						Entity entity = base.Entity;
						BaseGameplayCueComponent baseGameplayCueComponent = (entity != null) ? entity.GetComponent<BaseGameplayCueComponent>() : null;
						foreach (int num2 in this.Params.TeleportEffect)
						{
							if (baseGameplayCueComponent != null)
							{
								baseGameplayCueComponent.AddCue((long)num2, new GameplayCueParam?(new GameplayCueParam
								{
									Instant = true
								}));
							}
						}
					}
					CharacterActorComponent actorComp = this.ActorComp;
					if (actorComp != null)
					{
						actorComp.SetActorLocation(this.ChairNearbyPos.ToUeVector(false), "[NpcSitOnChairComponent] ExecuteMoveNearby", false);
					}
					Vector sitLocation2 = this.ChairController.GetSitLocation();
					this.CloseMoveLocation.Set(sitLocation2.X, sitLocation2.Y, this.ActorComp.ActorLocationProxy.Z);
					this.ResetMoveStateAtChair();
					this.Phase = NpcSitOnChair.ETaskPhase.TurnTo;
					return;
				}
				this.Phase = NpcSitOnChair.ETaskPhase.MoveClose;
			},
			ReturnTimeoutFailed = new float?((float)1),
			ReturnFalseWhenNavigationFailed = true,
			StrictNavigation = new bool?(true)
		};
		this.MoveHandleId = this.MoveComp.MoveAlongPath(config, "NpcSitOnChairComponent.ExecuteMoveNearby");
	}

	// Token: 0x06019458 RID: 103512 RVA: 0x007B7C10 File Offset: 0x007B5E10
	private void ExecuteMoveClose()
	{
		if (this.IsExecuteMoveClose)
		{
			return;
		}
		this.IsExecuteMoveClose = true;
		this.ChairController.IgnoreCollision();
		Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
		Vector sitLocation = this.ChairController.GetSitLocation();
		this.CloseMoveLocation.Set(sitLocation.X, sitLocation.Y, actorLocationProxy.Z);
		MoveCharacterPoint moveCharacterPoint = new MoveCharacterPoint
		{
			Index = 0,
			Position = this.CloseMoveLocation,
			MoveState = new EPatrolMoveState?(EPatrolMoveState.Walk),
			MoveSpeed = new float?((float)70)
		};
		MoveCharacterConfig config = new MoveCharacterConfig
		{
			Points = new MoveCharacterPoint[]
			{
				moveCharacterPoint
			},
			Navigation = true,
			IsFly = false,
			DebugMode = true,
			Loop = false,
			Distance = new float?((float)5),
			Callback = delegate(ELevelEventState result)
			{
				this.StopCurrentMove();
				if (result == ELevelEventState.Failure)
				{
					this.SetActorLocation(this.CloseMoveLocation, "ExecuteMoveClose.移动靠近椅子保底");
				}
				this.ResetMoveStateAtChair();
				this.Phase = NpcSitOnChair.ETaskPhase.TurnTo;
			},
			ReturnTimeoutFailed = new float?((float)1),
			ReturnFalseWhenNavigationFailed = true,
			StrictNavigation = new bool?(true)
		};
		this.MoveHandleId = this.MoveComp.MoveAlongPath(config, "NpcSitOnChairComponent.ExecuteMoveClose");
	}

	// Token: 0x06019459 RID: 103513 RVA: 0x007B7D3C File Offset: 0x007B5F3C
	private void ExecuteTurnTo()
	{
		if (this.IsExecuteTurnTo)
		{
			return;
		}
		this.IsExecuteTurnTo = true;
		int num = 200;
		this.ChairController.GetForwardDirection().Multiply((double)num, this.TempVector);
		this.TempVector.AdditionEqual(this.ChairNearbyPos);
		this.MovementMode = this.MoveComp.CharacterMovement.MovementMode;
		this.MoveComp.CharacterMovement.MovementMode = EMovementMode.MOVE_Walking;
		AiControllerLibrary.TurnToTarget(this.ActorComp, this.TempVector, 200f, false, 0f);
	}

	// Token: 0x0601945A RID: 103514 RVA: 0x007B7DD7 File Offset: 0x007B5FD7
	private void ExecutePlaySitOnChairAnim()
	{
		if (!this.IsExecutePlayMontage)
		{
			this.StartSitOnChairTime = Time.Instance.Now;
			this.IsExecutePlayMontage = true;
			this.PlaySitDownAnim();
		}
	}

	// Token: 0x0601945B RID: 103515 RVA: 0x007B7E00 File Offset: 0x007B6000
	private void RequestMoveAwayAfterSitDown()
	{
		int flowId = this.FlowId;
		this.DelayExecuteAction(delegate
		{
			if (!this.IsCurrentPhase(flowId, NpcSitOnChair.ETaskPhase.SitOnChair))
			{
				return;
			}
			this.Phase = NpcSitOnChair.ETaskPhase.MoveAway;
		}, 1500, this.StartSitOnChairTime);
	}

	// Token: 0x0601945C RID: 103516 RVA: 0x007B7E43 File Offset: 0x007B6043
	private void ExecuteMoveAway()
	{
		if (this.IsExecuteMoveAway)
		{
			return;
		}
		this.PlayStandUpAnim();
		this.IsExecuteMoveAway = true;
		if (this.IsRoleNpc)
		{
			this.StartStandUpTime = Time.Instance.Now;
			return;
		}
		this.StartMoveAwayPath();
	}

	// Token: 0x0601945D RID: 103517 RVA: 0x007B7E7C File Offset: 0x007B607C
	private void StartMoveAwayPath()
	{
		MoveCharacterPoint moveCharacterPoint = new MoveCharacterPoint
		{
			Index = 0,
			Position = this.ChairNearbyPos,
			MoveState = new EPatrolMoveState?(EPatrolMoveState.Walk),
			MoveSpeed = new float?((float)70)
		};
		MoveCharacterConfig config = new MoveCharacterConfig
		{
			Points = new MoveCharacterPoint[]
			{
				moveCharacterPoint
			},
			Navigation = true,
			IsFly = false,
			DebugMode = true,
			Loop = false,
			Distance = new float?((float)5),
			Callback = delegate(ELevelEventState result)
			{
				if (result == ELevelEventState.Failure)
				{
					this.SetActorLocation(this.ChairNearbyPos, "ExecuteMoveAway.移动离开椅子保底");
				}
				this.OnMoveAwayEnd();
				this.Phase = NpcSitOnChair.ETaskPhase.Finish;
			},
			ReturnTimeoutFailed = new float?((float)2),
			ReturnFalseWhenNavigationFailed = false
		};
		this.MoveHandleId = this.MoveComp.MoveAlongPath(config, "NpcSitOnChairComponent.StartMoveAwayPath");
	}

	// Token: 0x0601945E RID: 103518 RVA: 0x007B7F40 File Offset: 0x007B6140
	private void TickRoleNpcStandUp()
	{
		if (!this.IsRoleNpc || this.StartStandUpTime == 0.0)
		{
			return;
		}
		if (Time.Instance.Now - this.StartStandUpTime >= 2000.0)
		{
			this.StartStandUpTime = 0.0;
			this.StartMoveAwayPath();
		}
	}

	// Token: 0x0601945F RID: 103519 RVA: 0x007B7F98 File Offset: 0x007B6198
	private void OnMoveAwayEnd()
	{
		this.StopCurrentMove();
		PawnChairController chairController = this.ChairController;
		if (chairController != null && this.IsExecuteMoveNearby)
		{
			if (this.IsActorChairCollisionIgnored && chairController.Entity != null)
			{
				this.ResetCollision(chairController.Entity);
			}
			this.IsActorChairCollisionIgnored = false;
			chairController.ResetCollision();
		}
		this.ReleaseChairPossession();
		this.IsExecuteMoveNearby = false;
	}

	// Token: 0x06019460 RID: 103520 RVA: 0x007B7FF4 File Offset: 0x007B61F4
	private void StopCurrentMove()
	{
		if (this.MoveHandleId == 0)
		{
			return;
		}
		int moveHandleId = this.MoveHandleId;
		this.MoveHandleId = 0;
		BaseMoveComponent moveComp = this.MoveComp;
		if (moveComp == null)
		{
			return;
		}
		moveComp.StopMoveByHandleId(moveHandleId, "NpcSitOnChairComponent.StopCurrentMove");
	}

	// Token: 0x06019461 RID: 103521 RVA: 0x007B802E File Offset: 0x007B622E
	private void ResetMoveStateAtChair()
	{
		this.MoveComp.Speed = 0f;
		this.MoveComp.SetForceSpeed(Vector.ZeroVectorProxy);
		Entity entity = base.Entity;
		if (entity == null)
		{
			return;
		}
		BaseUnifiedStateComponent component = entity.GetComponent<BaseUnifiedStateComponent>();
		if (component == null)
		{
			return;
		}
		component.SetMoveState(ECharMoveState.Stand);
	}

	// Token: 0x06019462 RID: 103522 RVA: 0x007B806C File Offset: 0x007B626C
	private void SkipMoveToChair()
	{
		this.ChairController.IgnoreCollision();
		Vector sitLocation = this.ChairController.GetSitLocation();
		this.CloseMoveLocation.Set(sitLocation.X, sitLocation.Y, this.ActorComp.ActorLocationProxy.Z);
		this.ResetMoveStateAtChair();
		this.ChairController.GetForwardDirection().Multiply(200.0, this.TempVector);
		this.TempVector.AdditionEqual(this.ChairNearbyPos);
		this.TempVector.Subtraction(this.ActorComp.ActorLocationProxy, this.TempVector2);
		this.ActorComp.SetInputFacing(this.TempVector2, true);
		bool flag = (double)GravityUtils.Instance.GetAngleOffsetFromCurrentToInputAbs(this.ActorComp) < 10.0;
		if (flag)
		{
			this.ActorComp.SetActorLocationAndRotation(this.CloseMoveLocation.ToUeVector(false), this.ActorComp.InputRotatorProxy.ToUeRotator(), "NpcSitOnChairComponent.SkipMoveToChair", false, null);
		}
		else
		{
			this.AnimComp.SetLocationAndRotatorWithModelBuffer(this.CloseMoveLocation.ToUeVector(false), this.ActorComp.ActorRotationProxy.ToUeRotator(), 200f, "NpcSitOnChairComponent.SkipMoveToChair", ESetRotationPriority.Anim, true);
		}
		this.IsAlignedToChair = flag;
		this.Phase = (flag ? NpcSitOnChair.ETaskPhase.SitOnChair : NpcSitOnChair.ETaskPhase.TurnTo);
	}

	// Token: 0x06019463 RID: 103523 RVA: 0x007B81C3 File Offset: 0x007B63C3
	private bool IsCurrentFlow(int flowId)
	{
		return this.FlowId == flowId && this.Params != null;
	}

	// Token: 0x06019464 RID: 103524 RVA: 0x007B81D9 File Offset: 0x007B63D9
	private bool IsCurrentPhase(int flowId, NpcSitOnChair.ETaskPhase phase)
	{
		return this.IsCurrentFlow(flowId) && this.IsExecuting && this.Phase == phase;
	}

	// Token: 0x06019465 RID: 103525 RVA: 0x007B81F8 File Offset: 0x007B63F8
	private void SetActorLocation(Vector target, string context)
	{
		FTransformDouble meshTransform = base.Entity.GetComponent<CharacterAnimationComponent>().GetMeshTransform();
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null)
		{
			actorComp.SetActorLocation(target.ToUeVector(false), "[NpcSitOnChairComponent]" + context, false);
		}
		CharacterAnimationComponent component = base.Entity.GetComponent<CharacterAnimationComponent>();
		if (component == null)
		{
			return;
		}
		component.SetModelBuffer(meshTransform, 200f);
	}

	// Token: 0x06019466 RID: 103526 RVA: 0x007B8258 File Offset: 0x007B6458
	private void DelayExecuteAction(Action action, int time, double lastTime)
	{
		this.ClearExitSitTimerHandle();
		double num = (double)time - (Time.Instance.Now - lastTime);
		if (num <= 20.0)
		{
			action();
			return;
		}
		this.ExitSitTimerHandle = TimerSystem.Instance.Delay(delegate(float _)
		{
			Action action2 = action;
			if (action2 != null)
			{
				action2();
			}
			this.ExitSitTimerHandle = null;
		}, (float)((int)num), null, null, true, 1f);
	}

	// Token: 0x06019467 RID: 103527 RVA: 0x007B82CE File Offset: 0x007B64CE
	private void ClearExitSitTimerHandle()
	{
		if (this.ExitSitTimerHandle != null && TimerSystem.Instance.Has(this.ExitSitTimerHandle))
		{
			TimerSystem.Instance.Remove(this.ExitSitTimerHandle);
		}
		this.ExitSitTimerHandle = null;
	}

	// Token: 0x06019468 RID: 103528 RVA: 0x007B8302 File Offset: 0x007B6502
	private void PlaySitDownAnim()
	{
		if (this.IsRoleNpc)
		{
			this.RoleNpcSitOnChair();
			return;
		}
		this.NormalNpcSitOnChair();
	}

	// Token: 0x06019469 RID: 103529 RVA: 0x007B8319 File Offset: 0x007B6519
	private void PlayStandUpAnim()
	{
		if (this.IsRoleNpc)
		{
			this.RoleNpcStandUp();
			return;
		}
		this.NormalNpcStopMontage();
	}

	// Token: 0x0601946A RID: 103530 RVA: 0x007B8330 File Offset: 0x007B6530
	private void NormalNpcSitOnChair()
	{
		if (string.IsNullOrEmpty(this.Params.MontagePath))
		{
			Log.Instance.Error(ELogModule.BehaviorTree, ELogAuthor.CWZ, "[NpcSitOnChairComponent] 没有MontagePath", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (!this.IsAlignedToChair)
		{
			CharacterAnimationComponent animComp = this.AnimComp;
			if (animComp != null)
			{
				animComp.SetLocationAndRotatorWithModelBuffer(this.CloseMoveLocation.ToUeVector(false), this.ActorComp.ActorRotationProxy.ToUeRotator(), 200f, "NpcSitOnChairComp.NormalNpcSitOnChair", ESetRotationPriority.Anim, true);
			}
		}
		int flowId = this.FlowId;
		this.PlayingMontage = this.PerformComp.VolatileMontagePlayByLoad(EPerformMode.Ecology, this.Params.MontagePath, null, null, delegate(UAnimMontage montage, bool _)
		{
			if (!this.IsCurrentPhase(flowId, NpcSitOnChair.ETaskPhase.SitOnChair))
			{
				return;
			}
			if (montage != null)
			{
				this.Phase = NpcSitOnChair.ETaskPhase.MoveAway;
				return;
			}
			this.AbortImmediately();
		}, new float?((float)-1), new float?((float)-1), new bool?(false), new bool?(false), new bool?(false));
	}

	// Token: 0x0601946B RID: 103531 RVA: 0x007B8411 File Offset: 0x007B6611
	private void NormalNpcStopMontage()
	{
		if (this.PlayingMontage != -1)
		{
			BasePerformComponent performComp = this.PerformComp;
			if (performComp != null)
			{
				performComp.VolatileMontageStopByLoad(EPerformMode.Ecology, this.PlayingMontage, EStopMethod.BlendOut);
			}
			this.PlayingMontage = -1;
		}
	}

	// Token: 0x0601946C RID: 103532 RVA: 0x007B843C File Offset: 0x007B663C
	private void RoleNpcSitOnChair()
	{
		CharacterAnimationComponent animComp = this.AnimComp;
		UAnimInstance uanimInstance = (animComp != null) ? animComp.MainAnimInstance : null;
		if (this.IsRoleAnimInstance())
		{
			UKuroAnimInstanceChar ukuroAnimInstanceChar = uanimInstance as UKuroAnimInstanceChar;
			if (((ukuroAnimInstanceChar != null) ? ukuroAnimInstanceChar.LogicParams : null) != null)
			{
				this.IgnoreCollision(this.ChairController.Entity);
				this.IsActorChairCollisionIgnored = true;
				ukuroAnimInstanceChar.LogicParams.SitDownDirect = this.IsChairCanInteract(this.ChairController.Entity) - EChairInteractDirection.Forward;
				ukuroAnimInstanceChar.LogicParams.SitDownType = 1;
				ukuroAnimInstanceChar.LogicParams.bSitDown = true;
				return;
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.BehaviorTree;
		ELogAuthor author = ELogAuthor.CWZ;
		string message = "[NpcSitOnChairComponent] RoleNpcSitOnChair执行异常";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("instance", uanimInstance != null);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0601946D RID: 103533 RVA: 0x007B84F8 File Offset: 0x007B66F8
	private void RoleNpcStandUp()
	{
		CharacterAnimationComponent animComp = this.AnimComp;
		UAnimInstance uanimInstance = (animComp != null) ? animComp.MainAnimInstance : null;
		if (this.IsRoleAnimInstance())
		{
			UKuroAnimInstanceChar ukuroAnimInstanceChar = uanimInstance as UKuroAnimInstanceChar;
			if (((ukuroAnimInstanceChar != null) ? ukuroAnimInstanceChar.LogicParams : null) != null)
			{
				ukuroAnimInstanceChar.LogicParams.StandUpDirect = this.CalculateLeaveSitDownIndex(this.ChairController.Entity);
				ukuroAnimInstanceChar.LogicParams.bSitDown = false;
				return;
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.BehaviorTree;
		ELogAuthor author = ELogAuthor.CWZ;
		string message = "[NpcSitOnChairComponent] RoleNpcStandUp执行异常";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("instance", uanimInstance != null);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0601946E RID: 103534 RVA: 0x007B8590 File Offset: 0x007B6790
	public void DoSitDownAction(Entity chair)
	{
		if (chair == null)
		{
			return;
		}
		this.TempVector.Reset();
		this.MoveComp.SetForceSpeed(this.TempVector);
		SceneItemActorComponent component = chair.GetComponent<SceneItemActorComponent>();
		PawnInteractNewComponent component2 = chair.GetComponent<PawnInteractNewComponent>();
		this.TempVector.DeepCopy(component2.GetInteractPoint());
		this.TempVector.Z += (double)this.ActorComp.HalfHeight;
		this.TempRotator.DeepCopy(component.ActorRotationProxy);
		this.TempRotator.Yaw += 90f;
		this.ActorComp.SetInputRotator(this.TempRotator);
		this.ActorComp.SetActorLocationAndRotation(this.TempVector.ToUeVector(false), this.TempRotator.ToUeRotator(), "角色坐下", false, null);
	}

	// Token: 0x0601946F RID: 103535 RVA: 0x007B8668 File Offset: 0x007B6868
	private int CalculateLeaveSitDownIndex(Entity chair)
	{
		if (chair == null)
		{
			return 0;
		}
		this.ActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
		{
			Mode = EMovementMode.MOVE_Walking,
			Context = "[NpcSitOnChairComponent.CalculateLeaveSitDownIndex]"
		});
		this.TempVector.DeepCopy(this.ActorComp.InputDirectProxy);
		if (this.TempVector.IsNearlyZero(9.999999747378752E-05))
		{
			return 0;
		}
		this.TempVector.Normalize(9.99999993922529E-09);
		IInteractSectorRange sectorRange = chair.GetComponent<PawnInteractNewComponent>().GetInteractController().SectorRange;
		if (this.TempVector.DotProduct(this.ActorComp.ActorForwardProxy) > 0.8 || sectorRange == null)
		{
			return 0;
		}
		this.TempVector.CrossProduct(this.ActorComp.ActorForwardProxy, this.TempVector2);
		if (this.TempVector2.Z >= 0.0)
		{
			if (sectorRange.Begin < -45f)
			{
				return 1;
			}
			return 0;
		}
		else
		{
			if (sectorRange.End > 45f)
			{
				return 2;
			}
			return 0;
		}
	}

	// Token: 0x06019470 RID: 103536 RVA: 0x007B8770 File Offset: 0x007B6970
	private EChairInteractDirection IsChairCanInteract(Entity sceneItem)
	{
		SceneItemActorComponent component = sceneItem.GetComponent<SceneItemActorComponent>();
		if (component == null)
		{
			return EChairInteractDirection.None;
		}
		this.ActorComp.ActorLocationProxy.Subtraction(component.ActorLocationProxy, this.TempVector);
		this.TempVector.Z = 0.0;
		this.TempVector.Normalize(9.99999993922529E-09);
		double num = Math.Acos(Math.Clamp(this.TempVector.DotProduct(component.ActorRightProxy), -1.0, 1.0)) * 57.295780181884766;
		this.TempVector.CrossProduct(component.ActorRightProxy, this.TempVector2);
		if (this.TempVector2.Z < 0.0)
		{
			num *= -1.0;
		}
		if (num >= -50.0 && num <= 50.0)
		{
			return EChairInteractDirection.Forward;
		}
		if (num >= 50.0 && num <= 140.0)
		{
			return EChairInteractDirection.Left;
		}
		if (num >= -140.0 && num <= -50.0)
		{
			return EChairInteractDirection.Right;
		}
		if (num < 0.0)
		{
			num += 360.0;
		}
		if (num >= 140.0 && num <= 220.0)
		{
			return EChairInteractDirection.Backward;
		}
		return EChairInteractDirection.None;
	}

	// Token: 0x06019471 RID: 103537 RVA: 0x007B88C4 File Offset: 0x007B6AC4
	public void ResetCollision(Entity chair)
	{
		this.ActorComp.Actor.CapsuleComponent.SetCollisionResponseToChannel(ECollisionChannel.ECC_Pawn, ECollisionResponse.ECR_Block);
		if (chair == null)
		{
			return;
		}
		SceneItemActorComponent component = chair.GetComponent<SceneItemActorComponent>();
		if (component != null && component.Entity != null)
		{
			this.IgnoreActorsCollision(component, false);
		}
	}

	// Token: 0x06019472 RID: 103538 RVA: 0x007B8908 File Offset: 0x007B6B08
	private void IgnoreCollision(Entity chair)
	{
		SceneItemActorComponent component = chair.GetComponent<SceneItemActorComponent>();
		if (component != null && component.Entity != null)
		{
			this.IgnoreActorsCollision(component, true);
		}
		this.ActorComp.Actor.CapsuleComponent.SetCollisionResponseToChannel(ECollisionChannel.ECC_Pawn, ECollisionResponse.ECR_Ignore);
	}

	// Token: 0x06019473 RID: 103539 RVA: 0x007B8948 File Offset: 0x007B6B48
	private void IgnoreActorsCollision(SceneItemActorComponent actorComp, bool bCollision)
	{
		CreatureDataComponent component = actorComp.Entity.GetComponent<CreatureDataComponent>();
		int pbDataId = (component != null) ? component.GetPbDataId() : 0;
		int? ownerEntity = CreatureModel.Instance.GetOwnerEntity(pbDataId);
		SceneItemActorComponent sceneItemActorComponent;
		if (ownerEntity != null)
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(ownerEntity.Value);
			if (entityByPbDataId != null && entityByPbDataId.Valid)
			{
				sceneItemActorComponent = entityByPbDataId.Entity.GetComponent<SceneItemActorComponent>();
			}
			else
			{
				sceneItemActorComponent = actorComp;
			}
		}
		else
		{
			sceneItemActorComponent = actorComp;
		}
		TArray<AActor> tarray = new TArray<AActor>();
		sceneItemActorComponent.Owner.GetAttachedActors(ref tarray, true);
		int num = tarray.Num();
		for (int i = 0; i < num; i++)
		{
			AActor aactor = tarray.Get(i);
			TArray<AActor> tarray2 = new TArray<AActor>();
			aactor.GetAttachedActors(ref tarray2, true);
			int num2 = tarray2.Num();
			for (int j = 0; j < num2; j++)
			{
				this.ActorComp.Actor.CapsuleComponent.IgnoreActorWhenMoving(tarray2.Get(j), bCollision);
			}
		}
	}

	// Token: 0x06019474 RID: 103540 RVA: 0x007B8A38 File Offset: 0x007B6C38
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		NpcSitOnChairComponent npcSitOnChairComponent = (NpcSitOnChairComponent)componentTemplate;
		if (npcSitOnChairComponent.ChairNearbyPos != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.ChairNearbyPos), "ChairNearbyPos"))
		{
			return false;
		}
		if (npcSitOnChairComponent.TempVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector), "TempVector"))
		{
			return false;
		}
		if (npcSitOnChairComponent.TempVector2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempVector2), "TempVector2"))
		{
			return false;
		}
		if (npcSitOnChairComponent.TempRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TempRotator), "TempRotator"))
		{
			return false;
		}
		if (npcSitOnChairComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (npcSitOnChairComponent.MoveComp == null)
		{
			this.MoveComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
		{
			return false;
		}
		if (npcSitOnChairComponent.PerformComp == null)
		{
			this.PerformComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PerformComp), "PerformComp"))
		{
			return false;
		}
		if (npcSitOnChairComponent.AnimComp == null)
		{
			this.AnimComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimComp), "AnimComp"))
		{
			return false;
		}
		this.IsRoleNpc = npcSitOnChairComponent.IsRoleNpc;
		this.PlayingMontage = npcSitOnChairComponent.PlayingMontage;
		this.MovementMode = npcSitOnChairComponent.MovementMode;
		if (npcSitOnChairComponent.ChairController == null)
		{
			this.ChairController = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ChairController), "ChairController"))
		{
			return false;
		}
		if (npcSitOnChairComponent.Params == null)
		{
			this.Params = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Params), "Params"))
		{
			return false;
		}
		if (npcSitOnChairComponent.CloseMoveLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CloseMoveLocation), "CloseMoveLocation"))
		{
			return false;
		}
		this.IsExecuting = npcSitOnChairComponent.IsExecuting;
		this.IsAbortRequested = npcSitOnChairComponent.IsAbortRequested;
		this.FlowId = npcSitOnChairComponent.FlowId;
		this.MoveHandleId = npcSitOnChairComponent.MoveHandleId;
		this.IsActorChairCollisionIgnored = npcSitOnChairComponent.IsActorChairCollisionIgnored;
		this.IsChairPossessed = npcSitOnChairComponent.IsChairPossessed;
		this.IsChairInteractLocked = npcSitOnChairComponent.IsChairInteractLocked;
		this.LastChairClientCanInteraction = npcSitOnChairComponent.LastChairClientCanInteraction;
		this.IsExecuteMoveNearby = npcSitOnChairComponent.IsExecuteMoveNearby;
		this.IsExecuteMoveClose = npcSitOnChairComponent.IsExecuteMoveClose;
		this.IsExecuteTurnTo = npcSitOnChairComponent.IsExecuteTurnTo;
		this.IsExecutePlayMontage = npcSitOnChairComponent.IsExecutePlayMontage;
		this.IsExecuteMoveAway = npcSitOnChairComponent.IsExecuteMoveAway;
		this.IsAlignedToChair = npcSitOnChairComponent.IsAlignedToChair;
		this.PhaseInternal = npcSitOnChairComponent.PhaseInternal;
		this.LastFinishTime = npcSitOnChairComponent.LastFinishTime;
		this.StartSitOnChairTime = npcSitOnChairComponent.StartSitOnChairTime;
		this.StartStandUpTime = npcSitOnChairComponent.StartStandUpTime;
		if (npcSitOnChairComponent.ExitSitTimerHandle == null)
		{
			this.ExitSitTimerHandle = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ExitSitTimerHandle), "ExitSitTimerHandle"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x17002850 RID: 10320
	// (get) Token: 0x06019475 RID: 103541 RVA: 0x007B8D2B File Offset: 0x007B6F2B
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002851 RID: 10321
	// (get) Token: 0x06019476 RID: 103542 RVA: 0x007B8D2E File Offset: 0x007B6F2E
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002852 RID: 10322
	// (get) Token: 0x06019477 RID: 103543 RVA: 0x007B8D31 File Offset: 0x007B6F31
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002853 RID: 10323
	// (get) Token: 0x06019478 RID: 103544 RVA: 0x007B8D34 File Offset: 0x007B6F34
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400DD0C RID: 56588
	private const int TOLERANCE = 10;

	// Token: 0x0400DD0D RID: 56589
	private const int TURN_SPEED = 200;

	// Token: 0x0400DD0E RID: 56590
	private const int NEARBY_CHAIR_TOLERANCE_SQUARED = 2500;

	// Token: 0x0400DD0F RID: 56591
	private const int NEARBY_CHAIR_OFFSET = 50;

	// Token: 0x0400DD10 RID: 56592
	private const int MOVE_TO_CHAIR_SPEED = 70;

	// Token: 0x0400DD11 RID: 56593
	private const int MOVE_TO_NEARBY_CHAIR_SPEED = 100;

	// Token: 0x0400DD12 RID: 56594
	private const int MOVE_TO_NEARBY_CHAIR_RUN_SPEED = 400;

	// Token: 0x0400DD13 RID: 56595
	private const int MOVE_TO_CHAIR_DISTANCE_TOLERANCE = 5;

	// Token: 0x0400DD14 RID: 56596
	private const int NEARBY_RUN_DISTANCE_SQUARED = 160000;

	// Token: 0x0400DD15 RID: 56597
	private const int MODEL_BUFFER_TIME = 200;

	// Token: 0x0400DD16 RID: 56598
	private const int SIT_UP_TIME = 2000;

	// Token: 0x0400DD17 RID: 56599
	private const int SIT_DOWN_TIME = 1500;

	// Token: 0x0400DD18 RID: 56600
	private const int MOVE_TIMEOUT_1 = 1;

	// Token: 0x0400DD19 RID: 56601
	private const int MOVE_TIMEOUT_2 = 2;

	// Token: 0x0400DD1A RID: 56602
	private const int FOURTY_FIVE = 45;

	// Token: 0x0400DD1B RID: 56603
	private const double ZERO_EIGHT = 0.8;

	// Token: 0x0400DD1C RID: 56604
	private const int FIVETY = 50;

	// Token: 0x0400DD1D RID: 56605
	private const int ONE_HUNDRED_FOURTY = 140;

	// Token: 0x0400DD1E RID: 56606
	private const int TWO_HUNDRED_TWENTY = 220;

	// Token: 0x0400DD1F RID: 56607
	private const double PI_DEG_DOUBLE = 360.0;

	// Token: 0x0400DD20 RID: 56608
	private readonly Vector ChairNearbyPos = Vector.Create();

	// Token: 0x0400DD21 RID: 56609
	private readonly Vector TempVector = Vector.Create();

	// Token: 0x0400DD22 RID: 56610
	private readonly Vector TempVector2 = Vector.Create();

	// Token: 0x0400DD23 RID: 56611
	private readonly Rotator TempRotator = Rotator.Create();

	// Token: 0x0400DD24 RID: 56612
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400DD25 RID: 56613
	[Nullable(2)]
	private BaseMoveComponent MoveComp;

	// Token: 0x0400DD26 RID: 56614
	[Nullable(2)]
	private BasePerformComponent PerformComp;

	// Token: 0x0400DD27 RID: 56615
	[Nullable(2)]
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400DD28 RID: 56616
	private bool IsRoleNpc;

	// Token: 0x0400DD29 RID: 56617
	private int PlayingMontage = -1;

	// Token: 0x0400DD2A RID: 56618
	private EMovementMode MovementMode;

	// Token: 0x0400DD2B RID: 56619
	[Nullable(2)]
	private PawnChairController ChairController;

	// Token: 0x0400DD2C RID: 56620
	[Nullable(2)]
	private INpcSitOnChairParams Params;

	// Token: 0x0400DD2D RID: 56621
	private readonly Vector CloseMoveLocation = Vector.Create();

	// Token: 0x0400DD2E RID: 56622
	private bool IsExecuting;

	// Token: 0x0400DD2F RID: 56623
	private bool IsAbortRequested;

	// Token: 0x0400DD30 RID: 56624
	private int FlowId;

	// Token: 0x0400DD31 RID: 56625
	private int MoveHandleId;

	// Token: 0x0400DD32 RID: 56626
	private bool IsActorChairCollisionIgnored;

	// Token: 0x0400DD33 RID: 56627
	private bool IsChairPossessed;

	// Token: 0x0400DD34 RID: 56628
	private bool IsChairInteractLocked;

	// Token: 0x0400DD35 RID: 56629
	private bool LastChairClientCanInteraction = true;

	// Token: 0x0400DD36 RID: 56630
	private bool IsExecuteMoveNearby;

	// Token: 0x0400DD37 RID: 56631
	private bool IsExecuteMoveClose;

	// Token: 0x0400DD38 RID: 56632
	private bool IsExecuteTurnTo;

	// Token: 0x0400DD39 RID: 56633
	private bool IsExecutePlayMontage;

	// Token: 0x0400DD3A RID: 56634
	private bool IsExecuteMoveAway;

	// Token: 0x0400DD3B RID: 56635
	private bool IsAlignedToChair;

	// Token: 0x0400DD3C RID: 56636
	private NpcSitOnChair.ETaskPhase PhaseInternal;

	// Token: 0x0400DD3D RID: 56637
	private double LastFinishTime;

	// Token: 0x0400DD3E RID: 56638
	private double StartSitOnChairTime;

	// Token: 0x0400DD3F RID: 56639
	private double StartStandUpTime;

	// Token: 0x0400DD40 RID: 56640
	[Nullable(2)]
	private TimerHandle ExitSitTimerHandle;
}
