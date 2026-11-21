using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003577 RID: 13687
	[NullableContext(2)]
	[Nullable(0)]
	public class CommonDragItemLogic<[Nullable(0)] TItem, [Nullable(1)] TData> where TItem : CommonDragLogicDataItem<TData> where TData : class
	{
		// Token: 0x06022DEA RID: 142826 RVA: 0x009E6EFC File Offset: 0x009E50FC
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

		// Token: 0x06022DEB RID: 142827 RVA: 0x009E710D File Offset: 0x009E530D
		[NullableContext(1)]
		public UUIItem GetNormalParent()
		{
			return this.NormalParent;
		}

		// Token: 0x06022DEC RID: 142828 RVA: 0x009E7115 File Offset: 0x009E5315
		[NullableContext(1)]
		public TItem GetItem()
		{
			return this.Delegate;
		}

		// Token: 0x06022DED RID: 142829 RVA: 0x009E7120 File Offset: 0x009E5320
		public void SetActive(bool state)
		{
			UUIDraggableComponent dragComponent = this.DragComponent;
			if (dragComponent == null)
			{
				return;
			}
			dragComponent.RootUIComp.Get().SetUIActive(state);
		}

		// Token: 0x06022DEE RID: 142830 RVA: 0x009E714C File Offset: 0x009E534C
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

		// Token: 0x06022DEF RID: 142831 RVA: 0x009E71F3 File Offset: 0x009E53F3
		public void Refresh(TData data)
		{
			this.Delegate.SetCurrentData(data);
		}

		// Token: 0x06022DF0 RID: 142832 RVA: 0x009E7206 File Offset: 0x009E5406
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

		// Token: 0x06022DF1 RID: 142833 RVA: 0x009E7238 File Offset: 0x009E5438
		public Vector2D GetAnimationTargetPos()
		{
			return this.AnimationTargetPosition;
		}

		// Token: 0x06022DF2 RID: 142834 RVA: 0x009E7240 File Offset: 0x009E5440
		public void SetDragItemHierarchyMax()
		{
			this.DragItem.SetAsLastHierarchy();
			this.Canvas.SetSortOrder(101, true);
		}

		// Token: 0x06022DF3 RID: 142835 RVA: 0x009E725B File Offset: 0x009E545B
		public TData GetCurrentData()
		{
			return this.Delegate.GetCurrentData();
		}

		// Token: 0x06022DF4 RID: 142836 RVA: 0x009E7270 File Offset: 0x009E5470
		public void CacheStartDragPosition()
		{
			FVector lguispaceAbsolutePosition = this.DragComponent.RootUIComp.Get().GetLGUISpaceAbsolutePosition();
			FVector lguispaceAbsolutePosition2 = this.DragComponent.RootUIComp.Get().GetLGUISpaceAbsolutePosition();
			this.StartPosition = new Vector2D((double)lguispaceAbsolutePosition2.X, (double)lguispaceAbsolutePosition2.Y);
			this.AnimationTargetPosition = new Vector2D((double)lguispaceAbsolutePosition.X, (double)lguispaceAbsolutePosition.Y);
		}

		// Token: 0x06022DF5 RID: 142837 RVA: 0x009E72E4 File Offset: 0x009E54E4
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

		// Token: 0x06022DF6 RID: 142838 RVA: 0x009E73A8 File Offset: 0x009E55A8
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

		// Token: 0x06022DF7 RID: 142839 RVA: 0x009E7418 File Offset: 0x009E5618
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

		// Token: 0x06022DF8 RID: 142840 RVA: 0x009E748D File Offset: 0x009E568D
		public virtual void SetToTargetParentAndSetStretch(UUIItem targetItem)
		{
		}

		// Token: 0x06022DF9 RID: 142841 RVA: 0x009E748F File Offset: 0x009E568F
		public void SetToNormalParent()
		{
			this.SetToTargetParentAndSetStretch(this.MovingParent);
		}

		// Token: 0x06022DFA RID: 142842 RVA: 0x009E749D File Offset: 0x009E569D
		public void SetDragSuccessCallBack([Nullable(new byte[]
		{
			1,
			1,
			2
		})] Action<TItem, TItem, bool> onFunction)
		{
			this.OnDragEndFunction = onFunction;
		}

		// Token: 0x06022DFB RID: 142843 RVA: 0x009E74A6 File Offset: 0x009E56A6
		[NullableContext(1)]
		public void SetMoveToScrollViewCallBack(Action<int> callBack)
		{
			this.OnMoveToScrollViewCallBack = callBack;
		}

		// Token: 0x06022DFC RID: 142844 RVA: 0x009E74AF File Offset: 0x009E56AF
		[NullableContext(1)]
		public void SetRemoveFromScrollViewCallBack(Action<int> callBack)
		{
			this.OnRemoveFromScrollViewCallBack = callBack;
		}

		// Token: 0x06022DFD RID: 142845 RVA: 0x009E74B8 File Offset: 0x009E56B8
		[NullableContext(1)]
		public void SetEndDragWhenOnScrollViewCallBack(Action<int, TData> callBack)
		{
			this.OnEndDragWhenOnScrollViewCallBack = callBack;
		}

		// Token: 0x06022DFE RID: 142846 RVA: 0x009E74C1 File Offset: 0x009E56C1
		[NullableContext(1)]
		public void SetOnUnOverlayCallBack(Action<int> callBack)
		{
			this.Delegate.SetOnUnOverlayCallBack(callBack);
		}

		// Token: 0x06022DFF RID: 142847 RVA: 0x009E74D4 File Offset: 0x009E56D4
		[NullableContext(1)]
		public void SetOnOverlayCallBack(Action<int> callBack)
		{
			this.Delegate.SetOnOverlayCallBack(callBack);
		}

		// Token: 0x06022E00 RID: 142848 RVA: 0x009E74E7 File Offset: 0x009E56E7
		[NullableContext(1)]
		public void SetPointerDownCallBack(Action<int> dragEvent)
		{
			this.OnPointerDownCallBack = dragEvent;
		}

		// Token: 0x06022E01 RID: 142849 RVA: 0x009E74F0 File Offset: 0x009E56F0
		[NullableContext(1)]
		public void SetOnDragAnimationStartFunction(Action<int> onFunction)
		{
			this.OnDragAnimationStartFunction = onFunction;
		}

		// Token: 0x06022E02 RID: 142850 RVA: 0x009E74F9 File Offset: 0x009E56F9
		[NullableContext(1)]
		public void SetOnDragAnimationEndFunction(Action<int> onFunction)
		{
			this.OnDragAnimationEndFunction = onFunction;
		}

		// Token: 0x06022E03 RID: 142851 RVA: 0x009E7502 File Offset: 0x009E5702
		[NullableContext(1)]
		public void SetOnClickCallBack(Action<int> onFunction)
		{
			this.ClickFunction = onFunction;
		}

		// Token: 0x06022E04 RID: 142852 RVA: 0x009E750B File Offset: 0x009E570B
		[NullableContext(1)]
		public void SetOnClickFailCallBack(Action<int> onFunction)
		{
			this.ClickFailFunction = onFunction;
		}

		// Token: 0x06022E05 RID: 142853 RVA: 0x009E7514 File Offset: 0x009E5714
		[NullableContext(1)]
		public void SetOnBeginDragCall(Action<int> onFunction)
		{
			this.OnBeginDragFunction = onFunction;
		}

		// Token: 0x06022E06 RID: 142854 RVA: 0x009E7520 File Offset: 0x009E5720
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

		// Token: 0x06022E07 RID: 142855 RVA: 0x009E7580 File Offset: 0x009E5780
		public int GetCurrentIndex()
		{
			return this.Index;
		}

		// Token: 0x06022E08 RID: 142856 RVA: 0x009E7588 File Offset: 0x009E5788
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

		// Token: 0x06022E09 RID: 142857 RVA: 0x009E75B6 File Offset: 0x009E57B6
		public void ClearStayingItem()
		{
			this.CurrentStaying = default(TItem);
		}

		// Token: 0x06022E0A RID: 142858 RVA: 0x009E75C4 File Offset: 0x009E57C4
		public TItem GetStayingItem()
		{
			return this.CurrentStaying;
		}

		// Token: 0x06022E0B RID: 142859 RVA: 0x009E75CC File Offset: 0x009E57CC
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

		// Token: 0x06022E0C RID: 142860 RVA: 0x009E76E4 File Offset: 0x009E58E4
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

		// Token: 0x06022E0D RID: 142861 RVA: 0x009E77A8 File Offset: 0x009E59A8
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

		// Token: 0x06022E0E RID: 142862 RVA: 0x009E783A File Offset: 0x009E5A3A
		private void ClearFingerTick()
		{
			if (this.CurrentCheckFingerTick != -1)
			{
				TickSystem.Instance.Remove(this.CurrentCheckFingerTick);
				this.CurrentCheckFingerTick = -1;
			}
		}

		// Token: 0x06022E0F RID: 142863 RVA: 0x009E7860 File Offset: 0x009E5A60
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

		// Token: 0x06022E10 RID: 142864 RVA: 0x009E78C4 File Offset: 0x009E5AC4
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

		// Token: 0x06022E11 RID: 142865 RVA: 0x009E792C File Offset: 0x009E5B2C
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

		// Token: 0x06022E12 RID: 142866 RVA: 0x009E79E9 File Offset: 0x009E5BE9
		public bool CheckAndGetCurrentClickState()
		{
			return this.CurrentClickState;
		}

		// Token: 0x06022E13 RID: 142867 RVA: 0x009E79F1 File Offset: 0x009E5BF1
		private void ClearTick()
		{
			if (this.CurrentTick != -1)
			{
				TickSystem.Instance.Remove(this.CurrentTick);
				this.CurrentTick = -1;
			}
		}

		// Token: 0x06022E14 RID: 142868 RVA: 0x009E7A14 File Offset: 0x009E5C14
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

		// Token: 0x06022E15 RID: 142869 RVA: 0x009E7A48 File Offset: 0x009E5C48
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

		// Token: 0x06022E16 RID: 142870 RVA: 0x009E7A7C File Offset: 0x009E5C7C
		public void DoCeaseSequence()
		{
			this.CeaseFailAnimationState = false;
			this.CeaseAnimationPromise = new CustomPromise<bool>();
			this.LevelSequencePlayer.PlayLevelSequenceByName("Cease", false, null, false);
		}

		// Token: 0x06022E17 RID: 142871 RVA: 0x009E7AB6 File Offset: 0x009E5CB6
		public CustomPromise<bool> GetCeaseAnimationPromise()
		{
			return this.CeaseAnimationPromise;
		}

		// Token: 0x06022E18 RID: 142872 RVA: 0x009E7AC0 File Offset: 0x009E5CC0
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

		// Token: 0x06022E19 RID: 142873 RVA: 0x009E7B08 File Offset: 0x009E5D08
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

		// Token: 0x06022E1A RID: 142874 RVA: 0x009E7B54 File Offset: 0x009E5D54
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

		// Token: 0x06022E1B RID: 142875 RVA: 0x009E7BF4 File Offset: 0x009E5DF4
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

		// Token: 0x06022E1C RID: 142876 RVA: 0x009E7C5B File Offset: 0x009E5E5B
		private bool CheckInClickGap()
		{
			return Info.Instance.IsInGamepad() || TimeUtil.Instance.GetServerTime() - this.LastClickTime > 0.10000000149011612;
		}

		// Token: 0x06022E1D RID: 142877 RVA: 0x009E7C87 File Offset: 0x009E5E87
		private bool CheckInClickableTime()
		{
			return this.CurrentRunningTime < this.Delegate.GetClickTime() && this.CheckInClickGap();
		}

		// Token: 0x06022E1E RID: 142878 RVA: 0x009E7CAC File Offset: 0x009E5EAC
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

		// Token: 0x06022E1F RID: 142879 RVA: 0x009E7DE8 File Offset: 0x009E5FE8
		[NullableContext(0)]
		public ValueTuple<float, float> GetMiddlePosition()
		{
			return new ValueTuple<float, float>(this.DragComponent.RootUIComp.Get().GetLGUISpaceCenterAbsolutePosition().X, this.DragComponent.RootUIComp.Get().GetLGUISpaceCenterAbsolutePosition().Y);
		}

		// Token: 0x06022E20 RID: 142880 RVA: 0x009E7E34 File Offset: 0x009E6034
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

		// Token: 0x06022E21 RID: 142881 RVA: 0x009E7E9C File Offset: 0x009E609C
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

		// Token: 0x06022E22 RID: 142882 RVA: 0x009E7EE7 File Offset: 0x009E60E7
		public void SetMovingState(bool state)
		{
			this.MovingState = state;
		}

		// Token: 0x0401343B RID: 78907
		public CustomPromise<bool> CeaseAnimationPromise;

		// Token: 0x0401343C RID: 78908
		private readonly TItem Delegate;

		// Token: 0x0401343D RID: 78909
		private readonly UUIDraggableComponent DragComponent;

		// Token: 0x0401343E RID: 78910
		private readonly int Index = -1;

		// Token: 0x0401343F RID: 78911
		protected Action<int> OnPointerDownCallBack;

		// Token: 0x04013440 RID: 78912
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Action<int, TData> OnEndDragWhenOnScrollViewCallBack;

		// Token: 0x04013441 RID: 78913
		protected Action<int> OnMoveToScrollViewCallBack;

		// Token: 0x04013442 RID: 78914
		protected Action<int> OnRemoveFromScrollViewCallBack;

		// Token: 0x04013443 RID: 78915
		protected Action<int> ClickFunction;

		// Token: 0x04013444 RID: 78916
		protected Action<int> ClickFailFunction;

		// Token: 0x04013445 RID: 78917
		protected Action<int> OnBeginDragFunction;

		// Token: 0x04013446 RID: 78918
		protected Action<int> OnDragAnimationStartFunction;

		// Token: 0x04013447 RID: 78919
		protected Action<int> OnDragAnimationEndFunction;

		// Token: 0x04013448 RID: 78920
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		protected Action<TItem, TItem, bool> OnDragEndFunction;

		// Token: 0x04013449 RID: 78921
		private ULGUIPointerEventData CurrentMoveData;

		// Token: 0x0401344A RID: 78922
		private bool CurrentClickState;

		// Token: 0x0401344B RID: 78923
		private float CurrentRunningTime;

		// Token: 0x0401344C RID: 78924
		private bool IfDragMove;

		// Token: 0x0401344D RID: 78925
		private bool PlayDragSequenceState;

		// Token: 0x0401344E RID: 78926
		private int CurrentTick = -1;

		// Token: 0x0401344F RID: 78927
		private bool IfBeginDrag;

		// Token: 0x04013450 RID: 78928
		private int CurrentCheckFingerTick = -1;

		// Token: 0x04013451 RID: 78929
		private double LastClickTime;

		// Token: 0x04013452 RID: 78930
		[Nullable(1)]
		private readonly Vector StaticBeginVector = Vector.Create();

		// Token: 0x04013453 RID: 78931
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected List<TItem> CheckList;

		// Token: 0x04013454 RID: 78932
		protected TItem CurrentStaying;

		// Token: 0x04013455 RID: 78933
		private bool CeaseFailAnimationState;

		// Token: 0x04013456 RID: 78934
		private bool DragState;

		// Token: 0x04013457 RID: 78935
		private readonly LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04013458 RID: 78936
		private float MoveParentDelay;

		// Token: 0x04013459 RID: 78937
		private Vector2D StartPosition;

		// Token: 0x0401345A RID: 78938
		private Vector2D AnimationTargetPosition;

		// Token: 0x0401345B RID: 78939
		private readonly UUIItem MovingParent;

		// Token: 0x0401345C RID: 78940
		private readonly UUIItem NormalParent;

		// Token: 0x0401345D RID: 78941
		private readonly FVector2D? StretchVector;

		// Token: 0x0401345E RID: 78942
		private readonly UUIItem DragItem;

		// Token: 0x0401345F RID: 78943
		[Nullable(1)]
		private readonly Vector2D ScrollViewBounceX = new Vector2D(0.0, 0.0);

		// Token: 0x04013460 RID: 78944
		[Nullable(1)]
		private readonly Vector2D ScrollViewBounceY = new Vector2D(0.0, 0.0);

		// Token: 0x04013461 RID: 78945
		private bool IfStayInScrollView;

		// Token: 0x04013462 RID: 78946
		[Nullable(1)]
		private readonly Vector2D CurrentAnimationTargetPos = new Vector2D(0.0, 0.0);

		// Token: 0x04013463 RID: 78947
		private bool CeaseState;

		// Token: 0x04013464 RID: 78948
		[Nullable(1)]
		private readonly Vector2D AnimationStartPos = new Vector2D(0.0, 0.0);

		// Token: 0x04013465 RID: 78949
		private bool MovingState;

		// Token: 0x04013466 RID: 78950
		private readonly ULGUICanvas Canvas;

		// Token: 0x04013467 RID: 78951
		private const float CLICKCALLGAP = 0.1f;

		// Token: 0x04013468 RID: 78952
		private const int MOVEPARENTDELAYTIME = 1;

		// Token: 0x04013469 RID: 78953
		private const int HEIGHTCANVASSORT = 100;
	}
}
