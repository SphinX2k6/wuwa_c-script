using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E7B RID: 15995
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleTeamRoleGrid : LoopScrollMediumItemGrid<IRogueBattleTeamRoleGridInfo>
	{
		// Token: 0x06028A5F RID: 166495 RVA: 0x00B69118 File Offset: 0x00B67318
		protected override void OnRefresh(IRogueBattleTeamRoleGridInfo data, bool isSelected, int gridIndex)
		{
			int dataId = data.RoleData.GetDataId();
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(dataId, true);
			RoleInfo roleConfig = roleDataById.GetRoleConfig();
			int incIdByRoleId = RogueBattleModel.Instance.GetIncIdByRoleId(dataId);
			RogueResRole roleInfoById = RogueBattleModel.Instance.GetRoleInfoById(incIdByRoleId);
			int roleIndex = RoleSelectModel.Instance.GetRoleIndex(dataId);
			int roleSkinId = roleDataById.GetRoleSkinId();
			IMediumLevelAndStar lvAndStar = new MediumLevelAndStar
			{
				Star = new int?(roleInfoById.Level)
			};
			CharacterMediumItemGrid parameters = new CharacterMediumItemGrid
			{
				ItemConfigId = new int?(dataId),
				SkinId = roleSkinId,
				Index = ((roleIndex > 0) ? new int?(roleIndex) : null),
				ElementId = new int?(roleConfig.ElementId),
				FrameEffect = new bool?(data.IsLinkOn),
				LvAndStar = lvAndStar,
				Data = data
			};
			base.Apply<CharacterMediumItemGrid>(parameters);
			bool bSelected = RoleSelectModel.Instance.SelectedRoleSet.Contains(dataId);
			this.SetSelected(bSelected, true);
		}

		// Token: 0x06028A60 RID: 166496 RVA: 0x00B69216 File Offset: 0x00B67416
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, false);
		}

		// Token: 0x06028A61 RID: 166497 RVA: 0x00B69220 File Offset: 0x00B67420
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x06028A62 RID: 166498 RVA: 0x00B6922A File Offset: 0x00B6742A
		public void OnForceSelected(bool bSelected)
		{
			this.SetSelected(bSelected, true);
		}
	}
}
