using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002906 RID: 10502
public class RedDotFriendNewApplication : RedDotBase
{
	// Token: 0x0601A7E0 RID: 108512 RVA: 0x0082D4E8 File Offset: 0x0082B6E8
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FunctionFriend);
	}

	// Token: 0x0601A7E1 RID: 108513 RVA: 0x0082D4F1 File Offset: 0x0082B6F1
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RefreshFriendApplicationRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.UpdateFriendViewShow, new Action(base.EventCheck));
	}

	// Token: 0x0601A7E2 RID: 108514 RVA: 0x0082D52B File Offset: 0x0082B72B
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RefreshFriendApplicationRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.UpdateFriendViewShow, new Action(base.EventCheck));
	}

	// Token: 0x0601A7E3 RID: 108515 RVA: 0x0082D565 File Offset: 0x0082B765
	protected override bool OnCheck(int uId = 0)
	{
		return FriendModel.Instance.HasNewFriendApplication();
	}
}
