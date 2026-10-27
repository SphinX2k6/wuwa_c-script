using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EB2 RID: 20146
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleTeamRoleGrid : LoopScrollMediumItemGrid<IRogueBattleTeamRoleGridInfo>
	{
		// Token: 0x06033BF4 RID: 211956 RVA: 0x00C1FC00 File Offset: 0x00C1DE00
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

		// Token: 0x06033BF5 RID: 211957 RVA: 0x00C1FCFE File Offset: 0x00C1DEFE
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelected(true, false);
		}

		// Token: 0x06033BF6 RID: 211958 RVA: 0x00C1FD08 File Offset: 0x00C1DF08
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelected(false, false);
		}

		// Token: 0x06033BF7 RID: 211959 RVA: 0x00C1FD12 File Offset: 0x00C1DF12
		public void OnForceSelected(bool bSelected)
		{
			this.SetSelected(bSelected, true);
		}
	}
}
