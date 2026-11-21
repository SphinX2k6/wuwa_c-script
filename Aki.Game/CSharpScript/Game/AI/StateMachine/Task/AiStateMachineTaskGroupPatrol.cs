using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.MonsterGroup;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Task
{
	// Token: 0x0200649C RID: 25756
	public class AiStateMachineTaskGroupPatrol : AiStateMachineTask
	{
		// Token: 0x0603E982 RID: 256386 RVA: 0x0123C297 File Offset: 0x0123A497
		[NullableContext(1)]
		public AiStateMachineTaskGroupPatrol(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Task state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x0603E983 RID: 256387 RVA: 0x0123C2A4 File Offset: 0x0123A4A4
		public override void OnEnter(long? contextId = null)
		{
			MonsterPatrolInfo monsterInfoByEntityId = MonsterGroupPatrolModel.Instance.GetMonsterInfoByEntityId(this.Node.Entity.Id);
			if (monsterInfoByEntityId != null)
			{
				monsterInfoByEntityId.GroupPatrolState = EGroupPatrolState.Ready;
			}
		}

		// Token: 0x0603E984 RID: 256388 RVA: 0x0123C2D8 File Offset: 0x0123A4D8
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

		// Token: 0x0603E985 RID: 256389 RVA: 0x0123C31B File Offset: 0x0123A51B
		protected override void OnTick(float delta, long? contextId = null)
		{
			if (MonsterGroupPatrolModel.Instance.GetMonsterInfoByEntityId(this.Node.Entity.Id) == null)
			{
				this.Node.TaskFinished = true;
			}
		}
	}
}
