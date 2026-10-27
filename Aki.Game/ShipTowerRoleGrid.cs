using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x020029CB RID: 10699
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerRoleGrid : LoopScrollMediumItemGrid<RoleDataBase>
{
	// Token: 0x060162CD RID: 90829 RVA: 0x0059BBC4 File Offset: 0x00599DC4
	protected override void OnRefresh(RoleDataBase data, bool isSelected, int gridIndex)
	{
		RoleLevelData levelData = data.GetLevelData();
		int dataId = data.GetDataId();
		int roleSkillBranchIndexInCurrentGamePlay = RoleModel.Instance.GetRoleSkillBranchIndexInCurrentGamePlay(dataId);
		CharacterMediumItemGrid parameters = new CharacterMediumItemGrid
		{
			ItemConfigId = new int?(dataId),
			SkinId = data.GetRoleSkinId(),
			IsTrialRoleVisible = new bool?(data.IsTrialRole()),
			BottomTextId = "Text_LevelShow_Text",
			BottomTextParameter = new object[]
			{
				levelData.GetLevel()
			},
			ElementId = new int?(data.GetRoleConfig().ElementId),
			Data = data,
			IsRecommendVisible = new bool?(false),
			HalfAreaInfo = ShipTowerModel.Instance.GetAllTeamRoleData(dataId),
			SkillBranchIndex = ((roleSkillBranchIndexInCurrentGamePlay >= 0) ? new int?(roleSkillBranchIndexInCurrentGamePlay) : null)
		};
		base.Apply<CharacterMediumItemGrid>(parameters);
		if (data.IsTrialRole())
		{
			base.SetLevelAndLock(null, null, null, null, null, null);
		}
		else
		{
			bool value = data == null || !BattleTeamModel.Instance.Context.CanAddRoleToEditTeam(dataId);
			base.SetLevelAndLock(null, new bool?(value), null, null, null, null);
		}
		bool bSelected = RoleSelectModel.Instance.SelectedRoleSet.Contains(dataId);
		this.SetSelected(bSelected, true);
	}

	// Token: 0x060162CE RID: 90830 RVA: 0x0059BD6F File Offset: 0x00599F6F
	public void OnForceSelected()
	{
		this.SetSelected(true, true);
	}

	// Token: 0x060162CF RID: 90831 RVA: 0x0059BD79 File Offset: 0x00599F79
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x060162D0 RID: 90832 RVA: 0x0059BD83 File Offset: 0x00599F83
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}

	// Token: 0x0400A522 RID: 42274
	[Nullable(2)]
	public Func<int, bool> IsHighlightIndex;
}
