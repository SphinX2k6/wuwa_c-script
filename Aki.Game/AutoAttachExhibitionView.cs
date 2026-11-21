using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000C6E RID: 3182
[NullableContext(1)]
[Nullable(0)]
public class AutoAttachExhibitionView
{
	// Token: 0x17000ECF RID: 3791
	// (get) Token: 0x0600850F RID: 34063 RVA: 0x0028BC2F File Offset: 0x00289E2F
	public EAutoAttachExhibitionViewDirection? Direction
	{
		get
		{
			return this.CurrentDirection;
		}
	}

	// Token: 0x06008510 RID: 34064 RVA: 0x0028BC38 File Offset: 0x00289E38
	public AutoAttachExhibitionView(AActor controllerActor)
	{
		this.Actor = controllerActor;
		this.ItemActor = (controllerActor.GetComponentByClass(UUIItem.StaticClass()) as UUIItem);
	}

	// Token: 0x06008511 RID: 34065 RVA: 0x0028BD04 File Offset: 0x00289F04
	public void SetVelocitySupport(bool state)
	{
		this.SupportVelocity = state;
	}

	// Token: 0x06008512 RID: 34066 RVA: 0x0028BD0D File Offset: 0x00289F0D
	public void SetVelocityFactor(Number factor)
	{
		this.VelocityFactor = factor;
	}

	// Token: 0x06008513 RID: 34067 RVA: 0x0028BD16 File Offset: 0x00289F16
	public void SetItemOnSelectTime(EItemOnSelectTime onSelectTime)
	{
		this.ItemOnSelectTime = onSelectTime;
	}

	// Token: 0x06008514 RID: 34068 RVA: 0x0028BD1F File Offset: 0x00289F1F
	public void SetBoundDistance(Number distance)
	{
		this.BoundDistance = distance;
	}

	// Token: 0x06008515 RID: 34069 RVA: 0x0028BD28 File Offset: 0x00289F28
	public int GetDataLength()
	{
		return this.DataLength;
	}

	// Token: 0x06008516 RID: 34070 RVA: 0x0028BD30 File Offset: 0x00289F30
	public void Destroy()
	{
		if (this.Actor != null)
		{
			ActorSystem.Instance.Put("AutoAttachExhibitionView.Destroy", this.Actor, null);
		}
		this.Actor = null;
	}

	// Token: 0x06008517 RID: 34071 RVA: 0x0028BD58 File Offset: 0x00289F58
	public void CreateItems(AActor itemActor, int showItemNum, Number initGap, Func<AActor, int, int, AutoAttachExhibitionItem> createFunction, EAutoAttachExhibitionViewDirection? direction = null)
	{
		this.AddDragEvent();
		this.CreateItemFunction = createFunction;
		this.CreateSourceActor = itemActor;
		this.CreateSourceUiActor = (this.CreateSourceActor.GetComponentByClass(UUIItem.StaticClass()) as UUIItem);
		this.ShowItemNum = showItemNum;
		this.CheckItemSizeChange();
		this.Gap = initGap;
	}

	// Token: 0x06008518 RID: 34072 RVA: 0x0028BDB0 File Offset: 0x00289FB0
	private void CheckItemSizeChange()
	{
		this.ItemSizeX = this.CreateSourceUiActor.GetWidth();
		this.ItemSizeY = this.CreateSourceUiActor.GetHeight();
		this.Width = this.ItemActor.GetWidth();
		this.Height = this.ItemActor.GetHeight();
		EAutoAttachExhibitionViewDirection? currentDirection = this.CurrentDirection;
		EAutoAttachExhibitionViewDirection eautoAttachExhibitionViewDirection = EAutoAttachExhibitionViewDirection.Horizontal;
		if (currentDirection.GetValueOrDefault() == eautoAttachExhibitionViewDirection & currentDirection != null)
		{
			this.BoundDistance = this.ItemSizeX;
			return;
		}
		this.BoundDistance = this.ItemSizeY;
	}

	// Token: 0x06008519 RID: 34073 RVA: 0x0028BE4B File Offset: 0x0028A04B
	public void ReloadView(int showItemNum, object data)
	{
	}

