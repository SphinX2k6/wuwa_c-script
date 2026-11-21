using System;

// Token: 0x02001FEB RID: 8171
public class SystemFunctionConditionImpl : ISkipSystemFunctionCondition, ISkipCondition<ESkipConditionType>
{
	// Token: 0x17001E65 RID: 7781
	// (get) Token: 0x06014430 RID: 82992 RVA: 0x005E82E5 File Offset: 0x005E64E5
	// (set) Token: 0x06014431 RID: 82993 RVA: 0x005E82ED File Offset: 0x005E64ED
	public ESkipConditionType ConditionType { get; set; }

	// Token: 0x17001E66 RID: 7782
	// (get) Token: 0x06014432 RID: 82994 RVA: 0x005E82F6 File Offset: 0x005E64F6
	// (set) Token: 0x06014433 RID: 82995 RVA: 0x005E82FE File Offset: 0x005E64FE
	public EFunctionType FunctionType { get; set; }
}
