using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;
using UnrealEngine;

// Token: 0x02000A39 RID: 2617
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerEnhanceRoleGridItem : LoopScrollMediumItemGrid<int>
{
	// Token: 0x06007122 RID: 28962 RVA: 0x0022B271 File Offset: 0x00229471
	protected override void OnStart()
	{
		this.GetItemGridExtendToggle().bLockStateOnSelect = true;
		base.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnExtendToggleStateChangedInternal));
		base.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback _)
		{
			this.OnExtendToggleClickedInternal();
		});
	}

	// Token: 0x06007123 RID: 28963 RVA: 0x0022B2A4 File Offset: 0x002294A4
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

	// Token: 0x06007124 RID: 28964 RVA: 0x0022B3B9 File Offset: 0x002295B9
	public void SetToggleClickCallback(Action<int> callback)
	{
		this.ToggleClickCallback = callback;
	}

	// Token: 0x06007125 RID: 28965 RVA: 0x0022B3C2 File Offset: 0x002295C2
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, true);
	}

	// Token: 0x06007126 RID: 28966 RVA: 0x0022B3CC File Offset: 0x002295CC
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x06007127 RID: 28967 RVA: 0x0022B3D6 File Offset: 0x002295D6
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

	// Token: 0x06007128 RID: 28968 RVA: 0x0022B3F7 File Offset: 0x002295F7
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

	// Token: 0x040045B2 RID: 17842
	private int RoleId;

	// Token: 0x040045B3 RID: 17843
	[Nullable(2)]
	private Action<int> ToggleClickCallback;
}
