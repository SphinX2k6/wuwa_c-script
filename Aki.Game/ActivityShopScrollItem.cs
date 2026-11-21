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

// Token: 0x0200069E RID: 1694
[NullableContext(1)]
[Nullable(0)]
public class ActivityShopScrollItem<[Nullable(0)] TGrid> : UiPanelBase where TGrid : IActivityGrid
{
	// Token: 0x06004E0C RID: 19980 RVA: 0x001A55CF File Offset: 0x001A37CF
	public ActivityShopScrollItem(UUILoopScrollViewComponent scroller, UUIItem item, int sourceViewId, Func<TGrid> gridConstructor)
	{
		this.Scroller = scroller;
		this.Item = item;
		this.SourceViewId = sourceViewId;
		this.GridConstructor = gridConstructor;
	}

	// Token: 0x06004E0D RID: 19981 RVA: 0x001A55F4 File Offset: 0x001A37F4
	public void AddEventListener()
	{
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Add(EEventName.ShopVersionCodeChange, new Action(this.OnShopVersionCodeChange));
	}

	// Token: 0x06004E0E RID: 19982 RVA: 0x001A562E File Offset: 0x001A382E
	public void RemoveEventListener()
	{
		EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Remove(EEventName.ShopVersionCodeChange, new Action(this.OnShopVersionCodeChange));
	}

	// Token: 0x06004E0F RID: 19983 RVA: 0x001A5668 File Offset: 0x001A3868
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
	{
		List<PayShopGoods> payShopTabData = PayShopModel.Instance.GetPayShopTabData(shopId, 1, true);
		this.LoopScrollView.RefreshByDataAsync(new List<IPayShopUnionData>(payShopTabData), false, true).Forget();
	}

	// Token: 0x06004E10 RID: 19984 RVA: 0x001A569C File Offset: 0x001A389C
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

	// Token: 0x06004E11 RID: 19985 RVA: 0x001A56F9 File Offset: 0x001A38F9
	protected override void OnStart()
	{
		this.LoopScrollView = new LoopScrollView<ActivityGrid, IPayShopUnionData>(this.Scroller, this.Item.GetOwner() as AUIBaseActor, new Func<ActivityGrid>(this.InitItem), false);
		this.AddEventListener();
	}

	// Token: 0x06004E12 RID: 19986 RVA: 0x001A572F File Offset: 0x001A392F
	private ActivityGrid InitItem()
	{
		return this.GridConstructor() as ActivityGrid;
	}

	// Token: 0x06004E13 RID: 19987 RVA: 0x001A5748 File Offset: 0x001A3948
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

	// Token: 0x06004E14 RID: 19988 RVA: 0x001A5793 File Offset: 0x001A3993
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
	}

	// Token: 0x040038B7 RID: 14519
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<ActivityGrid, IPayShopUnionData> LoopScrollView;

	// Token: 0x040038B8 RID: 14520
	private readonly UUILoopScrollViewComponent Scroller;

	// Token: 0x040038B9 RID: 14521
	private readonly UUIItem Item;

	// Token: 0x040038BA RID: 14522
	private readonly int SourceViewId;

	// Token: 0x040038BB RID: 14523
	private readonly Func<TGrid> GridConstructor;
}
