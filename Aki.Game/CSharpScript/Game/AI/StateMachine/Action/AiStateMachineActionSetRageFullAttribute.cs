using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x020064DC RID: 25820
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionSetRageFullAttribute : AiStateMachineAction
	{
		// Token: 0x0603EB13 RID: 256787 RVA: 0x01243AA3 File Offset: 0x01241CA3
		public AiStateMachineActionSetRageFullAttribute(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x0603EB14 RID: 256788 RVA: 0x01243AAD File Offset: 0x01241CAD
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Action action)
		{
			return true;
		}

		// Token: 0x0603EB15 RID: 256789 RVA: 0x01243AB0 File Offset: 0x01241CB0
		public override void DoAction(long? contextId = null)
		{
		}

		// Token: 0x0603EB16 RID: 256790 RVA: 0x01243AB2 File Offset: 0x01241CB2
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}
	}
}
