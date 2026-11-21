using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020013C4 RID: 5060
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryShopScrollItem<[Nullable(0)] TGrid> : UiPanelBase where TGrid : ActivityGrid
{
	// Token: 0x0600C887 RID: 51335 RVA: 0x003BB0F6 File Offset: 0x003B92F6
	public HonamiStoryShopScrollItem(UUILoopScrollViewComponent scroller, UUIItem item, int sourceViewId, Func<TGrid> gridConstructor)
	{
		this.Scroller = scroller;
		this.Item = item;
		this.SourceViewId = sourceViewId;
		this.GridConstructor = gridConstructor;
	}

	// Token: 0x0600C888 RID: 51336 RVA: 0x003BB11B File Offset: 0x003B931B
	public void AddEventListener()
	{
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Add(EEventName.ShopVersionCodeChange, new Action(this.OnShopVersionCodeChange));
	}

	// Token: 0x0600C889 RID: 51337 RVA: 0x003BB155 File Offset: 0x003B9355
	public void RemoveEventListener()
	{
		EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Remove(EEventName.ShopVersionCodeChange, new Action(this.OnShopVersionCodeChange));
	}

	// Token: 0x0600C88A RID: 51338 RVA: 0x003BB190 File Offset: 0x003B9390
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
	{
		List<IPayShopUnionData> canBuyDataList = this.GetCanBuyDataList(shopId);
		this.LoopScrollView.RefreshByDataAsync(canBuyDataList, false, true).Forget();
	}

	// Token: 0x0600C88B RID: 51339 RVA: 0x003BB1B8 File Offset: 0x003B93B8
	private void OnShopVersionCodeChange()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PayShopRefresh);
		Action value = delegate()
		{
			UiManager.Instance.CloseViewById(this.SourceViewId, null);
		};
		confirmBoxDataNew.FunctionMap.Add(1, value);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		Log.Instance.Info(ELogModule.Activity, ELogAuthor.YZY, "PayShop:DockyardBuyTabView 商品VersionCode不同步,打开弹窗", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0600C88C RID: 51340 RVA: 0x003BB215 File Offset: 0x003B9415
	protected override void OnStart()
	{
		this.LoopScrollView = new LoopScrollView<TGrid, IPayShopUnionData>(this.Scroller, this.Item.GetOwner() as AUIBaseActor, new Func<TGrid>(this.InitItem), false);
		this.AddEventListener();
	}

	// Token: 0x0600C88D RID: 51341 RVA: 0x003BB24B File Offset: 0x003B944B
	private TGrid InitItem()
	{
		return this.GridConstructor();
	}

	// Token: 0x0600C88E RID: 51342 RVA: 0x003BB258 File Offset: 0x003B9458
	private List<IPayShopUnionData> GetCanBuyDataList(PayShopDefine.EPayShopTabType shopId)
	{
		List<PayShopGoods> payShopTabData = PayShopModel.Instance.GetPayShopTabData(shopId, 1, true);
		List<IPayShopUnionData> list = new List<IPayShopUnionData>();
		foreach (PayShopGoods payShopGoods in payShopTabData)
		{
			if (payShopGoods.IfCanBuy())
			{
				list.Add(payShopGoods);
			}
		}
		return list;
	}

	// Token: 0x0600C88F RID: 51343 RVA: 0x003BB2C4 File Offset: 0x003B94C4
	public UniTask Refresh(int shopId)
	{
		HonamiStoryShopScrollItem<TGrid>.<Refresh>d__13 <Refresh>d__;
		<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Refresh>d__.<>4__this = this;
		<Refresh>d__.shopId = shopId;
		<Refresh>d__.<>1__state = -1;
		<Refresh>d__.<>t__builder.Start<HonamiStoryShopScrollItem<TGrid>.<Refresh>d__13>(ref <Refresh>d__);
		return <Refresh>d__.<>t__builder.Task;
	}

	// Token: 0x0600C890 RID: 51344 RVA: 0x003BB30F File Offset: 0x003B950F
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
	}

	// Token: 0x040071FA RID: 29178
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<TGrid, IPayShopUnionData> LoopScrollView;

	// Token: 0x040071FB RID: 29179
	private readonly UUILoopScrollViewComponent Scroller;

	// Token: 0x040071FC RID: 29180
	private readonly UUIItem Item;

	// Token: 0x040071FD RID: 29181
	private readonly int SourceViewId;

	// Token: 0x040071FE RID: 29182
	private readonly Func<TGrid> GridConstructor;
}
