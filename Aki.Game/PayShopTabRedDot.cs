using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020029A0 RID: 10656
[NullableContext(1)]
[Nullable(0)]
public class PayShopTabRedDot : RedDotBase
{
	// Token: 0x0601AABF RID: 109247 RVA: 0x008334A6 File Offset: 0x008316A6
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601AAC0 RID: 109248 RVA: 0x008334A9 File Offset: 0x008316A9
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601AAC1 RID: 109249 RVA: 0x008334AC File Offset: 0x008316AC
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.PayShopGoodsBuy, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.GoodsRefreshDiscountTime, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<PayShopDefine.EPayShopTabType>(EEventName.SwitchPayShopView, new Action<PayShopDefine.EPayShopTabType>(this.OnSwitchPayShopView));
		EventSystem.Instance.Add<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.OnRefreshPayShop));
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.RefreshGoodsList, new Action<IReadOnlySet<int>>(this.OnRefreshGoodsList));
		EventSystem.Instance.Add<IReadOnlyDictionary<int, HashSet<int>>>(EEventName.UnLockGoods, new Action<IReadOnlyDictionary<int, HashSet<int>>>(this.OnUnLockGoods));
		EventSystem.Instance.Add<int>(EEventName.RefreshPayShopTabRedDot, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add(EEventName.ReceiveWeekCardDataEvent, new Action(base.EventCheck));
	}

	// Token: 0x0601AAC2 RID: 109250 RVA: 0x008335B8 File Offset: 0x008317B8
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.PayShopGoodsBuy, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.GoodsRefreshDiscountTime, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<PayShopDefine.EPayShopTabType>(EEventName.SwitchPayShopView, new Action<PayShopDefine.EPayShopTabType>(this.OnSwitchPayShopView));
		EventSystem.Instance.Remove<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.OnRefreshPayShop));
		EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.RefreshGoodsList, new Action<IReadOnlySet<int>>(this.OnRefreshGoodsList));
		EventSystem.Instance.Remove<IReadOnlyDictionary<int, HashSet<int>>>(EEventName.UnLockGoods, new Action<IReadOnlyDictionary<int, HashSet<int>>>(this.OnUnLockGoods));
		EventSystem.Instance.Remove<int>(EEventName.RefreshPayShopTabRedDot, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove(EEventName.ReceiveWeekCardDataEvent, new Action(base.EventCheck));
	}

	// Token: 0x0601AAC3 RID: 109251 RVA: 0x008336C4 File Offset: 0x008318C4
	protected override bool OnCheck(int uId = 0)
	{
		int currentPayShopId = PayShopModel.Instance.GetCurrentPayShopId();
		return PayShopModel.Instance.CheckPayShopTabHasRedDot((PayShopDefine.EPayShopTabType)currentPayShopId, uId);
	}

	// Token: 0x0601AAC4 RID: 109252 RVA: 0x008336E8 File Offset: 0x008318E8
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType payShopId, int tabId)
	{
		base.EventCheck();
	}

	// Token: 0x0601AAC5 RID: 109253 RVA: 0x008336F0 File Offset: 0x008318F0
	private void OnUnLockGoods(IReadOnlyDictionary<int, HashSet<int>> payShopMap)
	{
		base.EventCheck();
	}

	// Token: 0x0601AAC6 RID: 109254 RVA: 0x008336F8 File Offset: 0x008318F8
	private void OnRefreshPayShop(int payShopId, bool ifItemRefresh)
	{
		base.EventCheck();
	}

	// Token: 0x0601AAC7 RID: 109255 RVA: 0x00833700 File Offset: 0x00831900
	private void OnSwitchPayShopView(PayShopDefine.EPayShopTabType payShopId)
	{
		base.EventCheck();
	}

	// Token: 0x0601AAC8 RID: 109256 RVA: 0x00833708 File Offset: 0x00831908
	private void OnRefreshGoodsList(IReadOnlySet<int> tabSet)
	{
		base.EventCheck();
	}
}
