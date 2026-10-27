using System;
using System.Runtime.CompilerServices;

// Token: 0x020034B6 RID: 13494
[NullableContext(1)]
[Nullable(0)]
public static class CriteriaDefine
{
	// Token: 0x0601D643 RID: 120387 RVA: 0x008331B4 File Offset: 0x008313B4
	public static bool AlwaysTrueCriteria<[Nullable(2)] T>(T target)
	{
		return true;
	}

	// Token: 0x0601D644 RID: 120388 RVA: 0x008331B7 File Offset: 0x008313B7
	public static bool AlwaysFalseCriteria<[Nullable(2)] T>(T target)
	{
		return false;
	}
}
