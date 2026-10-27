using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RecallQuest;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x02001FAD RID: 8109
[NullableContext(2)]
[Nullable(0)]
[Controller(0)]
public class InventoryController : UiControllerBase
{
	// Token: 0x0600FC6C RID: 64620 RVA: 0x003D37CE File Offset: 0x003D19CE
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<EOperationType, EOperationType>(EEventName.ShowTypeChange, new Action<EOperationType, EOperationType>(this.ShowTypeChange));
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
	}

	// Token: 0x0600FC6D RID: 64621 RVA: 0x003D3808 File Offset: 0x003D1A08
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.ShowTypeChange, new Action<EOperationType, EOperationType>(this.ShowTypeChange));
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
	}

	// Token: 0x0600FC6E RID: 64622 RVA: 0x003D3844 File Offset: 0x003D1A44
	protected override void OnRegisterNetEvent()
	{
		Net instance = Net.Instance;
		ENotifyMessageId id = ENotifyMessageId.NormalItemUpdateNotify;
		Action<IMessage, Net.CallbackStatus> callback;
		if ((callback = InventoryController.<>O.<0>__NormalItemUpdateNotify) == null)
		{
			callback = (InventoryController.<>O.<0>__NormalItemUpdateNotify = new Action<IMessage, Net.CallbackStatus>(InventoryController.NormalItemUpdateNotify));
		}
		instance.Register(id, callback);
		Net instance2 = Net.Instance;
		ENotifyMessageId id2 = ENotifyMessageId.NormalItemRemoveNotify;
		Action<IMessage, Net.CallbackStatus> callback2;
		if ((callback2 = InventoryController.<>O.<1>__NormalItemRemoveNotify) == null)
		{
			callback2 = (InventoryController.<>O.<1>__NormalItemRemoveNotify = new Action<IMessage, Net.CallbackStatus>(InventoryController.NormalItemRemoveNotify));
		}
		instance2.Register(id2, callback2);
		Net instance3 = Net.Instance;
		ENotifyMessageId id3 = ENotifyMessageId.NormalItemAddNotify;
		Action<IMessage, Net.CallbackStatus> callback3;
		if ((callback3 = InventoryController.<>O.<2>__NormalItemAddNotify) == null)
		{
			callback3 = (InventoryController.<>O.<2>__NormalItemAddNotify = new Action<IMessage, Net.CallbackStatus>(InventoryController.NormalItemAddNotify));
		}
		instance3.Register(id3, callback3);
		Net instance4 = Net.Instance;
		ENotifyMessageId id4 = ENotifyMessageId.ValidTimeItemUpdateNotify;
		Action<IMessage, Net.CallbackStatus> callback4;
		if ((callback4 = InventoryController.<>O.<3>__ValidTimeItemUpdateNotify) == null)
		{
			callback4 = (InventoryController.<>O.<3>__ValidTimeItemUpdateNotify = new Action<IMessage, Net.CallbackStatus>(InventoryController.ValidTimeItemUpdateNotify));
		}
		instance4.Register(id4, callback4);
		Net instance5 = Net.Instance;
		ENotifyMessageId id5 = ENotifyMessageId.ValidTimeItemRemoveNotify;
		Action<IMessage, Net.CallbackStatus> callback5;
		if ((callback5 = InventoryController.<>O.<4>__ValidTimeItemRemoveNotify) == null)
		{
			callback5 = (InventoryController.<>O.<4>__ValidTimeItemRemoveNotify = new Action<IMessage, Net.CallbackStatus>(InventoryController.ValidTimeItemRemoveNotify));
		}
		instance5.Register(id5, callback5);
		Net instance6 = Net.Instance;
		ENotifyMessageId id6 = ENotifyMessageId.ValidTimeItemAddNotify;
		Action<IMessage, Net.CallbackStatus> callback6;
		if ((callback6 = InventoryController.<>O.<5>__ValidTimeItemAddNotify) == null)
		{
			callback6 = (InventoryController.<>O.<5>__ValidTimeItemAddNotify = new Action<IMessage, Net.CallbackStatus>(InventoryController.ValidTimeItemAddNotify));
		}
		instance6.Register(id6, callback6);
		Net instance7 = Net.Instance;
		ENotifyMessageId id7 = ENotifyMessageId.WeaponItemAddNotify;
		Action<IMessage, Net.CallbackStatus> callback7;
		if ((callback7 = InventoryController.<>O.<6>__WeaponItemAddNotify) == null)
		{
			callback7 = (InventoryController.<>O.<6>__WeaponItemAddNotify = new Action<IMessage, Net.CallbackStatus>(InventoryController.WeaponItemAddNotify));
		}
		instance7.Register(id7, callback7);
		Net instance8 = Net.Instance;
		ENotifyMessageId id8 = ENotifyMessageId.WeaponItemRemoveNotify;
		Action<IMessage, Net.CallbackStatus> callback8;
		if ((callback8 = InventoryController.<>O.<7>__WeaponItemRemoveNotify) == null)
		{
			callback8 = (InventoryController.<>O.<7>__WeaponItemRemoveNotify = new Action<IMessage, Net.CallbackStatus>(InventoryController.WeaponItemRemoveNotify));
		}
		instance8.Register(id8, callback8);
		Net instance9 = Net.Instance;
		ENotifyMessageId id9 = ENotifyMessageId.PhantomItemAddNotify;
		Action<IMessage, Net.CallbackStatus> callback9;
		if ((callback9 = InventoryController.<>O.<8>__PhantomItemAddNotify) == null)
		{
			callback9 = (InventoryController.<>O.<8>__PhantomItemAddNotify = new Action<IMessage, Net.CallbackStatus>(InventoryController.PhantomItemAddNotify));
		}
		instance9.Register(id9, callback9);
		Net instance10 = Net.Instance;
		ENotifyMessageId id10 = ENotifyMessageId.PhantomItemRemoveNotify;
		Action<IMessage, Net.CallbackStatus> callback10;
		if ((callback10 = InventoryController.<>O.<9>__PhantomItemRemoveNotify) == null)
		{
			callback10 = (InventoryController.<>O.<9>__PhantomItemRemoveNotify = new Action<IMessage, Net.CallbackStatus>(InventoryController.PhantomItemRemoveNotify));
		}
		instance10.Register(id10, callback10);
		Net instance11 = Net.Instance;
		ENotifyMessageId id11 = ENotifyMessageId.ItemFuncValueUpdateNotify;
		Action<IMessage, Net.CallbackStatus> callback11;
		if ((callback11 = InventoryController.<>O.<10>__ItemFuncValueUpdateNotify) == null)
		{
			callback11 = (InventoryController.<>O.<10>__ItemFuncValueUpdateNotify = new Action<IMessage, Net.CallbackStatus>(InventoryController.ItemFuncValueUpdateNotify));
		}
		instance11.Register(id11, callback11);
		Net instance12 = Net.Instance;
		ENotifyMessageId id12 = ENotifyMessageId.ItemPkgOpenNotify;
		Action<IMessage, Net.CallbackStatus> callback12;
		if ((callback12 = InventoryController.<>O.<11>__InventoryTabOpenNotify) == null)
		{
			callback12 = (InventoryController.<>O.<11>__InventoryTabOpenNotify = new Action<IMessage, Net.CallbackStatus>(InventoryController.InventoryTabOpenNotify));
		}
		instance12.Register(id12, callback12);
		Net instance13 = Net.Instance;
		ENotifyMessageId id13 = ENotifyMessageId.ItemPkgFullNotify;
		Action<IMessage, Net.CallbackStatus> callback13;
		if ((callback13 = InventoryController.<>O.<12>__InventoryFullNotify) == null)
		{
			callback13 = (InventoryController.<>O.<12>__InventoryFullNotify = new Action<IMessage, Net.CallbackStatus>(InventoryController.InventoryFullNotify));
		}
		instance13.Register(id13, callback13);
		Net instance14 = Net.Instance;
		ENotifyMessageId id14 = ENotifyMessageId.BanItemUseNotify;
		Action<IMessage, Net.CallbackStatus> callback14;
		if ((callback14 = InventoryController.<>O.<13>__InventoryBanItemUseNotify) == null)
		{
			callback14 = (InventoryController.<>O.<13>__InventoryBanItemUseNotify = new Action<IMessage, Net.CallbackStatus>(InventoryController.InventoryBanItemUseNotify));
		}
		instance14.Register(id14, callback14);
	}

	// Token: 0x0600FC6F RID: 64623 RVA: 0x003D3AAC File Offset: 0x003D1CAC
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.NormalItemUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.NormalItemRemoveNotify);
		Net.Instance.UnRegister(ENotifyMessageId.NormalItemAddNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ValidTimeItemUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ValidTimeItemRemoveNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ValidTimeItemAddNotify);
		Net.Instance.UnRegister(ENotifyMessageId.WeaponItemAddNotify);
		Net.Instance.UnRegister(ENotifyMessageId.WeaponItemRemoveNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PhantomItemAddNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PhantomItemRemoveNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ItemFuncValueUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ItemPkgOpenNotify);
		Net.Instance.UnRegister(ENotifyMessageId.ItemPkgFullNotify);
		Net.Instance.UnRegister(ENotifyMessageId.BanItemUseNotify);
	}

	// Token: 0x0600FC70 RID: 64624 RVA: 0x003D3B99 File Offset: 0x003D1D99
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager instance = UiManager.Instance;
		EUiViewName inventoryView = EUiViewName.InventoryView;
		Func<EUiViewName, object, bool> func;
		if ((func = InventoryController.<>O.<14>__CanOpenView) == null)
		{
			func = (InventoryController.<>O.<14>__CanOpenView = new Func<EUiViewName, object, bool>(InventoryController.CanOpenView));
		}
		instance.AddOpenViewCheckFunction(inventoryView, func, "InventoryController.CanOpenView");
	}

	// Token: 0x0600FC71 RID: 64625 RVA: 0x003D3BCA File Offset: 0x003D1DCA
	protected override void OnRemoveOpenViewCheckFunction()
	{
		UiManager instance = UiManager.Instance;
		EUiViewName inventoryView = EUiViewName.InventoryView;
		Func<EUiViewName, object, bool> func;
		if ((func = InventoryController.<>O.<14>__CanOpenView) == null)
		{
			func = (InventoryController.<>O.<14>__CanOpenView = new Func<EUiViewName, object, bool>(InventoryController.CanOpenView));
		}
		instance.RemoveOpenViewCheckFunction(inventoryView, func);
	}

	// Token: 0x0600FC72 RID: 64626 RVA: 0x003D3BF6 File Offset: 0x003D1DF6
	private void OnDataDone()
	{
		this.NormalItemRequest();
		this.WeaponItemRequest();
		this.PhantomItemRequest();
		this.ValidTimeItemRequest();
	}

	// Token: 0x0600FC73 RID: 64627 RVA: 0x003D3C10 File Offset: 0x003D1E10
	private void ShowTypeChange(EOperationType last, EOperationType now)
	{
		if (UiManager.Instance.IsViewShow(EUiViewName.InventoryView))
		{
			UiManager.Instance.CloseView(EUiViewName.InventoryView, null);
			UiManager.Instance.OpenView(EUiViewName.InventoryView, null, null);
		}
	}

	// Token: 0x0600FC74 RID: 64628 RVA: 0x003D3C44 File Offset: 0x003D1E44
	public void ItemLockRequest(int uniqueId, bool bLock)
	{
		if (uniqueId <= 0)
		{
			return;
		}
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(uniqueId);
		if (attributeItemData == null)
		{
			return;
		}
		if (!attributeItemData.CanLock())
		{
			return;
		}
		ItemLockRequest itemLockRequest = Aki.Protocol.ItemLockRequest.Create();
		itemLockRequest.IncrId = attributeItemData.GetUniqueId();
		itemLockRequest.Oper = (bLock ? 1 : 2);
		InventoryModel.Instance.SetCurrentLockItemUniqueId(uniqueId);
		bool isDeprecate = attributeItemData.GetIsDeprecated();
		Net.Instance.Call(ERequestMessageId.ItemLockRequest, itemLockRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ItemLockResponse itemLockResponse = (ItemLockResponse)msg;
			if (itemLockResponse.ErrCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(itemLockResponse.ErrCode, 18915, null, true, true);
				return;
			}
			if (!bLock)
			{
				ScrollingTipsController.Instance.ShowTipsById("ItemUnlockSuccess", Array.Empty<object>());
			}
			else if (isDeprecate)
			{
				ScrollingTipsController.Instance.ShowTipsById("EchoAbandonToLock", Array.Empty<object>());
			}
			else
			{
				ScrollingTipsController.Instance.ShowTipsById("ItemLockSuccess", Array.Empty<object>());
			}
			EventSystem.Instance.Emit<int, bool>(EEventName.OnItemLock, uniqueId, bLock);
		}, 0);
	}

	// Token: 0x0600FC75 RID: 64629 RVA: 0x003D3CEC File Offset: 0x003D1EEC
	public void ItemDeprecateRequest(int uniqueId, bool isDeprecate)
	{
		if (uniqueId <= 0)
		{
			return;
		}
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(uniqueId);
		if (attributeItemData == null)
		{
			return;
		}
		if (!attributeItemData.CanDeprecate())
		{
			return;
		}
		ItemDisuseRequest itemDisuseRequest = ItemDisuseRequest.Create();
		itemDisuseRequest.IncrId = uniqueId;
		itemDisuseRequest.Oper = (isDeprecate ? 1 : 2);
		bool isLock = attributeItemData.GetIsLock();
		Net.Instance.Call(ERequestMessageId.ItemDisuseRequest, itemDisuseRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ItemDisuseResponse itemDisuseResponse = (ItemDisuseResponse)msg;
			if (itemDisuseResponse.ErrCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(itemDisuseResponse.ErrCode, 29774, null, true, true);
				return;
			}
			if (!isDeprecate)
			{
				ScrollingTipsController.Instance.ShowTipsById("EchoAbandonRelease", Array.Empty<object>());
				return;
			}
			if (isLock)
			{
				ScrollingTipsController.Instance.ShowTipsById("EchoLockToAbandon", Array.Empty<object>());
				return;
			}
			ScrollingTipsController.Instance.ShowTipsById("EchoAbandonSuccess", Array.Empty<object>());
		}, 0);
	}

	// Token: 0x0600FC76 RID: 64630 RVA: 0x003D3D6C File Offset: 0x003D1F6C
	public void RequestItemUse(int configId, int count)
	{
		InventoryController.<>c__DisplayClass17_0 CS$<>8__locals1 = new InventoryController.<>c__DisplayClass17_0();
		CS$<>8__locals1.configId = configId;
		CS$<>8__locals1.count = count;
		CS$<>8__locals1.itemConfig = InventoryConfig.Instance.GetItemConfig(CS$<>8__locals1.configId).Value;
		int restrictConditionGroupId = CS$<>8__locals1.itemConfig.RestrictConditionGroupId;
		if (restrictConditionGroupId > 0 && LevelGeneralController.Instance.CheckCondition(restrictConditionGroupId.ToString(), null, false, Array.Empty<object>()))
		{
			string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(restrictConditionGroupId);
			if (conditionGroupHintText != null)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId(conditionGroupHintText, Array.Empty<object>());
			}
			return;
		}
		int skillId;
		if (CS$<>8__locals1.itemConfig.SpecialItem && CS$<>8__locals1.itemConfig.Parameters().TryGetValue(21, out skillId))
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			CharacterSkillComponent characterSkillComponent = (getCurrentEntity != null) ? getCurrentEntity.Entity.GetComponent<CharacterSkillComponent>() : null;
			if (characterSkillComponent != null && characterSkillComponent.IsSkillInCd(skillId))
			{
				return;
			}
		}
		if (CS$<>8__locals1.itemConfig.SpecialItem && !SpecialItemController.Instance.AllowReqUseSpecialItem(CS$<>8__locals1.configId))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Inventory;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "试图请求使用的特殊道具被禁用";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configId", CS$<>8__locals1.configId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			EventSystem.Instance.Emit(EEventName.OnSpecialItemNotAllow);
			return;
		}
		if (RecallQuestModel.Instance.IsInRecallInstance())
		{
			RecallQuestController.Instance.RequestItemUse(CS$<>8__locals1.configId, CS$<>8__locals1.count, new Action<ErrorCode?>(CS$<>8__locals1.<RequestItemUse>g__onResponse|0));
			return;
		}
		InventoryController.StartRequestItemUse(CS$<>8__locals1.configId, CS$<>8__locals1.count, new Action<ErrorCode?>(CS$<>8__locals1.<RequestItemUse>g__onResponse|0));
	}

	// Token: 0x0600FC77 RID: 64631 RVA: 0x003D3EF0 File Offset: 0x003D20F0
	[NullableContext(1)]
	private static void StartRequestItemUse(int configId, int count, Action<ErrorCode?> callBack)
	{
		InventoryController.<>c__DisplayClass18_0 CS$<>8__locals1 = new InventoryController.<>c__DisplayClass18_0();
		CS$<>8__locals1.callBack = callBack;
		ItemUseRequest itemUseRequest = ItemUseRequest.Create();
		itemUseRequest.ItemId = configId;
		itemUseRequest.Count = count;
		Net.Instance.Call(ERequestMessageId.ItemUseRequest, itemUseRequest, new Action<IMessage, Net.CallbackStatus>(CS$<>8__locals1.<StartRequestItemUse>g__responseItemUse|0), 0);
	}

	// Token: 0x0600FC78 RID: 64632 RVA: 0x003D3F3C File Offset: 0x003D213C
	private static void InventoryBanItemUseNotify(IMessage msg, Net.CallbackStatus status)
	{
		BanItemUseNotify banItemUseNotify = (BanItemUseNotify)msg;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Inventory;
		ELogAuthor author = ELogAuthor.LY;
		string message = "收到道具使用封禁通知";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("notify", banItemUseNotify);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		long banEndTime = banItemUseNotify.BanEndTime;
		double serverTime = TimeUtil.Instance.GetServerTime();
		CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat8((double)banEndTime - serverTime);
		ScrollingTipsController.Instance.ShowTipsByTextId("Text_BanItemTextTime_Text", new object[]
		{
			remainTimeDataFormat.CountDownText
		});
	}

	// Token: 0x0600FC79 RID: 64633 RVA: 0x003D3FB8 File Offset: 0x003D21B8
	public void NormalItemRequest()
	{
		NormalItemRequest normalItemRequest = Aki.Protocol.NormalItemRequest.Create();
		Net instance = Net.Instance;
		ERequestMessageId requestMessageId = ERequestMessageId.NormalItemRequest;
		IMessage message = normalItemRequest;
		Action<IMessage, Net.CallbackStatus> handle;
		if ((handle = InventoryController.<>O.<15>__NormalItemResponse) == null)
		{
			handle = (InventoryController.<>O.<15>__NormalItemResponse = new Action<IMessage, Net.CallbackStatus>(InventoryController.NormalItemResponse));
		}
		instance.Call(requestMessageId, message, handle, 0);
	}

	// Token: 0x0600FC7A RID: 64634 RVA: 0x003D3FF8 File Offset: 0x003D21F8
	private static void NormalItemResponse(IMessage msg, Net.CallbackStatus _)
	{
		NormalItemResponse normalItemResponse = (NormalItemResponse)msg;
		InventoryModel instance = InventoryModel.Instance;
		instance.ClearCommonItemData();
		RepeatedField<NormalItem> normalItemList = normalItemResponse.NormalItemList;
		if (normalItemList == null || normalItemList.Count == 0)
		{
			return;
		}
		foreach (NormalItem normalItem in normalItemList)
		{
			int id = normalItem.Id;
			int count = normalItem.Count;
			long expireTime = normalItem.ExpireTime;
			instance.NewCommonItemData(id, count, 0, new long?(expireTime));
			EventSystem.Instance.Emit<IProto_NormalItem>(EEventName.OnResponseCommonItem, normalItem);
		}
		instance.RefreshItemRedDotSet();
		EventSystem.Instance.Emit(EEventName.OnResponseCommonItemFinished);
	}

	// Token: 0x0600FC7B RID: 64635 RVA: 0x003D40B0 File Offset: 0x003D22B0
	private static void NormalItemUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		NormalItemUpdateNotify normalItemUpdateNotify = (NormalItemUpdateNotify)msg;
		RepeatedField<NormalItem> normalItemList = normalItemUpdateNotify.NormalItemList;
		if (normalItemList == null || normalItemList.Count == 0)
		{
			return;
		}
		InventoryModel instance = InventoryModel.Instance;
		bool flag = !normalItemUpdateNotify.NoTips;
		foreach (NormalItem normalItem in normalItemList)
		{
			int id = normalItem.Id;
			int count = normalItem.Count;
			CommonItemData commonItemData = instance.GetCommonItemData(id, 0);
			if (commonItemData != null)
			{
				int count2 = commonItemData.GetCount();
				commonItemData.SetCount(count);
				if (count > count2 && flag)
				{
					instance.TryAddRedDotCommonItem(id, 0);
				}
				else
				{
					instance.RemoveRedDotCommonItem(id, 0);
				}
				EventSystem.Instance.Emit<IProto_NormalItem, int, int>(EEventName.OnCommonItemCountRefresh, normalItem, count, count2);
				EventSystem.Instance.Emit<int, int>(EEventName.OnCommonItemCountAnyChange, id, count);
				if (instance.IsNewCommonItem(id, 0))
				{
					EventSystem.Instance.Emit<int>(EEventName.OnGetNewItem, id);
				}
			}
		}
		if (flag)
		{
			ItemHintController.Instance.AddCommonItemList(normalItemList);
		}
		EventSystem.Instance.Emit<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, normalItemList);
		EventSystem.Instance.Emit(EEventName.RedDotRefreshItemData);
	}

	// Token: 0x0600FC7C RID: 64636 RVA: 0x003D41F0 File Offset: 0x003D23F0
	private static void NormalItemRemoveNotify(IMessage msg, Net.CallbackStatus status)
	{
		RepeatedField<int> normalItemIdList = ((NormalItemRemoveNotify)msg).NormalItemIdList;
		if (normalItemIdList == null || normalItemIdList.Count == 0)
		{
			return;
		}
		List<InventoryDefine.IGetItemData> list = new List<InventoryDefine.IGetItemData>();
		foreach (int itemId in normalItemIdList)
		{
			InventoryDefine.GetItemData item = new InventoryDefine.GetItemData(itemId, 0);
			list.Add(item);
		}
		InventoryModel.Instance.RemoveCommonItemDataAndSaveNewList(list);
		EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.OnRemoveCommonItem, normalItemIdList);
		foreach (int p in normalItemIdList)
		{
			EventSystem.Instance.Emit<int, int>(EEventName.OnCommonItemCountAnyChange, p, 0);
		}
	}

	// Token: 0x0600FC7D RID: 64637 RVA: 0x003D42BC File Offset: 0x003D24BC
	private static void NormalItemAddNotify(IMessage msg, Net.CallbackStatus status)
	{
		NormalItemAddNotify normalItemAddNotify = (NormalItemAddNotify)msg;
		RepeatedField<NormalItem> normalItemList = normalItemAddNotify.NormalItemList;
		if (normalItemList == null || normalItemList.Count == 0)
		{
			return;
		}
		InventoryModel instance = InventoryModel.Instance;
		bool flag = !normalItemAddNotify.NoTips;
		bool flag2 = normalItemAddNotify.Reason != 14000;
		foreach (NormalItem normalItem in normalItemList)
		{
			int id = normalItem.Id;
			int count = normalItem.Count;
			long expireTime = normalItem.ExpireTime;
			instance.NewCommonItemData(id, count, 0, new long?(expireTime));
			if (flag)
			{
				instance.TryAddNewCommonItem(id, 0);
				instance.TryAddRedDotCommonItem(id, 0);
			}
			else
			{
				instance.RemoveRedDotCommonItem(id, 0);
			}
			EventSystem.Instance.Emit<IProto_NormalItem, bool>(EEventName.OnAddCommonItem, normalItem, flag2);
			EventSystem.Instance.Emit<int, int>(EEventName.OnCommonItemCountAnyChange, id, count);
		}
		if (flag && flag2)
		{
			ItemHintController.Instance.AddCommonItemList(normalItemList);
		}
		EventSystem.Instance.Emit<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, normalItemList);
		EventSystem.Instance.Emit<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemNotify, normalItemList);
		instance.SaveNewCommonItemConfigIdList();
		instance.SaveRedDotCommonItemConfigIdList();
		EventSystem.Instance.Emit(EEventName.RedDotRefreshItemData);
	}

	// Token: 0x0600FC7E RID: 64638 RVA: 0x003D4410 File Offset: 0x003D2610
	public void ValidTimeItemRequest()
	{
		ValidTimeItemRequest validTimeItemRequest = Aki.Protocol.ValidTimeItemRequest.Create();
		Net instance = Net.Instance;
		ERequestMessageId requestMessageId = ERequestMessageId.ValidTimeItemRequest;
		IMessage message = validTimeItemRequest;
		Action<IMessage, Net.CallbackStatus> handle;
		if ((handle = InventoryController.<>O.<16>__ValidTimeItemResponse) == null)
		{
			handle = (InventoryController.<>O.<16>__ValidTimeItemResponse = new Action<IMessage, Net.CallbackStatus>(InventoryController.ValidTimeItemResponse));
		}
		instance.Call(requestMessageId, message, handle, 0);
	}

	// Token: 0x0600FC7F RID: 64639 RVA: 0x003D4450 File Offset: 0x003D2650
	private static void ValidTimeItemResponse(IMessage msg, Net.CallbackStatus _)
	{
		ValidTimeItemResponse validTimeItemResponse = (ValidTimeItemResponse)msg;
		if (validTimeItemResponse == null)
		{
			return;
		}
		RepeatedField<ValidTimeItem> itemList = validTimeItemResponse.ItemList;
		if (itemList == null || itemList.Count == 0)
		{
			return;
		}
		foreach (ValidTimeItem validTimeItem in itemList)
		{
			int id = validTimeItem.Id;
			int count = validTimeItem.Count;
			int incrId = validTimeItem.IncrId;
			long value = MathUtils.Instance.LongToBigInt(validTimeItem.ExpireTime);
			InventoryModel.Instance.NewCommonItemData(id, count, incrId, new long?(value));
			EventSystem.Instance.Emit<IProto_NormalItem>(EEventName.OnResponseCommonItem, validTimeItem);
		}
	}

	// Token: 0x0600FC80 RID: 64640 RVA: 0x003D4504 File Offset: 0x003D2704
	private static void ValidTimeItemUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		RepeatedField<ValidTimeItem> itemList = ((ValidTimeItemUpdateNotify)msg).ItemList;
		if (itemList == null || itemList.Count == 0)
		{
			return;
		}
		InventoryModel instance = InventoryModel.Instance;
		foreach (ValidTimeItem validTimeItem in itemList)
		{
			int id = validTimeItem.Id;
			int count = validTimeItem.Count;
			int incrId = validTimeItem.IncrId;
			long endTime = MathUtils.Instance.LongToBigInt(validTimeItem.ExpireTime);
			CommonItemData commonItemData = instance.GetCommonItemData(id, incrId);
			if (commonItemData != null)
			{
				commonItemData.SetCount(count);
				commonItemData.SetEndTime(endTime);
				EventSystem.Instance.Emit<int, int>(EEventName.OnCommonItemCountAnyChange, id, count);
				if (InventoryModel.Instance.IsNewCommonItem(id, 0))
				{
					EventSystem.Instance.Emit<int>(EEventName.OnGetNewItem, id);
				}
			}
		}
		ItemHintController.Instance.AddCommonItemList(itemList);
		EventSystem.Instance.Emit<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, itemList);
		EventSystem.Instance.Emit(EEventName.RedDotRefreshItemData);
	}

	// Token: 0x0600FC81 RID: 64641 RVA: 0x003D4618 File Offset: 0x003D2818
	private static void ValidTimeItemRemoveNotify(IMessage msg, Net.CallbackStatus status)
	{
		RepeatedField<RemoveValidTimeItem> itemList = ((ValidTimeItemRemoveNotify)msg).ItemList;
		if (itemList == null || itemList.Count == 0)
		{
			return;
		}
		List<InventoryDefine.IGetItemData> list = new List<InventoryDefine.IGetItemData>();
		List<int> list2 = new List<int>();
		foreach (RemoveValidTimeItem removeValidTimeItem in itemList)
		{
			InventoryDefine.GetItemData item = new InventoryDefine.GetItemData(removeValidTimeItem.ItemId, removeValidTimeItem.IncrId);
			list.Add(item);
			list2.Add(removeValidTimeItem.ItemId);
		}
		InventoryModel.Instance.RemoveCommonItemDataAndSaveNewList(list);
		EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.OnRemoveCommonItem, list2);
		foreach (RemoveValidTimeItem removeValidTimeItem2 in itemList)
		{
			EventSystem.Instance.Emit<int, int>(EEventName.OnCommonItemCountAnyChange, removeValidTimeItem2.ItemId, 0);
		}
	}

	// Token: 0x0600FC82 RID: 64642 RVA: 0x003D4710 File Offset: 0x003D2910
	private static void ValidTimeItemAddNotify(IMessage msg, Net.CallbackStatus status)
	{
		RepeatedField<ValidTimeItem> itemList = ((ValidTimeItemAddNotify)msg).ItemList;
		if (itemList == null || itemList.Count == 0)
		{
			return;
		}
		InventoryModel instance = InventoryModel.Instance;
		foreach (ValidTimeItem validTimeItem in itemList)
		{
			int id = validTimeItem.Id;
			int count = validTimeItem.Count;
			int incrId = validTimeItem.IncrId;
			long value = MathUtils.Instance.LongToBigInt(validTimeItem.ExpireTime);
			instance.NewCommonItemData(id, count, incrId, new long?(value));
			instance.TryAddNewCommonItem(id, 0);
			instance.TryAddRedDotCommonItem(id, 0);
			EventSystem.Instance.Emit<int, int>(EEventName.OnCommonItemCountAnyChange, id, count);
		}
		ItemHintController.Instance.AddCommonItemList(itemList);
		EventSystem.Instance.Emit<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, itemList);
		EventSystem.Instance.Emit<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemNotify, itemList);
		instance.SaveNewCommonItemConfigIdList();
		instance.SaveRedDotCommonItemConfigIdList();
		EventSystem.Instance.Emit(EEventName.RedDotRefreshItemData);
	}

	// Token: 0x0600FC83 RID: 64643 RVA: 0x003D4820 File Offset: 0x003D2A20
	public void WeaponItemRequest()
	{
		WeaponItemRequest weaponItemRequest = Aki.Protocol.WeaponItemRequest.Create();
		Net instance = Net.Instance;
		ERequestMessageId requestMessageId = ERequestMessageId.WeaponItemRequest;
		IMessage message = weaponItemRequest;
		Action<IMessage, Net.CallbackStatus> handle;
		if ((handle = InventoryController.<>O.<17>__WeaponItemResponse) == null)
		{
			handle = (InventoryController.<>O.<17>__WeaponItemResponse = new Action<IMessage, Net.CallbackStatus>(InventoryController.WeaponItemResponse));
		}
		instance.Call(requestMessageId, message, handle, 0);
	}

	// Token: 0x0600FC84 RID: 64644 RVA: 0x003D4860 File Offset: 0x003D2A60
	private static void WeaponItemResponse(IMessage msg, Net.CallbackStatus _)
	{
		WeaponItemResponse weaponItemResponse = (WeaponItemResponse)msg;
		InventoryModel instance = InventoryModel.Instance;
		instance.ClearWeaponItemData();
		RepeatedField<WeaponItem> weaponItemList = weaponItemResponse.WeaponItemList;
		if (weaponItemList == null || weaponItemList.Count == 0)
		{
			return;
		}
		foreach (WeaponItem weaponItem in weaponItemList)
		{
			int id = weaponItem.Id;
			int incrId = weaponItem.IncrId;
			int funcValue = weaponItem.FuncValue;
			instance.NewWeaponItemData(id, incrId, funcValue);
			EventSystem.Instance.Emit<WeaponItem>(EEventName.OnResponseWeaponItem, weaponItem);
		}
		EventSystem.Instance.Emit(EEventName.OnResponseWeaponAll);
	}

	// Token: 0x0600FC85 RID: 64645 RVA: 0x003D490C File Offset: 0x003D2B0C
	private static void WeaponItemAddNotify(IMessage msg, Net.CallbackStatus status)
	{
		WeaponItemAddNotify weaponItemAddNotify = (WeaponItemAddNotify)msg;
		InventoryModel instance = InventoryModel.Instance;
		RepeatedField<WeaponItem> weaponItemList = weaponItemAddNotify.WeaponItemList;
		if (weaponItemList == null || weaponItemList.Count == 0)
		{
			return;
		}
		bool p = weaponItemAddNotify.Reason != 14000;
		foreach (WeaponItem weaponItem in weaponItemList)
		{
			int id = weaponItem.Id;
			int incrId = weaponItem.IncrId;
			int funcValue = weaponItem.FuncValue;
			instance.NewWeaponItemData(id, incrId, funcValue);
			instance.TryAddNewAttributeItem(incrId);
			instance.TryAddRedDotAttributeItem(incrId);
			EventSystem.Instance.Emit<WeaponItem, bool, bool>(EEventName.OnAddWeaponItem, weaponItem, weaponItemAddNotify.AddFromRole, p);
		}
		EventSystem.Instance.Emit<IReadOnlyList<WeaponItem>, bool, bool>(EEventName.OnAddWeaponItemList, weaponItemList, weaponItemAddNotify.AddFromRole, p);
		instance.SaveNewAttributeItemUniqueIdList();
		instance.SaveRedDotAttributeItemUniqueIdList();
		EventSystem.Instance.Emit(EEventName.RedDotRefreshItemData);
	}

	// Token: 0x0600FC86 RID: 64646 RVA: 0x003D4A0C File Offset: 0x003D2C0C
	private static void WeaponItemRemoveNotify(IMessage msg, Net.CallbackStatus status)
	{
		RepeatedField<int> weaponItemIncrIdList = ((WeaponItemRemoveNotify)msg).WeaponItemIncrIdList;
		if (weaponItemIncrIdList == null || weaponItemIncrIdList.Count == 0)
		{
			return;
		}
		InventoryModel.Instance.RemoveWeaponItemDataAndSaveNewList(weaponItemIncrIdList);
		EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.OnRemoveWeaponItem, weaponItemIncrIdList);
	}

	// Token: 0x0600FC87 RID: 64647 RVA: 0x003D4A50 File Offset: 0x003D2C50
	public void PhantomItemRequest()
	{
		PhantomItemRequest phantomItemRequest = Aki.Protocol.PhantomItemRequest.Create();
		Net instance = Net.Instance;
		ERequestMessageId requestMessageId = ERequestMessageId.PhantomItemRequest;
		IMessage message = phantomItemRequest;
		Action<IMessage, Net.CallbackStatus> handle;
		if ((handle = InventoryController.<>O.<18>__PhantomItemResponse) == null)
		{
			handle = (InventoryController.<>O.<18>__PhantomItemResponse = new Action<IMessage, Net.CallbackStatus>(InventoryController.PhantomItemResponse));
		}
		instance.Call(requestMessageId, message, handle, 0);
	}

	// Token: 0x0600FC88 RID: 64648 RVA: 0x003D4A90 File Offset: 0x003D2C90
	private static void PhantomItemResponse(IMessage msg, Net.CallbackStatus _)
	{
		PhantomItemResponse phantomItemResponse = (PhantomItemResponse)msg;
		CalabashModel.Instance.DirectionalFusionTime = phantomItemResponse.DirectRefineWeekTimes;
		PhantomBattleModel.Instance.SetMaxCost(phantomItemResponse.TotalCost);
		RepeatedField<int> repeatedField = (phantomItemResponse != null) ? phantomItemResponse.UnlockSkins : null;
		if (repeatedField != null)
		{
			PhantomBattleModel.Instance.SetUnlockSkinList(repeatedField.ToArray<int>());
		}
		InventoryModel instance = InventoryModel.Instance;
		instance.ClearPhantomItemData();
		RepeatedField<PhantomItem> phantomItemList = phantomItemResponse.PhantomItemList;
		if (phantomItemList == null || phantomItemList.Count == 0)
		{
			return;
		}
		List<string> list = new List<string>();
		foreach (PhantomItem phantomItem in phantomItemList)
		{
			int id = phantomItem.Id;
			int incrId = phantomItem.IncrId;
			int funcValue = phantomItem.FuncValue;
			instance.NewPhantomItemData(id, incrId, funcValue, phantomItem.StackCount, phantomItem.AddTime);
			if (phantomItem.StackCount > 1)
			{
				List<string> list2 = list;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(incrId);
				defaultInterpolatedStringHandler.AppendLiteral(":");
				defaultInterpolatedStringHandler.AppendFormatted<int>(phantomItem.StackCount);
				list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			EventSystem.Instance.Emit<PhantomItem>(EEventName.OnResponsePhantomItem, phantomItem);
		}
		EventSystem.Instance.Emit<PhantomItemResponse>(EEventName.OnEquipPhantomItem, phantomItemResponse);
	}

	// Token: 0x0600FC89 RID: 64649 RVA: 0x003D4BE8 File Offset: 0x003D2DE8
	private unsafe static void PhantomItemAddNotify(IMessage msg, Net.CallbackStatus status)
	{
		PhantomItemAddNotify phantomItemAddNotify = (PhantomItemAddNotify)msg;
		RepeatedField<PhantomItem> phantomItemList = phantomItemAddNotify.PhantomItemList;
		if (phantomItemList == null || phantomItemList.Count == 0)
		{
			return;
		}
		InventoryModel instance = InventoryModel.Instance;
		foreach (PhantomItem phantomItem in phantomItemList)
		{
			int id = phantomItem.Id;
			int incrId = phantomItem.IncrId;
			int funcValue = phantomItem.FuncValue;
			PhantomItemData phantomItemData = instance.GetPhantomItemData(incrId);
			bool flag = true;
			if (phantomItemData != null)
			{
				if (phantomItem.StackCount > 0)
				{
					int stackCount = phantomItemData.GetStackCount();
					flag = (phantomItem.StackCount > stackCount);
					instance.UpdatePhantomItemData(phantomItem, "ItemAddNotify");
				}
				else
				{
					flag = false;
					Log instance2 = Log.Instance;
					ELogModule module = ELogModule.Phantom;
					ELogAuthor author = ELogAuthor.TZJ;
					string message = "[声骸堆叠] 入库通知携带已存在编号且数量缺失，忽略该条";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("incrId", incrId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("oldCount", phantomItemData.GetStackCount());
					instance2.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
			else
			{
				instance.NewPhantomItemData(id, incrId, funcValue, phantomItem.StackCount, phantomItem.AddTime);
			}
			if (flag)
			{
				instance.TryAddNewAttributeItem(incrId);
				instance.TryAddRedDotAttributeItem(incrId);
			}
			EventSystem.Instance.Emit<PhantomItem>(EEventName.OnAddPhantomItem, phantomItem);
		}
		if (phantomItemAddNotify.Reason == 19000)
		{
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				EventSystem.Instance.Emit<IReadOnlyList<PhantomItem>, bool>(EEventName.OnAddPhantomItemList, phantomItemList, true);
			}, (float)CalabashConfig.Instance.DelayTime, null, null, true, 1f);
		}
		else
		{
			EventSystem.Instance.Emit<IReadOnlyList<PhantomItem>, bool>(EEventName.OnAddPhantomItemList, phantomItemList, false);
		}
		instance.SaveNewAttributeItemUniqueIdList();
		instance.SaveRedDotAttributeItemUniqueIdList();
		EventSystem.Instance.Emit(EEventName.RedDotRefreshItemData);
	}

	// Token: 0x0600FC8A RID: 64650 RVA: 0x003D4DF8 File Offset: 0x003D2FF8
	private static void PhantomItemRemoveNotify(IMessage msg, Net.CallbackStatus status)
	{
		RepeatedField<int> phantomItemIncrIdList = ((PhantomItemRemoveNotify)msg).PhantomItemIncrIdList;
		if (phantomItemIncrIdList == null || phantomItemIncrIdList.Count == 0)
		{
			return;
		}
		InventoryModel.Instance.RemovePhantomItemDataAndNotify(phantomItemIncrIdList, "ItemRemoveNotify");
	}

	// Token: 0x0600FC8B RID: 64651 RVA: 0x003D4E30 File Offset: 0x003D3030
	[NullableContext(1)]
	public void ApplyPhantomStackSplitAndMerge([Nullable(new byte[]
	{
		2,
		1
	})] IReadOnlyList<PhantomStackSplitInfo> splitInfos, [Nullable(new byte[]
	{
		2,
		1
	})] IReadOnlyList<PhantomStackMergeInfo> mergeInfos, string reason = "")
	{
		InventoryModel instance = InventoryModel.Instance;
		List<PhantomItem> list = new List<PhantomItem>();
		if (splitInfos != null)
		{
			foreach (PhantomStackSplitInfo phantomStackSplitInfo in splitInfos)
			{
				PhantomItem operateItem = phantomStackSplitInfo.OperateItem;
				if (operateItem != null && operateItem.IncrId > 0)
				{
					instance.UpdatePhantomItemData(operateItem, "StackSplitOperate");
				}
				PhantomItem remainderItem = phantomStackSplitInfo.RemainderItem;
				if (remainderItem != null && remainderItem.IncrId > 0)
				{
					instance.NewPhantomItemData(remainderItem.Id, remainderItem.IncrId, remainderItem.FuncValue, remainderItem.StackCount, remainderItem.AddTime);
					EventSystem.Instance.Emit<PhantomItem>(EEventName.OnAddPhantomItem, remainderItem);
					list.Add(remainderItem);
				}
			}
		}
		if (mergeInfos != null)
		{
			foreach (PhantomStackMergeInfo phantomStackMergeInfo in mergeInfos)
			{
				int mergedIncrId = phantomStackMergeInfo.MergedIncrId;
				PhantomItem phantomItem = phantomStackMergeInfo.RepresentativeItem;
				if (phantomItem != null && phantomItem.IncrId <= 0)
				{
					phantomItem = null;
				}
				if (phantomItem != null)
				{
					instance.UpdatePhantomItemData(phantomItem, "StackMergeRepresentative");
				}
				if (mergedIncrId > 0)
				{
					if (phantomItem != null)
					{
						EventSystem.Instance.Emit<int, int>(EEventName.OnPhantomStackMerge, mergedIncrId, phantomItem.IncrId);
					}
					instance.RemovePhantomItemDataAndNotify(new int[]
					{
						mergedIncrId
					}, "StackMerge");
				}
			}
		}
		if (list.Count > 0)
		{
			EventSystem.Instance.Emit<IReadOnlyList<PhantomItem>, bool>(EEventName.OnAddPhantomItemList, list, false);
		}
	}

	// Token: 0x0600FC8C RID: 64652 RVA: 0x003D4FBC File Offset: 0x003D31BC
	[NullableContext(1)]
	public void InitCalabashSkinItemData(int[] skinIdList)
	{
		InventoryModel instance = InventoryModel.Instance;
		foreach (int configId in skinIdList)
		{
			instance.NewCalabashSkinItemData(configId);
		}
		instance.RefreshItemRedDotSet();
		EventSystem.Instance.Emit(EEventName.OnResponseCommonItemFinished);
	}

	// Token: 0x0600FC8D RID: 64653 RVA: 0x003D5000 File Offset: 0x003D3200
	[NullableContext(1)]
	public void AddCalabashSkinItemData(int[] skinIdList)
	{
		InventoryModel instance = InventoryModel.Instance;
		foreach (int num in skinIdList)
		{
			instance.NewCalabashSkinItemData(num);
			instance.TryAddNewCommonItem(num, 0);
			instance.TryAddRedDotCommonItem(num, 0);
			EventSystem.Instance.Emit<int, int>(EEventName.OnCommonItemCountAnyChange, num, 1);
		}
		instance.SaveNewCommonItemConfigIdList();
		instance.SaveRedDotCommonItemConfigIdList();
		EventSystem.Instance.Emit(EEventName.RedDotRefreshItemData);
	}

	// Token: 0x0600FC8E RID: 64654 RVA: 0x003D5070 File Offset: 0x003D3270
	[NullableContext(1)]
	public void InitOrnamentItemData(int[] ornamentIdList)
	{
		InventoryModel instance = InventoryModel.Instance;
		foreach (int configId in ornamentIdList)
		{
			instance.NewOrnamentItemData(configId);
		}
		instance.RefreshItemRedDotSet();
	}

	// Token: 0x0600FC8F RID: 64655 RVA: 0x003D50A4 File Offset: 0x003D32A4
	[NullableContext(1)]
	public void AddOrnamentItemData(int[] ornamentIdList)
	{
		InventoryModel instance = InventoryModel.Instance;
		foreach (int num in ornamentIdList)
		{
			instance.NewOrnamentItemData(num);
			instance.TryAddNewCommonItem(num, 0);
			instance.TryAddRedDotCommonItem(num, 0);
			EventSystem.Instance.Emit<int, int>(EEventName.OnCommonItemCountAnyChange, num, 1);
		}
		instance.SaveNewCommonItemConfigIdList();
		instance.SaveRedDotCommonItemConfigIdList();
		EventSystem.Instance.Emit(EEventName.RedDotRefreshItemData);
	}

	// Token: 0x0600FC90 RID: 64656 RVA: 0x003D5114 File Offset: 0x003D3314
	private static void ItemFuncValueUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		ItemFuncValueUpdateNotify itemFuncValueUpdateNotify = (ItemFuncValueUpdateNotify)msg;
		int incrId = itemFuncValueUpdateNotify.IncrId;
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(incrId);
		if (attributeItemData == null)
		{
			return;
		}
		int funcValue = itemFuncValueUpdateNotify.FuncValue;
		attributeItemData.SetFunctionValue(funcValue);
		EventSystem.Instance.Emit<int>(EEventName.OnItemFuncValueChange, incrId);
	}

	// Token: 0x0600FC91 RID: 64657 RVA: 0x003D5160 File Offset: 0x003D3360
	private static void InventoryTabOpenNotify(IMessage msg, Net.CallbackStatus status)
	{
		ItemPkgOpenNotify itemPkgOpenNotify = (ItemPkgOpenNotify)msg;
		InventoryModel.Instance.SetInventoryTabOpenIdList(itemPkgOpenNotify.OpenPkg.ToList<int>());
	}

	// Token: 0x0600FC92 RID: 64658 RVA: 0x003D5189 File Offset: 0x003D3389
	private static void InventoryFullNotify(IMessage msg, Net.CallbackStatus status)
	{
		ItemPkgFullNotify itemPkgFullNotify = (ItemPkgFullNotify)msg;
	}

	// Token: 0x0600FC93 RID: 64659 RVA: 0x003D5192 File Offset: 0x003D3392
	[NullableContext(1)]
	private static bool CanOpenView(EUiViewName viewName, object param)
	{
		if (SceneTeamModel.Instance.IsPhantomTeam || SceneTeamModel.Instance.HasPhantomRole())
		{
			ScrollingTipsController.Instance.ShowTipsById("PhantomFormationEnterInventoryTip", Array.Empty<object>());
			return false;
		}
		return FunctionModel.Instance.IsOpen(10002);
	}

	// Token: 0x0600FC94 RID: 64660 RVA: 0x003D51D4 File Offset: 0x003D33D4
	public void TryOpenPhantomFullConfirmBox(Action cancelFunc = null)
	{
		if (this.IsPhantomFullViewShow)
		{
			return;
		}
		this.IsPhantomFullViewShow = true;
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhantomCapacityMax);
		confirmBoxDataNew.FunctionMap.Add(1, cancelFunc);
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			CalabashController.Instance.JumpToCalabashRootView(EUiTabViewName.VisionRecoveryTabView, null);
		});
		confirmBoxDataNew.SetCloseFunction(delegate
		{
			this.IsPhantomFullViewShow = false;
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600FC95 RID: 64661 RVA: 0x003D5254 File Offset: 0x003D3454
	[NullableContext(1)]
	public void ItemDestructPreviewRequest(DecomposeItemInfo[] itemList)
	{
		ItemDecomposePreviewRequest itemDecomposePreviewRequest = ItemDecomposePreviewRequest.Create();
		itemDecomposePreviewRequest.ItemList.AddRange(itemList);
		Net.Instance.Call(ERequestMessageId.ItemDecomposePreviewRequest, itemDecomposePreviewRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ItemDecomposePreviewResponse itemDecomposePreviewResponse = (ItemDecomposePreviewResponse)msg;
			if (itemDecomposePreviewResponse == null)
			{
				return;
			}
			if (itemDecomposePreviewResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(itemDecomposePreviewResponse.ErrorCode, 16088, null, true, true);
				return;
			}
			List<TItem> list = new List<TItem>();
			foreach (DecomposeItemInfo decomposeItemInfo in itemList)
			{
				TItem item = new TItem(new InventoryDefine.GetItemData(decomposeItemInfo.ItemId, decomposeItemInfo.IncrId), decomposeItemInfo.Count);
				list.Add(item);
			}
			List<TItem> list2 = new List<TItem>();
			foreach (KeyValuePair<int, int> keyValuePair in itemDecomposePreviewResponse.ItemMap)
			{
				TItem item2 = new TItem(new InventoryDefine.GetItemData(keyValuePair.Key, 0), keyValuePair.Value);
				list2.Add(item2);
			}
			list2.Sort((TItem a, TItem b) => a.ItemData.ItemId - b.ItemData.ItemId);
			ItemViewDefine.DestroyPreviewData param = new ItemViewDefine.DestroyPreviewData
			{
				OriginList = list,
				ResultList = list2
			};
			UiManager.Instance.OpenView(EUiViewName.DestroyPreviewView, param, null);
		}, 0);
	}

	// Token: 0x0600FC96 RID: 64662 RVA: 0x003D52A4 File Offset: 0x003D34A4
	[NullableContext(1)]
	public void ItemDestructRequest(DecomposeItemInfo[] itemList)
	{
		ItemDecomposeRequest itemDecomposeRequest = ItemDecomposeRequest.Create();
		itemDecomposeRequest.ItemList.AddRange(itemList);
		Net.Instance.Call(ERequestMessageId.ItemDecomposeRequest, itemDecomposeRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ItemDecomposeResponse itemDecomposeResponse = (ItemDecomposeResponse)msg;
			if (itemDecomposeResponse == null)
			{
				return;
			}
			if (itemDecomposeResponse.ErrCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(itemDecomposeResponse.ErrCode, 23183, null, true, true);
				return;
			}
		}, 0);
	}

	// Token: 0x0600FC97 RID: 64663 RVA: 0x003D52F4 File Offset: 0x003D34F4
	public void InvalidItemRemoveRequest()
	{
		if (this.InvalidItemRemoveRequestLock)
		{
			return;
		}
		this.InvalidItemRemoveRequestLock = true;
		InvalidItemRequest message = InvalidItemRequest.Create();
		Net.Instance.Call(ERequestMessageId.InvalidItemRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			InvalidItemResponse invalidItemResponse = (InvalidItemResponse)msg;
			this.InvalidItemRemoveRequestLock = false;
			if (invalidItemResponse == null)
			{
				return;
			}
			if (!invalidItemResponse.HasInvalidItem && !invalidItemResponse.HasExpireConvertItem)
			{
				return;
			}
			if (UiManager.Instance.IsViewOpen(EUiViewName.InventoryView))
			{
				this.InvalidItemCheckRequest();
			}
		}, 0);
	}

	// Token: 0x0600FC98 RID: 64664 RVA: 0x003D5334 File Offset: 0x003D3534
	public void InvalidItemCheckRequest()
	{
		ShowInvalidItemRequest message = ShowInvalidItemRequest.Create();
		Net.Instance.Call(ERequestMessageId.ShowInvalidItemRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			ShowInvalidItemResponse showInvalidItemResponse = (ShowInvalidItemResponse)msg;
			if (showInvalidItemResponse == null)
			{
				return;
			}
			this.PhraseInvalidItem(showInvalidItemResponse);
			this.PhraseExpireConvertItem(showInvalidItemResponse);
		}, 0);
	}

	// Token: 0x0600FC99 RID: 64665 RVA: 0x003D5364 File Offset: 0x003D3564
	[NullableContext(1)]
	private void PhraseExpireConvertItem(ShowInvalidItemResponse response)
	{
		if (response.ExpireConvertItemInfoList == null || response.ExpireConvertItemInfoList.Count == 0)
		{
			return;
		}
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
		foreach (ExpireConvertItemInfo expireConvertItemInfo in response.ExpireConvertItemInfoList)
		{
			int num;
			if (!dictionary.TryGetValue(expireConvertItemInfo.ItemId, out num))
			{
				num = 0;
			}
			dictionary[expireConvertItemInfo.ItemId] = num + expireConvertItemInfo.ItemCount;
			if (expireConvertItemInfo.ExpireConvertTargetItemInfos != null)
			{
				foreach (ExpireConvertTargetItemInfo expireConvertTargetItemInfo in expireConvertItemInfo.ExpireConvertTargetItemInfos)
				{
					int num2;
					if (!dictionary2.TryGetValue(expireConvertTargetItemInfo.ItemId, out num2))
					{
						num2 = 0;
					}
					dictionary2[expireConvertTargetItemInfo.ItemId] = num2 + expireConvertTargetItemInfo.ItemCount;
				}
			}
		}
		List<TItem> list = new List<TItem>();
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			TItem item = new TItem(new InventoryDefine.GetItemData(keyValuePair.Key, 0), keyValuePair.Value);
			list.Add(item);
		}
		List<TItem> list2 = new List<TItem>();
		foreach (KeyValuePair<int, int> keyValuePair2 in dictionary2)
		{
			TItem item2 = new TItem(new InventoryDefine.GetItemData(keyValuePair2.Key, 0), keyValuePair2.Value);
			list2.Add(item2);
		}
		list.Sort((TItem a, TItem b) => a.ItemData.ItemId - b.ItemData.ItemId);
		list2.Sort((TItem a, TItem b) => a.ItemData.ItemId - b.ItemData.ItemId);
		EventSystem.Instance.Emit<IReadOnlyList<TItem>, IReadOnlyList<TItem>>(EEventName.NotifyExpireConvertItem, list, list2);
	}

	// Token: 0x0600FC9A RID: 64666 RVA: 0x003D5594 File Offset: 0x003D3794
	[NullableContext(1)]
	private void PhraseInvalidItem(ShowInvalidItemResponse response)
	{
		if (response.InvalidItemList == null || response.InvalidItemList.Count == 0)
		{
			return;
		}
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (InvalidItem invalidItem in response.InvalidItemList)
		{
			int num;
			if (dictionary.TryGetValue(invalidItem.ItemId, out num))
			{
				dictionary[invalidItem.ItemId] = num + invalidItem.Count;
			}
			else
			{
				dictionary.Add(invalidItem.ItemId, invalidItem.Count);
			}
		}
		List<TItem> list = new List<TItem>();
		foreach (KeyValuePair<int, int> keyValuePair in dictionary)
		{
			TItem item = new TItem(new InventoryDefine.GetItemData(keyValuePair.Key, 0), keyValuePair.Value);
			list.Add(item);
		}
		list.Sort((TItem a, TItem b) => a.ItemData.ItemId - b.ItemData.ItemId);
		Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
		foreach (TItem titem in list)
		{
			dictionary2[titem.ItemData.ItemId] = titem.Count;
		}
		EventSystem.Instance.Emit<Dictionary<int, int>>(EEventName.NotifyInvalidItem, dictionary2);
	}

	// Token: 0x0600FC9B RID: 64667 RVA: 0x003D5724 File Offset: 0x003D3924
	public bool TryUseItem(int itemId, int num = 1)
	{
		Func<int, int, bool>[] useItemLogicList = this.UseItemLogicList;
		for (int i = 0; i < useItemLogicList.Length; i++)
		{
			if (useItemLogicList[i](itemId, num))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600FC9C RID: 64668 RVA: 0x003D5755 File Offset: 0x003D3955
	public bool TryUseGiftItemWithSelectedItem(int giftItemId, int itemId, int num = 1)
	{
		return ItemUseLogic.TryUseGiftItemWithSelectedItem(giftItemId, itemId, num);
	}

	// Token: 0x0600FC9D RID: 64669 RVA: 0x003D5760 File Offset: 0x003D3960
	[NullableContext(0)]
	public UniTask<bool> PhantomFuncValueBatchRequest([Nullable(1)] int[] uniqueIdList, PhantomBatchOper operate)
	{
		InventoryController.<PhantomFuncValueBatchRequest>d__56 <PhantomFuncValueBatchRequest>d__;
		<PhantomFuncValueBatchRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<PhantomFuncValueBatchRequest>d__.uniqueIdList = uniqueIdList;
		<PhantomFuncValueBatchRequest>d__.operate = operate;
		<PhantomFuncValueBatchRequest>d__.<>1__state = -1;
		<PhantomFuncValueBatchRequest>d__.<>t__builder.Start<InventoryController.<PhantomFuncValueBatchRequest>d__56>(ref <PhantomFuncValueBatchRequest>d__);
		return <PhantomFuncValueBatchRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600FC9E RID: 64670 RVA: 0x003D57AC File Offset: 0x003D39AC
	public void PhantomManageConfigRequest(Action callback = null)
	{
		PhantomSettingRequest message = PhantomSettingRequest.Create();
		Net.Instance.Call(ERequestMessageId.PhantomSettingRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PhantomSettingResponse phantomSettingResponse = (PhantomSettingResponse)msg;
			if (phantomSettingResponse == null)
			{
				return;
			}
			InventoryModel.Instance.InitPhantomManageConfig(phantomSettingResponse);
			if (callback != null)
			{
				callback();
			}
		}, 0);
	}

	// Token: 0x0600FC9F RID: 64671 RVA: 0x003D57EC File Offset: 0x003D39EC
	public UniTask PhantomManageConfigRequestAsync()
	{
		InventoryController.<PhantomManageConfigRequestAsync>d__58 <PhantomManageConfigRequestAsync>d__;
		<PhantomManageConfigRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PhantomManageConfigRequestAsync>d__.<>1__state = -1;
		<PhantomManageConfigRequestAsync>d__.<>t__builder.Start<InventoryController.<PhantomManageConfigRequestAsync>d__58>(ref <PhantomManageConfigRequestAsync>d__);
		return <PhantomManageConfigRequestAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FCA0 RID: 64672 RVA: 0x003D5828 File Offset: 0x003D3A28
	[NullableContext(0)]
	public UniTask<ErrorCode> PhantomManageConfigUpdateRequest(PhantomSettingType type, [Nullable(2)] OnePhantomSetting setting)
	{
		InventoryController.<PhantomManageConfigUpdateRequest>d__59 <PhantomManageConfigUpdateRequest>d__;
		<PhantomManageConfigUpdateRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<ErrorCode>.Create();
		<PhantomManageConfigUpdateRequest>d__.type = type;
		<PhantomManageConfigUpdateRequest>d__.setting = setting;
		<PhantomManageConfigUpdateRequest>d__.<>1__state = -1;
		<PhantomManageConfigUpdateRequest>d__.<>t__builder.Start<InventoryController.<PhantomManageConfigUpdateRequest>d__59>(ref <PhantomManageConfigUpdateRequest>d__);
		return <PhantomManageConfigUpdateRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600FCA1 RID: 64673 RVA: 0x003D5874 File Offset: 0x003D3A74
	[NullableContext(0)]
	public UniTask<bool> PhantomSettingBatchUpdateRequestAsync([Nullable(1)] PhantomSettingInfo[] settings)
	{
		InventoryController.<PhantomSettingBatchUpdateRequestAsync>d__60 <PhantomSettingBatchUpdateRequestAsync>d__;
		<PhantomSettingBatchUpdateRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<PhantomSettingBatchUpdateRequestAsync>d__.settings = settings;
		<PhantomSettingBatchUpdateRequestAsync>d__.<>1__state = -1;
		<PhantomSettingBatchUpdateRequestAsync>d__.<>t__builder.Start<InventoryController.<PhantomSettingBatchUpdateRequestAsync>d__60>(ref <PhantomSettingBatchUpdateRequestAsync>d__);
		return <PhantomSettingBatchUpdateRequestAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FCA2 RID: 64674 RVA: 0x003D58B8 File Offset: 0x003D3AB8
	public void OpenManageConfigView()
	{
		if (!FunctionModel.Instance.IsOpen(10096))
		{
			return;
		}
		CalabashRootViewData param = new CalabashRootViewData
		{
			TabViewName = EUiTabViewName.PhantomManageConfigView,
			Param = null
		};
		UiManager.Instance.OpenView(EUiViewName.CalabashRootView, param, null);
	}

	// Token: 0x0600FCA3 RID: 64675 RVA: 0x003D5900 File Offset: 0x003D3B00
	public void OpenManageConfigNewView()
	{
		if (!FunctionModel.Instance.IsOpen(10096))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("GenericPrompt_FunctionDisable_TipsText", Array.Empty<object>());
			return;
		}
		CalabashRootViewData param = new CalabashRootViewData
		{
			TabViewName = EUiTabViewName.PhantomManageConfigNewView,
			Param = null
		};
		UiManager.Instance.OpenView(EUiViewName.CalabashRootView, param, null);
	}

	// Token: 0x0600FCA4 RID: 64676 RVA: 0x003D595C File Offset: 0x003D3B5C
	private int GetDeprecatedPhantomCount()
	{
		List<PhantomItemData> phantomItemDataList = InventoryModel.Instance.GetPhantomItemDataList();
		int num = 0;
		using (List<PhantomItemData>.Enumerator enumerator = phantomItemDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetIsDeprecated())
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x0600FCA5 RID: 64677 RVA: 0x003D59BC File Offset: 0x003D3BBC
	private int GetTotalPhantomCount()
	{
		return InventoryModel.Instance.GetPhantomItemDataList().Count;
	}

	// Token: 0x0600FCA6 RID: 64678 RVA: 0x003D59D0 File Offset: 0x003D3BD0
	public bool CheckAndShowPhantomTips()
	{
		if (this.IsPhantomFullViewLoginNotShow)
		{
			return false;
		}
		if (UiManager.Instance.IsViewOpen(EUiViewName.PhantomSmartDiscardPopupView))
		{
			return false;
		}
		if (ConfirmBoxController.Instance.CheckIsConfirmBoxOpen())
		{
			return false;
		}
		int deprecatedPhantomCount = this.GetDeprecatedPhantomCount();
		int totalPhantomCount = this.GetTotalPhantomCount();
		if (deprecatedPhantomCount >= InventoryConfig.Instance.GetPhantomFusionThreshold())
		{
			this.ShowPhantomFusionTip(deprecatedPhantomCount);
			return true;
		}
		if (totalPhantomCount >= InventoryConfig.Instance.GetPhantomDiscardThreshold())
		{
			this.ShowPhantomDiscardTip(totalPhantomCount);
			return true;
		}
		return false;
	}

	// Token: 0x0600FCA7 RID: 64679 RVA: 0x003D5A44 File Offset: 0x003D3C44
	private void ShowPhantomFusionTip(int deprecatedCount)
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhantomFullFusionConfirm);
		PhantomDiscardPlanRecycleReport logData = new PhantomDiscardPlanRecycleReport
		{
			i_type = 0
		};
		confirmBoxDataNew.FunctionMap.Add(1, delegate
		{
			logData.i_operation = 0;
			LogReportController.Instance.LogReport(logData);
		});
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			logData.i_operation = 1;
			LogReportController.Instance.LogReport(logData);
			CalabashController.Instance.JumpToCalabashRootView(EUiTabViewName.VisionRecoveryTabView, null);
		});
		confirmBoxDataNew.SetTextArgs(new string[]
		{
			deprecatedCount.ToString()
		});
		confirmBoxDataNew.HasToggle = true;
		confirmBoxDataNew.ToggleTextKey = "ConfirmBox_363_Desc";
		confirmBoxDataNew.SetToggleFunction(delegate(bool isSelectOn)
		{
			this.IsPhantomFullViewLoginNotShow = isSelectOn;
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600FCA8 RID: 64680 RVA: 0x003D5AF4 File Offset: 0x003D3CF4
	private void ShowPhantomDiscardTip(int totalCount)
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhantomFullDiscardConfirm);
		PhantomDiscardPlanRecycleReport logData = new PhantomDiscardPlanRecycleReport
		{
			i_type = 1
		};
		confirmBoxDataNew.FunctionMap.Add(1, delegate
		{
			logData.i_operation = 0;
			LogReportController.Instance.LogReport(logData);
		});
		confirmBoxDataNew.FunctionMap.Add(2, delegate
		{
			logData.i_operation = 1;
			LogReportController.Instance.LogReport(logData);
			UiManager.Instance.OpenView(EUiViewName.PhantomSmartDiscardPopupView, null, delegate(bool success, int viewId)
			{
				UiViewBase uiViewBase = null;
				if (UiManager.Instance.IsViewOpen(EUiViewName.PhantomManageView))
				{
					uiViewBase = UiManager.Instance.GetViewByName(EUiViewName.PhantomManageView);
				}
				else if (UiManager.Instance.IsViewOpen(EUiViewName.InventoryView))
				{
					uiViewBase = UiManager.Instance.GetViewByName(EUiViewName.InventoryView);
				}
				if (uiViewBase != null)
				{
					uiViewBase.AddChildViewById(viewId);
				}
			});
		});
		confirmBoxDataNew.SetTextArgs(new string[]
		{
			totalCount.ToString()
		});
		confirmBoxDataNew.HasToggle = true;
		confirmBoxDataNew.ToggleTextKey = "ConfirmBox_363_Desc";
		confirmBoxDataNew.SetToggleFunction(delegate(bool isSelectOn)
		{
			this.IsPhantomFullViewLoginNotShow = isSelectOn;
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600FCA9 RID: 64681 RVA: 0x003D5BA4 File Offset: 0x003D3DA4
	[NullableContext(0)]
	public UniTask<bool> ShowPhantomDiscardFusionTip([Nullable(1)] int[] discardList)
	{
		InventoryController.<ShowPhantomDiscardFusionTip>d__68 <ShowPhantomDiscardFusionTip>d__;
		<ShowPhantomDiscardFusionTip>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<ShowPhantomDiscardFusionTip>d__.<>4__this = this;
		<ShowPhantomDiscardFusionTip>d__.discardList = discardList;
		<ShowPhantomDiscardFusionTip>d__.<>1__state = -1;
		<ShowPhantomDiscardFusionTip>d__.<>t__builder.Start<InventoryController.<ShowPhantomDiscardFusionTip>d__68>(ref <ShowPhantomDiscardFusionTip>d__);
		return <ShowPhantomDiscardFusionTip>d__.<>t__builder.Task;
	}

	// Token: 0x17001355 RID: 4949
	// (get) Token: 0x0600FCAA RID: 64682 RVA: 0x003D5BEF File Offset: 0x003D3DEF
	[Nullable(1)]
	public static InventoryController Instance
	{
		[NullableContext(1)]
		get
		{
			return InventoryController._Instance;
		}
	}

	// Token: 0x0600FCAB RID: 64683 RVA: 0x003D5BF6 File Offset: 0x003D3DF6
	[NullableContext(1)]
	public static InventoryController GetOrCreateInstance()
	{
		if (InventoryController._Instance == null)
		{
			InventoryController.CreateInstance();
		}
		return InventoryController._Instance;
	}

	// Token: 0x0600FCAC RID: 64684 RVA: 0x003D5C0A File Offset: 0x003D3E0A
	public static bool CreateInstance()
	{
		if (InventoryController._Instance != null)
		{
			return true;
		}
		InventoryController._Instance = new InventoryController();
		return true;
	}

	// Token: 0x0600FCAD RID: 64685 RVA: 0x003D5C20 File Offset: 0x003D3E20
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600FCAE RID: 64686 RVA: 0x003D5C22 File Offset: 0x003D3E22
	public static void ResetStaticDefaultValue()
	{
		InventoryController._Instance = null;
	}

	// Token: 0x0600FCAF RID: 64687 RVA: 0x003D5C2A File Offset: 0x003D3E2A
	static InventoryController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InventoryController.CreateStaticDefaultValue), new Action(InventoryController.ResetStaticDefaultValue));
	}

	// Token: 0x0600FCB0 RID: 64688 RVA: 0x003D5C4C File Offset: 0x003D3E4C
	public InventoryController()
	{
		Func<int, int, bool>[] array = new Func<int, int, bool>[18];
		int num = 0;
		Func<int, int, bool> func;
		if ((func = InventoryController.<>O.<19>__TryUseOrnamentItem) == null)
		{
			func = (InventoryController.<>O.<19>__TryUseOrnamentItem = new Func<int, int, bool>(ItemUseLogic.TryUseOrnamentItem));
		}
		array[num] = func;
		int num2 = 1;
		Func<int, int, bool> func2;
		if ((func2 = InventoryController.<>O.<20>__TryUseVisionRefineItem) == null)
		{
			func2 = (InventoryController.<>O.<20>__TryUseVisionRefineItem = new Func<int, int, bool>(ItemUseLogic.TryUseVisionRefineItem));
		}
		array[num2] = func2;
		int num3 = 2;
		Func<int, int, bool> func3;
		if ((func3 = InventoryController.<>O.<21>__TryUseVisionRefineSubItem) == null)
		{
			func3 = (InventoryController.<>O.<21>__TryUseVisionRefineSubItem = new Func<int, int, bool>(ItemUseLogic.TryUseVisionRefineSubItem));
		}
		array[num3] = func3;
		int num4 = 3;
		Func<int, int, bool> func4;
		if ((func4 = InventoryController.<>O.<22>__TryUseUiPlayItem) == null)
		{
			func4 = (InventoryController.<>O.<22>__TryUseUiPlayItem = new Func<int, int, bool>(ItemUseLogic.TryUseUiPlayItem));
		}
		array[num4] = func4;
		int num5 = 4;
		Func<int, int, bool> func5;
		if ((func5 = InventoryController.<>O.<23>__TryUseBuffItem) == null)
		{
			func5 = (InventoryController.<>O.<23>__TryUseBuffItem = new Func<int, int, bool>(ItemUseLogic.TryUseBuffItem));
		}
		array[num5] = func5;
		int num6 = 5;
		Func<int, int, bool> func6;
		if ((func6 = InventoryController.<>O.<24>__TryUsePowerItem) == null)
		{
			func6 = (InventoryController.<>O.<24>__TryUsePowerItem = new Func<int, int, bool>(ItemUseLogic.TryUsePowerItem));
		}
		array[num6] = func6;
		int num7 = 6;
		Func<int, int, bool> func7;
		if ((func7 = InventoryController.<>O.<25>__TryUseTotalTopUpRolePickItem) == null)
		{
			func7 = (InventoryController.<>O.<25>__TryUseTotalTopUpRolePickItem = new Func<int, int, bool>(ItemUseLogic.TryUseTotalTopUpRolePickItem));
		}
		array[num7] = func7;
		int num8 = 7;
		Func<int, int, bool> func8;
		if ((func8 = InventoryController.<>O.<26>__TryUseGiftItem) == null)
		{
			func8 = (InventoryController.<>O.<26>__TryUseGiftItem = new Func<int, int, bool>(ItemUseLogic.TryUseGiftItem));
		}
		array[num8] = func8;
		int num9 = 8;
		Func<int, int, bool> func9;
		if ((func9 = InventoryController.<>O.<27>__TryUseResonantChainOptionalItem) == null)
		{
			func9 = (InventoryController.<>O.<27>__TryUseResonantChainOptionalItem = new Func<int, int, bool>(ItemUseLogic.TryUseResonantChainOptionalItem));
		}
		array[num9] = func9;
		int num10 = 9;
		Func<int, int, bool> func10;
		if ((func10 = InventoryController.<>O.<28>__TryUseMonthCardItem) == null)
		{
			func10 = (InventoryController.<>O.<28>__TryUseMonthCardItem = new Func<int, int, bool>(ItemUseLogic.TryUseMonthCardItem));
		}
		array[num10] = func10;
		int num11 = 10;
		Func<int, int, bool> func11;
		if ((func11 = InventoryController.<>O.<29>__TryUseBattlePassItem) == null)
		{
			func11 = (InventoryController.<>O.<29>__TryUseBattlePassItem = new Func<int, int, bool>(ItemUseLogic.TryUseBattlePassItem));
		}
		array[num11] = func11;
		int num12 = 11;
		Func<int, int, bool> func12;
		if ((func12 = InventoryController.<>O.<30>__TryUseBirthdayItem) == null)
		{
			func12 = (InventoryController.<>O.<30>__TryUseBirthdayItem = new Func<int, int, bool>(ItemUseLogic.TryUseBirthdayItem));
		}
		array[num12] = func12;
		int num13 = 12;
		Func<int, int, bool> func13;
		if ((func13 = InventoryController.<>O.<31>__TryUseBrochureItem) == null)
		{
			func13 = (InventoryController.<>O.<31>__TryUseBrochureItem = new Func<int, int, bool>(ItemUseLogic.TryUseBrochureItem));
		}
		array[num13] = func13;
		int num14 = 13;
		Func<int, int, bool> func14;
		if ((func14 = InventoryController.<>O.<32>__TryUseBuffEquipItem) == null)
		{
			func14 = (InventoryController.<>O.<32>__TryUseBuffEquipItem = new Func<int, int, bool>(ItemUseLogic.TryUseBuffEquipItem));
		}
		array[num14] = func14;
		int num15 = 14;
		Func<int, int, bool> func15;
		if ((func15 = InventoryController.<>O.<33>__TryUsePayShopCouponItem) == null)
		{
			func15 = (InventoryController.<>O.<33>__TryUsePayShopCouponItem = new Func<int, int, bool>(ItemUseLogic.TryUsePayShopCouponItem));
		}
		array[num15] = func15;
		int num16 = 15;
		Func<int, int, bool> func16;
		if ((func16 = InventoryController.<>O.<34>__TryUseStudentCardItem) == null)
		{
			func16 = (InventoryController.<>O.<34>__TryUseStudentCardItem = new Func<int, int, bool>(ItemUseLogic.TryUseStudentCardItem));
		}
		array[num16] = func16;
		int num17 = 16;
		Func<int, int, bool> func17;
		if ((func17 = InventoryController.<>O.<35>__TryUseParameterItem) == null)
		{
			func17 = (InventoryController.<>O.<35>__TryUseParameterItem = new Func<int, int, bool>(ItemUseLogic.TryUseParameterItem));
		}
		array[num17] = func17;
		int num18 = 17;
		Func<int, int, bool> func18;
		if ((func18 = InventoryController.<>O.<36>__TryUseShipTowerItem) == null)
		{
			func18 = (InventoryController.<>O.<36>__TryUseShipTowerItem = new Func<int, int, bool>(ItemUseLogic.TryUseShipTowerItem));
		}
		array[num18] = func18;
		this.UseItemLogicList = array;
		base..ctor();
	}

	// Token: 0x04007561 RID: 30049
	private const int VISION_CATCH_REASON = 19000;

	// Token: 0x04007562 RID: 30050
	private const int GACHA_REASON = 14000;

	// Token: 0x04007563 RID: 30051
	private bool IsPhantomFullViewShow = true;

	// Token: 0x04007564 RID: 30052
	private bool IsPhantomFullViewLoginNotShow;

	// Token: 0x04007565 RID: 30053
	private bool IsPhantomDiscardFuseLoginNotShow;

	// Token: 0x04007566 RID: 30054
	private bool InvalidItemRemoveRequestLock;

	// Token: 0x04007567 RID: 30055
	[Nullable(1)]
	private readonly Func<int, int, bool>[] UseItemLogicList;

	// Token: 0x04007568 RID: 30056
	private static InventoryController _Instance;

	// Token: 0x020085AA RID: 34218
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402B849 RID: 178249
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <0>__NormalItemUpdateNotify;

		// Token: 0x0402B84A RID: 178250
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <1>__NormalItemRemoveNotify;

		// Token: 0x0402B84B RID: 178251
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <2>__NormalItemAddNotify;

		// Token: 0x0402B84C RID: 178252
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <3>__ValidTimeItemUpdateNotify;

		// Token: 0x0402B84D RID: 178253
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <4>__ValidTimeItemRemoveNotify;

		// Token: 0x0402B84E RID: 178254
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <5>__ValidTimeItemAddNotify;

		// Token: 0x0402B84F RID: 178255
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <6>__WeaponItemAddNotify;

		// Token: 0x0402B850 RID: 178256
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <7>__WeaponItemRemoveNotify;

		// Token: 0x0402B851 RID: 178257
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <8>__PhantomItemAddNotify;

		// Token: 0x0402B852 RID: 178258
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <9>__PhantomItemRemoveNotify;

		// Token: 0x0402B853 RID: 178259
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <10>__ItemFuncValueUpdateNotify;

		// Token: 0x0402B854 RID: 178260
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <11>__InventoryTabOpenNotify;

		// Token: 0x0402B855 RID: 178261
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <12>__InventoryFullNotify;

		// Token: 0x0402B856 RID: 178262
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <13>__InventoryBanItemUseNotify;

		// Token: 0x0402B857 RID: 178263
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Func<EUiViewName, object, bool> <14>__CanOpenView;

		// Token: 0x0402B858 RID: 178264
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <15>__NormalItemResponse;

		// Token: 0x0402B859 RID: 178265
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <16>__ValidTimeItemResponse;

		// Token: 0x0402B85A RID: 178266
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <17>__WeaponItemResponse;

		// Token: 0x0402B85B RID: 178267
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <18>__PhantomItemResponse;

		// Token: 0x0402B85C RID: 178268
		[Nullable(0)]
		public static Func<int, int, bool> <19>__TryUseOrnamentItem;

		// Token: 0x0402B85D RID: 178269
		[Nullable(0)]
		public static Func<int, int, bool> <20>__TryUseVisionRefineItem;

		// Token: 0x0402B85E RID: 178270
		[Nullable(0)]
		public static Func<int, int, bool> <21>__TryUseVisionRefineSubItem;

		// Token: 0x0402B85F RID: 178271
		[Nullable(0)]
		public static Func<int, int, bool> <22>__TryUseUiPlayItem;

		// Token: 0x0402B860 RID: 178272
		[Nullable(0)]
		public static Func<int, int, bool> <23>__TryUseBuffItem;

		// Token: 0x0402B861 RID: 178273
		[Nullable(0)]
		public static Func<int, int, bool> <24>__TryUsePowerItem;

		// Token: 0x0402B862 RID: 178274
		[Nullable(0)]
		public static Func<int, int, bool> <25>__TryUseTotalTopUpRolePickItem;

		// Token: 0x0402B863 RID: 178275
		[Nullable(0)]
		public static Func<int, int, bool> <26>__TryUseGiftItem;

		// Token: 0x0402B864 RID: 178276
		[Nullable(0)]
		public static Func<int, int, bool> <27>__TryUseResonantChainOptionalItem;

		// Token: 0x0402B865 RID: 178277
		[Nullable(0)]
		public static Func<int, int, bool> <28>__TryUseMonthCardItem;

		// Token: 0x0402B866 RID: 178278
		[Nullable(0)]
		public static Func<int, int, bool> <29>__TryUseBattlePassItem;

		// Token: 0x0402B867 RID: 178279
		[Nullable(0)]
		public static Func<int, int, bool> <30>__TryUseBirthdayItem;

		// Token: 0x0402B868 RID: 178280
		[Nullable(0)]
		public static Func<int, int, bool> <31>__TryUseBrochureItem;

		// Token: 0x0402B869 RID: 178281
		[Nullable(0)]
		public static Func<int, int, bool> <32>__TryUseBuffEquipItem;

		// Token: 0x0402B86A RID: 178282
		[Nullable(0)]
		public static Func<int, int, bool> <33>__TryUsePayShopCouponItem;

		// Token: 0x0402B86B RID: 178283
		[Nullable(0)]
		public static Func<int, int, bool> <34>__TryUseStudentCardItem;

		// Token: 0x0402B86C RID: 178284
		[Nullable(0)]
		public static Func<int, int, bool> <35>__TryUseParameterItem;

		// Token: 0x0402B86D RID: 178285
		[Nullable(0)]
		public static Func<int, int, bool> <36>__TryUseShipTowerItem;
	}
}
