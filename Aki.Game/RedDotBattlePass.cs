using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003360 RID: 13152
public class RedDotBattlePass : RedDotBase
{
	// Token: 0x0601C9FB RID: 117243 RVA: 0x0080553B File Offset: 0x0080373B
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewMenu);
	}

	// Token: 0x0601C9FC RID: 117244 RVA: 0x00805543 File Offset: 0x00803743
	protected override void AddActiveEvents()
	{
		EventSystem.Instance.Add(EEventName.UpdateBattlePassTaskEvent, new Action(base.OnActiveEvent));
	}

	// Token: 0x0601C9FD RID: 117245 RVA: 0x00805561 File Offset: 0x00803761
	protected override void AddDisActiveEvents()
	{
		EventSystem.Instance.Add(EEventName.OnBattlePassExpireEvent, new Action(base.OnDisActiveEvent));
	}
}
