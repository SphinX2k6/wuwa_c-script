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
	// Token: 0x02003CA7 RID: 15527
	[NullableContext(2)]
	[Nullable(0)]
	public class VisionCommonDragItem
	{
		// Token: 0x06027C55 RID: 162901 RVA: 0x00B22B20 File Offset: 0x00B20D20
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

		// Token: 0x06027C56 RID: 162902 RVA: 0x00B22D35 File Offset: 0x00B20F35
		[NullableContext(1)]
		public UUIItem GetNormalParent()
		{
			return this.NormalParent;
		}

		// Token: 0x06027C57 RID: 162903 RVA: 0x00B22D40 File Offset: 0x00B20F40
		public void SetActive(bool state)
		{
			UUIDraggableComponent dragComponent = this.DragComponent;
			if (dragComponent == null)
			{
				return;
			}
			dragComponent.RootUIComp.Get().SetUIActive(state);
		}

		// Token: 0x06027C58 RID: 162904 RVA: 0x00B22D6C File Offset: 0x00B20F6C
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

		// Token: 0x06027C59 RID: 162905 RVA: 0x00B22E13 File Offset: 0x00B21013
		public void Refresh(PhantomDataBase data, bool isTrialRole)
		{
			this.CurrentData = data;
			this.IsTrailRole = isTrialRole;
		}

		// Token: 0x06027C5A RID: 162906 RVA: 0x00B22E24 File Offset: 0x00B21024
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

		// Token: 0x06027C5B RID: 162907 RVA: 0x00B22E66 File Offset: 0x00B21066
		public Vector2D GetAnimationTargetPos()
		{
			return this.AnimationTargetPosition;
		}

		// Token: 0x06027C5C RID: 162908 RVA: 0x00B22E6E File Offset: 0x00B2106E
		public void SetDragItemHierarchyMax()
		{
			this.DragItem.SetAsLastHierarchy();
			this.Canvas.SetSortOrder(101, true);
		}

		// Token: 0x06027C5D RID: 162909 RVA: 0x00B22E89 File Offset: 0x00B21089
		public PhantomDataBase GetCurrentData()
		{
			return this.CurrentData;
		}

		// Token: 0x06027C5E RID: 162910 RVA: 0x00B22E94 File Offset: 0x00B21094
		public void CacheStartDragPosition()
		{
			FVector lguispaceAbsolutePosition = this.DragComponent.RootUIComp.Get().GetLGUISpaceAbsolutePosition();
			FVector lguispaceAbsolutePosition2 = this.DragComponent.RootUIComp.Get().GetLGUISpaceAbsolutePosition();
			this.StartPosition = new Vector2D((double)lguispaceAbsolutePosition2.X, (double)lguispaceAbsolutePosition2.Y);
			this.AnimationTargetPosition = new Vector2D((double)lguispaceAbsolutePosition.X, (double)lguispaceAbsolutePosition.Y);
		}

		// Token: 0x06027C5F RID: 162911 RVA: 0x00B22F08 File Offset: 0x00B21108
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

		// Token: 0x06027C60 RID: 162912 RVA: 0x00B22FCC File Offset: 0x00B211CC
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

		// Token: 0x06027C61 RID: 162913 RVA: 0x00B23074 File Offset: 0x00B21274
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

		// Token: 0x06027C62 RID: 162914 RVA: 0x00B230E9 File Offset: 0x00B212E9
		public void SetToTargetParentAndSetStretch(UUIItem targetItem)
		{
		}

		// Token: 0x06027C63 RID: 162915 RVA: 0x00B230EB File Offset: 0x00B212EB
		public void SetToNormalParent()
		{
			this.SetToTargetParentAndSetStretch(this.MovingParent);
		}

		// Token: 0x06027C64 RID: 162916 RVA: 0x00B230F9 File Offset: 0x00B212F9
		[NullableContext(1)]
		public void SetDragSuccessCallBack(Action<VisionCommonDragItem, List<VisionCommonDragItem>, bool> onFunction)
		{
			this.OnDragEndFunction = onFunction;
		}

		// Token: 0x06027C65 RID: 162917 RVA: 0x00B23102 File Offset: 0x00B21302
		[NullableContext(1)]
		public void SetMoveToScrollViewCallBack(Action<int> callBack)
		{
			this.OnMoveToScrollViewCallBack = callBack;
		}

		// Token: 0x06027C66 RID: 162918 RVA: 0x00B2310B File Offset: 0x00B2130B
		[NullableContext(1)]
		public void SetRemoveFromScrollViewCallBack(Action<int> callBack)
		{
			this.OnRemoveFromScrollViewCallBack = callBack;
		}

		// Token: 0x06027C67 RID: 162919 RVA: 0x00B23114 File Offset: 0x00B21314
		[NullableContext(1)]
		public void SetEndDragWhenOnScrollViewCallBack(Action<int, PhantomBattleData> callBack)
		{
			this.OnEndDragWhenOnScrollViewCallBack = callBack;
		}

		// Token: 0x06027C68 RID: 162920 RVA: 0x00B2311D File Offset: 0x00B2131D
		[NullableContext(1)]
		public void SetOnUnOverlayCallBack(Action<int> callBack)
		{
			this.OnUnOverlayCallBack = callBack;
		}

		// Token: 0x06027C69 RID: 162921 RVA: 0x00B23126 File Offset: 0x00B21326
		[NullableContext(1)]
		public void SetOnOverlayCallBack(Action<int> callBack)
		{
			this.OnOverlayCallBack = callBack;
		}

		// Token: 0x06027C6A RID: 162922 RVA: 0x00B2312F File Offset: 0x00B2132F
		[NullableContext(1)]
		public void SetPointerDownCallBack(Action<int> dragEvent)
		{
			this.OnPointerDownCallBack = dragEvent;
		}

		// Token: 0x06027C6B RID: 162923 RVA: 0x00B23138 File Offset: 0x00B21338
		[NullableContext(1)]
		public void SetPointerUpCallBack(Action<int> dragEvent)
		{
			this.OnPointerUpCallBack = dragEvent;
		}

		// Token: 0x06027C6C RID: 162924 RVA: 0x00B23141 File Offset: 0x00B21341
		[NullableContext(1)]
		public void SetOnDragAnimationStartFunction(Action<int> onFunction)
		{
			this.OnDragAnimationStartFunction = onFunction;
		}

		// Token: 0x06027C6D RID: 162925 RVA: 0x00B2314A File Offset: 0x00B2134A
		[NullableContext(1)]
		public void SetOnDragAnimationEndFunction(Action<int> onFunction)
		{
			this.OnDragAnimationEndFunction = onFunction;
		}

		// Token: 0x06027C6E RID: 162926 RVA: 0x00B23153 File Offset: 0x00B21353
		[NullableContext(1)]
		public void SetOnClickCallBack(Action<int> onFunction)
		{
			this.ClickFunction = onFunction;
		}

		// Token: 0x06027C6F RID: 162927 RVA: 0x00B2315C File Offset: 0x00B2135C
		[NullableContext(1)]
		public void SetOnClickFailCallBack(Action<int> onFunction)
		{
			this.ClickFailFunction = onFunction;
		}

		// Token: 0x06027C70 RID: 162928 RVA: 0x00B23165 File Offset: 0x00B21365
		[NullableContext(1)]
		public void SetOnBeginDragCall(Action<int> onFunction)
		{
			this.OnBeginDragFunction = onFunction;
		}

		// Token: 0x06027C71 RID: 162929 RVA: 0x00B2316E File Offset: 0x00B2136E
		[NullableContext(1)]
		public void SetDragCheckItem(List<VisionCommonDragItem> itemList)
		{
			this.CheckList = itemList;
		}

		// Token: 0x06027C72 RID: 162930 RVA: 0x00B23177 File Offset: 0x00B21377
		public int GetCurrentIndex()
		{
			return this.Index;
		}

		// Token: 0x06027C73 RID: 162931 RVA: 0x00B2317F File Offset: 0x00B2137F
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

		// Token: 0x06027C74 RID: 162932 RVA: 0x00B231A5 File Offset: 0x00B213A5
		public void ClearStayingItem()
		{
			this.CurrentStaying.Clear();
		}

		// Token: 0x06027C75 RID: 162933 RVA: 0x00B231B2 File Offset: 0x00B213B2
		[NullableContext(1)]
		public List<VisionCommonDragItem> GetStayingItem()
		{
			return this.CurrentStaying;
		}

		// Token: 0x06027C76 RID: 162934 RVA: 0x00B231BC File Offset: 0x00B213BC
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

		// Token: 0x06027C77 RID: 162935 RVA: 0x00B232D4 File Offset: 0x00B214D4
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

		// Token: 0x06027C78 RID: 162936 RVA: 0x00B23384 File Offset: 0x00B21584
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

		// Token: 0x06027C79 RID: 162937 RVA: 0x00B23423 File Offset: 0x00B21623
		private void ClearFingerTick()
		{
			if (this.CurrentCheckFingerTick != -1)
			{
				TickSystem.Instance.Remove(this.CurrentCheckFingerTick);
				this.CurrentCheckFingerTick = -1;
			}
		}

		// Token: 0x06027C7A RID: 162938 RVA: 0x00B23448 File Offset: 0x00B21648
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

		// Token: 0x06027C7B RID: 162939 RVA: 0x00B23498 File Offset: 0x00B21698
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

		// Token: 0x06027C7C RID: 162940 RVA: 0x00B234F0 File Offset: 0x00B216F0
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

		// Token: 0x06027C7D RID: 162941 RVA: 0x00B23592 File Offset: 0x00B21792
		public bool CheckAndGetCurrentClickState()
		{
			return this.CurrentClickState;
		}

		// Token: 0x06027C7E RID: 162942 RVA: 0x00B2359A File Offset: 0x00B2179A
		private void ClearTick()
		{
			if (this.CurrentTick != -1)
			{
				TickSystem.Instance.Remove(this.CurrentTick);
				this.CurrentTick = -1;
			}
		}

		// Token: 0x06027C7F RID: 162943 RVA: 0x00B235C0 File Offset: 0x00B217C0
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

		// Token: 0x06027C80 RID: 162944 RVA: 0x00B23620 File Offset: 0x00B21820
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

		// Token: 0x06027C81 RID: 162945 RVA: 0x00B23654 File Offset: 0x00B21854
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

		// Token: 0x06027C82 RID: 162946 RVA: 0x00B23688 File Offset: 0x00B21888
		public void DoCeaseSequence()
		{
			this.CeaseFailAnimationState = false;
			this.CeaseAnimationPromise = new CustomPromise<bool>();
			this.LevelSequencePlayer.PlayLevelSequenceByName("Cease", false, null, false);
		}

		// Token: 0x06027C83 RID: 162947 RVA: 0x00B236C2 File Offset: 0x00B218C2
		public CustomPromise<bool> GetCeaseAnimationPromise()
		{
			return this.CeaseAnimationPromise;
		}

		// Token: 0x06027C84 RID: 162948 RVA: 0x00B236CC File Offset: 0x00B218CC
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

		// Token: 0x06027C85 RID: 162949 RVA: 0x00B23714 File Offset: 0x00B21914
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

		// Token: 0x06027C86 RID: 162950 RVA: 0x00B23768 File Offset: 0x00B21968
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

		// Token: 0x06027C87 RID: 162951 RVA: 0x00B237EC File Offset: 0x00B219EC
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

		// Token: 0x06027C88 RID: 162952 RVA: 0x00B23864 File Offset: 0x00B21A64
		private bool CheckIsBlockedByOther()
		{
			UUIItem nowHitComponent = LguiEventSystemManager.Instance.GetNowHitComponent();
			return nowHitComponent != null && nowHitComponent != this.DragItem && nowHitComponent != this.DragParent;
		}

		// Token: 0x06027C89 RID: 162953 RVA: 0x00B23896 File Offset: 0x00B21A96
		private bool CheckInClickGap()
		{
			return Info.Instance.IsInGamepad() || TimeUtil.Instance.GetServerTime() - this.LastClickTime > 1.0;
		}

		// Token: 0x06027C8A RID: 162954 RVA: 0x00B238C2 File Offset: 0x00B21AC2
		private bool CheckInClickableTime()
		{
			return this.CurrentRunningTime < 300f && this.CheckInClickGap();
		}

		// Token: 0x06027C8B RID: 162955 RVA: 0x00B238DC File Offset: 0x00B21ADC
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

		// Token: 0x06027C8C RID: 162956 RVA: 0x00B23A74 File Offset: 0x00B21C74
		public bool CheckIfSelfItem(int index)
		{
			return index == this.Index;
		}

		// Token: 0x06027C8D RID: 162957 RVA: 0x00B23A80 File Offset: 0x00B21C80
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

		// Token: 0x06027C8E RID: 162958 RVA: 0x00B23AF0 File Offset: 0x00B21CF0
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

		// Token: 0x06027C8F RID: 162959 RVA: 0x00B23B58 File Offset: 0x00B21D58
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

		// Token: 0x06027C90 RID: 162960 RVA: 0x00B23BC0 File Offset: 0x00B21DC0
		private void OnUnOverlay()
		{
			Action<int> onUnOverlayCallBack = this.OnUnOverlayCallBack;
			if (onUnOverlayCallBack == null)
			{
				return;
			}
			onUnOverlayCallBack(this.GetCurrentIndex());
		}

		// Token: 0x06027C91 RID: 162961 RVA: 0x00B23BD8 File Offset: 0x00B21DD8
		private void OnOverlay()
		{
			Action<int> onOverlayCallBack = this.OnOverlayCallBack;
			if (onOverlayCallBack == null)
			{
				return;
			}
			onOverlayCallBack(this.GetCurrentIndex());
		}

		// Token: 0x06027C92 RID: 162962 RVA: 0x00B23BF0 File Offset: 0x00B21DF0
		[NullableContext(0)]
		public ValueTuple<float, float> GetMiddlePosition()
		{
			return new ValueTuple<float, float>(this.DragComponent.RootUIComp.Get().GetLGUISpaceCenterAbsolutePosition().X, this.DragComponent.RootUIComp.Get().GetLGUISpaceCenterAbsolutePosition().Y);
		}

		// Token: 0x06027C93 RID: 162963 RVA: 0x00B23C3C File Offset: 0x00B21E3C
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

		// Token: 0x06027C94 RID: 162964 RVA: 0x00B23D28 File Offset: 0x00B21F28
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

		// Token: 0x06027C95 RID: 162965 RVA: 0x00B23D90 File Offset: 0x00B21F90
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

		// Token: 0x06027C96 RID: 162966 RVA: 0x00B23DDB File Offset: 0x00B21FDB
		public void SetMovingState(bool state)
		{
			this.MovingState = state;
		}

		// Token: 0x04015AA4 RID: 88740
		private const int CLICKTIME = 300;

		// Token: 0x04015AA5 RID: 88741
		private const int CLICKCALLGAP = 1;

		// Token: 0x04015AA6 RID: 88742
		private const int MOVEPARENTDELAYTIME = 1;

		// Token: 0x04015AA7 RID: 88743
		private const int HEIGHTCANVASSORT = 100;

		// Token: 0x04015AA8 RID: 88744
		public CustomPromise<bool> CeaseAnimationPromise;

		// Token: 0x04015AA9 RID: 88745
		private readonly UUIDraggableComponent DragComponent;

		// Token: 0x04015AAA RID: 88746
		private readonly int Index = -1;

		// Token: 0x04015AAB RID: 88747
		private Action<int> OnPointerDownCallBack;

		// Token: 0x04015AAC RID: 88748
		private Action<int> OnPointerUpCallBack;

		// Token: 0x04015AAD RID: 88749
		private Action<int> OnOverlayCallBack;

		// Token: 0x04015AAE RID: 88750
		private Action<int> OnUnOverlayCallBack;

		// Token: 0x04015AAF RID: 88751
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<int, PhantomBattleData> OnEndDragWhenOnScrollViewCallBack;

		// Token: 0x04015AB0 RID: 88752
		private Action<int> OnMoveToScrollViewCallBack;

		// Token: 0x04015AB1 RID: 88753
		private Action<int> OnRemoveFromScrollViewCallBack;

		// Token: 0x04015AB2 RID: 88754
		private Action<int> ClickFunction;

		// Token: 0x04015AB3 RID: 88755
		private Action<int> ClickFailFunction;

		// Token: 0x04015AB4 RID: 88756
		private Action<int> OnBeginDragFunction;

		// Token: 0x04015AB5 RID: 88757
		private Action<int> OnDragAnimationStartFunction;

		// Token: 0x04015AB6 RID: 88758
		private Action<int> OnDragAnimationEndFunction;

		// Token: 0x04015AB7 RID: 88759
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private Action<VisionCommonDragItem, List<VisionCommonDragItem>, bool> OnDragEndFunction;

		// Token: 0x04015AB8 RID: 88760
		private ULGUIPointerEventData CurrentMoveData;

		// Token: 0x04015AB9 RID: 88761
		private bool CurrentClickState;

		// Token: 0x04015ABA RID: 88762
		private float CurrentRunningTime;

		// Token: 0x04015ABB RID: 88763
		private bool IfDragMove;

		// Token: 0x04015ABC RID: 88764
		private bool PlayDragSequenceState;

		// Token: 0x04015ABD RID: 88765
		private int CurrentTick = -1;

		// Token: 0x04015ABE RID: 88766
		private bool IfBeginDrag;

		// Token: 0x04015ABF RID: 88767
		private int CurrentCheckFingerTick = -1;

		// Token: 0x04015AC0 RID: 88768
		private double LastClickTime;

		// Token: 0x04015AC1 RID: 88769
		[Nullable(1)]
		private readonly Vector StaticBeginVector = Vector.Create();

		// Token: 0x04015AC2 RID: 88770
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<VisionCommonDragItem> CheckList;

		// Token: 0x04015AC3 RID: 88771
		private float SourceWidth;

		// Token: 0x04015AC4 RID: 88772
		private float SourceHeight;

		// Token: 0x04015AC5 RID: 88773
		[Nullable(1)]
		private readonly Vector2D BounceX = new Vector2D(0.0, 0.0);

		// Token: 0x04015AC6 RID: 88774
		[Nullable(1)]
		private readonly Vector2D BounceY = new Vector2D(0.0, 0.0);

		// Token: 0x04015AC7 RID: 88775
		[Nullable(1)]
		private List<VisionCommonDragItem> CurrentStaying = new List<VisionCommonDragItem>();

		// Token: 0x04015AC8 RID: 88776
		private bool CeaseFailAnimationState;

		// Token: 0x04015AC9 RID: 88777
		private bool DragState;

		// Token: 0x04015ACA RID: 88778
		private readonly LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04015ACB RID: 88779
		private int MoveParentDelay;

		// Token: 0x04015ACC RID: 88780
		private PhantomDataBase CurrentData;

		// Token: 0x04015ACD RID: 88781
		private Vector2D StartPosition;

		// Token: 0x04015ACE RID: 88782
		private Vector2D AnimationTargetPosition;

		// Token: 0x04015ACF RID: 88783
		private readonly UUIItem MovingParent;

		// Token: 0x04015AD0 RID: 88784
		private readonly UUIItem NormalParent;

		// Token: 0x04015AD1 RID: 88785
		private readonly FVector2D? StretchVector;

		// Token: 0x04015AD2 RID: 88786
		private readonly UUIItem DragItem;

		// Token: 0x04015AD3 RID: 88787
		private readonly UUIItem DragParent;

		// Token: 0x04015AD4 RID: 88788
		[Nullable(1)]
		private readonly Vector2D ScrollViewBounceX = new Vector2D(0.0, 0.0);

		// Token: 0x04015AD5 RID: 88789
		[Nullable(1)]
		private readonly Vector2D ScrollViewBounceY = new Vector2D(0.0, 0.0);

		// Token: 0x04015AD6 RID: 88790
		private bool IfStayInScrollView;

		// Token: 0x04015AD7 RID: 88791
		[Nullable(1)]
		private readonly Vector2D CurrentAnimationTargetPos = new Vector2D(0.0, 0.0);

		// Token: 0x04015AD8 RID: 88792
		private bool CeaseState;

		// Token: 0x04015AD9 RID: 88793
		[Nullable(1)]
		private readonly Vector2D AnimationStartPos = new Vector2D(0.0, 0.0);

		// Token: 0x04015ADA RID: 88794
		private bool MovingState;

		// Token: 0x04015ADB RID: 88795
		private readonly ULGUICanvas Canvas;

		// Token: 0x04015ADC RID: 88796
		private bool IsTrailRole;
	}
}
