using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.AI.StateMachine.Task;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x02007342 RID: 29506
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionMontageTimeElapsing : AiStateMachineCondition
	{
		// Token: 0x06048654 RID: 296532 RVA: 0x0129F7D6 File Offset: 0x0129D9D6
		public AiStateMachineConditionMontageTimeElapsing(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x06048655 RID: 296533 RVA: 0x0129F7E4 File Offset: 0x0129D9E4
		protected override bool RegisterEvents()
		{
			if (base.RegisterEvents() && this.TaskMontage != null && !EventSystem.Instance.HasWithTarget(this.TaskMontage, EEventName.OnMontageRemain, new Action<float>(this.OnMontageRemain)))
			{
				EventSystem.Instance.AddWithTarget(this.TaskMontage, EEventName.OnMontageRemain, new Action<float>(this.OnMontageRemain));
				return true;
			}
			return false;
		}

		// Token: 0x06048656 RID: 296534 RVA: 0x0129F84C File Offset: 0x0129DA4C
		protected override bool UnregisterEvents()
		{
			if (base.UnregisterEvents() && this.TaskMontage != null && EventSystem.Instance.HasWithTarget(this.TaskMontage, EEventName.OnMontageRemain, new Action<float>(this.OnMontageRemain)))
			{
				EventSystem.Instance.RemoveWithTarget(this.TaskMontage, EEventName.OnMontageRemain, new Action<float>(this.OnMontageRemain));
				return true;
			}
			return false;
		}

		// Token: 0x06048657 RID: 296535 RVA: 0x0129F8B4 File Offset: 0x0129DAB4
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

		// Token: 0x06048658 RID: 296536 RVA: 0x0129F924 File Offset: 0x0129DB24
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

		// Token: 0x06048659 RID: 296537 RVA: 0x0129FA84 File Offset: 0x0129DC84
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

		// Token: 0x0604865A RID: 296538 RVA: 0x0129FAF8 File Offset: 0x0129DCF8
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

		// Token: 0x0604865B RID: 296539 RVA: 0x0129FB6A File Offset: 0x0129DD6A
		protected override void OnExit()
		{
			this.ResultSelf = false;
		}

		// Token: 0x0604865C RID: 296540 RVA: 0x0129FB73 File Offset: 0x0129DD73
		protected override void OnClear()
		{
			this.UnregisterEvents();
			this.TaskMontage = null;
		}

		// Token: 0x0604865D RID: 296541 RVA: 0x0129FB84 File Offset: 0x0129DD84
		private void OnMontageRemain(float remainTime)
		{
			this.ResultSelf = true;
			AiStateMachineBase node = this.Node;
			if (node != null && node.Activated)
			{
				this.Node.Owner.TickStateMachine(base.Result, "AiStateMachineConditionMontageTimeElapsing", this.Node.Name);
			}
		}

		// Token: 0x0604865E RID: 296542 RVA: 0x0129FBD4 File Offset: 0x0129DDD4
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(11, 1, outBuilder);
			appendInterpolatedStringHandler.AppendLiteral("动画播放时间大于 [");
			appendInterpolatedStringHandler.AppendFormatted<float>(this.Time, "F1");
			appendInterpolatedStringHandler.AppendLiteral("\n");
			outBuilder.Append(ref appendInterpolatedStringHandler);
		}

		// Token: 0x04026468 RID: 156776
		private float Time;

		// Token: 0x04026469 RID: 156777
		[Nullable(2)]
		private IAiTaskMontage TaskMontage;
	}
}
