using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x02007354 RID: 29524
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionRemoveBuff : AiStateMachineAction
	{
		// Token: 0x060486B5 RID: 296629 RVA: 0x012A0D7E File Offset: 0x0129EF7E
		public AiStateMachineActionRemoveBuff(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x060486B6 RID: 296630 RVA: 0x012A0D88 File Offset: 0x0129EF88
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Action action)
		{
			this.BuffId = new long?(action.ActionRemoveBuff.BuffId);
			return true;
		}

		// Token: 0x060486B7 RID: 296631 RVA: 0x012A0DA1 File Offset: 0x0129EFA1
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04026481 RID: 156801
		public long? BuffId;
	}
}
