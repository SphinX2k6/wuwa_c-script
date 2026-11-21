using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028D2 RID: 10450
public class RedDotBattlePass : RedDotBase
{
	// Token: 0x0601A6F3 RID: 108275 RVA: 0x0082BAFF File Offset: 0x00829CFF
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewMenu);
	}

	// Token: 0x0601A6F4 RID: 108276 RVA: 0x0082BB07 File Offset: 0x00829D07
	protected override void AddActiveEvents()
	{
		EventSystem.Instance.Add(EEventName.UpdateBattlePassTaskEvent, new Action(base.OnActiveEvent));
	}

	// Token: 0x0601A6F5 RID: 108277 RVA: 0x0082BB25 File Offset: 0x00829D25
	protected override void AddDisActiveEvents()
	{
		EventSystem.Instance.Add(EEventName.OnBattlePassExpireEvent, new Action(base.OnDisActiveEvent));
	}
}
