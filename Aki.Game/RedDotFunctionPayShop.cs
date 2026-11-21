using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x0200290F RID: 10511
public class RedDotFunctionPayShop : RedDotBase
{
	// Token: 0x0601A805 RID: 108549 RVA: 0x0082DAE7 File Offset: 0x0082BCE7
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewMenu);
	}

	// Token: 0x0601A806 RID: 108550 RVA: 0x0082DAF0 File Offset: 0x0082BCF0
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnFunctionViewShow, new Action(base.EventCheck));
		EventSystem.Instance.Add<IEnumerable<PayShopDefine.EPayShopTabType>>(EEventName.RefreshAllPayShop, new Action<IEnumerable<PayShopDefine.EPayShopTabType>>(this.OnRefreshAllPayShop));
		EventSystem.Instance.Add(EEventName.RefreshPayShopEntranceRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A807 RID: 108551 RVA: 0x0082DB54 File Offset: 0x0082BD54
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnFunctionViewShow, new Action(base.EventCheck));
		EventSystem.Instance.Remove<IEnumerable<PayShopDefine.EPayShopTabType>>(EEventName.RefreshAllPayShop, new Action<IEnumerable<PayShopDefine.EPayShopTabType>>(this.OnRefreshAllPayShop));
		EventSystem.Instance.Remove(EEventName.RefreshPayShopEntranceRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A808 RID: 108552 RVA: 0x0082DBB5 File Offset: 0x0082BDB5
	protected override bool OnCheck(int uId = 0)
	{
		return PayShopModel.Instance.CheckPayShopEntranceHasRedDot();
	}

	// Token: 0x0601A809 RID: 108553 RVA: 0x0082DBC1 File Offset: 0x0082BDC1
	[NullableContext(1)]
	private void OnRefreshAllPayShop(IEnumerable<PayShopDefine.EPayShopTabType> idList)
	{
		base.EventCheck();
	}
}
