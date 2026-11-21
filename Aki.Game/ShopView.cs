using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F6F RID: 8047
[NullableContext(2)]
[Nullable(0)]
public class ShopView : UiTickViewBase, IUiViewCameraBehavior
{
	// Token: 0x17001E18 RID: 7704
	// (get) Token: 0x06013E64 RID: 81508 RVA: 0x005CCE62 File Offset: 0x005CB062
	public Shop ShopInfo
	{
		get
		{
			return ShopModel.Instance.GetShopInfo(this.ShopId);
		}
	}

	// Token: 0x17001E19 RID: 7705
	// (get) Token: 0x06013E65 RID: 81509 RVA: 0x005CCE74 File Offset: 0x005CB074
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

	// Token: 0x17001E1A RID: 7706
	// (get) Token: 0x06013E66 RID: 81510 RVA: 0x005CCE9F File Offset: 0x005CB09F
	// (set) Token: 0x06013E67 RID: 81511 RVA: 0x005CCEA7 File Offset: 0x005CB0A7
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

	// Token: 0x06013E68 RID: 81512 RVA: 0x005CCEE4 File Offset: 0x005CB0E4
	[NullableContext(1)]
	public ShopView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013E69 RID: 81513 RVA: 0x005CCEF8 File Offset: 0x005CB0F8
	public void PushCameraHandleByOpenView(EUiViewName viewName, int viewId, EUiCameraHandleOperationType operationType)
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
		this.ViewHandleData = UiCameraModel.Instance.PushCameraHandleByHandleName(handleName, true, true, "1001", false, null);
	}

	// Token: 0x06013E6A RID: 81514 RVA: 0x005CCF73 File Offset: 0x005CB173
	public void PopCameraHandleByCloseView(EUiViewName viewName, EUiViewName? nextViewName, int closeViewId, EUiCameraHandleOperationType operationType)
	{
		UiCameraModel.Instance.PopCameraHandle(this.ViewHandleData, null);
	}

	// Token: 0x06013E6B RID: 81515 RVA: 0x005CCF88 File Offset: 0x005CB188
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

	// Token: 0x06013E6C RID: 81516 RVA: 0x005CCFE0 File Offset: 0x005CB1E0
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

	// Token: 0x06013E6D RID: 81517 RVA: 0x005CD094 File Offset: 0x005CB294
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

	// Token: 0x06013E6E RID: 81518 RVA: 0x005CD0E4 File Offset: 0x005CB2E4
	protected override UniTask OnBeforeStartAsync()
	{
		ShopView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShopView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013E6F RID: 81519 RVA: 0x005CD128 File Offset: 0x005CB328
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

	// Token: 0x06013E70 RID: 81520 RVA: 0x005CD200 File Offset: 0x005CB400
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

	// Token: 0x06013E71 RID: 81521 RVA: 0x005CD258 File Offset: 0x005CB458
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OpenItemInfo, new Action(this.OpenItemInfoEvent));
		EventSystem.Instance.Add(EEventName.CloseItemInfo, new Action(this.CloseItemInfoEvent));
		EventSystem.Instance.Add<int, int>(EEventName.BoughtItem, new Action<int, int>(this.OnBuyItem));
		EventSystem.Instance.Add<int?>(EEventName.ShopUpdate, new Action<int?>(this.OnShopUpdate));
	}

	// Token: 0x06013E72 RID: 81522 RVA: 0x005CD2D8 File Offset: 0x005CB4D8
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OpenItemInfo, new Action(this.OpenItemInfoEvent));
		EventSystem.Instance.Remove(EEventName.CloseItemInfo, new Action(this.CloseItemInfoEvent));
		EventSystem.Instance.Remove(EEventName.BoughtItem, new Action<int, int>(this.OnBuyItem));
		EventSystem.Instance.Remove(EEventName.ShopUpdate, new Action<int?>(this.OnShopUpdate));
	}

	// Token: 0x06013E73 RID: 81523 RVA: 0x005CD358 File Offset: 0x005CB558
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

	// Token: 0x06013E74 RID: 81524 RVA: 0x005CD416 File Offset: 0x005CB616
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

	// Token: 0x06013E75 RID: 81525 RVA: 0x005CD43D File Offset: 0x005CB63D
	protected override void OnTick(float delta)
	{
		this.RefreshTimeOnTick();
	}

	// Token: 0x06013E76 RID: 81526 RVA: 0x005CD448 File Offset: 0x005CB648
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

	// Token: 0x06013E77 RID: 81527 RVA: 0x005CD4B8 File Offset: 0x005CB6B8
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

	// Token: 0x06013E78 RID: 81528 RVA: 0x005CD558 File Offset: 0x005CB758
	private void OnBuyItem(int shopId, int id)
	{
		this.RefreshShopItemList(false, false);
		this.UpdateCurrency();
	}

	// Token: 0x06013E79 RID: 81529 RVA: 0x005CD568 File Offset: 0x005CB768
	private void OnShopUpdate(int? shopId)
	{
		int shopId2 = this.ShopId;
		int? num = shopId;
		if (shopId2 == num.GetValueOrDefault() & num != null)
		{
			this.RefreshShopItemList(false, true);
		}
	}

	// Token: 0x06013E7A RID: 81530 RVA: 0x005CD598 File Offset: 0x005CB798
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

	// Token: 0x06013E7B RID: 81531 RVA: 0x005CD698 File Offset: 0x005CB898
	private void CloseItemInfoEvent()
	{
		if (this.UiViewSequence != null)
		{
			this.UiViewSequence.PlaySequence("UnSle", false, null);
		}
	}

	// Token: 0x06013E7C RID: 81532 RVA: 0x005CD6C7 File Offset: 0x005CB8C7
	protected void SetShopName()
	{
	}

	// Token: 0x06013E7D RID: 81533 RVA: 0x005CD6CC File Offset: 0x005CB8CC
	protected void UpdateCurrency()
	{
		ShopInfo? shopConfig = ShopModel.Instance.GetShopConfig(this.ShopId);
		if (shopConfig != null)
		{
			this.ShowNpcName(shopConfig.Value);
		}
	}

	// Token: 0x06013E7E RID: 81534 RVA: 0x005CD700 File Offset: 0x005CB900
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

	// Token: 0x06013E7F RID: 81535 RVA: 0x005CD748 File Offset: 0x005CB948
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

	// Token: 0x06013E80 RID: 81536 RVA: 0x005CD7AC File Offset: 0x005CB9AC
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

	// Token: 0x0400A99A RID: 43418
	private int ShopId;

	// Token: 0x0400A99B RID: 43419
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<ShopMediumItemGrid, ShopItemFullInfo> ShopItemScrollView;

	// Token: 0x0400A99C RID: 43420
	private ShopItemInfoDetailPanel ShopItemInfoPanelInternal;

	// Token: 0x0400A99D RID: 43421
	[Nullable(1)]
	private readonly List<CommonCurrencyItem> CurrencyItemList = new List<CommonCurrencyItem>();

	// Token: 0x0400A99E RID: 43422
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ShopItemFullInfo> ShopItemInfoList;

	// Token: 0x0400A99F RID: 43423
	private int? SecondsToRefreshInner;

	// Token: 0x0400A9A0 RID: 43424
	private UiCameraHandleData ViewHandleData;

	// Token: 0x02008272 RID: 33394
	[NullableContext(0)]
	private enum EShopViewDefine
	{
		// Token: 0x0402A1C3 RID: 172483
		RefreshTimeText,
		// Token: 0x0402A1C4 RID: 172484
		RefreshTimeItem,
		// Token: 0x0402A1C5 RID: 172485
		NpcName,
		// Token: 0x0402A1C6 RID: 172486
		DialogueText,
		// Token: 0x0402A1C7 RID: 172487
		ScrollView,
		// Token: 0x0402A1C8 RID: 172488
		InfoPanel,
		// Token: 0x0402A1C9 RID: 172489
		GridItem
	}
}
