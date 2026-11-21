using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x020064CA RID: 25802
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionTaskFinish : AiStateMachineCondition
	{
		// Token: 0x0603EAC9 RID: 256713 RVA: 0x01242EEB File Offset: 0x012410EB
		public AiStateMachineConditionTaskFinish(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0603EACA RID: 256714 RVA: 0x01242EF8 File Offset: 0x012410F8
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

		// Token: 0x0603EACB RID: 256715 RVA: 0x01242F5C File Offset: 0x0124115C
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

		// Token: 0x0603EACC RID: 256716 RVA: 0x01242FBE File Offset: 0x012411BE
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			this.HasTaskFinishCondition = true;
			return true;
		}

		// Token: 0x0603EACD RID: 256717 RVA: 0x01242FC8 File Offset: 0x012411C8
		protected override void OnClear()
		{
			this.HasTaskFinishCondition = false;
		}

		// Token: 0x0603EACE RID: 256718 RVA: 0x01242FD1 File Offset: 0x012411D1
		protected override void OnEnter()
		{
			this.ResultSelf = this.Node.CurrentLeafNode.TaskFinished;
		}

		// Token: 0x0603EACF RID: 256719 RVA: 0x01242FE9 File Offset: 0x012411E9
		protected override void OnTick()
		{
			this.ResultSelf = this.Node.CurrentLeafNode.TaskFinished;
		}

		// Token: 0x0603EAD0 RID: 256720 RVA: 0x01243004 File Offset: 0x01241204
		private void OnStateTaskFinished(bool taskFinished)
		{
			this.ResultSelf = this.Node.CurrentLeafNode.TaskFinished;
			AiStateMachineBase node = this.Node;
			if (node != null && node.Activated)
			{
				this.Node.Owner.TickStateMachine(base.Result, "AiStateMachineConditionTaskFinish", this.Node.Name);
			}
		}

		// Token: 0x0603EAD1 RID: 256721 RVA: 0x01243061 File Offset: 0x01241261
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			outBuilder.Append("节点任务完成\n");
		}
	}
}
