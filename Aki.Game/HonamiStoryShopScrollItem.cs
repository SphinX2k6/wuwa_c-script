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

// Token: 0x02001F02 RID: 7938
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryShopScrollItem<[Nullable(0)] TGrid> : UiPanelBase where TGrid : ActivityGrid
{
	// Token: 0x0600F468 RID: 62568 RVA: 0x003AF602 File Offset: 0x003AD802
	public HonamiStoryShopScrollItem(UUILoopScrollViewComponent scroller, UUIItem item, int sourceViewId, Func<TGrid> gridConstructor)
	{
		this.Scroller = scroller;
		this.Item = item;
		this.SourceViewId = sourceViewId;
		this.GridConstructor = gridConstructor;
	}

	// Token: 0x0600F469 RID: 62569 RVA: 0x003AF627 File Offset: 0x003AD827
	public void AddEventListener()
	{
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Add(EEventName.ShopVersionCodeChange, new Action(this.OnShopVersionCodeChange));
	}

	// Token: 0x0600F46A RID: 62570 RVA: 0x003AF661 File Offset: 0x003AD861
	public void RemoveEventListener()
	{
		EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Remove(EEventName.ShopVersionCodeChange, new Action(this.OnShopVersionCodeChange));
	}

	// Token: 0x0600F46B RID: 62571 RVA: 0x003AF69C File Offset: 0x003AD89C
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
	{
		List<IPayShopUnionData> canBuyDataList = this.GetCanBuyDataList(shopId);
		this.LoopScrollView.RefreshByDataAsync(canBuyDataList, false, true).Forget();
	}

	// Token: 0x0600F46C RID: 62572 RVA: 0x003AF6C4 File Offset: 0x003AD8C4
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

	// Token: 0x0600F46D RID: 62573 RVA: 0x003AF721 File Offset: 0x003AD921
	protected override void OnStart()
	{
		this.LoopScrollView = new LoopScrollView<TGrid, IPayShopUnionData>(this.Scroller, this.Item.GetOwner() as AUIBaseActor, new Func<TGrid>(this.InitItem), false);
		this.AddEventListener();
	}

	// Token: 0x0600F46E RID: 62574 RVA: 0x003AF757 File Offset: 0x003AD957
	private TGrid InitItem()
	{
		return this.GridConstructor();
	}

	// Token: 0x0600F46F RID: 62575 RVA: 0x003AF764 File Offset: 0x003AD964
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

	// Token: 0x0600F470 RID: 62576 RVA: 0x003AF7D0 File Offset: 0x003AD9D0
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

	// Token: 0x0600F471 RID: 62577 RVA: 0x003AF81B File Offset: 0x003ADA1B
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
	}

	// Token: 0x04007119 RID: 28953
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<TGrid, IPayShopUnionData> LoopScrollView;

	// Token: 0x0400711A RID: 28954
	private readonly UUILoopScrollViewComponent Scroller;

	// Token: 0x0400711B RID: 28955
	private readonly UUIItem Item;

	// Token: 0x0400711C RID: 28956
	private readonly int SourceViewId;

	// Token: 0x0400711D RID: 28957
	private readonly Func<TGrid> GridConstructor;
}
