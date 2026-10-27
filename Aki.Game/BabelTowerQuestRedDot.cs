using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200335F RID: 13151
public class BabelTowerQuestRedDot : RedDotBase
{
	// Token: 0x0601C9F7 RID: 117239 RVA: 0x008054D4 File Offset: 0x008036D4
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.BabelTowerRefreshQuestState, new Action(base.EventCheck));
	}

	// Token: 0x0601C9F8 RID: 117240 RVA: 0x008054F2 File Offset: 0x008036F2
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.BabelTowerRefreshQuestState, new Action(base.EventCheck));
	}

	// Token: 0x0601C9F9 RID: 117241 RVA: 0x00805510 File Offset: 0x00803710
	protected override bool OnCheck(int uId = 0)
	{
		BabelTowerData babelTowerData = BabelTowerController.Instance.GetBabelTowerData();
		return babelTowerData != null && babelTowerData.GetQuestAnyRedDot();
	}
}
