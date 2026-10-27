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
	// Token: 0x06000EF0 RID: 3824 RVA: 0x00056D88 File Offset: 0x00054F88
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

	// Token: 0x06000EF1 RID: 3825 RVA: 0x00056DCC File Offset: 0x00054FCC
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

	// Token: 0x06000EF2 RID: 3826 RVA: 0x00056E88 File Offset: 0x00055088
	public void Clear()
	{
		this.TeamMemberToGroup.Clear();
		this.TeamScheduleGroups.Clear();
		EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
	}

	// Token: 0x06000EF3 RID: 3827 RVA: 0x00056EBC File Offset: 0x000550BC
	public void AddMember(AiController aiController)
	{
		this.TeamMemberToGroup[aiController] = null;
	}

	// Token: 0x06000EF4 RID: 3828 RVA: 0x00056ECC File Offset: 0x000550CC
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

	// Token: 0x06000EF5 RID: 3829 RVA: 0x00056F38 File Offset: 0x00055138
	public void Tick()
	{
		this.ReorganizeGroup();
		foreach (KeyValuePair<EntityHandle, AiScheduleGroup> keyValuePair in this.TeamScheduleGroups)
		{
			keyValuePair.Value.ScheduleGroup();
		}
	}

	// Token: 0x06000EF6 RID: 3830 RVA: 0x00056F98 File Offset: 0x00055198
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

	// Token: 0x06000EF7 RID: 3831 RVA: 0x000571B0 File Offset: 0x000553B0
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

	// Token: 0x04000BE7 RID: 3047
	public int TeamId;

	// Token: 0x04000BE8 RID: 3048
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	public readonly Dictionary<AiController, AiScheduleGroup> TeamMemberToGroup = new Dictionary<AiController, AiScheduleGroup>();

	// Token: 0x04000BE9 RID: 3049
	public AiTeamLevelNew? AiTeamLevel;

	// Token: 0x04000BEA RID: 3050
	[Nullable(2)]
	public List<AiTeamAreaNew> AiTeamAreas;

	// Token: 0x04000BEB RID: 3051
	[Nullable(2)]
	public List<AiTeamAttack> AiTeamAttacks;

	// Token: 0x04000BEC RID: 3052
	public readonly List<Dictionary<int, int>> AreaCharTypeToPriority = new List<Dictionary<int, int>>();

	// Token: 0x04000BED RID: 3053
	private readonly Dictionary<EntityHandle, AiScheduleGroup> TeamScheduleGroups = new Dictionary<EntityHandle, AiScheduleGroup>();
}
