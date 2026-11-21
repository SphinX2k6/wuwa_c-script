using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200292C RID: 10540
public class RedDotMailBoxImportantFilter : RedDotBase
{
	// Token: 0x0601A892 RID: 108690 RVA: 0x0082EEE8 File Offset: 0x0082D0E8
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.SwitchUnfinishedFlag, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
	}

	// Token: 0x0601A893 RID: 108691 RVA: 0x0082EF22 File Offset: 0x0082D122
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.SwitchUnfinishedFlag, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
	}

	// Token: 0x0601A894 RID: 108692 RVA: 0x0082EF5C File Offset: 0x0082D15C
	protected override bool OnCheck(int uId = 0)
	{
		return MailModel.Instance.GetRedDotImportant();
	}

	// Token: 0x0601A895 RID: 108693 RVA: 0x0082EF68 File Offset: 0x0082D168
	private void OnPlayerLevelChanged(int lastLevel, int currentLevel, int currentExp, int lastExp, int addExp, int currentMaxExp, int lastMaxExp)
	{
		base.EventCheck();
	}
}
