using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Skin;

// Token: 0x02002A40 RID: 10816
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CalabashSkinGridItem : LoopScrollSmallItemGrid<CalabashSkinData>
{
	// Token: 0x06016865 RID: 92261 RVA: 0x005B5F94 File Offset: 0x005B4194
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

	// Token: 0x06016866 RID: 92262 RVA: 0x005B5FDC File Offset: 0x005B41DC
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x06016867 RID: 92263 RVA: 0x005B5FE8 File Offset: 0x005B41E8
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

	// Token: 0x06016868 RID: 92264 RVA: 0x005B60BC File Offset: 0x005B42BC
	public void RefreshVisible()
	{
		CalabashSkinData calabashSkinData = this.Data as CalabashSkinData;
		base.SetSelectVisible(calabashSkinData.IsCurrentEquipSkinId());
	}
}
