using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.MailBind;

// Token: 0x0200290C RID: 10508
public class RedDotFunctionMailBind : RedDotBase
{
	// Token: 0x0601A7F9 RID: 108537 RVA: 0x0082D911 File Offset: 0x0082BB11
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewMenu);
	}

	// Token: 0x0601A7FA RID: 108538 RVA: 0x0082D91C File Offset: 0x0082BB1C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnMailBindInfoNotify, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnMailBindInfoResponse, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnMailBindResponse, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnMailBindRewardResponse, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.RefreshMailBindRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A7FB RID: 108539 RVA: 0x0082D9B8 File Offset: 0x0082BBB8
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnMailBindInfoNotify, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnMailBindInfoResponse, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnMailBindResponse, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnMailBindRewardResponse, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.RefreshMailBindRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A7FC RID: 108540 RVA: 0x0082DA54 File Offset: 0x0082BC54
	protected override bool OnCheck(int uId = 0)
	{
		MailBindModel instance = MailBindModel.Instance;
		return instance.CheckGlobalMailBindOpen() && instance.CheckMailBindRedDot();
	}
}
