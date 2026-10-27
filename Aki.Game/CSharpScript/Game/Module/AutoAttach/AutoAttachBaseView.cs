using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.AutoAttach
{
	// Token: 0x02005E7F RID: 24191
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class AutoAttachBaseView<T, [Nullable(0)] TAttachItem> : IAutoAttachBaseView<T> where TAttachItem : AutoAttachItem<T>
	{
		// Token: 0x0603D878 RID: 252024 RVA: 0x00ED9430 File Offset: 0x00ED7630
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

		// Token: 0x0603D879 RID: 252025 RVA: 0x00ED9606 File Offset: 0x00ED7806
		private void OnActorDestroy(AActor actor)
		{
			this.Clear();
		}

		// Token: 0x0603D87A RID: 252026 RVA: 0x00ED960E File Offset: 0x00ED780E
		public virtual float GetTrueBoundary()
		{
			return 0f;
		}

		// Token: 0x0603D87B RID: 252027 RVA: 0x00ED9615 File Offset: 0x00ED7815
		public void SetItemSelectMode(EAttachMode mode)
		{
			this.SelectItemModel = mode;
		}

		// Token: 0x0603D87C RID: 252028 RVA: 0x00ED961E File Offset: 0x00ED781E
		public void SetPageLimitState(bool state)
		{
			this.PageLimitState = state;
		}

		// Token: 0x0603D87D RID: 252029 RVA: 0x00ED9627 File Offset: 0x00ED7827
		public void SetMoveMultiFactor(float value)
		{
			this.MoveMultiFactor = value;
		}

		// Token: 0x0603D87E RID: 252030 RVA: 0x00ED9630 File Offset: 0x00ED7830
		[NullableContext(1)]
		public void SetDragBeginCallback(Action callback)
		{
			this.DragBegin = callback;
		}

		// Token: 0x0603D87F RID: 252031 RVA: 0x00ED9639 File Offset: 0x00ED7839
		[NullableContext(1)]
		public void SetMoveItemsCallback(Action callback)
		{
			this.MoveItemsCallback = callback;
		}

		// Token: 0x0603D880 RID: 252032 RVA: 0x00ED9642 File Offset: 0x00ED7842
		[NullableContext(1)]
		public void SetAudioEvent(string eventName)
		{
			this.AudioEvent = eventName;
		}

		// Token: 0x0603D881 RID: 252033 RVA: 0x00ED964B File Offset: 0x00ED784B
		public bool IsVelocityMoveState()
		{
			return this.VelocityMoveState;
		}

		// Token: 0x0603D882 RID: 252034 RVA: 0x00ED9654 File Offset: 0x00ED7854
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

		// Token: 0x0603D883 RID: 252035 RVA: 0x00ED96EF File Offset: 0x00ED78EF
		public void SetMoveBoundary(float distance)
		{
			this.MoveBoundary = distance;
		}

		// Token: 0x0603D884 RID: 252036 RVA: 0x00ED96F8 File Offset: 0x00ED78F8
		public EAttachDirection? GetCurrentMoveDirection()
		{
			return this.AttachDirection;
		}

		// Token: 0x0603D885 RID: 252037 RVA: 0x00ED9700 File Offset: 0x00ED7900
		private void InitDefaultMoveBoundary()
		{
			this.MoveBoundary = this.GetItemSize();
		}

		// Token: 0x0603D886 RID: 252038 RVA: 0x00ED970E File Offset: 0x00ED790E
		public void SetBoundDistance(float size)
		{
			this.MoveBoundary = size;
		}

		// Token: 0x0603D887 RID: 252039 RVA: 0x00ED9717 File Offset: 0x00ED7917
		protected float GetItemGapSize()
		{
			return this.GetItemSize() + this.Gap;
		}

		// Token: 0x0603D888 RID: 252040 RVA: 0x00ED9728 File Offset: 0x00ED7928
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

		// Token: 0x0603D889 RID: 252041 RVA: 0x00ED9788 File Offset: 0x00ED7988
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

		// Token: 0x0603D88A RID: 252042 RVA: 0x00ED9854 File Offset: 0x00ED7A54
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

		// Token: 0x0603D88B RID: 252043 RVA: 0x00ED98BE File Offset: 0x00ED7ABE
		public float GetGap()
		{
			return this.Gap;
		}

		// Token: 0x0603D88C RID: 252044 RVA: 0x00ED98C8 File Offset: 0x00ED7AC8
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

		// Token: 0x0603D88D RID: 252045 RVA: 0x00ED990C File Offset: 0x00ED7B0C
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

		// Token: 0x0603D88E RID: 252046 RVA: 0x00ED9950 File Offset: 0x00ED7B50
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

		// Token: 0x0603D88F RID: 252047 RVA: 0x00ED9B20 File Offset: 0x00ED7D20
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

		// Token: 0x0603D890 RID: 252048 RVA: 0x00ED9C3C File Offset: 0x00ED7E3C
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

		// Token: 0x0603D891 RID: 252049 RVA: 0x00ED9CFC File Offset: 0x00ED7EFC
		[NullableContext(1)]
		protected float GetCurveValue(UCurveFloat curve, float progress)
		{
			return curve.GetFloatValue(progress);
		}

		// Token: 0x0603D892 RID: 252050 RVA: 0x00ED9D08 File Offset: 0x00ED7F08
		private void EndVelocityMove()
		{
			this.VelocityMoveState = false;
			this.InertiaState = false;
			TAttachItem item = this.FindAutoAttachItem();
			this.ScrollToItem(item, false);
		}

		// Token: 0x0603D893 RID: 252051 RVA: 0x00ED9D32 File Offset: 0x00ED7F32
		[NullableContext(1)]
		public void ReloadView(int showItemNum, T[] data, int attachTo = 0)
		{
			this.DataLength = showItemNum;
			this.ReloadItems(showItemNum, data, attachTo);
		}

		// Token: 0x0603D894 RID: 252052 RVA: 0x00ED9D44 File Offset: 0x00ED7F44
		public int GetShowItemNum()
		{
			return this.ShowItemNum;
		}

		// Token: 0x0603D895 RID: 252053 RVA: 0x00ED9D4C File Offset: 0x00ED7F4C
		public int GetDataLength()
		{
			return this.DataLength;
		}

		// Token: 0x0603D896 RID: 252054 RVA: 0x00ED9D54 File Offset: 0x00ED7F54
		public void RefreshItems()
		{
			int count = this.Items.Count;
			for (int i = 0; i < count; i++)
			{
				this.Items[i].RefreshItem();
			}
		}

		// Token: 0x0603D897 RID: 252055 RVA: 0x00ED9D90 File Offset: 0x00ED7F90
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

		// Token: 0x0603D898 RID: 252056 RVA: 0x00ED9E58 File Offset: 0x00ED8058
		[NullableContext(1)]
		public List<TAttachItem> GetItems()
		{
			return this.Items;
		}

		// Token: 0x0603D899 RID: 252057 RVA: 0x00ED9E60 File Offset: 0x00ED8060
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

		// Token: 0x0603D89A RID: 252058 RVA: 0x00ED9EB8 File Offset: 0x00ED80B8
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

		// Token: 0x0603D89B RID: 252059 RVA: 0x00ED9F24 File Offset: 0x00ED8124
		protected void ForceUnSelectItems()
		{
			int count = this.Items.Count;
			for (int i = 0; i < count; i++)
			{
				this.Items[i].ForceUnSelectItem();
			}
			this.CurrentSelectState = false;
		}

		// Token: 0x0603D89C RID: 252060 RVA: 0x00ED9F68 File Offset: 0x00ED8168
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

		// Token: 0x0603D89D RID: 252061 RVA: 0x00ED9FCC File Offset: 0x00ED81CC
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

		// Token: 0x0603D89E RID: 252062 RVA: 0x00EDA040 File Offset: 0x00ED8240
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

		// Token: 0x0603D89F RID: 252063 RVA: 0x00EDA084 File Offset: 0x00ED8284
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

		// Token: 0x0603D8A0 RID: 252064 RVA: 0x00EDA0D8 File Offset: 0x00ED82D8
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

		// Token: 0x0603D8A1 RID: 252065 RVA: 0x00EDA18C File Offset: 0x00ED838C
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

		// Token: 0x0603D8A2 RID: 252066 RVA: 0x00EDA1B9 File Offset: 0x00ED83B9
		public int GetCurrentSelectIndex()
		{
			return this.CurrentSelectItemIndex;
		}

		// Token: 0x0603D8A3 RID: 252067 RVA: 0x00EDA1C1 File Offset: 0x00ED83C1
		[NullableContext(1)]
		public TAttachItem GetCurrentSelectItem()
		{
			return this.Items[this.CurrentSelectItemIndex];
		}

		// Token: 0x0603D8A4 RID: 252068 RVA: 0x00EDA1D4 File Offset: 0x00ED83D4
		public bool MovingState()
		{
			return this.DragState || this.InertiaState;
		}

		// Token: 0x0603D8A5 RID: 252069 RVA: 0x00EDA1E6 File Offset: 0x00ED83E6
		private void OnPointerDragCallback(ULGUIPointerEventData eventData)
		{
			this.OnPointerDrag(eventData);
		}

		// Token: 0x0603D8A6 RID: 252070 RVA: 0x00EDA1EF File Offset: 0x00ED83EF
		private void OnPointerDragEnd(ULGUIPointerEventData eventData)
		{
			this.OnPointerEndDrag(eventData);
		}

		// Token: 0x0603D8A7 RID: 252071 RVA: 0x00EDA1F8 File Offset: 0x00ED83F8
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

		// Token: 0x0603D8A8 RID: 252072 RVA: 0x00EDA29D File Offset: 0x00ED849D
		private void NavigateToPrev()
		{
			this.AttachToNextItem(-1);
		}

		// Token: 0x0603D8A9 RID: 252073 RVA: 0x00EDA2A6 File Offset: 0x00ED84A6
		private void NavigateToNext()
		{
			this.AttachToNextItem(1);
		}

		// Token: 0x0603D8AA RID: 252074 RVA: 0x00EDA2B0 File Offset: 0x00ED84B0
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

		// Token: 0x0603D8AB RID: 252075 RVA: 0x00EDA388 File Offset: 0x00ED8588
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

		// Token: 0x0603D8AC RID: 252076 RVA: 0x00EDA403 File Offset: 0x00ED8603
		private void ApplyCachePointerDragData(ULGUIPointerEventData eventData)
		{
			this.CurrentPlanePosition = new FVector?(eventData.GetWorldPointInPlane());
		}

		// Token: 0x0603D8AD RID: 252077 RVA: 0x00EDA418 File Offset: 0x00ED8618
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

		// Token: 0x0603D8AE RID: 252078 RVA: 0x00EDA564 File Offset: 0x00ED8764
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

		// Token: 0x0603D8AF RID: 252079 RVA: 0x00EDA59C File Offset: 0x00ED879C
		protected float? GetMoveTypeOffset(EMoveType type)
		{
			float value;
			if (!this.CurrentMoveOffsetMap.TryGetValue(type, out value))
			{
				return null;
			}
			return new float?(value);
		}

		// Token: 0x0603D8B0 RID: 252080 RVA: 0x00EDA5C9 File Offset: 0x00ED87C9
		protected void SetMoveTypeOffset(EMoveType type, float offset)
		{
			this.CurrentMoveOffsetMap[type] = offset;
			if (type == EMoveType.Inertia)
			{
				this.CurrentElasticMoveDelta = 0f;
			}
		}

		// Token: 0x0603D8B1 RID: 252081 RVA: 0x00EDA5E8 File Offset: 0x00ED87E8
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

		// Token: 0x0603D8B2 RID: 252082
		[NullableContext(1)]
		public abstract TAttachItem FindAutoAttachItem();

		// Token: 0x0603D8B3 RID: 252083
		protected abstract float RecalculateMoveOffset(float offset);

		// Token: 0x0603D8B4 RID: 252084
		[NullableContext(1)]
		protected abstract void ReloadItems(int showItemNum, T[] data, int attachTo = 0);

		// Token: 0x0603D8B5 RID: 252085
		public abstract bool GetIfCircle();

		// Token: 0x0603D8B6 RID: 252086
		protected abstract TAttachItem FindNextDirectionItem(int direction);

		// Token: 0x0603D8B7 RID: 252087 RVA: 0x00EDA76C File Offset: 0x00ED896C
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

		// Token: 0x040201B5 RID: 131509
		protected AActor SourceActor;

		// Token: 0x040201B6 RID: 131510
		protected UUIItem SourceItem;

		// Token: 0x040201B7 RID: 131511
		protected float SourceItemHeight;

		// Token: 0x040201B8 RID: 131512
		protected float SourceItemWidth;

		// Token: 0x040201B9 RID: 131513
		protected AActor ControllerActor;

		// Token: 0x040201BA RID: 131514
		protected UUIItem ControllerItem;

		// Token: 0x040201BB RID: 131515
		protected float ControllerHeight;

		// Token: 0x040201BC RID: 131516
		protected float ControllerWidth;

		// Token: 0x040201BD RID: 131517
		protected float Gap;

		// Token: 0x040201BE RID: 131518
		protected int ShowItemNum;

		// Token: 0x040201BF RID: 131519
		protected int DataLength;

		// Token: 0x040201C0 RID: 131520
		protected float MoveBoundary;

		// Token: 0x040201C1 RID: 131521
		protected bool InertiaState;

		// Token: 0x040201C2 RID: 131522
		private bool CheckInertiaSelectState;

		// Token: 0x040201C3 RID: 131523
		protected bool DragState;

		// Token: 0x040201C4 RID: 131524
		protected bool VelocityMoveState;

		// Token: 0x040201C5 RID: 131525
		private FVector? BeginPlanePosition;

		// Token: 0x040201C6 RID: 131526
		private FVector? CurrentPlanePosition;

		// Token: 0x040201C7 RID: 131527
		private readonly bool SupportVelocity = true;

		// Token: 0x040201C8 RID: 131528
		private float VelocityDirection;

		// Token: 0x040201C9 RID: 131529
		protected float CurrentVelocityRunningTime;

		// Token: 0x040201CA RID: 131530
		private readonly UCurveFloat VelocityCurve;

		// Token: 0x040201CB RID: 131531
		private readonly UCurveFloat InertiaCurve;

		// Token: 0x040201CC RID: 131532
		protected readonly UCurveFloat BoundaryCurve;

		// Token: 0x040201CD RID: 131533
		private readonly float FullVelocityTime;

		// Token: 0x040201CE RID: 131534
		private readonly float FullInertiaTime;

		// Token: 0x040201CF RID: 131535
		private float CurrentElasticMoveDelta;

		// Token: 0x040201D0 RID: 131536
		private float CurrentVelocityMoveDelta;

		// Token: 0x040201D1 RID: 131537
		private float MinusVelocityMoveDistance;

		// Token: 0x040201D2 RID: 131538
		[Nullable(1)]
		private readonly Dictionary<EMoveType, float> CurrentMoveOffsetMap = new Dictionary<EMoveType, float>();

		// Token: 0x040201D3 RID: 131539
		[Nullable(1)]
		protected List<TAttachItem> Items = new List<TAttachItem>();

		// Token: 0x040201D4 RID: 131540
		private TAttachItem ForceSelectItemCache;

		// Token: 0x040201D5 RID: 131541
		protected EAttachDirection? AttachDirection;

		// Token: 0x040201D6 RID: 131542
		protected bool CurrentSelectState;

		// Token: 0x040201D7 RID: 131543
		protected int CurrentSelectItemIndex;

		// Token: 0x040201D8 RID: 131544
		protected float CurrentRunningElasticTime;

		// Token: 0x040201D9 RID: 131545
		private EAttachMode SelectItemModel = EAttachMode.EndMove;

		// Token: 0x040201DA RID: 131546
		private int TickId = -1;

		// Token: 0x040201DB RID: 131547
		private float MoveMultiFactor = 5f;

		// Token: 0x040201DC RID: 131548
		private bool PageLimitState;

		// Token: 0x040201DD RID: 131549
		[Nullable(1)]
		private string AudioEvent = "ui_common_picker_tick";

		// Token: 0x040201DE RID: 131550
		private int? CurrentMiddleIndex;

		// Token: 0x040201DF RID: 131551
		[Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		protected Func<AActor, int, int, TAttachItem> CreateItemFunction = (AActor actor, int index, int showNum) => default(TAttachItem);

		// Token: 0x040201E0 RID: 131552
		private bool IsMoving;

		// Token: 0x040201E1 RID: 131553
		private readonly bool IsNeedScrollCallback;

		// Token: 0x040201E2 RID: 131554
		private Action DragBegin;

		// Token: 0x040201E3 RID: 131555
		private Action MoveItemsCallback;

		// Token: 0x040201E4 RID: 131556
		private const float ENDMOVEFLOAT = 0.01f;

		// Token: 0x040201E5 RID: 131557
		private const float MOVEMULFACTOR = 5f;

		// Token: 0x040201E6 RID: 131558
		private const float VERYBIGDISTANCE = 99999f;

		// Token: 0x040201E7 RID: 131559
		private const float DISTANCETOMIDDLE = 0.5f;

		// Token: 0x040201E8 RID: 131560
		[Nullable(1)]
		private const string DEFALTAUDIO = "ui_common_picker_tick";

		// Token: 0x040201E9 RID: 131561
		private int? ForceToItemIndex;

		// Token: 0x040201EA RID: 131562
		private int OnPointerDragDelay;

		// Token: 0x040201EB RID: 131563
		private bool NeedDelayApplyCachePointerDragData;

		// Token: 0x040201EC RID: 131564
		private ULGUIPointerEventData OnPointerDragCacheData;
	}
}
