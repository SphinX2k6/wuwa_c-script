using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003381 RID: 13185
public class RedDotDangoMonopolyRound : RedDotBase
{
	// Token: 0x0601CA9C RID: 117404 RVA: 0x00806840 File Offset: 0x00804A40
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.DangoMonopoly);
	}

	// Token: 0x0601CA9D RID: 117405 RVA: 0x0080684C File Offset: 0x00804A4C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateDangoMonopolyRound, new Action(base.EventCheck));
	}

	// Token: 0x0601CA9E RID: 117406 RVA: 0x0080686A File Offset: 0x00804A6A
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateDangoMonopolyRound, new Action(base.EventCheck));
	}

	// Token: 0x0601CA9F RID: 117407 RVA: 0x00806888 File Offset: 0x00804A88
	protected override bool OnCheck(int uId = 0)
	{
		ActivityDangoMonopolyData data = ActivityDangoMonopolyController.Instance.GetData();
		return data != null && data.IsRoundReward();
	}
}
