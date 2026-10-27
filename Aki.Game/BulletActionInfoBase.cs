using System;

// Token: 0x02002D89 RID: 11657
public class BulletActionInfoBase
{
	// Token: 0x060187EF RID: 100335 RVA: 0x0063C892 File Offset: 0x0063AA92
	public BulletActionInfoBase(EBulletAction type)
	{
		this.Type = type;
	}

	// Token: 0x060187F0 RID: 100336 RVA: 0x0063C8A4 File Offset: 0x0063AAA4
	public virtual void Clear()
	{
		Log.Instance.Error(ELogModule.Bullet, ELogAuthor.CFT, "BulletActionInfo need override clear()", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0400B5A4 RID: 46500
	public readonly EBulletAction Type;

	// Token: 0x0400B5A5 RID: 46501
	public bool IsInPool;

	// Token: 0x0400B5A6 RID: 46502
	public int Index;
}
