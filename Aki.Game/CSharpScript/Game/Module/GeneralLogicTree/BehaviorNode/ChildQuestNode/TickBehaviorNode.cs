using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020059E5 RID: 23013
	public class TickBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0603A527 RID: 238887 RVA: 0x00DDF43B File Offset: 0x00DDD63B
		public TickBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0603A528 RID: 238888 RVA: 0x00DDF44F File Offset: 0x00DDD64F
		protected override void OnStart(ENodeStatusUpdateReason reason)
		{
			base.OnStart(reason);
			this.TimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.Tick), (float)((int)this.IntervalTime), 1f, null, null, true);
		}

		// Token: 0x0603A529 RID: 238889 RVA: 0x00DDF484 File Offset: 0x00DDD684
		protected override void OnEnd(bool bFinished)
		{
			this.RemoveTimer();
			base.OnEnd(bFinished);
		}

		// Token: 0x0603A52A RID: 238890 RVA: 0x00DDF493 File Offset: 0x00DDD693
		protected void RemoveTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.TimerId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
			}
		}

		// Token: 0x0603A52B RID: 238891 RVA: 0x00DDF4B8 File Offset: 0x00DDD6B8
		private void Tick(float _)
		{
			this.OnTick(this.IntervalTime);
		}

		// Token: 0x0603A52C RID: 238892 RVA: 0x00DDF4C6 File Offset: 0x00DDD6C6
		protected virtual void OnTick(float delta)
		{
		}

		// Token: 0x0401E682 RID: 124546
		[Nullable(2)]
		private TimerHandle TimerId;

		// Token: 0x0401E683 RID: 124547
		protected float IntervalTime = 20f;
	}
}
