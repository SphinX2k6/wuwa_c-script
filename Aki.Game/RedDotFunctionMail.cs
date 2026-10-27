using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003399 RID: 13209
public class RedDotFunctionMail : RedDotBase
{
	// Token: 0x0601CAFC RID: 117500 RVA: 0x0080726B File Offset: 0x0080546B
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewResonanceButton);
	}

	// Token: 0x0601CAFD RID: 117501 RVA: 0x00807274 File Offset: 0x00805474
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.SwitchUnfinishedFlag, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.AddingNewMail, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnFunctionOpenUpdateNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601CAFE RID: 117502 RVA: 0x008072D8 File Offset: 0x008054D8
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.SwitchUnfinishedFlag, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.AddingNewMail, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdateNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601CAFF RID: 117503 RVA: 0x00807339 File Offset: 0x00805539
	protected override bool OnCheck(int uId = 0)
	{
		return MailModel.Instance.GetRedDotCouldLightOn();
	}
}
