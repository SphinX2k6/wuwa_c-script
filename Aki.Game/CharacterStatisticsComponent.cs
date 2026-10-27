using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.World.Model;
using UnrealEngine;

// Token: 0x02002EE1 RID: 12001
[NullableContext(1)]
[Nullable(0)]
public class CharacterStatisticsComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x06019A04 RID: 104964 RVA: 0x006A7F38 File Offset: 0x006A6138
	static CharacterStatisticsComponent()
	{
		Dictionary<global::ECharMoveState, string> dictionary = new Dictionary<global::ECharMoveState, string>();
		dictionary[global::ECharMoveState.Walk] = "走";
		dictionary[global::ECharMoveState.Run] = "跑";
		dictionary[global::ECharMoveState.Sprint] = "冲刺";
		dictionary[global::ECharMoveState.Dodge] = "闪避";
		CharacterStatisticsComponent.MoveStateToString = dictionary;
		CharacterStatisticsComponent.SkillGenreName = new string[]
		{
			"普攻0",
			"蓄力1",
			"E技能2",
			"大招3",
			"QTE4",
			"极限闪避反击5",
			"地面闪避6",
			"极限闪避7",
			"被动技能8",
			"战斗幻象技9",
			"探索幻象技10",
			"空中闪避11",
			"无类别"
		};
		CharacterStatisticsComponent.OperationRecordTitle = "角色ID,角色名称,配置ID,技能/阶段,时间,次数\n";
		CharacterStatisticsComponent.IsCombatStarted = false;
		CharacterStatisticsComponent.CurrentAttackerId = 0;
		CharacterStatisticsComponent.CurrentTargetId = 0;
		CharacterStatisticsComponent.ItemsResetInternal = false;
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterStatisticsComponent.CreateStaticDefaultValue), new Action(CharacterStatisticsComponent.ResetStaticDefaultValue));
	}

	// Token: 0x06019A05 RID: 104965 RVA: 0x006A80E8 File Offset: 0x006A62E8
	protected override bool OnInit()
	{
		EventSystem.Instance.AddWithTarget<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(base.Entity, EEventName.CharBeDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnCharDamageAll));
		EventSystem.Instance.AddWithTarget<int, int, bool>(base.Entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnBeginSkillCombat));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharOnRevive, new Action(this.OnCharReviveAll));
		return true;
	}

	// Token: 0x06019A06 RID: 104966 RVA: 0x006A8156 File Offset: 0x006A6356
	protected override bool OnStart()
	{
		this.InitStageBeginTime();
		return true;
	}

	// Token: 0x06019A07 RID: 104967 RVA: 0x006A815F File Offset: 0x006A635F
	protected override void OnActivate()
	{
		if (CharacterStatisticsComponent.OpenOperationRecord)
		{
			this.StatisticsEnable = CharacterStatisticsComponent.IsInRecordArea(base.Entity);
		}
		this.OnActivateOperationRecord();
	}

	// Token: 0x06019A08 RID: 104968 RVA: 0x006A8180 File Offset: 0x006A6380
	protected override bool OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(base.Entity, EEventName.CharBeDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnCharDamageAll));
		EventSystem.Instance.RemoveWithTarget<int, int, bool>(base.Entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnBeginSkillCombat));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharOnRevive, new Action(this.OnCharReviveAll));
		if (CharacterStatisticsComponent.OpenOperationRecordInternal)
		{
			this.RemoveListenOperation();
		}
		return true;
	}

	// Token: 0x06019A09 RID: 104969 RVA: 0x006A81FC File Offset: 0x006A63FC
	private void OnCharDamageAll(Entity attacker, Entity victim, RequirementPayload requirements, DamageResult damageResult, FVectorDouble damagePosition)
	{
		int num = (int)damageResult.Damage;
		Damage damageData = damageResult.DamageData;
		ECalculationType calculateType = (ECalculationType)damageData.CalculateType;
		if (calculateType != ECalculationType.Hurt)
		{
			if (calculateType == ECalculationType.Heal)
			{
				if (this.StatisticsEnable)
				{
					this.OnCharHealStatistic(-num, attacker, victim, damageResult);
				}
				this.OnCharHealCombat(-num, attacker, victim, damageResult, requirements);
				return;
			}
		}
		else
		{
			if (this.StatisticsEnable)
			{
				this.OnCharDamageStatistic(num, (int)damageResult.Element, damagePosition, attacker, victim, requirements.IsCritical.GetValueOrDefault(), damageData.DamageTextType, requirements.IsImmune.GetValueOrDefault(), damageData.Id, requirements.BulletId, requirements.BuffId);
			}
			this.OnCharDamageCombat(num, (int)damageResult.Element, damagePosition, attacker, victim, requirements.IsCritical.GetValueOrDefault(), damageData.DamageTextType, requirements.IsImmune.GetValueOrDefault(), damageData.Id, requirements.BulletId, requirements.BuffId, requirements.IsTargetKilled, requirements);
		}
	}

	// Token: 0x06019A0A RID: 104970 RVA: 0x006A82E1 File Offset: 0x006A64E1
	public void OnBuffAdded(ActiveBuffInternal buff)
	{
		this.OnBuffAddedCombat(buff);
	}

	// Token: 0x06019A0B RID: 104971 RVA: 0x006A82EA File Offset: 0x006A64EA
	public void OnBuffRemoved(ActiveBuffInternal buff)
	{
		this.OnBuffRemovedCombat(buff);
	}

	// Token: 0x06019A0C RID: 104972 RVA: 0x006A82F3 File Offset: 0x006A64F3
	private void OnCharReviveAll()
	{
		this.OnCharReviveCombat();
	}

	// Token: 0x06019A0D RID: 104973 RVA: 0x006A82FB File Offset: 0x006A64FB
	public bool GetStatisticsEnable()
	{
		return this.StatisticsEnable;
	}

	// Token: 0x1700236E RID: 9070
	// (get) Token: 0x06019A0E RID: 104974 RVA: 0x006A8303 File Offset: 0x006A6503
	private static List<int> AllStatisticsEnableEntityId
	{
		get
		{
			return CharacterStatisticsComponent._allStatisticsEnableEntityId;
		}
	}

	// Token: 0x06019A0F RID: 104975 RVA: 0x006A830C File Offset: 0x006A650C
	public static void SetStatisticsEnable(bool enable)
	{
		if (enable)
		{
			using (IEnumerator<EntityHandle> enumerator = CreatureModel.Instance.GetAllEntities().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					EntityHandle entityHandle = enumerator.Current;
					if (CharacterStatisticsComponent.IsInRecordArea(entityHandle.Entity))
					{
						CharacterStatisticsComponent component = entityHandle.Entity.GetComponent<CharacterStatisticsComponent>();
						if (component != null && component.Valid)
						{
							component.StatisticsEnable = true;
							CharacterStatisticsComponent.AllStatisticsEnableEntityId.Add(entityHandle.Id);
						}
					}
				}
				return;
			}
		}
		foreach (int id in CharacterStatisticsComponent.AllStatisticsEnableEntityId)
		{
			Entity entity = EntitySystem.Instance.Get(id);
			if (entity != null && entity.Valid)
			{
				entity.GetComponent<CharacterStatisticsComponent>().StatisticsEnable = false;
			}
		}
		CharacterStatisticsComponent.AllStatisticsEnableEntityId.Clear();
	}

	// Token: 0x1700236F RID: 9071
	// (get) Token: 0x06019A10 RID: 104976 RVA: 0x006A8410 File Offset: 0x006A6610
	private static Dictionary<int, Dictionary<EDamageType, DamageStatisticsData>> DamageStaticsBySkillTypeMap
	{
		get
		{
			return CharacterStatisticsComponent._damageStaticsBySkillTypeMap;
		}
	}

	// Token: 0x17002370 RID: 9072
	// (get) Token: 0x06019A11 RID: 104977 RVA: 0x006A8417 File Offset: 0x006A6617
	private static Dictionary<int, Dictionary<global::EAttackType, DamageStatisticsData>> DamageStaticsByAttackTypeMap
	{
		get
		{
			return CharacterStatisticsComponent._damageStaticsByAttackTypeMap;
		}
	}

	// Token: 0x17002371 RID: 9073
	// (get) Token: 0x06019A12 RID: 104978 RVA: 0x006A841E File Offset: 0x006A661E
	private static Dictionary<int, Dictionary<EDamageType, DamageStatisticsData>> HealStaticsBySkillTypeMap
	{
		get
		{
			return CharacterStatisticsComponent._healStaticsBySkillTypeMap;
		}
	}

	// Token: 0x17002372 RID: 9074
	// (get) Token: 0x06019A13 RID: 104979 RVA: 0x006A8425 File Offset: 0x006A6625
	private static Dictionary<int, Dictionary<global::EAttackType, DamageStatisticsData>> HealStaticsByAttackTypeMap
	{
		get
		{
			return CharacterStatisticsComponent._healStaticsByAttackTypeMap;
		}
	}

	// Token: 0x06019A14 RID: 104980 RVA: 0x006A842C File Offset: 0x006A662C
	public static void CleanupRecordData()
	{
		CharacterStatisticsComponent.DamageStaticsByAttackTypeMap.Clear();
		CharacterStatisticsComponent.HealStaticsByAttackTypeMap.Clear();
		CharacterStatisticsComponent.DamageStaticsBySkillTypeMap.Clear();
		CharacterStatisticsComponent.HealStaticsBySkillTypeMap.Clear();
	}

	// Token: 0x06019A15 RID: 104981 RVA: 0x006A8458 File Offset: 0x006A6658
	private void OnCharHealStatistic(int healMagnitude, Entity healer, Entity target, DamageResult parameters)
	{
		int damage = (int)parameters.Damage;
		long id = parameters.DamageData.Id;
		CharacterStatisticsComponent.ProcessRecordBySkillType(damage, healer, target, id, true, null, null);
		CharacterStatisticsComponent.ProcessRecordByAttackType(damage, healer, target, id, true);
	}

	// Token: 0x06019A16 RID: 104982 RVA: 0x006A849F File Offset: 0x006A669F
	private void OnCharDamageStatistic(int damage, int elementId, FVectorDouble damagePosition, Entity attacker, Entity victim, bool bCritical, int damageTextType, bool bImmune, long damageId, long? bulletId = null, long? buffId = null)
	{
		CharacterStatisticsComponent.ProcessRecordBySkillType(damage, attacker, victim, damageId, false, bulletId, buffId);
		CharacterStatisticsComponent.ProcessRecordByAttackType(damage, attacker, victim, damageId, false);
	}

	// Token: 0x06019A17 RID: 104983 RVA: 0x006A84C0 File Offset: 0x006A66C0
	public static void ProcessRecordBySkillType(int damage, Entity attacker, Entity victim, long damageId, bool isHeal, long? bulletId = null, long? buffId = null)
	{
		CreatureDataComponent component = attacker.GetComponent<CreatureDataComponent>();
		if (component.GetEntityType() != EEntityType.Player)
		{
			return;
		}
		int num = component.Valid ? component.GetRoleId() : 0;
		int baseRoleId = RoleConfig.Instance.GetBaseRoleId(num);
		if (baseRoleId == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "获取不到roleData";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", num);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(baseRoleId);
		if (roleConfig == null)
		{
			return;
		}
		string roleName = RoleConfig.Instance.GetRoleName(roleConfig.Value.Name);
		IReadOnlyList<Aki.Config.Skill> skillList = RoleSkillConfig.Instance.GetSkillList(roleConfig.Value.SkillId);
		int num2 = 0;
		if (skillList != null)
		{
			foreach (Aki.Config.Skill skill in skillList)
			{
				if (CharacterStatisticsComponent.TryGetSkillContainsDamage(skill, damageId))
				{
					num2 = skill.SkillType;
					break;
				}
			}
		}
		Dictionary<int, Dictionary<EDamageType, DamageStatisticsData>> dictionary = isHeal ? CharacterStatisticsComponent.HealStaticsBySkillTypeMap : CharacterStatisticsComponent.DamageStaticsBySkillTypeMap;
		Dictionary<EDamageType, DamageStatisticsData> dictionary2;
		if (!dictionary.TryGetValue(baseRoleId, out dictionary2))
		{
			dictionary2 = new Dictionary<EDamageType, DamageStatisticsData>();
			dictionary[baseRoleId] = dictionary2;
		}
		if (num2 > 0)
		{
			EDamageType key = (EDamageType)(num2 - 1);
			DamageStatisticsData damageStatisticsData;
			if (!dictionary2.TryGetValue(key, out damageStatisticsData))
			{
				string damageType = CharacterStatisticsComponent.skillTypeToString[num2 - 1];
				damageStatisticsData = new DamageStatisticsData(baseRoleId, roleName, damageType, isHeal);
				dictionary2[key] = damageStatisticsData;
			}
			damageStatisticsData.AddDamageValue(victim.Id, damage);
			if (damageStatisticsData.GetTargetCount() > CharacterStatisticsComponent.TargetMaxCountSkillType)
			{
				CharacterStatisticsComponent.TargetMaxCountSkillType = damageStatisticsData.GetTargetCount();
				return;
			}
		}
		else
		{
			Damage? damageConfigById = DamageModel.Instance.GetDamageConfigById(damageId);
			if (((damageConfigById != null) ? damageConfigById.GetValueOrDefault().Type : -1) != 5)
			{
				return;
			}
			DamageStatisticsData damageStatisticsData2;
			if (!dictionary2.TryGetValue(EDamageType.Vision, out damageStatisticsData2))
			{
				damageStatisticsData2 = new DamageStatisticsData(baseRoleId, roleName, CharacterStatisticsComponent.skillTypeToString[6], isHeal);
				dictionary2[EDamageType.Vision] = damageStatisticsData2;
			}
			damageStatisticsData2.AddDamageValue(victim.Id, damage);
			if (damageStatisticsData2.GetTargetCount() > CharacterStatisticsComponent.TargetMaxCountSkillType)
			{
				CharacterStatisticsComponent.TargetMaxCountSkillType = damageStatisticsData2.GetTargetCount();
			}
		}
	}

	// Token: 0x06019A18 RID: 104984 RVA: 0x006A86E8 File Offset: 0x006A68E8
	private static void ProcessRecordByAttackType(int damage, Entity attacker, Entity victim, long damageId, bool isHeal)
	{
		CreatureDataComponent component = attacker.GetComponent<CreatureDataComponent>();
		if (!component.IsRole())
		{
			return;
		}
		Damage? damageConfigById = DamageModel.Instance.GetDamageConfigById(damageId);
		if (damageConfigById == null)
		{
			return;
		}
		int num = component.Valid ? component.GetRoleId() : 0;
		int baseRoleId = RoleConfig.Instance.GetBaseRoleId(num);
		if (baseRoleId == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "获取不到roleData";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", num);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(baseRoleId);
		if (roleConfig == null)
		{
			return;
		}
		string roleName = RoleConfig.Instance.GetRoleName(roleConfig.Value.Name);
		Dictionary<int, Dictionary<global::EAttackType, DamageStatisticsData>> dictionary = isHeal ? CharacterStatisticsComponent.HealStaticsByAttackTypeMap : CharacterStatisticsComponent.DamageStaticsByAttackTypeMap;
		Dictionary<global::EAttackType, DamageStatisticsData> dictionary2;
		if (!dictionary.TryGetValue(baseRoleId, out dictionary2))
		{
			dictionary2 = new Dictionary<global::EAttackType, DamageStatisticsData>();
			dictionary[baseRoleId] = dictionary2;
		}
		global::EAttackType type = (global::EAttackType)damageConfigById.Value.Type;
		DamageStatisticsData damageStatisticsData;
		if (!dictionary2.TryGetValue(type, out damageStatisticsData))
		{
			damageStatisticsData = new DamageStatisticsData(baseRoleId, roleName, CharacterStatisticsComponent.attackTypeToString[(int)type], isHeal);
			dictionary2[type] = damageStatisticsData;
		}
		damageStatisticsData.AddDamageValue(victim.Id, damage);
		if (CharacterStatisticsComponent.TargetMaxCountAttackType < damageStatisticsData.GetTargetCount())
		{
			CharacterStatisticsComponent.TargetMaxCountAttackType = damageStatisticsData.GetTargetCount();
		}
	}

	// Token: 0x06019A19 RID: 104985 RVA: 0x006A8831 File Offset: 0x006A6A31
	private static bool TryGetSkillContainsDamage(Aki.Config.Skill skill, long damageId)
	{
		return CharacterStatisticsComponent.SkillContainsDamageInternal(skill, damageId);
	}

	// Token: 0x06019A1A RID: 104986 RVA: 0x006A883C File Offset: 0x006A6A3C
	private unsafe static bool SkillContainsDamageInternal(Aki.Config.Skill skill, long damageId)
	{
		try
		{
			Span<long> damageListBytes = skill.GetDamageListBytes();
			for (int i = 0; i < damageListBytes.Length; i++)
			{
				long num = *damageListBytes[i];
				if (num == damageId || num == (long)((int)damageId))
				{
					return true;
				}
			}
		}
		catch
		{
		}
		return false;
	}

	// Token: 0x06019A1B RID: 104987 RVA: 0x006A8894 File Offset: 0x006A6A94
	public static string ExportStatisticsBySkillType()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("角色Id,名称,治疗/伤害,技能");
		for (int i = 0; i < CharacterStatisticsComponent.TargetMaxCountSkillType; i++)
		{
			string text = (i + 1).ToString();
			stringBuilder.Append(StringUtils.Format(CharacterStatisticsComponent.TargetTitleFormat, new string[]
			{
				text,
				text,
				text,
				text,
				text
			}));
		}
		stringBuilder.Append('\n');
		foreach (Dictionary<EDamageType, DamageStatisticsData> dictionary in CharacterStatisticsComponent.DamageStaticsBySkillTypeMap.Values)
		{
			foreach (DamageStatisticsData damageStatisticsData in dictionary.Values)
			{
				stringBuilder.Append(damageStatisticsData.ToString());
			}
		}
		foreach (Dictionary<EDamageType, DamageStatisticsData> dictionary2 in CharacterStatisticsComponent.HealStaticsBySkillTypeMap.Values)
		{
			foreach (DamageStatisticsData damageStatisticsData2 in dictionary2.Values)
			{
				stringBuilder.Append(damageStatisticsData2.ToString());
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06019A1C RID: 104988 RVA: 0x006A8A20 File Offset: 0x006A6C20
	public static string ExportStatisticsByAttackType()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("角色Id,名称,治疗/伤害,伤害类型");
		for (int i = 0; i < CharacterStatisticsComponent.TargetMaxCountAttackType; i++)
		{
			string text = (i + 1).ToString();
			stringBuilder.Append(StringUtils.Format(CharacterStatisticsComponent.TargetTitleFormat, new string[]
			{
				text,
				text,
				text,
				text,
				text
			}));
		}
		stringBuilder.Append('\n');
		foreach (Dictionary<global::EAttackType, DamageStatisticsData> dictionary in CharacterStatisticsComponent.DamageStaticsByAttackTypeMap.Values)
		{
			foreach (DamageStatisticsData damageStatisticsData in dictionary.Values)
			{
				stringBuilder.Append(damageStatisticsData.ToString());
			}
		}
		foreach (Dictionary<global::EAttackType, DamageStatisticsData> dictionary2 in CharacterStatisticsComponent.HealStaticsByAttackTypeMap.Values)
		{
			foreach (DamageStatisticsData damageStatisticsData2 in dictionary2.Values)
			{
				stringBuilder.Append(damageStatisticsData2.ToString());
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x17002373 RID: 9075
	// (get) Token: 0x06019A1D RID: 104989 RVA: 0x006A8BAC File Offset: 0x006A6DAC
	private static Dictionary<int, CharacterOperationRecord> CharacterOperationRecordMap
	{
		get
		{
			return CharacterStatisticsComponent._characterOperationRecordMap;
		}
	}

	// Token: 0x17002374 RID: 9076
	// (get) Token: 0x06019A1E RID: 104990 RVA: 0x006A8BB3 File Offset: 0x006A6DB3
	public static bool OpenOperationRecord
	{
		get
		{
			return CharacterStatisticsComponent.OpenOperationRecordInternal;
		}
	}

	// Token: 0x06019A1F RID: 104991 RVA: 0x006A8BBA File Offset: 0x006A6DBA
	private void OnActivateOperationRecord()
	{
		if (!CharacterStatisticsComponent.OpenOperationRecordInternal)
		{
			return;
		}
		if (CharacterStatisticsComponent.CharacterOperationRecordMap.ContainsKey(base.Entity.Id))
		{
			return;
		}
		if (CharacterStatisticsComponent.IsInRecordArea(base.Entity))
		{
			this.ListenOperation();
		}
	}

	// Token: 0x06019A20 RID: 104992 RVA: 0x006A8BF0 File Offset: 0x006A6DF0
	private void ListenOperation()
	{
		this.OperationBeginTimeMap.Clear();
		this.MoveOperationBeginTimeMap.Clear();
		this.TagOperationBeginTimeMap.Clear();
		if (base.Entity.GetComponent<CreatureDataComponent>().IsRole())
		{
			CharacterStatisticsComponent.InAreaEntityId.Add(base.Entity.Id);
			EventSystem.Instance.AddWithTarget<int, int, bool>(base.Entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OperationRecordBeginSkill));
			EventSystem.Instance.AddWithTarget<int, int>(base.Entity, EEventName.OnSkillEnd, new Action<int, int>(this.OperationRecordEndSkill));
			EventSystem.Instance.AddWithTarget<global::ECharMoveState, global::ECharMoveState>(base.Entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<global::ECharMoveState, global::ECharMoveState>(this.OnMoveStateChange));
			CharacterUnifiedStateComponent component = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
			if (component != null && component.Valid)
			{
				this.OnMoveStateStart(component.MoveState);
			}
			BaseTagComponent baseTagComponent = base.Entity.CheckGetComponent<BaseTagComponent>();
			if (baseTagComponent != null && baseTagComponent.Valid)
			{
				ITagTask tagTask = baseTagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.被击硬直时间"]), new BaseTagComponent.TTagSwitchedCallback(this.OnTagChanged), null);
				if (tagTask != null)
				{
					this.ListenOperationTasks.Add(tagTask);
				}
			}
			using (Dictionary<int, string>.KeyCollection.Enumerator enumerator = CharacterStatisticsComponent.RoleStageInfo.Keys.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int num = enumerator.Current;
					if (baseTagComponent.HasTag(num))
					{
						this.TagOperationBeginTimeMap[num] = Time.Instance.NowSeconds;
					}
				}
				return;
			}
		}
		BaseTagComponent baseTagComponent2 = base.Entity.CheckGetComponent<BaseTagComponent>();
		if (baseTagComponent2 != null && baseTagComponent2.Valid)
		{
			CharacterStatisticsComponent.InAreaEntityId.Add(base.Entity.Id);
			this.AddListenTagTask(baseTagComponent2, GameplayTagDefine.EGameplayTagId["Damage.Vulnerable"]);
			this.AddListenTagTask(baseTagComponent2, GameplayTagDefine.EGameplayTagId["功能.功能制作.白条生效"]);
			this.AddListenTagTask(baseTagComponent2, GameplayTagDefine.EGameplayTagId["功能.功能制作.狂暴生效"]);
			this.AddListenTagTask(baseTagComponent2, GameplayTagDefine.EGameplayTagId["怪物.common.状态标识.瘫痪中"]);
			foreach (int num2 in CharacterStatisticsComponent.MonsterStageInfo.Keys)
			{
				if (baseTagComponent2.HasTag(num2))
				{
					this.TagOperationBeginTimeMap[num2] = Time.Instance.NowSeconds;
				}
			}
		}
	}

	// Token: 0x06019A21 RID: 104993 RVA: 0x006A8E74 File Offset: 0x006A7074
	private void AddListenTagTask(BaseTagComponent tagComp, int tagId)
	{
		ITagTask tagTask = tagComp.ListenForTagAddOrRemove(new int?(tagId), new BaseTagComponent.TTagSwitchedCallback(this.OnTagChanged), null);
		if (tagTask != null)
		{
			this.ListenOperationTasks.Add(tagTask);
		}
	}

	// Token: 0x06019A22 RID: 104994 RVA: 0x006A8EAC File Offset: 0x006A70AC
	private void RemoveListenOperation()
	{
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		if (component != null && component.IsRole())
		{
			EventSystem.Instance.RemoveWithTarget<int, int, bool>(base.Entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OperationRecordBeginSkill));
			EventSystem.Instance.RemoveWithTarget<int, int>(base.Entity, EEventName.OnSkillEnd, new Action<int, int>(this.OperationRecordEndSkill));
			EventSystem.Instance.RemoveWithTarget<global::ECharMoveState, global::ECharMoveState>(base.Entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<global::ECharMoveState, global::ECharMoveState>(this.OnMoveStateChange));
		}
		foreach (ITagTask tagTask in this.ListenOperationTasks)
		{
			tagTask.EndTask();
		}
		this.ListenOperationTasks.Clear();
	}

	// Token: 0x06019A23 RID: 104995 RVA: 0x006A8F80 File Offset: 0x006A7180
	private void OnMoveStateChange(global::ECharMoveState oldMoveState, global::ECharMoveState newMoveState)
	{
		if (!CharacterStatisticsComponent.OpenOperationRecordInternal || !base.Entity.GetComponent<CreatureDataComponent>().IsRole())
		{
			return;
		}
		this.OnMoveStateEnd(oldMoveState);
		this.OnMoveStateStart(newMoveState);
	}

	// Token: 0x06019A24 RID: 104996 RVA: 0x006A8FAC File Offset: 0x006A71AC
	private unsafe void OnMoveStateStart(global::ECharMoveState state)
	{
		if (!CharacterStatisticsComponent.MoveStateToString.ContainsKey(state))
		{
			return;
		}
		double? num;
		if (this.MoveOperationBeginTimeMap.TryGetValue(state, out num) && num != null)
		{
			RoleInfo? roleConfig = base.Entity.GetComponent<CreatureDataComponent>().GetRoleConfig();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "记录移动开始时间时有未执行OnMoveStateEnd";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("RoleName", RoleConfig.Instance.GetRoleName(roleConfig.Value.Name));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("State", state);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		this.MoveOperationBeginTimeMap[state] = new double?(Time.Instance.NowSeconds);
	}

	// Token: 0x06019A25 RID: 104997 RVA: 0x006A9084 File Offset: 0x006A7284
	private unsafe void OnMoveStateEnd(global::ECharMoveState state)
	{
		if (!CharacterStatisticsComponent.MoveStateToString.ContainsKey(state))
		{
			return;
		}
		int id = base.Entity.Id;
		CharacterOperationRecord characterOperationRecord;
		if (!CharacterStatisticsComponent.CharacterOperationRecordMap.TryGetValue(id, out characterOperationRecord))
		{
			RoleInfo? roleConfig = base.Entity.GetComponent<CreatureDataComponent>().GetRoleConfig();
			characterOperationRecord = new CharacterOperationRecord(RoleConfig.Instance.GetRoleName(roleConfig.Value.Name), id, roleConfig.Value.Id);
			CharacterStatisticsComponent.CharacterOperationRecordMap[id] = characterOperationRecord;
		}
		SkillOperationRecord skillOperationRecord;
		if (!characterOperationRecord.MoveOperationMap.TryGetValue(state, out skillOperationRecord))
		{
			skillOperationRecord = new SkillOperationRecord(CharacterStatisticsComponent.MoveStateToString[state]);
			characterOperationRecord.MoveOperationMap[state] = skillOperationRecord;
		}
		double? num;
		if (!this.MoveOperationBeginTimeMap.TryGetValue(state, out num) || num == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "计算出现异常 OnMoveStateEnd";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", characterOperationRecord.Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Id", characterOperationRecord.EntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Map", this.MoveOperationBeginTimeMap);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		else
		{
			skillOperationRecord.AddOptCountAndTime((int)(Time.Instance.NowSeconds - num.Value), 1);
		}
		this.MoveOperationBeginTimeMap[state] = null;
	}

	// Token: 0x06019A26 RID: 104998 RVA: 0x006A9204 File Offset: 0x006A7404
	private unsafe void OperationRecordBeginSkill(int entityId, int skillId, bool isAutonomousProxy)
	{
		if (!CharacterStatisticsComponent.OpenOperationRecordInternal || !base.Entity.GetComponent<CreatureDataComponent>().IsRole())
		{
			return;
		}
		double? num;
		if (this.OperationBeginTimeMap.TryGetValue((long)skillId, out num) && num != null)
		{
			RoleInfo? roleConfig = base.Entity.GetComponent<CreatureDataComponent>().GetRoleConfig();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "记录技能开始使用时间时有技能未执行EndSkill";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("RoleName", RoleConfig.Instance.GetRoleName(roleConfig.Value.Name));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SkillId", skillId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		this.OperationBeginTimeMap[(long)skillId] = new double?(Time.Instance.NowSeconds);
	}

	// Token: 0x06019A27 RID: 104999 RVA: 0x006A92E8 File Offset: 0x006A74E8
	private unsafe void OperationRecordEndSkill(int entityId, int skillId)
	{
		if (!CharacterStatisticsComponent.OpenOperationRecordInternal || !base.Entity.GetComponent<CreatureDataComponent>().IsRole())
		{
			return;
		}
		CharacterOperationRecord characterOperationRecord;
		if (!CharacterStatisticsComponent.CharacterOperationRecordMap.TryGetValue(entityId, out characterOperationRecord))
		{
			RoleInfo? roleConfig = base.Entity.GetComponent<CreatureDataComponent>().GetRoleConfig();
			characterOperationRecord = new CharacterOperationRecord(RoleConfig.Instance.GetRoleName(roleConfig.Value.Name), entityId, roleConfig.Value.Id);
			CharacterStatisticsComponent.CharacterOperationRecordMap[entityId] = characterOperationRecord;
		}
		double? num;
		if (!this.OperationBeginTimeMap.TryGetValue((long)skillId, out num) || num == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "计算出现异常 EndSkill";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", characterOperationRecord.Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Id", characterOperationRecord.EntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Map", this.OperationBeginTimeMap);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		else
		{
			IReadOnlyList<ESkillGenre> skillGenres = base.Entity.GetComponent<BaseSkillComponent>().GetSkillGenres(skillId);
			int time = (int)(Time.Instance.NowSeconds - num.Value);
			for (int i = 0; i < skillGenres.Count; i++)
			{
				int num2 = (int)skillGenres[i];
				SkillOperationRecord skillOperationRecord;
				if (!characterOperationRecord.SkillOperationMap.TryGetValue(num2, out skillOperationRecord))
				{
					skillOperationRecord = new SkillOperationRecord((num2 >= 0 && num2 < CharacterStatisticsComponent.SkillGenreName.Length) ? CharacterStatisticsComponent.SkillGenreName[num2] : CharacterStatisticsComponent.SkillGenreName[CharacterStatisticsComponent.SkillGenreName.Length - 1]);
					characterOperationRecord.SkillOperationMap[num2] = skillOperationRecord;
				}
				skillOperationRecord.AddOptCountAndTime(time, 1);
			}
		}
		this.OperationBeginTimeMap[(long)skillId] = null;
	}

	// Token: 0x17002375 RID: 9077
	// (get) Token: 0x06019A28 RID: 105000 RVA: 0x006A94C7 File Offset: 0x006A76C7
	private static Dictionary<int, string> MonsterStageInfo
	{
		get
		{
			return CharacterStatisticsComponent._monsterStageInfo;
		}
	}

	// Token: 0x17002376 RID: 9078
	// (get) Token: 0x06019A29 RID: 105001 RVA: 0x006A94CE File Offset: 0x006A76CE
	private static Dictionary<int, string> RoleStageInfo
	{
		get
		{
			return CharacterStatisticsComponent._roleStageInfo;
		}
	}

	// Token: 0x06019A2A RID: 105002 RVA: 0x006A94D5 File Offset: 0x006A76D5
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public static Dictionary<int, string> StageInfo(EEntityType entityType)
	{
		if (entityType == EEntityType.Monster)
		{
			return CharacterStatisticsComponent.MonsterStageInfo;
		}
		if (entityType == EEntityType.Player)
		{
			return CharacterStatisticsComponent.RoleStageInfo;
		}
		return null;
	}

	// Token: 0x06019A2B RID: 105003 RVA: 0x006A94EC File Offset: 0x006A76EC
	private void InitStageBeginTime()
	{
		if (!CharacterStatisticsComponent.OpenOperationRecordInternal)
		{
			return;
		}
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		if (component == null)
		{
			return;
		}
		Dictionary<int, string> dictionary = CharacterStatisticsComponent.StageInfo(base.Entity.GetComponent<CreatureDataComponent>().GetEntityType());
		if (dictionary == null)
		{
			return;
		}
		foreach (int tagId in dictionary.Keys)
		{
			if (component.HasTag(tagId))
			{
				this.OnTagChanged(tagId, true);
			}
		}
	}

	// Token: 0x06019A2C RID: 105004 RVA: 0x006A957C File Offset: 0x006A777C
	private unsafe void OnTagChanged(int tagId, bool exists)
	{
		if (!CharacterStatisticsComponent.OpenOperationRecordInternal)
		{
			return;
		}
		if (exists)
		{
			this.TagOperationBeginTimeMap[tagId] = Time.Instance.NowSeconds;
			return;
		}
		double num;
		this.TagOperationBeginTimeMap.TryGetValue(tagId, out num);
		double num2 = Time.Instance.NowSeconds - num;
		int id = base.Entity.Id;
		CharacterOperationRecord characterOperationRecord;
		if (!CharacterStatisticsComponent.CharacterOperationRecordMap.TryGetValue(id, out characterOperationRecord))
		{
			CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
			EEntityType entityType = component.GetEntityType();
			if (entityType == EEntityType.Monster)
			{
				characterOperationRecord = new CharacterOperationRecord(PublicUtil.Instance.GetConfigTextByKey(component.GetEntityTidName() ?? ""), id, component.GetPbDataId());
			}
			else
			{
				if (entityType != EEntityType.Player)
				{
					return;
				}
				RoleInfo? roleConfig = component.GetRoleConfig();
				characterOperationRecord = new CharacterOperationRecord(RoleConfig.Instance.GetRoleName(roleConfig.Value.Name), id, roleConfig.Value.Id);
			}
			CharacterStatisticsComponent.CharacterOperationRecordMap[id] = characterOperationRecord;
		}
		Dictionary<int, string> dictionary = CharacterStatisticsComponent.StageInfo(base.Entity.GetComponent<CreatureDataComponent>().GetEntityType());
		if (dictionary == null)
		{
			return;
		}
		SkillOperationRecord skillOperationRecord;
		if (!characterOperationRecord.TagOperationMap.TryGetValue(tagId, out skillOperationRecord))
		{
			skillOperationRecord = new SkillOperationRecord(dictionary[tagId]);
			characterOperationRecord.TagOperationMap[tagId] = skillOperationRecord;
		}
		if (double.IsNaN(num2))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "计算出现异常 OnTagChanged";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", base.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("beginTime", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Map", this.TagOperationBeginTimeMap);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("TagId", tagId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			return;
		}
		skillOperationRecord.AddOptCountAndTime((int)num2, 1);
	}

	// Token: 0x17002377 RID: 9079
	// (get) Token: 0x06019A2D RID: 105005 RVA: 0x006A9777 File Offset: 0x006A7977
	private static List<int> InAreaEntityId
	{
		get
		{
			return CharacterStatisticsComponent._inAreaEntityId;
		}
	}

	// Token: 0x06019A2E RID: 105006 RVA: 0x006A9780 File Offset: 0x006A7980
	public static void OperationRecord(bool open)
	{
		CharacterStatisticsComponent.OpenOperationRecordInternal = open;
		if (!open)
		{
			foreach (int id in CharacterStatisticsComponent.InAreaEntityId)
			{
				Entity entity = EntitySystem.Instance.Get(id);
				if (entity != null && entity.Valid)
				{
					CharacterStatisticsComponent component = entity.GetComponent<CharacterStatisticsComponent>();
					if (component != null)
					{
						component.StatisticsEnable = false;
						component.RemoveListenOperation();
					}
				}
			}
			CharacterStatisticsComponent.InAreaEntityId.Clear();
			return;
		}
		foreach (EntityHandle entityHandle in CreatureModel.Instance.GetAllEntities())
		{
			CharacterStatisticsComponent component2 = entityHandle.Entity.GetComponent<CharacterStatisticsComponent>();
			if (component2 != null)
			{
				CharacterAbilityComponent component3 = entityHandle.Entity.GetComponent<CharacterAbilityComponent>();
				if (component3 != null && component3.Valid && CharacterStatisticsComponent.IsInRecordArea(entityHandle.Entity))
				{
					component2.StatisticsEnable = true;
					component2.ListenOperation();
				}
			}
		}
	}

	// Token: 0x06019A2F RID: 105007 RVA: 0x006A98A0 File Offset: 0x006A7AA0
	public static bool IsInRecordArea(Entity entity)
	{
		if (entity == null || !entity.Valid)
		{
			return false;
		}
		CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
		if (component.IsRole())
		{
			return true;
		}
		if (component.IsMonster())
		{
			BaseActorComponent component2 = entity.GetComponent<BaseActorComponent>();
			if (component2 == null)
			{
				return false;
			}
			if (global::Vector.DistSquaredXY(component2.ActorLocationProxy, CameraModel.Instance.MainModel.CameraLocation) < CharacterStatisticsComponent.HalfLengthRecordSquared)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06019A30 RID: 105008 RVA: 0x006A990C File Offset: 0x006A7B0C
	[NullableContext(2)]
	public static string ExportRecord()
	{
		if (CharacterStatisticsComponent.CharacterOperationRecordMap.Count == 0)
		{
			return null;
		}
		if (CharacterStatisticsComponent.OpenOperationRecordInternal)
		{
			CharacterStatisticsComponent.OperationRecord(false);
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(CharacterStatisticsComponent.OperationRecordTitle);
		foreach (CharacterOperationRecord characterOperationRecord in CharacterStatisticsComponent.CharacterOperationRecordMap.Values)
		{
			stringBuilder.Append(characterOperationRecord.ToString());
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06019A31 RID: 105009 RVA: 0x006A999C File Offset: 0x006A7B9C
	public static int OperationRecordCount()
	{
		int num = 0;
		foreach (CharacterOperationRecord characterOperationRecord in CharacterStatisticsComponent.CharacterOperationRecordMap.Values)
		{
			num += characterOperationRecord.SkillOperationMap.Count;
			num += characterOperationRecord.MoveOperationMap.Count;
			num += characterOperationRecord.TagOperationMap.Count;
		}
		return num;
	}

	// Token: 0x06019A32 RID: 105010 RVA: 0x006A9A1C File Offset: 0x006A7C1C
	public static void CleanupOperationRecord()
	{
		CharacterStatisticsComponent.CharacterOperationRecordMap.Clear();
	}

	// Token: 0x17002378 RID: 9080
	// (get) Token: 0x06019A33 RID: 105011 RVA: 0x006A9A28 File Offset: 0x006A7C28
	private static Dictionary<ECombatDataType, bool> MapCombatDataType
	{
		get
		{
			return CharacterStatisticsComponent._mapCombatDataType;
		}
	}

	// Token: 0x06019A34 RID: 105012 RVA: 0x006A9A2F File Offset: 0x006A7C2F
	public static void SetCombatStarted(bool isCombatStarted, IList<ECombatDataType> combatTypeOpen, int attackerIndex, int targetIndex)
	{
		CharacterStatisticsComponent.IsCombatStarted = isCombatStarted;
		if (isCombatStarted)
		{
			CharacterStatisticsComponent.SetTypeOpen(combatTypeOpen);
			CharacterStatisticsComponent.SetCurrentAttacker(attackerIndex);
			CharacterStatisticsComponent.SetCurrentTarget(targetIndex);
		}
	}

	// Token: 0x17002379 RID: 9081
	// (get) Token: 0x06019A35 RID: 105013 RVA: 0x006A9A4C File Offset: 0x006A7C4C
	private static List<int> ArrayAttackerEntityId
	{
		get
		{
			return CharacterStatisticsComponent._arrayAttackerEntityId;
		}
	}

	// Token: 0x06019A36 RID: 105014 RVA: 0x006A9A54 File Offset: 0x006A7C54
	public static TArray<string> GetAttackerCombatEntities()
	{
		CharacterStatisticsComponent.ArrayAttackerEntityId.Clear();
		TArray<string> tarray = new TArray<string>();
		tarray.Add("无");
		CharacterStatisticsComponent.ArrayAttackerEntityId.Add(0);
		foreach (EntityHandle entityHandle in CreatureModel.Instance.GetAllEntities())
		{
			string entityName = CharacterStatisticsComponent.GetEntityName(entityHandle);
			if (!string.IsNullOrEmpty(entityName))
			{
				tarray.Add(entityName);
				CharacterStatisticsComponent.ArrayAttackerEntityId.Add(entityHandle.Id);
			}
		}
		return tarray;
	}

	// Token: 0x1700237A RID: 9082
	// (get) Token: 0x06019A37 RID: 105015 RVA: 0x006A9AEC File Offset: 0x006A7CEC
	private static List<int> ArrayTargetEntityId
	{
		get
		{
			return CharacterStatisticsComponent._arrayTargetEntityId;
		}
	}

	// Token: 0x06019A38 RID: 105016 RVA: 0x006A9AF4 File Offset: 0x006A7CF4
	public static TArray<string> GetTargetCombatEntities()
	{
		CharacterStatisticsComponent.ArrayTargetEntityId.Clear();
		TArray<string> tarray = new TArray<string>();
		tarray.Add("无");
		CharacterStatisticsComponent.ArrayTargetEntityId.Add(0);
		foreach (EntityHandle entityHandle in CreatureModel.Instance.GetAllEntities())
		{
			string entityName = CharacterStatisticsComponent.GetEntityName(entityHandle);
			if (!string.IsNullOrEmpty(entityName))
			{
				tarray.Add(entityName);
				CharacterStatisticsComponent.ArrayTargetEntityId.Add(entityHandle.Id);
			}
		}
		return tarray;
	}

	// Token: 0x06019A39 RID: 105017 RVA: 0x006A9B8C File Offset: 0x006A7D8C
	[return: Nullable(2)]
	public static string GetEntityName(EntityHandle handle)
	{
		if (handle == null)
		{
			return null;
		}
		CreatureDataComponent component = handle.Entity.GetComponent<CreatureDataComponent>();
		EEntityType entityType = component.GetEntityType();
		if (entityType == EEntityType.Player)
		{
			int id = component.Valid ? component.GetRoleId() : 0;
			int baseRoleId = RoleConfig.Instance.GetBaseRoleId(id);
			if (baseRoleId == 0)
			{
				return null;
			}
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(baseRoleId);
			if (roleConfig == null)
			{
				return null;
			}
			return RoleConfig.Instance.GetRoleName(roleConfig.Value.Name);
		}
		else
		{
			if (entityType == EEntityType.Monster)
			{
				return PublicUtil.Instance.GetConfigTextByKey(component.GetEntityTidName() ?? "");
			}
			return null;
		}
	}

	// Token: 0x06019A3A RID: 105018 RVA: 0x006A9C2C File Offset: 0x006A7E2C
	public static void SetTypeOpen(IList<ECombatDataType> combatTypeOpen)
	{
		if (!CharacterStatisticsComponent.ItemsResetInternal)
		{
			if (CharacterStatisticsComponent.MapCombatDataType.Count != combatTypeOpen.Count)
			{
				CharacterStatisticsComponent.ItemsResetInternal = true;
			}
			else
			{
				for (int i = 0; i < combatTypeOpen.Count; i++)
				{
					bool flag;
					if (!CharacterStatisticsComponent.MapCombatDataType.TryGetValue(combatTypeOpen[i], out flag) || !flag)
					{
						CharacterStatisticsComponent.ItemsResetInternal = true;
						break;
					}
				}
			}
		}
		CharacterStatisticsComponent.MapCombatDataType.Clear();
		for (int j = 0; j < combatTypeOpen.Count; j++)
		{
			CharacterStatisticsComponent.MapCombatDataType[combatTypeOpen[j]] = true;
		}
	}

	// Token: 0x06019A3B RID: 105019 RVA: 0x006A9CB8 File Offset: 0x006A7EB8
	public static void SetCurrentAttacker(int index)
	{
		int num = (index >= 0 && index < CharacterStatisticsComponent.ArrayAttackerEntityId.Count) ? CharacterStatisticsComponent.ArrayAttackerEntityId[index] : 0;
		if (CharacterStatisticsComponent.CurrentAttackerId != num)
		{
			CharacterStatisticsComponent.ItemsResetInternal = true;
		}
		CharacterStatisticsComponent.CurrentAttackerId = num;
	}

	// Token: 0x06019A3C RID: 105020 RVA: 0x006A9CFC File Offset: 0x006A7EFC
	public static void SetCurrentTarget(int index)
	{
		int num = (index >= 0 && index < CharacterStatisticsComponent.ArrayTargetEntityId.Count) ? CharacterStatisticsComponent.ArrayTargetEntityId[index] : 0;
		if (CharacterStatisticsComponent.CurrentTargetId != num)
		{
			CharacterStatisticsComponent.ItemsResetInternal = true;
		}
		CharacterStatisticsComponent.CurrentTargetId = num;
	}

	// Token: 0x1700237B RID: 9083
	// (get) Token: 0x06019A3D RID: 105021 RVA: 0x006A9D3D File Offset: 0x006A7F3D
	public static bool ItemReset
	{
		get
		{
			return CharacterStatisticsComponent.ItemsResetInternal;
		}
	}

	// Token: 0x06019A3E RID: 105022 RVA: 0x006A9D44 File Offset: 0x006A7F44
	public static void OnItemsResetFinished()
	{
		CharacterStatisticsComponent.ItemsResetInternal = false;
		CharacterStatisticsComponent.ListCombatData.Clear();
		foreach (CombatDataBase combatDataBase in CharacterStatisticsComponent.ListCombatDataAll)
		{
			if (CharacterStatisticsComponent.ListViewFilter(combatDataBase))
			{
				CharacterStatisticsComponent.ListCombatData.Add(combatDataBase);
			}
		}
	}

	// Token: 0x06019A3F RID: 105023 RVA: 0x006A9DB4 File Offset: 0x006A7FB4
	public static TArray<string> GetSubItemsListView(int startIndex, int length)
	{
		TArray<string> tarray = new TArray<string>();
		for (int i = 0; i < length; i++)
		{
			tarray.Add(CharacterStatisticsComponent.ListCombatData[startIndex + i].ToString());
		}
		return tarray;
	}

	// Token: 0x06019A40 RID: 105024 RVA: 0x006A9DEC File Offset: 0x006A7FEC
	public static int GetItemListViewCount()
	{
		return CharacterStatisticsComponent.ListCombatData.Count;
	}

	// Token: 0x1700237C RID: 9084
	// (get) Token: 0x06019A41 RID: 105025 RVA: 0x006A9DF8 File Offset: 0x006A7FF8
	private static List<CombatDataBase> ListCombatData
	{
		get
		{
			return CharacterStatisticsComponent._listCombatData;
		}
	}

	// Token: 0x1700237D RID: 9085
	// (get) Token: 0x06019A42 RID: 105026 RVA: 0x006A9DFF File Offset: 0x006A7FFF
	private static List<CombatDataBase> ListCombatDataAll
	{
		get
		{
			return CharacterStatisticsComponent._listCombatDataAll;
		}
	}

	// Token: 0x06019A43 RID: 105027 RVA: 0x006A9E08 File Offset: 0x006A8008
	private void OnCharHealCombat(int healMagnitude, Entity healer, Entity target, DamageResult parameters, RequirementPayload requirements)
	{
		if (!CharacterStatisticsComponent.IsCombatStarted)
		{
			return;
		}
		CombatDataHeal combatDataHeal = new CombatDataHeal(healer.Id, parameters.DamageData.Id, (int)parameters.Damage, requirements.SkillId.GetValueOrDefault(), target.Id);
		combatDataHeal.ToString();
		CharacterStatisticsComponent.ListCombatDataAll.Add(combatDataHeal);
		if (CharacterStatisticsComponent.ListViewFilter(combatDataHeal))
		{
			CharacterStatisticsComponent.ListCombatData.Add(combatDataHeal);
		}
	}

	// Token: 0x06019A44 RID: 105028 RVA: 0x006A9E74 File Offset: 0x006A8074
	private void OnCharDamageCombat(int damage, int elementId, FVectorDouble damagePosition, Entity attacker, Entity victim, bool bCritical, int damageTextType, bool bImmune, long damageId, long? bulletId = null, long? buffId = null, bool? isTargetKilled = null, [Nullable(2)] RequirementPayload requirements = null)
	{
		if (!CharacterStatisticsComponent.IsCombatStarted)
		{
			return;
		}
		CombatDataDamage combatDataDamage = new CombatDataDamage(attacker.Id, damageId, damage, ((requirements != null) ? requirements.SkillId : null).GetValueOrDefault(), victim.Id);
		combatDataDamage.ToString();
		CharacterStatisticsComponent.ListCombatDataAll.Add(combatDataDamage);
		if (CharacterStatisticsComponent.ListViewFilter(combatDataDamage))
		{
			CharacterStatisticsComponent.ListCombatData.Add(combatDataDamage);
		}
		if (isTargetKilled.GetValueOrDefault())
		{
			CombatDataKilled combatDataKilled = new CombatDataKilled(attacker.Id, victim.Id);
			combatDataKilled.ToString();
			CharacterStatisticsComponent.ListCombatDataAll.Add(combatDataKilled);
			if (CharacterStatisticsComponent.ListViewFilter(combatDataKilled))
			{
				CharacterStatisticsComponent.ListCombatData.Add(combatDataKilled);
			}
		}
	}

	// Token: 0x06019A45 RID: 105029 RVA: 0x006A9F28 File Offset: 0x006A8128
	private void OnBeginSkillCombat(int entityId, int skillId, bool isAutonomousProxy)
	{
		if (!CharacterStatisticsComponent.IsCombatStarted)
		{
			return;
		}
		CombatDataSkill combatDataSkill = new CombatDataSkill(base.Entity.Id, skillId, 0);
		combatDataSkill.ToString();
		CharacterStatisticsComponent.ListCombatDataAll.Add(combatDataSkill);
		if (CharacterStatisticsComponent.ListViewFilter(combatDataSkill))
		{
			CharacterStatisticsComponent.ListCombatData.Add(combatDataSkill);
		}
	}

	// Token: 0x06019A46 RID: 105030 RVA: 0x006A9F78 File Offset: 0x006A8178
	private void OnBuffAddedCombat(ActiveBuffInternal buff)
	{
		long? id = buff.Config.Id;
		if (!CharacterStatisticsComponent.IsCombatStarted || id == null || id.Value <= 0L)
		{
			return;
		}
		CombatDataBuffAdded combatDataBuffAdded = new CombatDataBuffAdded(buff.GetInstigator().Id, id.Value, buff.GetOwner().Id);
		combatDataBuffAdded.ToString();
		CharacterStatisticsComponent.ListCombatDataAll.Add(combatDataBuffAdded);
		if (CharacterStatisticsComponent.ListViewFilter(combatDataBuffAdded))
		{
			CharacterStatisticsComponent.ListCombatData.Add(combatDataBuffAdded);
		}
	}

	// Token: 0x06019A47 RID: 105031 RVA: 0x006A9FF8 File Offset: 0x006A81F8
	private void OnBuffRemovedCombat(ActiveBuffInternal buff)
	{
		long? id = buff.Config.Id;
		if (!CharacterStatisticsComponent.IsCombatStarted || id == null || id.Value <= 0L)
		{
			return;
		}
		CombatDataBuffRemoved combatDataBuffRemoved = new CombatDataBuffRemoved(buff.GetInstigator().Id, id.Value, buff.GetOwner().Id);
		combatDataBuffRemoved.ToString();
		CharacterStatisticsComponent.ListCombatDataAll.Add(combatDataBuffRemoved);
		if (CharacterStatisticsComponent.ListViewFilter(combatDataBuffRemoved))
		{
			CharacterStatisticsComponent.ListCombatData.Add(combatDataBuffRemoved);
		}
	}

	// Token: 0x06019A48 RID: 105032 RVA: 0x006AA078 File Offset: 0x006A8278
	private void OnCharReviveCombat()
	{
		if (!CharacterStatisticsComponent.IsCombatStarted)
		{
			return;
		}
		CombatDataRevive combatDataRevive = new CombatDataRevive(base.Entity.Id);
		combatDataRevive.ToString();
		CharacterStatisticsComponent.ListCombatDataAll.Add(combatDataRevive);
		if (CharacterStatisticsComponent.ListViewFilter(combatDataRevive))
		{
			CharacterStatisticsComponent.ListCombatData.Add(combatDataRevive);
		}
	}

	// Token: 0x06019A49 RID: 105033 RVA: 0x006AA0C4 File Offset: 0x006A82C4
	private static bool ListViewFilter(CombatDataBase data)
	{
		return (CharacterStatisticsComponent.CurrentAttackerId <= 0 || CharacterStatisticsComponent.CurrentAttackerId == data.AttackerId) && (CharacterStatisticsComponent.CurrentTargetId <= 0 || CharacterStatisticsComponent.CurrentTargetId == data.TargetId) && (CharacterStatisticsComponent.MapCombatDataType.ContainsKey(ECombatDataType.Damage) || !(data is CombatDataDamage)) && (CharacterStatisticsComponent.MapCombatDataType.ContainsKey(ECombatDataType.Heal) || !(data is CombatDataHeal)) && (CharacterStatisticsComponent.MapCombatDataType.ContainsKey(ECombatDataType.SkillUsed) || !(data is CombatDataSkill)) && (CharacterStatisticsComponent.MapCombatDataType.ContainsKey(ECombatDataType.State) || (!(data is CombatDataBuffRemoved) && !(data is CombatDataBuffAdded))) && (CharacterStatisticsComponent.MapCombatDataType.ContainsKey(ECombatDataType.Kill) || !(data is CombatDataKilled)) && (CharacterStatisticsComponent.MapCombatDataType.ContainsKey(ECombatDataType.Revive) || !(data is CombatDataRevive));
	}

	// Token: 0x06019A4A RID: 105034 RVA: 0x006AA194 File Offset: 0x006A8394
	public static void CreateStaticDefaultValue()
	{
		Dictionary<int, string> dictionary = new Dictionary<int, string>();
		int key = GameplayTagDefine.EGameplayTagId["功能.功能制作.白条生效"];
		dictionary[key] = "正常时间";
		int key2 = GameplayTagDefine.EGameplayTagId["功能.功能制作.狂暴生效"];
		dictionary[key2] = "狂暴时间";
		int key3 = GameplayTagDefine.EGameplayTagId["怪物.common.状态标识.瘫痪中"];
		dictionary[key3] = "瘫痪时间";
		int key4 = GameplayTagDefine.EGameplayTagId["Damage.Vulnerable"];
		dictionary[key4] = "脆弱时间";
		CharacterStatisticsComponent._monsterStageInfo = dictionary;
		Dictionary<int, string> dictionary2 = new Dictionary<int, string>();
		key4 = GameplayTagDefine.EGameplayTagId["功能.功能制作.被击硬直时间"];
		dictionary2[key4] = "受击硬直";
		CharacterStatisticsComponent._roleStageInfo = dictionary2;
		CharacterStatisticsComponent._allStatisticsEnableEntityId = new List<int>();
		CharacterStatisticsComponent._damageStaticsBySkillTypeMap = new Dictionary<int, Dictionary<EDamageType, DamageStatisticsData>>();
		CharacterStatisticsComponent._damageStaticsByAttackTypeMap = new Dictionary<int, Dictionary<global::EAttackType, DamageStatisticsData>>();
		CharacterStatisticsComponent._healStaticsBySkillTypeMap = new Dictionary<int, Dictionary<EDamageType, DamageStatisticsData>>();
		CharacterStatisticsComponent._healStaticsByAttackTypeMap = new Dictionary<int, Dictionary<global::EAttackType, DamageStatisticsData>>();
		CharacterStatisticsComponent.TargetMaxCountSkillType = 0;
		CharacterStatisticsComponent.TargetMaxCountAttackType = 0;
		CharacterStatisticsComponent.HalfLengthRecordSquared = 25000000.0;
		CharacterStatisticsComponent._characterOperationRecordMap = new Dictionary<int, CharacterOperationRecord>();
		CharacterStatisticsComponent.OpenOperationRecordInternal = false;
		CharacterStatisticsComponent._inAreaEntityId = new List<int>();
		CharacterStatisticsComponent._mapCombatDataType = new Dictionary<ECombatDataType, bool>();
		CharacterStatisticsComponent._arrayAttackerEntityId = new List<int>();
		CharacterStatisticsComponent._arrayTargetEntityId = new List<int>();
		CharacterStatisticsComponent.CurrentAttackerId = 0;
		CharacterStatisticsComponent.CurrentTargetId = 0;
		CharacterStatisticsComponent.ItemsResetInternal = false;
		CharacterStatisticsComponent._listCombatData = new List<CombatDataBase>();
		CharacterStatisticsComponent._listCombatDataAll = new List<CombatDataBase>();
	}

	// Token: 0x06019A4B RID: 105035 RVA: 0x006AA2EC File Offset: 0x006A84EC
	public static void ResetStaticDefaultValue()
	{
		CharacterStatisticsComponent._monsterStageInfo = null;
		CharacterStatisticsComponent._roleStageInfo = null;
		CharacterStatisticsComponent._allStatisticsEnableEntityId = null;
		CharacterStatisticsComponent._damageStaticsBySkillTypeMap = null;
		CharacterStatisticsComponent._damageStaticsByAttackTypeMap = null;
		CharacterStatisticsComponent._healStaticsBySkillTypeMap = null;
		CharacterStatisticsComponent._healStaticsByAttackTypeMap = null;
		CharacterStatisticsComponent.TargetMaxCountSkillType = 0;
		CharacterStatisticsComponent.TargetMaxCountAttackType = 0;
		CharacterStatisticsComponent.HalfLengthRecordSquared = 25000000.0;
		CharacterStatisticsComponent._characterOperationRecordMap = null;
		CharacterStatisticsComponent.OpenOperationRecordInternal = false;
		CharacterStatisticsComponent._inAreaEntityId = null;
		CharacterStatisticsComponent.IsCombatStarted = false;
		CharacterStatisticsComponent._mapCombatDataType = null;
		CharacterStatisticsComponent._arrayAttackerEntityId = null;
		CharacterStatisticsComponent._arrayTargetEntityId = null;
		CharacterStatisticsComponent.CurrentAttackerId = 0;
		CharacterStatisticsComponent.CurrentTargetId = 0;
		CharacterStatisticsComponent.ItemsResetInternal = false;
		CharacterStatisticsComponent._listCombatData = null;
		CharacterStatisticsComponent._listCombatDataAll = null;
	}

	// Token: 0x06019A4C RID: 105036 RVA: 0x006AA388 File Offset: 0x006A8588
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterStatisticsComponent characterStatisticsComponent = (CharacterStatisticsComponent)componentTemplate;
		if (base.CanResetComponentProperty("StatisticsEnable"))
		{
			this.StatisticsEnable = characterStatisticsComponent.StatisticsEnable;
		}
		return (!base.CanResetComponentProperty("OperationBeginTimeMap") || characterStatisticsComponent.OperationBeginTimeMap == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<long, double?>>(this.OperationBeginTimeMap), "OperationBeginTimeMap")) && (!base.CanResetComponentProperty("TagOperationBeginTimeMap") || characterStatisticsComponent.TagOperationBeginTimeMap == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, double>>(this.TagOperationBeginTimeMap), "TagOperationBeginTimeMap")) && (!base.CanResetComponentProperty("MoveOperationBeginTimeMap") || characterStatisticsComponent.MoveOperationBeginTimeMap == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<global::ECharMoveState, double?>>(this.MoveOperationBeginTimeMap), "MoveOperationBeginTimeMap")) && (!base.CanResetComponentProperty("ListenOperationTasks") || characterStatisticsComponent.ListenOperationTasks == null || base.CheckClearObject(EntityComponentSystem.ClearObject<List<ITagTask>>(this.ListenOperationTasks), "ListenOperationTasks"));
	}

	// Token: 0x0400BFF4 RID: 49140
	[StaticVariableRuleIgnore]
	internal static readonly string[] skillTypeToString = new string[]
	{
		"常态攻击",
		"共鸣技能",
		"共鸣解放",
		"固有技能",
		"连携技能",
		"异能力",
		"声骸技能"
	};

	// Token: 0x0400BFF5 RID: 49141
	[StaticVariableRuleIgnore]
	private static readonly string[] attackTypeToString = new string[]
	{
		"普攻伤害",
		"蓄力攻击伤害",
		"大招伤害",
		"QTE伤害",
		"普通技能伤害",
		"战斗幻象技能伤害",
		"探索幻象技能伤害"
	};

	// Token: 0x0400BFF6 RID: 49142
	private bool StatisticsEnable;

	// Token: 0x0400BFF7 RID: 49143
	[Nullable(2)]
	private static List<int> _allStatisticsEnableEntityId;

	// Token: 0x0400BFF8 RID: 49144
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<int, Dictionary<EDamageType, DamageStatisticsData>> _damageStaticsBySkillTypeMap;

	// Token: 0x0400BFF9 RID: 49145
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<int, Dictionary<global::EAttackType, DamageStatisticsData>> _damageStaticsByAttackTypeMap;

	// Token: 0x0400BFFA RID: 49146
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<int, Dictionary<EDamageType, DamageStatisticsData>> _healStaticsBySkillTypeMap;

	// Token: 0x0400BFFB RID: 49147
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<int, Dictionary<global::EAttackType, DamageStatisticsData>> _healStaticsByAttackTypeMap;

	// Token: 0x0400BFFC RID: 49148
	private static readonly string TargetTitleFormat = ",目标{0}类型,目标{1}名称,目标{2}配置ID,目标{3}单位Id,目标{4}伤害";

	// Token: 0x0400BFFD RID: 49149
	private static int TargetMaxCountSkillType = 0;

	// Token: 0x0400BFFE RID: 49150
	private static int TargetMaxCountAttackType = 0;

	// Token: 0x0400BFFF RID: 49151
	public static double HalfLengthRecordSquared = 0.0;

	// Token: 0x0400C000 RID: 49152
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<int, CharacterOperationRecord> _characterOperationRecordMap;

	// Token: 0x0400C001 RID: 49153
	private readonly Dictionary<long, double?> OperationBeginTimeMap = new Dictionary<long, double?>();

	// Token: 0x0400C002 RID: 49154
	private readonly Dictionary<int, double> TagOperationBeginTimeMap = new Dictionary<int, double>();

	// Token: 0x0400C003 RID: 49155
	private readonly Dictionary<global::ECharMoveState, double?> MoveOperationBeginTimeMap = new Dictionary<global::ECharMoveState, double?>();

	// Token: 0x0400C004 RID: 49156
	private static bool OpenOperationRecordInternal = false;

	// Token: 0x0400C005 RID: 49157
	private readonly List<ITagTask> ListenOperationTasks = new List<ITagTask>();

	// Token: 0x0400C006 RID: 49158
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<global::ECharMoveState, string> MoveStateToString;

	// Token: 0x0400C007 RID: 49159
	[StaticVariableRuleIgnore]
	private static readonly string[] SkillGenreName;

	// Token: 0x0400C008 RID: 49160
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<int, string> _monsterStageInfo;

	// Token: 0x0400C009 RID: 49161
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<int, string> _roleStageInfo;

	// Token: 0x0400C00A RID: 49162
	[Nullable(2)]
	private static List<int> _inAreaEntityId;

	// Token: 0x0400C00B RID: 49163
	private static readonly string OperationRecordTitle;

	// Token: 0x0400C00C RID: 49164
	private static bool IsCombatStarted;

	// Token: 0x0400C00D RID: 49165
	[Nullable(2)]
	private static Dictionary<ECombatDataType, bool> _mapCombatDataType;

	// Token: 0x0400C00E RID: 49166
	[Nullable(2)]
	private static List<int> _arrayAttackerEntityId;

	// Token: 0x0400C00F RID: 49167
	[Nullable(2)]
	private static List<int> _arrayTargetEntityId;

	// Token: 0x0400C010 RID: 49168
	private static int CurrentAttackerId;

	// Token: 0x0400C011 RID: 49169
	private static int CurrentTargetId;

	// Token: 0x0400C012 RID: 49170
	private static bool ItemsResetInternal;

	// Token: 0x0400C013 RID: 49171
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<CombatDataBase> _listCombatData;

	// Token: 0x0400C014 RID: 49172
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<CombatDataBase> _listCombatDataAll;
}
