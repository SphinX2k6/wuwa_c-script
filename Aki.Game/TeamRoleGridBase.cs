using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Module.InstanceDungeon;

// Token: 0x02001C7C RID: 7292
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class TeamRoleGridBase : LoopScrollMediumItemGrid<RoleDataBase>
{
	// Token: 0x17001B5B RID: 7003
	// (get) Token: 0x06012174 RID: 74100 RVA: 0x00552C5F File Offset: 0x00550E5F
	// (set) Token: 0x06012175 RID: 74101 RVA: 0x00552C67 File Offset: 0x00550E67
	public virtual Func<int, bool> IsHighlightIndex { get; set; }

	// Token: 0x17001B5C RID: 7004
	// (get) Token: 0x06012176 RID: 74102 RVA: 0x00552C70 File Offset: 0x00550E70
	// (set) Token: 0x06012177 RID: 74103 RVA: 0x00552C78 File Offset: 0x00550E78
	public virtual Func<int, bool> IsShowGray { get; set; }

	// Token: 0x06012178 RID: 74104 RVA: 0x00552C84 File Offset: 0x00550E84
	[NullableContext(1)]
	protected override void OnRefresh(RoleDataBase data, bool isSelected, int gridIndex)
	{
		RoleLevelData levelData = data.GetLevelData();
		int dataId = data.GetDataId();
		int roleIndex = RoleSelectModel.Instance.GetRoleIndex(dataId);
		bool value = data.IsTrialRole();
		Func<int, bool> isHighlightIndex = this.IsHighlightIndex;
		bool? highlightIndex = (isHighlightIndex != null) ? new bool?(isHighlightIndex(roleIndex)) : null;
		bool value2 = false;
		bool value3 = false;
		if (InstanceDungeonEntranceModel.Instance.SelectInstanceId != 0)
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(InstanceDungeonEntranceModel.Instance.SelectInstanceId);
			int[] array = config.Value.RecommendRole();
			value2 = (array != null && Array.IndexOf<int>(array, data.GetRoleId()) >= 0);
			int[] array2 = config.Value.RecommendRoleBottom();
			value3 = (array2 != null && Array.IndexOf<int>(array2, data.GetRoleId()) >= 0);
		}
		int roleSkillBranchIndexInCurrentGamePlay = RoleModel.Instance.GetRoleSkillBranchIndexInCurrentGamePlay(dataId);
		CharacterMediumItemGrid baseParameter = new CharacterMediumItemGrid
		{
			ItemConfigId = new int?(dataId),
			SkinId = data.GetRoleSkinId(),
			IsTrialRoleVisible = new bool?(value),
			BottomTextId = "Text_LevelShow_Text",
			BottomTextParameter = new object[]
			{
				levelData.GetLevel()
			},
			Index = ((roleIndex > 0) ? new int?(roleIndex) : null),
			HighlightIndex = highlightIndex,
			ElementId = new int?(data.GetRoleConfig().ElementId),
			Data = data,
			IsRecommendVisible = new bool?(value2),
			IsRecommendBottomVisible = new bool?(value3),
			SkillBranchIndex = ((roleSkillBranchIndexInCurrentGamePlay > -1) ? new int?(roleSkillBranchIndexInCurrentGamePlay) : null)
		};
		base.Apply<CharacterMediumItemGrid>(this.GetRoleParameters(baseParameter, data));
		this.ExtraRefreshFunc(data);
		if (data.IsTrialRole())
		{
			base.SetLevelAndLock(null, null, null, null, null, null);
		}
		else
		{
			bool value4 = data == null || !BattleTeamModel.Instance.Context.CanAddRoleToEditTeam(dataId);
			base.SetLevelAndLock(null, new bool?(value4), null, null, null, null);
		}
		bool bSelected = RoleSelectModel.Instance.SelectedRoleSet.Contains(dataId);
		this.SetSelected(bSelected, true);
	}

	// Token: 0x06012179 RID: 74105 RVA: 0x00552F1A File Offset: 0x0055111A
	[NullableContext(1)]
	protected virtual CharacterMediumItemGrid GetRoleParameters(CharacterMediumItemGrid baseParameter, RoleDataBase data)
	{
		return baseParameter;
	}

	// Token: 0x0601217A RID: 74106 RVA: 0x00552F1D File Offset: 0x0055111D
	[NullableContext(1)]
	protected virtual void ExtraRefreshFunc(RoleDataBase data)
	{
	}

	// Token: 0x0601217B RID: 74107 RVA: 0x00552F1F File Offset: 0x0055111F
	public virtual void OnForceSelected()
	{
		this.SetSelected(true, true);
	}

	// Token: 0x0601217C RID: 74108 RVA: 0x00552F29 File Offset: 0x00551129
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x0601217D RID: 74109 RVA: 0x00552F33 File Offset: 0x00551133
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}
}
