using System;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;

// Token: 0x02003369 RID: 13161
public class RedDotBattleViewShopButton : RedDotBase
{
	// Token: 0x0601CA2C RID: 117292 RVA: 0x00805AE1 File Offset: 0x00803CE1
	protected override bool OnCheck(int uId = 0)
	{
		return LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.FirstOpenShop, true);
	}

	// Token: 0x0601CA2D RID: 117293 RVA: 0x00805AEA File Offset: 0x00803CEA
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnFirstOpenShopChanged, new Action(base.EventCheck));
	}

	// Token: 0x0601CA2E RID: 117294 RVA: 0x00805B08 File Offset: 0x00803D08
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnFirstOpenShopChanged, new Action(base.EventCheck));
	}
}
