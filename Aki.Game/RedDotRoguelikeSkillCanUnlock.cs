using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity;

// Token: 0x02002982 RID: 10626
public class RedDotRoguelikeSkillCanUnlock : RedDotBase
{
	// Token: 0x0601AA2A RID: 109098 RVA: 0x00831D6C File Offset: 0x0082FF6C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RoguelikeCurrencyUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.RoguelikeDataUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.RoguelikeTalentLevelUp, new Action<int>(this.OnRoguelikeTalentLevelUp));
	}

	// Token: 0x0601AA2B RID: 109099 RVA: 0x00831DD0 File Offset: 0x0082FFD0
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RoguelikeCurrencyUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.RoguelikeDataUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.RoguelikeTalentLevelUp, new Action<int>(this.OnRoguelikeTalentLevelUp));
	}

	// Token: 0x0601AA2C RID: 109100 RVA: 0x00831E31 File Offset: 0x00830031
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601AA2D RID: 109101 RVA: 0x00831E34 File Offset: 0x00830034
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRogueController.Instance.RefreshActivityRedDot();
		return RoguelikeModel.Instance.CheckHasCanUnlockSkill();
	}

	// Token: 0x0601AA2E RID: 109102 RVA: 0x00831E4A File Offset: 0x0083004A
	private void OnRoguelikeTalentLevelUp(int _)
	{
		base.EventCheck();
	}
}
