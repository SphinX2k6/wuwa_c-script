using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x02003442 RID: 13378
public class RedDotTrapDefenseDevelopBranchBuilding : RedDotBase
{
	// Token: 0x0601CE1E RID: 118302 RVA: 0x0080DC84 File Offset: 0x0080BE84
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.TrapDefenseDevelopBranchAll);
	}

	// Token: 0x0601CE1F RID: 118303 RVA: 0x0080DC90 File Offset: 0x0080BE90
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.TrapDefenseOnBranchUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CE20 RID: 118304 RVA: 0x0080DCAE File Offset: 0x0080BEAE
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.TrapDefenseOnBranchUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CE21 RID: 118305 RVA: 0x0080DCCC File Offset: 0x0080BECC
	protected override bool OnCheck(int uId = 0)
	{
		return TrapDefenseModel.Instance.ViewModelBuildingDevelop.CheckBuildingRedDot();
	}
}
