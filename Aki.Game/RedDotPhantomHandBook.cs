using System;
using System.Collections.Generic;
using CSharpScript.Game.Common.Event;

// Token: 0x02001E45 RID: 7749
public class RedDotPhantomHandBook : RedDotBase
{
	// Token: 0x0600EBAF RID: 60335 RVA: 0x0037EF09 File Offset: 0x0037D109
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnPhantomReadRedDotUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnHandBookRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0600EBB0 RID: 60336 RVA: 0x0037EF43 File Offset: 0x0037D143
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnPhantomReadRedDotUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnHandBookRedDotUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0600EBB1 RID: 60337 RVA: 0x0037EF80 File Offset: 0x0037D180
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
