using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Module.CombatMessage;
using CSharpScript.Utils;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x02002426 RID: 9254
[NullableContext(1)]
[Nullable(0)]
public class CharacterPassiveSkillComponent : EntityComponent
{
	// Token: 0x060172B2 RID: 94898 RVA: 0x006CB168 File Offset: 0x006C9368
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

	// Token: 0x060172B3 RID: 94899 RVA: 0x006CB1EC File Offset: 0x006C93EC
	protected override bool OnStart()
	{
		return true;
	}

	// Token: 0x060172B4 RID: 94900 RVA: 0x006CB1F0 File Offset: 0x006C93F0
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

	// Token: 0x060172B5 RID: 94901 RVA: 0x006CB2B0 File Offset: 0x006C94B0
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

	// Token: 0x060172B6 RID: 94902 RVA: 0x006CB314 File Offset: 0x006C9514
	protected override void OnTick(float delta)
	{
		this.LockMap.Clear();
	}

	// Token: 0x060172B7 RID: 94903 RVA: 0x006CB324 File Offset: 0x006C9524
	public PassiveSkillData[] GetAllPassiveSkills()
	{
		PassiveSkillData[] array = new PassiveSkillData[this.SkillMap.Count];
		this.SkillMap.Values.CopyTo(array, 0);
		return array;
	}

	// Token: 0x060172B8 RID: 94904 RVA: 0x006CB355 File Offset: 0x006C9555
	public bool HasSkill(long skillId)
	{
		return this.SkillMap.ContainsKey(skillId);
	}

	// Token: 0x060172B9 RID: 94905 RVA: 0x006CB363 File Offset: 0x006C9563
	[NullableContext(2)]
	public PassiveSkillData GetSKill(long skillId)
	{
		return this.SkillMap.GetValueOrDefault(skillId);
	}

	// Token: 0x060172BA RID: 94906 RVA: 0x006CB371 File Offset: 0x006C9571
	private bool IsPassiveSkillInCd(long skillId, int cdEntityId)
	{
		BaseSkillCdComponent baseSkillCdComponent = this.cdComp;
		return baseSkillCdComponent != null && baseSkillCdComponent.IsPassiveSkillInCd(skillId, cdEntityId);
	}

	// Token: 0x060172BB RID: 94907 RVA: 0x006CB386 File Offset: 0x006C9586
	private void StartPassiveCd(long skillId, int cdEntityId)
	{
		BaseSkillCdComponent baseSkillCdComponent = this.cdComp;
		if (baseSkillCdComponent == null)
		{
			return;
		}
		baseSkillCdComponent.StartPassiveCd(skillId, cdEntityId, -1f);
	}

	// Token: 0x060172BC RID: 94908 RVA: 0x006CB3A0 File Offset: 0x006C95A0
	private PassiveSkill? GetPassiveSkillConfig(long skillId)
	{
		return ConfigPassiveSkillById.GetConfig(skillId, true);
	}

	// Token: 0x060172BD RID: 94909 RVA: 0x006CB3AC File Offset: 0x006C95AC
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

	// Token: 0x060172BE RID: 94910 RVA: 0x006CB473 File Offset: 0x006C9673
	private int GetCdEntityId(PassiveSkill config, Entity cdEntity)
	{
		if (!config.IsShareAllCdSkill || config.CDType != "Owner")
		{
			return cdEntity.Id;
		}
		return 0;
	}

	// Token: 0x060172BF RID: 94911 RVA: 0x006CB49C File Offset: 0x006C969C
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

	// Token: 0x060172C0 RID: 94912 RVA: 0x006CB4C8 File Offset: 0x006C96C8
	public bool CheckAddSkillHasAuthority(PassiveSkill config)
	{
		return this.buffComp.HasBuffAuthority() || config.ActionExecuteFlag == 2;
	}

	// Token: 0x060172C1 RID: 94913 RVA: 0x006CB4E3 File Offset: 0x006C96E3
	public bool CheckSkillHasAuthority(PassiveSkill config)
	{
		return this.buffComp.HasBuffAuthority() || (Convert.ToInt32(config.ActionExecuteFlag) == 2 && this.actorComp.IsAutonomousProxy);
	}

	// Token: 0x060172C2 RID: 94914 RVA: 0x006CB514 File Offset: 0x006C9714
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

	// Token: 0x060172C3 RID: 94915 RVA: 0x006CB85C File Offset: 0x006C9A5C
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

	// Token: 0x060172C4 RID: 94916 RVA: 0x006CB9B4 File Offset: 0x006C9BB4
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

