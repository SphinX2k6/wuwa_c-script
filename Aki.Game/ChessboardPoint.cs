using System;
using System.Runtime.CompilerServices;

// Token: 0x020011CB RID: 4555
[NullableContext(1)]
[Nullable(0)]
public abstract class ChessboardPoint
{
	// Token: 0x06007955 RID: 31061 RVA: 0x00199AC4 File Offset: 0x00197CC4
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

	// Token: 0x06007956 RID: 31062 RVA: 0x00199B14 File Offset: 0x00197D14
	public int GetId()
	{
		return this.Id;
	}

	// Token: 0x06007957 RID: 31063 RVA: 0x00199B1C File Offset: 0x00197D1C
	public int GetSortIndex()
	{
		return this.SortIndex;
	}

	// Token: 0x06007958 RID: 31064 RVA: 0x00199B24 File Offset: 0x00197D24
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

	// Token: 0x06007959 RID: 31065 RVA: 0x00199B38 File Offset: 0x00197D38
	public Vector GetPointLocation()
	{
		return this.Location;
	}

	// Token: 0x0600795A RID: 31066 RVA: 0x00199B40 File Offset: 0x00197D40
	public Rotator GetPointRotator(bool rotationIsForward = true)
	{
		if (rotationIsForward || this.BackwardRotator == null)
		{
			return this.Rotator;
		}
		return this.BackwardRotator;
	}

	// Token: 0x0600795B RID: 31067
	public abstract void ItemEnter(ChessItem chessItem);

	// Token: 0x0600795C RID: 31068
	public abstract void ItemLeave(ChessItem chessItem);

	// Token: 0x0600795D RID: 31069
	public abstract void ChangeItemToMaxPriority(ChessItem chessItem);

	// Token: 0x0600795E RID: 31070
	public abstract int ComparePriority(ChessItem a, ChessItem b);

	// Token: 0x040037D5 RID: 14293
	private int Id;

	// Token: 0x040037D6 RID: 14294
	private int SortIndex;

	// Token: 0x040037D7 RID: 14295
	private readonly Vector Location = Vector.Create();

	// Token: 0x040037D8 RID: 14296
	private readonly Rotator Rotator = Rotator.Create();

	// Token: 0x040037D9 RID: 14297
	[Nullable(2)]
	private Rotator BackwardRotator;
}
