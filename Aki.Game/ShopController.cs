using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02001F66 RID: 8038
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ShopController : UiControllerBase
{
	// Token: 0x06013E24 RID: 81444 RVA: 0x005CC363 File Offset: 0x005CA563
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.CrossDay, new Action(this.OnCrossDay));
	}

	// Token: 0x06013E25 RID: 81445 RVA: 0x005CC381 File Offset: 0x005CA581
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.CrossDay, new Action(this.OnCrossDay));
	}

	// Token: 0x06013E26 RID: 81446 RVA: 0x005CC39F File Offset: 0x005CA59F
	private void OnCrossDay()
	{
		this.SendShopInfoRequest(ShopModel.Instance.VersionId).ContinueWith(delegate(bool success)
		{
			if (success)
			{
				EventSystem instance = EventSystem.Instance;
				EEventName name = EEventName.ShopUpdate;
				ShopItemFullInfo openItemInfo = ShopModel.Instance.OpenItemInfo;
				instance.Emit<int?>(name, (openItemInfo != null) ? new int?(openItemInfo.ShopId) : null);
			}
		});
	}

	// Token: 0x06013E27 RID: 81447 RVA: 0x005CC3D8 File Offset: 0x005CA5D8
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ShopInfoNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ShopInfoNotify shopInfoNotify = (ShopInfoNotify)msg;
			Log.Instance.Info(ELogModule.Shop, ELogAuthor.YSQ, "Receive ShopInfoNotify", default(ReadOnlySpan<ValueTuple<string, object>>));
			ShopModel.Instance.VersionId = shopInfoNotify.VersionStr;
			ShopModel.Instance.UpdateShopListData(shopInfoNotify.ShopList);
		});
		Net.Instance.Register(ENotifyMessageId.ShopUnlockNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ShopUnlockNotify shopUnlockNotify = (ShopUnlockNotify)msg;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Shop;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "Receive ShopUnlockNotify";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("unlockList", shopUnlockNotify.UnlockList);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.OnShopUnlockNotify(shopUnlockNotify);
		});
		Net.Instance.Register(ENotifyMessageId.ShopInfoUpdateNotify, this.OnShopInfoUpdateNotify);
	}

	// Token: 0x06013E28 RID: 81448 RVA: 0x005CC446 File Offset: 0x005CA646
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ShopInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ShopUnlockNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ShopInfoUpdateNotify);
	}

	// Token: 0x06013E29 RID: 81449 RVA: 0x005CC478 File Offset: 0x005CA678
	[NullableContext(2)]
	public bool OpenShop(int shopId, string uiCameraName = null, Action<bool, int> finishCallback = null)
	{
		if (ShopModel.Instance.IsOpen(shopId))
		{
			if (!UiManager.Instance.IsViewShow(EUiViewName.ShopView))
			{
				ShopOpenParam param = new ShopOpenParam
				{
					ShopId = shopId,
					UiCameraName = uiCameraName
				};
				UiManager.Instance.OpenView(EUiViewName.ShopView, param, delegate(bool success, int viewId)
				{
					Action<bool, int> finishCallback2 = finishCallback;
					if (finishCallback2 == null)
					{
						return;
					}
					finishCallback2(success, viewId);
				});
				return true;
			}
		}
		else if (GlobalData.World != null)
		{
			string shopName = ShopConfig.Instance.GetShopName(ShopModel.Instance.GetShopConfig(shopId).Value.ShopName);
			if (shopName != null)
			{
				ScrollingTipsController.Instance.ShowTipsById("ShopNotOpenTip", new object[]
				{
					shopName
				});
			}
		}
		return false;
	}

	// Token: 0x06013E2A RID: 81450 RVA: 0x005CC530 File Offset: 0x005CA730
	[NullableContext(2)]
	public unsafe void SendShopBuyRequest(int shopId, int itemId, int moneyId, int count, Action callback = null)
	{
		ShopBuyRequest shopBuyRequest = ShopBuyRequest.Create();
		shopBuyRequest.VersionStr = ShopModel.Instance.VersionId;
		shopBuyRequest.ShopId = shopId;
		shopBuyRequest.Id = itemId;
		shopBuyRequest.MoneyId = moneyId;
		shopBuyRequest.Num = count;
		shopBuyRequest.InteractEntityId = ShopModel.Instance.CurrentInteractCreatureDataLongId.GetValueOrDefault();
		Net.Instance.Call(ERequestMessageId.ShopBuyRequest, shopBuyRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ShopBuyResponse shopBuyResponse = (ShopBuyResponse)msg;
			if (shopBuyResponse == null)
			{
				return;
			}
			if (shopBuyResponse.ErrorCode == ErrorCode.Success)
			{
				ShopModel.Instance.UpdateItemData(shopBuyResponse);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Shop;
				ELogAuthor author = ELogAuthor.YZY;
				string message = "购买物品成功";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", shopBuyResponse.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("buyCount", shopBuyResponse.BoughtCount);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("response", shopBuyResponse);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				EventSystem.Instance.Emit<int, int>(EEventName.BoughtItem, shopId, itemId);
				if (callback != null)
				{
					callback();
					return;
				}
			}
			else
			{
				string textByErrorId = ErrorCodeConfig.Instance.GetTextByErrorId(shopBuyResponse.ErrorCode);
				ScrollingTipsController.Instance.ShowTipsByText(textByErrorId);
				EventSystem.Instance.Emit<int, int>(EEventName.BoughtItem, 0, 0);
			}
		}, 0);
	}

	// Token: 0x06013E2B RID: 81451 RVA: 0x005CC5C8 File Offset: 0x005CA7C8
	[NullableContext(0)]
	public UniTask<bool> SendShopInfoRequest([Nullable(1)] string version)
	{
		ShopController.<SendShopInfoRequest>d__7 <SendShopInfoRequest>d__;
		<SendShopInfoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<SendShopInfoRequest>d__.version = version;
		<SendShopInfoRequest>d__.<>1__state = -1;
		<SendShopInfoRequest>d__.<>t__builder.Start<ShopController.<SendShopInfoRequest>d__7>(ref <SendShopInfoRequest>d__);
		return <SendShopInfoRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06013E2C RID: 81452 RVA: 0x005CC60C File Offset: 0x005CA80C
	public UniTask SendShopUpdateRequestAsync(int shopId)
	{
		ShopController.<SendShopUpdateRequestAsync>d__8 <SendShopUpdateRequestAsync>d__;
		<SendShopUpdateRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SendShopUpdateRequestAsync>d__.shopId = shopId;
		<SendShopUpdateRequestAsync>d__.<>1__state = -1;
		<SendShopUpdateRequestAsync>d__.<>t__builder.Start<ShopController.<SendShopUpdateRequestAsync>d__8>(ref <SendShopUpdateRequestAsync>d__);
		return <SendShopUpdateRequestAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013E2D RID: 81453 RVA: 0x005CC650 File Offset: 0x005CA850
	public void SendShopUpdateRequest(int shopId)
	{
		ShopUpdateRequest shopUpdateRequest = ShopUpdateRequest.Create();
		shopUpdateRequest.ShopId = shopId;
		Net.Instance.Call(ERequestMessageId.ShopUpdateRequest, shopUpdateRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ShopUpdateResponse shopUpdateResponse = (ShopUpdateResponse)msg;
			if (shopUpdateResponse == null)
			{
				return;
			}
			if (shopUpdateResponse.ErrorCode == ErrorCode.Success)
			{
				ShopModel.Instance.UpdateShopData(shopUpdateResponse.Info);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(shopUpdateResponse.ErrorCode, 27292, null, true, true);
		}, 0);
	}

	// Token: 0x06013E2E RID: 81454 RVA: 0x005CC69C File Offset: 0x005CA89C
	public unsafe void OnShopUnlockNotify(ShopUnlockNotify notify)
	{
		foreach (UnlockInfo unlockInfo in notify.UnlockList)
		{
			if (ShopModel.Instance.GetShopInfo(unlockInfo.ShopId) != null)
			{
				ShopItemInfoNew shopItem = ShopModel.Instance.GetShopItem(unlockInfo.ShopId, unlockInfo.Id);
				if (shopItem != null)
				{
					shopItem.Lock = false;
					EventSystem.Instance.Emit(EEventName.OnGoodUnlock);
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Shop;
					ELogAuthor author = ELogAuthor.YZY;
					string message = "新商品解锁";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("id", unlockInfo.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("buyCount", unlockInfo.ShopId);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					EventSystem.Instance.Emit<int?>(EEventName.ShopUpdate, new int?(unlockInfo.ShopId));
				}
			}
		}
	}

	// Token: 0x17001E10 RID: 7696
	// (get) Token: 0x06013E2F RID: 81455 RVA: 0x005CC7B4 File Offset: 0x005CA9B4
	public static ShopController Instance
	{
		get
		{
			return ShopController._Instance;
		}
	}

	// Token: 0x06013E30 RID: 81456 RVA: 0x005CC7BB File Offset: 0x005CA9BB
	public static ShopController GetOrCreateInstance()
	{
		if (ShopController._Instance == null)
		{
			ShopController.CreateInstance();
		}
		return ShopController._Instance;
	}

	// Token: 0x06013E31 RID: 81457 RVA: 0x005CC7CF File Offset: 0x005CA9CF
	public static bool CreateInstance()
	{
		if (ShopController._Instance != null)
		{
			return true;
		}
		ShopController._Instance = new ShopController();
		return true;
	}

	// Token: 0x06013E32 RID: 81458 RVA: 0x005CC7E5 File Offset: 0x005CA9E5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013E33 RID: 81459 RVA: 0x005CC7E7 File Offset: 0x005CA9E7
	public static void ResetStaticDefaultValue()
	{
		ShopController._Instance = null;
	}

	// Token: 0x06013E34 RID: 81460 RVA: 0x005CC7EF File Offset: 0x005CA9EF
	static ShopController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ShopController.CreateStaticDefaultValue), new Action(ShopController.ResetStaticDefaultValue));
	}

	// Token: 0x0400A97D RID: 43389
	[Nullable(new byte[]
	{
		1,
		2,
		2
	})]
	public readonly Action<IMessage, Net.CallbackStatus> OnShopInfoUpdateNotify = delegate(IMessage msg, Net.CallbackStatus _)
	{
		ShopInfoUpdateNotify shopInfoUpdateNotify = (ShopInfoUpdateNotify)msg;
		ShopModel.Instance.UpdateShopData(shopInfoUpdateNotify.ShopInfo);
	};

	// Token: 0x0400A97E RID: 43390
	[Nullable(2)]
	private static ShopController _Instance;
}
