using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020017B5 RID: 6069
[NullableContext(1)]
[Nullable(0)]
public class AutoAttachExhibitionView
{
	// Token: 0x17000EAC RID: 3756
	// (get) Token: 0x0600B127 RID: 45351 RVA: 0x00281697 File Offset: 0x0027F897
	public EAutoAttachExhibitionViewDirection? Direction
	{
		get
		{
			return this.CurrentDirection;
		}
	}

	// Token: 0x0600B128 RID: 45352 RVA: 0x002816A0 File Offset: 0x0027F8A0
	public AutoAttachExhibitionView(AActor controllerActor)
	{
		this.Actor = controllerActor;
		this.ItemActor = (controllerActor.GetComponentByClass(UUIItem.StaticClass()) as UUIItem);
	}

	// Token: 0x0600B129 RID: 45353 RVA: 0x0028176C File Offset: 0x0027F96C
	public void SetVelocitySupport(bool state)
	{
		this.SupportVelocity = state;
	}

	// Token: 0x0600B12A RID: 45354 RVA: 0x00281775 File Offset: 0x0027F975
	public void SetVelocityFactor(Number factor)
	{
		this.VelocityFactor = factor;
	}

	// Token: 0x0600B12B RID: 45355 RVA: 0x0028177E File Offset: 0x0027F97E
	public void SetItemOnSelectTime(EItemOnSelectTime onSelectTime)
	{
		this.ItemOnSelectTime = onSelectTime;
	}

	// Token: 0x0600B12C RID: 45356 RVA: 0x00281787 File Offset: 0x0027F987
	public void SetBoundDistance(Number distance)
	{
		this.BoundDistance = distance;
	}

	// Token: 0x0600B12D RID: 45357 RVA: 0x00281790 File Offset: 0x0027F990
	public int GetDataLength()
	{
		return this.DataLength;
	}

	// Token: 0x0600B12E RID: 45358 RVA: 0x00281798 File Offset: 0x0027F998
	public void Destroy()
	{
		if (this.Actor != null)
		{
			ActorSystem.Instance.Put("AutoAttachExhibitionView.Destroy", this.Actor, null);
		}
		this.Actor = null;
	}

	// Token: 0x0600B12F RID: 45359 RVA: 0x002817C0 File Offset: 0x0027F9C0
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

	// Token: 0x0600B130 RID: 45360 RVA: 0x00281818 File Offset: 0x0027FA18
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

	// Token: 0x0600B131 RID: 45361 RVA: 0x002818B3 File Offset: 0x0027FAB3
	public void ReloadView(int showItemNum, object data)
	{
	}

	// Token: 0x0600B132 RID: 45362 RVA: 0x002818B8 File Offset: 0x0027FAB8
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

	// Token: 0x0600B133 RID: 45363 RVA: 0x0028190C File Offset: 0x0027FB0C
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

	// Token: 0x0600B134 RID: 45364 RVA: 0x00281984 File Offset: 0x0027FB84
	protected void SetData(object data)
	{
		for (int i = 0; i < this.Items.Count; i++)
		{
			this.Items[i].SetData(data);
		}
	}

	// Token: 0x0600B135 RID: 45365 RVA: 0x002819BC File Offset: 0x0027FBBC
	protected void InitItems()
	{
		for (int i = 0; i < this.Items.Count; i++)
		{
			this.Items[i].Init(this);
		}
		this.RefreshItemsView();
	}

	// Token: 0x0600B136 RID: 45366 RVA: 0x002819F8 File Offset: 0x0027FBF8
	protected void ForceUnSelectItems()
	{
		for (int i = 0; i < this.Items.Count; i++)
		{
			this.Items[i].ForceUnSelectItem();
		}
		this.CurrentSelectState = false;
	}

	// Token: 0x0600B137 RID: 45367 RVA: 0x00281A33 File Offset: 0x0027FC33
	public void SetAttachTime(Number attachTime)
	{
		this.AttachTime = attachTime;
	}

