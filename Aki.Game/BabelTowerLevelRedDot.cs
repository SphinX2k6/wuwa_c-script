using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200335E RID: 13150
public class BabelTowerLevelRedDot : RedDotBase
{
	// Token: 0x0601C9F3 RID: 117235 RVA: 0x00805434 File Offset: 0x00803634
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.BabelTowerLevelClick, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.BabelTowerLevelRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601C9F4 RID: 117236 RVA: 0x0080546E File Offset: 0x0080366E
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.BabelTowerLevelClick, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.BabelTowerLevelRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601C9F5 RID: 117237 RVA: 0x008054A8 File Offset: 0x008036A8
	protected override bool OnCheck(int uId = 0)
	{
		BabelTowerData babelTowerData = BabelTowerController.Instance.GetBabelTowerData();
		return babelTowerData != null && babelTowerData.GetNewLevelRedDot(uId);
	}
}
