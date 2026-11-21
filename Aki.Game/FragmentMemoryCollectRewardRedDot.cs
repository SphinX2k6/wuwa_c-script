using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002902 RID: 10498
public class FragmentMemoryCollectRewardRedDot : RedDotBase
{
	// Token: 0x0601A7D0 RID: 108496 RVA: 0x0082D35F File Offset: 0x0082B55F
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.FragmentRewardRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A7D1 RID: 108497 RVA: 0x0082D37D File Offset: 0x0082B57D
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.FragmentRewardRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A7D2 RID: 108498 RVA: 0x0082D39C File Offset: 0x0082B59C
	protected override bool OnCheck(int uId = 0)
	{
		FragmentMemoryCollectData collectDataById = FragmentMemoryModel.Instance.GetCollectDataById(uId);
		return collectDataById != null && collectDataById.GetIfCanGetReward();
	}
}
