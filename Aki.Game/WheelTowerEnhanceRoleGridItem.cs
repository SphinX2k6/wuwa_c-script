using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

// Token: 0x02001581 RID: 5505
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerEnhanceRoleGridItem : LoopScrollMediumItemGrid<int>
{
	// Token: 0x06009D44 RID: 40260 RVA: 0x002214C1 File Offset: 0x0021F6C1
	protected override void OnStart()
	{
		this.GetItemGridExtendToggle().bLockStateOnSelect = true;
		base.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnExtendToggleStateChangedInternal));
		base.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback _)
		{
			this.OnExtendToggleClickedInternal();
		});
	}

	// Token: 0x06009D45 RID: 40261 RVA: 0x002214F4 File Offset: 0x0021F6F4
	protected override void OnRefresh(int roleId, bool isSelected, int gridIndex)
	{
		this.RoleId = roleId;
		if (roleId == 0)
		{
			base.Apply<OnlyEmptyItemGrid>(new OnlyEmptyItemGrid
			{
				IsClickable = new bool?(false)
			});
			this.SetSelected(false, true);
			return;
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
		if (roleConfig == null)
		{
			return;
		}
		base.SetUseFixedAsync(true);
		CharacterMediumItemGrid characterMediumItemGrid = new CharacterMediumItemGrid
		{
			ItemConfigId = new int?(roleId),
			SkinId = roleConfig.Value.SkinId,
			BottomTextId = roleConfig.Value.Name,
			ElementId = new int?(roleConfig.Value.ElementId)
		};
		int specialUpRoleAddEnergy = WheelTowerModel.Instance.GetSpecialUpRoleAddEnergy(roleId);
		if (specialUpRoleAddEnergy > 0)
		{
			CharacterMediumItemGrid characterMediumItemGrid2 = characterMediumItemGrid;
			MediumItemGridCostComponentData mediumItemGridCostComponentData = new MediumItemGridCostComponentData();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("+");
			defaultInterpolatedStringHandler.AppendFormatted<int>(specialUpRoleAddEnergy);
			mediumItemGridCostComponentData.Text = defaultInterpolatedStringHandler.ToStringAndClear();
			mediumItemGridCostComponentData.Cost = 0;
			mediumItemGridCostComponentData.Color = TowerData.highColor.Value;
			characterMediumItemGrid2.ShowCostData = mediumItemGridCostComponentData;
		}
		base.Apply<CharacterMediumItemGrid>(characterMediumItemGrid);
		this.SetSelected(isSelected, true);
	}

	// Token: 0x06009D46 RID: 40262 RVA: 0x00221609 File Offset: 0x0021F809
	public void SetToggleClickCallback(Action<int> callback)
	{
		this.ToggleClickCallback = callback;
	}

	// Token: 0x06009D47 RID: 40263 RVA: 0x00221612 File Offset: 0x0021F812
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, true);
	}

	// Token: 0x06009D48 RID: 40264 RVA: 0x0022161C File Offset: 0x0021F81C
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x06009D49 RID: 40265 RVA: 0x00221626 File Offset: 0x0021F826
	private void OnExtendToggleStateChangedInternal(MediumItemGridExtendCallback callback)
	{
		if (callback.State == EToggleState.ETT_Checked)
		{
			Action<int> toggleClickCallback = this.ToggleClickCallback;
			if (toggleClickCallback == null)
			{
				return;
			}
			toggleClickCallback(this.RoleId);
		}
	}

	// Token: 0x06009D4A RID: 40266 RVA: 0x00221647 File Offset: 0x0021F847
	private void OnExtendToggleClickedInternal()
	{
		if (this.IsSelected)
		{
			return;
		}
		Action<int> toggleClickCallback = this.ToggleClickCallback;
		if (toggleClickCallback == null)
		{
			return;
		}
		toggleClickCallback(this.RoleId);
	}

	// Token: 0x0400450C RID: 17676
	private int RoleId;

	// Token: 0x0400450D RID: 17677
	[Nullable(2)]
	private Action<int> ToggleClickCallback;
}
