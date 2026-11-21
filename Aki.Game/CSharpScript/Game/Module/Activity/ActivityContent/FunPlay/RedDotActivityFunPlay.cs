using System;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FunPlay
{
	// Token: 0x020054F3 RID: 21747
	public class RedDotActivityFunPlay : RedDotBase
	{
		// Token: 0x06035E52 RID: 220754 RVA: 0x00F0E000 File Offset: 0x00F0C200
		protected override void AddCheckEvent()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshActivityFunPlayRedDot, new Action<int>(base.EventCheckWithUid));
		}

		// Token: 0x06035E53 RID: 220755 RVA: 0x00F0E01E File Offset: 0x00F0C21E
		protected override void RemoveCheckEvent()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshActivityFunPlayRedDot, new Action<int>(base.EventCheckWithUid));
		}

		// Token: 0x06035E54 RID: 220756 RVA: 0x00F0E03C File Offset: 0x00F0C23C
		protected override bool OnCheck(int challengeId)
		{
			ActivityFunPlayChallengeData challengeData = ActivityFunPlayModel.Instance.GetChallengeData(challengeId);
			return challengeData != null && challengeData.GetRedPoint();
		}
	}
}
