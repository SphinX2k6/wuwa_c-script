using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Bubble
{
	// Token: 0x020069DE RID: 27102
	public class TuningStandBubbleTypeEnter : TuningStandBubbleTypeBase
	{
		// Token: 0x060436D9 RID: 276185 RVA: 0x0107A86C File Offset: 0x01078A6C
		public override bool TryStartBubble(bool canPlay)
		{
			if (this.PlayFlow == null || this.HasPlayedOnce)
			{
				return false;
			}
			this.HasPlayedOnce = true;
			base.UpdateBubble();
			return true;
		}

		// Token: 0x040232FB RID: 144123
		protected new ETuningStandBubbleTriggerType BubbleType;

		// Token: 0x040232FC RID: 144124
		protected bool HasPlayedOnce;
	}
}
