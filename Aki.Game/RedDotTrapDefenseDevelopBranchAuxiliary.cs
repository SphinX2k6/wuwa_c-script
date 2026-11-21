using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x020029B5 RID: 10677
public class RedDotTrapDefenseDevelopBranchAuxiliary : RedDotBase
{
	// Token: 0x0601AB19 RID: 109337 RVA: 0x0083430B File Offset: 0x0083250B
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.TrapDefenseDevelopBranchAll);
	}

	// Token: 0x0601AB1A RID: 109338 RVA: 0x00834317 File Offset: 0x00832517
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.TrapDefenseOnBranchUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601AB1B RID: 109339 RVA: 0x00834335 File Offset: 0x00832535
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.TrapDefenseOnBranchUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601AB1C RID: 109340 RVA: 0x00834353 File Offset: 0x00832553
	protected override bool OnCheck(int uId = 0)
	{
		return TrapDefenseModel.Instance.ViewModelBuildingDevelop.CheckAuxiliaryRedDot();
	}
}
