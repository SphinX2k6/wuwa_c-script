using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x0200343E RID: 13374
public class RedDotTrapDefenseBdBuffNewUnlock : RedDotBase
{
	// Token: 0x0601CE12 RID: 118290 RVA: 0x0080DBB2 File Offset: 0x0080BDB2
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.TrapDefenseBdSum);
	}

	// Token: 0x0601CE13 RID: 118291 RVA: 0x0080DBBE File Offset: 0x0080BDBE
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateTrapDefenseBdBuffNewUnlock, new Action(base.EventCheck));
	}

	// Token: 0x0601CE14 RID: 118292 RVA: 0x0080DBDC File Offset: 0x0080BDDC
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateTrapDefenseBdBuffNewUnlock, new Action(base.EventCheck));
	}

	// Token: 0x0601CE15 RID: 118293 RVA: 0x0080DBFA File Offset: 0x0080BDFA
	protected override bool OnCheck(int uId = 0)
	{
		return TrapDefenseModel.Instance.RougeModeData.RedDotNewUnlockBdBuff();
	}
}
