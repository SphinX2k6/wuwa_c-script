using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.Protocol.Summon;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using UnrealEngine;

// Token: 0x020018EA RID: 6378
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PhantomBattleController : UiControllerBase
{
	// Token: 0x0600FC36 RID: 64566 RVA: 0x0049B175 File Offset: 0x00499375
	public static void InitData()
	{
	}

	// Token: 0x0600FC37 RID: 64567 RVA: 0x0049B178 File Offset: 0x00499378
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<Aki.Protocol.PhantomItem>(EEventName.OnAddPhantomItem, new Action<Aki.Protocol.PhantomItem>(this.OnAddPhantomItem));
		EventSystem.Instance.Add<Aki.Protocol.PhantomItem>(EEventName.OnResponsePhantomItem, new Action<Aki.Protocol.PhantomItem>(this.OnResponsePhantomItem));
		EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.OnRemovePhantomItem, new Action<IReadOnlyList<int>>(this.OnRemovePhantomItem));
		EventSystem.Instance.Add<PhantomItemResponse>(EEventName.OnEquipPhantomItem, new Action<PhantomItemResponse>(this.OnEquipPhantomItem));
		EventSystem.Instance.Add(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
	}

	// Token: 0x0600FC38 RID: 64568 RVA: 0x0049B214 File Offset: 0x00499414
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnAddPhantomItem, new Action<Aki.Protocol.PhantomItem>(this.OnAddPhantomItem));
		EventSystem.Instance.Remove(EEventName.OnResponsePhantomItem, new Action<Aki.Protocol.PhantomItem>(this.OnResponsePhantomItem));
		EventSystem.Instance.Remove(EEventName.OnRemovePhantomItem, new Action<IReadOnlyList<int>>(this.OnRemovePhantomItem));
		EventSystem.Instance.Remove(EEventName.OnEquipPhantomItem, new Action<PhantomItemResponse>(this.OnEquipPhantomItem));
		EventSystem.Instance.Remove(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
	}

	// Token: 0x0600FC39 RID: 64569 RVA: 0x0049B2AD File Offset: 0x004994AD
	private void OnResponsePhantomItem(Aki.Protocol.PhantomItem phantomItem)
	{
		PhantomBattleModel.Instance.NewPhantomBattleData(phantomItem);
	}

	// Token: 0x0600FC3A RID: 64570 RVA: 0x0049B2BB File Offset: 0x004994BB
	private void OnAddPhantomItem(Aki.Protocol.PhantomItem phantomItem)
	{
		PhantomBattleModel.Instance.NewPhantomBattleData(phantomItem);
	}

	// Token: 0x0600FC3B RID: 64571 RVA: 0x0049B2CC File Offset: 0x004994CC
	private void OnRemovePhantomItem(IReadOnlyList<int> uniqueIdList)
	{
		foreach (int uniqueId in uniqueIdList)
		{
			PhantomBattleModel.Instance.RemovePhantomBattleData(uniqueId);
		}
	}

	// Token: 0x0600FC3C RID: 64572 RVA: 0x0049B318 File Offset: 0x00499518
	private void OnEquipPhantomItem(PhantomItemResponse equipInfoList)
	{
		foreach (RolePhantomEquipInfo data in equipInfoList.EquipInfo)
		{
			PhantomBattleModel.Instance.UpdateRoleEquipmentData(data);
		}
		foreach (RolePhantomPropInfo data2 in equipInfoList.PropInfo)
		{
			PhantomBattleModel.Instance.UpdateRoleEquipmentPropData(data2);
		}
		EventSystem.Instance.Emit(EEventName.PhantomEquip);
	}

	// Token: 0x0600FC3D RID: 64573 RVA: 0x0049B3BC File Offset: 0x004995BC
	[NullableContext(2)]
	public PhantomBattleData GetPhantomItemDataByUniqueId(int uniqueId)
	{
		return PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId);
	}

	// Token: 0x0600FC3E RID: 64574 RVA: 0x0049B3C9 File Offset: 0x004995C9
	public void ChangeRoleEvent(int roleId)
	{
		PhantomBattleModel.Instance.UpdateFetterList(roleId);
	}

	// Token: 0x0600FC3F RID: 64575 RVA: 0x0049B3D8 File Offset: 0x004995D8
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.PhantomEquipInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPhantomEquipInfoNotify));
		Net.Instance.Register(ENotifyMessageId.PhantomItemUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPhantomItemUpdate));
		Net.Instance.Register(ENotifyMessageId.RolePhantomPropUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRolePhantomPropUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.PhantomUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPhantomUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.PhantomSkinAddNotify, new Action<IMessage, Net.CallbackStatus>(this.PhantomSkinAddNotify));
		Net.Instance.Register(ENotifyMessageId.PhantomUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.PhantomUnlockNotify));
	}

	// Token: 0x0600FC40 RID: 64576 RVA: 0x0049B490 File Offset: 0x00499690
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.PhantomEquipInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PhantomItemUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RolePhantomPropUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PhantomUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PhantomSkinAddNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PhantomUnlockNotify);
	}

	// Token: 0x0600FC41 RID: 64577 RVA: 0x0049B500 File Offset: 0x00499700
	public void SendPhantomLevelUpRequest(int incId, List<PhantomConsumeItem> consumeItem, int identifyCount)
	{
		PhantomLevelUpRequest phantomLevelUpRequest = PhantomLevelUpRequest.Create();
		phantomLevelUpRequest.IncId = incId;
		phantomLevelUpRequest.ConsumeList.AddRange(consumeItem);
		phantomLevelUpRequest.IdentifyCount = identifyCount;
		LevelUpPastVisionData data = PhantomBattleModel.Instance.CreatePhantomLevelCacheData(incId);
		Net.Instance.Call(ERequestMessageId.PhantomLevelUpRequest, phantomLevelUpRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PhantomLevelUpResponse phantomLevelUpResponse = (PhantomLevelUpResponse)msg;
			PhantomBattleModel instance = PhantomBattleModel.Instance;
			if (phantomLevelUpResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				if (phantomLevelUpResponse.ErrorCode == Aki.Protocol.ErrorCode.ErrPhantomPkgFull)
				{
					ErrorCodeController.Instance.OpenErrorCodeScrollingTipsView(phantomLevelUpResponse.ErrorCode, Array.Empty<string>());
					return;
				}
				ErrorCodeController.Instance.OpenErrorCodeTipView(phantomLevelUpResponse.ErrorCode, 29647, null, true, true);
				return;
			}
			else
			{
				if (phantomLevelUpResponse.StackSplitInfo != null)
				{
					InventoryController.Instance.ApplyPhantomStackSplitAndMerge(new PhantomStackSplitInfo[]
					{
						phantomLevelUpResponse.StackSplitInfo
					}, null, "LevelUp");
				}
				instance.ResetLevelUpItemData();
				PhantomBattleData phantomItemDataByUniqueId = this.GetPhantomItemDataByUniqueId(phantomLevelUpResponse.UpdateInfo.IncrId);
				if (phantomItemDataByUniqueId == null)
				{
					Log.Instance.Error(ELogModule.Phantom, ELogAuthor.YZY, "幻象升级返回，获取phantomBattleData异常", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				phantomItemDataByUniqueId.SetData(phantomLevelUpResponse.UpdateInfo);
				instance.PhantomLevelUpReceiveItem(new Dictionary<int, int>(phantomLevelUpResponse.ItemMap));
				instance.CachePhantomLevelUpData(data);
				EventSystem.Instance.Emit(EEventName.PhantomLevelUp);
				EventSystem.Instance.Emit<int>(EEventName.PhantomLevelUpWithId, incId);
				return;
			}
		}, 0);
	}

	// Token: 0x0600FC42 RID: 64578 RVA: 0x0049B57C File Offset: 0x0049977C
	public void TryShowReceiveItem()
	{
		TItem[] tempSaveItemList = PhantomBattleModel.Instance.GetTempSaveItemList();
		if (tempSaveItemList.Length != 0)
		{
			List<RewardItemData> list = new List<RewardItemData>();
			foreach (TItem titem in tempSaveItemList)
			{
				InventoryDefine.IGetItemData itemData = titem.ItemData;
				int count = titem.Count;
				RewardItemData item = new RewardItemData(itemData.ItemId, count, new int?(itemData.IncId), EDropItemType.Normal);
				list.Add(item);
			}
			ItemRewardController.Instance.OpenCommonRewardView(1008, list, null);
			PhantomBattleModel.Instance.ClearTempSaveItemList();
		}
	}

	// Token: 0x0600FC43 RID: 64579 RVA: 0x0049B604 File Offset: 0x00499804
	public void SendPhantomPutOnRequest(int incId, int roleId, int pos, int sourcePos = -1, bool fromDrag = false)
	{
		if (SceneTeamModel.Instance.GetCurrentEntity.Entity.GetComponent<BaseTagComponent>().HasTag(GameplayTagDefine.EGameplayTagId["幻象.Common.技能中"]))
		{
			GenericPromptController.Instance.ShowPromptByCode("VisionSkilling", Array.Empty<object>());
			EventSystem.Instance.Emit(EEventName.PhantomEquipError);
			return;
		}
		if (PhantomUtil.IsInVisionSkill())
		{
			GenericPromptController.Instance.ShowPromptByCode("VisionSkilling", Array.Empty<object>());
			EventSystem.Instance.Emit(EEventName.PhantomEquipError);
			return;
		}
		int getConfigId = SceneTeamModel.Instance.GetCurrentTeamItem.GetConfigId;
		int? phantomEquipOnRoleId = PhantomBattleModel.Instance.GetPhantomEquipOnRoleId(incId);
		bool flag = PhantomBattleModel.Instance.CheckPhantomIsMain(incId);
		int roleIndexPhantomId = PhantomBattleModel.Instance.GetRoleIndexPhantomId(roleId, pos);
		int? phantomEquipOnRoleId2 = PhantomBattleModel.Instance.GetPhantomEquipOnRoleId(roleIndexPhantomId);
		bool flag2 = PhantomBattleModel.Instance.CheckPhantomIsMain(roleIndexPhantomId);
		int num = getConfigId;
		int? num2 = phantomEquipOnRoleId;
		bool flag3;
		if (num == num2.GetValueOrDefault() & num2 != null)
		{
			num2 = phantomEquipOnRoleId;
			int num3 = 0;
			flag3 = (num2.GetValueOrDefault() > num3 & num2 != null);
		}
		else
		{
			flag3 = false;
		}
		if (!flag3 || !flag)
		{
			int num4 = getConfigId;
			num2 = phantomEquipOnRoleId2;
			bool flag4;
			if (num4 == num2.GetValueOrDefault() & num2 != null)
			{
				num2 = phantomEquipOnRoleId2;
				int num3 = 0;
				flag4 = (num2.GetValueOrDefault() > num3 & num2 != null);
			}
			else
			{
				flag4 = false;
			}
			if (!flag4 || !flag2)
			{
				goto IL_1C7;
			}
		}
		bool flag5 = false;
		int id = SceneTeamModel.Instance.GetCurrentEntity.Id;
		EntityHandle summonedEntity = PhantomUtil.GetSummonedEntity(EntitySystem.Instance.Get(id), ESummonType.ConcomitantVision, 1);
		if (summonedEntity != null && summonedEntity.Entity.Active)
		{
			flag5 = true;
		}
		if (flag5)
		{
			GenericPromptController.Instance.ShowPromptByCode("VisionSkilling", Array.Empty<object>());
			EventSystem.Instance.Emit(EEventName.PhantomEquipError);
			return;
		}
		IL_1C7:
		if (RoleController.Instance.CheckCharacterInBattleTagAndShowTips(true))
		{
			EventSystem.Instance.Emit(EEventName.PhantomEquipError);
			return;
		}
		PhantomPutOnRequest phantomPutOnRequest = PhantomPutOnRequest.Create();
		phantomPutOnRequest.IncId = incId;
		phantomPutOnRequest.RoleId = roleId;
		phantomPutOnRequest.Pos = pos;
		Net.Instance.Call(ERequestMessageId.PhantomPutOnRequest, phantomPutOnRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PhantomPutOnResponse phantomPutOnResponse = (PhantomPutOnResponse)msg;
			if (phantomPutOnResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(phantomPutOnResponse.ErrorCode, 21144, null, true, true);
				EventSystem.Instance.Emit(EEventName.PhantomEquipError);
				return;
			}
			RepeatedField<RolePhantomEquipInfo> equipInfoList = phantomPutOnResponse.EquipInfoList;
			if (equipInfoList == null)
			{
				Log.Instance.Error(ELogModule.Phantom, ELogAuthor.YZY, "角色幻象装备数据异常", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			InventoryController.Instance.ApplyPhantomStackSplitAndMerge(phantomPutOnResponse.StackSplitInfos, phantomPutOnResponse.StackMergeInfos, "Equip");
			foreach (RolePhantomEquipInfo rolePhantomEquipInfo in equipInfoList)
			{
				PhantomBattleModel.Instance.UpdateRoleEquipmentData(rolePhantomEquipInfo);
				PhantomBattleModel.Instance.UpdateFetterList(rolePhantomEquipInfo.RoleId);
			}
			EventSystem.Instance.Emit(EEventName.PhantomEquip);
			EventSystem.Instance.Emit<int, int, bool>(EEventName.PhantomEquipWithSourceAndTargetPos, sourcePos, pos, fromDrag);
		}, 0);
	}

	// Token: 0x0600FC44 RID: 64580 RVA: 0x0049B838 File Offset: 0x00499A38
	public void SendPhantomAutoPutRequest(int roleId, IEnumerable<int> uniqueIdList, [Nullable(2)] Action successCallBack = null)
	{
		if (SceneTeamModel.Instance.GetCurrentEntity.Entity.GetComponent<BaseTagComponent>().HasTag(GameplayTagDefine.EGameplayTagId["幻象.Common.技能中"]))
		{
			GenericPromptController.Instance.ShowPromptByCode("VisionSkilling", Array.Empty<object>());
			return;
		}
		if (PhantomUtil.IsInVisionSkill())
		{
			GenericPromptController.Instance.ShowPromptByCode("VisionSkilling", Array.Empty<object>());
			return;
		}
		bool flag = false;
		EntityHandle summonedEntity = PhantomUtil.GetSummonedEntity(EntitySystem.Instance.Get(SceneTeamModel.Instance.GetCurrentEntity.Id), ESummonType.ConcomitantVision, 1);
		if (summonedEntity != null && summonedEntity.Entity.Active)
		{
			flag = true;
		}
		if (flag)
		{
			GenericPromptController.Instance.ShowPromptByCode("VisionSkilling", Array.Empty<object>());
			return;
		}
		if (RoleController.Instance.CheckCharacterInBattleTagAndShowTips(true))
		{
			return;
		}
		PhantomAutoPutRequest phantomAutoPutRequest = PhantomAutoPutRequest.Create();
		phantomAutoPutRequest.RoleId = roleId;
		phantomAutoPutRequest.PhantomItemIncrId.AddRange(uniqueIdList);
		Net.Instance.Call(ERequestMessageId.PhantomAutoPutRequest, phantomAutoPutRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PhantomAutoPutResponse phantomAutoPutResponse = (PhantomAutoPutResponse)msg;
			if (phantomAutoPutResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(phantomAutoPutResponse.ErrorCode, 21508, null, true, true);
				return;
			}
			RepeatedField<RolePhantomEquipInfo> equipInfoList = phantomAutoPutResponse.EquipInfoList;
			if (equipInfoList == null)
			{
				Log.Instance.Error(ELogModule.Phantom, ELogAuthor.YZY, "角色幻象装备数据异常!!!!", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			InventoryController.Instance.ApplyPhantomStackSplitAndMerge(phantomAutoPutResponse.StackSplitInfos, phantomAutoPutResponse.StackMergeInfos, "EquipAll");
			foreach (RolePhantomEquipInfo rolePhantomEquipInfo in equipInfoList)
			{
				PhantomBattleModel.Instance.UpdateRoleEquipmentData(rolePhantomEquipInfo);
				PhantomBattleModel.Instance.UpdateFetterList(rolePhantomEquipInfo.RoleId);
			}
			Action successCallBack2 = successCallBack;
			if (successCallBack2 != null)
			{
				successCallBack2();
			}
			EventSystem.Instance.Emit(EEventName.PhantomEquip);
			EventSystem.Instance.Emit<int, int, bool>(EEventName.PhantomEquipWithSourceAndTargetPos, 0, 0, false);
		}, 0);
	}

	// Token: 0x0600FC45 RID: 64581 RVA: 0x0049B940 File Offset: 0x00499B40
	public void ApplyRecommendEquip(int roleId, List<int> uniqueIdList, Action onSuccess)
	{
		if (!PhantomBattleModel.Instance.GetRoleIfEquipVision(roleId))
		{
			this.SendPhantomAutoPutRequest(roleId, uniqueIdList, onSuccess);
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhantomSupplementTips);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			this.SendPhantomAutoPutRequest(roleId, uniqueIdList, onSuccess);
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600FC46 RID: 64582 RVA: 0x0049B9C8 File Offset: 0x00499BC8
	[NullableContext(2)]
	private void OnRolePhantomPropUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		foreach (RolePhantomPropInfo rolePhantomPropInfo in ((RolePhantomPropUpdateNotify)msg).PropInfo)
		{
			PhantomBattleModel.Instance.GetBattleDataById(rolePhantomPropInfo.RoleId).Phrase(rolePhantomPropInfo);
		}
		EventSystem.Instance.Emit(EEventName.OnRolePropUpdate);
	}

	// Token: 0x0600FC47 RID: 64583 RVA: 0x0049BA3C File Offset: 0x00499C3C
	[NullableContext(2)]
	private void OnPhantomUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		PhantomUpdateNotify phantomUpdateNotify = (PhantomUpdateNotify)msg;
		PhantomBattleModel.Instance.SetMaxCost(phantomUpdateNotify.TotalCost);
	}

	// Token: 0x0600FC48 RID: 64584 RVA: 0x0049BA60 File Offset: 0x00499C60
	[NullableContext(2)]
	private void PhantomUnlockNotify(IMessage msg, Net.CallbackStatus status)
	{
		PhantomUnlockNotify phantomUnlockNotify = (PhantomUnlockNotify)msg;
		if (phantomUnlockNotify.UnlockQualityItemList.Count > 0)
		{
			PhantomBattleModel.Instance.CacheNewQualityData(phantomUnlockNotify);
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.DoShowUnlockQualityView();
			}, (float)CalabashConfig.Instance.DelayTime, null, null, true, 1f);
			return;
		}
		foreach (int num in phantomUnlockNotify.UnlockMonsterItemList)
		{
			int qualityId = PhantomBattleConfig.Instance.GetPhantomItemById(num).Value.QualityId;
			CalabashModel.Instance.AddCalabashUnlockTipsList(num, qualityId);
		}
		this.DoShowNewItemView();
	}

	// Token: 0x0600FC49 RID: 64585 RVA: 0x0049BB24 File Offset: 0x00499D24
	[NullableContext(2)]
	private void PhantomSkinAddNotify(IMessage msg, Net.CallbackStatus status)
	{
		RepeatedField<int> skinIds = ((PhantomSkinAddNotify)msg).SkinIds;
		PhantomBattleModel.Instance.ConcatUnlockSkinList(skinIds);
		foreach (int num in skinIds)
		{
			NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.VisionSkin, num);
			NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.VisionSkin);
			PhantomBattleModel.Instance.CacheNewSkinData(num);
		}
		TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.DoShowUnlockQualityView();
		}, (float)CalabashConfig.Instance.DelayTime, null, null, true, 1f);
	}

	// Token: 0x0600FC4A RID: 64586 RVA: 0x0049BBCC File Offset: 0x00499DCC
	[NullableContext(2)]
	private void OnPhantomEquipInfoNotify(IMessage msg, Net.CallbackStatus status)
	{
		RepeatedField<RolePhantomEquipInfo> equipInfo = ((PhantomEquipInfoNotify)msg).EquipInfo;
		if (equipInfo == null)
		{
			Log.Instance.Error(ELogModule.Phantom, ELogAuthor.YZY, "没有角色装备过幻象!!!!", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		foreach (RolePhantomEquipInfo data in equipInfo)
		{
			PhantomBattleModel.Instance.UpdateRoleEquipmentData(data);
		}
		EventSystem.Instance.Emit(EEventName.PhantomEquip);
	}

	// Token: 0x0600FC4B RID: 64587 RVA: 0x0049BC54 File Offset: 0x00499E54
	[NullableContext(2)]
	private void OnPhantomItemUpdate(IMessage msg, Net.CallbackStatus status)
	{
		PhantomItemUpdateNotify phantomItemUpdateNotify = (PhantomItemUpdateNotify)msg;
		List<string> list = new List<string>();
		foreach (Aki.Protocol.PhantomItem phantomItem in phantomItemUpdateNotify.UpdateInfo)
		{
			List<string> list2 = list;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(phantomItem.IncrId);
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted<int>(phantomItem.StackCount);
			list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		foreach (Aki.Protocol.PhantomItem phantomItem2 in phantomItemUpdateNotify.UpdateInfo)
		{
			PhantomBattleData phantomItemDataByUniqueId = this.GetPhantomItemDataByUniqueId(phantomItem2.IncrId);
			if (phantomItemDataByUniqueId != null)
			{
				phantomItemDataByUniqueId.UpdateData(phantomItem2);
			}
			InventoryModel.Instance.UpdatePhantomItemData(phantomItem2, "ItemUpdateNotify");
		}
		EventSystem.Instance.Emit(EEventName.OnPhantomItemUpdate);
	}

	// Token: 0x0600FC4C RID: 64588 RVA: 0x0049BD54 File Offset: 0x00499F54
	public UniTask RequestPhantomIdentify(int uniqueId, int count)
	{
		PhantomBattleController.<RequestPhantomIdentify>d__22 <RequestPhantomIdentify>d__;
		<RequestPhantomIdentify>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestPhantomIdentify>d__.<>4__this = this;
		<RequestPhantomIdentify>d__.uniqueId = uniqueId;
		<RequestPhantomIdentify>d__.count = count;
		<RequestPhantomIdentify>d__.<>1__state = -1;
		<RequestPhantomIdentify>d__.<>t__builder.Start<PhantomBattleController.<RequestPhantomIdentify>d__22>(ref <RequestPhantomIdentify>d__);
		return <RequestPhantomIdentify>d__.<>t__builder.Task;
	}

	// Token: 0x0600FC4D RID: 64589 RVA: 0x0049BDA8 File Offset: 0x00499FA8
	public void PhantomSkinChangeRequest(int uniqueId, int skinId, bool changeDefault)
	{
		if (SceneTeamModel.Instance.GetCurrentEntity.Entity.GetComponent<BaseTagComponent>().HasTag(GameplayTagDefine.EGameplayTagId["幻象.Common.技能中"]))
		{
			GenericPromptController.Instance.ShowPromptByCode("VisionSkilling", Array.Empty<object>());
			EventSystem.Instance.Emit(EEventName.PhantomEquipError);
			return;
		}
		if (PhantomUtil.IsInVisionSkill())
		{
			GenericPromptController.Instance.ShowPromptByCode("VisionSkilling", Array.Empty<object>());
			EventSystem.Instance.Emit(EEventName.PhantomEquipError);
			return;
		}
		bool flag = false;
		int id = SceneTeamModel.Instance.GetCurrentEntity.Id;
		EntityHandle summonedEntity = PhantomUtil.GetSummonedEntity(EntitySystem.Instance.Get(id), ESummonType.ConcomitantVision, 1);
		if (summonedEntity != null && summonedEntity.Entity.Active)
		{
			flag = true;
		}
		if (flag)
		{
			GenericPromptController.Instance.ShowPromptByCode("VisionSkilling", Array.Empty<object>());
			return;
		}
		if (RoleController.Instance.CheckCharacterInBattleTagAndShowTips(false))
		{
			return;
		}
		PhantomSkinChangeRequest phantomSkinChangeRequest = Aki.Protocol.PhantomSkinChangeRequest.Create();
		phantomSkinChangeRequest.IncrId = uniqueId;
		phantomSkinChangeRequest.SkinId = skinId;
		phantomSkinChangeRequest.ChangeDefault = changeDefault;
		Net.Instance.Call(ERequestMessageId.PhantomSkinChangeRequest, phantomSkinChangeRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PhantomSkinChangeResponse phantomSkinChangeResponse = (PhantomSkinChangeResponse)msg;
			if (phantomSkinChangeResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(phantomSkinChangeResponse.ErrorCode, 26665, null, true, true);
				return;
			}
			PhantomBattleData phantomItemDataByUniqueId = this.GetPhantomItemDataByUniqueId(uniqueId);
			if (phantomItemDataByUniqueId != null)
			{
				phantomItemDataByUniqueId.SetSkinId(skinId);
			}
			if (changeDefault)
			{
				PhantomBattleModel.Instance.SetDefaultSkin(phantomItemDataByUniqueId.GetConfig().MonsterId, skinId);
			}
			ScrollingTipsController.Instance.ShowTipsById("PhantomSkinUse", Array.Empty<object>());
			EventSystem.Instance.Emit(EEventName.OnVisionSkinEquip);
		}, 0);
	}

	// Token: 0x0600FC4E RID: 64590 RVA: 0x0049BEFC File Offset: 0x0049A0FC
	public void RequestForTraceMonster(int monsterId)
	{
		if (GameModeController.Instance.IsInInstance())
		{
			GenericPromptController.Instance.ShowPromptByCode("DungeonDetection", Array.Empty<object>());
			return;
		}
		MonsterDetectionRecord monsterDetectionRecord;
		if (AdventureGuideModel.Instance.GetAllDetectMonsters().TryGetValue(monsterId, out monsterDetectionRecord))
		{
			int[] array = AdventureGuideController.Instance.GetValidMonsterEntityIdsOfDetectConf(monsterDetectionRecord.Conf);
			if (array.Length == 0)
			{
				int entityConfigId = monsterDetectionRecord.Conf.EntityConfigId;
				if (entityConfigId == 0)
				{
					GenericPromptController.Instance.ShowPromptByCode("NoMonster", Array.Empty<object>());
					return;
				}
				array = new int[]
				{
					entityConfigId
				};
			}
			AdventureGuideModel.Instance.SetFromManualDetect(true);
			AdventureGuideController.Instance.RequestForDetection(DetectionType.NormalMonster, array, monsterId);
		}
	}

	// Token: 0x0600FC4F RID: 64591 RVA: 0x0049BFA0 File Offset: 0x0049A1A0
	[NullableContext(2)]
	public UniTask OpenPhantomBattleFetterView(int selectedGroupId, int roleId, bool showFastFilter = true, List<int> recommendGroupIds = null)
	{
		PhantomBattleController.<OpenPhantomBattleFetterView>d__25 <OpenPhantomBattleFetterView>d__;
		<OpenPhantomBattleFetterView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenPhantomBattleFetterView>d__.selectedGroupId = selectedGroupId;
		<OpenPhantomBattleFetterView>d__.roleId = roleId;
		<OpenPhantomBattleFetterView>d__.showFastFilter = showFastFilter;
		<OpenPhantomBattleFetterView>d__.recommendGroupIds = recommendGroupIds;
		<OpenPhantomBattleFetterView>d__.<>1__state = -1;
		<OpenPhantomBattleFetterView>d__.<>t__builder.Start<PhantomBattleController.<OpenPhantomBattleFetterView>d__25>(ref <OpenPhantomBattleFetterView>d__);
		return <OpenPhantomBattleFetterView>d__.<>t__builder.Task;
	}

	// Token: 0x0600FC50 RID: 64592 RVA: 0x0049BFFC File Offset: 0x0049A1FC
	private void OnActiveBattleView()
	{
		if (PhantomBattleModel.Instance.QualityUnlockTipsList.Count > 0)
		{
			this.DoShowUnlockQualityView();
		}
		if (CalabashModel.Instance.CalabashUnlockTipsList.Count > 0)
		{
			this.DoShowNewItemView();
		}
	}

	// Token: 0x0600FC51 RID: 64593 RVA: 0x0049C030 File Offset: 0x0049A230
	private void DoShowUnlockQualityView()
	{
		if (!UiManager.Instance.IsViewShow(EUiViewName.CalabashUnlockItemView) && UiManager.Instance.IsViewShow(EUiViewName.BattleView) && !SundryModel.Instance.IsBlockTips && PhantomBattleModel.Instance.QualityUnlockTipsList.Count > 0)
		{
			VisionUnlockQualityData param = PhantomBattleModel.Instance.QualityUnlockTipsList[0];
			PhantomBattleModel.Instance.QualityUnlockTipsList.RemoveAt(0);
			UiManager.Instance.OpenView(EUiViewName.CalabashUnlockItemView, param, null);
		}
	}

	// Token: 0x0600FC52 RID: 64594 RVA: 0x0049C0B0 File Offset: 0x0049A2B0
	private void DoShowNewItemView()
	{
		if (!UiManager.Instance.IsViewShow(EUiViewName.CalabashUnlockItemView) && UiManager.Instance.IsViewShow(EUiViewName.BattleView) && !SundryModel.Instance.IsBlockTips && CalabashModel.Instance.CalabashUnlockTipsList.Count > 0)
		{
			VisionUnlockQualityData param = CalabashModel.Instance.CalabashUnlockTipsList[0];
			CalabashModel.Instance.CalabashUnlockTipsList.RemoveAt(0);
			UiManager.Instance.OpenView(EUiViewName.CalabashUnlockItemView, param, null);
		}
	}

	// Token: 0x0600FC53 RID: 64595 RVA: 0x0049C12F File Offset: 0x0049A32F
	public bool CheckIsEquip(int uniqueId)
	{
		return PhantomBattleModel.Instance.CheckPhantomIsEquip(uniqueId);
	}

	// Token: 0x0600FC54 RID: 64596 RVA: 0x0049C13C File Offset: 0x0049A33C
	public bool CheckIsEquipByMonsterId(int monsterId, int roleId)
	{
		return PhantomBattleModel.Instance.CheckMonsterIsEquipOnRole(roleId, monsterId);
	}

	// Token: 0x0600FC55 RID: 64597 RVA: 0x0049C14A File Offset: 0x0049A34A
	public bool CheckIsMain(int id)
	{
		return PhantomBattleModel.Instance.CheckPhantomIsMain(id);
	}

	// Token: 0x0600FC56 RID: 64598 RVA: 0x0049C157 File Offset: 0x0049A357
	public bool CheckIsSub(int id)
	{
		return PhantomBattleModel.Instance.CheckPhantomIsSub(id);
	}

	// Token: 0x0600FC57 RID: 64599 RVA: 0x0049C164 File Offset: 0x0049A364
	public bool CheckFetterActivate(int fettersId, int roleId)
	{
		return PhantomBattleModel.Instance.CheckFetterActiveState(roleId, fettersId);
	}

	// Token: 0x0600FC58 RID: 64600 RVA: 0x0049C172 File Offset: 0x0049A372
	public bool CheckPhantomIsUnlock(int monsterId)
	{
		return PhantomBattleModel.Instance.GetPhantomIsUnlock(monsterId);
	}

	// Token: 0x0600FC59 RID: 64601 RVA: 0x0049C17F File Offset: 0x0049A37F
	public int? GetEquipRole(int uniqueId)
	{
		return PhantomBattleModel.Instance.GetPhantomEquipOnRoleId(uniqueId);
	}

	// Token: 0x0600FC5A RID: 64602 RVA: 0x0049C18C File Offset: 0x0049A38C
	public void SetMeshShow(int itemId, [Nullable(2)] Action callBack, SkeletalObserverHandle observer, bool isChangeLocation = true)
	{
		PhantomBattleController.<>c__DisplayClass36_0 CS$<>8__locals1 = new PhantomBattleController.<>c__DisplayClass36_0();
		CS$<>8__locals1.itemId = itemId;
		CS$<>8__locals1.callBack = callBack;
		UiModelBase model = observer.Model;
		CS$<>8__locals1.phantomInstance = PhantomBattleModel.Instance.GetPhantomInstanceByItemId(CS$<>8__locals1.itemId);
		int meshId = CS$<>8__locals1.phantomInstance.PhantomItem.Value.MeshId;
		UiModelDataComponent uiModelDataComponent = model.CheckGetComponent<UiModelDataComponent>();
		if (uiModelDataComponent != null && uiModelDataComponent.ModelConfigId == meshId)
		{
			if (uiModelDataComponent.GetModelLoadState() == EUiModelLoadState.LoadComplete)
			{
				Action callBack2 = CS$<>8__locals1.callBack;
				if (callBack2 == null)
				{
					return;
				}
				callBack2();
			}
			return;
		}
		if (SkeletalObserverConfig.Instance.GetMeshConfig(meshId) == null)
		{
			return;
		}
		CS$<>8__locals1.actorComponent = model.CheckGetComponent<UiModelActorComponent>();
		CS$<>8__locals1.animationComponent = model.CheckGetComponent<UiModelAnimationComponent>();
		CS$<>8__locals1.animationComponent.StopAnimation();
		if (isChangeLocation)
		{
			this.SetMeshTransform(observer);
		}
		CS$<>8__locals1.loadComponent = model.CheckGetComponent<UiModelLoadComponent>();
		CS$<>8__locals1.animationComponent.SetAnimationMode(EAnimationMode.AnimationSingleNode);
		string standAnim = PhantomBattleModel.Instance.GetStandAnim(CS$<>8__locals1.itemId);
		ResourceSystem.Instance.LoadAsync<UAnimationAsset>(standAnim, delegate([Nullable(2)] UAnimationAsset result, string _)
		{
			if (result != null)
			{
				CS$<>8__locals1.loadComponent.LoadModelByModelId(CS$<>8__locals1.phantomInstance.PhantomItem.Value.MeshId, true, delegate
				{
					CS$<>8__locals1.<SetMeshShow>g__LoadFinishCallBack|0(result);
				}, null);
			}
		}, 100, "Ui.PhantomUi");
	}

	// Token: 0x0600FC5B RID: 64603 RVA: 0x0049C2A1 File Offset: 0x0049A4A1
	public void SetMeshTransform(SkeletalObserverHandle observer)
	{
		observer.Model.CheckGetComponent<UiModelActorComponent>().SetTransformByTag("MonsterCase");
	}

	// Token: 0x0600FC5C RID: 64604 RVA: 0x0049C2B8 File Offset: 0x0049A4B8
	public EEquipType GetEquipState(int roleId, int index, int uniqueId)
	{
		return PhantomBattleModel.Instance.GetRolePhantomEquipState(roleId, index, uniqueId);
	}

	// Token: 0x0600FC5D RID: 64605 RVA: 0x0049C2C7 File Offset: 0x0049A4C7
	public int GetEquipByIndex(int roleId, int index)
	{
		return PhantomBattleModel.Instance.GetRoleIndexPhantomId(roleId, index);
	}

	// Token: 0x0600FC5E RID: 64606 RVA: 0x0049C2D5 File Offset: 0x0049A4D5
	public List<ItemInfo> GetLevelUpItemList(int uniqueId)
	{
		return new List<ItemInfo>(PhantomBattleModel.Instance.GetPhantomLevelUpItemSortList(uniqueId));
	}

	// Token: 0x0600FC5F RID: 64607 RVA: 0x0049C2E7 File Offset: 0x0049A4E7
	public int GetLevelUpNeedCost(int exp)
	{
		return PhantomBattleModel.Instance.GetLevelUpNeedCost(exp);
	}

	// Token: 0x0600FC60 RID: 64608 RVA: 0x0049C2F4 File Offset: 0x0049A4F4
	public int GetMaxLevel(int uniqueId)
	{
		return PhantomBattleModel.Instance.GetPhantomMaxLevel(uniqueId);
	}

	// Token: 0x0600FC61 RID: 64609 RVA: 0x0049C301 File Offset: 0x0049A501
	public bool CheckPhantomLevelSatisfied(int itemId, int level)
	{
		return PhantomBattleModel.Instance.CheckIfHasPhantomSatisfiedLevelCondition(itemId, level);
	}

	// Token: 0x0600FC62 RID: 64610 RVA: 0x0049C30F File Offset: 0x0049A50F
	public bool CheckHasPhantomMaxLevel()
	{
		return PhantomBattleModel.Instance.CheckIfHasPhantomLevelMax();
	}

	// Token: 0x0600FC63 RID: 64611 RVA: 0x0049C31C File Offset: 0x0049A51C
	[NullableContext(0)]
	public UniTask<double> GetProgressCurveValue(float progress, double startPosition, double targetPosition)
	{
		PhantomBattleController.<GetProgressCurveValue>d__45 <GetProgressCurveValue>d__;
		<GetProgressCurveValue>d__.<>t__builder = AsyncUniTaskMethodBuilder<double>.Create();
		<GetProgressCurveValue>d__.progress = progress;
		<GetProgressCurveValue>d__.startPosition = startPosition;
		<GetProgressCurveValue>d__.targetPosition = targetPosition;
		<GetProgressCurveValue>d__.<>1__state = -1;
		<GetProgressCurveValue>d__.<>t__builder.Start<PhantomBattleController.<GetProgressCurveValue>d__45>(ref <GetProgressCurveValue>d__);
		return <GetProgressCurveValue>d__.<>t__builder.Task;
	}

	// Token: 0x0600FC64 RID: 64612 RVA: 0x0049C36F File Offset: 0x0049A56F
	public void RecordVisionLevelUpSettingRedDot()
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.VisionLevelUpSettingRedDot, true);
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.VisionLevelUpIdentifyRedDot, true);
		EventSystem.Instance.Emit(EEventName.RefreshVisionLevelUpSettingRedPoint);
	}

	// Token: 0x0600FC65 RID: 64613 RVA: 0x0049C394 File Offset: 0x0049A594
	[NullableContext(0)]
	public UniTask<bool> RequestPhBaPlanUsePlan()
	{
		PhantomBattleController.<RequestPhBaPlanUsePlan>d__47 <RequestPhBaPlanUsePlan>d__;
		<RequestPhBaPlanUsePlan>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestPhBaPlanUsePlan>d__.<>1__state = -1;
		<RequestPhBaPlanUsePlan>d__.<>t__builder.Start<PhantomBattleController.<RequestPhBaPlanUsePlan>d__47>(ref <RequestPhBaPlanUsePlan>d__);
		return <RequestPhBaPlanUsePlan>d__.<>t__builder.Task;
	}

	// Token: 0x0600FC66 RID: 64614 RVA: 0x0049C3D0 File Offset: 0x0049A5D0
	[NullableContext(0)]
	public UniTask<bool> RequestPhBaPlanSaveUsePlan(bool isReset, [Nullable(1)] HashSet<int> openIdSet)
	{
		PhantomBattleController.<RequestPhBaPlanSaveUsePlan>d__48 <RequestPhBaPlanSaveUsePlan>d__;
		<RequestPhBaPlanSaveUsePlan>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestPhBaPlanSaveUsePlan>d__.<>4__this = this;
		<RequestPhBaPlanSaveUsePlan>d__.isReset = isReset;
		<RequestPhBaPlanSaveUsePlan>d__.openIdSet = openIdSet;
		<RequestPhBaPlanSaveUsePlan>d__.<>1__state = -1;
		<RequestPhBaPlanSaveUsePlan>d__.<>t__builder.Start<PhantomBattleController.<RequestPhBaPlanSaveUsePlan>d__48>(ref <RequestPhBaPlanSaveUsePlan>d__);
		return <RequestPhBaPlanSaveUsePlan>d__.<>t__builder.Task;
	}

	// Token: 0x0600FC67 RID: 64615 RVA: 0x0049C424 File Offset: 0x0049A624
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public UniTask<PhBaPlanFindPlanResponse> RequestPhBaPlanFindPlan(string code)
	{
		PhantomBattleController.<RequestPhBaPlanFindPlan>d__49 <RequestPhBaPlanFindPlan>d__;
		<RequestPhBaPlanFindPlan>d__.<>t__builder = AsyncUniTaskMethodBuilder<PhBaPlanFindPlanResponse>.Create();
		<RequestPhBaPlanFindPlan>d__.code = code;
		<RequestPhBaPlanFindPlan>d__.<>1__state = -1;
		<RequestPhBaPlanFindPlan>d__.<>t__builder.Start<PhantomBattleController.<RequestPhBaPlanFindPlan>d__49>(ref <RequestPhBaPlanFindPlan>d__);
		return <RequestPhBaPlanFindPlan>d__.<>t__builder.Task;
	}

	// Token: 0x0600FC68 RID: 64616 RVA: 0x0049C468 File Offset: 0x0049A668
	[NullableContext(0)]
	public UniTask<bool> RequestPhBaPlanUpdatePlan()
	{
		PhantomBattleController.<RequestPhBaPlanUpdatePlan>d__50 <RequestPhBaPlanUpdatePlan>d__;
		<RequestPhBaPlanUpdatePlan>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestPhBaPlanUpdatePlan>d__.<>1__state = -1;
		<RequestPhBaPlanUpdatePlan>d__.<>t__builder.Start<PhantomBattleController.<RequestPhBaPlanUpdatePlan>d__50>(ref <RequestPhBaPlanUpdatePlan>d__);
		return <RequestPhBaPlanUpdatePlan>d__.<>t__builder.Task;
	}

	// Token: 0x0600FC69 RID: 64617 RVA: 0x0049C4A4 File Offset: 0x0049A6A4
	[NullableContext(0)]
	public UniTask<bool> RequestPhBaPlanSetFiveStarSwitch()
	{
		PhantomBattleController.<RequestPhBaPlanSetFiveStarSwitch>d__51 <RequestPhBaPlanSetFiveStarSwitch>d__;
		<RequestPhBaPlanSetFiveStarSwitch>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestPhBaPlanSetFiveStarSwitch>d__.<>1__state = -1;
		<RequestPhBaPlanSetFiveStarSwitch>d__.<>t__builder.Start<PhantomBattleController.<RequestPhBaPlanSetFiveStarSwitch>d__51>(ref <RequestPhBaPlanSetFiveStarSwitch>d__);
		return <RequestPhBaPlanSetFiveStarSwitch>d__.<>t__builder.Task;
	}

	// Token: 0x0600FC6A RID: 64618 RVA: 0x0049C4E0 File Offset: 0x0049A6E0
	[NullableContext(0)]
	public UniTask<bool> RequestPhBaPlanSetPlanStatus([Nullable(1)] IEnumerable<int> fetterIdList, bool isOpen)
	{
		PhantomBattleController.<RequestPhBaPlanSetPlanStatus>d__52 <RequestPhBaPlanSetPlanStatus>d__;
		<RequestPhBaPlanSetPlanStatus>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestPhBaPlanSetPlanStatus>d__.fetterIdList = fetterIdList;
		<RequestPhBaPlanSetPlanStatus>d__.isOpen = isOpen;
		<RequestPhBaPlanSetPlanStatus>d__.<>1__state = -1;
		<RequestPhBaPlanSetPlanStatus>d__.<>t__builder.Start<PhantomBattleController.<RequestPhBaPlanSetPlanStatus>d__52>(ref <RequestPhBaPlanSetPlanStatus>d__);
		return <RequestPhBaPlanSetPlanStatus>d__.<>t__builder.Task;
	}

	// Token: 0x17001819 RID: 6169
	// (get) Token: 0x0600FC6B RID: 64619 RVA: 0x0049C52B File Offset: 0x0049A72B
	public static PhantomBattleController Instance
	{
		get
		{
			return PhantomBattleController._Instance;
		}
	}

	// Token: 0x0600FC6C RID: 64620 RVA: 0x0049C532 File Offset: 0x0049A732
	public static PhantomBattleController GetOrCreateInstance()
	{
		if (PhantomBattleController._Instance == null)
		{
			PhantomBattleController.CreateInstance();
		}
		return PhantomBattleController._Instance;
	}

	// Token: 0x0600FC6D RID: 64621 RVA: 0x0049C546 File Offset: 0x0049A746
	public static bool CreateInstance()
	{
		if (PhantomBattleController._Instance != null)
		{
			return true;
		}
		PhantomBattleController._Instance = new PhantomBattleController();
		return true;
	}

	// Token: 0x0600FC6E RID: 64622 RVA: 0x0049C55C File Offset: 0x0049A75C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600FC6F RID: 64623 RVA: 0x0049C55E File Offset: 0x0049A75E
	public static void ResetStaticDefaultValue()
	{
		PhantomBattleController._Instance = null;
	}

	// Token: 0x0600FC70 RID: 64624 RVA: 0x0049C566 File Offset: 0x0049A766
	static PhantomBattleController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhantomBattleController.CreateStaticDefaultValue), new Action(PhantomBattleController.ResetStaticDefaultValue));
	}

	// Token: 0x04008CB4 RID: 36020
	[Nullable(2)]
	private static PhantomBattleController _Instance;
}
