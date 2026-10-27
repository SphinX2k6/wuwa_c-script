using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200299C RID: 10652
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerBuffItem : LoopScrollMediumItemGrid<ShipTowerBuffData>
{
	// Token: 0x06016150 RID: 90448 RVA: 0x00595516 File Offset: 0x00593716
	[NullableContext(1)]
	protected override void OnRefresh(ShipTowerBuffData data, bool isSelected, int gridIndex)
	{
		this.BuffData = data;
		this.UpdateBuffInfo();
		this.UpdateBuffSelected();
		if (data.IsSelected)
		{
			this.OnExtendToggleStateChanged(EToggleState.ETT_Checked);
		}
	}

	// Token: 0x06016151 RID: 90449 RVA: 0x0059553C File Offset: 0x0059373C
	public void UpdateBuffInfo()
	{
		ShipTowerBuffData buffData = this.BuffData;
		Func<int?> getStageIdCallback = this.GetStageIdCallback;
		int? stageId = (getStageIdCallback != null) ? getStageIdCallback() : null;
		PropMediumItemGrid parameters = new PropMediumItemGrid
		{
			ItemConfigId = new int?(buffData.ItemId),
			IsLockVisible = new bool?(!buffData.IsUnlock),
			IsDisable = new bool?(!buffData.IsCanUse(stageId)),
			Level = (buffData.IsUnlimited(stageId) ? null : new int?(buffData.CanUseCount)),
			IsLevelInfinite = (buffData.IsUnlimited(stageId) ? new bool?(true) : null),
			BottomTextId = buffData.ItemNameKey,
			IsNewVisible = new bool?(buffData.IsFirstGet()),
			Data = buffData
		};
		base.Apply<PropMediumItemGrid>(parameters);
	}

	// Token: 0x06016152 RID: 90450 RVA: 0x0059561C File Offset: 0x0059381C
	public void OnForceSelected()
	{
		this.SetSelected(true, true);
	}

	// Token: 0x06016153 RID: 90451 RVA: 0x00595626 File Offset: 0x00593826
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x06016154 RID: 90452 RVA: 0x00595630 File Offset: 0x00593830
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}

	// Token: 0x06016155 RID: 90453 RVA: 0x0059563A File Offset: 0x0059383A
	protected override void OnBeforeDestroy()
	{
		ShipTowerBuffData buffData = this.BuffData;
		if (buffData == null)
		{
			return;
		}
		buffData.ClearSelected();
	}

	// Token: 0x06016156 RID: 90454 RVA: 0x0059564C File Offset: 0x0059384C
	protected override void OnExtendToggleStateChanged(EToggleState state)
	{
		ShipTowerBuffData buffData = this.BuffData;
		if (buffData != null)
		{
			buffData.SetSelected(true);
		}
		IScrollViewDelegate<IGridProxy<ShipTowerBuffData>, ShipTowerBuffData> scrollViewDelegate = base.ScrollViewDelegate;
		if (scrollViewDelegate != null)
		{
			scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
		}
		Action<ShipTowerBuffData> onItemClickCallback = this.OnItemClickCallback;
		if (onItemClickCallback == null)
		{
			return;
		}
		onItemClickCallback(this.BuffData);
	}

	// Token: 0x06016157 RID: 90455 RVA: 0x0059569F File Offset: 0x0059389F
	protected override bool OnCanExecuteChange()
	{
		ShipTowerBuffData buffData = this.BuffData;
		return buffData == null || !buffData.IsSelected;
	}

	// Token: 0x06016158 RID: 90456 RVA: 0x005956B8 File Offset: 0x005938B8
	public void UpdateBuffState()
	{
		this.UpdateBuffInfo();
	}

	// Token: 0x06016159 RID: 90457 RVA: 0x005956C0 File Offset: 0x005938C0
	public void UpdateBuffSelected()
	{
		ShipTowerBuffData buffData = this.BuffData;
		bool? flag = (buffData != null) ? new bool?(buffData.IsSelected) : null;
		bool? isLastSelected = this.IsLastSelected;
		if (flag.GetValueOrDefault() == isLastSelected.GetValueOrDefault() & flag != null == (isLastSelected != null))
		{
			return;
		}
		ShipTowerBuffData buffData2 = this.BuffData;
		this.SetSelected(buffData2 != null && buffData2.IsSelected, true);
		ShipTowerBuffData buffData3 = this.BuffData;
		this.IsLastSelected = ((buffData3 != null) ? new bool?(buffData3.IsSelected) : null);
	}

	// Token: 0x0400A49A RID: 42138
	protected ShipTowerBuffData BuffData;

	// Token: 0x0400A49B RID: 42139
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerBuffData> OnItemClickCallback;

	// Token: 0x0400A49C RID: 42140
	public Func<int?> GetStageIdCallback;

	// Token: 0x0400A49D RID: 42141
	private bool? IsLastSelected;
}
