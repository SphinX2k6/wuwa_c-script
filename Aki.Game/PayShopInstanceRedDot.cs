using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x0200342D RID: 13357
[NullableContext(1)]
[Nullable(0)]
public class PayShopInstanceRedDot : RedDotBase
{
	// Token: 0x0601CDBA RID: 118202 RVA: 0x0080CC76 File Offset: 0x0080AE76
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FunctionPayShop);
	}

	// Token: 0x0601CDBB RID: 118203 RVA: 0x0080CC7F File Offset: 0x0080AE7F
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CDBC RID: 118204 RVA: 0x0080CC82 File Offset: 0x0080AE82
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601CDBD RID: 118205 RVA: 0x0080CC88 File Offset: 0x0080AE88
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.PayShopGoodsBuy, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.GoodsRefreshDiscountTime, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<IEnumerable<PayShopDefine.EPayShopTabType>>(EEventName.RefreshAllPayShop, new Action<IEnumerable<PayShopDefine.EPayShopTabType>>(this.OnRefreshAllPayShop));
		EventSystem.Instance.Add<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.OnRefreshPayShop));
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.RefreshGoodsList, new Action<IReadOnlySet<int>>(this.OnRefreshGoodsList));
		EventSystem.Instance.Add<IReadOnlyDictionary<int, HashSet<int>>>(EEventName.UnLockGoods, new Action<IReadOnlyDictionary<int, HashSet<int>>>(this.OnUnLockGoods));
		EventSystem.Instance.Add<PayShopDefine.EPayShopTabType>(EEventName.RefreshPayShopInstanceRedDot, new Action<PayShopDefine.EPayShopTabType>(this.OnRefreshPayShopInstanceRedDot));
		EventSystem.Instance.Add(EEventName.ReceiveWeekCardDataEvent, new Action(base.EventCheck));
	}

	// Token: 0x0601CDBE RID: 118206 RVA: 0x0080CD94 File Offset: 0x0080AF94
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.PayShopGoodsBuy, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.GoodsRefreshDiscountTime, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<IEnumerable<PayShopDefine.EPayShopTabType>>(EEventName.RefreshAllPayShop, new Action<IEnumerable<PayShopDefine.EPayShopTabType>>(this.OnRefreshAllPayShop));
		EventSystem.Instance.Remove<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.OnRefreshPayShop));
		EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.RefreshGoodsList, new Action<IReadOnlySet<int>>(this.OnRefreshGoodsList));
		EventSystem.Instance.Remove<IReadOnlyDictionary<int, HashSet<int>>>(EEventName.UnLockGoods, new Action<IReadOnlyDictionary<int, HashSet<int>>>(this.OnUnLockGoods));
		EventSystem.Instance.Remove<PayShopDefine.EPayShopTabType>(EEventName.RefreshPayShopInstanceRedDot, new Action<PayShopDefine.EPayShopTabType>(this.OnRefreshPayShopInstanceRedDot));
		EventSystem.Instance.Remove(EEventName.ReceiveWeekCardDataEvent, new Action(base.EventCheck));
	}

	// Token: 0x0601CDBF RID: 118207 RVA: 0x0080CE9D File Offset: 0x0080B09D
	protected override bool OnCheck(int uId = 0)
	{
		return PayShopModel.Instance.CheckPayShopHasRedDot((PayShopDefine.EPayShopTabType)uId);
	}

	// Token: 0x0601CDC0 RID: 118208 RVA: 0x0080CEAA File Offset: 0x0080B0AA
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType payShopId, int tabId)
	{
		base.EventCheck();
	}

	// Token: 0x0601CDC1 RID: 118209 RVA: 0x0080CEB2 File Offset: 0x0080B0B2
	private void OnUnLockGoods(IReadOnlyDictionary<int, HashSet<int>> payShopMap)
	{
		base.EventCheck();
	}

	// Token: 0x0601CDC2 RID: 118210 RVA: 0x0080CEBA File Offset: 0x0080B0BA
	private void OnRefreshPayShop(int payShopId, bool ifItemRefresh)
	{
		base.EventCheck();
	}

	// Token: 0x0601CDC3 RID: 118211 RVA: 0x0080CEC2 File Offset: 0x0080B0C2
	private void OnRefreshAllPayShop(IEnumerable<PayShopDefine.EPayShopTabType> idList)
	{
		base.EventCheck();
	}

	// Token: 0x0601CDC4 RID: 118212 RVA: 0x0080CECA File Offset: 0x0080B0CA
	private void OnRefreshGoodsList(IReadOnlySet<int> tabSet)
	{
		base.EventCheck();
	}

	// Token: 0x0601CDC5 RID: 118213 RVA: 0x0080CED2 File Offset: 0x0080B0D2
	private void OnRefreshPayShopInstanceRedDot(PayShopDefine.EPayShopTabType payShopId)
	{
		base.EventCheck();
	}
}
