using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033E2 RID: 13282
public class MowingTowerRewardRedDot : RedDotBase
{
	// Token: 0x0601CC57 RID: 117847 RVA: 0x00809D8B File Offset: 0x00807F8B
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshMowingTowerRewardRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CC58 RID: 117848 RVA: 0x00809DA9 File Offset: 0x00807FA9
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshMowingTowerRewardRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CC59 RID: 117849 RVA: 0x00809DC8 File Offset: 0x00807FC8
	protected override bool OnCheck(int uId = 0)
	{
		ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(uId);
		return activityById != null && (activityById as MowingTowerData).HaveRewardCanTake();
	}
}
