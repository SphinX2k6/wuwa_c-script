using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028F3 RID: 10483
public class RedDotDangoMonopolyRound : RedDotBase
{
	// Token: 0x0601A794 RID: 108436 RVA: 0x0082CE04 File Offset: 0x0082B004
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.DangoMonopoly);
	}

	// Token: 0x0601A795 RID: 108437 RVA: 0x0082CE10 File Offset: 0x0082B010
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateDangoMonopolyRound, new Action(base.EventCheck));
	}

	// Token: 0x0601A796 RID: 108438 RVA: 0x0082CE2E File Offset: 0x0082B02E
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateDangoMonopolyRound, new Action(base.EventCheck));
	}

	// Token: 0x0601A797 RID: 108439 RVA: 0x0082CE4C File Offset: 0x0082B04C
	protected override bool OnCheck(int uId = 0)
	{
		ActivityDangoMonopolyData data = ActivityDangoMonopolyController.Instance.GetData();
		return data != null && data.IsRoundReward();
	}
}
