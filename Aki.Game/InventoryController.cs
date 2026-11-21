using System;
using System.Collections.Generic;
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

// Token: 0x0200146F RID: 5231
[NullableContext(2)]
[Nullable(0)]
[Controller(0)]
public class InventoryController : UiControllerBase
{
	// Token: 0x0600D090 RID: 53392 RVA: 0x003DF3AA File Offset: 0x003DD5AA
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<EOperationType, EOperationType>(EEventName.ShowTypeChange, new Action<EOperationType, EOperationType>(this.ShowTypeChange));
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
	}

	// Token: 0x0600D091 RID: 53393 RVA: 0x003DF3E4 File Offset: 0x003DD5E4
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.ShowTypeChange, new Action<EOperationType, EOperationType>(this.ShowTypeChange));
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
	}

	// Token: 0x0600D092 RID: 53394 RVA: 0x003DF420 File Offset: 0x003DD620
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

	// Token: 0x0600D093 RID: 53395 RVA: 0x003DF688 File Offset: 0x003DD888
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

	// Token: 0x0600D094 RID: 53396 RVA: 0x003DF775 File Offset: 0x003DD975
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

	// Token: 0x0600D095 RID: 53397 RVA: 0x003DF7A6 File Offset: 0x003DD9A6
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

	// Token: 0x0600D096 RID: 53398 RVA: 0x003DF7D2 File Offset: 0x003DD9D2
	private void OnDataDone()
	{
		this.NormalItemRequest();
		this.WeaponItemRequest();
		this.PhantomItemRequest();
		this.ValidTimeItemRequest();
	}

	// Token: 0x0600D097 RID: 53399 RVA: 0x003DF7EC File Offset: 0x003DD9EC
	private void ShowTypeChange(EOperationType last, EOperationType now)
	{
		if (UiManager.Instance.IsViewShow(EUiViewName.InventoryView))
		{
			UiManager.Instance.CloseView(EUiViewName.InventoryView, null);
			UiManager.Instance.OpenView(EUiViewName.InventoryView, null, null);
		}
	}

	// Token: 0x0600D098 RID: 53400 RVA: 0x003DF820 File Offset: 0x003DDA20
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(itemLockResponse.ErrCode, 22732, null, true, true);
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

	// Token: 0x0600D099 RID: 53401 RVA: 0x003DF8C8 File Offset: 0x003DDAC8
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(itemDisuseResponse.ErrCode, 28866, null, true, true);
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

	// Token: 0x0600D09A RID: 53402 RVA: 0x003DF948 File Offset: 0x003DDB48
	public unsafe void RequestItemUse(int configId, int count)
	{
		InventoryController.<>c__DisplayClass16_0 CS$<>8__locals1 = new InventoryController.<>c__DisplayClass16_0();
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
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Inventory;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[InventoryController.RequestItemUse] 道具使用被限制条件拦截";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("configId", CS$<>8__locals1.configId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("conditionGroupId", restrictConditionGroupId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("conditionIds", LevelGeneralCommons.GetReachedConditionIds(restrictConditionGroupId));
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
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
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Inventory;
			ELogAuthor author2 = ELogAuthor.ZYL;
			string message2 = "试图请求使用的特殊道具被禁用";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configId", CS$<>8__locals1.configId);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
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

	// Token: 0x0600D09B RID: 53403 RVA: 0x003DFB54 File Offset: 0x003DDD54
	[NullableContext(1)]
	private static void StartRequestItemUse(int configId, int count, Action<ErrorCode?> callBack)
	{
		InventoryController.<>c__DisplayClass17_0 CS$<>8__locals1 = new InventoryController.<>c__DisplayClass17_0();
		CS$<>8__locals1.callBack = callBack;
		ItemUseRequest itemUseRequest = ItemUseRequest.Create();
		itemUseRequest.ItemId = configId;
		itemUseRequest.Count = count;
		Net.Instance.Call(ERequestMessageId.ItemUseRequest, itemUseRequest, new Action<IMessage, Net.CallbackStatus>(CS$<>8__locals1.<StartRequestItemUse>g__responseItemUse|0), 0);
	}

	// Token: 0x0600D09C RID: 53404 RVA: 0x003DFBA0 File Offset: 0x003DDDA0
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

	// Token: 0x0600D09D RID: 53405 RVA: 0x003DFC1C File Offset: 0x003DDE1C
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

	// Token: 0x0600D09E RID: 53406 RVA: 0x003DFC5C File Offset: 0x003DDE5C
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

	// Token: 0x0600D09F RID: 53407 RVA: 0x003DFD14 File Offset: 0x003DDF14
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

	// Token: 0x0600D0A0 RID: 53408 RVA: 0x003DFE54 File Offset: 0x003DE054
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

	// Token: 0x0600D0A1 RID: 53409 RVA: 0x003DFF20 File Offset: 0x003DE120
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

	// Token: 0x0600D0A2 RID: 53410 RVA: 0x003E0074 File Offset: 0x003DE274
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

	// Token: 0x0600D0A3 RID: 53411 RVA: 0x003E00B4 File Offset: 0x003DE2B4
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

	// Token: 0x0600D0A4 RID: 53412 RVA: 0x003E0168 File Offset: 0x003DE368
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

	// Token: 0x0600D0A5 RID: 53413 RVA: 0x003E027C File Offset: 0x003DE47C
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

	// Token: 0x0600D0A6 RID: 53414 RVA: 0x003E0374 File Offset: 0x003DE574
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

	// Token: 0x0600D0A7 RID: 53415 RVA: 0x003E0484 File Offset: 0x003DE684
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

	// Token: 0x0600D0A8 RID: 53416 RVA: 0x003E04C4 File Offset: 0x003DE6C4
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

	// Token: 0x0600D0A9 RID: 53417 RVA: 0x003E0570 File Offset: 0x003DE770
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

	// Token: 0x0600D0AA RID: 53418 RVA: 0x003E0670 File Offset: 0x003DE870
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

	// Token: 0x0600D0AB RID: 53419 RVA: 0x003E06B4 File Offset: 0x003DE8B4
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

	// Token: 0x0600D0AC RID: 53420 RVA: 0x003E06F4 File Offset: 0x003DE8F4
	private static void PhantomItemResponse(IMessage msg, Net.CallbackStatus _)
	{
		PhantomItemResponse phantomItemResponse = (PhantomItemResponse)msg;
		CalabashModel.Instance.DirectionalFusionTime = phantomItemResponse.DirectRefineWeekTimes;
		PhantomBattleModel.Instance.SetMaxCost(phantomItemResponse.TotalCost);
		RepeatedField<int> repeatedField = (phantomItemResponse != null) ? phantomItemResponse.UnlockSkins : null;
		if (repeatedField != null)
		{
			int[] array = new int[repeatedField.Count];
			repeatedField.CopyTo(array, 0);
			PhantomBattleModel.Instance.SetUnlockSkinList(array);
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

	// Token: 0x0600D0AD RID: 53421 RVA: 0x003E085C File Offset: 0x003DEA5C
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

	// Token: 0x0600D0AE RID: 53422 RVA: 0x003E0A6C File Offset: 0x003DEC6C
	private static void PhantomItemRemoveNotify(IMessage msg, Net.CallbackStatus status)
	{
		RepeatedField<int> phantomItemIncrIdList = ((PhantomItemRemoveNotify)msg).PhantomItemIncrIdList;
		if (phantomItemIncrIdList == null || phantomItemIncrIdList.Count == 0)
		{
			return;
		}
		InventoryModel.Instance.RemovePhantomItemDataAndNotify(phantomItemIncrIdList, "ItemRemoveNotify");
	}

	// Token: 0x0600D0AF RID: 53423 RVA: 0x003E0AA4 File Offset: 0x003DECA4
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

	// Token: 0x0600D0B0 RID: 53424 RVA: 0x003E0C30 File Offset: 0x003DEE30
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

	// Token: 0x0600D0B1 RID: 53425 RVA: 0x003E0C74 File Offset: 0x003DEE74
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

	// Token: 0x0600D0B2 RID: 53426 RVA: 0x003E0CE4 File Offset: 0x003DEEE4
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

	// Token: 0x0600D0B3 RID: 53427 RVA: 0x003E0D18 File Offset: 0x003DEF18
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

	// Token: 0x0600D0B4 RID: 53428 RVA: 0x003E0D88 File Offset: 0x003DEF88
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

	// Token: 0x0600D0B5 RID: 53429 RVA: 0x003E0DD4 File Offset: 0x003DEFD4
	private static void InventoryTabOpenNotify(IMessage msg, Net.CallbackStatus status)
	{
		ItemPkgOpenNotify itemPkgOpenNotify = (ItemPkgOpenNotify)msg;
		InventoryModel.Instance.SetInventoryTabOpenIdList(new List<int>(itemPkgOpenNotify.OpenPkg));
	}

	// Token: 0x0600D0B6 RID: 53430 RVA: 0x003E0DFD File Offset: 0x003DEFFD
	private static void InventoryFullNotify(IMessage msg, Net.CallbackStatus status)
	{
		ItemPkgFullNotify itemPkgFullNotify = (ItemPkgFullNotify)msg;
	}

	// Token: 0x0600D0B7 RID: 53431 RVA: 0x003E0E06 File Offset: 0x003DF006
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

	// Token: 0x0600D0B8 RID: 53432 RVA: 0x003E0E48 File Offset: 0x003DF048
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

	// Token: 0x0600D0B9 RID: 53433 RVA: 0x003E0EC8 File Offset: 0x003DF0C8
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(itemDecomposePreviewResponse.ErrorCode, 16064, null, true, true);
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

	// Token: 0x0600D0BA RID: 53434 RVA: 0x003E0F18 File Offset: 0x003DF118
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(itemDecomposeResponse.ErrCode, 24230, null, true, true);
				return;
			}
		}, 0);
	}

	// Token: 0x0600D0BB RID: 53435 RVA: 0x003E0F68 File Offset: 0x003DF168
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

	// Token: 0x0600D0BC RID: 53436 RVA: 0x003E0FA8 File Offset: 0x003DF1A8
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

	// Token: 0x0600D0BD RID: 53437 RVA: 0x003E0FD8 File Offset: 0x003DF1D8
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

	// Token: 0x0600D0BE RID: 53438 RVA: 0x003E1208 File Offset: 0x003DF408
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

	// Token: 0x0600D0BF RID: 53439 RVA: 0x003E1398 File Offset: 0x003DF598
	public bool TryUseItem(int itemId, int num = 1)
	{
		ItemUseLogicBase itemUseLogicBase = ItemUseLogicModel.Instance.Resolve(itemId);
		if (itemUseLogicBase != null && itemUseLogicBase.CheckUseCondition(itemId, num))
		{
			itemUseLogicBase.OnUse(itemId, num);
			return true;
		}
		return ItemUseLogic.TryUseParameterItem(itemId, num);
	}

	// Token: 0x0600D0C0 RID: 53440 RVA: 0x003E13CF File Offset: 0x003DF5CF
	public bool TryUseGiftItemWithSelectedItem(int giftItemId, int itemId, int num = 1)
	{
		return ItemUseLogic.TryUseGiftItemWithSelectedItem(giftItemId, itemId, num);
	}

	// Token: 0x0600D0C1 RID: 53441 RVA: 0x003E13DC File Offset: 0x003DF5DC
	[NullableContext(0)]
	public UniTask<bool> PhantomFuncValueBatchRequest([Nullable(1)] int[] uniqueIdList, PhantomBatchOper operate)
	{
		InventoryController.<PhantomFuncValueBatchRequest>d__55 <PhantomFuncValueBatchRequest>d__;
		<PhantomFuncValueBatchRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<PhantomFuncValueBatchRequest>d__.uniqueIdList = uniqueIdList;
		<PhantomFuncValueBatchRequest>d__.operate = operate;
		<PhantomFuncValueBatchRequest>d__.<>1__state = -1;
		<PhantomFuncValueBatchRequest>d__.<>t__builder.Start<InventoryController.<PhantomFuncValueBatchRequest>d__55>(ref <PhantomFuncValueBatchRequest>d__);
		return <PhantomFuncValueBatchRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600D0C2 RID: 53442 RVA: 0x003E1428 File Offset: 0x003DF628
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

	// Token: 0x0600D0C3 RID: 53443 RVA: 0x003E1468 File Offset: 0x003DF668
	public UniTask PhantomManageConfigRequestAsync()
	{
		InventoryController.<PhantomManageConfigRequestAsync>d__57 <PhantomManageConfigRequestAsync>d__;
		<PhantomManageConfigRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PhantomManageConfigRequestAsync>d__.<>1__state = -1;
		<PhantomManageConfigRequestAsync>d__.<>t__builder.Start<InventoryController.<PhantomManageConfigRequestAsync>d__57>(ref <PhantomManageConfigRequestAsync>d__);
		return <PhantomManageConfigRequestAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D0C4 RID: 53444 RVA: 0x003E14A4 File Offset: 0x003DF6A4
	[NullableContext(0)]
	public UniTask<ErrorCode> PhantomManageConfigUpdateRequest(PhantomSettingType type, [Nullable(2)] OnePhantomSetting setting)
	{
		InventoryController.<PhantomManageConfigUpdateRequest>d__58 <PhantomManageConfigUpdateRequest>d__;
		<PhantomManageConfigUpdateRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<ErrorCode>.Create();
		<PhantomManageConfigUpdateRequest>d__.type = type;
		<PhantomManageConfigUpdateRequest>d__.setting = setting;
		<PhantomManageConfigUpdateRequest>d__.<>1__state = -1;
		<PhantomManageConfigUpdateRequest>d__.<>t__builder.Start<InventoryController.<PhantomManageConfigUpdateRequest>d__58>(ref <PhantomManageConfigUpdateRequest>d__);
		return <PhantomManageConfigUpdateRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600D0C5 RID: 53445 RVA: 0x003E14F0 File Offset: 0x003DF6F0
	[NullableContext(0)]
	public UniTask<bool> PhantomSettingBatchUpdateRequestAsync([Nullable(1)] PhantomSettingInfo[] settings)
	{
		InventoryController.<PhantomSettingBatchUpdateRequestAsync>d__59 <PhantomSettingBatchUpdateRequestAsync>d__;
		<PhantomSettingBatchUpdateRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<PhantomSettingBatchUpdateRequestAsync>d__.settings = settings;
		<PhantomSettingBatchUpdateRequestAsync>d__.<>1__state = -1;
		<PhantomSettingBatchUpdateRequestAsync>d__.<>t__builder.Start<InventoryController.<PhantomSettingBatchUpdateRequestAsync>d__59>(ref <PhantomSettingBatchUpdateRequestAsync>d__);
		return <PhantomSettingBatchUpdateRequestAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D0C6 RID: 53446 RVA: 0x003E1534 File Offset: 0x003DF734
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

	// Token: 0x0600D0C7 RID: 53447 RVA: 0x003E157C File Offset: 0x003DF77C
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

	// Token: 0x0600D0C8 RID: 53448 RVA: 0x003E15D8 File Offset: 0x003DF7D8
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

	// Token: 0x0600D0C9 RID: 53449 RVA: 0x003E1638 File Offset: 0x003DF838
	private int GetTotalPhantomCount()
	{
		return InventoryModel.Instance.GetPhantomItemDataList().Count;
	}

	// Token: 0x0600D0CA RID: 53450 RVA: 0x003E164C File Offset: 0x003DF84C
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
		if (totalPhantomCount >= InventoryConfig.Instance.GetPhantomDiscardThreshold())
		{
			this.ShowPhantomFusionOrDiscardTip(totalPhantomCount, deprecatedPhantomCount);
			return true;
		}
		return false;
	}

	// Token: 0x0600D0CB RID: 53451 RVA: 0x003E16AC File Offset: 0x003DF8AC
	private void ShowPhantomFusionOrDiscardTip(int totalCount, int deprecatedCount)
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhantomFusionOrDiscardConfirm);
		confirmBoxDataNew.SetTextArgs(new string[]
		{
			totalCount.ToString(),
			deprecatedCount.ToString()
		});
		confirmBoxDataNew.IsEscViewTriggerCallBack = false;
		confirmBoxDataNew.FunctionMap.Add(1, new Action(this.OnClickPhantomFusionTip));
		confirmBoxDataNew.FunctionMap.Add(2, new Action(this.OnClickPhantomDiscardTip));
		confirmBoxDataNew.HasToggle = true;
		confirmBoxDataNew.ToggleTextKey = "ConfirmBox_363_Desc";
		confirmBoxDataNew.SetToggleFunction(delegate(bool isSelectOn)
		{
			this.IsPhantomFullViewLoginNotShow = isSelectOn;
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600D0CC RID: 53452 RVA: 0x003E174B File Offset: 0x003DF94B
	private void OnClickPhantomFusionTip()
	{
		CalabashController.Instance.JumpToCalabashRootView(EUiTabViewName.VisionRecoveryTabView, null);
	}

	// Token: 0x0600D0CD RID: 53453 RVA: 0x003E175D File Offset: 0x003DF95D
	private void OnClickPhantomDiscardTip()
	{
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
	}

	// Token: 0x0600D0CE RID: 53454 RVA: 0x003E1790 File Offset: 0x003DF990
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

	// Token: 0x17001381 RID: 4993
	// (get) Token: 0x0600D0CF RID: 53455 RVA: 0x003E17DB File Offset: 0x003DF9DB
	[Nullable(1)]
	public static InventoryController Instance
	{
		[NullableContext(1)]
		get
		{
			return InventoryController._Instance;
		}
	}

	// Token: 0x0600D0D0 RID: 53456 RVA: 0x003E17E2 File Offset: 0x003DF9E2
	[NullableContext(1)]
	public static InventoryController GetOrCreateInstance()
	{
		if (InventoryController._Instance == null)
		{
			InventoryController.CreateInstance();
		}
		return InventoryController._Instance;
	}

	// Token: 0x0600D0D1 RID: 53457 RVA: 0x003E17F6 File Offset: 0x003DF9F6
	public static bool CreateInstance()
	{
		if (InventoryController._Instance != null)
		{
			return true;
		}
		InventoryController._Instance = new InventoryController();
		return true;
	}

	// Token: 0x0600D0D2 RID: 53458 RVA: 0x003E180C File Offset: 0x003DFA0C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D0D3 RID: 53459 RVA: 0x003E180E File Offset: 0x003DFA0E
	public static void ResetStaticDefaultValue()
	{
		InventoryController._Instance = null;
	}

	// Token: 0x0600D0D4 RID: 53460 RVA: 0x003E1816 File Offset: 0x003DFA16
	static InventoryController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InventoryController.CreateStaticDefaultValue), new Action(InventoryController.ResetStaticDefaultValue));
	}

	// Token: 0x04007644 RID: 30276
	private const int VISION_CATCH_REASON = 19000;

	// Token: 0x04007645 RID: 30277
	private const int GACHA_REASON = 14000;

	// Token: 0x04007646 RID: 30278
	private bool IsPhantomFullViewShow = true;

	// Token: 0x04007647 RID: 30279
	private bool IsPhantomFullViewLoginNotShow;

	// Token: 0x04007648 RID: 30280
	private bool IsPhantomDiscardFuseLoginNotShow;

	// Token: 0x04007649 RID: 30281
	private bool InvalidItemRemoveRequestLock;

	// Token: 0x0400764A RID: 30282
	private static InventoryController _Instance;

	// Token: 0x0200772E RID: 30510
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04026B69 RID: 158569
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <0>__NormalItemUpdateNotify;

		// Token: 0x04026B6A RID: 158570
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <1>__NormalItemRemoveNotify;

		// Token: 0x04026B6B RID: 158571
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <2>__NormalItemAddNotify;

		// Token: 0x04026B6C RID: 158572
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <3>__ValidTimeItemUpdateNotify;

		// Token: 0x04026B6D RID: 158573
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <4>__ValidTimeItemRemoveNotify;

		// Token: 0x04026B6E RID: 158574
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <5>__ValidTimeItemAddNotify;

		// Token: 0x04026B6F RID: 158575
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <6>__WeaponItemAddNotify;

		// Token: 0x04026B70 RID: 158576
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <7>__WeaponItemRemoveNotify;

		// Token: 0x04026B71 RID: 158577
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <8>__PhantomItemAddNotify;

		// Token: 0x04026B72 RID: 158578
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <9>__PhantomItemRemoveNotify;

		// Token: 0x04026B73 RID: 158579
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <10>__ItemFuncValueUpdateNotify;

		// Token: 0x04026B74 RID: 158580
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <11>__InventoryTabOpenNotify;

		// Token: 0x04026B75 RID: 158581
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <12>__InventoryFullNotify;

		// Token: 0x04026B76 RID: 158582
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <13>__InventoryBanItemUseNotify;

		// Token: 0x04026B77 RID: 158583
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Func<EUiViewName, object, bool> <14>__CanOpenView;

		// Token: 0x04026B78 RID: 158584
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <15>__NormalItemResponse;

		// Token: 0x04026B79 RID: 158585
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <16>__ValidTimeItemResponse;

		// Token: 0x04026B7A RID: 158586
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <17>__WeaponItemResponse;

		// Token: 0x04026B7B RID: 158587
		[Nullable(new byte[]
		{
			0,
			2,
			2
		})]
		public static Action<IMessage, Net.CallbackStatus> <18>__PhantomItemResponse;
	}
}
