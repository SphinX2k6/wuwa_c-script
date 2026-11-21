using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena;

// Token: 0x02002962 RID: 10594
public class RedDotPhantomArenaGym : RedDotBase
{
	// Token: 0x0601A98F RID: 108943 RVA: 0x00830BD8 File Offset: 0x0082EDD8
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotPhantomArenaActivity);
	}

	// Token: 0x0601A990 RID: 108944 RVA: 0x00830BE4 File Offset: 0x0082EDE4
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnPhantomArenaChallengeUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A991 RID: 108945 RVA: 0x00830C02 File Offset: 0x0082EE02
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnPhantomArenaChallengeUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A992 RID: 108946 RVA: 0x00830C20 File Offset: 0x0082EE20
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A993 RID: 108947 RVA: 0x00830C23 File Offset: 0x0082EE23
	protected override bool OnCheck(int uId = 0)
	{
		return uId != 0 && PhantomArenaModel.Instance.GetGymRedDot(uId);
	}
}
