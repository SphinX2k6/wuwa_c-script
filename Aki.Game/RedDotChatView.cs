using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003372 RID: 13170
public class RedDotChatView : RedDotBase
{
	// Token: 0x0601CA4F RID: 117327 RVA: 0x00805F0C File Offset: 0x0080410C
	protected override bool OnCheck(int uId = 0)
	{
		return ChatModel.Instance.HasRedDot();
	}

	// Token: 0x0601CA50 RID: 117328 RVA: 0x00805F18 File Offset: 0x00804118
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshChatRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.OnRemoveFriend, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CA51 RID: 117329 RVA: 0x00805F52 File Offset: 0x00804152
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshChatRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.OnRemoveFriend, new Action<int>(base.EventCheckWithUid));
	}
}
