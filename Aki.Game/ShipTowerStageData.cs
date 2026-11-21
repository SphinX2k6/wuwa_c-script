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

// Token: 0x02001F14 RID: 7956
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerStageData
{
	// Token: 0x06013AE0 RID: 80608 RVA: 0x005BD9A0 File Offset: 0x005BBBA0
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

	// Token: 0x06013AE1 RID: 80609 RVA: 0x005BDA24 File Offset: 0x005BBC24
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

	// Token: 0x06013AE2 RID: 80610 RVA: 0x005BDAE8 File Offset: 0x005BBCE8
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

	// Token: 0x06013AE3 RID: 80611 RVA: 0x005BDB64 File Offset: 0x005BBD64
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

	// Token: 0x06013AE4 RID: 80612 RVA: 0x005BDBE8 File Offset: 0x005BBDE8
	public bool IsPassed()
	{
		if (this.IsHaveProtoData)
		{
			return this.ProtoIsPassed;
		}
		return this.CurrentIsPassed();
	}

	// Token: 0x06013AE5 RID: 80613 RVA: 0x005BDBFF File Offset: 0x005BBDFF
	public bool CurrentIsPassed()
	{
		return this.CurrentScore >= this.PassScore;
	}

	// Token: 0x06013AE6 RID: 80614 RVA: 0x005BDC12 File Offset: 0x005BBE12
	public bool CanReset()
	{
		return this.IsTeamSetRoleFinish();
	}

	// Token: 0x06013AE7 RID: 80615 RVA: 0x005BDC1C File Offset: 0x005BBE1C
	public bool IsNewRecord(int? currentScore = null)
	{
		return (currentScore ?? this.CurrentScore) > this.LastScore;
	}

	// Token: 0x06013AE8 RID: 80616 RVA: 0x005BDC4B File Offset: 0x005BBE4B
	public bool IsNotChallenge()
	{
		return !this.IsTeamSetBuffFinish() || !this.IsTeamSetRoleFinish();
	}

	// Token: 0x06013AE9 RID: 80617 RVA: 0x005BDC60 File Offset: 0x005BBE60
	public void SetOrderIndex(int index)
	{
		this.OrderIndex = index;
	}

	// Token: 0x06013AEA RID: 80618 RVA: 0x005BDC69 File Offset: 0x005BBE69
	public bool IsCurrent()
	{
		return this.IsUnLocked() && !this.IsPassed();
	}

	// Token: 0x06013AEB RID: 80619 RVA: 0x005BDC80 File Offset: 0x005BBE80
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

	// Token: 0x06013AEC RID: 80620 RVA: 0x005BDCD0 File Offset: 0x005BBED0
	public void OpenViewPassBuffShow()
	{
		ShipTowerModel.Instance.OpenViewPassBuffShow(new ShipTowerPassBuffShowViewParams
		{
			StageData = this
		});
	}

	// Token: 0x06013AED RID: 80621 RVA: 0x005BDCE8 File Offset: 0x005BBEE8
	public void OpenViewTeamRecommend()
	{
		ShipTowerModel.Instance.OpenViewTeamRecommend(new ShipTowerTeamRecommendViewParams
		{
			StageData = this
		});
	}

	// Token: 0x06013AEE RID: 80622 RVA: 0x005BDD00 File Offset: 0x005BBF00
	public void OpenViewMonsterDesc(int? instId = null)
	{
		ShipTowerModel.Instance.OpenViewMonsterDesc(new ShipTowerMonsterDescViewParams
		{
			StageData = this,
			InstId = instId
		});
	}

	// Token: 0x06013AEF RID: 80623 RVA: 0x005BDD20 File Offset: 0x005BBF20
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

	// Token: 0x06013AF0 RID: 80624 RVA: 0x005BDD54 File Offset: 0x005BBF54
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

	// Token: 0x06013AF1 RID: 80625 RVA: 0x005BDDD0 File Offset: 0x005BBFD0
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

	// Token: 0x06013AF2 RID: 80626 RVA: 0x005BDE91 File Offset: 0x005BC091
	[NullableContext(2)]
	public string GetStageGradeResIdByScore(int score)
	{
		return ShipTowerModel.Instance.GetStageGradeResIdByScore(score, this.TargetScoreList.ToArray(), this.ScoreStageList.ToArray());
	}

	// Token: 0x06013AF3 RID: 80627 RVA: 0x005BDEB4 File Offset: 0x005BC0B4
	[NullableContext(2)]
	public string GetShareStageGradeResIdByScore(int score)
	{
		return ShipTowerModel.Instance.GetShareStageGradeResIdByScore(score, this.TargetScoreList.ToArray(), this.ScoreStageList.ToArray());
	}

	// Token: 0x06013AF4 RID: 80628 RVA: 0x005BDED8 File Offset: 0x005BC0D8
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

	// Token: 0x06013AF5 RID: 80629 RVA: 0x005BDF80 File Offset: 0x005BC180
	public void UpdateCurSelectTeamIndex(int index)
	{
		if (this.CurSelectTeamIndex == index)
		{
			return;
		}
		this.CurSelectTeamIndex = index;
	}

	// Token: 0x06013AF6 RID: 80630 RVA: 0x005BDF94 File Offset: 0x005BC194
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

	// Token: 0x06013AF7 RID: 80631 RVA: 0x005BE000 File Offset: 0x005BC200
	public void UpdateAllTeamRoleToModel()
	{
		ShipTowerModel.Instance.ClearAllTeamRoleData();
		foreach (ShipTowerTeamData shipTowerTeamData in this.TeamDataList)
		{
			shipTowerTeamData.UpdateAllTeamRoleToShipTowerModel();
		}
	}

	// Token: 0x06013AF8 RID: 80632 RVA: 0x005BE05C File Offset: 0x005BC25C
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

	// Token: 0x06013AF9 RID: 80633 RVA: 0x005BE0DC File Offset: 0x005BC2DC
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

	// Token: 0x06013AFA RID: 80634 RVA: 0x005BE1A8 File Offset: 0x005BC3A8
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

	// Token: 0x06013AFB RID: 80635 RVA: 0x005BE200 File Offset: 0x005BC400
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

	// Token: 0x06013AFC RID: 80636 RVA: 0x005BE25C File Offset: 0x005BC45C
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

	// Token: 0x06013AFD RID: 80637 RVA: 0x005BE2B8 File Offset: 0x005BC4B8
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

	// Token: 0x06013AFE RID: 80638 RVA: 0x005BE314 File Offset: 0x005BC514
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

	// Token: 0x06013AFF RID: 80639 RVA: 0x005BE370 File Offset: 0x005BC570
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

	// Token: 0x06013B00 RID: 80640 RVA: 0x005BE3DC File Offset: 0x005BC5DC
	public int GetChallengeInstId()
	{
		return this.InstIds[0];
	}

	// Token: 0x06013B01 RID: 80641 RVA: 0x005BE3EC File Offset: 0x005BC5EC
	private void UpdateCurrentScore()
	{
		int num = 0;
		foreach (ShipTowerTeamData shipTowerTeamData in this.TeamDataList)
		{
			num += shipTowerTeamData.CurrentScore;
		}
		this.CurrentScore = num;
	}

	// Token: 0x06013B02 RID: 80642 RVA: 0x005BE44C File Offset: 0x005BC64C
	private void UpdateCurrentScoreAndSaveLast()
	{
		this.UpdateCurrentScore();
		this.SaveLastData();
	}

	// Token: 0x06013B03 RID: 80643 RVA: 0x005BE45C File Offset: 0x005BC65C
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

	// Token: 0x06013B04 RID: 80644 RVA: 0x005BE669 File Offset: 0x005BC869
	public void ProtoNotifyInitData(SlashLevelPlayInfo data)
	{
		this.ProtoUpdateDataBase(data);
		this.UpdateCurrentScore();
		this.SaveLastData();
		EventSystem.Instance.Emit<int>(EEventName.ShipTowerStageUpdate, this.Id);
	}

	// Token: 0x06013B05 RID: 80645 RVA: 0x005BE694 File Offset: 0x005BC894
	public void ProtoNotifyUpdateData(SlashLevelPlayInfo data)
	{
		this.ProtoUpdateDataBase(data);
		this.UpdateCurrentScore();
		EventSystem.Instance.Emit<int>(EEventName.ShipTowerStageUpdate, this.Id);
	}

	// Token: 0x06013B06 RID: 80646 RVA: 0x005BE6B9 File Offset: 0x005BC8B9
	public void SaveLastData()
	{
		this.LastIsPass = this.IsPassed();
		this.LastScore = this.CurrentScore;
		this.IsNeedSureScore = (this.LastScore > 0);
	}

	// Token: 0x06013B07 RID: 80647 RVA: 0x005BE6E2 File Offset: 0x005BC8E2
	public bool CheckPass(int newScore = 0)
	{
		return newScore >= this.PassScore;
	}

	// Token: 0x06013B08 RID: 80648 RVA: 0x005BE6F0 File Offset: 0x005BC8F0
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

	// Token: 0x06013B09 RID: 80649 RVA: 0x005BE741 File Offset: 0x005BC941
	public void GotoDescFromInstance()
	{
		ShipTowerModel.Instance.OpenViewMain(new ShipTowerViewParams
		{
			StageId = new int?(this.Id),
			IsOpenStageDesc = new bool?(true),
			IsFromInstanceDungeon = new bool?(true)
		});
	}

	// Token: 0x06013B0A RID: 80650 RVA: 0x005BE77C File Offset: 0x005BC97C
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

	// Token: 0x06013B0B RID: 80651 RVA: 0x005BE7D0 File Offset: 0x005BC9D0
	public UniTask SureResetStage()
	{
		ShipTowerStageData.<SureResetStage>d__70 <SureResetStage>d__;
		<SureResetStage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SureResetStage>d__.<>4__this = this;
		<SureResetStage>d__.<>1__state = -1;
		<SureResetStage>d__.<>t__builder.Start<ShipTowerStageData.<SureResetStage>d__70>(ref <SureResetStage>d__);
		return <SureResetStage>d__.<>t__builder.Task;
	}

	// Token: 0x06013B0C RID: 80652 RVA: 0x005BE814 File Offset: 0x005BCA14
	public void ResetStage()
	{
		foreach (ShipTowerTeamData shipTowerTeamData in this.TeamDataList)
		{
			shipTowerTeamData.ResetStage();
		}
		this.ResetQuickPass();
		this.UpdateCurrentScoreAndSaveLast();
	}

	// Token: 0x06013B0D RID: 80653 RVA: 0x005BE870 File Offset: 0x005BCA70
	public UniTask SureCoverChallenge()
	{
		ShipTowerStageData.<SureCoverChallenge>d__72 <SureCoverChallenge>d__;
		<SureCoverChallenge>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SureCoverChallenge>d__.<>4__this = this;
		<SureCoverChallenge>d__.<>1__state = -1;
		<SureCoverChallenge>d__.<>t__builder.Start<ShipTowerStageData.<SureCoverChallenge>d__72>(ref <SureCoverChallenge>d__);
		return <SureCoverChallenge>d__.<>t__builder.Task;
	}

	// Token: 0x06013B0E RID: 80654 RVA: 0x005BE8B4 File Offset: 0x005BCAB4
	public void CoverChallenge()
	{
		foreach (ShipTowerTeamData shipTowerTeamData in this.TeamDataList)
		{
			shipTowerTeamData.CoverChallenge();
		}
		this.ResetQuickPass();
		this.UpdateCurrentScoreAndSaveLast();
	}

	// Token: 0x06013B0F RID: 80655 RVA: 0x005BE910 File Offset: 0x005BCB10
	public void UpdateNewChallengeScore()
	{
		this.NewChallengeScore = 0;
		foreach (ShipTowerTeamData shipTowerTeamData in this.TeamDataList)
		{
			this.NewChallengeScore += shipTowerTeamData.NewChallengeScore;
		}
	}

	// Token: 0x06013B10 RID: 80656 RVA: 0x005BE978 File Offset: 0x005BCB78
	public void UpdateToEdit()
	{
		foreach (ShipTowerTeamData shipTowerTeamData in this.TeamDataList)
		{
			shipTowerTeamData.UpdateToEdit();
		}
	}

	// Token: 0x06013B11 RID: 80657 RVA: 0x005BE9C8 File Offset: 0x005BCBC8
	public void CopyTeamRoleToEdit(int targetId)
	{
		ShipTowerStageData stageDataById = ShipTowerModel.Instance.GetStageDataById(targetId);
		for (int i = 0; i < this.TeamDataList.Count; i++)
		{
			this.TeamDataList[i].CopyTeamRoleToEdit(stageDataById.TeamDataList[i]);
		}
	}

	// Token: 0x06013B12 RID: 80658 RVA: 0x005BEA14 File Offset: 0x005BCC14
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

	// Token: 0x06013B13 RID: 80659 RVA: 0x005BEA84 File Offset: 0x005BCC84
	public UniTask RequestTeamRecommendList()
	{
		ShipTowerStageData.<RequestTeamRecommendList>d__78 <RequestTeamRecommendList>d__;
		<RequestTeamRecommendList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestTeamRecommendList>d__.<>4__this = this;
		<RequestTeamRecommendList>d__.<>1__state = -1;
		<RequestTeamRecommendList>d__.<>t__builder.Start<ShipTowerStageData.<RequestTeamRecommendList>d__78>(ref <RequestTeamRecommendList>d__);
		return <RequestTeamRecommendList>d__.<>t__builder.Task;
	}

	// Token: 0x06013B14 RID: 80660 RVA: 0x005BEAC8 File Offset: 0x005BCCC8
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

	// Token: 0x06013B15 RID: 80661 RVA: 0x005BECF0 File Offset: 0x005BCEF0
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

	// Token: 0x06013B16 RID: 80662 RVA: 0x005BEEB0 File Offset: 0x005BD0B0
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

	// Token: 0x06013B17 RID: 80663 RVA: 0x005BEFBC File Offset: 0x005BD1BC
	public void UpdateMainRoleToEdit()
	{
		foreach (ShipTowerTeamData shipTowerTeamData in this.TeamDataList)
		{
			shipTowerTeamData.UpdateMainRoleToEdit();
		}
	}

	// Token: 0x06013B18 RID: 80664 RVA: 0x005BF00C File Offset: 0x005BD20C
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

	// Token: 0x06013B19 RID: 80665 RVA: 0x005BF098 File Offset: 0x005BD298
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

	// Token: 0x06013B1A RID: 80666 RVA: 0x005BF0F3 File Offset: 0x005BD2F3
	[NullableContext(2)]
	public ShipTowerTeamData GetCurSelectTeamData()
	{
		if (this.CurSelectTeamIndex < this.TeamDataList.Count)
		{
			return this.TeamDataList[this.CurSelectTeamIndex];
		}
		return null;
	}

	// Token: 0x06013B1B RID: 80667 RVA: 0x005BF11B File Offset: 0x005BD31B
	private void ResetQuickPass()
	{
		this.IsQuickPass = false;
	}

	// Token: 0x0400A85C RID: 43100
	public int Id;

	// Token: 0x0400A85D RID: 43101
	public int OrderIndex;

	// Token: 0x0400A85E RID: 43102
	public EShipTowerStageType StageType;

	// Token: 0x0400A85F RID: 43103
	public int Season;

	// Token: 0x0400A860 RID: 43104
	public bool IsEndLess;

	// Token: 0x0400A861 RID: 43105
	public bool IsQuickPass;

	// Token: 0x0400A862 RID: 43106
	public List<int> InstIds;

	// Token: 0x0400A863 RID: 43107
	public List<int> PreLevel;

	// Token: 0x0400A864 RID: 43108
	public string TitleKey;

	// Token: 0x0400A865 RID: 43109
	public string DescKey;

	// Token: 0x0400A866 RID: 43110
	public List<int> TargetScoreList;

	// Token: 0x0400A867 RID: 43111
	public List<string> ScoreStageList;

	// Token: 0x0400A868 RID: 43112
	public int CurrentScore;

	// Token: 0x0400A869 RID: 43113
	public int PassScore;

	// Token: 0x0400A86A RID: 43114
	public int PassReward;

	// Token: 0x0400A86B RID: 43115
	private readonly List<TItem> PassRewardItems;

	// Token: 0x0400A86C RID: 43116
	public readonly List<ShipTowerTeamData> TeamDataList;

	// Token: 0x0400A86D RID: 43117
	public bool ProtoIsUnLocked;

	// Token: 0x0400A86E RID: 43118
	public int NewChallengeScore;

	// Token: 0x0400A86F RID: 43119
	public bool IsHaveProtoData;

	// Token: 0x0400A870 RID: 43120
	public bool LastIsPass;

	// Token: 0x0400A871 RID: 43121
	public int LastScore;

	// Token: 0x0400A872 RID: 43122
	public bool IsNeedSureScore;

	// Token: 0x0400A873 RID: 43123
	public int BelongToSeason;

	// Token: 0x0400A874 RID: 43124
	public bool ProtoIsPassed;

	// Token: 0x0400A875 RID: 43125
	public List<ShipTowerTeamRecommendItemData> TeamRecommendList;

	// Token: 0x0400A876 RID: 43126
	public int CurSelectTeamIndex;
}
