using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001879 RID: 6265
public abstract class CommonSort<T> : CommonSort where T : Enum
{
	// Token: 0x0600B7CF RID: 47055 RVA: 0x00299941 File Offset: 0x00297B41
	public CommonSort()
	{
		this.SortMap = new Dictionary<T, TSortResult>();
	}

	// Token: 0x0600B7D0 RID: 47056 RVA: 0x00299954 File Offset: 0x00297B54
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

	// Token: 0x040052EB RID: 21227
	[Nullable(1)]
	protected Dictionary<T, TSortResult> SortMap;
}
