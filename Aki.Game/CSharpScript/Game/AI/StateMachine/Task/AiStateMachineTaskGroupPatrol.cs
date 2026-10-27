using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.MonsterGroup;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Task
{
	// Token: 0x02007319 RID: 29465
	public class AiStateMachineTaskGroupPatrol : AiStateMachineTask
	{
		// Token: 0x06048535 RID: 296245 RVA: 0x01299817 File Offset: 0x01297A17
		[NullableContext(1)]
		public AiStateMachineTaskGroupPatrol(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Task state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x06048536 RID: 296246 RVA: 0x01299824 File Offset: 0x01297A24
		public override void OnEnter(long? contextId = null)
		{
			MonsterPatrolInfo monsterInfoByEntityId = MonsterGroupPatrolModel.Instance.GetMonsterInfoByEntityId(this.Node.Entity.Id);
			if (monsterInfoByEntityId != null)
			{
				monsterInfoByEntityId.GroupPatrolState = EGroupPatrolState.Ready;
			}
		}

		// Token: 0x06048537 RID: 296247 RVA: 0x01299858 File Offset: 0x01297A58
		public override void OnExit(long? contextId = null)
		{
			MonsterPatrolInfo monsterInfoByEntityId = MonsterGroupPatrolModel.Instance.GetMonsterInfoByEntityId(this.Node.Entity.Id);
			if (monsterInfoByEntityId != null)
			{
				MonsterGroupInfo group = monsterInfoByEntityId.Group;
				if (group != null)
				{
					group.PausePatrol();
				}
				monsterInfoByEntityId.GroupPatrolState = EGroupPatrolState.None;
			}
		}

		// Token: 0x06048538 RID: 296248 RVA: 0x0129989B File Offset: 0x01297A9B
		protected override void OnTick(float delta, long? contextId = null)
		{
			if (MonsterGroupPatrolModel.Instance.GetMonsterInfoByEntityId(this.Node.Entity.Id) == null)
			{
				this.Node.TaskFinished = true;
			}
		}
	}
}
