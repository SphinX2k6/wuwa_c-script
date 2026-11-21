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

// Token: 0x02002434 RID: 9268
[NullableContext(1)]
[Nullable(0)]
public class CharacterStatisticsComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x06017303 RID: 94979 RVA: 0x006CE0DC File Offset: 0x006CC2DC
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

	// Token: 0x06017304 RID: 94980 RVA: 0x006CE28C File Offset: 0x006CC48C
	protected override bool OnInit()
	{
		EventSystem.Instance.AddWithTarget<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(base.Entity, EEventName.CharBeDamage, new Action<Entity, Entity, RequirementPayload, DamageResult, FVectorDouble>(this.OnCharDamageAll));
		EventSystem.Instance.AddWithTarget<int, int, bool>(base.Entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnBeginSkillCombat));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharOnRevive, new Action(this.OnCharReviveAll));
		return true;
	}

	// Token: 0x06017305 RID: 94981 RVA: 0x006CE2FA File Offset: 0x006CC4FA
	protected override bool OnStart()
	{
		this.InitStageBeginTime();
		return true;
	}

	// Token: 0x06017306 RID: 94982 RVA: 0x006CE303 File Offset: 0x006CC503
	protected override void OnActivate()
	{
		if (CharacterStatisticsComponent.OpenOperationRecord)
		{
			this.StatisticsEnable = CharacterStatisticsComponent.IsInRecordArea(base.Entity);
		}
		this.OnActivateOperationRecord();
	}

	// Token: 0x06017307 RID: 94983 RVA: 0x006CE324 File Offset: 0x006CC524
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

	// Token: 0x06017308 RID: 94984 RVA: 0x006CE3A0 File Offset: 0x006CC5A0
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

	// Token: 0x06017309 RID: 94985 RVA: 0x006CE485 File Offset: 0x006CC685
	public void OnBuffAdded(ActiveBuffInternal buff)
	{
		this.OnBuffAddedCombat(buff);
	}

	// Token: 0x0601730A RID: 94986 RVA: 0x006CE48E File Offset: 0x006CC68E
	public void OnBuffRemoved(ActiveBuffInternal buff)
	{
		this.OnBuffRemovedCombat(buff);
	}

	// Token: 0x0601730B RID: 94987 RVA: 0x006CE497 File Offset: 0x006CC697
	private void OnCharReviveAll()
	{
		this.OnCharReviveCombat();
	}

	// Token: 0x0601730C RID: 94988 RVA: 0x006CE49F File Offset: 0x006CC69F
	public bool GetStatisticsEnable()
	{
		return this.StatisticsEnable;
	}

	// Token: 0x17002423 RID: 9251
	// (get) Token: 0x0601730D RID: 94989 RVA: 0x006CE4A7 File Offset: 0x006CC6A7
	private static List<int> AllStatisticsEnableEntityId
	{
		get
		{
			return CharacterStatisticsComponent._allStatisticsEnableEntityId;
		}
	}

	// Token: 0x0601730E RID: 94990 RVA: 0x006CE4B0 File Offset: 0x006CC6B0
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

	// Token: 0x17002424 RID: 9252
	// (get) Token: 0x0601730F RID: 94991 RVA: 0x006CE5B4 File Offset: 0x006CC7B4
	private static Dictionary<int, Dictionary<EDamageType, DamageStatisticsData>> DamageStaticsBySkillTypeMap
	{
		get
		{
			return CharacterStatisticsComponent._damageStaticsBySkillTypeMap;
		}
	}

	// Token: 0x17002425 RID: 9253
	// (get) Token: 0x06017310 RID: 94992 RVA: 0x006CE5BB File Offset: 0x006CC7BB
	private static Dictionary<int, Dictionary<EAttackType, DamageStatisticsData>> DamageStaticsByAttackTypeMap
	{
		get
		{
			return CharacterStatisticsComponent._damageStaticsByAttackTypeMap;
		}
	}

	// Token: 0x17002426 RID: 9254
	// (get) Token: 0x06017311 RID: 94993 RVA: 0x006CE5C2 File Offset: 0x006CC7C2
	private static Dictionary<int, Dictionary<EDamageType, DamageStatisticsData>> HealStaticsBySkillTypeMap
	{
		get
		{
			return CharacterStatisticsComponent._healStaticsBySkillTypeMap;
		}
	}

	// Token: 0x17002427 RID: 9255
	// (get) Token: 0x06017312 RID: 94994 RVA: 0x006CE5C9 File Offset: 0x006CC7C9
	private static Dictionary<int, Dictionary<EAttackType, DamageStatisticsData>> HealStaticsByAttackTypeMap
	{
		get
		{
			return CharacterStatisticsComponent._healStaticsByAttackTypeMap;
		}
	}

	// Token: 0x06017313 RID: 94995 RVA: 0x006CE5D0 File Offset: 0x006CC7D0
	public static void CleanupRecordData()
	{
		CharacterStatisticsComponent.DamageStaticsByAttackTypeMap.Clear();
		CharacterStatisticsComponent.HealStaticsByAttackTypeMap.Clear();
		CharacterStatisticsComponent.DamageStaticsBySkillTypeMap.Clear();
		CharacterStatisticsComponent.HealStaticsBySkillTypeMap.Clear();
	}

	// Token: 0x06017314 RID: 94996 RVA: 0x006CE5FC File Offset: 0x006CC7FC
	private void OnCharHealStatistic(int healMagnitude, Entity healer, Entity target, DamageResult parameters)
	{
		int damage = (int)parameters.Damage;
		long id = parameters.DamageData.Id;
		CharacterStatisticsComponent.ProcessRecordBySkillType(damage, healer, target, id, true, null, null);
		CharacterStatisticsComponent.ProcessRecordByAttackType(damage, healer, target, id, true);
	}

	// Token: 0x06017315 RID: 94997 RVA: 0x006CE643 File Offset: 0x006CC843
	private void OnCharDamageStatistic(int damage, int elementId, FVectorDouble damagePosition, Entity attacker, Entity victim, bool bCritical, int damageTextType, bool bImmune, long damageId, long? bulletId = null, long? buffId = null)
	{
		CharacterStatisticsComponent.ProcessRecordBySkillType(damage, attacker, victim, damageId, false, bulletId, buffId);
		CharacterStatisticsComponent.ProcessRecordByAttackType(damage, attacker, victim, damageId, false);
	}

	// Token: 0x06017316 RID: 94998 RVA: 0x006CE664 File Offset: 0x006CC864
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

	// Token: 0x06017317 RID: 94999 RVA: 0x006CE88C File Offset: 0x006CCA8C
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
		Dictionary<int, Dictionary<EAttackType, DamageStatisticsData>> dictionary = isHeal ? CharacterStatisticsComponent.HealStaticsByAttackTypeMap : CharacterStatisticsComponent.DamageStaticsByAttackTypeMap;
		Dictionary<EAttackType, DamageStatisticsData> dictionary2;
		if (!dictionary.TryGetValue(baseRoleId, out dictionary2))
		{
			dictionary2 = new Dictionary<EAttackType, DamageStatisticsData>();
			dictionary[baseRoleId] = dictionary2;
		}
		EAttackType type = (EAttackType)damageConfigById.Value.Type;
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

	// Token: 0x06017318 RID: 95000 RVA: 0x006CE9D5 File Offset: 0x006CCBD5
	private static bool TryGetSkillContainsDamage(Aki.Config.Skill skill, long damageId)
	{
		return CharacterStatisticsComponent.SkillContainsDamageInternal(skill, damageId);
	}

	// Token: 0x06017319 RID: 95001 RVA: 0x006CE9E0 File Offset: 0x006CCBE0
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

	// Token: 0x0601731A RID: 95002 RVA: 0x006CEA38 File Offset: 0x006CCC38
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

	// Token: 0x0601731B RID: 95003 RVA: 0x006CEBC4 File Offset: 0x006CCDC4
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
		foreach (Dictionary<EAttackType, DamageStatisticsData> dictionary in CharacterStatisticsComponent.DamageStaticsByAttackTypeMap.Values)
		{
			foreach (DamageStatisticsData damageStatisticsData in dictionary.Values)
			{
				stringBuilder.Append(damageStatisticsData.ToString());
			}
		}
		foreach (Dictionary<EAttackType, DamageStatisticsData> dictionary2 in CharacterStatisticsComponent.HealStaticsByAttackTypeMap.Values)
		{
			foreach (DamageStatisticsData damageStatisticsData2 in dictionary2.Values)
			{
				stringBuilder.Append(damageStatisticsData2.ToString());
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x17002428 RID: 9256
	// (get) Token: 0x0601731C RID: 95004 RVA: 0x006CED50 File Offset: 0x006CCF50
	private static Dictionary<int, CharacterOperationRecord> CharacterOperationRecordMap
	{
		get
		{
			return CharacterStatisticsComponent._characterOperationRecordMap;
		}
	}

	// Token: 0x17002429 RID: 9257
	// (get) Token: 0x0601731D RID: 95005 RVA: 0x006CED57 File Offset: 0x006CCF57
	public static bool OpenOperationRecord
	{
		get
		{
			return CharacterStatisticsComponent.OpenOperationRecordInternal;
		}
	}

	// Token: 0x0601731E RID: 95006 RVA: 0x006CED5E File Offset: 0x006CCF5E
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

	// Token: 0x0601731F RID: 95007 RVA: 0x006CED94 File Offset: 0x006CCF94
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

	// Token: 0x06017320 RID: 95008 RVA: 0x006CF018 File Offset: 0x006CD218
	private void AddListenTagTask(BaseTagComponent tagComp, int tagId)
	{
		ITagTask tagTask = tagComp.ListenForTagAddOrRemove(new int?(tagId), new BaseTagComponent.TTagSwitchedCallback(this.OnTagChanged), null);
		if (tagTask != null)
		{
			this.ListenOperationTasks.Add(tagTask);
		}
	}

	// Token: 0x06017321 RID: 95009 RVA: 0x006CF050 File Offset: 0x006CD250
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

	// Token: 0x06017322 RID: 95010 RVA: 0x006CF124 File Offset: 0x006CD324
	private void OnMoveStateChange(global::ECharMoveState oldMoveState, global::ECharMoveState newMoveState)
	{
		if (!CharacterStatisticsComponent.OpenOperationRecordInternal || !base.Entity.GetComponent<CreatureDataComponent>().IsRole())
		{
			return;
		}
		this.OnMoveStateEnd(oldMoveState);
		this.OnMoveStateStart(newMoveState);
	}

	// Token: 0x06017323 RID: 95011 RVA: 0x006CF150 File Offset: 0x006CD350
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

	// Token: 0x06017324 RID: 95012 RVA: 0x006CF228 File Offset: 0x006CD428
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

	// Token: 0x06017325 RID: 95013 RVA: 0x006CF3A8 File Offset: 0x006CD5A8
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

	// Token: 0x06017326 RID: 95014 RVA: 0x006CF48C File Offset: 0x006CD68C
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

	// Token: 0x1700242A RID: 9258
	// (get) Token: 0x06017327 RID: 95015 RVA: 0x006CF66B File Offset: 0x006CD86B
	private static Dictionary<int, string> MonsterStageInfo
	{
		get
		{
			return CharacterStatisticsComponent._monsterStageInfo;
		}
	}

	// Token: 0x1700242B RID: 9259
	// (get) Token: 0x06017328 RID: 95016 RVA: 0x006CF672 File Offset: 0x006CD872
	private static Dictionary<int, string> RoleStageInfo
	{
		get
		{
			return CharacterStatisticsComponent._roleStageInfo;
		}
	}

	// Token: 0x06017329 RID: 95017 RVA: 0x006CF679 File Offset: 0x006CD879
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

	// Token: 0x0601732A RID: 95018 RVA: 0x006CF690 File Offset: 0x006CD890
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

	// Token: 0x0601732B RID: 95019 RVA: 0x006CF720 File Offset: 0x006CD920
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

	// Token: 0x1700242C RID: 9260
	// (get) Token: 0x0601732C RID: 95020 RVA: 0x006CF91B File Offset: 0x006CDB1B
	private static List<int> InAreaEntityId
	{
		get
		{
			return CharacterStatisticsComponent._inAreaEntityId;
		}
	}

	// Token: 0x0601732D RID: 95021 RVA: 0x006CF924 File Offset: 0x006CDB24
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

	// Token: 0x0601732E RID: 95022 RVA: 0x006CFA44 File Offset: 0x006CDC44
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

	// Token: 0x0601732F RID: 95023 RVA: 0x006CFAB0 File Offset: 0x006CDCB0
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

	// Token: 0x06017330 RID: 95024 RVA: 0x006CFB40 File Offset: 0x006CDD40
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

	// Token: 0x06017331 RID: 95025 RVA: 0x006CFBC0 File Offset: 0x006CDDC0
	public static void CleanupOperationRecord()
	{
		CharacterStatisticsComponent.CharacterOperationRecordMap.Clear();
	}

	// Token: 0x1700242D RID: 9261
	// (get) Token: 0x06017332 RID: 95026 RVA: 0x006CFBCC File Offset: 0x006CDDCC
	private static Dictionary<ECombatDataType, bool> MapCombatDataType
	{
		get
		{
			return CharacterStatisticsComponent._mapCombatDataType;
		}
	}

	// Token: 0x06017333 RID: 95027 RVA: 0x006CFBD3 File Offset: 0x006CDDD3
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

	// Token: 0x1700242E RID: 9262
	// (get) Token: 0x06017334 RID: 95028 RVA: 0x006CFBF0 File Offset: 0x006CDDF0
	private static List<int> ArrayAttackerEntityId
	{
		get
		{
			return CharacterStatisticsComponent._arrayAttackerEntityId;
		}
	}

	// Token: 0x06017335 RID: 95029 RVA: 0x006CFBF8 File Offset: 0x006CDDF8
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

	// Token: 0x1700242F RID: 9263
	// (get) Token: 0x06017336 RID: 95030 RVA: 0x006CFC90 File Offset: 0x006CDE90
	private static List<int> ArrayTargetEntityId
	{
		get
		{
			return CharacterStatisticsComponent._arrayTargetEntityId;
		}
	}

	// Token: 0x06017337 RID: 95031 RVA: 0x006CFC98 File Offset: 0x006CDE98
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

	// Token: 0x06017338 RID: 95032 RVA: 0x006CFD30 File Offset: 0x006CDF30
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

	// Token: 0x06017339 RID: 95033 RVA: 0x006CFDD0 File Offset: 0x006CDFD0
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

	// Token: 0x0601733A RID: 95034 RVA: 0x006CFE5C File Offset: 0x006CE05C
	public static void SetCurrentAttacker(int index)
	{
		int num = (index >= 0 && index < CharacterStatisticsComponent.ArrayAttackerEntityId.Count) ? CharacterStatisticsComponent.ArrayAttackerEntityId[index] : 0;
		if (CharacterStatisticsComponent.CurrentAttackerId != num)
		{
			CharacterStatisticsComponent.ItemsResetInternal = true;
		}
		CharacterStatisticsComponent.CurrentAttackerId = num;
	}

	// Token: 0x0601733B RID: 95035 RVA: 0x006CFEA0 File Offset: 0x006CE0A0
	public static void SetCurrentTarget(int index)
	{
		int num = (index >= 0 && index < CharacterStatisticsComponent.ArrayTargetEntityId.Count) ? CharacterStatisticsComponent.ArrayTargetEntityId[index] : 0;
		if (CharacterStatisticsComponent.CurrentTargetId != num)
		{
			CharacterStatisticsComponent.ItemsResetInternal = true;
		}
		CharacterStatisticsComponent.CurrentTargetId = num;
	}

	// Token: 0x17002430 RID: 9264
	// (get) Token: 0x0601733C RID: 95036 RVA: 0x006CFEE1 File Offset: 0x006CE0E1
	public static bool ItemReset
	{
		get
		{
			return CharacterStatisticsComponent.ItemsResetInternal;
		}
	}

	// Token: 0x0601733D RID: 95037 RVA: 0x006CFEE8 File Offset: 0x006CE0E8
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

	// Token: 0x0601733E RID: 95038 RVA: 0x006CFF58 File Offset: 0x006CE158
	public static TArray<string> GetSubItemsListView(int startIndex, int length)
	{
		TArray<string> tarray = new TArray<string>();
		for (int i = 0; i < length; i++)
		{
			tarray.Add(CharacterStatisticsComponent.ListCombatData[startIndex + i].ToString());
		}
		return tarray;
	}

	// Token: 0x0601733F RID: 95039 RVA: 0x006CFF90 File Offset: 0x006CE190
	public static int GetItemListViewCount()
	{
		return CharacterStatisticsComponent.ListCombatData.Count;
	}

	// Token: 0x17002431 RID: 9265
	// (get) Token: 0x06017340 RID: 95040 RVA: 0x006CFF9C File Offset: 0x006CE19C
	private static List<CombatDataBase> ListCombatData
	{
		get
		{
			return CharacterStatisticsComponent._listCombatData;
		}
	}

	// Token: 0x17002432 RID: 9266
	// (get) Token: 0x06017341 RID: 95041 RVA: 0x006CFFA3 File Offset: 0x006CE1A3
	private static List<CombatDataBase> ListCombatDataAll
	{
		get
		{
			return CharacterStatisticsComponent._listCombatDataAll;
		}
	}

	// Token: 0x06017342 RID: 95042 RVA: 0x006CFFAC File Offset: 0x006CE1AC
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

	// Token: 0x06017343 RID: 95043 RVA: 0x006D0018 File Offset: 0x006CE218
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

	// Token: 0x06017344 RID: 95044 RVA: 0x006D00CC File Offset: 0x006CE2CC
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

	// Token: 0x06017345 RID: 95045 RVA: 0x006D011C File Offset: 0x006CE31C
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

	// Token: 0x06017346 RID: 95046 RVA: 0x006D019C File Offset: 0x006CE39C
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

	// Token: 0x06017347 RID: 95047 RVA: 0x006D021C File Offset: 0x006CE41C
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

	// Token: 0x06017348 RID: 95048 RVA: 0x006D0268 File Offset: 0x006CE468
	private static bool ListViewFilter(CombatDataBase data)
	{
		return (CharacterStatisticsComponent.CurrentAttackerId <= 0 || CharacterStatisticsComponent.CurrentAttackerId == data.AttackerId) && (CharacterStatisticsComponent.CurrentTargetId <= 0 || CharacterStatisticsComponent.CurrentTargetId == data.TargetId) && (CharacterStatisticsComponent.MapCombatDataType.ContainsKey(ECombatDataType.Damage) || !(data is CombatDataDamage)) && (CharacterStatisticsComponent.MapCombatDataType.ContainsKey(ECombatDataType.Heal) || !(data is CombatDataHeal)) && (CharacterStatisticsComponent.MapCombatDataType.ContainsKey(ECombatDataType.SkillUsed) || !(data is CombatDataSkill)) && (CharacterStatisticsComponent.MapCombatDataType.ContainsKey(ECombatDataType.State) || (!(data is CombatDataBuffRemoved) && !(data is CombatDataBuffAdded))) && (CharacterStatisticsComponent.MapCombatDataType.ContainsKey(ECombatDataType.Kill) || !(data is CombatDataKilled)) && (CharacterStatisticsComponent.MapCombatDataType.ContainsKey(ECombatDataType.Revive) || !(data is CombatDataRevive));
	}

	// Token: 0x06017349 RID: 95049 RVA: 0x006D0338 File Offset: 0x006CE538
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
		CharacterStatisticsComponent._damageStaticsByAttackTypeMap = new Dictionary<int, Dictionary<EAttackType, DamageStatisticsData>>();
		CharacterStatisticsComponent._healStaticsBySkillTypeMap = new Dictionary<int, Dictionary<EDamageType, DamageStatisticsData>>();
		CharacterStatisticsComponent._healStaticsByAttackTypeMap = new Dictionary<int, Dictionary<EAttackType, DamageStatisticsData>>();
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

	// Token: 0x0601734A RID: 95050 RVA: 0x006D0490 File Offset: 0x006CE690
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

	// Token: 0x0601734B RID: 95051 RVA: 0x006D052C File Offset: 0x006CE72C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterStatisticsComponent characterStatisticsComponent = (CharacterStatisticsComponent)componentTemplate;
		this.StatisticsEnable = characterStatisticsComponent.StatisticsEnable;
		return (characterStatisticsComponent.OperationBeginTimeMap == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.OperationBeginTimeMap), "OperationBeginTimeMap")) && (characterStatisticsComponent.TagOperationBeginTimeMap == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagOperationBeginTimeMap), "TagOperationBeginTimeMap")) && (characterStatisticsComponent.MoveOperationBeginTimeMap == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveOperationBeginTimeMap), "MoveOperationBeginTimeMap")) && (characterStatisticsComponent.ListenOperationTasks == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.ListenOperationTasks), "ListenOperationTasks"));
	}

	// Token: 0x17002433 RID: 9267
	// (get) Token: 0x0601734C RID: 95052 RVA: 0x006D05E0 File Offset: 0x006CE7E0
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002434 RID: 9268
	// (get) Token: 0x0601734D RID: 95053 RVA: 0x006D05E3 File Offset: 0x006CE7E3
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002435 RID: 9269
	// (get) Token: 0x0601734E RID: 95054 RVA: 0x006D05E6 File Offset: 0x006CE7E6
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002436 RID: 9270
	// (get) Token: 0x0601734F RID: 95055 RVA: 0x006D05E9 File Offset: 0x006CE7E9
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400C38F RID: 50063
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

	// Token: 0x0400C390 RID: 50064
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

	// Token: 0x0400C391 RID: 50065
	private bool StatisticsEnable;

	// Token: 0x0400C392 RID: 50066
	[Nullable(2)]
	private static List<int> _allStatisticsEnableEntityId;

	// Token: 0x0400C393 RID: 50067
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<int, Dictionary<EDamageType, DamageStatisticsData>> _damageStaticsBySkillTypeMap;

	// Token: 0x0400C394 RID: 50068
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<int, Dictionary<EAttackType, DamageStatisticsData>> _damageStaticsByAttackTypeMap;

	// Token: 0x0400C395 RID: 50069
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<int, Dictionary<EDamageType, DamageStatisticsData>> _healStaticsBySkillTypeMap;

	// Token: 0x0400C396 RID: 50070
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<int, Dictionary<EAttackType, DamageStatisticsData>> _healStaticsByAttackTypeMap;

	// Token: 0x0400C397 RID: 50071
	private static readonly string TargetTitleFormat = ",目标{0}类型,目标{1}名称,目标{2}配置ID,目标{3}单位Id,目标{4}伤害";

	// Token: 0x0400C398 RID: 50072
	private static int TargetMaxCountSkillType = 0;

	// Token: 0x0400C399 RID: 50073
	private static int TargetMaxCountAttackType = 0;

	// Token: 0x0400C39A RID: 50074
	public static double HalfLengthRecordSquared = 0.0;

	// Token: 0x0400C39B RID: 50075
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<int, CharacterOperationRecord> _characterOperationRecordMap;

	// Token: 0x0400C39C RID: 50076
	private readonly Dictionary<long, double?> OperationBeginTimeMap = new Dictionary<long, double?>();

	// Token: 0x0400C39D RID: 50077
	private readonly Dictionary<int, double> TagOperationBeginTimeMap = new Dictionary<int, double>();

	// Token: 0x0400C39E RID: 50078
	private readonly Dictionary<global::ECharMoveState, double?> MoveOperationBeginTimeMap = new Dictionary<global::ECharMoveState, double?>();

	// Token: 0x0400C39F RID: 50079
	private static bool OpenOperationRecordInternal = false;

	// Token: 0x0400C3A0 RID: 50080
	private readonly List<ITagTask> ListenOperationTasks = new List<ITagTask>();

	// Token: 0x0400C3A1 RID: 50081
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<global::ECharMoveState, string> MoveStateToString;

	// Token: 0x0400C3A2 RID: 50082
	[StaticVariableRuleIgnore]
	private static readonly string[] SkillGenreName;

	// Token: 0x0400C3A3 RID: 50083
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<int, string> _monsterStageInfo;

	// Token: 0x0400C3A4 RID: 50084
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<int, string> _roleStageInfo;

	// Token: 0x0400C3A5 RID: 50085
	[Nullable(2)]
	private static List<int> _inAreaEntityId;

	// Token: 0x0400C3A6 RID: 50086
	private static readonly string OperationRecordTitle;

	// Token: 0x0400C3A7 RID: 50087
	private static bool IsCombatStarted;

	// Token: 0x0400C3A8 RID: 50088
	[Nullable(2)]
	private static Dictionary<ECombatDataType, bool> _mapCombatDataType;

	// Token: 0x0400C3A9 RID: 50089
	[Nullable(2)]
	private static List<int> _arrayAttackerEntityId;

	// Token: 0x0400C3AA RID: 50090
	[Nullable(2)]
	private static List<int> _arrayTargetEntityId;

	// Token: 0x0400C3AB RID: 50091
	private static int CurrentAttackerId;

	// Token: 0x0400C3AC RID: 50092
	private static int CurrentTargetId;

	// Token: 0x0400C3AD RID: 50093
	private static bool ItemsResetInternal;

	// Token: 0x0400C3AE RID: 50094
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<CombatDataBase> _listCombatData;

	// Token: 0x0400C3AF RID: 50095
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<CombatDataBase> _listCombatDataAll;
}
