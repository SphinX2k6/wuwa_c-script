using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020029AE RID: 10670
public class TowerDefenseInstanceRedDot : RedDotBase
{
	// Token: 0x0601AB05 RID: 109317 RVA: 0x0083406A File Offset: 0x0083226A
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.TowerDefenseOnInstanceInfoUpdateNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601AB06 RID: 109318 RVA: 0x00834088 File Offset: 0x00832288
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.TowerDefenseOnInstanceInfoUpdateNotify, new Action(base.EventCheck));
	}

	// Token: 0x0601AB07 RID: 109319 RVA: 0x008340A6 File Offset: 0x008322A6
	protected override bool OnCheck(int uId = 0)
	{
		return TowerDefenseController.Instance.CheckHasNewStage();
	}
}
