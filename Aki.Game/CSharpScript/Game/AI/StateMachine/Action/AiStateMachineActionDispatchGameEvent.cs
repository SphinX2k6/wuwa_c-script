using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x020064D4 RID: 25812
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionDispatchGameEvent : AiStateMachineAction
	{
		// Token: 0x0603EAF9 RID: 256761 RVA: 0x012437B1 File Offset: 0x012419B1
		public AiStateMachineActionDispatchGameEvent(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x0603EAFA RID: 256762 RVA: 0x012437BB File Offset: 0x012419BB
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Action action)
		{
			return true;
		}

		// Token: 0x0603EAFB RID: 256763 RVA: 0x012437BE File Offset: 0x012419BE
		public override void DoAction(long? contextId = null)
		{
		}

		// Token: 0x0603EAFC RID: 256764 RVA: 0x012437C0 File Offset: 0x012419C0
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}
	}
}
