using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Bubble
{
	// Token: 0x020069E0 RID: 27104
	public class TuningStandBubbleTypeInValidLink : TuningStandBubbleTypeBase
	{
		// Token: 0x060436DD RID: 276189 RVA: 0x0107A8DC File Offset: 0x01078ADC
		public override bool TryStartBubble(bool canPlay)
		{
			if (this.PlayFlow == null)
			{
				return false;
			}
			if (Time.Instance.Now - 20.0 < this.PrevPlayTime)
			{
				return false;
			}
			this.PrevPlayTime = Time.Instance.Now;
			this.CurIndex = 0;
			base.UpdateBubble();
			return true;
		}

		// Token: 0x040232FF RID: 144127
		protected new ETuningStandBubbleTriggerType BubbleType = ETuningStandBubbleTriggerType.InvalidLink;

		// Token: 0x04023300 RID: 144128
		private double PrevPlayTime;
	}
}
