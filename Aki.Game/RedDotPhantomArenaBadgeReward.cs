using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena;

// Token: 0x0200295E RID: 10590
public class RedDotPhantomArenaBadgeReward : RedDotBase
{
	// Token: 0x0601A97C RID: 108924 RVA: 0x00830AA6 File Offset: 0x0082ECA6
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotPhantomArenaCollect);
	}

	// Token: 0x0601A97D RID: 108925 RVA: 0x00830AB2 File Offset: 0x0082ECB2
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A97E RID: 108926 RVA: 0x00830AB5 File Offset: 0x0082ECB5
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnPhantomArenaBadgeRewardUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A97F RID: 108927 RVA: 0x00830AD3 File Offset: 0x0082ECD3
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnPhantomArenaBadgeRewardUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A980 RID: 108928 RVA: 0x00830AF1 File Offset: 0x0082ECF1
	protected override bool OnCheck(int uId = 0)
	{
		return uId != 0 && PhantomArenaModel.Instance.GetBadgeRewardRedDot(uId);
	}
}
