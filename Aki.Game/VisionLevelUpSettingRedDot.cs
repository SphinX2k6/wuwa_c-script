using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003450 RID: 13392
public class VisionLevelUpSettingRedDot : RedDotBase
{
	// Token: 0x0601CE5B RID: 118363 RVA: 0x0080E23E File Offset: 0x0080C43E
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RefreshVisionLevelUpSettingRedPoint, new Action(base.EventCheck));
	}

	// Token: 0x0601CE5C RID: 118364 RVA: 0x0080E25C File Offset: 0x0080C45C
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RefreshVisionLevelUpSettingRedPoint, new Action(base.EventCheck));
	}

	// Token: 0x0601CE5D RID: 118365 RVA: 0x0080E27A File Offset: 0x0080C47A
	protected override bool OnCheck(int uId = 0)
	{
		return PhantomBattleModel.Instance.CheckVisionLevelUpSettingRedDot();
	}
}
