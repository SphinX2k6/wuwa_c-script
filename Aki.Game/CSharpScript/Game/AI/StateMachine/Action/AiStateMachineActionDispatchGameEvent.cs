using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x02007351 RID: 29521
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionDispatchGameEvent : AiStateMachineAction
	{
		// Token: 0x060486AC RID: 296620 RVA: 0x012A0D29 File Offset: 0x0129EF29
		public AiStateMachineActionDispatchGameEvent(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x060486AD RID: 296621 RVA: 0x012A0D33 File Offset: 0x0129EF33
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Action action)
		{
			return true;
		}

		// Token: 0x060486AE RID: 296622 RVA: 0x012A0D36 File Offset: 0x0129EF36
		public override void DoAction(long? contextId = null)
		{
		}

		// Token: 0x060486AF RID: 296623 RVA: 0x012A0D38 File Offset: 0x0129EF38
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}
	}
}
