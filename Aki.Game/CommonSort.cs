using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D31 RID: 3377
public abstract class CommonSort
{
	// Token: 0x06008BB4 RID: 35764 RVA: 0x002A4039 File Offset: 0x002A2239
	public void InitSortMap()
	{
		if (this.IsInit)
		{
			return;
		}
		this.IsInit = true;
		this.OnInitSortMap();
	}

	// Token: 0x06008BB5 RID: 35765
	protected abstract void OnInitSortMap();

	// Token: 0x06008BB6 RID: 35766
	[NullableContext(2)]
	public abstract TSortResult GetSortFunctionByRuleId(int ruleId);

	// Token: 0x04005395 RID: 21397
	protected bool IsInit;
}
