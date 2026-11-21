using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Utils.CombatStateMachine;
using UnrealEngine;

namespace CSharpScript.Game.AI.StateMachine.Task
{
	// Token: 0x020064A2 RID: 25762
	[NullableContext(2)]
	[Nullable(0)]
	public class AiStateMachineTaskPatrol : AiStateMachineTask
	{
		// Token: 0x0603E9B6 RID: 256438 RVA: 0x0123E019 File Offset: 0x0123C219
		[NullableContext(1)]
		public AiStateMachineTaskPatrol(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Task state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x0603E9B7 RID: 256439 RVA: 0x0123E023 File Offset: 0x0123C223
		[NullableContext(1)]
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Task state)
		{
			this.MoveState = state.TaskPatrol.MoveState;
			this.OpenDebugMode = state.TaskPatrol.OpenDebugMode;
			return true;
		}

		// Token: 0x0603E9B8 RID: 256440 RVA: 0x0123E048 File Offset: 0x0123C248
		public override void OnEnter(long? contextId = null)
		{
			this.AiController = this.Node.AiComponent.AiController;
			if (this.AiController == null)
			{
				this.Finish();
				return;
			}
			this.PatrolLogic = this.AiController.AiPatrol;
			AiPatrolController patrolLogic = this.PatrolLogic;
			this.PatrolConfig = ((patrolLogic != null) ? patrolLogic.GetConfig() : null);
			if (this.PatrolConfig == null)
			{
				this.Finish();
				return;
			}
			this.Entity = this.AiController.CharAiDesignComp.Entity;
			this.MoveComp = this.Entity.GetComponent<BaseMoveComponent>();
			this.StateComp = this.Entity.GetComponent<BaseUnifiedStateComponent>();
			this.PatrolComp = this.Entity.GetComponent<CharacterPatrolComponent>();
			this.ActorComp = this.AiController.CharActorComp;
			if (this.PatrolComp == null)
			{
				this.Finish();
				return;
			}
			this.BeginPatrol();
		}

		// Token: 0x0603E9B9 RID: 256441 RVA: 0x0123E124 File Offset: 0x0123C324
		public override void OnExit(long? contextId = null)
		{
			if (!this.Node.TaskFinished)
			{
				if (this.PatrolComp != null && this.PatrolConfig != null)
				{
					this.PatrolComp.PausePatrol(this.PatrolConfig.SplineEntityId, "AiStateMachineTaskPatrol");
				}
				this.PatrolFinish();
				this.Finish();
			}
			if (this.MoveComp != null)
			{
				this.MoveComp.StopMoveNew("AiStateMachineTaskPatrol.OnExit");
				this.MoveComp.IsSpecialMove = false;
			}
		}

		// Token: 0x0603E9BA RID: 256442 RVA: 0x0123E199 File Offset: 0x0123C399
		private void Finish()
		{
			this.Node.TaskFinished = true;
		}

		// Token: 0x0603E9BB RID: 256443 RVA: 0x0123E1A8 File Offset: 0x0123C3A8
		private void InitPatrolInfo()
		{
			this.PatrolLogic.GeneratePatrol(true);
			this.PatrolLogic.StartPatrol(true, new Action(this.CallOutside));
			this.PatrolLogic.ResetBaseInfoByMainPoint(this.MoveComp, this.StateComp, this.MoveState);
		}

		// Token: 0x0603E9BC RID: 256444 RVA: 0x0123E1F8 File Offset: 0x0123C3F8
		private void CallOutside()
		{
			if (GlobalData.BpEventManager == null)
			{
				return;
			}
			AiPatrolController patrolLogic = this.PatrolLogic;
			PatrolPoint patrolPoint = (patrolLogic != null) ? patrolLogic.PatrolPoint : null;
			if (patrolPoint == null)
			{
				return;
			}
			if (!patrolPoint.IsMain)
			{
				return;
			}
			GlobalData.BpEventManager.AI巡逻达到样条点.Broadcast(this.ActorComp.Actor, this.PatrolLogic.PatrolIndex);
		}

