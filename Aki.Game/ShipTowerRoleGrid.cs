using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x02001F46 RID: 8006
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerRoleGrid : LoopScrollMediumItemGrid<RoleDataBase>
{
	// Token: 0x06013CD3 RID: 81107 RVA: 0x005C6B7C File Offset: 0x005C4D7C
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

	// Token: 0x06013CD4 RID: 81108 RVA: 0x005C6D27 File Offset: 0x005C4F27
	public void OnForceSelected()
	{
		this.SetSelected(true, true);
	}

	// Token: 0x06013CD5 RID: 81109 RVA: 0x005C6D31 File Offset: 0x005C4F31
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x06013CD6 RID: 81110 RVA: 0x005C6D3B File Offset: 0x005C4F3B
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}

	// Token: 0x0400A90C RID: 43276
	[Nullable(2)]
	public Func<int, bool> IsHighlightIndex;
}
