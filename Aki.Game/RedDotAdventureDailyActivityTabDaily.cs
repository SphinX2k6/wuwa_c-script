using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003355 RID: 13141
public class RedDotAdventureDailyActivityTabDaily : RedDotBase
{
	// Token: 0x0601C9CA RID: 117194 RVA: 0x00804DE7 File Offset: 0x00802FE7
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.AdventureDailyActivityTab);
	}

	// Token: 0x0601C9CB RID: 117195 RVA: 0x00804DF0 File Offset: 0x00802FF0
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.DailyActivityRefresh, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.DailyActivityStateNotify, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.DailyActivityMainTabOpened, new Action<int>(this.OnDailyActivityMainTabOpened));
		EventSystem.Instance.Add(EEventName.OnServerStorageInfoInited, new Action(base.EventCheck));
	}

	// Token: 0x0601C9CC RID: 117196 RVA: 0x00804E70 File Offset: 0x00803070
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.DailyActivityRefresh, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.DailyActivityStateNotify, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.DailyActivityMainTabOpened, new Action<int>(this.OnDailyActivityMainTabOpened));
		EventSystem.Instance.Remove(EEventName.OnServerStorageInfoInited, new Action(base.EventCheck));
	}

	// Token: 0x0601C9CD RID: 117197 RVA: 0x00804EED File Offset: 0x008030ED
	private void OnDailyActivityMainTabOpened(int tab)
	{
		base.EventCheck();
	}

	// Token: 0x0601C9CE RID: 117198 RVA: 0x00804EF8 File Offset: 0x008030F8
	protected override bool OnCheck(int uId = 0)
	{
		if (!FunctionModel.Instance.IsOpen(EFunctionType.AdventureGuide) || !FunctionModel.Instance.IsOpen(EFunctionType.DailyActivity))
		{
			return false;
		}
		long dayEndTime = DailyActivityModel.Instance.DayEndTime;
		return dayEndTime > 0L && ((long)DailyActivityModel.Instance.GetFirstOpenTabTime(DailyActivityDefine.EDailyActivityMainTab.Daily).GetValueOrDefault() != dayEndTime || DailyActivityModel.Instance.CheckIsRewardWaitTake());
	}
}
