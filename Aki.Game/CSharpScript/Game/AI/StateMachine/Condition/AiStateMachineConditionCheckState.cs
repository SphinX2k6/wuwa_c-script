using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x020064C0 RID: 25792
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionCheckState : AiStateMachineCondition
	{
		// Token: 0x0603EA80 RID: 256640 RVA: 0x01241803 File Offset: 0x0123FA03
		public AiStateMachineConditionCheckState(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0603EA81 RID: 256641 RVA: 0x01241810 File Offset: 0x0123FA10
		protected override bool RegisterEvents()
		{
			if (base.RegisterEvents())
			{
				AiStateMachineBase targetNode = this.GetTargetNode();
				if (targetNode != null && !EventSystem.Instance.HasWithTarget(targetNode, EEventName.OnStateActivated, new Action<bool>(this.OnStateActivated)))
				{
					EventSystem.Instance.AddWithTarget(targetNode, EEventName.OnStateActivated, new Action<bool>(this.OnStateActivated));
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603EA82 RID: 256642 RVA: 0x01241870 File Offset: 0x0123FA70
		protected override bool UnregisterEvents()
		{
			if (base.UnregisterEvents())
			{
				AiStateMachineBase targetNode = this.GetTargetNode();
				if (targetNode != null && EventSystem.Instance.HasWithTarget(targetNode, EEventName.OnStateActivated, new Action<bool>(this.OnStateActivated)))
				{
					EventSystem.Instance.RemoveWithTarget(targetNode, EEventName.OnStateActivated, new Action<bool>(this.OnStateActivated));
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603EA83 RID: 256643 RVA: 0x012418CD File Offset: 0x0123FACD
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			if (condition.CondCheckState != null)
			{
				this.TargetNodeUuid = new int?(condition.CondCheckState.TargetState);
			}
			else if (condition.CondCheckStateByName != null)
			{
				this.TargetNodeName = condition.CondCheckStateByName.TargetStateName;
			}
			return true;
		}

		// Token: 0x0603EA84 RID: 256644 RVA: 0x0124190C File Offset: 0x0123FB0C
		[NullableContext(2)]
		private AiStateMachineBase GetTargetNode()
		{
			AiStateMachineBase result = null;
			if (this.TargetNodeUuid != null)
			{
				result = this.Node.Owner.GetNodeByUuid(this.TargetNodeUuid.Value);
			}
			else if (this.TargetNodeName != null)
			{
				result = this.Node.Owner.GetNodeByName(this.TargetNodeName);
			}
			return result;
		}

		// Token: 0x0603EA85 RID: 256645 RVA: 0x01241966 File Offset: 0x0123FB66
		protected override void OnTick()
		{
			if (this.TargetNode == null)
			{
				this.TargetNode = this.GetTargetNode();
			}
			AiStateMachineBase targetNode = this.TargetNode;
			this.ResultSelf = (targetNode != null && targetNode.Activated);
		}

		// Token: 0x0603EA86 RID: 256646 RVA: 0x01241994 File Offset: 0x0123FB94
		private void OnStateActivated(bool value)
		{
			this.ResultSelf = value;
			AiStateMachineBase node = this.Node;
			if (node != null && node.Activated)
			{
				this.Node.Owner.TickStateMachine(base.Result, "AiStateMachineConditionCheckState", this.Node.Name);
			}
		}

		// Token: 0x0603EA87 RID: 256647 RVA: 0x012419E4 File Offset: 0x0123FBE4
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler;
			if (this.TargetNode == null)
			{
				appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(17, 1, outBuilder);
				appendInterpolatedStringHandler.AppendLiteral("检查节点状态 [");
				appendInterpolatedStringHandler.AppendFormatted(this.TargetNodeName);
				appendInterpolatedStringHandler.AppendLiteral("] 目标节点不存在");
				outBuilder.Append(ref appendInterpolatedStringHandler);
				return;
			}
			appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(10, 1, outBuilder);
			appendInterpolatedStringHandler.AppendLiteral("检查节点状态 [");
			appendInterpolatedStringHandler.AppendFormatted(this.TargetNode.Name);
			appendInterpolatedStringHandler.AppendLiteral("]\n");
			outBuilder.Append(ref appendInterpolatedStringHandler);
		}

		// Token: 0x0402174F RID: 137039
		[Nullable(2)]
		private string TargetNodeName;

		// Token: 0x04021750 RID: 137040
		private int? TargetNodeUuid;

		// Token: 0x04021751 RID: 137041
		[Nullable(2)]
		private AiStateMachineBase TargetNode;
	}
}
