using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x020025F0 RID: 9712
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PowerController : UiControllerBase
{
	// Token: 0x17001952 RID: 6482
	// (get) Token: 0x06013C27 RID: 80935 RVA: 0x004F44C9 File Offset: 0x004F26C9
	protected override bool IsTickEvenPausedInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06013C28 RID: 80936 RVA: 0x004F44CC File Offset: 0x004F26CC
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.EnergyUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			EnergyUpdateNotify energyUpdateNotify = (EnergyUpdateNotify)msg;
			PowerModel.Instance.UpdatePowerData(energyUpdateNotify.UpdateInfoList.ToArray<EnergyInfo>());
		});
	}

	// Token: 0x06013C29 RID: 80937 RVA: 0x004F44FD File Offset: 0x004F26FD
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.EnergyUpdateNotify);
	}

	// Token: 0x06013C2A RID: 80938 RVA: 0x004F450F File Offset: 0x004F270F
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.BackLoginView, this.OnBackLoginView);
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
	}

	// Token: 0x06013C2B RID: 80939 RVA: 0x004F4543 File Offset: 0x004F2743
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.BackLoginView, this.OnBackLoginView);
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnLoadingNetDataDone));
	}

	// Token: 0x06013C2C RID: 80940 RVA: 0x004F4578 File Offset: 0x004F2778
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

	// Token: 0x06013C2D RID: 80941 RVA: 0x004F4600 File Offset: 0x004F2800
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

	// Token: 0x06013C2E RID: 80942 RVA: 0x004F4654 File Offset: 0x004F2854
	private UniTask UpdatePowerShopData()
	{
		PowerController.<UpdatePowerShopData>d__14 <UpdatePowerShopData>d__;
		<UpdatePowerShopData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdatePowerShopData>d__.<>1__state = -1;
		<UpdatePowerShopData>d__.<>t__builder.Start<PowerController.<UpdatePowerShopData>d__14>(ref <UpdatePowerShopData>d__);
		return <UpdatePowerShopData>d__.<>t__builder.Task;
	}

	// Token: 0x06013C2F RID: 80943 RVA: 0x004F4690 File Offset: 0x004F2890
	private void OnLoadingNetDataDone()
	{
		this.SendUpdatePowerRequest(PowerModel.Instance.PowerItemKeyArray);
		this.CancelTimer();
		this.CheckPowerTimer = TimerSystem.Instance.Forever(new TTimerAction(this.OnPowerTimer), 500f, 1f, null, null, true);
	}

	// Token: 0x06013C30 RID: 80944 RVA: 0x004F46DC File Offset: 0x004F28DC
	private void CancelTimer()
	{
		if (this.CheckPowerTimer == null)
		{
			return;
		}
		TimerSystem.Instance.Remove(this.CheckPowerTimer);
		this.CheckPowerTimer = null;
	}

	// Token: 0x06013C31 RID: 80945 RVA: 0x004F46FF File Offset: 0x004F28FF
	private void OnPowerTimer(float _)
	{
		PowerModel.Instance.UpdatePowerRenewTimer();
	}

	// Token: 0x06013C32 RID: 80946 RVA: 0x004F470B File Offset: 0x004F290B
	public bool GetIfCanRequestNewPower()
	{
		return TimeUtil.Instance.GetServerTime() - this.CurrentRequestPowerTime > 1.0;
	}

	// Token: 0x06013C33 RID: 80947 RVA: 0x004F472C File Offset: 0x004F292C
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
				PowerModel.Instance.UpdatePowerData(energySyncResponse.SyncInfoList.ToArray<EnergyInfo>());
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(energySyncResponse.ErrCode, 18125, null, true, true);
		}, 0);
	}

	// Token: 0x06013C34 RID: 80948 RVA: 0x004F478C File Offset: 0x004F298C
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

	// Token: 0x06013C35 RID: 80949 RVA: 0x004F49E8 File Offset: 0x004F2BE8
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

	// Token: 0x06013C36 RID: 80950 RVA: 0x004F4A34 File Offset: 0x004F2C34
	public UniTask UseSinglePowerRecoveryItem()
	{
		PowerController.<UseSinglePowerRecoveryItem>d__22 <UseSinglePowerRecoveryItem>d__;
		<UseSinglePowerRecoveryItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UseSinglePowerRecoveryItem>d__.<>1__state = -1;
		<UseSinglePowerRecoveryItem>d__.<>t__builder.Start<PowerController.<UseSinglePowerRecoveryItem>d__22>(ref <UseSinglePowerRecoveryItem>d__);
		return <UseSinglePowerRecoveryItem>d__.<>t__builder.Task;
	}

	// Token: 0x06013C37 RID: 80951 RVA: 0x004F4A70 File Offset: 0x004F2C70
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

	// Token: 0x06013C38 RID: 80952 RVA: 0x004F4AC5 File Offset: 0x004F2CC5
	public override bool Clear()
	{
		this.CancelTimer();
		return base.Clear();
	}

	// Token: 0x17001953 RID: 6483
	// (get) Token: 0x06013C39 RID: 80953 RVA: 0x004F4AD3 File Offset: 0x004F2CD3
	public static PowerController Instance
	{
		get
		{
			return PowerController._Instance;
		}
	}

	// Token: 0x06013C3A RID: 80954 RVA: 0x004F4ADA File Offset: 0x004F2CDA
	public static PowerController GetOrCreateInstance()
	{
		if (PowerController._Instance == null)
		{
			PowerController.CreateInstance();
		}
		return PowerController._Instance;
	}

	// Token: 0x06013C3B RID: 80955 RVA: 0x004F4AEE File Offset: 0x004F2CEE
	public static bool CreateInstance()
	{
		if (PowerController._Instance != null)
		{
			return true;
		}
		PowerController._Instance = new PowerController();
		return true;
	}

	// Token: 0x06013C3C RID: 80956 RVA: 0x004F4B04 File Offset: 0x004F2D04
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013C3D RID: 80957 RVA: 0x004F4B06 File Offset: 0x004F2D06
	public static void ResetStaticDefaultValue()
	{
		PowerController._Instance = null;
	}

	// Token: 0x06013C3E RID: 80958 RVA: 0x004F4B0E File Offset: 0x004F2D0E
	static PowerController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PowerController.CreateStaticDefaultValue), new Action(PowerController.ResetStaticDefaultValue));
	}

	// Token: 0x040094DC RID: 38108
	private const int DEFAULTEXCHANGETIME = 60;

	// Token: 0x040094DD RID: 38109
	private const int REQUESTPOWERGAP = 1;

	// Token: 0x040094DE RID: 38110
	private const int CHECKPOWERGAP = 500;

	// Token: 0x040094DF RID: 38111
	[Nullable(2)]
	private TimerHandle CheckPowerTimer;

	// Token: 0x040094E0 RID: 38112
	private double CurrentRequestPowerTime;

	// Token: 0x040094E1 RID: 38113
	private readonly Action OnBackLoginView = delegate()
	{
		if (UiManager.Instance.IsViewShow(EUiViewName.PowerView))
		{
			UiManager.Instance.CloseView(EUiViewName.PowerView, null);
		}
	};

	// Token: 0x040094E2 RID: 38114
	[Nullable(2)]
	private static PowerController _Instance;
}
