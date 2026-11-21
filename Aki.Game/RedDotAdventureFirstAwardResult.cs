using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028CB RID: 10443
public class RedDotAdventureFirstAwardResult : RedDotBase
{
	// Token: 0x0601A6D7 RID: 108247 RVA: 0x0082B7AB File Offset: 0x008299AB
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RedDotSilentFirstAwardResult, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A6D8 RID: 108248 RVA: 0x0082B7C9 File Offset: 0x008299C9
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RedDotSilentFirstAwardResult, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A6D9 RID: 108249 RVA: 0x0082B7E7 File Offset: 0x008299E7
	protected override bool OnCheck(int uId = 0)
	{
		return AdventureGuideController.Instance.CheckCanGetFirstAwardById(uId);
	}
}
