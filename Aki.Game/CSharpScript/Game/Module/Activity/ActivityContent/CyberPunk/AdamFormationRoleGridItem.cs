using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020057F6 RID: 22518
	public class AdamFormationRoleGridItem : WeeklyRogueRoleGridItem
	{
		// Token: 0x060378FC RID: 227580 RVA: 0x00F87D90 File Offset: 0x00F85F90
		[NullableContext(1)]
		protected override void OnRefresh(RoleDataBase data, bool isSelected, int gridIndex)
		{
			int dataId = data.GetDataId();
			int roleIndex = RoleSelectModel.Instance.GetRoleIndex(dataId);
			int roleSkillBranchIndexInCurrentGamePlay = RoleModel.Instance.GetRoleSkillBranchIndexInCurrentGamePlay(dataId);
			CharacterMediumItemGrid characterMediumItemGrid = new CharacterMediumItemGrid();
			characterMediumItemGrid.ItemConfigId = new int?(dataId);
			characterMediumItemGrid.SkinId = data.GetRoleSkinId();
			characterMediumItemGrid.BottomTextId = "Text_LevelShow_Text";
			characterMediumItemGrid.BottomTextParameter = new object[]
			{
				data.GetLevelData().GetLevel()
			};
			characterMediumItemGrid.Index = ((roleIndex > 0) ? new int?(roleIndex) : null);
			characterMediumItemGrid.ElementId = new int?(data.GetRoleConfig().ElementId);
			characterMediumItemGrid.IsDisable = new bool?(false);
			characterMediumItemGrid.Data = data;
			characterMediumItemGrid.SkillBranchIndex = ((roleSkillBranchIndexInCurrentGamePlay > -1) ? new int?(roleSkillBranchIndexInCurrentGamePlay) : null);
			CharacterMediumItemGrid characterMediumItemGrid2 = characterMediumItemGrid;
			IReadOnlySet<int> recommendedRoleIdSet = this.RecommendedRoleIdSet;
			characterMediumItemGrid2.IsRecommendBottomVisible = new bool?(recommendedRoleIdSet != null && recommendedRoleIdSet.Contains(dataId));
			characterMediumItemGrid.IsTrialBottomVisible = new bool?(data.IsTrialRole());
			CharacterMediumItemGrid parameters = characterMediumItemGrid;
			base.Apply<CharacterMediumItemGrid>(parameters);
			bool bSelected = RoleSelectModel.Instance.SelectedRoleSet.Contains(dataId);
			this.SetSelected(bSelected, true);
		}

		// Token: 0x0401D4FD RID: 120061
		[Nullable(2)]
		public IReadOnlySet<int> RecommendedRoleIdSet;
	}
}
