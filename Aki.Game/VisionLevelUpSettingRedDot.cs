using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020029C4 RID: 10692
public class VisionLevelUpSettingRedDot : RedDotBase
{
	// Token: 0x0601AB5B RID: 109403 RVA: 0x00834926 File Offset: 0x00832B26
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RefreshVisionLevelUpSettingRedPoint, new Action(base.EventCheck));
	}

	// Token: 0x0601AB5C RID: 109404 RVA: 0x00834944 File Offset: 0x00832B44
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RefreshVisionLevelUpSettingRedPoint, new Action(base.EventCheck));
	}

	// Token: 0x0601AB5D RID: 109405 RVA: 0x00834962 File Offset: 0x00832B62
	protected override bool OnCheck(int uId = 0)
	{
		return PhantomBattleModel.Instance.CheckVisionLevelUpSettingRedDot();
	}
}
