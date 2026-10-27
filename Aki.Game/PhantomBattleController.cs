using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02002405 RID: 9221
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PhantomBattleController : UiControllerBase
{
	// Token: 0x06012780 RID: 75648 RVA: 0x0048DB51 File Offset: 0x0048BD51
	public static void InitData()
	{
	}

	// Token: 0x06012781 RID: 75649 RVA: 0x0048DB54 File Offset: 0x0048BD54
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<Aki.Protocol.PhantomItem>(EEventName.OnAddPhantomItem, new Action<Aki.Protocol.PhantomItem>(this.OnAddPhantomItem));
		EventSystem.Instance.Add<Aki.Protocol.PhantomItem>(EEventName.OnResponsePhantomItem, new Action<Aki.Protocol.PhantomItem>(this.OnResponsePhantomItem));
		EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.OnRemovePhantomItem, new Action<IReadOnlyList<int>>(this.OnRemovePhantomItem));
		EventSystem.Instance.Add<PhantomItemResponse>(EEventName.OnEquipPhantomItem, new Action<PhantomItemResponse>(this.OnEquipPhantomItem));
		EventSystem.Instance.Add(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
	}

	// Token: 0x06012782 RID: 75650 RVA: 0x0048DBF0 File Offset: 0x0048BDF0
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnAddPhantomItem, new Action<Aki.Protocol.PhantomItem>(this.OnAddPhantomItem));
		EventSystem.Instance.Remove(EEventName.OnResponsePhantomItem, new Action<Aki.Protocol.PhantomItem>(this.OnResponsePhantomItem));
		EventSystem.Instance.Remove(EEventName.OnRemovePhantomItem, new Action<IReadOnlyList<int>>(this.OnRemovePhantomItem));
		EventSystem.Instance.Remove(EEventName.OnEquipPhantomItem, new Action<PhantomItemResponse>(this.OnEquipPhantomItem));
		EventSystem.Instance.Remove(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
	}

	// Token: 0x06012783 RID: 75651 RVA: 0x0048DC89 File Offset: 0x0048BE89
	private void OnResponsePhantomItem(Aki.Protocol.PhantomItem phantomItem)
	{
		PhantomBattleModel.Instance.NewPhantomBattleData(phantomItem);
	}

	// Token: 0x06012784 RID: 75652 RVA: 0x0048DC97 File Offset: 0x0048BE97
	private void OnAddPhantomItem(Aki.Protocol.PhantomItem phantomItem)
	{
		PhantomBattleModel.Instance.NewPhantomBattleData(phantomItem);
	}

	// Token: 0x06012785 RID: 75653 RVA: 0x0048DCA8 File Offset: 0x0048BEA8
	private void OnRemovePhantomItem(IReadOnlyList<int> uniqueIdList)
	{
		foreach (int uniqueId in uniqueIdList)
		{
			PhantomBattleModel.Instance.RemovePhantomBattleData(uniqueId);
		}
	}

	// Token: 0x06012786 RID: 75654 RVA: 0x0048DCF4 File Offset: 0x0048BEF4
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

	// Token: 0x06012787 RID: 75655 RVA: 0x0048DD98 File Offset: 0x0048BF98
	[NullableContext(2)]
	public PhantomBattleData GetPhantomItemDataByUniqueId(int uniqueId)
	{
		return PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId);
	}

	// Token: 0x06012788 RID: 75656 RVA: 0x0048DDA5 File Offset: 0x0048BFA5
	public void ChangeRoleEvent(int roleId)
	{
		PhantomBattleModel.Instance.UpdateFetterList(roleId);
	}

	// Token: 0x06012789 RID: 75657 RVA: 0x0048DDB4 File Offset: 0x0048BFB4
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.PhantomEquipInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPhantomEquipInfoNotify));
		Net.Instance.Register(ENotifyMessageId.PhantomItemUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPhantomItemUpdate));
		Net.Instance.Register(ENotifyMessageId.RolePhantomPropUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRolePhantomPropUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.PhantomUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPhantomUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.PhantomSkinAddNotify, new Action<IMessage, Net.CallbackStatus>(this.PhantomSkinAddNotify));
		Net.Instance.Register(ENotifyMessageId.PhantomUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.PhantomUnlockNotify));
	}

	// Token: 0x0601278A RID: 75658 RVA: 0x0048DE6C File Offset: 0x0048C06C
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.PhantomEquipInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PhantomItemUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RolePhantomPropUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PhantomUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PhantomSkinAddNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PhantomUnlockNotify);
	}

	// Token: 0x0601278B RID: 75659 RVA: 0x0048DEDC File Offset: 0x0048C0DC
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(phantomLevelUpResponse.ErrorCode, 22489, null, true, true);
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
				instance.PhantomLevelUpReceiveItem(phantomLevelUpResponse.ItemMap.ToDictionary<int, int>());
				instance.CachePhantomLevelUpData(data);
				EventSystem.Instance.Emit(EEventName.PhantomLevelUp);
				EventSystem.Instance.Emit<int>(EEventName.PhantomLevelUpWithId, incId);
				return;
			}
		}, 0);
	}

	// Token: 0x0601278C RID: 75660 RVA: 0x0048DF58 File Offset: 0x0048C158
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

	// Token: 0x0601278D RID: 75661 RVA: 0x0048DFE0 File Offset: 0x0048C1E0
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(phantomPutOnResponse.ErrorCode, 16317, null, true, true);
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

	// Token: 0x0601278E RID: 75662 RVA: 0x0048E214 File Offset: 0x0048C414
	public void SendPhantomAutoPutRequest(int roleId, List<int> uniqueIdList, [Nullable(2)] Action successCallBack = null)
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(phantomAutoPutResponse.ErrorCode, 19223, null, true, true);
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

	// Token: 0x0601278F RID: 75663 RVA: 0x0048E31C File Offset: 0x0048C51C
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

	// Token: 0x06012790 RID: 75664 RVA: 0x0048E3A4 File Offset: 0x0048C5A4
	[NullableContext(2)]
	private void OnRolePhantomPropUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		foreach (RolePhantomPropInfo rolePhantomPropInfo in ((RolePhantomPropUpdateNotify)msg).PropInfo)
		{
			PhantomBattleModel.Instance.GetBattleDataById(rolePhantomPropInfo.RoleId).Phrase(rolePhantomPropInfo);
		}
		EventSystem.Instance.Emit(EEventName.OnRolePropUpdate);
	}

	// Token: 0x06012791 RID: 75665 RVA: 0x0048E418 File Offset: 0x0048C618
	[NullableContext(2)]
	private void OnPhantomUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		PhantomUpdateNotify phantomUpdateNotify = (PhantomUpdateNotify)msg;
		PhantomBattleModel.Instance.SetMaxCost(phantomUpdateNotify.TotalCost);
	}

	// Token: 0x06012792 RID: 75666 RVA: 0x0048E43C File Offset: 0x0048C63C
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

	// Token: 0x06012793 RID: 75667 RVA: 0x0048E500 File Offset: 0x0048C700
	[NullableContext(2)]
	private void PhantomSkinAddNotify(IMessage msg, Net.CallbackStatus status)
	{
		RepeatedField<int> skinIds = ((PhantomSkinAddNotify)msg).SkinIds;
		PhantomBattleModel.Instance.ConcatUnlockSkinList(skinIds.ToList<int>());
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

	// Token: 0x06012794 RID: 75668 RVA: 0x0048E5B0 File Offset: 0x0048C7B0
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

	// Token: 0x06012795 RID: 75669 RVA: 0x0048E638 File Offset: 0x0048C838
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

	// Token: 0x06012796 RID: 75670 RVA: 0x0048E738 File Offset: 0x0048C938
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

	// Token: 0x06012797 RID: 75671 RVA: 0x0048E78C File Offset: 0x0048C98C
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(phantomSkinChangeResponse.ErrorCode, 29630, null, true, true);
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

	// Token: 0x06012798 RID: 75672 RVA: 0x0048E8E0 File Offset: 0x0048CAE0
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

	// Token: 0x06012799 RID: 75673 RVA: 0x0048E984 File Offset: 0x0048CB84
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

	// Token: 0x0601279A RID: 75674 RVA: 0x0048E9E0 File Offset: 0x0048CBE0
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

	// Token: 0x0601279B RID: 75675 RVA: 0x0048EA14 File Offset: 0x0048CC14
	private void DoShowUnlockQualityView()
	{
		if (!UiManager.Instance.IsViewShow(EUiViewName.CalabashUnlockItemView) && UiManager.Instance.IsViewShow(EUiViewName.BattleView) && !SundryModel.Instance.IsBlockTips && PhantomBattleModel.Instance.QualityUnlockTipsList.Count > 0)
		{
			VisionUnlockQualityData param = PhantomBattleModel.Instance.QualityUnlockTipsList[0];
			PhantomBattleModel.Instance.QualityUnlockTipsList.RemoveAt(0);
			UiManager.Instance.OpenView(EUiViewName.CalabashUnlockItemView, param, null);
		}
	}

	// Token: 0x0601279C RID: 75676 RVA: 0x0048EA94 File Offset: 0x0048CC94
	private void DoShowNewItemView()
	{
		if (!UiManager.Instance.IsViewShow(EUiViewName.CalabashUnlockItemView) && UiManager.Instance.IsViewShow(EUiViewName.BattleView) && !SundryModel.Instance.IsBlockTips && CalabashModel.Instance.CalabashUnlockTipsList.Count > 0)
		{
			VisionUnlockQualityData param = CalabashModel.Instance.CalabashUnlockTipsList[0];
			CalabashModel.Instance.CalabashUnlockTipsList.RemoveAt(0);
			UiManager.Instance.OpenView(EUiViewName.CalabashUnlockItemView, param, null);
		}
	}

	// Token: 0x0601279D RID: 75677 RVA: 0x0048EB13 File Offset: 0x0048CD13
	public bool CheckIsEquip(int uniqueId)
	{
		return PhantomBattleModel.Instance.CheckPhantomIsEquip(uniqueId);
	}

	// Token: 0x0601279E RID: 75678 RVA: 0x0048EB20 File Offset: 0x0048CD20
	public bool CheckIsEquipByMonsterId(int monsterId, int roleId)
	{
		return PhantomBattleModel.Instance.CheckMonsterIsEquipOnRole(roleId, monsterId);
	}

	// Token: 0x0601279F RID: 75679 RVA: 0x0048EB2E File Offset: 0x0048CD2E
	public bool CheckIsMain(int id)
	{
		return PhantomBattleModel.Instance.CheckPhantomIsMain(id);
	}

	// Token: 0x060127A0 RID: 75680 RVA: 0x0048EB3B File Offset: 0x0048CD3B
	public bool CheckIsSub(int id)
	{
		return PhantomBattleModel.Instance.CheckPhantomIsSub(id);
	}

	// Token: 0x060127A1 RID: 75681 RVA: 0x0048EB48 File Offset: 0x0048CD48
	public bool CheckFetterActivate(int fettersId, int roleId)
	{
		return PhantomBattleModel.Instance.CheckFetterActiveState(roleId, fettersId);
	}

	// Token: 0x060127A2 RID: 75682 RVA: 0x0048EB56 File Offset: 0x0048CD56
	public bool CheckPhantomIsUnlock(int monsterId)
	{
		return PhantomBattleModel.Instance.GetPhantomIsUnlock(monsterId);
	}

	// Token: 0x060127A3 RID: 75683 RVA: 0x0048EB63 File Offset: 0x0048CD63
	public int? GetEquipRole(int uniqueId)
	{
		return PhantomBattleModel.Instance.GetPhantomEquipOnRoleId(uniqueId);
	}

	// Token: 0x060127A4 RID: 75684 RVA: 0x0048EB70 File Offset: 0x0048CD70
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

	// Token: 0x060127A5 RID: 75685 RVA: 0x0048EC85 File Offset: 0x0048CE85
	public void SetMeshTransform(SkeletalObserverHandle observer)
	{
		observer.Model.CheckGetComponent<UiModelActorComponent>().SetTransformByTag("MonsterCase");
	}

	// Token: 0x060127A6 RID: 75686 RVA: 0x0048EC9C File Offset: 0x0048CE9C
	public EEquipType GetEquipState(int roleId, int index, int uniqueId)
	{
		return PhantomBattleModel.Instance.GetRolePhantomEquipState(roleId, index, uniqueId);
	}

	// Token: 0x060127A7 RID: 75687 RVA: 0x0048ECAB File Offset: 0x0048CEAB
	public int GetEquipByIndex(int roleId, int index)
	{
		return PhantomBattleModel.Instance.GetRoleIndexPhantomId(roleId, index);
	}

	// Token: 0x060127A8 RID: 75688 RVA: 0x0048ECB9 File Offset: 0x0048CEB9
	public List<ItemInfo> GetLevelUpItemList(int uniqueId)
	{
		return PhantomBattleModel.Instance.GetPhantomLevelUpItemSortList(uniqueId).ToList<ItemInfo>();
	}

	// Token: 0x060127A9 RID: 75689 RVA: 0x0048ECCB File Offset: 0x0048CECB
	public int GetLevelUpNeedCost(int exp)
	{
		return PhantomBattleModel.Instance.GetLevelUpNeedCost(exp);
	}

	// Token: 0x060127AA RID: 75690 RVA: 0x0048ECD8 File Offset: 0x0048CED8
	public int GetMaxLevel(int uniqueId)
	{
		return PhantomBattleModel.Instance.GetPhantomMaxLevel(uniqueId);
	}

	// Token: 0x060127AB RID: 75691 RVA: 0x0048ECE5 File Offset: 0x0048CEE5
	public bool CheckPhantomLevelSatisfied(int itemId, int level)
	{
		return PhantomBattleModel.Instance.CheckIfHasPhantomSatisfiedLevelCondition(itemId, level);
	}

	// Token: 0x060127AC RID: 75692 RVA: 0x0048ECF3 File Offset: 0x0048CEF3
	public bool CheckHasPhantomMaxLevel()
	{
		return PhantomBattleModel.Instance.CheckIfHasPhantomLevelMax();
	}

	// Token: 0x060127AD RID: 75693 RVA: 0x0048ED00 File Offset: 0x0048CF00
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

	// Token: 0x060127AE RID: 75694 RVA: 0x0048ED53 File Offset: 0x0048CF53
	public void RecordVisionLevelUpSettingRedDot()
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.VisionLevelUpSettingRedDot, true);
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.VisionLevelUpIdentifyRedDot, true);
		EventSystem.Instance.Emit(EEventName.RefreshVisionLevelUpSettingRedPoint);
	}

	// Token: 0x060127AF RID: 75695 RVA: 0x0048ED78 File Offset: 0x0048CF78
	[NullableContext(0)]
	public UniTask<bool> RequestPhBaPlanUsePlan()
	{
		PhantomBattleController.<RequestPhBaPlanUsePlan>d__47 <RequestPhBaPlanUsePlan>d__;
		<RequestPhBaPlanUsePlan>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestPhBaPlanUsePlan>d__.<>1__state = -1;
		<RequestPhBaPlanUsePlan>d__.<>t__builder.Start<PhantomBattleController.<RequestPhBaPlanUsePlan>d__47>(ref <RequestPhBaPlanUsePlan>d__);
		return <RequestPhBaPlanUsePlan>d__.<>t__builder.Task;
	}

	// Token: 0x060127B0 RID: 75696 RVA: 0x0048EDB4 File Offset: 0x0048CFB4
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

	// Token: 0x060127B1 RID: 75697 RVA: 0x0048EE08 File Offset: 0x0048D008
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

	// Token: 0x060127B2 RID: 75698 RVA: 0x0048EE4C File Offset: 0x0048D04C
	[NullableContext(0)]
	public UniTask<bool> RequestPhBaPlanUpdatePlan()
	{
		PhantomBattleController.<RequestPhBaPlanUpdatePlan>d__50 <RequestPhBaPlanUpdatePlan>d__;
		<RequestPhBaPlanUpdatePlan>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestPhBaPlanUpdatePlan>d__.<>1__state = -1;
		<RequestPhBaPlanUpdatePlan>d__.<>t__builder.Start<PhantomBattleController.<RequestPhBaPlanUpdatePlan>d__50>(ref <RequestPhBaPlanUpdatePlan>d__);
		return <RequestPhBaPlanUpdatePlan>d__.<>t__builder.Task;
	}

	// Token: 0x060127B3 RID: 75699 RVA: 0x0048EE88 File Offset: 0x0048D088
	[NullableContext(0)]
	public UniTask<bool> RequestPhBaPlanSetFiveStarSwitch()
	{
		PhantomBattleController.<RequestPhBaPlanSetFiveStarSwitch>d__51 <RequestPhBaPlanSetFiveStarSwitch>d__;
		<RequestPhBaPlanSetFiveStarSwitch>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestPhBaPlanSetFiveStarSwitch>d__.<>1__state = -1;
		<RequestPhBaPlanSetFiveStarSwitch>d__.<>t__builder.Start<PhantomBattleController.<RequestPhBaPlanSetFiveStarSwitch>d__51>(ref <RequestPhBaPlanSetFiveStarSwitch>d__);
		return <RequestPhBaPlanSetFiveStarSwitch>d__.<>t__builder.Task;
	}

	// Token: 0x060127B4 RID: 75700 RVA: 0x0048EEC4 File Offset: 0x0048D0C4
	[NullableContext(0)]
	public UniTask<bool> RequestPhBaPlanSetPlanStatus([Nullable(1)] List<int> fetterIdList, bool isOpen)
	{
		PhantomBattleController.<RequestPhBaPlanSetPlanStatus>d__52 <RequestPhBaPlanSetPlanStatus>d__;
		<RequestPhBaPlanSetPlanStatus>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestPhBaPlanSetPlanStatus>d__.fetterIdList = fetterIdList;
		<RequestPhBaPlanSetPlanStatus>d__.isOpen = isOpen;
		<RequestPhBaPlanSetPlanStatus>d__.<>1__state = -1;
		<RequestPhBaPlanSetPlanStatus>d__.<>t__builder.Start<PhantomBattleController.<RequestPhBaPlanSetPlanStatus>d__52>(ref <RequestPhBaPlanSetPlanStatus>d__);
		return <RequestPhBaPlanSetPlanStatus>d__.<>t__builder.Task;
	}

	// Token: 0x170017DF RID: 6111
	// (get) Token: 0x060127B5 RID: 75701 RVA: 0x0048EF0F File Offset: 0x0048D10F
	public static PhantomBattleController Instance
	{
		get
		{
			return PhantomBattleController._Instance;
		}
	}

	// Token: 0x060127B6 RID: 75702 RVA: 0x0048EF16 File Offset: 0x0048D116
	public static PhantomBattleController GetOrCreateInstance()
	{
		if (PhantomBattleController._Instance == null)
		{
			PhantomBattleController.CreateInstance();
		}
		return PhantomBattleController._Instance;
	}

	// Token: 0x060127B7 RID: 75703 RVA: 0x0048EF2A File Offset: 0x0048D12A
	public static bool CreateInstance()
	{
		if (PhantomBattleController._Instance != null)
		{
			return true;
		}
		PhantomBattleController._Instance = new PhantomBattleController();
		return true;
	}

	// Token: 0x060127B8 RID: 75704 RVA: 0x0048EF40 File Offset: 0x0048D140
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060127B9 RID: 75705 RVA: 0x0048EF42 File Offset: 0x0048D142
	public static void ResetStaticDefaultValue()
	{
		PhantomBattleController._Instance = null;
	}

	// Token: 0x060127BA RID: 75706 RVA: 0x0048EF4A File Offset: 0x0048D14A
	static PhantomBattleController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhantomBattleController.CreateStaticDefaultValue), new Action(PhantomBattleController.ResetStaticDefaultValue));
	}

	// Token: 0x04008B6D RID: 35693
	[Nullable(2)]
	private static PhantomBattleController _Instance;
}
