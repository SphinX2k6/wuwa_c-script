using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

// Token: 0x020015E7 RID: 5607
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WheelTowerRoleGridItem : LoopScrollMediumItemGrid<RoleDataWithBranch>
{
	// Token: 0x06009E65 RID: 40549 RVA: 0x00228CAA File Offset: 0x00226EAA
	protected override void OnStart()
	{
		base.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
	}

	// Token: 0x06009E66 RID: 40550 RVA: 0x00228CD4 File Offset: 0x00226ED4
	protected override void OnRefresh(RoleDataWithBranch data, bool isSelected, int gridIndex)
	{
		int roleId = data.RoleId;
		if (roleId == 0)
		{
			base.Apply<OnlyEmptyItemGrid>(new OnlyEmptyItemGrid
			{
				IsClickable = new bool?(false)
			});
			this.SetSelected(false, true);
			return;
		}
		this.RoleId = roleId;
		int num = WheelTowerModel.Instance.TryGetRealRoleId(roleId);
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
		if (roleDataById == null)
		{
			return;
		}
		int roleEnergy = WheelTowerModel.Instance.SelectedEnergyInfo.GetRoleEnergy(roleId);
		int roleSlot = WheelTowerModel.Instance.GetRoleSlot(roleId);
		int? index = (roleSlot == -1) ? null : new int?(roleSlot + 1);
		bool flag = WheelTowerModel.Instance.IsTemplateRole(roleId);
		bool flag2 = roleEnergy <= 0;
		bool value = !flag && !flag2 && WheelTowerModel.Instance.CheckConflict(roleId) != null;
		TrialRoleInfo? trialRoleInfo;
		int num2 = flag ? ((TrialRoleConfig.Instance.GetTrialRoleConfig(roleId) != null) ? trialRoleInfo.GetValueOrDefault().Level : 90) : roleDataById.GetLevelData().GetLevel();
		base.SetUseFixedAsync(true);
		base.Apply<CharacterMediumItemGrid>(new CharacterMediumItemGrid
		{
			Data = roleDataById,
			ItemConfigId = new int?(num),
			SkinId = roleDataById.GetRoleSkinId(),
			BottomTextId = "Text_LevelShow_Text",
			BottomTextParameter = new object[]
			{
				num2
			},
			ElementId = new int?(roleDataById.GetRoleConfig().ElementId),
			ShowCostData = new MediumItemGridCostComponentData
			{
				Cost = roleEnergy,
				Color = ((roleEnergy > 0) ? TowerData.highColor.Value : TowerData.redColor.Value)
			},
			Index = index,
			IsDisable = new bool?(flag2),
			SkillBranchIndex = ((data.SkillBranchIndex > -1) ? new int?(data.SkillBranchIndex) : null)
		});
		base.SetWarningTips(new bool?(value));
		base.SetTemplateIcon(new bool?(flag));
		base.SetUpgradeArrow(new bool?(WheelTowerModel.Instance.IsEnhanceRole(num)));
		this.GetItemGridExtendToggle().SetToggleStateForce(WheelTowerModel.Instance.IsSelectRole(roleId) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06009E67 RID: 40551 RVA: 0x00228F0D File Offset: 0x0022710D
	public void SetToggleClickCallback(Action<int> callback)
	{
		this.ToggleClickCallback = callback;
	}

	// Token: 0x06009E68 RID: 40552 RVA: 0x00228F16 File Offset: 0x00227116
	protected override void OnExtendToggleClicked()
	{
		Action<int> toggleClickCallback = this.ToggleClickCallback;
		if (toggleClickCallback == null)
		{
			return;
		}
		toggleClickCallback(this.RoleId);
	}

	// Token: 0x040046A7 RID: 18087
	private int RoleId;

	// Token: 0x040046A8 RID: 18088
	[Nullable(2)]
	private Action<int> ToggleClickCallback;
}
