using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x0200733B RID: 29499
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionCheckLastState : AiStateMachineCondition
	{
		// Token: 0x06048628 RID: 296488 RVA: 0x0129EB03 File Offset: 0x0129CD03
		public AiStateMachineConditionCheckLastState(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x06048629 RID: 296489 RVA: 0x0129EB0E File Offset: 0x0129CD0E
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			this.TargetNodeName = condition.CondCheckLastState.TargetStateName;
			return true;
		}

		// Token: 0x0604862A RID: 296490 RVA: 0x0129EB22 File Offset: 0x0129CD22
		protected override void OnTick()
		{
			this.ResultSelf = this.Node.Owner.CheckLastActivatedNode(this.TargetNodeName);
		}

		// Token: 0x0604862B RID: 296491 RVA: 0x0129EB40 File Offset: 0x0129CD40
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

		// Token: 0x0402645F RID: 156767
		[Nullable(2)]
		private string TargetNodeName;

		// Token: 0x04026460 RID: 156768
		[Nullable(2)]
		private readonly AiStateMachineBase TargetNode;
	}
}
