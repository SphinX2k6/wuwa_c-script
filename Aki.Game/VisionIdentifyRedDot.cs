using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020029C3 RID: 10691
public class VisionIdentifyRedDot : RedDotBase
{
	// Token: 0x0601AB57 RID: 109399 RVA: 0x0083484C File Offset: 0x00832A4C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.PhantomLevelUpWithId, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.OnVisionIdentifyWithId, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.RefreshVisionIdentifyRedPoint, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AB58 RID: 109400 RVA: 0x008348B0 File Offset: 0x00832AB0
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.PhantomLevelUpWithId, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.OnVisionIdentifyWithId, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.RefreshVisionIdentifyRedPoint, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AB59 RID: 109401 RVA: 0x00834911 File Offset: 0x00832B11
	protected override bool OnCheck(int uId = 0)
	{
		return PhantomBattleModel.Instance.CheckVisionIdentifyRedDot(uId);
	}
}
