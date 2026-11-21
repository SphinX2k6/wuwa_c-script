using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Module.CombatMessage;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x020064DA RID: 25818
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionResetStatus : AiStateMachineAction
	{
		// Token: 0x0603EB0C RID: 256780 RVA: 0x012439E2 File Offset: 0x01241BE2
		public AiStateMachineActionResetStatus(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x0603EB0D RID: 256781 RVA: 0x012439EC File Offset: 0x01241BEC
		public override void DoAction(long? contextId = null)
		{
			if (this.Node.AiController == null)
			{
				return;
			}
			CombatMessageModel.Instance.AnyHateChange = true;
		}

		// Token: 0x0603EB0E RID: 256782 RVA: 0x01243A07 File Offset: 0x01241C07
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}
	}
}
