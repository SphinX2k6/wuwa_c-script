using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033BA RID: 13242
public class RedDotMailBoxImportantFilter : RedDotBase
{
	// Token: 0x0601CB9A RID: 117658 RVA: 0x00808924 File Offset: 0x00806B24
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.SwitchUnfinishedFlag, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
	}

	// Token: 0x0601CB9B RID: 117659 RVA: 0x0080895E File Offset: 0x00806B5E
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.SwitchUnfinishedFlag, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
	}

	// Token: 0x0601CB9C RID: 117660 RVA: 0x00808998 File Offset: 0x00806B98
	protected override bool OnCheck(int uId = 0)
	{
		return MailModel.Instance.GetRedDotImportant();
	}

	// Token: 0x0601CB9D RID: 117661 RVA: 0x008089A4 File Offset: 0x00806BA4
	private void OnPlayerLevelChanged(int lastLevel, int currentLevel, int currentExp, int lastExp, int addExp, int currentMaxExp, int lastMaxExp)
	{
		base.EventCheck();
	}
}
