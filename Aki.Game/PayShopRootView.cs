using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform.PlatformSdk;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200184C RID: 6220
[NullableContext(1)]
[Nullable(0)]
public class PayShopRootView : UiTickViewBase
{
	// Token: 0x0600F5CA RID: 62922 RVA: 0x0047C6CE File Offset: 0x0047A8CE
	public PayShopRootView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F5CB RID: 62923 RVA: 0x0047C6F9 File Offset: 0x0047A8F9
	protected override void OnBeforeCreate()
	{
		this.PayShopViewData = (this.OpenParam as PayShopViewData);
	}

	// Token: 0x0600F5CC RID: 62924 RVA: 0x0047C70C File Offset: 0x0047A90C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickService));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickShopRuleButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600F5CD RID: 62925 RVA: 0x0047C904 File Offset: 0x0047AB04
	protected override UniTask OnBeforeStartAsync()
	{
		PayShopRootView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PayShopRootView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F5CE RID: 62926 RVA: 0x0047C947 File Offset: 0x0047AB47
	protected override void OnBeforeShow()
	{
		TotalTopUpPageActivityEnterPanel totalTopUpEnterItem = this.TotalTopUpEnterItem;
		if (totalTopUpEnterItem == null)
		{
			return;
		}
		totalTopUpEnterItem.PlayStartSequence();
	}

	// Token: 0x0600F5CF RID: 62927 RVA: 0x0047C95C File Offset: 0x0047AB5C
	protected override void OnStart()
	{
		CommonTabComponentData<PayShopTabItem> data = new CommonTabComponentData<PayShopTabItem>(new Func<UUIItem, int?, PayShopTabItem>(this.TabItemProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
		this.TabComponent = new TabComponentWithCaptionItem<PayShopTabItem>(base.GetItem(0), data, new Action(this.BackClick), false);
		this.TabViewComponent = new TabViewComponent<PayShopDefine.EPayShopTabType>(base.GetItem(1), EKeyMode.Default);
		this.RefreshUid();
		this.PayShopId = null;
		base.GetButton(6).RootUIComp.Get().SetRaycastTarget(true);
		this.CountDownText = base.GetText(3);
		this.CountDownTextActive = base.GetItem(2).bIsUIActive;
		base.GetItem(2).SetUIActive(false);
		this.CountDownTextActive = false;
		this.TabComponent.SetTitle("");
		this.TabComponent.SetTitleIconVisible(false);
		this.BindServiceRedDot();
		this.RefreshShopRuleButtonState();
		this.RefreshTotalTopUpEnterItem();
	}

	// Token: 0x0600F5D0 RID: 62928 RVA: 0x0047CA53 File Offset: 0x0047AC53
	private void BindServiceRedDot()
	{
		RedDotController.Instance.BindRedDot(ERedDotName.CustomerService, base.GetItem(7), null, 0);
	}

	// Token: 0x0600F5D1 RID: 62929 RVA: 0x0047CA6A File Offset: 0x0047AC6A
	private void UnBindServiceRedDot()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.CustomerService, base.GetItem(7), 0);
	}

	// Token: 0x0600F5D2 RID: 62930 RVA: 0x0047CA80 File Offset: 0x0047AC80
	private void OnClickService()
	{
		Log.Instance.Info(ELogModule.Shop, ELogAuthor.XXJ, "PayShop:Root 打开客服反馈", default(ReadOnlySpan<ValueTuple<string, object>>));
		KuroSdkController.Instance.OpenCustomerService(EKuroSdkOpenCustomerServerType.Pay);
	}

	// Token: 0x0600F5D3 RID: 62931 RVA: 0x0047CAB4 File Offset: 0x0047ACB4
	private void OnClickShopRuleButton()
	{
		string text = "";
		string packageLanguage = LanguageSystem.Instance.PackageLanguage;
		if (packageLanguage == "ko")
		{
			text = CommonConfig.Instance.GetKoShopRuleUrl();
		}
		else if (packageLanguage == "ja")
		{
			text = CommonConfig.Instance.GetJaShopRuleUrl();
		}
		if (text != "")
		{
			KuroSdkController.Instance.OpenExternalUrl(text);
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "PayShop:Root 打开商城规则失败，没有配置链接";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("url", text);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600F5D4 RID: 62932 RVA: 0x0047CB44 File Offset: 0x0047AD44
	private void RefreshShopRuleButtonState()
	{
		string packageLanguage = LanguageSystem.Instance.PackageLanguage;
		bool flag = packageLanguage == "ko" || packageLanguage == "ja";
		base.GetButton(9).RootUIComp.Get().SetUIActive(flag && KuroSdkController.Instance.GetIfGlobalSdk());
	}

	// Token: 0x0600F5D5 RID: 62933 RVA: 0x0047CBA4 File Offset: 0x0047ADA4
	private void RefreshTotalTopUpEnterItem()
	{
		PayShopViewData payShopViewData = this.PayShopViewData;
		int? num;
		if (payShopViewData == null)
		{
			num = null;
		}
		else
		{
			List<int> showShopIdList = payShopViewData.ShowShopIdList;
			num = ((showShopIdList != null) ? new int?(showShopIdList.Count) : null);
		}
		int? num2 = num;
		bool flag = num2.GetValueOrDefault() == 0;
		TotalTopUpController instance = TotalTopUpController.Instance;
		bool flag2 = instance != null && instance.CheckCurrentTotalUpRunning();
		bool uiActive = flag && flag2;
		TotalTopUpPageActivityEnterPanel totalTopUpEnterItem = this.TotalTopUpEnterItem;
		if (totalTopUpEnterItem == null)
		{
			return;
		}
		totalTopUpEnterItem.SetUiActive(uiActive);
	}

	// Token: 0x0600F5D6 RID: 62934 RVA: 0x0047CC15 File Offset: 0x0047AE15
	private void BackClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600F5D7 RID: 62935 RVA: 0x0047CC20 File Offset: 0x0047AE20
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<IEnumerable<PayShopDefine.EPayShopTabType>>(EEventName.RefreshAllPayShop, new Action<IEnumerable<PayShopDefine.EPayShopTabType>>(this.RefreshAllPayShop));
		EventSystem.Instance.Add(EEventName.SwitchPayShopTabItem, new Action<PayShopDefine.EPayShopTabType, int>(this.SwitchPayShopTabItem));
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.RefreshGoods));
		EventSystem.Instance.Add<PayShopDefine.EPayShopTabType>(EEventName.SwitchPayShopView, new Action<PayShopDefine.EPayShopTabType>(this.SwitchPayShop));
		EventSystem.Instance.Add<int, bool>(EEventName.RefreshPayShop, new Action<int, bool>(this.RefreshPayShop));
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.RefreshGoodsList, new Action<IReadOnlySet<int>>(this.RefreshGoodsList));
		EventSystem.Instance.Add<IReadOnlyDictionary<int, HashSet<int>>>(EEventName.UnLockGoods, new Action<IReadOnlyDictionary<int, HashSet<int>>>(this.UnLockGoods));
		EventSystem.Instance.Add(EEventName.ShopVersionCodeChange, new Action(this.ShopVersionCodeChange));
		EventSystem.Instance.Add<string, IReadOnlyList<string>>(EEventName.RefreshShopAccumulateCurrency, new Action<string, IReadOnlyList<string>>(this.OnAccumulateCurrencyUpdate));
		EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.TryRefreshRootShopMoney, new Action<IReadOnlyList<int>>(this.TryRefreshRootShopMoney));
		EventSystem.Instance.Add<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccessForRefresh));
		EventSystem.Instance.Add<int>(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOutForRefresh));
	}

	// Token: 0x0600F5D8 RID: 62936 RVA: 0x0047CD80 File Offset: 0x0047AF80
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<IEnumerable<PayShopDefine.EPayShopTabType>>(EEventName.RefreshAllPayShop, new Action<IEnumerable<PayShopDefine.EPayShopTabType>>(this.RefreshAllPayShop));
		EventSystem.Instance.Remove(EEventName.SwitchPayShopTabItem, new Action<PayShopDefine.EPayShopTabType, int>(this.SwitchPayShopTabItem));
		EventSystem.Instance.Remove(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.RefreshGoods));
		EventSystem.Instance.Remove<PayShopDefine.EPayShopTabType>(EEventName.SwitchPayShopView, new Action<PayShopDefine.EPayShopTabType>(this.SwitchPayShop));
		EventSystem.Instance.Remove(EEventName.RefreshPayShop, new Action<int, bool>(this.RefreshPayShop));
		EventSystem.Instance.Remove<IReadOnlySet<int>>(EEventName.RefreshGoodsList, new Action<IReadOnlySet<int>>(this.RefreshGoodsList));
		EventSystem.Instance.Remove(EEventName.UnLockGoods, new Action<IReadOnlyDictionary<int, HashSet<int>>>(this.UnLockGoods));
		EventSystem.Instance.Remove(EEventName.ShopVersionCodeChange, new Action(this.ShopVersionCodeChange));
		EventSystem.Instance.Remove<string, IReadOnlyList<string>>(EEventName.RefreshShopAccumulateCurrency, new Action<string, IReadOnlyList<string>>(this.OnAccumulateCurrencyUpdate));
		EventSystem.Instance.Remove<IReadOnlyList<int>>(EEventName.TryRefreshRootShopMoney, new Action<IReadOnlyList<int>>(this.TryRefreshRootShopMoney));
		EventSystem.Instance.Remove<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccessForRefresh));
		EventSystem.Instance.Remove<int>(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOutForRefresh));
	}

	// Token: 0x0600F5D9 RID: 62937 RVA: 0x0047CEDD File Offset: 0x0047B0DD
	private PayShopTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new PayShopTabItem();
	}

	// Token: 0x0600F5DA RID: 62938 RVA: 0x0047CEE4 File Offset: 0x0047B0E4
	private void ToggleCallBack(int index)
	{
		int num = this.TabShopList[index];
		int payShopInfoDynamicTabId = PayShopModel.Instance.GetPayShopInfoDynamicTabId((PayShopDefine.EPayShopTabType)num);
		EUiTabViewName euiTabViewName = (EUiTabViewName)DynamicTabConfig.Instance.GetTabViewConfById(payShopInfoDynamicTabId).ChildViewName;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "PayShop:Root 点击切换界面";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", euiTabViewName);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.RefreshServiceButton(new int?(num));
		this.TargetPayShopId = new PayShopDefine.EPayShopTabType?((PayShopDefine.EPayShopTabType)num);
		PayShopController.Instance.SendRequestPayShopUpdate((PayShopDefine.EPayShopTabType)num, true, null);
	}

	// Token: 0x0600F5DB RID: 62939 RVA: 0x0047CF74 File Offset: 0x0047B174
	private CommonTabData GetCommonData(int index)
	{
		int payShopId = this.TabShopList[index];
		UiDynamicTab? tabInfoByPayShopIdId = PayShopModel.Instance.GetTabInfoByPayShopIdId(payShopId);
		return new CommonTabData(tabInfoByPayShopIdId.Value.Icon, new CommonTabTitleData(tabInfoByPayShopIdId.Value.TabName, Array.Empty<object>()), null);
	}

	// Token: 0x0600F5DC RID: 62940 RVA: 0x0047CFC8 File Offset: 0x0047B1C8
	protected override void OnAfterShow()
	{
		if (this.PayShopId == null)
		{
			this.SelectDefaultPayShop();
			this.RefreshCountDownText();
			return;
		}
		this.TabViewComponent.SetCurrentTabViewState(true);
	}

	// Token: 0x0600F5DD RID: 62941 RVA: 0x0047CFF0 File Offset: 0x0047B1F0
	private void RefreshServiceButton(int? payShopId)
	{
		UUIItem item = base.GetItem(5);
		if (payShopId == null)
		{
			item.SetUIActive(false);
			return;
		}
		if (!KuroSdkController.Instance.NeedShowCustomerService())
		{
			item.SetUIActive(false);
			return;
		}
		item.SetUIActive(payShopId.GetValueOrDefault() == 100);
	}

	// Token: 0x0600F5DE RID: 62942 RVA: 0x0047D03C File Offset: 0x0047B23C
	private void RefreshUid()
	{
		LguiUtil.Instance.SetLocalText(base.GetText(4), "FriendMyUid", new <>z__ReadOnlySingleElementList<object>(FunctionModel.Instance.PlayerId.ToString()));
	}

	// Token: 0x0600F5DF RID: 62943 RVA: 0x0047D076 File Offset: 0x0047B276
	protected override void OnAfterHide()
	{
		this.TabViewComponent.SetCurrentTabViewState(false);
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (platformSdk == null)
		{
			return;
		}
		platformSdk.HidePlayStationStoreIcon();
	}

	// Token: 0x0600F5E0 RID: 62944 RVA: 0x0047D098 File Offset: 0x0047B298
	protected override void OnBeforeDestroy()
	{
		this.UnBindServiceRedDot();
		if (this.TabComponent != null)
		{
			this.TabComponent.Destroy(null);
			this.TabComponent = null;
		}
		if (this.TabViewComponent != null)
		{
			this.TabViewComponent.DestroyTabViewComponent();
			this.TabViewComponent = null;
		}
		this.TabShopList.Clear();
	}

	// Token: 0x0600F5E1 RID: 62945 RVA: 0x0047D0EC File Offset: 0x0047B2EC
	protected UniTask RefreshCurrency(PayShopDefine.EPayShopTabType payShopId)
	{
		PayShopRootView.<RefreshCurrency>d__38 <RefreshCurrency>d__;
		<RefreshCurrency>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshCurrency>d__.<>4__this = this;
		<RefreshCurrency>d__.payShopId = payShopId;
		<RefreshCurrency>d__.<>1__state = -1;
		<RefreshCurrency>d__.<>t__builder.Start<PayShopRootView.<RefreshCurrency>d__38>(ref <RefreshCurrency>d__);
		return <RefreshCurrency>d__.<>t__builder.Task;
	}

	// Token: 0x0600F5E2 RID: 62946 RVA: 0x0047D137 File Offset: 0x0047B337
	private void TryRefreshRootShopMoney(IReadOnlyList<int> money)
	{
		this.RefreshCurrencyByMoney(money);
	}

	// Token: 0x0600F5E3 RID: 62947 RVA: 0x0047D144 File Offset: 0x0047B344
	private UniTask RefreshCurrencyByMoney(IReadOnlyList<int> money)
	{
		PayShopRootView.<RefreshCurrencyByMoney>d__40 <RefreshCurrencyByMoney>d__;
		<RefreshCurrencyByMoney>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshCurrencyByMoney>d__.<>4__this = this;
		<RefreshCurrencyByMoney>d__.money = money;
		<RefreshCurrencyByMoney>d__.<>1__state = -1;
		<RefreshCurrencyByMoney>d__.<>t__builder.Start<PayShopRootView.<RefreshCurrencyByMoney>d__40>(ref <RefreshCurrencyByMoney>d__);
		return <RefreshCurrencyByMoney>d__.<>t__builder.Task;
	}

	// Token: 0x0600F5E4 RID: 62948 RVA: 0x0047D190 File Offset: 0x0047B390
	private void SelectDefaultPayShop()
	{
		PayShopViewData payShopViewData = this.PayShopViewData;
		PayShopJumpParam payShopJumpParam;
		if (payShopViewData == null)
		{
			payShopJumpParam = null;
		}
		else
		{
			Func<PayShopJumpParam> jumpTabResolver = payShopViewData.JumpTabResolver;
			payShopJumpParam = ((jumpTabResolver != null) ? jumpTabResolver() : null);
		}
		PayShopJumpParam payShopJumpParam2 = payShopJumpParam;
		if (payShopJumpParam2 != null && this.PayShopViewData != null)
		{
			this.PayShopViewData.PayShopId = payShopJumpParam2.PayShopId;
			this.PayShopViewData.SwitchId = new int?(payShopJumpParam2.SwitchId);
		}
		this.TabShopList = this.BuildTabShopList();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "PayShop:Root 页签数据";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TabShopList", this.TabShopList);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (this.PayShopViewData != null && this.PayShopViewData.PayShopId != PayShopDefine.EPayShopTabType.Default)
		{
			int num = this.TabShopList.IndexOf((int)this.PayShopViewData.PayShopId);
			this.RefreshTabItem(this.TabShopList, (num < 0) ? 0 : num);
			return;
		}
		this.RefreshTabItem(this.TabShopList, 0);
	}

	// Token: 0x0600F5E5 RID: 62949 RVA: 0x0047D274 File Offset: 0x0047B474
	private List<int> BuildTabShopList()
	{
		bool iosAuditFirstDownloadTip = BaseConfigController.Instance.GetIosAuditFirstDownloadTip();
		PayShopViewData payShopViewData = this.PayShopViewData;
		bool flag;
		if (payShopViewData == null)
		{
			flag = false;
		}
		else
		{
			List<int> showShopIdList = payShopViewData.ShowShopIdList;
			int? num = (showShopIdList != null) ? new int?(showShopIdList.Count) : null;
			int num2 = 0;
			flag = (num.GetValueOrDefault() > num2 & num != null);
		}
		List<int> list;
		if (flag)
		{
			list = new List<int>(this.PayShopViewData.ShowShopIdList);
		}
		else
		{
			list = new List<int>();
			foreach (PayShopDefine.EPayShopTabType epayShopTabType in PayShopModel.Instance.GetPayShopIdList())
			{
				int payShopInfoTabViewType = PayShopModel.Instance.GetPayShopInfoTabViewType(epayShopTabType);
				if (iosAuditFirstDownloadTip)
				{
					using (IEnumerator<PayShopDefine.EShopTabViewType> enumerator2 = PayShopDefine.iosLimitModePayShopViewType.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							if (enumerator2.Current == (PayShopDefine.EShopTabViewType)payShopInfoTabViewType)
							{
								list.Add((int)epayShopTabType);
								break;
							}
						}
						continue;
					}
				}
				using (IEnumerator<PayShopDefine.EShopTabViewType> enumerator2 = PayShopDefine.payShopViewTabType.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current == (PayShopDefine.EShopTabViewType)payShopInfoTabViewType)
						{
							list.Add((int)epayShopTabType);
							break;
						}
					}
				}
			}
		}
		List<int> list2 = new List<int>();
		foreach (int num3 in list)
		{
			if (PayShopModel.Instance.IsPayShopVisible((PayShopDefine.EPayShopTabType)num3))
			{
				list2.Add(num3);
			}
		}
		return list2;
	}

	// Token: 0x0600F5E6 RID: 62950 RVA: 0x0047D42C File Offset: 0x0047B62C
	private void OnPayItemSuccessForRefresh(PayItemSuccess _)
	{
		this.TryRefreshTabShopList();
	}

	// Token: 0x0600F5E7 RID: 62951 RVA: 0x0047D434 File Offset: 0x0047B634
	private void OnGoodsSoldOutForRefresh(int _)
	{
		this.TryRefreshTabShopList();
	}

	// Token: 0x0600F5E8 RID: 62952 RVA: 0x0047D43C File Offset: 0x0047B63C
	private unsafe void TryRefreshTabShopList()
	{
		if (this.TabComponent == null)
		{
			return;
		}
		List<int> list = this.BuildTabShopList();
		if (this.IsSameShopList(this.TabShopList, list))
		{
			return;
		}
		PayShopDefine.EPayShopTabType? payShopId = this.PayShopId;
		int num = 0;
		if (payShopId != null)
		{
			int num2 = list.IndexOf((int)payShopId.Value);
			if (num2 >= 0)
			{
				num = num2;
			}
		}
		this.TabShopList = list;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "PayShop:Root TabShopList可见性变更";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TabShopList", list);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SelectIndex", num);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.RefreshTabItem(this.TabShopList, num);
	}

	// Token: 0x0600F5E9 RID: 62953 RVA: 0x0047D500 File Offset: 0x0047B700
	private bool IsSameShopList(List<int> a, List<int> b)
	{
		if (a.Count != b.Count)
		{
			return false;
		}
		for (int i = 0; i < a.Count; i++)
		{
			if (a[i] != b[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600F5EA RID: 62954 RVA: 0x0047D541 File Offset: 0x0047B741
	private void RefreshAllPayShop(IEnumerable<PayShopDefine.EPayShopTabType> idList)
	{
		this.RefreshTabItem(this.TabShopList, 0);
	}

	// Token: 0x0600F5EB RID: 62955 RVA: 0x0047D550 File Offset: 0x0047B750
	private void RefreshTabItem(List<int> numberList, int selectedIndex = 0)
	{
		int length = numberList.Count;
		Action callBack = delegate()
		{
			for (int i = 0; i < length; i++)
			{
				PayShopTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(i);
				int num = this.TabShopList[i];
				UUIText nameTextComponent = tabItemByIndex.GetNameTextComponent();
				UiDynamicTab value = PayShopModel.Instance.GetTabInfoByPayShopIdId(num).Value;
				tabItemByIndex.RefreshContentItem((PayShopDefine.EPayShopTabType)num);
				tabItemByIndex.BindRedDot(ERedDotName.PayShopInstance, new int?(num));
				LguiUtil.Instance.SetLocalTextNew(nameTextComponent, value.TabName, Array.Empty<object>());
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Shop;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "PayShop:Root 选择页签";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Index", selectedIndex);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			TabComponentWithCaptionItem<PayShopTabItem> tabComponent = this.TabComponent;
			if (tabComponent == null)
			{
				return;
			}
			tabComponent.SelectToggleByIndex(selectedIndex, false);
		};
		this.TabComponent.RefreshTabItemByLength(length, callBack);
	}

	// Token: 0x0600F5EC RID: 62956 RVA: 0x0047D59C File Offset: 0x0047B79C
	public void SwitchPayShopTabItem(PayShopDefine.EPayShopTabType payShopId, int tabId)
	{
		int index = this.TabShopList.IndexOf((int)payShopId);
		if (this.PayShopViewData != null)
		{
			this.PayShopViewData.SwitchId = new int?(tabId);
		}
		else
		{
			this.PayShopViewData = new PayShopViewData();
			this.PayShopViewData.PayShopId = payShopId;
			this.PayShopViewData.SwitchId = new int?(tabId);
		}
		this.TabComponent.SelectToggleByIndex(index, true);
	}

	// Token: 0x0600F5ED RID: 62957 RVA: 0x0047D608 File Offset: 0x0047B808
	private void RefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
	{
		PayShopDefine.EPayShopTabType? payShopId = this.PayShopId;
		if (shopId == payShopId.GetValueOrDefault() & payShopId != null)
		{
			((IUiTabViewRefresh)this.TabViewComponent.GetCurrentTabView()).RefreshView(tabId);
		}
	}

	// Token: 0x0600F5EE RID: 62958 RVA: 0x0047D64C File Offset: 0x0047B84C
	private unsafe void SwitchPayShop(PayShopDefine.EPayShopTabType payShopId)
	{
		PayShopDefine.EPayShopTabType? targetPayShopId = this.TargetPayShopId;
		if (!(targetPayShopId.GetValueOrDefault() == payShopId & targetPayShopId != null))
		{
			return;
		}
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (platformSdk != null)
		{
			platformSdk.HidePlayStationStoreIcon();
		}
		int payShopInfoDynamicTabId = PayShopModel.Instance.GetPayShopInfoDynamicTabId(payShopId);
		EUiTabViewName euiTabViewName = (EUiTabViewName)DynamicTabConfig.Instance.GetTabViewConfById(payShopInfoDynamicTabId).ChildViewName;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "PayShop:Root 切换界面";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ViewName", euiTabViewName);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
		string item = "Switch";
		PayShopViewData payShopViewData = this.PayShopViewData;
		ptr = new ValueTuple<string, object>(item, (payShopViewData != null) ? payShopViewData.SwitchId : null);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		TabComponentWithCaptionItem<PayShopTabItem> tabComponent = this.TabComponent;
		if (tabComponent != null)
		{
			tabComponent.SetTitleIconVisible(true);
		}
		this.PayShopId = new PayShopDefine.EPayShopTabType?(payShopId);
		this.RefreshCurrency(payShopId);
		int index = this.TabShopList.IndexOf((int)payShopId);
		PayShopTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
		if (payShopId == PayShopDefine.EPayShopTabType.Recommend)
		{
			TabViewComponent<PayShopDefine.EPayShopTabType> tabViewComponent = this.TabViewComponent;
			EUiTabViewName viewName = euiTabViewName;
			CommonTabItemBase tabItem = tabItemByIndex;
			PayShopViewData payShopViewData2 = this.PayShopViewData;
			tabViewComponent.ToggleCallBack(payShopId, viewName, tabItem, (payShopViewData2 != null) ? payShopViewData2.RecommendId : null, null);
		}
		else
		{
			TabViewComponent<PayShopDefine.EPayShopTabType> tabViewComponent2 = this.TabViewComponent;
			EUiTabViewName viewName2 = euiTabViewName;
			CommonTabItemBase tabItem2 = tabItemByIndex;
			PayShopViewData payShopViewData3 = this.PayShopViewData;
			tabViewComponent2.ToggleCallBack(payShopId, viewName2, tabItem2, (payShopViewData3 != null) ? payShopViewData3.SwitchId : null, null);
		}
		TabComponentWithCaptionItem<PayShopTabItem> tabComponent2 = this.TabComponent;
		if (tabComponent2 != null)
		{
			tabComponent2.LateScrollToToggleByIndex(index);
		}
		this.UpdateGoodsList();
		this.UpdateInterval = new double?(0.0);
		if (this.PayShopViewData != null)
		{
			this.PayShopViewData.SwitchId = null;
			this.PayShopViewData.RecommendId = null;
		}
		if (payShopId == PayShopDefine.EPayShopTabType.Recharge)
		{
			LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.PayShopRechargeRedDot, true);
			EventSystem.Instance.Emit<PayShopDefine.EPayShopTabType>(EEventName.RefreshPayShopInstanceRedDot, payShopId);
		}
	}

	// Token: 0x0600F5EF RID: 62959 RVA: 0x0047D85C File Offset: 0x0047BA5C
	private void RefreshPayShop(int payShopId, bool ifItemRefresh)
	{
		if (ifItemRefresh)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PayShopRefresh);
			Action value = delegate()
			{
				this.UpdatePayShopView();
				this.CloseExchangePopView();
			};
			confirmBoxDataNew.FunctionMap.Add(1, value);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			Log.Instance.Info(ELogModule.Shop, ELogAuthor.XXJ, "PayShop:Root 商品数据不同步,打开弹窗", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x0600F5F0 RID: 62960 RVA: 0x0047D8BC File Offset: 0x0047BABC
	private void UpdatePayShopView()
	{
		((IUiTabViewRefresh)this.TabViewComponent.GetCurrentTabView()).RefreshView(null);
		this.UpdateGoodsList();
		CommonDefine.ICountDown payShopCountDownData = PayShopModel.Instance.GetPayShopCountDownData(this.PayShopId.Value);
		if (payShopCountDownData != null && payShopCountDownData.RemainingTime > TimeUtil.Instance.TimeDeviation)
		{
			this.UpdateInterval = new double?(payShopCountDownData.RemainingTime * 1000.0);
		}
		this.SendRequestState = false;
		this.TryRefreshTabShopList();
	}

	// Token: 0x0600F5F1 RID: 62961 RVA: 0x0047D938 File Offset: 0x0047BB38
	private void RefreshGoodsList(IReadOnlySet<int> tabSet)
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PayShopRefresh);
		Action value = delegate()
		{
			((IUiTabViewRefresh)this.TabViewComponent.GetCurrentTabView()).RefreshView(tabSet);
			this.UpdateGoodsList();
			this.CloseExchangePopView();
		};
		confirmBoxDataNew.FunctionMap.Add(1, value);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600F5F2 RID: 62962 RVA: 0x0047D988 File Offset: 0x0047BB88
	private void ShopVersionCodeChange()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PayShopRefresh);
		Action value = delegate()
		{
			base.CloseMe(null);
			this.CloseExchangePopView();
		};
		confirmBoxDataNew.FunctionMap.Add(1, value);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		Log.Instance.Info(ELogModule.Shop, ELogAuthor.XXJ, "PayShop:Root 商品VersionCode不同步,打开弹窗", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0600F5F3 RID: 62963 RVA: 0x0047D9E2 File Offset: 0x0047BBE2
	private void OnAccumulateCurrencyUpdate(string textId, IReadOnlyList<string> args)
	{
		PayShopAccumulateItem accumulateItem = this.AccumulateItem;
		if (accumulateItem != null)
		{
			accumulateItem.SetUiActive(true);
		}
		PayShopAccumulateItem accumulateItem2 = this.AccumulateItem;
		if (accumulateItem2 == null)
		{
			return;
		}
		accumulateItem2.RefreshTextById(textId, args);
	}

	// Token: 0x0600F5F4 RID: 62964 RVA: 0x0047DA08 File Offset: 0x0047BC08
	private void CloseExchangePopView()
	{
		UiManager.Instance.CloseView(EUiViewName.GiftPackageDetailsView, null);
		UiManager.Instance.CloseView(EUiViewName.ExchangePopView, null);
	}

	// Token: 0x0600F5F5 RID: 62965 RVA: 0x0047DA2C File Offset: 0x0047BC2C
	private void UnLockGoods(IReadOnlyDictionary<int, HashSet<int>> payShopSet)
	{
		HashSet<int> @params;
		if (payShopSet.TryGetValue((int)this.PayShopId.Value, out @params))
		{
			((IUiTabViewRefresh)this.TabViewComponent.GetCurrentTabView()).RefreshView(@params);
		}
	}

	// Token: 0x0600F5F6 RID: 62966 RVA: 0x0047DA64 File Offset: 0x0047BC64
	protected void UpdateTime(float delta)
	{
		if (this.UpdateInterval == null)
		{
			return;
		}
		double? updateInterval = this.UpdateInterval;
		double num = 0.0;
		if (updateInterval.GetValueOrDefault() > num & updateInterval != null)
		{
			this.UpdateInterval -= (double)delta;
			return;
		}
		this.RefreshCountDownText();
		CommonDefine.ICountDown payShopCountDownData = PayShopModel.Instance.GetPayShopCountDownData(this.PayShopId.Value);
		if (payShopCountDownData != null)
		{
			this.UpdateInterval = new double?(payShopCountDownData.RemainingTime * 1000.0);
		}
	}

	// Token: 0x0600F5F7 RID: 62967 RVA: 0x0047DB14 File Offset: 0x0047BD14
	protected void RefreshCountDownText()
	{
		if (this.PayShopId == null)
		{
			this.CountDownTextActive = false;
			base.GetItem(2).SetUIActive(false);
			this.UpdateInterval = null;
			return;
		}
		CommonDefine.ICountDown payShopCountDownData = PayShopModel.Instance.GetPayShopCountDownData(this.PayShopId.Value);
		if (payShopCountDownData == null)
		{
			this.CountDownTextActive = false;
			base.GetItem(2).SetUIActive(false);
			this.UpdateInterval = null;
			return;
		}
		if (payShopCountDownData.CountDownText == null)
		{
			this.CountDownTextActive = false;
			base.GetItem(2).SetUIActive(false);
			if (this.UpdateInterval != null)
			{
				double? updateInterval = this.UpdateInterval;
				double num = 0.0;
				if ((updateInterval.GetValueOrDefault() <= num & updateInterval != null) && !this.SendRequestState)
				{
					PayShopController.Instance.SendRequestPayShopUpdate(this.PayShopId.Value, false, null);
					this.SendRequestState = true;
				}
			}
			this.UpdateInterval = null;
			return;
		}
		if (!this.CountDownTextActive)
		{
			base.GetItem(2).SetUIActive(true);
			this.CountDownTextActive = true;
		}
		string endTimeShowText = PayShopGoods.GetEndTimeShowText(PayShopModel.Instance.GetPayShopUpdateTime(this.PayShopId.Value));
		LguiUtil.Instance.SetLocalText(this.CountDownText, "RefreshTime", new <>z__ReadOnlySingleElementList<object>(endTimeShowText));
	}

	// Token: 0x0600F5F8 RID: 62968 RVA: 0x0047DC5F File Offset: 0x0047BE5F
	protected void UpdateGoodsList()
	{
		this.GoodsList = PayShopModel.Instance.GetNeedCheckGoods(this.PayShopId.Value);
		this.AllowTick = true;
	}

	// Token: 0x0600F5F9 RID: 62969 RVA: 0x0047DC84 File Offset: 0x0047BE84
	protected void TickGoodList()
	{
		if (!this.AllowTick)
		{
			return;
		}
		if (this.GoodsList == null || this.GoodsList.Count <= 0)
		{
			this.AllowTick = false;
			return;
		}
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		foreach (PayShopGoods payShopGoods in this.GoodsList)
		{
			if (payShopGoods.NeedUpdate())
			{
				if (payShopGoods.IsDirect())
				{
					list.Add(payShopGoods.GetGoodsId());
				}
				else
				{
					list2.Add(payShopGoods.GetGoodsId());
				}
			}
		}
		if (list2.Count <= 0 && list.Count <= 0)
		{
			return;
		}
		this.AllowTick = false;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "请求刷新商品";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("goodsList", list2);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (list2.Count > 0)
		{
			PayShopController.Instance.SendRequestPayShopItemUpdate(list2.ToArray());
		}
		if (list.Count > 0)
		{
			PayGiftController.Instance.SendPayGiftInfoRequest(true);
		}
	}

	// Token: 0x0600F5FA RID: 62970 RVA: 0x0047DDA0 File Offset: 0x0047BFA0
	protected override void OnTick(float delta)
	{
		base.OnTick(delta);
		this.TickGoodList();
		this.UpdateTime(delta);
		TotalTopUpPageActivityEnterPanel totalTopUpEnterItem = this.TotalTopUpEnterItem;
		if (totalTopUpEnterItem == null)
		{
			return;
		}
		totalTopUpEnterItem.OnTick();
	}

	// Token: 0x04008A04 RID: 35332
	protected PayShopDefine.EPayShopTabType? PayShopId = new PayShopDefine.EPayShopTabType?(PayShopDefine.EPayShopTabType.Recommend);

	// Token: 0x04008A05 RID: 35333
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponentWithCaptionItem<PayShopTabItem> TabComponent;

	// Token: 0x04008A06 RID: 35334
	[Nullable(2)]
	protected TabViewComponent<PayShopDefine.EPayShopTabType> TabViewComponent;

	// Token: 0x04008A07 RID: 35335
	protected List<int> TabShopList = new List<int>();

	// Token: 0x04008A08 RID: 35336
	protected bool CountDownTextActive;

	// Token: 0x04008A09 RID: 35337
	[Nullable(2)]
	protected UUIText CountDownText;

	// Token: 0x04008A0A RID: 35338
	protected double? UpdateInterval;

	// Token: 0x04008A0B RID: 35339
	protected List<PayShopGoods> GoodsList = new List<PayShopGoods>();

	// Token: 0x04008A0C RID: 35340
	protected bool AllowTick;

	// Token: 0x04008A0D RID: 35341
	private bool SendRequestState;

	// Token: 0x04008A0E RID: 35342
	[Nullable(2)]
	protected PayShopViewData PayShopViewData;

	// Token: 0x04008A0F RID: 35343
	private PayShopDefine.EPayShopTabType? TargetPayShopId;

	// Token: 0x04008A10 RID: 35344
	[Nullable(2)]
	private PayShopAccumulateItem AccumulateItem;

	// Token: 0x04008A11 RID: 35345
	[Nullable(2)]
	private TotalTopUpPageActivityEnterPanel TotalTopUpEnterItem;

	// Token: 0x02007A7A RID: 31354
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04027B1C RID: 162588
		CaptionItem,
		// Token: 0x04027B1D RID: 162589
		Content,
		// Token: 0x04027B1E RID: 162590
		TimeItem,
		// Token: 0x04027B1F RID: 162591
		TimeText,
		// Token: 0x04027B20 RID: 162592
		UidText,
		// Token: 0x04027B21 RID: 162593
		ServiceItem,
		// Token: 0x04027B22 RID: 162594
		ServiceButton,
		// Token: 0x04027B23 RID: 162595
		ServiceRedDot,
		// Token: 0x04027B24 RID: 162596
		ExchangeShopTip,
		// Token: 0x04027B25 RID: 162597
		ShopRuleButton,
		// Token: 0x04027B26 RID: 162598
		AccumulateCurrencyItem
	}
}
