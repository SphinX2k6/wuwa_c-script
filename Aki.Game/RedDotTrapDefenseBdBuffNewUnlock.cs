using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x020029B2 RID: 10674
public class RedDotTrapDefenseBdBuffNewUnlock : RedDotBase
{
	// Token: 0x0601AB12 RID: 109330 RVA: 0x0083429A File Offset: 0x0083249A
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.TrapDefenseBdSum);
	}

	// Token: 0x0601AB13 RID: 109331 RVA: 0x008342A6 File Offset: 0x008324A6
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateTrapDefenseBdBuffNewUnlock, new Action(base.EventCheck));
	}

	// Token: 0x0601AB14 RID: 109332 RVA: 0x008342C4 File Offset: 0x008324C4
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateTrapDefenseBdBuffNewUnlock, new Action(base.EventCheck));
	}

	// Token: 0x0601AB15 RID: 109333 RVA: 0x008342E2 File Offset: 0x008324E2
	protected override bool OnCheck(int uId = 0)
	{
		return TrapDefenseModel.Instance.RougeModeData.RedDotNewUnlockBdBuff();
	}
}
