using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

// Token: 0x02000BAC RID: 2988
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class NoCircleAttachView<[Nullable(2)] T, [Nullable(0)] TAttachItem> : AutoAttachBaseView<T, TAttachItem> where TAttachItem : AutoAttachItem<T>
{
	// Token: 0x06007C4E RID: 31822 RVA: 0x00268101 File Offset: 0x00266301
	public NoCircleAttachView(AActor controllerActor, bool isNeedScrollCallback = false) : base(controllerActor, isNeedScrollCallback)
	{
	}

	// Token: 0x06007C4F RID: 31823 RVA: 0x00268116 File Offset: 0x00266316
	public void SetIfNeedFakeItem(bool state)
	{
		this.NeedFakeShowItem = state;
	}

	// Token: 0x06007C50 RID: 31824 RVA: 0x0026811F File Offset: 0x0026631F
	public void SetControllerItem(UUIItem controllerItem)
	{
		this.ControllerItem = controllerItem;
		this.ControllerWidth = controllerItem.GetWidth();
		this.ControllerHeight = controllerItem.GetHeight();
	}

	// Token: 0x06007C51 RID: 31825 RVA: 0x00268140 File Offset: 0x00266340
	public override TAttachItem FindAutoAttachItem()
	{
		return this.FindNoCircleAttachItem();
	}

	// Token: 0x06007C52 RID: 31826 RVA: 0x00268148 File Offset: 0x00266348
	private TAttachItem FindNoCircleAttachItem()
	{
		TAttachItem tattachItem = default(TAttachItem);
		float num = 10000000f;
		int count = this.Items.Count;
		for (int i = 0; i < count; i++)
		{
			float num2 = Math.Abs(this.Items[i].GetCurrentPosition());
			bool flag = this.Items[i].GetCurrentShowItemIndex() >= 0 && this.Items[i].GetCurrentShowItemIndex() < this.DataLength;
			if (num2 < num && flag)
			{
				tattachItem = this.Items[i];
				num = num2;
			}
		}
		if (tattachItem == null)
		{
			tattachItem = this.Items[0];
		}
		return tattachItem;
	}

	// Token: 0x06007C53 RID: 31827 RVA: 0x00268204 File Offset: 0x00266404
	public override float GetTrueBoundary()
	{
		if (this.ReCalculateBoundary == null)
		{
			float num = 0f;
			for (float num2 = 0f; num2 < 1f; num2 += 0.01f)
			{
				float curveValue = base.GetCurveValue(this.BoundaryCurve, num2);
				num += 0.01f * curveValue * this.MoveBoundary;
			}
			this.ReCalculateBoundary = new float?(num);
		}
		return this.ReCalculateBoundary.Value;
	}

	// Token: 0x06007C54 RID: 31828 RVA: 0x00268274 File Offset: 0x00266474
	protected override float RecalculateMoveOffset(float offset)
	{
		float num = this.CalculateOffset(offset);
		EAttachDirection? attachDirection = this.AttachDirection;
		EAttachDirection eattachDirection = EAttachDirection.Horizontal;
		if (attachDirection.GetValueOrDefault() == eattachDirection & attachDirection != null)
		{
			if (!this.CheckInHorizontalBounds(num))
			{
				return 0f;
			}
		}
		else if (!this.CheckInVerticalBounds(num))
		{
			return 0f;
		}
		return num;
	}

	// Token: 0x06007C55 RID: 31829 RVA: 0x002682C8 File Offset: 0x002664C8
	private float GetNearestMiddleItemToBoundaryOffset(float offset)
	{
		TAttachItem tattachItem = base.FindNearestMiddleItem();
		float currentPosition = tattachItem.GetCurrentPosition();
		float result;
		if (offset > 0f)
		{
			EAttachDirection? currentMoveDirection = base.GetCurrentMoveDirection();
			EAttachDirection eattachDirection = EAttachDirection.Horizontal;
			if (currentMoveDirection.GetValueOrDefault() == eattachDirection & currentMoveDirection != null)
			{
				result = (float)tattachItem.GetCurrentShowItemIndex() * (base.GetItemSize() + this.Gap) + currentPosition;
			}
			else
			{
				int num = this.DataLength - 1 - tattachItem.GetCurrentShowItemIndex();
				result = -1f * ((float)num * (base.GetItemSize() + this.Gap)) + currentPosition;
			}
		}
		else
		{
			EAttachDirection? currentMoveDirection = base.GetCurrentMoveDirection();
			EAttachDirection eattachDirection = EAttachDirection.Horizontal;
			if (currentMoveDirection.GetValueOrDefault() == eattachDirection & currentMoveDirection != null)
			{
				int num2 = this.DataLength - 1 - tattachItem.GetCurrentShowItemIndex();
				result = -1f * ((float)num2 * (base.GetItemSize() + this.Gap)) + currentPosition;
			}
			else
			{
				result = (float)tattachItem.GetCurrentShowItemIndex() * (base.GetItemSize() + this.Gap) + currentPosition;
			}
		}
		return result;
	}

	// Token: 0x06007C56 RID: 31830 RVA: 0x002683D8 File Offset: 0x002665D8
	private float CalculateOffset(float offset)
	{
		int showIndex = (offset > 0f) ? 0 : (this.DataLength - 1);
		EAttachDirection? attachDirection = this.AttachDirection;
		EAttachDirection eattachDirection = EAttachDirection.Horizontal;
		if (!(attachDirection.GetValueOrDefault() == eattachDirection & attachDirection != null))
		{
			showIndex = ((offset > 0f) ? (this.DataLength - 1) : 0);
		}
		TAttachItem showIndexItem = base.GetShowIndexItem(showIndex);
		if (showIndexItem != null)
		{
			float num = showIndexItem.GetCurrentPosition();
			if (-0.01f < num && num < 0.01f)
			{
				num = 0f;
			}
			float num2 = num + offset;
			attachDirection = this.AttachDirection;
			eattachDirection = EAttachDirection.Horizontal;
			if (!(attachDirection.GetValueOrDefault() == eattachDirection & attachDirection != null))
			{
				num2 = num - offset;
			}
			if (offset > 0f)
			{
				if (num2 < 0f)
				{
					return offset;
				}
			}
			else if (num2 > 0f)
			{
				return offset;
			}
			return this.CalculateDecreaseOffset(offset, num);
		}
		float nearestMiddleItemToBoundaryOffset = this.GetNearestMiddleItemToBoundaryOffset(offset);
		if (Math.Abs(nearestMiddleItemToBoundaryOffset) < Math.Abs(offset))
		{
			return nearestMiddleItemToBoundaryOffset;
		}
		return offset;
	}

	// Token: 0x06007C57 RID: 31831 RVA: 0x002684C8 File Offset: 0x002666C8
	private float CalculateDecreaseOffset(float offset, float currentZeroItemPosition)
	{
		float num = 0f;
		if (offset > 0f)
		{
			if (currentZeroItemPosition < 0f)
			{
				num = 0f - currentZeroItemPosition;
			}
		}
		else if (currentZeroItemPosition > 0f)
		{
			num = 0f - currentZeroItemPosition;
		}
		float num2 = 0f + num;
		float num3 = offset - num2;
		float num4 = this.CalculateDecreaseFactor(offset, currentZeroItemPosition);
		float num5 = num2 + num3 * num4;
		float num6 = currentZeroItemPosition + num5;
		if (offset > 0f)
		{
			if (num6 >= this.GetMoveDistance())
			{
				num2 = ((num > 0f) ? (num + this.GetMoveDistance()) : (this.GetMoveDistance() - currentZeroItemPosition));
			}
			else
			{
				num2 = num5;
			}
		}
		else if (num6 <= -1f * this.GetMoveDistance())
		{
			num2 = ((num < 0f) ? (num + -1f * this.GetMoveDistance()) : (-1f * (this.GetMoveDistance() + currentZeroItemPosition)));
		}
		else
		{
			num2 = num5;
		}
		return num2;
	}

	// Token: 0x06007C58 RID: 31832 RVA: 0x002685A0 File Offset: 0x002667A0
	private float GetMoveDistance()
	{
		if (this.MoveDistance == null)
		{
			int num = 1;
			float num2 = 0f;
			int num3 = 0;
			while ((float)num3 < this.MoveBoundary)
			{
				float num4 = this.CalculateDecreaseFactor((float)num, (float)num3);
				num2 += (float)num * num4;
				num3 += num;
			}
			this.MoveDistance = new float?(num2);
		}
		return this.MoveDistance.Value;
	}

	// Token: 0x06007C59 RID: 31833 RVA: 0x00268600 File Offset: 0x00266800
	private float CalculateDecreaseFactor(float offset, float currentZeroItemPosition)
	{
		if (this.GetTrueBoundary() <= 0f)
		{
			return 0f;
		}
		float num = Math.Abs(currentZeroItemPosition) / this.GetTrueBoundary();
		num = ((num > 1f) ? 1f : num);
		return base.GetCurveValue(this.BoundaryCurve, num);
	}

	// Token: 0x06007C5A RID: 31834 RVA: 0x0026864C File Offset: 0x0026684C
	private bool CheckInHorizontalBounds(float offset)
	{
		TAttachItem tattachItem = default(TAttachItem);
		int count = this.Items.Count;
		for (int i = 0; i < count - 1; i++)
		{
			if (this.Items[i].GetCurrentShowItemIndex() == 0)
			{
				tattachItem = this.Items[i];
				break;
			}
		}
		if (tattachItem != null && offset > 0f)
		{
			float value = tattachItem.GetCurrentPosition() + offset;
			float value2 = Math.Abs(tattachItem.GetCurrentPosition()) + this.GetTrueBoundary();
			if (Math.Abs(value) > Math.Abs(value2))
			{
				return false;
			}
		}
		else if (offset < 0f)
		{
			for (int j = 0; j < count; j++)
			{
				if (this.Items[j].GetCurrentShowItemIndex() == this.DataLength - 1)
				{
					float num = this.Items[j].GetCurrentPosition() + offset;
					float num2 = 0f - this.Items[j].GetCurrentPosition() - this.GetTrueBoundary();
					if (num < num2)
					{
						return false;
					}
				}
			}
		}
		return true;
	}

	// Token: 0x06007C5B RID: 31835 RVA: 0x00268778 File Offset: 0x00266978
	private bool CheckInVerticalBounds(float offset)
	{
		TAttachItem tattachItem = default(TAttachItem);
		int count = this.Items.Count;
		for (int i = 0; i < count - 1; i++)
		{
			if (this.Items[i].GetCurrentShowItemIndex() == 0)
			{
				tattachItem = this.Items[i];
				break;
			}
		}
		if (offset > 0f)
		{
			for (int j = 0; j < count; j++)
			{
				if (this.Items[j].GetCurrentShowItemIndex() == this.DataLength - 1)
				{
					float num = this.Items[j].GetCurrentPosition() + offset;
					float num2 = 0f - this.Items[j].GetCurrentPosition() + this.GetTrueBoundary();
					if (num > num2)
					{
						return false;
					}
				}
			}
		}
		else if (tattachItem != null && offset < 0f)
		{
			float value = tattachItem.GetCurrentPosition() + offset;
			float value2 = tattachItem.GetCurrentPosition() + this.GetTrueBoundary();
			if (Math.Abs(value) > Math.Abs(value2))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06007C5C RID: 31836 RVA: 0x0026889C File Offset: 0x00266A9C
	[NullableContext(2)]
	protected override TAttachItem FindNextDirectionItem(int direction)
	{
		int currentShowItemIndex = base.FindNearestMiddleItem().GetCurrentShowItemIndex();
		int showIndex;
		if (direction > 0)
		{
			if (currentShowItemIndex + direction < this.DataLength)
			{
				showIndex = currentShowItemIndex + direction;
			}
			else
			{
				showIndex = this.DataLength - 1;
			}
		}
		else if (currentShowItemIndex + direction > 0)
		{
			showIndex = currentShowItemIndex + direction;
		}
		else
		{
			showIndex = 0;
		}
		return base.GetShowIndexItem(showIndex);
	}

	// Token: 0x06007C5D RID: 31837 RVA: 0x002688F4 File Offset: 0x00266AF4
	protected override void ReloadItems(int showItemNum, T[] data, int attachTo = 0)
	{
		int num = (showItemNum > this.ShowItemNum || this.NeedFakeShowItem) ? (this.ShowItemNum + 1) : showItemNum;
		for (int i = showItemNum; i < this.AllItemList.Count; i++)
		{
			this.AllItemList[i].SetUiActive(false);
		}
		this.Items = new List<TAttachItem>();
		for (int j = 0; j < num; j++)
		{
			if (j >= this.AllItemList.Count)
			{
				AActor arg = LguiUtil.Instance.DuplicateActor(this.SourceActor as AUIBaseActor, this.ControllerItem);
				TAttachItem tattachItem = this.CreateItemFunction(arg, j, this.ShowItemNum);
				tattachItem.SetSourceView(this);
				this.Items.Add(tattachItem);
				this.AllItemList.Add(tattachItem);
			}
			else
			{
				this.Items.Add(this.AllItemList[j]);
			}
			this.Items[j].SetIfNeedShowFakeItem(this.NeedFakeShowItem);
			this.Items[j].SetItemIndex(j);
			this.Items[j].SetUiActive(true);
			this.Items[j].SetData(data);
			this.Items[j].InitItem();
		}
		base.RefreshItems();
		base.ForceUnSelectItems();
		base.AttachToIndex(attachTo, true);
	}

	// Token: 0x06007C5E RID: 31838 RVA: 0x00268A74 File Offset: 0x00266C74
	public override bool GetIfCircle()
	{
		return false;
	}

	// Token: 0x06007C5F RID: 31839 RVA: 0x00268A77 File Offset: 0x00266C77
	public void SetShowItemNum(int showItemNum)
	{
		this.ShowItemNum = showItemNum;
	}

	// Token: 0x04004D79 RID: 19833
	private const float FLOATDURABLENUM = 0.01f;

	// Token: 0x04004D7A RID: 19834
	private float? ReCalculateBoundary;

	// Token: 0x04004D7B RID: 19835
	private float? MoveDistance;

	// Token: 0x04004D7C RID: 19836
	private bool NeedFakeShowItem;

	// Token: 0x04004D7D RID: 19837
	private readonly List<TAttachItem> AllItemList = new List<TAttachItem>();
}
