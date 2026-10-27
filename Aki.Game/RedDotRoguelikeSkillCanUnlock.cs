using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity;

// Token: 0x02003410 RID: 13328
public class RedDotRoguelikeSkillCanUnlock : RedDotBase
{
	// Token: 0x0601CD32 RID: 118066 RVA: 0x0080B7A8 File Offset: 0x008099A8
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RoguelikeCurrencyUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.RoguelikeDataUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.RoguelikeTalentLevelUp, new Action<int>(this.OnRoguelikeTalentLevelUp));
	}

	// Token: 0x0601CD33 RID: 118067 RVA: 0x0080B80C File Offset: 0x00809A0C
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RoguelikeCurrencyUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.RoguelikeDataUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.RoguelikeTalentLevelUp, new Action<int>(this.OnRoguelikeTalentLevelUp));
	}

	// Token: 0x0601CD34 RID: 118068 RVA: 0x0080B86D File Offset: 0x00809A6D
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601CD35 RID: 118069 RVA: 0x0080B870 File Offset: 0x00809A70
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRogueController.Instance.RefreshActivityRedDot();
		return RoguelikeModel.Instance.CheckHasCanUnlockSkill();
	}

	// Token: 0x0601CD36 RID: 118070 RVA: 0x0080B886 File Offset: 0x00809A86
	private void OnRoguelikeTalentLevelUp(int _)
	{
		base.EventCheck();
	}
}
