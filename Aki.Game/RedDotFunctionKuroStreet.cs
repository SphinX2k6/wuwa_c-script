using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.MailBind;

// Token: 0x0200290A RID: 10506
public class RedDotFunctionKuroStreet : RedDotBase
{
	// Token: 0x0601A7EF RID: 108527 RVA: 0x0082D6BD File Offset: 0x0082B8BD
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewMenu);
	}

	// Token: 0x0601A7F0 RID: 108528 RVA: 0x0082D6C8 File Offset: 0x0082B8C8
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnMailBindInfoNotify, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnMailBindInfoResponse, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnMailBindResponse, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnMailBindRewardResponse, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.RefreshMailBindRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A7F1 RID: 108529 RVA: 0x0082D764 File Offset: 0x0082B964
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnMailBindInfoNotify, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnMailBindInfoResponse, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnMailBindResponse, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnMailBindRewardResponse, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.RefreshMailBindRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A7F2 RID: 108530 RVA: 0x0082D800 File Offset: 0x0082BA00
	protected override bool OnCheck(int uId = 0)
	{
		MailBindModel instance = MailBindModel.Instance;
		return ChannelController.Instance.CheckKuroStreetOpen() && instance.CheckMailBindRedDot();
	}
}
