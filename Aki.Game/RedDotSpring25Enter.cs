using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003432 RID: 13362
public class RedDotSpring25Enter : RedDotBase
{
	// Token: 0x0601CDDE RID: 118238 RVA: 0x0080D3CC File Offset: 0x0080B5CC
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.Spring25DrawRewardDone, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.Spring25SkinRewardDone, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.Spring25InviteDone, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.Spring25ActivityParseDone, new Action(base.EventCheck));
	}

	// Token: 0x0601CDDF RID: 118239 RVA: 0x0080D44C File Offset: 0x0080B64C
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.Spring25DrawRewardDone, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.Spring25SkinRewardDone, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.Spring25InviteDone, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.Spring25ActivityParseDone, new Action(base.EventCheck));
	}

	// Token: 0x0601CDE0 RID: 118240 RVA: 0x0080D4C9 File Offset: 0x0080B6C9
	protected override bool OnCheck(int uId = 0)
	{
		return Spring25Model.Instance.HasRedDot;
	}
}
