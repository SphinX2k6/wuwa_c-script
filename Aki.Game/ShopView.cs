using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029F4 RID: 10740
[NullableContext(2)]
[Nullable(0)]
public class ShopView : UiTickViewBase, IUiCameraBehavior
{
	// Token: 0x17001DBF RID: 7615
	// (get) Token: 0x0601645D RID: 91229 RVA: 0x005A1E82 File Offset: 0x005A0082
	public Shop ShopInfo
	{
		get
		{
			return ShopModel.Instance.GetShopInfo(this.ShopId);
		}
	}

	// Token: 0x17001DC0 RID: 7616
	// (get) Token: 0x0601645E RID: 91230 RVA: 0x005A1E94 File Offset: 0x005A0094
	private uint? RefreshTime
	{
		get
		{
			Shop shopInfo = this.ShopInfo;
			if (shopInfo == null)
			{
				return null;
			}
			return new uint?(shopInfo.UpdateTime);
		}
	}

	// Token: 0x17001DC1 RID: 7617
	// (get) Token: 0x0601645F RID: 91231 RVA: 0x005A1EBF File Offset: 0x005A00BF
	// (set) Token: 0x06016460 RID: 91232 RVA: 0x005A1EC7 File Offset: 0x005A00C7
	public int? SecondsToRefresh
	{
		get
		{
			return this.SecondsToRefreshInner;
		}
		set
		{
			if (value != null && value.Value <= 0 && this.SecondsToRefreshInner != null && this.SecondsToRefreshInner.Value > 0)
			{
				this.ShowRefreshBox();
			}
			this.SecondsToRefreshInner = value;
		}
	}

	// Token: 0x06016461 RID: 91233 RVA: 0x005A1F04 File Offset: 0x005A0104
	[NullableContext(1)]
	public ShopView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016462 RID: 91234 RVA: 0x005A1F18 File Offset: 0x005A0118
	public void PushCameraHandle(EUiViewName viewName, int viewId, bool isBlend)
	{
		IShopOpenParam shopOpenParam = this.OpenParam as IShopOpenParam;
		string handleName = "";
		if (shopOpenParam != null && shopOpenParam.UiCameraName != null && shopOpenParam.UiCameraName != "")
		{
			handleName = shopOpenParam.UiCameraName;
		}
		else if (shopOpenParam != null)
		{
			handleName = ShopConfig.Instance.GetShopInfoConfig(shopOpenParam.ShopId).UiCamera;
		}
		this.ViewHandleData = UiCameraAnimationManager.Instance.PushCameraHandleByHandleName(handleName, true, true, "1001", false, null, null);
	}

	// Token: 0x06016463 RID: 91235 RVA: 0x005A1F9C File Offset: 0x005A019C
	public void PopCameraHandle(EUiViewName viewName, UiViewInfo stackTopInfo, int closeViewId, bool popOrDelete)
	{
		UiCameraAnimationManager.Instance.PopCameraHandle(this.ViewHandleData, null);
	}

	// Token: 0x06016464 RID: 91236 RVA: 0x005A1FB0 File Offset: 0x005A01B0
	protected override void OnBeforeCreate()
	{
		IShopOpenParam shopOpenParam = this.OpenParam as IShopOpenParam;
		if (shopOpenParam != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
			defaultInterpolatedStringHandler.AppendLiteral("ShopView");
			defaultInterpolatedStringHandler.AppendFormatted<int>(10000 + shopOpenParam.ShopId);
			string commonPopBgKey = defaultInterpolatedStringHandler.ToStringAndClear();
			this.ViewInfo.CommonPopBgKey = commonPopBgKey;
		}
	}

