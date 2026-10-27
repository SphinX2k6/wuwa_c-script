using System;
using System.Runtime.CompilerServices;

// Token: 0x02001878 RID: 6264
public abstract class CommonSort
{
	// Token: 0x0600B7CB RID: 47051 RVA: 0x00299921 File Offset: 0x00297B21
	public void InitSortMap()
	{
		if (this.IsInit)
		{
			return;
		}
		this.IsInit = true;
		this.OnInitSortMap();
	}

	// Token: 0x0600B7CC RID: 47052
	protected abstract void OnInitSortMap();

	// Token: 0x0600B7CD RID: 47053
	[NullableContext(2)]
	public abstract TSortResult GetSortFunctionByRuleId(int ruleId);

	// Token: 0x040052EA RID: 21226
	protected bool IsInit;
}
