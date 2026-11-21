using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002931 RID: 10545
public class RedDotMoonChasingBranchTab : RedDotBase
{
	// Token: 0x0601A8A5 RID: 108709 RVA: 0x0082F07D File Offset: 0x0082D27D
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.MoonChasingAllQuest);
	}

	// Token: 0x0601A8A6 RID: 108710 RVA: 0x0082F089 File Offset: 0x0082D289
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MoonChasingRefreshQuestRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A8A7 RID: 108711 RVA: 0x0082F0A7 File Offset: 0x0082D2A7
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MoonChasingRefreshQuestRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A8A8 RID: 108712 RVA: 0x0082F0C5 File Offset: 0x0082D2C5
	protected override bool OnCheck(int uId = 0)
	{
		ActivityMoonChasingController.Instance.RefreshActivityRedDot();
		return MoonChasingModel.Instance.CheckBranchRedDot();
	}
}
