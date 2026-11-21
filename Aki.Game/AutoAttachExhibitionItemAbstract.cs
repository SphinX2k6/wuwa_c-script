using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000C6A RID: 3178
[NullableContext(1)]
[Nullable(0)]
public abstract class AutoAttachExhibitionItemAbstract : UiPanelBase, IAutoAttachExhibitionItem
{
	// Token: 0x060084EB RID: 34027 RVA: 0x0028B9E7 File Offset: 0x00289BE7
	public AutoAttachExhibitionItemAbstract(AActor uiItem)
	{
		base.CreateThenShowByActor(uiItem, null);
	}

	// Token: 0x060084EC RID: 34028 RVA: 0x0028B9F7 File Offset: 0x00289BF7
	public void SetShowItemIndex(int showIndex)
	{
		this.CurrentShowItemIndex = showIndex;
	}

	// Token: 0x060084ED RID: 34029 RVA: 0x0028BA00 File Offset: 0x00289C00
	public int GetShowItemIndex()
	{
		return this.CurrentShowItemIndex;
	}

	// Token: 0x060084EE RID: 34030 RVA: 0x0028BA08 File Offset: 0x00289C08
	public void OnChangeDirection(int direction)
	{
	}

	// Token: 0x060084EF RID: 34031 RVA: 0x0028BA0A File Offset: 0x00289C0A
	public virtual void RefreshItem(int showItemIndex)
	{
	}

	// Token: 0x060084F0 RID: 34032 RVA: 0x0028BA0C File Offset: 0x00289C0C
	public virtual void SetData(object param)
	{
	}

	// Token: 0x060084F1 RID: 34033 RVA: 0x0028BA0E File Offset: 0x00289C0E
	public virtual void OnMoveItem(float offset)
	{
	}

	// Token: 0x060084F2 RID: 34034 RVA: 0x0028BA10 File Offset: 0x00289C10
	public virtual void OnUnSelect()
	{
	}

	// Token: 0x060084F3 RID: 34035 RVA: 0x0028BA12 File Offset: 0x00289C12
	public virtual void OnSelect()
	{
	}

	// Token: 0x060084F4 RID: 34036 RVA: 0x0028BA14 File Offset: 0x00289C14
	public void SetAttachItem(AutoAttachExhibitionItem item)
	{
		this.AttachItem = item;
	}

	// Token: 0x060084F5 RID: 34037 RVA: 0x0028BA1D File Offset: 0x00289C1D
	[NullableContext(2)]
	public AutoAttachExhibitionItem GetAttachItem()
	{
		return this.AttachItem;
	}

	// Token: 0x060084F6 RID: 34038 RVA: 0x0028BA25 File Offset: 0x00289C25
	public virtual void Clear()
	{
	}

	// Token: 0x040050EA RID: 20714
	public int CurrentShowItemIndex;

	// Token: 0x040050EB RID: 20715
	[Nullable(2)]
	protected AutoAttachExhibitionItem AttachItem;
}
