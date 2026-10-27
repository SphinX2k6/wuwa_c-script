using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip;

// Token: 0x0200340B RID: 13323
public class RedDotRhythmShipTaskTab : RedDotBase
{
	// Token: 0x0601CD18 RID: 118040 RVA: 0x0080B47C File Offset: 0x0080967C
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RhythmShipTask);
	}

	// Token: 0x0601CD19 RID: 118041 RVA: 0x0080B488 File Offset: 0x00809688
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnRhythmShipTaskTabRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD1A RID: 118042 RVA: 0x0080B4A6 File Offset: 0x008096A6
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnRhythmShipTaskTabRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD1B RID: 118043 RVA: 0x0080B4C4 File Offset: 0x008096C4
	protected override bool OnCheck(int uId = 0)
	{
		return RhythmShipModel.Instance.GetCanTaskTabGetReward(uId, 0);
	}
}
