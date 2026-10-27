using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena;

// Token: 0x020033ED RID: 13293
public class RedDotPhantomArenaCardReward : RedDotBase
{
	// Token: 0x0601CC8A RID: 117898 RVA: 0x0080A547 File Offset: 0x00808747
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotPhantomArenaCollect);
	}

	// Token: 0x0601CC8B RID: 117899 RVA: 0x0080A553 File Offset: 0x00808753
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CC8C RID: 117900 RVA: 0x0080A556 File Offset: 0x00808756
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnPhantomArenaCardRewardUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CC8D RID: 117901 RVA: 0x0080A574 File Offset: 0x00808774
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnPhantomArenaCardRewardUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CC8E RID: 117902 RVA: 0x0080A592 File Offset: 0x00808792
	protected override bool OnCheck(int uId = 0)
	{
		return uId != 0 && PhantomArenaModel.Instance.GetCardRewardRedDot(uId);
	}
}
