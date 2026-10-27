using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033BB RID: 13243
public class RedDotMailBoxUnScannedFilter : RedDotBase
{
	// Token: 0x0601CB9F RID: 117663 RVA: 0x008089B4 File Offset: 0x00806BB4
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.SwitchUnfinishedFlag, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
	}

	// Token: 0x0601CBA0 RID: 117664 RVA: 0x008089EE File Offset: 0x00806BEE
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.SwitchUnfinishedFlag, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
	}

	// Token: 0x0601CBA1 RID: 117665 RVA: 0x00808A28 File Offset: 0x00806C28
	protected override bool OnCheck(int uId = 0)
	{
		return MailModel.Instance.UnScannedRedPoint();
	}

	// Token: 0x0601CBA2 RID: 117666 RVA: 0x00808A34 File Offset: 0x00806C34
	private void OnPlayerLevelChanged(int lastLevel, int currentLevel, int currentExp, int lastExp, int addExp, int currentMaxExp, int lastMaxExp)
	{
		base.EventCheck();
	}
}
