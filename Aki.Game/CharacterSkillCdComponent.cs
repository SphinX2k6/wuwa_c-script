using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Battle;
using UnrealEngine;

// Token: 0x02003145 RID: 12613
[NullableContext(1)]
[Nullable(0)]
public class CharacterSkillCdComponent : BaseSkillCdComponent
{
	// Token: 0x0601B213 RID: 111123 RVA: 0x00760A50 File Offset: 0x0075EC50
	protected override bool OnInit()
	{
		base.OnInit();
		this.SkillComp = base.Entity.CheckGetComponent<BaseSkillComponent>();
		this.AttrComp = base.Entity.CheckGetComponent<BaseAttributeComponent>();
		this.CurWorldSkillCdData = SkillCdModel.Instance.GetCurWorldSkillCdData();
		this.GroupSkillCdInfoMap = new Dictionary<long, GroupSkillCdInfo>();
		this.SkillInfoMap = new Dictionary<long, SSkillInfo>();
		this.MultiSkillData = this.CurWorldSkillCdData.InitMultiSkill(base.Entity.Id);
		this.MultiSkillData.Init(base.Entity.Id, 0);
		return true;
	}

	// Token: 0x0601B214 RID: 111124 RVA: 0x00760AE0 File Offset: 0x0075ECE0
	protected override bool OnStart()
	{
		if (this.SkillComp != null)
		{
			foreach (int skillId in this.SkillComp.GetAllSkillId(EFightDataTableSourceType.All))
			{
				SSkillInfo skillInfo = this.SkillComp.GetSkillInfo(skillId);
				if (skillInfo != null)
				{
					this.InitSkillCdBySkillInfo(skillId, skillInfo);
				}
			}
		}
		this.InitSkillCdTags();
		if (GlobalData.IsPlayInEditor)
		{
			foreach (GroupSkillCdInfo groupSkillCdInfo in this.GroupSkillCdInfoMap.Values)
			{
				groupSkillCdInfo.CheckConfigValid();
			}
		}
		EventSystem.Instance.AddWithTarget<double>(base.Entity, EEventName.OnChangeRoleCoolDownChanged, new Action<double>(this.GoDown));
		return true;
	}

