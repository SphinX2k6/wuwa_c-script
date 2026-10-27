using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.NewWorld.Pawn.Controllers;
using NpcSitOnChair;
using UnrealEngine;

// Token: 0x020031E5 RID: 12773
[NullableContext(1)]
[Nullable(0)]
public class NpcSitOnChairComponent : EntityComponent
{
	// Token: 0x17002618 RID: 9752
	// (get) Token: 0x0601B8CB RID: 112843 RVA: 0x0078EA25 File Offset: 0x0078CC25
	// (set) Token: 0x0601B8CC RID: 112844 RVA: 0x0078EA2D File Offset: 0x0078CC2D
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

	// Token: 0x17002619 RID: 9753
	// (get) Token: 0x0601B8CD RID: 112845 RVA: 0x0078EA40 File Offset: 0x0078CC40
	public bool IsSitOnChairTaskRunning
	{
		get
		{
			return this.Params != null;
		}
	}

	// Token: 0x1700261A RID: 9754
	// (get) Token: 0x0601B8CE RID: 112846 RVA: 0x0078EA4B File Offset: 0x0078CC4B
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

	// Token: 0x0601B8CF RID: 112847 RVA: 0x0078EA74 File Offset: 0x0078CC74
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

	// Token: 0x0601B8D0 RID: 112848 RVA: 0x0078EAEC File Offset: 0x0078CCEC
	private bool IsRoleAnimInstance()
	{
		CharacterAnimationComponent animComp = this.AnimComp;
		UAnimInstance @object = (animComp != null) ? animComp.MainAnimInstance : null;
		return UKuroStaticLibrary.IsObjectClassByName(@object, CharacterNameDefines.Instance.ABP_BASEROLENPC) || UKuroStaticLibrary.IsObjectClassByName(@object, CharacterNameDefines.Instance.ABP_BASEROLE);
	}

	// Token: 0x0601B8D1 RID: 112849 RVA: 0x0078EB30 File Offset: 0x0078CD30
	protected override void OnActivate()
	{
	}

	// Token: 0x0601B8D2 RID: 112850 RVA: 0x0078EB32 File Offset: 0x0078CD32
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

	// Token: 0x0601B8D3 RID: 112851 RVA: 0x0078EB6B File Offset: 0x0078CD6B
	protected override bool OnEnd()
	{
		this.AbortImmediately();
		return true;
	}

	// Token: 0x0601B8D4 RID: 112852 RVA: 0x0078EB74 File Offset: 0x0078CD74
	public void RequestExit()
	{
		if (this.Params != null)
		{
			this.AbortGracefully();
		}
	}

	// Token: 0x0601B8D5 RID: 112853 RVA: 0x0078EB84 File Offset: 0x0078CD84
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

	// Token: 0x0601B8D6 RID: 112854 RVA: 0x0078ED44 File Offset: 0x0078CF44
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

	// Token: 0x0601B8D7 RID: 112855 RVA: 0x0078EE20 File Offset: 0x0078D020
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

	// Token: 0x0601B8D8 RID: 112856 RVA: 0x0078EEAC File Offset: 0x0078D0AC
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

	// Token: 0x0601B8D9 RID: 112857 RVA: 0x0078EF48 File Offset: 0x0078D148
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

	// Token: 0x0601B8DA RID: 112858 RVA: 0x0078EF8C File Offset: 0x0078D18C
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

	// Token: 0x0601B8DB RID: 112859 RVA: 0x0078EFE4 File Offset: 0x0078D1E4
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

	// Token: 0x0601B8DC RID: 112860 RVA: 0x0078F038 File Offset: 0x0078D238
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

	// Token: 0x0601B8DD RID: 112861 RVA: 0x0078F138 File Offset: 0x0078D338
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

	// Token: 0x0601B8DE RID: 112862 RVA: 0x0078F194 File Offset: 0x0078D394
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

	// Token: 0x0601B8DF RID: 112863 RVA: 0x0078F318 File Offset: 0x0078D518
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

