using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x0200734C RID: 29516
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionAddBuff : AiStateMachineAction
	{
		// Token: 0x0604869A RID: 296602 RVA: 0x012A0861 File Offset: 0x0129EA61
		public AiStateMachineActionAddBuff(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x0604869B RID: 296603 RVA: 0x012A086B File Offset: 0x0129EA6B
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Action action)
		{
			this.BuffId = new long?(action.ActionAddBuff.BuffId);
			return true;
		}

		// Token: 0x0604869C RID: 296604 RVA: 0x012A0884 File Offset: 0x0129EA84
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}

		// Token: 0x04026477 RID: 156791
		public long? BuffId;
	}
}
