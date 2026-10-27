using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x020029EB RID: 10731
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ShopController : UiControllerBase
{
	// Token: 0x0601641D RID: 91165 RVA: 0x005A136F File Offset: 0x0059F56F
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.CrossDay, new Action(this.OnCrossDay));
	}

	// Token: 0x0601641E RID: 91166 RVA: 0x005A138D File Offset: 0x0059F58D
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.CrossDay, new Action(this.OnCrossDay));
	}

	// Token: 0x0601641F RID: 91167 RVA: 0x005A13AB File Offset: 0x0059F5AB
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

	// Token: 0x06016420 RID: 91168 RVA: 0x005A13E4 File Offset: 0x0059F5E4
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ShopInfoNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ShopInfoNotify shopInfoNotify = (ShopInfoNotify)msg;
			Log.Instance.Info(ELogModule.Shop, ELogAuthor.YSQ, "Receive ShopInfoNotify", default(ReadOnlySpan<ValueTuple<string, object>>));
			ShopModel.Instance.VersionId = shopInfoNotify.VersionStr;
			ShopModel.Instance.UpdateShopListData(shopInfoNotify.ShopList.ToList<ShopInfo>());
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

	// Token: 0x06016421 RID: 91169 RVA: 0x005A1452 File Offset: 0x0059F652
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ShopInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ShopUnlockNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ShopInfoUpdateNotify);
	}

	// Token: 0x06016422 RID: 91170 RVA: 0x005A1484 File Offset: 0x0059F684
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

	// Token: 0x06016423 RID: 91171 RVA: 0x005A153C File Offset: 0x0059F73C
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

	// Token: 0x06016424 RID: 91172 RVA: 0x005A15D4 File Offset: 0x0059F7D4
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

	// Token: 0x06016425 RID: 91173 RVA: 0x005A1618 File Offset: 0x0059F818
	public UniTask SendShopUpdateRequestAsync(int shopId)
	{
		ShopController.<SendShopUpdateRequestAsync>d__8 <SendShopUpdateRequestAsync>d__;
		<SendShopUpdateRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SendShopUpdateRequestAsync>d__.shopId = shopId;
		<SendShopUpdateRequestAsync>d__.<>1__state = -1;
		<SendShopUpdateRequestAsync>d__.<>t__builder.Start<ShopController.<SendShopUpdateRequestAsync>d__8>(ref <SendShopUpdateRequestAsync>d__);
		return <SendShopUpdateRequestAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016426 RID: 91174 RVA: 0x005A165C File Offset: 0x0059F85C
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
			ErrorCodeController.Instance.OpenErrorCodeTipView(shopUpdateResponse.ErrorCode, 28984, null, true, true);
		}, 0);
	}

	// Token: 0x06016427 RID: 91175 RVA: 0x005A16A8 File Offset: 0x0059F8A8
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

	// Token: 0x17001DB7 RID: 7607
	// (get) Token: 0x06016428 RID: 91176 RVA: 0x005A17C0 File Offset: 0x0059F9C0
	public static ShopController Instance
	{
		get
		{
			return ShopController._Instance;
		}
	}

	// Token: 0x06016429 RID: 91177 RVA: 0x005A17C7 File Offset: 0x0059F9C7
	public static ShopController GetOrCreateInstance()
	{
		if (ShopController._Instance == null)
		{
			ShopController.CreateInstance();
		}
		return ShopController._Instance;
	}

	// Token: 0x0601642A RID: 91178 RVA: 0x005A17DB File Offset: 0x0059F9DB
	public static bool CreateInstance()
	{
		if (ShopController._Instance != null)
		{
			return true;
		}
		ShopController._Instance = new ShopController();
		return true;
	}

	// Token: 0x0601642B RID: 91179 RVA: 0x005A17F1 File Offset: 0x0059F9F1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601642C RID: 91180 RVA: 0x005A17F3 File Offset: 0x0059F9F3
	public static void ResetStaticDefaultValue()
	{
		ShopController._Instance = null;
	}

	// Token: 0x0601642D RID: 91181 RVA: 0x005A17FB File Offset: 0x0059F9FB
	static ShopController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ShopController.CreateStaticDefaultValue), new Action(ShopController.ResetStaticDefaultValue));
	}

	// Token: 0x0400A593 RID: 42387
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

	// Token: 0x0400A594 RID: 42388
	[Nullable(2)]
	private static ShopController _Instance;
}
