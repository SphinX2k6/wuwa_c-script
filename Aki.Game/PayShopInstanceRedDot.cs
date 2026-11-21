using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x0200299F RID: 10655
[NullableContext(1)]
[Nullable(0)]
public class PayShopInstanceRedDot : RedDotBase
{
	// Token: 0x0601AAB2 RID: 109234 RVA: 0x0083323A File Offset: 0x0083143A
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FunctionPayShop);
	}

	// Token: 0x0601AAB3 RID: 109235 RVA: 0x00833243 File Offset: 0x00831443
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601AAB4 RID: 109236 RVA: 0x00833246 File Offset: 0x00831446
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601AAB5 RID: 109237 RVA: 0x0083324C File Offset: 0x0083144C
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

	// Token: 0x0601AAB6 RID: 109238 RVA: 0x00833358 File Offset: 0x00831558
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

	// Token: 0x0601AAB7 RID: 109239 RVA: 0x00833461 File Offset: 0x00831661
	protected override bool OnCheck(int uId = 0)
	{
		return PayShopModel.Instance.CheckPayShopHasRedDot((PayShopDefine.EPayShopTabType)uId);
	}

	// Token: 0x0601AAB8 RID: 109240 RVA: 0x0083346E File Offset: 0x0083166E
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType payShopId, int tabId)
	{
		base.EventCheck();
	}

	// Token: 0x0601AAB9 RID: 109241 RVA: 0x00833476 File Offset: 0x00831676
	private void OnUnLockGoods(IReadOnlyDictionary<int, HashSet<int>> payShopMap)
	{
		base.EventCheck();
	}

	// Token: 0x0601AABA RID: 109242 RVA: 0x0083347E File Offset: 0x0083167E
	private void OnRefreshPayShop(int payShopId, bool ifItemRefresh)
	{
		base.EventCheck();
	}

	// Token: 0x0601AABB RID: 109243 RVA: 0x00833486 File Offset: 0x00831686
	private void OnRefreshAllPayShop(IEnumerable<PayShopDefine.EPayShopTabType> idList)
	{
		base.EventCheck();
	}

	// Token: 0x0601AABC RID: 109244 RVA: 0x0083348E File Offset: 0x0083168E
	private void OnRefreshGoodsList(IReadOnlySet<int> tabSet)
	{
		base.EventCheck();
	}

	// Token: 0x0601AABD RID: 109245 RVA: 0x00833496 File Offset: 0x00831696
	private void OnRefreshPayShopInstanceRedDot(PayShopDefine.EPayShopTabType payShopId)
	{
		base.EventCheck();
	}
}
