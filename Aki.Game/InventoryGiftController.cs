using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x02001FAE RID: 8110
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class InventoryGiftController : UiControllerBase
{
	// Token: 0x0600FCB4 RID: 64692 RVA: 0x003D5F14 File Offset: 0x003D4114
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(itemGiftUseResponse.ErrorCode, 17290, null, true, true);
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

	// Token: 0x0600FCB5 RID: 64693 RVA: 0x003D5FC4 File Offset: 0x003D41C4
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

	// Token: 0x0600FCB6 RID: 64694 RVA: 0x003D6028 File Offset: 0x003D4228
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

	// Token: 0x0600FCB7 RID: 64695 RVA: 0x003D6074 File Offset: 0x003D4274
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

	// Token: 0x0600FCB8 RID: 64696 RVA: 0x003D60B8 File Offset: 0x003D42B8
	public void ShowRewardViewWithList(List<TItem> rewardList)
	{
		AcquireData acquireData = new AcquireData();
		acquireData.SetAcquireViewType(EAcquireViewType.ShowReward);
		acquireData.SetItemData(rewardList);
		this.ShowAcquireView(acquireData);
	}

	// Token: 0x0600FCB9 RID: 64697 RVA: 0x003D60E0 File Offset: 0x003D42E0
	public void CloseAcquireView()
	{
		if (!UiManager.Instance.IsViewShow(EUiViewName.AcquireView))
		{
			return;
		}
		UiManager.Instance.CloseView(EUiViewName.AcquireView, null);
	}

	// Token: 0x0600FCBA RID: 64698 RVA: 0x003D6104 File Offset: 0x003D4304
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ItemGiftUseNotify, new Action<IMessage, Net.CallbackStatus>(this.ItemGiftUseNotify));
	}

	// Token: 0x0600FCBB RID: 64699 RVA: 0x003D6122 File Offset: 0x003D4322
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ItemGiftUseNotify);
	}

	// Token: 0x0600FCBC RID: 64700 RVA: 0x003D6134 File Offset: 0x003D4334
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

	// Token: 0x17001356 RID: 4950
	// (get) Token: 0x0600FCBD RID: 64701 RVA: 0x003D61FF File Offset: 0x003D43FF
	public static InventoryGiftController Instance
	{
		get
		{
			return InventoryGiftController._Instance;
		}
	}

	// Token: 0x0600FCBE RID: 64702 RVA: 0x003D6206 File Offset: 0x003D4406
	public static InventoryGiftController GetOrCreateInstance()
	{
		if (InventoryGiftController._Instance == null)
		{
			InventoryGiftController.CreateInstance();
		}
		return InventoryGiftController._Instance;
	}

	// Token: 0x0600FCBF RID: 64703 RVA: 0x003D621A File Offset: 0x003D441A
	public static bool CreateInstance()
	{
		if (InventoryGiftController._Instance != null)
		{
			return true;
		}
		InventoryGiftController._Instance = new InventoryGiftController();
		return true;
	}

	// Token: 0x0600FCC0 RID: 64704 RVA: 0x003D6230 File Offset: 0x003D4430
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600FCC1 RID: 64705 RVA: 0x003D6232 File Offset: 0x003D4432
	public static void ResetStaticDefaultValue()
	{
		InventoryGiftController._Instance = null;
	}

	// Token: 0x0600FCC2 RID: 64706 RVA: 0x003D623A File Offset: 0x003D443A
	static InventoryGiftController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InventoryGiftController.CreateStaticDefaultValue), new Action(InventoryGiftController.ResetStaticDefaultValue));
	}

	// Token: 0x04007569 RID: 30057
	[Nullable(2)]
	private static InventoryGiftController _Instance;
}
