using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200296F RID: 10607
public class RedDotPhoneMsgChatPartnerGiftIcon : RedDotBase
{
	// Token: 0x0601A9D1 RID: 109009 RVA: 0x0083111C File Offset: 0x0082F31C
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A9D2 RID: 109010 RVA: 0x0083111F File Offset: 0x0082F31F
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601A9D3 RID: 109011 RVA: 0x00831122 File Offset: 0x0082F322
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnPhoneMsgSetReceived, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add(EEventName.OnPhoneMsgPanelOpen, new Action(base.EventCheck));
	}

	// Token: 0x0601A9D4 RID: 109012 RVA: 0x0083115C File Offset: 0x0082F35C
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnPhoneMsgSetReceived, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove(EEventName.OnPhoneMsgPanelOpen, new Action(base.EventCheck));
	}

	// Token: 0x0601A9D5 RID: 109013 RVA: 0x00831196 File Offset: 0x0082F396
	protected override bool OnCheck(int uId = 0)
	{
		return PhoneMsgModel.Instance.IsSomeOneHasUnReceivedMsg(uId);
	}
}
