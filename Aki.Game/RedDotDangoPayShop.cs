using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x0200337D RID: 13181
[NullableContext(1)]
[Nullable(0)]
public class RedDotDangoPayShop : RedDotBase
{
	// Token: 0x0601CA80 RID: 117376 RVA: 0x0080642B File Offset: 0x0080462B
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601CA81 RID: 117377 RVA: 0x00806430 File Offset: 0x00804630
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
	}

	// Token: 0x0601CA82 RID: 117378 RVA: 0x00806520 File Offset: 0x00804720
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
	}

	// Token: 0x0601CA83 RID: 117379 RVA: 0x0080660D File Offset: 0x0080480D
	protected override bool OnCheck(int uId = 0)
	{
		return DangoAbyssModel.Instance.CheckPayShopRedDot();
	}

	// Token: 0x0601CA84 RID: 117380 RVA: 0x00806619 File Offset: 0x00804819
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType payShopId, int tabId)
	{
		base.EventCheck();
	}

	// Token: 0x0601CA85 RID: 117381 RVA: 0x00806621 File Offset: 0x00804821
	private void OnUnLockGoods(IReadOnlyDictionary<int, HashSet<int>> payShopMap)
	{
		base.EventCheck();
	}

	// Token: 0x0601CA86 RID: 117382 RVA: 0x00806629 File Offset: 0x00804829
	private void OnRefreshPayShop(int payShopId, bool ifItemRefresh)
	{
		base.EventCheck();
	}

	// Token: 0x0601CA87 RID: 117383 RVA: 0x00806631 File Offset: 0x00804831
	private void OnRefreshAllPayShop(IEnumerable<PayShopDefine.EPayShopTabType> idList)
	{
		base.EventCheck();
	}

	// Token: 0x0601CA88 RID: 117384 RVA: 0x00806639 File Offset: 0x00804839
	private void OnRefreshGoodsList(IReadOnlySet<int> tabSet)
	{
		base.EventCheck();
	}

	// Token: 0x0601CA89 RID: 117385 RVA: 0x00806641 File Offset: 0x00804841
	private void OnRefreshPayShopInstanceRedDot(PayShopDefine.EPayShopTabType obj)
	{
		base.EventCheck();
	}
}
