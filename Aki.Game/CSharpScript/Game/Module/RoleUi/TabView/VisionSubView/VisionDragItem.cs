using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.TabView.VisionSubView
{
	// Token: 0x02004CF6 RID: 19702
	[NullableContext(2)]
	[Nullable(0)]
	public class VisionDragItem : UiPanelBase
	{
		// Token: 0x06032EBE RID: 208574 RVA: 0x00BDE514 File Offset: 0x00BDC714
		[NullableContext(1)]
		public VisionDragItem(UUIItem uiItem, UUIDraggableComponent dragComponent, UUISprite bgSprite, UUITexture middleTexture, EPhantomItemIndex index)
		{
			this.DragComponent = dragComponent;
			this.DragItem = (dragComponent.GetOwner().GetComponentByClass(UUIItem.StaticClass()) as UUIItem);
			this.BgSprite = bgSprite;
			this.MiddleTexture = middleTexture;
			this.Index = (int)index;
			this.NormalParent = uiItem;
			this.LevelSequencePlayer = new LevelSequencePlayer(this.DragItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.FinishSequenceEvent), false);
			this.SourceItem = uiItem;
			this.StretchVector = new FVector2D?(Vector2D.Create(0.0, 0.0).ToUeVector2D(false));
			this.SourceWidth = uiItem.Width;
			this.SourceHeight = uiItem.Width;
		}

		// Token: 0x06032EBF RID: 208575 RVA: 0x00BDE64C File Offset: 0x00BDC84C
		public void Init()
		{
			base.CreateThenShowByActor(this.SourceItem.GetOwner(), null);
		}

		// Token: 0x06032EC0 RID: 208576 RVA: 0x00BDE660 File Offset: 0x00BDC860
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

		// Token: 0x06032EC1 RID: 208577 RVA: 0x00BDE691 File Offset: 0x00BDC891
		public void SetDragItemHierarchyMax()
		{
			this.GetDragRoot().SetAsLastHierarchy();
		}

		// Token: 0x06032EC2 RID: 208578 RVA: 0x00BDE69E File Offset: 0x00BDC89E
		public UUIItem GetDragRoot()
		{
			return this.DragItem;
		}

		// Token: 0x06032EC3 RID: 208579 RVA: 0x00BDE6A6 File Offset: 0x00BDC8A6
		[NullableContext(1)]
		public void SetDragCheckItem(List<VisionDragItem> itemList)
		{
			this.CheckList = itemList;
		}

		// Token: 0x06032EC4 RID: 208580 RVA: 0x00BDE6AF File Offset: 0x00BDC8AF
		[NullableContext(1)]
		public void SetDraggingParent(UUIItem item)
		{
			this.DraggingParent = item;
		}

		// Token: 0x06032EC5 RID: 208581 RVA: 0x00BDE6B8 File Offset: 0x00BDC8B8
		[NullableContext(1)]
		public void SetOnDragAnimationStartFunction(Action<int> onFunction)
		{
			this.OnDragAnimationStartFunction = onFunction;
		}

		// Token: 0x06032EC6 RID: 208582 RVA: 0x00BDE6C1 File Offset: 0x00BDC8C1
		[NullableContext(1)]
		public void SetOnDragAnimationEndFunction(Action<int> onFunction)
		{
			this.OnDragAnimationEndFunction = onFunction;
		}

		// Token: 0x06032EC7 RID: 208583 RVA: 0x00BDE6CA File Offset: 0x00BDC8CA
		[NullableContext(1)]
		public void SetOnClickCallBack(Action<int> onFunction)
		{
			this.ClickFunction = onFunction;
		}

		// Token: 0x06032EC8 RID: 208584 RVA: 0x00BDE6D3 File Offset: 0x00BDC8D3
		[NullableContext(1)]
		public void SetOnClickFailCallBack(Action<int> onFunction)
		{
			this.ClickFailFunction = onFunction;
		}

		// Token: 0x06032EC9 RID: 208585 RVA: 0x00BDE6DC File Offset: 0x00BDC8DC
		[NullableContext(1)]
		public void SetOnBeginDragCall(Action<int> onFunction)
		{
			this.OnBeginDragFunction = onFunction;
		}

		// Token: 0x06032ECA RID: 208586 RVA: 0x00BDE6E8 File Offset: 0x00BDC8E8
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

		// Token: 0x06032ECB RID: 208587 RVA: 0x00BDE74F File Offset: 0x00BDC94F
		public bool CheckAndGetCurrentClickState()
		{
			return this.CurrentClickState;
		}

		// Token: 0x06032ECC RID: 208588 RVA: 0x00BDE757 File Offset: 0x00BDC957
		[NullableContext(1)]
		public void SetDragSuccessCallBack(Action<VisionDragItem, List<VisionDragItem>> onFunction)
		{
			this.OnDragEndFunction = onFunction;
		}

		// Token: 0x06032ECD RID: 208589 RVA: 0x00BDE760 File Offset: 0x00BDC960
		public Vector2D GetAnimationTargetPos()
		{
			return this.AnimationTargetPosition;
		}

		// Token: 0x06032ECE RID: 208590 RVA: 0x00BDE768 File Offset: 0x00BDC968
		public void ClearStayingItem()
		{
			this.CurrentStaying.Clear();
		}

		// Token: 0x06032ECF RID: 208591 RVA: 0x00BDE775 File Offset: 0x00BDC975
		[NullableContext(1)]
		public List<VisionDragItem> GetStayingItem()
		{
			return this.CurrentStaying;
		}

		// Token: 0x06032ED0 RID: 208592 RVA: 0x00BDE780 File Offset: 0x00BDC980
		public void DoDragSequence()
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

		// Token: 0x06032ED1 RID: 208593 RVA: 0x00BDE7CC File Offset: 0x00BDC9CC
		public void DoCeaseSequence()
		{
			this.CeaseFailAnimationState = false;
			this.CeaseAnimationPromise = new CustomPromise<bool>();
			this.LevelSequencePlayer.PlayLevelSequenceByName("Cease", false, null, false);
		}

		// Token: 0x06032ED2 RID: 208594 RVA: 0x00BDE808 File Offset: 0x00BDCA08
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

		// Token: 0x06032ED3 RID: 208595 RVA: 0x00BDE84E File Offset: 0x00BDCA4E
		public void ResetPositionThenStartDragState()
		{
			this.ResetPosition();
			this.StartDragState();
		}

		// Token: 0x06032ED4 RID: 208596 RVA: 0x00BDE85C File Offset: 0x00BDCA5C
		public void CacheStartDragPosition()
		{
			this.DragComponent.RootUIComp.Get().SetAnchorAlign(UIAnchorHorizontalAlign.Center, UIAnchorVerticalAlign.Middle);
			FVector lguispaceAbsolutePosition = this.DragComponent.RootUIComp.Get().GetLGUISpaceAbsolutePosition();
			this.DragComponent.RootUIComp.Get().SetUIParent(this.DraggingParent, true);
			this.DragComponent.RootUIComp.Get().SetLGUISpaceAbsolutePosition(lguispaceAbsolutePosition);
			FVector lguispaceAbsolutePosition2 = this.DragComponent.RootUIComp.Get().GetLGUISpaceAbsolutePosition();
			this.StartPosition = new Vector2D((double)lguispaceAbsolutePosition2.X, (double)lguispaceAbsolutePosition2.Y);
			this.AnimationTargetPosition = new Vector2D((double)lguispaceAbsolutePosition.X, (double)lguispaceAbsolutePosition.Y);
			this.BackDragItemToNormalParent();
			FVector uiitemScale = new FVector(1f, 1f, 1f);
			this.DragComponent.RootUIComp.Get().SetUIItemScale(uiitemScale);
		}

		// Token: 0x06032ED5 RID: 208597 RVA: 0x00BDE958 File Offset: 0x00BDCB58
		public void StartDragState()
		{
			this.DragState = true;
			this.DragComponent.RootUIComp.Get().SetAnchorAlign(UIAnchorHorizontalAlign.Center, UIAnchorVerticalAlign.Middle);
			FVector lguispaceAbsolutePosition = this.DragComponent.RootUIComp.Get().GetLGUISpaceAbsolutePosition();
			this.DragComponent.RootUIComp.Get().SetUIParent(this.DraggingParent, true);
			this.DragComponent.RootUIComp.Get().SetLGUISpaceAbsolutePosition(lguispaceAbsolutePosition);
			this.MoveParentDelay = 0;
		}

		// Token: 0x06032ED6 RID: 208598 RVA: 0x00BDE9E0 File Offset: 0x00BDCBE0
		public void SetItemToSourceSize()
		{
			this.DragComponent.RootUIComp.Get().SetWidth(this.SourceWidth);
			this.DragComponent.RootUIComp.Get().SetHeight(this.SourceHeight);
		}

		// Token: 0x06032ED7 RID: 208599 RVA: 0x00BDEA2C File Offset: 0x00BDCC2C
		public void StartClickCheckTimer()
		{
			this.ClearFingerTick();
			Ticker ticker = TickSystem.Instance.Add(delegate(float _)
			{
				if (this.GetCurrentFinger() == 0)
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

		// Token: 0x06032ED8 RID: 208600 RVA: 0x00BDEA70 File Offset: 0x00BDCC70
		public void OnDragBegin(ULGUIPointerEventData eventData)
		{
			if (!PhantomBattleModel.Instance.CheckIfCurrentDragIndex(this.Index))
			{
				return;
			}
			this.OnDragStartVector.X = (double)this.DragComponent.RootUIComp.Get().GetAnchorOffsetX();
			this.OnDragStartVector.Y = (double)this.DragComponent.RootUIComp.Get().GetAnchorOffsetY();
			this.CurrentStaying.Clear();
			this.IfDragMove = true;
			this.OnBeginDrag();
		}

		// Token: 0x06032ED9 RID: 208601 RVA: 0x00BDEAF0 File Offset: 0x00BDCCF0
		[NullableContext(1)]
		public void SetPointerDownCallBack(Action<int> dragEvent)
		{
			this.OnPointerDownCallBack = dragEvent;
		}

		// Token: 0x06032EDA RID: 208602 RVA: 0x00BDEAFC File Offset: 0x00BDCCFC
		public void OnPointerDown(ULGUIPointerEventData eventData)
		{
			if (!PhantomBattleModel.Instance.CheckIfCanDrag())
			{
				return;
			}
			if (PhantomBattleModel.Instance.CheckIfCanDrag())
			{
				PhantomBattleModel.Instance.SetCurrentDragIndex(this.Index);
			}
			this.CurrentClickState = false;
			this.CurrentRunningTime = 0f;
			this.PlayDragSequenceState = false;
			this.IfDragMove = false;
			this.CeaseAnimationPromise = null;
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

		// Token: 0x06032EDB RID: 208603 RVA: 0x00BDEBB4 File Offset: 0x00BDCDB4
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

		// Token: 0x06032EDC RID: 208604 RVA: 0x00BDEBE8 File Offset: 0x00BDCDE8
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

		// Token: 0x06032EDD RID: 208605 RVA: 0x00BDEC6C File Offset: 0x00BDCE6C
		private int GetCurrentFinger()
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

		// Token: 0x06032EDE RID: 208606 RVA: 0x00BDECA0 File Offset: 0x00BDCEA0
		public void SetToTargetParentAndSetStretch(UUIItem targetItem)
		{
			this.DragComponent.RootUIComp.Get().SetAnchorAlign(UIAnchorHorizontalAlign.Stretch, UIAnchorVerticalAlign.Stretch);
			this.DragComponent.RootUIComp.Get().SetUIParent(targetItem, true);
			this.DragComponent.RootUIComp.Get().SetVerticalStretch(this.StretchVector.Value);
			this.DragComponent.RootUIComp.Get().SetHorizontalStretch(this.StretchVector.Value);
		}

		// Token: 0x06032EDF RID: 208607 RVA: 0x00BDED27 File Offset: 0x00BDCF27
		public void SetToNormalParent()
		{
			this.SetToTargetParentAndSetStretch(this.NormalParent);
		}

		// Token: 0x06032EE0 RID: 208608 RVA: 0x00BDED38 File Offset: 0x00BDCF38
		public void ResetPosition()
		{
			if (this.CeaseFailAnimationState)
			{
				this.TryDoCeaseFailSequence();
			}
			this.CeaseFailAnimationState = false;
			if (!this.DragState)
			{
				return;
			}
			this.EndDragState();
			if (this.StartPosition != null)
			{
				this.DragComponent.RootUIComp.Get().SetAnchorOffset(this.StretchVector.Value);
			}
			this.DragState = false;
		}

		// Token: 0x06032EE1 RID: 208609 RVA: 0x00BDED9B File Offset: 0x00BDCF9B
		private void EndDragState()
		{
			this.BackDragItemToNormalParent();
		}

		// Token: 0x06032EE2 RID: 208610 RVA: 0x00BDEDA4 File Offset: 0x00BDCFA4
		private void BackDragItemToNormalParent()
		{
			this.DragComponent.RootUIComp.Get().SetAnchorAlign(UIAnchorHorizontalAlign.Stretch, UIAnchorVerticalAlign.Stretch);
			this.DragComponent.RootUIComp.Get().SetUIParent(this.NormalParent, true);
			FVector uiitemScale = new FVector(1f, 1f, 1f);
			this.DragComponent.RootUIComp.Get().SetUIItemScale(uiitemScale);
			this.DragComponent.RootUIComp.Get().SetHorizontalStretch(this.StretchVector.Value);
			this.DragComponent.RootUIComp.Get().SetVerticalStretch(this.StretchVector.Value);
		}

		// Token: 0x06032EE3 RID: 208611 RVA: 0x00BDEE60 File Offset: 0x00BDD060
		public void OnPointUp(ULGUIPointerEventData eventData)
		{
			this.ClearTick();
			this.ClearFingerTick();
			if (!PhantomBattleModel.Instance.CheckIfCurrentDragIndex(this.Index))
			{
				return;
			}
			PhantomBattleModel.Instance.ClearCurrentDragIndex();
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
		}

		// Token: 0x06032EE4 RID: 208612 RVA: 0x00BDEEC6 File Offset: 0x00BDD0C6
		private bool CheckInClickableTime()
		{
			return this.CurrentRunningTime < 300f && this.CheckInClickGap();
		}

		// Token: 0x06032EE5 RID: 208613 RVA: 0x00BDEEDD File Offset: 0x00BDD0DD
		private bool CheckInClickGap()
		{
			return Info.Instance.IsInGamepad() || TimeUtil.Instance.GetServerTime() - this.LastClickTime > 1.0;
		}

		// Token: 0x06032EE6 RID: 208614 RVA: 0x00BDEF09 File Offset: 0x00BDD109
		protected void OnBeginDrag()
		{
			this.IfBeginDrag = true;
		}

		// Token: 0x06032EE7 RID: 208615 RVA: 0x00BDEF12 File Offset: 0x00BDD112
		private void ClearFingerTick()
		{
			if (this.CurrentCheckFingerTick != -1)
			{
				TickSystem.Instance.Remove(this.CurrentCheckFingerTick);
				this.CurrentCheckFingerTick = -1;
			}
		}

		// Token: 0x06032EE8 RID: 208616 RVA: 0x00BDEF35 File Offset: 0x00BDD135
		private void ClearTick()
		{
			if (this.CurrentTick != -1)
			{
				TickSystem.Instance.Remove(this.CurrentTick);
				this.CurrentTick = -1;
			}
		}

		// Token: 0x06032EE9 RID: 208617 RVA: 0x00BDEF58 File Offset: 0x00BDD158
		public void OnDragEnd(ULGUIPointerEventData eventData)
		{
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
				else
				{
					Action<VisionDragItem, List<VisionDragItem>> onDragEndFunction = this.OnDragEndFunction;
					if (onDragEndFunction != null)
					{
						onDragEndFunction(this, this.CurrentStaying);
					}
				}
				this.IfDragMove = false;
			}
		}

		// Token: 0x06032EEA RID: 208618 RVA: 0x00BDEFAC File Offset: 0x00BDD1AC
		public void SetItemToPointerPosition()
		{
			if (!this.DragState)
			{
				return;
			}
			FVector worldPointInPlane = LguiEventSystemManager.Instance.GetPointerEventData(0, false).GetWorldPointInPlane();
			float num = PhantomBattleConfig.Instance.GetVisionScrollerOffsetX() * (float)PhantomBattleConfig.Instance.GetVisionScrollerOffsetXDir();
			float num2 = PhantomBattleConfig.Instance.GetVisionScrollerOffsetY() * (float)PhantomBattleConfig.Instance.GetVisionScrollerOffsetYDir();
			float num3 = worldPointInPlane.X + num;
			float num4 = worldPointInPlane.Z + num2;
			if (this.StaticBeginVector.X == (double)num3 && this.StaticBeginVector.Y == (double)num4)
			{
				return;
			}
			this.StaticBeginVector.X = (double)num3;
			this.StaticBeginVector.Y = (double)num4;
			this.DragComponent.RootUIComp.Get().SetAnchorOffsetX((float)this.StaticBeginVector.X);
			this.DragComponent.RootUIComp.Get().SetAnchorOffsetY((float)this.StaticBeginVector.Y);
		}

		// Token: 0x06032EEB RID: 208619 RVA: 0x00BDF095 File Offset: 0x00BDD295
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

		// Token: 0x06032EEC RID: 208620 RVA: 0x00BDF0BC File Offset: 0x00BDD2BC
		[NullableContext(0)]
		public ValueTuple<float, float> GetMiddlePosition()
		{
			return new ValueTuple<float, float>(this.DragComponent.RootUIComp.Get().GetLGUISpaceCenterAbsolutePosition().X, this.DragComponent.RootUIComp.Get().GetLGUISpaceCenterAbsolutePosition().Y);
		}

		// Token: 0x06032EED RID: 208621 RVA: 0x00BDF108 File Offset: 0x00BDD308
		private void OnDrag(ULGUIPointerEventData eventData)
		{
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

		// Token: 0x06032EEE RID: 208622 RVA: 0x00BDF144 File Offset: 0x00BDD344
		private void CheckOnDrag()
		{
			List<VisionDragItem> list = new List<VisionDragItem>();
			if (this.CheckList != null)
			{
				foreach (VisionDragItem visionDragItem in this.CheckList)
				{
					if (!visionDragItem.CheckIfSelfItem(this.Index) && visionDragItem.CheckOverlap(this.GetBounceX(), this.GetBounceY()))
					{
						list.Add(visionDragItem);
					}
				}
			}
			foreach (VisionDragItem visionDragItem2 in this.CurrentStaying)
			{
				if (!list.Contains(visionDragItem2))
				{
					visionDragItem2.OnUnOverlay();
				}
			}
			foreach (VisionDragItem visionDragItem3 in list)
			{
				if (!this.CurrentStaying.Contains(visionDragItem3))
				{
					visionDragItem3.OnOverlay();
				}
			}
			this.CurrentStaying = list;
		}

		// Token: 0x06032EEF RID: 208623 RVA: 0x00BDF268 File Offset: 0x00BDD468
		public bool CheckIfSelfItem(int index)
		{
			return index == this.Index;
		}

		// Token: 0x06032EF0 RID: 208624 RVA: 0x00BDF273 File Offset: 0x00BDD473
		public int GetCurrentIndex()
		{
			return this.Index;
		}

		// Token: 0x06032EF1 RID: 208625 RVA: 0x00BDF27B File Offset: 0x00BDD47B
		public void Refresh(PhantomDataBase data)
		{
			this.CurrentData = data;
			this.RefreshIcon(data);
			this.RefreshQuality(data);
		}

		// Token: 0x06032EF2 RID: 208626 RVA: 0x00BDF292 File Offset: 0x00BDD492
		public PhantomDataBase GetCurrentData()
		{
			return this.CurrentData;
		}

		// Token: 0x06032EF3 RID: 208627 RVA: 0x00BDF29A File Offset: 0x00BDD49A
		protected void OnUnOverlay()
		{
			Action onUnOverlayCallBack = this.OnUnOverlayCallBack;
			if (onUnOverlayCallBack == null)
			{
				return;
			}
			onUnOverlayCallBack();
		}

		// Token: 0x06032EF4 RID: 208628 RVA: 0x00BDF2AC File Offset: 0x00BDD4AC
		protected void OnOverlay()
		{
			Action onOverlayCallBack = this.OnOverlayCallBack;
			if (onOverlayCallBack == null)
			{
				return;
			}
			onOverlayCallBack();
		}

		// Token: 0x06032EF5 RID: 208629 RVA: 0x00BDF2C0 File Offset: 0x00BDD4C0
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

		// Token: 0x06032EF6 RID: 208630 RVA: 0x00BDF330 File Offset: 0x00BDD530
		private void RefreshIcon(PhantomDataBase data)
		{
			this.MiddleTexture.SetUIActive(data != null);
			if (data == null)
			{
				return;
			}
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(data.GetConfigId(true));
			base.SetTextureByPath(itemConfigData.IconMiddle, this.MiddleTexture, new EUiViewName?(EUiViewName.VisionEquipmentView), null);
		}

		// Token: 0x06032EF7 RID: 208631 RVA: 0x00BDF37F File Offset: 0x00BDD57F
		private void RefreshQuality(PhantomDataBase data)
		{
			this.BgSprite.SetUIActive(data != null);
		}

		// Token: 0x06032EF8 RID: 208632 RVA: 0x00BDF390 File Offset: 0x00BDD590
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

		// Token: 0x06032EF9 RID: 208633 RVA: 0x00BDF3F8 File Offset: 0x00BDD5F8
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

		// Token: 0x0401B158 RID: 110936
		private const int CLICKTIME = 300;

		// Token: 0x0401B159 RID: 110937
		private const int CLICKCALLGAP = 1;

		// Token: 0x0401B15A RID: 110938
		private const int MOVEPARENTDELAYTIME = 1;

		// Token: 0x0401B15B RID: 110939
		public CustomPromise<bool> CeaseAnimationPromise;

		// Token: 0x0401B15C RID: 110940
		private readonly UUIDraggableComponent DragComponent;

		// Token: 0x0401B15D RID: 110941
		private readonly UUISprite BgSprite;

		// Token: 0x0401B15E RID: 110942
		private readonly UUITexture MiddleTexture;

		// Token: 0x0401B15F RID: 110943
		private readonly int Index = -1;

		// Token: 0x0401B160 RID: 110944
		private PhantomDataBase CurrentData;

		// Token: 0x0401B161 RID: 110945
		private Action<int> OnPointerDownCallBack;

		// Token: 0x0401B162 RID: 110946
		public Action OnOverlayCallBack;

		// Token: 0x0401B163 RID: 110947
		public Action OnUnOverlayCallBack;

		// Token: 0x0401B164 RID: 110948
		protected Action<int> ClickFunction;

		// Token: 0x0401B165 RID: 110949
		protected Action<int> ClickFailFunction;

		// Token: 0x0401B166 RID: 110950
		private Action<int> OnBeginDragFunction;

		// Token: 0x0401B167 RID: 110951
		[Nullable(1)]
		private readonly Vector2D BounceX = new Vector2D(0.0, 0.0);

		// Token: 0x0401B168 RID: 110952
		[Nullable(1)]
		private readonly Vector2D BounceY = new Vector2D(0.0, 0.0);

		// Token: 0x0401B169 RID: 110953
		private readonly LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401B16A RID: 110954
		private Vector2D StartPosition;

		// Token: 0x0401B16B RID: 110955
		private UUIItem DraggingParent;

		// Token: 0x0401B16C RID: 110956
		private Vector2D AnimationTargetPosition;

		// Token: 0x0401B16D RID: 110957
		private int CurrentTick = -1;

		// Token: 0x0401B16E RID: 110958
		private int CurrentCheckFingerTick = -1;

		// Token: 0x0401B16F RID: 110959
		private ULGUIPointerEventData CurrentMoveData;

		// Token: 0x0401B170 RID: 110960
		[Nullable(1)]
		private List<VisionDragItem> CurrentStaying = new List<VisionDragItem>();

		// Token: 0x0401B171 RID: 110961
		private float CurrentRunningTime;

		// Token: 0x0401B172 RID: 110962
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<VisionDragItem> CheckList;

		// Token: 0x0401B173 RID: 110963
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private Action<VisionDragItem, List<VisionDragItem>> OnDragEndFunction;

		// Token: 0x0401B174 RID: 110964
		private Action<int> OnDragAnimationStartFunction;

		// Token: 0x0401B175 RID: 110965
		private Action<int> OnDragAnimationEndFunction;

		// Token: 0x0401B176 RID: 110966
		private readonly UUIItem NormalParent;

		// Token: 0x0401B177 RID: 110967
		[Nullable(1)]
		private readonly Vector StaticBeginVector = Vector.Create();

		// Token: 0x0401B178 RID: 110968
		[Nullable(1)]
		private readonly Vector OnDragStartVector = Vector.Create();

		// Token: 0x0401B179 RID: 110969
		private readonly UUIItem DragItem;

		// Token: 0x0401B17A RID: 110970
		private bool DragState;

		// Token: 0x0401B17B RID: 110971
		private bool IfDragMove;

		// Token: 0x0401B17C RID: 110972
		private bool CurrentClickState;

		// Token: 0x0401B17D RID: 110973
		private double LastClickTime;

		// Token: 0x0401B17E RID: 110974
		private bool PlayDragSequenceState;

		// Token: 0x0401B17F RID: 110975
		private bool CeaseFailAnimationState;

		// Token: 0x0401B180 RID: 110976
		private readonly FVector2D? StretchVector;

		// Token: 0x0401B181 RID: 110977
		private readonly UUIItem SourceItem;

		// Token: 0x0401B182 RID: 110978
		private readonly float SourceWidth;

		// Token: 0x0401B183 RID: 110979
		private readonly float SourceHeight;

		// Token: 0x0401B184 RID: 110980
		private int MoveParentDelay;

		// Token: 0x0401B185 RID: 110981
		private bool IfBeginDrag;
	}
}
