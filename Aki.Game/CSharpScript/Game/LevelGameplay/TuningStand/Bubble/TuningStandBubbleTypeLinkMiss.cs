using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Bubble
{
	// Token: 0x020069E2 RID: 27106
	public class TuningStandBubbleTypeLinkMiss : TuningStandBubbleTypeBase
	{
		// Token: 0x060436E1 RID: 276193 RVA: 0x0107A982 File Offset: 0x01078B82
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

		// Token: 0x04023303 RID: 144131
		protected new ETuningStandBubbleTriggerType BubbleType = ETuningStandBubbleTriggerType.LinkMiss;
	}
}
