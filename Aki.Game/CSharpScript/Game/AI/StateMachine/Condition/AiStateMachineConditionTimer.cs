using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x02007348 RID: 29512
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionTimer : AiStateMachineCondition
	{
		// Token: 0x06048685 RID: 296581 RVA: 0x012A05EF File Offset: 0x0129E7EF
		public AiStateMachineConditionTimer(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x06048686 RID: 296582 RVA: 0x012A05FA File Offset: 0x0129E7FA
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			this.MinTime = (double)condition.CondTimer.MinTime;
			this.MaxTime = (double)condition.CondTimer.MaxTime;
			return true;
		}

		// Token: 0x06048687 RID: 296583 RVA: 0x012A0624 File Offset: 0x0129E824
		protected override void OnEnter()
		{
			if (!this.CheckForClient)
			{
				return;
			}
			this.ResultSelf = false;
			this.ClearTimer();
			double randomRange = MathUtils.Instance.GetRandomRange(this.MinTime, this.MaxTime);
			this.TimerHandle = TimerSystem.Instance.Delay(new TTimerAction(this.OnTimerTimeout), (float)randomRange, null, null, true, 1f);
		}

		// Token: 0x06048688 RID: 296584 RVA: 0x012A0684 File Offset: 0x0129E884
		private void OnTimerTimeout(float delta)
		{
			this.ResultSelf = true;
			AiStateMachineBase node = this.Node;
			if (node != null && node.Activated)
			{
				this.Node.Owner.TickStateMachine(base.Result, "AiStateMachineConditionTimer", this.Node.Name);
			}
			this.TimerHandle = null;
		}

		// Token: 0x06048689 RID: 296585 RVA: 0x012A06D9 File Offset: 0x0129E8D9
		protected override void OnClear()
		{
			this.ClearTimer();
		}

		// Token: 0x0604868A RID: 296586 RVA: 0x012A06E1 File Offset: 0x0129E8E1
		private void ClearTimer()
		{
			if (this.TimerHandle != null)
			{
				if (this.TimerHandle.Valid())
				{
					this.TimerHandle.Remove();
				}
				this.TimerHandle = null;
			}
		}

		// Token: 0x0604868B RID: 296587 RVA: 0x012A070C File Offset: 0x0129E90C
		public override void ToString(StringBuilder outBuilder, int depth = 0)
		{
			base.ToString(outBuilder, depth);
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(10, 2, outBuilder);
			appendInterpolatedStringHandler.AppendLiteral("延迟 [时间:");
			appendInterpolatedStringHandler.AppendFormatted<double>(this.MinTime * TimeUtil.Instance.Millisecond, "F1");
			appendInterpolatedStringHandler.AppendLiteral("-");
			appendInterpolatedStringHandler.AppendFormatted<double>(this.MaxTime * TimeUtil.Instance.Millisecond, "F1");
			appendInterpolatedStringHandler.AppendLiteral("]\n");
			outBuilder.Append(ref appendInterpolatedStringHandler);
		}

		// Token: 0x04026470 RID: 156784
		private double MinTime;

		// Token: 0x04026471 RID: 156785
		private double MaxTime;

		// Token: 0x04026472 RID: 156786
		[Nullable(2)]
		private TimerHandle TimerHandle;
	}
}
