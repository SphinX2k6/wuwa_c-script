using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003394 RID: 13204
public class RedDotFriendNewApplication : RedDotBase
{
	// Token: 0x0601CAE8 RID: 117480 RVA: 0x00806F24 File Offset: 0x00805124
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FunctionFriend);
	}

	// Token: 0x0601CAE9 RID: 117481 RVA: 0x00806F2D File Offset: 0x0080512D
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RefreshFriendApplicationRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.UpdateFriendViewShow, new Action(base.EventCheck));
	}

	// Token: 0x0601CAEA RID: 117482 RVA: 0x00806F67 File Offset: 0x00805167
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RefreshFriendApplicationRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.UpdateFriendViewShow, new Action(base.EventCheck));
	}

	// Token: 0x0601CAEB RID: 117483 RVA: 0x00806FA1 File Offset: 0x008051A1
	protected override bool OnCheck(int uId = 0)
	{
		return FriendModel.Instance.HasNewFriendApplication();
	}
}
