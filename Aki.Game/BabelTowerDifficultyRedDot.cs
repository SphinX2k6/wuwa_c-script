using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200335D RID: 13149
public class BabelTowerDifficultyRedDot : RedDotBase
{
	// Token: 0x0601C9EF RID: 117231 RVA: 0x00805391 File Offset: 0x00803591
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.BabelTowerDifficultyLevelClick, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.BabelTowerDifficultyRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601C9F0 RID: 117232 RVA: 0x008053CB File Offset: 0x008035CB
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.BabelTowerDifficultyLevelClick, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.BabelTowerDifficultyRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601C9F1 RID: 117233 RVA: 0x00805408 File Offset: 0x00803608
	protected override bool OnCheck(int uId = 0)
	{
		BabelTowerData babelTowerData = BabelTowerController.Instance.GetBabelTowerData();
		return babelTowerData != null && babelTowerData.GetDifficultyNewLevelRedDot(uId);
	}
}
