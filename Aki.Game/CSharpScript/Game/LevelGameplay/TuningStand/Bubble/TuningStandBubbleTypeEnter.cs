using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Bubble
{
	// Token: 0x02005B3A RID: 23354
	public class TuningStandBubbleTypeEnter : TuningStandBubbleTypeBase
	{
		// Token: 0x06039715 RID: 235285 RVA: 0x0101ED20 File Offset: 0x0101CF20
		public override bool TryStartBubble(bool canPlay)
		{
			if (this.PlayFlow == null || this.HasPlayedOnce)
			{
				return false;
			}
			this.HasPlayedOnce = true;
			base.UpdateBubble();
			return true;
		}

		// Token: 0x0401E4EB RID: 124139
		protected new ETuningStandBubbleTriggerType BubbleType;

		// Token: 0x0401E4EC RID: 124140
		protected bool HasPlayedOnce;
	}
}
