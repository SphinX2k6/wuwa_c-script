using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Utils;
using UnrealEngine;

// Token: 0x020026A9 RID: 9897
[NullableContext(1)]
[Nullable(0)]
public class CharacterSkillTriggerComponent : EntityComponent, ISkillTableChangeListener
{
	// Token: 0x06018CF1 RID: 101617 RVA: 0x00788A9C File Offset: 0x00786C9C
	protected override bool OnInit()
	{
		this.SkillComp = base.Entity.CheckGetComponent<BaseSkillComponent>();
		this.TriggerComp = base.Entity.CheckGetComponent<CharacterTriggerComponent>();
		return true;
	}

	// Token: 0x06018CF2 RID: 101618 RVA: 0x00788AC1 File Offset: 0x00786CC1
	protected override bool OnStart()
	{
		return true;
	}

	// Token: 0x06018CF3 RID: 101619 RVA: 0x00788AC4 File Offset: 0x00786CC4
	protected override void OnActivate()
	{
		foreach (int skillId in this.SkillComp.GetAllSkillId(EFightDataTableSourceType.All))
		{
			this.RefreshSkillTriggerById(skillId);
		}
		BaseSkillComponent skillComp = this.SkillComp;
		if (skillComp == null)
		{
			return;
		}
		skillComp.AddSkillTableChangeListener(this);
	}

	// Token: 0x06018CF4 RID: 101620 RVA: 0x00788B28 File Offset: 0x00786D28
	protected override bool OnEnd()
	{
		BaseSkillComponent skillComp = this.SkillComp;
		if (skillComp != null)
		{
			skillComp.RemoveSkillTableChangeListener(this);
		}
		foreach (int skillId in new List<int>(this.SkillTriggerHandles.Keys))
		{
			this.UnregisterSkillTriggerById(skillId);
		}
		return true;
	}

	// Token: 0x06018CF5 RID: 101621 RVA: 0x00788B98 File Offset: 0x00786D98
	public void OnSkillIdsChanged(IReadOnlyList<int> candidateSkillIds)
	{
		try
		{
			foreach (int skillId in candidateSkillIds)
			{
				this.RefreshSkillTriggerById(skillId);
			}
		}
		finally
		{
		}
	}

	// Token: 0x06018CF6 RID: 101622 RVA: 0x00788BF0 File Offset: 0x00786DF0
	public void AddSkillTriggerDebug(int skillId, SSkillInfo info)
	{
		if (this.SkillTriggerHandles.ContainsKey(skillId))
		{
			this.UnregisterSkillTriggerById(skillId);
		}
		List<int> list = this.AddSkillTrigger(skillId, info);
		if (list.Count > 0)
		{
			this.SkillTriggerHandles[skillId] = list;
		}
	}

	// Token: 0x06018CF7 RID: 101623 RVA: 0x00788C34 File Offset: 0x00786E34
	private void RefreshSkillTriggerById(int skillId)
	{
		ResolvedSkillInfo resolvedSkillInfo = this.SkillComp.FindSkillInfo(skillId);
		if (resolvedSkillInfo == null)
		{
			this.UnregisterSkillTriggerById(skillId);
			return;
		}
		UDataTable udataTable;
		if (this.SkillTriggerSources.TryGetValue(skillId, out udataTable) && udataTable == resolvedSkillInfo.SourceTable)
		{
			return;
		}
		this.UnregisterSkillTriggerById(skillId);
		List<int> list = this.AddSkillTrigger(skillId, resolvedSkillInfo.Info);
		if (list.Count > 0)
		{
			this.SkillTriggerHandles[skillId] = list;
			this.SkillTriggerSources[skillId] = resolvedSkillInfo.SourceTable;
		}
	}

	// Token: 0x06018CF8 RID: 101624 RVA: 0x00788CB0 File Offset: 0x00786EB0
	private void UnregisterSkillTriggerById(int skillId)
	{
		List<int> list;
		if (this.SkillTriggerHandles.TryGetValue(skillId, out list))
		{
			foreach (int handle in list)
			{
				this.TriggerComp.RemoveTrigger(handle);
			}
		}
		this.SkillTriggerHandles.Remove(skillId);
		this.SkillTriggerSources.Remove(skillId);
	}

