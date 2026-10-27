using System;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FunPlay
{
	// Token: 0x02006575 RID: 25973
	public class RedDotActivityFunPlay : RedDotBase
	{
		// Token: 0x0604118D RID: 266637 RVA: 0x00FC701C File Offset: 0x00FC521C
		protected override void AddCheckEvent()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshActivityFunPlayRedDot, new Action<int>(base.EventCheckWithUid));
		}

		// Token: 0x0604118E RID: 266638 RVA: 0x00FC703A File Offset: 0x00FC523A
		protected override void RemoveCheckEvent()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshActivityFunPlayRedDot, new Action<int>(base.EventCheckWithUid));
		}

		// Token: 0x0604118F RID: 266639 RVA: 0x00FC7058 File Offset: 0x00FC5258
		protected override bool OnCheck(int challengeId)
		{
			ActivityFunPlayChallengeData challengeData = ActivityFunPlayModel.Instance.GetChallengeData(challengeId);
			return challengeData != null && challengeData.GetRedPoint();
		}
	}
}
