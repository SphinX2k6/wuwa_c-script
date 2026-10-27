using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Module.CombatMessage;
using CSharpScript.Utils;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x02002ED3 RID: 11987
[NullableContext(1)]
[Nullable(0)]
public class CharacterPassiveSkillComponent : EntityComponent
{
	// Token: 0x060199B8 RID: 104888 RVA: 0x006A4F9C File Offset: 0x006A319C
	protected override bool OnInit()
	{
		this.triggerComp = base.Entity.CheckGetComponent<CharacterTriggerComponent>();
		this.buffComp = base.Entity.CheckGetComponent<CharacterBuffComponent>();
		this.cdComp = base.Entity.GetComponent<BaseSkillCdComponent>();
		this.actorComp = base.Entity.GetComponent<CharacterActorComponent>();
		this.Context = new ContextParam
		{
			SkillId = 0L,
			Owner = base.Entity,
			BuffComp = this.buffComp,
			PassiveSkillComp = this
		};
		return true;
	}

	// Token: 0x060199B9 RID: 104889 RVA: 0x006A5020 File Offset: 0x006A3220
	protected override bool OnStart()
	{
		return true;
	}

	// Token: 0x060199BA RID: 104890 RVA: 0x006A5024 File Offset: 0x006A3224
	protected override void OnActivate()
	{
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		Dictionary<string, EntityComponentPb> dictionary = (component != null) ? component.ComponentDataMap : null;
		if (dictionary == null)
		{
			return;
		}
		EntityComponentPb entityComponentPb;
		if (!dictionary.TryGetValue("PassiveSkillComponentPb", out entityComponentPb) && !dictionary.TryGetValue("Proto_PassiveSkillComponentPb", out entityComponentPb))
		{
			return;
		}
		PassiveSkillComponentPb passiveSkillComponentPb = entityComponentPb.PassiveSkillComponentPb;
		if (passiveSkillComponentPb == null)
		{
			return;
		}
		foreach (PassiveSkillItemPb passiveSkillItemPb in passiveSkillComponentPb.PassiveSkillItemPbList)
		{
			CombatCommon combatCommon = passiveSkillItemPb.CombatCommon;
			long combatMessageId = (combatCommon != null) ? combatCommon.MessageId : 0L;
			this.LearnPassiveSkill(passiveSkillItemPb.SkillId, new AddPassiveSkillParam
			{
				CombatMessageId = combatMessageId
			});
		}
	}

	// Token: 0x060199BB RID: 104891 RVA: 0x006A50E4 File Offset: 0x006A32E4
	protected override bool OnClear()
	{
		bool result;
		using (PoolArray<long> poolArray = this.SkillMap.Keys.ToPoolArray<long>())
		{
			for (int i = 0; i < poolArray.Count; i++)
			{
				this.ForgetPassiveSkill(poolArray[i], false);
			}
			result = true;
		}
		return result;
	}

	// Token: 0x060199BC RID: 104892 RVA: 0x006A5148 File Offset: 0x006A3348
	protected override void OnTick(float delta)
	{
		this.LockMap.Clear();
	}

	// Token: 0x060199BD RID: 104893 RVA: 0x006A5155 File Offset: 0x006A3355
	public PassiveSkillData[] GetAllPassiveSkills()
	{
		return this.SkillMap.Values.ToArray<PassiveSkillData>();
	}

	// Token: 0x060199BE RID: 104894 RVA: 0x006A5167 File Offset: 0x006A3367
	public bool HasSkill(long skillId)
	{
		return this.SkillMap.ContainsKey(skillId);
	}

	// Token: 0x060199BF RID: 104895 RVA: 0x006A5175 File Offset: 0x006A3375
	[NullableContext(2)]
	public PassiveSkillData GetSKill(long skillId)
	{
		return this.SkillMap.GetValueOrDefault(skillId);
	}

	// Token: 0x060199C0 RID: 104896 RVA: 0x006A5183 File Offset: 0x006A3383
	private bool IsPassiveSkillInCd(long skillId, int cdEntityId)
	{
		BaseSkillCdComponent baseSkillCdComponent = this.cdComp;
		return baseSkillCdComponent != null && baseSkillCdComponent.IsPassiveSkillInCd(skillId, cdEntityId);
	}

