using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020017B2 RID: 6066
[NullableContext(1)]
[Nullable(0)]
public class AutoAttachExhibitionItem
{
	// Token: 0x0600B10F RID: 45327 RVA: 0x00281490 File Offset: 0x0027F690
	public AutoAttachExhibitionItem(AActor actor, int index, int showNum)
	{
		this.Actor = (actor.GetComponentByClass(UUIItem.StaticClass()) as UUIItem);
		this.FullSizeX = this.Actor.GetWidth();
		this.FullSizeY = this.Actor.GetHeight();
		this.Index = index;
		this.ShowItemNum = showNum;
	}

	// Token: 0x0600B110 RID: 45328 RVA: 0x00281504 File Offset: 0x0027F704
	public void SetViewItem(AutoAttachExhibitionItemAbstract view)
	{
		this.ViewItem = view;
		this.ViewItem.SetAttachItem(this);
	}

	// Token: 0x0600B111 RID: 45329 RVA: 0x00281519 File Offset: 0x0027F719
	public void SetActive(bool state)
	{
		this.Actor.SetUIActive(state);
	}

	// Token: 0x0600B112 RID: 45330 RVA: 0x00281527 File Offset: 0x0027F727
	public void Init(AutoAttachExhibitionView exhibitionView)
	{
		this.ExhibitionView = exhibitionView;
		this.CurrentDirection = exhibitionView.Direction;
		this.DataLength = exhibitionView.GetDataLength();
		this.OnInit();
		this.SelectState = false;
		this.OnUnSelect();
	}

	// Token: 0x0600B113 RID: 45331 RVA: 0x0028155B File Offset: 0x0027F75B
	public void ForceUnSelectItem()
	{
		this.SelectState = false;
		this.OnUnSelect();
	}

	// Token: 0x0600B114 RID: 45332 RVA: 0x0028156A File Offset: 0x0027F76A
	protected virtual void OnInit()
	{
	}

	// Token: 0x0600B115 RID: 45333 RVA: 0x0028156C File Offset: 0x0027F76C
	public void OnControllerDragStart()
	{
		this.DragState = true;
	}

	// Token: 0x0600B116 RID: 45334 RVA: 0x00281575 File Offset: 0x0027F775
	public void MoveItem(Number offset)
	{
		this.OnMoveItem(offset);
		this.ViewItem.OnMoveItem(offset);
	}

	// Token: 0x0600B117 RID: 45335 RVA: 0x00281590 File Offset: 0x0027F790
	protected virtual void OnMoveItem(Number vectorX)
	{
	}

	// Token: 0x0600B118 RID: 45336 RVA: 0x00281592 File Offset: 0x0027F792
	protected void OnMoveFromRightToLeft()
	{
		this.ViewItem.OnChangeDirection(1);
	}

	// Token: 0x0600B119 RID: 45337 RVA: 0x002815A0 File Offset: 0x0027F7A0
	protected void OnMoveFromLeftToRight()
	{
		this.ViewItem.OnChangeDirection(-1);
	}

	// Token: 0x0600B11A RID: 45338 RVA: 0x002815AE File Offset: 0x0027F7AE
	protected void OnMoveFromDownToUp()
	{
		this.ViewItem.OnChangeDirection(1);
	}

	// Token: 0x0600B11B RID: 45339 RVA: 0x002815BC File Offset: 0x0027F7BC
	protected void OnMoveFromUpToDown()
	{
		this.ViewItem.OnChangeDirection(-1);
	}

	// Token: 0x0600B11C RID: 45340 RVA: 0x002815CA File Offset: 0x0027F7CA
	public void RefreshItem()
	{
		this.ViewItem.SetShowItemIndex(this.ShowItemIndex);
		this.ViewItem.RefreshItem(this.ShowItemIndex);
	}

	// Token: 0x0600B11D RID: 45341 RVA: 0x002815EE File Offset: 0x0027F7EE
	public void SetData(object param)
	{
		this.ViewItem.SetData(param);
	}

	// Token: 0x0600B11E RID: 45342 RVA: 0x002815FC File Offset: 0x0027F7FC
	public void OnControllerDragEnd()
	{
		this.DragState = false;
	}

	// Token: 0x0600B11F RID: 45343 RVA: 0x00281605 File Offset: 0x0027F805
	public Number GetItemPositionX()
	{
		return this.Actor.GetAnchorOffsetX();
	}

	// Token: 0x0600B120 RID: 45344 RVA: 0x00281617 File Offset: 0x0027F817
	public Number GetItemPositionY()
	{
		return this.Actor.GetAnchorOffsetY();
	}

	// Token: 0x0600B121 RID: 45345 RVA: 0x00281629 File Offset: 0x0027F829
	public bool GetSelectState()
	{
		return this.SelectState;
	}

	// Token: 0x0600B122 RID: 45346 RVA: 0x00281631 File Offset: 0x0027F831
	public void Select()
	{
		if (!this.SelectState)
		{
			this.SelectState = true;
			this.ExhibitionView.SelectedIndex = this.ShowItemIndex;
			this.OnSelect();
		}
	}

	// Token: 0x0600B123 RID: 45347 RVA: 0x00281659 File Offset: 0x0027F859
	protected virtual void OnSelect()
	{
		this.ViewItem.OnSelect();
	}

	// Token: 0x0600B124 RID: 45348 RVA: 0x00281666 File Offset: 0x0027F866
	public void UnSelect()
	{
		if (this.SelectState)
		{
			this.SelectState = false;
			this.OnUnSelect();
		}
	}

	// Token: 0x0600B125 RID: 45349 RVA: 0x0028167D File Offset: 0x0027F87D
	protected virtual void OnUnSelect()
	{
		this.ViewItem.OnUnSelect();
	}

	// Token: 0x0600B126 RID: 45350 RVA: 0x0028168A File Offset: 0x0027F88A
	public void Clear()
	{
		this.ViewItem.Clear();
	}

	// Token: 0x04005042 RID: 20546
	protected bool SelectState;

	// Token: 0x04005043 RID: 20547
	protected EAutoAttachExhibitionViewDirection? CurrentDirection;

	// Token: 0x04005044 RID: 20548
	protected int Index;

	// Token: 0x04005045 RID: 20549
	public Number InitGap = 0;

	// Token: 0x04005046 RID: 20550
	protected int ShowItemNum;

	// Token: 0x04005047 RID: 20551
	protected int DataLength;

	// Token: 0x04005048 RID: 20552
	protected bool DragState;

	// Token: 0x04005049 RID: 20553
	protected readonly UUIItem Actor;

	// Token: 0x0400504A RID: 20554
	protected readonly Number FullSizeX;

	// Token: 0x0400504B RID: 20555
	protected readonly Number FullSizeY;

	// Token: 0x0400504C RID: 20556
	[Nullable(2)]
	public AutoAttachExhibitionView ExhibitionView;

	// Token: 0x0400504D RID: 20557
	[Nullable(2)]
	private AutoAttachExhibitionItemAbstract ViewItem;

	// Token: 0x0400504E RID: 20558
	public int ShowItemIndex;
}
