using System;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LineCross
{
	// Token: 0x020054D9 RID: 21721
	public class LineCrossChallengeRedDot : RedDotBase
	{
		// Token: 0x06035D2D RID: 220461 RVA: 0x00F098BD File Offset: 0x00F07ABD
		protected override void AddCheckEvent()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshLineCrossChallengeRedDot, new Action<int>(base.EventCheckWithUid));
		}

		// Token: 0x06035D2E RID: 220462 RVA: 0x00F098DB File Offset: 0x00F07ADB
		protected override void RemoveCheckEvent()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshLineCrossChallengeRedDot, new Action<int>(base.EventCheckWithUid));
		}

		// Token: 0x06035D2F RID: 220463 RVA: 0x00F098F9 File Offset: 0x00F07AF9
		protected override bool OnCheck(int challengeId = 0)
		{
			return LineCrossModel.Instance.GetChallengeRedDotState(challengeId);
		}
	}
}
