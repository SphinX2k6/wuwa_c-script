using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x0200342E RID: 13358
[NullableContext(1)]
[Nullable(0)]
public class PayShopTabRedDot : RedDotBase
{
	// Token: 0x0601CDC7 RID: 118215 RVA: 0x0080CEE2 File Offset: 0x0080B0E2
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CDC8 RID: 118216 RVA: 0x0080CEE5 File Offset: 0x0080B0E5
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601CDC9 RID: 118217 RVA: 0x0080CEE8 File Offset: 0x0080B0E8
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

	// Token: 0x0601CDCA RID: 118218 RVA: 0x0080CFF4 File Offset: 0x0080B1F4
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

	// Token: 0x0601CDCB RID: 118219 RVA: 0x0080D100 File Offset: 0x0080B300
	protected override bool OnCheck(int uId = 0)
	{
		int currentPayShopId = PayShopModel.Instance.GetCurrentPayShopId();
		return PayShopModel.Instance.CheckPayShopTabHasRedDot((PayShopDefine.EPayShopTabType)currentPayShopId, uId);
	}

	// Token: 0x0601CDCC RID: 118220 RVA: 0x0080D124 File Offset: 0x0080B324
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType payShopId, int tabId)
	{
		base.EventCheck();
	}

	// Token: 0x0601CDCD RID: 118221 RVA: 0x0080D12C File Offset: 0x0080B32C
	private void OnUnLockGoods(IReadOnlyDictionary<int, HashSet<int>> payShopMap)
	{
		base.EventCheck();
	}

	// Token: 0x0601CDCE RID: 118222 RVA: 0x0080D134 File Offset: 0x0080B334
	private void OnRefreshPayShop(int payShopId, bool ifItemRefresh)
	{
		base.EventCheck();
	}

	// Token: 0x0601CDCF RID: 118223 RVA: 0x0080D13C File Offset: 0x0080B33C
	private void OnSwitchPayShopView(PayShopDefine.EPayShopTabType payShopId)
	{
		base.EventCheck();
	}

	// Token: 0x0601CDD0 RID: 118224 RVA: 0x0080D144 File Offset: 0x0080B344
	private void OnRefreshGoodsList(IReadOnlySet<int> tabSet)
	{
		base.EventCheck();
	}
}
