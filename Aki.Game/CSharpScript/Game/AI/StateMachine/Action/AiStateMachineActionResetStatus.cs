using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Module.CombatMessage;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Action
{
	// Token: 0x02007357 RID: 29527
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineActionResetStatus : AiStateMachineAction
	{
		// Token: 0x060486BE RID: 296638 RVA: 0x012A0EE8 File Offset: 0x0129F0E8
		public AiStateMachineActionResetStatus(AiStateMachineBase stateMachineNode, CombatStateMachineDefine.Fsm.Action action) : base(stateMachineNode, action)
		{
		}

		// Token: 0x060486BF RID: 296639 RVA: 0x012A0EF2 File Offset: 0x0129F0F2
		public override void DoAction(long? contextId = null)
		{
			if (this.Node.AiController == null)
			{
				return;
			}
			CombatMessageModel.Instance.AnyHateChange = true;
		}

		// Token: 0x060486C0 RID: 296640 RVA: 0x012A0F0D File Offset: 0x0129F10D
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			AiStateMachineHelper.AppendDepthSpace(outBuilder, depth);
		}
	}
}
