using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020029A7 RID: 10663
[NullableContext(1)]
[Nullable(0)]
public class RedDotFurnitureEntrance : RedDotBase
{
	// Token: 0x0601AAE2 RID: 109282 RVA: 0x00833BC8 File Offset: 0x00831DC8
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

	// Token: 0x0601AAE3 RID: 109283 RVA: 0x00833C9C File Offset: 0x00831E9C
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

	// Token: 0x0601AAE4 RID: 109284 RVA: 0x00833D6D File Offset: 0x00831F6D
	protected override bool OnCheck(int uId = 0)
	{
		return FurnitureModel.Instance.CheckFurnitureEntranceRedDot();
	}

	// Token: 0x0601AAE5 RID: 109285 RVA: 0x00833D79 File Offset: 0x00831F79
	private void OnUnLockGoods(IReadOnlyDictionary<int, HashSet<int>> payShopMap)
	{
		base.EventCheck();
	}

	// Token: 0x0601AAE6 RID: 109286 RVA: 0x00833D81 File Offset: 0x00831F81
	private void OnRefreshAllPayShop(IEnumerable<PayShopDefine.EPayShopTabType> idList)
	{
		base.EventCheck();
	}

	// Token: 0x0601AAE7 RID: 109287 RVA: 0x00833D89 File Offset: 0x00831F89
	private void OnRefreshGoodsList(IReadOnlySet<int> tabSet)
	{
		base.EventCheck();
	}

	// Token: 0x0601AAE8 RID: 109288 RVA: 0x00833D91 File Offset: 0x00831F91
	private void OnPayShopConditionFinish(List<Aki.Protocol.PayShopItem> shopItemList)
	{
		base.EventCheck();
	}

	// Token: 0x0601AAE9 RID: 109289 RVA: 0x00833D99 File Offset: 0x00831F99
	private void OnFurnitureAreaUnlockNotify(int handleId, IReadOnlyList<AreaInfo> areaIds)
	{
		base.EventCheck();
	}
}
