using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033B9 RID: 13241
public class RedDotMailBoxFilter : RedDotBase
{
	// Token: 0x0601CB95 RID: 117653 RVA: 0x00808894 File Offset: 0x00806A94
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.SwitchUnfinishedFlag, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
	}

	// Token: 0x0601CB96 RID: 117654 RVA: 0x008088CE File Offset: 0x00806ACE
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.SwitchUnfinishedFlag, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
	}

	// Token: 0x0601CB97 RID: 117655 RVA: 0x00808908 File Offset: 0x00806B08
	protected override bool OnCheck(int uId = 0)
	{
		return MailModel.Instance.GetRedDotCouldLightOn();
	}

	// Token: 0x0601CB98 RID: 117656 RVA: 0x00808914 File Offset: 0x00806B14
	private void OnPlayerLevelChanged(int lastLevel, int currentLevel, int currentExp, int lastExp, int addExp, int currentMaxExp, int lastMaxExp)
	{
		base.EventCheck();
	}
}
