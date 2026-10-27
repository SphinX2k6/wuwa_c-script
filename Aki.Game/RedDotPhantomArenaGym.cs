using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena;

// Token: 0x020033F0 RID: 13296
public class RedDotPhantomArenaGym : RedDotBase
{
	// Token: 0x0601CC97 RID: 117911 RVA: 0x0080A614 File Offset: 0x00808814
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotPhantomArenaActivity);
	}

	// Token: 0x0601CC98 RID: 117912 RVA: 0x0080A620 File Offset: 0x00808820
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnPhantomArenaChallengeUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC99 RID: 117913 RVA: 0x0080A63E File Offset: 0x0080883E
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnPhantomArenaChallengeUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CC9A RID: 117914 RVA: 0x0080A65C File Offset: 0x0080885C
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CC9B RID: 117915 RVA: 0x0080A65F File Offset: 0x0080885F
	protected override bool OnCheck(int uId = 0)
	{
		return uId != 0 && PhantomArenaModel.Instance.GetGymRedDot(uId);
	}
}
