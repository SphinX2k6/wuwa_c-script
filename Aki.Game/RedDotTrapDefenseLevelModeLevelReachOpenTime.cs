using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x02003443 RID: 13379
public class RedDotTrapDefenseLevelModeLevelReachOpenTime : RedDotBase
{
	// Token: 0x0601CE23 RID: 118307 RVA: 0x0080DCE5 File Offset: 0x0080BEE5
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.TrapDefenseMainLevel);
	}

	// Token: 0x0601CE24 RID: 118308 RVA: 0x0080DCF1 File Offset: 0x0080BEF1
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateTrapDefenseLevelModeLevelReachOpenTime, new Action(base.EventCheck));
	}

	// Token: 0x0601CE25 RID: 118309 RVA: 0x0080DD0F File Offset: 0x0080BF0F
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateTrapDefenseLevelModeLevelReachOpenTime, new Action(base.EventCheck));
	}

	// Token: 0x0601CE26 RID: 118310 RVA: 0x0080DD2D File Offset: 0x0080BF2D
	protected override bool OnCheck(int uId = 0)
	{
		return TrapDefenseModel.Instance.LevelModeData.RedDotLevelReachOpenTime();
	}
}
