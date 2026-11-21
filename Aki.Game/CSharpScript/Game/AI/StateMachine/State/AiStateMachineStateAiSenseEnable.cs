using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x020064A8 RID: 25768
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStateAiSenseEnable : AiStateMachineState
	{
		// Token: 0x0603E9F6 RID: 256502 RVA: 0x0123F22F File Offset: 0x0123D42F
		public AiStateMachineStateAiSenseEnable(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x0603E9F7 RID: 256503 RVA: 0x0123F239 File Offset: 0x0123D439
		protected override bool OnInit(CombatStateMachineDefine.Fsm.State state)
		{
			this.ConfigId = state.BindAiSenseEnable.ConfigId;
			return true;
		}

		// Token: 0x0603E9F8 RID: 256504 RVA: 0x0123F24D File Offset: 0x0123D44D
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

		// Token: 0x0603E9F9 RID: 256505 RVA: 0x0123F270 File Offset: 0x0123D470
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

		// Token: 0x0603E9FA RID: 256506 RVA: 0x0123F293 File Offset: 0x0123D493
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04021703 RID: 136963
		public int ConfigId;
	}
}
