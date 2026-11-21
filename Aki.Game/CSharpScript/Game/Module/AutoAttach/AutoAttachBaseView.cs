using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.AutoAttach
{
	// Token: 0x02004E64 RID: 20068
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class AutoAttachBaseView<T, [Nullable(0)] TAttachItem> : IAutoAttachBaseView<T> where TAttachItem : AutoAttachItem<T>
	{
		// Token: 0x06032808 RID: 206856 RVA: 0x00E2A9BC File Offset: 0x00E28BBC
		[NullableContext(1)]
		public AutoAttachBaseView(AActor controllerActor, bool isNeedScrollCallback = false)
		{
			this.ControllerActor = controllerActor;
			this.ControllerItem = (controllerActor.GetComponentByClass(UUIItem.StaticClass()) as UUIItem);
			UUIItem controllerItem = this.ControllerItem;
			this.ControllerHeight = ((controllerItem != null) ? controllerItem.Height : 0f);
			UUIItem controllerItem2 = this.ControllerItem;
			this.ControllerWidth = ((controllerItem2 != null) ? controllerItem2.Width : 0f);
			this.CurrentMoveOffsetMap[EMoveType.Velocity] = 0f;
			this.CurrentMoveOffsetMap[EMoveType.Inertia] = 0f;
			Ticker ticker = TickSystem.Instance.Add(new Action<float>(this.Tick), "AutoAttachBaseView", ETickingGroup.TG_PrePhysics, true, 0, true);
			this.TickId = ((ticker != null) ? ticker.Id : -1);
			this.VelocityCurve = ResourceSystem.Instance.GetLoadedAsset<UCurveFloat>("/Game/Aki/UI/UIResources/Common/LevelSequence/Curve/VelocityCurve.VelocityCurve");
			this.InertiaCurve = ResourceSystem.Instance.GetLoadedAsset<UCurveFloat>("/Game/Aki/UI/UIResources/Common/LevelSequence/Curve/InertiaCurve.InertiaCurve");
			this.BoundaryCurve = ResourceSystem.Instance.GetLoadedAsset<UCurveFloat>("/Game/Aki/UI/UIResources/Common/LevelSequence/Curve/BoundaryCurve.BoundaryCurve");
			this.FullVelocityTime = CommonConfig.Instance.GetAutoAttachVelocityTime().GetValueOrDefault();
			this.FullInertiaTime = CommonConfig.Instance.GetAutoAttachInertiaTime().GetValueOrDefault();
			this.IsMoving = false;
			UUIItem controllerItem3 = this.ControllerItem;
			AUIBaseActor auibaseActor = ((controllerItem3 != null) ? controllerItem3.GetOwner() : null) as AUIBaseActor;
			if (auibaseActor != null)
			{
				auibaseActor.OnPreDestroyed.Add(new Action<AActor>(this.OnActorDestroy));
			}
			this.IsNeedScrollCallback = isNeedScrollCallback;
		}

		// Token: 0x06032809 RID: 206857 RVA: 0x00E2AB92 File Offset: 0x00E28D92
		private void OnActorDestroy(AActor actor)
		{
			this.Clear();
		}

		// Token: 0x0603280A RID: 206858 RVA: 0x00E2AB9A File Offset: 0x00E28D9A
		public virtual float GetTrueBoundary()
		{
			return 0f;
		}

		// Token: 0x0603280B RID: 206859 RVA: 0x00E2ABA1 File Offset: 0x00E28DA1
		public void SetItemSelectMode(EAttachMode mode)
		{
			this.SelectItemModel = mode;
		}

		// Token: 0x0603280C RID: 206860 RVA: 0x00E2ABAA File Offset: 0x00E28DAA
		public void SetPageLimitState(bool state)
		{
			this.PageLimitState = state;
		}

		// Token: 0x0603280D RID: 206861 RVA: 0x00E2ABB3 File Offset: 0x00E28DB3
		public void SetMoveMultiFactor(float value)
		{
			this.MoveMultiFactor = value;
		}

		// Token: 0x0603280E RID: 206862 RVA: 0x00E2ABBC File Offset: 0x00E28DBC
		[NullableContext(1)]
		public void SetDragBeginCallback(Action callback)
		{
			this.DragBegin = callback;
		}

		// Token: 0x0603280F RID: 206863 RVA: 0x00E2ABC5 File Offset: 0x00E28DC5
		[NullableContext(1)]
		public void SetMoveItemsCallback(Action callback)
		{
			this.MoveItemsCallback = callback;
		}

		// Token: 0x06032810 RID: 206864 RVA: 0x00E2ABCE File Offset: 0x00E28DCE
		[NullableContext(1)]
		public void SetAudioEvent(string eventName)
		{
			this.AudioEvent = eventName;
		}

		// Token: 0x06032811 RID: 206865 RVA: 0x00E2ABD7 File Offset: 0x00E28DD7
		public bool IsVelocityMoveState()
		{
			return this.VelocityMoveState;
		}

		// Token: 0x06032812 RID: 206866 RVA: 0x00E2ABE0 File Offset: 0x00E28DE0
		[NullableContext(1)]
		public void CreateItems(AActor itemActor, float initGap, Func<AActor, int, int, TAttachItem> createFunction, EAttachDirection direction = EAttachDirection.Horizontal)
		{
			this.EnableDragEvent();
			this.CreateItemFunction = createFunction;
			this.SourceActor = itemActor;
			this.SourceItem = (this.SourceActor.GetComponentByClass(UUIItem.StaticClass()) as UUIItem);
			this.Gap = initGap;
			this.AttachDirection = new EAttachDirection?(direction);
			this.SourceItemHeight = this.SourceItem.Height;
			this.SourceItemWidth = this.SourceItem.Width;
			this.ShowItemNum = this.GetCurrentShowNum();
			this.MinusVelocityMoveDistance = this.GetItemGapSize() / 2f;
			this.InitDefaultMoveBoundary();
		}

		// Token: 0x06032813 RID: 206867 RVA: 0x00E2AC7B File Offset: 0x00E28E7B
		public void SetMoveBoundary(float distance)
		{
			this.MoveBoundary = distance;
		}

		// Token: 0x06032814 RID: 206868 RVA: 0x00E2AC84 File Offset: 0x00E28E84
		public EAttachDirection? GetCurrentMoveDirection()
		{
			return this.AttachDirection;
		}

		// Token: 0x06032815 RID: 206869 RVA: 0x00E2AC8C File Offset: 0x00E28E8C
		private void InitDefaultMoveBoundary()
		{
			this.MoveBoundary = this.GetItemSize();
		}

		// Token: 0x06032816 RID: 206870 RVA: 0x00E2AC9A File Offset: 0x00E28E9A
		public void SetBoundDistance(float size)
		{
			this.MoveBoundary = size;
		}

		// Token: 0x06032817 RID: 206871 RVA: 0x00E2ACA3 File Offset: 0x00E28EA3
		protected float GetItemGapSize()
		{
			return this.GetItemSize() + this.Gap;
		}

		// Token: 0x06032818 RID: 206872 RVA: 0x00E2ACB4 File Offset: 0x00E28EB4
		private int GetCurrentShowNum()
		{
			EAttachDirection? attachDirection = this.AttachDirection;
			EAttachDirection eattachDirection = EAttachDirection.Horizontal;
			float num;
			if (attachDirection.GetValueOrDefault() == eattachDirection & attachDirection != null)
			{
				num = this.ControllerWidth;
			}
			else
			{
				num = this.ControllerHeight;
			}
			float itemGapSize = this.GetItemGapSize();
			int num2 = (int)Math.Ceiling((double)(num / itemGapSize));
			if (num2 % 2 != 0)
			{
				return num2;
			}
			return num2 - 1;
		}

		// Token: 0x06032819 RID: 206873 RVA: 0x00E2AD14 File Offset: 0x00E28F14
		public void EnableDragEvent()
		{
			if (this.ControllerActor != null)
			{
				UUIDraggableComponent uuidraggableComponent = this.ControllerActor.GetComponentByClass(UUIDraggableComponent.StaticClass()) as UUIDraggableComponent;
				if (uuidraggableComponent != null)
				{
					uuidraggableComponent.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerBeginDrag));
					uuidraggableComponent.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDragCallback));
					uuidraggableComponent.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDragEnd));
					uuidraggableComponent.NavigateToPrevDelegate.Bind(new Action(this.NavigateToPrev));
					uuidraggableComponent.NavigateToNextDelegate.Bind(new Action(this.NavigateToNext));
					if (this.IsNeedScrollCallback)
					{
						uuidraggableComponent.OnPointerScrollCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerScrollCallBack));
					}
				}
			}
		}

		// Token: 0x0603281A RID: 206874 RVA: 0x00E2ADE0 File Offset: 0x00E28FE0
		public void DisableDragEvent()
		{
			if (this.ControllerActor != null)
			{
				UUIDraggableComponent uuidraggableComponent = this.ControllerActor.GetComponentByClass(UUIDraggableComponent.StaticClass()) as UUIDraggableComponent;
				if (uuidraggableComponent != null)
				{
					uuidraggableComponent.OnPointerBeginDragCallBack.Unbind();
					uuidraggableComponent.OnPointerDragCallBack.Unbind();
					uuidraggableComponent.OnPointerEndDragCallBack.Unbind();
					uuidraggableComponent.NavigateToPrevDelegate.Unbind();
					uuidraggableComponent.NavigateToNextDelegate.Unbind();
				}
			}
		}

		// Token: 0x0603281B RID: 206875 RVA: 0x00E2AE4A File Offset: 0x00E2904A
		public float GetGap()
		{
			return this.Gap;
		}

		// Token: 0x0603281C RID: 206876 RVA: 0x00E2AE54 File Offset: 0x00E29054
		public float GetItemSize()
		{
			EAttachDirection? attachDirection = this.AttachDirection;
			EAttachDirection eattachDirection = EAttachDirection.Horizontal;
			float result;
			if (attachDirection.GetValueOrDefault() == eattachDirection & attachDirection != null)
			{
				result = this.SourceItemWidth;
			}
			else
			{
				result = this.SourceItemHeight;
			}
			return result;
		}

		// Token: 0x0603281D RID: 206877 RVA: 0x00E2AE98 File Offset: 0x00E29098
		public float GetViewSize()
		{
			EAttachDirection? attachDirection = this.AttachDirection;
			EAttachDirection eattachDirection = EAttachDirection.Horizontal;
			float result;
			if (attachDirection.GetValueOrDefault() == eattachDirection & attachDirection != null)
			{
				result = this.ControllerWidth;
			}
			else
			{
				result = this.ControllerHeight;
			}
			return result;
		}

		// Token: 0x0603281E RID: 206878 RVA: 0x00E2AEDC File Offset: 0x00E290DC
		protected void Tick(float delta)
		{
			USequencerManager sequencerManager = ALGUIManagerActor.GetSequencerManager(GlobalData.World);
			float num = (sequencerManager != null) ? sequencerManager.GetGlobalPlayRate() : 1f;
			float deltaTime = delta * num;
			if (this.ForceToItemIndex != null)
			{
				this.MoveToShowIndexForce(this.ForceToItemIndex.Value);
				this.ForceToItemIndex = null;
			}
			if (this.ForceSelectItemCache != null)
			{
				this.MoveToItemForce(this.ForceSelectItemCache);
				this.ForceSelectItemCache = default(TAttachItem);
			}
			if (this.NeedDelayApplyCachePointerDragData)
			{
				this.OnPointerDragDelay++;
				if (this.OnPointerDragDelay >= 1)
				{
					this.NeedDelayApplyCachePointerDragData = false;
					this.ApplyCachePointerDragData(this.OnPointerDragCacheData);
				}
			}
			if (!this.DragState && (this.InertiaState || this.VelocityMoveState))
			{
				if (this.VelocityMoveState)
				{
					this.DoVelocityMove(deltaTime);
				}
				else if (this.CurrentRunningElasticTime < this.FullInertiaTime)
				{
					this.DoElasticMove(deltaTime);
				}
				else
				{
					this.CheckInertiaSelectState = true;
					this.InertiaState = false;
				}
			}
			else
			{
				if (this.CheckInertiaSelectState)
				{
					this.CheckInertiaSelectState = false;
					this.CurrentRunningElasticTime = 0f;
					if (!this.CurrentSelectState && this.SelectItemModel == EAttachMode.EndMove)
					{
						int count = this.Items.Count;
						for (int i = 0; i < count; i++)
						{
							TAttachItem tattachItem = this.Items[i];
							if (tattachItem.GetCurrentShowItemIndex() == this.CurrentSelectItemIndex && !tattachItem.GetSelectedState())
							{
								tattachItem.Select();
								this.CurrentSelectState = true;
							}
						}
					}
				}
				this.VelocityMoveState = false;
			}
			if (this.IsMoving != this.MovingState())
			{
				this.IsMoving = this.MovingState();
				if (this.IsMoving)
				{
					Action dragBegin = this.DragBegin;
					if (dragBegin == null)
					{
						return;
					}
					dragBegin();
				}
			}
		}

		// Token: 0x0603281F RID: 206879 RVA: 0x00E2B0AC File Offset: 0x00E292AC
		private void DoVelocityMove(float deltaTime)
		{
			float value = this.GetMoveTypeOffset(EMoveType.Velocity).Value;
			float num = value / this.FullVelocityTime;
			this.CurrentVelocityRunningTime += deltaTime;
			float num2 = this.CurrentVelocityRunningTime / this.FullVelocityTime;
			num2 = ((num2 > 1f) ? 1f : num2);
			float offset = num * this.GetCurveValue(this.VelocityCurve, num2) * deltaTime;
			float num3 = this.RecalculateMoveOffset(offset);
			if (Math.Abs(num3) < 0.01f)
			{
				num3 = 0f;
			}
			if (Math.Abs(this.CurrentVelocityMoveDelta + num3) > Math.Abs(value))
			{
				num3 = value - this.CurrentVelocityMoveDelta;
			}
			this.MoveItems(num3, false);
			this.CurrentVelocityMoveDelta += num3;
			if (this.VelocityDirection > 0f)
			{
				if (num3 <= 0f)
				{
					this.EndVelocityMove();
				}
			}
			else if (this.VelocityDirection < 0f && num3 >= 0f)
			{
				this.EndVelocityMove();
			}
			if (num2 >= 1f)
			{
				if (Math.Abs(this.CurrentVelocityMoveDelta) < Math.Abs(value))
				{
					this.CurrentVelocityRunningTime -= deltaTime;
					return;
				}
				this.EndVelocityMove();
			}
		}

		// Token: 0x06032820 RID: 206880 RVA: 0x00E2B1C8 File Offset: 0x00E293C8
		private void DoElasticMove(float deltaTime)
		{
			float value = this.GetMoveTypeOffset(EMoveType.Inertia).Value;
			float num = value / this.FullInertiaTime;
			this.CurrentRunningElasticTime += deltaTime;
			float num2 = this.CurrentRunningElasticTime / this.FullInertiaTime;
			num2 = ((num2 > 1f) ? 1f : num2);
			float num3 = num * this.GetCurveValue(this.InertiaCurve, num2) * deltaTime;
			if (Math.Abs(this.CurrentElasticMoveDelta + num3) > Math.Abs(value))
			{
				num3 = value - this.CurrentElasticMoveDelta;
			}
			this.MoveItems(num3, false);
			this.CurrentElasticMoveDelta += num3;
			if (num2 >= 1f && Math.Abs(this.CurrentElasticMoveDelta) < Math.Abs(value))
			{
				this.CurrentRunningElasticTime -= deltaTime;
			}
		}

		// Token: 0x06032821 RID: 206881 RVA: 0x00E2B288 File Offset: 0x00E29488
		[NullableContext(1)]
		protected float GetCurveValue(UCurveFloat curve, float progress)
		{
			return curve.GetFloatValue(progress);
		}

		// Token: 0x06032822 RID: 206882 RVA: 0x00E2B294 File Offset: 0x00E29494
		private void EndVelocityMove()
		{
			this.VelocityMoveState = false;
			this.InertiaState = false;
			TAttachItem item = this.FindAutoAttachItem();
			this.ScrollToItem(item, false);
		}

		// Token: 0x06032823 RID: 206883 RVA: 0x00E2B2BE File Offset: 0x00E294BE
		[NullableContext(1)]
		public void ReloadView(int showItemNum, T[] data, int attachTo = 0)
		{
			this.DataLength = showItemNum;
			this.ReloadItems(showItemNum, data, attachTo);
		}

		// Token: 0x06032824 RID: 206884 RVA: 0x00E2B2D0 File Offset: 0x00E294D0
		public int GetShowItemNum()
		{
			return this.ShowItemNum;
		}

		// Token: 0x06032825 RID: 206885 RVA: 0x00E2B2D8 File Offset: 0x00E294D8
		public int GetDataLength()
		{
			return this.DataLength;
		}

		// Token: 0x06032826 RID: 206886 RVA: 0x00E2B2E0 File Offset: 0x00E294E0
		public void RefreshItems()
		{
			int count = this.Items.Count;
			for (int i = 0; i < count; i++)
			{
				this.Items[i].RefreshItem();
			}
		}

		// Token: 0x06032827 RID: 206887 RVA: 0x00E2B31C File Offset: 0x00E2951C
		public TAttachItem FindNearestMiddleItem()
		{
			if (this.Items.Count == 0)
			{
				Log.Instance.Error(ELogModule.UiCommon, ELogAuthor.YZY, "列表没有数据，找不到中间物体", default(ReadOnlySpan<ValueTuple<string, object>>));
				return default(TAttachItem);
			}
			TAttachItem result = this.Items[0];
			float num = Math.Abs(this.Items[0].GetCurrentPosition());
			int count = this.Items.Count;
			for (int i = 0; i < count; i++)
			{
				float num2 = Math.Abs(this.Items[i].GetCurrentPosition());
				if (num2 < num)
				{
					result = this.Items[i];
					num = num2;
				}
			}
			return result;
		}

		// Token: 0x06032828 RID: 206888 RVA: 0x00E2B3E4 File Offset: 0x00E295E4
		[NullableContext(1)]
		public List<TAttachItem> GetItems()
		{
			return this.Items;
		}

		// Token: 0x06032829 RID: 206889 RVA: 0x00E2B3EC File Offset: 0x00E295EC
		protected TAttachItem GetShowIndexItem(int showIndex)
		{
			TAttachItem result = default(TAttachItem);
			int count = this.Items.Count;
			for (int i = 0; i < count; i++)
			{
				if (this.Items[i].GetCurrentShowItemIndex() == showIndex)
				{
					result = this.Items[i];
					break;
				}
			}
			return result;
		}

		// Token: 0x0603282A RID: 206890 RVA: 0x00E2B444 File Offset: 0x00E29644
		public TAttachItem GetItemByShowIndex(int showItemIndex)
		{
			foreach (TAttachItem tattachItem in this.Items)
			{
				if (tattachItem.GetCurrentShowItemIndex() == showItemIndex)
				{
					return tattachItem;
				}
			}
			return default(TAttachItem);
		}

		// Token: 0x0603282B RID: 206891 RVA: 0x00E2B4B0 File Offset: 0x00E296B0
		protected void ForceUnSelectItems()
		{
			int count = this.Items.Count;
			for (int i = 0; i < count; i++)
			{
				this.Items[i].ForceUnSelectItem();
			}
			this.CurrentSelectState = false;
		}

		// Token: 0x0603282C RID: 206892 RVA: 0x00E2B4F4 File Offset: 0x00E296F4
		[NullableContext(1)]
		public void ScrollToItem(TAttachItem item, bool force = false)
		{
			if (this.InertiaState && !force)
			{
				return;
			}
			float currentPosition = item.GetCurrentPosition();
			this.SetMoveTypeOffset(EMoveType.Inertia, -currentPosition);
			this.ForceUnSelectItems();
			this.CurrentSelectItemIndex = item.GetCurrentShowItemIndex();
			if (force)
			{
				this.ForceSelectItemCache = item;
				return;
			}
			this.CurrentRunningElasticTime = 0f;
			this.InertiaState = true;
		}

		// Token: 0x0603282D RID: 206893 RVA: 0x00E2B558 File Offset: 0x00E29758
		private void MoveToShowIndexForce(int showItemIndex)
		{
			TAttachItem tattachItem = this.FindNearestMiddleItem();
			if (tattachItem == null)
			{
				return;
			}
			int num = showItemIndex - tattachItem.GetCurrentShowItemIndex();
			float num2 = (float)this.GetAutoAttachMoveMinusOffsetDirection() * this.GetItemGapSize() * (float)num + tattachItem.GetCurrentPosition();
			this.SetMoveTypeOffset(EMoveType.Inertia, -num2);
			float offset = this.RecalculateMoveOffset(-num2);
			this.MoveItems(offset, true);
			this.InertiaState = false;
			this.VelocityMoveState = false;
		}

		// Token: 0x0603282E RID: 206894 RVA: 0x00E2B5CC File Offset: 0x00E297CC
		[NullableContext(1)]
		private void MoveToItemForce(TAttachItem item)
		{
			float currentPosition = item.GetCurrentPosition();
			this.SetMoveTypeOffset(EMoveType.Inertia, -currentPosition);
			float offset = this.RecalculateMoveOffset(-currentPosition);
			this.MoveItems(offset, true);
			this.InertiaState = false;
			this.VelocityMoveState = false;
		}

		// Token: 0x0603282F RID: 206895 RVA: 0x00E2B610 File Offset: 0x00E29810
		public void AttachToNextItem(int direction)
		{
			TAttachItem tattachItem = this.FindNextDirectionItem(direction);
			if (tattachItem != null)
			{
				this.AttachToIndex(tattachItem.GetCurrentShowItemIndex(), false);
				return;
			}
			TAttachItem tattachItem2 = this.FindNearestMiddleItem();
			if (tattachItem2 == null)
			{
				return;
			}
			this.AttachToIndex(tattachItem2.GetCurrentShowItemIndex(), false);
		}

		// Token: 0x06032830 RID: 206896 RVA: 0x00E2B664 File Offset: 0x00E29864
		public void AttachToIndex(int showItemIndex, bool force = false)
		{
			if (this.InertiaState && !force)
			{
				return;
			}
			TAttachItem showIndexItem = this.GetShowIndexItem(showItemIndex);
			if (showIndexItem != null)
			{
				this.ScrollToItem(showIndexItem, force);
			}
			else
			{
				this.ForceUnSelectItems();
				this.CurrentSelectItemIndex = showItemIndex;
				TAttachItem tattachItem = this.FindNearestMiddleItem();
				if (tattachItem == null)
				{
					return;
				}
				if (!force)
				{
					int num = showItemIndex - tattachItem.GetCurrentShowItemIndex();
					float num2 = (float)this.GetAutoAttachMoveMinusOffsetDirection() * this.GetItemGapSize() * (float)num - tattachItem.GetCurrentPosition();
					this.SetMoveTypeOffset(EMoveType.Inertia, -num2);
					this.CurrentRunningElasticTime = 0f;
					this.InertiaState = true;
				}
				else
				{
					this.ForceToItemIndex = new int?(showItemIndex);
				}
			}
			this.Tick(0f);
		}

		// Token: 0x06032831 RID: 206897 RVA: 0x00E2B718 File Offset: 0x00E29918
		protected int GetAutoAttachMoveMinusOffsetDirection()
		{
			EAttachDirection? attachDirection = this.AttachDirection;
			EAttachDirection eattachDirection = EAttachDirection.Horizontal;
			if (attachDirection.GetValueOrDefault() == eattachDirection & attachDirection != null)
			{
				return 1;
			}
			return -1;
		}

		// Token: 0x06032832 RID: 206898 RVA: 0x00E2B745 File Offset: 0x00E29945
		public int GetCurrentSelectIndex()
		{
			return this.CurrentSelectItemIndex;
		}

		// Token: 0x06032833 RID: 206899 RVA: 0x00E2B74D File Offset: 0x00E2994D
		[NullableContext(1)]
		public TAttachItem GetCurrentSelectItem()
		{
			return this.Items[this.CurrentSelectItemIndex];
		}

		// Token: 0x06032834 RID: 206900 RVA: 0x00E2B760 File Offset: 0x00E29960
		public bool MovingState()
		{
			return this.DragState || this.InertiaState;
		}

		// Token: 0x06032835 RID: 206901 RVA: 0x00E2B772 File Offset: 0x00E29972
		private void OnPointerDragCallback(ULGUIPointerEventData eventData)
		{
			this.OnPointerDrag(eventData);
		}

		// Token: 0x06032836 RID: 206902 RVA: 0x00E2B77B File Offset: 0x00E2997B
		private void OnPointerDragEnd(ULGUIPointerEventData eventData)
		{
			this.OnPointerEndDrag(eventData);
		}

		// Token: 0x06032837 RID: 206903 RVA: 0x00E2B784 File Offset: 0x00E29984
		private void OnPointerBeginDrag(ULGUIPointerEventData eventData)
		{
			this.DragState = true;
			this.InertiaState = false;
			this.CheckInertiaSelectState = false;
			this.VelocityMoveState = false;
			this.BeginPlanePosition = ((eventData != null) ? new FVector?(eventData.GetWorldPointInPlane()) : null);
			this.CurrentPlanePosition = ((eventData != null) ? new FVector?(eventData.GetWorldPointInPlane()) : null);
			int count = this.Items.Count;
			for (int i = 0; i < count; i++)
			{
				this.Items[i].OnControllerDragStart();
			}
			Action dragBegin = this.DragBegin;
			if (dragBegin == null)
			{
				return;
			}
			dragBegin();
		}

		// Token: 0x06032838 RID: 206904 RVA: 0x00E2B829 File Offset: 0x00E29A29
		private void NavigateToPrev()
		{
			this.AttachToNextItem(-1);
		}

		// Token: 0x06032839 RID: 206905 RVA: 0x00E2B832 File Offset: 0x00E29A32
		private void NavigateToNext()
		{
			this.AttachToNextItem(1);
		}

		// Token: 0x0603283A RID: 206906 RVA: 0x00E2B83C File Offset: 0x00E29A3C
		private void OnPointerScrollCallBack(ULGUIPointerEventData eventData)
		{
			float? num = (eventData != null) ? new float?(eventData.scrollAxisValue) : null;
			if (num != null)
			{
				float? num2 = num;
				float num3 = 0f;
				if (!(num2.GetValueOrDefault() == num3 & num2 != null))
				{
					num2 = num;
					num3 = 0f;
					int num4 = (int)((num2.GetValueOrDefault() > num3 & num2 != null) ? (num + 0.5f) : (num - 0.5f)).Value;
					this.AttachToNextItem(-num4);
				}
			}
		}

		// Token: 0x0603283B RID: 206907 RVA: 0x00E2B914 File Offset: 0x00E29B14
		private void OnPointerDrag(ULGUIPointerEventData eventData)
		{
			this.OnPointerDragDelay = 0;
			this.NeedDelayApplyCachePointerDragData = true;
			this.OnPointerDragCacheData = eventData;
			FVector worldPointInPlane = eventData.GetWorldPointInPlane();
			FVector? beginPlanePosition = this.BeginPlanePosition;
			if (beginPlanePosition != null)
			{
				float num = this.GetVectorPositionByMoveDirection(worldPointInPlane) - this.GetVectorPositionByMoveDirection(beginPlanePosition.Value);
				if (num != 0f)
				{
					this.SetMoveTypeOffset(EMoveType.Inertia, num);
					float offset = this.RecalculateMoveOffset(num);
					this.MoveItems(offset, false);
					this.BeginPlanePosition = new FVector?(worldPointInPlane);
				}
			}
		}

		// Token: 0x0603283C RID: 206908 RVA: 0x00E2B98F File Offset: 0x00E29B8F
		private void ApplyCachePointerDragData(ULGUIPointerEventData eventData)
		{
			this.CurrentPlanePosition = new FVector?(eventData.GetWorldPointInPlane());
		}

		// Token: 0x0603283D RID: 206909 RVA: 0x00E2B9A4 File Offset: 0x00E29BA4
		private void OnPointerEndDrag(ULGUIPointerEventData eventData)
		{
			int count = this.Items.Count;
			for (int i = 0; i < count; i++)
			{
				this.Items[i].OnControllerDragEnd();
			}
			this.DragState = false;
			this.CurrentRunningElasticTime = 0f;
			this.CurrentVelocityMoveDelta = 0f;
			this.CurrentElasticMoveDelta = 0f;
			if (!this.SupportVelocity)
			{
				TAttachItem tattachItem = this.FindAutoAttachItem();
				this.AttachToIndex(tattachItem.GetCurrentShowItemIndex(), false);
				return;
			}
			FVector worldPointInPlane = eventData.GetWorldPointInPlane();
			float num = 0f;
			if (this.CurrentPlanePosition != null)
			{
				num = (this.GetVectorPositionByMoveDirection(worldPointInPlane) - this.GetVectorPositionByMoveDirection(this.CurrentPlanePosition.Value)) * this.MoveMultiFactor;
			}
			if (Math.Abs(num) < this.MinusVelocityMoveDistance)
			{
				TAttachItem tattachItem2 = this.FindAutoAttachItem();
				this.AttachToIndex(tattachItem2.GetCurrentShowItemIndex(), false);
				return;
			}
			if (this.PageLimitState && Math.Abs(num) > this.GetItemGapSize())
			{
				int direction = (num > 0f) ? -1 : 1;
				this.AttachToNextItem(direction);
				return;
			}
			this.VelocityMoveState = true;
			this.SetMoveTypeOffset(EMoveType.Velocity, num);
			this.VelocityDirection = (float)((num > 0f) ? 1 : -1);
			this.CurrentVelocityRunningTime = 0f;
		}

		// Token: 0x0603283E RID: 206910 RVA: 0x00E2BAF0 File Offset: 0x00E29CF0
		private float GetVectorPositionByMoveDirection(FVector vector)
		{
			EAttachDirection? attachDirection = this.AttachDirection;
			EAttachDirection eattachDirection = EAttachDirection.Horizontal;
			if (attachDirection.GetValueOrDefault() == eattachDirection & attachDirection != null)
			{
				return vector.X;
			}
			return vector.Z;
		}

		// Token: 0x0603283F RID: 206911 RVA: 0x00E2BB28 File Offset: 0x00E29D28
		protected float? GetMoveTypeOffset(EMoveType type)
		{
			float value;
			if (!this.CurrentMoveOffsetMap.TryGetValue(type, out value))
			{
				return null;
			}
			return new float?(value);
		}

		// Token: 0x06032840 RID: 206912 RVA: 0x00E2BB55 File Offset: 0x00E29D55
		protected void SetMoveTypeOffset(EMoveType type, float offset)
		{
			this.CurrentMoveOffsetMap[type] = offset;
			if (type == EMoveType.Inertia)
			{
				this.CurrentElasticMoveDelta = 0f;
			}
		}

		// Token: 0x06032841 RID: 206913 RVA: 0x00E2BB74 File Offset: 0x00E29D74
		private void MoveItems(float offset, bool forceMove = false)
		{
			float num = 99999f;
			int? num2 = null;
			int count = this.Items.Count;
			for (int i = 0; i < count; i++)
			{
				TAttachItem tattachItem = this.Items[i];
				tattachItem.MoveItem(offset);
				if (((!this.CurrentSelectState && this.SelectItemModel == EAttachMode.OnMoving) || forceMove) && tattachItem.GetCurrentShowItemIndex() == this.CurrentSelectItemIndex && !tattachItem.GetSelectedState())
				{
					tattachItem.Select();
					this.CurrentSelectState = true;
				}
				float num3 = Math.Abs(tattachItem.GetCurrentMovePercentage() - 0.5f);
				if (num3 < num)
				{
					num = num3;
					num2 = new int?(tattachItem.GetItemIndex());
				}
			}
			int? currentMiddleIndex = this.CurrentMiddleIndex;
			int? num4 = num2;
			if (!(currentMiddleIndex.GetValueOrDefault() == num4.GetValueOrDefault() & currentMiddleIndex != null == (num4 != null)))
			{
				this.CurrentMiddleIndex = num2;
				if (!forceMove)
				{
					AudioSystem.Instance.PostEvent(this.AudioEvent);
				}
			}
			if (this.SelectItemModel == EAttachMode.OnMovingNearest && !forceMove)
			{
				TAttachItem tattachItem2 = this.FindAutoAttachItem();
				if (tattachItem2 != null && !tattachItem2.GetSelectedState())
				{
					this.ForceUnSelectItems();
					this.CurrentSelectItemIndex = tattachItem2.GetCurrentShowItemIndex();
					tattachItem2.Select();
					this.CurrentSelectState = true;
				}
			}
			Action moveItemsCallback = this.MoveItemsCallback;
			if (moveItemsCallback == null)
			{
				return;
			}
			moveItemsCallback();
		}

		// Token: 0x06032842 RID: 206914
		[NullableContext(1)]
		public abstract TAttachItem FindAutoAttachItem();

		// Token: 0x06032843 RID: 206915
		protected abstract float RecalculateMoveOffset(float offset);

		// Token: 0x06032844 RID: 206916
		[NullableContext(1)]
		protected abstract void ReloadItems(int showItemNum, T[] data, int attachTo = 0);

		// Token: 0x06032845 RID: 206917
		public abstract bool GetIfCircle();

		// Token: 0x06032846 RID: 206918
		protected abstract TAttachItem FindNextDirectionItem(int direction);

		// Token: 0x06032847 RID: 206919 RVA: 0x00E2BCF8 File Offset: 0x00E29EF8
		public void Clear()
		{
			foreach (TAttachItem tattachItem in this.Items)
			{
				tattachItem.Destroy(null);
			}
			this.Items = new List<TAttachItem>();
			if (this.TickId != -1)
			{
				TickSystem.Instance.Remove(this.TickId);
				this.TickId = -1;
			}
		}

		// Token: 0x0401AC7C RID: 109692
		protected AActor SourceActor;

		// Token: 0x0401AC7D RID: 109693
		protected UUIItem SourceItem;

		// Token: 0x0401AC7E RID: 109694
		protected float SourceItemHeight;

		// Token: 0x0401AC7F RID: 109695
		protected float SourceItemWidth;

		// Token: 0x0401AC80 RID: 109696
		protected AActor ControllerActor;

		// Token: 0x0401AC81 RID: 109697
		protected UUIItem ControllerItem;

		// Token: 0x0401AC82 RID: 109698
		protected float ControllerHeight;

		// Token: 0x0401AC83 RID: 109699
		protected float ControllerWidth;

		// Token: 0x0401AC84 RID: 109700
		protected float Gap;

		// Token: 0x0401AC85 RID: 109701
		protected int ShowItemNum;

		// Token: 0x0401AC86 RID: 109702
		protected int DataLength;

		// Token: 0x0401AC87 RID: 109703
		protected float MoveBoundary;

		// Token: 0x0401AC88 RID: 109704
		protected bool InertiaState;

		// Token: 0x0401AC89 RID: 109705
		private bool CheckInertiaSelectState;

		// Token: 0x0401AC8A RID: 109706
		protected bool DragState;

		// Token: 0x0401AC8B RID: 109707
		protected bool VelocityMoveState;

		// Token: 0x0401AC8C RID: 109708
		private FVector? BeginPlanePosition;

		// Token: 0x0401AC8D RID: 109709
		private FVector? CurrentPlanePosition;

		// Token: 0x0401AC8E RID: 109710
		private readonly bool SupportVelocity = true;

		// Token: 0x0401AC8F RID: 109711
		private float VelocityDirection;

		// Token: 0x0401AC90 RID: 109712
		protected float CurrentVelocityRunningTime;

		// Token: 0x0401AC91 RID: 109713
		private readonly UCurveFloat VelocityCurve;

		// Token: 0x0401AC92 RID: 109714
		private readonly UCurveFloat InertiaCurve;

		// Token: 0x0401AC93 RID: 109715
		protected readonly UCurveFloat BoundaryCurve;

		// Token: 0x0401AC94 RID: 109716
		private readonly float FullVelocityTime;

		// Token: 0x0401AC95 RID: 109717
		private readonly float FullInertiaTime;

		// Token: 0x0401AC96 RID: 109718
		private float CurrentElasticMoveDelta;

		// Token: 0x0401AC97 RID: 109719
		private float CurrentVelocityMoveDelta;

		// Token: 0x0401AC98 RID: 109720
		private float MinusVelocityMoveDistance;

		// Token: 0x0401AC99 RID: 109721
		[Nullable(1)]
		private readonly Dictionary<EMoveType, float> CurrentMoveOffsetMap = new Dictionary<EMoveType, float>();

		// Token: 0x0401AC9A RID: 109722
		[Nullable(1)]
		protected List<TAttachItem> Items = new List<TAttachItem>();

		// Token: 0x0401AC9B RID: 109723
		private TAttachItem ForceSelectItemCache;

		// Token: 0x0401AC9C RID: 109724
		protected EAttachDirection? AttachDirection;

		// Token: 0x0401AC9D RID: 109725
		protected bool CurrentSelectState;

		// Token: 0x0401AC9E RID: 109726
		protected int CurrentSelectItemIndex;

		// Token: 0x0401AC9F RID: 109727
		protected float CurrentRunningElasticTime;

		// Token: 0x0401ACA0 RID: 109728
		private EAttachMode SelectItemModel = EAttachMode.EndMove;

		// Token: 0x0401ACA1 RID: 109729
		private int TickId = -1;

		// Token: 0x0401ACA2 RID: 109730
		private float MoveMultiFactor = 5f;

		// Token: 0x0401ACA3 RID: 109731
		private bool PageLimitState;

		// Token: 0x0401ACA4 RID: 109732
		[Nullable(1)]
		private string AudioEvent = "ui_common_picker_tick";

		// Token: 0x0401ACA5 RID: 109733
		private int? CurrentMiddleIndex;

		// Token: 0x0401ACA6 RID: 109734
		[Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		protected Func<AActor, int, int, TAttachItem> CreateItemFunction = (AActor actor, int index, int showNum) => default(TAttachItem);

		// Token: 0x0401ACA7 RID: 109735
		private bool IsMoving;

		// Token: 0x0401ACA8 RID: 109736
		private readonly bool IsNeedScrollCallback;

		// Token: 0x0401ACA9 RID: 109737
		private Action DragBegin;

		// Token: 0x0401ACAA RID: 109738
		private Action MoveItemsCallback;

		// Token: 0x0401ACAB RID: 109739
		private const float ENDMOVEFLOAT = 0.01f;

		// Token: 0x0401ACAC RID: 109740
		private const float MOVEMULFACTOR = 5f;

		// Token: 0x0401ACAD RID: 109741
		private const float VERYBIGDISTANCE = 99999f;

		// Token: 0x0401ACAE RID: 109742
		private const float DISTANCETOMIDDLE = 0.5f;

		// Token: 0x0401ACAF RID: 109743
		[Nullable(1)]
		private const string DEFALTAUDIO = "ui_common_picker_tick";

		// Token: 0x0401ACB0 RID: 109744
		private int? ForceToItemIndex;

		// Token: 0x0401ACB1 RID: 109745
		private int OnPointerDragDelay;

		// Token: 0x0401ACB2 RID: 109746
		private bool NeedDelayApplyCachePointerDragData;

		// Token: 0x0401ACB3 RID: 109747
		private ULGUIPointerEventData OnPointerDragCacheData;
	}
}
