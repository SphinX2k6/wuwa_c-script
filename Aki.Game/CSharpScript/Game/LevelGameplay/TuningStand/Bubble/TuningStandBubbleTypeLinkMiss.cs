using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Bubble
{
	// Token: 0x02005B3E RID: 23358
	public class TuningStandBubbleTypeLinkMiss : TuningStandBubbleTypeBase
	{
		// Token: 0x0603971D RID: 235293 RVA: 0x0101EE36 File Offset: 0x0101D036
		public override bool TryStartBubble(bool canPlay)
		{
			if (this.PlayFlow == null)
			{
				return false;
			}
			this.CurIndex = 0;
			base.UpdateBubble();
			return true;
		}

		// Token: 0x0401E4F3 RID: 124147
		protected new ETuningStandBubbleTriggerType BubbleType = ETuningStandBubbleTriggerType.LinkMiss;
	}
}