	// Token: 0x0600B138 RID: 45368 RVA: 0x00281A3C File Offset: 0x0027FC3C
	protected void RefreshItemsView()
	{
		for (int i = 0; i < this.Items.Count; i++)
		{
			this.Items[i].RefreshItem();
		}
	}

	// Token: 0x0600B139 RID: 45369 RVA: 0x00281A70 File Offset: 0x0027FC70
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

	// Token: 0x0600B13A RID: 45370 RVA: 0x00281BA0 File Offset: 0x0027FDA0
	public List<AutoAttachExhibitionItem> GetItems()
	{
		return this.Items;
	}

	// Token: 0x0600B13B RID: 45371 RVA: 0x00281BA8 File Offset: 0x0027FDA8
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

	// Token: 0x0600B13C RID: 45372 RVA: 0x00281C04 File Offset: 0x0027FE04
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

	// Token: 0x0600B13D RID: 45373 RVA: 0x00281CCC File Offset: 0x0027FECC
	protected void ScrollToIndex(int finishTick, int itemIndex)
	{
		this.AttachToIndex(finishTick, itemIndex);
	}

	// Token: 0x0600B13E RID: 45374 RVA: 0x00281CD6 File Offset: 0x0027FED6
	public void AttachToIndex(int finishTick, int showItemIndex)
	{
		this.AttachToIndex2(finishTick, showItemIndex);
	}

	// Token: 0x0600B13F RID: 45375 RVA: 0x00281CE0 File Offset: 0x0027FEE0
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

	// Token: 0x0600B140 RID: 45376 RVA: 0x00281E1C File Offset: 0x0028001C
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

	// Token: 0x0600B141 RID: 45377 RVA: 0x00281EF4 File Offset: 0x002800F4
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

	// Token: 0x0600B142 RID: 45378 RVA: 0x00281FC0 File Offset: 0x002801C0
	protected Number ReCalculateOffset(Number offset)
	{
		return offset;
	}

	// Token: 0x0600B143 RID: 45379 RVA: 0x00281FC4 File Offset: 0x002801C4
	protected void EndVelocityMove()
	{
		this.VelocityMoveState = false;
		this.InertiaState = false;
		AutoAttachExhibitionItem autoAttachExhibitionItem = this.FindAutoAttachItem();
		this.ScrollToIndex(this.AttachTime, autoAttachExhibitionItem.ShowItemIndex);
	}

	// Token: 0x0600B144 RID: 45380 RVA: 0x00281FFD File Offset: 0x002801FD
	private void DoElasticMove()
	{
		this.MoveItems(this.Distance / this.FinishTick);
		this.CurrentTick++;
	}

	// Token: 0x0600B145 RID: 45381 RVA: 0x0028202C File Offset: 0x0028022C
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

	// Token: 0x0600B146 RID: 45382 RVA: 0x0028209D File Offset: 0x0028029D
	public bool MovingState()
	{
		return this.DragState || this.InertiaState;
	}

	// Token: 0x0600B147 RID: 45383 RVA: 0x002820B0 File Offset: 0x002802B0
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

	// Token: 0x0600B148 RID: 45384 RVA: 0x0028211C File Offset: 0x0028031C
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

	// Token: 0x0600B149 RID: 45385 RVA: 0x002821C4 File Offset: 0x002803C4
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

	// Token: 0x0600B14A RID: 45386 RVA: 0x00282310 File Offset: 0x00280510
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

	// Token: 0x0600B14B RID: 45387 RVA: 0x00282359 File Offset: 0x00280559
	[NullableContext(2)]
	public AutoAttachExhibitionItem AttachItem(int direction)
	{
		return null;
	}

	// Token: 0x0600B14C RID: 45388 RVA: 0x0028235C File Offset: 0x0028055C
	protected AutoAttachExhibitionItem FindAutoAttachItem()
	{
		return this.FindNearestMiddleItem();
	}

