using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Module.InstanceDungeon;

// Token: 0x02002790 RID: 10128
[NullableContext(2)]
[Nullable(0)]
public class TeamRoleGrid : TeamRoleGridBase
{
	// Token: 0x17001B20 RID: 6944
	// (get) Token: 0x06014C7F RID: 85119 RVA: 0x00543670 File Offset: 0x00541870
	// (set) Token: 0x06014C80 RID: 85120 RVA: 0x00543678 File Offset: 0x00541878
	public override Func<int, bool> IsHighlightIndex { get; set; }

	// Token: 0x17001B21 RID: 6945
	// (get) Token: 0x06014C81 RID: 85121 RVA: 0x00543681 File Offset: 0x00541881
	// (set) Token: 0x06014C82 RID: 85122 RVA: 0x00543689 File Offset: 0x00541889
	public override Func<int, bool> IsShowGray { get; set; }

	// Token: 0x06014C83 RID: 85123 RVA: 0x00543694 File Offset: 0x00541894
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
				value = (array != null && array.Contains(data.GetRoleId()));
				int[] array2 = config.Value.RecommendRoleBottom();
				value2 = (array2 != null && array2.Contains(data.GetRoleId()));
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

	// Token: 0x06014C84 RID: 85124 RVA: 0x00543AE7 File Offset: 0x00541CE7
	public override void OnForceSelected()
	{
		this.SetSelected(true, true);
	}

	// Token: 0x06014C85 RID: 85125 RVA: 0x00543AF1 File Offset: 0x00541CF1
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x06014C86 RID: 85126 RVA: 0x00543AFB File Offset: 0x00541CFB
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}

	// Token: 0x06014C87 RID: 85127 RVA: 0x00543B08 File Offset: 0x00541D08
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
