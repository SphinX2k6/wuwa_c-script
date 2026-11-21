using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Bubble
{
	// Token: 0x02005B3D RID: 23357
	public class TuningStandBubbleTypeLinkUp : TuningStandBubbleTypeBase
	{
		// Token: 0x0603971B RID: 235291 RVA: 0x0101EDF2 File Offset: 0x0101CFF2
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

		// Token: 0x0401E4F1 RID: 124145
		protected new ETuningStandBubbleTriggerType BubbleType = ETuningStandBubbleTriggerType.LinkUp;

		// Token: 0x0401E4F2 RID: 124146
		protected bool HasPlayedOnce;
	}
}
