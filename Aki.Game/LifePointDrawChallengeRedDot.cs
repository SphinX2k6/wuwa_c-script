using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02000748 RID: 1864
public class LifePointDrawChallengeRedDot : RedDotBase
{
	// Token: 0x060055B5 RID: 21941 RVA: 0x001C24E7 File Offset: 0x001C06E7
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshLifePointDrawChallengeRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x060055B6 RID: 21942 RVA: 0x001C2505 File Offset: 0x001C0705
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshLifePointDrawChallengeRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x060055B7 RID: 21943 RVA: 0x001C2523 File Offset: 0x001C0723
	protected override bool OnCheck(int challengeId)
	{
		return LifePointDrawModel.Instance.GetChallengeRedDotState(challengeId);
	}
}
