using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x0200244A RID: 9290
[NullableContext(1)]
[Nullable(0)]
public class ExtraEffectAddSkillLimitCount : BuffEffect
{
	// Token: 0x06017400 RID: 95232 RVA: 0x006D58AF File Offset: 0x006D3AAF
	public ExtraEffectAddSkillLimitCount(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06017401 RID: 95233 RVA: 0x006D58CC File Offset: 0x006D3ACC
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		this.SkillInfoIds = extraEffectParameters_[0].Split('#', StringSplitOptions.None);
		string[] array = extraEffectParameters_[1].Split('#', StringSplitOptions.None);
		this.SkillLimitCounts = new int[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			this.SkillLimitCounts[i] = int.Parse(array[i]);
		}
		ExtraEffectAddSkillLimitCount.ETargetType etargetType = (ExtraEffectAddSkillLimitCount.ETargetType)((extraEffectParameters_.Length > 2) ? int.Parse(extraEffectParameters_[2]) : 0);
		if (etargetType != ExtraEffectAddSkillLimitCount.ETargetType.Owner)
		{
			if (etargetType != ExtraEffectAddSkillLimitCount.ETargetType.Instigator)
			{
			}
			this.TargetType = ExtraEffectAddSkillLimitCount.ETargetType.Instigator;
			return;
		}
		this.TargetType = ExtraEffectAddSkillLimitCount.ETargetType.Owner;
	}

