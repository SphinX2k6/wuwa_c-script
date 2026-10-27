using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020033C7 RID: 13255
[NullableContext(1)]
[Nullable(0)]
public class RedDotMoonChasingShop : RedDotBase
{
	// Token: 0x0601CBD1 RID: 117713 RVA: 0x00808DC9 File Offset: 0x00806FC9
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.MoonChasingRewardAndShop);
	}

	// Token: 0x0601CBD2 RID: 117714 RVA: 0x00808DD8 File Offset: 0x00806FD8
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.MoonChasingRefreshRewardRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.RefreshGoodsList, new Action<IReadOnlySet<int>>(this.OnRefreshGoodsList));
		EventSystem.Instance.Add<IReadOnlyDictionary<int, HashSet<int>>>(EEventName.UnLockGoods, new Action<IReadOnlyDictionary<int, HashSet<int>>>(this.OnUnLockGoods));
		EventSystem.Instance.Add<int>(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOut));
	}

	// Token: 0x0601CBD3 RID: 117715 RVA: 0x00808E58 File Offset: 0x00807058
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.MoonChasingRefreshRewardRedDot, new Action(base.EventCheck));
		EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.RefreshGoodsList, new Action<IReadOnlySet<int>>(this.OnRefreshGoodsList));
		EventSystem.Instance.Remove<IReadOnlyDictionary<int, HashSet<int>>>(EEventName.UnLockGoods, new Action<IReadOnlyDictionary<int, HashSet<int>>>(this.OnUnLockGoods));
		EventSystem.Instance.Remove<int>(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOut));
	}

	// Token: 0x0601CBD4 RID: 117716 RVA: 0x00808ED5 File Offset: 0x008070D5
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601CBD5 RID: 117717 RVA: 0x00808ED8 File Offset: 0x008070D8
	protected override bool OnCheck(int uId = 0)
	{
		ActivityMoonChasingController.Instance.RefreshActivityRedDot();
		return MoonChasingRewardModel.Instance.GetShopRedDotState();
	}

	// Token: 0x0601CBD6 RID: 117718 RVA: 0x00808EEE File Offset: 0x008070EE
	private void OnGoodsSoldOut(int _)
	{
		base.EventCheck();
	}

	// Token: 0x0601CBD7 RID: 117719 RVA: 0x00808EF6 File Offset: 0x008070F6
	private void OnUnLockGoods(IReadOnlyDictionary<int, HashSet<int>> payShopMap)
	{
		base.EventCheck();
	}

	// Token: 0x0601CBD8 RID: 117720 RVA: 0x00808EFE File Offset: 0x008070FE
	private void OnRefreshGoodsList(IReadOnlySet<int> tabSet)
	{
		base.EventCheck();
	}
}
