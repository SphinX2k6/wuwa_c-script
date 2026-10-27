using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.AI.StateMachine.Task;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x02007343 RID: 29507
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionMontageTimeRemaining : AiStateMachineCondition
	{
		// Token: 0x0604865F RID: 296543 RVA: 0x0129FC29 File Offset: 0x0129DE29
		public AiStateMachineConditionMontageTimeRemaining(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x06048660 RID: 296544 RVA: 0x0129FC34 File Offset: 0x0129DE34
		protected override bool RegisterEvents()
		{
			if (base.RegisterEvents() && this.TaskMontage != null && !EventSystem.Instance.HasWithTarget(this.TaskMontage, EEventName.OnMontageRemain, new Action<float>(this.OnMontageRemain)))
			{
				EventSystem.Instance.AddWithTarget(this.TaskMontage, EEventName.OnMontageRemain, new Action<float>(this.OnMontageRemain));
				return true;
			}
			return false;
		}

		// Token: 0x06048661 RID: 296545 RVA: 0x0129FC9C File Offset: 0x0129DE9C
		protected override bool UnregisterEvents()
		{
			if (base.UnregisterEvents() && this.TaskMontage != null && EventSystem.Instance.HasWithTarget(this.TaskMontage, EEventName.OnMontageRemain, new Action<float>(this.OnMontageRemain)))
			{
				EventSystem.Instance.RemoveWithTarget(this.TaskMontage, EEventName.OnMontageRemain, new Action<float>(this.OnMontageRemain));
				return true;
			}
			return false;
		}

		// Token: 0x06048662 RID: 296546 RVA: 0x0129FD04 File Offset: 0x0129DF04
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

		// Token: 0x06048663 RID: 296547 RVA: 0x0129FD58 File Offset: 0x0129DF58
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

		// Token: 0x06048664 RID: 296548 RVA: 0x0129FEB8 File Offset: 0x0129E0B8
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

		// Token: 0x06048665 RID: 296549 RVA: 0x0129FF2C File Offset: 0x0129E12C
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

		// Token: 0x06048666 RID: 296550 RVA: 0x0129FF9E File Offset: 0x0129E19E
		protected override void OnExit()
		{
			this.ResultSelf = false;
		}

		// Token: 0x06048667 RID: 296551 RVA: 0x0129FFA7 File Offset: 0x0129E1A7
		protected override void OnClear()
		{
			this.UnregisterEvents();
			this.TaskMontage = null;
		}

		// Token: 0x06048668 RID: 296552 RVA: 0x0129FFB8 File Offset: 0x0129E1B8
		private void OnMontageRemain(float remainTime)
		{
			this.ResultSelf = true;
			AiStateMachineBase node = this.Node;
			if (node != null && node.Activated)
			{
				this.Node.Owner.TickStateMachine(base.Result, "AiStateMachineConditionMontageTimeRemaining", this.Node.Name);
			}
		}

		// Token: 0x06048669 RID: 296553 RVA: 0x012A0008 File Offset: 0x0129E208
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, outBuilder);
			appendInterpolatedStringHandler.AppendLiteral("动画剩余时间小于 [");
			appendInterpolatedStringHandler.AppendFormatted<float>(this.Time, "F1");
			appendInterpolatedStringHandler.AppendLiteral("\n");
			outBuilder.Append(ref appendInterpolatedStringHandler);
		}

		// Token: 0x0402646A RID: 156778
		private float Time;

		// Token: 0x0402646B RID: 156779
		[Nullable(2)]
		private IAiTaskMontage TaskMontage;
	}
}
