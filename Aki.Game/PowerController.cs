using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02001ADB RID: 6875
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PowerController : UiControllerBase
{
	// Token: 0x1700198A RID: 6538
	// (get) Token: 0x06011109 RID: 69897 RVA: 0x00503255 File Offset: 0x00501455
	protected override bool IsTickEvenPausedInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0601110A RID: 69898 RVA: 0x00503258 File Offset: 0x00501458
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.EnergyUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			EnergyUpdateNotify energyUpdateNotify = (EnergyUpdateNotify)msg;
			EnergyInfo[] array = new EnergyInfo[energyUpdateNotify.UpdateInfoList.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = energyUpdateNotify.UpdateInfoList[i];
			}
			PowerModel.Instance.UpdatePowerData(array);
		});
	}

	// Token: 0x0601110B RID: 69899 RVA: 0x00503289 File Offset: 0x00501489
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.EnergyUpdateNotify);
	}

	// Token: 0x0601110C RID: 69900 RVA: 0x0050329B File Offset: 0x0050149B
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.BackLoginView, this.OnBackLoginView);
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
	}

	// Token: 0x0601110D RID: 69901 RVA: 0x005032CF File Offset: 0x005014CF
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.BackLoginView, this.OnBackLoginView);
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
	}

	// Token: 0x0601110E RID: 69902 RVA: 0x00503304 File Offset: 0x00501504
	public void OpenPowerView(EPowerMenuType powerMenuType = EPowerMenuType.Supply, int requirePower = 0)
	{
		if (!FunctionModel.Instance.IsOpen(10017))
		{
			return;
		}
		if (UiManager.Instance.IsViewOpen(EUiViewName.PowerView))
		{
			return;
		}
		if (PowerModel.Instance.PowerCount >= PowerConfig.Instance.GetPowerChargeLimit())
		{
			ScrollingTipsController.Instance.ShowTipsById("PowerBound", Array.Empty<object>());
			return;
		}
		this.UpdatePowerShopData().ContinueWith(delegate()
		{
			bool flag = requirePower == 0;
			PowerModel.Instance.CurrentNeedPower = (flag ? 60 : requirePower);
			int autoClosePowerCount = flag ? PowerConfig.Instance.GetPowerChargeLimit() : (requirePower + PowerModel.Instance.PowerCount);
			PowerConfirmBoxData param = new PowerConfirmBoxData(PowerModel.Instance.PowerCount, powerMenuType, !flag, autoClosePowerCount);
			UiManager.Instance.OpenView(EUiViewName.PowerView, param, null);
		});
	}

	// Token: 0x0601110F RID: 69903 RVA: 0x0050338C File Offset: 0x0050158C
	private UniTask TryExchangePowerRecoveryItem(int itemId, int num)
	{
		PowerController.<TryExchangePowerRecoveryItem>d__13 <TryExchangePowerRecoveryItem>d__;
		<TryExchangePowerRecoveryItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TryExchangePowerRecoveryItem>d__.<>4__this = this;
		<TryExchangePowerRecoveryItem>d__.itemId = itemId;
		<TryExchangePowerRecoveryItem>d__.num = num;
		<TryExchangePowerRecoveryItem>d__.<>1__state = -1;
		<TryExchangePowerRecoveryItem>d__.<>t__builder.Start<PowerController.<TryExchangePowerRecoveryItem>d__13>(ref <TryExchangePowerRecoveryItem>d__);
		return <TryExchangePowerRecoveryItem>d__.<>t__builder.Task;
	}

	// Token: 0x06011110 RID: 69904 RVA: 0x005033E0 File Offset: 0x005015E0
	private UniTask UpdatePowerShopData()
	{
		PowerController.<UpdatePowerShopData>d__14 <UpdatePowerShopData>d__;
		<UpdatePowerShopData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdatePowerShopData>d__.<>1__state = -1;
		<UpdatePowerShopData>d__.<>t__builder.Start<PowerController.<UpdatePowerShopData>d__14>(ref <UpdatePowerShopData>d__);
		return <UpdatePowerShopData>d__.<>t__builder.Task;
	}

	// Token: 0x06011111 RID: 69905 RVA: 0x0050341C File Offset: 0x0050161C
	private void OnLoadingNetDataDone()
	{
		this.SendUpdatePowerRequest(PowerModel.Instance.PowerItemKeyArray);
		this.CancelTimer();
		this.CheckPowerTimer = TimerSystem.Instance.Forever(new TTimerAction(this.OnPowerTimer), 500f, 1f, null, null, true);
	}

	// Token: 0x06011112 RID: 69906 RVA: 0x00503468 File Offset: 0x00501668
	private void CancelTimer()
	{
		if (this.CheckPowerTimer == null)
		{
			return;
		}
		TimerSystem.Instance.Remove(this.CheckPowerTimer);
		this.CheckPowerTimer = null;
	}

	// Token: 0x06011113 RID: 69907 RVA: 0x0050348B File Offset: 0x0050168B
	private void OnPowerTimer(float _)
	{
		PowerModel.Instance.UpdatePowerRenewTimer();
	}

	// Token: 0x06011114 RID: 69908 RVA: 0x00503497 File Offset: 0x00501697
	public bool GetIfCanRequestNewPower()
	{
		return TimeUtil.Instance.GetServerTime() - this.CurrentRequestPowerTime > 1.0;
	}

	// Token: 0x06011115 RID: 69909 RVA: 0x005034B8 File Offset: 0x005016B8
	public void SendUpdatePowerRequest(int[] itemList)
	{
		EnergySyncRequest energySyncRequest = EnergySyncRequest.Create();
		energySyncRequest.Ids.AddRange(itemList);
		this.CurrentRequestPowerTime = TimeUtil.Instance.GetServerTime();
		Net.Instance.Call(ERequestMessageId.EnergySyncRequest, energySyncRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			EnergySyncResponse energySyncResponse = (EnergySyncResponse)msg;
			if (energySyncResponse == null)
			{
				return;
			}
			if (energySyncResponse.ErrCode == Aki.Protocol.ErrorCode.Success)
			{
				EnergyInfo[] array = new EnergyInfo[energySyncResponse.SyncInfoList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = energySyncResponse.SyncInfoList[i];
				}
				PowerModel.Instance.UpdatePowerData(array);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(energySyncResponse.ErrCode, 16637, null, true, true);
		}, 0);
	}

	// Token: 0x06011116 RID: 69910 RVA: 0x00503518 File Offset: 0x00501718
	public unsafe void OpenOverPowerExchangeView()
	{
		PowerData powerDataById = PowerModel.Instance.GetPowerDataById(5);
		PowerData powerDataById2 = PowerModel.Instance.GetPowerDataById(6);
		int num = PowerConfig.Instance.GetPowerChargeLimit() - powerDataById.GetCurrentPower();
		if (num == 0)
		{
			ScrollingTipsController.Instance.ShowTipsByText(ConfigMultiTextLang.GetLocalTextNew("PowerMaxCannotExchange", null));
			return;
		}
		if (powerDataById2.GetCurrentPower() == 0)
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(ConfigItemInfoById.GetConfig(6, true).Value.Name, null);
			string text = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("PowerPropsCannotExchange", null), new string[]
			{
				localTextNew
			});
			ScrollingTipsController.Instance.ShowTipsByText(text);
			return;
		}
		CommonExchangeData commonExchangeData = new CommonExchangeData();
		commonExchangeData.InitBySrcAndDestItemId(6, 5, new int?(powerDataById2.GetCurrentPower()), new int?(powerDataById.GetCurrentPower()));
		commonExchangeData.ConfirmCallBack = delegate(int itemId, int exChangeTime)
		{
			ShopFixed value = PowerModel.Instance.GetOverPowerShopConfig().Value;
			int moneyId = 6;
			if (value.PriceLength > 0)
			{
				moneyId = value.Price(0).Value.Key;
			}
			ShopController.Instance.SendShopBuyRequest(value.ShopId, value.Id, moneyId, exChangeTime, delegate
			{
				ScrollingTipsController.Instance.ShowTipsById("PowerBuySucceed", new object[]
				{
					exChangeTime.ToString()
				});
			});
		};
		CommonExchangeViewData commonExchangeViewData = new CommonExchangeViewData();
		int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(commonExchangeData.GetSrcItemId(), 0);
		commonExchangeViewData.GetGainCount = ((int itemId, int exchangeCount) => exchangeCount);
		commonExchangeViewData.GetConsumeCount = ((int itemId, int exchangeCount) => exchangeCount);
		commonExchangeViewData.GetConsumeTotalCount = ((int consumeCount, int exchangeTime) => exchangeTime);
		CommonExchangeViewData commonExchangeViewData2 = commonExchangeViewData;
		int num2 = 2;
		List<int> list = new List<int>(num2);
		CollectionsMarshal.SetCount<int>(list, num2);
		Span<int> span = CollectionsMarshal.AsSpan<int>(list);
		int num3 = 0;
		*span[num3] = 6;
		num3++;
		*span[num3] = 5;
		commonExchangeViewData2.ShowCurrencyList = list;
		if (PowerModel.Instance.CurrentNeedPower > 0)
		{
			commonExchangeViewData.StartSliderValue = ((PowerModel.Instance.CurrentNeedPower <= powerDataById2.GetCurrentPower()) ? PowerModel.Instance.CurrentNeedPower : powerDataById2.GetCurrentPower());
		}
		int num4 = PowerConfig.Instance.GetSingleTimeExchangePowerLimit();
		if (num < PowerConfig.Instance.GetSingleTimeExchangePowerLimit())
		{
			num4 = num;
		}
		if (num4 > powerDataById2.GetCurrentPower())
		{
			num4 = powerDataById2.GetCurrentPower();
		}
		commonExchangeViewData.StartSliderValue = ((commonExchangeViewData.StartSliderValue > num4) ? num4 : commonExchangeViewData.StartSliderValue);
		commonExchangeViewData.CreateData(commonExchangeData, num4, itemCountByConfigId);
		UiManager.Instance.OpenView(EUiViewName.CommonExchangeView, commonExchangeViewData, null);
	}

	// Token: 0x06011117 RID: 69911 RVA: 0x00503774 File Offset: 0x00501974
	public UniTask OpenPowerRecoveryExchangeView(EPowerRecoveryItem powerRecoveryItemId)
	{
		PowerController.<OpenPowerRecoveryExchangeView>d__21 <OpenPowerRecoveryExchangeView>d__;
		<OpenPowerRecoveryExchangeView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenPowerRecoveryExchangeView>d__.<>4__this = this;
		<OpenPowerRecoveryExchangeView>d__.powerRecoveryItemId = powerRecoveryItemId;
		<OpenPowerRecoveryExchangeView>d__.<>1__state = -1;
		<OpenPowerRecoveryExchangeView>d__.<>t__builder.Start<PowerController.<OpenPowerRecoveryExchangeView>d__21>(ref <OpenPowerRecoveryExchangeView>d__);
		return <OpenPowerRecoveryExchangeView>d__.<>t__builder.Task;
	}

	// Token: 0x06011118 RID: 69912 RVA: 0x005037C0 File Offset: 0x005019C0
	public UniTask UseSinglePowerRecoveryItem()
	{
		PowerController.<UseSinglePowerRecoveryItem>d__22 <UseSinglePowerRecoveryItem>d__;
		<UseSinglePowerRecoveryItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UseSinglePowerRecoveryItem>d__.<>1__state = -1;
		<UseSinglePowerRecoveryItem>d__.<>t__builder.Start<PowerController.<UseSinglePowerRecoveryItem>d__22>(ref <UseSinglePowerRecoveryItem>d__);
		return <UseSinglePowerRecoveryItem>d__.<>t__builder.Task;
	}

	// Token: 0x06011119 RID: 69913 RVA: 0x005037FC File Offset: 0x005019FC
	public void ExchangePower(PowerItemInfo itemInfo, int costCount, [Nullable(2)] Action callback = null)
	{
		int itemId = itemInfo.ItemId;
		if (itemId == 6)
		{
			this.OpenOverPowerExchangeView();
			return;
		}
		if (itemId != 10800)
		{
			ShopController.Instance.SendShopBuyRequest(itemInfo.ShopId, itemInfo.GoodsId, itemInfo.ItemId, costCount, callback);
			return;
		}
		this.OpenPowerRecoveryExchangeView((EPowerRecoveryItem)itemInfo.ItemId);
	}

	// Token: 0x0601111A RID: 69914 RVA: 0x00503851 File Offset: 0x00501A51
	public override bool Clear()
	{
		this.CancelTimer();
		return base.Clear();
	}

	// Token: 0x1700198B RID: 6539
	// (get) Token: 0x0601111B RID: 69915 RVA: 0x0050385F File Offset: 0x00501A5F
	public static PowerController Instance
	{
		get
		{
			return PowerController._Instance;
		}
	}

	// Token: 0x0601111C RID: 69916 RVA: 0x00503866 File Offset: 0x00501A66
	public static PowerController GetOrCreateInstance()
	{
		if (PowerController._Instance == null)
		{
			PowerController.CreateInstance();
		}
		return PowerController._Instance;
	}

	// Token: 0x0601111D RID: 69917 RVA: 0x0050387A File Offset: 0x00501A7A
	public static bool CreateInstance()
	{
		if (PowerController._Instance != null)
		{
			return true;
		}
		PowerController._Instance = new PowerController();
		return true;
	}

	// Token: 0x0601111E RID: 69918 RVA: 0x00503890 File Offset: 0x00501A90
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601111F RID: 69919 RVA: 0x00503892 File Offset: 0x00501A92
	public static void ResetStaticDefaultValue()
	{
		PowerController._Instance = null;
	}

	// Token: 0x06011120 RID: 69920 RVA: 0x0050389A File Offset: 0x00501A9A
	static PowerController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PowerController.CreateStaticDefaultValue), new Action(PowerController.ResetStaticDefaultValue));
	}

	// Token: 0x04009633 RID: 38451
	private const int DEFAULTEXCHANGETIME = 60;

	// Token: 0x04009634 RID: 38452
	private const int REQUESTPOWERGAP = 1;

	// Token: 0x04009635 RID: 38453
	private const int CHECKPOWERGAP = 500;

	// Token: 0x04009636 RID: 38454
	[Nullable(2)]
	private TimerHandle CheckPowerTimer;

	// Token: 0x04009637 RID: 38455
	private double CurrentRequestPowerTime;

	// Token: 0x04009638 RID: 38456
	private readonly Action OnBackLoginView = delegate()
	{
		if (UiManager.Instance.IsViewShow(EUiViewName.PowerView))
		{
			UiManager.Instance.CloseView(EUiViewName.PowerView, null);
		}
	};

	// Token: 0x04009639 RID: 38457
	[Nullable(2)]
	private static PowerController _Instance;
}
