using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020029A6 RID: 10662
public class RedDotSpring25Enter : RedDotBase
{
	// Token: 0x0601AADE RID: 109278 RVA: 0x00833AB4 File Offset: 0x00831CB4
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.Spring25DrawRewardDone, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.Spring25SkinRewardDone, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.Spring25InviteDone, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.Spring25ActivityParseDone, new Action(base.EventCheck));
	}

	// Token: 0x0601AADF RID: 109279 RVA: 0x00833B34 File Offset: 0x00831D34
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.Spring25DrawRewardDone, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.Spring25SkinRewardDone, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.Spring25InviteDone, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.Spring25ActivityParseDone, new Action(base.EventCheck));
	}

	// Token: 0x0601AAE0 RID: 109280 RVA: 0x00833BB1 File Offset: 0x00831DB1
	protected override bool OnCheck(int uId = 0)
	{
		return Spring25Model.Instance.HasRedDot;
	}
}
