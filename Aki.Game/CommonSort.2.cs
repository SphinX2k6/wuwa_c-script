using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000D32 RID: 3378
public abstract class CommonSort<T> : CommonSort where T : Enum
{
	// Token: 0x06008BB8 RID: 35768 RVA: 0x002A4059 File Offset: 0x002A2259
	public CommonSort()
	{
		this.SortMap = new Dictionary<T, TSortResult>();
	}

	// Token: 0x06008BB9 RID: 35769 RVA: 0x002A406C File Offset: 0x002A226C
	[NullableContext(2)]
	public override TSortResult GetSortFunctionByRuleId(int ruleId)
	{
		TSortResult result;
		if (this.SortMap.TryGetValue((T)((object)Enum.ToObject(typeof(T), ruleId)), out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x04005396 RID: 21398
	[Nullable(1)]
	protected Dictionary<T, TSortResult> SortMap;
}
