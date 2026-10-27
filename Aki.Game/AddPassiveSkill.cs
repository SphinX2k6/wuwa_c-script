using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002F45 RID: 12101
[NullableContext(1)]
[Nullable(0)]
public class AddPassiveSkill : BuffEffect
{
	// Token: 0x06019C35 RID: 105525 RVA: 0x006B7063 File Offset: 0x006B5263
	public AddPassiveSkill(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019C36 RID: 105526 RVA: 0x006B7088 File Offset: 0x006B5288
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

	// Token: 0x06019C37 RID: 105527 RVA: 0x006B70E7 File Offset: 0x006B52E7
	public override void OnCreated()
	{
		this.UpdateTeamListenAndApply(true);
	}

	// Token: 0x06019C38 RID: 105528 RVA: 0x006B70F0 File Offset: 0x006B52F0
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019C39 RID: 105529 RVA: 0x006B70F3 File Offset: 0x006B52F3
	public override void OnRemoved(bool bPremature)
	{
		this.UpdateTeamListenAndApply(false);
	}

	// Token: 0x06019C3A RID: 105530 RVA: 0x006B70FC File Offset: 0x006B52FC
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

	// Token: 0x06019C3B RID: 105531 RVA: 0x006B71FC File Offset: 0x006B53FC
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

	// Token: 0x06019C3C RID: 105532 RVA: 0x006B72B0 File Offset: 0x006B54B0
	private void OnChangeTeam()
	{
		SceneTeamModel instance = SceneTeamModel.Instance;
		List<EntityHandle> list = ((instance != null) ? instance.GetTeamEntities(false) : null) ?? new List<EntityHandle>();
		List<long> list2 = (from handle in list
		select handle.CreatureDataId).ToList<long>();
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

	// Token: 0x06019C3D RID: 105533 RVA: 0x006B73C4 File Offset: 0x006B55C4
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

	// Token: 0x06019C3E RID: 105534 RVA: 0x006B7404 File Offset: 0x006B5604
	public override string GetDebugEffectString()
	{
		Entity exactOwnerEntity = base.ExactOwnerEntity;
		BaseBuffComponent baseBuffComponent = (exactOwnerEntity != null) ? exactOwnerEntity.CheckGetComponent<BaseBuffComponent>() : null;
		return ((baseBuffComponent != null && baseBuffComponent.IsTeamBuffComponent()) ? "编队buff" : "非编队buff") + "添加被动技能" + string.Join<long>(",", this.SkillIds);
	}

	// Token: 0x0400C236 RID: 49718
	protected long[] SkillIds = Array.Empty<long>();

	// Token: 0x0400C237 RID: 49719
	private List<long> TeamCreatureDataIds = new List<long>();
}
