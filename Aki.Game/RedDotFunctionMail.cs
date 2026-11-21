using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200290B RID: 10507
public class RedDotFunctionMail : RedDotBase
{
	// Token: 0x0601A7F4 RID: 108532 RVA: 0x0082D82F File Offset: 0x0082BA2F
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewResonanceButton);
	}

	// Token: 0x0601A7F5 RID: 108533 RVA: 0x0082D838 File Offset: 0x0082BA38
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.SwitchUnfinishedFlag, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.AddingNewMail, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnFunctionOpenUpdateNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601A7F6 RID: 108534 RVA: 0x0082D89C File Offset: 0x0082BA9C
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.SwitchUnfinishedFlag, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.AddingNewMail, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdateNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601A7F7 RID: 108535 RVA: 0x0082D8FD File Offset: 0x0082BAFD
	protected override bool OnCheck(int uId = 0)
	{
		return MailModel.Instance.GetRedDotCouldLightOn();
	}
}
