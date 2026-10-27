using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;

// Token: 0x02002DAA RID: 11690
[NullableContext(1)]
[Nullable(0)]
public class BulletDataChild
{
	// Token: 0x17002156 RID: 8534
	// (get) Token: 0x06018931 RID: 100657 RVA: 0x00647A4D File Offset: 0x00645C4D
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

	// Token: 0x17002157 RID: 8535
	// (get) Token: 0x06018932 RID: 100658 RVA: 0x00647A7D File Offset: 0x00645C7D
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

	// Token: 0x17002158 RID: 8536
	// (get) Token: 0x06018933 RID: 100659 RVA: 0x00647AAD File Offset: 0x00645CAD
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

	// Token: 0x17002159 RID: 8537
	// (get) Token: 0x06018934 RID: 100660 RVA: 0x00647ADD File Offset: 0x00645CDD
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

	// Token: 0x1700215A RID: 8538
	// (get) Token: 0x06018935 RID: 100661 RVA: 0x00647B0D File Offset: 0x00645D0D
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

	// Token: 0x1700215B RID: 8539
	// (get) Token: 0x06018936 RID: 100662 RVA: 0x00647B42 File Offset: 0x00645D42
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

	// Token: 0x06018937 RID: 100663 RVA: 0x00647B72 File Offset: 0x00645D72
	public BulletDataChild(SReBulletDataChildren data)
	{
		this.Data = data;
	}

	// Token: 0x0400B64B RID: 46667
	private readonly SReBulletDataChildren Data;

	// Token: 0x0400B64C RID: 46668
	private long? RowNameInternal;

	// Token: 0x0400B64D RID: 46669
	private float? DelayInternal;

	// Token: 0x0400B64E RID: 46670
	private int? NumInternal;

	// Token: 0x0400B64F RID: 46671
	private float? IntervalInternal;

	// Token: 0x0400B650 RID: 46672
	private global::EBulletChildrenType? ConditionInternal;

	// Token: 0x0400B651 RID: 46673
	private bool? BreakOnFailInternal;
}
