using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003356 RID: 13142
public class RedDotAdventureDailyActivityTabWeekly : RedDotBase
{
	// Token: 0x0601C9D0 RID: 117200 RVA: 0x00804F66 File Offset: 0x00803166
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.AdventureDailyActivityTab);
	}

	// Token: 0x0601C9D1 RID: 117201 RVA: 0x00804F70 File Offset: 0x00803170
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.WeeklyChallengeRefresh, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.WeeklyChallengeRewardStateChanged, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.WeeklyChallengeScoreChanged, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.WeeklyChallengeRefreshRedDotChanged, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnServerStorageInfoInited, new Action(base.EventCheck));
	}

	// Token: 0x0601C9D2 RID: 117202 RVA: 0x0080500C File Offset: 0x0080320C
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.WeeklyChallengeRefresh, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.WeeklyChallengeRewardStateChanged, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.WeeklyChallengeScoreChanged, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.WeeklyChallengeRefreshRedDotChanged, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnServerStorageInfoInited, new Action(base.EventCheck));
	}

	// Token: 0x0601C9D3 RID: 117203 RVA: 0x008050A8 File Offset: 0x008032A8
	protected override bool OnCheck(int uId = 0)
	{
		if (!FunctionModel.Instance.IsOpen(EFunctionType.AdventureGuide) || !FunctionModel.Instance.IsOpen(EFunctionType.WeeklyChallenge) || WeeklyChallengeModel.Instance.WeeklyConfigId == 0)
		{
			return false;
		}
		long weeklyEndTime = WeeklyChallengeModel.Instance.WeeklyEndTime;
		return weeklyEndTime > 0L && ((long)DailyActivityModel.Instance.GetFirstOpenTabTime(DailyActivityDefine.EDailyActivityMainTab.Weekly).GetValueOrDefault() != weeklyEndTime || WeeklyChallengeModel.Instance.CheckIsRewardWaitTake());
	}
}
