using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GameMainView.TrapDefense;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using UnrealEngine;

// Token: 0x02002194 RID: 8596
[Controller(0)]
public class TrapDefenseController : UiControllerBase
{
	// Token: 0x06015200 RID: 86528 RVA: 0x006259C8 File Offset: 0x00623BC8
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.TrapDefenseSystemInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTrapDefenseSystemInfoNotify));
		Net.Instance.Register(ENotifyMessageId.TrapDefenseSyncGainingGroupsNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TrapDefenseSyncGainingGroupsNotify response = (TrapDefenseSyncGainingGroupsNotify)msg;
			TrapDefenseModel instance = TrapDefenseModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ProtoBdBuffAllUpdateNotify(response);
		});
		Net.Instance.Register(ENotifyMessageId.TrapDefenseRewardGainingGroupsNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TrapDefenseRewardGainingGroupsNotify response = (TrapDefenseRewardGainingGroupsNotify)msg;
			TrapDefenseModel instance = TrapDefenseModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ProtoBdBuffSelectUpdateNotify(response);
		});
		Net.Instance.Register(ENotifyMessageId.TrapDefenseGainingGroupUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TrapDefenseGainingGroupUpdateNotify response = (TrapDefenseGainingGroupUpdateNotify)msg;
			TrapDefenseModel instance = TrapDefenseModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ProtoBdBuffGetUpdateNotify(response);
		});
		Net.Instance.Register(ENotifyMessageId.TrapDefenseMonsterConsecutiveKillsNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMonsterConsecutiveKillsNotify));
		Net.Instance.Register(ENotifyMessageId.TrapDefenseSpawnMonsterWaveEndNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSpawnMonsterWaveEndNotify));
		Net.Instance.Register(ENotifyMessageId.TrapDefenseDevelopInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTrapDefenseDevelopInfoUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.TrapDefenseChallengeResultNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTrapDefenseChallengeResultNotify));
		Net.Instance.Register(ENotifyMessageId.TrapDefenseItemUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTrapDefenseItemUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.TrapDefenseSystemInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTrapDefenseSystemInfoUpdateNotify));
	}

	// Token: 0x06015201 RID: 86529 RVA: 0x00625B26 File Offset: 0x00623D26
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.TrapDefenseBuildingDevelopMainView, new Func<EUiViewName, object, bool>(this.CanOpenDevelopView), "TrapDefenseController.CanOpenDevelopView");
	}

	// Token: 0x06015202 RID: 86530 RVA: 0x00625B48 File Offset: 0x00623D48
	protected override void OnRemoveOpenViewCheckFunction()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.TrapDefenseBuildingDevelopMainView, new Func<EUiViewName, object, bool>(this.CanOpenDevelopView));
	}

	// Token: 0x06015203 RID: 86531 RVA: 0x00625B68 File Offset: 0x00623D68
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.TrapDefenseSystemInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TrapDefenseSyncGainingGroupsNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TrapDefenseRewardGainingGroupsNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TrapDefenseMonsterConsecutiveKillsNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TrapDefenseSpawnMonsterWaveEndNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TrapDefenseDevelopInfoUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TrapDefenseChallengeResultNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TrapDefenseItemUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.TrapDefenseSystemInfoUpdateNotify);
	}

	// Token: 0x06015204 RID: 86532 RVA: 0x00625C05 File Offset: 0x00623E05
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnInstanceChange, new Action<int, int>(this.OnInstanceChange));
		EventSystem.Instance.Add(EEventName.TrapDefenseInventoryDataUpdate, new Action(this.OnTrapDefenseInventoryDataUpdate));
	}

	// Token: 0x06015205 RID: 86533 RVA: 0x00625C3F File Offset: 0x00623E3F
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.OnInstanceChange, new Action<int, int>(this.OnInstanceChange));
		EventSystem.Instance.Remove(EEventName.TrapDefenseInventoryDataUpdate, new Action(this.OnTrapDefenseInventoryDataUpdate));
	}

	// Token: 0x06015206 RID: 86534 RVA: 0x00625C7C File Offset: 0x00623E7C
	public void RequestTrapDefenseUseItem(int itemId)
	{
		TrapDefenseUseItemRequest trapDefenseUseItemRequest = TrapDefenseUseItemRequest.Create();
		trapDefenseUseItemRequest.ItemConfigId = itemId;
		Net.Instance.Call(ERequestMessageId.TrapDefenseUseItemRequest, trapDefenseUseItemRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TrapDefenseUseItemResponse trapDefenseUseItemResponse = (TrapDefenseUseItemResponse)msg;
			if (trapDefenseUseItemResponse == null)
			{
				return;
			}
			if (trapDefenseUseItemResponse.ErrorCode == Aki.Protocol.ErrorCode.TrapDefenseItemNotEnough)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.TowerDefenseEvent;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "塔防尝试使用道具不足";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ItemId", itemId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (trapDefenseUseItemResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(trapDefenseUseItemResponse.ErrorCode, 28819, null, true, true);
				return;
			}
			TrapDefenseModel instance2 = TrapDefenseModel.Instance;
			TrapDefenseBattleItemData trapDefenseBattleItemData = (instance2 != null) ? instance2.BattleInventoryData.GetItemData(itemId) : null;
			if (trapDefenseBattleItemData != null && trapDefenseBattleItemData.IsUseSkill)
			{
				TowerDefensePlayerController.PlayerDoSkill(trapDefenseBattleItemData.SkillIndex);
				TrapDefenseModel instance3 = TrapDefenseModel.Instance;
				if (instance3 == null)
				{
					return;
				}
				instance3.BattleData.RefreshExploreSkillData();
			}
		}, 0);
	}

	// Token: 0x06015207 RID: 86535 RVA: 0x00625CC8 File Offset: 0x00623EC8
	[NullableContext(2)]
	private void OnTrapDefenseItemUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		TrapDefenseItemUpdateNotify trapDefenseItemUpdateNotify = (TrapDefenseItemUpdateNotify)msg;
		TrapDefenseModel instance = TrapDefenseModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.BattleInventoryData.UpdateItemData(trapDefenseItemUpdateNotify.ItemDatas);
	}

	// Token: 0x06015208 RID: 86536 RVA: 0x00625CF6 File Offset: 0x00623EF6
	[NullableContext(2)]
	private bool CanOpenDevelopView(EUiViewName viewName, object param)
	{
		return !((ITrapDefenseDevelopOpenParam)param).IsInDungeon || TrapDefenseModel.Instance.BattleData.IsCanBuildMachine;
	}

	// Token: 0x06015209 RID: 86537 RVA: 0x00625D18 File Offset: 0x00623F18
	[NullableContext(2)]
	public void OpenOrganDevelop(bool isInDungeon, UiViewBase parentView, int index = 0, TrapDefenseLevelData levelData = null)
	{
		TrapDefenseDevelopOpenParam param = new TrapDefenseDevelopOpenParam
		{
			IsInDungeon = isInDungeon,
			SelectedIndex = index,
			LevelData = levelData
		};
		UiManager.Instance.OpenView(EUiViewName.TrapDefenseBuildingDevelopMainView, param, delegate(bool success, int viewId)
		{
			if (success && parentView != null)
			{
				parentView.AddChildViewById(viewId);
			}
		});
	}

	// Token: 0x0601520A RID: 86538 RVA: 0x00625D6C File Offset: 0x00623F6C
	[NullableContext(2)]
	private void OnTrapDefenseDevelopInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		TrapDefenseDevelopInfoUpdateNotify data = (TrapDefenseDevelopInfoUpdateNotify)msg;
		TrapDefenseModel.Instance.ViewModelBuildingDevelop.UpdateDevelopInfo(data);
	}

	// Token: 0x0601520B RID: 86539 RVA: 0x00625D90 File Offset: 0x00623F90
	[NullableContext(1)]
	public void OpenDefenseChallengeResultView(TrapDefenseChallengeResultNotify data, bool needShowViewAnim)
	{
		TrapDefenseResultViewInfo param = new TrapDefenseResultViewInfo
		{
			Notify = data,
			NeedShowViewAnim = needShowViewAnim
		};
		AudioSystem.Instance.ExecuteAction("play_2_6_tower_defence_music_ingame", EAudioActionType.Stop, null);
		UiManager.Instance.OpenView(EUiViewName.TrapDefenseResultView, param, null);
	}

	// Token: 0x0601520C RID: 86540 RVA: 0x00625DDC File Offset: 0x00623FDC
	[NullableContext(2)]
	private void OnTrapDefenseChallengeResultNotify(IMessage msg, Net.CallbackStatus status)
	{
		TrapDefenseChallengeResultNotify trapDefenseChallengeResultNotify = (TrapDefenseChallengeResultNotify)msg;
		if (!this.IsActivityInited)
		{
			this.ResultNotifyCache = trapDefenseChallengeResultNotify;
			return;
		}
		this.OpenDefenseChallengeResultView(trapDefenseChallengeResultNotify, false);
	}

	// Token: 0x0601520D RID: 86541 RVA: 0x00625E08 File Offset: 0x00624008
	public void RequestTrapDefenseDevelopReset()
	{
		TrapDefenseDevelopResetRequest trapDefenseDevelopResetRequest = TrapDefenseDevelopResetRequest.Create();
		trapDefenseDevelopResetRequest.ActivityId = TrapDefenseModel.Instance.GetActivityId();
		Net.Instance.Call(ERequestMessageId.TrapDefenseDevelopResetRequest, trapDefenseDevelopResetRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TrapDefenseDevelopResetResponse trapDefenseDevelopResetResponse = (TrapDefenseDevelopResetResponse)msg;
			if (trapDefenseDevelopResetResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(trapDefenseDevelopResetResponse.ErrorCode, 24446, null, true, true);
				return;
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("TrapDefense_Building_Reset_Text", Array.Empty<object>());
			TrapDefenseModel.Instance.ViewModelBuildingDevelop.ResetAllOrgan();
			EventSystem.Instance.Emit(EEventName.TrapDefenseOnDevelopResetAll);
		}, 0);
	}

	// Token: 0x0601520E RID: 86542 RVA: 0x00625E5C File Offset: 0x0062405C
	public void RequestTrapDefenseDevelopLevelUp(int id)
	{
		ITrapDefenseMachineIdInfo trapDefenseMachineIdInfo = TrapDefenseModel.Instance.DecomposeMachineId(id);
		ITrapDefenseMachineIdInfo info = new ITrapDefenseMachineIdInfo
		{
			MachineType = trapDefenseMachineIdInfo.MachineType,
			DataType = trapDefenseMachineIdInfo.DataType,
			Level = trapDefenseMachineIdInfo.Level + 1,
			Branch = trapDefenseMachineIdInfo.Branch
		};
		int newId = TrapDefenseModel.Instance.ComposeMachineId(info);
		if (trapDefenseMachineIdInfo.MachineType == ETrapDefenseMachineType.Auxiliary)
		{
			this.RequestTrapDefenseAuxiliaryLevelUp(trapDefenseMachineIdInfo.DataType, newId);
			return;
		}
		this.RequestTrapDefenseBuildingLevelUp(trapDefenseMachineIdInfo.DataType, newId);
	}

	// Token: 0x0601520F RID: 86543 RVA: 0x00625EE0 File Offset: 0x006240E0
	private void RequestTrapDefenseBuildingLevelUp(int typeId, int newId)
	{
		TrapDefenseBuildingLevelUpRequest trapDefenseBuildingLevelUpRequest = TrapDefenseBuildingLevelUpRequest.Create();
		trapDefenseBuildingLevelUpRequest.Id = typeId;
		Net.Instance.Call(ERequestMessageId.TrapDefenseBuildingLevelUpRequest, trapDefenseBuildingLevelUpRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TrapDefenseBuildingLevelUpResponse trapDefenseBuildingLevelUpResponse = (TrapDefenseBuildingLevelUpResponse)msg;
			if (trapDefenseBuildingLevelUpResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(trapDefenseBuildingLevelUpResponse.ErrorCode, 21393, null, true, true);
				return;
			}
			TrapDefenseModel.Instance.ViewModelBuildingDevelop.OnItemUpdate(newId);
			ScrollingTipsController.Instance.ShowTipsByTextId("TowerDefense_Building_LevelUp", Array.Empty<object>());
		}, 0);
	}

	// Token: 0x06015210 RID: 86544 RVA: 0x00625F24 File Offset: 0x00624124
	private void RequestTrapDefenseAuxiliaryLevelUp(int typeId, int newId)
	{
		TrapDefenseAuxiliaryLevelUpRequest trapDefenseAuxiliaryLevelUpRequest = TrapDefenseAuxiliaryLevelUpRequest.Create();
		trapDefenseAuxiliaryLevelUpRequest.Id = typeId;
		Net.Instance.Call(ERequestMessageId.TrapDefenseAuxiliaryLevelUpRequest, trapDefenseAuxiliaryLevelUpRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TrapDefenseAuxiliaryLevelUpResponse trapDefenseAuxiliaryLevelUpResponse = (TrapDefenseAuxiliaryLevelUpResponse)msg;
			if (trapDefenseAuxiliaryLevelUpResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(trapDefenseAuxiliaryLevelUpResponse.ErrorCode, 24981, null, true, true);
				return;
			}
			TrapDefenseModel.Instance.ViewModelBuildingDevelop.OnItemUpdate(newId);
			ScrollingTipsController.Instance.ShowTipsByTextId("TowerDefense_Building_LevelUp", Array.Empty<object>());
		}, 0);
	}

	// Token: 0x06015211 RID: 86545 RVA: 0x00625F68 File Offset: 0x00624168
	public void RequestTrapDefenseDevelopResetOne(int id)
	{
		ITrapDefenseMachineIdInfo trapDefenseMachineIdInfo = TrapDefenseModel.Instance.DecomposeMachineId(id);
		ITrapDefenseMachineIdInfo info = new ITrapDefenseMachineIdInfo
		{
			MachineType = trapDefenseMachineIdInfo.MachineType,
			DataType = trapDefenseMachineIdInfo.DataType,
			Level = 1,
			Branch = 0
		};
		int newId = TrapDefenseModel.Instance.ComposeMachineId(info);
		if (trapDefenseMachineIdInfo.MachineType == ETrapDefenseMachineType.Auxiliary)
		{
			this.RequestTrapDefenseAuxiliaryReset(trapDefenseMachineIdInfo.DataType, newId);
			return;
		}
		this.RequestTrapDefenseBuildingReset(trapDefenseMachineIdInfo.DataType, newId);
	}

	// Token: 0x06015212 RID: 86546 RVA: 0x00625FE0 File Offset: 0x006241E0
	private void RequestTrapDefenseBuildingReset(int typeId, int newId)
	{
		TrapDefenseBuildingResetRequest trapDefenseBuildingResetRequest = TrapDefenseBuildingResetRequest.Create();
		trapDefenseBuildingResetRequest.Id = typeId;
		Net.Instance.Call(ERequestMessageId.TrapDefenseBuildingResetRequest, trapDefenseBuildingResetRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TrapDefenseBuildingResetResponse trapDefenseBuildingResetResponse = (TrapDefenseBuildingResetResponse)msg;
			if (trapDefenseBuildingResetResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(trapDefenseBuildingResetResponse.ErrorCode, 20421, null, true, true);
				return;
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("TrapDefense_Building_Reset_Text", Array.Empty<object>());
			TrapDefenseModel.Instance.ViewModelBuildingDevelop.OnItemUpdate(newId);
		}, 0);
	}

	// Token: 0x06015213 RID: 86547 RVA: 0x00626024 File Offset: 0x00624224
	private void RequestTrapDefenseAuxiliaryReset(int typeId, int newId)
	{
		TrapDefenseAuxiliaryResetRequest trapDefenseAuxiliaryResetRequest = TrapDefenseAuxiliaryResetRequest.Create();
		trapDefenseAuxiliaryResetRequest.Id = typeId;
		Net.Instance.Call(ERequestMessageId.TrapDefenseAuxiliaryResetRequest, trapDefenseAuxiliaryResetRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TrapDefenseAuxiliaryResetResponse trapDefenseAuxiliaryResetResponse = (TrapDefenseAuxiliaryResetResponse)msg;
			if (trapDefenseAuxiliaryResetResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(trapDefenseAuxiliaryResetResponse.ErrorCode, 29607, null, true, true);
				return;
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("TrapDefense_Building_Reset_Text", Array.Empty<object>());
			TrapDefenseModel.Instance.ViewModelBuildingDevelop.OnItemUpdate(newId);
		}, 0);
	}

	// Token: 0x06015214 RID: 86548 RVA: 0x00626068 File Offset: 0x00624268
	public UniTask<bool> RequestTrapDefenseDevelopBranch(int id)
	{
		TrapDefenseController.<RequestTrapDefenseDevelopBranch>d__22 <RequestTrapDefenseDevelopBranch>d__;
		<RequestTrapDefenseDevelopBranch>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestTrapDefenseDevelopBranch>d__.<>4__this = this;
		<RequestTrapDefenseDevelopBranch>d__.id = id;
		<RequestTrapDefenseDevelopBranch>d__.<>1__state = -1;
		<RequestTrapDefenseDevelopBranch>d__.<>t__builder.Start<TrapDefenseController.<RequestTrapDefenseDevelopBranch>d__22>(ref <RequestTrapDefenseDevelopBranch>d__);
		return <RequestTrapDefenseDevelopBranch>d__.<>t__builder.Task;
	}

	// Token: 0x06015215 RID: 86549 RVA: 0x006260B4 File Offset: 0x006242B4
	private UniTask<bool> RequestTrapDefenseBuildingBranch(int typeId, int branch, int newId)
	{
		TrapDefenseController.<RequestTrapDefenseBuildingBranch>d__23 <RequestTrapDefenseBuildingBranch>d__;
		<RequestTrapDefenseBuildingBranch>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestTrapDefenseBuildingBranch>d__.typeId = typeId;
		<RequestTrapDefenseBuildingBranch>d__.branch = branch;
		<RequestTrapDefenseBuildingBranch>d__.newId = newId;
		<RequestTrapDefenseBuildingBranch>d__.<>1__state = -1;
		<RequestTrapDefenseBuildingBranch>d__.<>t__builder.Start<TrapDefenseController.<RequestTrapDefenseBuildingBranch>d__23>(ref <RequestTrapDefenseBuildingBranch>d__);
		return <RequestTrapDefenseBuildingBranch>d__.<>t__builder.Task;
	}

	// Token: 0x06015216 RID: 86550 RVA: 0x00626108 File Offset: 0x00624308
	private UniTask<bool> RequestTrapDefenseAuxiliaryBranch(int typeId, int branch, int newId)
	{
		TrapDefenseController.<RequestTrapDefenseAuxiliaryBranch>d__24 <RequestTrapDefenseAuxiliaryBranch>d__;
		<RequestTrapDefenseAuxiliaryBranch>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestTrapDefenseAuxiliaryBranch>d__.typeId = typeId;
		<RequestTrapDefenseAuxiliaryBranch>d__.branch = branch;
		<RequestTrapDefenseAuxiliaryBranch>d__.newId = newId;
		<RequestTrapDefenseAuxiliaryBranch>d__.<>1__state = -1;
		<RequestTrapDefenseAuxiliaryBranch>d__.<>t__builder.Start<TrapDefenseController.<RequestTrapDefenseAuxiliaryBranch>d__24>(ref <RequestTrapDefenseAuxiliaryBranch>d__);
		return <RequestTrapDefenseAuxiliaryBranch>d__.<>t__builder.Task;
	}

	// Token: 0x06015217 RID: 86551 RVA: 0x0062615C File Offset: 0x0062435C
	[NullableContext(2)]
	private void OnMonsterConsecutiveKillsNotify(IMessage msg, Net.CallbackStatus status)
	{
		TrapDefenseMonsterConsecutiveKillsNotify trapDefenseMonsterConsecutiveKillsNotify = (TrapDefenseMonsterConsecutiveKillsNotify)msg;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.TowerDefenseBattle;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "怪物连击通知";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("连击数", trapDefenseMonsterConsecutiveKillsNotify.ConsecutiveKillCount);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		TrapDefenseModel.Instance.BattleData.SetComboNum(trapDefenseMonsterConsecutiveKillsNotify.ConsecutiveKillCount);
	}

	// Token: 0x06015218 RID: 86552 RVA: 0x006261BC File Offset: 0x006243BC
	[NullableContext(2)]
	private void OnSpawnMonsterWaveEndNotify(IMessage msg, Net.CallbackStatus status)
	{
		TrapDefenseSpawnMonsterWaveEndNotify trapDefenseSpawnMonsterWaveEndNotify = (TrapDefenseSpawnMonsterWaveEndNotify)msg;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.TowerDefenseBattle;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "怪物波次结束通知";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("倒计时", trapDefenseSpawnMonsterWaveEndNotify.CountdownSecond);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.StartRoundTips((float)trapDefenseSpawnMonsterWaveEndNotify.CountdownSecond);
	}

	// Token: 0x06015219 RID: 86553 RVA: 0x00626212 File Offset: 0x00624412
	public void OpenPauseView()
	{
		UiManager.Instance.OpenView(EUiViewName.TrapDefensePauseView, null, null);
	}

	// Token: 0x0601521A RID: 86554 RVA: 0x00626228 File Offset: 0x00624428
	[NullableContext(2)]
	public void OpenTrapDefenseShopOpenTips(Action callback = null)
	{
		TrapDefenseShopTipsData param = new TrapDefenseShopTipsData
		{
			Callback = callback
		};
		UiManager.Instance.OpenView(EUiViewName.TrapDefenseEventShopOpenTips, param, null);
	}

	// Token: 0x0601521B RID: 86555 RVA: 0x00626254 File Offset: 0x00624454
	public UniTask<bool> OpenTrapDefenseTerrainChangeTips([Nullable(2)] Action callback = null)
	{
		TrapDefenseController.<OpenTrapDefenseTerrainChangeTips>d__29 <OpenTrapDefenseTerrainChangeTips>d__;
		<OpenTrapDefenseTerrainChangeTips>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenTrapDefenseTerrainChangeTips>d__.callback = callback;
		<OpenTrapDefenseTerrainChangeTips>d__.<>1__state = -1;
		<OpenTrapDefenseTerrainChangeTips>d__.<>t__builder.Start<TrapDefenseController.<OpenTrapDefenseTerrainChangeTips>d__29>(ref <OpenTrapDefenseTerrainChangeTips>d__);
		return <OpenTrapDefenseTerrainChangeTips>d__.<>t__builder.Task;
	}

	// Token: 0x0601521C RID: 86556 RVA: 0x00626298 File Offset: 0x00624498
	public UniTask<bool> OpenTrapDefenseBossComingTips([Nullable(2)] Action callback = null)
	{
		TrapDefenseController.<OpenTrapDefenseBossComingTips>d__30 <OpenTrapDefenseBossComingTips>d__;
		<OpenTrapDefenseBossComingTips>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenTrapDefenseBossComingTips>d__.callback = callback;
		<OpenTrapDefenseBossComingTips>d__.<>1__state = -1;
		<OpenTrapDefenseBossComingTips>d__.<>t__builder.Start<TrapDefenseController.<OpenTrapDefenseBossComingTips>d__30>(ref <OpenTrapDefenseBossComingTips>d__);
		return <OpenTrapDefenseBossComingTips>d__.<>t__builder.Task;
	}

	// Token: 0x0601521D RID: 86557 RVA: 0x006262DC File Offset: 0x006244DC
	[NullableContext(2)]
	public void OpenTrapDefenseRoundTips(int round, Action callback = null)
	{
		TrapDefenseRoundTipsData param = new TrapDefenseRoundTipsData
		{
			Round = round,
			Callback = callback
		};
		UiManager.Instance.OpenView(EUiViewName.TrapDefenseRoundTips, param, null);
	}

	// Token: 0x0601521E RID: 86558 RVA: 0x00626310 File Offset: 0x00624510
	[NullableContext(2)]
	public void OpenTrapDefenseCountDownTips(float countDownTime, Action callback = null)
	{
		TrapDefenseCountDownTipsData param = new TrapDefenseCountDownTipsData
		{
			CountDownTime = countDownTime,
			Callback = callback
		};
		UiManager.Instance.OpenView(EUiViewName.TrapDefenseCountDownTips, param, null);
	}

	// Token: 0x0601521F RID: 86559 RVA: 0x00626344 File Offset: 0x00624544
	private UniTask StartChallengeCountDown(float countDownTime)
	{
		TrapDefenseController.<StartChallengeCountDown>d__33 <StartChallengeCountDown>d__;
		<StartChallengeCountDown>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<StartChallengeCountDown>d__.<>4__this = this;
		<StartChallengeCountDown>d__.countDownTime = countDownTime;
		<StartChallengeCountDown>d__.<>1__state = -1;
		<StartChallengeCountDown>d__.<>t__builder.Start<TrapDefenseController.<StartChallengeCountDown>d__33>(ref <StartChallengeCountDown>d__);
		return <StartChallengeCountDown>d__.<>t__builder.Task;
	}

	// Token: 0x06015220 RID: 86560 RVA: 0x00626390 File Offset: 0x00624590
	private UniTask StartChallengeBatchTips()
	{
		TrapDefenseController.<StartChallengeBatchTips>d__34 <StartChallengeBatchTips>d__;
		<StartChallengeBatchTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<StartChallengeBatchTips>d__.<>4__this = this;
		<StartChallengeBatchTips>d__.<>1__state = -1;
		<StartChallengeBatchTips>d__.<>t__builder.Start<TrapDefenseController.<StartChallengeBatchTips>d__34>(ref <StartChallengeBatchTips>d__);
		return <StartChallengeBatchTips>d__.<>t__builder.Task;
	}

	// Token: 0x06015221 RID: 86561 RVA: 0x006263D4 File Offset: 0x006245D4
	private UniTask StartRoundTips(float countDownTime)
	{
		TrapDefenseController.<StartRoundTips>d__35 <StartRoundTips>d__;
		<StartRoundTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<StartRoundTips>d__.<>4__this = this;
		<StartRoundTips>d__.countDownTime = countDownTime;
		<StartRoundTips>d__.<>1__state = -1;
		<StartRoundTips>d__.<>t__builder.Start<TrapDefenseController.<StartRoundTips>d__35>(ref <StartRoundTips>d__);
		return <StartRoundTips>d__.<>t__builder.Task;
	}

	// Token: 0x06015222 RID: 86562 RVA: 0x00626420 File Offset: 0x00624620
	public UniTask StartChallengeRoundTips()
	{
		TrapDefenseController.<StartChallengeRoundTips>d__36 <StartChallengeRoundTips>d__;
		<StartChallengeRoundTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<StartChallengeRoundTips>d__.<>4__this = this;
		<StartChallengeRoundTips>d__.<>1__state = -1;
		<StartChallengeRoundTips>d__.<>t__builder.Start<TrapDefenseController.<StartChallengeRoundTips>d__36>(ref <StartChallengeRoundTips>d__);
		return <StartChallengeRoundTips>d__.<>t__builder.Task;
	}

	// Token: 0x06015223 RID: 86563 RVA: 0x00626464 File Offset: 0x00624664
	public void RefreshTrapDefenseMainView()
	{
		UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.CommonGameMainView);
		if (viewByName != null)
		{
			TrapDefenseMainViewProxy trapDefenseMainViewProxy = viewByName.OpenParam as TrapDefenseMainViewProxy;
			if (trapDefenseMainViewProxy == null)
			{
				return;
			}
			trapDefenseMainViewProxy.RefreshSelectPanel();
		}
	}

	// Token: 0x06015224 RID: 86564 RVA: 0x0062649C File Offset: 0x0062469C
	[NullableContext(2)]
	private void OnTrapDefenseSystemInfoNotify(IMessage msg, Net.CallbackStatus status)
	{
		TrapDefenseSystemInfoNotify trapDefenseSystemInfoNotify = (TrapDefenseSystemInfoNotify)msg;
		TrapDefenseModel instance = TrapDefenseModel.Instance;
		if (instance != null)
		{
			instance.BattleData.SetBehaviorTreeVar(new Dictionary<string, string>(trapDefenseSystemInfoNotify.VariableKeyNames));
		}
		TrapDefenseModel instance2 = TrapDefenseModel.Instance;
		if (instance2 != null)
		{
			instance2.BattleData.SetTechParamMapVar((trapDefenseSystemInfoNotify.TechParams == null) ? null : new Dictionary<int, int>(trapDefenseSystemInfoNotify.TechParams.Params));
		}
		TrapDefenseModel instance3 = TrapDefenseModel.Instance;
		if (instance3 != null)
		{
			instance3.ViewModelBuildingDevelop.InitInBattle(trapDefenseSystemInfoNotify);
		}
		TrapDefenseModel instance4 = TrapDefenseModel.Instance;
		if (instance4 != null)
		{
			instance4.BattleInventoryData.UpdateItemData(trapDefenseSystemInfoNotify.ItemDatas);
		}
		if (trapDefenseSystemInfoNotify.ChangedMiniMap != 0)
		{
			this.ChangeMap(trapDefenseSystemInfoNotify.ChangedMiniMap);
		}
		EventSystem.Instance.Emit(EEventName.TrapDefenseOnSystemInfoNotify);
	}

	// Token: 0x06015225 RID: 86565 RVA: 0x00626558 File Offset: 0x00624758
	public UniTask<bool> RequestBdBuffSelect(int id)
	{
		TrapDefenseController.<RequestBdBuffSelect>d__39 <RequestBdBuffSelect>d__;
		<RequestBdBuffSelect>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestBdBuffSelect>d__.id = id;
		<RequestBdBuffSelect>d__.<>1__state = -1;
		<RequestBdBuffSelect>d__.<>t__builder.Start<TrapDefenseController.<RequestBdBuffSelect>d__39>(ref <RequestBdBuffSelect>d__);
		return <RequestBdBuffSelect>d__.<>t__builder.Task;
	}

	// Token: 0x06015226 RID: 86566 RVA: 0x0062659C File Offset: 0x0062479C
	public UniTask<bool> RequestBdBuffRefresh()
	{
		TrapDefenseController.<RequestBdBuffRefresh>d__40 <RequestBdBuffRefresh>d__;
		<RequestBdBuffRefresh>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestBdBuffRefresh>d__.<>1__state = -1;
		<RequestBdBuffRefresh>d__.<>t__builder.Start<TrapDefenseController.<RequestBdBuffRefresh>d__40>(ref <RequestBdBuffRefresh>d__);
		return <RequestBdBuffRefresh>d__.<>t__builder.Task;
	}

	// Token: 0x06015227 RID: 86567 RVA: 0x006265D8 File Offset: 0x006247D8
	public UniTask<bool> RequestChallenge([Nullable(1)] TrapDefenseLevelData data, bool fromSaveStar = false)
	{
		TrapDefenseController.<RequestChallenge>d__41 <RequestChallenge>d__;
		<RequestChallenge>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestChallenge>d__.data = data;
		<RequestChallenge>d__.fromSaveStar = fromSaveStar;
		<RequestChallenge>d__.<>1__state = -1;
		<RequestChallenge>d__.<>t__builder.Start<TrapDefenseController.<RequestChallenge>d__41>(ref <RequestChallenge>d__);
		return <RequestChallenge>d__.<>t__builder.Task;
	}

	// Token: 0x06015228 RID: 86568 RVA: 0x00626624 File Offset: 0x00624824
	public UniTask<bool> RequestTrapDefenseChallengeQuit(bool needSettle)
	{
		TrapDefenseController.<RequestTrapDefenseChallengeQuit>d__42 <RequestTrapDefenseChallengeQuit>d__;
		<RequestTrapDefenseChallengeQuit>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestTrapDefenseChallengeQuit>d__.needSettle = needSettle;
		<RequestTrapDefenseChallengeQuit>d__.<>1__state = -1;
		<RequestTrapDefenseChallengeQuit>d__.<>t__builder.Start<TrapDefenseController.<RequestTrapDefenseChallengeQuit>d__42>(ref <RequestTrapDefenseChallengeQuit>d__);
		return <RequestTrapDefenseChallengeQuit>d__.<>t__builder.Task;
	}

	// Token: 0x06015229 RID: 86569 RVA: 0x00626668 File Offset: 0x00624868
	public UniTask<bool> RequestTrapDefenseSlotUpdate([Nullable(1)] List<TrapDefenseSlot> slotList)
	{
		TrapDefenseController.<RequestTrapDefenseSlotUpdate>d__43 <RequestTrapDefenseSlotUpdate>d__;
		<RequestTrapDefenseSlotUpdate>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestTrapDefenseSlotUpdate>d__.slotList = slotList;
		<RequestTrapDefenseSlotUpdate>d__.<>1__state = -1;
		<RequestTrapDefenseSlotUpdate>d__.<>t__builder.Start<TrapDefenseController.<RequestTrapDefenseSlotUpdate>d__43>(ref <RequestTrapDefenseSlotUpdate>d__);
		return <RequestTrapDefenseSlotUpdate>d__.<>t__builder.Task;
	}

	// Token: 0x0601522A RID: 86570 RVA: 0x006266AC File Offset: 0x006248AC
	public UniTask<int> RequestTrapDefenseCurChallengeInfo()
	{
		TrapDefenseController.<RequestTrapDefenseCurChallengeInfo>d__44 <RequestTrapDefenseCurChallengeInfo>d__;
		<RequestTrapDefenseCurChallengeInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder<int>.Create();
		<RequestTrapDefenseCurChallengeInfo>d__.<>1__state = -1;
		<RequestTrapDefenseCurChallengeInfo>d__.<>t__builder.Start<TrapDefenseController.<RequestTrapDefenseCurChallengeInfo>d__44>(ref <RequestTrapDefenseCurChallengeInfo>d__);
		return <RequestTrapDefenseCurChallengeInfo>d__.<>t__builder.Task;
	}

	// Token: 0x0601522B RID: 86571 RVA: 0x006266E8 File Offset: 0x006248E8
	[NullableContext(2)]
	private void OnTrapDefenseSystemInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		RepeatedField<TrapDefenseSlot> slots = ((TrapDefenseSystemInfoUpdateNotify)msg).Slots;
		TrapDefenseModel.Instance.ViewModelBuildingDevelop.UploadSlotChangeByNotify(new List<TrapDefenseSlot>(slots));
	}

	// Token: 0x0601522C RID: 86572 RVA: 0x00626718 File Offset: 0x00624918
	public UniTask<bool> RequestTrapDefenseRewardClaim([Nullable(1)] IReadOnlyList<int> ids)
	{
		TrapDefenseController.<RequestTrapDefenseRewardClaim>d__46 <RequestTrapDefenseRewardClaim>d__;
		<RequestTrapDefenseRewardClaim>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestTrapDefenseRewardClaim>d__.ids = ids;
		<RequestTrapDefenseRewardClaim>d__.<>1__state = -1;
		<RequestTrapDefenseRewardClaim>d__.<>t__builder.Start<TrapDefenseController.<RequestTrapDefenseRewardClaim>d__46>(ref <RequestTrapDefenseRewardClaim>d__);
		return <RequestTrapDefenseRewardClaim>d__.<>t__builder.Task;
	}

	// Token: 0x0601522D RID: 86573 RVA: 0x0062675C File Offset: 0x0062495C
	public UniTask<bool> RequestTrapDefenseSpecialRewardClaim(int id)
	{
		TrapDefenseController.<RequestTrapDefenseSpecialRewardClaim>d__47 <RequestTrapDefenseSpecialRewardClaim>d__;
		<RequestTrapDefenseSpecialRewardClaim>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestTrapDefenseSpecialRewardClaim>d__.id = id;
		<RequestTrapDefenseSpecialRewardClaim>d__.<>1__state = -1;
		<RequestTrapDefenseSpecialRewardClaim>d__.<>t__builder.Start<TrapDefenseController.<RequestTrapDefenseSpecialRewardClaim>d__47>(ref <RequestTrapDefenseSpecialRewardClaim>d__);
		return <RequestTrapDefenseSpecialRewardClaim>d__.<>t__builder.Task;
	}

	// Token: 0x0601522E RID: 86574 RVA: 0x006267A0 File Offset: 0x006249A0
	public UniTask<bool> RequestTrapDefenseTechUnlock(int id)
	{
		TrapDefenseController.<RequestTrapDefenseTechUnlock>d__48 <RequestTrapDefenseTechUnlock>d__;
		<RequestTrapDefenseTechUnlock>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestTrapDefenseTechUnlock>d__.id = id;
		<RequestTrapDefenseTechUnlock>d__.<>1__state = -1;
		<RequestTrapDefenseTechUnlock>d__.<>t__builder.Start<TrapDefenseController.<RequestTrapDefenseTechUnlock>d__48>(ref <RequestTrapDefenseTechUnlock>d__);
		return <RequestTrapDefenseTechUnlock>d__.<>t__builder.Task;
	}

	// Token: 0x0601522F RID: 86575 RVA: 0x006267E4 File Offset: 0x006249E4
	public UniTask<bool> RequestTrapDefenseShopRefresh()
	{
		TrapDefenseController.<RequestTrapDefenseShopRefresh>d__49 <RequestTrapDefenseShopRefresh>d__;
		<RequestTrapDefenseShopRefresh>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestTrapDefenseShopRefresh>d__.<>1__state = -1;
		<RequestTrapDefenseShopRefresh>d__.<>t__builder.Start<TrapDefenseController.<RequestTrapDefenseShopRefresh>d__49>(ref <RequestTrapDefenseShopRefresh>d__);
		return <RequestTrapDefenseShopRefresh>d__.<>t__builder.Task;
	}

	// Token: 0x06015230 RID: 86576 RVA: 0x00626820 File Offset: 0x00624A20
	public UniTask<bool> RequestTrapDefenseShopPurchase(int id, ETrapDefenseShopGoodsType type, int count = 1)
	{
		TrapDefenseController.<RequestTrapDefenseShopPurchase>d__50 <RequestTrapDefenseShopPurchase>d__;
		<RequestTrapDefenseShopPurchase>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestTrapDefenseShopPurchase>d__.id = id;
		<RequestTrapDefenseShopPurchase>d__.type = type;
		<RequestTrapDefenseShopPurchase>d__.count = count;
		<RequestTrapDefenseShopPurchase>d__.<>1__state = -1;
		<RequestTrapDefenseShopPurchase>d__.<>t__builder.Start<TrapDefenseController.<RequestTrapDefenseShopPurchase>d__50>(ref <RequestTrapDefenseShopPurchase>d__);
		return <RequestTrapDefenseShopPurchase>d__.<>t__builder.Task;
	}

	// Token: 0x06015231 RID: 86577 RVA: 0x00626874 File Offset: 0x00624A74
	public void UpdateEnemyPositions()
	{
		FKSC_MiniMapContext[] entityPositions = KuroSimpleCombatController.Instance.GetEntityPositions();
		if (entityPositions == null)
		{
			return;
		}
		TrapDefenseModel.Instance.MapData.UpdateEnemyPositions(new List<FKSC_MiniMapContext>(entityPositions));
	}

	// Token: 0x06015232 RID: 86578 RVA: 0x006268A5 File Offset: 0x00624AA5
	public void ChangeMap(int mapId)
	{
		TrapDefenseModel.Instance.MapData.ChangeMap(mapId);
		EventSystem.Instance.Emit<int>(EEventName.TrapDefenseMapChanged, mapId);
	}

	// Token: 0x06015233 RID: 86579 RVA: 0x006268C8 File Offset: 0x00624AC8
	private void OnInstanceChange(int lastInstanceId, int newInstanceId)
	{
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(newInstanceId);
		if (config != null && config.Value.InstSubType == 37)
		{
			SkillButtonUiController.Instance.AddEventInterface(TrapDefenseModel.Instance.BattleData);
			return;
		}
		SkillButtonUiController.Instance.RemoveEventInterface(TrapDefenseModel.Instance.BattleData);
	}

	// Token: 0x06015234 RID: 86580 RVA: 0x00626926 File Offset: 0x00624B26
	private void OnTrapDefenseInventoryDataUpdate()
	{
		TrapDefenseModel.Instance.BattleData.RefreshExploreSkillData();
	}

	// Token: 0x1700200B RID: 8203
	// (get) Token: 0x06015235 RID: 86581 RVA: 0x00626937 File Offset: 0x00624B37
	[Nullable(1)]
	public static TrapDefenseController Instance
	{
		[NullableContext(1)]
		get
		{
			return TrapDefenseController._Instance;
		}
	}

	// Token: 0x06015236 RID: 86582 RVA: 0x0062693E File Offset: 0x00624B3E
	[NullableContext(1)]
	public static TrapDefenseController GetOrCreateInstance()
	{
		if (TrapDefenseController._Instance == null)
		{
			TrapDefenseController.CreateInstance();
		}
		return TrapDefenseController._Instance;
	}

	// Token: 0x06015237 RID: 86583 RVA: 0x00626952 File Offset: 0x00624B52
	public static bool CreateInstance()
	{
		if (TrapDefenseController._Instance != null)
		{
			return true;
		}
		TrapDefenseController._Instance = new TrapDefenseController();
		return true;
	}

	// Token: 0x06015238 RID: 86584 RVA: 0x00626968 File Offset: 0x00624B68
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015239 RID: 86585 RVA: 0x0062696A File Offset: 0x00624B6A
	public static void ResetStaticDefaultValue()
	{
		TrapDefenseController._Instance = null;
	}

	// Token: 0x0601523A RID: 86586 RVA: 0x00626972 File Offset: 0x00624B72
	static TrapDefenseController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TrapDefenseController.CreateStaticDefaultValue), new Action(TrapDefenseController.ResetStaticDefaultValue));
	}

	// Token: 0x0400B379 RID: 45945
	[Nullable(2)]
	public TrapDefenseChallengeResultNotify ResultNotifyCache;

	// Token: 0x0400B37A RID: 45946
	public bool IsActivityInited;

	// Token: 0x0400B37B RID: 45947
	[Nullable(2)]
	private static TrapDefenseController _Instance;
}
