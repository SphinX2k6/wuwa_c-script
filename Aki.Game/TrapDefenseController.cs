using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02002C19 RID: 11289
[Controller(0)]
public class TrapDefenseController : UiControllerBase
{
	// Token: 0x060177CE RID: 96206 RVA: 0x005F8FA8 File Offset: 0x005F71A8
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

	// Token: 0x060177CF RID: 96207 RVA: 0x005F9106 File Offset: 0x005F7306
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.TrapDefenseBuildingDevelopMainView, new Func<EUiViewName, object, bool>(this.CanOpenDevelopView), "TrapDefenseController.CanOpenDevelopView");
	}

	// Token: 0x060177D0 RID: 96208 RVA: 0x005F9128 File Offset: 0x005F7328
	protected override void OnRemoveOpenViewCheckFunction()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.TrapDefenseBuildingDevelopMainView, new Func<EUiViewName, object, bool>(this.CanOpenDevelopView));
	}

	// Token: 0x060177D1 RID: 96209 RVA: 0x005F9148 File Offset: 0x005F7348
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

	// Token: 0x060177D2 RID: 96210 RVA: 0x005F91E5 File Offset: 0x005F73E5
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnInstanceChange, new Action<int, int>(this.OnInstanceChange));
		EventSystem.Instance.Add(EEventName.TrapDefenseInventoryDataUpdate, new Action(this.OnTrapDefenseInventoryDataUpdate));
	}

	// Token: 0x060177D3 RID: 96211 RVA: 0x005F921F File Offset: 0x005F741F
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.OnInstanceChange, new Action<int, int>(this.OnInstanceChange));
		EventSystem.Instance.Remove(EEventName.TrapDefenseInventoryDataUpdate, new Action(this.OnTrapDefenseInventoryDataUpdate));
	}

	// Token: 0x060177D4 RID: 96212 RVA: 0x005F925C File Offset: 0x005F745C
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(trapDefenseUseItemResponse.ErrorCode, 27014, null, true, true);
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

	// Token: 0x060177D5 RID: 96213 RVA: 0x005F92A8 File Offset: 0x005F74A8
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

	// Token: 0x060177D6 RID: 96214 RVA: 0x005F92D6 File Offset: 0x005F74D6
	[NullableContext(2)]
	private bool CanOpenDevelopView(EUiViewName viewName, object param)
	{
		return !((ITrapDefenseDevelopOpenParam)param).IsInDungeon || TrapDefenseModel.Instance.BattleData.IsCanBuildMachine;
	}

	// Token: 0x060177D7 RID: 96215 RVA: 0x005F92F8 File Offset: 0x005F74F8
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

	// Token: 0x060177D8 RID: 96216 RVA: 0x005F934C File Offset: 0x005F754C
	[NullableContext(2)]
	private void OnTrapDefenseDevelopInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		TrapDefenseDevelopInfoUpdateNotify data = (TrapDefenseDevelopInfoUpdateNotify)msg;
		TrapDefenseModel.Instance.ViewModelBuildingDevelop.UpdateDevelopInfo(data);
	}

	// Token: 0x060177D9 RID: 96217 RVA: 0x005F9370 File Offset: 0x005F7570
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

	// Token: 0x060177DA RID: 96218 RVA: 0x005F93BC File Offset: 0x005F75BC
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

	// Token: 0x060177DB RID: 96219 RVA: 0x005F93E8 File Offset: 0x005F75E8
	public void RequestTrapDefenseDevelopReset()
	{
		TrapDefenseDevelopResetRequest trapDefenseDevelopResetRequest = TrapDefenseDevelopResetRequest.Create();
		trapDefenseDevelopResetRequest.ActivityId = TrapDefenseModel.Instance.GetActivityId();
		Net.Instance.Call(ERequestMessageId.TrapDefenseDevelopResetRequest, trapDefenseDevelopResetRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TrapDefenseDevelopResetResponse trapDefenseDevelopResetResponse = (TrapDefenseDevelopResetResponse)msg;
			if (trapDefenseDevelopResetResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(trapDefenseDevelopResetResponse.ErrorCode, 17328, null, true, true);
				return;
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("TrapDefense_Building_Reset_Text", Array.Empty<object>());
			TrapDefenseModel.Instance.ViewModelBuildingDevelop.ResetAllOrgan();
			EventSystem.Instance.Emit(EEventName.TrapDefenseOnDevelopResetAll);
		}, 0);
	}

	// Token: 0x060177DC RID: 96220 RVA: 0x005F943C File Offset: 0x005F763C
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

	// Token: 0x060177DD RID: 96221 RVA: 0x005F94C0 File Offset: 0x005F76C0
	private void RequestTrapDefenseBuildingLevelUp(int typeId, int newId)
	{
		TrapDefenseBuildingLevelUpRequest trapDefenseBuildingLevelUpRequest = TrapDefenseBuildingLevelUpRequest.Create();
		trapDefenseBuildingLevelUpRequest.Id = typeId;
		Net.Instance.Call(ERequestMessageId.TrapDefenseBuildingLevelUpRequest, trapDefenseBuildingLevelUpRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TrapDefenseBuildingLevelUpResponse trapDefenseBuildingLevelUpResponse = (TrapDefenseBuildingLevelUpResponse)msg;
			if (trapDefenseBuildingLevelUpResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(trapDefenseBuildingLevelUpResponse.ErrorCode, 28185, null, true, true);
				return;
			}
			TrapDefenseModel.Instance.ViewModelBuildingDevelop.OnItemUpdate(newId);
			ScrollingTipsController.Instance.ShowTipsByTextId("TowerDefense_Building_LevelUp", Array.Empty<object>());
		}, 0);
	}

	// Token: 0x060177DE RID: 96222 RVA: 0x005F9504 File Offset: 0x005F7704
	private void RequestTrapDefenseAuxiliaryLevelUp(int typeId, int newId)
	{
		TrapDefenseAuxiliaryLevelUpRequest trapDefenseAuxiliaryLevelUpRequest = TrapDefenseAuxiliaryLevelUpRequest.Create();
		trapDefenseAuxiliaryLevelUpRequest.Id = typeId;
		Net.Instance.Call(ERequestMessageId.TrapDefenseAuxiliaryLevelUpRequest, trapDefenseAuxiliaryLevelUpRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TrapDefenseAuxiliaryLevelUpResponse trapDefenseAuxiliaryLevelUpResponse = (TrapDefenseAuxiliaryLevelUpResponse)msg;
			if (trapDefenseAuxiliaryLevelUpResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(trapDefenseAuxiliaryLevelUpResponse.ErrorCode, 18673, null, true, true);
				return;
			}
			TrapDefenseModel.Instance.ViewModelBuildingDevelop.OnItemUpdate(newId);
			ScrollingTipsController.Instance.ShowTipsByTextId("TowerDefense_Building_LevelUp", Array.Empty<object>());
		}, 0);
	}

	// Token: 0x060177DF RID: 96223 RVA: 0x005F9548 File Offset: 0x005F7748
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

	// Token: 0x060177E0 RID: 96224 RVA: 0x005F95C0 File Offset: 0x005F77C0
	private void RequestTrapDefenseBuildingReset(int typeId, int newId)
	{
		TrapDefenseBuildingResetRequest trapDefenseBuildingResetRequest = TrapDefenseBuildingResetRequest.Create();
		trapDefenseBuildingResetRequest.Id = typeId;
		Net.Instance.Call(ERequestMessageId.TrapDefenseBuildingResetRequest, trapDefenseBuildingResetRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TrapDefenseBuildingResetResponse trapDefenseBuildingResetResponse = (TrapDefenseBuildingResetResponse)msg;
			if (trapDefenseBuildingResetResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(trapDefenseBuildingResetResponse.ErrorCode, 18053, null, true, true);
				return;
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("TrapDefense_Building_Reset_Text", Array.Empty<object>());
			TrapDefenseModel.Instance.ViewModelBuildingDevelop.OnItemUpdate(newId);
		}, 0);
	}

	// Token: 0x060177E1 RID: 96225 RVA: 0x005F9604 File Offset: 0x005F7804
	private void RequestTrapDefenseAuxiliaryReset(int typeId, int newId)
	{
		TrapDefenseAuxiliaryResetRequest trapDefenseAuxiliaryResetRequest = TrapDefenseAuxiliaryResetRequest.Create();
		trapDefenseAuxiliaryResetRequest.Id = typeId;
		Net.Instance.Call(ERequestMessageId.TrapDefenseAuxiliaryResetRequest, trapDefenseAuxiliaryResetRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TrapDefenseAuxiliaryResetResponse trapDefenseAuxiliaryResetResponse = (TrapDefenseAuxiliaryResetResponse)msg;
			if (trapDefenseAuxiliaryResetResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(trapDefenseAuxiliaryResetResponse.ErrorCode, 26880, null, true, true);
				return;
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("TrapDefense_Building_Reset_Text", Array.Empty<object>());
			TrapDefenseModel.Instance.ViewModelBuildingDevelop.OnItemUpdate(newId);
		}, 0);
	}

	// Token: 0x060177E2 RID: 96226 RVA: 0x005F9648 File Offset: 0x005F7848
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

	// Token: 0x060177E3 RID: 96227 RVA: 0x005F9694 File Offset: 0x005F7894
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

	// Token: 0x060177E4 RID: 96228 RVA: 0x005F96E8 File Offset: 0x005F78E8
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

	// Token: 0x060177E5 RID: 96229 RVA: 0x005F973C File Offset: 0x005F793C
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

	// Token: 0x060177E6 RID: 96230 RVA: 0x005F979C File Offset: 0x005F799C
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

	// Token: 0x060177E7 RID: 96231 RVA: 0x005F97F2 File Offset: 0x005F79F2
	public void OpenPauseView()
	{
		UiManager.Instance.OpenView(EUiViewName.TrapDefensePauseView, null, null);
	}

	// Token: 0x060177E8 RID: 96232 RVA: 0x005F9808 File Offset: 0x005F7A08
	[NullableContext(2)]
	public void OpenTrapDefenseShopOpenTips(Action callback = null)
	{
		TrapDefenseShopTipsData param = new TrapDefenseShopTipsData
		{
			Callback = callback
		};
		UiManager.Instance.OpenView(EUiViewName.TrapDefenseEventShopOpenTips, param, null);
	}

	// Token: 0x060177E9 RID: 96233 RVA: 0x005F9834 File Offset: 0x005F7A34
	public UniTask<bool> OpenTrapDefenseTerrainChangeTips([Nullable(2)] Action callback = null)
	{
		TrapDefenseController.<OpenTrapDefenseTerrainChangeTips>d__29 <OpenTrapDefenseTerrainChangeTips>d__;
		<OpenTrapDefenseTerrainChangeTips>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenTrapDefenseTerrainChangeTips>d__.callback = callback;
		<OpenTrapDefenseTerrainChangeTips>d__.<>1__state = -1;
		<OpenTrapDefenseTerrainChangeTips>d__.<>t__builder.Start<TrapDefenseController.<OpenTrapDefenseTerrainChangeTips>d__29>(ref <OpenTrapDefenseTerrainChangeTips>d__);
		return <OpenTrapDefenseTerrainChangeTips>d__.<>t__builder.Task;
	}

	// Token: 0x060177EA RID: 96234 RVA: 0x005F9878 File Offset: 0x005F7A78
	public UniTask<bool> OpenTrapDefenseBossComingTips([Nullable(2)] Action callback = null)
	{
		TrapDefenseController.<OpenTrapDefenseBossComingTips>d__30 <OpenTrapDefenseBossComingTips>d__;
		<OpenTrapDefenseBossComingTips>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenTrapDefenseBossComingTips>d__.callback = callback;
		<OpenTrapDefenseBossComingTips>d__.<>1__state = -1;
		<OpenTrapDefenseBossComingTips>d__.<>t__builder.Start<TrapDefenseController.<OpenTrapDefenseBossComingTips>d__30>(ref <OpenTrapDefenseBossComingTips>d__);
		return <OpenTrapDefenseBossComingTips>d__.<>t__builder.Task;
	}

	// Token: 0x060177EB RID: 96235 RVA: 0x005F98BC File Offset: 0x005F7ABC
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

	// Token: 0x060177EC RID: 96236 RVA: 0x005F98F0 File Offset: 0x005F7AF0
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

	// Token: 0x060177ED RID: 96237 RVA: 0x005F9924 File Offset: 0x005F7B24
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

	// Token: 0x060177EE RID: 96238 RVA: 0x005F9970 File Offset: 0x005F7B70
	private UniTask StartChallengeBatchTips()
	{
		TrapDefenseController.<StartChallengeBatchTips>d__34 <StartChallengeBatchTips>d__;
		<StartChallengeBatchTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<StartChallengeBatchTips>d__.<>4__this = this;
		<StartChallengeBatchTips>d__.<>1__state = -1;
		<StartChallengeBatchTips>d__.<>t__builder.Start<TrapDefenseController.<StartChallengeBatchTips>d__34>(ref <StartChallengeBatchTips>d__);
		return <StartChallengeBatchTips>d__.<>t__builder.Task;
	}

	// Token: 0x060177EF RID: 96239 RVA: 0x005F99B4 File Offset: 0x005F7BB4
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

	// Token: 0x060177F0 RID: 96240 RVA: 0x005F9A00 File Offset: 0x005F7C00
	public UniTask StartChallengeRoundTips()
	{
		TrapDefenseController.<StartChallengeRoundTips>d__36 <StartChallengeRoundTips>d__;
		<StartChallengeRoundTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<StartChallengeRoundTips>d__.<>4__this = this;
		<StartChallengeRoundTips>d__.<>1__state = -1;
		<StartChallengeRoundTips>d__.<>t__builder.Start<TrapDefenseController.<StartChallengeRoundTips>d__36>(ref <StartChallengeRoundTips>d__);
		return <StartChallengeRoundTips>d__.<>t__builder.Task;
	}

	// Token: 0x060177F1 RID: 96241 RVA: 0x005F9A44 File Offset: 0x005F7C44
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

	// Token: 0x060177F2 RID: 96242 RVA: 0x005F9A7C File Offset: 0x005F7C7C
	[NullableContext(2)]
	private void OnTrapDefenseSystemInfoNotify(IMessage msg, Net.CallbackStatus status)
	{
		TrapDefenseSystemInfoNotify trapDefenseSystemInfoNotify = (TrapDefenseSystemInfoNotify)msg;
		TrapDefenseModel instance = TrapDefenseModel.Instance;
		if (instance != null)
		{
			instance.BattleData.SetBehaviorTreeVar(trapDefenseSystemInfoNotify.VariableKeyNames.ToDictionary<string, string>());
		}
		TrapDefenseModel instance2 = TrapDefenseModel.Instance;
		if (instance2 != null)
		{
			TrapDefenseBattleData battleData = instance2.BattleData;
			TrapDefenseTechParam techParams = trapDefenseSystemInfoNotify.TechParams;
			battleData.SetTechParamMapVar((techParams != null) ? techParams.Params.ToDictionary<int, int>() : null);
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

	// Token: 0x060177F3 RID: 96243 RVA: 0x005F9B34 File Offset: 0x005F7D34
	public UniTask<bool> RequestBdBuffSelect(int id)
	{
		TrapDefenseController.<RequestBdBuffSelect>d__39 <RequestBdBuffSelect>d__;
		<RequestBdBuffSelect>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestBdBuffSelect>d__.id = id;
		<RequestBdBuffSelect>d__.<>1__state = -1;
		<RequestBdBuffSelect>d__.<>t__builder.Start<TrapDefenseController.<RequestBdBuffSelect>d__39>(ref <RequestBdBuffSelect>d__);
		return <RequestBdBuffSelect>d__.<>t__builder.Task;
	}

	// Token: 0x060177F4 RID: 96244 RVA: 0x005F9B78 File Offset: 0x005F7D78
	public UniTask<bool> RequestBdBuffRefresh()
	{
		TrapDefenseController.<RequestBdBuffRefresh>d__40 <RequestBdBuffRefresh>d__;
		<RequestBdBuffRefresh>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestBdBuffRefresh>d__.<>1__state = -1;
		<RequestBdBuffRefresh>d__.<>t__builder.Start<TrapDefenseController.<RequestBdBuffRefresh>d__40>(ref <RequestBdBuffRefresh>d__);
		return <RequestBdBuffRefresh>d__.<>t__builder.Task;
	}

	// Token: 0x060177F5 RID: 96245 RVA: 0x005F9BB4 File Offset: 0x005F7DB4
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

	// Token: 0x060177F6 RID: 96246 RVA: 0x005F9C00 File Offset: 0x005F7E00
	public UniTask<bool> RequestTrapDefenseChallengeQuit(bool needSettle)
	{
		TrapDefenseController.<RequestTrapDefenseChallengeQuit>d__42 <RequestTrapDefenseChallengeQuit>d__;
		<RequestTrapDefenseChallengeQuit>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestTrapDefenseChallengeQuit>d__.needSettle = needSettle;
		<RequestTrapDefenseChallengeQuit>d__.<>1__state = -1;
		<RequestTrapDefenseChallengeQuit>d__.<>t__builder.Start<TrapDefenseController.<RequestTrapDefenseChallengeQuit>d__42>(ref <RequestTrapDefenseChallengeQuit>d__);
		return <RequestTrapDefenseChallengeQuit>d__.<>t__builder.Task;
	}

	// Token: 0x060177F7 RID: 96247 RVA: 0x005F9C44 File Offset: 0x005F7E44
	public UniTask<bool> RequestTrapDefenseSlotUpdate([Nullable(1)] List<TrapDefenseSlot> slotList)
	{
		TrapDefenseController.<RequestTrapDefenseSlotUpdate>d__43 <RequestTrapDefenseSlotUpdate>d__;
		<RequestTrapDefenseSlotUpdate>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestTrapDefenseSlotUpdate>d__.slotList = slotList;
		<RequestTrapDefenseSlotUpdate>d__.<>1__state = -1;
		<RequestTrapDefenseSlotUpdate>d__.<>t__builder.Start<TrapDefenseController.<RequestTrapDefenseSlotUpdate>d__43>(ref <RequestTrapDefenseSlotUpdate>d__);
		return <RequestTrapDefenseSlotUpdate>d__.<>t__builder.Task;
	}

	// Token: 0x060177F8 RID: 96248 RVA: 0x005F9C88 File Offset: 0x005F7E88
	public UniTask<int> RequestTrapDefenseCurChallengeInfo()
	{
		TrapDefenseController.<RequestTrapDefenseCurChallengeInfo>d__44 <RequestTrapDefenseCurChallengeInfo>d__;
		<RequestTrapDefenseCurChallengeInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder<int>.Create();
		<RequestTrapDefenseCurChallengeInfo>d__.<>1__state = -1;
		<RequestTrapDefenseCurChallengeInfo>d__.<>t__builder.Start<TrapDefenseController.<RequestTrapDefenseCurChallengeInfo>d__44>(ref <RequestTrapDefenseCurChallengeInfo>d__);
		return <RequestTrapDefenseCurChallengeInfo>d__.<>t__builder.Task;
	}

	// Token: 0x060177F9 RID: 96249 RVA: 0x005F9CC4 File Offset: 0x005F7EC4
	[NullableContext(2)]
	private void OnTrapDefenseSystemInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		RepeatedField<TrapDefenseSlot> slots = ((TrapDefenseSystemInfoUpdateNotify)msg).Slots;
		TrapDefenseModel.Instance.ViewModelBuildingDevelop.UploadSlotChangeByNotify(new List<TrapDefenseSlot>(slots));
	}

	// Token: 0x060177FA RID: 96250 RVA: 0x005F9CF4 File Offset: 0x005F7EF4
	public UniTask<bool> RequestTrapDefenseRewardClaim([Nullable(1)] IReadOnlyList<int> ids)
	{
		TrapDefenseController.<RequestTrapDefenseRewardClaim>d__46 <RequestTrapDefenseRewardClaim>d__;
		<RequestTrapDefenseRewardClaim>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestTrapDefenseRewardClaim>d__.ids = ids;
		<RequestTrapDefenseRewardClaim>d__.<>1__state = -1;
		<RequestTrapDefenseRewardClaim>d__.<>t__builder.Start<TrapDefenseController.<RequestTrapDefenseRewardClaim>d__46>(ref <RequestTrapDefenseRewardClaim>d__);
		return <RequestTrapDefenseRewardClaim>d__.<>t__builder.Task;
	}

	// Token: 0x060177FB RID: 96251 RVA: 0x005F9D38 File Offset: 0x005F7F38
	public UniTask<bool> RequestTrapDefenseSpecialRewardClaim(int id)
	{
		TrapDefenseController.<RequestTrapDefenseSpecialRewardClaim>d__47 <RequestTrapDefenseSpecialRewardClaim>d__;
		<RequestTrapDefenseSpecialRewardClaim>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestTrapDefenseSpecialRewardClaim>d__.id = id;
		<RequestTrapDefenseSpecialRewardClaim>d__.<>1__state = -1;
		<RequestTrapDefenseSpecialRewardClaim>d__.<>t__builder.Start<TrapDefenseController.<RequestTrapDefenseSpecialRewardClaim>d__47>(ref <RequestTrapDefenseSpecialRewardClaim>d__);
		return <RequestTrapDefenseSpecialRewardClaim>d__.<>t__builder.Task;
	}

	// Token: 0x060177FC RID: 96252 RVA: 0x005F9D7C File Offset: 0x005F7F7C
	public UniTask<bool> RequestTrapDefenseTechUnlock(int id)
	{
		TrapDefenseController.<RequestTrapDefenseTechUnlock>d__48 <RequestTrapDefenseTechUnlock>d__;
		<RequestTrapDefenseTechUnlock>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestTrapDefenseTechUnlock>d__.id = id;
		<RequestTrapDefenseTechUnlock>d__.<>1__state = -1;
		<RequestTrapDefenseTechUnlock>d__.<>t__builder.Start<TrapDefenseController.<RequestTrapDefenseTechUnlock>d__48>(ref <RequestTrapDefenseTechUnlock>d__);
		return <RequestTrapDefenseTechUnlock>d__.<>t__builder.Task;
	}

	// Token: 0x060177FD RID: 96253 RVA: 0x005F9DC0 File Offset: 0x005F7FC0
	public UniTask<bool> RequestTrapDefenseShopRefresh()
	{
		TrapDefenseController.<RequestTrapDefenseShopRefresh>d__49 <RequestTrapDefenseShopRefresh>d__;
		<RequestTrapDefenseShopRefresh>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestTrapDefenseShopRefresh>d__.<>1__state = -1;
		<RequestTrapDefenseShopRefresh>d__.<>t__builder.Start<TrapDefenseController.<RequestTrapDefenseShopRefresh>d__49>(ref <RequestTrapDefenseShopRefresh>d__);
		return <RequestTrapDefenseShopRefresh>d__.<>t__builder.Task;
	}

	// Token: 0x060177FE RID: 96254 RVA: 0x005F9DFC File Offset: 0x005F7FFC
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

	// Token: 0x060177FF RID: 96255 RVA: 0x005F9E50 File Offset: 0x005F8050
	public void UpdateEnemyPositions()
	{
		FKSC_MiniMapContext[] entityPositions = KuroSimpleCombatController.Instance.GetEntityPositions();
		if (entityPositions == null)
		{
			return;
		}
		TrapDefenseModel.Instance.MapData.UpdateEnemyPositions(new List<FKSC_MiniMapContext>(entityPositions));
	}

	// Token: 0x06017800 RID: 96256 RVA: 0x005F9E81 File Offset: 0x005F8081
	public void ChangeMap(int mapId)
	{
		TrapDefenseModel.Instance.MapData.ChangeMap(mapId);
		EventSystem.Instance.Emit<int>(EEventName.TrapDefenseMapChanged, mapId);
	}

	// Token: 0x06017801 RID: 96257 RVA: 0x005F9EA4 File Offset: 0x005F80A4
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

	// Token: 0x06017802 RID: 96258 RVA: 0x005F9F02 File Offset: 0x005F8102
	private void OnTrapDefenseInventoryDataUpdate()
	{
		TrapDefenseModel.Instance.BattleData.RefreshExploreSkillData();
	}

	// Token: 0x17001FB3 RID: 8115
	// (get) Token: 0x06017803 RID: 96259 RVA: 0x005F9F13 File Offset: 0x005F8113
	[Nullable(1)]
	public static TrapDefenseController Instance
	{
		[NullableContext(1)]
		get
		{
			return TrapDefenseController._Instance;
		}
	}

	// Token: 0x06017804 RID: 96260 RVA: 0x005F9F1A File Offset: 0x005F811A
	[NullableContext(1)]
	public static TrapDefenseController GetOrCreateInstance()
	{
		if (TrapDefenseController._Instance == null)
		{
			TrapDefenseController.CreateInstance();
		}
		return TrapDefenseController._Instance;
	}

	// Token: 0x06017805 RID: 96261 RVA: 0x005F9F2E File Offset: 0x005F812E
	public static bool CreateInstance()
	{
		if (TrapDefenseController._Instance != null)
		{
			return true;
		}
		TrapDefenseController._Instance = new TrapDefenseController();
		return true;
	}

	// Token: 0x06017806 RID: 96262 RVA: 0x005F9F44 File Offset: 0x005F8144
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06017807 RID: 96263 RVA: 0x005F9F46 File Offset: 0x005F8146
	public static void ResetStaticDefaultValue()
	{
		TrapDefenseController._Instance = null;
	}

	// Token: 0x06017808 RID: 96264 RVA: 0x005F9F4E File Offset: 0x005F814E
	static TrapDefenseController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TrapDefenseController.CreateStaticDefaultValue), new Action(TrapDefenseController.ResetStaticDefaultValue));
	}

	// Token: 0x0400AF74 RID: 44916
	[Nullable(2)]
	public TrapDefenseChallengeResultNotify ResultNotifyCache;

	// Token: 0x0400AF75 RID: 44917
	public bool IsActivityInited;

	// Token: 0x0400AF76 RID: 44918
	[Nullable(2)]
	private static TrapDefenseController _Instance;
}
