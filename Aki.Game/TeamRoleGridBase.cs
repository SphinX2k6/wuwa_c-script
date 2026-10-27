using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Module.InstanceDungeon;

// Token: 0x02002791 RID: 10129
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class TeamRoleGridBase : LoopScrollMediumItemGrid<RoleDataBase>
{
	// Token: 0x17001B22 RID: 6946
	// (get) Token: 0x06014C89 RID: 85129 RVA: 0x00543B6F File Offset: 0x00541D6F
	// (set) Token: 0x06014C8A RID: 85130 RVA: 0x00543B77 File Offset: 0x00541D77
	public virtual Func<int, bool> IsHighlightIndex { get; set; }

	// Token: 0x17001B23 RID: 6947
	// (get) Token: 0x06014C8B RID: 85131 RVA: 0x00543B80 File Offset: 0x00541D80
	// (set) Token: 0x06014C8C RID: 85132 RVA: 0x00543B88 File Offset: 0x00541D88
	public virtual Func<int, bool> IsShowGray { get; set; }

	// Token: 0x06014C8D RID: 85133 RVA: 0x00543B94 File Offset: 0x00541D94
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
			value2 = (array != null && array.Contains(data.GetRoleId()));
			int[] array2 = config.Value.RecommendRoleBottom();
			value3 = (array2 != null && array2.Contains(data.GetRoleId()));
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

	// Token: 0x06014C8E RID: 85134 RVA: 0x00543E1E File Offset: 0x0054201E
	[NullableContext(1)]
	protected virtual CharacterMediumItemGrid GetRoleParameters(CharacterMediumItemGrid baseParameter, RoleDataBase data)
	{
		return baseParameter;
	}

	// Token: 0x06014C8F RID: 85135 RVA: 0x00543E21 File Offset: 0x00542021
	[NullableContext(1)]
	protected virtual void ExtraRefreshFunc(RoleDataBase data)
	{
	}

	// Token: 0x06014C90 RID: 85136 RVA: 0x00543E23 File Offset: 0x00542023
	public virtual void OnForceSelected()
	{
		this.SetSelected(true, true);
	}

	// Token: 0x06014C91 RID: 85137 RVA: 0x00543E2D File Offset: 0x0054202D
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x06014C92 RID: 85138 RVA: 0x00543E37 File Offset: 0x00542037
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}
}