	// Token: 0x060199C1 RID: 104897 RVA: 0x006A5198 File Offset: 0x006A3398
	private void StartPassiveCd(long skillId, int cdEntityId)
	{
		BaseSkillCdComponent baseSkillCdComponent = this.cdComp;
		if (baseSkillCdComponent == null)
		{
			return;
		}
		baseSkillCdComponent.StartPassiveCd(skillId, cdEntityId, -1f);
	}

	// Token: 0x060199C2 RID: 104898 RVA: 0x006A51B2 File Offset: 0x006A33B2
	private PassiveSkill? GetPassiveSkillConfig(long skillId)
	{
		return ConfigPassiveSkillById.GetConfig(skillId, true);
	}

	// Token: 0x060199C3 RID: 104899 RVA: 0x006A51BC File Offset: 0x006A33BC
	[return: Nullable(2)]
	private unsafe Entity GetEntityByKey(long skillId, string targetKey, [Nullable(new byte[]
	{
		2,
		1
	})] Dictionary<string, TFormulaValue> parameters, [Nullable(new byte[]
	{
		2,
		1
	})] Dictionary<string, TFormulaValue> extraParams)
	{
		object obj = base.Entity;
		if (!string.IsNullOrEmpty(targetKey))
		{
			TFormulaValue tformulaValue;
			TFormulaValue tformulaValue2;
			if (parameters != null && parameters.TryGetValue(targetKey, out tformulaValue))
			{
				Entity entity;
				obj = (tformulaValue.TryGetEntity(out entity) ? entity : null);
			}
			else if (extraParams != null && extraParams.TryGetValue(targetKey, out tformulaValue2))
			{
				Entity entity2;
				obj = (tformulaValue2.TryGetEntity(out entity2) ? entity2 : null);
			}
		}
		Entity entity3 = obj as Entity;
		if (entity3 != null)
		{
			return entity3;
		}
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.PassiveSkill;
		Entity entity4 = base.Entity;
		string message = "被动技能Entity非法";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("targetKey", targetKey);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("skillId", skillId);
		instance.Error(flag, entity4, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		return null;
	}

	// Token: 0x060199C4 RID: 104900 RVA: 0x006A5283 File Offset: 0x006A3483
	private int GetCdEntityId(PassiveSkill config, Entity cdEntity)
	{
		if (!config.IsShareAllCdSkill || config.CDType != "Owner")
		{
			return cdEntity.Id;
		}
		return 0;
	}

	// Token: 0x060199C5 RID: 104901 RVA: 0x006A52AC File Offset: 0x006A34AC
	private static bool IsWhitelistSkill(long skillId)
	{
		for (int i = 0; i < CharacterPassiveSkillComponent.GlobalTriggerWhitelist.Length; i++)
		{
			if (CharacterPassiveSkillComponent.GlobalTriggerWhitelist[i] == skillId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060199C6 RID: 104902 RVA: 0x006A52D8 File Offset: 0x006A34D8
	public bool CheckAddSkillHasAuthority(PassiveSkill config)
	{
		return this.buffComp.HasBuffAuthority() || config.ActionExecuteFlag == 2;
	}

	// Token: 0x060199C7 RID: 104903 RVA: 0x006A52F3 File Offset: 0x006A34F3
	public bool CheckSkillHasAuthority(PassiveSkill config)
	{
		return this.buffComp.HasBuffAuthority() || (Convert.ToInt32(config.ActionExecuteFlag) == 2 && this.actorComp.IsAutonomousProxy);
	}

	// Token: 0x060199C8 RID: 104904 RVA: 0x006A5324 File Offset: 0x006A3524
	public unsafe bool LearnPassiveSkill(long skillId, AddPassiveSkillParam param)
	{
		PassiveSkill? config = this.GetPassiveSkillConfig(skillId);
		if (config == null)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.PassiveSkill;
			Entity entity = base.Entity;
			string message = "被动技能配置不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("skillId", skillId);
			instance.Error(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		if (this.HasSkill(skillId) || !this.CheckAddSkillHasAuthority(config.Value))
		{
			return false;
		}
		if (Convert.ToInt32(config.Value.ActionExecuteFlag) == 1)
		{
			if (param.NeedBroadcast.GetValueOrDefault())
			{
				SkillMessageController.Instance.PassiveSkillAddRequest(base.Entity, skillId, param.PreMessageId);
			}
			return true;
		}
		ETriggerEvent etriggerEvent;
		if (string.IsNullOrEmpty(config.Value.TriggerType) || !Enum.TryParse<ETriggerEvent>(config.Value.TriggerType, out etriggerEvent))
		{
			CombatLog instance2 = CombatLog.Instance;
			CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.PassiveSkill;
			Entity entity2 = base.Entity;
			string message2 = "被动技能配置错误，缺少触发类型";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("skillId", skillId);
			instance2.Error(flag2, entity2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return false;
		}
		if (etriggerEvent == ETriggerEvent.GlobalDamageTrigger && !CharacterPassiveSkillComponent.IsWhitelistSkill(skillId))
		{
			CombatLog instance3 = CombatLog.Instance;
			CombatLog.EDebugModule flag3 = CombatLog.EDebugModule.PassiveSkill;
			Entity entity3 = base.Entity;
			string message3 = "禁止白名单之外的被动使用全局伤害监听";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("skillId", skillId);
			instance3.Error(flag3, entity3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return false;
		}
		Log instance4 = Log.Instance;
		ELogModule module = ELogModule.Battle;
		ELogAuthor author = ELogAuthor.ZQR;
		string message4 = "角色添加被动技能";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("owner", base.Entity.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("skillId", skillId);
		instance4.Info(module, author, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		int num = this.triggerComp.AddTrigger(new TriggerConfigData
		{
			Type = config.Value.TriggerType,
			Preset = config.Value.TriggerPreset(),
			Params = config.Value.TriggerParams,
			Formula = config.Value.TriggerFormula,
			ExecuteType = (EExecuteType)Convert.ToInt32(config.Value.ExecuteType)
		}, delegate([Nullable(new byte[]
		{
			2,
			1
		})] Dictionary<string, TFormulaValue> parameters, [Nullable(new byte[]
		{
			2,
			1
		})] Dictionary<string, TFormulaValue> extraParams)
		{
			Entity entityByKey = this.GetEntityByKey(skillId, config.Value.InstigatorType, parameters, extraParams);
			if (entityByKey == null)
			{
				return;
			}
			Entity entityByKey2 = this.GetEntityByKey(skillId, config.Value.CDType, parameters, extraParams);
			if (entityByKey2 == null)
			{
				return;
			}
			int cdEntityId = this.GetCdEntityId(config.Value, entityByKey2);
			if (!this.CheckSkillHasAuthority(config.Value) || this.IsPassiveSkillInCd(skillId, cdEntityId))
			{
				return;
			}
			this.ExecuteAction(skillId, entityByKey, cdEntityId, extraParams);
		}, delegate
		{
			if (config.Value.CDType == "Owner")
			{
				int cdEntityId = this.GetCdEntityId(config.Value, this.Entity);
				if (this.IsPassiveSkillInCd(skillId, cdEntityId))
				{
					return false;
				}
			}
			return this.CheckSkillHasAuthority(config.Value);
		});
		this.SkillMap[skillId] = new PassiveSkillData
		{
			SkillId = skillId,
			TriggerHandle = num,
			Actions = this.ParseActions(config.Value, skillId),
			TargetKey = config.Value.InstigatorType,
			CombatMessageId = new long?(param.CombatMessageId)
		};
		this.OnPassiveSkillAdded(skillId, num, config.Value, param);
		return true;
	}

	// Token: 0x060199C9 RID: 104905 RVA: 0x006A566C File Offset: 0x006A386C
	public unsafe void ForgetPassiveSkill(long skillId, bool needBroadcast = false)
	{
		PassiveSkill? passiveSkillConfig = this.GetPassiveSkillConfig(skillId);
		if (passiveSkillConfig != null && Convert.ToInt32(passiveSkillConfig.Value.ActionExecuteFlag) == 1)
		{
			SkillMessageController.Instance.PassiveSkillRemoveRequest(base.Entity, skillId, null, null);
			return;
		}
		PassiveSkillData passiveSkillData;
		if (!this.SkillMap.TryGetValue(skillId, out passiveSkillData))
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Battle;
		ELogAuthor author = ELogAuthor.ZQR;
		string message = "角色失去被动技能";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("owner", base.Entity.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("skillId", skillId);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.triggerComp.RemoveTrigger(passiveSkillData.TriggerHandle);
		foreach (SkillActionData skillActionData in passiveSkillData.Actions)
		{
			if (skillActionData.Action == ESkillAction.Customize)
			{
				Formula formula = skillActionData.Formula;
				if (formula != null)
				{
					formula.Dispose();
				}
			}
		}
		this.SkillMap.Remove(skillId);
		this.OnPassiveSkillRemoved(skillId, needBroadcast);
	}

	// Token: 0x060199CA RID: 104906 RVA: 0x006A57C4 File Offset: 0x006A39C4
	public void SetPassiveSkillActive(long skillId, bool active)
	{
		PassiveSkillData passiveSkillData;
		if (!this.SkillMap.TryGetValue(skillId, out passiveSkillData))
		{
			return;
		}
		if (passiveSkillData.TriggerHandle > 0)
		{
			this.triggerComp.SetTriggerActive(passiveSkillData.TriggerHandle, active);
		}
	}

	// Token: 0x060199CB RID: 104907 RVA: 0x006A5800 File Offset: 0x006A3A00
	protected List<SkillActionData> ParseActions(PassiveSkill config, long skillId)
	{
		List<SkillActionData> list = new List<SkillActionData>();
		SkillActionData skillActionData = this.ParseAction(config, skillId);
		if (skillActionData != null)
		{
			list.Add(skillActionData);
		}
		foreach (long skillId2 in config.SubSkillActionIter())
		{
			PassiveSkill? passiveSkillConfig = this.GetPassiveSkillConfig(skillId2);
			if (passiveSkillConfig != null)
			{
				SkillActionData skillActionData2 = this.ParseAction(passiveSkillConfig.Value, skillId);
				if (skillActionData2 != null)
				{
					list.Add(skillActionData2);
				}
			}
		}
		return list;
	}

	// Token: 0x060199CC RID: 104908 RVA: 0x006A5890 File Offset: 0x006A3A90
	[NullableContext(2)]
	protected SkillActionData ParseAction(PassiveSkill config, long skillId)
	{
		ESkillAction action;
		if (!Enum.TryParse<ESkillAction>(Convert.ToString(config.SkillAction), out action))
		{
			return null;
		}
		string[] array = config.SkillActionParams() ?? Array.Empty<string>();
		SkillActionData skillActionData = new SkillActionData
		{
			Action = action
		};
		switch (action)
		{
		case ESkillAction.AddBullet:
			skillActionData.BulletRowNames = new string[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				skillActionData.BulletRowNames[i] = array[i].Trim();
			}
			return skillActionData;
		case ESkillAction.RemoveBullet:
			skillActionData.BulletRowNames = new string[array.Length];
			skillActionData.SummonChild = new bool[array.Length];
			for (int j = 0; j < array.Length; j++)
			{
				string[] array2 = array[j].Split('#', StringSplitOptions.None);
				skillActionData.BulletRowNames[j] = ((array2.Length != 0) ? array2[0].Trim() : string.Empty);
				skillActionData.SummonChild[j] = (array2.Length > 1 && array2[1].Trim() == "1");
			}
			return skillActionData;
		case ESkillAction.AddBuff:
			skillActionData.BuffId = new long[array.Length];
			for (int k = 0; k < array.Length; k++)
			{
				skillActionData.BuffId[k] = Convert.ToInt64(array[k]);
			}
			return skillActionData;
		case ESkillAction.RemoveBuff:
			skillActionData.BuffId = new long[array.Length];
			skillActionData.StackCount = new int[array.Length];
			for (int l = 0; l < array.Length; l++)
			{
				string[] array3 = array[l].Split('#', StringSplitOptions.None);
				skillActionData.BuffId[l] = ((array3.Length != 0) ? Convert.ToInt64(array3[0]) : 0L);
				skillActionData.StackCount[l] = ((array3.Length > 1) ? Convert.ToInt32(array3[1]) : -1);
			}
			return skillActionData;
		case ESkillAction.StartSkill:
			skillActionData.SkillId = ((array.Length != 0) ? Convert.ToInt32(array[0]) : 0);
			return skillActionData;
		case ESkillAction.LockOn:
			skillActionData.IsHardLock = (array.Length != 0 && array[0] == "1");
			skillActionData.LockOnConfigId = ((array.Length > 1) ? Convert.ToInt32(array[1]) : 0);
			skillActionData.SkillTargetPriority = ((array.Length > 2) ? ((ESkillTargetPriority)Convert.ToInt32(array[2])) : ESkillTargetPriority.系统设置);
			skillActionData.ShowTarget = (array.Length <= 3 || array[3] == "1");
			skillActionData.GlobalTarget = (array.Length > 4 && array[4] == "1");
			return skillActionData;
		case ESkillAction.Customize:
			skillActionData.Formula = CharacterPassiveSkillCustomAction.AddCustomAction(new PassiveSkill?(config), base.Entity, this.triggerComp.TriggerFormulaFunc);
			return skillActionData;
		case ESkillAction.ReduceSkillCd:
			skillActionData.ReduceSkillId = new long[array.Length];
			skillActionData.CdResetType = new ESkillCdReduceType[array.Length];
			skillActionData.DecreaseMagnitude = new float[array.Length];
			skillActionData.DecreaseRatio = new float[array.Length];
			for (int m = 0; m < array.Length; m++)
			{
				string[] array4 = array[m].Split('#', StringSplitOptions.None);
				skillActionData.ReduceSkillId[m] = ((array4.Length != 0) ? Convert.ToInt64(array4[0]) : 0L);
				skillActionData.CdResetType[m] = (ESkillCdReduceType)((array4.Length > 1) ? Convert.ToInt32(array4[1]) : 0);
				skillActionData.DecreaseMagnitude[m] = ((array4.Length > 2) ? Convert.ToSingle(array4[2]) : 0f);
				skillActionData.DecreaseRatio[m] = ((array4.Length > 3) ? Convert.ToSingle(array4[3]) : 0f);
			}
			return skillActionData;
		default:
			return null;
		}
	}

	// Token: 0x060199CD RID: 104909 RVA: 0x006A5BF0 File Offset: 0x006A3DF0
	protected unsafe void ExecuteAction(long skillId, Entity targetEntity, int passiveCdEntityId, [Nullable(new byte[]
	{
		2,
		1
	})] Dictionary<string, TFormulaValue> extraParams)
	{
		if (this.LockMap.Contains(skillId))
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.PassiveSkill;
			Entity entity = base.Entity;
			string message = "被动技能在同一次调用栈中重复触发，需要检查技能配置";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("skillId", skillId);
			PassiveSkill? passiveSkill;
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("desc", ((this.GetPassiveSkillConfig(skillId) != null) ? passiveSkill.GetValueOrDefault().SkillDesc : null) ?? string.Empty);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("current executing skill ids", new List<long>(this.LockMap));
			instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		PassiveSkillData passiveSkillData;
		if (!this.SkillMap.TryGetValue(skillId, out passiveSkillData))
		{
			return;
		}
		this.StartPassiveCd(skillId, passiveCdEntityId);
		this.LockMap.Add(skillId);
		PassiveSkill? passiveSkillConfig = this.GetPassiveSkillConfig(skillId);
		int num = (passiveSkillConfig != null) ? passiveSkillConfig.GetValueOrDefault().ActionBaseProbability : -1;
		if (num >= 0)
		{
			float num2 = ModifyPassiveSkillProbability.CalculateFinalProbability((float)num, skillId, this.buffComp.BuffEffectManager);
			if (Random.Shared.NextDouble() * 10000.0 > (double)num2)
			{
				this.LockMap.Remove(skillId);
				return;
			}
		}
		for (int i = 0; i < passiveSkillData.Actions.Count; i++)
		{
			SkillActionData skillActionData = passiveSkillData.Actions[i];
			switch (skillActionData.Action)
			{
			case ESkillAction.AddBullet:
			{
				BaseActorComponent component = targetEntity.GetComponent<BaseActorComponent>();
				FTransformDouble? initialTransform = (component != null) ? new FTransformDouble?(component.ActorTransform) : null;
				if (initialTransform == null)
				{
					CombatLog instance2 = CombatLog.Instance;
					CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.PassiveSkill;
					Entity entity2 = base.Entity;
					string message2 = "被动技能目标没有ActorTransform";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("skillId", skillId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("targetEntity", targetEntity.Id);
					instance2.Error(flag2, entity2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				}
				else
				{
					for (int j = 0; j < skillActionData.BulletRowNames.Length; j++)
					{
						BulletController.Instance.CreateBulletCustomTarget(base.Entity, skillActionData.BulletRowNames[j], initialTransform, null, passiveSkillData.CombatMessageId, global::EBulletCreateSource.Others);
					}
				}
				break;
			}
			case ESkillAction.RemoveBullet:
			{
				IReadOnlyCollection<BulletEntity> bulletSetByAttacker = BulletModel.Instance.GetBulletSetByAttacker(base.Entity.Id);
				if (bulletSetByAttacker != null)
				{
					List<ValueTuple<long, bool>> list = new List<ValueTuple<long, bool>>();
					foreach (BulletEntity bulletEntity in bulletSetByAttacker)
					{
						BulletInfo bulletInfo = bulletEntity.GetBulletInfo();
						for (int k = 0; k < skillActionData.BulletRowNames.Length; k++)
						{
							if (skillActionData.BulletRowNames[k] == bulletInfo.BulletRowName)
							{
								bool item = k < skillActionData.SummonChild.Length && skillActionData.SummonChild[k];
								list.Add(new ValueTuple<long, bool>((long)bulletInfo.BulletEntityId, item));
								break;
							}
						}
					}
					for (int l = 0; l < list.Count; l++)
					{
						BulletController.Instance.DestroyBullet(Convert.ToInt32(list[l].Item1), list[l].Item2, EBulletDestroyReason.FromPassiveSkill, false);
					}
				}
				break;
			}
			case ESkillAction.AddBuff:
			{
				CharacterBuffComponent component2 = targetEntity.GetComponent<CharacterBuffComponent>();
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
				defaultInterpolatedStringHandler.AppendLiteral("被动技能");
				defaultInterpolatedStringHandler.AppendFormatted<long>(skillId);
				defaultInterpolatedStringHandler.AppendLiteral("添加");
				string reason = defaultInterpolatedStringHandler.ToStringAndClear();
				for (int m = 0; m < skillActionData.BuffId.Length; m++)
				{
					if (component2 != null)
					{
						component2.AddBuff(skillActionData.BuffId[m], new AddBuffParam
						{
							InstigatorId = this.buffComp.CreatureDataId,
							PreMessageId = passiveSkillData.CombatMessageId,
							Reason = reason
						});
					}
				}
				break;
			}
			case ESkillAction.RemoveBuff:
			{
				CharacterBuffComponent component3 = targetEntity.GetComponent<CharacterBuffComponent>();
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
				defaultInterpolatedStringHandler.AppendLiteral("被动技能");
				defaultInterpolatedStringHandler.AppendFormatted<long>(skillId);
				defaultInterpolatedStringHandler.AppendLiteral("移除");
				string reason2 = defaultInterpolatedStringHandler.ToStringAndClear();
				for (int n = 0; n < skillActionData.BuffId.Length; n++)
				{
					int stackCount = (n < skillActionData.StackCount.Length) ? skillActionData.StackCount[n] : -1;
					if (component3 != null)
					{
						component3.RemoveBuff(skillActionData.BuffId[n], stackCount, reason2, null, null, null);
					}
				}
				break;
			}
			case ESkillAction.StartSkill:
			{
				CharacterSkillComponent component4 = targetEntity.GetComponent<CharacterSkillComponent>();
				if (component4 != null)
				{
					component4.BeginSkillAsync(skillActionData.SkillId, new SkillParam
					{
						ContextId = passiveSkillData.CombatMessageId,
						Reason = "PassiveSkillComponent.ExecuteAction"
					});
				}
				break;
			}
			case ESkillAction.LockOn:
			{
				CharacterLockOnComponent component5 = targetEntity.GetComponent<CharacterLockOnComponent>();
				CharacterSkillComponent component6 = targetEntity.GetComponent<CharacterSkillComponent>();
				if (skillActionData.IsHardLock)
				{
					if (component5 != null)
					{
						component5.EnterLockDirection();
					}
				}
				else if (component6 != null)
				{
					component6.LockOnTargetAndSetShow(new SSkillTarget
					{
						LockOnConfigId = skillActionData.LockOnConfigId,
						SkillTargetPriority = skillActionData.SkillTargetPriority,
						ShowTarget = skillActionData.ShowTarget,
						GlobalTarget = skillActionData.GlobalTarget
					}, true);
				}
				break;
			}
			case ESkillAction.Customize:
			{
				this.Context.SkillId = skillId;
				Formula formula = skillActionData.Formula;
				if (formula != null)
				{
					formula.Evaluate(extraParams, this.Context);
				}
				break;
			}
			case ESkillAction.ReduceSkillCd:
			{
				CharacterSkillCdComponent component7 = targetEntity.GetComponent<CharacterSkillCdComponent>();
				if (component7 != null)
				{
					for (int num3 = 0; num3 < skillActionData.ReduceSkillId.Length; num3++)
					{
						float num4 = (num3 < skillActionData.DecreaseMagnitude.Length) ? skillActionData.DecreaseMagnitude[num3] : 0f;
						float changeTimePercentage = -((num3 < skillActionData.DecreaseRatio.Length) ? skillActionData.DecreaseRatio[num3] : 0f) * 0.0001f;
						float modifyTime = -num4;
						if (num3 < skillActionData.CdResetType.Length && skillActionData.CdResetType[num3] == ESkillCdReduceType.SpecifiedSkillId)
						{
							component7.ModifyCdTime(new long[]
							{
								skillActionData.ReduceSkillId[num3]
							}, modifyTime, changeTimePercentage);
						}
						else if (num3 < skillActionData.CdResetType.Length && skillActionData.CdResetType[num3] == ESkillCdReduceType.SpecifiedSkillGenre)
						{
							component7.ModifyCdTimeBySkillGenres(new int[]
							{
								Convert.ToInt32(skillActionData.ReduceSkillId[num3])
							}, modifyTime, changeTimePercentage);
						}
					}
				}
				break;
			}
			}
		}
		this.LockMap.Remove(skillId);
	}

	// Token: 0x060199CE RID: 104910 RVA: 0x006A62B8 File Offset: 0x006A44B8
	[NullableContext(2)]
	protected void OnPassiveSkillAdded(long skillId, int handle, PassiveSkill config, AddPassiveSkillParam param = null)
	{
		this.triggerComp.GetTrigger(handle);
		BaseSkillCdComponent baseSkillCdComponent = this.cdComp;
		if (baseSkillCdComponent != null)
		{
			baseSkillCdComponent.InitPassiveSkill(config);
		}
		if (param != null && param.NeedBroadcast.GetValueOrDefault())
		{
			long value = SkillMessageController.Instance.PassiveSkillAddRequest(base.Entity, skillId, param.PreMessageId);
			PassiveSkillData passiveSkillData;
			if (this.SkillMap.TryGetValue(skillId, out passiveSkillData))
			{
				passiveSkillData.CombatMessageId = new long?(value);
			}
		}
		if (config.IsDefaultActivated)
		{
			this.triggerComp.SetTriggerActive(handle, true);
		}
	}

	// Token: 0x060199CF RID: 104911 RVA: 0x006A6348 File Offset: 0x006A4548
	protected void OnPassiveSkillRemoved(long skillId, bool needBroadcast)
	{
		if (needBroadcast)
		{
			SkillMessageController.Instance.PassiveSkillRemoveRequest(base.Entity, skillId, null, null);
		}
	}

	// Token: 0x060199D0 RID: 104912 RVA: 0x006A637C File Offset: 0x006A457C
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.PassiveSkillAddNotify, false, false)]
	public static void PassiveSkillAddNotify(Entity entity, [Nullable(1)] PassiveSkillAddNotify data, CombatCommon combatCommon = null)
	{
		CharacterPassiveSkillComponent characterPassiveSkillComponent = (entity != null) ? entity.GetComponent<CharacterPassiveSkillComponent>() : null;
		foreach (PassiveSkillItemPb passiveSkillItemPb in data.PassiveSkillItemPbList)
		{
			if (characterPassiveSkillComponent != null)
			{
				characterPassiveSkillComponent.LearnPassiveSkill(passiveSkillItemPb.SkillId, new AddPassiveSkillParam
				{
					CombatMessageId = passiveSkillItemPb.CombatCommon.MessageId
				});
			}
		}
	}

	// Token: 0x060199D1 RID: 104913 RVA: 0x006A63F8 File Offset: 0x006A45F8
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.PassiveSkillRemoveNotify, false, false)]
	public static void PassiveSkillRemoveNotify(Entity entity, [Nullable(1)] PassiveSkillRemoveNotify data, CombatCommon combatCommon = null)
	{
		CharacterPassiveSkillComponent characterPassiveSkillComponent = (entity != null) ? entity.GetComponent<CharacterPassiveSkillComponent>() : null;
		foreach (long skillId in data.SkillIdList)
		{
			if (characterPassiveSkillComponent != null)
			{
				characterPassiveSkillComponent.ForgetPassiveSkill(skillId, false);
			}
		}
	}

	// Token: 0x060199D2 RID: 104914 RVA: 0x006A6458 File Offset: 0x006A4658
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterPassiveSkillComponent characterPassiveSkillComponent = (CharacterPassiveSkillComponent)componentTemplate;
		if (base.CanResetComponentProperty("triggerComp"))
		{
			if (characterPassiveSkillComponent.triggerComp == null)
			{
				this.triggerComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterTriggerComponent>(this.triggerComp), "triggerComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("buffComp"))
		{
			if (characterPassiveSkillComponent.buffComp == null)
			{
				this.buffComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterBuffComponent>(this.buffComp), "buffComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("cdComp"))
		{
			if (characterPassiveSkillComponent.cdComp == null)
			{
				this.cdComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseSkillCdComponent>(this.cdComp), "cdComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("actorComp"))
		{
			if (characterPassiveSkillComponent.actorComp == null)
			{
				this.actorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.actorComp), "actorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SkillMap") && characterPassiveSkillComponent.SkillMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<long, PassiveSkillData>>(this.SkillMap), "SkillMap"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("Context"))
		{
			if (characterPassiveSkillComponent.Context == null)
			{
				this.Context = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ContextParam>(this.Context), "Context"))
			{
				return false;
			}
		}
		return !base.CanResetComponentProperty("LockMap") || characterPassiveSkillComponent.LockMap == null || base.CheckClearObject(EntityComponentSystem.ClearObject<long>(this.LockMap), "LockMap");
	}

	// Token: 0x0400BFC0 RID: 49088
	private const float DIVIDED_TEN_THOUSAND = 0.0001f;

	// Token: 0x0400BFC1 RID: 49089
	private const string OwnerType = "Owner";

	// Token: 0x0400BFC2 RID: 49090
	private const int ShareAllCdSkillEntityId = 0;

	// Token: 0x0400BFC3 RID: 49091
	[StaticVariableRuleIgnore]
	private static readonly long[] GlobalTriggerWhitelist = new long[]
	{
		1302101064L
	};

	// Token: 0x0400BFC4 RID: 49092
	private CharacterTriggerComponent triggerComp;

	// Token: 0x0400BFC5 RID: 49093
	private CharacterBuffComponent buffComp;

	// Token: 0x0400BFC6 RID: 49094
	[Nullable(2)]
	private BaseSkillCdComponent cdComp;

	// Token: 0x0400BFC7 RID: 49095
	private CharacterActorComponent actorComp;

	// Token: 0x0400BFC8 RID: 49096
	private readonly Dictionary<long, PassiveSkillData> SkillMap = new Dictionary<long, PassiveSkillData>();

	// Token: 0x0400BFC9 RID: 49097
	private ContextParam Context;

	// Token: 0x0400BFCA RID: 49098
	private readonly HashSet<long> LockMap = new HashSet<long>();
}
