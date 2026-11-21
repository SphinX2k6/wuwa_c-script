using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020024BE RID: 9406
[NullableContext(1)]
[Nullable(0)]
public class ExtraEffectSkillLimitCount : BuffEffect
{
	// Token: 0x0601760D RID: 95757 RVA: 0x006E20B8 File Offset: 0x006E02B8
	public ExtraEffectSkillLimitCount(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x0601760E RID: 95758 RVA: 0x006E20D4 File Offset: 0x006E02D4
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		this.SkillInfoIds = ((extraEffectParameters_.Length != 0) ? extraEffectParameters_[0].Split('#', StringSplitOptions.None) : Array.Empty<string>());
		if (extraEffectParameters_.Length > 1)
		{
			string[] array = extraEffectParameters_[1].Split('#', StringSplitOptions.None);
			this.SkillLimitCounts = new int[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				this.SkillLimitCounts[i] = int.Parse(array[i]);
			}
		}
		else
		{
			this.SkillLimitCounts = Array.Empty<int>();
		}
		ETargetType etargetType = (ETargetType)((extraEffectParameters_.Length > 2) ? int.Parse(extraEffectParameters_[2]) : 0);
		if (etargetType != ETargetType.Owner)
		{
			if (etargetType != ETargetType.Instigator)
			{
			}
			this.TargetType = ETargetType.Instigator;
			return;
		}
		this.TargetType = ETargetType.Owner;
	}

	// Token: 0x0601760F RID: 95759 RVA: 0x006E217C File Offset: 0x006E037C
	public override void OnCreated()
	{
		BaseBuffComponent baseBuffComponent = this.GetEffectTarget().CheckGetComponent<BaseBuffComponent>();
		foreach (CharacterSkillCdComponent characterSkillCdComponent in (((baseBuffComponent != null) ? baseBuffComponent.GetTargetComponents<CharacterSkillCdComponent>(EComponent.CharacterSkillCdComponent, null) : null) ?? new List<CharacterSkillCdComponent>()))
		{
			string[] skillInfoIds = this.SkillInfoIds;
			int num = (skillInfoIds != null) ? skillInfoIds.Length : 0;
			int[] skillLimitCounts = this.SkillLimitCounts;
			int num2 = (skillLimitCounts != null) ? skillLimitCounts.Length : 0;
			int num3 = (num < num2) ? num : num2;
			for (int i = 0; i < num3; i++)
			{
				int skillId = int.Parse(this.SkillInfoIds[i]);
				characterSkillCdComponent.IsSkillInCd(skillId, true);
				characterSkillCdComponent.SetLimitCount(skillId, new int?(this.SkillLimitCounts[i]));
			}
		}
		if (baseBuffComponent != null && baseBuffComponent.IsTeamBuffComponent())
		{
			this.TeamEntityIds = BaseBuffComponent.GetCurrentEntityIds();
			EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnChangeTeam));
		}
	}

	// Token: 0x06017610 RID: 95760 RVA: 0x006E2298 File Offset: 0x006E0498
	public override void OnRemoved(bool bPremature)
	{
		BaseBuffComponent baseBuffComponent = this.GetEffectTarget().CheckGetComponent<BaseBuffComponent>();
		foreach (CharacterSkillCdComponent characterSkillCdComponent in (((baseBuffComponent != null) ? baseBuffComponent.GetTargetComponents<CharacterSkillCdComponent>(EComponent.CharacterSkillCdComponent, null) : null) ?? new List<CharacterSkillCdComponent>()))
		{
			if (this.SkillInfoIds != null)
			{
				string[] skillInfoIds = this.SkillInfoIds;
				for (int i = 0; i < skillInfoIds.Length; i++)
				{
					int skillId = int.Parse(skillInfoIds[i]);
					characterSkillCdComponent.IsSkillInCd(skillId, true);
					characterSkillCdComponent.SetLimitCount(skillId, null);
				}
			}
		}
		if (baseBuffComponent != null && baseBuffComponent.IsTeamBuffComponent())
		{
			EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnChangeTeam));
		}
	}

	// Token: 0x06017611 RID: 95761 RVA: 0x006E2380 File Offset: 0x006E0580
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06017612 RID: 95762 RVA: 0x006E2384 File Offset: 0x006E0584
	private Entity GetEffectTarget()
	{
		ETargetType targetType = this.TargetType;
		if (targetType != ETargetType.Owner)
		{
			if (targetType != ETargetType.Instigator)
			{
			}
			return base.InstigatorEntity.Entity;
		}
		return base.ExactOwnerEntity;
	}

	// Token: 0x06017613 RID: 95763 RVA: 0x006E23B4 File Offset: 0x006E05B4
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
			string[] skillInfoIds = this.SkillInfoIds;
			int num = (skillInfoIds != null) ? skillInfoIds.Length : 0;
			int[] skillLimitCounts = this.SkillLimitCounts;
			int num2 = (skillLimitCounts != null) ? skillLimitCounts.Length : 0;
			int num3 = (num < num2) ? num : num2;
			for (int i = 0; i < num3; i++)
			{
				int skillId = int.Parse(this.SkillInfoIds[i]);
				if (characterSkillCdComponent2 != null)
				{
					characterSkillCdComponent2.IsSkillInCd(skillId, true);
				}
				if (characterSkillCdComponent2 != null)
				{
					characterSkillCdComponent2.SetLimitCount(skillId, new int?(this.SkillLimitCounts[i]));
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
			if (this.SkillInfoIds != null)
			{
				string[] skillInfoIds2 = this.SkillInfoIds;
				for (int j = 0; j < skillInfoIds2.Length; j++)
				{
					int skillId2 = int.Parse(skillInfoIds2[j]);
					if (characterSkillCdComponent4 != null)
					{
						characterSkillCdComponent4.IsSkillInCd(skillId2, true);
					}
					if (characterSkillCdComponent4 != null)
					{
						characterSkillCdComponent4.SetLimitCount(skillId2, null);
					}
				}
			}
		}
		this.TeamEntityIds = BaseBuffComponent.GetCurrentEntityIds();
	}

	// Token: 0x0400C666 RID: 50790
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private string[] SkillInfoIds;

	// Token: 0x0400C667 RID: 50791
	[Nullable(2)]
	private int[] SkillLimitCounts;

	// Token: 0x0400C668 RID: 50792
	private ETargetType TargetType;

	// Token: 0x0400C669 RID: 50793
	private List<int> TeamEntityIds = new List<int>();
}
