using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200296D RID: 10605
public class RedDotPhoneMsgChatItem : RedDotBase
{
	// Token: 0x0601A9C6 RID: 108998 RVA: 0x00830F88 File Offset: 0x0082F188
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A9C7 RID: 108999 RVA: 0x00830F8B File Offset: 0x0082F18B
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnPhoneMsgSetAsRead, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add(EEventName.OnPhoneMsgPanelOpen, new Action(base.EventCheck));
	}

	// Token: 0x0601A9C8 RID: 109000 RVA: 0x00830FC5 File Offset: 0x0082F1C5
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnPhoneMsgSetAsRead, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove(EEventName.OnPhoneMsgPanelOpen, new Action(base.EventCheck));
	}

	// Token: 0x0601A9C9 RID: 109001 RVA: 0x00830FFF File Offset: 0x0082F1FF
	protected override bool OnCheck(int uId = 0)
	{
		return !PhoneMsgModel.Instance.IsShortMsgRead(uId);
	}
}
