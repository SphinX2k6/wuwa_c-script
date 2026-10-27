using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.AutoAttach
{
	// Token: 0x02005E81 RID: 24193
	public abstract class AutoAttachItem<[Nullable(2)] T> : UiPanelBase
	{
		// Token: 0x0603D8B9 RID: 252089 RVA: 0x00EDA7F8 File Offset: 0x00ED89F8
		[NullableContext(2)]
		public AutoAttachItem(AActor uiItem = null)
		{
			if (uiItem != null)
			{
				base.CreateThenShowByActor(uiItem, null);
			}
		}

		// Token: 0x0603D8BA RID: 252090 RVA: 0x00EDA80B File Offset: 0x00ED8A0B
		[NullableContext(1)]
		public void SetData(T[] dataArray)
		{
			this.AllData = dataArray;
		}

		// Token: 0x0603D8BB RID: 252091 RVA: 0x00EDA814 File Offset: 0x00ED8A14
		public void SetIfNeedShowFakeItem(bool state)
		{
			this.IfNeedShowFakeItem = state;
		}

		// Token: 0x0603D8BC RID: 252092 RVA: 0x00EDA81D File Offset: 0x00ED8A1D
		[NullableContext(1)]
		public void SetSourceView(IAutoAttachBaseView<T> view)
		{
			this.SourceView = view;
			this.CurrentMoveDirection = this.SourceView.GetCurrentMoveDirection();
		}

		// Token: 0x0603D8BD RID: 252093 RVA: 0x00EDA837 File Offset: 0x00ED8A37
		public void SetItemIndex(int index)
		{
			this.CreateIndex = index;
		}

		// Token: 0x0603D8BE RID: 252094 RVA: 0x00EDA840 File Offset: 0x00ED8A40
		public int GetItemIndex()
		{
			return this.CreateIndex;
		}

		// Token: 0x0603D8BF RID: 252095 RVA: 0x00EDA848 File Offset: 0x00ED8A48
		public void InitItem()
		{
			this.TryInitSelectToggle();
			this.DataLength = this.SourceView.GetDataLength();
			if (this.CreateIndex < this.DataLength)
			{
				this.CurrentShowItemIndex = this.CreateIndex;
			}
			else
			{
				this.CurrentShowItemIndex = this.CreateIndex - this.SourceView.GetShowItemNum();
			}
			this.InitPosition();
		}

		// Token: 0x0603D8C0 RID: 252096 RVA: 0x00EDA8A8 File Offset: 0x00ED8AA8
		private void InitPosition()
		{
			this.ResetPosition();
			if (this.SourceView != null)
			{
				int num = (int)Math.Floor((double)this.SourceView.GetShowItemNum() / 2.0);
				float itemSize = this.SourceView.GetItemSize();
				float gap = this.SourceView.GetGap();
				float offset;
				if (this.SourceView.GetIfCircle())
				{
					offset = (float)(this.CreateIndex - num) * (itemSize + gap);
				}
				else
				{
					EAttachDirection? currentMoveDirection = this.CurrentMoveDirection;
					EAttachDirection eattachDirection = EAttachDirection.Horizontal;
					if (currentMoveDirection.GetValueOrDefault() == eattachDirection & currentMoveDirection != null)
					{
						offset = (float)(this.CreateIndex - num) * (itemSize + gap);
					}
					else
					{
						offset = (float)(num - this.CreateIndex) * (itemSize + gap);
					}
				}
				this.MoveItem(offset);
			}
		}

		// Token: 0x0603D8C1 RID: 252097 RVA: 0x00EDA963 File Offset: 0x00ED8B63
		private void ResetPosition()
		{
			this.RootItem.SetAnchorOffsetX(0f);
			this.RootItem.SetAnchorOffsetY(0f);
		}

		// Token: 0x0603D8C2 RID: 252098 RVA: 0x00EDA988 File Offset: 0x00ED8B88
		public void MoveItem(float offset)
		{
			int currentShowItemIndex = this.CurrentShowItemIndex;
			ValueTuple<float, int> moveOffsetFinalPositionAndShowIndex = this.GetMoveOffsetFinalPositionAndShowIndex(offset);
			this.CurrentShowItemIndex = moveOffsetFinalPositionAndShowIndex.Item2;
			EAttachDirection? currentMoveDirection = this.CurrentMoveDirection;
			EAttachDirection eattachDirection = EAttachDirection.Horizontal;
			if (currentMoveDirection.GetValueOrDefault() == eattachDirection & currentMoveDirection != null)
			{
				this.RootItem.SetAnchorOffsetX(moveOffsetFinalPositionAndShowIndex.Item1);
			}
			else
			{
				this.RootItem.SetAnchorOffsetY(moveOffsetFinalPositionAndShowIndex.Item1);
			}
			if (!this.SourceView.GetIfCircle() && !this.IfShowOverSizeItem)
			{
				bool uiactive = (this.CurrentShowItemIndex >= 0 && this.CurrentShowItemIndex < this.DataLength) || this.IfNeedShowFakeItem;
				this.RootItem.SetUIActive(uiactive);
			}
			if (currentShowItemIndex != this.CurrentShowItemIndex)
			{
				this.RefreshItem();
			}
			this.RefreshSelectToggleState();
			this.OnMoveItem();
		}

		// Token: 0x0603D8C3 RID: 252099 RVA: 0x00EDAA4C File Offset: 0x00ED8C4C
		public float GetCurrentMovePercentage()
		{
			float viewSize = this.SourceView.GetViewSize();
			return (this.GetCurrentPosition() + viewSize / 2f) / viewSize;
		}

		// Token: 0x0603D8C4 RID: 252100 RVA: 0x00EDAA78 File Offset: 0x00ED8C78
		private ValueTuple<float, int> GetMoveOffsetFinalPositionAndShowIndex(float offset)
		{
			float checkPosition = this.GetCurrentPosition() + offset;
			if (this.SourceView.GetIfCircle())
			{
				return this.GetCircleMoveOffsetPositionAndShowIndex(checkPosition);
			}
			return this.GetNoCircleMoveOffsetPositionAndShowIndex(checkPosition);
		}

		// Token: 0x0603D8C5 RID: 252101 RVA: 0x00EDAAAC File Offset: 0x00ED8CAC
		private ValueTuple<float, int> GetCircleMoveOffsetPositionAndShowIndex(float checkPosition)
		{
			float num = checkPosition;
			int i = this.CurrentShowItemIndex;
			float itemSize = this.SourceView.GetItemSize();
			float gap = this.SourceView.GetGap();
			int showItemNum = this.SourceView.GetShowItemNum();
			if (!this.CheckIfInSizeOneBorder(num))
			{
				while (!this.CheckIfInSizeOneBorder(num))
				{
					num -= (itemSize + gap) * (float)Math.Ceiling((double)showItemNum + 1.0);
					i -= showItemNum + 1;
				}
				while (i < 0)
				{
					i = this.DataLength + i;
				}
			}
			else if (!this.CheckIfInSizeTwoBorder(num))
			{
				while (!this.CheckIfInSizeTwoBorder(num))
				{
					num += (itemSize + gap) * (float)Math.Ceiling((double)showItemNum + 1.0);
					i += showItemNum + 1;
				}
				while (i >= this.DataLength)
				{
					i -= this.DataLength;
				}
			}
			return new ValueTuple<float, int>(num, i);
		}

		// Token: 0x0603D8C6 RID: 252102 RVA: 0x00EDAB80 File Offset: 0x00ED8D80
		private ValueTuple<float, int> GetNoCircleMoveOffsetPositionAndShowIndex(float checkPosition)
		{
			float num = checkPosition;
			int num2 = this.CurrentShowItemIndex;
			float itemSize = this.SourceView.GetItemSize();
			float gap = this.SourceView.GetGap();
			int showItemNum = this.SourceView.GetShowItemNum();
			if (!this.CheckIfInSizeOneBorder(num))
			{
				while (!this.CheckIfInSizeOneBorder(num))
				{
					num -= (itemSize + gap) * (float)Math.Ceiling((double)showItemNum + 1.0);
					EAttachDirection? currentMoveDirection = this.CurrentMoveDirection;
					EAttachDirection eattachDirection = EAttachDirection.Horizontal;
					if (currentMoveDirection.GetValueOrDefault() == eattachDirection & currentMoveDirection != null)
					{
						num2 -= showItemNum + 1;
					}
					else
					{
						num2 += showItemNum + 1;
					}
				}
			}
			else if (!this.CheckIfInSizeTwoBorder(num))
			{
				while (!this.CheckIfInSizeTwoBorder(num))
				{
					num += (itemSize + gap) * (float)Math.Ceiling((double)showItemNum + 1.0);
					EAttachDirection? currentMoveDirection = this.CurrentMoveDirection;
					EAttachDirection eattachDirection = EAttachDirection.Horizontal;
					if (currentMoveDirection.GetValueOrDefault() == eattachDirection & currentMoveDirection != null)
					{
						num2 += showItemNum + 1;
					}
					else
					{
						num2 -= showItemNum + 1;
					}
				}
			}
			return new ValueTuple<float, int>(num, num2);
		}

		// Token: 0x0603D8C7 RID: 252103 RVA: 0x00EDAC80 File Offset: 0x00ED8E80
		public int GetCurrentShowItemIndex()
		{
			return this.CurrentShowItemIndex;
		}

		// Token: 0x0603D8C8 RID: 252104 RVA: 0x00EDAC88 File Offset: 0x00ED8E88
		protected bool GetCurrentSelectedState()
		{
			return this.SourceView.GetCurrentSelectIndex() == this.GetCurrentShowItemIndex();
		}

		// Token: 0x0603D8C9 RID: 252105 RVA: 0x00EDAC9D File Offset: 0x00ED8E9D
		public bool GetSelectedState()
		{
			return this.SelectState;
		}

		// Token: 0x0603D8CA RID: 252106 RVA: 0x00EDACA5 File Offset: 0x00ED8EA5
		public void Select()
		{
			if (!this.SelectState)
			{
				this.SelectState = true;
				this.RefreshSelectToggleState();
				this.OnSelect();
			}
		}

		// Token: 0x0603D8CB RID: 252107 RVA: 0x00EDACC2 File Offset: 0x00ED8EC2
		public void OnControllerDragStart()
		{
			this.DragState = true;
		}

		// Token: 0x0603D8CC RID: 252108 RVA: 0x00EDACCB File Offset: 0x00ED8ECB
		public void OnControllerDragEnd()
		{
			this.DragState = false;
		}

		// Token: 0x0603D8CD RID: 252109 RVA: 0x00EDACD4 File Offset: 0x00ED8ED4
		public void ForceUnSelectItem()
		{
			this.SelectState = false;
			this.RefreshSelectToggleState();
			this.OnUnSelect();
		}

		// Token: 0x0603D8CE RID: 252110 RVA: 0x00EDACE9 File Offset: 0x00ED8EE9
		[NullableContext(2)]
		protected virtual UUIExtendToggle GetSelectToggle()
		{
			return null;
		}

		// Token: 0x0603D8CF RID: 252111 RVA: 0x00EDACEC File Offset: 0x00ED8EEC
		protected virtual void OnSelectToggleClick()
		{
		}

		// Token: 0x0603D8D0 RID: 252112 RVA: 0x00EDACEE File Offset: 0x00ED8EEE
		private void TryInitSelectToggle()
		{
			if (this.SelectToggleInited)
			{
				return;
			}
			this.SelectToggleInited = true;
			this.SelectToggle = this.GetSelectToggle();
			UUIExtendToggle selectToggle = this.SelectToggle;
			if (selectToggle == null)
			{
				return;
			}
			selectToggle.OnStateChange.Add(new Action<EToggleState>(this.OnSelectToggleStateChange));
		}

		// Token: 0x0603D8D1 RID: 252113 RVA: 0x00EDAD2D File Offset: 0x00ED8F2D
		private void OnSelectToggleStateChange(EToggleState state)
		{
			this.RefreshSelectToggleState();
			this.OnSelectToggleClick();
		}

		// Token: 0x0603D8D2 RID: 252114 RVA: 0x00EDAD3B File Offset: 0x00ED8F3B
		private void RefreshSelectToggleState()
		{
			UUIExtendToggle selectToggle = this.SelectToggle;
			if (selectToggle == null)
			{
				return;
			}
			selectToggle.SetToggleStateForce(this.SelectState ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603D8D3 RID: 252115 RVA: 0x00EDAD5C File Offset: 0x00ED8F5C
		protected override void OnBeforeDestroyImplement()
		{
			base.OnBeforeDestroyImplement();
			UUIExtendToggle selectToggle = this.SelectToggle;
			if (selectToggle != null)
			{
				selectToggle.OnStateChange.Remove(new Action<EToggleState>(this.OnSelectToggleStateChange));
			}
			this.SelectToggle = null;
		}

		// Token: 0x0603D8D4 RID: 252116 RVA: 0x00EDAD90 File Offset: 0x00ED8F90
		public float GetCurrentPosition()
		{
			EAttachDirection? currentMoveDirection = this.CurrentMoveDirection;
			EAttachDirection eattachDirection = EAttachDirection.Horizontal;
			if (currentMoveDirection.GetValueOrDefault() == eattachDirection & currentMoveDirection != null)
			{
				return this.RootItem.GetAnchorOffsetX();
			}
			return this.RootItem.GetAnchorOffsetY();
		}

		// Token: 0x0603D8D5 RID: 252117 RVA: 0x00EDADD4 File Offset: 0x00ED8FD4
		public void RefreshItem()
		{
			T data = default(T);
			bool flag = false;
			if (this.AllData != null && this.CurrentShowItemIndex >= 0 && this.CurrentShowItemIndex < this.AllData.Length)
			{
				data = this.AllData[this.CurrentShowItemIndex];
				flag = true;
			}
			if (!this.IfShowOverSizeItem && !flag)
			{
				if (this.IfNeedShowFakeItem)
				{
					this.OnRefreshItem(default(T));
				}
				return;
			}
			this.OnRefreshItem(data);
		}

		// Token: 0x0603D8D6 RID: 252118
		[NullableContext(1)]
		protected abstract void OnRefreshItem(T data);

		// Token: 0x0603D8D7 RID: 252119
		public abstract void OnSelect();

		// Token: 0x0603D8D8 RID: 252120
		protected abstract void OnUnSelect();

		// Token: 0x0603D8D9 RID: 252121
		protected abstract void OnMoveItem();

		// Token: 0x0603D8DA RID: 252122 RVA: 0x00EDAE4C File Offset: 0x00ED904C
		private bool CheckIfInSizeOneBorder(float prePosition)
		{
			float itemSize = this.SourceView.GetItemSize();
			float gap = this.SourceView.GetGap();
			int showItemNum = this.SourceView.GetShowItemNum();
			float num = (itemSize + gap) * (float)Math.Ceiling((double)(showItemNum + 1) / 2.0) + this.SourceView.GetTrueBoundary();
			return prePosition <= num;
		}

		// Token: 0x0603D8DB RID: 252123 RVA: 0x00EDAEA8 File Offset: 0x00ED90A8
		private bool CheckIfInSizeTwoBorder(float prePosition)
		{
			float itemSize = this.SourceView.GetItemSize();
			float gap = this.SourceView.GetGap();
			int showItemNum = this.SourceView.GetShowItemNum();
			float num = -(itemSize + gap) * (float)Math.Ceiling((double)showItemNum / 2.0) - this.SourceView.GetTrueBoundary();
			return prePosition >= num;
		}

		// Token: 0x040201F0 RID: 131568
		protected int CurrentShowItemIndex;

		// Token: 0x040201F1 RID: 131569
		private int CreateIndex;

		// Token: 0x040201F2 RID: 131570
		private int DataLength;

		// Token: 0x040201F3 RID: 131571
		protected bool SelectState;

		// Token: 0x040201F4 RID: 131572
		private readonly bool IfShowOverSizeItem;

		// Token: 0x040201F5 RID: 131573
		private bool IfNeedShowFakeItem;

		// Token: 0x040201F6 RID: 131574
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected IAutoAttachBaseView<T> SourceView;

		// Token: 0x040201F7 RID: 131575
		protected EAttachDirection? CurrentMoveDirection;

		// Token: 0x040201F8 RID: 131576
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected T[] AllData;

		// Token: 0x040201F9 RID: 131577
		protected bool DragState;

		// Token: 0x040201FA RID: 131578
		[Nullable(2)]
		private UUIExtendToggle SelectToggle;

		// Token: 0x040201FB RID: 131579
		private bool SelectToggleInited;
	}
}
