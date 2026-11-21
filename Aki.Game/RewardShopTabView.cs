using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000816 RID: 2070
public class RewardShopTabView : UiTabViewBase
{
	// Token: 0x06005DDC RID: 24028 RVA: 0x001E18EA File Offset: 0x001DFAEA
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06005DDD RID: 24029 RVA: 0x001E1923 File Offset: 0x001DFB23
	protected override void OnStart()
	{
		this.LoopScrollView = new LoopScrollView<RewardShopGridItem, IPayShopUnionData>(base.GetLoopScrollViewComponent(0), (AUIBaseActor)base.GetItem(1).GetOwner(), new Func<RewardShopGridItem>(this.InitItem), false);
	}

	// Token: 0x06005DDE RID: 24030 RVA: 0x001E1958 File Offset: 0x001DFB58
	protected override UniTask OnShowAsyncImplementImplement()
	{
		RewardShopTabView.<OnShowAsyncImplementImplement>d__3 <OnShowAsyncImplementImplement>d__;
		<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnShowAsyncImplementImplement>d__.<>4__this = this;
		<OnShowAsyncImplementImplement>d__.<>1__state = -1;
		<OnShowAsyncImplementImplement>d__.<>t__builder.Start<RewardShopTabView.<OnShowAsyncImplementImplement>d__3>(ref <OnShowAsyncImplementImplement>d__);
		return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06005DDF RID: 24031 RVA: 0x001E199C File Offset: 0x001DFB9C
	protected override void OnBeforeShow()
	{
		UiTabSequence tabBehavior = base.GetTabBehavior<UiTabSequence>();
		LevelSequencePlayer levelSequencePlayer = (tabBehavior != null) ? tabBehavior.GetLevelSequencePlayer() : null;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}
	}

	// Token: 0x06005DE0 RID: 24032 RVA: 0x001E19D6 File Offset: 0x001DFBD6
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Add(EEventName.ShopVersionCodeChange, new Action(this.OnShopVersionCodeChange));
	}

	// Token: 0x06005DE1 RID: 24033 RVA: 0x001E1A10 File Offset: 0x001DFC10
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Remove(EEventName.ShopVersionCodeChange, new Action(this.OnShopVersionCodeChange));
	}

	// Token: 0x06005DE2 RID: 24034 RVA: 0x001E1A4A File Offset: 0x001DFC4A
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
	{
		this.LoopScrollView.RefreshAllGridProxies();
	}

	// Token: 0x06005DE3 RID: 24035 RVA: 0x001E1A58 File Offset: 0x001DFC58
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

	// Token: 0x06005DE4 RID: 24036 RVA: 0x001E1AC5 File Offset: 0x001DFCC5
	[NullableContext(1)]
	private RewardShopGridItem InitItem()
	{
		return new RewardShopGridItem();
	}

	// Token: 0x04003E3A RID: 15930
	[Nullable(1)]
	protected LoopScrollView<RewardShopGridItem, IPayShopUnionData> LoopScrollView;

	// Token: 0x02006B51 RID: 27473
	private class EComponentDefine
	{
		// Token: 0x0402349A RID: 144538
		public const int Scroll = 0;

		// Token: 0x0402349B RID: 144539
		public const int RewardItem = 1;
	}
}
