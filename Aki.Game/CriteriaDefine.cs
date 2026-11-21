using System;
using System.Runtime.CompilerServices;

// Token: 0x02002A2A RID: 10794
[NullableContext(1)]
[Nullable(0)]
public static class CriteriaDefine
{
	// Token: 0x0601B342 RID: 111426 RVA: 0x0085A5D4 File Offset: 0x008587D4
	public static bool AlwaysTrueCriteria<[Nullable(2)] T>(T target)
	{
		return true;
	}

	// Token: 0x0601B343 RID: 111427 RVA: 0x0085A5D7 File Offset: 0x008587D7
	public static bool AlwaysFalseCriteria<[Nullable(2)] T>(T target)
	{
		return false;
	}
}
