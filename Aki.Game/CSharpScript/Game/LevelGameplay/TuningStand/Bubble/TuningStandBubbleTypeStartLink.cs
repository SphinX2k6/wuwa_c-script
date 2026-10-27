using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Bubble
{
	// Token: 0x020069DF RID: 27103
	public class TuningStandBubbleTypeStartLink : TuningStandBubbleTypeBase
	{
		// Token: 0x060436DB RID: 276187 RVA: 0x0107A896 File Offset: 0x01078A96
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

		// Token: 0x040232FD RID: 144125
		protected new ETuningStandBubbleTriggerType BubbleType = ETuningStandBubbleTriggerType.StartLink;

		// Token: 0x040232FE RID: 144126
		private bool HasPlayedOnce;
	}
}
