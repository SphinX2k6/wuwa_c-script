using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Battle;
using UnrealEngine;

// Token: 0x020026A7 RID: 9895
[NullableContext(1)]
[Nullable(0)]
public class CharacterSkillCdComponent : BaseSkillCdComponent, ISkillTableChangeListener
{
	// Token: 0x06018CAE RID: 101550 RVA: 0x007872D8 File Offset: 0x007854D8
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

	// Token: 0x06018CAF RID: 101551 RVA: 0x00787368 File Offset: 0x00785568
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
		BaseSkillComponent skillComp = this.SkillComp;
		if (skillComp != null)
		{
			skillComp.AddSkillTableChangeListener(this);
		}
		return true;
	}

	// Token: 0x06018CB0 RID: 101552 RVA: 0x00787464 File Offset: 0x00785664
	protected override bool OnEnd()
	{
		base.OnEnd();
		BaseSkillComponent skillComp = this.SkillComp;
		if (skillComp != null)
		{
			skillComp.RemoveSkillTableChangeListener(this);
		}
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

	// Token: 0x06018CB1 RID: 101553 RVA: 0x00787520 File Offset: 0x00785720
	[NullableContext(2)]
	public MultiSkillInfo GetMultiSkillInfo(int skillId)
	{
		return this.MultiSkillData.GetMultiSkillInfo(skillId);
	}

	// Token: 0x06018CB2 RID: 101554 RVA: 0x00787530 File Offset: 0x00785730
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

	// Token: 0x06018CB3 RID: 101555 RVA: 0x007875D8 File Offset: 0x007857D8
	public bool IsMultiSkill(SSkillInfo skillInfo)
	{
		return this.MultiSkillData.IsMultiSkill(skillInfo);
	}

	// Token: 0x06018CB4 RID: 101556 RVA: 0x007875E6 File Offset: 0x007857E6
	public bool CanStartMultiSkill(Skill skill)
	{
		SkillCdModel instance = SkillCdModel.Instance;
		return (instance != null && instance.SkillDebugMode) || this.MultiSkillData.CanStartMultiSkill(skill);
	}

	// Token: 0x06018CB5 RID: 101557 RVA: 0x00787609 File Offset: 0x00785809
	public bool StartMultiSkill(Skill skill, bool bCheck = true)
	{
		return SkillCdModel.Instance.SkillDebugMode || this.MultiSkillData.StartMultiSkill(skill, bCheck);
	}

	// Token: 0x06018CB6 RID: 101558 RVA: 0x00787626 File Offset: 0x00785826
	public void ResetMultiSkills(int skillId)
	{
		this.MultiSkillData.ResetMultiSkills(skillId, false);
	}

	// Token: 0x06018CB7 RID: 101559 RVA: 0x00787635 File Offset: 0x00785835
	private void GoDown(double coolDownTime)
	{
		this.MultiSkillData.ResetOnChangeRole();
	}

	// Token: 0x06018CB8 RID: 101560 RVA: 0x00787644 File Offset: 0x00785844
	public void OnSkillIdsChanged(IReadOnlyList<int> candidateSkillIds)
	{
		EntityHandle handleByEntity = CharacterModel.Instance.GetHandleByEntity(base.Entity);
		foreach (int num in candidateSkillIds)
		{
			if (!this.GroupSkillCdInfoMap.ContainsKey((long)num))
			{
				BaseSkillComponent skillComp = this.SkillComp;
				SSkillInfo sskillInfo = (skillComp != null) ? skillComp.GetSkillInfo(num) : null;
				if (sskillInfo != null)
				{
					GroupSkillCdInfo groupSkillCdInfo = this.InitSkillCdBySkillInfo(num, sskillInfo);
					if (groupSkillCdInfo != null)
					{
						groupSkillCdInfo.InitCdTags(handleByEntity);
					}
				}
			}
		}
	}

	// Token: 0x06018CB9 RID: 101561 RVA: 0x007876D8 File Offset: 0x007858D8
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

	// Token: 0x06018CBA RID: 101562 RVA: 0x00787800 File Offset: 0x00785A00
	private void InitSkillCdTags()
	{
		EntityHandle handleByEntity = CharacterModel.Instance.GetHandleByEntity(base.Entity);
		foreach (GroupSkillCdInfo groupSkillCdInfo in this.GroupSkillCdInfoMap.Values)
		{
			groupSkillCdInfo.InitCdTags(handleByEntity);
		}
	}

	// Token: 0x06018CBB RID: 101563 RVA: 0x00787868 File Offset: 0x00785A68
	public GroupSkillCdInfo GetGroupSkillCdInfo(int skillId)
	{
		return this.GroupSkillCdInfoMap.GetValueOrDefault((long)skillId);
	}

	// Token: 0x06018CBC RID: 101564 RVA: 0x00787878 File Offset: 0x00785A78
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

	// Token: 0x06018CBD RID: 101565 RVA: 0x007878AC File Offset: 0x00785AAC
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

	// Token: 0x06018CBE RID: 101566 RVA: 0x00787908 File Offset: 0x00785B08
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

	// Token: 0x06018CBF RID: 101567 RVA: 0x007879B4 File Offset: 0x00785BB4
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

	// Token: 0x06018CC0 RID: 101568 RVA: 0x00787AC0 File Offset: 0x00785CC0
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

	// Token: 0x06018CC1 RID: 101569 RVA: 0x00787B1C File Offset: 0x00785D1C
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

	// Token: 0x06018CC2 RID: 101570 RVA: 0x00787C8C File Offset: 0x00785E8C
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

	// Token: 0x06018CC3 RID: 101571 RVA: 0x00787CE4 File Offset: 0x00785EE4
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

	// Token: 0x06018CC4 RID: 101572 RVA: 0x00787D9C File Offset: 0x00785F9C
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

	// Token: 0x06018CC5 RID: 101573 RVA: 0x00787E54 File Offset: 0x00786054
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

	// Token: 0x06018CC6 RID: 101574 RVA: 0x00787ED0 File Offset: 0x007860D0
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterSkillCdComponent characterSkillCdComponent = (CharacterSkillCdComponent)componentTemplate;
		if (characterSkillCdComponent.SkillComp == null)
		{
			this.SkillComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SkillComp), "SkillComp"))
		{
			return false;
		}
		if (characterSkillCdComponent.AttrComp == null)
		{
			this.AttrComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AttrComp), "AttrComp"))
		{
			return false;
		}
		if (characterSkillCdComponent.CurWorldSkillCdData == null)
		{
			this.CurWorldSkillCdData = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurWorldSkillCdData), "CurWorldSkillCdData"))
		{
			return false;
		}
		if (characterSkillCdComponent.GroupSkillCdInfoMap == null)
		{
			this.GroupSkillCdInfoMap = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.GroupSkillCdInfoMap), "GroupSkillCdInfoMap"))
		{
			return false;
		}
		if (characterSkillCdComponent.SkillInfoMap == null)
		{
			this.SkillInfoMap = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SkillInfoMap), "SkillInfoMap"))
		{
			return false;
		}
		if (characterSkillCdComponent.MultiSkillData == null)
		{
			this.MultiSkillData = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MultiSkillData), "MultiSkillData"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x17002755 RID: 10069
	// (get) Token: 0x06018CC7 RID: 101575 RVA: 0x00787FF2 File Offset: 0x007861F2
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002756 RID: 10070
	// (get) Token: 0x06018CC8 RID: 101576 RVA: 0x00787FF5 File Offset: 0x007861F5
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002757 RID: 10071
	// (get) Token: 0x06018CC9 RID: 101577 RVA: 0x00787FF8 File Offset: 0x007861F8
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400D751 RID: 55121
	private const int DEFAULT_PROPORTTION_VALUE = 10000;

	// Token: 0x0400D752 RID: 55122
	[Nullable(2)]
	private BaseSkillComponent SkillComp;

	// Token: 0x0400D753 RID: 55123
	[Nullable(2)]
	private BaseAttributeComponent AttrComp;

	// Token: 0x0400D754 RID: 55124
	[Nullable(2)]
	private WorldSkillCdData CurWorldSkillCdData;

	// Token: 0x0400D755 RID: 55125
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<long, GroupSkillCdInfo> GroupSkillCdInfoMap;

	// Token: 0x0400D756 RID: 55126
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<long, SSkillInfo> SkillInfoMap;

	// Token: 0x0400D757 RID: 55127
	[Nullable(2)]
	private MultiSkillData MultiSkillData;
}
