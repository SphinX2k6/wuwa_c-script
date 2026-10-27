using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02001294 RID: 4756
public class LifePointDrawChallengeRedDot : RedDotBase
{
	// Token: 0x0600821E RID: 33310 RVA: 0x001B9817 File Offset: 0x001B7A17
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshLifePointDrawChallengeRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0600821F RID: 33311 RVA: 0x001B9835 File Offset: 0x001B7A35
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshLifePointDrawChallengeRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x06008220 RID: 33312 RVA: 0x001B9853 File Offset: 0x001B7A53
	protected override bool OnCheck(int challengeId)
	{
		return LifePointDrawModel.Instance.GetChallengeRedDotState(challengeId);
	}
}
