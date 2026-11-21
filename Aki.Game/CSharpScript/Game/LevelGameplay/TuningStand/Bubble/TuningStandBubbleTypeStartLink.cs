using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Bubble
{
	// Token: 0x02005B3B RID: 23355
	public class TuningStandBubbleTypeStartLink : TuningStandBubbleTypeBase
	{
		// Token: 0x06039717 RID: 235287 RVA: 0x0101ED4A File Offset: 0x0101CF4A
		public override bool TryStartBubble(bool canPlay)
		{
			if (!canPlay)
			{
				this.HasPlayedOnce = true;
				return false;
			}
			if (this.PlayFlow == null || this.HasPlayedOnce)
			{
				return false;
			}
			this.CurIndex = 0;
			base.UpdateBubble();
			this.HasPlayedOnce = true;
			return true;
		}

		// Token: 0x0401E4ED RID: 124141
		protected new ETuningStandBubbleTriggerType BubbleType = ETuningStandBubbleTriggerType.StartLink;

		// Token: 0x0401E4EE RID: 124142
		private bool HasPlayedOnce;
	}
}
