using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028C8 RID: 10440
public class RedDotAdventureDailyActivityTabWeekly : RedDotBase
{
	// Token: 0x0601A6C8 RID: 108232 RVA: 0x0082B52A File Offset: 0x0082972A
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.AdventureDailyActivityTab);
	}

	// Token: 0x0601A6C9 RID: 108233 RVA: 0x0082B534 File Offset: 0x00829734
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.WeeklyChallengeRefresh, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.WeeklyChallengeRewardStateChanged, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.WeeklyChallengeScoreChanged, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.WeeklyChallengeRefreshRedDotChanged, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnServerStorageInfoInited, new Action(base.EventCheck));
	}

	// Token: 0x0601A6CA RID: 108234 RVA: 0x0082B5D0 File Offset: 0x008297D0
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.WeeklyChallengeRefresh, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.WeeklyChallengeRewardStateChanged, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.WeeklyChallengeScoreChanged, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.WeeklyChallengeRefreshRedDotChanged, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnServerStorageInfoInited, new Action(base.EventCheck));
	}

	// Token: 0x0601A6CB RID: 108235 RVA: 0x0082B66C File Offset: 0x0082986C
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
