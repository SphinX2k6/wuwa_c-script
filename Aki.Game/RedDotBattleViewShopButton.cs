using System;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;

// Token: 0x020028DB RID: 10459
public class RedDotBattleViewShopButton : RedDotBase
{
	// Token: 0x0601A724 RID: 108324 RVA: 0x0082C0A5 File Offset: 0x0082A2A5
	protected override bool OnCheck(int uId = 0)
	{
		return LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.FirstOpenShop, true);
	}

	// Token: 0x0601A725 RID: 108325 RVA: 0x0082C0AE File Offset: 0x0082A2AE
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnFirstOpenShopChanged, new Action(base.EventCheck));
	}

	// Token: 0x0601A726 RID: 108326 RVA: 0x0082C0CC File Offset: 0x0082A2CC
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnFirstOpenShopChanged, new Action(base.EventCheck));
	}
}
