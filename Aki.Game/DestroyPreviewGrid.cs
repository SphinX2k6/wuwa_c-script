using System;
using UnrealEngine;

// Token: 0x02001498 RID: 5272
public class DestroyPreviewGrid : LoopScrollSmallItemGrid<TItem>
{
	// Token: 0x0600D2CB RID: 53963 RVA: 0x003E861C File Offset: 0x003E681C
	protected override void OnRefresh(TItem data, bool isSelected, int gridIndex)
	{
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			Data = data,
			BottomText = data.Count.ToString(),
			ItemConfigId = new int?(data.ItemData.ItemId)
		};
		base.Apply<PropSmallItemGrid>(parameters);
		this.SetSelected(false, false);
	}

	// Token: 0x0600D2CC RID: 53964 RVA: 0x003E8672 File Offset: 0x003E6872
	protected override void OnStart()
	{
		base.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
	}

	// Token: 0x0600D2CD RID: 53965 RVA: 0x003E8699 File Offset: 0x003E6899
	public override void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600D2CE RID: 53966 RVA: 0x003E869B File Offset: 0x003E689B
	public override void OnDeselected(bool fireEvent)
	{
	}
}
