using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028F2 RID: 10482
public class RedDotDangoMonopolyDiceNum : RedDotBase
{
	// Token: 0x0601A78F RID: 108431 RVA: 0x0082CD9D File Offset: 0x0082AF9D
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.DangoMonopoly);
	}

	// Token: 0x0601A790 RID: 108432 RVA: 0x0082CDA9 File Offset: 0x0082AFA9
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateDangoMonopolyNum, new Action(base.EventCheck));
	}

	// Token: 0x0601A791 RID: 108433 RVA: 0x0082CDC7 File Offset: 0x0082AFC7
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateDangoMonopolyNum, new Action(base.EventCheck));
	}

	// Token: 0x0601A792 RID: 108434 RVA: 0x0082CDE5 File Offset: 0x0082AFE5
	protected override bool OnCheck(int uId = 0)
	{
		ActivityDangoMonopolyData data = ActivityDangoMonopolyController.Instance.GetData();
		return data != null && data.IsCanUseDice();
	}
}