	// Token: 0x06018CF9 RID: 101625 RVA: 0x00788D30 File Offset: 0x00786F30
	private unsafe List<int> AddSkillTrigger(int skillId, SSkillInfo info)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < info.SkillTriggers.Num(); i++)
		{
			SSkillTrigger skillTrigger = info.SkillTriggers.Get(i);
			ETriggerEvent etriggerEvent;
			if (!Enum.TryParse<ETriggerEvent>(skillTrigger.TriggerType, out etriggerEvent))
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
				Entity entity = base.Entity;
				string message = "技能触发器类型不合法";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("技能Id", skillId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("触发器类型", skillTrigger.TriggerType);
				instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			else
			{
				List<string> list2 = new List<string>();
				if (skillTrigger.TriggerPreset != null)
				{
					for (int j = 0; j < skillTrigger.TriggerPreset.Num(); j++)
					{
						list2.Add(skillTrigger.TriggerPreset.Get(j));
					}
				}
				if (etriggerEvent == ETriggerEvent.GlobalDamageTrigger)
				{
					CombatLog instance2 = CombatLog.Instance;
					CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Skill;
					Entity entity2 = base.Entity;
					string message2 = "禁止白名单之外的技能使用全局伤害监听";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("skillId", skillId);
					instance2.Error(flag2, entity2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					int num = this.TriggerComp.AddTrigger(new TriggerConfigData
					{
						Type = skillTrigger.TriggerType,
						Preset = list2.ToArray(),
						Params = (string.IsNullOrEmpty(skillTrigger.TriggerParams) ? "{}" : skillTrigger.TriggerParams),
						Formula = (string.IsNullOrEmpty(skillTrigger.TriggerFormula) ? "TRUE" : skillTrigger.TriggerFormula),
						ExecuteType = EExecuteType.Default
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
						string triggerTarget = skillTrigger.TriggerTarget;
						Entity target = null;
						TFormulaValue tformulaValue;
						if (!string.IsNullOrEmpty(triggerTarget) && extraParams != null && extraParams.TryGetValue(triggerTarget, out tformulaValue) && !tformulaValue.TryGetEntity(out target))
						{
							CombatLog.Instance.Error(CombatLog.EDebugModule.Skill, this.Entity, "技能触发器配的技能目标不正确或不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
							return;
						}
						string triggerTargetSocket = skillTrigger.TriggerTargetSocket;
						string socketName = null;
						TFormulaValue tformulaValue2;
						string text;
						if (!string.IsNullOrEmpty(triggerTargetSocket) && extraParams != null && extraParams.TryGetValue(triggerTargetSocket, out tformulaValue2) && tformulaValue2.TryGetString(out text))
						{
							socketName = text;
						}
						this.SkillComp.BeginSkill(skillId, new SkillParam
						{
							Reason = "技能触发器触发",
							Target = target,
							SocketName = socketName
						});
					}, null);
					if (num != -1)
					{
						this.TriggerComp.SetTriggerActive(num, true);
						list.Add(num);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06018CFA RID: 101626 RVA: 0x00788F74 File Offset: 0x00787174
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterSkillTriggerComponent characterSkillTriggerComponent = (CharacterSkillTriggerComponent)componentTemplate;
		if (characterSkillTriggerComponent.SkillComp == null)
		{
			this.SkillComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SkillComp), "SkillComp"))
		{
			return false;
		}
		if (characterSkillTriggerComponent.TriggerComp == null)
		{
			this.TriggerComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TriggerComp), "TriggerComp"))
		{
			return false;
		}
		return (characterSkillTriggerComponent.SkillTriggerHandles == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.SkillTriggerHandles), "SkillTriggerHandles")) && (characterSkillTriggerComponent.SkillTriggerSources == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.SkillTriggerSources), "SkillTriggerSources"));
	}

	// Token: 0x17002763 RID: 10083
	// (get) Token: 0x06018CFB RID: 101627 RVA: 0x0078902E File Offset: 0x0078722E
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002764 RID: 10084
	// (get) Token: 0x06018CFC RID: 101628 RVA: 0x00789031 File Offset: 0x00787231
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002765 RID: 10085
	// (get) Token: 0x06018CFD RID: 101629 RVA: 0x00789034 File Offset: 0x00787234
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002766 RID: 10086
	// (get) Token: 0x06018CFE RID: 101630 RVA: 0x00789037 File Offset: 0x00787237
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400D766 RID: 55142
	[StaticVariableRuleIgnore]
	private static readonly Stat OnSkillIdsChangedStat = Stat.Create("CharacterSkillTriggerComponent.OnSkillIdsChanged", "", "");

	// Token: 0x0400D767 RID: 55143
	[Nullable(2)]
	private BaseSkillComponent SkillComp;

	// Token: 0x0400D768 RID: 55144
	[Nullable(2)]
	private CharacterTriggerComponent TriggerComp;

	// Token: 0x0400D769 RID: 55145
	private readonly Dictionary<int, List<int>> SkillTriggerHandles = new Dictionary<int, List<int>>();

	// Token: 0x0400D76A RID: 55146
	private readonly Dictionary<int, UDataTable> SkillTriggerSources = new Dictionary<int, UDataTable>();
}
