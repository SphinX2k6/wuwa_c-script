using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleLangCustomModel;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Module.InstanceDungeon;

// Token: 0x02001E76 RID: 7798
[NullableContext(1)]
[Nullable(0)]
public class RoleInstance : RoleDataBase
{
	// Token: 0x06013482 RID: 78978 RVA: 0x005A283F File Offset: 0x005A0A3F
	public RoleInstance(int id) : base(id)
	{
	}

	// Token: 0x06013483 RID: 78979 RVA: 0x005A2848 File Offset: 0x005A0A48
	public override bool IsTrialRole()
	{
		return false;
	}

	// Token: 0x06013484 RID: 78980 RVA: 0x005A284C File Offset: 0x005A0A4C
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

	// Token: 0x06013485 RID: 78981 RVA: 0x005A2887 File Offset: 0x005A0A87
	public override string GetName(int? playerId = null)
	{
		if (PlayerInfoModel.Instance.IsPlayerId(this.Id, playerId))
		{
			return FunctionModel.Instance.GetPlayerName();
		}
		return this.GetRoleRealName();
	}

	// Token: 0x06013486 RID: 78982 RVA: 0x005A28B0 File Offset: 0x005A0AB0
	public string GetRoleRealName()
	{
		RoleSkinData roleSkinData = RoleSkinModel.Instance.GetRoleSkinData(this.GetRoleSkinId());
		return RoleConfig.Instance.GetRoleName(roleSkinData.GetName());
	}

	// Token: 0x06013487 RID: 78983 RVA: 0x005A28DE File Offset: 0x005A0ADE
	public int GetSkillInfoLevel(long infoId)
	{
		return base.GetSkillData().GetReferencedSkillLevel(infoId, ERoleSkillReferenceType.SkillInfo, null);
	}

	// Token: 0x06013488 RID: 78984 RVA: 0x005A28EE File Offset: 0x005A0AEE
	public override int GetRoleId()
	{
		return this.Id;
	}

	// Token: 0x06013489 RID: 78985 RVA: 0x005A28F6 File Offset: 0x005A0AF6
	public override int GetRoleCreateTime()
	{
		return this.CreateTime;
	}

	// Token: 0x0601348A RID: 78986 RVA: 0x005A2900 File Offset: 0x005A0B00
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

	// Token: 0x0601348B RID: 78987 RVA: 0x005A2950 File Offset: 0x005A0B50
	public void RefreshRoleAttr(IReadOnlyList<ArrayIntInt> baseAttr, IReadOnlyList<ArrayIntInt> addAttr)
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

	// Token: 0x0601348C RID: 78988 RVA: 0x005A2AA0 File Offset: 0x005A0CA0
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
		this.RefreshRoleAttr(roleInfo.BaseProp, roleInfo.AddProp);
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

	// Token: 0x0601348D RID: 78989 RVA: 0x005A2CA8 File Offset: 0x005A0EA8
	public void RefreshResonance(ResonInfo resonance)
	{
		RoleResonanceData resonanceData = base.GetResonanceData();
		ResonanceDataInfo resonance2 = new ResonanceDataInfo(resonance.ResonId, resonance.IsOpen, resonance.Increase);
		resonanceData.SetResonance(resonance2);
	}

	// Token: 0x0601348E RID: 78990 RVA: 0x005A2CDC File Offset: 0x005A0EDC
	public override bool CanChangeName()
	{
		return !PlayerInfoModel.Instance.IsPlayerId(this.Id, null) || !PlayerInfoConfig.Instance.GetIsUseAccountName();
	}

	// Token: 0x0601348F RID: 78991 RVA: 0x005A2D13 File Offset: 0x005A0F13
	public override bool IsOnlineRole()
	{
		return false;
	}

	// Token: 0x06013490 RID: 78992 RVA: 0x005A2D16 File Offset: 0x005A0F16
	public override bool GetIsNew()
	{
		return NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.RoleDataItem, this.Id);
	}

	// Token: 0x06013491 RID: 78993 RVA: 0x005A2D2A File Offset: 0x005A0F2A
	public override bool TryRemoveNewFlag()
	{
		if (NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.RoleDataItem, this.Id))
		{
			NewFlagModel.Instance.RemoveNewFlag(ELocalStoragePlayerKey.RoleDataItem, this.Id);
			return true;
		}
		return false;
	}

	// Token: 0x0400A503 RID: 42243
	protected int CreateTime;
}
