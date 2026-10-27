using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003359 RID: 13145
public class RedDotAdventureFirstAwardResult : RedDotBase
{
	// Token: 0x0601C9DF RID: 117215 RVA: 0x008051E7 File Offset: 0x008033E7
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RedDotSilentFirstAwardResult, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601C9E0 RID: 117216 RVA: 0x00805205 File Offset: 0x00803405
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RedDotSilentFirstAwardResult, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601C9E1 RID: 117217 RVA: 0x00805223 File Offset: 0x00803423
	protected override bool OnCheck(int uId = 0)
	{
		return AdventureGuideController.Instance.CheckCanGetFirstAwardById(uId);
	}
}