		// Token: 0x0603E9BD RID: 256445 RVA: 0x0123E254 File Offset: 0x0123C454
		private void MoveToPatrolPoint()
		{
			AiStateMachineTaskPatrol.<>c__DisplayClass17_0 CS$<>8__locals1 = new AiStateMachineTaskPatrol.<>c__DisplayClass17_0();
			CS$<>8__locals1.<>4__this = this;
			AiStateMachineTaskPatrol.<>c__DisplayClass17_0 CS$<>8__locals2 = CS$<>8__locals1;
			AiPatrolController patrolLogic = this.PatrolLogic;
			CS$<>8__locals2.curPoint = ((patrolLogic != null) ? patrolLogic.PatrolPoint : null);
			if (CS$<>8__locals1.curPoint == null)
			{
				return;
			}
			if (this.PatrolComp.HasPatrolRecord(null))
			{
				this.PatrolComp.ResumePatrol(this.PatrolConfig.SplineEntityId, "AiStateMachineTaskPatrol");
				return;
			}
			Action<int> onArrivePointHandle = delegate(int _)
			{
				int lastPointRawIndex = CS$<>8__locals1.<>4__this.PatrolComp.GetLastPointRawIndex();
				if (lastPointRawIndex != -1)
				{
					CS$<>8__locals1.<>4__this.PatrolLogic.SetPatrolIndex(lastPointRawIndex);
				}
				if (CS$<>8__locals1.curPoint.IsMain)
				{
					CS$<>8__locals1.<>4__this.CallOutside();
				}
			};
			Action<ELevelEventState> onPatrolEndHandle = delegate(ELevelEventState result)
			{
				if (result == ELevelEventState.Success)
				{
					CS$<>8__locals1.<>4__this.PatrolFinish();
				}
				CS$<>8__locals1.<>4__this.Finish();
			};
			PatrolParamsImpl config = new PatrolParamsImpl
			{
				DebugMode = new bool?(this.OpenDebugMode),
				StartMode = new EPatrolStartMode?(EPatrolStartMode.NearestPoint),
				ReturnFalseWhenNavigationFailed = new bool?(false),
				OnArrivePointHandle = onArrivePointHandle,
				OnPatrolEndHandle = onPatrolEndHandle
			};
			this.PatrolComp.StartPatrol(this.PatrolConfig.SplineEntityId, config);
		}

		// Token: 0x0603E9BE RID: 256446 RVA: 0x0123E330 File Offset: 0x0123C530
		private void PatrolFinish()
		{
			this.CallOutside();
			AiPatrolController patrolLogic = this.PatrolLogic;
			if (patrolLogic == null)
			{
				return;
			}
			patrolLogic.PatrolFinish();
		}

		// Token: 0x0603E9BF RID: 256447 RVA: 0x0123E348 File Offset: 0x0123C548
		private void BeginPatrol()
		{
			if (this.PatrolConfig.ContainZ && this.MoveComp != null)
			{
				CharacterActorComponent actorComp = this.ActorComp;
				if (actorComp != null)
				{
					actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
					{
						Mode = EMovementMode.MOVE_Flying,
						Context = "[AiStateMachineTaskPatrol.BeginPatrol]"
					});
				}
			}
			this.InitPatrolInfo();
			AiPatrolController patrolLogic = this.PatrolLogic;
			if (((patrolLogic != null) ? patrolLogic.PatrolPoint : null) == null)
			{
				this.Finish();
				return;
			}
			this.MoveToPatrolPoint();
			if (this.AiController.AiPatrol.StartWithInversePath != null)
			{
				this.AiController.AiPatrol.StartWithInversePath = null;
			}
		}

		// Token: 0x040216E0 RID: 136928
		private AiPatrolController PatrolLogic;

		// Token: 0x040216E1 RID: 136929
		private AiPatrolConfig PatrolConfig;

		// Token: 0x040216E2 RID: 136930
		private Entity Entity;

		// Token: 0x040216E3 RID: 136931
		private BaseMoveComponent MoveComp;

		// Token: 0x040216E4 RID: 136932
		private BaseUnifiedStateComponent StateComp;

		// Token: 0x040216E5 RID: 136933
		private CharacterPatrolComponent PatrolComp;

		// Token: 0x040216E6 RID: 136934
		private CharacterActorComponent ActorComp;

		// Token: 0x040216E7 RID: 136935
		private AiController AiController;

		// Token: 0x040216E8 RID: 136936
		public int MoveState;

		// Token: 0x040216E9 RID: 136937
		public bool OpenDebugMode;
	}
}
