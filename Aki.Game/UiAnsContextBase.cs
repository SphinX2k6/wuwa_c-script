using System;
using System.Runtime.CompilerServices;

// Token: 0x020021D2 RID: 8658
public abstract class UiAnsContextBase
{
	// Token: 0x0601550A RID: 87306
	[NullableContext(1)]
	public abstract bool IsEqual(UiAnsContextBase inAnsContext);

	// Token: 0x0601550B RID: 87307 RVA: 0x00632EDA File Offset: 0x006310DA
	public virtual bool IsValid()
	{
		return true;
	}

	// Token: 0x0400B4AA RID: 46250
	public int ExistCount;

	// Token: 0x0400B4AB RID: 46251
	public int CacheCount;
}
