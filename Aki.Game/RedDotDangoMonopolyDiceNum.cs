using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003380 RID: 13184
public class RedDotDangoMonopolyDiceNum : RedDotBase
{
	// Token: 0x0601CA97 RID: 117399 RVA: 0x008067D9 File Offset: 0x008049D9
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.DangoMonopoly);
	}

	// Token: 0x0601CA98 RID: 117400 RVA: 0x008067E5 File Offset: 0x008049E5
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateDangoMonopolyNum, new Action(base.EventCheck));
	}

	// Token: 0x0601CA99 RID: 117401 RVA: 0x00806803 File Offset: 0x00804A03
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateDangoMonopolyNum, new Action(base.EventCheck));
	}

	// Token: 0x0601CA9A RID: 117402 RVA: 0x00806821 File Offset: 0x00804A21
	protected override bool OnCheck(int uId = 0)
	{
		ActivityDangoMonopolyData data = ActivityDangoMonopolyController.Instance.GetData();
		return data != null && data.IsCanUseDice();
	}
}
