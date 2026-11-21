using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity;

// Token: 0x02002981 RID: 10625
[NullableContext(1)]
[Nullable(0)]
public class RedDotRoguelikeShop : RedDotBase
{
	// Token: 0x0601AA21 RID: 109089 RVA: 0x00831BBC File Offset: 0x0082FDBC
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RoguelikeDataUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add<IEnumerable<PayShopDefine.EPayShopTabType>>(EEventName.RefreshAllPayShop, new Action<IEnumerable<PayShopDefine.EPayShopTabType>>(this.OnRefreshAllPayShop));
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.RefreshGoodsList, new Action<IReadOnlySet<int>>(this.OnRefreshGoodsList));
		EventSystem.Instance.Add<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.OnRefreshPayShop));
		EventSystem.Instance.Add(EEventName.CrossDay, new Action(base.EventCheck));
	}

	// Token: 0x0601AA22 RID: 109090 RVA: 0x00831C74 File Offset: 0x0082FE74
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RoguelikeDataUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove<IEnumerable<PayShopDefine.EPayShopTabType>>(EEventName.RefreshAllPayShop, new Action<IEnumerable<PayShopDefine.EPayShopTabType>>(this.OnRefreshAllPayShop));
		EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.RefreshGoodsList, new Action<IReadOnlySet<int>>(this.OnRefreshGoodsList));
		EventSystem.Instance.Remove<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.OnRefreshPayShop));
		EventSystem.Instance.Remove(EEventName.CrossDay, new Action(base.EventCheck));
	}

	// Token: 0x0601AA23 RID: 109091 RVA: 0x00831D29 File Offset: 0x0082FF29
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601AA24 RID: 109092 RVA: 0x00831D2C File Offset: 0x0082FF2C
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRogueController.Instance.RefreshActivityRedDot();
		return RoguelikeModel.Instance.CheckRoguelikeShopRedDot();
	}

	// Token: 0x0601AA25 RID: 109093 RVA: 0x00831D42 File Offset: 0x0082FF42
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType payShopId, int tabId)
	{
		base.EventCheck();
	}

	// Token: 0x0601AA26 RID: 109094 RVA: 0x00831D4A File Offset: 0x0082FF4A
	private void OnRefreshPayShop(int payShopId, bool ifItemRefresh)
	{
		base.EventCheck();
	}

	// Token: 0x0601AA27 RID: 109095 RVA: 0x00831D52 File Offset: 0x0082FF52
	private void OnRefreshAllPayShop(IEnumerable<PayShopDefine.EPayShopTabType> idList)
	{
		base.EventCheck();
	}

	// Token: 0x0601AA28 RID: 109096 RVA: 0x00831D5A File Offset: 0x0082FF5A
	private void OnRefreshGoodsList(IReadOnlySet<int> tabSet)
	{
		base.EventCheck();
	}
}
