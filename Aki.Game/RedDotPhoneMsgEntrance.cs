using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033FE RID: 13310
public class RedDotPhoneMsgEntrance : RedDotBase
{
	// Token: 0x0601CCDF RID: 117983 RVA: 0x0080ABE8 File Offset: 0x00808DE8
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnPhoneMsgSetAsRead, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.OnPhoneMsgSetReceived, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.OnPhoneMsgAdd, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add(EEventName.OnPhoneHaveMsgToRemove, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnPhoneMsgPanelOpen, new Action(base.EventCheck));
	}

	// Token: 0x0601CCE0 RID: 117984 RVA: 0x0080AC84 File Offset: 0x00808E84
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnPhoneMsgSetAsRead, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.OnPhoneMsgSetReceived, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.OnPhoneMsgAdd, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove(EEventName.OnPhoneHaveMsgToRemove, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnPhoneMsgPanelOpen, new Action(base.EventCheck));
	}

	// Token: 0x0601CCE1 RID: 117985 RVA: 0x0080AD1D File Offset: 0x00808F1D
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601CCE2 RID: 117986 RVA: 0x0080AD20 File Offset: 0x00808F20
	protected override bool OnCheck(int uId = 0)
	{
		bool flag = PhoneMsgModel.Instance.IsHasPhoneMsgUnReview();
		bool flag2 = PhoneMsgModel.Instance.IsHasUnReceivedMsg();
		return flag || flag2;
	}
}
