using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x020029B7 RID: 10679
public class RedDotTrapDefenseLevelModeLevelReachOpenTime : RedDotBase
{
	// Token: 0x0601AB23 RID: 109347 RVA: 0x008343CD File Offset: 0x008325CD
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.TrapDefenseMainLevel);
	}

	// Token: 0x0601AB24 RID: 109348 RVA: 0x008343D9 File Offset: 0x008325D9
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateTrapDefenseLevelModeLevelReachOpenTime, new Action(base.EventCheck));
	}

	// Token: 0x0601AB25 RID: 109349 RVA: 0x008343F7 File Offset: 0x008325F7
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateTrapDefenseLevelModeLevelReachOpenTime, new Action(base.EventCheck));
	}

	// Token: 0x0601AB26 RID: 109350 RVA: 0x00834415 File Offset: 0x00832615
	protected override bool OnCheck(int uId = 0)
	{
		return TrapDefenseModel.Instance.LevelModeData.RedDotLevelReachOpenTime();
	}
}
