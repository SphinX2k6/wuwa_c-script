using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.MailBind;

// Token: 0x02003398 RID: 13208
public class RedDotFunctionKuroStreet : RedDotBase
{
	// Token: 0x0601CAF7 RID: 117495 RVA: 0x008070F9 File Offset: 0x008052F9
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewMenu);
	}

	// Token: 0x0601CAF8 RID: 117496 RVA: 0x00807104 File Offset: 0x00805304
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnMailBindInfoNotify, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnMailBindInfoResponse, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnMailBindResponse, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnMailBindRewardResponse, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.RefreshMailBindRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CAF9 RID: 117497 RVA: 0x008071A0 File Offset: 0x008053A0
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnMailBindInfoNotify, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnMailBindInfoResponse, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnMailBindResponse, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnMailBindRewardResponse, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.RefreshMailBindRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CAFA RID: 117498 RVA: 0x0080723C File Offset: 0x0080543C
	protected override bool OnCheck(int uId = 0)
	{
		MailBindModel instance = MailBindModel.Instance;
		return ChannelController.Instance.CheckKuroStreetOpen() && instance.CheckMailBindRedDot();
	}
}