	// Token: 0x0601B8E0 RID: 112864 RVA: 0x0078F444 File Offset: 0x0078D644
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

	// Token: 0x0601B8E1 RID: 112865 RVA: 0x0078F4DF File Offset: 0x0078D6DF
	private void ExecutePlaySitOnChairAnim()
	{
		if (!this.IsExecutePlayMontage)
		{
			this.StartSitOnChairTime = Time.Instance.Now;
			this.IsExecutePlayMontage = true;
			this.PlaySitDownAnim();
		}
	}

	// Token: 0x0601B8E2 RID: 112866 RVA: 0x0078F508 File Offset: 0x0078D708
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

	// Token: 0x0601B8E3 RID: 112867 RVA: 0x0078F54B File Offset: 0x0078D74B
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

	// Token: 0x0601B8E4 RID: 112868 RVA: 0x0078F584 File Offset: 0x0078D784
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

	// Token: 0x0601B8E5 RID: 112869 RVA: 0x0078F648 File Offset: 0x0078D848
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

	// Token: 0x0601B8E6 RID: 112870 RVA: 0x0078F6A0 File Offset: 0x0078D8A0
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

	// Token: 0x0601B8E7 RID: 112871 RVA: 0x0078F6FC File Offset: 0x0078D8FC
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

	// Token: 0x0601B8E8 RID: 112872 RVA: 0x0078F736 File Offset: 0x0078D936
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

	// Token: 0x0601B8E9 RID: 112873 RVA: 0x0078F774 File Offset: 0x0078D974
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

	// Token: 0x0601B8EA RID: 112874 RVA: 0x0078F8CB File Offset: 0x0078DACB
	private bool IsCurrentFlow(int flowId)
	{
		return this.FlowId == flowId && this.Params != null;
	}

	// Token: 0x0601B8EB RID: 112875 RVA: 0x0078F8E1 File Offset: 0x0078DAE1
	private bool IsCurrentPhase(int flowId, NpcSitOnChair.ETaskPhase phase)
	{
		return this.IsCurrentFlow(flowId) && this.IsExecuting && this.Phase == phase;
	}

	// Token: 0x0601B8EC RID: 112876 RVA: 0x0078F900 File Offset: 0x0078DB00
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

	// Token: 0x0601B8ED RID: 112877 RVA: 0x0078F960 File Offset: 0x0078DB60
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

	// Token: 0x0601B8EE RID: 112878 RVA: 0x0078F9D6 File Offset: 0x0078DBD6
	private void ClearExitSitTimerHandle()
	{
		if (this.ExitSitTimerHandle != null && TimerSystem.Instance.Has(this.ExitSitTimerHandle))
		{
			TimerSystem.Instance.Remove(this.ExitSitTimerHandle);
		}
		this.ExitSitTimerHandle = null;
	}

	// Token: 0x0601B8EF RID: 112879 RVA: 0x0078FA0A File Offset: 0x0078DC0A
	private void PlaySitDownAnim()
	{
		if (this.IsRoleNpc)
		{
			this.RoleNpcSitOnChair();
			return;
		}
		this.NormalNpcSitOnChair();
	}

	// Token: 0x0601B8F0 RID: 112880 RVA: 0x0078FA21 File Offset: 0x0078DC21
	private void PlayStandUpAnim()
	{
		if (this.IsRoleNpc)
		{
			this.RoleNpcStandUp();
			return;
		}
		this.NormalNpcStopMontage();
	}

	// Token: 0x0601B8F1 RID: 112881 RVA: 0x0078FA38 File Offset: 0x0078DC38
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

	// Token: 0x0601B8F2 RID: 112882 RVA: 0x0078FB19 File Offset: 0x0078DD19
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

	// Token: 0x0601B8F3 RID: 112883 RVA: 0x0078FB44 File Offset: 0x0078DD44
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

	// Token: 0x0601B8F4 RID: 112884 RVA: 0x0078FC00 File Offset: 0x0078DE00
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

	// Token: 0x0601B8F5 RID: 112885 RVA: 0x0078FC98 File Offset: 0x0078DE98
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

