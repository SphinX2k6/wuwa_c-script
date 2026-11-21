using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Bubble
{
	// Token: 0x02005B40 RID: 23360
	public class TuningStandBubbleTypeReset : TuningStandBubbleTypeBase
	{
		// Token: 0x06039721 RID: 235297 RVA: 0x0101EE88 File Offset: 0x0101D088
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

		// Token: 0x0401E4F5 RID: 124149
		protected new ETuningStandBubbleTriggerType BubbleType = ETuningStandBubbleTriggerType.Reset;

		// Token: 0x0401E4F6 RID: 124150
		protected bool HasPlayedOnce;
	}
}
