using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Roverlike;

// Token: 0x02003350 RID: 13136
public class RedDotRoverlikeShopRewardBtn : RedDotBase
{
	// Token: 0x0601C9B4 RID: 117172 RVA: 0x00804B6C File Offset: 0x00802D6C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.PayShopGoodsBuy, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.OnRefreshPayShop));
		EventSystem.Instance.Add<IEnumerable<PayShopDefine.EPayShopTabType>>(EEventName.RefreshAllPayShop, new Action<IEnumerable<PayShopDefine.EPayShopTabType>>(this.OnRefreshAllPayShop));
		EventSystem.Instance.Add<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnPlayerCurrencyChange));
	}

	// Token: 0x0601C9B5 RID: 117173 RVA: 0x00804BEC File Offset: 0x00802DEC
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.PayShopGoodsBuy, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.OnRefreshPayShop));
		EventSystem.Instance.Remove<IEnumerable<PayShopDefine.EPayShopTabType>>(EEventName.RefreshAllPayShop, new Action<IEnumerable<PayShopDefine.EPayShopTabType>>(this.OnRefreshAllPayShop));
		EventSystem.Instance.Remove<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnPlayerCurrencyChange));
	}

	// Token: 0x0601C9B6 RID: 117174 RVA: 0x00804C69 File Offset: 0x00802E69
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601C9B7 RID: 117175 RVA: 0x00804C6C File Offset: 0x00802E6C
	private void OnRefreshPayShop(int payShopId, bool ifItemRefresh)
	{
		base.EventCheck();
	}

	// Token: 0x0601C9B8 RID: 117176 RVA: 0x00804C74 File Offset: 0x00802E74
	[NullableContext(1)]
	private void OnRefreshAllPayShop(IEnumerable<PayShopDefine.EPayShopTabType> idList)
	{
		base.EventCheck();
	}

	// Token: 0x0601C9B9 RID: 117177 RVA: 0x00804C7C File Offset: 0x00802E7C
	private void OnPlayerCurrencyChange(int itemId)
	{
		base.EventCheck();
	}

	// Token: 0x0601C9BA RID: 117178 RVA: 0x00804C84 File Offset: 0x00802E84
	protected override bool OnCheck(int uId = 0)
	{
		RoverlikeActivityController instance = RoverlikeActivityController.Instance;
		RoverlikeActivityData roverlikeActivityData = (instance != null) ? instance.GetCurrentActivityData() : null;
		return roverlikeActivityData != null && roverlikeActivityData.HasShopRedDot();
	}
}
