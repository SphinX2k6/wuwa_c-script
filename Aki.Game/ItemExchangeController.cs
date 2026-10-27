using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x02001FE8 RID: 8168
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ItemExchangeController : UiControllerBase
{
	// Token: 0x17001364 RID: 4964
	// (get) Token: 0x0601000A RID: 65546 RVA: 0x003E643C File Offset: 0x003E463C
	public bool NeedPop
	{
		get
		{
			return this.NeedPopInternal;
		}
	}

	// Token: 0x0601000B RID: 65547 RVA: 0x003E6444 File Offset: 0x003E4644
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.ItemExchangeInfoRequest));
		EventSystem.Instance.Add(EEventName.CrossDay, new Action(this.ItemExchange));
	}

	// Token: 0x0601000C RID: 65548 RVA: 0x003E647E File Offset: 0x003E467E
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.ItemExchangeInfoRequest));
		EventSystem.Instance.Remove(EEventName.CrossDay, new Action(this.ItemExchange));
	}

	// Token: 0x0601000D RID: 65549 RVA: 0x003E64B8 File Offset: 0x003E46B8
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

	// Token: 0x0601000E RID: 65550 RVA: 0x003E650C File Offset: 0x003E470C
	private void ItemExchangeInfoRequest()
	{
		ItemExchangeInfoRequest message = Aki.Protocol.ItemExchangeInfoRequest.Create();
		Net.Instance.Call(ERequestMessageId.ItemExchangeInfoRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ItemExchangeInfoResponse itemExchangeInfoResponse = (ItemExchangeInfoResponse)msg;
			ItemExchangeModel.Instance.InitItemExchangeTimeInfo(itemExchangeInfoResponse.ItemExchangeInfos.ToList<ItemExchangeInfo>());
		}, 0);
	}

	// Token: 0x0601000F RID: 65551 RVA: 0x003E654F File Offset: 0x003E474F
	private void ItemExchangeRequest(int itemId, int exchangeTimes)
	{
		this.ItemExchangeRequest(itemId, exchangeTimes, true, null);
	}

	// Token: 0x06010010 RID: 65552 RVA: 0x003E655C File Offset: 0x003E475C
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(itemExchangeResponse.ErrorCode, 23286, null, true, true);
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

	// Token: 0x06010011 RID: 65553 RVA: 0x003E65D8 File Offset: 0x003E47D8
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

	// Token: 0x06010012 RID: 65554 RVA: 0x003E6624 File Offset: 0x003E4824
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

	// Token: 0x17001365 RID: 4965
	// (get) Token: 0x06010013 RID: 65555 RVA: 0x003E66E3 File Offset: 0x003E48E3
	public static ItemExchangeController Instance
	{
		get
		{
			return ItemExchangeController._Instance;
		}
	}

	// Token: 0x06010014 RID: 65556 RVA: 0x003E66EA File Offset: 0x003E48EA
	public static ItemExchangeController GetOrCreateInstance()
	{
		if (ItemExchangeController._Instance == null)
		{
			ItemExchangeController.CreateInstance();
		}
		return ItemExchangeController._Instance;
	}

	// Token: 0x06010015 RID: 65557 RVA: 0x003E66FE File Offset: 0x003E48FE
	public static bool CreateInstance()
	{
		if (ItemExchangeController._Instance != null)
		{
			return true;
		}
		ItemExchangeController._Instance = new ItemExchangeController();
		return true;
	}

	// Token: 0x06010016 RID: 65558 RVA: 0x003E6714 File Offset: 0x003E4914
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010017 RID: 65559 RVA: 0x003E6716 File Offset: 0x003E4916
	public static void ResetStaticDefaultValue()
	{
		ItemExchangeController._Instance = null;
	}

	// Token: 0x06010018 RID: 65560 RVA: 0x003E671E File Offset: 0x003E491E
	static ItemExchangeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ItemExchangeController.CreateStaticDefaultValue), new Action(ItemExchangeController.ResetStaticDefaultValue));
	}

	// Token: 0x04007678 RID: 30328
	private bool NeedPopInternal = true;

	// Token: 0x04007679 RID: 30329
	[Nullable(2)]
	private static ItemExchangeController _Instance;
}
