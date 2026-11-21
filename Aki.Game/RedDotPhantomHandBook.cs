using System;
using System.Collections.Generic;
using CSharpScript.Game.Common.Event;

// Token: 0x02001307 RID: 4871
public class RedDotPhantomHandBook : RedDotBase
{
	// Token: 0x0600BFCE RID: 49102 RVA: 0x0038AB99 File Offset: 0x00388D99
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnPhantomReadRedDotUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnHandBookRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0600BFCF RID: 49103 RVA: 0x0038ABD3 File Offset: 0x00388DD3
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnPhantomReadRedDotUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnHandBookRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0600BFD0 RID: 49104 RVA: 0x0038AC10 File Offset: 0x00388E10
	protected override bool OnCheck(int uId = 0)
	{
		List<HandBookEntry> handBookInfoList = HandBookModel.Instance.GetHandBookInfoList(EHandBookTabType.Phantom);
		if (handBookInfoList == null)
		{
			return false;
		}
		int count = handBookInfoList.Count;
		for (int i = 0; i < count; i++)
		{
			if (!handBookInfoList[i].IsRead)
			{
				return true;
			}
		}
		return false;
	}
}
