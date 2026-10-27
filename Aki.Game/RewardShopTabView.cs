using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001362 RID: 4962
public class RewardShopTabView : UiTabViewBase
{
	// Token: 0x06008A41 RID: 35393 RVA: 0x001D8A8E File Offset: 0x001D6C8E
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06008A42 RID: 35394 RVA: 0x001D8AC7 File Offset: 0x001D6CC7
	protected override void OnStart()
	{
		this.LoopScrollView = new LoopScrollView<RewardShopGridItem, IPayShopUnionData>(base.GetLoopScrollViewComponent(0), (AUIBaseActor)base.GetItem(1).GetOwner(), new Func<RewardShopGridItem>(this.InitItem), false);
	}

	// Token: 0x06008A43 RID: 35395 RVA: 0x001D8AFC File Offset: 0x001D6CFC
	protected override UniTask OnShowAsyncImplementImplement()
	{
		RewardShopTabView.<OnShowAsyncImplementImplement>d__3 <OnShowAsyncImplementImplement>d__;
		<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnShowAsyncImplementImplement>d__.<>4__this = this;
		<OnShowAsyncImplementImplement>d__.<>1__state = -1;
		<OnShowAsyncImplementImplement>d__.<>t__builder.Start<RewardShopTabView.<OnShowAsyncImplementImplement>d__3>(ref <OnShowAsyncImplementImplement>d__);
		return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06008A44 RID: 35396 RVA: 0x001D8B40 File Offset: 0x001D6D40
	protected override void OnBeforeShow()
	{
		UiTabSequence tabBehavior = base.GetTabBehavior<UiTabSequence>();
		LevelSequencePlayer levelSequencePlayer = (tabBehavior != null) ? tabBehavior.GetLevelSequencePlayer() : null;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}
	}

	// Token: 0x06008A45 RID: 35397 RVA: 0x001D8B7A File Offset: 0x001D6D7A
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Add(EEventName.ShopVersionCodeChange, new Action(this.OnShopVersionCodeChange));
	}

	// Token: 0x06008A46 RID: 35398 RVA: 0x001D8BB4 File Offset: 0x001D6DB4
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Remove(EEventName.ShopVersionCodeChange, new Action(this.OnShopVersionCodeChange));
	}

	// Token: 0x06008A47 RID: 35399 RVA: 0x001D8BEE File Offset: 0x001D6DEE
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
	{
		this.LoopScrollView.RefreshAllGridProxies();
	}

	// Token: 0x06008A48 RID: 35400 RVA: 0x001D8BFC File Offset: 0x001D6DFC
	private void OnShopVersionCodeChange()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PayShopRefresh);
		Action value = delegate()
		{
			UiManager.Instance.CloseView(EUiViewName.RewardMainView, null);
		};
		confirmBoxDataNew.FunctionMap[1] = value;
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		Log.Instance.Info(ELogModule.Shop, ELogAuthor.XXJ, "PayShop:RewardShopTabView 商品VersionCode不同步,打开弹窗", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06008A49 RID: 35401 RVA: 0x001D8C69 File Offset: 0x001D6E69
	[NullableContext(1)]
	private RewardShopGridItem InitItem()
	{
		return new RewardShopGridItem();
	}

	// Token: 0x04003DA2 RID: 15778
	[Nullable(1)]
	protected LoopScrollView<RewardShopGridItem, IPayShopUnionData> LoopScrollView;

	// Token: 0x020079C7 RID: 31175
	private class EComponentDefine
	{
		// Token: 0x0402816D RID: 164205
		public const int Scroll = 0;

		// Token: 0x0402816E RID: 164206
		public const int RewardItem = 1;
	}
}
