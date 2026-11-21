using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020029A4 RID: 10660
public class RedDotSpring25Reward : RedDotBase
{
	// Token: 0x0601AAD6 RID: 109270 RVA: 0x00833918 File Offset: 0x00831B18
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.Spring25DrawRewardDone, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.Spring25SkinRewardDone, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.Spring25InviteDone, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.Spring25ActivityParseDone, new Action(base.EventCheck));
	}

	// Token: 0x0601AAD7 RID: 109271 RVA: 0x00833998 File Offset: 0x00831B98
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.Spring25DrawRewardDone, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.Spring25SkinRewardDone, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.Spring25InviteDone, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.Spring25ActivityParseDone, new Action(base.EventCheck));
	}

	// Token: 0x0601AAD8 RID: 109272 RVA: 0x00833A15 File Offset: 0x00831C15
	protected override bool OnCheck(int uId = 0)
	{
		return Spring25Model.Instance.HasAnyRewardExternal;
	}
}
