using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Bubble
{
	// Token: 0x020069E1 RID: 27105
	public class TuningStandBubbleTypeLinkUp : TuningStandBubbleTypeBase
	{
		// Token: 0x060436DF RID: 276191 RVA: 0x0107A93E File Offset: 0x01078B3E
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
			this.HasPlayedOnce = true;
			this.CurIndex = 0;
			base.UpdateBubble();
			return true;
		}

		// Token: 0x04023301 RID: 144129
		protected new ETuningStandBubbleTriggerType BubbleType = ETuningStandBubbleTriggerType.LinkUp;

		// Token: 0x04023302 RID: 144130
		protected bool HasPlayedOnce;
	}
}