	// Token: 0x0600851A RID: 34074 RVA: 0x0028BE50 File Offset: 0x0028A050
	public void DisableDragEvent()
	{
		if (this.Actor != null)
		{
			UUIDraggableComponent uuidraggableComponent = this.Actor.GetComponentByClass(UUIDraggableComponent.StaticClass()) as UUIDraggableComponent;
			if (uuidraggableComponent != null)
			{
				uuidraggableComponent.OnPointerBeginDragCallBack.Unbind();
				uuidraggableComponent.OnPointerDragCallBack.Unbind();
				uuidraggableComponent.OnPointerEndDragCallBack.Unbind();
			}
		}
	}

	// Token: 0x0600851B RID: 34075 RVA: 0x0028BEA4 File Offset: 0x0028A0A4
	public void AddDragEvent()
	{
		if (this.Actor != null)
		{
			UUIDraggableComponent uuidraggableComponent = this.Actor.GetComponentByClass(UUIDraggableComponent.StaticClass()) as UUIDraggableComponent;
			if (uuidraggableComponent != null)
			{
				uuidraggableComponent.OnPointerBeginDragCallBack.Bind(delegate(ULGUIPointerEventData eventData)
				{
					this.OnPointerBeginDrag(eventData);
				});
				uuidraggableComponent.OnPointerDragCallBack.Bind(delegate(ULGUIPointerEventData eventData)
				{
					this.OnPointerDrag(eventData);
				});
				uuidraggableComponent.OnPointerEndDragCallBack.Bind(delegate(ULGUIPointerEventData eventData)
				{
					this.OnPointerEndDrag(eventData);
				});
			}
		}
	}

	// Token: 0x0600851C RID: 34076 RVA: 0x0028BF1C File Offset: 0x0028A11C
	protected void SetData(object data)
	{
		for (int i = 0; i < this.Items.Count; i++)
		{
			this.Items[i].SetData(data);
		}
	}

	// Token: 0x0600851D RID: 34077 RVA: 0x0028BF54 File Offset: 0x0028A154
	protected void InitItems()
	{
		for (int i = 0; i < this.Items.Count; i++)
		{
			this.Items[i].Init(this);
		}
		this.RefreshItemsView();
	}

	// Token: 0x0600851E RID: 34078 RVA: 0x0028BF90 File Offset: 0x0028A190
	protected void ForceUnSelectItems()
	{
		for (int i = 0; i < this.Items.Count; i++)
		{
			this.Items[i].ForceUnSelectItem();
		}
		this.CurrentSelectState = false;
	}

	// Token: 0x0600851F RID: 34079 RVA: 0x0028BFCB File Offset: 0x0028A1CB
	public void SetAttachTime(Number attachTime)
	{
		this.AttachTime = attachTime;
	}

	// Token: 0x06008520 RID: 34080 RVA: 0x0028BFD4 File Offset: 0x0028A1D4
	protected void RefreshItemsView()
	{
		for (int i = 0; i < this.Items.Count; i++)
		{
			this.Items[i].RefreshItem();
		}
	}

	// Token: 0x06008521 RID: 34081 RVA: 0x0028C008 File Offset: 0x0028A208
	[NullableContext(2)]
	public AutoAttachExhibitionItem FindNearestMiddleItem()
	{
		AutoAttachExhibitionItem autoAttachExhibitionItem = this.Items[0];
		if (autoAttachExhibitionItem == null)
		{
			return null;
		}
		Number b = 0;
		EAutoAttachExhibitionViewDirection? currentDirection = this.CurrentDirection;
		EAutoAttachExhibitionViewDirection eautoAttachExhibitionViewDirection = EAutoAttachExhibitionViewDirection.Horizontal;
		if (currentDirection.GetValueOrDefault() == eautoAttachExhibitionViewDirection & currentDirection != null)
		{
			b = Math.Abs(this.Items[0].GetItemPositionX());
		}
		else
		{
			b = Math.Abs(this.Items[0].GetItemPositionY());
		}
		for (int i = 0; i < this.Items.Count; i++)
		{
			Number number = 0;
			currentDirection = this.CurrentDirection;
			eautoAttachExhibitionViewDirection = EAutoAttachExhibitionViewDirection.Horizontal;
			if (currentDirection.GetValueOrDefault() == eautoAttachExhibitionViewDirection & currentDirection != null)
			{
				number = Math.Abs(this.Items[i].GetItemPositionX());
			}
			else
			{
				number = Math.Abs(this.Items[i].GetItemPositionY());
			}
			if (number < b)
			{
				autoAttachExhibitionItem = this.Items[i];
				b = number;
			}
		}
		return autoAttachExhibitionItem;
	}

