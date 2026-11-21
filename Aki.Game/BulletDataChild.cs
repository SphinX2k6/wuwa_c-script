using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;

// Token: 0x02002304 RID: 8964
[NullableContext(1)]
[Nullable(0)]
public class BulletDataChild
{
	// Token: 0x170021B2 RID: 8626
	// (get) Token: 0x060161D9 RID: 90585 RVA: 0x0066D92D File Offset: 0x0066BB2D
	public long RowName
	{
		get
		{
			if (this.RowNameInternal == null)
			{
				this.RowNameInternal = new long?(this.Data.召唤子弹ID);
			}
			return this.RowNameInternal.Value;
		}
	}

	// Token: 0x170021B3 RID: 8627
	// (get) Token: 0x060161DA RID: 90586 RVA: 0x0066D95D File Offset: 0x0066BB5D
	public float Delay
	{
		get
		{
			if (this.DelayInternal == null)
			{
				this.DelayInternal = new float?(this.Data.召唤子弹延迟);
			}
			return this.DelayInternal.Value;
		}
	}

	// Token: 0x170021B4 RID: 8628
	// (get) Token: 0x060161DB RID: 90587 RVA: 0x0066D98D File Offset: 0x0066BB8D
	public int Num
	{
		get
		{
			if (this.NumInternal == null)
			{
				this.NumInternal = new int?(this.Data.召唤子弹数量);
			}
			return this.NumInternal.Value;
		}
	}

	// Token: 0x170021B5 RID: 8629
	// (get) Token: 0x060161DC RID: 90588 RVA: 0x0066D9BD File Offset: 0x0066BBBD
	public float Interval
	{
		get
		{
			if (this.IntervalInternal == null)
			{
				this.IntervalInternal = new float?(this.Data.召唤子弹间隔);
			}
			return this.IntervalInternal.Value;
		}
	}

	// Token: 0x170021B6 RID: 8630
	// (get) Token: 0x060161DD RID: 90589 RVA: 0x0066D9ED File Offset: 0x0066BBED
	public global::EBulletChildrenType Condition
	{
		get
		{
			if (this.ConditionInternal == null)
			{
				this.ConditionInternal = new global::EBulletChildrenType?((global::EBulletChildrenType)this.Data.召唤触发);
			}
			return this.ConditionInternal.Value;
		}
	}

	// Token: 0x170021B7 RID: 8631
	// (get) Token: 0x060161DE RID: 90590 RVA: 0x0066DA22 File Offset: 0x0066BC22
	public bool BreakOnFail
	{
		get
		{
			if (this.BreakOnFailInternal == null)
			{
				this.BreakOnFailInternal = new bool?(this.Data.失败是否停止);
			}
			return this.BreakOnFailInternal.Value;
		}
	}

	// Token: 0x060161DF RID: 90591 RVA: 0x0066DA52 File Offset: 0x0066BC52
	public BulletDataChild(SReBulletDataChildren data)
	{
		this.Data = data;
	}

	// Token: 0x0400B9C5 RID: 47557
	private readonly SReBulletDataChildren Data;

	// Token: 0x0400B9C6 RID: 47558
	private long? RowNameInternal;

	// Token: 0x0400B9C7 RID: 47559
	private float? DelayInternal;

	// Token: 0x0400B9C8 RID: 47560
	private int? NumInternal;

	// Token: 0x0400B9C9 RID: 47561
	private float? IntervalInternal;

	// Token: 0x0400B9CA RID: 47562
	private global::EBulletChildrenType? ConditionInternal;

	// Token: 0x0400B9CB RID: 47563
	private bool? BreakOnFailInternal;
}
