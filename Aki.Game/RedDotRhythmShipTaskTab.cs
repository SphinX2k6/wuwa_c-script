using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip;

// Token: 0x0200297D RID: 10621
public class RedDotRhythmShipTaskTab : RedDotBase
{
	// Token: 0x0601AA10 RID: 109072 RVA: 0x00831A40 File Offset: 0x0082FC40
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RhythmShipTask);
	}

	// Token: 0x0601AA11 RID: 109073 RVA: 0x00831A4C File Offset: 0x0082FC4C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnRhythmShipTaskTabRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA12 RID: 109074 RVA: 0x00831A6A File Offset: 0x0082FC6A
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnRhythmShipTaskTabRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA13 RID: 109075 RVA: 0x00831A88 File Offset: 0x0082FC88
	protected override bool OnCheck(int uId = 0)
	{
		return RhythmShipModel.Instance.GetCanTaskTabGetReward(uId, 0);
	}
}
