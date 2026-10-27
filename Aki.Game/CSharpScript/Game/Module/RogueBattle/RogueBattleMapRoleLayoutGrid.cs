using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E7A RID: 20090
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleMapRoleLayoutGrid : LoopScrollMediumItemGrid<IRogueBattleMapRoleGridInfo>
	{
		// Token: 0x06033B2E RID: 211758 RVA: 0x00C1B99C File Offset: 0x00C19B9C
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

		// Token: 0x06033B2F RID: 211759 RVA: 0x00C1BAE8 File Offset: 0x00C19CE8
		public void SetBottomStarTextVisible(IRogueBattleMapRoleGridInfo data)
		{
			ItemGridComponent component = base.RefreshComponent(typeof(MediumItemGridRogueRoleLevelComponent), new bool?(true), data);
			base.SetComponentVisible(component, RogueBattleModel.Instance.IsRoleGot(data.ConfigId));
		}

		// Token: 0x06033B30 RID: 211760 RVA: 0x00C1BB24 File Offset: 0x00C19D24
		protected override void OnExtendToggleStateChanged(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				EventSystem.Instance.Emit<int>(EEventName.RogueResMapSummaryTeamUpdate, this.RoleData.ConfigId);
			}
		}

		// Token: 0x0401B6FE RID: 112382
		private IRogueBattleMapRoleGridInfo RoleData;
	}
}
