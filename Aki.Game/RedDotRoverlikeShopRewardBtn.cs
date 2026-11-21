using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Roverlike;

// Token: 0x020028C2 RID: 10434
public class RedDotRoverlikeShopRewardBtn : RedDotBase
{
	// Token: 0x0601A6AC RID: 108204 RVA: 0x0082B130 File Offset: 0x00829330
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.PayShopGoodsBuy, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.OnRefreshPayShop));
		EventSystem.Instance.Add<IEnumerable<PayShopDefine.EPayShopTabType>>(EEventName.RefreshAllPayShop, new Action<IEnumerable<PayShopDefine.EPayShopTabType>>(this.OnRefreshAllPayShop));
		EventSystem.Instance.Add<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnPlayerCurrencyChange));
	}

	// Token: 0x0601A6AD RID: 108205 RVA: 0x0082B1B0 File Offset: 0x008293B0
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.PayShopGoodsBuy, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.OnRefreshPayShop));
		EventSystem.Instance.Remove<IEnumerable<PayShopDefine.EPayShopTabType>>(EEventName.RefreshAllPayShop, new Action<IEnumerable<PayShopDefine.EPayShopTabType>>(this.OnRefreshAllPayShop));
		EventSystem.Instance.Remove<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnPlayerCurrencyChange));
	}

	// Token: 0x0601A6AE RID: 108206 RVA: 0x0082B22D File Offset: 0x0082942D
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601A6AF RID: 108207 RVA: 0x0082B230 File Offset: 0x00829430
	private void OnRefreshPayShop(int payShopId, bool ifItemRefresh)
	{
		base.EventCheck();
	}

	// Token: 0x0601A6B0 RID: 108208 RVA: 0x0082B238 File Offset: 0x00829438
	[NullableContext(1)]
	private void OnRefreshAllPayShop(IEnumerable<PayShopDefine.EPayShopTabType> idList)
	{
		base.EventCheck();
	}

	// Token: 0x0601A6B1 RID: 108209 RVA: 0x0082B240 File Offset: 0x00829440
	private void OnPlayerCurrencyChange(int itemId)
	{
		base.EventCheck();
	}

	// Token: 0x0601A6B2 RID: 108210 RVA: 0x0082B248 File Offset: 0x00829448
	protected override bool OnCheck(int uId = 0)
	{
		RoverlikeActivityController instance = RoverlikeActivityController.Instance;
		RoverlikeActivityData roverlikeActivityData = (instance != null) ? instance.GetCurrentActivityData() : null;
		return roverlikeActivityData != null && roverlikeActivityData.HasShopRedDot();
	}
}
