using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028CF RID: 10447
public class BabelTowerDifficultyRedDot : RedDotBase
{
	// Token: 0x0601A6E7 RID: 108263 RVA: 0x0082B955 File Offset: 0x00829B55
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.BabelTowerDifficultyLevelClick, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.BabelTowerDifficultyRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A6E8 RID: 108264 RVA: 0x0082B98F File Offset: 0x00829B8F
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.BabelTowerDifficultyLevelClick, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.BabelTowerDifficultyRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A6E9 RID: 108265 RVA: 0x0082B9CC File Offset: 0x00829BCC
	protected override bool OnCheck(int uId = 0)
	{
		BabelTowerData babelTowerData = BabelTowerController.Instance.GetBabelTowerData();
		return babelTowerData != null && babelTowerData.GetDifficultyNewLevelRedDot(uId);
	}
}
