using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028D1 RID: 10449
public class BabelTowerQuestRedDot : RedDotBase
{
	// Token: 0x0601A6EF RID: 108271 RVA: 0x0082BA98 File Offset: 0x00829C98
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.BabelTowerRefreshQuestState, new Action(base.EventCheck));
	}

	// Token: 0x0601A6F0 RID: 108272 RVA: 0x0082BAB6 File Offset: 0x00829CB6
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.BabelTowerRefreshQuestState, new Action(base.EventCheck));
	}

	// Token: 0x0601A6F1 RID: 108273 RVA: 0x0082BAD4 File Offset: 0x00829CD4
	protected override bool OnCheck(int uId = 0)
	{
		BabelTowerData babelTowerData = BabelTowerController.Instance.GetBabelTowerData();
		return babelTowerData != null && babelTowerData.GetQuestAnyRedDot();
	}
}
