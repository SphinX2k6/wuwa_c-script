using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02003433 RID: 13363
[NullableContext(1)]
[Nullable(0)]
public class RedDotFurnitureEntrance : RedDotBase
{
	// Token: 0x0601CDE2 RID: 118242 RVA: 0x0080D4E0 File Offset: 0x0080B6E0
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.UpdateFurnitureEntranceRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.RefreshGoodsList, new Action<IReadOnlySet<int>>(this.OnRefreshGoodsList));
		EventSystem.Instance.Add<IEnumerable<PayShopDefine.EPayShopTabType>>(EEventName.RefreshAllPayShop, new Action<IEnumerable<PayShopDefine.EPayShopTabType>>(this.OnRefreshAllPayShop));
		EventSystem.Instance.Add<List<Aki.Protocol.PayShopItem>>(EEventName.OnPayShopConditionFinish, new Action<List<Aki.Protocol.PayShopItem>>(this.OnPayShopConditionFinish));
		EventSystem.Instance.Add<IReadOnlyDictionary<int, HashSet<int>>>(EEventName.UnLockGoods, new Action<IReadOnlyDictionary<int, HashSet<int>>>(this.OnUnLockGoods));
		EventSystem.Instance.Add<int>(EEventName.FurnitureFunctionOpenNotify, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int, IReadOnlyList<AreaInfo>>(EEventName.OnFurnitureAreaUnlockNotify, new Action<int, IReadOnlyList<AreaInfo>>(this.OnFurnitureAreaUnlockNotify));
	}

	// Token: 0x0601CDE3 RID: 118243 RVA: 0x0080D5B4 File Offset: 0x0080B7B4
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.UpdateFurnitureEntranceRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.RefreshGoodsList, new Action<IReadOnlySet<int>>(this.OnRefreshGoodsList));
		EventSystem.Instance.Remove<IEnumerable<PayShopDefine.EPayShopTabType>>(EEventName.RefreshAllPayShop, new Action<IEnumerable<PayShopDefine.EPayShopTabType>>(this.OnRefreshAllPayShop));
		EventSystem.Instance.Remove<List<Aki.Protocol.PayShopItem>>(EEventName.OnPayShopConditionFinish, new Action<List<Aki.Protocol.PayShopItem>>(this.OnPayShopConditionFinish));
		EventSystem.Instance.Remove<IReadOnlyDictionary<int, HashSet<int>>>(EEventName.UnLockGoods, new Action<IReadOnlyDictionary<int, HashSet<int>>>(this.OnUnLockGoods));
		EventSystem.Instance.Remove<int>(EEventName.FurnitureFunctionOpenNotify, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int, IReadOnlyList<AreaInfo>>(EEventName.OnFurnitureAreaUnlockNotify, new Action<int, IReadOnlyList<AreaInfo>>(this.OnFurnitureAreaUnlockNotify));
	}

	// Token: 0x0601CDE4 RID: 118244 RVA: 0x0080D685 File Offset: 0x0080B885
	protected override bool OnCheck(int uId = 0)
	{
		return FurnitureModel.Instance.CheckFurnitureEntranceRedDot();
	}

	// Token: 0x0601CDE5 RID: 118245 RVA: 0x0080D691 File Offset: 0x0080B891
	private void OnUnLockGoods(IReadOnlyDictionary<int, HashSet<int>> payShopMap)
	{
		base.EventCheck();
	}

	// Token: 0x0601CDE6 RID: 118246 RVA: 0x0080D699 File Offset: 0x0080B899
	private void OnRefreshAllPayShop(IEnumerable<PayShopDefine.EPayShopTabType> idList)
	{
		base.EventCheck();
	}

	// Token: 0x0601CDE7 RID: 118247 RVA: 0x0080D6A1 File Offset: 0x0080B8A1
	private void OnRefreshGoodsList(IReadOnlySet<int> tabSet)
	{
		base.EventCheck();
	}

	// Token: 0x0601CDE8 RID: 118248 RVA: 0x0080D6A9 File Offset: 0x0080B8A9
	private void OnPayShopConditionFinish(List<Aki.Protocol.PayShopItem> shopItemList)
	{
		base.EventCheck();
	}

	// Token: 0x0601CDE9 RID: 118249 RVA: 0x0080D6B1 File Offset: 0x0080B8B1
	private void OnFurnitureAreaUnlockNotify(int handleId, IReadOnlyList<AreaInfo> areaIds)
	{
		base.EventCheck();
	}
}
