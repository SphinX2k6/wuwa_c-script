using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.TabView.VisionSubView
{
	// Token: 0x02003CA8 RID: 15528
	[NullableContext(2)]
	[Nullable(0)]
	public class VisionDragItem : UiPanelBase
	{
		// Token: 0x06027C99 RID: 162969 RVA: 0x00B23E1C File Offset: 0x00B2201C
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

		// Token: 0x06027C9A RID: 162970 RVA: 0x00B23F54 File Offset: 0x00B22154
		public void Init()
		{
			base.CreateThenShowByActor(this.SourceItem.GetOwner(), null);
		}

		// Token: 0x06027C9B RID: 162971 RVA: 0x00B23F68 File Offset: 0x00B22168
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

		// Token: 0x06027C9C RID: 162972 RVA: 0x00B23F99 File Offset: 0x00B22199
		public void SetDragItemHierarchyMax()
		{
			this.GetDragRoot().SetAsLastHierarchy();
		}

		// Token: 0x06027C9D RID: 162973 RVA: 0x00B23FA6 File Offset: 0x00B221A6
		public UUIItem GetDragRoot()
		{
			return this.DragItem;
		}

		// Token: 0x06027C9E RID: 162974 RVA: 0x00B23FAE File Offset: 0x00B221AE
		[NullableContext(1)]
		public void SetDragCheckItem(List<VisionDragItem> itemList)
		{
			this.CheckList = itemList;
		}

		// Token: 0x06027C9F RID: 162975 RVA: 0x00B23FB7 File Offset: 0x00B221B7
		[NullableContext(1)]
		public void SetDraggingParent(UUIItem item)
		{
			this.DraggingParent = item;
		}

		// Token: 0x06027CA0 RID: 162976 RVA: 0x00B23FC0 File Offset: 0x00B221C0
		[NullableContext(1)]
		public void SetOnDragAnimationStartFunction(Action<int> onFunction)
		{
			this.OnDragAnimationStartFunction = onFunction;
		}

		// Token: 0x06027CA1 RID: 162977 RVA: 0x00B23FC9 File Offset: 0x00B221C9
		[NullableContext(1)]
		public void SetOnDragAnimationEndFunction(Action<int> onFunction)
		{
			this.OnDragAnimationEndFunction = onFunction;
		}

		// Token: 0x06027CA2 RID: 162978 RVA: 0x00B23FD2 File Offset: 0x00B221D2
		[NullableContext(1)]
		public void SetOnClickCallBack(Action<int> onFunction)
		{
			this.ClickFunction = onFunction;
		}

		// Token: 0x06027CA3 RID: 162979 RVA: 0x00B23FDB File Offset: 0x00B221DB
		[NullableContext(1)]
		public void SetOnClickFailCallBack(Action<int> onFunction)
		{
			this.ClickFailFunction = onFunction;
		}

		// Token: 0x06027CA4 RID: 162980 RVA: 0x00B23FE4 File Offset: 0x00B221E4
		[NullableContext(1)]
		public void SetOnBeginDragCall(Action<int> onFunction)
		{
			this.OnBeginDragFunction = onFunction;
		}

		// Token: 0x06027CA5 RID: 162981 RVA: 0x00B23FF0 File Offset: 0x00B221F0
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

		// Token: 0x06027CA6 RID: 162982 RVA: 0x00B24057 File Offset: 0x00B22257
		public bool CheckAndGetCurrentClickState()
		{
			return this.CurrentClickState;
		}

		// Token: 0x06027CA7 RID: 162983 RVA: 0x00B2405F File Offset: 0x00B2225F
		[NullableContext(1)]
		public void SetDragSuccessCallBack(Action<VisionDragItem, List<VisionDragItem>> onFunction)
		{
			this.OnDragEndFunction = onFunction;
		}

		// Token: 0x06027CA8 RID: 162984 RVA: 0x00B24068 File Offset: 0x00B22268
		public Vector2D GetAnimationTargetPos()
		{
			return this.AnimationTargetPosition;
		}

		// Token: 0x06027CA9 RID: 162985 RVA: 0x00B24070 File Offset: 0x00B22270
		public void ClearStayingItem()
		{
			this.CurrentStaying.Clear();
		}

		// Token: 0x06027CAA RID: 162986 RVA: 0x00B2407D File Offset: 0x00B2227D
		[NullableContext(1)]
		public List<VisionDragItem> GetStayingItem()
		{
			return this.CurrentStaying;
		}

		// Token: 0x06027CAB RID: 162987 RVA: 0x00B24088 File Offset: 0x00B22288
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

		// Token: 0x06027CAC RID: 162988 RVA: 0x00B240D4 File Offset: 0x00B222D4
		public void DoCeaseSequence()
		{
			this.CeaseFailAnimationState = false;
			this.CeaseAnimationPromise = new CustomPromise<bool>();
			this.LevelSequencePlayer.PlayLevelSequenceByName("Cease", false, null, false);
		}

		// Token: 0x06027CAD RID: 162989 RVA: 0x00B24110 File Offset: 0x00B22310
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

		// Token: 0x06027CAE RID: 162990 RVA: 0x00B24156 File Offset: 0x00B22356
		public void ResetPositionThenStartDragState()
		{
			this.ResetPosition();
			this.StartDragState();
		}

		// Token: 0x06027CAF RID: 162991 RVA: 0x00B24164 File Offset: 0x00B22364
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

		// Token: 0x06027CB0 RID: 162992 RVA: 0x00B24260 File Offset: 0x00B22460
		public void StartDragState()
		{
			this.DragState = true;
			this.DragComponent.RootUIComp.Get().SetAnchorAlign(UIAnchorHorizontalAlign.Center, UIAnchorVerticalAlign.Middle);
			FVector lguispaceAbsolutePosition = this.DragComponent.RootUIComp.Get().GetLGUISpaceAbsolutePosition();
			this.DragComponent.RootUIComp.Get().SetUIParent(this.DraggingParent, true);
			this.DragComponent.RootUIComp.Get().SetLGUISpaceAbsolutePosition(lguispaceAbsolutePosition);
			this.MoveParentDelay = 0;
		}

		// Token: 0x06027CB1 RID: 162993 RVA: 0x00B242E8 File Offset: 0x00B224E8
		public void SetItemToSourceSize()
		{
			this.DragComponent.RootUIComp.Get().SetWidth(this.SourceWidth);
			this.DragComponent.RootUIComp.Get().SetHeight(this.SourceHeight);
		}

		// Token: 0x06027CB2 RID: 162994 RVA: 0x00B24334 File Offset: 0x00B22534
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

		// Token: 0x06027CB3 RID: 162995 RVA: 0x00B24378 File Offset: 0x00B22578
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

		// Token: 0x06027CB4 RID: 162996 RVA: 0x00B243F8 File Offset: 0x00B225F8
		[NullableContext(1)]
		public void SetPointerDownCallBack(Action<int> dragEvent)
		{
			this.OnPointerDownCallBack = dragEvent;
		}

		// Token: 0x06027CB5 RID: 162997 RVA: 0x00B24404 File Offset: 0x00B22604
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

		// Token: 0x06027CB6 RID: 162998 RVA: 0x00B244BC File Offset: 0x00B226BC
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

		// Token: 0x06027CB7 RID: 162999 RVA: 0x00B244F0 File Offset: 0x00B226F0
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

		// Token: 0x06027CB8 RID: 163000 RVA: 0x00B24574 File Offset: 0x00B22774
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

		// Token: 0x06027CB9 RID: 163001 RVA: 0x00B245A8 File Offset: 0x00B227A8
		public void SetToTargetParentAndSetStretch(UUIItem targetItem)
		{
			this.DragComponent.RootUIComp.Get().SetAnchorAlign(UIAnchorHorizontalAlign.Stretch, UIAnchorVerticalAlign.Stretch);
			this.DragComponent.RootUIComp.Get().SetUIParent(targetItem, true);
			this.DragComponent.RootUIComp.Get().SetVerticalStretch(this.StretchVector.Value);
			this.DragComponent.RootUIComp.Get().SetHorizontalStretch(this.StretchVector.Value);
		}

		// Token: 0x06027CBA RID: 163002 RVA: 0x00B2462F File Offset: 0x00B2282F
		public void SetToNormalParent()
		{
			this.SetToTargetParentAndSetStretch(this.NormalParent);
		}

		// Token: 0x06027CBB RID: 163003 RVA: 0x00B24640 File Offset: 0x00B22840
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

		// Token: 0x06027CBC RID: 163004 RVA: 0x00B246A3 File Offset: 0x00B228A3
		private void EndDragState()
		{
			this.BackDragItemToNormalParent();
		}

		// Token: 0x06027CBD RID: 163005 RVA: 0x00B246AC File Offset: 0x00B228AC
		private void BackDragItemToNormalParent()
		{
			this.DragComponent.RootUIComp.Get().SetAnchorAlign(UIAnchorHorizontalAlign.Stretch, UIAnchorVerticalAlign.Stretch);
			this.DragComponent.RootUIComp.Get().SetUIParent(this.NormalParent, true);
			FVector uiitemScale = new FVector(1f, 1f, 1f);
			this.DragComponent.RootUIComp.Get().SetUIItemScale(uiitemScale);
			this.DragComponent.RootUIComp.Get().SetHorizontalStretch(this.StretchVector.Value);
			this.DragComponent.RootUIComp.Get().SetVerticalStretch(this.StretchVector.Value);
		}

		// Token: 0x06027CBE RID: 163006 RVA: 0x00B24768 File Offset: 0x00B22968
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

		// Token: 0x06027CBF RID: 163007 RVA: 0x00B247CE File Offset: 0x00B229CE
		private bool CheckInClickableTime()
		{
			return this.CurrentRunningTime < 300f && this.CheckInClickGap();
		}

		// Token: 0x06027CC0 RID: 163008 RVA: 0x00B247E5 File Offset: 0x00B229E5
		private bool CheckInClickGap()
		{
			return Info.Instance.IsInGamepad() || TimeUtil.Instance.GetServerTime() - this.LastClickTime > 1.0;
		}

		// Token: 0x06027CC1 RID: 163009 RVA: 0x00B24811 File Offset: 0x00B22A11
		protected void OnBeginDrag()
		{
			this.IfBeginDrag = true;
		}

		// Token: 0x06027CC2 RID: 163010 RVA: 0x00B2481A File Offset: 0x00B22A1A
		private void ClearFingerTick()
		{
			if (this.CurrentCheckFingerTick != -1)
			{
				TickSystem.Instance.Remove(this.CurrentCheckFingerTick);
				this.CurrentCheckFingerTick = -1;
			}
		}

		// Token: 0x06027CC3 RID: 163011 RVA: 0x00B2483D File Offset: 0x00B22A3D
		private void ClearTick()
		{
			if (this.CurrentTick != -1)
			{
				TickSystem.Instance.Remove(this.CurrentTick);
				this.CurrentTick = -1;
			}
		}

		// Token: 0x06027CC4 RID: 163012 RVA: 0x00B24860 File Offset: 0x00B22A60
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

		// Token: 0x06027CC5 RID: 163013 RVA: 0x00B248B4 File Offset: 0x00B22AB4
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

		// Token: 0x06027CC6 RID: 163014 RVA: 0x00B2499D File Offset: 0x00B22B9D
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

		// Token: 0x06027CC7 RID: 163015 RVA: 0x00B249C4 File Offset: 0x00B22BC4
		[NullableContext(0)]
		public ValueTuple<float, float> GetMiddlePosition()
		{
			return new ValueTuple<float, float>(this.DragComponent.RootUIComp.Get().GetLGUISpaceCenterAbsolutePosition().X, this.DragComponent.RootUIComp.Get().GetLGUISpaceCenterAbsolutePosition().Y);
		}

		// Token: 0x06027CC8 RID: 163016 RVA: 0x00B24A10 File Offset: 0x00B22C10
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

		// Token: 0x06027CC9 RID: 163017 RVA: 0x00B24A4C File Offset: 0x00B22C4C
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

		// Token: 0x06027CCA RID: 163018 RVA: 0x00B24B70 File Offset: 0x00B22D70
		public bool CheckIfSelfItem(int index)
		{
			return index == this.Index;
		}

		// Token: 0x06027CCB RID: 163019 RVA: 0x00B24B7B File Offset: 0x00B22D7B
		public int GetCurrentIndex()
		{
			return this.Index;
		}

		// Token: 0x06027CCC RID: 163020 RVA: 0x00B24B83 File Offset: 0x00B22D83
		public void Refresh(PhantomDataBase data)
		{
			this.CurrentData = data;
			this.RefreshIcon(data);
			this.RefreshQuality(data);
		}

		// Token: 0x06027CCD RID: 163021 RVA: 0x00B24B9A File Offset: 0x00B22D9A
		public PhantomDataBase GetCurrentData()
		{
			return this.CurrentData;
		}

		// Token: 0x06027CCE RID: 163022 RVA: 0x00B24BA2 File Offset: 0x00B22DA2
		protected void OnUnOverlay()
		{
			Action onUnOverlayCallBack = this.OnUnOverlayCallBack;
			if (onUnOverlayCallBack == null)
			{
				return;
			}
			onUnOverlayCallBack();
		}

		// Token: 0x06027CCF RID: 163023 RVA: 0x00B24BB4 File Offset: 0x00B22DB4
		protected void OnOverlay()
		{
			Action onOverlayCallBack = this.OnOverlayCallBack;
			if (onOverlayCallBack == null)
			{
				return;
			}
			onOverlayCallBack();
		}

		// Token: 0x06027CD0 RID: 163024 RVA: 0x00B24BC8 File Offset: 0x00B22DC8
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

		// Token: 0x06027CD1 RID: 163025 RVA: 0x00B24C38 File Offset: 0x00B22E38
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

		// Token: 0x06027CD2 RID: 163026 RVA: 0x00B24C87 File Offset: 0x00B22E87
		private void RefreshQuality(PhantomDataBase data)
		{
			this.BgSprite.SetUIActive(data != null);
		}

		// Token: 0x06027CD3 RID: 163027 RVA: 0x00B24C98 File Offset: 0x00B22E98
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

		// Token: 0x06027CD4 RID: 163028 RVA: 0x00B24D00 File Offset: 0x00B22F00
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

		// Token: 0x04015ADD RID: 88797
		private const int CLICKTIME = 300;

		// Token: 0x04015ADE RID: 88798
		private const int CLICKCALLGAP = 1;

		// Token: 0x04015ADF RID: 88799
		private const int MOVEPARENTDELAYTIME = 1;

		// Token: 0x04015AE0 RID: 88800
		public CustomPromise<bool> CeaseAnimationPromise;

		// Token: 0x04015AE1 RID: 88801
		private readonly UUIDraggableComponent DragComponent;

		// Token: 0x04015AE2 RID: 88802
		private readonly UUISprite BgSprite;

		// Token: 0x04015AE3 RID: 88803
		private readonly UUITexture MiddleTexture;

		// Token: 0x04015AE4 RID: 88804
		private readonly int Index = -1;

		// Token: 0x04015AE5 RID: 88805
		private PhantomDataBase CurrentData;

		// Token: 0x04015AE6 RID: 88806
		private Action<int> OnPointerDownCallBack;

		// Token: 0x04015AE7 RID: 88807
		public Action OnOverlayCallBack;

		// Token: 0x04015AE8 RID: 88808
		public Action OnUnOverlayCallBack;

		// Token: 0x04015AE9 RID: 88809
		protected Action<int> ClickFunction;

		// Token: 0x04015AEA RID: 88810
		protected Action<int> ClickFailFunction;

		// Token: 0x04015AEB RID: 88811
		private Action<int> OnBeginDragFunction;

		// Token: 0x04015AEC RID: 88812
		[Nullable(1)]
		private readonly Vector2D BounceX = new Vector2D(0.0, 0.0);

		// Token: 0x04015AED RID: 88813
		[Nullable(1)]
		private readonly Vector2D BounceY = new Vector2D(0.0, 0.0);

		// Token: 0x04015AEE RID: 88814
		private readonly LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04015AEF RID: 88815
		private Vector2D StartPosition;

		// Token: 0x04015AF0 RID: 88816
		private UUIItem DraggingParent;

		// Token: 0x04015AF1 RID: 88817
		private Vector2D AnimationTargetPosition;

		// Token: 0x04015AF2 RID: 88818
		private int CurrentTick = -1;

		// Token: 0x04015AF3 RID: 88819
		private int CurrentCheckFingerTick = -1;

		// Token: 0x04015AF4 RID: 88820
		private ULGUIPointerEventData CurrentMoveData;

		// Token: 0x04015AF5 RID: 88821
		[Nullable(1)]
		private List<VisionDragItem> CurrentStaying = new List<VisionDragItem>();

		// Token: 0x04015AF6 RID: 88822
		private float CurrentRunningTime;

		// Token: 0x04015AF7 RID: 88823
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<VisionDragItem> CheckList;

		// Token: 0x04015AF8 RID: 88824
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private Action<VisionDragItem, List<VisionDragItem>> OnDragEndFunction;

		// Token: 0x04015AF9 RID: 88825
		private Action<int> OnDragAnimationStartFunction;

		// Token: 0x04015AFA RID: 88826
		private Action<int> OnDragAnimationEndFunction;

		// Token: 0x04015AFB RID: 88827
		private readonly UUIItem NormalParent;

		// Token: 0x04015AFC RID: 88828
		[Nullable(1)]
		private readonly Vector StaticBeginVector = Vector.Create();

		// Token: 0x04015AFD RID: 88829
		[Nullable(1)]
		private readonly Vector OnDragStartVector = Vector.Create();

		// Token: 0x04015AFE RID: 88830
		private readonly UUIItem DragItem;

		// Token: 0x04015AFF RID: 88831
		private bool DragState;

		// Token: 0x04015B00 RID: 88832
		private bool IfDragMove;

		// Token: 0x04015B01 RID: 88833
		private bool CurrentClickState;

		// Token: 0x04015B02 RID: 88834
		private double LastClickTime;

		// Token: 0x04015B03 RID: 88835
		private bool PlayDragSequenceState;

		// Token: 0x04015B04 RID: 88836
		private bool CeaseFailAnimationState;

		// Token: 0x04015B05 RID: 88837
		private readonly FVector2D? StretchVector;

		// Token: 0x04015B06 RID: 88838
		private readonly UUIItem SourceItem;

		// Token: 0x04015B07 RID: 88839
		private readonly float SourceWidth;

		// Token: 0x04015B08 RID: 88840
		private readonly float SourceHeight;

		// Token: 0x04015B09 RID: 88841
		private int MoveParentDelay;

		// Token: 0x04015B0A RID: 88842
		private bool IfBeginDrag;
	}
}
