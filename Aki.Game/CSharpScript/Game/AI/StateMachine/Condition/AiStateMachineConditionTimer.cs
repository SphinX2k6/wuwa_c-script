using System;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Utils.CombatStateMachine;

namespace CSharpScript.Game.AI.StateMachine.Condition
{
	// Token: 0x020064CB RID: 25803
	[NullableContext(1)]
	[Nullable(0)]
	public class AiStateMachineConditionTimer : AiStateMachineCondition
	{
		// Token: 0x0603EAD2 RID: 256722 RVA: 0x01243077 File Offset: 0x01241277
		public AiStateMachineConditionTimer(AiStateMachineTransition transition, CombatStateMachineDefine.Fsm.Condition condition, int index) : base(transition, condition, index)
		{
		}

		// Token: 0x0603EAD3 RID: 256723 RVA: 0x01243082 File Offset: 0x01241282
		protected override bool OnInit(CombatStateMachineDefine.Fsm.Condition condition)
		{
			this.MinTime = (double)condition.CondTimer.MinTime;
			this.MaxTime = (double)condition.CondTimer.MaxTime;
			return true;
		}

		// Token: 0x0603EAD4 RID: 256724 RVA: 0x012430AC File Offset: 0x012412AC
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

		// Token: 0x0603EAD5 RID: 256725 RVA: 0x0124310C File Offset: 0x0124130C
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

		// Token: 0x0603EAD6 RID: 256726 RVA: 0x01243161 File Offset: 0x01241361
		protected override void OnClear()
		{
			this.ClearTimer();
		}

		// Token: 0x0603EAD7 RID: 256727 RVA: 0x01243169 File Offset: 0x01241369
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

		// Token: 0x0603EAD8 RID: 256728 RVA: 0x01243194 File Offset: 0x01241394
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

		// Token: 0x0402175D RID: 137053
		private double MinTime;

		// Token: 0x0402175E RID: 137054
		private double MaxTime;

		// Token: 0x0402175F RID: 137055
		[Nullable(2)]
		private TimerHandle TimerHandle;
	}
}
