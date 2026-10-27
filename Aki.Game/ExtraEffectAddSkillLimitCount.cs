using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002EF7 RID: 12023
[NullableContext(1)]
[Nullable(0)]
public class ExtraEffectAddSkillLimitCount : BuffEffect
{
	// Token: 0x06019AF5 RID: 105205 RVA: 0x006AF5BB File Offset: 0x006AD7BB
	public ExtraEffectAddSkillLimitCount(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019AF6 RID: 105206 RVA: 0x006AF5D8 File Offset: 0x006AD7D8
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

	// Token: 0x06019AF7 RID: 105207 RVA: 0x006AF660 File Offset: 0x006AD860
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

	// Token: 0x06019AF8 RID: 105208 RVA: 0x006AF75C File Offset: 0x006AD95C
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

	// Token: 0x06019AF9 RID: 105209 RVA: 0x006AF84C File Offset: 0x006ADA4C
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019AFA RID: 105210 RVA: 0x006AF850 File Offset: 0x006ADA50
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

	// Token: 0x06019AFB RID: 105211 RVA: 0x006AF880 File Offset: 0x006ADA80
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

	// Token: 0x0400C0B2 RID: 49330
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private string[] SkillInfoIds;

	// Token: 0x0400C0B3 RID: 49331
	[Nullable(2)]
	private int[] SkillLimitCounts;

	// Token: 0x0400C0B4 RID: 49332
	private ExtraEffectAddSkillLimitCount.ETargetType TargetType;

	// Token: 0x0400C0B5 RID: 49333
	private List<int> TeamEntityIds = new List<int>();

	// Token: 0x020095FC RID: 38396
	[NullableContext(0)]
	public enum ETargetType
	{
		// Token: 0x04030243 RID: 197187
		Owner,
		// Token: 0x04030244 RID: 197188
		Instigator
	}
}
