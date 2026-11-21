using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.KeySetting;
using CSharpScript.Game.Module.TowerDefenseEvent;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A28 RID: 14888
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class TrapDefenseModel : ModelBase
	{
		// Token: 0x06026438 RID: 156728 RVA: 0x00AB6CFC File Offset: 0x00AB4EFC
		public TrapDefenseModel()
		{
			this.ViewModelBdSum = TrapDefenseBdSumViewModel.Create(this);
			this.ViewModelBdQuality = TrapDefenseBdQualityViewModel.Create(this);
			this.ViewModeBdBuffSelect = TrapDefenseBdBuffSelectViewModel.Create(this);
			this.ViewModelReward = TrapDefenseRewardViewModel.Create();
			this.ViewModelMonster = TrapDefenseMonsterViewModel.Create(this);
			this.ViewModelTalentTree = TrapDefenseTalentTreeViewModel.Create();
			this.ViewModelFixedReward = TrapDefenseFixedRewardViewModel.Create(this);
			this.ViewModelMainLevel = TrapDefenseMainLevelViewModel.Create(this);
			this.ViewModelRougeLevel = TrapDefenseRougeLevelViewModel.Create(this);
			this.ViewModelShop = TrapDefenseShopViewModel.Create();
			this.BattleData = TrapDefenseBattleData.Create();
			this.MapData = TrapDefenseMapModel.Create();
			this.ShopData = TrapDefenseShopData.Create();
			this.BattleInventoryData = TrapDefenseBattleInventoryData.Create();
			this.ViewModelBuildingDevelop = TrapDefenseBuildingDevelopViewModel.Create(this);
		}

		// Token: 0x06026439 RID: 156729 RVA: 0x00AB6DE0 File Offset: 0x00AB4FE0
		protected override bool OnInit()
		{
			this.AddOpenViewCheck(EUiViewName.TrapDefenseMainLevelView, null);
			this.AddOpenViewCheck(EUiViewName.TrapDefenseRougeLevelView, new Func<EUiViewName, object, bool>(this.CheckCanOpenRougeMode));
			this.AddOpenViewCheck(EUiViewName.TrapDefenseFixedRewardView, null);
			this.AddOpenViewCheck(EUiViewName.TrapDefenseBdSumView, null);
			this.AddOpenViewCheck(EUiViewName.TrapDefenseBdQualityView, null);
			this.AddOpenViewCheck(EUiViewName.TrapDefenseBdBuffSelectView, null);
			this.AddOpenViewCheck(EUiViewName.TrapDefenseBdBuffGetView, null);
			this.AddOpenViewCheck(EUiViewName.TrapDefenseBdBuffStrengthenView, null);
			return true;
		}

		// Token: 0x0602643A RID: 156730 RVA: 0x00AB6E5C File Offset: 0x00AB505C
		protected override bool OnClear()
		{
			foreach (KeyValuePair<EUiViewName, Func<EUiViewName, object, bool>> keyValuePair in this.CheckCanOpenViewMap)
			{
				UiManager.Instance.RemoveOpenViewCheckFunction(keyValuePair.Key, keyValuePair.Value);
			}
			this.BattleData.Clear();
			return true;
		}

		// Token: 0x0602643B RID: 156731 RVA: 0x00AB6ECC File Offset: 0x00AB50CC
		protected override bool OnLeaveLevel()
		{
			this.BattleData.Clear();
			return true;
		}

		// Token: 0x0602643C RID: 156732 RVA: 0x00AB6EDC File Offset: 0x00AB50DC
		private void AddOpenViewCheck(EUiViewName name, [Nullable(new byte[]
		{
			2,
			1
		})] Func<EUiViewName, object, bool> checkFun = null)
		{
			Func<EUiViewName, object, bool> func = checkFun ?? new Func<EUiViewName, object, bool>(this.CheckCanOpen);
			UiManager instance = UiManager.Instance;
			Func<EUiViewName, object, bool> func2 = func;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
			defaultInterpolatedStringHandler.AppendFormatted<EUiViewName>(name);
			defaultInterpolatedStringHandler.AppendLiteral(".CheckCanOpen");
			instance.AddOpenViewCheckFunction(name, func2, defaultInterpolatedStringHandler.ToStringAndClear());
			this.CheckCanOpenViewMap[name] = func;
		}

		// Token: 0x17004E89 RID: 20105
		// (get) Token: 0x0602643D RID: 156733 RVA: 0x00AB6F39 File Offset: 0x00AB5139
		public bool NeedOpenActivityMainView
		{
			get
			{
				bool needOpenMainView = this.NeedOpenMainView;
				this.NeedOpenMainView = false;
				return needOpenMainView;
			}
		}

		// Token: 0x0602643E RID: 156734 RVA: 0x00AB6F48 File Offset: 0x00AB5148
		private bool CheckCanOpen(EUiViewName viewName, object _)
		{
			if (this.LevelModeData == null)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_2500068_Text", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x0602643F RID: 156735 RVA: 0x00AB6F69 File Offset: 0x00AB5169
		private bool CheckCanOpenRougeMode(EUiViewName viewName, object _)
		{
			if (!this.CheckCanOpen(viewName, _))
			{
				return false;
			}
			if (!this.RougeModeData.CanEnterRougeMode())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId(ETrapDefenseTextKey.RougeModeNotOpen.ToString(), Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x06026440 RID: 156736 RVA: 0x00AB6FA8 File Offset: 0x00AB51A8
		public void InitData(int? id = null)
		{
			int num = id ?? this.GetActivityId();
			TrapDefenseLevelModeData levelModeData = this.LevelModeData;
			if (levelModeData != null && levelModeData.ActivityId == num)
			{
				return;
			}
			this.LevelModeData = TrapDefenseLevelModeDataBase.Create<TrapDefenseLevelModeData>(num);
			this.RougeModeData = TrapDefenseLevelModeDataBase.Create<TrapDefenseRougeModeData>(num);
			this.RewardData = TrapDefenseRewardData.Create(num);
			this.TalentTreeData = TrapDefenseTalentTreeData.Create(num);
			this.LevelModeData.LevelDataList.Clear();
			this.RougeModeData.LevelDataList.Clear();
			this.LevelDataFromInstIdMap.Clear();
			this.LevelDataFromIdMap.Clear();
			foreach (TrapDefenseActivity levelConfig in TrapDefenseConfig.Instance.GetLevelListByActivityId(num))
			{
				TrapDefenseLevelData trapDefenseLevelData = this.AddLevelConfigToMode(levelConfig);
				this.LevelDataFromInstIdMap[trapDefenseLevelData.Config.InstId] = trapDefenseLevelData;
				this.LevelDataFromIdMap[trapDefenseLevelData.Config.Id] = trapDefenseLevelData;
			}
			this.LevelModeData.SortLevelDataList();
			this.RougeModeData.SortLevelDataList();
		}

		// Token: 0x06026441 RID: 156737 RVA: 0x00AB70E0 File Offset: 0x00AB52E0
		public void UpdateActivityData(TrapDefenseActivityInfo data)
		{
			foreach (TrapDefenseChallengeInfo trapDefenseChallengeInfo in data.Challenges)
			{
				TrapDefenseLevelData trapDefenseLevelData;
				if (this.LevelDataFromIdMap.TryGetValue(trapDefenseChallengeInfo.ChallengeId, out trapDefenseLevelData))
				{
					trapDefenseLevelData.ProtoUpdateData(trapDefenseChallengeInfo);
				}
			}
			foreach (int key in data.UnlockBds)
			{
				TrapDefenseBdData trapDefenseBdData;
				if (this.RougeModeData.BdDataMap.TryGetValue(key, out trapDefenseBdData) && trapDefenseBdData != null)
				{
					trapDefenseBdData.SetUnlock(true);
				}
			}
			foreach (int key2 in data.UnlockBdGroups)
			{
				TrapDefenseBdBuffData trapDefenseBdBuffData;
				if (this.RougeModeData.BdBuffDataMap.TryGetValue(key2, out trapDefenseBdBuffData) && trapDefenseBdBuffData != null)
				{
					trapDefenseBdBuffData.SetUnlock(true);
				}
			}
			this.ViewModelBuildingDevelop.InitDevelopInfo(data);
			this.ViewModelBuildingDevelop.SetRemainPoints(data.LeftLevelUpPoint);
			TrapDefenseRewardData rewardData = this.RewardData;
			if (rewardData != null)
			{
				rewardData.UpdateRewardsByServerData(new List<TrapDefenseRewardInfo>(data.Rewards).ToArray());
			}
			this.RewardData.SetLimitTime(data.LimitBeginTime, data.LimitEndTime);
			TrapDefenseSpecialRewardData specialRewardData = this.RewardData.SpecialRewardData;
			if (specialRewardData != null)
			{
				specialRewardData.UpdateByServerData(data.SpecialRewards[0]);
			}
			foreach (int key3 in data.UnlockTechNodes)
			{
				TrapDefenseTalentTreeData talentTreeData = this.TalentTreeData;
				TrapDefenseTalentTreeNodeData trapDefenseTalentTreeNodeData;
				if (talentTreeData != null && talentTreeData.NodeIdMap.TryGetValue(key3, out trapDefenseTalentTreeNodeData) && trapDefenseTalentTreeNodeData != null)
				{
					trapDefenseTalentTreeNodeData.SetUnlock();
				}
			}
			TrapDefenseTalentTreeData talentTreeData2 = this.TalentTreeData;
			if (talentTreeData2 != null)
			{
				talentTreeData2.SetRemainPoints(data.LeftTechPoint);
			}
			TrapDefenseTalentTreeData talentTreeData3 = this.TalentTreeData;
			if (talentTreeData3 != null)
			{
				talentTreeData3.SetMaxPoints(data.TotalTechPoint);
			}
			TrapDefenseTalentTreeData talentTreeData4 = this.TalentTreeData;
			if (talentTreeData4 != null)
			{
				talentTreeData4.RefreshLineTypeMap();
			}
			this.MapData.InitMapData();
			this.ShopData.TryUpdateData();
			this.TryUpdateBdBuffAllUpdateNotify();
			EventSystem.Instance.Emit(EEventName.TrapDefenseActivityDataUpdate);
		}

		// Token: 0x06026442 RID: 156738 RVA: 0x00AB7334 File Offset: 0x00AB5534
		private TrapDefenseLevelData AddLevelConfigToMode(TrapDefenseActivity levelConfig)
		{
			ETrapDefenseLevelType modeType = (ETrapDefenseLevelType)levelConfig.ModeType;
			if (modeType == ETrapDefenseLevelType.Mainline)
			{
				return this.LevelModeData.AddLevelConfig(levelConfig);
			}
			if (modeType - ETrapDefenseLevelType.RougeNormal > 1)
			{
				return this.LevelModeData.AddLevelConfig(levelConfig);
			}
			return this.RougeModeData.AddLevelConfig(levelConfig);
		}

		// Token: 0x06026443 RID: 156739 RVA: 0x00AB737C File Offset: 0x00AB557C
		public ITrapDefenseMachineIdInfo DecomposeMachineId(int id)
		{
			int branch = id % 100;
			int level = (int)Math.Floor((double)id / 100.0) % 100;
			int dataType = (int)Math.Floor((double)id / 10000.0) % 100;
			int machineType = (int)Math.Floor((double)id / 1000000.0) % 100;
			return new ITrapDefenseMachineIdInfo
			{
				MachineType = (ETrapDefenseMachineType)machineType,
				DataType = dataType,
				Level = level,
				Branch = branch
			};
		}

		// Token: 0x06026444 RID: 156740 RVA: 0x00AB73F1 File Offset: 0x00AB55F1
		public int ComposeMachineId(ITrapDefenseMachineIdInfo info)
		{
			return (int)(info.MachineType * (ETrapDefenseMachineType)1000000 + info.DataType * 10000 + info.Level * 100 + info.Branch);
		}

		// Token: 0x06026445 RID: 156741 RVA: 0x00AB7420 File Offset: 0x00AB5620
		public int GetActivityId()
		{
			ActivityTrapDefenseController instance = ActivityTrapDefenseController.Instance;
			int? num;
			if (instance == null)
			{
				num = null;
			}
			else
			{
				ActivityTrapDefenseData data = instance.Data;
				num = ((data != null) ? new int?(data.Id) : null);
			}
			int? num2 = num;
			return num2.GetValueOrDefault();
		}

		// Token: 0x06026446 RID: 156742 RVA: 0x00AB7468 File Offset: 0x00AB5668
		[NullableContext(2)]
		public TrapDefenseLevelData GetCurInstToLevelData()
		{
			int instanceId = CreatureModel.Instance.GetInstanceId();
			TrapDefenseLevelData result;
			if (!this.LevelDataFromInstIdMap.TryGetValue(instanceId, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06026447 RID: 156743 RVA: 0x00AB7494 File Offset: 0x00AB5694
		[return: Nullable(2)]
		public TrapDefenseLevelData GetNextLevelData(TrapDefenseLevelData data)
		{
			int nextId = data.Config.NextId;
			if (nextId == 0)
			{
				return null;
			}
			TrapDefenseLevelData result;
			if (!this.LevelDataFromIdMap.TryGetValue(nextId, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06026448 RID: 156744 RVA: 0x00AB74C8 File Offset: 0x00AB56C8
		public TrapDefenseWave? GetCurrentBatchData()
		{
			TrapDefenseLevelData curInstToLevelData = this.GetCurInstToLevelData();
			if (curInstToLevelData == null)
			{
				return null;
			}
			int batch = this.BattleData.GetBatch();
			IReadOnlyList<TrapDefenseWave> trapDefenseWavesByLevelId = TrapDefenseConfig.Instance.GetTrapDefenseWavesByLevelId(curInstToLevelData.Config.Id);
			return new TrapDefenseWave?((batch > 0 && batch <= trapDefenseWavesByLevelId.Count) ? trapDefenseWavesByLevelId[batch - 1] : trapDefenseWavesByLevelId[0]);
		}

		// Token: 0x06026449 RID: 156745 RVA: 0x00AB7530 File Offset: 0x00AB5730
		public bool GetCurInstIsRogue()
		{
			TrapDefenseLevelData curInstToLevelData = this.GetCurInstToLevelData();
			return curInstToLevelData != null && curInstToLevelData.Config.ModeType != 1;
		}

		// Token: 0x0602644A RID: 156746 RVA: 0x00AB755C File Offset: 0x00AB575C
		public bool IsInMainline()
		{
			TrapDefenseLevelData curInstToLevelData = this.GetCurInstToLevelData();
			return curInstToLevelData != null && curInstToLevelData.Config.ModeType == 1;
		}

		// Token: 0x0602644B RID: 156747 RVA: 0x00AB7584 File Offset: 0x00AB5784
		public bool GetCurInstToLevelDataHasShop()
		{
			TrapDefenseLevelData curInstToLevelData = this.GetCurInstToLevelData();
			return curInstToLevelData != null && curInstToLevelData.HasShop;
		}

		// Token: 0x0602644C RID: 156748 RVA: 0x00AB75A3 File Offset: 0x00AB57A3
		public void BdBuffSelectProcessFinish()
		{
			this.ViewModeBdBuffSelect.ViewProcessFinish();
			this.CheckIsNeedOpenBdBuffSelectView();
		}

		// Token: 0x0602644D RID: 156749 RVA: 0x00AB75B8 File Offset: 0x00AB57B8
		public void CheckIsNeedOpenBdBuffSelectView()
		{
			if (this.ViewModeBdBuffSelect.ShowingViewProcess)
			{
				return;
			}
			if (this.ViewModeBdBuffSelect.BackupIdList.Count <= 0)
			{
				return;
			}
			List<int> collection = this.ViewModeBdBuffSelect.BackupIdList[0];
			this.ViewModeBdBuffSelect.BackupIdList.RemoveAt(0);
			this.OpenViewBdBuffSelect(new List<int>(collection), null);
		}

		// Token: 0x0602644E RID: 156750 RVA: 0x00AB7620 File Offset: 0x00AB5820
		public int GetAllGetStarByLevel()
		{
			int num = 0;
			foreach (TrapDefenseLevelData trapDefenseLevelData in this.LevelModeData.LevelDataList)
			{
				num += trapDefenseLevelData.ReachTargetIndexList.Count;
			}
			int num2 = 0;
			foreach (TrapDefenseLevelData trapDefenseLevelData2 in this.RougeModeData.LevelDataList)
			{
				num2 += trapDefenseLevelData2.ReachTargetIndexList.Count;
			}
			return num + num2;
		}

		// Token: 0x0602644F RID: 156751 RVA: 0x00AB76D8 File Offset: 0x00AB58D8
		public void OpenViewBdSum(bool? isInInstance = null, ETrapDefenseBdTabType? jumpTab = null, int? jumpId = null)
		{
			bool isInstance = isInInstance ?? TowerDefenseEventController.Instance.IsTowerDefenseEventInstance();
			this.ViewModelBdSum.SetIsInstance(isInstance);
			this.ViewModelBdSum.SetJumpTabType(jumpTab);
			this.ViewModelBdSum.SetJumpBdId(jumpId);
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseBdSumView, null, null);
		}

		// Token: 0x06026450 RID: 156752 RVA: 0x00AB773C File Offset: 0x00AB593C
		public void OpenViewBdQuality(int bdId, ETrapDefenseBdBuffQuality? quality = null, bool? isNew = null, int? bdBuffId = null)
		{
			TrapDefenseBdData trapDefenseBdData;
			TrapDefenseBdData curSelectBdData = this.RougeModeData.BdDataMap.TryGetValue(bdId, out trapDefenseBdData) ? trapDefenseBdData : this.RougeModeData.BdDataList[0];
			TrapDefenseBdBuffData trapDefenseBdBuffData;
			TrapDefenseBdBuffData curSelectBdBuffData = (bdBuffId != null && this.RougeModeData.BdBuffDataMap.TryGetValue(bdBuffId.Value, out trapDefenseBdBuffData)) ? trapDefenseBdBuffData : null;
			this.ViewModelBdQuality.SetCurSelectBdData(curSelectBdData);
			this.ViewModelBdQuality.SetCurSelectBdBuffData(curSelectBdBuffData);
			this.ViewModelBdQuality.SetNewQualityMode(isNew.GetValueOrDefault());
			this.ViewModelBdQuality.SetShowQuality(quality);
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseBdQualityView, null, null);
		}

		// Token: 0x06026451 RID: 156753 RVA: 0x00AB77E3 File Offset: 0x00AB59E3
		public bool OpenViewBdBuffSelect(List<int> idList, int? selectId = null)
		{
			if (idList.Count <= 0)
			{
				return false;
			}
			this.ViewModeBdBuffSelect.SetBuffList(new List<int>(idList), selectId);
			this.ViewModeBdBuffSelect.OnOpenView();
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseBdBuffSelectView, null, null);
			return true;
		}

		// Token: 0x06026452 RID: 156754 RVA: 0x00AB7820 File Offset: 0x00AB5A20
		public void OpenViewBdBuffNewGet(int buffId, bool isCheckBdProgress = true)
		{
			TrapDefenseBdBuffData trapDefenseBdBuffData;
			TrapDefenseBdBuffData lastGetBdBuffData = this.RougeModeData.BdBuffDataMap.TryGetValue(buffId, out trapDefenseBdBuffData) ? trapDefenseBdBuffData : this.RougeModeData.BdBuffDataList[0];
			this.RougeModeData.SetLastGetBdBuffData(lastGetBdBuffData);
			this.RougeModeData.SetIsCheckBdProgress(isCheckBdProgress);
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseBdBuffGetView, null, null);
		}

		// Token: 0x06026453 RID: 156755 RVA: 0x00AB7880 File Offset: 0x00AB5A80
		public void OpenViewBdBuffStrengthen(int buffId, bool isCheckBdProgress = true)
		{
			TrapDefenseBdBuffData trapDefenseBdBuffData;
			TrapDefenseBdBuffData lastGetBdBuffData = this.RougeModeData.BdBuffDataMap.TryGetValue(buffId, out trapDefenseBdBuffData) ? trapDefenseBdBuffData : this.RougeModeData.BdBuffDataList[0];
			this.RougeModeData.SetLastGetBdBuffData(lastGetBdBuffData);
			this.RougeModeData.SetIsCheckBdProgress(isCheckBdProgress);
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseBdBuffStrengthenView, null, null);
		}

		// Token: 0x06026454 RID: 156756 RVA: 0x00AB78E0 File Offset: 0x00AB5AE0
		public void OpenViewMonster(int? instId = null, ETrapDefenseMonsterTabType? jumpTab = null, bool? isInst = null)
		{
			TrapDefenseLevelData trapDefenseLevelData;
			TrapDefenseLevelData selectLevelData = (instId != null && this.LevelDataFromInstIdMap.TryGetValue(instId.Value, out trapDefenseLevelData)) ? trapDefenseLevelData : this.GetCurInstToLevelData();
			bool isInstance = isInst ?? TowerDefenseEventController.Instance.IsTowerDefenseEventInstance();
			this.ViewModelMonster.SetSelectLevelData(selectLevelData);
			this.ViewModelMonster.SetJumpTabType(jumpTab);
			this.ViewModelMonster.SetIsInstance(isInstance);
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseMonsterView, null, null);
		}

		// Token: 0x06026455 RID: 156757 RVA: 0x00AB796C File Offset: 0x00AB5B6C
		public void OpenViewKeySetting()
		{
			if (Info.Instance.IsInTouch())
			{
				TouchUiEditController.Instance.OpenCommonTouchUiEditView(1);
				return;
			}
			CommonKeySettingViewOpenData param = new CommonKeySettingViewOpenData
			{
				ViewType = EKeySettingExclusiveType.TrapDefense,
				BgSourceId = "T_FightEditBg"
			};
			UiManager.Instance.OpenView(EUiViewName.CommonKeySettingView, param, null);
		}

		// Token: 0x06026456 RID: 156758 RVA: 0x00AB79BA File Offset: 0x00AB5BBA
		public void OpenViewLimitReward()
		{
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseRewardView, null, null);
		}

		// Token: 0x06026457 RID: 156759 RVA: 0x00AB79CD File Offset: 0x00AB5BCD
		[NullableContext(2)]
		public void OpenViewTalentTree(ITrapDefenseTalentTreeViewParam param = null)
		{
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseTalentTreeView, param, null);
		}

		// Token: 0x06026458 RID: 156760 RVA: 0x00AB79E0 File Offset: 0x00AB5BE0
		public void OpenMainEntryView()
		{
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseMainView, null, null);
		}

		// Token: 0x06026459 RID: 156761 RVA: 0x00AB79F3 File Offset: 0x00AB5BF3
		public void OpenViewFixedReward()
		{
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseFixedRewardView, null, null);
		}

		// Token: 0x0602645A RID: 156762 RVA: 0x00AB7A08 File Offset: 0x00AB5C08
		public void OpenViewMainLevelMode(int? id = null, ETrapDefenseDifficultyLevel? difficulty = null, bool? isInst = null)
		{
			bool isInstance = isInst ?? TowerDefenseEventController.Instance.IsTowerDefenseEventInstance();
			this.ViewModelMainLevel.SetJumpLevelData(id);
			this.ViewModelMainLevel.SetJumpDifficulty(difficulty);
			this.ViewModelMainLevel.SetIsInstance(isInstance);
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseMainLevelView, null, null);
		}

		// Token: 0x0602645B RID: 156763 RVA: 0x00AB7A6C File Offset: 0x00AB5C6C
		public void OpenViewRougeLevelMode(int? id = null, bool? isInst = null)
		{
			bool isInstance = isInst ?? TowerDefenseEventController.Instance.IsTowerDefenseEventInstance();
			this.ViewModelRougeLevel.SetJumpLevelData(id);
			this.ViewModelRougeLevel.SetIsInstance(isInstance);
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseRougeLevelView, null, null);
		}

		// Token: 0x0602645C RID: 156764 RVA: 0x00AB7AC1 File Offset: 0x00AB5CC1
		public void OpenViewShop()
		{
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseShopView, null, null);
		}

		// Token: 0x0602645D RID: 156765 RVA: 0x00AB7AD4 File Offset: 0x00AB5CD4
		public bool CheckNextLevelThreshold(TrapDefenseLevelData levelData, Action cb, [Nullable(2)] UiViewBase parent)
		{
			int nextLevelCostThreshold = TrapDefenseConfig.Instance.GetNextLevelCostThreshold();
			if (this.ViewModelBuildingDevelop.RemainPoints < nextLevelCostThreshold)
			{
				return false;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.TrapDefenseNextLevelThreshold);
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			confirmBoxDataNew.FunctionMap[1] = cb;
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				TrapDefenseController.Instance.OpenOrganDevelop(false, parent, 0, levelData);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return true;
		}

		// Token: 0x0602645E RID: 156766 RVA: 0x00AB7B54 File Offset: 0x00AB5D54
		public void ProtoBdBuffAllUpdateNotify(TrapDefenseSyncGainingGroupsNotify response)
		{
			if (this.RougeModeData == null)
			{
				this.ResponseCacheBdBuff = response;
				return;
			}
			Dictionary<int, TrapDefenseGainingInfo> dictionary = new Dictionary<int, TrapDefenseGainingInfo>();
			foreach (TrapDefenseGainingInfo trapDefenseGainingInfo in response.GainingInfos)
			{
				dictionary[trapDefenseGainingInfo.GroupId] = trapDefenseGainingInfo;
			}
			foreach (TrapDefenseBdBuffData trapDefenseBdBuffData in this.RougeModeData.BdBuffDataList)
			{
				TrapDefenseGainingInfo trapDefenseGainingInfo2;
				dictionary.TryGetValue(trapDefenseBdBuffData.Id, out trapDefenseGainingInfo2);
				trapDefenseBdBuffData.SetActive(trapDefenseGainingInfo2 != null);
				trapDefenseBdBuffData.SetLevel((trapDefenseGainingInfo2 != null) ? trapDefenseGainingInfo2.LevelId : 1);
			}
			EventSystem.Instance.Emit(EEventName.TrapDefenseBdBuffAllUpdate);
		}

		// Token: 0x0602645F RID: 156767 RVA: 0x00AB7C40 File Offset: 0x00AB5E40
		private void TryUpdateBdBuffAllUpdateNotify()
		{
			if (this.ResponseCacheBdBuff == null)
			{
				return;
			}
			this.ProtoBdBuffAllUpdateNotify(this.ResponseCacheBdBuff);
			this.ResponseCacheBdBuff = null;
		}

		// Token: 0x06026460 RID: 156768 RVA: 0x00AB7C60 File Offset: 0x00AB5E60
		public void ProtoBdBuffSelectUpdateNotify(TrapDefenseRewardGainingGroupsNotify response)
		{
			RewardGainingPanelInfo rewardInfo = response.RewardInfo;
			if (rewardInfo == null)
			{
				return;
			}
			if (rewardInfo.GainingGroupIds.Count <= 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId(ETrapDefenseTextKey.BdBuffSelectEmptyListTips.ToString(), Array.Empty<object>());
				return;
			}
			this.ViewModeBdBuffSelect.SetRemainRefreshCount(rewardInfo.RemainRefreshTimes);
			this.ViewModeBdBuffSelect.SetMaxRefreshCount(rewardInfo.TotalRefreshTimes);
			this.ViewModeBdBuffSelect.SetRefreshBuffCostNum(rewardInfo.RefreshCost);
			if (this.ViewModeBdBuffSelect.ShowingViewProcess)
			{
				this.ViewModeBdBuffSelect.BackupIdList.Add(new List<int>(rewardInfo.GainingGroupIds));
				return;
			}
			this.ViewModeBdBuffSelect.OnOpenView();
			this.OpenViewBdBuffSelect(new List<int>(rewardInfo.GainingGroupIds), null);
		}

		// Token: 0x06026461 RID: 156769 RVA: 0x00AB7D28 File Offset: 0x00AB5F28
		public void ProtoBdBuffGetUpdateNotify(TrapDefenseGainingGroupUpdateNotify response)
		{
			TrapDefenseGainingInfo gainingGroupInfo = response.GainingGroupInfo;
			if (gainingGroupInfo == null)
			{
				return;
			}
			if (response.Reason != TrapDefenseGainingUpdateReason.RewardSelect)
			{
				this.RougeModeData.CheckBdBuffGetUpdate(gainingGroupInfo.GroupId, gainingGroupInfo.LevelId);
			}
		}

		// Token: 0x06026462 RID: 156770 RVA: 0x00AB7D60 File Offset: 0x00AB5F60
		public void ProtoBdBuffRefreshResponse(TrapDefenseRefreshGainingGroupResponse response)
		{
			RewardGainingPanelInfo newRewardInfo = response.NewRewardInfo;
			if (newRewardInfo != null && newRewardInfo.GainingGroupIds.Count > 0)
			{
				this.ViewModeBdBuffSelect.SetBuffList(new List<int>(newRewardInfo.GainingGroupIds), null);
				this.ViewModeBdBuffSelect.SetRemainRefreshCount(newRewardInfo.RemainRefreshTimes);
				this.ViewModeBdBuffSelect.SetMaxRefreshCount(newRewardInfo.TotalRefreshTimes);
				this.ViewModeBdBuffSelect.SetRefreshBuffCostNum(newRewardInfo.RefreshCost);
			}
		}

		// Token: 0x06026463 RID: 156771 RVA: 0x00AB7DD8 File Offset: 0x00AB5FD8
		public UniTask RequestBdBuffSelect(int id)
		{
			TrapDefenseModel.<RequestBdBuffSelect>d__69 <RequestBdBuffSelect>d__;
			<RequestBdBuffSelect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestBdBuffSelect>d__.<>4__this = this;
			<RequestBdBuffSelect>d__.id = id;
			<RequestBdBuffSelect>d__.<>1__state = -1;
			<RequestBdBuffSelect>d__.<>t__builder.Start<TrapDefenseModel.<RequestBdBuffSelect>d__69>(ref <RequestBdBuffSelect>d__);
			return <RequestBdBuffSelect>d__.<>t__builder.Task;
		}

		// Token: 0x06026464 RID: 156772 RVA: 0x00AB7E24 File Offset: 0x00AB6024
		public void ProtoChallengeUpdateNotify(TrapDefenseChallengeUpdateNotify response)
		{
			foreach (TrapDefenseChallengeInfo trapDefenseChallengeInfo in response.ChallengeInfo)
			{
				TrapDefenseLevelData trapDefenseLevelData;
				if (this.LevelDataFromIdMap.TryGetValue(trapDefenseChallengeInfo.ChallengeId, out trapDefenseLevelData))
				{
					trapDefenseLevelData.ProtoUpdateData(trapDefenseChallengeInfo);
				}
			}
			EventSystem.Instance.Emit(EEventName.TrapDefenseLevelDataListUpdate);
		}

		// Token: 0x06026465 RID: 156773 RVA: 0x00AB7E98 File Offset: 0x00AB6098
		public void ProtoRewardUpdateNotify(TrapDefenseRewardUpdateNotify response)
		{
			TrapDefenseRewardData rewardData = this.RewardData;
			if (rewardData != null)
			{
				rewardData.UpdateRewardsByServerData(new List<TrapDefenseRewardInfo>(response.Rewards).ToArray());
			}
			EventSystem.Instance.Emit(EEventName.TrapDefenseRewardUpdate);
			EventSystem.Instance.Emit(EEventName.RedDotUpdateTrapDefenseLimitReward);
			EventSystem.Instance.Emit(EEventName.RedDotUpdateTrapDefenseFixedReward);
			ActivityTrapDefenseController instance = ActivityTrapDefenseController.Instance;
			if (instance == null)
			{
				return;
			}
			instance.RefreshActivityRedDot();
		}

		// Token: 0x06026466 RID: 156774 RVA: 0x00AB7F08 File Offset: 0x00AB6108
		public void ProtoSpecialRewardUpdateNotify(TrapDefenseSpecialRewardUpdateNotify response)
		{
			TrapDefenseRewardData rewardData = this.RewardData;
			if (rewardData != null)
			{
				TrapDefenseSpecialRewardData specialRewardData = rewardData.SpecialRewardData;
				if (specialRewardData != null)
				{
					specialRewardData.UpdateByServerData(response.SpecialRewards[0]);
				}
			}
			EventSystem.Instance.Emit(EEventName.TrapDefenseRewardUpdate);
			EventSystem.Instance.Emit(EEventName.RedDotUpdateTrapDefenseLimitReward);
			ActivityTrapDefenseController instance = ActivityTrapDefenseController.Instance;
			if (instance == null)
			{
				return;
			}
			instance.RefreshActivityRedDot();
		}

		// Token: 0x06026467 RID: 156775 RVA: 0x00AB7F6C File Offset: 0x00AB616C
		public void ProtoTechUpdateNotify(TrapDefenseTechUpdateNotify response)
		{
			foreach (int key in response.UnlockTechNodes)
			{
				TrapDefenseTalentTreeData talentTreeData = this.TalentTreeData;
				TrapDefenseTalentTreeNodeData trapDefenseTalentTreeNodeData;
				if (talentTreeData != null && talentTreeData.NodeIdMap.TryGetValue(key, out trapDefenseTalentTreeNodeData) && trapDefenseTalentTreeNodeData != null)
				{
					trapDefenseTalentTreeNodeData.SetUnlock();
				}
			}
			TrapDefenseTalentTreeData talentTreeData2 = this.TalentTreeData;
			if (talentTreeData2 != null)
			{
				talentTreeData2.RefreshLineTypeMap();
			}
			EventSystem.Instance.Emit(EEventName.TrapDefenseTalentTreeUpdate);
			EventSystem.Instance.Emit(EEventName.RedDotUpdateTrapDefenseTalentTree);
			ActivityTrapDefenseController instance = ActivityTrapDefenseController.Instance;
			if (instance == null)
			{
				return;
			}
			instance.RefreshActivityRedDot();
		}

		// Token: 0x06026468 RID: 156776 RVA: 0x00AB8018 File Offset: 0x00AB6218
		public void ProtoBdUpdateNotify(TrapDefenseBdUpdateNotify response)
		{
			foreach (int key in response.UnlockBds)
			{
				TrapDefenseBdData trapDefenseBdData;
				if (this.RougeModeData.BdDataMap.TryGetValue(key, out trapDefenseBdData) && trapDefenseBdData != null)
				{
					trapDefenseBdData.SetUnlock(true);
				}
			}
		}

		// Token: 0x06026469 RID: 156777 RVA: 0x00AB8080 File Offset: 0x00AB6280
		public void ProtoBdBuffUpdateNotify(TrapDefenseBdGroupUnlockNotify response)
		{
			foreach (int key in response.UnlockBdGroups)
			{
				TrapDefenseBdBuffData trapDefenseBdBuffData;
				if (this.RougeModeData.BdBuffDataMap.TryGetValue(key, out trapDefenseBdBuffData) && trapDefenseBdBuffData != null)
				{
					trapDefenseBdBuffData.SetUnlock(true);
				}
			}
			EventSystem.Instance.Emit(EEventName.TrapDefenseBdBuffListUpdate);
			EventSystem.Instance.Emit(EEventName.RedDotUpdateTrapDefenseBdBuffNewUnlock);
			ActivityTrapDefenseController instance = ActivityTrapDefenseController.Instance;
			if (instance == null)
			{
				return;
			}
			instance.RefreshActivityRedDot();
		}

		// Token: 0x0602646A RID: 156778 RVA: 0x00AB8114 File Offset: 0x00AB6314
		public void ProtoTechPointUpdateNotify(TrapDefenseTechPointUpdateNotify response)
		{
			TrapDefenseTalentTreeData talentTreeData = this.TalentTreeData;
			if (talentTreeData != null)
			{
				talentTreeData.SetRemainPoints(response.LeftTechPoint);
			}
			TrapDefenseTalentTreeData talentTreeData2 = this.TalentTreeData;
			if (talentTreeData2 != null)
			{
				talentTreeData2.SetMaxPoints(response.TotalTechPoint);
			}
			this.ViewModelBuildingDevelop.SetRemainPoints(response.LeftLevelUpPoint);
			EventSystem.Instance.Emit(EEventName.TrapDefenseTalentTreeUpdate);
			EventSystem.Instance.Emit(EEventName.RedDotUpdateTrapDefenseTalentTree);
			ActivityTrapDefenseController instance = ActivityTrapDefenseController.Instance;
			if (instance == null)
			{
				return;
			}
			instance.RefreshActivityRedDot();
		}

		// Token: 0x0602646B RID: 156779 RVA: 0x00AB818F File Offset: 0x00AB638F
		public void ProtoShopRefreshResponse(TrapDefenseRefreshShopResponse response)
		{
			if (response.NewShopInfo == null)
			{
				return;
			}
			TrapDefenseShopData shopData = this.ShopData;
			if (shopData != null)
			{
				shopData.UpdateByServerData(response.NewShopInfo);
			}
			EventSystem.Instance.Emit(EEventName.TrapDefenseShopRefresh);
		}

		// Token: 0x0602646C RID: 156780 RVA: 0x00AB81C1 File Offset: 0x00AB63C1
		public void ProtoShopInitNotify(TrapDefenseShopPanelInfo response)
		{
			TrapDefenseShopData shopData = this.ShopData;
			if (shopData != null)
			{
				shopData.UpdateByServerData(response);
			}
			EventSystem.Instance.Emit(EEventName.TrapDefenseShopRefresh);
		}

		// Token: 0x0602646D RID: 156781 RVA: 0x00AB81E5 File Offset: 0x00AB63E5
		public void ProtoShopPurchaseResponse(TrapDefenseShopPanelInfo response, int purchasedId)
		{
			TrapDefenseShopData shopData = this.ShopData;
			if (shopData != null)
			{
				shopData.UpdateByServerData(response);
			}
			EventSystem.Instance.Emit(EEventName.TrapDefenseShopRefresh);
		}

		// Token: 0x0602646E RID: 156782 RVA: 0x00AB820C File Offset: 0x00AB640C
		public bool RequestStartChallenge(TrapDefenseLevelData data)
		{
			if (!data.IsLeaved)
			{
				TrapDefenseController.Instance.RequestChallenge(data, false);
				return true;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.TrapDefenseLevelStarSwitch);
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			confirmBoxDataNew.FunctionMap[1] = delegate()
			{
				TrapDefenseController.Instance.RequestChallenge(data, false);
			};
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				TrapDefenseController.Instance.RequestChallenge(data, true);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return true;
		}

		// Token: 0x17004E8A RID: 20106
		// (get) Token: 0x0602646F RID: 156783 RVA: 0x00AB8296 File Offset: 0x00AB6496
		public static TrapDefenseModel Instance
		{
			get
			{
				return TrapDefenseModel._Instance;
			}
		}

		// Token: 0x06026470 RID: 156784 RVA: 0x00AB829D File Offset: 0x00AB649D
		public static TrapDefenseModel GetOrCreateInstance()
		{
			if (TrapDefenseModel._Instance == null)
			{
				TrapDefenseModel.CreateInstance();
			}
			return TrapDefenseModel._Instance;
		}

		// Token: 0x06026471 RID: 156785 RVA: 0x00AB82B1 File Offset: 0x00AB64B1
		public static bool CreateInstance()
		{
			if (TrapDefenseModel._Instance != null)
			{
				return true;
			}
			TrapDefenseModel._Instance = new TrapDefenseModel();
			return true;
		}

		// Token: 0x06026472 RID: 156786 RVA: 0x00AB82C7 File Offset: 0x00AB64C7
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06026473 RID: 156787 RVA: 0x00AB82C9 File Offset: 0x00AB64C9
		public static void ResetStaticDefaultValue()
		{
			TrapDefenseModel._Instance = null;
		}

		// Token: 0x06026474 RID: 156788 RVA: 0x00AB82D1 File Offset: 0x00AB64D1
		static TrapDefenseModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TrapDefenseModel.CreateStaticDefaultValue), new Action(TrapDefenseModel.ResetStaticDefaultValue));
		}

		// Token: 0x04015038 RID: 86072
		public TrapDefenseLevelModeData LevelModeData;

		// Token: 0x04015039 RID: 86073
		public TrapDefenseRougeModeData RougeModeData;

		// Token: 0x0401503A RID: 86074
		public TrapDefenseRewardData RewardData;

		// Token: 0x0401503B RID: 86075
		public TrapDefenseTalentTreeData TalentTreeData;

		// Token: 0x0401503C RID: 86076
		public readonly Dictionary<int, TrapDefenseLevelData> LevelDataFromInstIdMap = new Dictionary<int, TrapDefenseLevelData>();

		// Token: 0x0401503D RID: 86077
		public readonly Dictionary<int, TrapDefenseLevelData> LevelDataFromIdMap = new Dictionary<int, TrapDefenseLevelData>();

		// Token: 0x0401503E RID: 86078
		public Dictionary<EUiViewName, Func<EUiViewName, object, bool>> CheckCanOpenViewMap = new Dictionary<EUiViewName, Func<EUiViewName, object, bool>>();

		// Token: 0x0401503F RID: 86079
		public TrapDefenseBdSumViewModel ViewModelBdSum;

		// Token: 0x04015040 RID: 86080
		public TrapDefenseBdQualityViewModel ViewModelBdQuality;

		// Token: 0x04015041 RID: 86081
		public TrapDefenseBdBuffSelectViewModel ViewModeBdBuffSelect;

		// Token: 0x04015042 RID: 86082
		public TrapDefenseRewardViewModel ViewModelReward;

		// Token: 0x04015043 RID: 86083
		public TrapDefenseMonsterViewModel ViewModelMonster;

		// Token: 0x04015044 RID: 86084
		public TrapDefenseTalentTreeViewModel ViewModelTalentTree;

		// Token: 0x04015045 RID: 86085
		public TrapDefenseFixedRewardViewModel ViewModelFixedReward;

		// Token: 0x04015046 RID: 86086
		public TrapDefenseMainLevelViewModel ViewModelMainLevel;

		// Token: 0x04015047 RID: 86087
		public TrapDefenseRougeLevelViewModel ViewModelRougeLevel;

		// Token: 0x04015048 RID: 86088
		public TrapDefenseShopViewModel ViewModelShop;

		// Token: 0x04015049 RID: 86089
		public TrapDefenseBattleData BattleData;

		// Token: 0x0401504A RID: 86090
		public TrapDefenseMapModel MapData;

		// Token: 0x0401504B RID: 86091
		public TrapDefenseShopData ShopData;

		// Token: 0x0401504C RID: 86092
		public TrapDefenseBattleInventoryData BattleInventoryData;

		// Token: 0x0401504D RID: 86093
		public TrapDefenseBuildingDevelopViewModel ViewModelBuildingDevelop;

		// Token: 0x0401504E RID: 86094
		public bool NeedOpenMainView;

		// Token: 0x0401504F RID: 86095
		public bool IsSkipMachineFullCheck;

		// Token: 0x04015050 RID: 86096
		[Nullable(2)]
		private TrapDefenseSyncGainingGroupsNotify ResponseCacheBdBuff;

		// Token: 0x04015051 RID: 86097
		[Nullable(2)]
		private static TrapDefenseModel _Instance;
	}
}
