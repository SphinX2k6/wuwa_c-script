using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

// Token: 0x020016F4 RID: 5876
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class NoCircleAttachView<[Nullable(2)] T, [Nullable(0)] TAttachItem> : AutoAttachBaseView<T, TAttachItem> where TAttachItem : AutoAttachItem<T>
{
	// Token: 0x0600A86E RID: 43118 RVA: 0x0025DCE5 File Offset: 0x0025BEE5
	public NoCircleAttachView(AActor controllerActor, bool isNeedScrollCallback = false) : base(controllerActor, isNeedScrollCallback)
	{
	}

	// Token: 0x0600A86F RID: 43119 RVA: 0x0025DCFA File Offset: 0x0025BEFA
	public void SetIfNeedFakeItem(bool state)
	{
		this.NeedFakeShowItem = state;
	}

	// Token: 0x0600A870 RID: 43120 RVA: 0x0025DD03 File Offset: 0x0025BF03
	public void SetControllerItem(UUIItem controllerItem)
	{
		this.ControllerItem = controllerItem;
		this.ControllerWidth = controllerItem.GetWidth();
		this.ControllerHeight = controllerItem.GetHeight();
	}

	// Token: 0x0600A871 RID: 43121 RVA: 0x0025DD24 File Offset: 0x0025BF24
	public override TAttachItem FindAutoAttachItem()
	{
		return this.FindNoCircleAttachItem();
	}

	// Token: 0x0600A872 RID: 43122 RVA: 0x0025DD2C File Offset: 0x0025BF2C
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

	// Token: 0x0600A873 RID: 43123 RVA: 0x0025DDE8 File Offset: 0x0025BFE8
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

	// Token: 0x0600A874 RID: 43124 RVA: 0x0025DE58 File Offset: 0x0025C058
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

	// Token: 0x0600A875 RID: 43125 RVA: 0x0025DEAC File Offset: 0x0025C0AC
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

	// Token: 0x0600A876 RID: 43126 RVA: 0x0025DFBC File Offset: 0x0025C1BC
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

	// Token: 0x0600A877 RID: 43127 RVA: 0x0025E0AC File Offset: 0x0025C2AC
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

	// Token: 0x0600A878 RID: 43128 RVA: 0x0025E184 File Offset: 0x0025C384
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

	// Token: 0x0600A879 RID: 43129 RVA: 0x0025E1E4 File Offset: 0x0025C3E4
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

	// Token: 0x0600A87A RID: 43130 RVA: 0x0025E230 File Offset: 0x0025C430
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

	// Token: 0x0600A87B RID: 43131 RVA: 0x0025E35C File Offset: 0x0025C55C
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

	// Token: 0x0600A87C RID: 43132 RVA: 0x0025E480 File Offset: 0x0025C680
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

	// Token: 0x0600A87D RID: 43133 RVA: 0x0025E4D8 File Offset: 0x0025C6D8
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

	// Token: 0x0600A87E RID: 43134 RVA: 0x0025E658 File Offset: 0x0025C858
	public override bool GetIfCircle()
	{
		return false;
	}

	// Token: 0x0600A87F RID: 43135 RVA: 0x0025E65B File Offset: 0x0025C85B
	public void SetShowItemNum(int showItemNum)
	{
		this.ShowItemNum = showItemNum;
	}

	// Token: 0x04004CD2 RID: 19666
	private const float FLOATDURABLENUM = 0.01f;

	// Token: 0x04004CD3 RID: 19667
	private float? ReCalculateBoundary;

	// Token: 0x04004CD4 RID: 19668
	private float? MoveDistance;

	// Token: 0x04004CD5 RID: 19669
	private bool NeedFakeShowItem;

	// Token: 0x04004CD6 RID: 19670
	private readonly List<TAttachItem> AllItemList = new List<TAttachItem>();
}
