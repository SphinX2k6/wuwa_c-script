using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x0200733D RID: 29501
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionCheckState : AiStateMachineCondition
	{
		// Token: 0x06048633 RID: 296499 RVA: 0x0129ED7B File Offset: 0x0129CF7B
		public AiStateMachineConditionCheckState(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x06048634 RID: 296500 RVA: 0x0129ED88 File Offset: 0x0129CF88
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

		// Token: 0x06048635 RID: 296501 RVA: 0x0129EDE8 File Offset: 0x0129CFE8
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

		// Token: 0x06048636 RID: 296502 RVA: 0x0129EE45 File Offset: 0x0129D045
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

		// Token: 0x06048637 RID: 296503 RVA: 0x0129EE84 File Offset: 0x0129D084
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

		// Token: 0x06048638 RID: 296504 RVA: 0x0129EEDE File Offset: 0x0129D0DE
		protected override void OnTick()
		{
			if (this.TargetNode == null)
			{
				this.TargetNode = this.GetTargetNode();
			}
			AiStateMachineBase targetNode = this.TargetNode;
			this.ResultSelf = (targetNode != null && targetNode.Activated);
		}

		// Token: 0x06048639 RID: 296505 RVA: 0x0129EF0C File Offset: 0x0129D10C
		private void OnStateActivated(bool value)
		{
			this.ResultSelf = value;
			AiStateMachineBase node = this.Node;
			if (node != null && node.Activated)
			{
				this.Node.Owner.TickStateMachine(base.Result, "AiStateMachineConditionCheckState", this.Node.Name);
			}
		}

		// Token: 0x0604863A RID: 296506 RVA: 0x0129EF5C File Offset: 0x0129D15C
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

		// Token: 0x04026462 RID: 156770
		[Nullable(2)]
		private string TargetNodeName;

		// Token: 0x04026463 RID: 156771
		private int? TargetNodeUuid;

		// Token: 0x04026464 RID: 156772
		[Nullable(2)]
		private AiStateMachineBase TargetNode;
	}
}
