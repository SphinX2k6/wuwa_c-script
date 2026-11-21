using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.AI.StateMachine.Task;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x020064C6 RID: 25798
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionMontageTimeRemaining : AiStateMachineCondition
	{
		// Token: 0x0603EAAC RID: 256684 RVA: 0x012426B1 File Offset: 0x012408B1
		public AiStateMachineConditionMontageTimeRemaining(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0603EAAD RID: 256685 RVA: 0x012426BC File Offset: 0x012408BC
		protected override bool RegisterEvents()
		{
			if (base.RegisterEvents() && this.TaskMontage != null && !EventSystem.Instance.HasWithTarget(this.TaskMontage, EEventName.OnMontageRemain, new Action<float>(this.OnMontageRemain)))
			{
				EventSystem.Instance.AddWithTarget(this.TaskMontage, EEventName.OnMontageRemain, new Action<float>(this.OnMontageRemain));
				return true;
			}
			return false;
		}

		// Token: 0x0603EAAE RID: 256686 RVA: 0x01242724 File Offset: 0x01240924
		protected override bool UnregisterEvents()
		{
			if (base.UnregisterEvents() && this.TaskMontage != null && EventSystem.Instance.HasWithTarget(this.TaskMontage, EEventName.OnMontageRemain, new Action<float>(this.OnMontageRemain)))
			{
				EventSystem.Instance.RemoveWithTarget(this.TaskMontage, EEventName.OnMontageRemain, new Action<float>(this.OnMontageRemain));
				return true;
			}
			return false;
		}

		// Token: 0x0603EAAF RID: 256687 RVA: 0x0124278C File Offset: 0x0124098C
		private void InitMontageRemain()
		{
			if (this.TaskMontage != null)
			{
				AiStateMachineTaskMontage aiStateMachineTaskMontage = this.TaskMontage as AiStateMachineTaskMontage;
				if (aiStateMachineTaskMontage != null)
				{
					aiStateMachineTaskMontage.RemainedTrigger = this.Time;
				}
				else
				{
					AiStateMachineTaskRandomMontage aiStateMachineTaskRandomMontage = this.TaskMontage as AiStateMachineTaskRandomMontage;
					if (aiStateMachineTaskRandomMontage != null)
					{
						aiStateMachineTaskRandomMontage.RemainedTrigger = this.Time;
					}
				}
				this.RegisterEvents();
			}
		}

		// Token: 0x0603EAB0 RID: 256688 RVA: 0x012427E0 File Offset: 0x012409E0
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			this.HasTaskFinishCondition = true;
			this.Time = condition.CondMontageTimeRemaining.Time * 0.001f;
			AiStateMachineTask task = this.Node.Task;
			if (task != null && task.Type == CombatStateMachineDefine.Fsm.ETaskType.TaskMontage)
			{
				this.TaskMontage = (this.Node.Task as AiStateMachineTaskMontage);
				this.InitMontageRemain();
			}
			else
			{
				AiStateMachineTask task2 = this.Node.Task;
				if (task2 != null && task2.Type == CombatStateMachineDefine.Fsm.ETaskType.TaskRandomMontage)
				{
					this.TaskMontage = (this.Node.Task as AiStateMachineTaskRandomMontage);
					this.InitMontageRemain();
				}
				else
				{
					AiStateMachineTask task3 = this.Node.Task;
					if (task3 == null || task3.Type != CombatStateMachineDefine.Fsm.ETaskType.TaskBeHitMontage)
					{
						AiStateMachineGroup owner = this.Node.Owner;
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
						defaultInterpolatedStringHandler.AppendLiteral("初始化条件[动画剩余时间]失败，node[");
						defaultInterpolatedStringHandler.AppendFormatted(this.Node.Name);
						defaultInterpolatedStringHandler.AppendLiteral("|");
						defaultInterpolatedStringHandler.AppendFormatted<int>(this.Node.Uuid);
						defaultInterpolatedStringHandler.AppendLiteral("], to:");
						defaultInterpolatedStringHandler.AppendFormatted<int>(this.Transition.To);
						owner.PushErrorMessage(defaultInterpolatedStringHandler.ToStringAndClear());
						return true;
					}
					this.TaskMontage = (this.Node.Task as AiStateMachineTaskBeHitMontage);
					this.InitMontageRemain();
				}
			}
			return true;
		}

		// Token: 0x0603EAB1 RID: 256689 RVA: 0x01242940 File Offset: 0x01240B40
		protected override void OnEnter()
		{
			IAiTaskMontage taskMontage = this.TaskMontage;
			if (taskMontage == null || !taskMontage.HasResource)
			{
				this.ResultSelf = false;
				return;
			}
			if (this.Node.TaskFinished)
			{
				this.ResultSelf = true;
				return;
			}
			IAiTaskMontage taskMontage2 = this.TaskMontage;
			if (taskMontage2 != null && taskMontage2.Playing)
			{
				this.ResultSelf = (this.TaskMontage.GetTimeRemaining() <= (double)this.Time);
			}
		}

		// Token: 0x0603EAB2 RID: 256690 RVA: 0x012429B4 File Offset: 0x01240BB4
		protected override void OnTick()
		{
			IAiTaskMontage taskMontage = this.TaskMontage;
			if (taskMontage == null || !taskMontage.HasResource)
			{
				this.ResultSelf = false;
				return;
			}
			if (this.Node.TaskFinished)
			{
				this.ResultSelf = true;
				return;
			}
			IAiTaskMontage taskMontage2 = this.TaskMontage;
			if (taskMontage2 != null && taskMontage2.Playing)
			{
				this.ResultSelf = (this.TaskMontage.GetTimeRemaining() <= (double)this.Time);
			}
		}

		// Token: 0x0603EAB3 RID: 256691 RVA: 0x01242A26 File Offset: 0x01240C26
		protected override void OnExit()
		{
			this.ResultSelf = false;
		}

		// Token: 0x0603EAB4 RID: 256692 RVA: 0x01242A2F File Offset: 0x01240C2F
		protected override void OnClear()
		{
			this.UnregisterEvents();
			this.TaskMontage = null;
		}

		// Token: 0x0603EAB5 RID: 256693 RVA: 0x01242A40 File Offset: 0x01240C40
		private void OnMontageRemain(float remainTime)
		{
			this.ResultSelf = true;
			AiStateMachineBase node = this.Node;
			if (node != null && node.Activated)
			{
				this.Node.Owner.TickStateMachine(base.Result, "AiStateMachineConditionMontageTimeRemaining", this.Node.Name);
			}
		}

		// Token: 0x0603EAB6 RID: 256694 RVA: 0x01242A90 File Offset: 0x01240C90
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, outBuilder);
			appendInterpolatedStringHandler.AppendLiteral("动画剩余时间小于 [");
			appendInterpolatedStringHandler.AppendFormatted<float>(this.Time, "F1");
			appendInterpolatedStringHandler.AppendLiteral("\n");
			outBuilder.Append(ref appendInterpolatedStringHandler);
		}

		// Token: 0x04021757 RID: 137047
		private float Time;

		// Token: 0x04021758 RID: 137048
		[Nullable(2)]
		private IAiTaskMontage TaskMontage;
	}
}