	// Token: 0x0601B215 RID: 111125 RVA: 0x00760BC8 File Offset: 0x0075EDC8
	protected override bool OnEnd()
	{
		base.OnEnd();
		foreach (GroupSkillCdInfo groupSkillCdInfo in this.GroupSkillCdInfoMap.Values)
		{
			groupSkillCdInfo.ClearCdTags(base.Entity.Id);
		}
		if (this.CurWorldSkillCdData != null)
		{
			this.CurWorldSkillCdData.RemoveEntity(base.Entity);
			this.CurWorldSkillCdData = null;
		}
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnChangeRoleCoolDownChanged, new Action<double>(this.GoDown));
		return true;
	}

	// Token: 0x0601B216 RID: 111126 RVA: 0x00760C74 File Offset: 0x0075EE74
	[NullableContext(2)]
	public MultiSkillInfo GetMultiSkillInfo(int skillId)
	{
		return this.MultiSkillData.GetMultiSkillInfo(skillId);
	}

	// Token: 0x0601B217 RID: 111127 RVA: 0x00760C84 File Offset: 0x0075EE84
	public long GetNextMultiSkillId(int skillId)
	{
		if (GlobalData.IsPlayInEditor)
		{
			foreach (KeyValuePair<long, SSkillInfo> keyValuePair in this.SkillInfoMap)
			{
				if (keyValuePair.Key == (long)skillId)
				{
					if (!this.IsMultiSkill(keyValuePair.Value))
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Battle;
						ELogAuthor author = ELogAuthor.CFT;
						string message = "获取多段技能下一段技能Id时，传入的技能Id不是多段技能";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("skillId", skillId);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						break;
					}
					break;
				}
			}
		}
		return this.MultiSkillData.GetNextMultiSkillId(skillId);
	}

	// Token: 0x0601B218 RID: 111128 RVA: 0x00760D2C File Offset: 0x0075EF2C
	public bool IsMultiSkill(SSkillInfo skillInfo)
	{
		return this.MultiSkillData.IsMultiSkill(skillInfo);
	}

	// Token: 0x0601B219 RID: 111129 RVA: 0x00760D3A File Offset: 0x0075EF3A
	public bool CanStartMultiSkill(Skill skill)
	{
		SkillCdModel instance = SkillCdModel.Instance;
		return (instance != null && instance.SkillDebugMode) || this.MultiSkillData.CanStartMultiSkill(skill);
	}

	// Token: 0x0601B21A RID: 111130 RVA: 0x00760D5D File Offset: 0x0075EF5D
	public bool StartMultiSkill(Skill skill, bool bCheck = true)
	{
		return SkillCdModel.Instance.SkillDebugMode || this.MultiSkillData.StartMultiSkill(skill, bCheck);
	}

	// Token: 0x0601B21B RID: 111131 RVA: 0x00760D7A File Offset: 0x0075EF7A
	public void ResetMultiSkills(int skillId)
	{
		this.MultiSkillData.ResetMultiSkills(skillId, false);
	}

	// Token: 0x0601B21C RID: 111132 RVA: 0x00760D89 File Offset: 0x0075EF89
	private void GoDown(double coolDownTime)
	{
		this.MultiSkillData.ResetOnChangeRole();
	}

	// Token: 0x0601B21D RID: 111133 RVA: 0x00760D98 File Offset: 0x0075EF98
	[return: Nullable(2)]
	public unsafe GroupSkillCdInfo InitSkillCdBySkillInfo(int skillId, SSkillInfo skillInfo)
	{
		GroupSkillCdInfo groupSkillCdInfo;
		if (this.GroupSkillCdInfoMap.TryGetValue((long)skillId, out groupSkillCdInfo))
		{
			return groupSkillCdInfo;
		}
		try
		{
			SSkillCooldownInfo cooldownConfig = skillInfo.CooldownConfig;
			if (cooldownConfig.SectionCount - cooldownConfig.SectionRemaining > 1)
			{
				return null;
			}
			groupSkillCdInfo = this.CurWorldSkillCdData.InitSkillCd(base.Entity, skillId, skillInfo);
			this.GroupSkillCdInfoMap[(long)skillId] = groupSkillCdInfo;
			this.SkillInfoMap[(long)skillId] = skillInfo;
			return groupSkillCdInfo;
		}
		catch (Exception ex)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
			Entity entity = base.Entity;
			string message = "初始化技能CD异常";
			Exception e = ex;
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("skillId", skillId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("skillId", (skillInfo != null) ? new FName?(skillInfo.SkillName) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("error", ex.Message);
			instance.ErrorWithStack(flag, entity, message, e, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		return null;
	}

	// Token: 0x0601B21E RID: 111134 RVA: 0x00760EC0 File Offset: 0x0075F0C0
	private void InitSkillCdTags()
	{
		EntityHandle handleByEntity = CharacterModel.Instance.GetHandleByEntity(base.Entity);
		foreach (GroupSkillCdInfo groupSkillCdInfo in this.GroupSkillCdInfoMap.Values)
		{
			groupSkillCdInfo.InitCdTags(handleByEntity);
		}
	}

	// Token: 0x0601B21F RID: 111135 RVA: 0x00760F28 File Offset: 0x0075F128
	public GroupSkillCdInfo GetGroupSkillCdInfo(int skillId)
	{
		return this.GroupSkillCdInfoMap.GetValueOrDefault((long)skillId);
	}

	// Token: 0x0601B220 RID: 111136 RVA: 0x00760F38 File Offset: 0x0075F138
	public bool IsSkillInCd(int skillId, bool checkCount = true)
	{
		GroupSkillCdInfo groupSkillCdInfo;
		if (!this.GroupSkillCdInfoMap.TryGetValue((long)skillId, out groupSkillCdInfo))
		{
			return false;
		}
		if (checkCount)
		{
			return !groupSkillCdInfo.HasRemainingCount();
		}
		return groupSkillCdInfo.IsInCd();
	}

	// Token: 0x0601B221 RID: 111137 RVA: 0x00760F6C File Offset: 0x0075F16C
	public bool ModifyCdInfo(int skillId, float skillCd)
	{
		if (this.GroupSkillCdInfoMap == null)
		{
			Log.Instance.Warn(ELogModule.Battle, ELogAuthor.CFT, "角色技能组件还没有初始化，不允许修改技能CD", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		GroupSkillCdInfo groupSkillCdInfo;
		if (!this.GroupSkillCdInfoMap.TryGetValue((long)skillId, out groupSkillCdInfo))
		{
			return false;
		}
		groupSkillCdInfo.SkillCdInfoMap[skillId].SkillCd = skillCd;
		return true;
	}

	// Token: 0x0601B222 RID: 111138 RVA: 0x00760FC8 File Offset: 0x0075F1C8
	[NullableContext(2)]
	public void ModifyCdTime(long[] skillIds, float modifyTime, float changeTimePercentage)
	{
		if (skillIds == null || skillIds.Length == 0)
		{
			return;
		}
		if (skillIds.Length == 1)
		{
			GroupSkillCdInfo groupSkillCdInfo;
			if (this.GroupSkillCdInfoMap.TryGetValue(skillIds[0], out groupSkillCdInfo))
			{
				groupSkillCdInfo.ModifyRemainingCd(modifyTime, changeTimePercentage);
			}
			return;
		}
		HashSet<GroupSkillCdInfo> hashSet = new HashSet<GroupSkillCdInfo>();
		foreach (long key in skillIds)
		{
			GroupSkillCdInfo item;
			if (this.GroupSkillCdInfoMap.TryGetValue(key, out item))
			{
				hashSet.Add(item);
			}
		}
		foreach (GroupSkillCdInfo groupSkillCdInfo2 in hashSet)
		{
			groupSkillCdInfo2.ModifyRemainingCd(modifyTime, changeTimePercentage);
		}
	}

	// Token: 0x0601B223 RID: 111139 RVA: 0x00761074 File Offset: 0x0075F274
	public void ModifyCdTimeBySkillGenres(int[] skillGenres, float modifyTime, float changeTimePercentage)
	{
		List<int> list = new List<int>();
		foreach (int item in skillGenres)
		{
			list.Add(item);
		}
		HashSet<GroupSkillCdInfo> hashSet = new HashSet<GroupSkillCdInfo>();
		foreach (KeyValuePair<long, SSkillInfo> keyValuePair in this.SkillInfoMap)
		{
			bool flag = false;
			for (int j = 0; j < list.Count; j++)
			{
				if (SkillUtils.HasSkillGenre(keyValuePair.Value, (ESkillGenre)list[j]))
				{
					flag = true;
					break;
				}
			}
			GroupSkillCdInfo item2;
			if (flag && this.GroupSkillCdInfoMap.TryGetValue(keyValuePair.Key, out item2))
			{
				hashSet.Add(item2);
			}
		}
		foreach (GroupSkillCdInfo groupSkillCdInfo in hashSet)
		{
			groupSkillCdInfo.ModifyRemainingCd(modifyTime, changeTimePercentage);
		}
	}

	// Token: 0x0601B224 RID: 111140 RVA: 0x00761180 File Offset: 0x0075F380
	public bool StartCd(int skillId, IReadOnlyList<ESkillGenre> skillGenres)
	{
		GroupSkillCdInfo groupSkillCdInfo;
		if (!this.GroupSkillCdInfoMap.TryGetValue((long)skillId, out groupSkillCdInfo))
		{
			return false;
		}
		BaseAttributeComponent attrComp = this.AttrComp;
		float cdProportion = ((attrComp != null) ? attrComp.GetCurrentValue(EAttributeType.CdReduse) : 10000f) / 10000f;
		groupSkillCdInfo.StartCd(skillId, cdProportion, CharacterModel.Instance.GetHandleByEntity(base.Entity), this, skillGenres);
		return true;
	}

	// Token: 0x0601B225 RID: 111141 RVA: 0x007611DC File Offset: 0x0075F3DC
	public float CalcExtraEffectCd(float skillCd, int skillId, IReadOnlyList<ESkillGenre> skillGenres)
	{
		float num = 0f;
		float num2 = 1f;
		if (this.HasModifyCdEffect)
		{
			foreach (ModifyCd modifyCd in this.BuffComp.BuffEffectManager.FilterById<ModifyCd>(EExtraEffectId.ModifyCd, null))
			{
				if (this.IsBuffEffectSkillCd(modifyCd, skillId, skillGenres))
				{
					if (modifyCd.ModifyType == EModifyCdType.Add || modifyCd.ModifyType == EModifyCdType.AddPerTenThousand)
					{
						num += modifyCd.ModifyValue;
					}
					else if (modifyCd.ModifyType == EModifyCdType.Multiply)
					{
						num2 *= modifyCd.ModifyValue;
					}
				}
			}
		}
		WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(CreatureModel.Instance.GetPlayerId());
		BaseSkillCdComponent baseSkillCdComponent = (playerEntity != null) ? playerEntity.GetComponent<BaseSkillCdComponent>() : null;
		if (baseSkillCdComponent != null && baseSkillCdComponent.HasModifyCdEffect)
		{
			BaseBuffComponent baseBuffComponent = (playerEntity != null) ? playerEntity.GetComponent<BaseBuffComponent>() : null;
			if (baseBuffComponent != null)
			{
				foreach (ModifyCd modifyCd2 in baseBuffComponent.BuffEffectManager.FilterById<ModifyCd>(EExtraEffectId.ModifyCd, null))
				{
					if (this.IsBuffEffectSkillCd(modifyCd2, skillId, skillGenres))
					{
						if (modifyCd2.ModifyType == EModifyCdType.Add || modifyCd2.ModifyType == EModifyCdType.AddPerTenThousand)
						{
							num += modifyCd2.ModifyValue;
						}
						else if (modifyCd2.ModifyType == EModifyCdType.Multiply)
						{
							num2 *= modifyCd2.ModifyValue;
						}
					}
				}
			}
		}
		return (skillCd + num) * num2;
	}

	// Token: 0x0601B226 RID: 111142 RVA: 0x0076134C File Offset: 0x0075F54C
	private bool IsBuffEffectSkillCd(ModifyCd effect, int skillId, IReadOnlyList<ESkillGenre> skillGenres)
	{
		if (effect.SkillType == 0)
		{
			return effect.SkillIdOrGenres.Contains((long)skillId);
		}
		if (effect.SkillType == 1)
		{
			for (int i = 0; i < skillGenres.Count; i++)
			{
				if (effect.SkillIdOrGenres.Contains((long)skillGenres[i]))
				{
					return true;
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x0601B227 RID: 111143 RVA: 0x007613A4 File Offset: 0x0075F5A4
	public unsafe bool SetLimitCount(int skillId, int? limitCount = null)
	{
		Dictionary<long, GroupSkillCdInfo> groupSkillCdInfoMap = this.GroupSkillCdInfoMap;
		GroupSkillCdInfo groupSkillCdInfo = (groupSkillCdInfoMap != null) ? groupSkillCdInfoMap.GetValueOrDefault((long)skillId) : null;
		if (groupSkillCdInfo == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "SetLimitCount 不存在该技能:";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("limitCount", limitCount);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("skillID", skillId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		groupSkillCdInfo.SetLimitCount(limitCount);
		return true;
	}

	// Token: 0x0601B228 RID: 111144 RVA: 0x0076145C File Offset: 0x0075F65C
	public unsafe bool AddLimitCount(int skillId, int limitCount)
	{
		Dictionary<long, GroupSkillCdInfo> groupSkillCdInfoMap = this.GroupSkillCdInfoMap;
		GroupSkillCdInfo groupSkillCdInfo = (groupSkillCdInfoMap != null) ? groupSkillCdInfoMap.GetValueOrDefault((long)skillId) : null;
		if (groupSkillCdInfo == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "AddLimitCount 不存在该技能:";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", base.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("limitCount", limitCount);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("skillID", skillId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		groupSkillCdInfo.AddLimitCount(limitCount);
		return true;
	}

	// Token: 0x0601B229 RID: 111145 RVA: 0x00761514 File Offset: 0x0075F714
	public bool ResetCdDelayTime(int skillId)
	{
		GroupSkillCdInfo groupSkillCdInfo;
		if (!this.GroupSkillCdInfoMap.TryGetValue((long)skillId, out groupSkillCdInfo))
		{
			return false;
		}
		if (groupSkillCdInfo.ResetDelayCd())
		{
			InterruptSkillInDelayPush message = new InterruptSkillInDelayPush
			{
				SkillId = (long)skillId
			};
			CombatNet.Instance.Send(EPushMessageId.InterruptSkillInDelayPush, base.Entity, message, null, null, null);
			MultiSkillData multiSkillData = this.MultiSkillData;
			if (multiSkillData != null)
			{
				multiSkillData.ResetMultiSkills(skillId, true);
			}
		}
		return true;
	}

	// Token: 0x0601B22A RID: 111146 RVA: 0x00761590 File Offset: 0x0075F790
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterSkillCdComponent characterSkillCdComponent = (CharacterSkillCdComponent)componentTemplate;
		if (base.CanResetComponentProperty("SkillComp"))
		{
			if (characterSkillCdComponent.SkillComp == null)
			{
				this.SkillComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseSkillComponent>(this.SkillComp), "SkillComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AttrComp"))
		{
			if (characterSkillCdComponent.AttrComp == null)
			{
				this.AttrComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseAttributeComponent>(this.AttrComp), "AttrComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CurWorldSkillCdData"))
		{
			if (characterSkillCdComponent.CurWorldSkillCdData == null)
			{
				this.CurWorldSkillCdData = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<WorldSkillCdData>(this.CurWorldSkillCdData), "CurWorldSkillCdData"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("GroupSkillCdInfoMap"))
		{
			if (characterSkillCdComponent.GroupSkillCdInfoMap == null)
			{
				this.GroupSkillCdInfoMap = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<long, GroupSkillCdInfo>>(this.GroupSkillCdInfoMap), "GroupSkillCdInfoMap"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SkillInfoMap"))
		{
			if (characterSkillCdComponent.SkillInfoMap == null)
			{
				this.SkillInfoMap = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<long, SSkillInfo>>(this.SkillInfoMap), "SkillInfoMap"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MultiSkillData"))
		{
			if (characterSkillCdComponent.MultiSkillData == null)
			{
				this.MultiSkillData = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<MultiSkillData>(this.MultiSkillData), "MultiSkillData"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400D313 RID: 54035
	private const int DEFAULT_PROPORTTION_VALUE = 10000;

	// Token: 0x0400D314 RID: 54036
	[Nullable(2)]
	private BaseSkillComponent SkillComp;

	// Token: 0x0400D315 RID: 54037
	[Nullable(2)]
	private BaseAttributeComponent AttrComp;

	// Token: 0x0400D316 RID: 54038
	[Nullable(2)]
	private WorldSkillCdData CurWorldSkillCdData;

	// Token: 0x0400D317 RID: 54039
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<long, GroupSkillCdInfo> GroupSkillCdInfoMap;

	// Token: 0x0400D318 RID: 54040
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<long, SSkillInfo> SkillInfoMap;

	// Token: 0x0400D319 RID: 54041
	[Nullable(2)]
	private MultiSkillData MultiSkillData;
}
