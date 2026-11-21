using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x02002295 RID: 8853
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WeeklyRogueRoleGridItem : LoopScrollMediumItemGrid<RoleDataBase>
{
	// Token: 0x06015E15 RID: 89621 RVA: 0x00658304 File Offset: 0x00656504
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

	// Token: 0x06015E16 RID: 89622 RVA: 0x00658432 File Offset: 0x00656632
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x06015E17 RID: 89623 RVA: 0x0065843C File Offset: 0x0065663C
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}

	// Token: 0x06015E18 RID: 89624 RVA: 0x00658446 File Offset: 0x00656646
	public void OnForceSelected(bool bSelected)
	{
		this.SetSelected(bSelected, true);
	}

	// Token: 0x06015E19 RID: 89625 RVA: 0x00658450 File Offset: 0x00656650
	public override object GetKey(RoleDataBase data, int gridIndex)
	{
		return data.GetDataId();
	}
}
