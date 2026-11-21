using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001F17 RID: 7959
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerBuffItem : LoopScrollMediumItemGrid<ShipTowerBuffData>
{
	// Token: 0x06013B56 RID: 80726 RVA: 0x005C04D6 File Offset: 0x005BE6D6
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

	// Token: 0x06013B57 RID: 80727 RVA: 0x005C04FC File Offset: 0x005BE6FC
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

	// Token: 0x06013B58 RID: 80728 RVA: 0x005C05DC File Offset: 0x005BE7DC
	public void OnForceSelected()
	{
		this.SetSelected(true, true);
	}

	// Token: 0x06013B59 RID: 80729 RVA: 0x005C05E6 File Offset: 0x005BE7E6
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x06013B5A RID: 80730 RVA: 0x005C05F0 File Offset: 0x005BE7F0
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}

	// Token: 0x06013B5B RID: 80731 RVA: 0x005C05FA File Offset: 0x005BE7FA
	protected override void OnBeforeDestroy()
	{
		ShipTowerBuffData buffData = this.BuffData;
		if (buffData == null)
		{
			return;
		}
		buffData.ClearSelected();
	}

	// Token: 0x06013B5C RID: 80732 RVA: 0x005C060C File Offset: 0x005BE80C
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

	// Token: 0x06013B5D RID: 80733 RVA: 0x005C065F File Offset: 0x005BE85F
	protected override bool OnCanExecuteChange()
	{
		ShipTowerBuffData buffData = this.BuffData;
		return buffData == null || !buffData.IsSelected;
	}

	// Token: 0x06013B5E RID: 80734 RVA: 0x005C0678 File Offset: 0x005BE878
	public void UpdateBuffState()
	{
		this.UpdateBuffInfo();
	}

	// Token: 0x06013B5F RID: 80735 RVA: 0x005C0680 File Offset: 0x005BE880
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

	// Token: 0x0400A884 RID: 43140
	protected ShipTowerBuffData BuffData;

	// Token: 0x0400A885 RID: 43141
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerBuffData> OnItemClickCallback;

	// Token: 0x0400A886 RID: 43142
	public Func<int?> GetStageIdCallback;

	// Token: 0x0400A887 RID: 43143
	private bool? IsLastSelected;
}