	// Token: 0x06008522 RID: 34082 RVA: 0x0028C138 File Offset: 0x0028A338
	public List<AutoAttachExhibitionItem> GetItems()
	{
		return this.Items;
	}

	// Token: 0x06008523 RID: 34083 RVA: 0x0028C140 File Offset: 0x0028A340
	[NullableContext(2)]
	public AutoAttachExhibitionItem GetItemByShowIndex(int showItemIndex)
	{
		foreach (AutoAttachExhibitionItem autoAttachExhibitionItem in this.Items)
		{
			if (autoAttachExhibitionItem.ShowItemIndex == showItemIndex)
			{
				return autoAttachExhibitionItem;
			}
		}
		return null;
	}

	// Token: 0x06008524 RID: 34084 RVA: 0x0028C19C File Offset: 0x0028A39C
	public void ScrollToItem(int finishTick, AutoAttachExhibitionItem item)
	{
		if (this.InertiaState)
		{
			return;
		}
		Number number = 0;
		EAutoAttachExhibitionViewDirection? currentDirection = this.CurrentDirection;
		EAutoAttachExhibitionViewDirection eautoAttachExhibitionViewDirection = EAutoAttachExhibitionViewDirection.Horizontal;
		if (currentDirection.GetValueOrDefault() == eautoAttachExhibitionViewDirection & currentDirection != null)
		{
			number = item.GetItemPositionX();
		}
		else
		{
			number = item.GetItemPositionY();
		}
		this.Distance = -number;
		for (int i = 0; i < this.Items.Count; i++)
		{
			this.Items[i].UnSelect();
		}
		this.CurrentSelectState = false;
		this.CurrentShowItemIndex = item.ShowItemIndex;
		if (finishTick == 0)
		{
			this.MoveItems(-number);
			return;
		}
		this.CurrentTick = 0;
		this.FinishTick = finishTick;
		this.InertiaState = true;
	}

	// Token: 0x06008525 RID: 34085 RVA: 0x0028C264 File Offset: 0x0028A464
	protected void ScrollToIndex(int finishTick, int itemIndex)
	{
		this.AttachToIndex(finishTick, itemIndex);
	}

	// Token: 0x06008526 RID: 34086 RVA: 0x0028C26E File Offset: 0x0028A46E
	public void AttachToIndex(int finishTick, int showItemIndex)
	{
		this.AttachToIndex2(finishTick, showItemIndex);
	}

	// Token: 0x06008527 RID: 34087 RVA: 0x0028C278 File Offset: 0x0028A478
	private void AttachToIndex2(int finishTick, int showItemIndex)
	{
		if (this.InertiaState)
		{
			return;
		}
		AutoAttachExhibitionItem showIndexItem = this.GetShowIndexItem(showItemIndex);
		if (showIndexItem != null)
		{
			this.ScrollToItem(finishTick, showIndexItem);
			return;
		}
		for (int i = 0; i < this.Items.Count; i++)
		{
			this.Items[i].UnSelect();
		}
		this.CurrentSelectState = false;
		this.CurrentShowItemIndex = showItemIndex;
		AutoAttachExhibitionItem autoAttachExhibitionItem = this.FindNearestMiddleItem();
		if (autoAttachExhibitionItem == null)
		{
			return;
		}
		int value = showItemIndex - autoAttachExhibitionItem.ShowItemIndex;
		Number number = 0;
		EAutoAttachExhibitionViewDirection? currentDirection = this.CurrentDirection;
		EAutoAttachExhibitionViewDirection eautoAttachExhibitionViewDirection = EAutoAttachExhibitionViewDirection.Horizontal;
		if (currentDirection.GetValueOrDefault() == eautoAttachExhibitionViewDirection & currentDirection != null)
		{
			number = (this.ItemSizeX + this.Gap) * value - autoAttachExhibitionItem.GetItemPositionX();
		}
		else
		{
			number = -1 * ((this.ItemSizeY + this.Gap) * value - autoAttachExhibitionItem.GetItemPositionY());
		}
		this.Distance = -number;
		if (finishTick == 0)
		{
			this.MoveItems(-number);
			return;
		}
		this.CurrentTick = 0;
		this.FinishTick = finishTick;
		this.InertiaState = true;
	}

