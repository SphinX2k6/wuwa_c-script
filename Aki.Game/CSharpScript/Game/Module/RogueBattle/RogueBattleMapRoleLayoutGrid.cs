using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003E43 RID: 15939
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleMapRoleLayoutGrid : LoopScrollMediumItemGrid<IRogueBattleMapRoleGridInfo>
	{
		// Token: 0x06028999 RID: 166297 RVA: 0x00B64EC0 File Offset: 0x00B630C0
		protected override void OnRefresh(IRogueBattleMapRoleGridInfo data, bool isSelected, int gridIndex)
		{
			this.RoleData = data;
			bool flag = !data.IsGain;
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(data.ConfigId);
			bool roleIsRogueTrial = RogueBattleModel.Instance.GetRoleIsRogueTrial(data.ConfigId);
			base.SetUseFixedAsync(true);
			if (flag)
			{
				bool roleCantGet = RogueBattleModel.Instance.GetRoleCantGet(data.ConfigId);
				CharacterMediumItemGrid parameters = new CharacterMediumItemGrid
				{
					ItemConfigId = new int?(data.ConfigId),
					SkinId = roleConfig.Value.SkinId,
					BottomTextId = (roleCantGet ? "RogueResRole_Unable" : "RogueRes_Overall_Role_9"),
					ElementId = new int?(roleConfig.Value.ElementId),
					Data = data,
					IsDisable = new bool?(true),
					IsTrialRoleVisible = new bool?(roleIsRogueTrial)
				};
				base.Apply<CharacterMediumItemGrid>(parameters);
			}
			else
			{
				CharacterMediumItemGrid parameters2 = new CharacterMediumItemGrid
				{
					ItemConfigId = new int?(data.ConfigId),
					SkinId = roleConfig.Value.SkinId,
					ElementId = new int?(roleConfig.Value.ElementId),
					Data = data,
					IsTrialRoleVisible = new bool?(roleIsRogueTrial)
				};
				base.Apply<CharacterMediumItemGrid>(parameters2);
			}
			this.SetBottomStarTextVisible(data);
		}

		// Token: 0x0602899A RID: 166298 RVA: 0x00B6500C File Offset: 0x00B6320C
		public void SetBottomStarTextVisible(IRogueBattleMapRoleGridInfo data)
		{
			ItemGridComponent component = base.RefreshComponent(typeof(MediumItemGridRogueRoleLevelComponent), new bool?(true), data);
			base.SetComponentVisible(component, RogueBattleModel.Instance.IsRoleGot(data.ConfigId));
		}

		// Token: 0x0602899B RID: 166299 RVA: 0x00B65048 File Offset: 0x00B63248
		protected override void OnExtendToggleStateChanged(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				EventSystem.Instance.Emit<int>(EEventName.RogueResMapSummaryTeamUpdate, this.RoleData.ConfigId);
			}
		}

		// Token: 0x040160D1 RID: 90321
		private IRogueBattleMapRoleGridInfo RoleData;
	}
}
