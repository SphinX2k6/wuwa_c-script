using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.State
{
	// Token: 0x02007328 RID: 29480
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineStateBuff : AiStateMachineState
	{
		// Token: 0x060485B8 RID: 296376 RVA: 0x0129CA02 File Offset: 0x0129AC02
		public AiStateMachineStateBuff(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.State state) : base(stateMachineNode, state)
		{
		}

		// Token: 0x060485B9 RID: 296377 RVA: 0x0129CA0C File Offset: 0x0129AC0C
		protected override bool OnInit(CombatStateMachineDefine.Fsm.State state)
		{
			this.BuffId = new long?(state.BindBuff.BuffId);
			return true;
		}

		// Token: 0x060485BA RID: 296378 RVA: 0x0129CA25 File Offset: 0x0129AC25
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04026422 RID: 156706
		public long? BuffId;
	}
}