	// Token: 0x06008528 RID: 34088 RVA: 0x0028C3B4 File Offset: 0x0028A5B4
	public void Tick(Number deltaTime)
	{
		if (this.DragState || (!this.InertiaState && !this.VelocityMoveState))
		{
			if (this.InertiaState)
			{
				this.InertiaState = false;
				this.CurrentTick = 0;
				if (!this.CurrentSelectState && this.ItemOnSelectTime == EItemOnSelectTime.EndMove)
				{
					for (int i = 0; i < this.Items.Count; i++)
					{
						AutoAttachExhibitionItem autoAttachExhibitionItem = this.Items[i];
						if (autoAttachExhibitionItem.ShowItemIndex == this.CurrentShowItemIndex && !autoAttachExhibitionItem.GetSelectState())
						{
							autoAttachExhibitionItem.Select();
							this.CurrentSelectState = true;
						}
					}
				}
			}
			this.VelocityMoveState = false;
			return;
		}
		if (this.VelocityMoveState)
		{
			this.CurrentVelocity = this.ReCalculateOffset(this.CurrentVelocity);
			this.DoVelocityMove(deltaTime);
			return;
		}
		if (this.CurrentTick < this.FinishTick)
		{
			this.DoElasticMove();
			return;
		}
		this.InertiaState = false;
	}

	// Token: 0x06008529 RID: 34089 RVA: 0x0028C48C File Offset: 0x0028A68C
	private void DoVelocityMove(Number deltaTime)
	{
		this.CurrentVelocityTime += deltaTime / 100;
		if (this.VelocityDirection > 0)
		{
			this.MoveItems(this.CurrentVelocity);
			this.CurrentVelocity -= this.VelocityFactor * this.CurrentVelocityTime;
			if (this.CurrentVelocity <= 0)
			{
				this.EndVelocityMove();
				return;
			}
		}
		else if (this.VelocityDirection < 0)
		{
			this.MoveItems(this.CurrentVelocity);
			this.CurrentVelocity += this.VelocityFactor * this.CurrentVelocityTime;
			if (this.CurrentVelocity >= 0)
			{
				this.EndVelocityMove();
			}
		}
	}

	// Token: 0x0600852A RID: 34090 RVA: 0x0028C558 File Offset: 0x0028A758
	protected Number ReCalculateOffset(Number offset)
	{
		return offset;
	}

	// Token: 0x0600852B RID: 34091 RVA: 0x0028C55C File Offset: 0x0028A75C
	protected void EndVelocityMove()
	{
		this.VelocityMoveState = false;
		this.InertiaState = false;
		AutoAttachExhibitionItem autoAttachExhibitionItem = this.FindAutoAttachItem();
		this.ScrollToIndex(this.AttachTime, autoAttachExhibitionItem.ShowItemIndex);
	}

	// Token: 0x0600852C RID: 34092 RVA: 0x0028C595 File Offset: 0x0028A795
	private void DoElasticMove()
	{
		this.MoveItems(this.Distance / this.FinishTick);
		this.CurrentTick++;
	}

	// Token: 0x0600852D RID: 34093 RVA: 0x0028C5C4 File Offset: 0x0028A7C4
	protected void MoveItems(Number offset)
	{
		for (int i = 0; i < this.Items.Count; i++)
		{
			AutoAttachExhibitionItem autoAttachExhibitionItem = this.Items[i];
			autoAttachExhibitionItem.MoveItem(offset);
			bool debugMode = this.DebugMode;
			if (!this.CurrentSelectState && this.ItemOnSelectTime == EItemOnSelectTime.OnMoving && autoAttachExhibitionItem.ShowItemIndex == this.CurrentShowItemIndex && !autoAttachExhibitionItem.GetSelectState())
			{
				autoAttachExhibitionItem.Select();
				this.CurrentSelectState = true;
			}
		}
	}

	// Token: 0x0600852E RID: 34094 RVA: 0x0028C635 File Offset: 0x0028A835
	public bool MovingState()
	{
		return this.DragState || this.InertiaState;
	}

