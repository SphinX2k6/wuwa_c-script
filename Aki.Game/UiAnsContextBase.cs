using System;
using System.Runtime.CompilerServices;

// Token: 0x02002C79 RID: 11385
public abstract class UiAnsContextBase
{
	// Token: 0x06017C97 RID: 97431
	[NullableContext(1)]
	public abstract bool IsEqual(UiAnsContextBase inAnsContext);

	// Token: 0x06017C98 RID: 97432 RVA: 0x0060D3F6 File Offset: 0x0060B5F6
	public virtual bool IsValid()
	{
		return true;
	}

	// Token: 0x0400B13F RID: 45375
	public int ExistCount;

	// Token: 0x0400B140 RID: 45376
	public int CacheCount;
}
