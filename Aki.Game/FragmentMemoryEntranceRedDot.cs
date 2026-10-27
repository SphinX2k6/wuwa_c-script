using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003391 RID: 13201
public class FragmentMemoryEntranceRedDot : RedDotBase
{
	// Token: 0x0601CADC RID: 117468 RVA: 0x00806E04 File Offset: 0x00805004
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.FragmentRewardEntranceRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CADD RID: 117469 RVA: 0x00806E22 File Offset: 0x00805022
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.FragmentRewardEntranceRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CADE RID: 117470 RVA: 0x00806E40 File Offset: 0x00805040
	protected override bool OnCheck(int uId = 0)
	{
		return FragmentMemoryModel.Instance.GetRedDotState();
	}
}
