using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x0200734B RID: 29515
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionActivateSkillGroup : AiStateMachineAction
	{
		// Token: 0x06048696 RID: 296598 RVA: 0x012A07FC File Offset: 0x0129E9FC
		public AiStateMachineActionActivateSkillGroup(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x06048697 RID: 296599 RVA: 0x012A0806 File Offset: 0x0129EA06
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Action action)
		{
			this.ConfigId = action.ActionActivateSkillGroup.ConfigId;
			this.Activate = action.ActionActivateSkillGroup.Activate;
			return true;
		}

		// Token: 0x06048698 RID: 296600 RVA: 0x012A082B File Offset: 0x0129EA2B
		public override void DoAction(long? contextId = null)
		{
			AiController aiController = this.Node.AiController;
			if (aiController == null)
			{
				return;
			}
			AiSkill aiSkill = aiController.AiSkill;
			if (aiSkill == null)
			{
				return;
			}
			aiSkill.ActivateSkillGroup(this.ConfigId, this.Activate);
		}

		// Token: 0x06048699 RID: 296601 RVA: 0x012A0858 File Offset: 0x0129EA58
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04026475 RID: 156789
		public int ConfigId;

		// Token: 0x04026476 RID: 156790
		public bool Activate;
	}
}
