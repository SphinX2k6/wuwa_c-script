using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004646 RID: 17990
	[NullableContext(2)]
	[Nullable(0)]
	public class CommonDragItemLogic<[Nullable(0)] TItem, [Nullable(1)] TData> where TItem : CommonDragLogicDataItem<TData> where TData : class
	{
		// Token: 0x0602E6A0 RID: 190112 RVA: 0x00AB98CC File Offset: 0x00AB7ACC
		[NullableContext(1)]
		public CommonDragItemLogic(UUIItem normalParent, UUIDraggableComponent dragComponent, int index, Func<TItem> delegateCreateFunction)
		{
			this.StretchVector = new FVector2D?(new FVector2D(0f, 0f));
			this.NormalParent = normalParent;
			this.DragComponent = dragComponent;
			this.Index = index;
			this.MovingParent = dragComponent.RootUIComp.Get().GetParentAsUIItem();
			dragComponent.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDown));
			dragComponent.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointUp));
			dragComponent.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDrag));
			dragComponent.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragBegin));
			dragComponent.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragEnd));
			UUIItem uuiitem = dragComponent.RootUIComp.Get().GetOwner().GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
			this.DragItem = uuiitem;
			this.LevelSequencePlayer = new LevelSequencePlayer(uuiitem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.FinishSequenceEvent), false);
			this.Canvas = (dragComponent.RootUIComp.Get().GetOwner().GetComponentByClass(ULGUICanvas.StaticClass()) as ULGUICanvas);
			this.Delegate = delegateCreateFunction();
			this.Delegate.SetDragComponent(dragComponent);
			this.Delegate.SetCurrentIndex(index);
		}

		// Token: 0x0602E6A1 RID: 190113 RVA: 0x00AB9ADD File Offset: 0x00AB7CDD
		[NullableContext(1)]
		public UUIItem GetNormalParent()
		{
			return this.NormalParent;
		}

		// Token: 0x0602E6A2 RID: 190114 RVA: 0x00AB9AE5 File Offset: 0x00AB7CE5
		[NullableContext(1)]
		public TItem GetItem()
		{
			return this.Delegate;
		}

		// Token: 0x0602E6A3 RID: 190115 RVA: 0x00AB9AF0 File Offset: 0x00AB7CF0
		public void SetActive(bool state)
		{
			UUIDraggableComponent dragComponent = this.DragComponent;
			if (dragComponent == null)
			{
				return;
			}
			dragComponent.RootUIComp.Get().SetUIActive(state);
		}

		// Token: 0x0602E6A4 RID: 190116 RVA: 0x00AB9B1C File Offset: 0x00AB7D1C
		[NullableContext(1)]
		public void SetScrollViewItem(UUIItem scrollView)
		{
			FVector2D fvector2D = new Vector2D(0.5, 0.5).ToUeVector2D(false);
			FVector lguispaceAbsolutePositionByPivot = scrollView.GetLGUISpaceAbsolutePositionByPivot(fvector2D);
			float num = scrollView.Width / 2f;
			float num2 = lguispaceAbsolutePositionByPivot.X - num;
			float num3 = lguispaceAbsolutePositionByPivot.X + num;
			this.ScrollViewBounceX.X = (double)num2;
			this.ScrollViewBounceX.Y = (double)num3;
			num = scrollView.Height / 2f;
			float num4 = lguispaceAbsolutePositionByPivot.Y - num;
			float num5 = lguispaceAbsolutePositionByPivot.Y + num;
			this.ScrollViewBounceY.X = (double)num4;
			this.ScrollViewBounceY.Y = (double)num5;
		}

		// Token: 0x0602E6A5 RID: 190117 RVA: 0x00AB9BC3 File Offset: 0x00AB7DC3
		public void Refresh(TData data)
		{
			this.Delegate.SetCurrentData(data);
		}

		// Token: 0x0602E6A6 RID: 190118 RVA: 0x00AB9BD6 File Offset: 0x00AB7DD6
		public void StartClickCheckTimer()
		{
			this.ClearFingerTick();
			this.CurrentCheckFingerTick = TickSystem.Instance.Add(delegate(float _)
			{
				if (this.GetCurrentFingerNum() == 0)
				{
					this.OnPointUp(null);
					this.ClearFingerTick();
				}
			}, "DragTick", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
		}

		// Token: 0x0602E6A7 RID: 190119 RVA: 0x00AB9C08 File Offset: 0x00AB7E08
		public Vector2D GetAnimationTargetPos()
		{
			return this.AnimationTargetPosition;
		}

		// Token: 0x0602E6A8 RID: 190120 RVA: 0x00AB9C10 File Offset: 0x00AB7E10
		public void SetDragItemHierarchyMax()
		{
			this.DragItem.SetAsLastHierarchy();
			this.Canvas.SetSortOrder(101, true);
		}

		// Token: 0x0602E6A9 RID: 190121 RVA: 0x00AB9C2B File Offset: 0x00AB7E2B
		public TData GetCurrentData()
		{
			return this.Delegate.GetCurrentData();
		}

		// Token: 0x0602E6AA RID: 190122 RVA: 0x00AB9C40 File Offset: 0x00AB7E40
		public void CacheStartDragPosition()
		{
			FVector lguispaceAbsolutePosition = this.DragComponent.RootUIComp.Get().GetLGUISpaceAbsolutePosition();
			FVector lguispaceAbsolutePosition2 = this.DragComponent.RootUIComp.Get().GetLGUISpaceAbsolutePosition();
			this.StartPosition = new Vector2D((double)lguispaceAbsolutePosition2.X, (double)lguispaceAbsolutePosition2.Y);
			this.AnimationTargetPosition = new Vector2D((double)lguispaceAbsolutePosition.X, (double)lguispaceAbsolutePosition.Y);
		}

		// Token: 0x0602E6AB RID: 190123 RVA: 0x00AB9CB4 File Offset: 0x00AB7EB4
		private void BackDragItemToNormalParent()
		{
			this.DragComponent.RootUIComp.Get().SetAnchorAlign(UIAnchorHorizontalAlign.Stretch, UIAnchorVerticalAlign.Stretch);
			FVector uiitemScale = new FVector(1f, 1f, 1f);
			this.DragComponent.RootUIComp.Get().SetUIItemScale(uiitemScale);
			this.DragComponent.RootUIComp.Get().SetHorizontalStretch(this.StretchVector.Value);
			this.DragComponent.RootUIComp.Get().SetVerticalStretch(this.StretchVector.Value);
			this.Canvas.SetSortOrder(0, true);
			this.DragComponent.RootUIComp.Get().SetBubbleUpToParent(true);
		}

		// Token: 0x0602E6AC RID: 190124 RVA: 0x00AB9D78 File Offset: 0x00AB7F78
		public void StartDragState()
		{
			this.CacheStartDragPosition();
			this.DragState = true;
			this.IfStayInScrollView = false;
			this.DragComponent.RootUIComp.Get().SetAnchorAlign(UIAnchorHorizontalAlign.Center, UIAnchorVerticalAlign.Middle);
			this.MoveParentDelay = 0f;
			this.Canvas.SetSortOrder(100, true);
			this.DragComponent.RootUIComp.Get().SetBubbleUpToParent(false);
		}

		// Token: 0x0602E6AD RID: 190125 RVA: 0x00AB9DE8 File Offset: 0x00AB7FE8
		public void ResetPosition()
		{
			this.LevelSequencePlayer.StopSequenceByKey("Drag", false, true);
			if (this.CeaseFailAnimationState)
			{
				this.TryDoCeaseFailSequence();
			}
			this.CeaseFailAnimationState = false;
			if (!this.DragState)
			{
				return;
			}
			this.BackDragItemToNormalParent();
			if (this.StartPosition != null)
			{
				this.DragComponent.RootUIComp.Get().SetAnchorOffset(this.StretchVector.Value);
			}
			this.DragState = false;
		}

		// Token: 0x0602E6AE RID: 190126 RVA: 0x00AB9E5D File Offset: 0x00AB805D
		public virtual void SetToTargetParentAndSetStretch(UUIItem targetItem)
		{
		}

		// Token: 0x0602E6AF RID: 190127 RVA: 0x00AB9E5F File Offset: 0x00AB805F
		public void SetToNormalParent()
		{
			this.SetToTargetParentAndSetStretch(this.MovingParent);
		}

		// Token: 0x0602E6B0 RID: 190128 RVA: 0x00AB9E6D File Offset: 0x00AB806D
		public void SetDragSuccessCallBack([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Action<TItem, TItem, bool> onFunction)
		{
			this.OnDragEndFunction = onFunction;
		}

		// Token: 0x0602E6B1 RID: 190129 RVA: 0x00AB9E76 File Offset: 0x00AB8076
		[NullableContext(1)]
		public void SetMoveToScrollViewCallBack(Action<int> callBack)
		{
			this.OnMoveToScrollViewCallBack = callBack;
		}

		// Token: 0x0602E6B2 RID: 190130 RVA: 0x00AB9E7F File Offset: 0x00AB807F
		[NullableContext(1)]
		public void SetRemoveFromScrollViewCallBack(Action<int> callBack)
		{
			this.OnRemoveFromScrollViewCallBack = callBack;
		}

		// Token: 0x0602E6B3 RID: 190131 RVA: 0x00AB9E88 File Offset: 0x00AB8088
		[NullableContext(1)]
		public void SetEndDragWhenOnScrollViewCallBack(Action<int, TData> callBack)
		{
			this.OnEndDragWhenOnScrollViewCallBack = callBack;
		}

		// Token: 0x0602E6B4 RID: 190132 RVA: 0x00AB9E91 File Offset: 0x00AB8091
		[NullableContext(1)]
		public void SetOnUnOverlayCallBack(Action<int> callBack)
		{
			this.Delegate.SetOnUnOverlayCallBack(callBack);
		}

		// Token: 0x0602E6B5 RID: 190133 RVA: 0x00AB9EA4 File Offset: 0x00AB80A4
		[NullableContext(1)]
		public void SetOnOverlayCallBack(Action<int> callBack)
		{
			this.Delegate.SetOnOverlayCallBack(callBack);
		}

		// Token: 0x0602E6B6 RID: 190134 RVA: 0x00AB9EB7 File Offset: 0x00AB80B7
		[NullableContext(1)]
		public void SetPointerDownCallBack(Action<int> dragEvent)
		{
			this.OnPointerDownCallBack = dragEvent;
		}

		// Token: 0x0602E6B7 RID: 190135 RVA: 0x00AB9EC0 File Offset: 0x00AB80C0
		[NullableContext(1)]
		public void SetOnDragAnimationStartFunction(Action<int> onFunction)
		{
			this.OnDragAnimationStartFunction = onFunction;
		}

		// Token: 0x0602E6B8 RID: 190136 RVA: 0x00AB9EC9 File Offset: 0x00AB80C9
		[NullableContext(1)]
		public void SetOnDragAnimationEndFunction(Action<int> onFunction)
		{
			this.OnDragAnimationEndFunction = onFunction;
		}

		// Token: 0x0602E6B9 RID: 190137 RVA: 0x00AB9ED2 File Offset: 0x00AB80D2
		[NullableContext(1)]
		public void SetOnClickCallBack(Action<int> onFunction)
		{
			this.ClickFunction = onFunction;
		}

		// Token: 0x0602E6BA RID: 190138 RVA: 0x00AB9EDB File Offset: 0x00AB80DB
		[NullableContext(1)]
		public void SetOnClickFailCallBack(Action<int> onFunction)
		{
			this.ClickFailFunction = onFunction;
		}

		// Token: 0x0602E6BB RID: 190139 RVA: 0x00AB9EE4 File Offset: 0x00AB80E4
		[NullableContext(1)]
		public void SetOnBeginDragCall(Action<int> onFunction)
		{
			this.OnBeginDragFunction = onFunction;
		}

		// Token: 0x0602E6BC RID: 190140 RVA: 0x00AB9EF0 File Offset: 0x00AB80F0
		[NullableContext(1)]
		public void SetDragCheckItem(List<CommonDragItemLogic<TItem, TData>> itemList)
		{
			List<TItem> list = new List<TItem>();
			foreach (CommonDragItemLogic<TItem, TData> commonDragItemLogic in itemList)
			{
				list.Add(commonDragItemLogic.GetItem());
			}
			this.CheckList = list;
		}

		// Token: 0x0602E6BD RID: 190141 RVA: 0x00AB9F50 File Offset: 0x00AB8150
		public int GetCurrentIndex()
		{
			return this.Index;
		}

		// Token: 0x0602E6BE RID: 190142 RVA: 0x00AB9F58 File Offset: 0x00AB8158
		public void TickCheckDrag()
		{
			if (this.MoveParentDelay <= 1f)
			{
				this.MoveParentDelay += 1f;
				return;
			}
			this.SetItemToPointerPosition();
			this.CheckOnDrag();
		}

		// Token: 0x0602E6BF RID: 190143 RVA: 0x00AB9F86 File Offset: 0x00AB8186
		public void ClearStayingItem()
		{
			this.CurrentStaying = default(TItem);
		}

		// Token: 0x0602E6C0 RID: 190144 RVA: 0x00AB9F94 File Offset: 0x00AB8194
		public TItem GetStayingItem()
		{
			return this.CurrentStaying;
		}

		// Token: 0x0602E6C1 RID: 190145 RVA: 0x00AB9F9C File Offset: 0x00AB819C
		public void SetItemToPointerPosition()
		{
			if (!this.DragState)
			{
				return;
			}
			FVector? pointerEventDataPosition = LguiEventSystemManager.Instance.GetPointerEventDataPosition(0);
			Vector2D vector2D = Vector2D.Create((double)pointerEventDataPosition.Value.X, (double)pointerEventDataPosition.Value.Y);
			Vector2D vector2D2 = vector2D;
			ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
			FVector2D fvector2D = vector2D.ToUeVector2D(false);
			vector2D2.FromUeVector2D(canvasScaler.ConvertPositionFromViewportToLGUICanvas(fvector2D));
			float num = PhantomBattleConfig.Instance.GetVisionScrollerOffsetX() * (float)PhantomBattleConfig.Instance.GetVisionScrollerOffsetXDir();
			float num2 = PhantomBattleConfig.Instance.GetVisionScrollerOffsetY() * (float)PhantomBattleConfig.Instance.GetVisionScrollerOffsetYDir();
			double num3 = vector2D.X + (double)num;
			double num4 = vector2D.Y + (double)num2;
			if (this.StaticBeginVector.X == num3 && this.StaticBeginVector.Y == num4)
			{
				return;
			}
			this.StaticBeginVector.X = num3;
			this.StaticBeginVector.Y = num4;
			UUIItem uuiitem = this.DragComponent.RootUIComp.Get();
			FVector fvector = new FVector((float)num3, (float)num4, 0f);
			uuiitem.SetLGUISpaceAbsolutePosition(fvector);
		}

		// Token: 0x0602E6C2 RID: 190146 RVA: 0x00ABA0B4 File Offset: 0x00AB82B4
		private void OnPointerDown(ULGUIPointerEventData eventData)
		{
			if (!this.Delegate.CheckIfCanDrag() || this.DragState)
			{
				return;
			}
			this.Delegate.SetCurrentDragIndex(this.Index);
			this.CurrentClickState = false;
			this.CurrentRunningTime = 0f;
			this.PlayDragSequenceState = false;
			this.IfDragMove = false;
			this.CurrentMoveData = null;
			this.IfBeginDrag = false;
			this.CurrentTick = TickSystem.Instance.Add(delegate(float _)
			{
				this.CheckTimeForDoDrag();
				this.CurrentRunningTime += Time.Instance.DeltaTime;
			}, "DragTick", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
			if (this.Delegate.GetCurrentData() != null)
			{
				Action<int> onPointerDownCallBack = this.OnPointerDownCallBack;
				if (onPointerDownCallBack == null)
				{
					return;
				}
				onPointerDownCallBack(this.GetCurrentIndex());
			}
		}

		// Token: 0x0602E6C3 RID: 190147 RVA: 0x00ABA178 File Offset: 0x00AB8378
		private void OnPointUp(ULGUIPointerEventData eventData)
		{
			this.ClearTick();
			this.ClearFingerTick();
			if (!this.Delegate.CheckIfCurrentDragIndex(this.Index))
			{
				return;
			}
			this.Delegate.ClearCurrentDragIndex();
			if (this.Delegate.GetCurrentData() == null)
			{
				if (this.CheckInClickableTime())
				{
					this.TryDoClick(true);
				}
				return;
			}
			float currentRunningTime = this.CurrentRunningTime;
			this.Delegate.GetClickTime();
			if (!this.IfBeginDrag)
			{
				this.TryDoClick(false);
			}
		}

		// Token: 0x0602E6C4 RID: 190148 RVA: 0x00ABA20A File Offset: 0x00AB840A
		private void ClearFingerTick()
		{
			if (this.CurrentCheckFingerTick != -1)
			{
				TickSystem.Instance.Remove(this.CurrentCheckFingerTick);
				this.CurrentCheckFingerTick = -1;
			}
		}

		// Token: 0x0602E6C5 RID: 190149 RVA: 0x00ABA230 File Offset: 0x00AB8430
		private void OnDrag(ULGUIPointerEventData eventData)
		{
			if (!this.Delegate.CheckIfCurrentDragIndex(this.Index))
			{
				return;
			}
			if (this.Delegate.GetCurrentData() == null)
			{
				return;
			}
			this.CurrentMoveData = eventData;
			if (this.CurrentRunningTime < this.Delegate.GetClickTime())
			{
				return;
			}
			this.TickCheckDrag();
		}

		// Token: 0x0602E6C6 RID: 190150 RVA: 0x00ABA294 File Offset: 0x00AB8494
		private void OnDragBegin(ULGUIPointerEventData eventData)
		{
			if (!this.Delegate.CheckIfCurrentDragIndex(this.Index))
			{
				return;
			}
			if (this.Delegate.GetCurrentData() == null)
			{
				this.Delegate.ClearCurrentDragIndex();
				return;
			}
			this.CurrentStaying = default(TItem);
			this.IfDragMove = true;
			this.IfBeginDrag = true;
		}

		// Token: 0x0602E6C7 RID: 190151 RVA: 0x00ABA2FC File Offset: 0x00AB84FC
		private void OnDragEnd(ULGUIPointerEventData eventData)
		{
			if (this.Delegate.GetCurrentData() == null)
			{
				return;
			}
			if (this.IfDragMove)
			{
				if (this.CurrentRunningTime < this.Delegate.GetClickTime())
				{
					this.TryDoClick(false);
				}
				else if (!this.IfStayInScrollView)
				{
					Action<TItem, TItem, bool> onDragEndFunction = this.OnDragEndFunction;
					if (onDragEndFunction != null)
					{
						onDragEndFunction(this.Delegate, this.CurrentStaying, this.IfStayInScrollView);
					}
				}
				this.IfDragMove = false;
			}
			if (this.IfStayInScrollView)
			{
				this.IfStayInScrollView = false;
				this.CeaseFailAnimationState = false;
				Action<int, TData> onEndDragWhenOnScrollViewCallBack = this.OnEndDragWhenOnScrollViewCallBack;
				if (onEndDragWhenOnScrollViewCallBack == null)
				{
					return;
				}
				onEndDragWhenOnScrollViewCallBack(this.GetCurrentIndex(), this.Delegate.GetCurrentData());
			}
		}

		// Token: 0x0602E6C8 RID: 190152 RVA: 0x00ABA3B9 File Offset: 0x00AB85B9
		public bool CheckAndGetCurrentClickState()
		{
			return this.CurrentClickState;
		}

		// Token: 0x0602E6C9 RID: 190153 RVA: 0x00ABA3C1 File Offset: 0x00AB85C1
		private void ClearTick()
		{
			if (this.CurrentTick != -1)
			{
				TickSystem.Instance.Remove(this.CurrentTick);
				this.CurrentTick = -1;
			}
		}

		// Token: 0x0602E6CA RID: 190154 RVA: 0x00ABA3E4 File Offset: 0x00AB85E4
		private int GetCurrentFingerNum()
		{
			bool flag = LguiEventSystemManager.Instance.IsPressComponentIsValid(0);
			bool flag2 = LguiEventSystemManager.Instance.IsPressComponentIsValid(1);
			int num = 0;
			if (flag)
			{
				num++;
			}
			if (flag2)
			{
				num++;
			}
			return num;
		}

		// Token: 0x0602E6CB RID: 190155 RVA: 0x00ABA418 File Offset: 0x00AB8618
		[NullableContext(1)]
		private void FinishSequenceEvent(string sequenceName)
		{
			if (sequenceName == "Cease")
			{
				this.CeaseAnimationPromise.SetResult(true);
				Action<int> onDragAnimationEndFunction = this.OnDragAnimationEndFunction;
				if (onDragAnimationEndFunction == null)
				{
					return;
				}
				onDragAnimationEndFunction(this.GetCurrentIndex());
			}
		}

		// Token: 0x0602E6CC RID: 190156 RVA: 0x00ABA44C File Offset: 0x00AB864C
		public void DoCeaseSequence()
		{
			this.CeaseFailAnimationState = false;
			this.CeaseAnimationPromise = new CustomPromise<bool>();
			this.LevelSequencePlayer.PlayLevelSequenceByName("Cease", false, null, false);
		}

		// Token: 0x0602E6CD RID: 190157 RVA: 0x00ABA486 File Offset: 0x00AB8686
		public CustomPromise<bool> GetCeaseAnimationPromise()
		{
			return this.CeaseAnimationPromise;
		}

		// Token: 0x0602E6CE RID: 190158 RVA: 0x00ABA490 File Offset: 0x00AB8690
		private void TryDoCeaseFailSequence()
		{
			if (this.CeaseFailAnimationState)
			{
				this.LevelSequencePlayer.PlayLevelSequenceByName("Fail", false, null, false);
				Action<int> onDragAnimationEndFunction = this.OnDragAnimationEndFunction;
				if (onDragAnimationEndFunction == null)
				{
					return;
				}
				onDragAnimationEndFunction(this.GetCurrentIndex());
			}
		}

		// Token: 0x0602E6CF RID: 190159 RVA: 0x00ABA4D8 File Offset: 0x00AB86D8
		private void DoDragSequence()
		{
			this.TickCheckDrag();
			this.LevelSequencePlayer.PlayLevelSequenceByName("Drag", false, null, false);
			this.CeaseFailAnimationState = true;
			Action<int> onDragAnimationStartFunction = this.OnDragAnimationStartFunction;
			if (onDragAnimationStartFunction == null)
			{
				return;
			}
			onDragAnimationStartFunction(this.GetCurrentIndex());
		}

		// Token: 0x0602E6D0 RID: 190160 RVA: 0x00ABA524 File Offset: 0x00AB8724
		private void CheckTimeForDoDrag()
		{
			if (this.GetCurrentFingerNum() >= 2 || this.GetCurrentFingerNum() == 0)
			{
				this.ClearTick();
				return;
			}
			if (this.CurrentRunningTime >= this.Delegate.GetClickTime())
			{
				this.ClearTick();
				if (this.Delegate.GetCurrentData() == null)
				{
					return;
				}
				if (!this.PlayDragSequenceState)
				{
					this.DoDragSequence();
					this.PlayDragSequenceState = true;
				}
				if (this.OnBeginDragFunction != null)
				{
					this.OnBeginDragFunction(this.Index);
				}
				if (this.CurrentMoveData != null)
				{
					this.OnDrag(this.CurrentMoveData);
				}
			}
		}

		// Token: 0x0602E6D1 RID: 190161 RVA: 0x00ABA5C4 File Offset: 0x00AB87C4
		private bool TryDoClick(bool force = false)
		{
			if (force || this.CheckInClickableTime())
			{
				Action<int> clickFunction = this.ClickFunction;
				if (clickFunction != null)
				{
					clickFunction(this.Index);
				}
				this.LastClickTime = TimeUtil.Instance.GetServerTime();
				this.CurrentClickState = true;
				return true;
			}
			this.CurrentClickState = false;
			Action<int> clickFailFunction = this.ClickFailFunction;
			if (clickFailFunction != null)
			{
				clickFailFunction(this.Index);
			}
			return false;
		}

		// Token: 0x0602E6D2 RID: 190162 RVA: 0x00ABA62B File Offset: 0x00AB882B
		private bool CheckInClickGap()
		{
			return Info.Instance.IsInGamepad() || TimeUtil.Instance.GetServerTime() - this.LastClickTime > 0.10000000149011612;
		}

		// Token: 0x0602E6D3 RID: 190163 RVA: 0x00ABA657 File Offset: 0x00AB8857
		private bool CheckInClickableTime()
		{
			return this.CurrentRunningTime < this.Delegate.GetClickTime() && this.CheckInClickGap();
		}

		// Token: 0x0602E6D4 RID: 190164 RVA: 0x00ABA67C File Offset: 0x00AB887C
		private void CheckOnDrag()
		{
			List<CommonDragLogicDataItem<TData>> newOverlayTmp = new List<CommonDragLogicDataItem<TData>>();
			TItem titem = default(TItem);
			List<TItem> checkList = this.CheckList;
			if (checkList != null)
			{
				checkList.ForEach(delegate(TItem value)
				{
					if (!value.CheckIfSelfItem(this.Index) && value.CheckOverlap(this.Delegate.GetBounceX(), this.Delegate.GetBounceY()))
					{
						newOverlayTmp.Add(value);
					}
				});
			}
			int overlapIndex = this.Delegate.GetOverlapIndex(newOverlayTmp);
			if (this.CheckList != null && overlapIndex >= 0)
			{
				titem = this.CheckList[overlapIndex];
			}
			if (this.CurrentStaying != titem)
			{
				TItem titem2 = this.CurrentStaying;
				if (titem2 != null)
				{
					titem2.OnUnOverlay();
				}
				TItem titem3 = titem;
				if (titem3 != null)
				{
					titem3.OnOverlay();
				}
			}
			this.CurrentStaying = titem;
			if (this.ScrollViewBounceX.X != 0.0)
			{
				if (this.Delegate.CheckOverlap(this.ScrollViewBounceX, this.ScrollViewBounceY))
				{
					if (!this.IfStayInScrollView)
					{
						Action<int> onMoveToScrollViewCallBack = this.OnMoveToScrollViewCallBack;
						if (onMoveToScrollViewCallBack != null)
						{
							onMoveToScrollViewCallBack(this.GetCurrentIndex());
						}
						this.IfStayInScrollView = true;
						return;
					}
				}
				else if (this.IfStayInScrollView)
				{
					Action<int> onRemoveFromScrollViewCallBack = this.OnRemoveFromScrollViewCallBack;
					if (onRemoveFromScrollViewCallBack != null)
					{
						onRemoveFromScrollViewCallBack(this.GetCurrentIndex());
					}
					this.IfStayInScrollView = false;
				}
			}
		}

		// Token: 0x0602E6D5 RID: 190165 RVA: 0x00ABA7B8 File Offset: 0x00AB89B8
		[NullableContext(0)]
		public ValueTuple<float, float> GetMiddlePosition()
		{
			return new ValueTuple<float, float>(this.DragComponent.RootUIComp.Get().GetLGUISpaceCenterAbsolutePosition().X, this.DragComponent.RootUIComp.Get().GetLGUISpaceCenterAbsolutePosition().Y);
		}

		// Token: 0x0602E6D6 RID: 190166 RVA: 0x00ABA804 File Offset: 0x00AB8A04
		[NullableContext(1)]
		public void SetDragComponentToTargetPositionParam(Vector2D targetVec)
		{
			this.CeaseState = true;
			this.CurrentAnimationTargetPos.X = targetVec.X;
			this.CurrentAnimationTargetPos.Y = targetVec.Y;
			FVector lguispaceAbsolutePosition = this.DragItem.GetLGUISpaceAbsolutePosition();
			this.AnimationStartPos.X = (double)lguispaceAbsolutePosition.X;
			this.AnimationStartPos.Y = (double)lguispaceAbsolutePosition.Y;
		}

		// Token: 0x0602E6D7 RID: 190167 RVA: 0x00ABA86C File Offset: 0x00AB8A6C
		public UniTask TickDoCeaseAnimation(float currentProgress)
		{
			CommonDragItemLogic<TItem, TData>.<TickDoCeaseAnimation>d__102 <TickDoCeaseAnimation>d__;
			<TickDoCeaseAnimation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TickDoCeaseAnimation>d__.<>4__this = this;
			<TickDoCeaseAnimation>d__.currentProgress = currentProgress;
			<TickDoCeaseAnimation>d__.<>1__state = -1;
			<TickDoCeaseAnimation>d__.<>t__builder.Start<CommonDragItemLogic<TItem, TData>.<TickDoCeaseAnimation>d__102>(ref <TickDoCeaseAnimation>d__);
			return <TickDoCeaseAnimation>d__.<>t__builder.Task;
		}

		// Token: 0x0602E6D8 RID: 190168 RVA: 0x00ABA8B7 File Offset: 0x00AB8AB7
		public void SetMovingState(bool state)
		{
			this.MovingState = state;
		}

		// Token: 0x04018DE2 RID: 101858
		public CustomPromise<bool> CeaseAnimationPromise;

		// Token: 0x04018DE3 RID: 101859
		private readonly TItem Delegate;

		// Token: 0x04018DE4 RID: 101860
		private readonly UUIDraggableComponent DragComponent;

		// Token: 0x04018DE5 RID: 101861
		private readonly int Index = -1;

		// Token: 0x04018DE6 RID: 101862
		protected Action<int> OnPointerDownCallBack;

		// Token: 0x04018DE7 RID: 101863
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Action<int, TData> OnEndDragWhenOnScrollViewCallBack;

		// Token: 0x04018DE8 RID: 101864
		protected Action<int> OnMoveToScrollViewCallBack;

		// Token: 0x04018DE9 RID: 101865
		protected Action<int> OnRemoveFromScrollViewCallBack;

		// Token: 0x04018DEA RID: 101866
		protected Action<int> ClickFunction;

		// Token: 0x04018DEB RID: 101867
		protected Action<int> ClickFailFunction;

		// Token: 0x04018DEC RID: 101868
		protected Action<int> OnBeginDragFunction;

		// Token: 0x04018DED RID: 101869
		protected Action<int> OnDragAnimationStartFunction;

		// Token: 0x04018DEE RID: 101870
		protected Action<int> OnDragAnimationEndFunction;

		// Token: 0x04018DEF RID: 101871
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		protected Action<TItem, TItem, bool> OnDragEndFunction;

		// Token: 0x04018DF0 RID: 101872
		private ULGUIPointerEventData CurrentMoveData;

		// Token: 0x04018DF1 RID: 101873
		private bool CurrentClickState;

		// Token: 0x04018DF2 RID: 101874
		private float CurrentRunningTime;

		// Token: 0x04018DF3 RID: 101875
		private bool IfDragMove;

		// Token: 0x04018DF4 RID: 101876
		private bool PlayDragSequenceState;

		// Token: 0x04018DF5 RID: 101877
		private int CurrentTick = -1;

		// Token: 0x04018DF6 RID: 101878
		private bool IfBeginDrag;

		// Token: 0x04018DF7 RID: 101879
		private int CurrentCheckFingerTick = -1;

		// Token: 0x04018DF8 RID: 101880
		private double LastClickTime;

		// Token: 0x04018DF9 RID: 101881
		[Nullable(1)]
		private readonly Vector StaticBeginVector = Vector.Create();

		// Token: 0x04018DFA RID: 101882
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected List<TItem> CheckList;

		// Token: 0x04018DFB RID: 101883
		protected TItem CurrentStaying;

		// Token: 0x04018DFC RID: 101884
		private bool CeaseFailAnimationState;

		// Token: 0x04018DFD RID: 101885
		private bool DragState;

		// Token: 0x04018DFE RID: 101886
		private readonly LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04018DFF RID: 101887
		private float MoveParentDelay;

		// Token: 0x04018E00 RID: 101888
		private Vector2D StartPosition;

		// Token: 0x04018E01 RID: 101889
		private Vector2D AnimationTargetPosition;

		// Token: 0x04018E02 RID: 101890
		private readonly UUIItem MovingParent;

		// Token: 0x04018E03 RID: 101891
		private readonly UUIItem NormalParent;

		// Token: 0x04018E04 RID: 101892
		private readonly FVector2D? StretchVector;

		// Token: 0x04018E05 RID: 101893
		private readonly UUIItem DragItem;

		// Token: 0x04018E06 RID: 101894
		[Nullable(1)]
		private readonly Vector2D ScrollViewBounceX = new Vector2D(0.0, 0.0);

		// Token: 0x04018E07 RID: 101895
		[Nullable(1)]
		private readonly Vector2D ScrollViewBounceY = new Vector2D(0.0, 0.0);

		// Token: 0x04018E08 RID: 101896
		private bool IfStayInScrollView;

		// Token: 0x04018E09 RID: 101897
		[Nullable(1)]
		private readonly Vector2D CurrentAnimationTargetPos = new Vector2D(0.0, 0.0);

		// Token: 0x04018E0A RID: 101898
		private bool CeaseState;

		// Token: 0x04018E0B RID: 101899
		[Nullable(1)]
		private readonly Vector2D AnimationStartPos = new Vector2D(0.0, 0.0);

		// Token: 0x04018E0C RID: 101900
		private bool MovingState;

		// Token: 0x04018E0D RID: 101901
		private readonly ULGUICanvas Canvas;

		// Token: 0x04018E0E RID: 101902
		private const float CLICKCALLGAP = 0.1f;

		// Token: 0x04018E0F RID: 101903
		private const int MOVEPARENTDELAYTIME = 1;

		// Token: 0x04018E10 RID: 101904
		private const int HEIGHTCANVASSORT = 100;
	}
}