	// Token: 0x060172C5 RID: 94917 RVA: 0x006CB9F0 File Offset: 0x006C9BF0
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

	// Token: 0x060172C6 RID: 94918 RVA: 0x006CBA80 File Offset: 0x006C9C80
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

	// Token: 0x060172C7 RID: 94919 RVA: 0x006CBDE0 File Offset: 0x006C9FE0
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

	// Token: 0x060172C8 RID: 94920 RVA: 0x006CC4A8 File Offset: 0x006CA6A8
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

	// Token: 0x060172C9 RID: 94921 RVA: 0x006CC538 File Offset: 0x006CA738
	protected void OnPassiveSkillRemoved(long skillId, bool needBroadcast)
	{
		if (needBroadcast)
		{
			SkillMessageController.Instance.PassiveSkillRemoveRequest(base.Entity, skillId, null, null);
		}
	}

	// Token: 0x060172CA RID: 94922 RVA: 0x006CC56C File Offset: 0x006CA76C
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

	// Token: 0x060172CB RID: 94923 RVA: 0x006CC5E8 File Offset: 0x006CA7E8
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

	// Token: 0x060172CC RID: 94924 RVA: 0x006CC648 File Offset: 0x006CA848
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterPassiveSkillComponent characterPassiveSkillComponent = (CharacterPassiveSkillComponent)componentTemplate;
		if (characterPassiveSkillComponent.triggerComp == null)
		{
			this.triggerComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.triggerComp), "triggerComp"))
		{
			return false;
		}
		if (characterPassiveSkillComponent.buffComp == null)
		{
			this.buffComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.buffComp), "buffComp"))
		{
			return false;
		}
		if (characterPassiveSkillComponent.cdComp == null)
		{
			this.cdComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.cdComp), "cdComp"))
		{
			return false;
		}
		if (characterPassiveSkillComponent.actorComp == null)
		{
			this.actorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.actorComp), "actorComp"))
		{
			return false;
		}
		if (characterPassiveSkillComponent.SkillMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.SkillMap), "SkillMap"))
		{
			return false;
		}
		if (characterPassiveSkillComponent.Context == null)
		{
			this.Context = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Context), "Context"))
		{
			return false;
		}
		return characterPassiveSkillComponent.LockMap == null || base.CheckClearObject(EntityComponentSystem.ClearObject<long>(this.LockMap), "LockMap");
	}

	// Token: 0x1700241D RID: 9245
	// (get) Token: 0x060172CD RID: 94925 RVA: 0x006CC783 File Offset: 0x006CA983
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700241E RID: 9246
	// (get) Token: 0x060172CE RID: 94926 RVA: 0x006CC786 File Offset: 0x006CA986
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700241F RID: 9247
	// (get) Token: 0x060172CF RID: 94927 RVA: 0x006CC789 File Offset: 0x006CA989
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002420 RID: 9248
	// (get) Token: 0x060172D0 RID: 94928 RVA: 0x006CC78C File Offset: 0x006CA98C
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002421 RID: 9249
	// (get) Token: 0x060172D1 RID: 94929 RVA: 0x006CC78F File Offset: 0x006CA98F
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400C35B RID: 50011
	private const float DIVIDED_TEN_THOUSAND = 0.0001f;

	// Token: 0x0400C35C RID: 50012
	private const string OwnerType = "Owner";

	// Token: 0x0400C35D RID: 50013
	private const int ShareAllCdSkillEntityId = 0;

	// Token: 0x0400C35E RID: 50014
	[StaticVariableRuleIgnore]
	private static readonly long[] GlobalTriggerWhitelist = new long[]
	{
		1302101064L
	};

	// Token: 0x0400C35F RID: 50015
	private CharacterTriggerComponent triggerComp;

	// Token: 0x0400C360 RID: 50016
	private CharacterBuffComponent buffComp;

	// Token: 0x0400C361 RID: 50017
	[Nullable(2)]
	private BaseSkillCdComponent cdComp;

	// Token: 0x0400C362 RID: 50018
	private CharacterActorComponent actorComp;

	// Token: 0x0400C363 RID: 50019
	private readonly Dictionary<long, PassiveSkillData> SkillMap = new Dictionary<long, PassiveSkillData>();

	// Token: 0x0400C364 RID: 50020
	private ContextParam Context;

	// Token: 0x0400C365 RID: 50021
	private readonly HashSet<long> LockMap = new HashSet<long>();
}
