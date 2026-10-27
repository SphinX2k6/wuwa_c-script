using System;
using UnrealEngine;

// Token: 0x02001FC5 RID: 8133
public class DestroyPreviewGrid : LoopScrollSmallItemGrid<TItem>
{
	// Token: 0x0600FE63 RID: 65123 RVA: 0x003DC040 File Offset: 0x003DA240
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

	// Token: 0x0600FE64 RID: 65124 RVA: 0x003DC096 File Offset: 0x003DA296
	protected override void OnStart()
	{
		base.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
	}

	// Token: 0x0600FE65 RID: 65125 RVA: 0x003DC0BD File Offset: 0x003DA2BD
	public override void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600FE66 RID: 65126 RVA: 0x003DC0BF File Offset: 0x003DA2BF
	public override void OnDeselected(bool fireEvent)
	{
	}
}
