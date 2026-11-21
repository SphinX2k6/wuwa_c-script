using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028E4 RID: 10468
public class RedDotChatView : RedDotBase
{
	// Token: 0x0601A747 RID: 108359 RVA: 0x0082C4D0 File Offset: 0x0082A6D0
	protected override bool OnCheck(int uId = 0)
	{
		return ChatModel.Instance.HasRedDot();
	}

	// Token: 0x0601A748 RID: 108360 RVA: 0x0082C4DC File Offset: 0x0082A6DC
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshChatRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.OnRemoveFriend, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A749 RID: 108361 RVA: 0x0082C516 File Offset: 0x0082A716
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshChatRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.OnRemoveFriend, new Action<int>(base.EventCheckWithUid));
	}
}
