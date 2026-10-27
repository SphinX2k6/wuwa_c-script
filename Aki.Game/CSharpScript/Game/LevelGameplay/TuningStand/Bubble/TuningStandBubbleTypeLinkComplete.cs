using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Bubble
{
	// Token: 0x020069E3 RID: 27107
	public class TuningStandBubbleTypeLinkComplete : TuningStandBubbleTypeBase
	{
		// Token: 0x060436E3 RID: 276195 RVA: 0x0107A9AB File Offset: 0x01078BAB
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

		// Token: 0x04023304 RID: 144132
		protected new ETuningStandBubbleTriggerType BubbleType = ETuningStandBubbleTriggerType.LinkComplete;
	}
}
