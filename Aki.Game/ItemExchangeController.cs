using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x020014BB RID: 5307
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ItemExchangeController : UiControllerBase
{
	// Token: 0x17001391 RID: 5009
	// (get) Token: 0x0600D472 RID: 54386 RVA: 0x003F2A3C File Offset: 0x003F0C3C
	public bool NeedPop
	{
		get
		{
			return this.NeedPopInternal;
		}
	}

	// Token: 0x0600D473 RID: 54387 RVA: 0x003F2A44 File Offset: 0x003F0C44
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.ItemExchangeInfoRequest));
		EventSystem.Instance.Add(EEventName.CrossDay, new Action(this.ItemExchange));
	}

	// Token: 0x0600D474 RID: 54388 RVA: 0x003F2A7E File Offset: 0x003F0C7E
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.ItemExchangeInfoRequest));
		EventSystem.Instance.Remove(EEventName.CrossDay, new Action(this.ItemExchange));
	}

	// Token: 0x0600D475 RID: 54389 RVA: 0x003F2AB8 File Offset: 0x003F0CB8
	private void ItemExchange()
	{
		LoginDefine.ELoginStatus loginStatus = LoginModel.Instance.GetLoginStatus();
		if (loginStatus < LoginDefine.ELoginStatus.EnterGameRet)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ItemExchange;
			ELogAuthor author = ELogAuthor.ZJC;
			string message = "登录状态错误, 无法请求物品兑换数据";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("loginStatus", loginStatus);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.ItemExchangeInfoRequest();
	}

	// Token: 0x0600D476 RID: 54390 RVA: 0x003F2B0C File Offset: 0x003F0D0C
	private void ItemExchangeInfoRequest()
	{
		ItemExchangeInfoRequest message = Aki.Protocol.ItemExchangeInfoRequest.Create();
		Net.Instance.Call(ERequestMessageId.ItemExchangeInfoRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ItemExchangeInfoResponse itemExchangeInfoResponse = (ItemExchangeInfoResponse)msg;
			ItemExchangeModel.Instance.InitItemExchangeTimeInfo(itemExchangeInfoResponse.ItemExchangeInfos);
		}, 0);
	}

	// Token: 0x0600D477 RID: 54391 RVA: 0x003F2B4F File Offset: 0x003F0D4F
	private void ItemExchangeRequest(int itemId, int exchangeTimes)
	{
		this.ItemExchangeRequest(itemId, exchangeTimes, true, null);
	}

	// Token: 0x0600D478 RID: 54392 RVA: 0x003F2B5C File Offset: 0x003F0D5C
	[NullableContext(2)]
	public void ItemExchangeRequest(int itemId, int exchangeTimes, bool needPop = true, Action<int, int> callback = null)
	{
		if (exchangeTimes == 0)
		{
			return;
		}
		this.NeedPopInternal = needPop;
		ItemExchangeRequest itemExchangeRequest = Aki.Protocol.ItemExchangeRequest.Create();
		itemExchangeRequest.ItemId = itemId;
		itemExchangeRequest.ExchangeTimes = exchangeTimes;
		Net.Instance.Call(ERequestMessageId.ItemExchangeRequest, itemExchangeRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ItemExchangeResponse itemExchangeResponse = (ItemExchangeResponse)msg;
			this.NeedPopInternal = true;
			if (itemExchangeResponse == null)
			{
				return;
			}
			if (itemExchangeResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(itemExchangeResponse.ErrorCode, 24645, null, true, true);
				return;
			}
			ItemExchangeModel.Instance.AddExchangeTime(itemId, exchangeTimes);
			EventSystem.Instance.Emit<int, int>(EEventName.ItemExChangeResponse, itemExchangeResponse.ItemId, itemExchangeResponse.ItemCount);
			if (callback != null)
			{
				callback(itemExchangeResponse.ItemId, itemExchangeResponse.ItemCount);
			}
		}, 0);
	}

	// Token: 0x0600D479 RID: 54393 RVA: 0x003F2BD8 File Offset: 0x003F0DD8
	[NullableContext(2)]
	public void OpenExchangeViewByItemId(int itemId, Action<int, int> confirmCallBack = null, bool confirmNoClose = false)
	{
		CommonExchangeData commonExchangeData = new CommonExchangeData();
		commonExchangeData.InitByItemId(itemId);
		commonExchangeData.ConfirmNoClose = confirmNoClose;
		commonExchangeData.ConfirmCallBack = confirmCallBack;
		if (commonExchangeData.ConfirmCallBack == null)
		{
			commonExchangeData.ConfirmCallBack = new Action<int, int>(this.ItemExchangeRequest);
		}
		this.OpenExchangeViewByData(commonExchangeData);
	}

	// Token: 0x0600D47A RID: 54394 RVA: 0x003F2C24 File Offset: 0x003F0E24
	public void OpenExchangeViewByData(CommonExchangeData data)
	{
		CommonExchangeViewData commonExchangeViewData = new CommonExchangeViewData();
		int maxExChangeTime = ItemExchangeModel.Instance.GetMaxExChangeTime(data.GetDestItemId());
		int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(data.GetSrcItemId(), 0);
		commonExchangeViewData.GetGainCount = ((int itemId, int exchangeCount) => ItemExchangeModel.Instance.GetCurExchangeInfo(itemId, exchangeCount).GainCount);
		commonExchangeViewData.GetConsumeCount = ((int itemId, int exchangeCount) => ItemExchangeModel.Instance.GetCurExchangeInfo(itemId, exchangeCount).ConsumeCount);
		commonExchangeViewData.GetConsumeTotalCount = ((int consumeCount, int exchangeTime) => consumeCount * exchangeTime);
		commonExchangeViewData.CreateData(data, maxExChangeTime, itemCountByConfigId);
		UiManager.Instance.OpenView(EUiViewName.CommonExchangeView, commonExchangeViewData, null);
	}

	// Token: 0x17001392 RID: 5010
	// (get) Token: 0x0600D47B RID: 54395 RVA: 0x003F2CE3 File Offset: 0x003F0EE3
	public static ItemExchangeController Instance
	{
		get
		{
			return ItemExchangeController._Instance;
		}
	}

	// Token: 0x0600D47C RID: 54396 RVA: 0x003F2CEA File Offset: 0x003F0EEA
	public static ItemExchangeController GetOrCreateInstance()
	{
		if (ItemExchangeController._Instance == null)
		{
			ItemExchangeController.CreateInstance();
		}
		return ItemExchangeController._Instance;
	}

	// Token: 0x0600D47D RID: 54397 RVA: 0x003F2CFE File Offset: 0x003F0EFE
	public static bool CreateInstance()
	{
		if (ItemExchangeController._Instance != null)
		{
			return true;
		}
		ItemExchangeController._Instance = new ItemExchangeController();
		return true;
	}

	// Token: 0x0600D47E RID: 54398 RVA: 0x003F2D14 File Offset: 0x003F0F14
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D47F RID: 54399 RVA: 0x003F2D16 File Offset: 0x003F0F16
	public static void ResetStaticDefaultValue()
	{
		ItemExchangeController._Instance = null;
	}

	// Token: 0x0600D480 RID: 54400 RVA: 0x003F2D1E File Offset: 0x003F0F1E
	static ItemExchangeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ItemExchangeController.CreateStaticDefaultValue), new Action(ItemExchangeController.ResetStaticDefaultValue));
	}

	// Token: 0x04007761 RID: 30561
	private bool NeedPopInternal = true;

	// Token: 0x04007762 RID: 30562
	[Nullable(2)]
	private static ItemExchangeController _Instance;
}
