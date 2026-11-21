using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Infrastructure;

// Token: 0x02002920 RID: 10528
public class RedDotInfrShop : RedDotBase
{
	// Token: 0x0601A857 RID: 108631 RVA: 0x0082E4E9 File Offset: 0x0082C6E9
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.Infrastructure);
	}

	// Token: 0x0601A858 RID: 108632 RVA: 0x0082E4F8 File Offset: 0x0082C6F8
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Add(EEventName.InfrastructureShopRedDotUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.InfrastructureFireDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A859 RID: 108633 RVA: 0x0082E55C File Offset: 0x0082C75C
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Remove(EEventName.InfrastructureShopRedDotUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.InfrastructureFireDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A85A RID: 108634 RVA: 0x0082E5BD File Offset: 0x0082C7BD
	protected override bool OnCheck(int uId = 0)
	{
		return InfrastructureModel.Instance.GetShopHasNewRedDot();
	}

	// Token: 0x0601A85B RID: 108635 RVA: 0x0082E5C9 File Offset: 0x0082C7C9
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType payShopId, int tabId)
	{
		base.EventCheck();
	}
}
