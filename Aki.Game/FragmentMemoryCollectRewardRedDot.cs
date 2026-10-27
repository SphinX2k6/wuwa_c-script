using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003390 RID: 13200
public class FragmentMemoryCollectRewardRedDot : RedDotBase
{
	// Token: 0x0601CAD8 RID: 117464 RVA: 0x00806D9B File Offset: 0x00804F9B
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.FragmentRewardRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CAD9 RID: 117465 RVA: 0x00806DB9 File Offset: 0x00804FB9
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.FragmentRewardRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CADA RID: 117466 RVA: 0x00806DD8 File Offset: 0x00804FD8
	protected override bool OnCheck(int uId = 0)
	{
		FragmentMemoryCollectData collectDataById = FragmentMemoryModel.Instance.GetCollectDataById(uId);
		return collectDataById != null && collectDataById.GetIfCanGetReward();
	}
}
