using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033FB RID: 13307
public class RedDotPhoneMsgChatItem : RedDotBase
{
	// Token: 0x0601CCCE RID: 117966 RVA: 0x0080A9C4 File Offset: 0x00808BC4
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CCCF RID: 117967 RVA: 0x0080A9C7 File Offset: 0x00808BC7
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnPhoneMsgSetAsRead, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add(EEventName.OnPhoneMsgPanelOpen, new Action(base.EventCheck));
	}

	// Token: 0x0601CCD0 RID: 117968 RVA: 0x0080AA01 File Offset: 0x00808C01
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnPhoneMsgSetAsRead, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove(EEventName.OnPhoneMsgPanelOpen, new Action(base.EventCheck));
	}

	// Token: 0x0601CCD1 RID: 117969 RVA: 0x0080AA3B File Offset: 0x00808C3B
	protected override bool OnCheck(int uId = 0)
	{
		return !PhoneMsgModel.Instance.IsShortMsgRead(uId);
	}
}
