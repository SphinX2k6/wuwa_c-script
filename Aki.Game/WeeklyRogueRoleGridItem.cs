using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x02002D3B RID: 11579
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WeeklyRogueRoleGridItem : LoopScrollMediumItemGrid<RoleDataBase>
{
	// Token: 0x06018573 RID: 99699 RVA: 0x006322F4 File Offset: 0x006304F4
	protected override void OnRefresh(RoleDataBase data, bool isSelected, int gridIndex)
	{
		int dataId = data.GetDataId();
		int roleIndex = RoleSelectModel.Instance.GetRoleIndex(dataId);
		int roleSkillBranchIndexInCurrentGamePlay = RoleModel.Instance.GetRoleSkillBranchIndexInCurrentGamePlay(dataId);
		CharacterMediumItemGrid characterMediumItemGrid = new CharacterMediumItemGrid();
		characterMediumItemGrid.ItemConfigId = new int?(dataId);
		characterMediumItemGrid.SkinId = data.GetRoleSkinId();
		characterMediumItemGrid.BottomTextId = (data.IsTrialRole() ? "WeRougeFormationMissingRole" : "Text_LevelShow_Text");
		MediumItemGridBase mediumItemGridBase = characterMediumItemGrid;
		object[] bottomTextParameter;
		if (!data.IsTrialRole())
		{
			(bottomTextParameter = new object[1])[0] = data.GetLevelData().GetLevel();
		}
		else
		{
			bottomTextParameter = null;
		}
		mediumItemGridBase.BottomTextParameter = bottomTextParameter;
		characterMediumItemGrid.Index = ((roleIndex > 0) ? new int?(roleIndex) : null);
		characterMediumItemGrid.ElementId = new int?(data.GetRoleConfig().ElementId);
		characterMediumItemGrid.IsDisable = new bool?(data.IsTrialRole());
		characterMediumItemGrid.Data = data;
		characterMediumItemGrid.SkillBranchIndex = ((roleSkillBranchIndexInCurrentGamePlay > -1) ? new int?(roleSkillBranchIndexInCurrentGamePlay) : null);
		CharacterMediumItemGrid parameters = characterMediumItemGrid;
		base.SetUseFixedAsync(true);
		base.Apply<CharacterMediumItemGrid>(parameters);
		bool bSelected = RoleSelectModel.Instance.SelectedRoleSet.Contains(dataId);
		this.SetSelected(bSelected, true);
	}

	// Token: 0x06018574 RID: 99700 RVA: 0x00632422 File Offset: 0x00630622
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x06018575 RID: 99701 RVA: 0x0063242C File Offset: 0x0063062C
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}

	// Token: 0x06018576 RID: 99702 RVA: 0x00632436 File Offset: 0x00630636
	public void OnForceSelected(bool bSelected)
	{
		this.SetSelected(bSelected, true);
	}

	// Token: 0x06018577 RID: 99703 RVA: 0x00632440 File Offset: 0x00630640
	public override object GetKey(RoleDataBase data, int gridIndex)
	{
		return data.GetDataId();
	}
}
