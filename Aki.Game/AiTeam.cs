using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02000100 RID: 256
[NullableContext(1)]
[Nullable(0)]
public class AiTeam
{
	// Token: 0x06000EF6 RID: 3830 RVA: 0x00057C58 File Offset: 0x00055E58
	private void OnChangeRole(EntityHandle newEntityHandle, [Nullable(2)] EntityHandle oldEntityHandle)
	{
		if (oldEntityHandle == null)
		{
			return;
		}
		AiScheduleGroup aiScheduleGroup;
		if (this.TeamScheduleGroups.TryGetValue(oldEntityHandle, out aiScheduleGroup))
		{
			this.TeamScheduleGroups.Remove(oldEntityHandle);
			this.TeamScheduleGroups[newEntityHandle] = aiScheduleGroup;
			aiScheduleGroup.Target = newEntityHandle;
		}
	}

	// Token: 0x06000EF7 RID: 3831 RVA: 0x00057C9C File Offset: 0x00055E9C
	public void Init(int levelId)
	{
		AiConfig.Instance.LoadAiTeamConfigNew(this, levelId);
		EventSystem.Instance.Add(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		foreach (AiTeamAreaNew aiTeamAreaNew in this.AiTeamAreas)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			this.AreaCharTypeToPriority.Add(dictionary);
			int num = 0;
			foreach (int key in aiTeamAreaNew.CharTypes())
			{
				num = (dictionary[key] = num + 1);
			}
		}
	}

	// Token: 0x06000EF8 RID: 3832 RVA: 0x00057D58 File Offset: 0x00055F58
	public void Clear()
	{
		this.TeamMemberToGroup.Clear();
		this.TeamScheduleGroups.Clear();
		EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
	}

	// Token: 0x06000EF9 RID: 3833 RVA: 0x00057D8C File Offset: 0x00055F8C
	public void AddMember(AiController aiController)
	{
		this.TeamMemberToGroup[aiController] = null;
	}

	// Token: 0x06000EFA RID: 3834 RVA: 0x00057D9C File Offset: 0x00055F9C
	public void RemoveMember(AiController ai)
	{
		if (!this.TeamMemberToGroup.Remove(ai))
		{
			return;
		}
		foreach (KeyValuePair<EntityHandle, AiScheduleGroup> keyValuePair in this.TeamScheduleGroups)
		{
			keyValuePair.Value.Remove(ai);
		}
	}

	// Token: 0x06000EFB RID: 3835 RVA: 0x00057E08 File Offset: 0x00056008
	public void Tick()
	{
		this.ReorganizeGroup();
		foreach (KeyValuePair<EntityHandle, AiScheduleGroup> keyValuePair in this.TeamScheduleGroups)
		{
			keyValuePair.Value.ScheduleGroup();
		}
	}

	// Token: 0x06000EFC RID: 3836 RVA: 0x00057E68 File Offset: 0x00056068
	private void ReorganizeGroup()
	{
		foreach (KeyValuePair<EntityHandle, AiScheduleGroup> keyValuePair in this.TeamScheduleGroups)
		{
			keyValuePair.Value.CheckTargetAndRemove();
		}
		foreach (KeyValuePair<AiController, AiScheduleGroup> keyValuePair2 in this.TeamMemberToGroup)
		{
			AiController key = keyValuePair2.Key;
			EntityHandle currentTarget = key.AiHateList.GetCurrentTarget();
			if (currentTarget == null || !currentTarget.Valid)
			{
				this.TeamMemberToGroup[key] = null;
			}
			else
			{
				WorldEntity entity = currentTarget.Entity;
				BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
				if (baseActorComponent != null)
				{
					if (baseActorComponent.CreatureData.GetEntityType() != EEntityType.Player)
					{
						BlackboardController.Instance.SetBooleanValueByEntity(key.CharAiDesignComp.Entity.Id, "TeamAttacker", true);
						this.TeamMemberToGroup[key] = null;
					}
					else
					{
						AiScheduleGroup aiScheduleGroup;
						if (!this.TeamScheduleGroups.TryGetValue(currentTarget, out aiScheduleGroup))
						{
							aiScheduleGroup = new AiScheduleGroup(this, currentTarget);
							this.TeamScheduleGroups[currentTarget] = aiScheduleGroup;
						}
						aiScheduleGroup.TryAdd(key);
						this.TeamMemberToGroup[key] = aiScheduleGroup;
					}
				}
			}
		}
		List<EntityHandle> list = new List<EntityHandle>();
		foreach (KeyValuePair<EntityHandle, AiScheduleGroup> keyValuePair3 in this.TeamScheduleGroups)
		{
			if (keyValuePair3.Value.IsEmpty())
			{
				list.Add(keyValuePair3.Key);
			}
		}
		foreach (EntityHandle key2 in list)
		{
			this.TeamScheduleGroups.Remove(key2);
		}
	}

	// Token: 0x06000EFD RID: 3837 RVA: 0x00058080 File Offset: 0x00056280
	[return: Nullable(2)]
	public AiAreaMemberData GetAiTeamAreaMemberData(AiController ai)
	{
		AiScheduleGroup aiScheduleGroup;
		this.TeamMemberToGroup.TryGetValue(ai, out aiScheduleGroup);
		if (aiScheduleGroup == null)
		{
			return null;
		}
		return aiScheduleGroup.GetMemberData(ai);
	}

	// Token: 0x04000BEF RID: 3055
	public int TeamId;

	// Token: 0x04000BF0 RID: 3056
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	public readonly Dictionary<AiController, AiScheduleGroup> TeamMemberToGroup = new Dictionary<AiController, AiScheduleGroup>();

	// Token: 0x04000BF1 RID: 3057
	public AiTeamLevelNew? AiTeamLevel;

	// Token: 0x04000BF2 RID: 3058
	[Nullable(2)]
	public List<AiTeamAreaNew> AiTeamAreas;

	// Token: 0x04000BF3 RID: 3059
	[Nullable(2)]
	public List<AiTeamAttack> AiTeamAttacks;

	// Token: 0x04000BF4 RID: 3060
	public readonly List<Dictionary<int, int>> AreaCharTypeToPriority = new List<Dictionary<int, int>>();

	// Token: 0x04000BF5 RID: 3061
	private readonly Dictionary<EntityHandle, AiScheduleGroup> TeamScheduleGroups = new Dictionary<EntityHandle, AiScheduleGroup>();
}
