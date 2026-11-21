using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002970 RID: 10608
public class RedDotPhoneMsgEntrance : RedDotBase
{
	// Token: 0x0601A9D7 RID: 109015 RVA: 0x008311AC File Offset: 0x0082F3AC
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnPhoneMsgSetAsRead, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.OnPhoneMsgSetReceived, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.OnPhoneMsgAdd, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add(EEventName.OnPhoneHaveMsgToRemove, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnPhoneMsgPanelOpen, new Action(base.EventCheck));
	}

	// Token: 0x0601A9D8 RID: 109016 RVA: 0x00831248 File Offset: 0x0082F448
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnPhoneMsgSetAsRead, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.OnPhoneMsgSetReceived, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.OnPhoneMsgAdd, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove(EEventName.OnPhoneHaveMsgToRemove, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnPhoneMsgPanelOpen, new Action(base.EventCheck));
	}

	// Token: 0x0601A9D9 RID: 109017 RVA: 0x008312E1 File Offset: 0x0082F4E1
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601A9DA RID: 109018 RVA: 0x008312E4 File Offset: 0x0082F4E4
	protected override bool OnCheck(int uId = 0)
	{
		bool flag = PhoneMsgModel.Instance.IsHasPhoneMsgUnReview();
		bool flag2 = PhoneMsgModel.Instance.IsHasUnReceivedMsg();
		return flag || flag2;
	}
}
