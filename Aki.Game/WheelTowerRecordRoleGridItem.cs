using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

// Token: 0x02000A5B RID: 2651
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WheelTowerRecordRoleGridItem : LoopScrollMediumItemGrid<RoleDataWithBranch>
{
	// Token: 0x06007176 RID: 29046 RVA: 0x0022D312 File Offset: 0x0022B512
	protected override void OnStart()
	{
		base.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
		base.SetToggleInteractive(false);
	}

	// Token: 0x06007177 RID: 29047 RVA: 0x0022D340 File Offset: 0x0022B540
	protected override void OnRefresh(RoleDataWithBranch data, bool isSelected, int gridIndex)
	{
		int roleId = data.RoleId;
		int num = WheelTowerModel.Instance.TryGetRealRoleId(roleId);
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(num, true);
		if (roleDataById == null)
		{
			return;
		}
		int roleEnergy = WheelTowerModel.Instance.SelectedEnergyInfo.GetRoleEnergy(roleId);
		int roleCost = WheelTowerModel.Instance.GetRoleCost(roleId);
		bool flag = WheelTowerModel.Instance.IsTemplateRole(roleId);
		TrialRoleInfo? trialRoleInfo;
		int num2 = flag ? ((TrialRoleConfig.Instance.GetTrialRoleConfig(roleId) != null) ? trialRoleInfo.GetValueOrDefault().Level : 90) : roleDataById.GetLevelData().GetLevel();
		int roleBranchIndexById = RoleModel.Instance.GetRoleBranchIndexById(roleId, data.SkillBranchId);
		base.SetUseFixedAsync(true);
		CharacterMediumItemGrid characterMediumItemGrid = new CharacterMediumItemGrid();
		characterMediumItemGrid.Data = roleDataById;
		characterMediumItemGrid.ItemConfigId = new int?(num);
		characterMediumItemGrid.SkinId = roleDataById.GetRoleConfig().SkinId;
		characterMediumItemGrid.BottomTextId = "Text_LevelShow_Text";
		characterMediumItemGrid.BottomTextParameter = new object[]
		{
			num2
		};
		characterMediumItemGrid.ElementId = new int?(roleDataById.GetRoleConfig().ElementId);
		CharacterMediumItemGrid characterMediumItemGrid2 = characterMediumItemGrid;
		MediumItemGridCostComponentData mediumItemGridCostComponentData = new MediumItemGridCostComponentData();
		mediumItemGridCostComponentData.Cost = roleEnergy;
		mediumItemGridCostComponentData.Color = TowerData.highColor.Value;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(roleEnergy - roleCost);
		defaultInterpolatedStringHandler.AppendLiteral("(-");
		defaultInterpolatedStringHandler.AppendFormatted<int>(roleCost);
		defaultInterpolatedStringHandler.AppendLiteral(")");
		mediumItemGridCostComponentData.Text = defaultInterpolatedStringHandler.ToStringAndClear();
		characterMediumItemGrid2.ShowCostData = mediumItemGridCostComponentData;
		characterMediumItemGrid.SkillBranchIndex = ((roleBranchIndexById >= 0) ? new int?(roleBranchIndexById) : null);
		base.Apply<CharacterMediumItemGrid>(characterMediumItemGrid);
		base.SetTemplateIcon(new bool?(flag));
		base.SetUpgradeArrow(new bool?(WheelTowerModel.Instance.IsEnhanceRole(num)));
	}
}
