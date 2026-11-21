using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x020064BE RID: 25790
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionCheckLastState : AiStateMachineCondition
	{
		// Token: 0x0603EA75 RID: 256629 RVA: 0x0124158B File Offset: 0x0123F78B
		public AiStateMachineConditionCheckLastState(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0603EA76 RID: 256630 RVA: 0x01241596 File Offset: 0x0123F796
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			this.TargetNodeName = condition.CondCheckLastState.TargetStateName;
			return true;
		}

		// Token: 0x0603EA77 RID: 256631 RVA: 0x012415AA File Offset: 0x0123F7AA
		protected override void OnTick()
		{
			this.ResultSelf = this.Node.Owner.CheckLastActivatedNode(this.TargetNodeName);
		}

		// Token: 0x0603EA78 RID: 256632 RVA: 0x012415C8 File Offset: 0x0123F7C8
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler;
			if (this.TargetNode == null)
			{
				appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(20, 1, outBuilder);
				appendInterpolatedStringHandler.AppendLiteral("检查上一帧节点激活 [");
				appendInterpolatedStringHandler.AppendFormatted(this.TargetNodeName);
				appendInterpolatedStringHandler.AppendLiteral("] 目标节点不存在");
				outBuilder.Append(ref appendInterpolatedStringHandler);
				return;
			}
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(13, 1, outBuilder);
			appendInterpolatedStringHandler.AppendLiteral("检查上一帧节点激活 [");
			appendInterpolatedStringHandler.AppendFormatted(this.TargetNode.Name);
			appendInterpolatedStringHandler.AppendLiteral("]\n");
			outBuilder.Append(ref appendInterpolatedStringHandler);
		}

		// Token: 0x0402174C RID: 137036
		[Nullable(2)]
		private string TargetNodeName;

		// Token: 0x0402174D RID: 137037
		[Nullable(2)]
		private readonly AiStateMachineBase TargetNode;
	}
}
