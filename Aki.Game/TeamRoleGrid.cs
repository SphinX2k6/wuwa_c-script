using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Module.InstanceDungeon;

// Token: 0x02001C7B RID: 7291
[NullableContext(2)]
[Nullable(0)]
public class TeamRoleGrid : TeamRoleGridBase
{
	// Token: 0x17001B59 RID: 7001
	// (get) Token: 0x0601216A RID: 74090 RVA: 0x00552754 File Offset: 0x00550954
	// (set) Token: 0x0601216B RID: 74091 RVA: 0x0055275C File Offset: 0x0055095C
	public override Func<int, bool> IsHighlightIndex { get; set; }

	// Token: 0x17001B5A RID: 7002
	// (get) Token: 0x0601216C RID: 74092 RVA: 0x00552765 File Offset: 0x00550965
	// (set) Token: 0x0601216D RID: 74093 RVA: 0x0055276D File Offset: 0x0055096D
	public override Func<int, bool> IsShowGray { get; set; }

	// Token: 0x0601216E RID: 74094 RVA: 0x00552778 File Offset: 0x00550978
	[NullableContext(1)]
	protected override void OnRefresh(RoleDataBase data, bool isSelected, int gridIndex)
	{
		RoleLevelData levelData = data.GetLevelData();
		int dataId = data.GetDataId();
		FormationModel instance = FormationModel.Instance;
		int roleIndex = RoleSelectModel.Instance.GetRoleIndex(dataId);
		bool flag = false;
		bool flag2 = data.IsTrialRole();
		if (!flag2 && !TowerModel.Instance.IsOpenFloorFormation() && !LordGymController.Instance.IsInLordGymDungeon() && !MowingTowerModel.Instance.IsOpenMowingTowerFormation() && !MapRogueController.Instance.CheckInMapRogueInstance())
		{
			flag = instance.IsRoleDead(dataId);
		}
		Func<int, bool> isHighlightIndex = this.IsHighlightIndex;
		bool? highlightIndex = (isHighlightIndex != null) ? new bool?(isHighlightIndex(roleIndex)) : null;
		bool value = false;
		bool value2 = false;
		if (InstanceDungeonEntranceModel.Instance.SelectInstanceId > 0)
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(InstanceDungeonEntranceModel.Instance.SelectInstanceId);
			if (config != null)
			{
				int[] array = config.Value.RecommendRole();
				value = (array != null && Array.IndexOf<int>(array, data.GetRoleId()) >= 0);
				int[] array2 = config.Value.RecommendRoleBottom();
				value2 = (array2 != null && Array.IndexOf<int>(array2, data.GetRoleId()) >= 0);
			}
		}
		List<int> otherHalfAreaRoleList = MowingTowerModel.Instance.OtherHalfAreaRoleList;
		object obj;
		if (otherHalfAreaRoleList == null || !otherHalfAreaRoleList.Contains(dataId))
		{
			obj = null;
		}
		else
		{
			(obj = new HaveAreaInfo()).BelongTo = ETeamBelong.LowPart - MowingTowerModel.Instance.CurrentOptionArea;
		}
		HaveAreaInfo halfAreaInfo = obj;
		Func<int, bool> isShowGray = this.IsShowGray;
		bool flag3 = isShowGray != null && isShowGray(data.GetDataId()) && flag;
		MediumItemGridCostComponentData showCostData = null;
		if (TowerModel.Instance.IsOpenFloorFormation() && !flag3)
		{
			int roleRemainCost = TowerModel.Instance.GetRoleRemainCost(dataId, TowerModel.Instance.CurrentSelectDifficulties);
			showCostData = new MediumItemGridCostComponentData
			{
				Cost = roleRemainCost,
				Color = ((roleRemainCost >= 4) ? TowerData.highColor.Value : TowerData.lowColor.Value)
			};
		}
		int roleSkillBranchIndexInCurrentGamePlay = RoleModel.Instance.GetRoleSkillBranchIndexInCurrentGamePlay(dataId);
		CharacterMediumItemGrid parameters = new CharacterMediumItemGrid
		{
			ItemConfigId = new int?(dataId),
			SkinId = data.GetRoleSkinId(),
			IsTrialRoleVisible = new bool?(flag2),
			BottomTextId = "Text_LevelShow_Text",
			BottomTextParameter = new object[]
			{
				levelData.GetLevel()
			},
			Index = ((roleIndex > 0) ? new int?(roleIndex) : null),
			HighlightIndex = highlightIndex,
			ElementId = new int?(data.GetRoleConfig().ElementId),
			ShowCostData = showCostData,
			Data = data,
			IsDisable = new bool?(flag),
			IsRecommendVisible = new bool?(value),
			HalfAreaInfo = halfAreaInfo,
			IsShowWeeklyRogueTag = new bool?(WeeklyRogueModel.Instance.IsWeeklyRogueOpen() && WeeklyRogueModel.Instance.CheckIsRecommendRole(dataId)),
			IsRecommendBottomVisible = new bool?(value2),
			SkillBranchIndex = ((roleSkillBranchIndexInCurrentGamePlay > -1) ? new int?(roleSkillBranchIndexInCurrentGamePlay) : null)
		};
		base.Apply<CharacterMediumItemGrid>(parameters);
		if (data.IsTrialRole())
		{
			base.SetLevelAndLock(null, null, null, null, null, null);
		}
		else
		{
			bool value3 = data == null || !BattleTeamModel.Instance.Context.CanAddRoleToEditTeam(dataId);
			base.SetLevelAndLock(null, new bool?(value3), null, null, null, null);
		}
		int[] addLevel = MowingTowerModel.Instance.AddLevel;
		if (addLevel != null && addLevel.Length != 0)
		{
			bool flag4 = data.GetLevelData().GetLevel() < addLevel[0];
			if (addLevel[0] != -1 && flag4)
			{
				this.SetAddLevelComponent(addLevel[0], flag4);
			}
		}
		int[] addLevel2 = HonamiStoryModel.Instance.AddLevel;
		if (addLevel2 != null && addLevel2.Length != 0)
		{
			bool flag5 = data.GetLevelData().GetLevel() < addLevel2[0];
			if (addLevel2[0] != -1 && flag5)
			{
				this.SetAddLevelComponent(addLevel2[0], flag5);
			}
		}
		base.SetIsDisable(new bool?(flag3));
		bool bSelected = RoleSelectModel.Instance.SelectedRoleSet.Contains(dataId);
		this.SetSelected(bSelected, true);
	}

	// Token: 0x0601216F RID: 74095 RVA: 0x00552BD7 File Offset: 0x00550DD7
	public override void OnForceSelected()
	{
		this.SetSelected(true, true);
	}

	// Token: 0x06012170 RID: 74096 RVA: 0x00552BE1 File Offset: 0x00550DE1
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x06012171 RID: 74097 RVA: 0x00552BEB File Offset: 0x00550DEB
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}

	// Token: 0x06012172 RID: 74098 RVA: 0x00552BF8 File Offset: 0x00550DF8
	public void SetAddLevelComponent(int addLevel, bool isShow)
	{
		RoleDataBase roleDataBase = this.Data as RoleDataBase;
		if (roleDataBase == null)
		{
			return;
		}
		int num = Math.Max(roleDataBase.GetLevelData().GetLevel(), addLevel);
		ItemGridComponent component = base.RefreshComponent(typeof(RogueAddLevelComponent), new bool?(true), num);
		base.SetComponentVisible(component, isShow);
		if (num > 0)
		{
			base.SetBottomTextVisible(false);
		}
	}
}
