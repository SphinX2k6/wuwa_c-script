using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x02007325 RID: 29477
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStateAiSenseEnable : AiStateMachineState
	{
		// Token: 0x060485A9 RID: 296361 RVA: 0x0129C7AF File Offset: 0x0129A9AF
		public AiStateMachineStateAiSenseEnable(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x060485AA RID: 296362 RVA: 0x0129C7B9 File Offset: 0x0129A9B9
		protected override bool OnInit(CombatStateMachineDefine.Fsm.State state)
		{
			this.ConfigId = state.BindAiSenseEnable.ConfigId;
			return true;
		}

		// Token: 0x060485AB RID: 296363 RVA: 0x0129C7CD File Offset: 0x0129A9CD
		[NullableContext(2)]
		public override void OnActivate(AiStateMachineBase lastState = null, long? contextId = null)
		{
			IAiPerception aiPerception = this.Node.AiController.AiPerception;
			if (aiPerception == null)
			{
				return;
			}
			aiPerception.SetAiSenseEnable(this.ConfigId, true);
		}

		// Token: 0x060485AC RID: 296364 RVA: 0x0129C7F0 File Offset: 0x0129A9F0
		[NullableContext(2)]
		public override void OnDeactivate(AiStateMachineBase nextState = null, long? contextId = null)
		{
			IAiPerception aiPerception = this.Node.AiController.AiPerception;
			if (aiPerception == null)
			{
				return;
			}
			aiPerception.SetAiSenseEnable(this.ConfigId, false);
		}

		// Token: 0x060485AD RID: 296365 RVA: 0x0129C813 File Offset: 0x0129AA13
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04026416 RID: 156694
		public int ConfigId;
	}
}
