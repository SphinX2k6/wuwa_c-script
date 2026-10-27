using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x02007347 RID: 29511
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionTaskFinish : AiStateMachineCondition
	{
		// Token: 0x0604867C RID: 296572 RVA: 0x012A0463 File Offset: 0x0129E663
		public AiStateMachineConditionTaskFinish(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0604867D RID: 296573 RVA: 0x012A0470 File Offset: 0x0129E670
		protected override bool RegisterEvents()
		{
			if (base.RegisterEvents())
			{
				AiStateMachineBase currentLeafNode = this.Node.CurrentLeafNode;
				if (currentLeafNode != null && !EventSystem.Instance.HasWithTarget(currentLeafNode, EEventName.OnStateTaskFinished, new Action<bool>(this.OnStateTaskFinished)))
				{
					EventSystem.Instance.AddWithTarget(currentLeafNode, EEventName.OnStateTaskFinished, new Action<bool>(this.OnStateTaskFinished));
					return true;
				}
			}
			return false;
		}

		// Token: 0x0604867E RID: 296574 RVA: 0x012A04D4 File Offset: 0x0129E6D4
		protected override bool UnregisterEvents()
		{
			if (base.UnregisterEvents())
			{
				AiStateMachineBase currentLeafNode = this.Node.CurrentLeafNode;
				if (currentLeafNode != null && EventSystem.Instance.HasWithTarget(currentLeafNode, EEventName.OnStateTaskFinished, new Action<bool>(this.OnStateTaskFinished)))
				{
					EventSystem.Instance.RemoveWithTarget(currentLeafNode, EEventName.OnStateTaskFinished, new Action<bool>(this.OnStateTaskFinished));
					return true;
				}
			}
			return false;
		}

		// Token: 0x0604867F RID: 296575 RVA: 0x012A0536 File Offset: 0x0129E736
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			this.HasTaskFinishCondition = true;
			return true;
		}

		// Token: 0x06048680 RID: 296576 RVA: 0x012A0540 File Offset: 0x0129E740
		protected override void OnClear()
		{
			this.HasTaskFinishCondition = false;
		}

		// Token: 0x06048681 RID: 296577 RVA: 0x012A0549 File Offset: 0x0129E749
		protected override void OnEnter()
		{
			this.ResultSelf = this.Node.CurrentLeafNode.TaskFinished;
		}

		// Token: 0x06048682 RID: 296578 RVA: 0x012A0561 File Offset: 0x0129E761
		protected override void OnTick()
		{
			this.ResultSelf = this.Node.CurrentLeafNode.TaskFinished;
		}

		// Token: 0x06048683 RID: 296579 RVA: 0x012A057C File Offset: 0x0129E77C
		private void OnStateTaskFinished(bool taskFinished)
		{
			this.ResultSelf = this.Node.CurrentLeafNode.TaskFinished;
			AiStateMachineBase node = this.Node;
			if (node != null && node.Activated)
			{
				this.Node.Owner.TickStateMachine(base.Result, "AiStateMachineConditionTaskFinish", this.Node.Name);
			}
		}

		// Token: 0x06048684 RID: 296580 RVA: 0x012A05D9 File Offset: 0x0129E7D9
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			outBuilder.Append("节点任务完成\n");
		}
	}
}
