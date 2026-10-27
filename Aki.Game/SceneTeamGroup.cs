using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x0200294C RID: 10572
[NullableContext(1)]
[Nullable(0)]
public class SceneTeamGroup
{
	// Token: 0x06015D9A RID: 89498 RVA: 0x005838FE File Offset: 0x00581AFE
	public static SceneTeamGroup Create(int playerId, ETeamGroupType type)
	{
		return new SceneTeamGroup
		{
			PlayerId = playerId,
			GroupType = type
		};
	}

	// Token: 0x06015D9B RID: 89499 RVA: 0x00583913 File Offset: 0x00581B13
	public void Clear()
	{
		this.GroupType = ETeamGroupType.Default;
		this.RoleList.Clear();
		this.LivingState = ETeamLivingState.Unknown;
		this.CurrentRole = null;
	}

	// Token: 0x06015D9C RID: 89500 RVA: 0x00583935 File Offset: 0x00581B35
	public ETeamGroupType GetGroupType()
	{
		return this.GroupType;
	}

	// Token: 0x06015D9D RID: 89501 RVA: 0x00583940 File Offset: 0x00581B40
	public List<SceneTeamRole> GetRoleList()
	{
		List<SceneTeamRole> list = new List<SceneTeamRole>();
		foreach (SceneTeamRole item in this.RoleList)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x06015D9E RID: 89502 RVA: 0x0058399C File Offset: 0x00581B9C
	[NullableContext(2)]
	public SceneTeamRole GetCurrentRole()
	{
		return this.CurrentRole;
	}

	// Token: 0x06015D9F RID: 89503 RVA: 0x005839A4 File Offset: 0x00581BA4
	public bool HasRole(long creatureDataId)
	{
		using (List<SceneTeamRole>.Enumerator enumerator = this.RoleList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.CreatureDataId == creatureDataId)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06015DA0 RID: 89504 RVA: 0x00583A00 File Offset: 0x00581C00
	public void SetCurrentRole(long creatureDataId)
	{
		foreach (SceneTeamRole sceneTeamRole in this.RoleList)
		{
			if (sceneTeamRole.CreatureDataId == creatureDataId)
			{
				this.CurrentRole = sceneTeamRole;
			}
		}
	}

	// Token: 0x06015DA1 RID: 89505 RVA: 0x00583A5C File Offset: 0x00581C5C
	public ETeamLivingState GetLivingState()
	{
		return this.LivingState;
	}

	// Token: 0x06015DA2 RID: 89506 RVA: 0x00583A64 File Offset: 0x00581C64
	public void UpdateLivingState(ETeamLivingState state)
	{
		ETeamLivingState livingState = this.LivingState;
		this.LivingState = state;
		if (livingState != state)
		{
			bool p = this.PlayerId == CreatureModel.Instance.GetPlayerId();
			EventSystem.Instance.Emit<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(EEventName.OnTeamLivingStateChange, p, this.GroupType, state, livingState);
		}
	}

	// Token: 0x06015DA3 RID: 89507 RVA: 0x00583AB0 File Offset: 0x00581CB0
	public void Update(IList<SceneTeamRole> groupRoleList, int currentRoleId, ETeamLivingState livingState, bool isFixedLocation)
	{
		this.RoleList.Clear();
		this.CurrentRole = null;
		this.UpdateLivingState(livingState);
		if (groupRoleList.Count <= 0)
		{
			return;
		}
		this.IsFixedLocation = isFixedLocation;
		foreach (SceneTeamRole sceneTeamRole in groupRoleList)
		{
			this.RoleList.Add(sceneTeamRole);
			if (sceneTeamRole.RoleId == currentRoleId)
			{
				this.CurrentRole = sceneTeamRole;
			}
		}
	}

	// Token: 0x06015DA4 RID: 89508 RVA: 0x00583B38 File Offset: 0x00581D38
	public void AddRoleList(SceneTeamRole[] groupRoleList)
	{
		foreach (SceneTeamRole item in groupRoleList)
		{
			this.RoleList.Add(item);
		}
	}

	// Token: 0x0400A289 RID: 41609
	private int PlayerId;

	// Token: 0x0400A28A RID: 41610
	private ETeamGroupType GroupType;

	// Token: 0x0400A28B RID: 41611
	private readonly List<SceneTeamRole> RoleList = new List<SceneTeamRole>();

	// Token: 0x0400A28C RID: 41612
	[Nullable(2)]
	private SceneTeamRole CurrentRole;

	// Token: 0x0400A28D RID: 41613
	public bool IsFixedLocation;

	// Token: 0x0400A28E RID: 41614
	private ETeamLivingState LivingState;
}
