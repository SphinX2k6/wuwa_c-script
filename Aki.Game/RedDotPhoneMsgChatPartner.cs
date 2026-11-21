using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200296E RID: 10606
public class RedDotPhoneMsgChatPartner : RedDotBase
{
	// Token: 0x0601A9CB RID: 109003 RVA: 0x00831017 File Offset: 0x0082F217
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A9CC RID: 109004 RVA: 0x0083101A File Offset: 0x0082F21A
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601A9CD RID: 109005 RVA: 0x00831020 File Offset: 0x0082F220
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnPhoneMsgSetAsRead, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.OnPhoneMsgSetReceived, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add(EEventName.OnPhoneMsgPanelOpen, new Action(base.EventCheck));
	}

	// Token: 0x0601A9CE RID: 109006 RVA: 0x00831084 File Offset: 0x0082F284
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnPhoneMsgSetAsRead, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.OnPhoneMsgSetReceived, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove(EEventName.OnPhoneMsgPanelOpen, new Action(base.EventCheck));
	}

	// Token: 0x0601A9CF RID: 109007 RVA: 0x008310E8 File Offset: 0x0082F2E8
	protected override bool OnCheck(int uId = 0)
	{
		bool flag = PhoneMsgModel.Instance.IsSomeOneHasUnReadMsg(uId);
		bool flag2 = PhoneMsgModel.Instance.IsSomeOneHasUnReceivedMsg(uId);
		return flag && !flag2;
	}
}
