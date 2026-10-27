using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity;

// Token: 0x0200340F RID: 13327
[NullableContext(1)]
[Nullable(0)]
public class RedDotRoguelikeShop : RedDotBase
{
	// Token: 0x0601CD29 RID: 118057 RVA: 0x0080B5F8 File Offset: 0x008097F8
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RoguelikeDataUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add<IEnumerable<PayShopDefine.EPayShopTabType>>(EEventName.RefreshAllPayShop, new Action<IEnumerable<PayShopDefine.EPayShopTabType>>(this.OnRefreshAllPayShop));
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.RefreshGoodsList, new Action<IReadOnlySet<int>>(this.OnRefreshGoodsList));
		EventSystem.Instance.Add<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.OnRefreshPayShop));
		EventSystem.Instance.Add(EEventName.CrossDay, new Action(base.EventCheck));
	}

	// Token: 0x0601CD2A RID: 118058 RVA: 0x0080B6B0 File Offset: 0x008098B0
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RoguelikeDataUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove<IEnumerable<PayShopDefine.EPayShopTabType>>(EEventName.RefreshAllPayShop, new Action<IEnumerable<PayShopDefine.EPayShopTabType>>(this.OnRefreshAllPayShop));
		EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.RefreshGoodsList, new Action<IReadOnlySet<int>>(this.OnRefreshGoodsList));
		EventSystem.Instance.Remove<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.OnRefreshPayShop));
		EventSystem.Instance.Remove(EEventName.CrossDay, new Action(base.EventCheck));
	}

	// Token: 0x0601CD2B RID: 118059 RVA: 0x0080B765 File Offset: 0x00809965
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601CD2C RID: 118060 RVA: 0x0080B768 File Offset: 0x00809968
	protected override bool OnCheck(int uId = 0)
	{
		ActivityRogueController.Instance.RefreshActivityRedDot();
		return RoguelikeModel.Instance.CheckRoguelikeShopRedDot();
	}

	// Token: 0x0601CD2D RID: 118061 RVA: 0x0080B77E File Offset: 0x0080997E
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType payShopId, int tabId)
	{
		base.EventCheck();
	}

	// Token: 0x0601CD2E RID: 118062 RVA: 0x0080B786 File Offset: 0x00809986
	private void OnRefreshPayShop(int payShopId, bool ifItemRefresh)
	{
		base.EventCheck();
	}

	// Token: 0x0601CD2F RID: 118063 RVA: 0x0080B78E File Offset: 0x0080998E
	private void OnRefreshAllPayShop(IEnumerable<PayShopDefine.EPayShopTabType> idList)
	{
		base.EventCheck();
	}

	// Token: 0x0601CD30 RID: 118064 RVA: 0x0080B796 File Offset: 0x00809996
	private void OnRefreshGoodsList(IReadOnlySet<int> tabSet)
	{
		base.EventCheck();
	}
}
