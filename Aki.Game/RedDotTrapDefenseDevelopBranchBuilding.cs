using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x020029B6 RID: 10678
public class RedDotTrapDefenseDevelopBranchBuilding : RedDotBase
{
	// Token: 0x0601AB1E RID: 109342 RVA: 0x0083436C File Offset: 0x0083256C
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.TrapDefenseDevelopBranchAll);
	}

	// Token: 0x0601AB1F RID: 109343 RVA: 0x00834378 File Offset: 0x00832578
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.TrapDefenseOnBranchUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601AB20 RID: 109344 RVA: 0x00834396 File Offset: 0x00832596
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.TrapDefenseOnBranchUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601AB21 RID: 109345 RVA: 0x008343B4 File Offset: 0x008325B4
	protected override bool OnCheck(int uId = 0)
	{
		return TrapDefenseModel.Instance.ViewModelBuildingDevelop.CheckBuildingRedDot();
	}
}
