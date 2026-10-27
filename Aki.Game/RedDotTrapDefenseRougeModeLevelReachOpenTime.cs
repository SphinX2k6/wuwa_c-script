using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x02003446 RID: 13382
public class RedDotTrapDefenseRougeModeLevelReachOpenTime : RedDotBase
{
	// Token: 0x0601CE2A RID: 118314 RVA: 0x0080DD56 File Offset: 0x0080BF56
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.TrapDefenseRougeLevel);
	}

	// Token: 0x0601CE2B RID: 118315 RVA: 0x0080DD62 File Offset: 0x0080BF62
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateTrapDefenseRougeModeLevelReachOpenTime, new Action(base.EventCheck));
	}

	// Token: 0x0601CE2C RID: 118316 RVA: 0x0080DD80 File Offset: 0x0080BF80
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateTrapDefenseRougeModeLevelReachOpenTime, new Action(base.EventCheck));
	}

	// Token: 0x0601CE2D RID: 118317 RVA: 0x0080DD9E File Offset: 0x0080BF9E
	protected override bool OnCheck(int uId = 0)
	{
		return TrapDefenseModel.Instance.RougeModeData.RedDotLevelReachOpenTime();
	}
}
