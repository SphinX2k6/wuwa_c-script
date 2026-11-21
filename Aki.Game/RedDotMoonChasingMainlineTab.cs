using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002935 RID: 10549
public class RedDotMoonChasingMainlineTab : RedDotBase
{
	// Token: 0x0601A8B6 RID: 108726 RVA: 0x0082F216 File Offset: 0x0082D416
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.MoonChasingAllQuest);
	}

	// Token: 0x0601A8B7 RID: 108727 RVA: 0x0082F222 File Offset: 0x0082D422
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MoonChasingRefreshQuestRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A8B8 RID: 108728 RVA: 0x0082F240 File Offset: 0x0082D440
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MoonChasingRefreshQuestRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A8B9 RID: 108729 RVA: 0x0082F25E File Offset: 0x0082D45E
	protected override bool OnCheck(int uId = 0)
	{
		ActivityMoonChasingController.Instance.RefreshActivityRedDot();
		return MoonChasingModel.Instance.CheckMainlineRedDot();
	}
}
