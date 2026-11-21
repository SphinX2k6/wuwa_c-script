using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000C6B RID: 3179
[NullableContext(1)]
[Nullable(0)]
public class AutoAttachExhibitionItem
{
	// Token: 0x060084F7 RID: 34039 RVA: 0x0028BA28 File Offset: 0x00289C28
	public AutoAttachExhibitionItem(AActor actor, int index, int showNum)
	{
		this.Actor = (actor.GetComponentByClass(UUIItem.StaticClass()) as UUIItem);
		this.FullSizeX = this.Actor.GetWidth();
		this.FullSizeY = this.Actor.GetHeight();
		this.Index = index;
		this.ShowItemNum = showNum;
	}

	// Token: 0x060084F8 RID: 34040 RVA: 0x0028BA9C File Offset: 0x00289C9C
	public void SetViewItem(AutoAttachExhibitionItemAbstract view)
	{
		this.ViewItem = view;
		this.ViewItem.SetAttachItem(this);
	}

	// Token: 0x060084F9 RID: 34041 RVA: 0x0028BAB1 File Offset: 0x00289CB1
	public void SetActive(bool state)
	{
		this.Actor.SetUIActive(state);
	}

	// Token: 0x060084FA RID: 34042 RVA: 0x0028BABF File Offset: 0x00289CBF
	public void Init(AutoAttachExhibitionView exhibitionView)
	{
		this.ExhibitionView = exhibitionView;
		this.CurrentDirection = exhibitionView.Direction;
		this.DataLength = exhibitionView.GetDataLength();
		this.OnInit();
		this.SelectState = false;
		this.OnUnSelect();
	}

	// Token: 0x060084FB RID: 34043 RVA: 0x0028BAF3 File Offset: 0x00289CF3
	public void ForceUnSelectItem()
	{
		this.SelectState = false;
		this.OnUnSelect();
	}

	// Token: 0x060084FC RID: 34044 RVA: 0x0028BB02 File Offset: 0x00289D02
	protected virtual void OnInit()
	{
	}

	// Token: 0x060084FD RID: 34045 RVA: 0x0028BB04 File Offset: 0x00289D04
	public void OnControllerDragStart()
	{
		this.DragState = true;
	}

	// Token: 0x060084FE RID: 34046 RVA: 0x0028BB0D File Offset: 0x00289D0D
	public void MoveItem(Number offset)
	{
		this.OnMoveItem(offset);
		this.ViewItem.OnMoveItem(offset);
	}

	// Token: 0x060084FF RID: 34047 RVA: 0x0028BB28 File Offset: 0x00289D28
	protected virtual void OnMoveItem(Number vectorX)
	{
	}

	// Token: 0x06008500 RID: 34048 RVA: 0x0028BB2A File Offset: 0x00289D2A
	protected void OnMoveFromRightToLeft()
	{
		this.ViewItem.OnChangeDirection(1);
	}

	// Token: 0x06008501 RID: 34049 RVA: 0x0028BB38 File Offset: 0x00289D38
	protected void OnMoveFromLeftToRight()
	{
		this.ViewItem.OnChangeDirection(-1);
	}

	// Token: 0x06008502 RID: 34050 RVA: 0x0028BB46 File Offset: 0x00289D46
	protected void OnMoveFromDownToUp()
	{
		this.ViewItem.OnChangeDirection(1);
	}

	// Token: 0x06008503 RID: 34051 RVA: 0x0028BB54 File Offset: 0x00289D54
	protected void OnMoveFromUpToDown()
	{
		this.ViewItem.OnChangeDirection(-1);
	}

	// Token: 0x06008504 RID: 34052 RVA: 0x0028BB62 File Offset: 0x00289D62
	public void RefreshItem()
	{
		this.ViewItem.SetShowItemIndex(this.ShowItemIndex);
		this.ViewItem.RefreshItem(this.ShowItemIndex);
	}

	// Token: 0x06008505 RID: 34053 RVA: 0x0028BB86 File Offset: 0x00289D86
	public void SetData(object param)
	{
		this.ViewItem.SetData(param);
	}

	// Token: 0x06008506 RID: 34054 RVA: 0x0028BB94 File Offset: 0x00289D94
	public void OnControllerDragEnd()
	{
		this.DragState = false;
	}

	// Token: 0x06008507 RID: 34055 RVA: 0x0028BB9D File Offset: 0x00289D9D
	public Number GetItemPositionX()
	{
		return this.Actor.GetAnchorOffsetX();
	}

	// Token: 0x06008508 RID: 34056 RVA: 0x0028BBAF File Offset: 0x00289DAF
	public Number GetItemPositionY()
	{
		return this.Actor.GetAnchorOffsetY();
	}

	// Token: 0x06008509 RID: 34057 RVA: 0x0028BBC1 File Offset: 0x00289DC1
	public bool GetSelectState()
	{
		return this.SelectState;
	}

	// Token: 0x0600850A RID: 34058 RVA: 0x0028BBC9 File Offset: 0x00289DC9
	public void Select()
	{
		if (!this.SelectState)
		{
			this.SelectState = true;
			this.ExhibitionView.SelectedIndex = this.ShowItemIndex;
			this.OnSelect();
		}
	}

	// Token: 0x0600850B RID: 34059 RVA: 0x0028BBF1 File Offset: 0x00289DF1
	protected virtual void OnSelect()
	{
		this.ViewItem.OnSelect();
	}

	// Token: 0x0600850C RID: 34060 RVA: 0x0028BBFE File Offset: 0x00289DFE
	public void UnSelect()
	{
		if (this.SelectState)
		{
			this.SelectState = false;
			this.OnUnSelect();
		}
	}

	// Token: 0x0600850D RID: 34061 RVA: 0x0028BC15 File Offset: 0x00289E15
	protected virtual void OnUnSelect()
	{
		this.ViewItem.OnUnSelect();
	}

	// Token: 0x0600850E RID: 34062 RVA: 0x0028BC22 File Offset: 0x00289E22
	public void Clear()
	{
		this.ViewItem.Clear();
	}

	// Token: 0x040050EC RID: 20716
	protected bool SelectState;

	// Token: 0x040050ED RID: 20717
	protected EAutoAttachExhibitionViewDirection? CurrentDirection;

	// Token: 0x040050EE RID: 20718
	protected int Index;

	// Token: 0x040050EF RID: 20719
	public Number InitGap = 0;

	// Token: 0x040050F0 RID: 20720
	protected int ShowItemNum;

	// Token: 0x040050F1 RID: 20721
	protected int DataLength;

	// Token: 0x040050F2 RID: 20722
	protected bool DragState;

	// Token: 0x040050F3 RID: 20723
	protected readonly UUIItem Actor;

	// Token: 0x040050F4 RID: 20724
	protected readonly Number FullSizeX;

	// Token: 0x040050F5 RID: 20725
	protected readonly Number FullSizeY;

	// Token: 0x040050F6 RID: 20726
	[Nullable(2)]
	public AutoAttachExhibitionView ExhibitionView;

	// Token: 0x040050F7 RID: 20727
	[Nullable(2)]
	private AutoAttachExhibitionItemAbstract ViewItem;

	// Token: 0x040050F8 RID: 20728
	public int ShowItemIndex;
}
