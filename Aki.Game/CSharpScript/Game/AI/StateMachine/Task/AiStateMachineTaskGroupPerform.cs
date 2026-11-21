using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.MonsterGroup;
using CSharpScript.Game.NewWorld.Character.Monster.Controller;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Task
{
	// Token: 0x0200649D RID: 25757
	public class AiStateMachineTaskGroupPerform : AiStateMachineTask
	{
		// Token: 0x0603E986 RID: 256390 RVA: 0x0123C345 File Offset: 0x0123A545
		[NullableContext(1)]
		public AiStateMachineTaskGroupPerform(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Task state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x0603E987 RID: 256391 RVA: 0x0123C350 File Offset: 0x0123A550
		public override void OnEnter(long? contextId = null)
		{
			MonsterEcologyInfo monsterInfoByEntityId = MonsterGroupEcologyController.Instance.GetMonsterInfoByEntityId(this.Node.Entity.Id);
			if (monsterInfoByEntityId != null)
			{
				monsterInfoByEntityId.GroupEcologyState = EGroupEcologyState.Ready;
			}
		}

		// Token: 0x0603E988 RID: 256392 RVA: 0x0123C384 File Offset: 0x0123A584
		public override void OnExit(long? contextId = null)
		{
			MonsterEcologyInfo monsterInfoByEntityId = MonsterGroupEcologyController.Instance.GetMonsterInfoByEntityId(this.Node.Entity.Id);
			if (monsterInfoByEntityId != null)
			{
				monsterInfoByEntityId.GroupEcologyState = EGroupEcologyState.None;
			}
		}

		// Token: 0x0603E989 RID: 256393 RVA: 0x0123C3B6 File Offset: 0x0123A5B6
		protected override void OnTick(float delta, long? contextId = null)
		{
			if (!MonsterGroupEcologyController.Instance.CheckEntityInMonsterGroup(this.Node.Entity.Id))
			{
				this.Node.TaskFinished = true;
			}
		}
	}
}
