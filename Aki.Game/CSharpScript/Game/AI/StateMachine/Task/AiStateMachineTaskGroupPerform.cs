using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.MonsterGroup;
using CSharpScript.Game.NewWorld.Character.Monster.Controller;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Task
{
	// Token: 0x0200731A RID: 29466
	public class AiStateMachineTaskGroupPerform : AiStateMachineTask
	{
		// Token: 0x06048539 RID: 296249 RVA: 0x012998C5 File Offset: 0x01297AC5
		[NullableContext(1)]
		public AiStateMachineTaskGroupPerform(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Task state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x0604853A RID: 296250 RVA: 0x012998D0 File Offset: 0x01297AD0
		public override void OnEnter(long? contextId = null)
		{
			MonsterEcologyInfo monsterInfoByEntityId = MonsterGroupEcologyController.Instance.GetMonsterInfoByEntityId(this.Node.Entity.Id);
			if (monsterInfoByEntityId != null)
			{
				monsterInfoByEntityId.GroupEcologyState = EGroupEcologyState.Ready;
			}
		}

		// Token: 0x0604853B RID: 296251 RVA: 0x01299904 File Offset: 0x01297B04
		public override void OnExit(long? contextId = null)
		{
			MonsterEcologyInfo monsterInfoByEntityId = MonsterGroupEcologyController.Instance.GetMonsterInfoByEntityId(this.Node.Entity.Id);
			if (monsterInfoByEntityId != null)
			{
				monsterInfoByEntityId.GroupEcologyState = EGroupEcologyState.None;
			}
		}

		// Token: 0x0604853C RID: 296252 RVA: 0x01299936 File Offset: 0x01297B36
		protected override void OnTick(float delta, long? contextId = null)
		{
			if (!MonsterGroupEcologyController.Instance.CheckEntityInMonsterGroup(this.Node.Entity.Id))
			{
				this.Node.TaskFinished = true;
			}
		}
	}
}