	// Token: 0x06016465 RID: 91237 RVA: 0x005A2008 File Offset: 0x005A0208
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
	}

	// Token: 0x06016466 RID: 91238 RVA: 0x005A20BC File Offset: 0x005A02BC
	[NullableContext(1)]
	private void OnExtendToggleStateChanged(MediumItemGridExtendCallback callbackParameter)
	{
		ShopItemFullInfo shopItemFullInfo = callbackParameter.Data as ShopItemFullInfo;
		if (this.ShopItemInfoList == null || shopItemFullInfo == null)
		{
			return;
		}
		int num = this.ShopItemInfoList.IndexOf(shopItemFullInfo);
		this.ShopItemScrollView.DeselectCurrentGridProxy(false);
		if (num < 0)
		{
			return;
		}
		this.ShopItemScrollView.SelectGridProxy(num, false);
	}

	// Token: 0x06016467 RID: 91239 RVA: 0x005A210C File Offset: 0x005A030C
	protected override UniTask OnBeforeStartAsync()
	{
		ShopView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShopView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016468 RID: 91240 RVA: 0x005A2150 File Offset: 0x005A0350
	protected override void OnStart()
	{
		IShopOpenParam shopOpenParam = this.OpenParam as IShopOpenParam;
		if (shopOpenParam != null)
		{
			this.ShopId = shopOpenParam.ShopId;
		}
		this.ShopItemScrollView = new LoopScrollView<ShopMediumItemGrid, ShopItemFullInfo>(base.GetLoopScrollViewComponent(4), base.GetItem(6).GetOwner() as AUIBaseActor, delegate()
		{
			ShopMediumItemGrid shopMediumItemGrid = new ShopMediumItemGrid();
			shopMediumItemGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnExtendToggleStateChanged));
			return shopMediumItemGrid;
		}, false);
		IUiPopFrameInterface childPopView = this.ChildPopView;
		if (childPopView != null)
		{
			childPopView.PopItem.SetMaskResponsibleState(false);
		}
		this.UpdateCurrency();
		this.SetShopName();
		this.RefreshShopItemList(true, false);
		this.RefreshTimeOnTick();
		UUIItem item = base.GetItem(1);
		bool uiactive;
		if (this.RefreshTime != null)
		{
			uint? refreshTime = this.RefreshTime;
			uint num = 0U;
			uiactive = (refreshTime.GetValueOrDefault() > num & refreshTime != null);
		}
		else
		{
			uiactive = false;
		}
		item.SetUIActive(uiactive);
		ShopModel.Instance.CurrentInteractCreatureDataLongId = InteractionModel.Instance.InteractCreatureDataLongId;
	}

	// Token: 0x06016469 RID: 91241 RVA: 0x005A2228 File Offset: 0x005A0428
	private void ShowNpcName(ShopInfo shopInfo)
	{
		string newText = "";
		Entity entity = EntitySystem.Instance.Get(ShopModel.Instance.InteractTarget);
		if (entity != null)
		{
			PawnInfoManageComponent component = entity.GetComponent<PawnInfoManageComponent>();
			newText = (((component != null) ? component.PawnName : null) ?? "");
		}
		base.GetText(2).SetText(newText, true);
	}

	// Token: 0x0601646A RID: 91242 RVA: 0x005A2280 File Offset: 0x005A0480
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OpenItemInfo, new Action(this.OpenItemInfoEvent));
		EventSystem.Instance.Add(EEventName.CloseItemInfo, new Action(this.CloseItemInfoEvent));
		EventSystem.Instance.Add<int, int>(EEventName.BoughtItem, new Action<int, int>(this.OnBuyItem));
		EventSystem.Instance.Add<int?>(EEventName.ShopUpdate, new Action<int?>(this.OnShopUpdate));
	}

	// Token: 0x0601646B RID: 91243 RVA: 0x005A2300 File Offset: 0x005A0500
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OpenItemInfo, new Action(this.OpenItemInfoEvent));
		EventSystem.Instance.Remove(EEventName.CloseItemInfo, new Action(this.CloseItemInfoEvent));
		EventSystem.Instance.Remove(EEventName.BoughtItem, new Action<int, int>(this.OnBuyItem));
		EventSystem.Instance.Remove(EEventName.ShopUpdate, new Action<int?>(this.OnShopUpdate));
	}

	// Token: 0x0601646C RID: 91244 RVA: 0x005A2380 File Offset: 0x005A0580
	private void OnSequenceFinish()
	{
		ShopPanelData shopPanelData = new ShopPanelData();
		ShopItemFullInfo openItemInfo = ShopModel.Instance.OpenItemInfo;
		shopPanelData.ItemId = openItemInfo.ItemId;
		shopPanelData.ParamData = openItemInfo.Id;
		shopPanelData.CurrencyId = openItemInfo.GetMoneyId();
		shopPanelData.SingleBuyCount = openItemInfo.StackSize;
		shopPanelData.SingleBuyPrice = openItemInfo.DefaultPrice.CoinPrice;
		shopPanelData.BoughtCount = openItemInfo.BoughtCount;
		shopPanelData.BuyLimit = openItemInfo.BuyLimit;
		shopPanelData.IsLock = openItemInfo.IsLocked;
		shopPanelData.LockText = openItemInfo.LockInfo;
		shopPanelData.InSellTime = openItemInfo.InSellTime();
		shopPanelData.BuySuccessFunction = new TBuySuccess(this.RequestServer);
		this.ShopItemInfoPanelInternal.UpdatePanel(shopPanelData);
	}

	// Token: 0x0601646D RID: 91245 RVA: 0x005A243E File Offset: 0x005A063E
	[NullableContext(1)]
	private void RequestServer(int itemId, int buyCount, int currencyId, object param)
	{
		ShopController.Instance.SendShopBuyRequest(this.ShopId, (int)param, currencyId, buyCount, delegate
		{
			ShopPanelData shopPanelData = new ShopPanelData();
			ShopModel.Instance.OpenItemInfo = ShopModel.Instance.GetShopItemFullInfoByShopIdAndItemId(this.ShopId, ShopModel.Instance.OpenItemInfo.Id);
			ShopItemFullInfo openItemInfo = ShopModel.Instance.OpenItemInfo;
			shopPanelData.ItemId = openItemInfo.ItemId;
			shopPanelData.ParamData = openItemInfo.Id;
			shopPanelData.CurrencyId = openItemInfo.GetMoneyId();
			shopPanelData.SingleBuyCount = openItemInfo.StackSize;
			shopPanelData.SingleBuyPrice = openItemInfo.DefaultPrice.CoinPrice;
			shopPanelData.BoughtCount = openItemInfo.BoughtCount;
			shopPanelData.BuyLimit = openItemInfo.BuyLimit;
			shopPanelData.IsLock = openItemInfo.IsLocked;
			shopPanelData.LockText = openItemInfo.LockInfo;
			shopPanelData.InSellTime = openItemInfo.InSellTime();
			shopPanelData.BuySuccessFunction = new TBuySuccess(this.RequestServer);
			this.ShopItemInfoPanelInternal.UpdatePanel(shopPanelData);
		});
	}

	// Token: 0x0601646E RID: 91246 RVA: 0x005A2465 File Offset: 0x005A0665
	protected override void OnTick(float delta)
	{
		this.RefreshTimeOnTick();
	}

	// Token: 0x0601646F RID: 91247 RVA: 0x005A2470 File Offset: 0x005A0670
	private void RefreshTimeOnTick()
	{
		if (this.RefreshTime != null)
		{
			uint? refreshTime = this.RefreshTime;
			uint num = 0U;
			if (!(refreshTime.GetValueOrDefault() == num & refreshTime != null))
			{
				string text = this.FormatCountdown();
				if (text != null)
				{
					LguiUtil.Instance.SetLocalText(base.GetText(0), "RefreshTime", new <>z__ReadOnlySingleElementList<object>(text));
				}
				return;
			}
		}
		base.GetItem(1).SetUIActive(false);
	}

	// Token: 0x06016470 RID: 91248 RVA: 0x005A24E0 File Offset: 0x005A06E0
	protected override void OnBeforeDestroy()
	{
		List<ShopItemFullInfo> shopItemInfoList = this.ShopItemInfoList;
		if (shopItemInfoList != null)
		{
			shopItemInfoList.Clear();
		}
		if (this.ShopItemScrollView != null)
		{
			this.ShopItemScrollView.ClearGridProxies();
		}
		if (this.ShopItemInfoPanelInternal != null)
		{
			this.ShopItemInfoPanelInternal.Destroy(null);
		}
		foreach (CommonCurrencyItem commonCurrencyItem in this.CurrencyItemList)
		{
			commonCurrencyItem.Destroy(null);
		}
		AUIBaseActor rootActor = this.RootActor;
		if (rootActor != null)
		{
			rootActor.OnSequencePlayEvent.Unbind();
		}
	}

	// Token: 0x06016471 RID: 91249 RVA: 0x005A2580 File Offset: 0x005A0780
	private void OnBuyItem(int shopId, int id)
	{
		this.RefreshShopItemList(false, false);
		this.UpdateCurrency();
	}

	// Token: 0x06016472 RID: 91250 RVA: 0x005A2590 File Offset: 0x005A0790
	private void OnShopUpdate(int? shopId)
	{
		int shopId2 = this.ShopId;
		int? num = shopId;
		if (shopId2 == num.GetValueOrDefault() & num != null)
		{
			this.RefreshShopItemList(false, true);
		}
	}

	// Token: 0x06016473 RID: 91251 RVA: 0x005A25C0 File Offset: 0x005A07C0
	private void OpenItemInfoEvent()
	{
		base.PlaySequence("Sle", new Action(this.OnSequenceFinish), false);
		ShopModel.Instance.OpenItemInfo = ShopModel.Instance.GetShopItemFullInfoByShopIdAndItemId(this.ShopId, ShopModel.Instance.OpenItemInfo.Id);
		ShopPanelData shopPanelData = new ShopPanelData();
		ShopItemFullInfo openItemInfo = ShopModel.Instance.OpenItemInfo;
		shopPanelData.ItemId = openItemInfo.ItemId;
		shopPanelData.ParamData = openItemInfo.Id;
		shopPanelData.CurrencyId = openItemInfo.GetMoneyId();
		shopPanelData.SingleBuyCount = openItemInfo.StackSize;
		shopPanelData.SingleBuyPrice = openItemInfo.DefaultPrice.CoinPrice;
		shopPanelData.BoughtCount = openItemInfo.BoughtCount;
		shopPanelData.BuyLimit = openItemInfo.BuyLimit;
		shopPanelData.IsLock = openItemInfo.IsLocked;
		shopPanelData.LockText = openItemInfo.LockInfo;
		shopPanelData.InSellTime = openItemInfo.InSellTime();
		shopPanelData.BuySuccessFunction = new TBuySuccess(this.RequestServer);
		this.ShopItemInfoPanelInternal.UpdatePanel(shopPanelData);
	}

	// Token: 0x06016474 RID: 91252 RVA: 0x005A26C0 File Offset: 0x005A08C0
	private void CloseItemInfoEvent()
	{
		if (this.UiViewSequence != null)
		{
			this.UiViewSequence.PlaySequence("UnSle", false, null);
		}
	}

	// Token: 0x06016475 RID: 91253 RVA: 0x005A26EF File Offset: 0x005A08EF
	protected void SetShopName()
	{
	}

	// Token: 0x06016476 RID: 91254 RVA: 0x005A26F4 File Offset: 0x005A08F4
	protected void UpdateCurrency()
	{
		ShopInfo? shopConfig = ShopModel.Instance.GetShopConfig(this.ShopId);
		if (shopConfig != null)
		{
			this.ShowNpcName(shopConfig.Value);
		}
	}

	// Token: 0x06016477 RID: 91255 RVA: 0x005A2728 File Offset: 0x005A0928
	protected void RefreshShopItemList(bool isFirstRefresh = false, bool refreshItemInfo = false)
	{
		ShopView.<>c__DisplayClass37_0 CS$<>8__locals1 = new ShopView.<>c__DisplayClass37_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.isFirstRefresh = isFirstRefresh;
		CS$<>8__locals1.refreshItemInfo = refreshItemInfo;
		UiAsyncTask task = new UiAsyncTask("ShopView.RefreshShopItemList", delegate()
		{
			ShopView.<>c__DisplayClass37_0.<<RefreshShopItemList>b__0>d <<RefreshShopItemList>b__0>d;
			<<RefreshShopItemList>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<RefreshShopItemList>b__0>d.<>4__this = CS$<>8__locals1;
			<<RefreshShopItemList>b__0>d.<>1__state = -1;
			<<RefreshShopItemList>b__0>d.<>t__builder.Start<ShopView.<>c__DisplayClass37_0.<<RefreshShopItemList>b__0>d>(ref <<RefreshShopItemList>b__0>d);
			return <<RefreshShopItemList>b__0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
	}

	// Token: 0x06016478 RID: 91256 RVA: 0x005A2770 File Offset: 0x005A0970
	protected string FormatCountdown()
	{
		uint? refreshTime = this.RefreshTime;
		if (refreshTime == null)
		{
			return null;
		}
		int num = (int)Math.Truncate(refreshTime.Value - TimeUtil.Instance.GetServerTime());
		this.SecondsToRefresh = new int?(num);
		if (num <= 0)
		{
			ShopController.Instance.SendShopUpdateRequest(this.ShopId);
			return null;
		}
		return ShopUtils.FormatTime(num);
	}

	// Token: 0x06016479 RID: 91257 RVA: 0x005A27D4 File Offset: 0x005A09D4
	private void ShowRefreshBox()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ShowTimeDownTips);
		Action value = delegate()
		{
			ShopController.Instance.SendShopUpdateRequest(this.ShopId);
		};
		confirmBoxDataNew.FunctionMap[1] = value;
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0400A5B0 RID: 42416
	private int ShopId;

	// Token: 0x0400A5B1 RID: 42417
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<ShopMediumItemGrid, ShopItemFullInfo> ShopItemScrollView;

	// Token: 0x0400A5B2 RID: 42418
	private ShopItemInfoDetailPanel ShopItemInfoPanelInternal;

	// Token: 0x0400A5B3 RID: 42419
	[Nullable(1)]
	private readonly List<CommonCurrencyItem> CurrencyItemList = new List<CommonCurrencyItem>();

	// Token: 0x0400A5B4 RID: 42420
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ShopItemFullInfo> ShopItemInfoList;

	// Token: 0x0400A5B5 RID: 42421
	private int? SecondsToRefreshInner;

	// Token: 0x0400A5B6 RID: 42422
	private UiCameraHandleData ViewHandleData;

	// Token: 0x0200902B RID: 36907
	[NullableContext(0)]
	private enum EShopViewDefine
	{
		// Token: 0x0402EACB RID: 191179
		RefreshTimeText,
		// Token: 0x0402EACC RID: 191180
		RefreshTimeItem,
		// Token: 0x0402EACD RID: 191181
		NpcName,
		// Token: 0x0402EACE RID: 191182
		DialogueText,
		// Token: 0x0402EACF RID: 191183
		ScrollView,
		// Token: 0x0402EAD0 RID: 191184
		InfoPanel,
		// Token: 0x0402EAD1 RID: 191185
		GridItem
	}
}
