using System;
using System.Collections.Generic;
using CSharpScript.Game.Common.Event;

// Token: 0x02001306 RID: 4870
public class RedDotItemHandBook : RedDotBase
{
	// Token: 0x0600BFC9 RID: 49097 RVA: 0x0038AAE8 File Offset: 0x00388CE8
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0600BFCA RID: 49098 RVA: 0x0038AAEB File Offset: 0x00388CEB
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnItemReadRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0600BFCB RID: 49099 RVA: 0x0038AB09 File Offset: 0x00388D09
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnItemReadRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0600BFCC RID: 49100 RVA: 0x0038AB28 File Offset: 0x00388D28
	protected override bool OnCheck(int uId = 0)
	{
		List<HandBookEntry> handBookInfoList = HandBookModel.Instance.GetHandBookInfoList(EHandBookTabType.Item);
		if (handBookInfoList == null)
		{
			return false;
		}
		int count = handBookInfoList.Count;
		for (int i = 0; i < count; i++)
		{
			HandBookEntry handBookEntry = handBookInfoList[i];
			if (HandBookConfig.Instance.GetItemHandBookConfigById(handBookEntry.Id).Value.Type == uId && !handBookEntry.IsRead)
			{
				return true;
			}
		}
		return false;
	}
}
