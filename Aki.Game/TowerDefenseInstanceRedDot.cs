using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200343A RID: 13370
public class TowerDefenseInstanceRedDot : RedDotBase
{
	// Token: 0x0601CE05 RID: 118277 RVA: 0x0080D982 File Offset: 0x0080BB82
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.TowerDefenseOnInstanceInfoUpdateNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601CE06 RID: 118278 RVA: 0x0080D9A0 File Offset: 0x0080BBA0
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.TowerDefenseOnInstanceInfoUpdateNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601CE07 RID: 118279 RVA: 0x0080D9BE File Offset: 0x0080BBBE
	protected override bool OnCheck(int uId = 0)
	{
		return TowerDefenseController.Instance.CheckHasNewStage();
	}
}
