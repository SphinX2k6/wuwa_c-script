using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x02001470 RID: 5232
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class InventoryGiftController : UiControllerBase
{
	// Token: 0x0600D0DA RID: 53466 RVA: 0x003E18C8 File Offset: 0x003DFAC8
	[NullableContext(2)]
	public void SendItemGiftUseRequest(int configId, int count, int[] selectedId)
	{
		ItemGiftUseRequest itemGiftUseRequest = ItemGiftUseRequest.Create();
		itemGiftUseRequest.ItemId = configId;
		itemGiftUseRequest.Count = count;
		if (selectedId != null)
		{
			itemGiftUseRequest.SelectedId.Add(selectedId);
		}
		CommonItemData commonItemData = InventoryModel.Instance.GetCommonItemData(configId, 0);
		TItemConfig config = commonItemData.GetConfig();
		int num;
		if (!config.Parameters.TryGetValue(2, out num))
		{
			int num2;
			config.Parameters.TryGetValue(4, out num2);
		}
		int count2 = commonItemData.GetCount();
		int remainCount = count2 - count;
		Net.Instance.Call(ERequestMessageId.ItemGiftUseRequest, itemGiftUseRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ItemGiftUseResponse itemGiftUseResponse = (ItemGiftUseResponse)msg;
			if (itemGiftUseResponse == null)
			{
				return;
			}
			if (itemGiftUseResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(itemGiftUseResponse.ErrorCode, 25639, null, true, true);
				return;
			}
			if (UiManager.Instance.IsViewShow(EUiViewName.InventoryGiftView))
			{
				UiManager.Instance.CloseView(EUiViewName.InventoryGiftView, null);
			}
			AcquireData acquireData = InventoryModel.Instance.GetAcquireData();
			if (acquireData != null)
			{
				TItem item = new TItem(new InventoryDefine.GetItemData(configId, 0), remainCount);
				acquireData.SetRemainItemCount(remainCount);
				acquireData.SetMaxAmount(remainCount);
				acquireData.SetItemData(new List<TItem>
				{
					item
				});
				this.ShowAcquireView(acquireData);
			}
		}, 0);
	}

	// Token: 0x0600D0DB RID: 53467 RVA: 0x003E1978 File Offset: 0x003DFB78
	public void SendGiftPackPreviewRequest(int itemId, GiftPackage giftConfig, int? selectedId, int selectedCount = 1)
	{
		GiftPackPreviewRequest giftPackPreviewRequest = GiftPackPreviewRequest.Create();
		giftPackPreviewRequest.GiftPackId = giftConfig.Id;
		Net.Instance.Call(ERequestMessageId.GiftPackPreviewRequest, giftPackPreviewRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			GiftPackPreviewResponse giftPackPreviewResponse = (GiftPackPreviewResponse)msg;
			if (giftPackPreviewResponse == null)
			{
				return;
			}
			List<GiftItemData> list = new List<GiftItemData>();
			foreach (KeyValuePair<int, int> keyValuePair in giftConfig.Content())
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				GiftItemData giftItemData = new GiftItemData(key, value, 0);
				Aki.Protocol.PhantomItem phantomItemData;
				if (giftPackPreviewResponse.PhantomPreview.TryGetValue(key, out phantomItemData))
				{
					giftItemData.SetPhantomItemData(phantomItemData);
				}
				list.Add(giftItemData);
			}
			InventoryGiftData param = new InventoryGiftData(itemId, list.ToArray(), giftConfig, selectedId, new int?(selectedCount));
			UiManager.Instance.OpenView(EUiViewName.InventoryGiftView, param, null);
		}, 0);
	}

	// Token: 0x0600D0DC RID: 53468 RVA: 0x003E19DC File Offset: 0x003DFBDC
	public void ShowAcquireView(AcquireData acquireData)
	{
		InventoryModel.Instance.SetAcquireData(acquireData);
		if (UiManager.Instance.IsViewShow(EUiViewName.AcquireView))
		{
			EventSystem.Instance.Emit<AcquireData>(EEventName.RefreshAcquireView, acquireData);
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.AcquireView, acquireData, null);
	}

	// Token: 0x0600D0DD RID: 53469 RVA: 0x003E1A28 File Offset: 0x003DFC28
	public void ShowRewardViewWithCountAndId(int rewardId, int rewardCount)
	{
		AcquireData acquireData = new AcquireData();
		acquireData.SetAcquireViewType(EAcquireViewType.ShowReward);
		List<TItem> list = new List<TItem>();
		TItem item = new TItem(new InventoryDefine.GetItemData(rewardId, 0), rewardCount);
		list.Add(item);
		acquireData.SetItemData(list);
		this.ShowAcquireView(acquireData);
	}

	// Token: 0x0600D0DE RID: 53470 RVA: 0x003E1A6C File Offset: 0x003DFC6C
	public void ShowRewardViewWithList(List<TItem> rewardList)
	{
		AcquireData acquireData = new AcquireData();
		acquireData.SetAcquireViewType(EAcquireViewType.ShowReward);
		acquireData.SetItemData(rewardList);
		this.ShowAcquireView(acquireData);
	}

	// Token: 0x0600D0DF RID: 53471 RVA: 0x003E1A94 File Offset: 0x003DFC94
	public void CloseAcquireView()
	{
		if (!UiManager.Instance.IsViewShow(EUiViewName.AcquireView))
		{
			return;
		}
		UiManager.Instance.CloseView(EUiViewName.AcquireView, null);
	}

	// Token: 0x0600D0E0 RID: 53472 RVA: 0x003E1AB8 File Offset: 0x003DFCB8
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ItemGiftUseNotify, new Action<IMessage, Net.CallbackStatus>(this.ItemGiftUseNotify));
	}

	// Token: 0x0600D0E1 RID: 53473 RVA: 0x003E1AD6 File Offset: 0x003DFCD6
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ItemGiftUseNotify);
	}

	// Token: 0x0600D0E2 RID: 53474 RVA: 0x003E1AE8 File Offset: 0x003DFCE8
	[NullableContext(2)]
	public void ItemGiftUseNotify(IMessage msg, Net.CallbackStatus status)
	{
		ItemGiftUseNotify itemGiftUseNotify = (ItemGiftUseNotify)msg;
		int id = itemGiftUseNotify.Id;
		GiftPackage? giftPackageConfig = GiftPackageConfig.Instance.GetGiftPackageConfig(id);
		if (giftPackageConfig == null || giftPackageConfig.Value.ShowType == 1)
		{
			return;
		}
		if (giftPackageConfig.Value.ShowType == 0)
		{
			int count = itemGiftUseNotify.Infos.Count;
			List<TItem> list = new List<TItem>();
			for (int i = 0; i < count; i++)
			{
				AddCountItemInfo addCountItemInfo = itemGiftUseNotify.Infos[i];
				int id2 = addCountItemInfo.Id;
				int count2 = addCountItemInfo.Count;
				list.Add(new TItem(new InventoryDefine.GetItemData(id2, 0), count2));
			}
			AcquireData acquireData = new AcquireData();
			acquireData.SetAcquireViewType(EAcquireViewType.ShowReward);
			acquireData.SetItemData(list);
			this.ShowAcquireView(acquireData);
		}
	}

	// Token: 0x17001382 RID: 4994
	// (get) Token: 0x0600D0E3 RID: 53475 RVA: 0x003E1BB3 File Offset: 0x003DFDB3
	public static InventoryGiftController Instance
	{
		get
		{
			return InventoryGiftController._Instance;
		}
	}

	// Token: 0x0600D0E4 RID: 53476 RVA: 0x003E1BBA File Offset: 0x003DFDBA
	public static InventoryGiftController GetOrCreateInstance()
	{
		if (InventoryGiftController._Instance == null)
		{
			InventoryGiftController.CreateInstance();
		}
		return InventoryGiftController._Instance;
	}

	// Token: 0x0600D0E5 RID: 53477 RVA: 0x003E1BCE File Offset: 0x003DFDCE
	public static bool CreateInstance()
	{
		if (InventoryGiftController._Instance != null)
		{
			return true;
		}
		InventoryGiftController._Instance = new InventoryGiftController();
		return true;
	}

	// Token: 0x0600D0E6 RID: 53478 RVA: 0x003E1BE4 File Offset: 0x003DFDE4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D0E7 RID: 53479 RVA: 0x003E1BE6 File Offset: 0x003DFDE6
	public static void ResetStaticDefaultValue()
	{
		InventoryGiftController._Instance = null;
	}

	// Token: 0x0600D0E8 RID: 53480 RVA: 0x003E1BEE File Offset: 0x003DFDEE
	static InventoryGiftController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InventoryGiftController.CreateStaticDefaultValue), new Action(InventoryGiftController.ResetStaticDefaultValue));
	}

	// Token: 0x0400764B RID: 30283
	[Nullable(2)]
	private static InventoryGiftController _Instance;
}
