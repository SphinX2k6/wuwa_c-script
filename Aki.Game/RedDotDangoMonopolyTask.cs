using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003382 RID: 13186
public class RedDotDangoMonopolyTask : RedDotBase
{
	// Token: 0x0601CAA1 RID: 117409 RVA: 0x008068A7 File Offset: 0x00804AA7
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.DangoMonopoly);
	}

	// Token: 0x0601CAA2 RID: 117410 RVA: 0x008068B3 File Offset: 0x00804AB3
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateDangoMonopolyTask, new Action(base.EventCheck));
	}

	// Token: 0x0601CAA3 RID: 117411 RVA: 0x008068D1 File Offset: 0x00804AD1
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateDangoMonopolyTask, new Action(base.EventCheck));
	}

	// Token: 0x0601CAA4 RID: 117412 RVA: 0x008068EF File Offset: 0x00804AEF
	protected override bool OnCheck(int uId = 0)
	{
		ActivityDangoMonopolyData data = ActivityDangoMonopolyController.Instance.GetData();
		return data != null && data.IsRedDotDiceTask();
	}
}
