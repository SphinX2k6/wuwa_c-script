using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x02003441 RID: 13377
public class RedDotTrapDefenseDevelopBranchAuxiliary : RedDotBase
{
	// Token: 0x0601CE19 RID: 118297 RVA: 0x0080DC23 File Offset: 0x0080BE23
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.TrapDefenseDevelopBranchAll);
	}

	// Token: 0x0601CE1A RID: 118298 RVA: 0x0080DC2F File Offset: 0x0080BE2F
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.TrapDefenseOnBranchUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CE1B RID: 118299 RVA: 0x0080DC4D File Offset: 0x0080BE4D
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.TrapDefenseOnBranchUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CE1C RID: 118300 RVA: 0x0080DC6B File Offset: 0x0080BE6B
	protected override bool OnCheck(int uId = 0)
	{
		return TrapDefenseModel.Instance.ViewModelBuildingDevelop.CheckAuxiliaryRedDot();
	}
}
