using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x0200299A RID: 10650
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerTeamData
{
	// Token: 0x06016116 RID: 90390 RVA: 0x00594160 File Offset: 0x00592360
	public ShipTowerTeamData()
	{
		this.RoleList = new List<ShipTowerRoleData>();
		this.TeamInstName = "";
		this.AreaName = "";
		this.TeamName = "";
	}

	// Token: 0x06016117 RID: 90391 RVA: 0x00594194 File Offset: 0x00592394
	public void Init(int instId, int index, int stageId)
	{
		this.InstId = instId;
		this.Index = index;
		this.StageId = stageId;
		InstanceDungeon? instanceDungeonCfg = this.GetInstanceDungeonCfg(null);
		this.TeamInstName = (((instanceDungeonCfg != null) ? instanceDungeonCfg.GetValueOrDefault().MapName : null) ?? "MapName");
		string teamName = (index == 0) ? "GhostShipTeamName_Text1" : "GhostShipTeamName_Text2";
		this.TeamName = teamName;
		string areaName = (index == 0) ? "GhostShipTeamName_Text3" : "GhostShipTeamName_Text4";
		this.AreaName = areaName;
		for (int i = 0; i < 3; i++)
		{
			ShipTowerRoleData item = new ShipTowerRoleData
			{
				RoleId = 0,
				RoleIdEdit = 0,
				TeamIndex = index,
				TeamId = 0,
				PositionIndex = i,
				BelongTo = ((index == 0) ? ETeamBelong.FirstPart : ETeamBelong.LowPart),
				SkillBranchId = 0,
				SkillBranchIdEdit = 0
			};
			this.RoleList.Add(item);
		}
	}

	// Token: 0x06016118 RID: 90392 RVA: 0x00594282 File Offset: 0x00592482
	public List<ShipTowerRoleData> GetUseRoleList()
	{
		return this.RoleList;
	}

	// Token: 0x06016119 RID: 90393 RVA: 0x0059428C File Offset: 0x0059248C
	public void UpdateToEdit()
	{
		foreach (ShipTowerRoleData shipTowerRoleData in this.RoleList)
		{
			this.UpdateRoleIdEdit(shipTowerRoleData, shipTowerRoleData.RoleId, false);
			shipTowerRoleData.SkillBranchIdEdit = shipTowerRoleData.SkillBranchId;
		}
		this.UpdateBuffDataEdit(this.BuffData);
	}

	// Token: 0x0601611A RID: 90394 RVA: 0x00594300 File Offset: 0x00592500
	public void CopyTeamRoleToEdit(ShipTowerTeamData targetTeamData)
	{
		for (int i = 0; i < this.RoleList.Count; i++)
		{
			ShipTowerRoleData shipTowerRoleData = this.RoleList[i];
			ShipTowerRoleData shipTowerRoleData2 = (i < targetTeamData.RoleList.Count) ? targetTeamData.RoleList[i] : null;
			int roleId = (shipTowerRoleData2 != null) ? shipTowerRoleData2.RoleIdEdit : 0;
			this.UpdateRoleIdEdit(shipTowerRoleData, roleId, false);
			shipTowerRoleData.SkillBranchId = ((shipTowerRoleData2 != null) ? shipTowerRoleData2.SkillBranchId : 0);
		}
	}

	// Token: 0x0601611B RID: 90395 RVA: 0x00594378 File Offset: 0x00592578
	public void CopyIdsToEdit(List<int> roleIdList)
	{
		for (int i = 0; i < this.RoleList.Count; i++)
		{
			ShipTowerRoleData data = this.RoleList[i];
			int roleId = (i < roleIdList.Count) ? roleIdList[i] : 0;
			this.UpdateRoleIdEdit(data, roleId, true);
		}
	}

	// Token: 0x0601611C RID: 90396 RVA: 0x005943C8 File Offset: 0x005925C8
	public void UpdateRoleListByModel()
	{
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		foreach (ShipTowerRoleData shipTowerRoleData in this.RoleList)
		{
			int roleIndexInAllTeam = this.GetRoleIndexInAllTeam(shipTowerRoleData.PositionIndex + 1);
			int roleId = 0;
			RoleDataBase roleDataBase;
			if (roleIndexMap.TryGetValue(roleIndexInAllTeam, out roleDataBase))
			{
				roleId = roleDataBase.GetDataId();
			}
			this.UpdateRoleIdEdit(shipTowerRoleData, roleId, false);
		}
	}

	// Token: 0x0601611D RID: 90397 RVA: 0x00594450 File Offset: 0x00592650
	public void UpdateRoleListByFormationData(FormationData formationData)
	{
		RoleSelectModel.Instance.ClearData();
		for (int i = 0; i < this.RoleList.Count; i++)
		{
			ShipTowerRoleData shipTowerRoleData = this.RoleList[i];
			int roleId = (i < formationData.RoleIdList.Count) ? formationData.RoleIdList[i] : 0;
			this.UpdateRoleIdEdit(shipTowerRoleData, roleId, false);
			this.AddRoleDataToRoleSelectModel(shipTowerRoleData, true);
		}
	}

	// Token: 0x0601611E RID: 90398 RVA: 0x005944BC File Offset: 0x005926BC
	public void UpdateRoleListToRoleSelectModel()
	{
		RoleSelectModel.Instance.ClearData();
		foreach (ShipTowerRoleData shipTowerRoleData in this.RoleList)
		{
			this.AddRoleDataToRoleSelectModel(shipTowerRoleData, true);
		}
	}

	// Token: 0x0601611F RID: 90399 RVA: 0x0059451C File Offset: 0x0059271C
	private void AddRoleDataToRoleSelectModel(ShipTowerRoleData shipTowerRoleData, bool addSet = true)
	{
		int roleIndexInAllTeam = this.GetRoleIndexInAllTeam(shipTowerRoleData.PositionIndex + 1);
		if (shipTowerRoleData.RoleIdEdit == 0)
		{
			RoleSelectModel.Instance.RoleIndexMap.Remove(roleIndexInAllTeam);
			return;
		}
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(shipTowerRoleData.RoleIdEdit, true);
		if (roleDataById != null)
		{
			if (RoleSelectModel.Instance.RoleIndexMap.ContainsKey(roleIndexInAllTeam))
			{
				RoleSelectModel.Instance.RoleIndexMap[roleIndexInAllTeam] = roleDataById;
			}
			else
			{
				RoleSelectModel.Instance.RoleIndexMap.Add(roleIndexInAllTeam, roleDataById);
			}
			if (addSet)
			{
				RoleSelectModel.Instance.SelectedRoleSet.Add(roleDataById.GetDataId());
			}
		}
	}

	// Token: 0x06016120 RID: 90400 RVA: 0x005945B6 File Offset: 0x005927B6
	public int GetRoleIndexInAllTeam(int pos)
	{
		return this.Index * 3 + pos;
	}

	// Token: 0x06016121 RID: 90401 RVA: 0x005945C4 File Offset: 0x005927C4
	public void UpdateOtherTeamRoleToShipTowerModel()
	{
		foreach (ShipTowerRoleData roleData in this.RoleList)
		{
			ShipTowerModel.Instance.AddOtherTeamRoleData(roleData);
		}
	}

	// Token: 0x06016122 RID: 90402 RVA: 0x0059461C File Offset: 0x0059281C
	public void UpdateAllTeamRoleToShipTowerModel()
	{
		foreach (ShipTowerRoleData roleData in this.RoleList)
		{
			ShipTowerModel.Instance.AddAllTeamRoleData(roleData);
		}
	}

	// Token: 0x06016123 RID: 90403 RVA: 0x00594674 File Offset: 0x00592874
	public bool UpdateOtherTeamRoleRepeat(ShipTowerTeamData indexTeamData)
	{
		List<int> roleIdListEdit = indexTeamData.GetRoleIdListEdit();
		bool result = false;
		foreach (ShipTowerRoleData shipTowerRoleData in this.RoleList)
		{
			if (shipTowerRoleData.RoleIdEdit != 0 && roleIdListEdit.Contains(shipTowerRoleData.RoleIdEdit))
			{
				this.UpdateRoleIdEdit(shipTowerRoleData, 0, false);
				result = true;
			}
		}
		return result;
	}

	// Token: 0x06016124 RID: 90404 RVA: 0x005946EC File Offset: 0x005928EC
	public void RemoveRoleIdEdit(int? roleId = null)
	{
		if (roleId == null || roleId.Value == 0)
		{
			return;
		}
		foreach (ShipTowerRoleData shipTowerRoleData in this.RoleList)
		{
			if (shipTowerRoleData.RoleIdEdit == roleId.Value)
			{
				this.UpdateRoleIdEdit(shipTowerRoleData, 0, false);
			}
		}
	}

	// Token: 0x06016125 RID: 90405 RVA: 0x00594764 File Offset: 0x00592964
	public void UpdateRoleIndexInAllTeam()
	{
		foreach (ShipTowerRoleData shipTowerRoleData in this.RoleList)
		{
			this.AddRoleDataToRoleSelectModel(shipTowerRoleData, false);
		}
	}

	// Token: 0x06016126 RID: 90406 RVA: 0x005947B8 File Offset: 0x005929B8
	[NullableContext(2)]
	public void UseBuff(ShipTowerBuffData buffData = null)
	{
		this.UpdateBuffDataEdit(buffData);
	}

	// Token: 0x06016127 RID: 90407 RVA: 0x005947C4 File Offset: 0x005929C4
	public bool IsSetRoleFinish()
	{
		using (List<ShipTowerRoleData>.Enumerator enumerator = this.RoleList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.RoleId <= 0)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x06016128 RID: 90408 RVA: 0x00594820 File Offset: 0x00592A20
	public bool IsSetRoleFinishEdit()
	{
		using (List<ShipTowerRoleData>.Enumerator enumerator = this.RoleList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.RoleIdEdit <= 0)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x06016129 RID: 90409 RVA: 0x0059487C File Offset: 0x00592A7C
	public bool IsSetBuffFinish()
	{
		return this.BuffData != null;
	}

	// Token: 0x0601612A RID: 90410 RVA: 0x00594887 File Offset: 0x00592A87
	public bool IsSetBuffFinishEdit()
	{
		return this.BuffDataEdit != null;
	}

	// Token: 0x0601612B RID: 90411 RVA: 0x00594894 File Offset: 0x00592A94
	public bool TeamIsEmpty()
	{
		if (this.IsSetBuffFinishEdit())
		{
			return false;
		}
		using (List<ShipTowerRoleData>.Enumerator enumerator = this.RoleList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.RoleIdEdit != 0)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0601612C RID: 90412 RVA: 0x005948F8 File Offset: 0x00592AF8
	public void ExChangeTeamData(ShipTowerTeamData otherTeam)
	{
		ShipTowerBuffData buffDataEdit = this.BuffDataEdit;
		int? buffId = (buffDataEdit != null) ? new int?(buffDataEdit.Id) : null;
		this.UpdateBuffDataEdit(otherTeam.BuffDataEdit);
		otherTeam.UpdateBuffIdEdit(buffId);
		List<int> roleIdListEdit = this.GetRoleIdListEdit();
		this.CopyIdsToEdit(otherTeam.GetRoleIdListEdit());
		otherTeam.CopyIdsToEdit(roleIdListEdit);
		this.UpdateRoleListToRoleSelectModel();
	}

	// Token: 0x0601612D RID: 90413 RVA: 0x00594958 File Offset: 0x00592B58
	public void ProtoSetRole(int roleId, int index)
	{
		ShipTowerRoleData shipTowerRoleData = this.RoleList[index];
		if (shipTowerRoleData != null)
		{
			this.UpdateRoleId(shipTowerRoleData, roleId);
			this.UpdateRoleIdEdit(shipTowerRoleData, roleId, false);
		}
	}

	// Token: 0x0601612E RID: 90414 RVA: 0x00594988 File Offset: 0x00592B88
	public void ProtoSetBuff(int? buffId = null)
	{
		ShipTowerBuffData buffDataByBuffId = ShipTowerModel.Instance.GetBuffDataByBuffId(buffId.GetValueOrDefault());
		this.UpdateBuffData(buffDataByBuffId);
		this.UpdateBuffDataEdit(buffDataByBuffId);
	}

	// Token: 0x0601612F RID: 90415 RVA: 0x005949B8 File Offset: 0x00592BB8
	public void ProtoSetSkillBranch(int skillBranchId, int index)
	{
		ShipTowerRoleData shipTowerRoleData = this.RoleList[index];
		if (shipTowerRoleData != null)
		{
			shipTowerRoleData.SkillBranchId = skillBranchId;
			shipTowerRoleData.SkillBranchIdEdit = skillBranchId;
		}
	}

	// Token: 0x06016130 RID: 90416 RVA: 0x005949E3 File Offset: 0x00592BE3
	public void UpdateCurrentScore(int score)
	{
		this.CurrentScore = score;
	}

	// Token: 0x06016131 RID: 90417 RVA: 0x005949EC File Offset: 0x00592BEC
	public List<int> GetRoleIdList()
	{
		List<int> list = new List<int>();
		foreach (ShipTowerRoleData shipTowerRoleData in this.RoleList)
		{
			list.Add(shipTowerRoleData.RoleId);
		}
		return list;
	}

	// Token: 0x06016132 RID: 90418 RVA: 0x00594A4C File Offset: 0x00592C4C
	public List<int> GetRoleIdListEdit()
	{
		List<int> list = new List<int>();
		foreach (ShipTowerRoleData shipTowerRoleData in this.RoleList)
		{
			list.Add(shipTowerRoleData.RoleIdEdit);
		}
		return list;
	}

	// Token: 0x06016133 RID: 90419 RVA: 0x00594AAC File Offset: 0x00592CAC
	public void ResetStage()
	{
		foreach (ShipTowerRoleData shipTowerRoleData in this.RoleList)
		{
			this.UpdateRoleId(shipTowerRoleData, 0);
			this.UpdateRoleIdEdit(shipTowerRoleData, 0, false);
			shipTowerRoleData.SkillBranchId = 0;
			shipTowerRoleData.SkillBranchIdEdit = 0;
		}
		this.UpdateBuffData(null);
		this.UpdateBuffDataEdit(null);
		this.UpdateCurrentScore(0);
	}

	// Token: 0x06016134 RID: 90420 RVA: 0x00594B2C File Offset: 0x00592D2C
	public void CoverChallenge()
	{
		foreach (ShipTowerRoleData shipTowerRoleData in this.RoleList)
		{
			this.UpdateRoleId(shipTowerRoleData, shipTowerRoleData.RoleIdEdit);
			shipTowerRoleData.SkillBranchId = shipTowerRoleData.SkillBranchIdEdit;
		}
		this.UpdateBuffData(this.BuffDataEdit);
		this.UpdateCurrentScore(this.NewChallengeScore);
	}

	// Token: 0x06016135 RID: 90421 RVA: 0x00594BAC File Offset: 0x00592DAC
	private void UpdateRoleId(ShipTowerRoleData data, int roleId = 0)
	{
		data.RoleId = roleId;
	}

	// Token: 0x06016136 RID: 90422 RVA: 0x00594BB8 File Offset: 0x00592DB8
	private void UpdateRoleIdEdit(ShipTowerRoleData data, int roleId = 0, bool isCheck = false)
	{
		data.RoleIdEdit = roleId;
		if (roleId <= 0)
		{
			data.RoleIdEdit = 0;
			return;
		}
		if (isCheck)
		{
			data.RoleIdEdit = (ShipTowerModel.Instance.IsCanUseRole(roleId) ? roleId : 0);
			return;
		}
		RoleModel instance = RoleModel.Instance;
		if (instance != null && instance.IsMainRole(roleId))
		{
			data.RoleIdEdit = RoleModel.Instance.GetCurSelectMainRoleId().GetValueOrDefault(roleId);
		}
	}

	// Token: 0x06016137 RID: 90423 RVA: 0x00594C20 File Offset: 0x00592E20
	[NullableContext(2)]
	private void UpdateBuffData(ShipTowerBuffData buffData = null)
	{
		this.BuffData = buffData;
	}

	// Token: 0x06016138 RID: 90424 RVA: 0x00594C29 File Offset: 0x00592E29
	[NullableContext(2)]
	private void UpdateBuffDataEdit(ShipTowerBuffData buffData = null)
	{
		this.BuffDataEdit = buffData;
	}

	// Token: 0x06016139 RID: 90425 RVA: 0x00594C34 File Offset: 0x00592E34
	public void UpdateBuffIdEdit(int? buffId = null)
	{
		ShipTowerBuffData buffDataByBuffId = ShipTowerModel.Instance.GetBuffDataByBuffId(buffId.GetValueOrDefault());
		this.UpdateBuffDataEdit(buffDataByBuffId);
	}

	// Token: 0x0601613A RID: 90426 RVA: 0x00594C5C File Offset: 0x00592E5C
	public void CopyBuffIdToEdit(int buffId, int stageId)
	{
		ShipTowerBuffData buffDataByBuffId = ShipTowerModel.Instance.GetBuffDataByBuffId(buffId);
		if (buffDataByBuffId == null || !buffDataByBuffId.IsCanUse(new int?(stageId)))
		{
			this.UpdateBuffDataEdit(null);
			return;
		}
		this.UpdateBuffDataEdit(buffDataByBuffId);
	}

	// Token: 0x0601613B RID: 90427 RVA: 0x00594C9C File Offset: 0x00592E9C
	[NullableContext(2)]
	public void ProtoTeamEditFromResult(BattleFormation result = null)
	{
		if (result != null)
		{
			for (int i = 0; i < result.SelectRoles.Count; i++)
			{
				int roleId = result.SelectRoles[i];
				this.UpdateRoleIdEdit(this.RoleList[i], roleId, false);
			}
		}
		this.UpdateBuffIdEdit((result != null) ? new int?(result.BuffSelect) : null);
		if (((result != null) ? result.SkillBranchIds : null) != null)
		{
			for (int j = 0; j < result.SkillBranchIds.Count; j++)
			{
				this.RoleList[j].SkillBranchIdEdit = result.SkillBranchIds[j];
			}
		}
	}

	// Token: 0x0601613C RID: 90428 RVA: 0x00594D43 File Offset: 0x00592F43
	public void ProtoSetNewChallengeScore(int score)
	{
		this.NewChallengeScore = score;
	}

	// Token: 0x0601613D RID: 90429 RVA: 0x00594D4C File Offset: 0x00592F4C
	public InstanceDungeon? GetInstanceDungeonCfg(int? id = null)
	{
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(id ?? this.InstId);
		if (config != null)
		{
			return new InstanceDungeon?(config.Value);
		}
		return null;
	}

	// Token: 0x0601613E RID: 90430 RVA: 0x00594D9D File Offset: 0x00592F9D
	public SlashTowerStageInfo? GetShipTowerStageCfg()
	{
		return ShipTowerConfig.Instance.GetStageInfoCfgByInstId(this.InstId);
	}

	// Token: 0x0601613F RID: 90431 RVA: 0x00594DB0 File Offset: 0x00592FB0
	public unsafe ShipTowerMonsterWordItemData GetInfoAttr()
	{
		InstanceDungeon? instanceDungeonCfg = this.GetInstanceDungeonCfg(null);
		string text = "GhostShipMonster_Text1";
		string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(((instanceDungeonCfg != null) ? instanceDungeonCfg.GetValueOrDefault().DungeonDesc : null) ?? "", ((instanceDungeonCfg != null) ? instanceDungeonCfg.GetValueOrDefault().DungeonDesc : null) ?? "");
		ShipTowerMonsterWordItemData shipTowerMonsterWordItemData = new ShipTowerMonsterWordItemData();
		shipTowerMonsterWordItemData.Title = TextConfig.Instance.GetMultiTextByKey(text, text);
		int num = 1;
		List<ShipTowerMonsterWordInfoItemData> list = new List<ShipTowerMonsterWordInfoItemData>(num);
		CollectionsMarshal.SetCount<ShipTowerMonsterWordInfoItemData>(list, num);
		Span<ShipTowerMonsterWordInfoItemData> span = CollectionsMarshal.AsSpan<ShipTowerMonsterWordInfoItemData>(list);
		int index = 0;
		*span[index] = new ShipTowerMonsterWordInfoItemData
		{
			Desc = multiTextByKey
		};
		shipTowerMonsterWordItemData.InfoList = list;
		return shipTowerMonsterWordItemData;
	}

	// Token: 0x06016140 RID: 90432 RVA: 0x00594E78 File Offset: 0x00593078
	[NullableContext(2)]
	public ShipTowerMonsterWordItemData GetInfoWord()
	{
		SlashTowerStageInfo? shipTowerStageCfg = this.GetShipTowerStageCfg();
		List<ShipTowerMonsterWordInfoItemData> list = new List<ShipTowerMonsterWordInfoItemData>();
		if (((shipTowerStageCfg != null) ? shipTowerStageCfg.GetValueOrDefault().BuffId() : null) != null)
		{
			foreach (int num in shipTowerStageCfg.Value.BuffId())
			{
				SlashTowerTagInfo? wordInfoCfgById = ShipTowerConfig.Instance.GetWordInfoCfgById(num);
				if (wordInfoCfgById != null)
				{
					ShipTowerWordItemData wordInfoById = this.GetWordInfoById(num, wordInfoCfgById);
					string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(wordInfoCfgById.Value.Desc, wordInfoCfgById.Value.Desc);
					ShipTowerMonsterWordInfoItemData item = new ShipTowerMonsterWordInfoItemData
					{
						Desc = multiTextByKey,
						Title = (((wordInfoById != null) ? wordInfoById.Title : null) ?? ""),
						TitleColor = ((wordInfoById != null) ? wordInfoById.TitleColor : null),
						IconPath = (((wordInfoById != null) ? wordInfoById.IconPath : null) ?? "")
					};
					list.Add(item);
				}
			}
		}
		if (list.Count == 0)
		{
			string text = "GhostShipMonsterNull_Text";
			string multiTextByKey2 = TextConfig.Instance.GetMultiTextByKey(text, text);
			list.Add(new ShipTowerMonsterWordInfoItemData
			{
				Desc = multiTextByKey2
			});
		}
		string text2 = "GhostShipMonster_Text2";
		return new ShipTowerMonsterWordItemData
		{
			Title = TextConfig.Instance.GetMultiTextByKey(text2, text2),
			InfoList = list
		};
	}

	// Token: 0x06016141 RID: 90433 RVA: 0x00594FF0 File Offset: 0x005931F0
	public ShipTowerMonsterListItemData GetMonsterListItemData()
	{
		string text = "GhostShipMonster_Text3";
		return new ShipTowerMonsterListItemData
		{
			Title = TextConfig.Instance.GetMultiTextByKey(text, text),
			MonsterInfoList = this.GetMonsterInfoList()
		};
	}

	// Token: 0x06016142 RID: 90434 RVA: 0x00595028 File Offset: 0x00593228
	public List<ShipTowerMonsterInfoItemData> GetMonsterInfoList()
	{
		List<ShipTowerMonsterInfoItemData> list = new List<ShipTowerMonsterInfoItemData>();
		int instId = this.InstId;
		SlashTowerStageInfo? shipTowerStageCfg = this.GetShipTowerStageCfg();
		int curWorldLevel = WorldLevelModel.Instance.CurWorldLevel;
		int recommendLevel = InstanceDungeonConfig.Instance.GetRecommendLevel(instId, curWorldLevel);
		if (((shipTowerStageCfg != null) ? shipTowerStageCfg.GetValueOrDefault().MonsterId() : null) != null)
		{
			foreach (int monsterId in shipTowerStageCfg.Value.MonsterId())
			{
				Aki.Config.MonsterInfo? monsterInfoConfig = MonsterInfoConfig.Instance.GetMonsterInfoConfig(monsterId);
				string monsterIcon = MonsterInfoConfig.Instance.GetMonsterIcon(monsterId);
				ShipTowerMonsterInfoItemData item = new ShipTowerMonsterInfoItemData
				{
					Title = (((monsterInfoConfig != null) ? monsterInfoConfig.GetValueOrDefault().Name : null) ?? ""),
					Level = recommendLevel,
					MonsterIcon = monsterIcon,
					ElementList = ((((monsterInfoConfig != null) ? monsterInfoConfig.GetValueOrDefault().ElementIdArray() : null) != null) ? new List<int>(monsterInfoConfig.Value.ElementIdArray()) : new List<int>())
				};
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x06016143 RID: 90435 RVA: 0x0059515C File Offset: 0x0059335C
	public List<ShipTowerWordItemData> GetWordInfoList()
	{
		SlashTowerStageInfo? shipTowerStageCfg = this.GetShipTowerStageCfg();
		List<ShipTowerWordItemData> list = new List<ShipTowerWordItemData>();
		if (((shipTowerStageCfg != null) ? shipTowerStageCfg.GetValueOrDefault().BuffId() : null) != null)
		{
			foreach (int buffId in shipTowerStageCfg.Value.BuffId())
			{
				ShipTowerWordItemData wordInfoById = this.GetWordInfoById(buffId, null);
				if (wordInfoById != null)
				{
					list.Add(wordInfoById);
				}
			}
		}
		return list;
	}

	// Token: 0x06016144 RID: 90436 RVA: 0x005951DC File Offset: 0x005933DC
	[NullableContext(2)]
	private ShipTowerWordItemData GetWordInfoById(int buffId, SlashTowerTagInfo? tagCfg = null)
	{
		SlashTowerTagInfo? slashTowerTagInfo = tagCfg;
		SlashTowerTagInfo? slashTowerTagInfo2 = (slashTowerTagInfo != null) ? slashTowerTagInfo : ShipTowerConfig.Instance.GetWordInfoCfgById(buffId);
		if (slashTowerTagInfo2 != null)
		{
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey(slashTowerTagInfo2.Value.Name, slashTowerTagInfo2.Value.Name);
			return new ShipTowerWordItemData
			{
				Title = multiTextByKey,
				IconPath = slashTowerTagInfo2.Value.Path,
				TitleColor = slashTowerTagInfo2.Value.Color
			};
		}
		return null;
	}

	// Token: 0x06016145 RID: 90437 RVA: 0x00595270 File Offset: 0x00593470
	public void UpdateMainRoleToEdit()
	{
		foreach (ShipTowerRoleData shipTowerRoleData in this.RoleList)
		{
			if (shipTowerRoleData.RoleIdEdit > 0)
			{
				RoleModel instance = RoleModel.Instance;
				if (instance != null && instance.IsMainRole(shipTowerRoleData.RoleIdEdit))
				{
					this.UpdateRoleIdEdit(shipTowerRoleData, shipTowerRoleData.RoleIdEdit, false);
				}
			}
		}
	}

	// Token: 0x0400A48D RID: 42125
	public int InstId;

	// Token: 0x0400A48E RID: 42126
	public int Index;

	// Token: 0x0400A48F RID: 42127
	public readonly List<ShipTowerRoleData> RoleList;

	// Token: 0x0400A490 RID: 42128
	[Nullable(2)]
	public ShipTowerBuffData BuffData;

	// Token: 0x0400A491 RID: 42129
	[Nullable(2)]
	public ShipTowerBuffData BuffDataEdit;

	// Token: 0x0400A492 RID: 42130
	public int StageId;

	// Token: 0x0400A493 RID: 42131
	public int CurrentScore;

	// Token: 0x0400A494 RID: 42132
	public int NewChallengeScore;

	// Token: 0x0400A495 RID: 42133
	public string TeamInstName;

	// Token: 0x0400A496 RID: 42134
	public string AreaName;

	// Token: 0x0400A497 RID: 42135
	public string TeamName;
}
