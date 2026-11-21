using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena;

// Token: 0x0200295F RID: 10591
public class RedDotPhantomArenaCardReward : RedDotBase
{
	// Token: 0x0601A982 RID: 108930 RVA: 0x00830B0B File Offset: 0x0082ED0B
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotPhantomArenaCollect);
	}

	// Token: 0x0601A983 RID: 108931 RVA: 0x00830B17 File Offset: 0x0082ED17
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A984 RID: 108932 RVA: 0x00830B1A File Offset: 0x0082ED1A
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnPhantomArenaCardRewardUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A985 RID: 108933 RVA: 0x00830B38 File Offset: 0x0082ED38
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnPhantomArenaCardRewardUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A986 RID: 108934 RVA: 0x00830B56 File Offset: 0x0082ED56
	protected override bool OnCheck(int uId = 0)
	{
		return uId != 0 && PhantomArenaModel.Instance.GetCardRewardRedDot(uId);
	}
}
