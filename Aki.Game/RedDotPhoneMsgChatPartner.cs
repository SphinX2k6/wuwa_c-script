using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033FC RID: 13308
public class RedDotPhoneMsgChatPartner : RedDotBase
{
	// Token: 0x0601CCD3 RID: 117971 RVA: 0x0080AA53 File Offset: 0x00808C53
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CCD4 RID: 117972 RVA: 0x0080AA56 File Offset: 0x00808C56
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601CCD5 RID: 117973 RVA: 0x0080AA5C File Offset: 0x00808C5C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnPhoneMsgSetAsRead, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.OnPhoneMsgSetReceived, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add(EEventName.OnPhoneMsgPanelOpen, new Action(base.EventCheck));
	}

	// Token: 0x0601CCD6 RID: 117974 RVA: 0x0080AAC0 File Offset: 0x00808CC0
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnPhoneMsgSetAsRead, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.OnPhoneMsgSetReceived, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove(EEventName.OnPhoneMsgPanelOpen, new Action(base.EventCheck));
	}

	// Token: 0x0601CCD7 RID: 117975 RVA: 0x0080AB24 File Offset: 0x00808D24
	protected override bool OnCheck(int uId = 0)
	{
		bool flag = PhoneMsgModel.Instance.IsSomeOneHasUnReadMsg(uId);
		bool flag2 = PhoneMsgModel.Instance.IsSomeOneHasUnReceivedMsg(uId);
		return flag && !flag2;
	}
}
