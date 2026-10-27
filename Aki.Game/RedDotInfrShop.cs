using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Infrastructure;

// Token: 0x020033AE RID: 13230
public class RedDotInfrShop : RedDotBase
{
	// Token: 0x0601CB5F RID: 117599 RVA: 0x00807F25 File Offset: 0x00806125
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.Infrastructure);
	}

	// Token: 0x0601CB60 RID: 117600 RVA: 0x00807F34 File Offset: 0x00806134
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Add(EEventName.InfrastructureShopRedDotUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.InfrastructureFireDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CB61 RID: 117601 RVA: 0x00807F98 File Offset: 0x00806198
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Remove(EEventName.InfrastructureShopRedDotUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.InfrastructureFireDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CB62 RID: 117602 RVA: 0x00807FF9 File Offset: 0x008061F9
	protected override bool OnCheck(int uId = 0)
	{
		return InfrastructureModel.Instance.GetShopHasNewRedDot();
	}

	// Token: 0x0601CB63 RID: 117603 RVA: 0x00808005 File Offset: 0x00806205
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType payShopId, int tabId)
	{
		base.EventCheck();
	}
}
