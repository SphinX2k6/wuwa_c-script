using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x020064CE RID: 25806
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionActivateSkillGroup : AiStateMachineAction
	{
		// Token: 0x0603EAE3 RID: 256739 RVA: 0x01243284 File Offset: 0x01241484
		public AiStateMachineActionActivateSkillGroup(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x0603EAE4 RID: 256740 RVA: 0x0124328E File Offset: 0x0124148E
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Action action)
		{
			this.ConfigId = action.ActionActivateSkillGroup.ConfigId;
			this.Activate = action.ActionActivateSkillGroup.Activate;
			return true;
		}

		// Token: 0x0603EAE5 RID: 256741 RVA: 0x012432B3 File Offset: 0x012414B3
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

		// Token: 0x0603EAE6 RID: 256742 RVA: 0x012432E0 File Offset: 0x012414E0
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04021762 RID: 137058
		public int ConfigId;

		// Token: 0x04021763 RID: 137059
		public bool Activate;
	}
}
