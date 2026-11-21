using System;

// Token: 0x02001FE6 RID: 8166
public interface ISkipSystemFunctionCondition : ISkipCondition<ESkipConditionType>
{
	// Token: 0x17001E60 RID: 7776
	// (get) Token: 0x06014421 RID: 82977
	// (set) Token: 0x06014422 RID: 82978
	EFunctionType FunctionType { get; set; }
}
