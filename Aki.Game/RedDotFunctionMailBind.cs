using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.MailBind;

// Token: 0x0200339A RID: 13210
public class RedDotFunctionMailBind : RedDotBase
{
	// Token: 0x0601CB01 RID: 117505 RVA: 0x0080734D File Offset: 0x0080554D
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewMenu);
	}

	// Token: 0x0601CB02 RID: 117506 RVA: 0x00807358 File Offset: 0x00805558
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnMailBindInfoNotify, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnMailBindInfoResponse, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnMailBindResponse, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnMailBindRewardResponse, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.RefreshMailBindRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CB03 RID: 117507 RVA: 0x008073F4 File Offset: 0x008055F4
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnMailBindInfoNotify, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnMailBindInfoResponse, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnMailBindResponse, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnMailBindRewardResponse, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.RefreshMailBindRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CB04 RID: 117508 RVA: 0x00807490 File Offset: 0x00805690
	protected override bool OnCheck(int uId = 0)
	{
		MailBindModel instance = MailBindModel.Instance;
		return instance.CheckGlobalMailBindOpen() && instance.CheckMailBindRedDot();
	}
}
