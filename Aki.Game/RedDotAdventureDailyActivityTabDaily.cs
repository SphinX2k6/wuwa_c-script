using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028C7 RID: 10439
public class RedDotAdventureDailyActivityTabDaily : RedDotBase
{
	// Token: 0x0601A6C2 RID: 108226 RVA: 0x0082B3AB File Offset: 0x008295AB
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.AdventureDailyActivityTab);
	}

	// Token: 0x0601A6C3 RID: 108227 RVA: 0x0082B3B4 File Offset: 0x008295B4
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.DailyActivityRefresh, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.DailyActivityStateNotify, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.DailyActivityMainTabOpened, new Action<int>(this.OnDailyActivityMainTabOpened));
		EventSystem.Instance.Add(EEventName.OnServerStorageInfoInited, new Action(base.EventCheck));
	}

	// Token: 0x0601A6C4 RID: 108228 RVA: 0x0082B434 File Offset: 0x00829634
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.DailyActivityRefresh, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.DailyActivityStateNotify, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.DailyActivityMainTabOpened, new Action<int>(this.OnDailyActivityMainTabOpened));
		EventSystem.Instance.Remove(EEventName.OnServerStorageInfoInited, new Action(base.EventCheck));
	}

	// Token: 0x0601A6C5 RID: 108229 RVA: 0x0082B4B1 File Offset: 0x008296B1
	private void OnDailyActivityMainTabOpened(int tab)
	{
		base.EventCheck();
	}

	// Token: 0x0601A6C6 RID: 108230 RVA: 0x0082B4BC File Offset: 0x008296BC
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
