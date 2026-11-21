using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02001EC7 RID: 7879
[NullableContext(1)]
[Nullable(0)]
public class SceneTeamGroup
{
	// Token: 0x0601379E RID: 79774 RVA: 0x005AE8FE File Offset: 0x005ACAFE
	public static SceneTeamGroup Create(int playerId, ETeamGroupType type)
	{
		return new SceneTeamGroup
		{
			PlayerId = playerId,
			GroupType = type
		};
	}

	// Token: 0x0601379F RID: 79775 RVA: 0x005AE913 File Offset: 0x005ACB13
	public void Clear()
	{
		this.GroupType = ETeamGroupType.Default;
		this.RoleList.Clear();
		this.LivingState = ETeamLivingState.Unknown;
		this.CurrentRole = null;
	}

	// Token: 0x060137A0 RID: 79776 RVA: 0x005AE935 File Offset: 0x005ACB35
	public ETeamGroupType GetGroupType()
	{
		return this.GroupType;
	}

	// Token: 0x060137A1 RID: 79777 RVA: 0x005AE940 File Offset: 0x005ACB40
	public List<SceneTeamRole> GetRoleList()
	{
		List<SceneTeamRole> list = new List<SceneTeamRole>();
		foreach (SceneTeamRole item in this.RoleList)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x060137A2 RID: 79778 RVA: 0x005AE99C File Offset: 0x005ACB9C
	[NullableContext(2)]
	public SceneTeamRole GetCurrentRole()
	{
		return this.CurrentRole;
	}

	// Token: 0x060137A3 RID: 79779 RVA: 0x005AE9A4 File Offset: 0x005ACBA4
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

	// Token: 0x060137A4 RID: 79780 RVA: 0x005AEA00 File Offset: 0x005ACC00
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

	// Token: 0x060137A5 RID: 79781 RVA: 0x005AEA5C File Offset: 0x005ACC5C
	public ETeamLivingState GetLivingState()
	{
		return this.LivingState;
	}

	// Token: 0x060137A6 RID: 79782 RVA: 0x005AEA64 File Offset: 0x005ACC64
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

	// Token: 0x060137A7 RID: 79783 RVA: 0x005AEAB0 File Offset: 0x005ACCB0
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

	// Token: 0x060137A8 RID: 79784 RVA: 0x005AEB38 File Offset: 0x005ACD38
	public void AddRoleList(SceneTeamRole[] groupRoleList)
	{
		foreach (SceneTeamRole item in groupRoleList)
		{
			this.RoleList.Add(item);
		}
	}

	// Token: 0x0400A673 RID: 42611
	private int PlayerId;

	// Token: 0x0400A674 RID: 42612
	private ETeamGroupType GroupType;

	// Token: 0x0400A675 RID: 42613
	private readonly List<SceneTeamRole> RoleList = new List<SceneTeamRole>();

	// Token: 0x0400A676 RID: 42614
	[Nullable(2)]
	private SceneTeamRole CurrentRole;

	// Token: 0x0400A677 RID: 42615
	public bool IsFixedLocation;

	// Token: 0x0400A678 RID: 42616
	private ETeamLivingState LivingState;
}
