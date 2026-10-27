using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x02007359 RID: 29529
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionSetRageFullAttribute : AiStateMachineAction
	{
		// Token: 0x060486C5 RID: 296645 RVA: 0x012A0FA7 File Offset: 0x0129F1A7
		public AiStateMachineActionSetRageFullAttribute(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x060486C6 RID: 296646 RVA: 0x012A0FB1 File Offset: 0x0129F1B1
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Action action)
		{
			return true;
		}

		// Token: 0x060486C7 RID: 296647 RVA: 0x012A0FB4 File Offset: 0x0129F1B4
		public override void DoAction(long? contextId = null)
		{
		}

		// Token: 0x060486C8 RID: 296648 RVA: 0x012A0FB6 File Offset: 0x0129F1B6
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}
	}
}
