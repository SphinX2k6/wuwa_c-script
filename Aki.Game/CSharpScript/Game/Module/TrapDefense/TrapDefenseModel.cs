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
	// Token: 0x02004A80 RID: 19072
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class TrapDefenseModel : ModelBase
	{
		// Token: 0x060316A8 RID: 202408 RVA: 0x00B72D78 File Offset: 0x00B70F78
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

		// Token: 0x060316A9 RID: 202409 RVA: 0x00B72E5C File Offset: 0x00B7105C
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

		// Token: 0x060316AA RID: 202410 RVA: 0x00B72ED8 File Offset: 0x00B710D8
		protected override bool OnClear()
		{
			foreach (KeyValuePair<EUiViewName, Func<EUiViewName, object, bool>> keyValuePair in this.CheckCanOpenViewMap)
			{
				UiManager.Instance.RemoveOpenViewCheckFunction(keyValuePair.Key, keyValuePair.Value);
			}
			this.BattleData.Clear();
			return true;
		}

		// Token: 0x060316AB RID: 202411 RVA: 0x00B72F48 File Offset: 0x00B71148
		protected override bool OnLeaveLevel()
		{
			this.BattleData.Clear();
			return true;
		}

		// Token: 0x060316AC RID: 202412 RVA: 0x00B72F58 File Offset: 0x00B71158
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

		// Token: 0x17007ADC RID: 31452
		// (get) Token: 0x060316AD RID: 202413 RVA: 0x00B72FB5 File Offset: 0x00B711B5
		public bool NeedOpenActivityMainView
		{
			get
			{
				bool needOpenMainView = this.NeedOpenMainView;
				this.NeedOpenMainView = false;
				return needOpenMainView;
			}
		}

		// Token: 0x060316AE RID: 202414 RVA: 0x00B72FC4 File Offset: 0x00B711C4
		private bool CheckCanOpen(EUiViewName viewName, object _)
		{
			if (this.LevelModeData == null)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("ErrorCode_2500068_Text", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x060316AF RID: 202415 RVA: 0x00B72FE5 File Offset: 0x00B711E5
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

		// Token: 0x060316B0 RID: 202416 RVA: 0x00B73024 File Offset: 0x00B71224
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

		// Token: 0x060316B1 RID: 202417 RVA: 0x00B7315C File Offset: 0x00B7135C
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

		// Token: 0x060316B2 RID: 202418 RVA: 0x00B733B0 File Offset: 0x00B715B0
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

		// Token: 0x060316B3 RID: 202419 RVA: 0x00B733F8 File Offset: 0x00B715F8
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

		// Token: 0x060316B4 RID: 202420 RVA: 0x00B7346D File Offset: 0x00B7166D
		public int ComposeMachineId(ITrapDefenseMachineIdInfo info)
		{
			return (int)(info.MachineType * (ETrapDefenseMachineType)1000000 + info.DataType * 10000 + info.Level * 100 + info.Branch);
		}

		// Token: 0x060316B5 RID: 202421 RVA: 0x00B7349C File Offset: 0x00B7169C
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

		// Token: 0x060316B6 RID: 202422 RVA: 0x00B734E4 File Offset: 0x00B716E4
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

		// Token: 0x060316B7 RID: 202423 RVA: 0x00B73510 File Offset: 0x00B71710
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

		// Token: 0x060316B8 RID: 202424 RVA: 0x00B73544 File Offset: 0x00B71744
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

		// Token: 0x060316B9 RID: 202425 RVA: 0x00B735AC File Offset: 0x00B717AC
		public bool GetCurInstIsRogue()
		{
			TrapDefenseLevelData curInstToLevelData = this.GetCurInstToLevelData();
			return curInstToLevelData != null && curInstToLevelData.Config.ModeType != 1;
		}

		// Token: 0x060316BA RID: 202426 RVA: 0x00B735D8 File Offset: 0x00B717D8
		public bool IsInMainline()
		{
			TrapDefenseLevelData curInstToLevelData = this.GetCurInstToLevelData();
			return curInstToLevelData != null && curInstToLevelData.Config.ModeType == 1;
		}

		// Token: 0x060316BB RID: 202427 RVA: 0x00B73600 File Offset: 0x00B71800
		public bool GetCurInstToLevelDataHasShop()
		{
			TrapDefenseLevelData curInstToLevelData = this.GetCurInstToLevelData();
			return curInstToLevelData != null && curInstToLevelData.HasShop;
		}

		// Token: 0x060316BC RID: 202428 RVA: 0x00B7361F File Offset: 0x00B7181F
		public void BdBuffSelectProcessFinish()
		{
			this.ViewModeBdBuffSelect.ViewProcessFinish();
			this.CheckIsNeedOpenBdBuffSelectView();
		}

		// Token: 0x060316BD RID: 202429 RVA: 0x00B73634 File Offset: 0x00B71834
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

		// Token: 0x060316BE RID: 202430 RVA: 0x00B7369C File Offset: 0x00B7189C
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

		// Token: 0x060316BF RID: 202431 RVA: 0x00B73754 File Offset: 0x00B71954
		public void OpenViewBdSum(bool? isInInstance = null, ETrapDefenseBdTabType? jumpTab = null, int? jumpId = null)
		{
			bool isInstance = isInInstance ?? TowerDefenseEventController.Instance.IsTowerDefenseEventInstance();
			this.ViewModelBdSum.SetIsInstance(isInstance);
			this.ViewModelBdSum.SetJumpTabType(jumpTab);
			this.ViewModelBdSum.SetJumpBdId(jumpId);
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseBdSumView, null, null);
		}

		// Token: 0x060316C0 RID: 202432 RVA: 0x00B737B8 File Offset: 0x00B719B8
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

		// Token: 0x060316C1 RID: 202433 RVA: 0x00B7385F File Offset: 0x00B71A5F
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

		// Token: 0x060316C2 RID: 202434 RVA: 0x00B7389C File Offset: 0x00B71A9C
		public void OpenViewBdBuffNewGet(int buffId, bool isCheckBdProgress = true)
		{
			TrapDefenseBdBuffData trapDefenseBdBuffData;
			TrapDefenseBdBuffData lastGetBdBuffData = this.RougeModeData.BdBuffDataMap.TryGetValue(buffId, out trapDefenseBdBuffData) ? trapDefenseBdBuffData : this.RougeModeData.BdBuffDataList[0];
			this.RougeModeData.SetLastGetBdBuffData(lastGetBdBuffData);
			this.RougeModeData.SetIsCheckBdProgress(isCheckBdProgress);
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseBdBuffGetView, null, null);
		}

		// Token: 0x060316C3 RID: 202435 RVA: 0x00B738FC File Offset: 0x00B71AFC
		public void OpenViewBdBuffStrengthen(int buffId, bool isCheckBdProgress = true)
		{
			TrapDefenseBdBuffData trapDefenseBdBuffData;
			TrapDefenseBdBuffData lastGetBdBuffData = this.RougeModeData.BdBuffDataMap.TryGetValue(buffId, out trapDefenseBdBuffData) ? trapDefenseBdBuffData : this.RougeModeData.BdBuffDataList[0];
			this.RougeModeData.SetLastGetBdBuffData(lastGetBdBuffData);
			this.RougeModeData.SetIsCheckBdProgress(isCheckBdProgress);
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseBdBuffStrengthenView, null, null);
		}

		// Token: 0x060316C4 RID: 202436 RVA: 0x00B7395C File Offset: 0x00B71B5C
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

		// Token: 0x060316C5 RID: 202437 RVA: 0x00B739E8 File Offset: 0x00B71BE8
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

		// Token: 0x060316C6 RID: 202438 RVA: 0x00B73A36 File Offset: 0x00B71C36
		public void OpenViewLimitReward()
		{
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseRewardView, null, null);
		}

		// Token: 0x060316C7 RID: 202439 RVA: 0x00B73A49 File Offset: 0x00B71C49
		[NullableContext(2)]
		public void OpenViewTalentTree(ITrapDefenseTalentTreeViewParam param = null)
		{
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseTalentTreeView, param, null);
		}

		// Token: 0x060316C8 RID: 202440 RVA: 0x00B73A5C File Offset: 0x00B71C5C
		public void OpenMainEntryView()
		{
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseMainView, null, null);
		}

		// Token: 0x060316C9 RID: 202441 RVA: 0x00B73A6F File Offset: 0x00B71C6F
		public void OpenViewFixedReward()
		{
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseFixedRewardView, null, null);
		}

		// Token: 0x060316CA RID: 202442 RVA: 0x00B73A84 File Offset: 0x00B71C84
		public void OpenViewMainLevelMode(int? id = null, ETrapDefenseDifficultyLevel? difficulty = null, bool? isInst = null)
		{
			bool isInstance = isInst ?? TowerDefenseEventController.Instance.IsTowerDefenseEventInstance();
			this.ViewModelMainLevel.SetJumpLevelData(id);
			this.ViewModelMainLevel.SetJumpDifficulty(difficulty);
			this.ViewModelMainLevel.SetIsInstance(isInstance);
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseMainLevelView, null, null);
		}

		// Token: 0x060316CB RID: 202443 RVA: 0x00B73AE8 File Offset: 0x00B71CE8
		public void OpenViewRougeLevelMode(int? id = null, bool? isInst = null)
		{
			bool isInstance = isInst ?? TowerDefenseEventController.Instance.IsTowerDefenseEventInstance();
			this.ViewModelRougeLevel.SetJumpLevelData(id);
			this.ViewModelRougeLevel.SetIsInstance(isInstance);
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseRougeLevelView, null, null);
		}

		// Token: 0x060316CC RID: 202444 RVA: 0x00B73B3D File Offset: 0x00B71D3D
		public void OpenViewShop()
		{
			UiManager.Instance.OpenView(EUiViewName.TrapDefenseShopView, null, null);
		}

		// Token: 0x060316CD RID: 202445 RVA: 0x00B73B50 File Offset: 0x00B71D50
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

		// Token: 0x060316CE RID: 202446 RVA: 0x00B73BD0 File Offset: 0x00B71DD0
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

		// Token: 0x060316CF RID: 202447 RVA: 0x00B73CBC File Offset: 0x00B71EBC
		private void TryUpdateBdBuffAllUpdateNotify()
		{
			if (this.ResponseCacheBdBuff == null)
			{
				return;
			}
			this.ProtoBdBuffAllUpdateNotify(this.ResponseCacheBdBuff);
			this.ResponseCacheBdBuff = null;
		}

		// Token: 0x060316D0 RID: 202448 RVA: 0x00B73CDC File Offset: 0x00B71EDC
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

		// Token: 0x060316D1 RID: 202449 RVA: 0x00B73DA4 File Offset: 0x00B71FA4
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

		// Token: 0x060316D2 RID: 202450 RVA: 0x00B73DDC File Offset: 0x00B71FDC
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

		// Token: 0x060316D3 RID: 202451 RVA: 0x00B73E54 File Offset: 0x00B72054
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

		// Token: 0x060316D4 RID: 202452 RVA: 0x00B73EA0 File Offset: 0x00B720A0
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

		// Token: 0x060316D5 RID: 202453 RVA: 0x00B73F14 File Offset: 0x00B72114
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

		// Token: 0x060316D6 RID: 202454 RVA: 0x00B73F84 File Offset: 0x00B72184
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

		// Token: 0x060316D7 RID: 202455 RVA: 0x00B73FE8 File Offset: 0x00B721E8
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

		// Token: 0x060316D8 RID: 202456 RVA: 0x00B74094 File Offset: 0x00B72294
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

		// Token: 0x060316D9 RID: 202457 RVA: 0x00B740FC File Offset: 0x00B722FC
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

		// Token: 0x060316DA RID: 202458 RVA: 0x00B74190 File Offset: 0x00B72390
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

		// Token: 0x060316DB RID: 202459 RVA: 0x00B7420B File Offset: 0x00B7240B
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

		// Token: 0x060316DC RID: 202460 RVA: 0x00B7423D File Offset: 0x00B7243D
		public void ProtoShopInitNotify(TrapDefenseShopPanelInfo response)
		{
			TrapDefenseShopData shopData = this.ShopData;
			if (shopData != null)
			{
				shopData.UpdateByServerData(response);
			}
			EventSystem.Instance.Emit(EEventName.TrapDefenseShopRefresh);
		}

		// Token: 0x060316DD RID: 202461 RVA: 0x00B74261 File Offset: 0x00B72461
		public void ProtoShopPurchaseResponse(TrapDefenseShopPanelInfo response, int purchasedId)
		{
			TrapDefenseShopData shopData = this.ShopData;
			if (shopData != null)
			{
				shopData.UpdateByServerData(response);
			}
			EventSystem.Instance.Emit(EEventName.TrapDefenseShopRefresh);
		}

		// Token: 0x060316DE RID: 202462 RVA: 0x00B74288 File Offset: 0x00B72488
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

		// Token: 0x17007ADD RID: 31453
		// (get) Token: 0x060316DF RID: 202463 RVA: 0x00B74312 File Offset: 0x00B72512
		public static TrapDefenseModel Instance
		{
			get
			{
				return TrapDefenseModel._Instance;
			}
		}

		// Token: 0x060316E0 RID: 202464 RVA: 0x00B74319 File Offset: 0x00B72519
		public static TrapDefenseModel GetOrCreateInstance()
		{
			if (TrapDefenseModel._Instance == null)
			{
				TrapDefenseModel.CreateInstance();
			}
			return TrapDefenseModel._Instance;
		}

		// Token: 0x060316E1 RID: 202465 RVA: 0x00B7432D File Offset: 0x00B7252D
		public static bool CreateInstance()
		{
			if (TrapDefenseModel._Instance != null)
			{
				return true;
			}
			TrapDefenseModel._Instance = new TrapDefenseModel();
			return true;
		}

		// Token: 0x060316E2 RID: 202466 RVA: 0x00B74343 File Offset: 0x00B72543
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060316E3 RID: 202467 RVA: 0x00B74345 File Offset: 0x00B72545
		public static void ResetStaticDefaultValue()
		{
			TrapDefenseModel._Instance = null;
		}

		// Token: 0x060316E4 RID: 202468 RVA: 0x00B7434D File Offset: 0x00B7254D
		static TrapDefenseModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TrapDefenseModel.CreateStaticDefaultValue), new Action(TrapDefenseModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401A6E6 RID: 108262
		public TrapDefenseLevelModeData LevelModeData;

		// Token: 0x0401A6E7 RID: 108263
		public TrapDefenseRougeModeData RougeModeData;

		// Token: 0x0401A6E8 RID: 108264
		public TrapDefenseRewardData RewardData;

		// Token: 0x0401A6E9 RID: 108265
		public TrapDefenseTalentTreeData TalentTreeData;

		// Token: 0x0401A6EA RID: 108266
		public readonly Dictionary<int, TrapDefenseLevelData> LevelDataFromInstIdMap = new Dictionary<int, TrapDefenseLevelData>();

		// Token: 0x0401A6EB RID: 108267
		public readonly Dictionary<int, TrapDefenseLevelData> LevelDataFromIdMap = new Dictionary<int, TrapDefenseLevelData>();

		// Token: 0x0401A6EC RID: 108268
		public Dictionary<EUiViewName, Func<EUiViewName, object, bool>> CheckCanOpenViewMap = new Dictionary<EUiViewName, Func<EUiViewName, object, bool>>();

		// Token: 0x0401A6ED RID: 108269
		public TrapDefenseBdSumViewModel ViewModelBdSum;

		// Token: 0x0401A6EE RID: 108270
		public TrapDefenseBdQualityViewModel ViewModelBdQuality;

		// Token: 0x0401A6EF RID: 108271
		public TrapDefenseBdBuffSelectViewModel ViewModeBdBuffSelect;

		// Token: 0x0401A6F0 RID: 108272
		public TrapDefenseRewardViewModel ViewModelReward;

		// Token: 0x0401A6F1 RID: 108273
		public TrapDefenseMonsterViewModel ViewModelMonster;

		// Token: 0x0401A6F2 RID: 108274
		public TrapDefenseTalentTreeViewModel ViewModelTalentTree;

		// Token: 0x0401A6F3 RID: 108275
		public TrapDefenseFixedRewardViewModel ViewModelFixedReward;

		// Token: 0x0401A6F4 RID: 108276
		public TrapDefenseMainLevelViewModel ViewModelMainLevel;

		// Token: 0x0401A6F5 RID: 108277
		public TrapDefenseRougeLevelViewModel ViewModelRougeLevel;

		// Token: 0x0401A6F6 RID: 108278
		public TrapDefenseShopViewModel ViewModelShop;

		// Token: 0x0401A6F7 RID: 108279
		public TrapDefenseBattleData BattleData;

		// Token: 0x0401A6F8 RID: 108280
		public TrapDefenseMapModel MapData;

		// Token: 0x0401A6F9 RID: 108281
		public TrapDefenseShopData ShopData;

		// Token: 0x0401A6FA RID: 108282
		public TrapDefenseBattleInventoryData BattleInventoryData;

		// Token: 0x0401A6FB RID: 108283
		public TrapDefenseBuildingDevelopViewModel ViewModelBuildingDevelop;

		// Token: 0x0401A6FC RID: 108284
		public bool NeedOpenMainView;

		// Token: 0x0401A6FD RID: 108285
		public bool IsSkipMachineFullCheck;

		// Token: 0x0401A6FE RID: 108286
		[Nullable(2)]
		private TrapDefenseSyncGainingGroupsNotify ResponseCacheBdBuff;

		// Token: 0x0401A6FF RID: 108287
		[Nullable(2)]
		private static TrapDefenseModel _Instance;
	}
}
