using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033FD RID: 13309
public class RedDotPhoneMsgChatPartnerGiftIcon : RedDotBase
{
	// Token: 0x0601CCD9 RID: 117977 RVA: 0x0080AB58 File Offset: 0x00808D58
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CCDA RID: 117978 RVA: 0x0080AB5B File Offset: 0x00808D5B
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601CCDB RID: 117979 RVA: 0x0080AB5E File Offset: 0x00808D5E
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnPhoneMsgSetReceived, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add(EEventName.OnPhoneMsgPanelOpen, new Action(base.EventCheck));
	}

	// Token: 0x0601CCDC RID: 117980 RVA: 0x0080AB98 File Offset: 0x00808D98
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnPhoneMsgSetReceived, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove(EEventName.OnPhoneMsgPanelOpen, new Action(base.EventCheck));
	}

	// Token: 0x0601CCDD RID: 117981 RVA: 0x0080ABD2 File Offset: 0x00808DD2
	protected override bool OnCheck(int uId = 0)
	{
		return PhoneMsgModel.Instance.IsSomeOneHasUnReceivedMsg(uId);
	}
}
