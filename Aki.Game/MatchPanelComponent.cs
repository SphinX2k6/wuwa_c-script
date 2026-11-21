using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Module.InstanceDungeon;

// Token: 0x02001095 RID: 4245
[NullableContext(1)]
[Nullable(0)]
public class MatchPanelComponent
{
	// Token: 0x0600A882 RID: 43138 RVA: 0x003194AB File Offset: 0x003176AB
	public MatchPanelComponent(Func<List<FormationRoleSlot>> getRoleSlots)
	{
		this.GetRoleSlots = getRoleSlots;
	}

	// Token: 0x0600A883 RID: 43139 RVA: 0x003194BC File Offset: 0x003176BC
	public void Refresh(bool isMatching)
	{
		List<FormationRoleSlot> list = this.GetRoleSlots();
		if (!isMatching)
		{
			foreach (FormationRoleSlot formationRoleSlot in list)
			{
				formationRoleSlot.IsDragDisabled = false;
				formationRoleSlot.SetMatchState(false);
			}
			return;
		}
		foreach (FormationRoleSlot formationRoleSlot2 in list)
		{
			formationRoleSlot2.IsDragDisabled = true;
		}
		BattleTeamModel instance = BattleTeamModel.Instance;
		List<BattleRoleSlotData> allSlots = instance.GetAllSlots();
		List<FormationRoleSlot> list2 = new List<FormationRoleSlot>();
		int? leaderPlayerId = instance.LeaderPlayerId;
		bool flag = false;
		for (int i = 1; i <= 4; i++)
		{
			BattleRoleSlotData battleRoleSlotData = (i - 1 < allSlots.Count) ? allSlots[i - 1] : null;
			FormationRoleSlot formationRoleSlot3 = (i - 1 < list.Count) ? list[i - 1] : null;
			if (battleRoleSlotData != null && formationRoleSlot3 != null)
			{
				BattleRoleData roleData = battleRoleSlotData.RoleData;
				if (roleData == null)
				{
					list2.Add(formationRoleSlot3);
				}
				else
				{
					int playerId = roleData.PlayerId;
					int? num = leaderPlayerId;
					if (playerId == num.GetValueOrDefault() & num != null)
					{
						if (flag)
						{
							list2.Add(formationRoleSlot3);
						}
						else
						{
							flag = true;
						}
					}
				}
			}
		}
		int needMatchSize = InstanceDungeonModel.Instance.GetNeedMatchSize();
		InstanceDungeonEntranceModel entranceModel = InstanceDungeonEntranceModel.Instance;
		int matchingTime = entranceModel.MatchingTime;
		HashSet<FormationRoleSlot> hashSet = new HashSet<FormationRoleSlot>();
		for (int j = 0; j < needMatchSize; j++)
		{
			if (list2.Count != 0)
			{
				FormationRoleSlot formationRoleSlot4 = list2[list2.Count - 1];
				list2.RemoveAt(list2.Count - 1);
				hashSet.Add(formationRoleSlot4);
				formationRoleSlot4.SetMatchTime(matchingTime);
			}
		}
		foreach (FormationRoleSlot formationRoleSlot5 in list)
		{
			formationRoleSlot5.SetMatchState(hashSet.Contains(formationRoleSlot5));
		}
		entranceModel.MatchingTime = 0;
		entranceModel.OnStopTimer = (() => !entranceModel.EditBattleTeamMatching);
		InstanceDungeonEntranceController.Instance.StartMatchTimer(new Action(this.MatchHandle));
	}

	// Token: 0x0600A884 RID: 43140 RVA: 0x00319710 File Offset: 0x00317910
	private void MatchHandle()
	{
		int matchingTime = InstanceDungeonEntranceModel.Instance.MatchingTime;
		foreach (FormationRoleSlot formationRoleSlot in this.GetRoleSlots())
		{
			formationRoleSlot.SetMatchTime(matchingTime);
		}
	}

	// Token: 0x040061E2 RID: 25058
	private readonly Func<List<FormationRoleSlot>> GetRoleSlots;
}
