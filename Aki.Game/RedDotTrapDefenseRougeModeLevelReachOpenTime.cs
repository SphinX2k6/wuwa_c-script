using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x020029BA RID: 10682
public class RedDotTrapDefenseRougeModeLevelReachOpenTime : RedDotBase
{
	// Token: 0x0601AB2A RID: 109354 RVA: 0x0083443E File Offset: 0x0083263E
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.TrapDefenseRougeLevel);
	}

	// Token: 0x0601AB2B RID: 109355 RVA: 0x0083444A File Offset: 0x0083264A
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateTrapDefenseRougeModeLevelReachOpenTime, new Action(base.EventCheck));
	}

	// Token: 0x0601AB2C RID: 109356 RVA: 0x00834468 File Offset: 0x00832668
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateTrapDefenseRougeModeLevelReachOpenTime, new Action(base.EventCheck));
	}

	// Token: 0x0601AB2D RID: 109357 RVA: 0x00834486 File Offset: 0x00832686
	protected override bool OnCheck(int uId = 0)
	{
		return TrapDefenseModel.Instance.RougeModeData.RedDotLevelReachOpenTime();
	}
}
