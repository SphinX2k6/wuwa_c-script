using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x020064AB RID: 25771
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStateBuff : AiStateMachineState
	{
		// Token: 0x0603EA05 RID: 256517 RVA: 0x0123F482 File Offset: 0x0123D682
		public AiStateMachineStateBuff(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x0603EA06 RID: 256518 RVA: 0x0123F48C File Offset: 0x0123D68C
		protected override bool OnInit(CombatStateMachineDefine.Fsm.State state)
		{
			this.BuffId = new long?(state.BindBuff.BuffId);
			return true;
		}

		// Token: 0x0603EA07 RID: 256519 RVA: 0x0123F4A5 File Offset: 0x0123D6A5
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x0402170F RID: 136975
		public long? BuffId;
	}
}
