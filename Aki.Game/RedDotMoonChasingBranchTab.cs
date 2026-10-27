using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033BF RID: 13247
public class RedDotMoonChasingBranchTab : RedDotBase
{
	// Token: 0x0601CBAD RID: 117677 RVA: 0x00808AB9 File Offset: 0x00806CB9
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.MoonChasingAllQuest);
	}

	// Token: 0x0601CBAE RID: 117678 RVA: 0x00808AC5 File Offset: 0x00806CC5
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MoonChasingRefreshQuestRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CBAF RID: 117679 RVA: 0x00808AE3 File Offset: 0x00806CE3
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MoonChasingRefreshQuestRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CBB0 RID: 117680 RVA: 0x00808B01 File Offset: 0x00806D01
	protected override bool OnCheck(int uId = 0)
	{
		ActivityMoonChasingController.Instance.RefreshActivityRedDot();
		return MoonChasingModel.Instance.CheckBranchRedDot();
	}
}
