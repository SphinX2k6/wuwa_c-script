using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x0200225A RID: 8794
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WeaponReplaceMediumItemGrid : LoopScrollMediumItemGrid<SelectablePropData>
{
	// Token: 0x06015C06 RID: 89094 RVA: 0x0064F808 File Offset: 0x0064DA08
	public override void OnSelected(bool fireEvent)
	{
		if (fireEvent)
		{
			this.SetSelected(true, true);
		}
	}

	// Token: 0x06015C07 RID: 89095 RVA: 0x0064F815 File Offset: 0x0064DA15
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x06015C08 RID: 89096 RVA: 0x0064F820 File Offset: 0x0064DA20
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

	// Token: 0x06015C09 RID: 89097 RVA: 0x0064F910 File Offset: 0x0064DB10
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

	// Token: 0x0400B772 RID: 46962
	public ERoleViewSource Source;

	// Token: 0x0400B773 RID: 46963
	public int RoleId;
}
