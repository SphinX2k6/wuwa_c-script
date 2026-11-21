using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode
{
	// Token: 0x020049BE RID: 18878
	public class TickBehaviorNode : ChildQuestNodeBase
	{
		// Token: 0x0602F44E RID: 193614 RVA: 0x00D2ECA7 File Offset: 0x00D2CEA7
		public TickBehaviorNode(int nodeId) : base(nodeId)
		{
		}

		// Token: 0x0602F44F RID: 193615 RVA: 0x00D2ECBB File Offset: 0x00D2CEBB
		protected override void OnStart(ENodeStatusUpdateReason reason)
		{
			base.OnStart(reason);
			this.TimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.Tick), (float)((int)this.IntervalTime), 1f, null, null, true);
		}

		// Token: 0x0602F450 RID: 193616 RVA: 0x00D2ECF0 File Offset: 0x00D2CEF0
		protected override void OnEnd(bool bFinished)
		{
			this.RemoveTimer();
			base.OnEnd(bFinished);
		}

		// Token: 0x0602F451 RID: 193617 RVA: 0x00D2ECFF File Offset: 0x00D2CEFF
		protected void RemoveTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.TimerId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
			}
		}

		// Token: 0x0602F452 RID: 193618 RVA: 0x00D2ED24 File Offset: 0x00D2CF24
		private void Tick(float _)
		{
			this.OnTick(this.IntervalTime);
		}

		// Token: 0x0602F453 RID: 193619 RVA: 0x00D2ED32 File Offset: 0x00D2CF32
		protected virtual void OnTick(float delta)
		{
		}

		// Token: 0x04019121 RID: 102689
		[Nullable(2)]
		private TimerHandle TimerId;

		// Token: 0x04019122 RID: 102690
		protected float IntervalTime = 20f;
	}
}
