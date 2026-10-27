using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x0200339D RID: 13213
public class RedDotFunctionPayShop : RedDotBase
{
	// Token: 0x0601CB0D RID: 117517 RVA: 0x00807523 File Offset: 0x00805723
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewMenu);
	}

	// Token: 0x0601CB0E RID: 117518 RVA: 0x0080752C File Offset: 0x0080572C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnFunctionViewShow, new Action(base.EventCheck));
		EventSystem.Instance.Add<IEnumerable<PayShopDefine.EPayShopTabType>>(EEventName.RefreshAllPayShop, new Action<IEnumerable<PayShopDefine.EPayShopTabType>>(this.OnRefreshAllPayShop));
		EventSystem.Instance.Add(EEventName.RefreshPayShopEntranceRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CB0F RID: 117519 RVA: 0x00807590 File Offset: 0x00805790
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnFunctionViewShow, new Action(base.EventCheck));
		EventSystem.Instance.Remove<IEnumerable<PayShopDefine.EPayShopTabType>>(EEventName.RefreshAllPayShop, new Action<IEnumerable<PayShopDefine.EPayShopTabType>>(this.OnRefreshAllPayShop));
		EventSystem.Instance.Remove(EEventName.RefreshPayShopEntranceRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CB10 RID: 117520 RVA: 0x008075F1 File Offset: 0x008057F1
	protected override bool OnCheck(int uId = 0)
	{
		return PayShopModel.Instance.CheckPayShopEntranceHasRedDot();
	}

	// Token: 0x0601CB11 RID: 117521 RVA: 0x008075FD File Offset: 0x008057FD
	[NullableContext(1)]
	private void OnRefreshAllPayShop(IEnumerable<PayShopDefine.EPayShopTabType> idList)
	{
		base.EventCheck();
	}
}
