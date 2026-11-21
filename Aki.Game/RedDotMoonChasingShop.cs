using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002939 RID: 10553
[NullableContext(1)]
[Nullable(0)]
public class RedDotMoonChasingShop : RedDotBase
{
	// Token: 0x0601A8C9 RID: 108745 RVA: 0x0082F38D File Offset: 0x0082D58D
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.MoonChasingRewardAndShop);
	}

	// Token: 0x0601A8CA RID: 108746 RVA: 0x0082F39C File Offset: 0x0082D59C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MoonChasingRefreshRewardRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.RefreshGoodsList, new Action<IReadOnlySet<int>>(this.OnRefreshGoodsList));
		EventSystem.Instance.Add<IReadOnlyDictionary<int, HashSet<int>>>(EEventName.UnLockGoods, new Action<IReadOnlyDictionary<int, HashSet<int>>>(this.OnUnLockGoods));
		EventSystem.Instance.Add<int>(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOut));
	}

	// Token: 0x0601A8CB RID: 108747 RVA: 0x0082F41C File Offset: 0x0082D61C
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MoonChasingRefreshRewardRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.RefreshGoodsList, new Action<IReadOnlySet<int>>(this.OnRefreshGoodsList));
		EventSystem.Instance.Remove<IReadOnlyDictionary<int, HashSet<int>>>(EEventName.UnLockGoods, new Action<IReadOnlyDictionary<int, HashSet<int>>>(this.OnUnLockGoods));
		EventSystem.Instance.Remove<int>(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOut));
	}

	// Token: 0x0601A8CC RID: 108748 RVA: 0x0082F499 File Offset: 0x0082D699
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601A8CD RID: 108749 RVA: 0x0082F49C File Offset: 0x0082D69C
	protected override bool OnCheck(int uId = 0)
	{
		ActivityMoonChasingController.Instance.RefreshActivityRedDot();
		return MoonChasingRewardModel.Instance.GetShopRedDotState();
	}

	// Token: 0x0601A8CE RID: 108750 RVA: 0x0082F4B2 File Offset: 0x0082D6B2
	private void OnGoodsSoldOut(int _)
	{
		base.EventCheck();
	}

	// Token: 0x0601A8CF RID: 108751 RVA: 0x0082F4BA File Offset: 0x0082D6BA
	private void OnUnLockGoods(IReadOnlyDictionary<int, HashSet<int>> payShopMap)
	{
		base.EventCheck();
	}

	// Token: 0x0601A8D0 RID: 108752 RVA: 0x0082F4C2 File Offset: 0x0082D6C2
	private void OnRefreshGoodsList(IReadOnlySet<int> tabSet)
	{
		base.EventCheck();
	}
}
