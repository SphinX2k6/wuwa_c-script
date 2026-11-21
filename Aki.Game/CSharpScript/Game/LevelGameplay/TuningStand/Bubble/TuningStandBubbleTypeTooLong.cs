using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.TuningStand.Bubble
{
	// Token: 0x02005B41 RID: 23361
	public class TuningStandBubbleTypeTooLong : TuningStandBubbleTypeBase
	{
		// Token: 0x06039723 RID: 235299 RVA: 0x0101EECC File Offset: 0x0101D0CC
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

		// Token: 0x0401E4F7 RID: 124151
		protected new ETuningStandBubbleTriggerType BubbleType = ETuningStandBubbleTriggerType.TooLong;

		// Token: 0x0401E4F8 RID: 124152
		protected bool HasPlayedOnce;
	}
}
