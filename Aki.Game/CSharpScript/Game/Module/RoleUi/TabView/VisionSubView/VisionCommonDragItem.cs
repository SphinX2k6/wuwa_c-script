using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.TabView.VisionSubView
{
	// Token: 0x02004CF5 RID: 19701
	[NullableContext(2)]
	[Nullable(0)]
	public class VisionCommonDragItem
	{
		// Token: 0x06032E7A RID: 208506 RVA: 0x00BDD218 File Offset: 0x00BDB418
		[NullableContext(1)]
		public VisionCommonDragItem(UUIItem normalParent, UUIDraggableComponent dragComponent, UUIItem dragParent, EPhantomItemIndex index)
		{
			this.StretchVector = new FVector2D?(new FVector2D(0f, 0f));
			this.NormalParent = normalParent;
			this.DragComponent = dragComponent;
			this.Index = (int)index;
			this.MovingParent = dragComponent.RootUIComp.Get().GetParentAsUIItem();
			this.DragParent = dragParent;
			dragComponent.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDown));
			dragComponent.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointUp));
			dragComponent.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDrag));
			dragComponent.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragBegin));
			dragComponent.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragEnd));
			UUIItem uuiitem = dragComponent.GetOwner().GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
			this.DragItem = uuiitem;
			this.LevelSequencePlayer = new LevelSequencePlayer(uuiitem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.FinishSequenceEvent), false);
			this.Canvas = (dragComponent.GetOwner().GetComponentByClass(ULGUICanvas.StaticClass()) as ULGUICanvas);
		}

		// Token: 0x06032E7B RID: 208507 RVA: 0x00BDD42D File Offset: 0x00BDB62D
		[NullableContext(1)]
		public UUIItem GetNormalParent()
		{
			return this.NormalParent;
		}

		// Token: 0x06032E7C RID: 208508 RVA: 0x00BDD438 File Offset: 0x00BDB638
		public void SetActive(bool state)
		{
			UUIDraggableComponent dragComponent = this.DragComponent;
			if (dragComponent == null)
			{
				return;
			}
			dragComponent.RootUIComp.Get().SetUIActive(state);
		}

		// Token: 0x06032E7D RID: 208509 RVA: 0x00BDD464 File Offset: 0x00BDB664
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

		// Token: 0x06032E7E RID: 208510 RVA: 0x00BDD50B File Offset: 0x00BDB70B
		public void Refresh(PhantomDataBase data, bool isTrialRole)
		{
			this.CurrentData = data;
			this.IsTrailRole = isTrialRole;
		}

		// Token: 0x06032E7F RID: 208511 RVA: 0x00BDD51C File Offset: 0x00BDB71C
		public void StartClickCheckTimer()
		{
			this.ClearFingerTick();
			Ticker ticker = TickSystem.Instance.Add(delegate(float _)
			{
				if (this.GetCurrentFingerNum() == 0)
				{
					this.OnPointUp(null);
					this.ClearFingerTick();
				}
			}, "DragTick", ETickingGroup.TG_PrePhysics, true, 0, true);
			if (ticker != null)
			{
				this.CurrentCheckFingerTick = ticker.Id;
			}
		}

		// Token: 0x06032E80 RID: 208512 RVA: 0x00BDD55E File Offset: 0x00BDB75E
		public Vector2D GetAnimationTargetPos()
		{
			return this.AnimationTargetPosition;
		}

		// Token: 0x06032E81 RID: 208513 RVA: 0x00BDD566 File Offset: 0x00BDB766
		public void SetDragItemHierarchyMax()
		{
			this.DragItem.SetAsLastHierarchy();
			this.Canvas.SetSortOrder(101, true);
		}

		// Token: 0x06032E82 RID: 208514 RVA: 0x00BDD581 File Offset: 0x00BDB781
		public PhantomDataBase GetCurrentData()
		{
			return this.CurrentData;
		}

		// Token: 0x06032E83 RID: 208515 RVA: 0x00BDD58C File Offset: 0x00BDB78C
		public void CacheStartDragPosition()
		{
			FVector lguispaceAbsolutePosition = this.DragComponent.RootUIComp.Get().GetLGUISpaceAbsolutePosition();
			FVector lguispaceAbsolutePosition2 = this.DragComponent.RootUIComp.Get().GetLGUISpaceAbsolutePosition();
			this.StartPosition = new Vector2D((double)lguispaceAbsolutePosition2.X, (double)lguispaceAbsolutePosition2.Y);
			this.AnimationTargetPosition = new Vector2D((double)lguispaceAbsolutePosition.X, (double)lguispaceAbsolutePosition.Y);
		}

		// Token: 0x06032E84 RID: 208516 RVA: 0x00BDD600 File Offset: 0x00BDB800
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

		// Token: 0x06032E85 RID: 208517 RVA: 0x00BDD6C4 File Offset: 0x00BDB8C4
		public void StartDragState()
		{
			this.CacheStartDragPosition();
			this.DragState = true;
			this.IfStayInScrollView = false;
			this.DragComponent.RootUIComp.Get().SetAnchorAlign(UIAnchorHorizontalAlign.Center, UIAnchorVerticalAlign.Middle);
			this.SourceWidth = this.DragComponent.RootUIComp.Get().Width;
			this.SourceHeight = this.DragComponent.RootUIComp.Get().Height;
			this.MoveParentDelay = 0;
			this.Canvas.SetSortOrder(100, true);
			this.DragComponent.RootUIComp.Get().SetBubbleUpToParent(false);
		}

		// Token: 0x06032E86 RID: 208518 RVA: 0x00BDD76C File Offset: 0x00BDB96C
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

		// Token: 0x06032E87 RID: 208519 RVA: 0x00BDD7E1 File Offset: 0x00BDB9E1
		public void SetToTargetParentAndSetStretch(UUIItem targetItem)
		{
		}

		// Token: 0x06032E88 RID: 208520 RVA: 0x00BDD7E3 File Offset: 0x00BDB9E3
		public void SetToNormalParent()
		{
			this.SetToTargetParentAndSetStretch(this.MovingParent);
		}

		// Token: 0x06032E89 RID: 208521 RVA: 0x00BDD7F1 File Offset: 0x00BDB9F1
		[NullableContext(1)]
		public void SetDragSuccessCallBack(Action<VisionCommonDragItem, List<VisionCommonDragItem>, bool> onFunction)
		{
			this.OnDragEndFunction = onFunction;
		}

		// Token: 0x06032E8A RID: 208522 RVA: 0x00BDD7FA File Offset: 0x00BDB9FA
		[NullableContext(1)]
		public void SetMoveToScrollViewCallBack(Action<int> callBack)
		{
			this.OnMoveToScrollViewCallBack = callBack;
		}

		// Token: 0x06032E8B RID: 208523 RVA: 0x00BDD803 File Offset: 0x00BDBA03
		[NullableContext(1)]
		public void SetRemoveFromScrollViewCallBack(Action<int> callBack)
		{
			this.OnRemoveFromScrollViewCallBack = callBack;
		}

		// Token: 0x06032E8C RID: 208524 RVA: 0x00BDD80C File Offset: 0x00BDBA0C
		[NullableContext(1)]
		public void SetEndDragWhenOnScrollViewCallBack(Action<int, PhantomBattleData> callBack)
		{
			this.OnEndDragWhenOnScrollViewCallBack = callBack;
		}

		// Token: 0x06032E8D RID: 208525 RVA: 0x00BDD815 File Offset: 0x00BDBA15
		[NullableContext(1)]
		public void SetOnUnOverlayCallBack(Action<int> callBack)
		{
			this.OnUnOverlayCallBack = callBack;
		}

		// Token: 0x06032E8E RID: 208526 RVA: 0x00BDD81E File Offset: 0x00BDBA1E
		[NullableContext(1)]
		public void SetOnOverlayCallBack(Action<int> callBack)
		{
			this.OnOverlayCallBack = callBack;
		}

		// Token: 0x06032E8F RID: 208527 RVA: 0x00BDD827 File Offset: 0x00BDBA27
		[NullableContext(1)]
		public void SetPointerDownCallBack(Action<int> dragEvent)
		{
			this.OnPointerDownCallBack = dragEvent;
		}

		// Token: 0x06032E90 RID: 208528 RVA: 0x00BDD830 File Offset: 0x00BDBA30
		[NullableContext(1)]
		public void SetPointerUpCallBack(Action<int> dragEvent)
		{
			this.OnPointerUpCallBack = dragEvent;
		}

		// Token: 0x06032E91 RID: 208529 RVA: 0x00BDD839 File Offset: 0x00BDBA39
		[NullableContext(1)]
		public void SetOnDragAnimationStartFunction(Action<int> onFunction)
		{
			this.OnDragAnimationStartFunction = onFunction;
		}

		// Token: 0x06032E92 RID: 208530 RVA: 0x00BDD842 File Offset: 0x00BDBA42
		[NullableContext(1)]
		public void SetOnDragAnimationEndFunction(Action<int> onFunction)
		{
			this.OnDragAnimationEndFunction = onFunction;
		}

		// Token: 0x06032E93 RID: 208531 RVA: 0x00BDD84B File Offset: 0x00BDBA4B
		[NullableContext(1)]
		public void SetOnClickCallBack(Action<int> onFunction)
		{
			this.ClickFunction = onFunction;
		}

		// Token: 0x06032E94 RID: 208532 RVA: 0x00BDD854 File Offset: 0x00BDBA54
		[NullableContext(1)]
		public void SetOnClickFailCallBack(Action<int> onFunction)
		{
			this.ClickFailFunction = onFunction;
		}

		// Token: 0x06032E95 RID: 208533 RVA: 0x00BDD85D File Offset: 0x00BDBA5D
		[NullableContext(1)]
		public void SetOnBeginDragCall(Action<int> onFunction)
		{
			this.OnBeginDragFunction = onFunction;
		}

		// Token: 0x06032E96 RID: 208534 RVA: 0x00BDD866 File Offset: 0x00BDBA66
		[NullableContext(1)]
		public void SetDragCheckItem(List<VisionCommonDragItem> itemList)
		{
			this.CheckList = itemList;
		}

		// Token: 0x06032E97 RID: 208535 RVA: 0x00BDD86F File Offset: 0x00BDBA6F
		public int GetCurrentIndex()
		{
			return this.Index;
		}

		// Token: 0x06032E98 RID: 208536 RVA: 0x00BDD877 File Offset: 0x00BDBA77
		public void TickCheckDrag()
		{
			if (this.MoveParentDelay <= 1)
			{
				this.MoveParentDelay++;
				return;
			}
			this.SetItemToPointerPosition();
			this.CheckOnDrag();
		}

		// Token: 0x06032E99 RID: 208537 RVA: 0x00BDD89D File Offset: 0x00BDBA9D
		public void ClearStayingItem()
		{
			this.CurrentStaying.Clear();
		}

		// Token: 0x06032E9A RID: 208538 RVA: 0x00BDD8AA File Offset: 0x00BDBAAA
		[NullableContext(1)]
		public List<VisionCommonDragItem> GetStayingItem()
		{
			return this.CurrentStaying;
		}

		// Token: 0x06032E9B RID: 208539 RVA: 0x00BDD8B4 File Offset: 0x00BDBAB4
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

		// Token: 0x06032E9C RID: 208540 RVA: 0x00BDD9CC File Offset: 0x00BDBBCC
		private void OnPointerDown(ULGUIPointerEventData eventData)
		{
			if (!PhantomBattleModel.Instance.CheckIfCanDrag() || this.DragState)
			{
				return;
			}
			PhantomBattleModel.Instance.SetCurrentDragIndex(this.Index);
			this.CurrentClickState = false;
			this.CurrentRunningTime = 0f;
			this.PlayDragSequenceState = false;
			this.IfDragMove = false;
			this.CurrentMoveData = null;
			this.IfBeginDrag = false;
			Ticker ticker = TickSystem.Instance.Add(delegate(float _)
			{
				this.CheckTimeForDoDrag();
				this.CurrentRunningTime += Time.Instance.DeltaTime;
			}, "DragTick", ETickingGroup.TG_PrePhysics, true, 0, true);
			if (ticker != null)
			{
				this.CurrentTick = ticker.Id;
			}
			if (this.CurrentData != null)
			{
				Action<int> onPointerDownCallBack = this.OnPointerDownCallBack;
				if (onPointerDownCallBack == null)
				{
					return;
				}
				onPointerDownCallBack(this.GetCurrentIndex());
			}
		}

		// Token: 0x06032E9D RID: 208541 RVA: 0x00BDDA7C File Offset: 0x00BDBC7C
		private void OnPointUp(ULGUIPointerEventData eventData)
		{
			this.ClearTick();
			this.ClearFingerTick();
			if (!PhantomBattleModel.Instance.CheckIfCurrentDragIndex(this.Index))
			{
				return;
			}
			PhantomBattleModel.Instance.ClearCurrentDragIndex();
			Action<int> onPointerUpCallBack = this.OnPointerUpCallBack;
			if (onPointerUpCallBack != null)
			{
				onPointerUpCallBack(this.Index);
			}
			if (this.IsTrailRole)
			{
				if (this.CheckInClickGap())
				{
					this.TryDoClick(true);
					return;
				}
				this.TryDoClick(false);
				return;
			}
			else
			{
				if (this.CurrentData == null)
				{
					if (this.CheckInClickableTime())
					{
						this.TryDoClick(true);
					}
					return;
				}
				float currentRunningTime = this.CurrentRunningTime;
				if (!this.IfBeginDrag)
				{
					this.TryDoClick(false);
				}
				return;
			}
		}

		// Token: 0x06032E9E RID: 208542 RVA: 0x00BDDB1B File Offset: 0x00BDBD1B
		private void ClearFingerTick()
		{
			if (this.CurrentCheckFingerTick != -1)
			{
				TickSystem.Instance.Remove(this.CurrentCheckFingerTick);
				this.CurrentCheckFingerTick = -1;
			}
		}

		// Token: 0x06032E9F RID: 208543 RVA: 0x00BDDB40 File Offset: 0x00BDBD40
		private void OnDrag(ULGUIPointerEventData eventData)
		{
			if (this.IsTrailRole)
			{
				return;
			}
			if (!PhantomBattleModel.Instance.CheckIfCurrentDragIndex(this.Index))
			{
				return;
			}
			if (this.CurrentData == null)
			{
				return;
			}
			this.CurrentMoveData = eventData;
			if (this.CurrentRunningTime < 300f)
			{
				return;
			}
			this.TickCheckDrag();
		}

		// Token: 0x06032EA0 RID: 208544 RVA: 0x00BDDB90 File Offset: 0x00BDBD90
		private void OnDragBegin(ULGUIPointerEventData eventData)
		{
			if (this.IsTrailRole)
			{
				return;
			}
			if (!PhantomBattleModel.Instance.CheckIfCurrentDragIndex(this.Index))
			{
				return;
			}
			if (this.CurrentData == null)
			{
				PhantomBattleModel.Instance.ClearCurrentDragIndex();
				return;
			}
			this.CurrentStaying.Clear();
			this.IfDragMove = true;
			this.IfBeginDrag = true;
		}

		// Token: 0x06032EA1 RID: 208545 RVA: 0x00BDDBE8 File Offset: 0x00BDBDE8
		private void OnDragEnd(ULGUIPointerEventData eventData)
		{
			if (this.IsTrailRole)
			{
				return;
			}
			if (this.CurrentData == null)
			{
				return;
			}
			if (this.IfDragMove)
			{
				if (this.CurrentRunningTime < 300f)
				{
					this.TryDoClick(false);
				}
				else if (!this.IfStayInScrollView)
				{
					Action<VisionCommonDragItem, List<VisionCommonDragItem>, bool> onDragEndFunction = this.OnDragEndFunction;
					if (onDragEndFunction != null)
					{
						onDragEndFunction(this, this.CurrentStaying, this.IfStayInScrollView);
					}
				}
				this.IfDragMove = false;
			}
			if (this.IfStayInScrollView)
			{
				this.IfStayInScrollView = false;
				this.CeaseFailAnimationState = false;
				Action<int, PhantomBattleData> onEndDragWhenOnScrollViewCallBack = this.OnEndDragWhenOnScrollViewCallBack;
				if (onEndDragWhenOnScrollViewCallBack == null)
				{
					return;
				}
				onEndDragWhenOnScrollViewCallBack(this.GetCurrentIndex(), this.CurrentData as PhantomBattleData);
			}
		}

		// Token: 0x06032EA2 RID: 208546 RVA: 0x00BDDC8A File Offset: 0x00BDBE8A
		public bool CheckAndGetCurrentClickState()
		{
			return this.CurrentClickState;
		}

		// Token: 0x06032EA3 RID: 208547 RVA: 0x00BDDC92 File Offset: 0x00BDBE92
		private void ClearTick()
		{
			if (this.CurrentTick != -1)
			{
				TickSystem.Instance.Remove(this.CurrentTick);
				this.CurrentTick = -1;
			}
		}

		// Token: 0x06032EA4 RID: 208548 RVA: 0x00BDDCB8 File Offset: 0x00BDBEB8
		public void CancelDrag()
		{
			this.ClearTick();
			this.ClearFingerTick();
			this.IfDragMove = false;
			this.IfBeginDrag = false;
			this.IfStayInScrollView = false;
			this.CurrentStaying.Clear();
			this.CeaseState = false;
			this.MovingState = false;
			this.CeaseFailAnimationState = false;
			CustomPromise<bool> ceaseAnimationPromise = this.CeaseAnimationPromise;
			if (ceaseAnimationPromise == null)
			{
				return;
			}
			ceaseAnimationPromise.SetResult(true);
		}

		// Token: 0x06032EA5 RID: 208549 RVA: 0x00BDDD18 File Offset: 0x00BDBF18
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

		// Token: 0x06032EA6 RID: 208550 RVA: 0x00BDDD4C File Offset: 0x00BDBF4C
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

		// Token: 0x06032EA7 RID: 208551 RVA: 0x00BDDD80 File Offset: 0x00BDBF80
		public void DoCeaseSequence()
		{
			this.CeaseFailAnimationState = false;
			this.CeaseAnimationPromise = new CustomPromise<bool>();
			this.LevelSequencePlayer.PlayLevelSequenceByName("Cease", false, null, false);
		}

		// Token: 0x06032EA8 RID: 208552 RVA: 0x00BDDDBA File Offset: 0x00BDBFBA
		public CustomPromise<bool> GetCeaseAnimationPromise()
		{
			return this.CeaseAnimationPromise;
		}

		// Token: 0x06032EA9 RID: 208553 RVA: 0x00BDDDC4 File Offset: 0x00BDBFC4
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

		// Token: 0x06032EAA RID: 208554 RVA: 0x00BDDE0C File Offset: 0x00BDC00C
		private void DoDragSequence()
		{
			if (this.IsTrailRole)
			{
				return;
			}
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

		// Token: 0x06032EAB RID: 208555 RVA: 0x00BDDE60 File Offset: 0x00BDC060
		private void CheckTimeForDoDrag()
		{
			if (this.GetCurrentFingerNum() >= 2 || this.GetCurrentFingerNum() == 0)
			{
				this.ClearTick();
				return;
			}
			if (this.CurrentRunningTime >= 300f)
			{
				this.ClearTick();
				if (this.CurrentData == null)
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

		// Token: 0x06032EAC RID: 208556 RVA: 0x00BDDEE4 File Offset: 0x00BDC0E4
		private bool TryDoClick(bool force = false)
		{
			if (this.CheckIsBlockedByOther())
			{
				this.CurrentClickState = false;
				return false;
			}
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

		// Token: 0x06032EAD RID: 208557 RVA: 0x00BDDF5C File Offset: 0x00BDC15C
		private bool CheckIsBlockedByOther()
		{
			UUIItem nowHitComponent = LguiEventSystemManager.Instance.GetNowHitComponent();
			return nowHitComponent != null && nowHitComponent != this.DragItem && nowHitComponent != this.DragParent;
		}

		// Token: 0x06032EAE RID: 208558 RVA: 0x00BDDF8E File Offset: 0x00BDC18E
		private bool CheckInClickGap()
		{
			return Info.Instance.IsInGamepad() || TimeUtil.Instance.GetServerTime() - this.LastClickTime > 1.0;
		}

		// Token: 0x06032EAF RID: 208559 RVA: 0x00BDDFBA File Offset: 0x00BDC1BA
		private bool CheckInClickableTime()
		{
			return this.CurrentRunningTime < 300f && this.CheckInClickGap();
		}

		// Token: 0x06032EB0 RID: 208560 RVA: 0x00BDDFD4 File Offset: 0x00BDC1D4
		private void CheckOnDrag()
		{
			List<VisionCommonDragItem> list = new List<VisionCommonDragItem>();
			if (this.CheckList != null)
			{
				foreach (VisionCommonDragItem visionCommonDragItem in this.CheckList)
				{
					if (!visionCommonDragItem.CheckIfSelfItem(this.Index) && visionCommonDragItem.CheckOverlap(this.GetBounceX(), this.GetBounceY()))
					{
						list.Add(visionCommonDragItem);
					}
				}
			}
			foreach (VisionCommonDragItem visionCommonDragItem2 in this.CurrentStaying)
			{
				if (!list.Contains(visionCommonDragItem2))
				{
					visionCommonDragItem2.OnUnOverlay();
				}
			}
			foreach (VisionCommonDragItem visionCommonDragItem3 in list)
			{
				if (!this.CurrentStaying.Contains(visionCommonDragItem3))
				{
					visionCommonDragItem3.OnOverlay();
				}
			}
			this.CurrentStaying = list;
			if (this.ScrollViewBounceX.X != 0.0)
			{
				if (this.CheckOverlap(this.ScrollViewBounceX, this.ScrollViewBounceY))
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

		// Token: 0x06032EB1 RID: 208561 RVA: 0x00BDE16C File Offset: 0x00BDC36C
		public bool CheckIfSelfItem(int index)
		{
			return index == this.Index;
		}

		// Token: 0x06032EB2 RID: 208562 RVA: 0x00BDE178 File Offset: 0x00BDC378
		[NullableContext(1)]
		public bool CheckOverlap(Vector2D inX, Vector2D inY)
		{
			double x = inX.X;
			double y = inX.Y;
			double x2 = inY.X;
			double y2 = inY.Y;
			double x3 = this.GetBounceX().X;
			double y3 = this.GetBounceX().Y;
			double x4 = this.GetBounceY().X;
			double y4 = this.GetBounceY().Y;
			return x < y3 && x3 < y && x2 < y4 && x4 < y2;
		}

		// Token: 0x06032EB3 RID: 208563 RVA: 0x00BDE1E8 File Offset: 0x00BDC3E8
		[NullableContext(1)]
		private Vector2D GetBounceX()
		{
			UUIItem uuiitem = this.DragComponent.RootUIComp.Get();
			float num = this.SourceWidth / 2f;
			float num2 = uuiitem.GetLGUISpaceCenterAbsolutePosition().X - num;
			float num3 = uuiitem.GetLGUISpaceCenterAbsolutePosition().X + num;
			this.BounceX.X = (double)num2;
			this.BounceX.Y = (double)num3;
			return this.BounceX;
		}

		// Token: 0x06032EB4 RID: 208564 RVA: 0x00BDE250 File Offset: 0x00BDC450
		[NullableContext(1)]
		private Vector2D GetBounceY()
		{
			UUIItem uuiitem = this.DragComponent.RootUIComp.Get();
			float num = this.SourceHeight / 2f;
			float num2 = uuiitem.GetLGUISpaceCenterAbsolutePosition().Y - num;
			float num3 = uuiitem.GetLGUISpaceCenterAbsolutePosition().Y + num;
			this.BounceY.X = (double)num2;
			this.BounceY.Y = (double)num3;
			return this.BounceY;
		}

		// Token: 0x06032EB5 RID: 208565 RVA: 0x00BDE2B8 File Offset: 0x00BDC4B8
		private void OnUnOverlay()
		{
			Action<int> onUnOverlayCallBack = this.OnUnOverlayCallBack;
			if (onUnOverlayCallBack == null)
			{
				return;
			}
			onUnOverlayCallBack(this.GetCurrentIndex());
		}

		// Token: 0x06032EB6 RID: 208566 RVA: 0x00BDE2D0 File Offset: 0x00BDC4D0
		private void OnOverlay()
		{
			Action<int> onOverlayCallBack = this.OnOverlayCallBack;
			if (onOverlayCallBack == null)
			{
				return;
			}
			onOverlayCallBack(this.GetCurrentIndex());
		}

		// Token: 0x06032EB7 RID: 208567 RVA: 0x00BDE2E8 File Offset: 0x00BDC4E8
		[NullableContext(0)]
		public ValueTuple<float, float> GetMiddlePosition()
		{
			return new ValueTuple<float, float>(this.DragComponent.RootUIComp.Get().GetLGUISpaceCenterAbsolutePosition().X, this.DragComponent.RootUIComp.Get().GetLGUISpaceCenterAbsolutePosition().Y);
		}

		// Token: 0x06032EB8 RID: 208568 RVA: 0x00BDE334 File Offset: 0x00BDC534
		[NullableContext(1)]
		public static int GetOverlapIndex(VisionCommonDragItem self, List<VisionCommonDragItem> targets)
		{
			int count = targets.Count;
			ValueTuple<float, float> middlePosition = self.GetMiddlePosition();
			int currentIndex = targets[0].GetCurrentIndex();
			ValueTuple<float, float> middlePosition2 = targets[0].GetMiddlePosition();
			float num = middlePosition.Item1 * middlePosition.Item1;
			float num2 = middlePosition.Item2 * middlePosition.Item2;
			float num3 = Math.Abs(num - middlePosition2.Item1 * middlePosition2.Item1);
			float num4 = Math.Abs(num2 - middlePosition2.Item2 * middlePosition2.Item2);
			float num5 = num3 + num4;
			for (int i = 0; i < count; i++)
			{
				middlePosition2 = targets[i].GetMiddlePosition();
				float num6 = Math.Abs(num - middlePosition2.Item1 * middlePosition2.Item1);
				num4 = Math.Abs(num2 - middlePosition2.Item2 * middlePosition2.Item2);
				float num7 = num6 + num4;
				if (num5 > num7)
				{
					num5 = num7;
					currentIndex = targets[i].GetCurrentIndex();
				}
			}
			return currentIndex;
		}

		// Token: 0x06032EB9 RID: 208569 RVA: 0x00BDE420 File Offset: 0x00BDC620
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

		// Token: 0x06032EBA RID: 208570 RVA: 0x00BDE488 File Offset: 0x00BDC688
		public UniTask TickDoCeaseAnimation(float currentProgress)
		{
			VisionCommonDragItem.<TickDoCeaseAnimation>d__121 <TickDoCeaseAnimation>d__;
			<TickDoCeaseAnimation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TickDoCeaseAnimation>d__.<>4__this = this;
			<TickDoCeaseAnimation>d__.currentProgress = currentProgress;
			<TickDoCeaseAnimation>d__.<>1__state = -1;
			<TickDoCeaseAnimation>d__.<>t__builder.Start<VisionCommonDragItem.<TickDoCeaseAnimation>d__121>(ref <TickDoCeaseAnimation>d__);
			return <TickDoCeaseAnimation>d__.<>t__builder.Task;
		}

		// Token: 0x06032EBB RID: 208571 RVA: 0x00BDE4D3 File Offset: 0x00BDC6D3
		public void SetMovingState(bool state)
		{
			this.MovingState = state;
		}

		// Token: 0x0401B11F RID: 110879
		private const int CLICKTIME = 300;

		// Token: 0x0401B120 RID: 110880
		private const int CLICKCALLGAP = 1;

		// Token: 0x0401B121 RID: 110881
		private const int MOVEPARENTDELAYTIME = 1;

		// Token: 0x0401B122 RID: 110882
		private const int HEIGHTCANVASSORT = 100;

		// Token: 0x0401B123 RID: 110883
		public CustomPromise<bool> CeaseAnimationPromise;

		// Token: 0x0401B124 RID: 110884
		private readonly UUIDraggableComponent DragComponent;

		// Token: 0x0401B125 RID: 110885
		private readonly int Index = -1;

		// Token: 0x0401B126 RID: 110886
		private Action<int> OnPointerDownCallBack;

		// Token: 0x0401B127 RID: 110887
		private Action<int> OnPointerUpCallBack;

		// Token: 0x0401B128 RID: 110888
		private Action<int> OnOverlayCallBack;

		// Token: 0x0401B129 RID: 110889
		private Action<int> OnUnOverlayCallBack;

		// Token: 0x0401B12A RID: 110890
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<int, PhantomBattleData> OnEndDragWhenOnScrollViewCallBack;

		// Token: 0x0401B12B RID: 110891
		private Action<int> OnMoveToScrollViewCallBack;

		// Token: 0x0401B12C RID: 110892
		private Action<int> OnRemoveFromScrollViewCallBack;

		// Token: 0x0401B12D RID: 110893
		private Action<int> ClickFunction;

		// Token: 0x0401B12E RID: 110894
		private Action<int> ClickFailFunction;

		// Token: 0x0401B12F RID: 110895
		private Action<int> OnBeginDragFunction;

		// Token: 0x0401B130 RID: 110896
		private Action<int> OnDragAnimationStartFunction;

		// Token: 0x0401B131 RID: 110897
		private Action<int> OnDragAnimationEndFunction;

		// Token: 0x0401B132 RID: 110898
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private Action<VisionCommonDragItem, List<VisionCommonDragItem>, bool> OnDragEndFunction;

		// Token: 0x0401B133 RID: 110899
		private ULGUIPointerEventData CurrentMoveData;

		// Token: 0x0401B134 RID: 110900
		private bool CurrentClickState;

		// Token: 0x0401B135 RID: 110901
		private float CurrentRunningTime;

		// Token: 0x0401B136 RID: 110902
		private bool IfDragMove;

		// Token: 0x0401B137 RID: 110903
		private bool PlayDragSequenceState;

		// Token: 0x0401B138 RID: 110904
		private int CurrentTick = -1;

		// Token: 0x0401B139 RID: 110905
		private bool IfBeginDrag;

		// Token: 0x0401B13A RID: 110906
		private int CurrentCheckFingerTick = -1;

		// Token: 0x0401B13B RID: 110907
		private double LastClickTime;

		// Token: 0x0401B13C RID: 110908
		[Nullable(1)]
		private readonly Vector StaticBeginVector = Vector.Create();

		// Token: 0x0401B13D RID: 110909
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<VisionCommonDragItem> CheckList;

		// Token: 0x0401B13E RID: 110910
		private float SourceWidth;

		// Token: 0x0401B13F RID: 110911
		private float SourceHeight;

		// Token: 0x0401B140 RID: 110912
		[Nullable(1)]
		private readonly Vector2D BounceX = new Vector2D(0.0, 0.0);

		// Token: 0x0401B141 RID: 110913
		[Nullable(1)]
		private readonly Vector2D BounceY = new Vector2D(0.0, 0.0);

		// Token: 0x0401B142 RID: 110914
		[Nullable(1)]
		private List<VisionCommonDragItem> CurrentStaying = new List<VisionCommonDragItem>();

		// Token: 0x0401B143 RID: 110915
		private bool CeaseFailAnimationState;

		// Token: 0x0401B144 RID: 110916
		private bool DragState;

		// Token: 0x0401B145 RID: 110917
		private readonly LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401B146 RID: 110918
		private int MoveParentDelay;

		// Token: 0x0401B147 RID: 110919
		private PhantomDataBase CurrentData;

		// Token: 0x0401B148 RID: 110920
		private Vector2D StartPosition;

		// Token: 0x0401B149 RID: 110921
		private Vector2D AnimationTargetPosition;

		// Token: 0x0401B14A RID: 110922
		private readonly UUIItem MovingParent;

		// Token: 0x0401B14B RID: 110923
		private readonly UUIItem NormalParent;

		// Token: 0x0401B14C RID: 110924
		private readonly FVector2D? StretchVector;

		// Token: 0x0401B14D RID: 110925
		private readonly UUIItem DragItem;

		// Token: 0x0401B14E RID: 110926
		private readonly UUIItem DragParent;

		// Token: 0x0401B14F RID: 110927
		[Nullable(1)]
		private readonly Vector2D ScrollViewBounceX = new Vector2D(0.0, 0.0);

		// Token: 0x0401B150 RID: 110928
		[Nullable(1)]
		private readonly Vector2D ScrollViewBounceY = new Vector2D(0.0, 0.0);

		// Token: 0x0401B151 RID: 110929
		private bool IfStayInScrollView;

		// Token: 0x0401B152 RID: 110930
		[Nullable(1)]
		private readonly Vector2D CurrentAnimationTargetPos = new Vector2D(0.0, 0.0);

		// Token: 0x0401B153 RID: 110931
		private bool CeaseState;

		// Token: 0x0401B154 RID: 110932
		[Nullable(1)]
		private readonly Vector2D AnimationStartPos = new Vector2D(0.0, 0.0);

		// Token: 0x0401B155 RID: 110933
		private bool MovingState;

		// Token: 0x0401B156 RID: 110934
		private readonly ULGUICanvas Canvas;

		// Token: 0x0401B157 RID: 110935
		private bool IsTrailRole;
	}
}
