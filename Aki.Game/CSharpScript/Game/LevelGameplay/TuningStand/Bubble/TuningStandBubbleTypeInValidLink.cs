using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Bubble
{
	// Token: 0x02005B3C RID: 23356
	public class TuningStandBubbleTypeInValidLink : TuningStandBubbleTypeBase
	{
		// Token: 0x06039719 RID: 235289 RVA: 0x0101ED90 File Offset: 0x0101CF90
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

		// Token: 0x0401E4EF RID: 124143
		protected new ETuningStandBubbleTriggerType BubbleType = ETuningStandBubbleTriggerType.InvalidLink;

		// Token: 0x0401E4F0 RID: 124144
		private double PrevPlayTime;
	}
}
