using System;
using System.Runtime.CompilerServices;

// Token: 0x0200067F RID: 1663
[NullableContext(1)]
[Nullable(0)]
public abstract class ChessboardPoint
{
	// Token: 0x06004CEC RID: 19692 RVA: 0x001A2774 File Offset: 0x001A0974
	public void Init(int id, Vector location, Rotator rotator, [Nullable(2)] Rotator backwardRotator, int sortIndex)
	{
		this.Id = id;
		this.SortIndex = sortIndex;
		this.Location.DeepCopy(location);
		this.Rotator.DeepCopy(rotator);
		if (backwardRotator != null)
		{
			this.BackwardRotator = Rotator.Create();
			this.BackwardRotator.DeepCopy(backwardRotator);
		}
	}

	// Token: 0x06004CED RID: 19693 RVA: 0x001A27C4 File Offset: 0x001A09C4
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x06004CEE RID: 19694 RVA: 0x001A27CC File Offset: 0x001A09CC
	public int GetSortIndex()
	{
		return this.SortIndex;
	}

	// Token: 0x06004CEF RID: 19695 RVA: 0x001A27D4 File Offset: 0x001A09D4
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public virtual ValueTuple<Vector, Rotator> GetMoveLocationAndRotator(bool rotationIsForward = true)
	{
		return new ValueTuple<Vector, Rotator>(this.Location, this.GetPointRotator(rotationIsForward));
	}

	// Token: 0x06004CF0 RID: 19696 RVA: 0x001A27E8 File Offset: 0x001A09E8
	public Vector GetPointLocation()
	{
		return this.Location;
	}

	// Token: 0x06004CF1 RID: 19697 RVA: 0x001A27F0 File Offset: 0x001A09F0
	public Rotator GetPointRotator(bool rotationIsForward = true)
	{
		if (rotationIsForward || this.BackwardRotator == null)
		{
			return this.Rotator;
		}
		return this.BackwardRotator;
	}

	// Token: 0x06004CF2 RID: 19698
	public abstract void ItemEnter(ChessItem chessItem);

	// Token: 0x06004CF3 RID: 19699
	public abstract void ItemLeave(ChessItem chessItem);

	// Token: 0x06004CF4 RID: 19700
	public abstract void ChangeItemToMaxPriority(ChessItem chessItem);

	// Token: 0x06004CF5 RID: 19701
	public abstract int ComparePriority(ChessItem a, ChessItem b);

	// Token: 0x0400386E RID: 14446
	private int Id;

	// Token: 0x0400386F RID: 14447
	private int SortIndex;

	// Token: 0x04003870 RID: 14448
	private readonly Vector Location = Vector.Create();

	// Token: 0x04003871 RID: 14449
	private readonly Rotator Rotator = Rotator.Create();

	// Token: 0x04003872 RID: 14450
	[Nullable(2)]
	private Rotator BackwardRotator;
}
