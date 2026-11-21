using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002903 RID: 10499
public class FragmentMemoryEntranceRedDot : RedDotBase
{
	// Token: 0x0601A7D4 RID: 108500 RVA: 0x0082D3C8 File Offset: 0x0082B5C8
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.FragmentRewardEntranceRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A7D5 RID: 108501 RVA: 0x0082D3E6 File Offset: 0x0082B5E6
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.FragmentRewardEntranceRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A7D6 RID: 108502 RVA: 0x0082D404 File Offset: 0x0082B604
	protected override bool OnCheck(int uId = 0)
	{
		return FragmentMemoryModel.Instance.GetRedDotState();
	}
}
