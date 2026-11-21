using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.AutoAttach
{
	// Token: 0x02004E66 RID: 20070
	public abstract class AutoAttachItem<[Nullable(2)] T> : UiPanelBase
	{
		// Token: 0x06032849 RID: 206921 RVA: 0x00E2BD84 File Offset: 0x00E29F84
		[NullableContext(2)]
		public AutoAttachItem(AActor uiItem = null)
		{
			if (uiItem != null)
			{
				base.CreateThenShowByActor(uiItem, null);
			}
		}

		// Token: 0x0603284A RID: 206922 RVA: 0x00E2BD97 File Offset: 0x00E29F97
		[NullableContext(1)]
		public void SetData(T[] dataArray)
		{
			this.AllData = dataArray;
		}

		// Token: 0x0603284B RID: 206923 RVA: 0x00E2BDA0 File Offset: 0x00E29FA0
		public void SetIfNeedShowFakeItem(bool state)
		{
			this.IfNeedShowFakeItem = state;
		}

		// Token: 0x0603284C RID: 206924 RVA: 0x00E2BDA9 File Offset: 0x00E29FA9
		[NullableContext(1)]
		public void SetSourceView(IAutoAttachBaseView<T> view)
		{
			this.SourceView = view;
			this.CurrentMoveDirection = this.SourceView.GetCurrentMoveDirection();
		}

		// Token: 0x0603284D RID: 206925 RVA: 0x00E2BDC3 File Offset: 0x00E29FC3
		public void SetItemIndex(int index)
		{
			this.CreateIndex = index;
		}

		// Token: 0x0603284E RID: 206926 RVA: 0x00E2BDCC File Offset: 0x00E29FCC
		public int GetItemIndex()
		{
			return this.CreateIndex;
		}

		// Token: 0x0603284F RID: 206927 RVA: 0x00E2BDD4 File Offset: 0x00E29FD4
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

		// Token: 0x06032850 RID: 206928 RVA: 0x00E2BE34 File Offset: 0x00E2A034
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

		// Token: 0x06032851 RID: 206929 RVA: 0x00E2BEEF File Offset: 0x00E2A0EF
		private void ResetPosition()
		{
			this.RootItem.SetAnchorOffsetX(0f);
			this.RootItem.SetAnchorOffsetY(0f);
		}

		// Token: 0x06032852 RID: 206930 RVA: 0x00E2BF14 File Offset: 0x00E2A114
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

		// Token: 0x06032853 RID: 206931 RVA: 0x00E2BFD8 File Offset: 0x00E2A1D8
		public float GetCurrentMovePercentage()
		{
			float viewSize = this.SourceView.GetViewSize();
			return (this.GetCurrentPosition() + viewSize / 2f) / viewSize;
		}

		// Token: 0x06032854 RID: 206932 RVA: 0x00E2C004 File Offset: 0x00E2A204
		private ValueTuple<float, int> GetMoveOffsetFinalPositionAndShowIndex(float offset)
		{
			float checkPosition = this.GetCurrentPosition() + offset;
			if (this.SourceView.GetIfCircle())
			{
				return this.GetCircleMoveOffsetPositionAndShowIndex(checkPosition);
			}
			return this.GetNoCircleMoveOffsetPositionAndShowIndex(checkPosition);
		}

		// Token: 0x06032855 RID: 206933 RVA: 0x00E2C038 File Offset: 0x00E2A238
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

		// Token: 0x06032856 RID: 206934 RVA: 0x00E2C10C File Offset: 0x00E2A30C
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

		// Token: 0x06032857 RID: 206935 RVA: 0x00E2C20C File Offset: 0x00E2A40C
		public int GetCurrentShowItemIndex()
		{
			return this.CurrentShowItemIndex;
		}

		// Token: 0x06032858 RID: 206936 RVA: 0x00E2C214 File Offset: 0x00E2A414
		protected bool GetCurrentSelectedState()
		{
			return this.SourceView.GetCurrentSelectIndex() == this.GetCurrentShowItemIndex();
		}

		// Token: 0x06032859 RID: 206937 RVA: 0x00E2C229 File Offset: 0x00E2A429
		public bool GetSelectedState()
		{
			return this.SelectState;
		}

		// Token: 0x0603285A RID: 206938 RVA: 0x00E2C231 File Offset: 0x00E2A431
		public void Select()
		{
			if (!this.SelectState)
			{
				this.SelectState = true;
				this.RefreshSelectToggleState();
				this.OnSelect();
			}
		}

		// Token: 0x0603285B RID: 206939 RVA: 0x00E2C24E File Offset: 0x00E2A44E
		public void OnControllerDragStart()
		{
			this.DragState = true;
		}

		// Token: 0x0603285C RID: 206940 RVA: 0x00E2C257 File Offset: 0x00E2A457
		public void OnControllerDragEnd()
		{
			this.DragState = false;
		}

		// Token: 0x0603285D RID: 206941 RVA: 0x00E2C260 File Offset: 0x00E2A460
		public void ForceUnSelectItem()
		{
			this.SelectState = false;
			this.RefreshSelectToggleState();
			this.OnUnSelect();
		}

		// Token: 0x0603285E RID: 206942 RVA: 0x00E2C275 File Offset: 0x00E2A475
		[NullableContext(2)]
		protected virtual UUIExtendToggle GetSelectToggle()
		{
			return null;
		}

		// Token: 0x0603285F RID: 206943 RVA: 0x00E2C278 File Offset: 0x00E2A478
		protected virtual void OnSelectToggleClick()
		{
		}

		// Token: 0x06032860 RID: 206944 RVA: 0x00E2C27A File Offset: 0x00E2A47A
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

		// Token: 0x06032861 RID: 206945 RVA: 0x00E2C2B9 File Offset: 0x00E2A4B9
		private void OnSelectToggleStateChange(EToggleState state)
		{
			this.RefreshSelectToggleState();
			this.OnSelectToggleClick();
		}

		// Token: 0x06032862 RID: 206946 RVA: 0x00E2C2C7 File Offset: 0x00E2A4C7
		private void RefreshSelectToggleState()
		{
			UUIExtendToggle selectToggle = this.SelectToggle;
			if (selectToggle == null)
			{
				return;
			}
			selectToggle.SetToggleStateForce(this.SelectState ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06032863 RID: 206947 RVA: 0x00E2C2E8 File Offset: 0x00E2A4E8
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

		// Token: 0x06032864 RID: 206948 RVA: 0x00E2C31C File Offset: 0x00E2A51C
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

		// Token: 0x06032865 RID: 206949 RVA: 0x00E2C360 File Offset: 0x00E2A560
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

		// Token: 0x06032866 RID: 206950
		[NullableContext(1)]
		protected abstract void OnRefreshItem(T data);

		// Token: 0x06032867 RID: 206951
		public abstract void OnSelect();

		// Token: 0x06032868 RID: 206952
		protected abstract void OnUnSelect();

		// Token: 0x06032869 RID: 206953
		protected abstract void OnMoveItem();

		// Token: 0x0603286A RID: 206954 RVA: 0x00E2C3D8 File Offset: 0x00E2A5D8
		private bool CheckIfInSizeOneBorder(float prePosition)
		{
			float itemSize = this.SourceView.GetItemSize();
			float gap = this.SourceView.GetGap();
			int showItemNum = this.SourceView.GetShowItemNum();
			float num = (itemSize + gap) * (float)Math.Ceiling((double)(showItemNum + 1) / 2.0) + this.SourceView.GetTrueBoundary();
			return prePosition <= num;
		}

		// Token: 0x0603286B RID: 206955 RVA: 0x00E2C434 File Offset: 0x00E2A634
		private bool CheckIfInSizeTwoBorder(float prePosition)
		{
			float itemSize = this.SourceView.GetItemSize();
			float gap = this.SourceView.GetGap();
			int showItemNum = this.SourceView.GetShowItemNum();
			float num = -(itemSize + gap) * (float)Math.Ceiling((double)showItemNum / 2.0) - this.SourceView.GetTrueBoundary();
			return prePosition >= num;
		}

		// Token: 0x0401ACB7 RID: 109751
		protected int CurrentShowItemIndex;

		// Token: 0x0401ACB8 RID: 109752
		private int CreateIndex;

		// Token: 0x0401ACB9 RID: 109753
		private int DataLength;

		// Token: 0x0401ACBA RID: 109754
		protected bool SelectState;

		// Token: 0x0401ACBB RID: 109755
		private readonly bool IfShowOverSizeItem;

		// Token: 0x0401ACBC RID: 109756
		private bool IfNeedShowFakeItem;

		// Token: 0x0401ACBD RID: 109757
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected IAutoAttachBaseView<T> SourceView;

		// Token: 0x0401ACBE RID: 109758
		protected EAttachDirection? CurrentMoveDirection;

		// Token: 0x0401ACBF RID: 109759
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected T[] AllData;

		// Token: 0x0401ACC0 RID: 109760
		protected bool DragState;

		// Token: 0x0401ACC1 RID: 109761
		[Nullable(2)]
		private UUIExtendToggle SelectToggle;

		// Token: 0x0401ACC2 RID: 109762
		private bool SelectToggleInited;
	}
}
