using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011EA RID: 4586
[NullableContext(1)]
[Nullable(0)]
public class ActivityShopScrollItem<[Nullable(0)] TGrid> : UiPanelBase where TGrid : IActivityGrid
{
	// Token: 0x06007A75 RID: 31349 RVA: 0x0019C923 File Offset: 0x0019AB23
	public ActivityShopScrollItem(UUILoopScrollViewComponent scroller, UUIItem item, int sourceViewId, Func<TGrid> gridConstructor)
	{
		this.Scroller = scroller;
		this.Item = item;
		this.SourceViewId = sourceViewId;
		this.GridConstructor = gridConstructor;
	}

	// Token: 0x06007A76 RID: 31350 RVA: 0x0019C948 File Offset: 0x0019AB48
	public void AddEventListener()
	{
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Add(EEventName.ShopVersionCodeChange, new Action(this.OnShopVersionCodeChange));
	}

	// Token: 0x06007A77 RID: 31351 RVA: 0x0019C982 File Offset: 0x0019AB82
	public void RemoveEventListener()
	{
		EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Remove(EEventName.ShopVersionCodeChange, new Action(this.OnShopVersionCodeChange));
	}

	// Token: 0x06007A78 RID: 31352 RVA: 0x0019C9BC File Offset: 0x0019ABBC
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
	{
		List<PayShopGoods> payShopTabData = PayShopModel.Instance.GetPayShopTabData(shopId, 1, true);
		this.LoopScrollView.RefreshByDataAsync(payShopTabData.Cast<IPayShopUnionData>().ToList<IPayShopUnionData>(), false, true).Forget();
	}

	// Token: 0x06007A79 RID: 31353 RVA: 0x0019C9F4 File Offset: 0x0019ABF4
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

	// Token: 0x06007A7A RID: 31354 RVA: 0x0019CA51 File Offset: 0x0019AC51
	protected override void OnStart()
	{
		this.LoopScrollView = new LoopScrollView<ActivityGrid, IPayShopUnionData>(this.Scroller, this.Item.GetOwner() as AUIBaseActor, new Func<ActivityGrid>(this.InitItem), false);
		this.AddEventListener();
	}

	// Token: 0x06007A7B RID: 31355 RVA: 0x0019CA87 File Offset: 0x0019AC87
	private ActivityGrid InitItem()
	{
		return this.GridConstructor() as ActivityGrid;
	}

	// Token: 0x06007A7C RID: 31356 RVA: 0x0019CAA0 File Offset: 0x0019ACA0
	public UniTask Refresh(int shopId)
	{
		ActivityShopScrollItem<TGrid>.<Refresh>d__12 <Refresh>d__;
		<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Refresh>d__.<>4__this = this;
		<Refresh>d__.shopId = shopId;
		<Refresh>d__.<>1__state = -1;
		<Refresh>d__.<>t__builder.Start<ActivityShopScrollItem<TGrid>.<Refresh>d__12>(ref <Refresh>d__);
		return <Refresh>d__.<>t__builder.Task;
	}

	// Token: 0x06007A7D RID: 31357 RVA: 0x0019CAEB File Offset: 0x0019ACEB
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
	}

	// Token: 0x0400381E RID: 14366
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<ActivityGrid, IPayShopUnionData> LoopScrollView;

	// Token: 0x0400381F RID: 14367
	private readonly UUILoopScrollViewComponent Scroller;

	// Token: 0x04003820 RID: 14368
	private readonly UUIItem Item;

	// Token: 0x04003821 RID: 14369
	private readonly int SourceViewId;

	// Token: 0x04003822 RID: 14370
	private readonly Func<TGrid> GridConstructor;
}
