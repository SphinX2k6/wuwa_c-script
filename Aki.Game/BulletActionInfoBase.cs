using System;

// Token: 0x020022E3 RID: 8931
public class BulletActionInfoBase
{
	// Token: 0x06016091 RID: 90257 RVA: 0x006625CA File Offset: 0x006607CA
	public BulletActionInfoBase(EBulletAction type)
	{
		this.Type = type;
	}

	// Token: 0x06016092 RID: 90258 RVA: 0x006625DC File Offset: 0x006607DC
	public virtual void Clear()
	{
		Log.Instance.Error(ELogModule.Bullet, ELogAuthor.CFT, "BulletActionInfo need override clear()", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x0400B919 RID: 47385
	public readonly EBulletAction Type;

	// Token: 0x0400B91A RID: 47386
	public bool IsInPool;

	// Token: 0x0400B91B RID: 47387
	public int Index;
}
