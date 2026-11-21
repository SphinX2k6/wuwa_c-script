using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002498 RID: 9368
[NullableContext(1)]
[Nullable(0)]
public class AddPassiveSkill : BuffEffect
{
	// Token: 0x06017540 RID: 95552 RVA: 0x006DD387 File Offset: 0x006DB587
	public AddPassiveSkill(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06017541 RID: 95553 RVA: 0x006DD3AC File Offset: 0x006DB5AC
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null || extraEffectParameters_.Length == 0)
		{
			this.SkillIds = Array.Empty<long>();
			return;
		}
		string[] array = extraEffectParameters_[0].Split('#', StringSplitOptions.None);
		this.SkillIds = new long[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			this.SkillIds[i] = long.Parse(array[i]);
		}
	}

	// Token: 0x06017542 RID: 95554 RVA: 0x006DD40B File Offset: 0x006DB60B
	public override void OnCreated()
	{
		this.UpdateTeamListenAndApply(true);
	}

	// Token: 0x06017543 RID: 95555 RVA: 0x006DD414 File Offset: 0x006DB614
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06017544 RID: 95556 RVA: 0x006DD417 File Offset: 0x006DB617
	public override void OnRemoved(bool bPremature)
	{
		this.UpdateTeamListenAndApply(false);
	}

	// Token: 0x06017545 RID: 95557 RVA: 0x006DD420 File Offset: 0x006DB620
	private void UpdateTeamListenAndApply(bool learn)
	{
		Entity exactOwnerEntity = base.ExactOwnerEntity;
		BaseBuffComponent baseBuffComponent = (exactOwnerEntity != null) ? exactOwnerEntity.CheckGetComponent<BaseBuffComponent>() : null;
		if (baseBuffComponent != null && baseBuffComponent.IsTeamBuffComponent())
		{
			if (learn)
			{
				this.TeamCreatureDataIds = new List<long>();
				EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnChangeTeam));
				SceneTeamModel instance = SceneTeamModel.Instance;
				if (instance != null && instance.IsTeamReady)
				{
					this.OnChangeTeam();
					return;
				}
			}
			else
			{
				EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnChangeTeam));
				foreach (long creatureDataId in this.TeamCreatureDataIds)
				{
					this.ApplyPassiveSkillsByCreatureDataId(creatureDataId, false);
				}
				this.TeamCreatureDataIds = new List<long>();
			}
			return;
		}
		Entity exactOwnerEntity2 = base.ExactOwnerEntity;
		CharacterPassiveSkillComponent skillComp = (exactOwnerEntity2 != null) ? exactOwnerEntity2.CheckGetComponent<CharacterPassiveSkillComponent>() : null;
		this.ApplyPassiveSkills(skillComp, learn);
	}

	// Token: 0x06017546 RID: 95558 RVA: 0x006DD520 File Offset: 0x006DB720
	[NullableContext(2)]
	private void ApplyPassiveSkills(CharacterPassiveSkillComponent skillComp, bool learn)
	{
		if (skillComp == null || !skillComp.Valid)
		{
			return;
		}
		if (learn && base.Buff == null)
		{
			Log.Instance.Warn(ELogModule.BuffItem, ELogAuthor.GHY, "没有Buff不能加被动技能", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		foreach (long skillId in this.SkillIds)
		{
			if (learn)
			{
				skillComp.LearnPassiveSkill(skillId, new AddPassiveSkillParam
				{
					NeedBroadcast = new bool?(true),
					PreMessageId = base.Buff.MessageId,
					CombatMessageId = base.Buff.MessageId.Value
				});
			}
			else
			{
				skillComp.ForgetPassiveSkill(skillId, true);
			}
		}
	}

	// Token: 0x06017547 RID: 95559 RVA: 0x006DD5D4 File Offset: 0x006DB7D4
	private void OnChangeTeam()
	{
		SceneTeamModel instance = SceneTeamModel.Instance;
		List<EntityHandle> list = ((instance != null) ? instance.GetTeamEntities(false) : null) ?? new List<EntityHandle>();
		List<long> list2 = list.ConvertAll<long>((EntityHandle handle) => handle.CreatureDataId);
		foreach (EntityHandle entityHandle in list)
		{
			if (!this.TeamCreatureDataIds.Contains(entityHandle.CreatureDataId))
			{
				WorldEntity entity = entityHandle.Entity;
				CharacterPassiveSkillComponent skillComp = (entity != null) ? entity.CheckGetComponent<CharacterPassiveSkillComponent>() : null;
				this.ApplyPassiveSkills(skillComp, true);
			}
		}
		foreach (long num in this.TeamCreatureDataIds)
		{
			if (!list2.Contains(num))
			{
				this.ApplyPassiveSkillsByCreatureDataId(num, false);
			}
		}
		this.TeamCreatureDataIds = list2;
	}

	// Token: 0x06017548 RID: 95560 RVA: 0x006DD6E0 File Offset: 0x006DB8E0
	private void ApplyPassiveSkillsByCreatureDataId(long creatureDataId, bool learn)
	{
		CreatureModel instance = CreatureModel.Instance;
		object obj;
		if (instance == null)
		{
			obj = null;
		}
		else
		{
			EntityHandle entity = instance.GetEntity(creatureDataId);
			obj = ((entity != null) ? entity.Entity : null);
		}
		object obj2 = obj;
		CharacterPassiveSkillComponent skillComp = (obj2 != null) ? obj2.CheckGetComponent<CharacterPassiveSkillComponent>() : null;
		this.ApplyPassiveSkills(skillComp, learn);
	}

	// Token: 0x06017549 RID: 95561 RVA: 0x006DD720 File Offset: 0x006DB920
	public override string GetDebugEffectString()
	{
		Entity exactOwnerEntity = base.ExactOwnerEntity;
		BaseBuffComponent baseBuffComponent = (exactOwnerEntity != null) ? exactOwnerEntity.CheckGetComponent<BaseBuffComponent>() : null;
		return ((baseBuffComponent != null && baseBuffComponent.IsTeamBuffComponent()) ? "编队buff" : "非编队buff") + "添加被动技能" + string.Join<long>(",", this.SkillIds);
	}

	// Token: 0x0400C5D8 RID: 50648
	protected long[] SkillIds = Array.Empty<long>();

	// Token: 0x0400C5D9 RID: 50649
	private List<long> TeamCreatureDataIds = new List<long>();
}
