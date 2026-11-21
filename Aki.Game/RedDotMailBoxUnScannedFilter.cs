using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200292D RID: 10541
public class RedDotMailBoxUnScannedFilter : RedDotBase
{
	// Token: 0x0601A897 RID: 108695 RVA: 0x0082EF78 File Offset: 0x0082D178
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.SwitchUnfinishedFlag, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
	}

	// Token: 0x0601A898 RID: 108696 RVA: 0x0082EFB2 File Offset: 0x0082D1B2
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.SwitchUnfinishedFlag, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
	}

	// Token: 0x0601A899 RID: 108697 RVA: 0x0082EFEC File Offset: 0x0082D1EC
	protected override bool OnCheck(int uId = 0)
	{
		return MailModel.Instance.UnScannedRedPoint();
	}

	// Token: 0x0601A89A RID: 108698 RVA: 0x0082EFF8 File Offset: 0x0082D1F8
	private void OnPlayerLevelChanged(int lastLevel, int currentLevel, int currentExp, int lastExp, int addExp, int currentMaxExp, int lastMaxExp)
	{
		base.EventCheck();
	}
}
