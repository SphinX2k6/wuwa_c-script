using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028D0 RID: 10448
public class BabelTowerLevelRedDot : RedDotBase
{
	// Token: 0x0601A6EB RID: 108267 RVA: 0x0082B9F8 File Offset: 0x00829BF8
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.BabelTowerLevelClick, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.BabelTowerLevelRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A6EC RID: 108268 RVA: 0x0082BA32 File Offset: 0x00829C32
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.BabelTowerLevelClick, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.BabelTowerLevelRedDotUpdate, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A6ED RID: 108269 RVA: 0x0082BA6C File Offset: 0x00829C6C
	protected override bool OnCheck(int uId = 0)
	{
		BabelTowerData babelTowerData = BabelTowerController.Instance.GetBabelTowerData();
		return babelTowerData != null && babelTowerData.GetNewLevelRedDot(uId);
	}
}
