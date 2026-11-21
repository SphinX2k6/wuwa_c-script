using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02001F15 RID: 7957
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerTeamData
{
	// Token: 0x06013B1C RID: 80668 RVA: 0x005BF124 File Offset: 0x005BD324
	public ShipTowerTeamData()
	{
		this.RoleList = new List<ShipTowerRoleData>();
		this.TeamInstName = "";
		this.AreaName = "";
		this.TeamName = "";
	}

	// Token: 0x06013B1D RID: 80669 RVA: 0x005BF158 File Offset: 0x005BD358
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

	// Token: 0x06013B1E RID: 80670 RVA: 0x005BF246 File Offset: 0x005BD446
	public List<ShipTowerRoleData> GetUseRoleList()
	{
		return this.RoleList;
	}

	// Token: 0x06013B1F RID: 80671 RVA: 0x005BF250 File Offset: 0x005BD450
	public void UpdateToEdit()
	{
		foreach (ShipTowerRoleData shipTowerRoleData in this.RoleList)
		{
			this.UpdateRoleIdEdit(shipTowerRoleData, shipTowerRoleData.RoleId, false);
			shipTowerRoleData.SkillBranchIdEdit = shipTowerRoleData.SkillBranchId;
		}
		this.UpdateBuffDataEdit(this.BuffData);
	}

	// Token: 0x06013B20 RID: 80672 RVA: 0x005BF2C4 File Offset: 0x005BD4C4
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

	// Token: 0x06013B21 RID: 80673 RVA: 0x005BF33C File Offset: 0x005BD53C
	public void CopyIdsToEdit(List<int> roleIdList)
	{
		for (int i = 0; i < this.RoleList.Count; i++)
		{
			ShipTowerRoleData data = this.RoleList[i];
			int roleId = (i < roleIdList.Count) ? roleIdList[i] : 0;
			this.UpdateRoleIdEdit(data, roleId, true);
		}
	}

	// Token: 0x06013B22 RID: 80674 RVA: 0x005BF38C File Offset: 0x005BD58C
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

	// Token: 0x06013B23 RID: 80675 RVA: 0x005BF414 File Offset: 0x005BD614
	public void UpdateRoleListByFormationData(FormationData formationData)
	{
		RoleSelectModel.Instance.ClearData();
		List<int> roleIdListWithTrial = formationData.GetRoleIdListWithTrial(false);
		for (int i = 0; i < this.RoleList.Count; i++)
		{
			ShipTowerRoleData shipTowerRoleData = this.RoleList[i];
			int roleId = (i < roleIdListWithTrial.Count) ? roleIdListWithTrial[i] : 0;
			this.UpdateRoleIdEdit(shipTowerRoleData, roleId, false);
			this.AddRoleDataToRoleSelectModel(shipTowerRoleData, true);
		}
	}

	// Token: 0x06013B24 RID: 80676 RVA: 0x005BF47C File Offset: 0x005BD67C
	public void UpdateRoleListToRoleSelectModel()
	{
		RoleSelectModel.Instance.ClearData();
		foreach (ShipTowerRoleData shipTowerRoleData in this.RoleList)
		{
			this.AddRoleDataToRoleSelectModel(shipTowerRoleData, true);
		}
	}

	// Token: 0x06013B25 RID: 80677 RVA: 0x005BF4DC File Offset: 0x005BD6DC
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

	// Token: 0x06013B26 RID: 80678 RVA: 0x005BF576 File Offset: 0x005BD776
	public int GetRoleIndexInAllTeam(int pos)
	{
		return this.Index * 3 + pos;
	}

	// Token: 0x06013B27 RID: 80679 RVA: 0x005BF584 File Offset: 0x005BD784
	public void UpdateOtherTeamRoleToShipTowerModel()
	{
		foreach (ShipTowerRoleData roleData in this.RoleList)
		{
			ShipTowerModel.Instance.AddOtherTeamRoleData(roleData);
		}
	}

	// Token: 0x06013B28 RID: 80680 RVA: 0x005BF5DC File Offset: 0x005BD7DC
	public void UpdateAllTeamRoleToShipTowerModel()
	{
		foreach (ShipTowerRoleData roleData in this.RoleList)
		{
			ShipTowerModel.Instance.AddAllTeamRoleData(roleData);
		}
	}

	// Token: 0x06013B29 RID: 80681 RVA: 0x005BF634 File Offset: 0x005BD834
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

	// Token: 0x06013B2A RID: 80682 RVA: 0x005BF6AC File Offset: 0x005BD8AC
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

	// Token: 0x06013B2B RID: 80683 RVA: 0x005BF724 File Offset: 0x005BD924
	public void UpdateRoleIndexInAllTeam()
	{
		foreach (ShipTowerRoleData shipTowerRoleData in this.RoleList)
		{
			this.AddRoleDataToRoleSelectModel(shipTowerRoleData, false);
		}
	}

	// Token: 0x06013B2C RID: 80684 RVA: 0x005BF778 File Offset: 0x005BD978
	[NullableContext(2)]
	public void UseBuff(ShipTowerBuffData buffData = null)
	{
		this.UpdateBuffDataEdit(buffData);
	}

	// Token: 0x06013B2D RID: 80685 RVA: 0x005BF784 File Offset: 0x005BD984
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

	// Token: 0x06013B2E RID: 80686 RVA: 0x005BF7E0 File Offset: 0x005BD9E0
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

	// Token: 0x06013B2F RID: 80687 RVA: 0x005BF83C File Offset: 0x005BDA3C
	public bool IsSetBuffFinish()
	{
		return this.BuffData != null;
	}

	// Token: 0x06013B30 RID: 80688 RVA: 0x005BF847 File Offset: 0x005BDA47
	public bool IsSetBuffFinishEdit()
	{
		return this.BuffDataEdit != null;
	}

	// Token: 0x06013B31 RID: 80689 RVA: 0x005BF854 File Offset: 0x005BDA54
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

	// Token: 0x06013B32 RID: 80690 RVA: 0x005BF8B8 File Offset: 0x005BDAB8
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

	// Token: 0x06013B33 RID: 80691 RVA: 0x005BF918 File Offset: 0x005BDB18
	public void ProtoSetRole(int roleId, int index)
	{
		ShipTowerRoleData shipTowerRoleData = this.RoleList[index];
		if (shipTowerRoleData != null)
		{
			this.UpdateRoleId(shipTowerRoleData, roleId);
			this.UpdateRoleIdEdit(shipTowerRoleData, roleId, false);
		}
	}

	// Token: 0x06013B34 RID: 80692 RVA: 0x005BF948 File Offset: 0x005BDB48
	public void ProtoSetBuff(int? buffId = null)
	{
		ShipTowerBuffData buffDataByBuffId = ShipTowerModel.Instance.GetBuffDataByBuffId(buffId.GetValueOrDefault());
		this.UpdateBuffData(buffDataByBuffId);
		this.UpdateBuffDataEdit(buffDataByBuffId);
	}

	// Token: 0x06013B35 RID: 80693 RVA: 0x005BF978 File Offset: 0x005BDB78
	public void ProtoSetSkillBranch(int skillBranchId, int index)
	{
		ShipTowerRoleData shipTowerRoleData = this.RoleList[index];
		if (shipTowerRoleData != null)
		{
			shipTowerRoleData.SkillBranchId = skillBranchId;
			shipTowerRoleData.SkillBranchIdEdit = skillBranchId;
		}
	}

	// Token: 0x06013B36 RID: 80694 RVA: 0x005BF9A3 File Offset: 0x005BDBA3
	public void UpdateCurrentScore(int score)
	{
		this.CurrentScore = score;
	}

	// Token: 0x06013B37 RID: 80695 RVA: 0x005BF9AC File Offset: 0x005BDBAC
	public List<int> GetRoleIdList()
	{
		List<int> list = new List<int>();
		foreach (ShipTowerRoleData shipTowerRoleData in this.RoleList)
		{
			list.Add(shipTowerRoleData.RoleId);
		}
		return list;
	}

	// Token: 0x06013B38 RID: 80696 RVA: 0x005BFA0C File Offset: 0x005BDC0C
	public List<int> GetRoleIdListEdit()
	{
		List<int> list = new List<int>();
		foreach (ShipTowerRoleData shipTowerRoleData in this.RoleList)
		{
			list.Add(shipTowerRoleData.RoleIdEdit);
		}
		return list;
	}

	// Token: 0x06013B39 RID: 80697 RVA: 0x005BFA6C File Offset: 0x005BDC6C
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

	// Token: 0x06013B3A RID: 80698 RVA: 0x005BFAEC File Offset: 0x005BDCEC
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

	// Token: 0x06013B3B RID: 80699 RVA: 0x005BFB6C File Offset: 0x005BDD6C
	private void UpdateRoleId(ShipTowerRoleData data, int roleId = 0)
	{
		data.RoleId = roleId;
	}

	// Token: 0x06013B3C RID: 80700 RVA: 0x005BFB78 File Offset: 0x005BDD78
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

	// Token: 0x06013B3D RID: 80701 RVA: 0x005BFBE0 File Offset: 0x005BDDE0
	[NullableContext(2)]
	private void UpdateBuffData(ShipTowerBuffData buffData = null)
	{
		this.BuffData = buffData;
	}

	// Token: 0x06013B3E RID: 80702 RVA: 0x005BFBE9 File Offset: 0x005BDDE9
	[NullableContext(2)]
	private void UpdateBuffDataEdit(ShipTowerBuffData buffData = null)
	{
		this.BuffDataEdit = buffData;
	}

	// Token: 0x06013B3F RID: 80703 RVA: 0x005BFBF4 File Offset: 0x005BDDF4
	public void UpdateBuffIdEdit(int? buffId = null)
	{
		ShipTowerBuffData buffDataByBuffId = ShipTowerModel.Instance.GetBuffDataByBuffId(buffId.GetValueOrDefault());
		this.UpdateBuffDataEdit(buffDataByBuffId);
	}

	// Token: 0x06013B40 RID: 80704 RVA: 0x005BFC1C File Offset: 0x005BDE1C
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

	// Token: 0x06013B41 RID: 80705 RVA: 0x005BFC5C File Offset: 0x005BDE5C
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

	// Token: 0x06013B42 RID: 80706 RVA: 0x005BFD03 File Offset: 0x005BDF03
	public void ProtoSetNewChallengeScore(int score)
	{
		this.NewChallengeScore = score;
	}

	// Token: 0x06013B43 RID: 80707 RVA: 0x005BFD0C File Offset: 0x005BDF0C
	public InstanceDungeon? GetInstanceDungeonCfg(int? id = null)
	{
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(id ?? this.InstId);
		if (config != null)
		{
			return new InstanceDungeon?(config.Value);
		}
		return null;
	}

	// Token: 0x06013B44 RID: 80708 RVA: 0x005BFD5D File Offset: 0x005BDF5D
	public SlashTowerStageInfo? GetShipTowerStageCfg()
	{
		return ShipTowerConfig.Instance.GetStageInfoCfgByInstId(this.InstId);
	}

	// Token: 0x06013B45 RID: 80709 RVA: 0x005BFD70 File Offset: 0x005BDF70
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

	// Token: 0x06013B46 RID: 80710 RVA: 0x005BFE38 File Offset: 0x005BE038
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

	// Token: 0x06013B47 RID: 80711 RVA: 0x005BFFB0 File Offset: 0x005BE1B0
	public ShipTowerMonsterListItemData GetMonsterListItemData()
	{
		string text = "GhostShipMonster_Text3";
		return new ShipTowerMonsterListItemData
		{
			Title = TextConfig.Instance.GetMultiTextByKey(text, text),
			MonsterInfoList = this.GetMonsterInfoList()
		};
	}

	// Token: 0x06013B48 RID: 80712 RVA: 0x005BFFE8 File Offset: 0x005BE1E8
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

	// Token: 0x06013B49 RID: 80713 RVA: 0x005C011C File Offset: 0x005BE31C
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

	// Token: 0x06013B4A RID: 80714 RVA: 0x005C019C File Offset: 0x005BE39C
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

	// Token: 0x06013B4B RID: 80715 RVA: 0x005C0230 File Offset: 0x005BE430
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

	// Token: 0x0400A877 RID: 43127
	public int InstId;

	// Token: 0x0400A878 RID: 43128
	public int Index;

	// Token: 0x0400A879 RID: 43129
	public readonly List<ShipTowerRoleData> RoleList;

	// Token: 0x0400A87A RID: 43130
	[Nullable(2)]
	public ShipTowerBuffData BuffData;

	// Token: 0x0400A87B RID: 43131
	[Nullable(2)]
	public ShipTowerBuffData BuffDataEdit;

	// Token: 0x0400A87C RID: 43132
	public int StageId;

	// Token: 0x0400A87D RID: 43133
	public int CurrentScore;

	// Token: 0x0400A87E RID: 43134
	public int NewChallengeScore;

	// Token: 0x0400A87F RID: 43135
	public string TeamInstName;

	// Token: 0x0400A880 RID: 43136
	public string AreaName;

	// Token: 0x0400A881 RID: 43137
	public string TeamName;
}
