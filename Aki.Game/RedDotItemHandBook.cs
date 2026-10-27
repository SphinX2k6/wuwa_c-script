using System;
using System.Collections.Generic;
using CSharpScript.Game.Common.Event;

// Token: 0x02001E44 RID: 7748
public class RedDotItemHandBook : RedDotBase
{
	// Token: 0x0600EBAA RID: 60330 RVA: 0x0037EE58 File Offset: 0x0037D058
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0600EBAB RID: 60331 RVA: 0x0037EE5B File Offset: 0x0037D05B
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnItemReadRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0600EBAC RID: 60332 RVA: 0x0037EE79 File Offset: 0x0037D079
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnItemReadRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0600EBAD RID: 60333 RVA: 0x0037EE98 File Offset: 0x0037D098
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
