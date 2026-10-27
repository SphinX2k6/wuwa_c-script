using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Bubble
{
	// Token: 0x020069E5 RID: 27109
	public class TuningStandBubbleTypeTooLong : TuningStandBubbleTypeBase
	{
		// Token: 0x060436E7 RID: 276199 RVA: 0x0107AA18 File Offset: 0x01078C18
		public override bool TryStartBubble(bool canPlay)
		{
			if (this.PlayFlow == null || this.HasPlayedOnce)
			{
				return false;
			}
			this.HasPlayedOnce = true;
			this.CurIndex = 0;
			ITuningStandBubbleData tuningStandBubbleData = this.TalkList[0];
			EventSystem.Instance.Emit<bool>(EEventName.TuningStandTooLongTime, tuningStandBubbleData.MainRoleTex != null);
			base.UpdateBubble();
			return true;
		}

		// Token: 0x04023307 RID: 144135
		protected new ETuningStandBubbleTriggerType BubbleType = ETuningStandBubbleTriggerType.TooLong;

		// Token: 0x04023308 RID: 144136
		protected bool HasPlayedOnce;
	}
}
