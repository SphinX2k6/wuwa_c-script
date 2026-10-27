using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017B1 RID: 6065
[NullableContext(1)]
[Nullable(0)]
public abstract class AutoAttachExhibitionItemAbstract : UiPanelBase, IAutoAttachExhibitionItem
{
	// Token: 0x0600B103 RID: 45315 RVA: 0x0028144F File Offset: 0x0027F64F
	public AutoAttachExhibitionItemAbstract(AActor uiItem)
	{
		base.CreateThenShowByActor(uiItem, null);
	}

	// Token: 0x0600B104 RID: 45316 RVA: 0x0028145F File Offset: 0x0027F65F
	public void SetShowItemIndex(int showIndex)
	{
		this.CurrentShowItemIndex = showIndex;
	}

	// Token: 0x0600B105 RID: 45317 RVA: 0x00281468 File Offset: 0x0027F668
	public int GetShowItemIndex()
	{
		return this.CurrentShowItemIndex;
	}

	// Token: 0x0600B106 RID: 45318 RVA: 0x00281470 File Offset: 0x0027F670
	public void OnChangeDirection(int direction)
	{
	}

	// Token: 0x0600B107 RID: 45319 RVA: 0x00281472 File Offset: 0x0027F672
	public virtual void RefreshItem(int showItemIndex)
	{
	}

	// Token: 0x0600B108 RID: 45320 RVA: 0x00281474 File Offset: 0x0027F674
	public virtual void SetData(object param)
	{
	}

	// Token: 0x0600B109 RID: 45321 RVA: 0x00281476 File Offset: 0x0027F676
	public virtual void OnMoveItem(float offset)
	{
	}

	// Token: 0x0600B10A RID: 45322 RVA: 0x00281478 File Offset: 0x0027F678
	public virtual void OnUnSelect()
	{
	}

	// Token: 0x0600B10B RID: 45323 RVA: 0x0028147A File Offset: 0x0027F67A
	public virtual void OnSelect()
	{
	}

	// Token: 0x0600B10C RID: 45324 RVA: 0x0028147C File Offset: 0x0027F67C
	public void SetAttachItem(AutoAttachExhibitionItem item)
	{
		this.AttachItem = item;
	}

	// Token: 0x0600B10D RID: 45325 RVA: 0x00281485 File Offset: 0x0027F685
	[NullableContext(2)]
	public AutoAttachExhibitionItem GetAttachItem()
	{
		return this.AttachItem;
	}

	// Token: 0x0600B10E RID: 45326 RVA: 0x0028148D File Offset: 0x0027F68D
	public virtual void Clear()
	{
	}

	// Token: 0x04005040 RID: 20544
	public int CurrentShowItemIndex;

	// Token: 0x04005041 RID: 20545
	[Nullable(2)]
	protected AutoAttachExhibitionItem AttachItem;
}
