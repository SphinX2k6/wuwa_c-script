using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Bubble
{
	// Token: 0x02005B3F RID: 23359
	public class TuningStandBubbleTypeLinkComplete : TuningStandBubbleTypeBase
	{
		// Token: 0x0603971F RID: 235295 RVA: 0x0101EE5F File Offset: 0x0101D05F
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

		// Token: 0x0401E4F4 RID: 124148
		protected new ETuningStandBubbleTriggerType BubbleType = ETuningStandBubbleTriggerType.LinkComplete;
	}
}
