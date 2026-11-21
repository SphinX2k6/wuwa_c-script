using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Skin;

// Token: 0x02001FBB RID: 8123
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CalabashSkinGridItem : LoopScrollSmallItemGrid<CalabashSkinData>
{
	// Token: 0x06014286 RID: 82566 RVA: 0x005E20FC File Offset: 0x005E02FC
	public override void OnSelected(bool fireEvent)
	{
		if (fireEvent)
		{
			this.SetSelected(true, true);
		}
		CalabashSkinData calabashSkinData = this.Data as CalabashSkinData;
		if (calabashSkinData.IsNew)
		{
			CalabashSkinModel.Instance.RemoveCalabashSkinRedDot(calabashSkinData.SkinId);
			base.SetNewFlagVisible(new bool?(false));
		}
	}

	// Token: 0x06014287 RID: 82567 RVA: 0x005E2144 File Offset: 0x005E0344
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x06014288 RID: 82568 RVA: 0x005E2150 File Offset: 0x005E0350
	protected override void OnRefresh(CalabashSkinData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		PropSmallItemGrid propSmallItemGrid = new PropSmallItemGrid
		{
			Data = data,
			IconPath = (data.IsEmptyData ? SkinConfig.Instance.GetDefaultCalabashSkinIconPath() : null),
			ItemConfigId = (data.IsEmptyData ? null : new int?(data.SkinId)),
			IsNewVisible = new bool?(data.IsNew),
			QualityId = (data.IsEmptyData ? new int?(5) : null)
		};
		base.Apply<PropSmallItemGrid>(propSmallItemGrid);
		this.SetSelected(isSelected, false);
		base.SetLockBlackVisible(data.GetIsLock());
		this.RefreshVisible();
		if (data.IsEmptyData)
		{
			base.SetSkinQualityByParameters(propSmallItemGrid);
			base.RefreshSkinByDefault(propSmallItemGrid.QualityId.Value, InventoryDefine.EItemDataType.CalabashSkinItem);
		}
	}

	// Token: 0x06014289 RID: 82569 RVA: 0x005E2224 File Offset: 0x005E0424
	public void RefreshVisible()
	{
		CalabashSkinData calabashSkinData = this.Data as CalabashSkinData;
		base.SetSelectVisible(calabashSkinData.IsCurrentEquipSkinId());
	}
}
