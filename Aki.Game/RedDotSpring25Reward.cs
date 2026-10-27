using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003430 RID: 13360
public class RedDotSpring25Reward : RedDotBase
{
	// Token: 0x0601CDD6 RID: 118230 RVA: 0x0080D230 File Offset: 0x0080B430
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.Spring25DrawRewardDone, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.Spring25SkinRewardDone, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.Spring25InviteDone, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.Spring25ActivityParseDone, new Action(base.EventCheck));
	}

	// Token: 0x0601CDD7 RID: 118231 RVA: 0x0080D2B0 File Offset: 0x0080B4B0
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.Spring25DrawRewardDone, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.Spring25SkinRewardDone, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.Spring25InviteDone, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.Spring25ActivityParseDone, new Action(base.EventCheck));
	}

	// Token: 0x0601CDD8 RID: 118232 RVA: 0x0080D32D File Offset: 0x0080B52D
	protected override bool OnCheck(int uId = 0)
	{
		return Spring25Model.Instance.HasAnyRewardExternal;
	}
}
