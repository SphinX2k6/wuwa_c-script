using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Utils;

// Token: 0x02003147 RID: 12615
[NullableContext(1)]
[Nullable(0)]
public class CharacterSkillTriggerComponent : EntityComponent
{
	// Token: 0x0601B24A RID: 111178 RVA: 0x007621E3 File Offset: 0x007603E3
	protected override bool OnInit()
	{
		this.SkillComp = base.Entity.CheckGetComponent<BaseSkillComponent>();
		this.TriggerComp = base.Entity.CheckGetComponent<CharacterTriggerComponent>();
		return true;
	}

	// Token: 0x0601B24B RID: 111179 RVA: 0x00762208 File Offset: 0x00760408
	protected override bool OnStart()
	{
		return true;
	}

	// Token: 0x0601B24C RID: 111180 RVA: 0x0076220C File Offset: 0x0076040C
	protected override void OnActivate()
	{
		foreach (int skillId in this.SkillComp.GetAllSkillId(EFightDataTableSourceType.All))
		{
			this.RegisterSkillTriggerById(skillId);
		}
	}

	// Token: 0x0601B24D RID: 111181 RVA: 0x00762260 File Offset: 0x00760460
	protected override bool OnEnd()
	{
		foreach (int skillId in new List<int>(this.SkillTriggerHandles.Keys))
		{
			this.UnregisterSkillTriggerById(skillId);
		}
		return true;
	}

	// Token: 0x0601B24E RID: 111182 RVA: 0x007622C0 File Offset: 0x007604C0
	public void RegisterSkillTriggersByIds(IReadOnlyList<int> skillIds)
	{
		foreach (int skillId in skillIds)
		{
			this.RegisterSkillTriggerById(skillId);
		}
	}

	// Token: 0x0601B24F RID: 111183 RVA: 0x00762308 File Offset: 0x00760508
	public void UnregisterSkillTriggersByIds(IReadOnlyList<int> skillIds)
	{
		foreach (int skillId in skillIds)
		{
			this.UnregisterSkillTriggerById(skillId);
		}
	}

	// Token: 0x0601B250 RID: 111184 RVA: 0x00762350 File Offset: 0x00760550
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

	// Token: 0x0601B251 RID: 111185 RVA: 0x00762394 File Offset: 0x00760594
	private void RegisterSkillTriggerById(int skillId)
	{
		if (this.SkillTriggerHandles.ContainsKey(skillId))
		{
			return;
		}
		SSkillInfo skillInfo = this.SkillComp.GetSkillInfo(skillId);
		if (skillInfo == null)
		{
			return;
		}
		List<int> list = this.AddSkillTrigger(skillId, skillInfo);
		if (list.Count > 0)
		{
			this.SkillTriggerHandles[skillId] = list;
		}
	}

	// Token: 0x0601B252 RID: 111186 RVA: 0x007623E8 File Offset: 0x007605E8
	private void UnregisterSkillTriggerById(int skillId)
	{
		List<int> list;
		if (!this.SkillTriggerHandles.TryGetValue(skillId, out list))
		{
			return;
		}
		foreach (int handle in list)
		{
			this.TriggerComp.RemoveTrigger(handle);
		}
		this.SkillTriggerHandles.Remove(skillId);
	}

	// Token: 0x0601B253 RID: 111187 RVA: 0x0076245C File Offset: 0x0076065C
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

	// Token: 0x0601B254 RID: 111188 RVA: 0x007626A0 File Offset: 0x007608A0
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterSkillTriggerComponent characterSkillTriggerComponent = (CharacterSkillTriggerComponent)componentTemplate;
		if (base.CanResetComponentProperty("SkillComp"))
		{
			if (characterSkillTriggerComponent.SkillComp == null)
			{
				this.SkillComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseSkillComponent>(this.SkillComp), "SkillComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TriggerComp"))
		{
			if (characterSkillTriggerComponent.TriggerComp == null)
			{
				this.TriggerComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterTriggerComponent>(this.TriggerComp), "TriggerComp"))
			{
				return false;
			}
		}
		return !base.CanResetComponentProperty("SkillTriggerHandles") || characterSkillTriggerComponent.SkillTriggerHandles == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, List<int>>>(this.SkillTriggerHandles), "SkillTriggerHandles");
	}

	// Token: 0x0400D328 RID: 54056
	[Nullable(2)]
	private BaseSkillComponent SkillComp;

	// Token: 0x0400D329 RID: 54057
	[Nullable(2)]
	private CharacterTriggerComponent TriggerComp;

	// Token: 0x0400D32A RID: 54058
	private readonly Dictionary<int, List<int>> SkillTriggerHandles = new Dictionary<int, List<int>>();
}
