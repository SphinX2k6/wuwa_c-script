using System;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LineCross
{
	// Token: 0x0200655B RID: 25947
	public class LineCrossChallengeRedDot : RedDotBase
	{
		// Token: 0x06041068 RID: 266344 RVA: 0x00FC28D5 File Offset: 0x00FC0AD5
		protected override void AddCheckEvent()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshLineCrossChallengeRedDot, new Action<int>(base.EventCheckWithUid));
		}

		// Token: 0x06041069 RID: 266345 RVA: 0x00FC28F3 File Offset: 0x00FC0AF3
		protected override void RemoveCheckEvent()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshLineCrossChallengeRedDot, new Action<int>(base.EventCheckWithUid));
		}

		// Token: 0x0604106A RID: 266346 RVA: 0x00FC2911 File Offset: 0x00FC0B11
		protected override bool OnCheck(int challengeId = 0)
		{
			return LineCrossModel.Instance.GetChallengeRedDotState(challengeId);
		}
	}
}
