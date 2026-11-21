using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028F4 RID: 10484
public class RedDotDangoMonopolyTask : RedDotBase
{
	// Token: 0x0601A799 RID: 108441 RVA: 0x0082CE6B File Offset: 0x0082B06B
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.DangoMonopoly);
	}

	// Token: 0x0601A79A RID: 108442 RVA: 0x0082CE77 File Offset: 0x0082B077
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateDangoMonopolyTask, new Action(base.EventCheck));
	}

	// Token: 0x0601A79B RID: 108443 RVA: 0x0082CE95 File Offset: 0x0082B095
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateDangoMonopolyTask, new Action(base.EventCheck));
	}

	// Token: 0x0601A79C RID: 108444 RVA: 0x0082CEB3 File Offset: 0x0082B0B3
	protected override bool OnCheck(int uId = 0)
	{
		ActivityDangoMonopolyData data = ActivityDangoMonopolyController.Instance.GetData();
		return data != null && data.IsRedDotDiceTask();
	}
}
