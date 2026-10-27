using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x02007353 RID: 29523
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionExitHit : AiStateMachineAction
	{
		// Token: 0x060486B2 RID: 296626 RVA: 0x012A0D54 File Offset: 0x0129EF54
		public AiStateMachineActionExitHit(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x060486B3 RID: 296627 RVA: 0x012A0D5E File Offset: 0x0129EF5E
		public override void DoAction(long? contextId = null)
		{
			this.Node.UnifiedStateComponent.ExitHitState("");
		}

		// Token: 0x060486B4 RID: 296628 RVA: 0x012A0D75 File Offset: 0x0129EF75
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}
	}
}