	// Token: 0x0600852F RID: 34095 RVA: 0x0028C648 File Offset: 0x0028A848
	protected void OnPointerBeginDrag(ULGUIPointerEventData eventData)
	{
		this.DragState = true;
		this.InertiaState = false;
		this.VelocityMoveState = false;
		this.BeginPlanePosition = new FVector?(eventData.GetWorldPointInPlane());
		this.CurrentPlanePosition = new FVector?(eventData.GetWorldPointInPlane());
		for (int i = 0; i < this.Items.Count; i++)
		{
			this.Items[i].OnControllerDragStart();
		}
	}

	// Token: 0x06008530 RID: 34096 RVA: 0x0028C6B4 File Offset: 0x0028A8B4
	protected void OnPointerDrag(ULGUIPointerEventData eventData)
	{
		FVector worldPointInPlane = eventData.GetWorldPointInPlane();
		this.CurrentPlanePosition = new FVector?(eventData.GetWorldPointInPlane());
		Number number = 0;
		EAutoAttachExhibitionViewDirection? currentDirection = this.CurrentDirection;
		EAutoAttachExhibitionViewDirection eautoAttachExhibitionViewDirection = EAutoAttachExhibitionViewDirection.Horizontal;
		if (currentDirection.GetValueOrDefault() == eautoAttachExhibitionViewDirection & currentDirection != null)
		{
			number = worldPointInPlane.X - this.BeginPlanePosition.Value.X;
		}
		else
		{
			number = worldPointInPlane.Z - this.BeginPlanePosition.Value.Z;
		}
		if (number != 0)
		{
			this.MoveItems(number);
			this.BeginPlanePosition = new FVector?(worldPointInPlane);
		}
	}

	// Token: 0x06008531 RID: 34097 RVA: 0x0028C75C File Offset: 0x0028A95C
	protected void OnPointerEndDrag(ULGUIPointerEventData eventData)
	{
		for (int i = 0; i < this.Items.Count; i++)
		{
			this.Items[i].OnControllerDragEnd();
		}
		this.DragState = false;
		this.CurrentTick = 0;
		if (!this.SupportVelocity)
		{
			AutoAttachExhibitionItem autoAttachExhibitionItem = this.FindAutoAttachItem();
			this.ScrollToIndex(this.AttachTime, autoAttachExhibitionItem.ShowItemIndex);
			return;
		}
		FVector worldPointInPlane = eventData.GetWorldPointInPlane();
		Number number = 0;
		EAutoAttachExhibitionViewDirection? currentDirection = this.CurrentDirection;
		EAutoAttachExhibitionViewDirection eautoAttachExhibitionViewDirection = EAutoAttachExhibitionViewDirection.Horizontal;
		if (currentDirection.GetValueOrDefault() == eautoAttachExhibitionViewDirection & currentDirection != null)
		{
			number = worldPointInPlane.X - this.CurrentPlanePosition.Value.X;
		}
		else
		{
			number = worldPointInPlane.Z - this.CurrentPlanePosition.Value.Z;
		}
		if (Math.Abs(number) < this.VelocityFactor)
		{
			AutoAttachExhibitionItem autoAttachExhibitionItem2 = this.FindAutoAttachItem();
			this.ScrollToIndex(this.AttachTime, autoAttachExhibitionItem2.ShowItemIndex);
			return;
		}
		this.VelocityMoveState = true;
		this.CurrentVelocity = number;
		this.VelocityDirection = ((this.CurrentVelocity > 0) ? 1 : -1);
		this.CurrentVelocityTime = 0;
	}

	// Token: 0x06008532 RID: 34098 RVA: 0x0028C8A8 File Offset: 0x0028AAA8
	[NullableContext(2)]
	protected AutoAttachExhibitionItem GetShowIndexItem(int showIndex)
	{
		AutoAttachExhibitionItem result = null;
		for (int i = 0; i < this.Items.Count; i++)
		{
			if (this.Items[i].ShowItemIndex == showIndex)
			{
				result = this.Items[i];
				break;
			}
		}
		return result;
	}

