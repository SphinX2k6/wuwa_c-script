using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200292B RID: 10539
public class RedDotMailBoxFilter : RedDotBase
{
	// Token: 0x0601A88D RID: 108685 RVA: 0x0082EE58 File Offset: 0x0082D058
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.SwitchUnfinishedFlag, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
	}

	// Token: 0x0601A88E RID: 108686 RVA: 0x0082EE92 File Offset: 0x0082D092
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.SwitchUnfinishedFlag, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
	}

	// Token: 0x0601A88F RID: 108687 RVA: 0x0082EECC File Offset: 0x0082D0CC
	protected override bool OnCheck(int uId = 0)
	{
		return MailModel.Instance.GetRedDotCouldLightOn();
	}

	// Token: 0x0601A890 RID: 108688 RVA: 0x0082EED8 File Offset: 0x0082D0D8
	private void OnPlayerLevelChanged(int lastLevel, int currentLevel, int currentExp, int lastExp, int addExp, int currentMaxExp, int lastMaxExp)
	{
		base.EventCheck();
	}
}
