using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x02003447 RID: 13383
public class RedDotTrapDefenseRougeModeOpen : RedDotBase
{
	// Token: 0x0601CE2F RID: 118319 RVA: 0x0080DDB7 File Offset: 0x0080BFB7
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.TrapDefenseRougeLevel);
	}

	// Token: 0x0601CE30 RID: 118320 RVA: 0x0080DDC3 File Offset: 0x0080BFC3
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateTrapDefenseRougeModeOpen, new Action(base.EventCheck));
	}

	// Token: 0x0601CE31 RID: 118321 RVA: 0x0080DDE1 File Offset: 0x0080BFE1
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateTrapDefenseRougeModeOpen, new Action(base.EventCheck));
	}

	// Token: 0x0601CE32 RID: 118322 RVA: 0x0080DDFF File Offset: 0x0080BFFF
	protected override bool OnCheck(int uId = 0)
	{
		return TrapDefenseModel.Instance.RougeModeData.RedDotModeOpen();
	}
}