	// Token: 0x0601B8F6 RID: 112886 RVA: 0x0078FD70 File Offset: 0x0078DF70
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

	// Token: 0x0601B8F7 RID: 112887 RVA: 0x0078FE78 File Offset: 0x0078E078
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

	// Token: 0x0601B8F8 RID: 112888 RVA: 0x0078FFCC File Offset: 0x0078E1CC
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

	// Token: 0x0601B8F9 RID: 112889 RVA: 0x00790010 File Offset: 0x0078E210
	private void IgnoreCollision(Entity chair)
	{
		SceneItemActorComponent component = chair.GetComponent<SceneItemActorComponent>();
		if (component != null && component.Entity != null)
		{
			this.IgnoreActorsCollision(component, true);
		}
		this.ActorComp.Actor.CapsuleComponent.SetCollisionResponseToChannel(ECollisionChannel.ECC_Pawn, ECollisionResponse.ECR_Ignore);
	}

	// Token: 0x0601B8FA RID: 112890 RVA: 0x00790050 File Offset: 0x0078E250
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

	// Token: 0x0601B8FB RID: 112891 RVA: 0x00790140 File Offset: 0x0078E340
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		NpcSitOnChairComponent npcSitOnChairComponent = (NpcSitOnChairComponent)componentTemplate;
		if (base.CanResetComponentProperty("ChairNearbyPos") && npcSitOnChairComponent.ChairNearbyPos != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.ChairNearbyPos), "ChairNearbyPos"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TempVector") && npcSitOnChairComponent.TempVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TempVector), "TempVector"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TempVector2") && npcSitOnChairComponent.TempVector2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TempVector2), "TempVector2"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TempRotator") && npcSitOnChairComponent.TempRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Rotator>(this.TempRotator), "TempRotator"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (npcSitOnChairComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MoveComp"))
		{
			if (npcSitOnChairComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseMoveComponent>(this.MoveComp), "MoveComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("PerformComp"))
		{
			if (npcSitOnChairComponent.PerformComp == null)
			{
				this.PerformComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BasePerformComponent>(this.PerformComp), "PerformComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AnimComp"))
		{
			if (npcSitOnChairComponent.AnimComp == null)
			{
				this.AnimComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterAnimationComponent>(this.AnimComp), "AnimComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IsRoleNpc"))
		{
			this.IsRoleNpc = npcSitOnChairComponent.IsRoleNpc;
		}
		if (base.CanResetComponentProperty("PlayingMontage"))
		{
			this.PlayingMontage = npcSitOnChairComponent.PlayingMontage;
		}
		if (base.CanResetComponentProperty("MovementMode"))
		{
			this.MovementMode = npcSitOnChairComponent.MovementMode;
		}
		if (base.CanResetComponentProperty("ChairController"))
		{
			if (npcSitOnChairComponent.ChairController == null)
			{
				this.ChairController = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PawnChairController>(this.ChairController), "ChairController"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("Params"))
		{
			if (npcSitOnChairComponent.Params == null)
			{
				this.Params = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<INpcSitOnChairParams>(this.Params), "Params"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CloseMoveLocation") && npcSitOnChairComponent.CloseMoveLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.CloseMoveLocation), "CloseMoveLocation"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("IsExecuting"))
		{
			this.IsExecuting = npcSitOnChairComponent.IsExecuting;
		}
		if (base.CanResetComponentProperty("IsAbortRequested"))
		{
			this.IsAbortRequested = npcSitOnChairComponent.IsAbortRequested;
		}
		if (base.CanResetComponentProperty("FlowId"))
		{
			this.FlowId = npcSitOnChairComponent.FlowId;
		}
		if (base.CanResetComponentProperty("MoveHandleId"))
		{
			this.MoveHandleId = npcSitOnChairComponent.MoveHandleId;
		}
		if (base.CanResetComponentProperty("IsActorChairCollisionIgnored"))
		{
			this.IsActorChairCollisionIgnored = npcSitOnChairComponent.IsActorChairCollisionIgnored;
		}
		if (base.CanResetComponentProperty("IsChairPossessed"))
		{
			this.IsChairPossessed = npcSitOnChairComponent.IsChairPossessed;
		}
		if (base.CanResetComponentProperty("IsChairInteractLocked"))
		{
			this.IsChairInteractLocked = npcSitOnChairComponent.IsChairInteractLocked;
		}
		if (base.CanResetComponentProperty("LastChairClientCanInteraction"))
		{
			this.LastChairClientCanInteraction = npcSitOnChairComponent.LastChairClientCanInteraction;
		}
		if (base.CanResetComponentProperty("IsExecuteMoveNearby"))
		{
			this.IsExecuteMoveNearby = npcSitOnChairComponent.IsExecuteMoveNearby;
		}
		if (base.CanResetComponentProperty("IsExecuteMoveClose"))
		{
			this.IsExecuteMoveClose = npcSitOnChairComponent.IsExecuteMoveClose;
		}
		if (base.CanResetComponentProperty("IsExecuteTurnTo"))
		{
			this.IsExecuteTurnTo = npcSitOnChairComponent.IsExecuteTurnTo;
		}
		if (base.CanResetComponentProperty("IsExecutePlayMontage"))
		{
			this.IsExecutePlayMontage = npcSitOnChairComponent.IsExecutePlayMontage;
		}
		if (base.CanResetComponentProperty("IsExecuteMoveAway"))
		{
			this.IsExecuteMoveAway = npcSitOnChairComponent.IsExecuteMoveAway;
		}
		if (base.CanResetComponentProperty("IsAlignedToChair"))
		{
			this.IsAlignedToChair = npcSitOnChairComponent.IsAlignedToChair;
		}
		if (base.CanResetComponentProperty("PhaseInternal"))
		{
			this.PhaseInternal = npcSitOnChairComponent.PhaseInternal;
		}
		if (base.CanResetComponentProperty("LastFinishTime"))
		{
			this.LastFinishTime = npcSitOnChairComponent.LastFinishTime;
		}
		if (base.CanResetComponentProperty("StartSitOnChairTime"))
		{
			this.StartSitOnChairTime = npcSitOnChairComponent.StartSitOnChairTime;
		}
		if (base.CanResetComponentProperty("StartStandUpTime"))
		{
			this.StartStandUpTime = npcSitOnChairComponent.StartStandUpTime;
		}
		if (base.CanResetComponentProperty("ExitSitTimerHandle"))
		{
			if (npcSitOnChairComponent.ExitSitTimerHandle == null)
			{
				this.ExitSitTimerHandle = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.ExitSitTimerHandle), "ExitSitTimerHandle"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400D86E RID: 55406
	private const int TOLERANCE = 10;

	// Token: 0x0400D86F RID: 55407
	private const int TURN_SPEED = 200;

	// Token: 0x0400D870 RID: 55408
	private const int NEARBY_CHAIR_TOLERANCE_SQUARED = 2500;

	// Token: 0x0400D871 RID: 55409
	private const int NEARBY_CHAIR_OFFSET = 50;

	// Token: 0x0400D872 RID: 55410
	private const int MOVE_TO_CHAIR_SPEED = 70;

	// Token: 0x0400D873 RID: 55411
	private const int MOVE_TO_NEARBY_CHAIR_SPEED = 100;

	// Token: 0x0400D874 RID: 55412
	private const int MOVE_TO_NEARBY_CHAIR_RUN_SPEED = 400;

	// Token: 0x0400D875 RID: 55413
	private const int MOVE_TO_CHAIR_DISTANCE_TOLERANCE = 5;

	// Token: 0x0400D876 RID: 55414
	private const int NEARBY_RUN_DISTANCE_SQUARED = 160000;

	// Token: 0x0400D877 RID: 55415
	private const int MODEL_BUFFER_TIME = 200;

	// Token: 0x0400D878 RID: 55416
	private const int SIT_UP_TIME = 2000;

	// Token: 0x0400D879 RID: 55417
	private const int SIT_DOWN_TIME = 1500;

	// Token: 0x0400D87A RID: 55418
	private const int MOVE_TIMEOUT_1 = 1;

	// Token: 0x0400D87B RID: 55419
	private const int MOVE_TIMEOUT_2 = 2;

	// Token: 0x0400D87C RID: 55420
	private const int FOURTY_FIVE = 45;

	// Token: 0x0400D87D RID: 55421
	private const double ZERO_EIGHT = 0.8;

	// Token: 0x0400D87E RID: 55422
	private const int FIVETY = 50;

	// Token: 0x0400D87F RID: 55423
	private const int ONE_HUNDRED_FOURTY = 140;

	// Token: 0x0400D880 RID: 55424
	private const int TWO_HUNDRED_TWENTY = 220;

	// Token: 0x0400D881 RID: 55425
	private const double PI_DEG_DOUBLE = 360.0;

	// Token: 0x0400D882 RID: 55426
	private readonly Vector ChairNearbyPos = Vector.Create();

	// Token: 0x0400D883 RID: 55427
	private readonly Vector TempVector = Vector.Create();

	// Token: 0x0400D884 RID: 55428
	private readonly Vector TempVector2 = Vector.Create();

	// Token: 0x0400D885 RID: 55429
	private readonly Rotator TempRotator = Rotator.Create();

	// Token: 0x0400D886 RID: 55430
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400D887 RID: 55431
	[Nullable(2)]
	private BaseMoveComponent MoveComp;

	// Token: 0x0400D888 RID: 55432
	[Nullable(2)]
	private BasePerformComponent PerformComp;

	// Token: 0x0400D889 RID: 55433
	[Nullable(2)]
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400D88A RID: 55434
	private bool IsRoleNpc;

	// Token: 0x0400D88B RID: 55435
	private int PlayingMontage = -1;

	// Token: 0x0400D88C RID: 55436
	private EMovementMode MovementMode;

	// Token: 0x0400D88D RID: 55437
	[Nullable(2)]
	private PawnChairController ChairController;

	// Token: 0x0400D88E RID: 55438
	[Nullable(2)]
	private INpcSitOnChairParams Params;

	// Token: 0x0400D88F RID: 55439
	private readonly Vector CloseMoveLocation = Vector.Create();

	// Token: 0x0400D890 RID: 55440
	private bool IsExecuting;

	// Token: 0x0400D891 RID: 55441
	private bool IsAbortRequested;

	// Token: 0x0400D892 RID: 55442
	private int FlowId;

	// Token: 0x0400D893 RID: 55443
	private int MoveHandleId;

	// Token: 0x0400D894 RID: 55444
	private bool IsActorChairCollisionIgnored;

	// Token: 0x0400D895 RID: 55445
	private bool IsChairPossessed;

	// Token: 0x0400D896 RID: 55446
	private bool IsChairInteractLocked;

	// Token: 0x0400D897 RID: 55447
	private bool LastChairClientCanInteraction = true;

	// Token: 0x0400D898 RID: 55448
	private bool IsExecuteMoveNearby;

	// Token: 0x0400D899 RID: 55449
	private bool IsExecuteMoveClose;

	// Token: 0x0400D89A RID: 55450
	private bool IsExecuteTurnTo;

	// Token: 0x0400D89B RID: 55451
	private bool IsExecutePlayMontage;

	// Token: 0x0400D89C RID: 55452
	private bool IsExecuteMoveAway;

	// Token: 0x0400D89D RID: 55453
	private bool IsAlignedToChair;

	// Token: 0x0400D89E RID: 55454
	private NpcSitOnChair.ETaskPhase PhaseInternal;

	// Token: 0x0400D89F RID: 55455
	private double LastFinishTime;

	// Token: 0x0400D8A0 RID: 55456
	private double StartSitOnChairTime;

	// Token: 0x0400D8A1 RID: 55457
	private double StartStandUpTime;

	// Token: 0x0400D8A2 RID: 55458
	[Nullable(2)]
	private TimerHandle ExitSitTimerHandle;
}