	// Token: 0x06008533 RID: 34099 RVA: 0x0028C8F1 File Offset: 0x0028AAF1
	[NullableContext(2)]
	public AutoAttachExhibitionItem AttachItem(int direction)
	{
		return null;
	}

	// Token: 0x06008534 RID: 34100 RVA: 0x0028C8F4 File Offset: 0x0028AAF4
	protected AutoAttachExhibitionItem FindAutoAttachItem()
	{
		return this.FindNearestMiddleItem();
	}

	// Token: 0x06008535 RID: 34101 RVA: 0x0028C8FC File Offset: 0x0028AAFC
	public Number GetWidth()
	{
		return this.Width;
	}

	// Token: 0x06008536 RID: 34102 RVA: 0x0028C904 File Offset: 0x0028AB04
	public Number GetHeight()
	{
		return this.Height;
	}

	// Token: 0x06008537 RID: 34103 RVA: 0x0028C90C File Offset: 0x0028AB0C
	public void Clear()
	{
		for (int i = 0; i < this.Items.Count; i++)
		{
			this.Items[i].Clear();
		}
	}

	// Token: 0x040050FF RID: 20735
	public const int DEFAULT_ATTACH_TIME = 8;

	// Token: 0x04005100 RID: 20736
	private FVector? BeginPlanePosition;

	// Token: 0x04005101 RID: 20737
	private FVector? CurrentPlanePosition;

	// Token: 0x04005102 RID: 20738
	protected EAutoAttachExhibitionViewDirection? CurrentDirection;

	// Token: 0x04005103 RID: 20739
	[Nullable(2)]
	public AActor Actor;

	// Token: 0x04005104 RID: 20740
	public UUIItem ItemActor;

	// Token: 0x04005105 RID: 20741
	[Nullable(2)]
	protected AActor CreateSourceActor;

	// Token: 0x04005106 RID: 20742
	[Nullable(2)]
	protected UUIItem CreateSourceUiActor;

	// Token: 0x04005107 RID: 20743
	protected List<AutoAttachExhibitionItem> Items = new List<AutoAttachExhibitionItem>();

	// Token: 0x04005108 RID: 20744
	public int SelectedIndex;

	// Token: 0x04005109 RID: 20745
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected Func<AActor, int, int, AutoAttachExhibitionItem> CreateItemFunction;

	// Token: 0x0400510A RID: 20746
	protected bool DragState;

	// Token: 0x0400510B RID: 20747
	protected bool InertiaState;

	// Token: 0x0400510C RID: 20748
	protected Number Distance = 0;

	// Token: 0x0400510D RID: 20749
	public Number AttachTime = 8;

	// Token: 0x0400510E RID: 20750
	protected Number ItemSizeX = 0;

	// Token: 0x0400510F RID: 20751
	protected Number ItemSizeY = 0;

	// Token: 0x04005110 RID: 20752
	protected Number Gap = 0;

	// Token: 0x04005111 RID: 20753
	protected int ShowItemNum;

	// Token: 0x04005112 RID: 20754
	protected int DataLength;

	// Token: 0x04005113 RID: 20755
	public int CurrentShowItemIndex;

	// Token: 0x04005114 RID: 20756
	protected Number Width = 0;

	// Token: 0x04005115 RID: 20757
	protected Number Height = 0;

	// Token: 0x04005116 RID: 20758
	private EItemOnSelectTime ItemOnSelectTime;

	// Token: 0x04005117 RID: 20759
	protected bool SupportVelocity = true;

	// Token: 0x04005118 RID: 20760
	protected Number CurrentVelocity = 0;

	// Token: 0x04005119 RID: 20761
	protected int VelocityDirection;

	// Token: 0x0400511A RID: 20762
	protected bool VelocityMoveState;

	// Token: 0x0400511B RID: 20763
	protected Number CurrentVelocityTime = 0;

	// Token: 0x0400511C RID: 20764
	protected Number VelocityFactor = 30;

	// Token: 0x0400511D RID: 20765
	protected Number BoundDistance = 0;

	// Token: 0x0400511E RID: 20766
	protected readonly bool DebugMode;

	// Token: 0x0400511F RID: 20767
	protected bool CurrentSelectState;

	// Token: 0x04005120 RID: 20768
	private int FinishTick;

	// Token: 0x04005121 RID: 20769
	private int CurrentTick;
}
