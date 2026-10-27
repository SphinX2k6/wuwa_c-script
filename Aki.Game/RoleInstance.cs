using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleLangCustomModel;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Module.InstanceDungeon;

// Token: 0x020028FB RID: 10491
[NullableContext(1)]
[Nullable(0)]
public class RoleInstance : RoleDataBase
{
	// Token: 0x06015A7E RID: 88702 RVA: 0x00577973 File Offset: 0x00575B73
	public RoleInstance(int id) : base(id)
	{
	}

	// Token: 0x06015A7F RID: 88703 RVA: 0x0057797C File Offset: 0x00575B7C
	public override bool IsTrialRole()
	{
		return false;
	}

	// Token: 0x06015A80 RID: 88704 RVA: 0x00577980 File Offset: 0x00575B80
	public void SetRoleName(string name)
	{
		if (!StringUtils.IsEmpty(name))
		{
			this.Name = name;
			return;
		}
		RoleInfo roleConfig = base.GetRoleConfig();
		this.Name = RoleConfig.Instance.GetRoleName(roleConfig.Name);
	}

	// Token: 0x06015A81 RID: 88705 RVA: 0x005779BB File Offset: 0x00575BBB
	public override string GetName(int? playerId = null)
	{
		if (PlayerInfoModel.Instance.IsPlayerId(this.Id, playerId))
		{
			return FunctionModel.Instance.GetPlayerName();
		}
		return this.GetRoleRealName();
	}

	// Token: 0x06015A82 RID: 88706 RVA: 0x005779E4 File Offset: 0x00575BE4
	public string GetRoleRealName()
	{
		RoleSkinData roleSkinData = RoleSkinModel.Instance.GetRoleSkinData(this.GetRoleSkinId());
		return RoleConfig.Instance.GetRoleName(roleSkinData.GetName());
	}

	// Token: 0x06015A83 RID: 88707 RVA: 0x00577A12 File Offset: 0x00575C12
	public int GetSkillInfoLevel(long infoId)
	{
		return base.GetSkillData().GetReferencedSkillLevel(infoId, ERoleSkillReferenceType.SkillInfo, null);
	}

	// Token: 0x06015A84 RID: 88708 RVA: 0x00577A22 File Offset: 0x00575C22
	public override int GetRoleId()
	{
		return this.Id;
	}

	// Token: 0x06015A85 RID: 88709 RVA: 0x00577A2A File Offset: 0x00575C2A
	public override int GetRoleCreateTime()
	{
		return this.CreateTime;
	}

	// Token: 0x06015A86 RID: 88710 RVA: 0x00577A34 File Offset: 0x00575C34
	public void RefreshSkillInfo(int skillId, int skillLevel)
	{
		RoleSkillData skillData = base.GetSkillData();
		skillData.SetSkillLevel(skillId, skillLevel);
		skillData.SetSkillReferenceMapBySkillId(skillId);
		ArrayIntInt arrayIntInt = new ArrayIntInt();
		arrayIntInt.Key = skillId;
		arrayIntInt.Value = skillLevel;
		EventSystem.Instance.EmitWithTarget<int, ArrayIntInt>(this, EEventName.RoleSkillLevelUp, this.GetRoleId(), arrayIntInt);
	}

	// Token: 0x06015A87 RID: 88711 RVA: 0x00577A84 File Offset: 0x00575C84
	public void RefreshRoleAttr(ArrayIntInt[] baseAttr, ArrayIntInt[] addAttr)
	{
		RoleAttributeData attributeData = base.GetAttributeData();
		Dictionary<int, int> oldRoleBaseAttr = attributeData.GetOldRoleBaseAttr();
		attributeData.ClearRoleBaseAttr();
		foreach (ArrayIntInt arrayIntInt in baseAttr)
		{
			attributeData.SetRoleBaseAttr(arrayIntInt.Key, arrayIntInt.Value);
			oldRoleBaseAttr[arrayIntInt.Key] = arrayIntInt.Value;
		}
		Dictionary<int, int> oldRoleAddAttr = attributeData.GetOldRoleAddAttr();
		attributeData.ClearRoleAddAttr();
		foreach (ArrayIntInt arrayIntInt2 in addAttr)
		{
			attributeData.SetRoleAddAttr(arrayIntInt2.Key, arrayIntInt2.Value);
			oldRoleAddAttr[arrayIntInt2.Key] = arrayIntInt2.Value;
		}
		int instanceId = InstanceDungeonEntranceModel.Instance.InstanceId;
		if (instanceId != 0 && InstanceDungeonConfig.Instance.GetConfig(instanceId).Value.ShareAttri == 0)
		{
			oldRoleBaseAttr.Remove(3);
			oldRoleAddAttr.Remove(3);
		}
		EventSystem.Instance.EmitWithTarget<IReadOnlyDictionary<int, int>, IReadOnlyDictionary<int, int>>(this, EEventName.RoleRefreshAttribute, oldRoleBaseAttr, oldRoleAddAttr);
		EventSystem.Instance.Emit<IReadOnlyDictionary<int, int>, IReadOnlyDictionary<int, int>>(EEventName.RoleRefreshAttribute, oldRoleBaseAttr, oldRoleAddAttr);
	}