	// Token: 0x0600B14D RID: 45389 RVA: 0x00282364 File Offset: 0x00280564
	public Number GetWidth()
	{
		return this.Width;
	}

	// Token: 0x0600B14E RID: 45390 RVA: 0x0028236C File Offset: 0x0028056C
	public Number GetHeight()
	{
		return this.Height;
	}

	// Token: 0x0600B14F RID: 45391 RVA: 0x00282374 File Offset: 0x00280574
	public void Clear()
	{
		for (int i = 0; i < this.Items.Count; i++)
		{
			this.Items[i].Clear();
		}
	}

	// Token: 0x04005055 RID: 20565
	public const int DEFAULT_ATTACH_TIME = 8;

	// Token: 0x04005056 RID: 20566
	private FVector? BeginPlanePosition;

	// Token: 0x04005057 RID: 20567
	private FVector? CurrentPlanePosition;

	// Token: 0x04005058 RID: 20568
	protected EAutoAttachExhibitionViewDirection? CurrentDirection;

	// Token: 0x04005059 RID: 20569
	[Nullable(2)]
	public AActor Actor;

	// Token: 0x0400505A RID: 20570
	public UUIItem ItemActor;

	// Token: 0x0400505B RID: 20571
	[Nullable(2)]
	protected AActor CreateSourceActor;

	// Token: 0x0400505C RID: 20572
	[Nullable(2)]
	protected UUIItem CreateSourceUiActor;

	// Token: 0x0400505D RID: 20573
	protected List<AutoAttachExhibitionItem> Items = new List<AutoAttachExhibitionItem>();

	// Token: 0x0400505E RID: 20574
	public int SelectedIndex;

	// Token: 0x0400505F RID: 20575
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected Func<AActor, int, int, AutoAttachExhibitionItem> CreateItemFunction;

	// Token: 0x04005060 RID: 20576
	protected bool DragState;

	// Token: 0x04005061 RID: 20577
	protected bool InertiaState;

	// Token: 0x04005062 RID: 20578
	protected Number Distance = 0;

	// Token: 0x04005063 RID: 20579
	public Number AttachTime = 8;

	// Token: 0x04005064 RID: 20580
	protected Number ItemSizeX = 0;

	// Token: 0x04005065 RID: 20581
	protected Number ItemSizeY = 0;

	// Token: 0x04005066 RID: 20582
	protected Number Gap = 0;

	// Token: 0x04005067 RID: 20583
	protected int ShowItemNum;

	// Token: 0x04005068 RID: 20584
	protected int DataLength;

	// Token: 0x04005069 RID: 20585
	public int CurrentShowItemIndex;

	// Token: 0x0400506A RID: 20586
	protected Number Width = 0;

	// Token: 0x0400506B RID: 20587
	protected Number Height = 0;

	// Token: 0x0400506C RID: 20588
	private EItemOnSelectTime ItemOnSelectTime;

	// Token: 0x0400506D RID: 20589
	protected bool SupportVelocity = true;

	// Token: 0x0400506E RID: 20590
	protected Number CurrentVelocity = 0;

	// Token: 0x0400506F RID: 20591
	protected int VelocityDirection;

	// Token: 0x04005070 RID: 20592
	protected bool VelocityMoveState;

	// Token: 0x04005071 RID: 20593
	protected Number CurrentVelocityTime = 0;

	// Token: 0x04005072 RID: 20594
	protected Number VelocityFactor = 30;

	// Token: 0x04005073 RID: 20595
	protected Number BoundDistance = 0;

	// Token: 0x04005074 RID: 20596
	protected readonly bool DebugMode;

	// Token: 0x04005075 RID: 20597
	protected bool CurrentSelectState;

	// Token: 0x04005076 RID: 20598
	private int FinishTick;

	// Token: 0x04005077 RID: 20599
	private int CurrentTick;
}