	// Token: 0x06017402 RID: 95234 RVA: 0x006D5954 File Offset: 0x006D3B54
	public override void OnCreated()
	{
		BaseBuffComponent component = this.GetEffectTarget().GetComponent<BaseBuffComponent>();
		foreach (CharacterSkillCdComponent characterSkillCdComponent in (((component != null) ? component.GetTargetComponents<CharacterSkillCdComponent>(EComponent.CharacterSkillCdComponent, null) : null) ?? new List<CharacterSkillCdComponent>()))
		{
			int num = this.SkillInfoIds.Length;
			if (this.SkillLimitCounts.Length < num)
			{
				num = this.SkillLimitCounts.Length;
			}
			for (int i = 0; i < num; i++)
			{
				int skillId = int.Parse(this.SkillInfoIds[i]);
				characterSkillCdComponent.AddLimitCount(skillId, this.SkillLimitCounts[i]);
			}
		}
		if (component != null && component.IsTeamBuffComponent())
		{
			this.TeamEntityIds = BaseBuffComponent.GetCurrentEntityIds();
			EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnChangeTeam));
		}
	}

	// Token: 0x06017403 RID: 95235 RVA: 0x006D5A50 File Offset: 0x006D3C50
	public override void OnRemoved(bool bPremature)
	{
		BaseBuffComponent component = this.GetEffectTarget().GetComponent<BaseBuffComponent>();
		foreach (CharacterSkillCdComponent characterSkillCdComponent in (((component != null) ? component.GetTargetComponents<CharacterSkillCdComponent>(EComponent.CharacterSkillCdComponent, null) : null) ?? new List<CharacterSkillCdComponent>()))
		{
			int num = this.SkillInfoIds.Length;
			if (this.SkillLimitCounts.Length < num)
			{
				num = this.SkillLimitCounts.Length;
			}
			for (int i = 0; i < num; i++)
			{
				int skillId = int.Parse(this.SkillInfoIds[i]);
				characterSkillCdComponent.AddLimitCount(skillId, -this.SkillLimitCounts[i]);
			}
		}
		if (component != null && component.IsTeamBuffComponent())
		{
			EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnChangeTeam));
		}
	}

	// Token: 0x06017404 RID: 95236 RVA: 0x006D5B40 File Offset: 0x006D3D40
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06017405 RID: 95237 RVA: 0x006D5B44 File Offset: 0x006D3D44
	private Entity GetEffectTarget()
	{
		ExtraEffectAddSkillLimitCount.ETargetType targetType = this.TargetType;
		if (targetType != ExtraEffectAddSkillLimitCount.ETargetType.Owner)
		{
			if (targetType != ExtraEffectAddSkillLimitCount.ETargetType.Instigator)
			{
			}
			return base.InstigatorEntity.Entity;
		}
		return base.ExactOwnerEntity;
	}

	// Token: 0x06017406 RID: 95238 RVA: 0x006D5B74 File Offset: 0x006D3D74
	private void OnChangeTeam()
	{
		foreach (int id in BaseBuffComponent.GetNewOrRemoveTeamEntityIds(this.TeamEntityIds, true))
		{
			CharacterModel instance = CharacterModel.Instance;
			CharacterSkillCdComponent characterSkillCdComponent;
			if (instance == null)
			{
				characterSkillCdComponent = null;
			}
			else
			{
				EntityHandle handle = instance.GetHandle(id);
				if (handle == null)
				{
					characterSkillCdComponent = null;
				}
				else
				{
					WorldEntity entity = handle.Entity;
					characterSkillCdComponent = ((entity != null) ? entity.CheckGetComponent<CharacterSkillCdComponent>() : null);
				}
			}
			CharacterSkillCdComponent characterSkillCdComponent2 = characterSkillCdComponent;
			int num = this.SkillInfoIds.Length;
			if (this.SkillLimitCounts.Length < num)
			{
				num = this.SkillLimitCounts.Length;
			}
			for (int i = 0; i < num; i++)
			{
				int skillId = int.Parse(this.SkillInfoIds[i]);
				if (characterSkillCdComponent2 != null)
				{
					characterSkillCdComponent2.AddLimitCount(skillId, this.SkillLimitCounts[i]);
				}
			}
		}
		foreach (int id2 in BaseBuffComponent.GetNewOrRemoveTeamEntityIds(this.TeamEntityIds, false))
		{
			CharacterModel instance2 = CharacterModel.Instance;
			CharacterSkillCdComponent characterSkillCdComponent3;
			if (instance2 == null)
			{
				characterSkillCdComponent3 = null;
			}
			else
			{
				EntityHandle handle2 = instance2.GetHandle(id2);
				if (handle2 == null)
				{
					characterSkillCdComponent3 = null;
				}
				else
				{
					WorldEntity entity2 = handle2.Entity;
					characterSkillCdComponent3 = ((entity2 != null) ? entity2.CheckGetComponent<CharacterSkillCdComponent>() : null);
				}
			}
			CharacterSkillCdComponent characterSkillCdComponent4 = characterSkillCdComponent3;
			int num2 = this.SkillInfoIds.Length;
			if (this.SkillLimitCounts.Length < num2)
			{
				num2 = this.SkillLimitCounts.Length;
			}
			for (int j = 0; j < num2; j++)
			{
				int skillId2 = int.Parse(this.SkillInfoIds[j]);
				if (characterSkillCdComponent4 != null)
				{
					characterSkillCdComponent4.AddLimitCount(skillId2, -this.SkillLimitCounts[j]);
				}
			}
		}
		this.TeamEntityIds = BaseBuffComponent.GetCurrentEntityIds();
	}

	// Token: 0x0400C453 RID: 50259
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private string[] SkillInfoIds;

	// Token: 0x0400C454 RID: 50260
	[Nullable(2)]
	private int[] SkillLimitCounts;

	// Token: 0x0400C455 RID: 50261
	private ExtraEffectAddSkillLimitCount.ETargetType TargetType;

	// Token: 0x0400C456 RID: 50262
	private List<int> TeamEntityIds = new List<int>();

	// Token: 0x02008821 RID: 34849
	[NullableContext(0)]
	public enum ETargetType
	{
		// Token: 0x0402B8D8 RID: 178392
		Owner,
		// Token: 0x0402B8D9 RID: 178393
		Instigator
	}
}