	// Token: 0x06015A88 RID: 88712 RVA: 0x00577BA0 File Offset: 0x00575DA0
	public void RefreshRoleInfo(roleInfo roleInfo)
	{
		this.SetRoleName(roleInfo.Name);
		this.CreateTime = (int)roleInfo.CreateTime;
		RoleLevelData levelData = base.GetLevelData();
		levelData.SetLevel(roleInfo.Level);
		levelData.SetExp(roleInfo.Exp);
		levelData.SetBreachLevel(roleInfo.Breakthrough);
		RoleSkillData skillData = base.GetSkillData();
		foreach (ArrayIntInt arrayIntInt in roleInfo.Skills)
		{
			skillData.SetSkillLevel(arrayIntInt.Key, arrayIntInt.Value);
			skillData.SetSkillReferenceMapBySkillId(arrayIntInt.Key);
		}
		RolePhantomData phantomData = base.GetPhantomData();
		foreach (ArrayIntInt arrayIntInt2 in roleInfo.Phantom)
		{
			phantomData.RefreshPhantom(arrayIntInt2.Key, arrayIntInt2.Value);
		}
		int count = roleInfo.SkillNodeState.Count;
		Dictionary<int, SkillNodeDataInfo> dictionary = new Dictionary<int, SkillNodeDataInfo>();
		for (int i = 0; i < count; i++)
		{
			ArraySkillNode arraySkillNode = roleInfo.SkillNodeState[i];
			int skillNodeId = arraySkillNode.SkillNodeId;
			SkillNodeDataInfo value = new SkillNodeDataInfo(skillNodeId, arraySkillNode.IsActive, arraySkillNode.SkillId);
			dictionary.Add(skillNodeId, value);
		}
		skillData.SetSkillNodeStateData(dictionary);
		this.RefreshRoleAttr(roleInfo.BaseProp.ToArray<ArrayIntInt>(), roleInfo.AddProp.ToArray<ArrayIntInt>());
		foreach (ResonInfo resonance in roleInfo.Reson)
		{
			this.RefreshResonance(resonance);
		}
		base.GetResonanceData().SetResonantChainGroupIndex(roleInfo.ResonantChainGroupIndex);
		base.SetRoleSkinId(roleInfo.SkinId);
		base.SetBackgroundMusicEnabled(roleInfo.EnableSelfBgm);
		if (RoleLangCustomModel.Instance.GetStartLoadingInited())
		{
			RoleLangCustomModel.Instance.ApplyPlayerVoice(roleInfo.RoleId, false);
		}
	}

	// Token: 0x06015A89 RID: 88713 RVA: 0x00577DB4 File Offset: 0x00575FB4
	public void RefreshResonance(ResonInfo resonance)
	{
		RoleResonanceData resonanceData = base.GetResonanceData();
		ResonanceDataInfo resonance2 = new ResonanceDataInfo(resonance.ResonId, resonance.IsOpen, resonance.Increase);
		resonanceData.SetResonance(resonance2);
	}

	// Token: 0x06015A8A RID: 88714 RVA: 0x00577DE8 File Offset: 0x00575FE8
	public override bool CanChangeName()
	{
		return !PlayerInfoModel.Instance.IsPlayerId(this.Id, null) || !PlayerInfoConfig.Instance.GetIsUseAccountName();
	}

	// Token: 0x06015A8B RID: 88715 RVA: 0x00577E1F File Offset: 0x0057601F
	public override bool IsOnlineRole()
	{
		return false;
	}

	// Token: 0x06015A8C RID: 88716 RVA: 0x00577E22 File Offset: 0x00576022
	public override bool GetIsNew()
	{
		return NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.RoleDataItem, this.Id);
	}

	// Token: 0x06015A8D RID: 88717 RVA: 0x00577E36 File Offset: 0x00576036
	public override bool TryRemoveNewFlag()
	{
		if (NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.RoleDataItem, this.Id))
		{
			NewFlagModel.Instance.RemoveNewFlag(ELocalStoragePlayerKey.RoleDataItem, this.Id);
			return true;
		}
		return false;
	}

	// Token: 0x0400A118 RID: 41240
	protected int CreateTime;
}
