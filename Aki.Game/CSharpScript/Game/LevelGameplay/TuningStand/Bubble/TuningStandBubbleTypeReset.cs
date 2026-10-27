using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Bubble
{
	// Token: 0x020069E4 RID: 27108
	public class TuningStandBubbleTypeReset : TuningStandBubbleTypeBase
	{
		// Token: 0x060436E5 RID: 276197 RVA: 0x0107A9D4 File Offset: 0x01078BD4
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

		// Token: 0x04023305 RID: 144133
		protected new ETuningStandBubbleTriggerType BubbleType = ETuningStandBubbleTriggerType.Reset;

		// Token: 0x04023306 RID: 144134
		protected bool HasPlayedOnce;
	}
}
