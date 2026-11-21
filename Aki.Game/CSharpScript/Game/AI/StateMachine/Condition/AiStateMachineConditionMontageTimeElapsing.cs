using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.AI.StateMachine.Task;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x020064C5 RID: 25797
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionMontageTimeElapsing : AiStateMachineCondition
	{
		// Token: 0x0603EAA1 RID: 256673 RVA: 0x0124225E File Offset: 0x0124045E
		public AiStateMachineConditionMontageTimeElapsing(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0603EAA2 RID: 256674 RVA: 0x0124226C File Offset: 0x0124046C
		protected override bool RegisterEvents()
		{
			if (base.RegisterEvents() && this.TaskMontage != null && !EventSystem.Instance.HasWithTarget(this.TaskMontage, EEventName.OnMontageRemain, new Action<float>(this.OnMontageRemain)))
			{
				EventSystem.Instance.AddWithTarget(this.TaskMontage, EEventName.OnMontageRemain, new Action<float>(this.OnMontageRemain));
				return true;
			}
			return false;
		}

		// Token: 0x0603EAA3 RID: 256675 RVA: 0x012422D4 File Offset: 0x012404D4
		protected override bool UnregisterEvents()
		{
			if (base.UnregisterEvents() && this.TaskMontage != null && EventSystem.Instance.HasWithTarget(this.TaskMontage, EEventName.OnMontageRemain, new Action<float>(this.OnMontageRemain)))
			{
				EventSystem.Instance.RemoveWithTarget(this.TaskMontage, EEventName.OnMontageRemain, new Action<float>(this.OnMontageRemain));
				return true;
			}
			return false;
		}

		// Token: 0x0603EAA4 RID: 256676 RVA: 0x0124233C File Offset: 0x0124053C
		private void InitMontageRemain()
		{
			if (this.TaskMontage != null)
			{
				double timeLength = this.TaskMontage.GetTimeLength();
				double num = (timeLength > 0.0 && timeLength >= this.TaskMontage.GetTimeElapsing()) ? (timeLength - this.TaskMontage.GetTimeElapsing()) : -1.0;
				this.TaskMontage.RemainedTrigger = (float)num;
				this.RegisterEvents();
			}
		}

		// Token: 0x0603EAA5 RID: 256677 RVA: 0x012423AC File Offset: 0x012405AC
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			this.HasTaskFinishCondition = true;
			this.Time = condition.CondMontageTimeElapsing.Time * 0.001f;
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
						defaultInterpolatedStringHandler.AppendLiteral("初始化条件[动画播放时间]失败，node[");
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

		// Token: 0x0603EAA6 RID: 256678 RVA: 0x0124250C File Offset: 0x0124070C
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
				this.ResultSelf = (this.TaskMontage.GetTimeElapsing() >= (double)this.Time);
			}
		}

		// Token: 0x0603EAA7 RID: 256679 RVA: 0x01242580 File Offset: 0x01240780
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
				this.ResultSelf = (this.TaskMontage.GetTimeElapsing() >= (double)this.Time);
			}
		}

		// Token: 0x0603EAA8 RID: 256680 RVA: 0x012425F2 File Offset: 0x012407F2
		protected override void OnExit()
		{
			this.ResultSelf = false;
		}

		// Token: 0x0603EAA9 RID: 256681 RVA: 0x012425FB File Offset: 0x012407FB
		protected override void OnClear()
		{
			this.UnregisterEvents();
			this.TaskMontage = null;
		}

		// Token: 0x0603EAAA RID: 256682 RVA: 0x0124260C File Offset: 0x0124080C
		private void OnMontageRemain(float remainTime)
		{
			this.ResultSelf = true;
			AiStateMachineBase node = this.Node;
			if (node != null && node.Activated)
			{
				this.Node.Owner.TickStateMachine(base.Result, "AiStateMachineConditionMontageTimeElapsing", this.Node.Name);
			}
		}

		// Token: 0x0603EAAB RID: 256683 RVA: 0x0124265C File Offset: 0x0124085C
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, outBuilder);
			appendInterpolatedStringHandler.AppendLiteral("动画播放时间大于 [");
			appendInterpolatedStringHandler.AppendFormatted<float>(this.Time, "F1");
			appendInterpolatedStringHandler.AppendLiteral("\n");
			outBuilder.Append(ref appendInterpolatedStringHandler);
		}

		// Token: 0x04021755 RID: 137045
		private float Time;

		// Token: 0x04021756 RID: 137046
		[Nullable(2)]
		private IAiTaskMontage TaskMontage;
	}
}
