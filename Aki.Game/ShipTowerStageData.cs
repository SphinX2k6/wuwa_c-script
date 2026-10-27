using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02002999 RID: 10649
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerStageData
{
	// Token: 0x060160DA RID: 90330 RVA: 0x005929DC File Offset: 0x00590BDC
	public ShipTowerStageData()
	{
		this.OrderIndex = 1;
		this.StageType = EShipTowerStageType.OneTimeStage;
		this.InstIds = new List<int>();
		this.PreLevel = new List<int>();
		this.TitleKey = "";
		this.DescKey = "";
		this.TargetScoreList = new List<int>();
		this.ScoreStageList = new List<string>();
		this.PassRewardItems = new List<TItem>();
		this.TeamDataList = new List<ShipTowerTeamData>();
		this.TeamRecommendList = new List<ShipTowerTeamRecommendItemData>();
	}

	// Token: 0x060160DB RID: 90331 RVA: 0x00592A60 File Offset: 0x00590C60
	public void Init(SlashAndTowerCfg cfg)
	{
		this.Id = cfg.Id;
		this.Season = cfg.Season;
		this.IsEndLess = cfg.EndLess;
		this.InstIds = new List<int>(cfg.InstIds());
		this.PreLevel = new List<int>(cfg.PreLevel());
		this.PassScore = cfg.PassScore;
		this.PassReward = cfg.LevelPassReward;
		this.TitleKey = cfg.Title;
		this.DescKey = cfg.Desc;
		this.TargetScoreList = new List<int>(cfg.TargetScore());
		this.ScoreStageList = new List<string>(cfg.ScoreStage());
		this.BelongToSeason = cfg.Season;
		this.AfterInit();
	}

	// Token: 0x060160DC RID: 90332 RVA: 0x00592B24 File Offset: 0x00590D24
	private void AfterInit()
	{
		if (this.IsEndLess)
		{
			this.StageType = EShipTowerStageType.EndlessStage;
		}
		else if (this.Season == 0)
		{
			this.StageType = EShipTowerStageType.OneTimeStage;
		}
		else
		{
			this.StageType = EShipTowerStageType.RefreshStage;
		}
		for (int i = 0; i < this.InstIds.Count; i++)
		{
			int instId = this.InstIds[i];
			ShipTowerTeamData shipTowerTeamData = new ShipTowerTeamData();
			shipTowerTeamData.Init(instId, i, this.Id);
			this.TeamDataList.Add(shipTowerTeamData);
		}
	}

	// Token: 0x060160DD RID: 90333 RVA: 0x00592BA0 File Offset: 0x00590DA0
	public bool IsUnLocked()
	{
		if (this.IsHaveProtoData)
		{
			return this.ProtoIsUnLocked;
		}
		if (this.PreLevel.Count == 0)
		{
			return true;
		}
		foreach (int id in this.PreLevel)
		{
			if (!ShipTowerModel.Instance.GetStageDataById(id).IsPassed())
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060160DE RID: 90334 RVA: 0x00592C24 File Offset: 0x00590E24
	public bool IsPassed()
	{
		if (this.IsHaveProtoData)
		{
			return this.ProtoIsPassed;
		}
		return this.CurrentIsPassed();
	}

	// Token: 0x060160DF RID: 90335 RVA: 0x00592C3B File Offset: 0x00590E3B
	public bool CurrentIsPassed()
	{
		return this.CurrentScore >= this.PassScore;
	}

	// Token: 0x060160E0 RID: 90336 RVA: 0x00592C4E File Offset: 0x00590E4E
	public bool CanReset()
	{
		return this.IsTeamSetRoleFinish();
	}

	// Token: 0x060160E1 RID: 90337 RVA: 0x00592C58 File Offset: 0x00590E58
	public bool IsNewRecord(int? currentScore = null)
	{
		return (currentScore ?? this.CurrentScore) > this.LastScore;
	}

	// Token: 0x060160E2 RID: 90338 RVA: 0x00592C87 File Offset: 0x00590E87
	public bool IsNotChallenge()
	{
		return !this.IsTeamSetBuffFinish() || !this.IsTeamSetRoleFinish();
	}

	// Token: 0x060160E3 RID: 90339 RVA: 0x00592C9C File Offset: 0x00590E9C
	public void SetOrderIndex(int index)
	{
		this.OrderIndex = index;
	}

	// Token: 0x060160E4 RID: 90340 RVA: 0x00592CA5 File Offset: 0x00590EA5
	public bool IsCurrent()
	{
		return this.IsUnLocked() && !this.IsPassed();
	}

	// Token: 0x060160E5 RID: 90341 RVA: 0x00592CBC File Offset: 0x00590EBC
	public void OpenViewStageDesc()
	{
		if (!this.IsUnLocked())
		{
			string text = "GhostShipLevelNotUnlock_Text";
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(text, text);
			ScrollingTipsController.Instance.ShowTipsByText(multiTextByKey);
			return;
		}
		ShipTowerModel.Instance.OpenViewDesc(new ShipTowerDescViewParams
		{
			StageId = this.Id
		}, null);
	}

	// Token: 0x060160E6 RID: 90342 RVA: 0x00592D0C File Offset: 0x00590F0C
	public void OpenViewPassBuffShow()
	{
		ShipTowerModel.Instance.OpenViewPassBuffShow(new ShipTowerPassBuffShowViewParams
		{
			StageData = this
		});
	}

	// Token: 0x060160E7 RID: 90343 RVA: 0x00592D24 File Offset: 0x00590F24
	public void OpenViewTeamRecommend()
	{
		ShipTowerModel.Instance.OpenViewTeamRecommend(new ShipTowerTeamRecommendViewParams
		{
			StageData = this
		});
	}

	// Token: 0x060160E8 RID: 90344 RVA: 0x00592D3C File Offset: 0x00590F3C
	public void OpenViewMonsterDesc(int? instId = null)
	{
		ShipTowerModel.Instance.OpenViewMonsterDesc(new ShipTowerMonsterDescViewParams
		{
			StageData = this,
			InstId = instId
		});
	}

	// Token: 0x060160E9 RID: 90345 RVA: 0x00592D5C File Offset: 0x00590F5C
	public List<ShipTowerScoreInfoData> GetTargetScoreInfoList()
	{
		List<ShipTowerScoreInfoData> list = new List<ShipTowerScoreInfoData>();
		ShipTowerScoreInfoData passTargetScoreInfo = this.GetPassTargetScoreInfo();
		if (passTargetScoreInfo != null)
		{
			list.Add(passTargetScoreInfo);
		}
		ShipTowerScoreInfoData challengeTargetScoreInfo = this.GetChallengeTargetScoreInfo();
		list.Add(challengeTargetScoreInfo);
		return list;
	}

	// Token: 0x060160EA RID: 90346 RVA: 0x00592D90 File Offset: 0x00590F90
	[NullableContext(2)]
	private ShipTowerScoreInfoData GetPassTargetScoreInfo()
	{
		if (this.IsEndLess)
		{
			return null;
		}
		string text = "GhostShipLevelPass_Text";
		string text2 = "GhostShipLevelPoints_Text";
		return new ShipTowerScoreInfoData
		{
			Title = TextConfig.Instance.GetMultiTextByKey(text, text),
			TargetList = new List<ShipTowerScoreTargetData>
			{
				new ShipTowerScoreTargetData
				{
					Title = TextConfig.Instance.GetMultiTextByKey(text2, text2),
					ScoreTarget = this.PassScore,
					IsFinish = this.CurrentIsPassed()
				}
			}
		};
	}

	// Token: 0x060160EB RID: 90347 RVA: 0x00592E0C File Offset: 0x0059100C
	private ShipTowerScoreInfoData GetChallengeTargetScoreInfo()
	{
		string text = "GhostShipLevelPoints_Text";
		string text2 = "GhostShipLevelChallenge_Text";
		List<ShipTowerScoreTargetData> list = new List<ShipTowerScoreTargetData>();
		ShipTowerScoreInfoData result = new ShipTowerScoreInfoData
		{
			Title = TextConfig.Instance.GetMultiTextByKey(text2, text2),
			TargetList = list
		};
		for (int i = 0; i < this.TargetScoreList.Count; i++)
		{
			int num = this.TargetScoreList[i];
			string stageGradeResId = ShipTowerModel.Instance.GetStageGradeResId(this.ScoreStageList[i]);
			list.Add(new ShipTowerScoreTargetData
			{
				Title = TextConfig.Instance.GetMultiTextByKey(text, text),
				ScoreTarget = num,
				IsFinish = (this.CurrentScore >= num),
				ScoreGradeRes = stageGradeResId
			});
		}
		return result;
	}

	// Token: 0x060160EC RID: 90348 RVA: 0x00592ECD File Offset: 0x005910CD
	[NullableContext(2)]
	public string GetStageGradeResIdByScore(int score)
	{
		return ShipTowerModel.Instance.GetStageGradeResIdByScore(score, this.TargetScoreList.ToArray(), this.ScoreStageList.ToArray());
	}

	// Token: 0x060160ED RID: 90349 RVA: 0x00592EF0 File Offset: 0x005910F0
	[NullableContext(2)]
	public string GetShareStageGradeResIdByScore(int score)
	{
		return ShipTowerModel.Instance.GetShareStageGradeResIdByScore(score, this.TargetScoreList.ToArray(), this.ScoreStageList.ToArray());
	}

	// Token: 0x060160EE RID: 90350 RVA: 0x00592F14 File Offset: 0x00591114
	public List<TItem> GetPassUnlockBuffList()
	{
		if (this.PassReward > 0 && this.PassRewardItems.Count == 0)
		{
			DropPackage? dropPackage = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(this.PassReward);
			if (dropPackage != null)
			{
				foreach (DicIntInt dicIntInt in dropPackage.Value.DropPreviewIter())
				{
					int key = dicIntInt.Key;
					this.PassRewardItems.Add(new TItem(new InventoryDefine.GetItemData(key, 0), 0));
				}
			}
		}
		return this.PassRewardItems;
	}

	// Token: 0x060160EF RID: 90351 RVA: 0x00592FBC File Offset: 0x005911BC
	public void UpdateCurSelectTeamIndex(int index)
	{
		if (this.CurSelectTeamIndex == index)
		{
			return;
		}
		this.CurSelectTeamIndex = index;
	}

	// Token: 0x060160F0 RID: 90352 RVA: 0x00592FD0 File Offset: 0x005911D0
	public void UpdateOtherTeamRoleToModel(int index)
	{
		ShipTowerModel.Instance.ClearOtherTeamRoleData();
		foreach (ShipTowerTeamData shipTowerTeamData in this.TeamDataList)
		{
			if (shipTowerTeamData.Index != index)
			{
				shipTowerTeamData.UpdateOtherTeamRoleToShipTowerModel();
				shipTowerTeamData.UpdateRoleIndexInAllTeam();
			}
		}
	}

	// Token: 0x060160F1 RID: 90353 RVA: 0x0059303C File Offset: 0x0059123C
	public void UpdateAllTeamRoleToModel()
	{
		ShipTowerModel.Instance.ClearAllTeamRoleData();
		foreach (ShipTowerTeamData shipTowerTeamData in this.TeamDataList)
		{
			shipTowerTeamData.UpdateAllTeamRoleToShipTowerModel();
		}
	}

	// Token: 0x060160F2 RID: 90354 RVA: 0x00593098 File Offset: 0x00591298
	public bool UpdateOtherTeamRoleRepeat(int index, int? roleId = null)
	{
		ShipTowerTeamData indexTeamData = this.TeamDataList[index];
		bool flag = false;
		foreach (ShipTowerTeamData shipTowerTeamData in this.TeamDataList)
		{
			if (shipTowerTeamData.Index != index)
			{
				flag = (shipTowerTeamData.UpdateOtherTeamRoleRepeat(indexTeamData) || flag);
				shipTowerTeamData.RemoveRoleIdEdit(roleId);
			}
		}
		this.UpdateOtherTeamRoleToModel(index);
		return flag;
	}

	// Token: 0x060160F3 RID: 90355 RVA: 0x00593118 File Offset: 0x00591318
	public void ExchangeTeamData()
	{
		bool flag = true;
		using (List<ShipTowerTeamData>.Enumerator enumerator = this.TeamDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.TeamIsEmpty())
				{
					flag = false;
					break;
				}
			}
		}
		if (flag)
		{
			return;
		}
		ShipTowerTeamData curSelectTeamData = this.GetCurSelectTeamData();
		ShipTowerTeamData shipTowerTeamData = null;
		foreach (ShipTowerTeamData shipTowerTeamData2 in this.TeamDataList)
		{
			if (shipTowerTeamData2 != curSelectTeamData)
			{
				shipTowerTeamData = shipTowerTeamData2;
				break;
			}
		}
		if (curSelectTeamData != null && shipTowerTeamData != null)
		{
			curSelectTeamData.ExChangeTeamData(shipTowerTeamData);
			this.UpdateOtherTeamRoleToModel(curSelectTeamData.Index);
			this.UpdateAllTeamRoleToModel();
		}
	}

	// Token: 0x060160F4 RID: 90356 RVA: 0x005931E4 File Offset: 0x005913E4
	public bool StartChallenge()
	{
		if (!this.IsTeamSetRoleFinishEdit())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("GhostShipConditionTeamError_Text", Array.Empty<object>());
			return false;
		}
		if (!this.IsTeamSetBuffFinishEdit())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("GhostShipConditionBuffError_Text2", Array.Empty<object>());
			return false;
		}
		ShipTowerModel.Instance.StartChallenge(this);
		return true;
	}

	// Token: 0x060160F5 RID: 90357 RVA: 0x0059323C File Offset: 0x0059143C
	public bool IsTeamSetRoleFinish()
	{
		using (List<ShipTowerTeamData>.Enumerator enumerator = this.TeamDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.IsSetRoleFinish())
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x060160F6 RID: 90358 RVA: 0x00593298 File Offset: 0x00591498
	public bool IsTeamSetRoleFinishEdit()
	{
		using (List<ShipTowerTeamData>.Enumerator enumerator = this.TeamDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.IsSetRoleFinishEdit())
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x060160F7 RID: 90359 RVA: 0x005932F4 File Offset: 0x005914F4
	public bool IsTeamSetBuffFinish()
	{
		using (List<ShipTowerTeamData>.Enumerator enumerator = this.TeamDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.IsSetBuffFinish())
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x060160F8 RID: 90360 RVA: 0x00593350 File Offset: 0x00591550
	public bool IsTeamSetBuffFinishEdit()
	{
		using (List<ShipTowerTeamData>.Enumerator enumerator = this.TeamDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.IsSetBuffFinishEdit())
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x060160F9 RID: 90361 RVA: 0x005933AC File Offset: 0x005915AC
	public List<int> GetAllTeamBuffIdList()
	{
		List<int> list = new List<int>();
		foreach (ShipTowerTeamData shipTowerTeamData in this.TeamDataList)
		{
			List<int> list2 = list;
			ShipTowerBuffData buffDataEdit = shipTowerTeamData.BuffDataEdit;
			list2.Add((buffDataEdit != null) ? buffDataEdit.Id : 0);
		}
		return list;
	}

	// Token: 0x060160FA RID: 90362 RVA: 0x00593418 File Offset: 0x00591618
	public int GetChallengeInstId()
	{
		return this.InstIds[0];
	}

	// Token: 0x060160FB RID: 90363 RVA: 0x00593428 File Offset: 0x00591628
	private void UpdateCurrentScore()
	{
		int num = 0;
		foreach (ShipTowerTeamData shipTowerTeamData in this.TeamDataList)
		{
			num += shipTowerTeamData.CurrentScore;
		}
		this.CurrentScore = num;
	}

	// Token: 0x060160FC RID: 90364 RVA: 0x00593488 File Offset: 0x00591688
	private void UpdateCurrentScoreAndSaveLast()
	{
		this.UpdateCurrentScore();
		this.SaveLastData();
	}

	// Token: 0x060160FD RID: 90365 RVA: 0x00593498 File Offset: 0x00591698
	public void ProtoUpdateDataBase(SlashLevelPlayInfo data)
	{
		this.IsHaveProtoData = true;
		this.ProtoIsUnLocked = data.UnLock;
		this.ProtoIsPassed = data.LevelPass;
		ShipTowerTeamData shipTowerTeamData = this.TeamDataList[0];
		ShipTowerTeamData shipTowerTeamData2 = this.TeamDataList[1];
		this.IsQuickPass = data.IsEasyPass;
		int num = 0;
		for (;;)
		{
			int num2 = num;
			BattleFormation firstBattle = data.FirstBattle;
			int? num3 = (firstBattle != null) ? new int?(firstBattle.SelectRoles.Count) : null;
			if (!(num2 < num3.GetValueOrDefault() & num3 != null))
			{
				break;
			}
			int roleId = data.FirstBattle.SelectRoles[num];
			shipTowerTeamData.ProtoSetRole(roleId, num);
			BattleFormation firstBattle2 = data.FirstBattle;
			int skillBranchId = (((firstBattle2 != null) ? firstBattle2.SkillBranchIds : null) != null && num < data.FirstBattle.SkillBranchIds.Count) ? data.FirstBattle.SkillBranchIds[num] : 0;
			shipTowerTeamData.ProtoSetSkillBranch(skillBranchId, num);
			num++;
		}
		ShipTowerTeamData shipTowerTeamData3 = shipTowerTeamData;
		BattleFormation firstBattle3 = data.FirstBattle;
		shipTowerTeamData3.ProtoSetBuff((firstBattle3 != null) ? new int?(firstBattle3.BuffSelect) : null);
		shipTowerTeamData.UpdateCurrentScore(data.SlashFirstScore);
		int num4 = 0;
		for (;;)
		{
			int num5 = num4;
			BattleFormation secondBattle = data.SecondBattle;
			int? num3 = (secondBattle != null) ? new int?(secondBattle.SelectRoles.Count) : null;
			if (!(num5 < num3.GetValueOrDefault() & num3 != null))
			{
				break;
			}
			int roleId2 = data.SecondBattle.SelectRoles[num4];
			shipTowerTeamData2.ProtoSetRole(roleId2, num4);
			BattleFormation secondBattle2 = data.SecondBattle;
			int skillBranchId2 = (((secondBattle2 != null) ? secondBattle2.SkillBranchIds : null) != null && num4 < data.SecondBattle.SkillBranchIds.Count) ? data.SecondBattle.SkillBranchIds[num4] : 0;
			shipTowerTeamData2.ProtoSetSkillBranch(skillBranchId2, num4);
			num4++;
		}
		ShipTowerTeamData shipTowerTeamData4 = shipTowerTeamData2;
		BattleFormation secondBattle3 = data.SecondBattle;
		shipTowerTeamData4.ProtoSetBuff((secondBattle3 != null) ? new int?(secondBattle3.BuffSelect) : null);
		shipTowerTeamData2.UpdateCurrentScore(data.SlashSecondScore);
	}

	// Token: 0x060160FE RID: 90366 RVA: 0x005936A5 File Offset: 0x005918A5
	public void ProtoNotifyInitData(SlashLevelPlayInfo data)
	{
		this.ProtoUpdateDataBase(data);
		this.UpdateCurrentScore();
		this.SaveLastData();
		EventSystem.Instance.Emit<int>(EEventName.ShipTowerStageUpdate, this.Id);
	}

	// Token: 0x060160FF RID: 90367 RVA: 0x005936D0 File Offset: 0x005918D0
	public void ProtoNotifyUpdateData(SlashLevelPlayInfo data)
	{
		this.ProtoUpdateDataBase(data);
		this.UpdateCurrentScore();
		EventSystem.Instance.Emit<int>(EEventName.ShipTowerStageUpdate, this.Id);
	}

	// Token: 0x06016100 RID: 90368 RVA: 0x005936F5 File Offset: 0x005918F5
	public void SaveLastData()
	{
		this.LastIsPass = this.IsPassed();
		this.LastScore = this.CurrentScore;
		this.IsNeedSureScore = (this.LastScore > 0);
	}

	// Token: 0x06016101 RID: 90369 RVA: 0x0059371E File Offset: 0x0059191E
	public bool CheckPass(int newScore = 0)
	{
		return newScore >= this.PassScore;
	}

	// Token: 0x06016102 RID: 90370 RVA: 0x0059372C File Offset: 0x0059192C
	public void SureResultFromInstance()
	{
		ShipTowerModel.Instance.OpenViewMain(new ShipTowerViewParams
		{
			StageId = new int?(this.Id),
			IsOpenStageDesc = new bool?(true),
			IsOpenCover = new bool?(true),
			IsFromInstanceDungeon = new bool?(true)
		});
	}

	// Token: 0x06016103 RID: 90371 RVA: 0x0059377D File Offset: 0x0059197D
	public void GotoDescFromInstance()
	{
		ShipTowerModel.Instance.OpenViewMain(new ShipTowerViewParams
		{
			StageId = new int?(this.Id),
			IsOpenStageDesc = new bool?(true),
			IsFromInstanceDungeon = new bool?(true)
		});
	}

	// Token: 0x06016104 RID: 90372 RVA: 0x005937B8 File Offset: 0x005919B8
	public void GotoNextDescFromInstance(ShipTowerStageData nextStageData)
	{
		ShipTowerModel.Instance.OpenViewMain(new ShipTowerViewParams
		{
			StageId = new int?(nextStageData.Id),
			IsOpenStageDesc = new bool?(true),
			IsFromInstanceDungeon = new bool?(true),
			ApplyTeamEditStageId = this.Id
		});
	}

	// Token: 0x06016105 RID: 90373 RVA: 0x0059380C File Offset: 0x00591A0C
	public UniTask SureResetStage()
	{
		ShipTowerStageData.<SureResetStage>d__70 <SureResetStage>d__;
		<SureResetStage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SureResetStage>d__.<>4__this = this;
		<SureResetStage>d__.<>1__state = -1;
		<SureResetStage>d__.<>t__builder.Start<ShipTowerStageData.<SureResetStage>d__70>(ref <SureResetStage>d__);
		return <SureResetStage>d__.<>t__builder.Task;
	}

	// Token: 0x06016106 RID: 90374 RVA: 0x00593850 File Offset: 0x00591A50
	public void ResetStage()
	{
		foreach (ShipTowerTeamData shipTowerTeamData in this.TeamDataList)
		{
			shipTowerTeamData.ResetStage();
		}
		this.ResetQuickPass();
		this.UpdateCurrentScoreAndSaveLast();
	}

	// Token: 0x06016107 RID: 90375 RVA: 0x005938AC File Offset: 0x00591AAC
	public UniTask SureCoverChallenge()
	{
		ShipTowerStageData.<SureCoverChallenge>d__72 <SureCoverChallenge>d__;
		<SureCoverChallenge>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SureCoverChallenge>d__.<>4__this = this;
		<SureCoverChallenge>d__.<>1__state = -1;
		<SureCoverChallenge>d__.<>t__builder.Start<ShipTowerStageData.<SureCoverChallenge>d__72>(ref <SureCoverChallenge>d__);
		return <SureCoverChallenge>d__.<>t__builder.Task;
	}

	// Token: 0x06016108 RID: 90376 RVA: 0x005938F0 File Offset: 0x00591AF0
	public void CoverChallenge()
	{
		foreach (ShipTowerTeamData shipTowerTeamData in this.TeamDataList)
		{
			shipTowerTeamData.CoverChallenge();
		}
		this.ResetQuickPass();
		this.UpdateCurrentScoreAndSaveLast();
	}

	// Token: 0x06016109 RID: 90377 RVA: 0x0059394C File Offset: 0x00591B4C
	public void UpdateNewChallengeScore()
	{
		this.NewChallengeScore = 0;
		foreach (ShipTowerTeamData shipTowerTeamData in this.TeamDataList)
		{
			this.NewChallengeScore += shipTowerTeamData.NewChallengeScore;
		}
	}

	// Token: 0x0601610A RID: 90378 RVA: 0x005939B4 File Offset: 0x00591BB4
	public void UpdateToEdit()
	{
		foreach (ShipTowerTeamData shipTowerTeamData in this.TeamDataList)
		{
			shipTowerTeamData.UpdateToEdit();
		}
	}

	// Token: 0x0601610B RID: 90379 RVA: 0x00593A04 File Offset: 0x00591C04
	public void CopyTeamRoleToEdit(int targetId)
	{
		ShipTowerStageData stageDataById = ShipTowerModel.Instance.GetStageDataById(targetId);
		for (int i = 0; i < this.TeamDataList.Count; i++)
		{
			this.TeamDataList[i].CopyTeamRoleToEdit(stageDataById.TeamDataList[i]);
		}
	}

	// Token: 0x0601610C RID: 90380 RVA: 0x00593A50 File Offset: 0x00591C50
	public void ProtoTeamEditFromResult(SlashAndTowerResultNotify result)
	{
		ShipTowerTeamData shipTowerTeamData = this.TeamDataList[0];
		ShipTowerTeamData shipTowerTeamData2 = this.TeamDataList[1];
		shipTowerTeamData.ProtoTeamEditFromResult(result.FirstFormation);
		shipTowerTeamData2.ProtoTeamEditFromResult(result.SecondFormation);
		int score = result.FirstKillMonsterScore + result.FirstRoundScore;
		int score2 = result.SecondKillMonsterScore + result.SecondRoundScore;
		shipTowerTeamData.ProtoSetNewChallengeScore(score);
		shipTowerTeamData2.ProtoSetNewChallengeScore(score2);
		this.UpdateNewChallengeScore();
	}

	// Token: 0x0601610D RID: 90381 RVA: 0x00593AC0 File Offset: 0x00591CC0
	public UniTask RequestTeamRecommendList()
	{
		ShipTowerStageData.<RequestTeamRecommendList>d__78 <RequestTeamRecommendList>d__;
		<RequestTeamRecommendList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestTeamRecommendList>d__.<>4__this = this;
		<RequestTeamRecommendList>d__.<>1__state = -1;
		<RequestTeamRecommendList>d__.<>t__builder.Start<ShipTowerStageData.<RequestTeamRecommendList>d__78>(ref <RequestTeamRecommendList>d__);
		return <RequestTeamRecommendList>d__.<>t__builder.Task;
	}

	// Token: 0x0601610E RID: 90382 RVA: 0x00593B04 File Offset: 0x00591D04
	public void ProtoUpdateTeamRecommendList(SlashAndTowerRecommendResponse response)
	{
		this.TeamRecommendList.Clear();
		for (int i = 0; i < response.RecommendInfos.Count; i++)
		{
			SlashLevelRecommend slashLevelRecommend = response.RecommendInfos[i];
			List<ShipTowerMediumItemData> list = new List<ShipTowerMediumItemData>();
			List<ShipTowerMediumItemData> list2 = new List<ShipTowerMediumItemData>();
			BattleFormation formationFirst = slashLevelRecommend.FormationFirst;
			if (((formationFirst != null) ? formationFirst.SelectRoles : null) != null)
			{
				for (int j = 0; j < slashLevelRecommend.FormationFirst.SelectRoles.Count; j++)
				{
					int id = slashLevelRecommend.FormationFirst.SelectRoles[j];
					int skillBranchId = (slashLevelRecommend.FormationFirst.SkillBranchIds != null && j < slashLevelRecommend.FormationFirst.SkillBranchIds.Count) ? slashLevelRecommend.FormationFirst.SkillBranchIds[j] : 0;
					list.Add(new ShipTowerMediumItemData
					{
						Id = id,
						Count = 0,
						SkillBranchId = skillBranchId
					});
				}
			}
			BattleFormation formationSecond = slashLevelRecommend.FormationSecond;
			if (((formationSecond != null) ? formationSecond.SelectRoles : null) != null)
			{
				for (int k = 0; k < slashLevelRecommend.FormationSecond.SelectRoles.Count; k++)
				{
					int id2 = slashLevelRecommend.FormationSecond.SelectRoles[k];
					int skillBranchId2 = (slashLevelRecommend.FormationSecond.SkillBranchIds != null && k < slashLevelRecommend.FormationSecond.SkillBranchIds.Count) ? slashLevelRecommend.FormationSecond.SkillBranchIds[k] : 0;
					list2.Add(new ShipTowerMediumItemData
					{
						Id = id2,
						Count = 0,
						SkillBranchId = skillBranchId2
					});
				}
			}
			int num = 100;
			ShipTowerTeamRecommendItemData shipTowerTeamRecommendItemData = new ShipTowerTeamRecommendItemData();
			shipTowerTeamRecommendItemData.UseRate = slashLevelRecommend.Usage / num;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(i + 1);
			shipTowerTeamRecommendItemData.Name = defaultInterpolatedStringHandler.ToStringAndClear();
			shipTowerTeamRecommendItemData.RoleIdList1 = list;
			shipTowerTeamRecommendItemData.RoleIdList2 = list2;
			BattleFormation formationFirst2 = slashLevelRecommend.FormationFirst;
			shipTowerTeamRecommendItemData.Buff1 = ((formationFirst2 != null) ? formationFirst2.BuffSelect : 0);
			BattleFormation formationSecond2 = slashLevelRecommend.FormationSecond;
			shipTowerTeamRecommendItemData.Buff2 = ((formationSecond2 != null) ? formationSecond2.BuffSelect : 0);
			shipTowerTeamRecommendItemData.StageData = this;
			ShipTowerTeamRecommendItemData item = shipTowerTeamRecommendItemData;
			this.TeamRecommendList.Add(item);
		}
	}

	// Token: 0x0601610F RID: 90383 RVA: 0x00593D2C File Offset: 0x00591F2C
	public bool UseTeamRecommend(ShipTowerTeamRecommendItemData data)
	{
		ShipTowerTeamData shipTowerTeamData = this.TeamDataList[0];
		ShipTowerTeamData shipTowerTeamData2 = this.TeamDataList[1];
		List<int> list = new List<int>();
		foreach (ShipTowerMediumItemData shipTowerMediumItemData in data.RoleIdList1)
		{
			list.Add(shipTowerMediumItemData.Id);
		}
		List<int> list2 = new List<int>();
		foreach (ShipTowerMediumItemData shipTowerMediumItemData2 in data.RoleIdList2)
		{
			list2.Add(shipTowerMediumItemData2.Id);
		}
		shipTowerTeamData.CopyIdsToEdit(list);
		shipTowerTeamData2.CopyIdsToEdit(list2);
		shipTowerTeamData.CopyBuffIdToEdit(data.Buff1, this.Id);
		shipTowerTeamData2.CopyBuffIdToEdit(data.Buff2, this.Id);
		foreach (ShipTowerMediumItemData shipTowerMediumItemData3 in data.RoleIdList1)
		{
			RoleModel.Instance.SetRoleSkillBranchGamePlayCache(shipTowerMediumItemData3.Id, shipTowerMediumItemData3.SkillBranchId, ESkillBranchCacheType.ShipTower);
		}
		foreach (ShipTowerMediumItemData shipTowerMediumItemData4 in data.RoleIdList2)
		{
			RoleModel.Instance.SetRoleSkillBranchGamePlayCache(shipTowerMediumItemData4.Id, shipTowerMediumItemData4.SkillBranchId, ESkillBranchCacheType.ShipTower);
		}
		EventSystem.Instance.Emit<int>(EEventName.ShipTowerTeamRecommendApplyFinish, this.Id);
		return true;
	}

	// Token: 0x06016110 RID: 90384 RVA: 0x00593EEC File Offset: 0x005920EC
	public bool IsCanApplyTeamRecommend(ShipTowerTeamRecommendItemData data)
	{
		ShipTowerBuffData buffDataByBuffId = ShipTowerModel.Instance.GetBuffDataByBuffId(data.Buff1);
		if (buffDataByBuffId != null && buffDataByBuffId.IsCanUse(new int?(this.Id)))
		{
			return true;
		}
		ShipTowerBuffData buffDataByBuffId2 = ShipTowerModel.Instance.GetBuffDataByBuffId(data.Buff2);
		if (buffDataByBuffId2 != null && buffDataByBuffId2.IsCanUse(new int?(this.Id)))
		{
			return true;
		}
		foreach (ShipTowerMediumItemData shipTowerMediumItemData in data.RoleIdList1)
		{
			if (ShipTowerModel.Instance.IsCanUseRole(shipTowerMediumItemData.Id))
			{
				return true;
			}
		}
		foreach (ShipTowerMediumItemData shipTowerMediumItemData2 in data.RoleIdList2)
		{
			if (ShipTowerModel.Instance.IsCanUseRole(shipTowerMediumItemData2.Id))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06016111 RID: 90385 RVA: 0x00593FF8 File Offset: 0x005921F8
	public void UpdateMainRoleToEdit()
	{
		foreach (ShipTowerTeamData shipTowerTeamData in this.TeamDataList)
		{
			shipTowerTeamData.UpdateMainRoleToEdit();
		}
	}

	// Token: 0x06016112 RID: 90386 RVA: 0x00594048 File Offset: 0x00592248
	public bool IsOldSeasonData()
	{
		if (this.IsTeamSetRoleFinish() && !this.IsTeamSetBuffFinish())
		{
			return true;
		}
		foreach (ShipTowerTeamData shipTowerTeamData in this.TeamDataList)
		{
			if (shipTowerTeamData.BuffData != null)
			{
				ShipTowerModel instance = ShipTowerModel.Instance;
				if (instance != null && instance.IsOldSeason(shipTowerTeamData.BuffData.Season))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06016113 RID: 90387 RVA: 0x005940D4 File Offset: 0x005922D4
	[NullableContext(2)]
	public ShipTowerTeamData GetCurrentTeamData()
	{
		int instanceId = CreatureModel.Instance.GetInstanceId();
		int num = -1;
		for (int i = 0; i < this.TeamDataList.Count; i++)
		{
			if (this.TeamDataList[i].InstId == instanceId)
			{
				num = i;
				break;
			}
		}
		return this.TeamDataList[(num >= 0) ? num : 0];
	}

	// Token: 0x06016114 RID: 90388 RVA: 0x0059412F File Offset: 0x0059232F
	[NullableContext(2)]
	public ShipTowerTeamData GetCurSelectTeamData()
	{
		if (this.CurSelectTeamIndex < this.TeamDataList.Count)
		{
			return this.TeamDataList[this.CurSelectTeamIndex];
		}
		return null;
	}

	// Token: 0x06016115 RID: 90389 RVA: 0x00594157 File Offset: 0x00592357
	private void ResetQuickPass()
	{
		this.IsQuickPass = false;
	}

	// Token: 0x0400A472 RID: 42098
	public int Id;

	// Token: 0x0400A473 RID: 42099
	public int OrderIndex;

	// Token: 0x0400A474 RID: 42100
	public EShipTowerStageType StageType;

	// Token: 0x0400A475 RID: 42101
	public int Season;

	// Token: 0x0400A476 RID: 42102
	public bool IsEndLess;

	// Token: 0x0400A477 RID: 42103
	public bool IsQuickPass;

	// Token: 0x0400A478 RID: 42104
	public List<int> InstIds;

	// Token: 0x0400A479 RID: 42105
	public List<int> PreLevel;

	// Token: 0x0400A47A RID: 42106
	public string TitleKey;

	// Token: 0x0400A47B RID: 42107
	public string DescKey;

	// Token: 0x0400A47C RID: 42108
	public List<int> TargetScoreList;

	// Token: 0x0400A47D RID: 42109
	public List<string> ScoreStageList;

	// Token: 0x0400A47E RID: 42110
	public int CurrentScore;

	// Token: 0x0400A47F RID: 42111
	public int PassScore;

	// Token: 0x0400A480 RID: 42112
	public int PassReward;

	// Token: 0x0400A481 RID: 42113
	private readonly List<TItem> PassRewardItems;

	// Token: 0x0400A482 RID: 42114
	public readonly List<ShipTowerTeamData> TeamDataList;

	// Token: 0x0400A483 RID: 42115
	public bool ProtoIsUnLocked;

	// Token: 0x0400A484 RID: 42116
	public int NewChallengeScore;

	// Token: 0x0400A485 RID: 42117
	public bool IsHaveProtoData;

	// Token: 0x0400A486 RID: 42118
	public bool LastIsPass;

	// Token: 0x0400A487 RID: 42119
	public int LastScore;

	// Token: 0x0400A488 RID: 42120
	public bool IsNeedSureScore;

	// Token: 0x0400A489 RID: 42121
	public int BelongToSeason;

	// Token: 0x0400A48A RID: 42122
	public bool ProtoIsPassed;

	// Token: 0x0400A48B RID: 42123
	public List<ShipTowerTeamRecommendItemData> TeamRecommendList;

	// Token: 0x0400A48C RID: 42124
	public int CurSelectTeamIndex;
}
