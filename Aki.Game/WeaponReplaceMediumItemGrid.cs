using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02002D00 RID: 11520
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WeaponReplaceMediumItemGrid : LoopScrollMediumItemGrid<SelectablePropData>
{
	// Token: 0x06018365 RID: 99173 RVA: 0x00629832 File Offset: 0x00627A32
	public override void OnSelected(bool fireEvent)
	{
		if (fireEvent)
		{
			this.SetSelected(true, true);
		}
	}

	// Token: 0x06018366 RID: 99174 RVA: 0x0062983F File Offset: 0x00627A3F
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x06018367 RID: 99175 RVA: 0x0062984C File Offset: 0x00627A4C
	protected override void OnRefresh(SelectablePropData data, bool isSelected, int gridIndex)
	{
		int incId = data.IncId;
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(incId);
		WeaponConf? weaponConfig = weaponDataByIncId.GetWeaponConfig();
		MediumWarningPanelInfo warningPanelInfo = this.GetWarningPanelInfo(data);
		PropMediumItemGrid parameters = new PropMediumItemGrid
		{
			Data = data,
			ItemConfigId = new int?(data.ItemId),
			IsLockVisible = new bool?(data.GetIsLock()),
			StarLevel = new int?(weaponConfig.Value.QualityId),
			Level = new int?(weaponDataByIncId.GetResonanceLevel()),
			BottomTextId = "Text_LevelShow_Text",
			BottomTextParameter = new object[]
			{
				weaponDataByIncId.GetLevel()
			},
			RoleHeadInfo = new RoleHeadInfo
			{
				RoleConfigId = new int?(data.RoleId)
			},
			WarningPanelInfo = warningPanelInfo
		};
		base.Apply<PropMediumItemGrid>(parameters);
		this.SetSelected(isSelected, true);
	}

	// Token: 0x06018368 RID: 99176 RVA: 0x0062993C File Offset: 0x00627B3C
	[return: Nullable(2)]
	private MediumWarningPanelInfo GetWarningPanelInfo(SelectablePropData data)
	{
		if (this.Source == ERoleViewSource.WheelTower)
		{
			int incId = data.IncId;
			EnergyInfo selectedEnergyInfo = WheelTowerModel.Instance.SelectedEnergyInfo;
			if (selectedEnergyInfo == null)
			{
				return null;
			}
			if (!selectedEnergyInfo.GetWeaponCanUse(incId, this.RoleId))
			{
				int weaponOccupyRoleId = selectedEnergyInfo.GetWeaponOccupyRoleId(incId, this.RoleId);
				Aki.Config.RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(weaponOccupyRoleId);
				if (roleConfig != null)
				{
					string multiText = TextConfig.Instance.GetMultiText("WheelTower_Occupy_Tip", Array.Empty<string>());
					return new MediumWarningPanelInfo
					{
						TipText = multiText,
						IconPath = roleConfig.Value.Card
					};
				}
			}
		}
		return null;
	}

	// Token: 0x0400B3FD RID: 46077
	public ERoleViewSource Source;

	// Token: 0x0400B3FE RID: 46078
	public int RoleId;
}
